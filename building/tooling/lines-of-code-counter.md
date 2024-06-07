# Lines of Code Counter

The Lines of Code (LoC) Counter takes a solution and counts its lines of code.

By default, only the LoC of files submitted by the student are counted.
If the student submitted a test file, those will be ignored.

While this works well for most submissions, some tracks might need to ignore additional files.
For that, we'll allow the Lines of Code Counter to be [customized per track][lines-of-code-counter-customize].

## Implementation

We're using the [tokei][tokei] library to do the actual counting.
As pull requests are often not merged quickly, we've created our own [fork][tokei-fork].
This allows us to iterate more quickly and add support for any language we want.

## Supported languages

You can check to see if your language is supported out of the box by looking it up in the [languages.json][languages.json] file.

### Adding new language

If your language is **not** supported, you can add support by:

1. Adding an entry for your language to the [languages.json] file.
   Check the [language addition docs][adding-language] for more information.
2. Adding tests to verify counting works correctly for your language.
   Check the [adding tests docs][adding-tests] for more information.

Once you've made these changes, open a pull request to the [exercism/tokei repository][tokei-fork].
Here is an [example pull request][example-pr] that adds support for the Arturo language.

[lines-of-code-counter]: https://github.com/exercism/lines-of-code-counter/
[lines-of-code-counter-customize]: https://github.com/exercism/lines-of-code-counter/#ignore-additional-files
[languages.json]: https://github.com/exercism/tokei/blob/master/languages.json
[tokei]: https://github.com/XAMPPRocky/tokei
[tokei-fork]: https://github.com/exercism/tokei
[example-pr]: https://github.com/exercism/tokei/pull/14/files
[adding-language]: https://github.com/exercism/tokei/blob/master/CONTRIBUTING.md#language-addition
[adding-tests]: https://github.com/exercism/tokei/blob/master/CONTRIBUTING.md#tests
