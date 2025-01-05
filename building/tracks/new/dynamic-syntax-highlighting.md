# Dynamic syntax highlighting

Dynamic syntax highlighting is highlighting of code that the user can change.
There is only one place where this happens, and that is the online editor.

```exercism/note
Code snippets, iterations, and the like are _static_ as the user can't change their code on the fly.
If you'd like to know more of how we handle static syntax highlighting, check the [static syntax highlighting docs](/docs/building/tracks/new/syntax-highlighting/static).
```

## Implementation

Dynamic syntax highlighting is done using the [CodeMirror library](https://codemirror.net/).

When adding support for your language, there are three options:

1. The language is supported _out of the box_ by CodeMirror (i.e. listed as a [supported language](https://codemirror.net/5/mode/)).
   If so, continue to the [Enable language](#enable-language) section.
2. The language is supported via an existing CodeMirror plugin.
   If so, continue to the [Using an existing plugin](#using-an-existing-plugin) section.
3. The language is _not_ supported.
   There are now three options:
   1. Write a CodeMirror plugin from scratch, as described in the [Create a new plugin](#create-a-new-plugin) section.
   2. Your language's syntax (closely) resembles another language's syntax (e.g. Unison's syntax resembles Haskell), in which case you could consider using the syntax highlighting of that language for your language.
      See the [Enable language](#enable-language) section for more information.
   3. Don't have dynamic syntax highlighting.

### Enable language

To enable CodeMirror support for your language, start a topic on [the forum](https://forum.exercism.org/c/exercism/building-exercism/125).
We (Exercism) will then create a Pull Request that enables CodeMirror support for your language on the website.

### Using an existing plugin

To use an existing plugin, it needs to be published on [NPM](https://www.npmjs.com/).

If the plugin isn't published on NPM, you can either:

1. Ask the plugin author if they want to publish on NPM.
2. Fork the repository and publish it yourself.
3. Have us (Exercism) fork the repository and we publish it.
   To do so, open a topic on [the forum](https://forum.exercism.org/c/exercism/building-exercism/125) requesting this.

```exercism/note
The CodeMirror website has a [list of community-built language plugins](https://codemirror.net/docs/community/#language).
```

The next step is to [Enable language](#enable-language).

### Create a new plugin

These are the steps to get going:

1. Check [our repository list for an existing `codemirror-lang-...`](https://github.com/search?q=org%3Acodemirror-lang&type=repositories) to ensure that one doesn't already exist.
2. Start a new topic on [the Exercism forum][building-exercism] telling us which language you'd like to create a CodeMirror plugin for.
3. Once a CodeMirror plugin repo has been created for you, implement the grammar for your track.

```exercism/note
To help you get started, the repo created for you contains a minimal sample grammar that you can build on/tweak.
```

We have an incredibly friendly and supportive community who will be happy to help you as you work through this!
If you get stuck, please start a new topic on [the Exercism forum][building-exercism] or create new issues at [exercism/exercism][exercism-repo] as needed 🙂

You'll then need to publish the plugin on [NPM](https://www.npmjs.com/).
The next step is to [Enable the language](#enable-language).

### Use a different language

Your language's syntax (closely) resembles another language's syntax, in which case you could consider using the syntax highlighting of that language for your language.
To do so, configure the track using the other language's CodeMirror plugin.
See the [Enable language](#enable-language) section for more information.

[building-exercism]: https://forum.exercism.org/c/exercism/building-exercism/125
[exercism-repo]: https://github.com/exercism/exercism
