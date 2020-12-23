_work in progress_

# Track

There are many different parts to a track.

## Metadata

The track's configuration and metadata are specified in the `config.json` file. It lists the track's exercises, concepts, editor settings, and much more. Checkout the [config.json documentation](./config.json.md).

## Config

TODO: describe the `config` folder's contents

## Docs

TODO: describe the `docs` folder's contents

## Concepts

TODO: describe the `concepts` folder's contents

## Exercises

### Concept Exercises

TODO: describe the `exercises/concept` folder's contents

### Practice Exercises

TODO: describe the `exercises/practice` folder's contents

### Shared

TODO: describe the `exercises/shared` folder's contents

## Structure

The basic structure of a track looks as follows:

<pre>
&lt;root&gt;
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
|   └── &lt;CONCEPT_SLUG&gt;
|       ├── about.md
|       ├── introduction.md (pending agreement on https://github.com/exercism/v3/issues/2767)
|       └── links.json
└── exercises
|   ├── concept
|   |   └── &lt;EXERCISE_SLUG&gt;
|   |       ├── .docs
|   |       |   ├── introduction.md
|   |       |   ├── instructions.md
|   |       |   ├── hints.md
|   |       |   └── source.md (required if there are third-party sources)
|   |       ├── .meta
|   |       |   ├── design.md
|   |       |   └── config.json
|   |       └── ... (track-specific exercise files like the stub, example and test files)
|   ├── practice
|   |   └── &lt;EXERCISE_SLUG&gt;
|   |       └── ... (TODO: describe practice exercise files)
|   └── shared
|       └── .docs
|           ├── cli.md
|           └── debug.md
└── [config.json](./config.json.md)
</pre>
