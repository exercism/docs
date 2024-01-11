# Markdown Specification

The following is the way that all Markdown files within Exercism should be structured.

Some of the rules in this document are not yet implemented across all of Exercism.
We welcome PRs to fix them.
All rules are being added to our CI and linting tools, and should be adhered to for new changes.

## Headings

- All files must start start with a level-1 heading (`# Some heading text`).
- Level-1 headings exist purely for consuming on GitHub or equivalent.
- If the file is rendered by Exercism (e.g. displayed on the website, rendered via the CLI), this heading will be removed, and a contextual heading will be inserted.
- No heading may descend a level greater than one below the previous (e.g. `##` may only be followed by `###`, not `####`).
- Beyond the single level-1 (`#`) heading, only level-2 (`##`), level-3 (`###`) and level-4 (`####`) headings may be used.

## Links

Please use [reference links][reference-links], which are defined at the bottom of the Markdown file, mapped to a reference slug, and referenced by that slug in the text.

This method makes maintenance easier, since link(s) only have to be updated in a single location.

Example:

```
I have a paragraph of text that links to the same page twice.

The [first link][indirect-reference] in one sentence.

Then, another sentence with the [link repeated][indirect-reference].

[indirect-reference]: https://example.com/link-to-page
```

Links should always have anchor text, instead of putting the URL itself into the text. For example, the following does not use anchor text, and is harder to read.

```
If you want some more information, please visit https://google.com.
```

Using anchor text and linking it is easier to understand and contextualize.

```
If you want some more information, [Google][google-link] is a useful resource.

[google-link]: https://google.com
```

Which renders as, "If you want some more information, [Google][google-link]".

## Code

Whenever one refers to code elements (e.g. functions or keywords), the code should be wrapped in backticks:

```
- The `printf()` function writes to the console.
```

Which renders as:

- The `printf()` function writes to the console.

More complex code (e.g. multiline code) should be wrapped in triple backticks. A [language identifier][language-identifier] should be specified after the opening triple backticks to enable syntax highlighting:

````python
```python
# Define a variable
album = "Abbey Road"
```
````

When possible, format code in a way that is most relevant to the environment it is being presented in. If available, please reference the docs for your language.

For example, Python has the REPL (read-eval-print loop), which allows a programmer to type code directly into a terminal. If a user was debugging some code, or running a function locally to test/observe how it works, they are more likely to use a REPL to do so, since it is more convenient to type interactively there. In this situation, we prefer formatting example code as if it was being typed into the REPL, with a leading `>>>`:

```python
# This is the expected output a student would see while testing a function they wrote.
>>> print(extract_message("[INFO] Logline message"))
'Logline message'
```

In other cases, it makes more sense to leave code formatted as if it was in a `.py` file. Here, the student benefits by being presented with something that mimics how they would write the code themselves.

```python
# presenting how functions are defined in Python:
def sample_func(argument1):
    pass
```

A quick way to distinguish between the two cases when it's unclear - if this is code the student can run in a terminal, format it that way. If it's code that Exercism might run (in tests, library code the student will write, etc), default to formatting it as runnable code.

## Special blocks (sometimes called admonitions)

We support special types of blocks that can be added to documents to pull out commentary that doesn't fit with the main body of the text.

<img width="500" alt="Markdown note block" src="https://user-images.githubusercontent.com/20866761/139531109-0c0f3ea5-b589-44ff-93ab-d901a45edc56.png">

<img width="500" alt="Markdown caution block" src="https://user-images.githubusercontent.com/20866761/139531234-9b58b9ab-524b-44fd-bbcb-4e10f2927d27.png">

<img width="500" alt="Markdown advanced block" src="https://user-images.githubusercontent.com/20866761/139531236-72259046-68a9-4934-9440-a730befde155.png">

We support three types of blocks:

- **exercism/note:** Blocks that pull out some extra special information
- **exercism/caution:** Things that people should know about or tread carefully with
- **exercism/advanced:** Information that is only relevant for people who want to dig more deeply into something or are expected to have more advanced knowledge.

All blocks are written using 4 tildes, in the form of:

````
~~~~exercism/note
Content goes here

You can include code:
```ruby
str = "Hello, World"
```
~~~~
````

(Note: You may also use backticks or other levels of tildes in exceptional circumstances)

## Layout

### One sentence per line

Paragraphs should be laid at using one sentence per line. The [Ascii Doctor docs][asciidoctor] explain the logic of this clearly.

For example, a single paragraph should be laid out as follows:

```
Exercism has been designed, engineered and built by thousands of very talented individuals.
Nearly everything with Exercism has been debated, discussed and rewritten many times.
Exercism is a very intentional product - things are there because they've been designed to be there, and things are often left out because they've been designed to be left out.
```

## Lists

Use the hyphen character (`-`) as the bullet list marker for unordered lists.

## Comments

- Prefer Markdown comments instead of HTML comments (e.g. use `[comment]: # (Actual comment...)` rather than `<!-- Actual comment -->`

You can test that your markdown comment gets removed by checking how your comment looks when rendered via commonmark at [babelmark3].

## Inline HTML

- Inline HTML is allowed, but should be used sparingly
- Always use native markdown alternatives if available (e.g. use `# ...` rather than `<h1>...</h1>`)

## Images

As the website supports light and dark themes, community-submitted images must render well in both themes.
The solution to this is to suffix your image name (before the file extension):

1. Have the image name end in `-invertible` (e.g. `graph-invertible.svg`). The image will automatically be inverted when shown in the dark theme (via `filter: invert(100%)`).
1. Have the image name end in `-light` (e.g. `graph-light.png`) and also create dark-theme compatible version that ends in `-dark` (which would be `graph-dark.png`). We'll automatically render the correct image depending on the user's theme.

Images with neither suffix will be used without modifications across both themes.
This means that if you want to create grayscale images, you can generally make them look good on light theme, and then set them to be invertible.
But if you’re using an image with lots of colours, you might like to make two variants.

The full image name (including `-invertible`) should be added to the markdown where the image is rendered.
For light/dark ones, **ONLY** include the `-light` variant.
This logic is honoured across all markdown docs.

## Linters

There are various rules you can use to configure linters to meet this spec:

- [MD001][md001]: Enable
- [MD002][md002]: Enable
- [MD003][md003]: Use `atx` style
- [MD004][md004]: Use `dash` style
- [MD013][md013]: Disable
- [MD033][md033]: Disable

## Auto formatting

Some repositories use [prettier][prettier] to ensure that all Markdown is formatted consistently. This can result in the following benefits:

- No formatting discussions.
- Great editor/IDE integration so files can be formatted on save.
- Easy to add CI checks for formatting.
- Easy to automatically format files using a script.

All the above can greatly help reduce churn in reviews, which is frustrating for both the reviewer and the reviewee.

---

[md001]: https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md002---header-levels-should-only-increment-by-one-level-at-a-time
[md002]: https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md002---first-header-should-be-a-top-level-header
[md003]: https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md003---header-style
[md004]: https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md004---unordered-list-style
[md013]: https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md013---line-length
[md033]: https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md033---inline-html
[asciidoctor]: https://asciidoctor.org/docs/asciidoc-recommended-practices/#one-sentence-per-line
[babelmark3]: https://babelmark.github.io
[google-link]: https://google.com
[language-identifier]: https://github.com/github/linguist/blob/master/lib/linguist/languages.yml
[prettier]: https://prettier.io/
[reference-links]: https://spec.commonmark.org/0.29/#reference-link
