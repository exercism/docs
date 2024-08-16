# Representers

One of the problems faced by the Exercism community is how to provide meaningful feedback to many people providing many solutions to many different exercises.
To help reduce the scope of this potentially enormous task, solutions are normalized into "representations".
For example, out of the most recent 500 submissions to the TwoFer exercise on the Ruby track, about 380 of them would be considered unique (if you normalize for trivial things like code formatting and comments).
If you normalize them even further (by normalizing things like function or variable names), that number gets even smaller, so there might be only 250 unique approaches.
If the Exercism community can provide some feedback on those 250 approaches, then hope is that we will have valid feedback prepared for ~99% of all future submissions for TwoFer.
With the Concept Exercises the solution space will be even smaller because Concepts Exercises will be deliberately designed to be solved in a specific way.

A _Representer_ is a bit of code that has the single responsibility of taking a solution and returning a normalized representation of it.

A _representation_ is an extraction of a solution to its essence with normalized names, comments, spacing, etc. but still uniquely identifying the approach taken. Two different ways of solving the same exercise must not have the same representation.

The simplest Representer is one that merely returns the solution's source code.
However, as our goal is to have the same representation for solutions only differing in non-essential details, the Representer should apply one or more [normalizations](/docs/building/tooling/representers/normalization).

Once we have a normalized representation for a solution, a team of vetted mentors will look at the solution and comment on it (if needed).
These comments will then automatically be submitted to each new solution with the same representation.
A notification will be sent for old solutions with a matching representation.

## Contributing to Representers

Each language has its own representer, written in that language.
The website acts as the orchestrator between the representer and students' submissions.

Each representer lives in the Exercism GitHub organization in a repository named `$LANG-representer` (e.g. `ruby-representer`).
You can explore the different representers [here](https://github.com/exercism?q=-representer).

If you would like to get involved in helping with an existing Representer, please open an issue in its repository asking if there is somewhere you can help.
If you would like to create a Representer for a language that currently does not have one, please follow the [creating a Representer](/docs/building/tooling/representers/creating-from-scratch) instructions.

You can use the following documents to learn more about building a representer:

- [Creating a Representer from scratch](/docs/building/tooling/representers/creating-from-scratch)
- [The Representer interface](/docs/building/tooling/representers/interface)
- [How to build a Docker image with Docker for local testing and deployment](/docs/building/tooling/representers/docker)
- [Best practices](/docs/building/tooling/best-practices)
- [How to normalize representations for the highest efficiency](/docs/building/tooling/representers/normalization)
