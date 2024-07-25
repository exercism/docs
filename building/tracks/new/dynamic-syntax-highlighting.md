# Dynamic syntax highlighting

There are two types of syntax highlighting of code on the website:

1. Syntax highlighting of _static_ code (code snippets, iterations, and such)
2. Syntax highlighting of _dynamic_ code (the online editor)

Both types of syntax highlighting use different libraries.

## Static code

Static code (like code snippets, iterations and such) is rendered using the [highlightjs library](https://highlightjs.org/).

When adding support for your language, there are three options:

1. The language is supported _out of the box_ (i.e. listed as a [supported language](https://github.com/highlightjs/highlight.js/blob/main/SUPPORTED_LANGUAGES.md)).
   If so, continue to the [Configuring track](#configuring-track) section.
2. The language is supported via an existing plugin.
   If so, continue to the [Using an existing plugin](#using-an-existing-plugin) section.
3. The language is _not_ supported.
   There are now two options:
   1. Write a highlightjs plugin from scratch, as described in the [Create a new plugin](#create-a-new-plugin) section.
   1. Write a highlightjs plugin from scratch, as described in the [Create a new plugin](#create-a-new-plugin) section.

### Configuring track

To enable highlightjs support for your track's language, you'll need to modify the track's [config.json file](/docs/building/tracks/config-json).
Within the `config.json` file, add/set the `online_editor.highlightjs_language` key to the appropriate highlightjs language identifier (which can be found in the documentation).

#### Example

```json
{
  "online_editor": {
    "highlightjs_language": "csharp"
  }
}
```

### Using an existing plugin

To use an existing plugin, it needs to be published on [NPM](https://www.npmjs.com/).

If the plugin isn't published on NPM, you can either:

1. Ask the plugin author if they want to publish on NPM.
2. Fork the repository and publish it yourself.
3. Have us (Exercism) fork the repository and we publish it.
   To do so, open a topic on the forum requesting this (https://forum.exercism.org/c/exercism/building-exercism/125).

The next step is to [Enable the plugin](#enable-plugin).

### Enable plugin

To enable a plugin (which must be published on [NPM](https://www.npmjs.com/)), start a topic on the forum requesting us to add support for the plugin to the website (https://forum.exercism.org/c/exercism/building-exercism/125).
We (Exercism) will then create a Pull Request that adds the plugin to the website.
Once the PR is merged, you can enable highlightjs support by following the instructions in the [Configuring track](#configuring-track) section.

### Create a new plugin

If you'd like to create plugin, you have two options for hosting:

1. Create a repository on your personal account and publish it yourself.
2. Have us (Exercism) create a repository and let us publish it.
   To do so, open a topic on the forum requesting this (https://forum.exercism.org/c/exercism/building-exercism/125).

Once you have a repo, follow the [language contribution instructions](https://highlightjs.readthedocs.io/en/latest/language-contribution.html) to implement the plugin.

You'll then need to publish the plugin on [NPM](https://www.npmjs.com/).
The next step is to [Enable the plugin](#enable-plugin).

### Use a different language

If

## Dynamic code

```

```
