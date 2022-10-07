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

### Updating the config

Start by adding an entry to the `exercises.practice` array in the top-level `config.json` file.

```
{
  "exercises": {
    "practice": [
      {
        "uuid": "",
        "slug": "hello-world",
        "name": "Hello World",
        "practices": [],
        "prerequisites": [],
        "difficulty": 1
      }
    ]
  }
}
```

You can use the [Configlet][configlet] tool to get a UUID.
Download Configlet by running `bin/fetch-configlet` from the root of the repository.
Then generate a UUID using the `bin/configlet uuid` command.

### Generating required files

To implement the "Hello, World!" exercise, you'll need to create several files.
Which files exactly is described in the [Practice Exercises documentation](/docs/building/tracks/practice-exercises).

Most of the files can be added automatically by running Configlet's `sync` command:

```
bin/configlet sync --update --yes --docs --metadata --exercise hello-world
bin/configlet sync --update --tests include --exercise hello-world
```

In addition to the generated files, you will to create a test suite, a stub solution that serves as the starting point for the student, and a sample solution that CI uses to ensure that the test suite is in a good state.

In order to create these files you need to make some decisions about filenames and file paths.
The rule of thumb is to use names that are idiomatic for the language, and where there are no strong preferences prefer shallower directory structures.
The sample solution will need to be identifiable by the CI script, so it's advisable to choose a generic basename that all exercises can use, e.g. `example`, `sample`, or `reference-solution`.

### Configuring the exercise

One you've decided on the filenames and paths, edit the `exercises/practice/hello-world/.meta/config.json` file to reflect those choices.
Also add your GitHub username to the "authors" array.

[configlet]: /docs/building/configlet
