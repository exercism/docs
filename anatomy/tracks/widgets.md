# Widgets

To allow rendering widgets for concepts and exercises on Exercism, a special type of Markdown link can be used. Instead of displaying a link, we'll render a user-contextual widget, that shows that concept or exercise with its icon, user-specific status (unlocked, completed, etc), and which provides a tooltip. 

## Usage

Widgets can be used wherever you can use Markdown, such as documentation, approaches and student/mentor discussions.

The link reference, i.e. the contents of `()`, is ignored by the website. You can point them at whatever you want for maintenance purposes.

### Concept widget

Link format: `[concept:<track-slug>/<concept-slug>]()`

Example:

##### List of concept widgets

This list is in the middle of a file, embedded in prose with further text below it.

```markdown
There are three primary conditional statements that are used in Julia:

- [concept:julia/if-statements]()
- [concept:julia/ternary-operator]()
- [concept:julia/short-circuiting]()

[...]
```

##### Related concepts sections

This is a section with solely buttons at the end of a document.

```markdown
A ternary expression is an alternative to `if` statements.

## Related concepts

- [concept:ruby/if-statements]()
```
### Exercise widget

Link format: `[exercise:<track-slug>/<exercise-slug>]()`

Example:

```markdown
Great job on solving this exercise! Some other exercises that you might also like to try:

- [exercise:fsharp/anagram]()
- [exercise:fsharp/isogram]()
```
