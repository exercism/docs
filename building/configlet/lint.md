# Linting

The primary use of [configlet](../) is linting: checking if a track's configuration files are properly structured - both syntactically and semantically. Misconfigured tracks may not sync correctly, may look wrong on the website, or may present a suboptimal user experience, so configlet's guards play an important part in maintaining the integrity of Exercism.

## Usage

The `lint` command can be used to lint a track.

```
configlet [global-options] lint [command-options]

Global options:
  -h, --help                   Show this help message and exit
      --version                Show this tool's version information and exit
  -t, --track-dir <dir>        Specify a track directory to use instead of the current directory
  -v, --verbosity <verbosity>  The verbosity of output. Allowed values: q[uiet], n[ormal], d[etailed]
```

## Rules

These are the linting rules being checked.

### Rule: required files are present

The linter should check if all the required files are present. The non-exercise specific files that must be present are:

- `config.json`

The Concept Exercise specific files that must be present are:

- `exercises/concept/<slug>/.docs/hints.md`
- `exercises/concept/<slug>/.docs/instructions.md`
- `exercises/concept/<slug>/.docs/introduction.md`
- `exercises/concept/<slug>/.meta/config.json`

There will be a similar list for Practice Exercises, but we've not yet defined the spec for that.

Each concept listed in the `config.json` should have the following files:

- `concepts/<slug>/about.md`
- `concepts/<slug>/introduction.md`
- `concepts/<slug>/links.json`

### Rule: config.json file is valid

The `config.json` file should have the following checks:

- The file must be valid JSON
- The `"language"` key is required
- The `"language"` value must be a non-empty, non-blank string
- The `"slug"` key is required
- The `"slug"` value must be a non-empty, non-blank, lowercased string using kebab-case
- The `"active"` key is required
- The `"active"` value must be a boolean
- The `"blurb"` key is required
- The `"blurb"` value must be a non-empty, non-blank string
- The `"version"` key is required
- The `"version"` value must be the integer `3`
- The `"status.concept_exercises"` key is required
- The `"status.concept_exercises"` value must be a boolean
- The `"status.test_runner"` key is required
- The `"status.test_runner"` value must be a boolean
- The `"status.representer"` key is required
- The `"status.representer"` value must be a boolean
- The `"status.analyzer"` key is required
- The `"status.analyzer"` value must be a boolean
- The `"online_editor.indent_style"` key is required
- The `"online_editor.indent_style"` value must be the string `space` or `tab`
- The `"online_editor.indent_size"` key is required
- The `"online_editor.indent_size"` value must be a positive integer (>= 0)
- The `"exercises"` key is required
- The `"exercises.concept"` key is required
- The `"exercises.concept"` value must be an array
- The `"exercises.concept[].slug"` key is required
- The `"exercises.concept[].slug"` value must be a non-empty, non-blank, lowercased string using kebab-case
- The `"exercises.concept[].slug"` value must be unique in `"exercises.concept[].slug"` and may not exist in `"exercises.practice[].slug"`
- The `"exercise.concept[].name"` key is required
- The `"exercise.concept[].name"` value must be a non-empty, non-blank string
- The `"exercise.concept[].uuid"` key is required
- The `"exercise.concept[].uuid"` value must be a unique, lowercased v4 UUID string
- The `"exercise.concept[].deprecated"` key is optional
- The `"exercise.concept[].deprecated"` value must be a boolean value
- The `"exercise.concept[].deprecated"` value must generate a warning if set to `false`
- The `"exercise.concept[].concepts"` key is required
- The `"exercise.concept[].concepts"` value must be a non-empty array of strings
- The `"exercise.concept[].concepts"` values must be non-empty, non-blank, lowercased strings using kebab-case
- The `"exercise.concept[].concepts"` values must not have duplicates
- The `"exercise.concept[].concepts"` values must not be in any other concept exercise's `"concepts"` property
- The `"exercise.concept[].concepts"` values must match the `"concepts.slug"` property of one of the concepts
- The `"exercise.concept[].prerequisites"` key is required
- The `"exercise.concept[].prerequisites"` value must be a non-empty array of strings for all but one exercise, which can have an empty array as its value
- The `"exercise.concept[].prerequisites"` values must be non-empty, non-blank, lowercased strings using kebab-case
- The `"exercise.concept[].prerequisites"` values must not have duplicates
- The `"exercise.concept[].prerequisites"` values must match any other concept exercise's `"concepts"` property values
- The `"exercise.concept[].prerequisites"` values must not match any of the values in the exercise's `"exercise.concept[].concepts"` property
- The `"exercise.concept[].prerequisites"` values must match the `"concepts.slug"` property of one of the concepts
- There must not be any cycles between `"exercise.concept[].concepts"` and `"exercise.concept[].prerequisites"`
- The `"exercise.concept[].status"` key is optional
- The `"exercise.concept[].status"` value must be the string `wip`, `beta`, `active` or `deprecated`
- The `"exercises.practice"` key is required
- The `"exercises.practice"` value must be an array
- The `"exercise.practice[].slug"` key is required
- The `"exercise.practice[].slug"` value must be a non-empty, non-blank, lowercased string using kebab-case
- The `"exercise.practice[].slug"` value must be unique in `"exercises.practice[].slug"` and may not exist in `"exercises.concept[].slug"`
- The `"exercise.practice[].name"` key is required
- The `"exercise.practice[].name"` value must be a non-empty, non-blank string
- The `"exercise.practice[].uuid"` key is required
- The `"exercise.practice[].uuid"` value must be a unique, lowercased v4 UUID string
- The `"exercise.practice[].deprecated"` key is optional
- The `"exercise.practice[].deprecated"` value must be a boolean value
- The `"exercise.practice[].deprecated"` value must generate a warning if set to `false`
- The `"exercise.practice[].difficulty"` key is required
- The `"exercise.practice[].difficulty"` value must be an integer >= 0 and <= 10
- The `"exercise.practice[].practices"` key is required
- The `"exercise.practice[].practices"` value must be a non-empty array of strings
- The `"exercise.practice[].practices"` values must be non-empty, lowercased strings using kebab-case
- The `"exercise.practice[].practices"` values must not have duplicates
- The `"exercise.practice[].practices"` values must match the `"concepts[].slug"` property of one of the concepts
- The `"exercise.practice[].prerequisites"` key is required
- The `"exercise.practice[].prerequisites"` value must be a non-empty array of strings
- The `"exercise.practice[].prerequisites"` values must be non-empty, non-blank, lowercased strings using kebab-case
- The `"exercise.practice[].prerequisites"` values must not have duplicates
- The `"exercise.practice[].prerequisites"` values must match any concept exercise's `"exercise.concept[].concepts"` values
- The `"exercise.practice[].prerequisites"` values must match the `"concepts[].slug"` property of one of the concepts
- The `"exercise.practice[].status"` key is optional
- The `"exercise.practice[].status"` value must be the string `wip`, `beta`, `active` or `deprecated`
- The `"exercises.foregone"` key is optional
- The `"exercises.foregone"` value must be an array
- The `"exercises.foregone"` values must be non-empty, non-blank, lowercased strings using kebab-case
- The `"exercises.foregone"` values must not match any of the concept or practice exercise slugs
- The `"concepts"` key is required
- The `"concepts"` value must be an array
- The `"concepts"` value must have a entry with a matching `"slug"` property for each concept listed in a concept exercise's `"concepts"` property
- The `"concepts[].uuid"` key is required
- The `"concepts[].uuid"` value must be a unique, lowercased v4 UUID string
- The `"concepts[].slug"` key is required
- The `"concepts[].slug"` value must be a non-empty, non-blank, lowercased string using kebab-case
- The `"concepts[].name"` key is required
- The `"concepts[].name"` value must be a non-empty, non-blank, titleized string
- The `"concepts[].blurb"` key is required
- The `"concepts[].blurb"` value must be a non-empty, non-blank string
- Each `"concepts"` value must have a `concept/<concepts.slug>/about.md` file. Linting rules for this file are specified below.
- Each `"concepts"` value must have a `concept/<concepts.slug>/introduction.md` file. Linting rules for this file are specified below.
- Each `"concepts"` value must have a `concept/<concepts.slug>/links.json` file. Linting rules for this file are specified below.
- The `"key_features"` key is optional
- The `"key_features"` value must be an array with length = 6
- The `"key_features[].icon"` key is required
- The `"key_features[].icon"` value must be a string that matches one of the pre-defined icon values (TODO: add link to list of icons)
- The `"key_features[].title"` key is required
- The `"key_features[].title"` value must be a non-empty, non-blank string with length <= 25
- The `"key_features[].content"` key is required
- The `"key_features[].content"` value must be a non-empty, non-blank string with length <= 100
- The `"tags"` key is optional
- The `"tags"` value must be an array of strings
- The `"tags"` values must use one of the [pre-defined tag values](https://github.com/exercism/v3-docs/blob/main/anatomy/tracks/config-json.md#tags)

### Rule: exercises/concept/&lt;slug&gt;/.meta/config.json is valid

- The file must be valid JSON
- The JSON root must be an object
- The `"authors"` key is required
- The `"authors"` value must be a non-empty array
- The `"authors"` values must be non-empty, non-blank strings
- The `"authors"` values must not have duplicates
- The `"authors"` values are treated case-insensitively
- The `"contributors"` key is optional
- The `"contributors"` value must be an array
- The `"contributors"` values must be non-empty, non-blank strings
- The `"contributors"` values must not have duplicates
- The `"contributors"` values are treated case-insensitively
- Users can only be listed in either the `"authors"` or `"contributors"` array (no overlap)
- The `"files.solution"` key is required
- The `"files.solution"` value must be a non-empty array
- The `"files.test"` key is required
- The `"files.test"` value must be a non-empty array
- The `"files.exemplar"` key is required
- The `"files.exemplar"` value must be a non-empty array
- The files listed in the `"files.solution"` must exist
- The files listed in the `"files.test"` must exist
- The files listed in the `"files.exemplar"` must exist
- Files can only be listed in either the `"files.solution"`, `"files.test"` or `"files.exemplar` array (no overlap)
- The `"forked_from"` key is optional
- The `"forked_from"` value must be an array
- The `"forked_from"` values must be strings formatted as `<track-slug>/<exercise-slug>` (e.g. `fsharp/bird-watcher`)
- The `"forked_from"` values must refer to actually implemented exercises
- The `"forked_from"` values must be unique
- The `"language_versions"` key is optional
- The `"language_versions"` value must be a string

### Rule: exercises/concept/&lt;slug&gt;/.docs/hints.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- All headings must be either `## General` or `## X. <task>` where `X` matches the task number heading in the `instructions.md`
- All hints must be specified as Markdown list items
- Links must be absolute (relative links are not allowed)

### Rule: exercises/concept/&lt;slug&gt;/.docs/instructions.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- All tasks must start with a level two heading that starts with a number followed by a dot: `## 1. Do X`
- Links must be absolute (relative links are not allowed)

### Rule: exercises/concept/&lt;slug&gt;/.docs/instructions.md.tpl is valid (if present)

- Each [concept placeholders](../concept-exercises.md#docsintroductionmdtploptional)'s concept must match the `"concepts.slug"` property of one of the concepts in the track's `config.json`.

### Rule: exercises/concept/&lt;slug&gt;/.docs/introduction.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: exercises/practice/&lt;slug&gt;/.meta/config.json is valid

- The file must be valid JSON
- The JSON root must be an object
- The `"authors"` key is optional
- The `"authors"` value must be an array
- The `"authors"` values must be non-empty, non-blank strings
- The `"authors"` values must not have duplicates
- The `"authors"` values are treated case-insensitively
- The `"contributors"` key is optional
- The `"contributors"` value must be an array
- The `"contributors"` values must be non-empty, non-blank strings
- The `"contributors"` values must not have duplicates
- The `"contributors"` values are treated case-insensitively
- Users can only be listed in either the `"authors"` or `"contributors"` array (no overlap)
- The `"files.solution"` key is required
- The `"files.solution"` value must be a non-empty array
- The `"files.test"` key is required
- The `"files.test"` value must be a non-empty array
- The `"files.example"` key is required
- The `"files.example"` value must be a non-empty array
- The files listed in the `"files.solution"` must exist
- The files listed in the `"files.test"` must exist
- The files listed in the `"files.example"` must exist
- Files can only be listed in either the `"files.solution"`, `"files.test"` or `"files.example` array (no overlap)
- The `"language_versions"` key is optional
- The `"language_versions"` value must be a string

### Rule: exercises/shared/.docs/cli.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: exercises/shared/.docs/debug.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: concepts/&lt;slug&gt;/about.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: concepts/&lt;slug&gt;/introduction.md is valid

- The Markdown must conform to the [Markdown standards](../../../contributing/standards/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: concept/&lt;slug&gt;/links.json is valid

- The file must be valid JSON
- The JSON root must be an array
- The `"[].url"` property is required
- The `"[].url"` value must be an URL
- The `"[].description"` property is required
- The `"[].description"` value must be a non-empty, non-blank string
- The `"[].icon_url"` property is optional
- The `"[].icon_url"` value must be an URL
