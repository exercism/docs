# Snippet Extractor

The [Snippet Extractor][snippet-extractor] takes a student's submission and extracts the first ten "interesting" lines of code from it.
The extracted snippet is shown on various pages on the website.

By default, the first ten lines are shown, ignore leading empty lines.
These first ten lines _could_ include things like comments, which are usually not ideal to be presented in a snippet.
Each track can [customize the snippet extraction][snippet-extractor-customize], for example to remove said comments.

[snippet-extractor]: https://github.com/exercism/snippet-extractor/
[snippet-extractor-customize]: https://github.com/exercism/snippet-extractor/#add-your-language
