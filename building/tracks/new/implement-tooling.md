# Implement tooling

After launching the track with the first 20+ exercises and a test runner, the focus should shift to implementing [additional track tooling](/docs/building/tooling).

There are two types of track tooling:

- Production: provide a key function to the learning experience of that language
- Maintenance: help with track maintenance

## Production tooling

There are (currently) three pieces of tooling for production:

- **[Test Runners](/docs/building/tooling/test-runners)**: runs an exercise's tests against a student's code. (required)
- **[Representers](/docs/building/tooling/representers)**: create a normalized representation of a solution (optional)
- **[Analyzers](/docs/building/tooling/analyzers)**: automatically assess student submissions and provide mentor-style commentary. (optional)

## Maintenance tooling

To help with track maintenance, one can also build:

- **[Test Generators](/docs/building/tooling/test-generators)**: auto generate/update an exercise's tests and student's code interface. (optional)

## Which tool to implement?

The production tools are more important than maintenance tools.
At this point, you should have implemented a Test Runner (if not, check the [Build a test runner docs](/docs/building/tracks/new/build-test-runner)).

Having built a test runner, the next tool to work on is the Representer.
There is some overlap between the goals of the Representer and the Analyzer, but we recommend building the Representer first for the following reasons:

- Representers are usually (far) easier to implement
- Representers can have a far bigger impact on the mentoring load than analyzers by empowering mentors
- Representers apply to all exercises, whereas Analyzers usually target specific exercises or a subset

To get started building a Representer, check the [Creating a Representer from scratch](/docs/building/tooling/representers/creating-from-scratch) document.

Finally, after having implemented a Representer, the last tool to build is the Analyzer.
To get started building an Analyzer, check the [Creating an Analyzer from scratch](/docs/building/tooling/analyzers/creating-from-scratch) document.

At this point, focus should probably shift back to adding more exercises.
To speed up adding new exercises, consider building a [Test Generator](/docs/building/tooling/test-generators).

## Implementation

Track tooling is usually (mostly) written in the track's language.

```exercism/caution
While you're free to use other languages, each additional language will make it harder to maintain or contribute to the track.
Therefore, we recommend using the track's language where possible, because it makes maintaining or contributing easier.
```

## Deployment

Production tools are packaged and run as a [Docker container](/docs/building/tooling/docker).
Tooling Docker images are deployed automatically using a [GitHub Actions workflow](https://github.com/exercism/generic-test-runner/blob/main/.github/workflows/docker.yml).

Maintenance tools are _not_ deployed.
