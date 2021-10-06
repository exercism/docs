# Add a New Track

TODO: add intro

The next steps are:

- [ ] [Request new language track](/docs/building/tracks/new/request-new)
- [ ] [Join our community](/docs/building/tracks/new/join-community)
- [ ] [Select programming language variant](/docs/building/tracks/new/select-programming-language-variant) (if applicable)
- [ ] [Select testing framework](/docs/building/tracks/new/select-testing-framework)
- [ ] [Add the first exercise](/docs/building/tracks/new/add-first-exercise)
- [ ] [Add initial exercises](/docs/building/tracks/new/add-initial-exercises)
- [ ] [Prepare for launch](/docs/building/tracks/new/prepare-for-launch)
- [ ] [Launch!](/docs/building/tracks/new/launch)
- [ ] [Prepare for open source contributions from strangers](/docs/building/tracks/new/prepare-for-contributions)

## Select programming language variant (if applicable)

Some programming languages have multiple variants.
If that is the case, we should decide upon one variant that we'll support.
Ignore this step if your languages does _not_ have multiple variants.

## Select testing framework

All of the exercises are based on providing a failing test suite for people to run and make pass, so we need to pick a testing framework.
If there are multiple testing frameworks available, we'll need to figure out which one is the best fit.

### Considerations

1. Ease of getting started.
1. Cross-platform support (MacOS, Linux, Windows).

For people who are going to be doing the exercises, it's important to get them up and running as quickly as possible.

In general we prefer tools in the standard library if they're available, and if not we aim for a third party library that is widely used.
If there is a choice between several common libraries, then consider a few factors:

- Is one of them easier to install?
- Is one of them easier to get help with or search for resources about?
- Is one of them simpler than the other either in syntax or conceptually?

Remember that all Exercism exercises are by nature very small, so there's no need for the complexity that real-world projects sometimes require.

### Document the decisions

As you make these decisions, document them in this repository's README.md for
contributors and future maintainers. In particular, when someone submits a contribution
that goes against one of these decisions, it's very helpful to be able to point to not just
the conclusion, but also a bit about why that decision was made. That makes it easier to
decide whether to just close the issue or pull request from the contributor, or whether
it's time to re-evaluate the decision based on new information.

The harder the decision was to make, the more important it is to document it thoroughly.
(e.g. What trade-offs did you consider? What tipped your gut feeling in one direction or the other? What sealed the deal?)

## Implement the first exercise

The first exercise must be a very simple "Hello, World!" exercise.

The point of this exercise is to quickly make sure that everything is wired together correctly.
This will confirm that the user has the programming environment installed correctly, that they know how to run the tests, and are able to make it pass.
Beyond this, for Exercism command-line client (CLI) it also ensures that they have the CLI installed and configured properly, and that the site delivers the correct files for the exercise without delivering any unnecessary artifacts.
Lastly it ensures that the user is familiar with the cycle of downloading an exercise using the CLI, solving a problem in their local development environment, and submitting their solution back to the site.

In other words, this isn't really about learning anything about the language itself yet.
We're aiming for something dead simple.

This is also probably going to be the hardest part of getting the track repository set up right, as there are a lot of moving pieces.

## Set up Continuous Integration

Once you have one exercise set up, it's worth looking at [tooling and continuous integration](/language-tracks/launch/tooling-and-ci.md).

## Plan initial core + optional exercises

The best place at the moment to help think this through is going to be the #project-track-anatomy channel in the exercism-team slack.

There are a ton of considerations to take into account in terms of making the best possible experience for those working through the track, as well as the mentors who will be providing feedback.

We're in the process of formalizing and documenting a lot of this, so more information will be available in the coming months.

## Prepare for launch

Each track has a landing page on the site.
E.g. (when logged out) https://exercism.io/tracks/go

The page is meant to entice people into wanting to try the language out.

There are four things that we need (details below):

- an icon for the track
- a short blurb for the header section
- an "about" section with a bit more detail
- a code snippet that gives a visual impression of what the language syntax looks like
- maintainer bios

In order to design an icon for the site open a new issue in the [exercism/website-icons](https://github.com/exercism/website-icons/issues) repository, answering the following questions:

- Does the language have an official logo? If so
  - please include a link to an example
  - please list the attribution rights of that logo
- Does the language have an unofficial logo? If so
  - please explain the ways in which people use the unofficial logo
  - please include a link to an example
  - please list the attribution rights of that logo

For the blurb, about section, and code snippet please see the [documentation about introductory copy](https://github.com/exercism/docs/blob/master/language-tracks/documentation/introductory-copy.md).

The maintainer bios go in the [maintainer config](/maintaining-a-track/maintainer-configuration.md).
The goal of the bio is to give people a little bit of insight into your background with the language and why you are involved with the track on Exercism.
As you bring on new co-maintainers, have them add themselves to the file as well.

## Write "getting started" instructions for people using the track

We need to guide people through the process of getting their development environment working, and make sure they know how to run the tests.

As a bonus, we could provide some links to learning resources for people who are completely new to the language, and resources that come in handy while they're developing.

More on this in the [documentation about documentation](https://github.com/exercism/docs/blob/master/language-tracks/documentation/for-consumers.md).
