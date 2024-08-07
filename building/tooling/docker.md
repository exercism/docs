# Docker Setup

Our various track tooling are deployed as Docker images.

Each piece of tooling requires a [Dockerfile](https://docs.docker.com/reference/dockerfile/), which specifies how the machine is built.
It should live at the root directory of your repository and should be called `Dockerfile`.

The Dockerfile should create the minimal image needed for the tooling to function correctly and speedily.
Our [Best Practices page](/docs/building/tooling/best-practices) has lots of tips to help you achieve this goal.

## Execution

### Timeouts

The test runner gets 100% CPU with 3GB of memory for a 20 second window per solution.
After 20 seconds, the process is halted and reports a time-out with a 408 error code.

### Stdout/stderr

A tooling run may produce up to a maximum of one-megabyte of stdout and stderr.
If it produces more, it will be killed with a 413 error code.

The contents of `stdout` and `stderr` from each run will be stored in files that can be viewed later.

You may write a `results.out` file to the output directory, which contains debugging information you want to view later.

### Results

The results file may not be larger than 500 kilobytes (including any stack traces etc).
If the file is larger than this, the tooling run will be killed with a 460 error code.

## Configuration

Each solution gets 100% machine resources for a twenty second window.

After 20 seconds, the process is halted and reports as a time-out.

Some tools require (slight) deviations from the default configuration.
If so, these are configured in the [`tools.json` file](https://github.com/exercism/tooling-invoker/blob/main/tools.json) in the Tooling Invoker repository.

### Network

Tools run without access to the internet. There are two different configurations you can use:

1. `none`. This disables the networking device inside the container.
2. `internal`. This adds a networking device inside the container but the network has no access to anything external.

Different languages perform better/worse with different configurations (e.g. Ruby is 2x faster with `none`. Elixir is `12x` faster with `internal`.

You can experiment locally by using the `--network` flag when running your docker. `--network none` is supported by default.
To use the internal network, first run `docker network create --internal internal` to create the network, then use `--network internal` when running the container.

### Memory

Languages can set the maximum memory they need to use to run their jobs. Setting this to be as low as possible means that we can run more jobs more quickly in parallel. It also means that people who try and abuse memory will not be able to succeed. Different languages need wildly different maximum memory usage. Benchmarking the execution of a docker run to establish the maximum memory it uses is advised and appreciated.

Memory [should be specified](https://docs.docker.com/config/containers/resource_constraints/#limit-a-containers-access-to-memory) using the number with suffix of b, k, m, g, to indicate bytes, kilobytes, megabytes, or gigabytes.

### Running Docker locally

You can test the settings above using this command:

```
docker container run -v /path/to/job:/mnt/exercism-iteration --network none -m 1GB exercism/ruby-test-runner lasagna /mnt/exercism-iteration/ /mnt/exercism-iteration/
```

## Editing a Dockerfile

All changes to Dockerfiles require a PR review from the `@exercism/maintainers-admin` team, in order to avoid the introduction of security exploits.
