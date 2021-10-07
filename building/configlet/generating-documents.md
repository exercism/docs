# Configlet generating documents

The secondary use of [configlet](/docs/building/configlet) is generating documents.

## Documents

These are the documents that configlet can generate.

### Document: Concept Exercise's introduction.md file

Each [Concept Exercise](/docs/building/tracks/concept-exercises) has an [`introduction.md` file](/docs/building/tracks/concept-exercises#docsintroductionmd). Each exercise can have an optional [`introduction.md.tpl` file](/docs/building/tracks/concept-exercises#docsintroductionmdtploptional).

The template file should be treated like a regular Markdown file but with one addition: the ability to specify placeholders. The following placeholders are supported:

- `%{concept:<slug>}`: refers to the concept's [`introduction.md` document](/docs/building/tracks/concepts#fileintroductionmd)

When configlet detects that a Concept Exercise has an `introduction.md.tpl` file, it will generate a `introduction.md` file from it. The generated introduction will have the same contents as the template, expect for the placeholders, which will be replaced with the contents of the documents they refer to.

### Document: Practice Exercise's introduction.md file

When configlet detects that a Practice Exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/) that has an `introduction.md` file, configlet will sync the Practice Exercise's `.meta/introduction.md` file with the Problem Specification Exercise's `introduction.md` file.

### Document: Practice Exercise's instructions.md file

When configlet detects that a Practice Exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/), configlet will sync the Practice Exercise's `.meta/instructions.md` file with either the Problem Specifications Exercise's `instructions.md` file or its `description.md` file when no `instructions.md` file was found.

### Document: Practice Exercise's .meta/config.json file

When configlet detects that a Practice Exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/), configlet will sync the Problem Specification Exercise's `source` and `source_url` keys from its `metadata.yml` file to the Practice Exercise's `source` and `source_url` properties in its `.meta/config.json` file.
