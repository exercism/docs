**NOTE: The approval and comments keys in this spec are currently under review.**

---

# The Analyzer Interface

All interactions with the Exercism website are handled automatically. Analyzers have the single responsibility of taking a solution and returning a status and any messages.

## Execution

- An Analyzer should provide an executable script. You can find more information in the [docker.md](../docker.md) file.
- The script will receive three parameters:
  - The slug of the exercise (e.g. `two-fer`).
  - A path to a directory containing the submitted file(s) (with a trailing slash).
  - A path to an output directory (with a trailing slash). This directory is writable.
- The script must write an `analysis.json` file to the output directory.

## Output format

The `analysis.json` file should be structured as followed:

```json
{
  "status": "...",
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


### `summary` (optional)

The summary field is a text field that summarises the output. 
It might say something like "Your solution is nearly there - there's just two small changes you can make." or "The code works great, but there's a little bit of linting that needs doing.".
This summary is rendered on the website above the comments.

### `comments`
Comments are keys into `website-copy/automated-comments/`, e.g. [`ruby.general.explicit_return -> automated-comments/ruby/general/explicit_return.md`](https://github.com/exercism/website-copy/blob/47af5b309ac263629ca5c52904046f81e0cc8def/automated-comments/ruby/general/explicit_return.md).

Then can be structured either as single pointer strings (e.g. the last example above) or using a JSON Object to specify the follow keys:

#### `comment`

The pointer-string to a file in `website-copy`.

#### `params` (optional)

A JSON Object containing any params that should be interpolated during rendering. 
For example, in the markdown file, you could write `Try %{variable_name} += 1 instead`, and then use `params` to substitute `%{variable_name}` for the actual variable that the student used.

When using parameterised files, ensure to escape all uses of `%` by placing anther `%` in front of it. 
e.g. `Try aim aim for 100%% of the tests passing`.

#### `type` (optional)
The following `type`s are valid:

- `essential`: We will soft-block students until they have addressed this comment
- `actionable`: Any comment that gives a specific instruction to a user to improve their solution
- `informative`: Comments that give information, but do not necessarily expect students to use it. For example, in Ruby, if someone uses String Concatenation in TwoFer, we also tell them about String Formatting, but don't suggest that it is a better option.
- `celebratory`: Comments that tell users they've done something right, either as a general comment on the solution, or on a technique. 

Comments without a type field default to `actionable`.

Currently in the website, we soft-block on essential comments, encourage students to complete actionable comments before marking as complete on Practice Exercises (but not Concept Exercises), but don't suggest any action on `informative` or `celebratory`. 
However, in the future we may choose to add emojis or indicators to other types, or group them seperately.

## Debugging

The contents of `stdout` and `stderr` from each run will be persisted into files that can be viewed later.

You may write an `analysis.out` file that contains debugging information you want to later view.

---

**NOTE: Everything below this line is currently changing.**

# LEGACY: Comments

Exercism is responsible for the display and communication of comments. The analyzer's job is purely to provide functional comments. Please follow these guidelines:

- Comments should be actionable. The user should understand the action they need to undertake.
- While friendly, they should not try and pretend to be a human and should not contain greetings, etc.
- The solution should not act like the start of a discussion.

- A good comment would be "This solution may be improved by doing XYZ".
- A bad comment would be "Hello. Have you thought about doing XYZ?".

# LEGACY: Feedback guidelines

The goal of a language track on Exercism is to give people a way to achieve a
high level of fluency at a low level of proficiency. We're aiming for fluency
in the syntax, idioms, and the standard library of the language. You can read
more about the [goal of exercism here](https://github.com/exercism/docs/blob/main/about/goal-of-exercism.md).

## Definitions

In the following paragraphs, keywords such as **MUST**, **SHOULD**, **MAY**
are to be interpreted as in [RFC2119](https://www.ietf.org/rfc/rfc2119.txt);
given that we recognise the following four output states and their restrictions:

- `approve`: **MUST** be an approvable solution, **MAY** be with comment.
- `disapprove`: **MUST** be with comment
- `refer_to_mentor`: **MAY** be with comment

### Why is it not ... (e.g. **MUST**)?

Per [RFC2119](https://www.ietf.org/rfc/rfc2119.txt), if **MUST** is used, it is
a guarantee that the rule is always so, and does not need to be guarded for. For
example, **MUST** be without comment means that the website could crash if an
analyzer sends a comment anyway. **SHOULD** indicates any consumer of the output
must still guard against unwanted behaviour.

### Approvability

A solution is approvable if it either matches the (set of) optimal solution(s)
of that exercise, or if it shows understanding of the teaching goals of that
exercise and every _core_ exercise that came before. This means that an
analyzer **MAY** approve a solution but still provide a set of comments as tips
relating to the exercise or further improvements.

### Idiomatic rules / Language features / Stylistic choices

In this document, **de facto** is defined as follows:

- **de facto**: describes practices that exist in reality, even if not
  officially recognized by laws.
- **de facto standard**: a custom or convention that has achieved a dominant
  position by public acceptance or market forces. Unofficial customs that are
  widely accepted.

In other words, if a nearly all developers (non-hobyists) who write code in a
certain language have established certain rules, these rules are a **de facto
standard** and become idiomatic use. Example: **Ruby** uses 2 space identation.

Some rules are language features, even if they are not documented well. These
language features are part of "idiomatic rules" and not stylistic choices.
Example: **Ruby**'s MRI treats variables named `_` differently.

Finally there are rules that are pure preferences, even though they might be
adopted by large bodies such as organisations and corporations. These rules
are usually part of _competing_ standards. Exercism does not favour one over
another. Example: **TypeScript** has a linter `tslint` (or `eslint` + plugin)
which is maintained by a company that is not Microsoft. It competes with other
linters such as `xo`. Most of the rules are not language features or idiomatic
rules, and therefore stylistic choices.

## Conditions and outcome

For feedback generated by automated mentoring:

- it **SHOULD** `disapprove` when someone isn't using one of the
  subjects the exercise is supposed to teach,
- each `disapprove` **MUST** have at least one comment,
- each `disapprove` **SHOULD** steer a student towards an `approve`,
- the analyzer **SHOULD** aim to teach a pathway, which means a student
  **SHOULD NOT** get a `refer_to_mentor` in a newer iteration, after a
  `disapprove`, given they follow that pathway.
- a `refer_to_mentor` **MAY** have one or more comments which will be given to
  the mentor,
- the same comment **MUST** not be added twice in one analysis. Adding the same
  comment with different parameters attached to it is not considered a duplicate.
- comments **SHOULD** be ordered by importance (the first comment being the most
  important, and the last comment being the least important).

It is currently undecided as to whether there is a minimum or maximum amount of
:speech_balloon: comments. However, each comment **SHOULD** be aiding the
student towards an approvable solution. Our recommendation is currently to aim
for one to three comments per iteration.

## Approvability

Given the above, and to re-iterate that we focus on language fluency:

### Incorrect Naming or Casing

In general, if it's a _language feature_ that will be caught by a compiler or
parser or based on official rules (which means there is a dependency on
correctness in tools), you should `disapprove`, preferably linking
to the official rules.

> - :-1: disapprove if there are official guidelines on naming conventions
> - :speech_balloon: leave a comment if there is something noteworthy
> - :no*bell: if its a \_stylistic* preference, **and** there are _competing
>   standards_, do not remark at all. Since there are competing standards,
>   they're all preferences.
> - :speech*balloon: if it's a \_stylistic* preference, **and** there is _one
>   clear standard_, comment on it. These rules enforce idiomatic code.
> - :question: If it's a _stylistic_ preference, **and** there is no clear
>   standard, but most to all non-hobyist have adopted the same style, this
>   might be idiomatic. Comment at your discretion.

#### Examples

- **Ruby** has a language feature where `_` is treated differently,
  - :-1: if a student uses `_` for a variable name, but then uses it.
- **Ruby** recognises `constants` only if they start with a **C**apital Letter,
  - :-1: if a student uses `snake_case` for a `class` name
- **Ruby** has _de facto_ standards on `cAsInG` and `name-ing`,
  - :speech_balloon: you **SHOULD** guide students that `snake_case` is to be
    expected by most IDEs and highlighting on exercism in code blocks.
- **JavaScript** IDEs highlight variables which are not used, except for those
  prefixed with an underscore (`_`).
  - :speech*balloon: note that this behaviour exist so it might help them to use
    a different naming strategy. They might think that prefixing with `*`means `private`, which is not the case in JavaScript.
- **TypeScript** has a _de facto_ standard lint tool provided by Palantir,
  - :no_bell: If a student does not follow these rules as the lint tool is not
    official. In fact, there are multiple linters out there, with mutually
    exclusive rules.
- **Go** has very strict rules around naming and other linting.
  - :-1: if the student does not follow these (e.g. has not applied `golint`)
- **Go** has very strict rules around formatting.
  - :-1: if the student does not follow these (e.g. has not applied `gofmt`)

### Badly formatted code

The same rules apply as above. In general, if `linting` and a specific format is
not part of the official language, and/or not integral to the language:

- :no_bell: **SHOULD NOT** disapprove on it
- :speech_balloon: You **MAY** guide students towards tools for auto-formatting
