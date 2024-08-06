# Test Runners

A Test Runner is a piece of software that runs an exercise's tests against a student's code.

Test Runners give us two advantages:

1. They enable in-browser coding, where a student can iterate on a solution seeing whether the tests pass or fail.
2. They allow us to provide information to mentors on whether a student's code "works" or not.

## Contributing to Test Runners

Each language has its own Test Runner, written in that language.
The website acts as the orchestrator between the Test Runners and students' submissions.

Each Test Runner lives in the Exercism GitHub organization in a repository named `$LANG-test-runner` (e.g. [`exercism/ruby-test-runner`](https://github.com/exercism/ruby-test-runner)).
You can explore the different Test Runners [here](https://github.com/exercism?q=-test-runner).

If you would like to get involved in helping with an existing Test Runner, please open an issue in its repository asking if there is somewhere you can help.
If you would like to create a Test Runner for a language that currently does not have one, please follow the [creating a Test Runner](/docs/building/tooling/test-runners/creating-from-scratch) instructions.

You can use the following documents to learn more about building a test runner:

- [creating a Test Runner from scratch](/docs/building/tooling/test-runners/creating-from-scratch)
- [The Test Runner interface](/docs/building/tooling/test-runners/interface)
- [How to build a Docker image with Docker for local testing and deployment](/docs/building/tooling/test-runners/docker)
- [Best practices](/docs/building/tooling/best-practices)
