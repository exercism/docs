# Markdown Specification

The following is the way that all Markdown files within Exercism should be structured.

Some of the rules in this document are not yet implemented across all of Exercism. 
We welcome PRs to fix them.
All rules are being added to our CI and linting tools, and should be adhered to for new changes.

## Headings
- All files must start start with a level-1 heading (`# Some heading text`). 
- Level-1 headings exist purely for consuming on GitHub or equivalent.
- If the file is rendered on by the Exercism (e.g. displayed on the website, rendered via the CLI), this heading will be removed, and a contextual heading will be inserted.
- No heading may decend a level greater than one below the previous (e.g. `##` may only be followed by `###`, not `####`)
- Beyond the single level-1 (`#`) heading, only level-2 (`##`), level-3 (`###`) and level-4 (`####`) headings may be used.

## Layout

### One sentence per line

Paragraphs should be laid at using one sentence per line. The [Ascii Doctor docs][asiidoctor] explain the logic of this clearly.

For example, a single paragraph should be laid out as follows:
```
Exercism has been designed, engineered and built by thousands of very talented individuals.
Nearly everything with Exercism has been debated, discussed and rewritten many times.
Exercism is a very intentional product - things are there because they've been designed to be there, and things are often left out because they've been designed to be left out.
```

[asiidoctor]: https://asciidoctor.org/docs/asciidoc-recommended-practices/#one-sentence-per-line
