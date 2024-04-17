# Test Generators

A Test Generator is a track-specifc piece of software to automatically generate a practice exercise's tests.
It does this by converting the exercise's JSON test cases to tests in the track's language.

## Benefits

Some benefits of having a Test Generator are:

1. Exercises can be added faster
2. Automates "boring" parts of adding an exercise
3. Easy to sync tests with latest canonical data

## Use cases

In general, one runs a Test Generator to either:

1. Generate the tests for a _new_ exercise
2. Update the tests of an _existing_ exercise

### Generate tests for new exercise

Adding a Test Generator for a new exercise allows one to generate its tests file(s).
Provided the Test Generator itself has already been implemented, generating the tests for the new exercise will be (far) less work than writing them from scratch.

### Update tests of existing exercise

Once an exercise has a Test Generator, you can re-run it to update/sync the exercise with its latest canonical data.
We recommend doing this periodically, to check if there are problematic test cases that need to be updated or new tests you might want to include.

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

We've found that the code-based approach will lead to fairly complex Test Generator code, whereas the template-based approach is simpler.

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
We recommend using the track's language where possible, only using additional languages when it makes maintaining or contributing easier.
```

### Canonical data

The core data the Test Generator works with is an exercise's [`canonical-data.json` file](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson).
This file is defined in the [exercism/problem-specifications repo](https://github.com/exercism/problem-specifications), which defines shared metadata for many Exercism's exercises.

```exercism/note
Not all exercises have a `canonical-data.json` file.
If case they don't, you'll need to manually create the tests, as there is no data for the Test Generator to work with.
```

#### Structure

Canonical data is defined in a JSON object.
This object contains a `"cases"` field which contains the test cases.
These test cases (normally) correspond one-to-one to tests in your track.

Each test case has a couple of properties, with the description, property, input value(s) and expected value being the most important ones.
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

The Test Generator's main responsibility is to transform this JSON data into track-specific tests.
Here's how the above JSON could translate into Nim test code:

```nim
import unittest
import leap

suite "Leap":
  test "year not divisible by 4 in common year":
    check isLeapYear(2015) == false

  test "year divisible by 4, not divisible by 100 in leap year":
    check isLeapYear(1996) == true
```

The structure of the `canonical-data.json` file is [well documented](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson) and it also has a [JSON schema](https://github.com/exercism/problem-specifications/blob/main/canonical-data.schema.json) definition.

##### Nesting

Some exercises use nesting, where `cases` are nested in other `cases` keys.
Only the innermost (leaf) `cases` will actually have any test cases, their parent `cases` will only ever be used for grouping.

```exercism/caution
If your track does not support grouping tests, you'll need to:

- Traverse/flatten the `cases` hierarchy to end up with only the innermost (leaf) test cases
- Combine the test case description with its parent description(s) to create a unique test name
```

#### Input and expected values

The contents of the `input` and `expected` test case keys vary widely.
In most cases, they'll be scalar values (like numbers, booleans or strings) or simple objects.
However, occasionally you'll also find more complex values that will likely require a bit or preprocessing, such as lambdas in pseudo code, lists of operations to perform on the students code and more.

#### Scenarios

Test cases have an optional `scenarios` field.
This field can be used by the test generator to special case certain test cases.
The most common use case is to ignore certain types of tests, for example tests with the `"unicode"` scenario as your track's language might not support Unicode.

The full list of scenarios can be found [here](https://github.com/exercism/problem-specifications/blob/main/SCENARIOS.txt).

#### Reading canonical-data.json files

There are a couple of options to read the `canonical-data.json` files:

1. Fetch them directly from the `problem-specifications` repository (e.g. `https://raw.githubusercontent.com/exercism/problem-specifications/main/exercises/leap/canonical-data.json`).
2. Add the `problem-specifications` repo as a Git submodule to the track repo.
3. Read them from the `configlet` cache.
   The [location depends on the user's system](https://nim-lang.org/docs/osappdirs.html#getCacheDir), but you can use `configlet info -o -v d | head -1 | cut -d " " -f 5` to programmatically get the location.

#### Track-specific test cases

If your track would like to add some additional, track-specific test cases (which are not found in the canonical data), one option is to creating an `additional-test-cases.json` file, which the Test Generator can then merge with the `canonical-data.json` file before passing it to the template for rendering.

### Templates

The template engine to use will likely be track-specific.
Ideally, you'll want your templates to be as straightforward as possible, so don't worry about code duplication and such.

The templates themselves will get their data from the Test Generator on which they iterate over to render them.

```exercism/note
To help keep the templates simple, it might be useful to do a little pre-processing on the Test Generator side or else define some "filters" or whatever extension mechanism your templates allow for.
```

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

### Minimum Viable Product

We recommend incrementally building the Test Generator, starting with a Minimal Viable Product.
A bare minimum version would read an exercise's `canonical-data.json` and just pass that data to the template.

Start by focusing on a single exercise, preferrably a simple one like `leap`.
Only when you have that working should you gradually add more exercises.

And try to keep the Test Generator as simple as it can be.

```exercism/note
Ideally, a contributor could you just/paste/modify an existing template without having to understand how the Test Generator works internally.
```

## Using or contributing

How to use or contribute to a Test Generator is track-specific.
Look for instructions in the track's `README.md`, `CONTRIBUTING.md` or the Test Generator code's directory.
