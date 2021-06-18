# Presentation

There are three types of documentation files that determine what documentation is being presented for an exercise:

- Exercise-specific files: see the [Concept Exercises documentation](./concept-exercises#documentationfiles) and the [Practice Exercises documentation](./concept-exercises#documentationfiles)
- Track-specific files: see the [documentation](./shared-files.md#trackspecificfiles)
- Exercism-wide files: see the [documentation](./shared-files.md#exercismwidefiles)

## Exercise-specific files

- `.docs/introduction.md`: introduce the concept(s) that the exercise teaches to the student (required)
- `.docs/introduction.append.md`: additional introduction text to append after the existing introduction (not used in concept exercises, optional for practice exercises)
- `.docs/instructions.md`: provide instructions for the exercise (required)
- `.docs/instructions.append.md`: additional introduction text to append after the existing instructions (not used in concept exercises, optional for practice exercises)
- `.docs/hints.md`: provide hints to a student to help them get themselves unstuck in an exercise (required for concept exercises, optional for practice exercises)
- `.meta/config.json`: contains source information of the exercise (optional)

## Track-specific files

- `debug.md`: explains how a student that is coding in the browser can still do "debugging" (optional)
- `help.md`: contains track-specific-wide instructions on how to get help (required)
- `tests.md`: contains track-specific instructions on how to run the tests (required)

## Exercism-wide files

- `cli.md`: contains information on how to work with the exercise when using the CLI to download and submit the exercise (required)
- `help.md`: contains generic Exercism-wide instructions on how to get help (required)

## Editor

When working on an exercise in the browser, documentation files will show at the relevant times. As an example, hints are not shown unless the student requests them to be shown. The editor also doesn't need to shown any CLI-specific instructions.

## CLI

When working locally via the CLI, we don't have the option to conditionally show documentation. Therefore, the CLI must always download all relevant documentation. To not require the student to open several files, the CLI will concatenate all relevant documentation into two documents: a `README.md` document and a `HINTS.md` document.

## Example: simple

```
## Exercise-specific files

# .docs/introduction.md
"# Introduction

This is the introduction."

# .docs/instructions.md
"# Instructions

These are the instructions."

# .docs/hints.md
"# Hints

## General

- Consider extracting the logic to a helper function."

# .meta/config.json
{ "source": "Wikipedia", "source_url": "https://en.wikipedia.org/wiki/Lasagne"}`

## Track-specific files

# debug.md
"# Debug

This is how to do debugging."

# help.md
"# Help

This is how to get track-specific help."

# tests.md
"# Tests

This is how to run the tests for this track."

## Exercism-wide files

# cli.md
"# CLI

This is how to submit the solution."

# help.md
"# Help

This is how to get Exercism-wide help."
```

### Editor

The editor will show the above documentation files, except for the `cli.md` document.

### CLI

The CLI will create a `README.md` and `HINTS.md` file that contain the above documentation files' contents, except for the `debug.md` document.

#### README.md

This is the contents of the generated `README.md` file:

```markdown
# Introduction

This is the introduction.

# Instructions

These are the instructions.

# Tests

This is how to run the tests for this track.

# Submitting

This is how to submit the solution.

# Help

This is how to get track-specific help.

This is how to get Exercism-wide help.
```

TODO: verify that this is the correct format

#### HINTS.md

This is the contents of the generated `HINTS.md` file:

```markdown
# Hints

## General

- Consider extracting the logic to a helper function.
```

## Example: with optional data

For this example, we'll re-use the documentation files from the [above example](#examplesimple), but with three additions:

```
## Exercise-specific files

# .docs/introduction.append.md
"# Introduction append

Append to the introduction."

# .docs/instructions.append.md
"# Instructions append

Append to the instructions."

# .meta/config.json
{ "source": "Wikipedia", "source_url": "https://en.wikipedia.org/wiki/Lasagne"}`
```

### Editor

The editor will show the above documentation files, except for the `cli.md` document. The two append files will be appended.

### CLI

The CLI will create a `README.md` and `HINTS.md` file that contain the above documentation files' contents, except for the `debug.md` document. The two append files will be appended.

#### README.md

This is the contents of the generated `README.md` file:

```markdown
# Introduction

This is the introduction.

Append to the introduction.

# Instructions

These are the instructions.

Append to the instructions.

# Tests

This is how to run the tests for this track.

# Submitting

This is how to submit the solution.

# Help

This is how to get track-specific help.

This is how to get Exercism-wide help.

---

Wikipedia. https://en.wikipedia.org/wiki/Lasagne
```

TODO: verify that this is the correct format

#### HINTS.md

This is the contents of the generated `HINTS.md` file:

```markdown
## General

- Consider extracting the logic to a helper function.
```
