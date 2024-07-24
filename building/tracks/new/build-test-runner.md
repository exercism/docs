# Build test runner

The test runner is an essential bit of tooling that allows:

- The website to automatically verify if an iteration passes all the tests.
- Students to solve exercises using the [in-browser editor](/docs/using/solving-exercises/using-the-online-editor) ([no CLI needed](/docs/using/solving-exercises/working-locally)).

To get started building a Test Runner, check the [Creating a Test Runner from scratch](/docs/building/tooling/test-runners/creating-from-scratch) document.

## Implementation

Track tooling is usually (mostly) written in the track's language.

```exercism/caution
While you're free to use other languages, each additional language will make it harder to maintain or contribute to the track.
Therefore, we recommend using the track's language where possible, because it makes maintaining or contributing easier.
```

## Deployment

The test runner is packaged and run as a [Docker container](/docs/building/tooling/docker).
Test runner Docker images are deployed automatically using a [GitHub Actions workflow](https://github.com/exercism/generic-test-runner/blob/main/.github/workflows/docker.yml).

## Testing

Once a test runner has been built, you could use its Docker image in your track's CI setup to verify the track's exercises.
The main benefit of this approach is that it better mimics the production setup; in other words, you can be more confident that things also work in production.
A possible downside is that it might slow down the CI workflow.
It is up to you, the maintainer, to decide which approach works best for your track.
