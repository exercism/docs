# Docker

Our Test Runners are deployed as Docker images.

Please read the [general Tooling docker information](../docker.md) to familarise yourself with how these work.

When we run the Test Runner's container we execute a `run.sh` script.
To ensure this works properly the following rules must be following:

- The working directory should be `/opt/test-runner`.
- There should be a `/opt/test-runner/bin/run.sh` script that can be called with 3 parameters:
  the `exercise slug`, the path to the `solution folder`, and the path to the `output folder`.
  For more information see [The Interface](./interface.md).
