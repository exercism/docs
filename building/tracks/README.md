# Track

A track consists of many different parts.

## Metadata

The track's configuration and metadata are specified in the `config.json` file. It lists the track's exercises, concepts, editor settings, and much more. Checkout the [config.json documentation](./config-json.md).

## Concepts

All concept and practices exercises of a track involve _concepts_. These concepts are separate entities by themselves. Check the [documentation](./concepts.md) for more information.

## Exercises

Tracks have two types of exercises:

- Concept exercises: they are designed to teach one or more concepts to a student. Check the [documentation](./concept-exercises.md) for more information.
- Practice exercise: they are designed to practice learned concepts. Check the [documentation](./practice-exercises.md) for more information.

## Shared files

Some files are not specific to individual exercises, but are instead applicable to _all_ exercises. Check the [documentation](./shared-files.md) for more information.

## Config

TODO: describe the `config` directory's contents

## Docs

TODO: describe the `docs` directory's contents

## Widgets

Some parts of the track can be displayed in [widgets](./widgets.md), such as [concepts](./widgets.md#conceptwidget) and [exercises](./widgets.md#exercisewidget).

## Style guide

All documents should adhere to the [style guide](../../contributing/standards/style-guide.md). Markdown documents should also adhere to our [Markdown standards](../../contributing/standards/markdown.md).

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
|   |       └── ... (TODO: describe practice exercise files)
|   └── shared
|       └── .docs
|           ├── debug.md
|           ├── help.md
|           └── tests.md
└── [config.json](./config-json.md)
</pre>
