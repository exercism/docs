# Test Generators

A Test Generator is a track-specifc piece of software that can automatically generate a practice exercise's tests.
It will do this by converting the exercise's JSON test cases to tests in the format of that track.

## Benefits

The are three key benefits from having a Test Generator:

1. Adding exercises is simpler and faster.
2. Automate "boring" parts of adding an exercise.
3. Easy to sync tests with latest canonical data.

## Use cases

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

1. Reads the exercise's canonical data
2. Exclude the test cases that are marked as `include = false` in the exercise's `tests.toml` file
3. Convert the exercise's canonical data into a format that can be used in a template
4. Pass the exercise's canonical data to an exercise-specific template

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

### Canonical data

The core data Test Generators work with is an exercise's [`canonical-data.json` file](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson).
This file is defined in the [exercism/problem-specifications repo](https://github.com/exercism/problem-specifications), which defines shared metadata for many Exercism's exercises.

#### Structure

Canonical data is defined in a JSON object.
This object contains a `"cases"` field which contains the test cases.
These test cases usually correspond one-to-one to tests in your track.

Each test case has a couple of properties, like a description, input value(s) and expected value.
Here is a (partial) example of the [canonical-data.json file of the leap exercise](https://github.com/exercism/problem-specifications/blob/main/exercises/leap/canonical-data.json):

```json
{
  "exercise": "leap",
  "cases": [
    {
      "uuid": "6466b30d-519c-438e-935d-388224ab5223",
      "description": "year not divisible by 4 in common year",
      "property": "leapYear",
      "input": {
        "year": 2015
      },
      "expected": false
    },
    {
      "uuid": "4fe9b84c-8e65-489e-970b-856d60b8b78e",
      "description": "year divisible by 4, not divisible by 100 in leap year",
      "property": "leapYear",
      "input": {
        "year": 1996
      },
      "expected": true
    }
  ]
}
```

The structure of the `canonical-data.json` file is [well documented](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson) (there is also a [JSON schema](https://github.com/exercism/problem-specifications/blob/main/canonical-data.schema.json)).

```exercism/caution
Some exercises use nesting, where `cases` are nested in other `cases`.
Only the innermost `cases` will actually have any test cases, its parent `cases` will only be used for grouping.
Be aware that you might need to combine the descriptions of test case description with its parent description(s) to create a unique test name.
```

```exercism/caution
The contents of the `input` and `expected` test case keys vary widely.
In most cases, they'll be scalar values (like numbers, booleans or strings) or simple objects.
However, occasionally you'll also find more complex values that will likely require a bit or preprocessing, such as lambdas in pseudo code, lists of operations to perform on the students code and more.
```

#### Reading canonical-data.json files

There are a couple of options to read the `canonical-data.json` files:

1. Fetch them directly from the `problem-specifications` repository (e.g. `https://raw.githubusercontent.com/exercism/problem-specifications/main/exercises/leap/canonical-data.json`).
2. Add the `problem-specifications` repo as a Git submodule to the track repo.
3. Read them from the `configlet` cache.
   The [location depends on the user's system](https://nim-lang.org/docs/osappdirs.html#getCacheDir), but you can use `configlet info -o -v d | head -1 | cut -d " " -f 5` to programmatically get the location.

### Using configlet

`configlet` is the primary track maintenance tool and can be used to:

- Create the exercise files for a new exercise: run `bin/configlet create --practice-exercise <slug>`
- Sync the `tests.toml` file of an existing exercise: run `bin/configlet sync --tests --update --exercise <slug>`
- Fetch the exercise's canonical data to disk (this is a side-effect or either of the above commands)

This makes `configlet` a great tool to use in combination with the Test Generator for some really powerful workflows.

### Command-line interface

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

## Building from scratch

Before you start building a Test Generator, we suggest you look at a couple of existing Test Generators to get a feel for how other tracks have implemented them:

- [C#](https://github.com/exercism/csharp/blob/main/docs/GENERATORS.md)
- [Clojure](https://github.com/exercism/clojure/blob/main/generator.clj)
- [Common Lisp](https://github.com/exercism/common-lisp/blob/main/bin/lisp_exercise_generator.py)
- [Crystal](https://github.com/exercism/crystal/tree/main/test-generator)
- [Emacs Lisp](https://github.com/exercism/emacs-lisp/blob/main/tools/practice-exercise-generator.el)
- [F#](https://github.com/exercism/fsharp/blob/main/docs/GENERATORS.md)
- [Perl 5](https://github.com/exercism/perl5/tree/main/t/generator)
- [Pharo Smalltalk](https://github.com/exercism/pharo-smalltalk/blob/main/dev/src/ExercismDev/ExercismGenerator.class.st)
- [Python](https://github.com/exercism/python/blob/main/docs/GENERATOR.md)
- [Rust](https://github.com/exercism/rust/blob/main/docs/CONTRIBUTING.md#creating-a-new-exercise)
- [Swift](https://github.com/exercism/swift/tree/main/generator)

If you have any questions, the [forum](https://forum.exercism.org/c/exercism/building-exercism/125) is the best place to ask them.
The forum discussions [around the Rust](https://forum.exercism.org/t/advice-for-writing-a-test-generator/7178) and the [JavaScript](https://forum.exercism.org/t/test-generators-for-tracks/10615) test generators might be helpful too.

## Using or contributing

How to use or contribute to a Test Generator is track-specific.
Look for instructions in the track's `README.md`, `CONTRIBUTING.md` or the Test Generator code's directory.

```

```
