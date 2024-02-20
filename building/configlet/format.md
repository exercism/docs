# Formatting JSON Files

An Exercism track repo has many JSON files, including:

- The track `config.json` file.

- For each concept, a `.meta/config.json` and `links.json` file.

- For each Concept Exercise or Practice Exercise, a `.meta/config.json` file.

These files are more readable if they have a consistent formatting Exercism-wide, and so configlet has a `fmt` command for rewriting a track's JSON files in a canonical form.

The `fmt` command currently operates on the exercise `.meta/config.json` files and the track `config.json` file, but it is likely to operate on all the track JSON files in the future.

## Usage

The `fmt` command formats the exercise 'meta/config.json' files.

```
configlet [global-options] fmt [command-options]

Global options:
  -h, --help                   Show this help message and exit
      --version                Show this tool's version information and exit
  -t, --track-dir <dir>        Specify a track directory to use instead of the current directory
  -v, --verbosity <verbosity>  The verbosity of output. Allowed values: q[uiet], n[ormal], d[etailed]

Options for fmt:
  -e, --exercise <slug>        Only operate on this exercise
  -u, --update                 Prompt to write formatted files
  -y, --yes                    Auto-confirm the prompt from --update
```

A plain `configlet fmt` makes no changes to the track and checks the formatting of the `.meta/config.json` file for every Concept Exercise and Practice Exercise and the track `config.json` file.

To print a list of paths for which there is not already a formatted exercise `.meta/config.json` file (exiting with a non-zero exit code if at least one exercise lacks a formatted config file):

```shell
configlet fmt
```

To be prompted to write formatted config files, add the `--update` option (or `-u` for short):

```shell
configlet fmt --update
```

To non-interactively write the formatted config files, add the `--yes` option (or `-y` for short):

```shell
configlet fmt --update --yes
```

To operate on a single exercise, use the `--exercise` option (or `-e` for short).
For example, to non-interactively write the formatted config file for the `prime-factors` exercise:

```shell
configlet fmt -uy -e prime-factors
```

When writing JSON files, `configlet fmt` will:

- Write the key/value pairs in the canonical order.

- Use two spaces for indentation.

- Use a separate line for each item in a JSON array, and each key in a JSON object.

- Remove key/value pairs for keys that are optional and have empty values.
  For example, `"source": ""` is removed.

- Remove `"test_runner": true` from Practice Exercise config files.
  This is an optional key - the spec says that an omitted `test_runner` key implies the value `true`.

- When a JSON object has more than one key/value pair with some key name, keep only the final one.

The canonical key order for an exercise `.meta/config.json` file is:

```text
- authors
- [contributors]
- files
  - solution
  - test
  - exemplar           (Concept Exercises only)
  - example            (Practice Exercises only)
  - [editor]
  - [invalidator]
- [language_versions]
- [forked_from]        (Concept Exercises only)
- [icon]               (Concept Exercises only)
- [test_runner]        (Practice Exercises only)
- blurb
- [source]
- [source_url]
- [custom]
```

where the square brackets indicate that the enclosed key is optional.

Note that `configlet fmt` only operates on exercises that exist in the track-level `config.json` file.
Therefore if you are implementing a new exercise on a track and want to format its `.meta/config.json` file, please add the exercise to the track-level `config.json` file first.
If the exercise is not yet ready to be user-facing, please set its `status` value to `wip`.

The exit code is 0 when every seen config file is formatted when configlet exits, and 1 otherwise.
