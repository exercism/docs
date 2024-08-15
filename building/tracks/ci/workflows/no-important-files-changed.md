# No important files changed workflow

When a track PR is merged that touches an exercise, it triggers _all_ the latest published iteration of students' solutions to be re-tested.
For popular exercises, this is a _very_ expensive operation (70,000 test runs for Python Hello World as an extreme!).

This workflow checks if the changes in a PR would trigger the re-testing of solutions, and if so, it adds a comment explaining the risk of merging the PR _as is_.
It also explains how to merge the PR without re-testing solutions.

For more information, check the [Avoiding triggering unnecessary test runs](https://exercism.org/docs/building/tracks#h-avoiding-triggering-unnecessary-test-runs) documentation.

## Source

The workflow is defined in the `.github/workflows/no-important-files-changed.yml` file.
