# Shared files

Some documentation files apply to both [Concept Exercises](./concept-exercises.md) and [Practice Exercises](./practice-exercises.md). There are two types of these files:

- Exercism-wide: these documentation files apply to all exercises, regardless of the track.
- Track-specific: these documentation files apply to all exercises for a specific track.

These files are located within the track's `exercises/shared/.docs` directory and will be automatically.

## Exercism-wide files

There are two Exercism-wide documentation files that apply to Concept- and Practice Exercises:

- `cli.md`: contains information on how to work with the exercise when using the CLI to download and submit the exercise. TODO: link to location of this file
- `help.md`: contains generic Exercism-wide instructions on how to get help. TODO: link to location of this file

## Track-specific files

The track-specific documentation files are located within the track's `exercises/shared/.docs` directory.

These files are presented to the student to help explain the exercise.

- `debug.md`: explains how a student that is coding in the browser can still do "debugging" (optional)
- `help.md`: contains track-specific-wide instructions on how to get help (required)
- `tests.md`: contains track-specific instructions on how to run the tests (required)

### Overwriting

Exercises can overwrite the track-specific files by creating an identically named file in the exercise's `.docs` directory (e.g. `.docs/debug.md`). This should only rarely be needed (if at all).

---

### File: `debug.md`

**Purpose:** Explain how a student that is coding in the browser can still do "debugging"

**Presence:** Optional

The in-browser editor does not have any built-in debugging support. If the track's test runner supports capturing console output, the student can still do some form of "debugging" and this document explains how to do that.

#### Example

````markdown
# Debug

To help with debugging, you can use the fact that any [console output](https://www.programiz.com/csharp-programming/basic-input-output) will be shown in the test results window. You can write to the console using:

```csharp
Console.WriteLine("Debug message");
```
````

### File: `help.md`

**Purpose:** Explain how a student can get help

**Presence:** Required

Describe how a student can get help, specifically for this track (not Exercism-wide).

#### Example

```markdown
# Help

If you're having trouble, feel free to ask help in the C# track's [gitter channel](https://gitter.im/exercism/csharp).
```

### File: `tests.md`

**Purpose:** Contains track-specific instructions on how to run the tests

**Presence:** Required

Describe how to run the tests for this particular exercise.

#### Example

```markdown
# Tests

To run the tests, run the command `dotnet test` from within the exercise directory.
```
