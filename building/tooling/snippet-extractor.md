# Snippet Extractor

The [Snippet Extractor][snippet-extractor] takes a student's submission and extracts the first ten "interesting" lines of code from it.
The extracted snippet is shown on various pages on the website.

By default, the first ten lines are shown, ignoring leading empty lines.
These first ten lines _could_ include things like comments, which are usually not ideal to be presented in a snippet.

## Customizing snippet extraction

We recommend each track [customizes snippet extraction][snippet-extractor-customize] to at least remove comments from the source code.
To customize snippet extraction, you'll need to:

1. Add a `lib/languages/<track_slug>.txt` file which configures snippet extraction.
   This file can use either [basic mode][basic-mode] or [extended mode][extended-mode].
   Most tracks use extended mode, as it gives more flexibility.
2. Add one or more test cases to a `tests/<track_slug>/<test_slug>` directory.
   Each test directory will need two files:

   1. `tests/<track_slug>/<test_slug>/code.<track_extension>`: the code to run the snippet extractor on
   2. `tests/<track_slug>/<test_slug>/expected_snippet.<track_extension>`: the expected snippet

See [this example pull request][example-pr] that customizes snippet extraction for the Arturo language.

[snippet-extractor]: https://github.com/exercism/snippet-extractor/
[snippet-extractor-customize]: https://github.com/exercism/snippet-extractor/?tab=readme-ov-file#customizing-snippet-extraction
[example-pr]: https://github.com/exercism/snippet-extractor/pull/94
[basic-mode]: https://github.com/exercism/snippet-extractor/blob/main/docs/basic.md
[extended-mode]: https://github.com/exercism/snippet-extractor/blob/main/docs/extended.md
