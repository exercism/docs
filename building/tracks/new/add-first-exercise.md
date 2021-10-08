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

To implement the "Hello, World!" exercise, you'll need to create several files.
Which files exactly is described in the [Practice Exercises documentation](/docs/building/tracks/practice-exercises).

The "Hello, World!" exercise has some special rules applied to it:

- It is always the first exercise in a track
- Each track must implement it
- The test file has only one test
- The stub file contains an almost-working implementation, but instead of "Hello, World!" it uses "Goodbye, Mars!"
- It has no `prerequisites`
- It has no `practices`
