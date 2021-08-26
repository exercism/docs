# Presentation

This document describes how the various exercise and track files are presented to the student, taking into account whether the student is using the CLI or the editor.

## Documentation

There are three types of documentation that determine what documentation is being presented for an exercise.

### Exercise-specific files

These file are specific to each exercise:

- `.docs/introduction.md`: introduce the concept(s) that the exercise teaches to the student (required)
- `.docs/introduction.append.md`: additional introduction text to append after the existing introduction (not used in concept exercises, optional for practice exercises)
- `.docs/instructions.md`: provide instructions for the exercise (required)
- `.docs/instructions.append.md`: additional introduction text to append after the existing instructions (not used in concept exercises, optional for practice exercises)
- `.docs/hints.md`: provide hints to a student to help them get themselves unstuck in an exercise (required for concept exercises, optional for practice exercises)
- `.meta/config.json`: contains source information of the exercise (optional)

See the [Concept Exercises documentation](/docs/building/tracks/concept-exercises#documentationfiles) and the [Practice Exercises documentation](/docs/building/tracks/concept-exercises#documentationfiles) for more information.

### Track-specific files

These file are shared between all exercises:

- `debug.md`: explains how a student that is coding in the browser can still do "debugging" (optional)
- `help.md`: contains track-specific-wide instructions on how to get help (required)
- `tests.md`: contains track-specific instructions on how to run the tests (required)

See the [shared files documentation](/docs/building/tracks/shared-files) for more information.

### Exercism-wide documentation

Besides the above, track/exercise-specific documentation files, there are two bits of documentation that are Exercism-wide (and thus shared across all track):

- Instructions on how to use the CLI to submit an exercise
- Instructions on how to get help

## Editor

When working on an exercise in the browser, documentation files will show at the relevant times. As an example, hints are not shown unless the student requests them to be shown. The editor also doesn't need to shown the CLI instructions.

## CLI

When working locally via the CLI, we don't have the option to conditionally show documentation. Therefore, the CLI must always download all relevant documentation. To not require the student to open several files, the CLI will concatenate all relevant documentation into three documents:

### README.md

This file contains the exercise's instructions, introduction (optional) and source information (optional).

```markdown
# [exercise name]

Welcome to [exercise name] on Exercism's [track name] Track.
If you need help running the tests or submitting your code, check out `HELP.md`.
If you get stuck on the exercise, check out `HINTS.md`, but try and solve it without using those first :)

## Introduction (optional)

[Exercise-specific file: .docs/introduction.md] (optional)

[Exercise-specific file: .docs/introduction.append.md] (optional)

## Instructions

[Exercise-specific file: .docs/instructions.md]

[Exercise-specific file: .docs/instructions.append.md] (optional)

## Source

### Created by

- @[author-1 handle]
- @[author-2 handle]
  ...

### Contributed to by (optional)

- @[contributor-1 handle]
- @[contributor-2 handle]
  ...

### Based on

[source] - [source url]
```

### HELP.md

This file describes how to run the tests as well as track- and Exercism-wide help instructions.

```markdown
# Help

## Running the tests

[Track-specific file: exercises/shared/.docs/tests.md]

## Submitting your solution

[Exercism-wide documentation: instructions on how to submit a solution]

## Need to get help?

[Exercism-wide documentation: instructions on how to get help]

[Track-specific file: exercises/shared/.docs/help.md]
```

### HINTS.md

This file contains the exercise-specific hints (optional)

```markdown
# Hints

## General

- Consider extracting the logic to a helper function.
```
