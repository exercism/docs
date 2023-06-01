# Widgets

Concept and Exercise Widgets are regularly used across the site, appearing as follows:

<img src="https://raw.githubusercontent.com/exercism/docs/main/.imgs/concept-widget.png" height="100">
<img src="https://raw.githubusercontent.com/exercism/docs/main/.imgs/exercise-widget.png" height="100">

They additionally feature user-contextual tooltips, such as this:

<img src="https://raw.githubusercontent.com/exercism/docs/main/.imgs/concept-tooltip.png" height="200">

To suggest further reading or beneficial exercises at the end of a document, you might want to render these widgets in your Markdown documents.

Note: Normal links can be used for inline text, with tooltips added accordingly. Please refer to the Internal Linking documentation for more information.

##Usage

Widgets can be deployed wherever Markdown is usable, including documentation, approaches, and student/mentor discussions.

They are rendered using the following format:

```md
[<type>:<track-slug>/<type-slug>]()
```

The link reference (the contents of the parentheses) is disregarded by the website. You can direct them wherever you wish for maintenance purposes.

##Concept Widget

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
