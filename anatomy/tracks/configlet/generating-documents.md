# Configlet generating documents

The secondary use of [configlet](./README.md) is generating documents.

## Usage

TODO: describe the command-line interface (command + options).

## Documents

These are the documents that configlet can generate.

### Document: Concept Exercise's introduction.md file

Each [Concept Exercise](../concept-exercises.md) has an [`introduction.md` file](../concept-exercises.md#docsintroductionmd). Each exercise can have an optional [`introduction.md.tpl` file](../concept-exercises.md#docsintroductionmdtploptional).

The template file should be treated like a regular Markdown file but with one addition: the ability to specify placeholders. The following placeholders are supported:

- `%{concept:<slug>}`: refers to the concept's [`introduction.md` document](../concepts.md#fileintroductionmd)

When configlet detects that an exercise has an `introduction.md.tpl` file, it will generate a `introduction.md` file from it. The generated introduction will have the same contents as the template, expect for the placeholders, which will be replaced with the contents of the documents they refer to.

### Document: Practice Exercise's README.md file

TODO: document how generating the README.md file works
