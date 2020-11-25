# Test Runners

A Test Runner is a piece of software that runs a an exercise's tests against a student's code.

Test runners give us two advantages

1. They enable in-browser coding, where a student can iterate on a solution seeing whether the tests pass or fail.
2. They allow us to provide information to mentors on whether a student's code "works" or not.

Each language has it's own test runner, written in that language.
The website acts as the orchestrator between the test runners and student's submissions.

Each test runner lives in the Exercism GitHub organsation in a repository named `$LANG-test-runner` (e.g. `ruby-test-runner`).
You can explore the different test runners [here](https://github.com/exercism?q=-test-runner).

If you would like to get involved in helping with an existing Test Runner, please open an issue in its repository asking if there is somewhere you can help.
If you would like to create a Test Runner for a language that currently does not have one, please follow the [creating a Test Runner](creating-from-scratch.md) instructions.

This directory contains the following information:

- **`creating-from-scratch.md:`** Information on creating a Test Runner from scratch.
- **`interface.md:`** The Test Runner interface.
- **`docker.md:`** How to build a Docker image with Docker for local testing and deployment.
