# Docker

Our Test Runners are deployed as Docker images.

Each Test Runner requires a Dockerfile.
This file specifies how the machine is built.
It should live at the root directory of your repository and should be called `Dockerfile`.

The Dockerfile should create the minimal image needed for the Test Runner to run the tests.

It should produce an image with as a small a size as possible.
The minimal-sized image is often based on Alpine Linux.
Applying the official [Dockerfile best practices](https://docs.docker.com/develop/develop-images/Dockerfile_best-practices/) can help to create a minimal image.

## Executing the Docker container

When we run the Docker container we execute a `run.sh` script.
To ensure this works properly the following rules must be following:

- The working directory should be `/opt/test-runner`.
- There should be a `/opt/test-runner/bin/run.sh` script that can be called with 3 parameters:
  the `exercise slug`, the path to the `solution folder`, and the path to the `output folder`.
  For more information see [The Interface](./interface.md).

## Local development

To allow for local development we have produced an exectuable called [tooling-webserver](https://github.com/exercism/tooling-webserver/blob/master/README.md#installation-docker).
Please follow its installation instructions.

## Creating/editing a Dockerfile

All changes to Dockerfiles require a PR review from the @exercism/ops team.
