# Exercism CLI

The [Exercism CLI][cli] lets students download exercises and submit solutions to the site.
It also supports the `exercism test` command, which then runs the track-specific command to run the tests.

## Adding new language

The track-specific test commands are defined in a [configuration file][test-configurations].
You can add support for your language by adding an entry to that [configuration file][test-configurations], where the key is the track's slug.

### Test command placeholders

There are three placeholders that can be used in the track-specific command:

- `{{test_files}}`: a space-separated list of the test files (as found in the `.files.test` key in the exercise's `.meta/config.json` file)
- `{{solution_files}}`: a space-separated list of the solution files (as found in the `.files.solution` key in the exercise's `.meta/config.json` file)
- `{{slug}}`: the exercise slug (as found in the exercise's `slug` key in the tracks's root `config.json` file)

Here is an [example pull request][example-pr] that adds support for the Arturo language.

[cli]: https://github.com/exercism/cli
[example-pr]: https://github.com/exercism/cli/pull/1147/files
[test-configurations]: https://github.com/exercism/cli/blob/main/workspace/test_configurations.go#L63
