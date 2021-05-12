# Tooling Docker Setup

Our various track tooling are deployed as Docker images.

Each piece of tooling requires a Dockerfile, which specifies how the machine is built.
It should live at the root directory of your repository and should be called `Dockerfile`.

The Dockerfile should create the minimal image needed for the tooling to function correctly and speedily.

The Dockerfile should produce an image with as a small a size as possible while maximising (and prioritising) perfomance.
Applying the official [Dockerfile best practices](https://docs.docker.com/develop/develop-images/dockerfile_best-practices/) can help to create a minimal image.

## Execution

### Timeouts

Each tooling run has a ten-second window in which to execute.
At the end of that period it will be timed out with a 408 error code.

### Stdout/stderr

A tooling run may produce up to a maximum of one-megabyte of stdout and stderr.
If it produces more it will be killed with a 413 error code.

The contents of `stdout` and `stderr` from each run will be stored in files that can be viewed later.

You may write an `results.out` file to the output directory, which contains debugging information you want to later view.

### Results

The results file may be no larger than 500 kilobytes (including any stack traces etc).
If the file is larger than this, the tooling run will be killed with a 460 error code.

## Configuration

Each solution gets 100% machine resources for a ten second window.

After 10 seconds, the process is halted and reports as a time-out.

Configuration can be set in the [`tools.json` file](https://github.com/exercism/tooling-invoker/blob/main/tools.json) in the Tooling Invoker repository.

### Network

Tools run without access to the internet. There are two different configurations you can use:

1. `none`. This disables the networking device inside the container.
2. `internal`. This adds a networking device inside the container but the network has no access to anything external.

Different languages perform better/worse with different configurations (e.g. Ruby is 2x faster with `none`. Elixir is `12x` faster with `internal`.

You can experiment locally by using the `--network` flag when running your docker. `--network none` is supported by default.
To use the internal network, first run `docker network create --internal internal` to create the network, then use `--network internal` when running the container.

### Memory

Languages can set the maximum memory they need to use to run their jobs. Setting this to be as low as possible means that we can run more jobs more quickly in parallel. It also means that people who try and abuse memory will not be able to succeed. Different langauges need wildly different maximum memory usage. Benchmarking the execution of a docker run to establish the maximum memory it uses is advised and appreciated.

Memory [should be specified](https://docs.docker.com/config/containers/resource_constraints/#limit-a-containers-access-to-memory) using the number with suffix of b, k, m, g, to indicate bytes, kilobytes, megabytes, or gigabytes.

### Running Docker locally

You can test the settings above using this command:

```
docker container run -v /path/to/job:/mnt/exercism-iteration --network none -m 1GB exercism/ruby-test-runner lasagna /mnt/exercism-iteration/ /mnt/exercism-iteration/
```

## Editing a Dockerfile

All changes to Dockerfiles require a PR review from the @exercism/ops team, in order to avoid the introduction of security exploits.
