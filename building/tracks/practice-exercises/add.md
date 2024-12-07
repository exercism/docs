# Add Practice Exercise

This document will explain how to add a new [Practice Exercise](/docs/building/tracks/practice-exercises).

## Select exercise

The simplest way to check what Practice Exercises have not yet been implemented is to go to the track's build page (e.g. https://exercism.org/tracks/csharp/build) and check the "Practice Exercises" section.

```exercism/caution
The data on the build page is updated once a day.
```

## Scaffold exercise

You can quickly scaffold a new Practice Exercise by running the `bin/add-practice-exercise` script ([source](https://github.com/exercism/generic-track/blob/main/bin/add-practice-exercise)) from the track's root directory:

```shell
bin/add-practice-exercise <exercise-slug>
```

Optionally, you can also specify the exercise's difficulty (via `-d`) and/or author's GitHub username (via `-a`):

```shell
bin/add-practice-exercise -d 3 -a foobar <exercise-slug>
```

```exercism/note
If you're working on a track repo without this file, feel free to copy them into your repo using the above source link.
```

## Implement exercise

Once the scaffolded files have been created, you'll then have to:

- Add tests to the tests file
- Add an example implementation
- Define the stub file's contents
- Within the exercise's `.meta/config.json` file:
  - Add the GitHub username of the exercise's authors to the `authors` key
- Within the track's `config.json` file:
  - Check/update the exercise's difficulty
  - Add concepts to the `practices` key (only required when the track has concept exercises)
  - Add concepts to the `prerequisites` key (only required when the track has concept exercises)

### Add tests

A key part of adding an exercise is adding tests.
Roughly speaking, there are two options when adding tests for one of the above exercises:

1. Implement the tests from scratch, using the test cases from the exercise's `canonical-data.json` file as found in the [problem-specifications repo](https://github.com/exercism/problem-specifications).
2. Port the tests from another track's implementation (tip: go to `https://exercism.org/exercises/<slug>` to get an overview of which tracks have implemented a specific exercise).

The second option can be particularly appealing, as it can give you results quickly.
Keep in mind, though, that you should tweak the implementation to best fit your track.
As an example, some tracks do not use classes but only work with functions.
If your track usually works with objects though, you should adapt the implementation to what best fits your track.

```exercism/note
Some tracks use a [test _generator_](/docs/building/tooling/test-generators) to automatically (re-)generate an exercise's test file(s).
Please check the track documentation to see if there is a test generator and if so, how to use it.
```

### Add example implementation

To ensure that it is possible to write code that passes the tests, an example implementation needs to be added.

```exercism/note
The code does _not_ have to be idiomatic, it only has to pass the tests.
```

You can verify the example implementation passes all the tests by running the `bin/verify-exercises` script ([source](https://github.com/exercism/generic-track/blob/main/bin/verify-exercises)) from the track's root directory:

```shell
bin/verify-exercises <exercise-slug>
```

Use the output to verify that the example implementation passes all the tests.

```exercism/note
If you're working on a track repo without this file, feel free to copy them into your repo using the above source link.
```

```exercism/advanced
Under the hood, the `bin/verify-exercises` script does several things:

- Copy the exercise to a temporary directory
- Overwrite the stub file(s) with the example implementation file(s)
- If the test file has skipped tests, they will be "unskipped"
- Run the tests
```

### Add stub file(s)

The stub implementation file(s) provide a starting point for students.

We recommend stub files to have the minimal amount of code such that:

- The student can immediately start implementing the logic to pass the tests
- The student is not presented with "weird" syntax errors

In practice, this means defining the functions/methods that are tested by the test suite.
Tracks are free as to how they setup this code, as long as they ensure that the stub code initially fails all the tests.

#### Examples

Python:

```python
def two_fer(name):
    pass
```

Kotlin:

```kotlin
fun twofer(name: String): String {
    TODO("Implement the function to complete the task")
}
```

## Lint exercise

The final step is to run [the linter](/docs/building/configlet/lint) to check if the track's (configuration) files are properly structured - both syntactically and semantically.

First, make sure you have the latest version of [`configlet`](/docs/building/configlet/) by running:

```shell
bin/fetch-configlet
```

The run [the linter](/docs/building/configlet/lint) by running:

```shell
bin/configlet lint
```

Use the output to verify that all is well.

## Submit Pull Request

Once all is well, you can then [Submit a Pull Request](/docs/building/github/contributors-pull-request-guide) to the track's repository.

Before submitting, please read the [Contributors Pull Request Guide](/docs/building/github/contributors-pull-request-guide) and [Pull Request Guide](/docs/community/being-a-good-community-member/pull-requests).

Ensure the PR description lists the exercise being added.
