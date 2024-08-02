# Best Practices

## Follow best practices

The official [Dockerfile best practices](https://docs.docker.com/develop/develop-images/dockerfile_best-practices/) have lots of great content on how to improve your Dockerfiles.

## Prefer official images

There are many Docker images on [Docker Hub](https://hub.docker.com/), but try to use [official ones](https://hub.docker.com/search?q=&image_filter=official).

## Pin versions

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

## Performance

You should primarily optimize for performance (especially for test runners).
This will ensure your tooling runs as fast as possible and does not time-out.

### Experiment with different Base images

Try experimenting with different base images (e.g. Ubuntu instead of Alpine), to see if one (significantly) outperforms the other.
If performance is relatively equal,

### Try Internal Network

Check if using the `internal` network instead of `none` improves performance.
See the [network docs](/docs/building/tooling/docker#network) for more information.

### Prefer build-time commands over run-time commands

Tooling runs as one-off, short-lived Docker container:

1. A Docker container is created
2. The Docker container is run with the correct arguments
3. The Docker container is destroyed

Therefore, code that runs in step 2 runs for _every single tooling run_.
For this reason, reducing the amount of code to run in step 2 is a great way to improve performance
One way of doing this is to move code from _run-time_ to _build-time_.
Whilst run-time code runs every single tooling run, build_time code only runs once (when the Docker image is built).

As build-time code runs as part of a GitHub Actions workflow, the student will never notice it.
This also means that the code at build-time could be relatively slow, it's only running once after all!

## Size

You should try to reduce the image's size, which means that it'll be:

- Faster to deploy
- Reduces costs for us
- Marginally improves startup time of each container

### Try different Base images

Some base images are

### Removing unneeded bits

An obvious, but great, way to reduce the size of your image is to remove anything you don't need.
These can include things like:

- Source files that are no longer needed after building a binary from them
- Files targeting different architectures from the Docker image
- Documentation

### Cleanup package manager

### Use multi-stage builds

https://docs.docker.com/build/building/multi-stage/

TODO

## Safety

TODO

## Support read-only filesystem

TODO
