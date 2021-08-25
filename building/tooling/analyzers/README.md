# Analyzers

Exercism's analyzers automatically assess student's submissions and provide mentor-style commentary.

## Contributing to Analyzers

Each language has its own Analyzer, written in that language.
The website acts as the orchestrator between the Analyzers and students' submissions.

Each Analyzer lives in the Exercism GitHub organization in a repository named `$LANG-analyzer` (e.g. `ruby-analyzer`).
You can explore the different Analyzers [here](https://github.com/exercism?q=-analyzer).

If you would like to get involved in helping with an existing Analyzer, please open an issue in its repository asking if there is somewhere you can help.
If you would like to create an Analyzer for a language that currently does not have one, please follow the [creating a Analyzer](/docs/building/tooling/analyzers/creating-from-scratch) instructions.

This directory contains the following information:

- **[`creating-from-scratch.md`](/docs/building/tooling/analyzers/creating-from-scratch):** Information on creating a Analyzer from scratch.
- **[`interface.md`](/docs/building/tooling/analyzers/interface):** The Analyzer interface.
- **[`docker.md`](/docs/building/tooling/analyzers/docker):** How to build a Docker image with Docker for local testing and deployment.
