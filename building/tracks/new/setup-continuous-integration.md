# Set up Continuous Integration

Setting up Continuous Integration (CI) for your track is very important, as it helps catch mistakes.

## GitHub Actions

Exercism repos (including track repos) use [GitHub Actions](https://docs.github.com/en/actions) to run their CI.
GitHub Actions are based on _workflows_, which define scripts to run automatically whenever a specific event occurs (e.g. pushing a commit).
For more information on GitHub Actions workflows, check the [workflows docs](/docs/building/tracks/ci/workflows).

## Pre-installed workflows

Tracks come pre-installed with a number of workflows, most of which you should _not_ modify (they're called _shared workflows_).
There is one workflow that you _should_ change though, which is the `test.yml` workflow.

## Test workflow

The goal of the `test.yml` workflow is to verify that the track's exercises are in proper shape.
The workflow is setup to run automatically (in GitHub Actions terminology: is _triggered_) when a push is made to the `main` branch or to a pull request's branch.

The workflow itself should not do much, except for:

- Checking out the code (already implemented)
- Installing dependencies (e.g. installing packages, optional)
- Installing tooling (e.g. installing an SDK, optional)
- Running the verify exercises script (already implemented)

## Implement the verify exercises script

As mentioned, the exercises are verified via a script, namely the `bin/verify-exercises` (bash) script.
This script is _almost_ done, and does the following:

- Loops over all exercise directories
- For each exercise directory, it then:
  - Copies the example/exemplar solution to the (stub) solution files (already implemented)
  - Calls the `unskip_tests` function in which you can unskip tests in your test files (optional)
  - Calls the `run_tests` function in which you should run the tests (required)

The `run_tests` and `unskip_tests` functions are the only things that you need to implement.

### Unskip tests

If your track supports skipping tests, we must ensure that no tests are skipped when verifying an exercise's example/exemplar solution.
In general, there are two ways in which tracks support "unskipping" tests:

1. Removing annotations/code/text from the test files.
   For example, changing `test.skip` to `test`.
2. Providing an environment variable.
   For example, setting `SKIP_TESTS=false`.

#### Removing annotations/code/text from the test files

If skipping tests is file-based (the first option mentioned above), edit the `unskip_tests` function to modify the test files (the existing code already handles the looping over the test files).

```exercism/note
The `unskip_test` function runs on a copy of an exercise directory, so feel free to modify the files as you see fit.
```

##### Example

The [Arturo track's `bin/verify-exercises file`](https://github.com/exercism/arturo/blob/2393d62933058f011baea3631e9295b7884925e0/bin/verify-exercises) uses `sed` to unskip the tests within the test files:

```bash
unskip_tests() {
    jq -r '.files.test[]' .meta/config.json | while read -r test_file; do
        sed -i 's/test.skip/test/g' "${test_file}"
    done
}
```

#### Providing an environment variable

```exercism/caution
If unskipping tests requires an environment variable to be set, make sure that it is set in the `run_tests` function.
```

### Run tests

The `run_tests` function is responsible for running the tests of an exercise.
When the function is called, the example/exemplar files will already have been copied to (stub) solution files, so you only need to call the right command to run the tests.

The function must return zero as the exit code if all tests pass, otherwise return a non-zero exit code.

```exercism/note
The `run_tests` function runs on a copy of an exercise directory, so feel free to modify the files as you see fit.
```

#### Option 1: use language tooling

The default option for the verify exercises script is to use the language's tooling (SDK/binary/etc.), which is what most tracks use.
Each track will have its own way of running the tests, but usually it is just a single command.

#### Example

The [Arturo track's `bin/verify-exercises file`](https://github.com/exercism/arturo/blob/2393d62933058f011baea3631e9295b7884925e0/bin/verify-exercises) modifies the `run_tests` function to simply call the `arturo` command on the test file:

```bash
run_tests() {
    arturo tester.art
}
```

### Option 2: use the test runner Docker image

The second option is to verify the exercises by running the track's [test runner](/docs/building/tracks/new/build-test-runner).
This of course depends on the track having a working [test runner](/docs/building/tracks/new/build-test-runner).

If your track does not yet have a test runner, you can either:

- build a working test runner, or
- use option 1 and directly use the language tooling

The following modifications need to be made to the default `bin/verify-exercises` script:

1. Verify that the `docker` command is available
2. Pull (download) the test runner Docker image
3. Use `docker run` to run the test runner Docker image on each exercise
4. Use `jq` to verify that the `results.json` file returned by the Docker container indicates all tests passed
5. Remove the `unskip_test` function and the call to that function

```exercism/note
The main benefit of this approach is that it best mimics how tests are being run in production (on the website).
With this approach, it is less likely that things fail in production that passed in CI.
The downside of this approach is that it usually is slower, due to having to pull the Docker image and the overhead of Docker.
```

#### Example

The [Unison track's `bin/verify-exercises file`](https://github.com/exercism/unison/blob/f39ab0e6bd0d6ac538f343474a01bf9755d4a93c/bin/test) adds the check to verify that the `docker` command is also installed:

```bash
required_tool docker
```

Then, it pulls the track's test runner image:

```bash
docker pull exercism/unison-test-runner
```

It then modifies the `run_tests` function to use `docker run` to run the test runner on the current exercise (which is in the working directory), followed by a `jq` command to check for the right status:

```bash
run_tests() {
    local slug

    slug="${1}"

    docker run \
        --rm \
        --network none \
        --mount type=bind,src="${PWD}",dst=/solution \
        --mount type=bind,src="${PWD}",dst=/output \
        --tmpfs /tmp:rw \
        exercism/unison-test-runner "${slug}" "/solution" "/output"
    jq -e '.status == "pass"' "${PWD}/results.json" >/dev/null 2>&1
}
```

Finally, we need to modify the calling of the `run_tests` command, as it now requires the slug:

```bash
run_tests "${slug}"
```

## Implement the test workflow

Now that the `verify-exercises` script is finished, it's time to finalize the `test.yml` workflow.
How to do so depends on what option was chosen for the `verify-exercises` script implementation.

### Option 1: use language tooling

If the `verify-exercises` script directly uses the language's tooling, the test workflow will need to install:

- Language tooling dependencies, such as openssh or a C/C++ compiler.
- Language tooling, such as an SDK or binary.
  If the language tooling installation does _not_ add the installed binary/binaries to the path, make sure to [add it to GitHub Actions' system path](https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does/workflow-commands-for-github-actions#adding-a-system-path).

Once that is done, the `verify-exercises` should work as expected, and you've successfully set up CI!

For an example, see the [Arturo track's `test.yml` workflow](https://github.com/exercism/arturo/blob/79560f853f5cb8e2f3f0a07cbb8fcce8438ee996/.github/workflows/test.yml):

```yml
name: Test

on:
  push:
    branches: [main]
  pull_request:
    branches: [main]
  workflow_dispatch:

jobs:
  ci:
    runs-on: ubuntu-22.04

    steps:
      - name: Checkout repository
        uses: actions/checkout@692973e3d937129bcbf40652eb9f2f61becf3332

      - name: Install dependencies
        run: |
          sudo apt-get update
          sudo apt-get install libgtk-3-dev libwebkit2gtk-4.0-dev libmpfr-dev

      - name: Install Arturo
        run: bin/install-arturo
        env:
          GH_TOKEN: ${{ github.token }}

      - name: Verify all exercises
        run: bin/verify-exercises
```

### Option 2: use the test runner Docker image

The second option is to verify the exercises by running the track's [test runner](/docs/building/tracks/new/build-test-runner).
This option requires two things to be true:

1. The track has a working [test runner](/docs/building/tracks/new/build-test-runner)
2. The `verify-exercises` script use the test runner Docker image to run an exercise's tests

If your track does not yet have a test runner, you can either:

- build a working test runner, or
- use option 1 and directly use the language tooling

This approach has a couple of advantages:

1. You don't need to install any dependencies/tooling within the test workflow (as those will have been installed within the Docker image)
2. The approach best mimics how tests are being run in production (on the website), reducing the likelihood of production issues.

The main downside is that it likely is slower, due to having to pull the Docker image and the overhead of Docker.

There a couple of ways in which could pull the test runner Docker image:

1. Download the image within the `verify-exercises` file.
   This is the approach taken by the [Unison track](https://github.com/exercism/unison/blob/f39ab0e6bd0d6ac538f343474a01bf9755d4a93c/bin/test#L32).
2. Download the image within the workflow.
   This is the approach taken by the [Standard ML track](https://github.com/exercism/sml/blob/e63e93ee50d8d7f0944ff4b7ad385819b86e1693/.github/workflows/ci.yml#L16).
3. Build the image within the workflow.
   This is the approach taken by the [8th track](https://github.com/exercism/8th/blob/9034bcb6aa38540e1a67ba2fa6b76001f50c094b/.github/workflows/test.yml#L18-L40).

So which approach to use?
We recommend _at least_ implementing option number 1, to make the `verify-exercises` script be _standalone_.
If your image is particularly large, it might be beneficial to also implement option 3, which will store the built Docker image into the GitHub Actions cache.
Subsequent runs can then just read the Docker image from cache, instead of downloading it, which might be better for performance (please measure to be sure).

### Option 3: running the verify exercises script within test runner Docker image

A third, alternative option is a hybrid of the previous two options.
Here, we're also using the test runner Docker image, only this time we run the `verify-exercises` script _within that Docker image_.
To enable this option, we need to set the workflow's container to the test runner:

```yml
container:
  image: exercism/vimscript-test-runner
```

We can then skip the dependencies and tooling installation steps (as those will have been installed within the test runner Docker image) and proceed with running the `bin/verify-exercises` script.

#### Example

The [vimscript track's `test.yml` workflow](https://github.com/exercism/vimscript/blob/e599cd6e02cbcab2c38c5112caed8bef6cdb3c38/.github/workflows/test.yml) uses this option:

```yml
name: Verify Exercises

on:
  push:
    branches: [main]
  pull_request:
  workflow_dispatch:

jobs:
  ci:
    runs-on: ubuntu-24.04
    container:
      image: exercism/vimscript-test-runner

    steps:
      - name: Checkout repository
        uses: actions/checkout@692973e3d937129bcbf40652eb9f2f61becf3332

      - name: Verify all exercises
        run: bin/verify-exercises
```
