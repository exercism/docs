# The Analyzer Interface

All interactions with the Exercism website are handled automatically. Analyzers have the single responsibility of taking a solution and returning a status and any messages.

## Execution

- An Analyzer should provide an executable script. You can find more information in the [docker.md](/docs/building/tooling/analyzers/docker) file.
- The script will receive three parameters:
  - The slug of the exercise (e.g. `two-fer`).
  - A path to a directory containing the submitted file(s) (with a trailing slash).
  - A path to an output directory (with a trailing slash). This directory is writable.
- The script must write an `analysis.json` file to the output directory.
- The script should write a `tags.json` file to the output directory.

### Allowed run time

The analyzer gets 100% machine resources for a 20 second window per solution.
After 20 seconds, the process is halted and reports a time-out.

```exercism/note
We highly recommend following our [Performance Best Practices document](/docs/building/tooling/best-practices#h-performance) to reduce the chance of timeouts.
```

## Output format

### analysis.json

The `analysis.json` file should be structured as followed:

```json
{
  "summary": "This solution looks good but has a few points to address",
  "comments": [
    {
      "comment": "ruby.general.some_parameterised_message",
      "params": { "foo": "param1", "bar": "param2" },
      "type": "essential"
    },
    {
      "comment": "ruby.general.some_unparameterised_message",
      "params": {},
      "type": "actionable"
    },
    {
      "comment": "ruby.general.some_unparameterised_message"
    },
    "ruby.general.some_unparameterised_message"
  ]
}
```

#### `summary` (optional)

The `summary` field is a text (not markdown) field that summarizes the output.
It might say something like "Your solution is nearly there - there's just two small changes you can make." or "The code works great, but there's a little bit of linting that needs doing.".
This summary is rendered on the website above the comments.

#### `comments`

The `comments` field is an array of comments that link to Markdown documents in the [`exercism/website-copy`][website-copy-repo] (see [Writing Analyzer comments][writing-analyzer-comments] for more information).
Each value in the array is either a pointer-string or a JSON object with the following format:

##### `comment`

The pointer-string to a file in `website-copy`.

##### `params` (optional)

A JSON Object containing any params that should be interpolated during rendering.
For example, in the markdown file, you could write `Try %{variable_name} += 1 instead`, and then set `params` to `{ "variable_name": "foo"}` in order to substitute `%{variable_name}` for the actual variable that the student used.

When using parameterized files, ensure to escape all uses of `%` by placing anther `%` in front of it.
e.g. `Try aim aim for 100%% of the tests passing`.

##### `type` (optional)

The following `type`s are valid:

- `essential`: We will soft-block students until they have addressed this comment
- `actionable`: Any comment that gives a specific instruction to a user to improve their solution
- `informative`: Comments that give information, but do not necessarily expect students to use it. For example, in Ruby, if someone uses String Concatenation in TwoFer, we also tell them about String Formatting, but don't suggest that it is a better option.
- `celebratory`: Comments that tell users they've done something right, either as a general comment on the solution, or on a technique.

Comments without a type field default to `informative `.

Currently in the website, we soft-block on `essential` comments, encourage students to complete `actionable` comments before marking as complete on Practice Exercises (but not Concept Exercises), but don't suggest any action on `informative` or `celebratory`.
However, in the future we may choose to add emojis or indicators to other types, or group them separately.

### tags.json

The `tags.json` file should be structured as followed:

```json
{
  "tags": [
    "construct:list",
    "paradigm:functional",
    "technique:higher-order-functions",
    "uses:List.unfold"
  ]
}
```

#### `tags`

The `tags` field is an array of strings.
Each tag is formatted as: `"<category>:<thing>"`.

Some examples being:

- `"paradigm:functional"`
- `"technique:recursion"`
- `"construct:bitwise-and"`
- `"uses:DateTime.add_seconds"`

Tags can be used to identify what constructs/techniques/paradigms a solution uses.

For more information, see [Tagging solutions][tagging-solutions].

## Debugging

The contents of `stdout` and `stderr` from each run will be persisted into files that can be viewed later.

You may write an `analysis.out` file that contains debugging information you want to later view.

## Further reading

Before building an analyzer, please read our [Analyzer Guidance][analyzer-guidance].

[website-copy-repo]: https://github.com/exercise/website-copy
[writing-analyzer-comments]: /docs/building/tooling/analyzers/comments
[tagging-solutions]: /docs/building/tooling/analyzers/tags
[analyzer-guidance]: /docs/building/tooling/analyzers/guidance
