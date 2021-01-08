# Widgets

To allow rendering widgets for concepts and exercises on Exercism, a special type of Markdown link can be used. Instead of display a link, we'll render a user-contextual widget, that shows that concept or exercise with its icon, user-specific status (unlocked, completed, etc), and which provides a tooltip.

### Concept widget

Link format: `[concept:<track-slug>/<concept-slug>]()`

Example:

```markdown
There are three primary conditional statements that are used in Julia:

- [concept:julia/if-statements]()
- [concept:julia/ternary-operator]()
- [concept:julia/short-circuiting]()
```
