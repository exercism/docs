# Test Generators

A Test Generator is a piece of software that creates a practice exercise's tests from the common [problem specifications](https://github.com/exercism/problem-specifications).
Some tracks also create tests for concept exercises from a similar track-owned data source.

A Test Generator give us these advantages:

1. They allow adding exercises more quickly without writing much boilerplate code.
2. Contributors can focus on the **design** of an exercise immediately.
3. Along the track life, automatic updates of existing tests can lower maintainer workload.

## Contributing to Test Generators

Each language may have its own Test Generator, written in that language.
It adds code and sometimes files to what [`configlet`](/docs/building/configlet) created / updated.
The code usually is rendered from template files, written for the tracks preferred templating engine.
You should find all the details in the tracks contribution docs or a `README` near the test generator.

You should also know:

- what [`configlet create`](/docs/building/configlet/create) or [`configlet sync`](/docs/building/configlet/sync) do.
- what [`canonical-data.json` in problem specifications](https://github.com/exercism/problem-specifications?tab=readme-ov-file#test-data-canonical-datajson) may provide.
- why ["creating from scratch" is different from "reproducing for updates"](#from-scratch-vs-updating).

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

### From Scratch vs. Updating

There are 2 common tasks a test generator may do, that require separate approaches:

- [Creating tests from scratch](#creating-tests-from-scratch)
- [Reproducing tests for updates](#reproducing-tests-for-updates)

The reason for this distinction is "designing the exercise" vs. "production-ready code".

When creating tests from scratch the test generator should provide all the information contained in `canonical-data.json` in the resulting files.
This enables contributors to simply open up the generated test file(s) and find all relevant information interwoven with the tracks boilerplate code.
They then design the exercise's tests and student facing code based on these files rather than on the original `canonical-data.json`.
As there is no knowledge of exercise specific things, yet, a one-fits-all template targeting the boilerplate code can be used.

When the exercise is already in production, changes in `canonical-data.json` are rarely a reason to change the design of the exercise.
So reproducing tests for updates is based on the existing design and should result in production-ready code.
Much of the additional data presented when creating the exercise from scratch is no longer part of the result.

Instead, very often additional conversion of test case data is required, which is specific to this exercise.
Most tracks opt for having at least one template per exercise for this.
This way they can represent all the design choices in that template without complicating things too much for further contribution.

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

### Reproducing tests for updates

This may become more relevant over track life time.
It is much harder to implement than the "from scratch" part.
If you need to invest much effort here, maybe manual maintenance is more efficient.
Also keep in mind: maintaining the test generator adds to the maintainers workload, too.

```exercism/note
Choose a flexible and extensible templating engine!
The test cases vary largely between exercises.
They include simple scalar values, lambdas in pseudo code, lists of operations to perform on the students code and any other kind of input or result one can imagine.
```

Doing the bare minimum required for a usable updating test generator includes:

- Read the `canonical-data.json` of the exercise from `configlet` cache or retrieve it from GitHub directly
- If the tracks testing framework supports no nested test case groups, flatten the nested data structure into a list of test cases
- Render the test cases into the exercise specific template(s) located in an exercise's `.meta/` folder
  - Render production-ready code that matches the manually designed exercise
  - Skip over "reimplemented" test cases (those referred to in a `reimplements` key of another test case)
  - Render only test cases selected by `tests.toml` (or another track-specific data source)

There are different strategies for respecting test case changes like "replace always", "replace when forced to", "use `tests.toml` to ignore replaced test cases" (works like a baseline for known test issues).
None of them is perfect.

```exercism/note
Don't try to have a versatile one-fits-all template!
There is way too much variation in the exercises to handle all in one template.
```

There are optional things a test generator might do:

- Provide a library of templates and / or extensions to the template engine
- Maintain or respect another track-specific data source than `tests.toml`
- Maintain student code file(s) or additional files required by the track
- Handle `scenarios` for grouping / test case selection
- Have a check functionality (e.g. to run after `configlet sync`) to detect when updating is required
