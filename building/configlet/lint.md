# Linting

The primary use of [configlet](./) is linting: checking if a track's configuration files are properly structured - both syntactically and semantically. Misconfigured tracks may not sync correctly, may look wrong on the website, or may present a suboptimal user experience, so configlet's guards play an important part in maintaining the integrity of Exercism.

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
- `docs/ABOUT.md`
- `docs/INSTALLATION.md`
- `docs/LEARNING.md`
- `docs/RESOURCES.md`
- `docs/SNIPPET.txt`
- `docs/TESTS.md`
- `exercises/shared/.docs/help.md`
- `exercises/shared/.docs/tests.md`

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
- The `"language"` value must be a non-blank string¹ with length <= 255
- The `"slug"` key is required
- The `"slug"` value must be a kebab-case string² with length <= 255
- The `"active"` key is required
- The `"active"` value must be a boolean
- The `"blurb"` key is required
- The `"blurb"` value must be a non-blank string¹ with length <= 400
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
- The `"online_editor.indent_size"` value must be an integer >= 0 and <= 8
- The `"online_editor.highlightjs_language"` key is required
- The `"online_editor.highlightjs_language"` value must be a non-blank string¹
- The `"files"` key is optional
- The `"files"` value must be an object
- The `"files.solution`" key is optional
- The `"files.solution`" value must be an array
- The `"files.solution`" values must be valid patterns⁴
- The `"files.solution`" values must not have duplicates
- The `"files.test`" key is optional
- The `"files.test`" value must be an array
- The `"files.test`" values must be valid patterns⁴
- The `"files.test`" values must not have duplicates
- The `"files.example`" key is optional
- The `"files.example`" value must be an array
- The `"files.example`" values must be valid patterns⁴
- The `"files.example`" values must not have duplicates
- The `"files.exemplar`" key is optional
- The `"files.exemplar`" value must be an array
- The `"files.exemplar`" values must be valid patterns⁴
- The `"files.exemplar`" values must not have duplicates
- The `"files.editor`" key is optional
- The `"files.editor`" value must be an array
- The `"files.editor`" values must be valid patterns⁴
- The `"files.editor`" values must not have duplicates
- Patterns can only be listed in either the `"files.solution"`, `"files.test"`, `"files.example`, `"files.exemplar` or `"files.editor` array (no overlap)
- The `"test_runner.average_run_time"` key is required if `status.test_runner` is equal to `true`
- The `"test_runner.average_run_time"` value must be a floating-point number > 0 with one decimal point of precision
- The `"exercises"` key is required
- The `"exercises.concept"` key is required
- The `"exercises.concept"` value must be an array
- The `"exercises.concept[].slug"` key is required
- The `"exercises.concept[].slug"` value must be a kebab-case string² with length <= 255
- The `"exercises.concept[].slug"` value must be unique in `"exercises.concept[].slug"` and may not exist in `"exercises.practice[].slug"`
- The `"exercises.concept[].name"` key is required
- The `"exercises.concept[].name"` value must be a Title Case string³ with length <= 255
- The `"exercises.concept[].uuid"` key is required
- The `"exercises.concept[].uuid"` value must be a unique version 4 UUID string⁵
- The `"exercises.concept[].concepts"` key is required
- The `"exercises.concept[].concepts"` value must be a non-empty array of strings if `"exercises.concept[].status"` is not equal to `deprecated`
- The `"exercises.concept[].concepts"` value must be an empty array if `"exercises.concept[].status"` is equal to `deprecated`
- The `"exercises.concept[].concepts"` values must be kebab-case strings²
- The `"exercises.concept[].concepts"` values must not have duplicates
- The `"exercises.concept[].concepts"` values must not be in any other concept exercise's `"concepts"` property
- The `"exercises.concept[].concepts"` values must match the `"concepts.slug"` property of one of the concepts
- The `"exercises.concept[].prerequisites"` key is required
- The `"exercises.concept[].prerequisites"` value must be a non-empty array of strings if `"exercises.concept[].status"` is not equal to `deprecated`, except for exactly one exercise which _is_ allowed to have an empty array as its value
- The `"exercises.concept[].prerequisites"` value must be an empty array if `"exercises.concept[].status"` is equal to `deprecated`
- The `"exercises.concept[].prerequisites"` values must be kebab-case strings²
- The `"exercises.concept[].prerequisites"` values must not have duplicates
- The `"exercises.concept[].prerequisites"` values must match any other concept exercise's `"concepts"` property values
- The `"exercises.concept[].prerequisites"` values must not match any of the values in the exercise's `"exercises.concept[].concepts"` property
- The `"exercises.concept[].prerequisites"` values must match the `"concepts.slug"` property of one of the concepts
- There must not be any cycles between `"exercises.concept[].concepts"` and `"exercises.concept[].prerequisites"`
- The `"exercises.concept[].status"` key is optional
- The `"exercises.concept[].status"` value must be the string `wip`, `beta`, `active` or `deprecated`
- The `"exercises.practice"` key is required
- The `"exercises.practice"` value must be an array
- The `"exercises.practice[].slug"` key is required
- The `"exercises.practice[].slug"` value must be a kebab-case string² with length <= 255
- The `"exercises.practice[].slug"` value must be unique in `"exercises.practice[].slug"` and may not exist in `"exercises.concept[].slug"`
- There must be exactly one `"exercises.practice[].slug"` value that is the string `hello-world`
- The `"exercises.practice[].name"` key is required
- The `"exercises.practice[].name"` value must be a Title Case string³ with length <= 255
- The `"exercises.practice[].uuid"` key is required
- The `"exercises.practice[].uuid"` value must be a unique version 4 UUID string⁵
- The `"exercises.practice[].difficulty"` key is required
- The `"exercises.practice[].difficulty"` value must be an integer >= 0 and <= 10
- The `"exercises.practice[].practices"` key is required
- The `"exercises.practice[].practices"` value must be a non-empty array of strings if `"exercises.practice[].status"` is not equal to `deprecated`
- The `"exercises.practice[].practices"` value must be an empty array if `"exercises.practice[].status"` is equal to `deprecated`
- The `"exercises.practice[].practices"` values must be kebab-case strings²
- The `"exercises.practice[].practices"` values must not have duplicates
- The `"exercises.practice[].practices"` values must match the `"concepts[].slug"` property of one of the concepts
- The `"exercises.practice[].practices"` values must refer to an individual concept's slug at most 10 times (across all exercises)
- The `"exercises.practice[].prerequisites"` key is required
- The `"exercises.practice[].prerequisites"` value must be a non-empty array of strings if `"exercises.practice[].status"` is not equal to `deprecated`
- The `"exercises.practice[].prerequisites"` value must be an empty array if `"exercises.practice[].status"` is equal to `deprecated`
- The `"exercises.practice[].prerequisites"` value must be an empty array if `"exercises.practice[].slug"` is equal to `hello-world`
- The `"exercises.practice[].prerequisites"` values must be kebab-case strings²
- The `"exercises.practice[].prerequisites"` values must not have duplicates
- The `"exercises.practice[].prerequisites"` values must match any concept exercise's `"exercises.concept[].concepts"` values
- The `"exercises.practice[].prerequisites"` values must match the `"concepts[].slug"` property of one of the concepts
- The `"exercises.practice[].status"` key is optional
- The `"exercises.practice[].status"` value must be the string `wip`, `beta`, `active` or `deprecated`
- The `"exercises.practice[].status"` value must either not be present or the string `active` if `"exercises.practice[].slug"` is equal to `hello-world`
- The `"exercises.foregone"` key is optional
- The `"exercises.foregone"` value must be an array
- The `"exercises.foregone"` values must be kebab-case strings²
- The `"exercises.foregone"` values must not have duplicates
- The `"exercises.foregone"` values must not match any of the concept or practice exercise slugs
- The `"concepts"` key is required
- The `"concepts"` value must be an array
- The `"concepts"` value must have a entry with a matching `"slug"` property for each concept listed in a concept exercise's `"concepts"` property
- The `"concepts[].uuid"` key is required
- The `"concepts[].uuid"` value must be a unique version 4 UUID string⁵
- The `"concepts[].slug"` key is required
- The `"concepts[].slug"` value must be a kebab-case string² with length <= 255
- The `"concepts[].name"` key is required
- The `"concepts[].name"` value must be a Title Case string³ with length <= 255
- Each `"concepts"` value must have a `concept/<concepts.slug>/about.md` file. Linting rules for this file are specified below.
- Each `"concepts"` value must have a `concept/<concepts.slug>/introduction.md` file. Linting rules for this file are specified below.
- Each `"concepts"` value must have a `concept/<concepts.slug>/links.json` file. Linting rules for this file are specified below.
- The `"key_features"` key is optional
- The `"key_features"` value must be an array with length = 6
- The `"key_features[].icon"` key is required
- The `"key_features[].icon"` value must be a string that matches one of the pre-defined icon values (TODO: add link to list of icons)
- The `"key_features[].title"` key is required
- The `"key_features[].title"` value must be a non-blank string¹ with length <= 25
- The `"key_features[].content"` key is required
- The `"key_features[].content"` value must be a non-blank string¹ with length <= 100
- The `"tags"` key is required
- The `"tags"` value must be an array of strings
- The `"tags"` values must not have duplicates
- The `"tags"` values must use one of the [pre-defined tag values](../tracks/config-json.md#tags)

### Rule: exercises/concept/&lt;slug&gt;/.meta/config.json is valid

- The file must be valid JSON
- The JSON root must be an object
- The `"blurb"` key is required
- The `"blurb"` value must be a non-blank string¹ with length <= 350
- The `"source"` key is optional
- The `"source"` value must be a non-blank string¹
- The `"source_url"` key is optional
- The `"source_url"` value must be a URL
- The `"authors"` key is required
- The `"authors"` value must be a non-empty array
- The `"authors"` values must be non-blank strings¹
- The `"authors"` values must not have duplicates
- The `"authors"` values are treated case-insensitively
- The `"contributors"` key is optional
- The `"contributors"` value must be an array
- The `"contributors"` values must be non-blank strings¹
- The `"contributors"` values must not have duplicates
- The `"contributors"` values are treated case-insensitively
- Users can only be listed in either the `"authors"` or `"contributors"` array (no overlap)
- The `"files.solution"` key is required
- The `"files.solution"` value must be a non-empty array
- The `"files.solution"` values must not have duplicates
- The `"files.test"` key is required
- The `"files.test"` value must be a non-empty array
- The `"files.test"` values must not have duplicates
- The `"files.exemplar"` key is required
- The `"files.exemplar"` value must be a non-empty array
- The `"files.exemplar"` values must not have duplicates
- The `"files.editor"` key is optional
- The `"files.editor"` value must be an array
- The `"files.editor"` values must not have duplicates
- The files listed in the `"files.solution"` must exist
- The files listed in the `"files.test"` must exist
- The files listed in the `"files.exemplar"` must exist
- The files listed in the `"files.editor"` must exist
- Files can only be listed in either the `"files.solution"`, `"files.test"` or `"files.exemplar` array (no overlap)
- The `"forked_from"` key is optional
- The `"forked_from"` value must be an array
- The `"forked_from"` values must be strings formatted as `<track-slug>/<exercise-slug>` (e.g. `fsharp/bird-watcher`)
- The `"forked_from"` values must refer to actually implemented exercises
- The `"forked_from"` values must not have duplicates
- The `"language_versions"` key is optional
- The `"language_versions"` value must be a string
- The `"icon"` key is optional
- The `"icon"` value must be a kebab-case string²

### Rule: exercises/concept/&lt;slug&gt;/.docs/hints.md is valid

- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- All headings must be either `## General` or `## X. <task>` where `X` matches the task number heading in the `instructions.md`
- All hints must be specified as Markdown list items
- Links must be absolute (relative links are not allowed)

### Rule: exercises/concept/&lt;slug&gt;/.docs/instructions.md is valid

- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- All tasks must start with a level two heading that starts with a number followed by a dot: `## 1. Do X`
- Links must be absolute (relative links are not allowed)

### Rule: exercises/concept/&lt;slug&gt;/.docs/instructions.md.tpl is valid (if present)

- Each [concept placeholders](../tracks/concept-exercises.md#file-docsintroductionmdtpl)'s concept must match the `"concepts.slug"` property of one of the concepts in the track's `config.json`.

### Rule: exercises/concept/&lt;slug&gt;/.docs/introduction.md is valid

- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: exercises/practice/&lt;slug&gt;/.meta/config.json is valid

- The file must be valid JSON
- The JSON root must be an object
- The `"blurb"` key is required
- The `"blurb"` value must be a non-blank string¹ with length <= 350
- The `"source"` key is optional
- The `"source"` value must be a non-blank string¹
- The `"source_url"` key is optional
- The `"source_url"` value must be a URL
- The `"authors"` key is optional
- The `"authors"` value must be an array
- The `"authors"` values must be non-blank strings¹
- The `"authors"` values must not have duplicates
- The `"authors"` values are treated case-insensitively
- The `"contributors"` key is optional
- The `"contributors"` value must be an array
- The `"contributors"` values must be non-blank strings¹
- The `"contributors"` values must not have duplicates
- The `"contributors"` values are treated case-insensitively
- Users can only be listed in either the `"authors"` or `"contributors"` array (no overlap)
- The `"files.solution"` key is required
- The `"files.solution"` value must be a non-empty array
- The `"files.solution"` values must not have duplicates
- The `"files.test"` key is required
- The `"files.test"` value must be a non-empty array
- The `"files.test"` values must not have duplicates
- The `"files.example"` key is required
- The `"files.example"` value must be a non-empty array
- The `"files.example"` values must not have duplicates
- The `"files.editor"` key is optional
- The `"files.editor"` value must be an array
- The `"files.editor"` values must not have duplicates
- The files listed in the `"files.solution"` must exist
- The files listed in the `"files.test"` must exist
- The files listed in the `"files.example"` must exist
- The files listed in the `"files.editor"` must exist
- Files can only be listed in either the `"files.solution"`, `"files.test"` or `"files.example` array (no overlap)
- The `"language_versions"` key is optional
- The `"language_versions"` value must be a string
- The `"test_runner"` key is optional
- The `"test_runner"` value must be a boolean

### Rule: exercises/shared/.docs/debug.md is valid

- The file's presence is optional
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: exercises/shared/.docs/help.md is valid

- The file's presence is required
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: exercises/shared/.docs/tests.md is valid

- The file's presence is required
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: concepts/&lt;slug&gt;/about.md is valid

- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: concepts/&lt;slug&gt;/introduction.md is valid

- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: concept/&lt;slug&gt;/links.json is valid

- The file must be valid JSON
- The JSON root must be an array
- The `"[].url"` property is required
- The `"[].url"` value must be an URL
- The `"[].description"` property is required
- The `"[].description"` value must be a non-blank string¹
- The `"[].icon_url"` property is optional
- The `"[].icon_url"` value must be an URL

### Rule: concept/&lt;slug&gt;/.meta/config.json is valid

- The file must be valid JSON
- The JSON root must be an object
- The `"blurb"` key is required
- The `"blurb"` value must be a non-blank string¹ with length <= 350
- The `"authors"` key is required
- The `"authors"` value must be an array
- The `"authors"` values must be non-blank strings¹
- The `"authors"` values must not have duplicates
- The `"authors"` values are treated case-insensitively
- The `"contributors"` key is optional
- The `"contributors"` value must be an array
- The `"contributors"` values must be non-blank strings¹
- The `"contributors"` values must not have duplicates
- The `"contributors"` values are treated case-insensitively
- Users can only be listed in either the `"authors"` or `"contributors"` array (no overlap)

### Rule: docs/ABOUT.md is valid

- The file's presence is required
- The file's contents must be non-blank
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: docs/INSTALLATION.md is valid

- The file's presence is required
- The file's contents must be non-blank
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: docs/LEARNING.md is valid

- The file's presence is required
- The file's contents must be non-blank
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: docs/RESOURCES.md is valid

- The file's presence is required
- The file's contents must be non-blank
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

### Rule: docs/SNIPPET.txt is valid

- The file's presence is required
- The file's contents must be non-blank

### Rule: docs/TESTS.md is valid

- The file's presence is required
- The file's contents must be non-blank
- The Markdown must conform to the [Markdown standards](../markdown/markdown.md)
- Links must be absolute (relative links are not allowed)

## Glossary

1. Non-blank string: a string that contains at least one non-whitespace character.
2. kebab-case string: a string that contains only characters in the range `[a-z0-9]`, optionally separated by dashes (e.g. "two-fer"). It must match the regular expression: `^[a-z0-9]+(-[a-z0-9]+)*$`
3. Title Case string: a non-blank string that follows the below guidelines (from the Chicago Manual of Style, see https://en.wikipedia.org/wiki/Title_case):
   > - Capitalize the first and last words of titles and subtitles.
   > - Capitalize "major" words (nouns, pronouns, verbs, adjectives, adverbs, and some conjunctions).
   > - Lowercase the conjunctions _and_, _but_, _for_, _or_, and _nor_.
   > - Lowercase the articles _the_, _a_, and _an_.
   > - Lowercase prepositions, regardless of length, except when they are stressed, are used adverbially or adjectivally, or are used as conjunctions.
   > - Lowercase the words _to_ and _as_.
   > - Lowercase the second part of Latin species names.
4. Valid `files` pattern: A non-blank string¹ that specifies a location of a file used in an exercise, relative to the exercise's directory. A pattern may use one of the following placeholders:
- `%{kebab_slug}`: the `kebab-case` exercise slug (e.g. `bit-manipulation`)
- `%{snake_slug}`: the `snake_case` exercise slug (e.g. `bit_manipulation`)
- `%{camel_slug}`: the `camelCase` exercise slug (e.g. `bitManipulation`)
- `%{pascal_slug}`: the `PascalCase` exercise slug (e.g. `BitManipulation`)
5. Unique version 4 UUID string: A string that satisfies all of these conditions:
   - It only exists once in the track-level `config.json` file of a given Exercism track
   - It does not exist in the track-level `config.json` file of any other Exercism track
   - It does not exist in any `canonical-data.json` file in https://github.com/exercism/problem-specifications
   - It matches the regular expression:
   ```
   ^[0-9a-f]{8}-[0-9a-f]{4}-4[0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$
   ```
   For example, the below UUID has the correct form:
   ```
   d334ffe3-657e-4725-a950-290b284b6d9f
   ```
   You can run `configlet uuid` to generate a suitable UUID.
