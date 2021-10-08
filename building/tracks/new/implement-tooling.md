# Implement tooling

After launching the track with the first 20+ exercises, the focus should shift to implementing the track tooling.
Each track has various pieces of tooling that run in production.
Each provides a key function to the learning experience of that language.

There are (currently) three pieces of tooling:

- **[Test Runners](/docs/building/tooling/test-runners)**: runs an exercise's tests against a student's code. (required)
- **[Representers](/docs/building/tooling/representers)**: create a normalized representation of a solution (optional)
- **[Analyzers](/docs/building/tooling/analyzers)**: automatically assess student submissions and provide mentor-style commentary. (optional)

## Which tool to implement?

Of these three tools, the test runner should be implemented first as it enables:

- Students to solve exercises using the [in-browser editor](/docs/using/solving-exercises/using-the-online-editor) ([no CLI needed](/docs/using/solving-exercises/working-locally)).
- The website to automatically verify if an iteration passes all the tests.

To get started building a Test Runner, check the [Creating a Test Runner from scratch](/docs/building/tooling/test-runners/creating-from-scratch) document.

Once a test runner has been built, the next tool to work on is the Representer.
There is some overlap between the goals of the Representer and the Analyzer, but we recommend building the Representer first for the following reasons:

- Representers are usually (far) easier to implement
- Representers can have a far bigger impact on the mentoring load than analyzers by empowering mentors
- Representers apply to all exercises, whereas Analyzers usually target specific exercises or a subset

To get started building a Representer, check the [Creating a Representer from scratch](/docs/building/tooling/representers/creating-from-scratch) document.

Finally, after having implemented a Representer, the last tool to build is the Analyzer.
To get started building an Analyzer, check the [Creating an Analyzer from scratch](/docs/building/tooling/analyzers/creating-from-scratch) document.

## Implementation

The tooling is (generally) written in the track's language, but you're completely free to use whatever language (or combination of languages) you prefer.

Each tool is packaged and run as a [Docker container](/docs/building/tooling/docker).
Tooling images are deployed automatically using a [Docker workflow](https://github.com/exercism/generic-test-runner/blob/main/.github/workflows/docker.yml).
