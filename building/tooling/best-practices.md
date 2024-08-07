# Best Practices

## Follow official best practices

The official [Dockerfile best practices](https://docs.docker.com/develop/develop-images/dockerfile_best-practices/) have lots of great content on how to improve your Dockerfiles.

## Performance

You should primarily optimize for performance (especially for test runners).
This will ensure your tooling runs as fast as possible and does not time-out.

### Experiment with different Base images

Try experimenting with different base images (e.g. Alpine instead of Ubuntu), to see if one (significantly) outperforms the other.
If performance is relatively equal, go for the image that is smallest.

### Try Internal Network

Check if using the `internal` network instead of `none` improves performance.
See the [network docs](/docs/building/tooling/docker#network) for more information.

### Prefer build-time commands over run-time commands

Tooling runs as one-off, short-lived Docker container:

1. A Docker container is created
2. The Docker container is run with the correct arguments
3. The Docker container is destroyed

Therefore, code that runs in step 2 runs for _every single tooling run_.
For this reason, reducing the amount of code that runs in step 2 is a great way to improve performance
One way of doing this is to move code from _run-time_ to _build-time_.
Whilst run-time code runs on every single tooling run, build-time code only runs once (when the Docker image is built).

Build-time code runs once as part of a GitHub Actions workflow.
Therefore, its fine if the code that runs at build-time is (relatively) slow.

#### Example: pre-compile libraries

When running tests in the Haskell test runner, it requires some base libraries to be compiled.
As each test run happens in a fresh container, this means that this compilation was done _in every single test run_!
To circumvent this, the [Haskell test runner's Dockerfile](https://github.com/exercism/haskell-test-runner/blob/5264c460054649fc672c3d5932c2f3cb082e2405/Dockerfile) has the following two commands:

```dockerfile
COPY pre-compiled/ .
RUN stack build --resolver lts-20.18 --no-terminal --test --no-run-tests
```

First, the `pre-compiled` directory is copied into the image.
This directory is setup as a sort of fake exercise and depends on the same base libraries that the actual exercise depend on.
Then we run the tests on that directory, which is similar to how tests are run for an actual exercise.
Running the tests will result in the base being compiled, but the difference is that this happens at _build time_.
The resulting Docker image will thus have its base libraries already compiled, which means that no longer has to happen at _run time_, resulting in (much) faster execution times.

#### Example: pre-compile binaries

Some languages allow code to be compiled ahead-of-time or just-in-time.
This is a build time vs. run time tradeoff, and again, we favor build time execution for performance reasons.

The [C# test runner's Dockerfile](https://github.com/exercism/csharp-test-runner/blob/b54122ef76cbf86eff0691daa33c8e50bc83979f/Dockerfile) uses this approach, where the test runner is compiled to a binary ahead-of-time (at build time) instead of just-in-time compiling the code (at run time).
This means that there is less work to do at run-time, which should help increase performance.

## Size

You should try to reduce the image's size, which means that it'll:

- Be faster to deploy
- Reduce costs for us
- Improve startup time of each container

### Try different distributions

Different distribution images will have different sizes.
For example, the `alpine:3.20.2` image is **ten times** smaller than the `ubuntu:24.10` image:

```
REPOSITORY   TAG       SIZE
alpine       3.20.2    8.83MB
ubuntu       24.10     101MB
```

In general, Alpine-based images are amongst the smallest images, so many tooling images are based on Alpine.

### Try slimmed-down images

Some images have special "slim" variants, in which some features will have been removed resulting in smaller image sizes.
For example, the `node:20.16.0-slim` image is **five times** smaller than the `node:20.16.0` image:

```
REPOSITORY   TAG            SIZE
node         20.16.0        1.09GB
node         20.16.0-slim   219MB
```

The reason "slim" variants are smaller is that they'll have less features.
Your image might not need the additional features, and if not, consider using the "slim" variant.

### Removing unneeded bits

An obvious, but great, way to reduce the size of your image is to remove anything you don't need.
These can include things like:

- Source files that are no longer needed after building a binary from them
- Files targeting different architectures from the Docker image
- Documentation

#### Remove package manager files

Most Docker images need to install additional packages, which is usually done via a package manager.
These packages must be installed at _build time_ (as no internet connection is available at _run time_).
Therefore, any package manager caching/bookkeeping files should be removed after installing the additional packages.

##### apk

Distributions that uses the `apk` package manager (such as Alpine) should use the `--no-cache` flag when using `apk add` to install packages:

```dockerfile
RUN apk add --no-cache curl
```

##### apt-get/apt

Distributions that use the `apt-get`/`apk` package manager (such as Ubuntu) should run the `apt-get autoremove -y` and `rm -rf /var/lib/apt/lists/*` commands _after_ installing the packages and in the same `RUN` command:

```dockerfile
RUN apt-get update && \
    apt-get install curl -y && \
    apt-get autoremove -y && \
    rm -rf /var/lib/apt/lists/*
```

### Use multi-stage builds

Docker has a feature called [multi-stage builds](https://docs.docker.com/build/building/multi-stage/).
These allow you to partition your Dockerfile into separate _stages_, with only the last stage ending up in the produced Docker image (the rest is only there to support building the last stage).
You can think of each stage as its own mini Dockerfile; stages can use different base images.

Multi-stage builds are particularly useful when your Dockerfile requires packages to be installed that are _only_ needed at build time.
In this situation, the general structure of your Dockerfile looks like this:

1. Define a new stage (we'll call this the "build" stage).
   This stage will _only_ be used at build time.
2. Install the required additional packages (into the "build" stage).
3. Run the commands that require the additional packages (within the "build" stage).
4. Define a new stage (we'll call this the "runtime" stage).
   This stage will make up the resulting Docker image and executed at run time.
5. Copy the result(s) from the commands run in step 3 (in the "build" stage) into this stage (the "runtime" stage).

With this setup, the additional packages are _only_ installed in the "build" stage and _not_ in the "runtime" stage, which means that they won't end up in the Docker image that is produced.

#### Example: downloading files

The Fortran test runner requires `curl` to download some files.
However, its run time image does _not_ need `curl`, which makes this a perfect use case for a multi-stage build.

First, its [Dockerfile](https://github.com/exercism/fortran-test-runner/blob/783e228d8449143d2040e68b95128bb791833a27/Dockerfile) defines a stage (named "build") in which the `curl` package is installed.
It then uses curl to download files into that stage.

```dockerfile
FROM alpine:3.15 AS build

RUN apk add --no-cache curl

WORKDIR /opt/test-runner
COPY bust_cache .

WORKDIR /opt/test-runner/testlib
RUN curl -R -O https://raw.githubusercontent.com/exercism/fortran/main/testlib/CMakeLists.txt
RUN curl -R -O https://raw.githubusercontent.com/exercism/fortran/main/testlib/TesterMain.f90

WORKDIR /opt/test-runner
RUN curl -R -O https://raw.githubusercontent.com/exercism/fortran/main/config/CMakeLists.txt
```

The second part of the Dockerfile defines a new stage and copies the downloaded files from the "build" stage into its own stage using the `COPY` command:

```dockerfile
FROM alpine:3.15

RUN apk add --no-cache coreutils jq gfortran libc-dev cmake make

WORKDIR /opt/test-runner
COPY --from=build /opt/test-runner/ .

COPY . .
ENTRYPOINT ["/opt/test-runner/bin/run.sh"]
```

##### Example: installing libraries

The Ruby test runner needs the `git`, `openssh`, `build-base`, `gcc` and `wget` packages to be installed before its required libraries (gems) can be installed.
Its [Dockerfile](https://github.com/exercism/ruby-test-runner/blob/e57ed45b553d6c6411faeea55efa3a4754d1cdbf/Dockerfile) starts with a stage (given the name `build`) that install those packages (via `apk add`) and then installs the libaries (via `bundle install`):

```dockerfile
FROM ruby:3.2.2-alpine3.18 AS build

RUN apk update && apk upgrade && \
    apk add --no-cache git openssh build-base gcc wget git

COPY Gemfile Gemfile.lock .

RUN gem install bundler:2.4.18 && \
    bundle config set without 'development test' && \
    bundle install
```

It then defines the stage that will form the resulting Docker image.
This stage does _not_ install the dependencies the previous stage installed, instead it uses the `COPY` command to copy the installed libraries from the build stage into its own stage:

```dockerfile
FROM ruby:3.2.2-alpine3.18

RUN apk add --no-cache bash

WORKDIR /opt/test-runner

COPY --from=build /usr/local/bundle /usr/local/bundle

COPY . .

ENTRYPOINT [ "sh", "/opt/test-runner/bin/run.sh" ]
```

```exercism/note
The [C# test runner's Dockerfile](https://github.com/exercism/csharp-test-runner/blob/b54122ef76cbf86eff0691daa33c8e50bc83979f/Dockerfile) does something similar, only in this case the build stage can use an existing Docker image that has pre-installed the additional packages required to install libraries.
```

## Safety

Safety is a main reason why we're using Docker containers to run our tooling.

### Prefer official images

There are many Docker images on [Docker Hub](https://hub.docker.com/), but try to use [official ones](https://hub.docker.com/search?q=&image_filter=official).
These images are curated and have (far) less chance of being unsafe.

### Pin versions

To ensure that builds are stable (i.e. they don't suddenly break), you should always pin your base images to specific tags.
That means instead of:

```dockerfile
FROM alpine:latest
```

you should use:

```dockerfile
FROM alpine:3.20.2
```

With the latter, builds will always use the same version.

### Run as a non-privileged user

By default, many images will run with a user that has root privileges.
You should consider running as a non-privileged user.

```dockerfile
FROM alpine

RUN groupadd -r myuser && useradd -r -g myuser myuser

# <RUN COMMANDS THAT REQUIRES ROOT USER, LIKE INSTALLING PACKAGES ETC.>

USER myuser
```

### Update package repositories to latest version

It is (almost) always a good idea to install the latest versions

```dockerfile
RUN apt-get update && \
    apt-get install curl
```

### Support read-only filesystem

We encourage Docker files to be written using a read-only filesystem.
The only directories you should assume to be writeable are:

- The solution dir (passed in as the second argument)
- The output dir (passed in as the third argument)
- The `/tmp` dir

```exercism/caution
Our production environment currently does _not_ enforce a read-only filesystem, but we might in the future.
For this reason, the base template for a new test runner/analyzer/representer starts out with a read-only filesystem.
If you can't get things working on a read-only file, feel free to (for now) assume a writeable file system.
```
