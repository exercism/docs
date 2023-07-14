# Track

A track consists of many different parts.

## Metadata

The track's configuration and metadata are specified in the `config.json` file. It lists the track's exercises, concepts, editor settings, and much more. Checkout the [config.json documentation](/docs/building/tracks/config-json).

## Concepts

All concept and practices exercises of a track involve _concepts_. These concepts are separate entities by themselves. Check the [documentation](/docs/building/tracks/concepts) for more information.

The concepts taught in the track's concept exercises form a _syllabus_.
For more information on how to design a syllabus, check the [syllabus documentation](/docs/building/tracks/syllabus).

## Exercises

Tracks have two types of exercises:

- Concept exercises: they are designed to teach one or more concepts to a student. Check the [documentation](/docs/building/tracks/concept-exercises) for more information.
- Practice exercises: they are designed to practice learned concepts. Check the [documentation](/docs/building/tracks/practice-exercises) for more information.

### Dig deeper

Each exercise has an optional Dig Deeper section that can contain:

- [Approaches](/docs/building/tracks/approaches): different ways in which the exercise can be solved
- [Articles](/docs/building/tracks/articles): describe interesting aspects of the exercise
- Community videos: videos that showcase the exercise, usually by having someone solve the exercise from scratch

## Shared files

Some files are not specific to individual exercises, but are instead applicable to _all_ exercises. Check the [documentation](/docs/building/tracks/shared-files) for more information.

## Docs

Each track has a couple of required documentation files. Check the [documentation](/docs/building/tracks/docs) for more information.

## Widgets

Some parts of the track can be displayed in [widgets](/docs/building/markdown/widgets).

## Style guide

All documents should adhere to the [style guide](/docs/building/markdown/style-guide). Markdown documents
should also adhere to our [Markdown standards](/docs/building/markdown/markdown).

## Example

<pre>
csharp
├── config
|   ├── exercise_readme.go.tmpl
|   └── maintainers.json
├── docs
|   ├── ABOUT.md
|   ├── INSTALLATION.md
|   ├── LEARNING.md
|   ├── RESOURCES.md
|   └── TESTS.md
├── concepts
|   └── numbers
|       ├── about.md
|       ├── introduction.md
|       └── links.json
└── exercises
|   ├── concept
|   |   └── cars-assemble
|   |       ├── .docs
|   |       |   ├── hints.md
|   |       |   ├── introduction.md
|   |       |   └── instructions.md
|   |       ├── .meta
|   |       |   ├── config.json
|   |       |   ├── design.md
|   |       |   └── Exemplar.cs (track-specific)
|   |       ├── CarsAssemble.cs (track-specific)
|   |       ├── CarsAssemble.csproj (track-specific)
|   |       └── CarsAssembleTests.cs (track-specific)
|   ├── practice
|   |   └── leap
|   |       └── .docs
|   |       |   └── instructions.md
|   |       └── .meta
|   |       |   ├── config.json
|   |       |   └── Example.cs (track-specific)
|   |       ├── Leap.cs (track-specific)
|   |       ├── Leap.csproj (track-specific)
|   |       └── LeapTests.cs (track-specific)
|   └── shared
|       └── .docs
|           ├── debug.md
|           ├── help.md
|           └── tests.md
└── config.json
</pre>

## Re-testing solutions

When you merge a track PR that touches an exercise, it triggers the latest published iteration of students' solutions to be re-tested.
For popular exercises, this is a _very_ expensive operation (70,000 test runs for Python Hello World as an extreme!).

We've added some further rules today to try and avoid this behaviour. I'll explain the logic in both directions:

Solutions **will not** be retested if:

- You add `[no important files changed]` into the PR's commit body.
- You only touch docs, hints, `.meta`, or other files that users don't interact with.

Solutions **will** be re-tested if:

1. The PR was merged **without** adding the text `[no important files changed]` into the PR's commit body.
2. The PR touches one of the following files for an exercise (as specified in its `.meta/config.json` file):

- test files
- editor files
- invalidator files

Some examples:

- [Python#3423](https://github.com/exercism/python/pull/3423): Only touches docs so no tests were run
- [Python#3437](https://github.com/exercism/python/commit/29a64a4889f94bafbd0062d7fc5052858523b25c): Was merged with `[no important files changed]` added, so no tests were run
- [Csharp#2138](https://github.com/exercism/csharp/pull/2138): Whitespace was removed from tests. The keyword was **not** added. Tests were re-run unnecessarily.
