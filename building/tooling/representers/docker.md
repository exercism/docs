# Docker

Our Representers are deployed as Docker images.

Please read the [general Tooling docker information](/docs/building/tooling/docker) to familiarize yourself with how these work.

## Integration

When we run a Representer to create a solution representation, we run a Docker command that looks like this:

```shell
docker run \
        --rm \
        --network none \
        --mount type=bind,src="${solution_dir}",dst=/solution \
        --mount type=bind,src="${output_dir}",dst=/output \
        --tmpfs /tmp:rw \
        "exercism/${track_slug}-representer" \
        "${exercise_slug}" "/solution" "/output"
```

You can see that we pass three arguments to the Docker image:

1. The exercise slug
2. The path to the solution's directory
3. The path to the output directory

## Conventions

All our Representers use the following conventions in their implementation:

- The `Dockerfile` is in the repo's root directory.
- The working directory should be `/opt/representer`.
- The entrypoint is `/opt/representer/bin/run.sh`
- The `/opt/representer/bin/run.sh` script takes 3 arguments:
  1. The exercise slug
  2. The path to the solution's directory
  3. The path to the output directory

For more information see [The Interface](/docs/building/tooling/test-runners/interface).

```exercism/note
New representer repos will use these conventions by default.
```
