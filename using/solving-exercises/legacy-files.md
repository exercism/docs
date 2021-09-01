# Legacy Files

```exercism/note
If you're seeing this on Elixir or Elm after starting using v3, is is most likely because those tracks have changed their file structures.
See the sections at the bottom of this document for how to deal with this change.
```

## What are Legacy Files?

If you're using the Exercism online editor, you might sometimes come across a warning about legacy files.
There are two reasons you might see this.

### Files incorrectly uploaded in the CLI

When you're using the CLI, you can upload any files you choose.
However, the online editor only allows you to edit files it knows about.
So if you upload a file that the editor doesn't know about, it won't let you edit it, and will show you a warning in case you want to delete it.

### Files due to exercises changing

Sometimes the structure of exercises changes.
Files might get renamed, or whole exercise structures might change.
While we try to avoid this, sometimes it is pragmatically the right decision.
For example, a track might change its build system, as Elixir did when moving from `exs` to `ex` files.
Or the normal directory structure within a language might change, as happened with Elm when they moved everything into subdirectories.

In these situations we can't automatically move the files for you, so there's some manual work for you to do.
In the editor you'll see the old solution file(s) (with a legacy banner), and the stub of the new soltion file.
Copy your work from the old file to the new one, and tweak any code that needs changing.
Once the tests are passing you can delete your old solution file, and forget any of this ever happened 🙂

## Deleting legacy files

When you delete a legacy file it does **not** affect previous iterations.
That file will still exist within those iterations.
Deleting a file simply removes it from the **next** iteration that you submit via the editor.

## Changes to Track structures

### Elixir

In July 2019, Elixir changed its exercise structure from using Elixir scripts (`*.exs` files) to a complete [Mix project](https://elixir-lang.org/getting-started/mix-otp/introduction-to-mix.html) for each exercise.
In order to use the features of v3, copy your solution to the stub file located at `lib/<exercise_stub>.ex`.
You don't need to move the test file, the updated version will already be present in the correct location.

### Elm

At the launch of v3, Elm changed its exercises.
