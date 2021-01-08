# Widgets

To allow rendering widgets for concepts and exercises on Exercism, a special type of Markdown link can be used. Instead of displaying a link, we'll render a user-contextual widget, that shows that concept or exercise with its icon, user-specific status (unlocked, completed, etc), and which provides a tooltip. 

## Usage

Widgets can be used wherever you can use Markdown, such as documentation, approaches and student/mentor discussions.

The link reference, i.e. the contents of `()`, is ignored by the website. You can point them at whatever you want for maintenance purposes.

### Concept widget

Link format: `[concept:<track-slug>/<concept-slug>]()`

Example:

```markdown
There are three primary conditional statements that are used in Julia:

- [concept:julia/if-statements]()
- [concept:julia/ternary-operator]()
- [concept:julia/short-circuiting]()
```

### Exercise widget

Link format: `[exercise:<track-slug>/<exercise-slug>]()`

Example:

```markdown
Great job on solving this exercise! Some other exercises that you might also like to try:

- [exercise:fsharp/anagram]()
- [exercise:fsharp/isogram]()
```
