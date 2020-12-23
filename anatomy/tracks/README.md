_work in progress_

# Track

There are many different parts to a track.

## Metadata

The track's configuration and metadata are specified in the `config.json` file. It lists the track's exercises, concepts, editor settings, and much more. Checkout the [config.json documentation](./config.json.md).

## Config

TODO: describe the `config` directory's contents

## Docs

TODO: describe the `docs` directory's contents

## Concepts

The `concepts` directory contains concept-specific information. Each concept listed in the [config.json file](./config.json#concepts) should have its own directory within the `concepts` directory, named after the concept's slug. Each concept directory contains the following files:

- `about.md`: provide information about the concept for a student to learn from.
- `introduction.md`: provide information about the concept for use in the introduction of an exercise. (pending agreement on https://github.com/exercism/v3/issues/2767)
- `links.json`: provide helpful links that provide more reading or information about a concept.

Example:

<pre>
concepts
└── numbers
    ├── about.md.md
    ├── introduction.md (pending agreement on https://github.com/exercism/v3/issues/2767)
    └── links.json
</pre>

### Links

The `links.json` file contains an array of objects with the following fields:

- `url`: the URL of the resource to link to
- `description`: the description of the link that is displayed on the website

Example:

```json
[
  {
    "url": "https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/strings",
    "description": "Strings"
  },
  ...
]
```

## Exercises

### Concept Exercises

The `exercises/concepts` directory contains the concept-exercise files. Each concept exercise listed in the [config.json file](./config.json#concept-exercises) should have its own directory within the `exercises/concepts` directory, named after the concept exercise's slug. Each concept exercise directory contains at least the following files:

TODO: describe files

Example:

<pre>
exercises
└── concept
    └── cars-assemble
        ├── .docs
        |   ├── introduction.md
        |   ├── instructions.md
        |   ├── hints.md
        |   └── source.md (required if there are third-party sources)
        ├── .meta
        |   ├── config.json        
        |   ├── design.md
        |   └── Example.cs (track-specific)
        ├── CarsAssemble.cs (track-specific)
        ├── CarsAssemble.csproj (track-specific)
        └── CarsAssembleTests.cs (track-specific)
</pre>

### Practice Exercises

TODO: describe the `exercises/practice` directory's contents

### Shared

The `exercises/shared` directory contains files that are shared across exercises:

- `.docs/cli.md`: contains information on how to work with the exercise when using the CLI to download and submit the exercise.
- `.docs/debug.md`: explains how a student that is coding in the browser can still do "debugging."

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
