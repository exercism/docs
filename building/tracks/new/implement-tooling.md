# Implement tooling

After launching the track with the first 20+ exercises, the focus should shift to implementing the track tooling.
Each track has various pieces of tooling that run in production.
Each provides a key function to the learning experience of that language.

There also can be track tooling to run for contribution or maintainance.
Such tools provide help to create new exercises or keeping them up-to-date.
Each lowers the barriers for new contributors and speeds up the growth of the track.

There are (currently) three pieces of tooling for production:

- **[Test Runners](/docs/building/tooling/test-runners)**: runs an exercise's tests against a student's code. (required)
- **[Representers](/docs/building/tooling/representers)**: create a normalized representation of a solution (optional)
- **[Analyzers](/docs/building/tooling/analyzers)**: automatically assess student submissions and provide mentor-style commentary. (optional)

Some tracks have (currently) implemented these pieces of tooling for contribution:

- **[Test Generators](/docs/building/tooling/test-generators)**: create or update an exercise's tests and student's code interface. (optional)

## Which tool to implement?

Of the three production tools, the test runner should be implemented first as it enables:

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

To speed up adding new exercises, a Test Generator is very handy.
The first thing to implement is creating tests for new exercises from scratch.
This takes away writing boilerplate code and leaves the focus on designing the exercises.
Later in track development, the test generator may become capable of reproducing production-ready tests for updates.
There are many hints and guidelines collected in the [Test Generators](/docs/building/tooling/test-generators) document.

## Implementation

The tooling is (generally) written in the track's language, but you're completely free to use whatever language (or combination of languages) you prefer.

Each production tool is packaged and run as a [Docker container](/docs/building/tooling/docker).
Tooling images are deployed automatically using a [Docker workflow](https://github.com/exercism/generic-test-runner/blob/main/.github/workflows/docker.yml).

Tools for contribution should fit into a workflow common for the language of the track.
When using external packages, make sure these do not get packaged into the production Docker images or loaded in CI.
