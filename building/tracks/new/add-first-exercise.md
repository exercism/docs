# Add the first exercise

The first exercise on each track is a very simple "Hello, World!" exercise.

The point of this exercise is to quickly make sure that everything is wired together correctly.
This will confirm that the user has the programming environment installed correctly, that they know how to run the tests, and are able to make it pass.
Beyond this, for Exercism command-line client (CLI) it also ensures that they have the CLI installed and configured properly, and that the site delivers the correct files for the exercise without delivering any unnecessary artifacts.
Lastly it ensures that the user is familiar with the cycle of downloading an exercise using the CLI, solving a problem in their local development environment, and submitting their solution back to the site.

In other words, this isn't really about learning anything about the language itself yet.
We're aiming for something dead simple.

This is also probably going to be the hardest part of getting the track repository set up right, as there are a lot of moving pieces to implementing an exercise.

## Implementing the exercise

To implement the "Hello, World!" exercise, you'll need to create a `exercises/practice/hello-world` directory.
Within that directory, the following files need to be created:

- `.docs/instructions.md`: provide instructions for the exercise.
  You can copy the instructions from [this file](https://github.com/exercism/problem-specifications/blob/main/exercises/hello-world/description.md).
  See the [Practice Exercises documentation](/docs/building/tracks/practice-exercises) for more information.
- `.meta/config.json`: contains meta information on the exercise
  See the [Practice Exercises documentation](/docs/building/tracks/practice-exercises) for more information.

```json
{
  "uuid": "aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",
  "slug": "hello-world",
  "name": "Hello, World!",
  "practices": [],
  "prerequisites": [],
  "difficulty": 1
}
```

Note that you have to replace the `uuid` value with a proper UUID V4 value.
The UUID V4 value can be generated.

An exercise contains of (at least) the following parts (as described in the [Practice Exercises documentation](/docs/building/tracks/practice-exercises)):
