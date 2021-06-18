# Docker

Our Representers are deployed as Docker images.

Please read the [general Tooling docker information](../docker.md) to familiarize yourself with how these work.

When we run the Representer's container we execute a `run.sh` script.
To ensure this works properly the following rules must be following:

- The working directory should be `/opt/representer`.
- There should be a `/opt/representer/bin/run.sh` script that can be called with 3 parameters:
  the `exercise slug`, the path to the `solution folder`, and the path to the `output folder`.
  For more information see [The Interface](./interface.md).
