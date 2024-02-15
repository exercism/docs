# Add the first exercise

The first exercise on each track is a very simple "Hello, World!" exercise.

The point of this exercise is to quickly make sure that everything is wired together correctly.
This will confirm that the user has the programming environment installed correctly, that they know how to run the tests, and are able to make it pass.
Beyond this, for Exercism command-line client (CLI) it also ensures that they have the CLI installed and configured properly, and that the site delivers the correct files for the exercise without delivering any unnecessary artifacts.
Lastly it ensures that the user is familiar with the cycle of downloading an exercise using the CLI, solving a problem in their local development environment, and submitting their solution back to the site.

In other words, this is not really about learning anything about the language itself yet.
We are aiming for something dead simple.

This is also probably going to be the hardest part of getting the track repository set up right, as there are a lot of moving parts to implementing an exercise.

## Implementing the exercise

The "Hello, World!" exercise has some special rules applied to it:

- It is always the first exercise in a track
- Each track must implement it
- The test file has only one test
- The stub file contains an almost-working implementation, but instead of "Hello, World!" it uses "Goodbye, Mars!"
- It has no `prerequisites`
- It has no `practices`

### Determine file paths

The "Hello, World!" exercise (and indeed, _all_ exercises on Exercism) requires a specific set of files:

- Documentation: explain to the student what they need to do (can be auto-generated).
- Metadata: provides Exercism with some metadata on the exercise (can be mostly auto-generated).
- Test suite: verifies a solution's correctness (track-specific).
- Stub implementation: provided a starting point for students (track-specific).
- Example implementation: provides an example implementation that passes all the tests (track-specific).
- Additional files: ensure that the tests can run (track-specific, optional).

Before we can create the "Hello, World!" exercise, you need to make some decisions about the track-specific filenames and file paths (test suite, stub implementation, example implementation and any additional files).

The rule of thumb is to use names that are idiomatic for the language.
Where there are no strong preferences, prefer shallower directory structures.
The example implementation will need to be identifiable by the CI script, so it's advisable to choose a generic basename that all exercises can use, e.g. `example`, `sample`, or `reference-solution`.

#### Configuring file paths

Having chosen the track-specific file paths, you should configure them in the `files` key in the root `config.json` file.
The `files` key will serve as the template for all exercises, which allows any tooling (some of which we'll use in a second) to know where to look for files.
You can use various placeholders to allow for easy configuring of the exercise's slug (`hello-world` in this case).

##### Example

If your track uses PascalCase for its files, the `files` key might look like this:

```json
"files": {
  "solution": [
    "%{pascal_slug}.cs"
  ],
  "test": [
    "%{pascal_slug}Tests.cs"
  ],
  "example": [
    ".meta/Example.cs"
  ]
}
```

```exercism/note
The example file(s) should be stored within the `.meta` directory.
```

For more information, check the [`files` key documentation](/docs/building/tracks/config-json#files).

### Creating files

Having specified the file path templates, you can then quickly scaffold the "Hello, World!" exercise's files by running the following commands from the track's root directory:

```shell
bin/fetch-configlet
bin/configlet create --practice-exercise hello-world
```

### Implement exercise

Once the scaffolded files have been created, you'll then have to:

- Add tests to the tests file
- Add an example implementation
- Define the stub file's contents
- Within the exercise's `.meta/config.json` file:
  - Add the GitHub username of the exercise's authors to the `authors` key

#### Add tests

A key part of adding an exercise is adding tests.
Rougly speaking, there are two options when implementing one of the above exercises:

1. Implement the tests from scratch, using the test cases from the [exercise's `canonical-data.json`][canonical-data.json]
2. Port the tests from another track's implementation (tip: go to `https://exercism.org/exercises/hello-world` to get an overview of which tracks have implemented a specific exercise).

For the "Hello, World!" exercise, there will only be one test case, so either option should be fine.

#### Add example implementation

The example implementation file should contain the code requires to solve the tests.

#### Define the stub

The stub file should have an _almost_ working solution to the tests, but with the "Hello, World!" text replaced with "Goodbye, Mars!".
Tip: just can copy-paste-modify the example solution.

### Update the exercise's author(s)

Once you're done with the exercise, please add your your GitHub username to the `"authors"` array in the exercise's `.meta/config.json` file.
This will ensure we correctly credit you with having created the exercise.

[configlet]: /docs/building/configlet
[canonical-data.json]: https://github.com/exercism/problem-specifications/blob/main/exercises/hello-world/canonical-data.json
