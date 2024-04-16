# Test Generators

A Test Generator is a piece of software that can automatically generate a practice exercise's tests.
It will do this by converting the exercise's JSON test cases to track-specific tests.

## Benefits

The are three key benefits from having a Test Generator:

1. Adding exercises is simpler and faster.
2. Automate "boring" parts of adding an exercise.
3. Easy to sync tests with latest canonical data.

## Using

How to use a Test Generator is track-specific.
Look for instructions in the track's `README.md`, `CONTRIBUTING.md` or the Test Generator code's directory.

## Goal

In general, one runs a Test Generator to either:

1. Generate the tests for a new exercise
2. Update the tests of an existing exercise

### Generate tests for new exercise

Adding a Test Generator for a new exercise allows one to generate its tests file(s).
Provided the Test Generator itself has already been implemented, adding support for the new exercise will be (far) less work than writing it from scratch.

### Update tests of existing exercise

Once an exercise has a Test Generator, you can re-run it to update/sync the exercise with its latest canonical data.
We recommend doing this periodically, to check if there are problematic test cases that need to be updated or new tests that you might want to include.

## Starting point

There are two possible starting points when implementing a Test Generator for an exercise:

1. The exercise is new and doesn't yet have any tests
2. The exercise already exists and has existing tests

```exercism/caution
If there are existing tests, implement the Test Generator such that the tests it generates do not break existing solutions.
```

## Design

Broadly speaking, test files are generated using either:

- Code: the tests files are (mostly) generated via code
- Templates: the tests files are (mostly) generated using templates

In general, the code-based approach will lead to fairly complex Test Generator code, whereas the template-based approach is simpler.

What we recommend is the following flow:

1. The Test Generator reads the exercise's canonical data
2. The Test Generator converts the exercise's canonical data into a format that can be used in a template
3. The Test Generator passes the exercise's canonical data to an exercise-specific template

The key benefit of this setup is that each exercise has its own template, which:

- Makes it obvious how the test files is generated
- Makes them easier to debug
- Makes it safe to edit them without risking breaking another exercise

```exercism/caution
Some additional things to be aware of when designing the test generator

- Minimize the pre-processing of canonical data inside the Test Generator
- Try to reduce coupling between templates
```

## Implementation

The Test Generator is usually (mostly) written in the track's language.

```exercism/caution
While you're free to use additional languages, each additional language will make it harder to find people that can maintain or contribute to the track.
We recommend using the track's language where possible, only using additional languages when it cannot be avoided.
```

## Using configlet

`configlet` is the primary track maintenance tool and can be used to:

- Create the exercise files for a new exercise: run `bin/configlet create --practice-exercise <slug>`
- Sync the `tests.toml` file of an existing exercise: run `bin/configlet sync --tests --update --exercise <slug>`
- Fetch the exercise's canonical data to disk (this is a side-effect or either of the above commands)

This makes `configlet` a great tool to use in combination with the Test Generator for some really powerful workflows.

## Command-line interface

You'll want to make using the Test Generator both easy _and_ powerful.
For that, we recommend creating one or more script files.

```exercism/note
You're free to choose whatever script file format fits your track best.
Shell scripts and PowerShell scripts are common options that can both work well.
```

Here is an example of a shell script that combines `configlet` and a Test Generator to quickly scaffold a new exercise:

```shell
bin/fetch-configlet
bin/configlet create --practice-exercise <slug>
path/to/test-generator <slug>
```
