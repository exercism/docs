# Prepare for launch

Before you are ready to launch your track, please ensure that the following tasks have been completed.

## Request track icon

In order to design an icon for the site, open a new issue in the [exercism/website-icons](https://github.com/exercism/website-icons/issues) repository, answering the following questions:

- Does the language have an official logo? If so
  - please include a link to an example
  - please list the attribution requirements, and rights given for use of that logo
- Does the language have an unofficial logo? If so
  - please explain the ways in which people use the unofficial logo
  - please include a link to an example
  - please list the attribution requirements of that logo

## Add track docs

Add the following track documents:

- `docs/ABOUT.md`: a short introduction to the language.
- `docs/INSTALLATION.md`: describe what the student needs to install to allow working on the track on their local system using the CLI.
- `docs/LEARNING.md`: links to learning resources.
- `docs/RESOURCES.md`: links to useful resources.
- `docs/TESTS.md`: describe everything related to running tests in the track.

These documents will help the student get started with the track as well as learn about the track and its language.
See the [docs documentation](/docs/building/tracks/docs) for more information.

## Add exercise docs

Add the following exercise documents:

- `exercises/shared/.docs/help.md`: contains track-specific instructions on how to get help
- `exercises/shared/.docs/tests.md`: contains track-specific instructions on how to run the tests

## Add code snippet

Add a code snippet to the `docs/SNIPPET.txt` file.
This snippet gives a visual impression of what the language syntax looks like.
See the [docs documentation](/docs/building/tracks/docs) for more information.

## Update metadata

The track's metadata is defined in the [config.json file](/docs/building/tracks/config-json).
The following properties should be updated:

- `language`: the track's language (e.g. `"C#"`). Its length must be <= 255
- `slug`: the track's language as a lowercased, kebab-case string (e.g. `"csharp"`). Its length must be <= 255
- `blurb`: a short description of the language. Its length must be <= 400
- `online_editor`: an object describing settings used for the online editor:
  - `indent_style`: either `"space"` or `"tab"`
  - `indent_size`: the indentation size as an integer (e.g. `4`)
  - `highlightjs_language`: the language identifier for Highlight.js (see the [full list of identifiers](https://github.com/highlightjs/highlight.js/blob/main/SUPPORTED_LANGUAGES.md)). If there is no Highlight.js support, this field can be omitted.
- `key_features`: the language's key features, which succinctly describe its most important features. For more information, check the [key features documentation](/docs/building/tracks/config-json#h-key-features).
- `tags`: define the tags that apply to this track, which allows it be searched for on the website. For more information and the list of supported tags, check the [tags documentation](/docs/building/tracks/config-json#h-tags).
