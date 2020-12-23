_work in progress_

# Track

There are many different parts to a track.

## Metadata

The track's configuration and metadata are specified in the `config.json` file. It lists the track's exercises, concepts, editor settings, and much more. Checkout the [config.json documentation](./config.json.md).

## Concepts

All concept and practices exercises of a track involve _concepts_. These concepts are separate entities by themselves. Check the [documentation](./concepts.md) for more information.

## Exercises

Tracks have two types of exercises:

- Concept exercises: they are designed to teach one or more concepts to a student. Check the [documentation](./concept-exercises.md) for more information.
- Practice exercise: they are designed to practice learnt concepts. Check the [documentation](./practice-exercises.md) for more information.

## Shared

Some files are not specific to individual exercises, but are instead applicable to _all_ exercises. These files are

The `exercises/shared` directory contains files that are shared across exercises:

- `.docs/cli.md`: contains information on how to work with the exercise when using the CLI to download and submit the exercise.
- `.docs/debug.md`: explains how a student that is coding in the browser can still do "debugging."

## Config

TODO: describe the `config` directory's contents

## Docs

TODO: describe the `docs` directory's contents

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
|   |       |   └── Example.cs (track-specific)
|   |       ├── CarsAssemble.cs (track-specific)
|   |       ├── CarsAssemble.csproj (track-specific)
|   |       └── CarsAssembleTests.cs (track-specific)
|   ├── practice
|   |   └── leap
|   |       └── ... (TODO: describe practice exercise files)
|   └── shared
|       └── .docs
|           ├── cli.md
|           └── debug.md
└── [config.json](./config.json.md)
</pre>
