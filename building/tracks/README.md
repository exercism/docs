# Track

A track consists of many different parts.

## Metadata

The track's configuration and metadata are specified in the `config.json` file. It lists the track's exercises, concepts, editor settings, and much more. Checkout the [config.json documentation](/docs/building/tracks/config-json).

## Concepts

All concept and practices exercises of a track involve _concepts_. These concepts are separate entities by themselves. Check the [documentation](/docs/building/tracks/concepts) for more information.

## Exercises

Tracks have two types of exercises:

- Concept exercises: they are designed to teach one or more concepts to a student. Check the [documentation](/docs/building/tracks/concept-exercises) for more information.
- Practice exercises: they are designed to practice learned concepts. Check the [documentation](/docs/building/tracks/practice-exercises) for more information.

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
|   |       |   ├── introduction.md
|   |       |   ├── instructions.md
|   |       |   └── hints.md
|   |       └── .meta
|   |       |   ├── config.json
|   |       |   ├── design.md
|   |       |   └── Exemplar.cs (track-specific)
|   |       ├── CarsAssemble.cs (track-specific)
|   |       └── CarsAssembleTests.cs (track-specific)
|   └── shared
|       └── .docs
|           ├── debug.md
|           ├── help.md
|           └── tests.md
└── [config.json](/docs/building/tracks)
</pre>
