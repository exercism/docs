# Widgets

Concept and Exercise Widgets are used frequently throughout the site.
They look like this:

<img src="https://raw.githubusercontent.com/exercism/docs/main/.imgs/concept-widget.png" height="100">
<img src="https://raw.githubusercontent.com/exercism/docs/main/.imgs/exercise-widget.png" height="100">

They also have user-contextual tooltips such as this:

<img src="https://raw.githubusercontent.com/exercism/docs/main/.imgs/concept-tooltip.png" height="200">

You may like to render these widgets yourself in Markdown documents, for example at the end of a document to suggest extra reading or good exercises to learn something from.

**Note:** You can also use normal links for inline text, which will have the tooltips added. See [the Internal Linking documentation](/docs/building/markdown/internal-linking) for more details.

## Usage

Widgets can be used wherever you can use Markdown, such as documentation, approaches and student/mentor discussions.

They are rendered using the following format

```md
[<type>:<track-slug>/<type-slug>]()
```

The link reference, i.e. the contents of `()`, is ignored by the website. You can point them at whatever you want for maintenance purposes.

## Concept widget

Link format: `[concept:<track-slug>/<concept-slug>]()`

### Example: list

```markdown
There are three primary conditional statements that are used in Julia:

- [concept:julia/if-statements]()
- [concept:julia/ternary-operator]()
- [concept:julia/short-circuiting]()
```

## Exercise widget

Link format: `[exercise:<track-slug>/<exercise-slug>]()`

### Example: list

```markdown
Great job on solving this exercise! Some other exercises that you might also like to try:

- [exercise:fsharp/anagram]()
- [exercise:fsharp/isogram]()
```
