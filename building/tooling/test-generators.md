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

When adding a new exercise, adding a Test Generator for that exercise allows one to generate the tests file.
Provided the Test Generator itself has already been implemented, adding support for the new exercise will be (far) less work than writing it from scratch.

### Update tests of existing exercise

Once a Test Generator has been written for an exercise, you can re-run it to update/sync the exercise with its latest canonical data.
We recommend doing this periodically, to check if there are problematic test cases that need to be updated or new tests added you want to include.

## Starting point

There are two possible starting points when implementing a Test Generator for an exercise:

1. The exercise is new and doesn't yet have any tests
2. The exercise already exists and has existing tests

In the first case, you're completely free to design the exercise as you see fit.
In the second case, you should try to adhere to the existing tests as much as you can, to not break any existing solutions.

## Implementation

At its core, a Test Generator takes in an exercise slug and outputs a test file for that exercise.

Each language may have its own Test Generator, written in that language.
It adds code and sometimes files to what [`configlet`](/docs/building/configlet) created / updated.
The code usually is rendered from template files, written for the tracks preferred templating engine.
You should find all the details in the tracks contribution docs or a `README` near the test generator.

You should also know:

- what [`configlet create`](/docs/building/configlet/create) or [`configlet sync`](/docs/building/configlet/sync) do.
- what [`canonical-data.json` in problem specifications](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson) may provide.
- why ["creating from scratch" is different from "reproducing for updates"](#from-scratch-vs-updating).

## Flow

There are a couple

## Contributing to Test Generators

## Creating a Test Generator from scratch

There are various test generators in Exercism's tracks.
These guidelines are based on the experiences of these tracks.

Even so test generators work very similar, they are very track specific.
It starts with the choice of the templating engine and ends with additional things they do for each track.
So a common test generator was not and will not be written.

There were helpful discussions [around the Rust](https://forum.exercism.org/t/advice-for-writing-a-test-generator/7178) and the [JavaScript](https://forum.exercism.org/t/test-generators-for-tracks/10615) test generators.
The [forum](https://forum.exercism.org/c/exercism/building-exercism/125) also is the best place for seeking additional advice.

### Things to know

- `configlet` cache with a local copy of the problem specifications is stored in a [location depending on the users system](https://nim-lang.org/docs/osappdirs.html#getCacheDir).
  Use `configlet info -o -v d | head -1 | cut -d " " -f 5` to get the location.
  Or fetch data from the problem specifications repository directly (`https://raw.githubusercontent.com/exercism/problem-specifications/main/exercises/{{exercise-slug}}/canonical-data.json`)
- [`canonical-data.json` data structure](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson) is well documented. There is optional nesting of `cases` arrays in `cases` mixed with actual test cases.
- The contents of `input` and `expected` test case keys of `canonical-data.json` vary largely. These can include simple scalar values, lambdas in pseudo code, lists of operations to perform on the students code and any other kind of input or result one can imagine.

### Creating tests from scratch

This is more productive in the beginning of a tracks life.
It is way more easy to implement than the "updating" part.

Doing only the bare minimum required for a first usable test generator may already help contributors a lot:

- Read the `canonical-data.json` of the exercise from `configlet` cache or retrieve it from GitHub directly
- Preserve all data (including `comments`, `description` and `scenarios`)
- If the tracks testing framework supports no nested test case groups, flatten the nested data structure into a list of test cases
- Dump the test cases into the one-fits-all boilerplate template(s)
  - Preserve the test case grouping for nested test case groups, e.g.
    - using the test frameworks grouping capability
    - using comments and code folding markers (`{{{`, `}}}`)
    - concatenating group `description` and test case `description`
  - Show all data (including `comments`, `description` and `scenarios`)

```exercism/note
Don't try to produce perfect production-ready code!
Dump all data and let the contributor design the exercise from that.
There is way too much variation in the exercises to handle all in one template.
```

There are optional things a test generator might do:

- Provide code for a simple test case (e.g. call a function with `input`, compare result to `expected`)
- Provide boilerplate code for student code file(s) or additional files required by the track
- Respect `scenarios` for grouping / test case selection
- Skip over "reimplemented" test cases (those referred to in a `reimplements` key of another test case)
- Update `tests.toml` with `include=false` to reflect tests skipped by `scenarios` / `reimplements`
