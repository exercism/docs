# Markdown Specification

The following is the way that all Markdown files within Exercism should be structured.

Some of the rules in this document are not yet implemented across all of Exercism. 
We welcome PRs to fix them.
All rules are being added to our CI and linting tools, and should be adhered to for new changes.

## Headings

- All files must start start with a level-1 heading (`# Some heading text`).
- Level-1 headings exist purely for consuming on GitHub or equivalent.
- If the file is rendered by Exercism (e.g. displayed on the website, rendered via the CLI), this heading will be removed, and a contextual heading will be inserted.
- No heading may decend a level greater than one below the previous (e.g. `##` may only be followed by `###`, not `####`).
- Beyond the single level-1 (`#`) heading, only level-2 (`##`), level-3 (`###`) and level-4 (`####`) headings may be used.

## Layout

### One sentence per line

Paragraphs should be laid at using one sentence per line. The [Ascii Doctor docs][asciidoctor] explain the logic of this clearly.

For example, a single paragraph should be laid out as follows:
```
Exercism has been designed, engineered and built by thousands of very talented individuals.
Nearly everything with Exercism has been debated, discussed and rewritten many times.
Exercism is a very intentional product - things are there because they've been designed to be there, and things are often left out because they've been designed to be left out.
```

## Inline HTML

- Inline HTML is allowed, but should be used sparingly
- Always use native markdown alternatives if available (e.g. use `# ...` rather than `<h1>...</h1>`)

## Linters

There are various rules you can use to configure linters to meet this spec:
- Enable [MD001](https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md001---header-levels-should-only-increment-by-one-level-at-a-time)
- Enable [MD002](https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md002---first-header-should-be-a-top-level-header)
- Use `atx` for [MD003](https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md003---header-style)
- Disable [MD013](https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md013---line-length)
- Disable [MD033](https://github.com/markdownlint/markdownlint/blob/master/docs/RULES.md#md033---inline-html)

---

[asciidoctor]: https://asciidoctor.org/docs/asciidoc-recommended-practices/#one-sentence-per-line