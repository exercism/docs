# Shared files

Some documentation files apply to both [Concept Exercises](/docs/building/tracks/concept-exercises) and [Practice Exercises](/docs/building/tracks/practice-exercises). These cross-exercise files are located within the track's `exercises/shared/.docs` directory:

- `debug.md`: explains how a student that is coding in the browser can still do "debugging" (optional)
- `help.md`: contains track-specific instructions on how to get help (required)
- `tests.md`: contains track-specific instructions on how to run the tests (required)

The [Presentation document](/docs/building/tracks/presentation) describes how these files are used to present content to the student.

---

## File: `debug.md`

**Purpose:** Explain how a student that is coding in the browser can still do "debugging"

**Presence:** Optional

The in-browser editor does not have any built-in debugging support. If the track's test runner supports capturing console output, the student can still do some form of "debugging" and this document explains how to do that.

The contents of this file are _only_ shown in the online editor; the CLI will ignore this file.

### Example

````markdown
# Debug

To help with debugging, you can use the fact that any [console output](https://www.programiz.com/csharp-programming/basic-input-output) will be shown in the test results window. You can write to the console using:

```csharp
Console.WriteLine("Debug message");
```
````

## File: `help.md`

**Purpose:** Explain how a student can get help

**Presence:** Required

Describe how a student can get help, specifically for this track (not Exercism-wide).

The contents of this file are _only_ used by the CLI, which [includes it in the HELP.md file](/docs/building/tracks/presentation).

The instructions should be short and to the point.

You could link to resources like Gitter channels, forums or mailing lists: whatever can help a student become unstuck.

The links in this document can overlap with those in `docs/LEARNING.md` or `docs/RESOURCES.md`.

This document should **not** link to Exercism-wide (track-agnostic) help resources, as those resources will automatically be included in the `HELP.md` file.

### Example

```markdown
# Help

If you're having trouble, feel free to ask help in the C# track's [gitter channel](https://gitter.im/exercism/csharp).
```

## File: `tests.md`

**Purpose:** Contains track-specific instructions on how to run the tests

**Presence:** Required

Describe how to run the tests for this particular exercise.

The contents of this file are _only_ used by the CLI, which [includes it in the HELP.md file](/docs/building/tracks/presentation).

The instructions should be short and to the point.

The `docs/TESTS.md` file can contain a more verbose description on how to run tests.

### Example

```markdown
# Tests

To run the tests, run the command `dotnet test` from within the exercise directory.
```

---

## Overwriting

_Note: this is not yet implemented_

Exercises can overwrite the track-specific files by creating an identically named file in the exercise's `.docs` directory (e.g. `.docs/debug.md`). This should only rarely be needed (if at all).
