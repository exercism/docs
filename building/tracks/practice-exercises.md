# Practice Exercises

[Practice Exercises](/docs/building/product/practice-exercises) are exercises designed to allow students to solve an arbitrary problem, with the aim of them making use of the concepts they have learned so far.

Interested in adding your first Practice Exercise to a track? Watch our walkthrough video 👇

[video:vimeo/906101866?h=2954ad331e]()

````exercism/note
You can quickly scaffold a new Practice Exercise by running the following commands from the track's root directory:

```shell
bin/fetch-configlet
bin/configlet create --practice-exercise <slug>
```

For more information, check the [`configlet create` docs](/docs/building/configlet/create)
````

## Metadata

Practice Exercise metadata is defined in the `exercises.practice` key in the [config.json file](/docs/building/tracks/config-json). The metadata defines the exercise's UUID, slug and more.

### Example

```json
{
  "exercises": {
    "practice": [
      {
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "slug": "leap",
        "name": "Leap",
        "practices": ["if-statements", "numbers", "operator-precedence"],
        "prerequisites": ["if-statements", "numbers"],
        "difficulty": 1
      }
    ]
  }
}
```

### `practices`

The `practices` key should list the slugs of Concepts that this Practice Exercise actively allows a student to practice.

- These show up in the UI as "Practice this Concept in: TwoFer, Leap, etc"
- Try and choose 3 - 8 Exercises that practice each Concept.
- Try and choose at least two Exercises that allow someone to practice the basics of a Concept.
- Some Concepts are very common (for example `strings`). In those cases we recommend choosing a few good exercises that make people think about those Concepts in interesting ways. For example, exercises that require UTF-8, string concatenation, char enumeration, etc, would all be good examples.

### `prerequisites`

The `prerequisites` key lists the Concepts that a student must have completed in order to access this Practice Exercise.

- These show up in the UI as "Learn Strings to unlock TwoFer"
- It should include all Concepts that a student needs to have covered to be able to complete the exercise in at least one idiomatic way. For example, for the TwoFer exercise in Ruby, prerequisites might include `strings`, `optional-params`, `implicit-return`.
- For Exercises that can be completed using alternative Concepts (e.g. an Exercise solvable by `loops` or `recursion`), the maintainer should choose the one approach that they would like to unlock the Exercise, considering the student's journey through the track. For example, the loops/recursion example, they might think this exercise is a good early practice of `loops` or that they might like to leave it later to teach recursion. They can also make use of an analyzer to prompt the student to try an alternative approach: "Nice work on solving this via loops. You might also like to try solving this using Recursion."

## Files

Each Practice Exercise has its own directory within the track's `exercises/practice` directory. The name of the Practice Exercise directory must match the `slug` property of the Practice Exercise, as defined in the [config.json file](/docs/building/tracks#concept-exercises).

A Practice Exercise has four types of files:

### Documentation files

These files are presented to the student to help explain the exercise.

- `.docs/introduction.md`: introduces the setting and background for the exercise (optional)
- `.docs/introduction.append.md`: additional introduction text to append after the existing introduction (optional)
- `.docs/instructions.md`: provide instructions for the exercise (required)
- `.docs/instructions.append.md`: additional introduction text to append after the existing instructions (optional)
- `.docs/hints.md`: provide hints to a student to help them get themselves unstuck in the exercise (optional)

### Metadata files

These files are _not_ presented to the student, but used to define metadata of the exercise.

- `.meta/config.json`: contains meta information on the exercise (required)
- `.meta/design.md`: describe the design of the exercise (optional)
- `.meta/tests.toml`: contains information on what tests are implemented (optional)

### Approach files

These files describe approaches for the exercise.

- `.approaches/introduction.md`: introduction to the most common approaches for the exercise (optional)
- `.approaches/config.json`: metadata for the approaches (optional)
- `.approaches/<approach-slug>/content.md`: description of the approach (optional)
- `.approaches/<approach-slug>/snippet.txt`: snippet showcasing the approach (optional)

### Article files

These files describe articles for the exercise.

- `.articles/config.json`: metadata for the articles (optional)
- `.articles/<article-slug>/content.md`: description of the article (optional)
- `.articles/<article-slug>/snippet.md`: snippet showcasing the article (optional)

### Exercise files

The language-specific files, like the implementation and test files. The names of these files are track-specific.

- Test suite: verify a solution's correctness.
- Stub implementation: provide a starting point for students.
- Example implementation: provide an example implementation that passes all the tests.
- Additional files: ensure that the tests can run.

### Example

<pre>
exercises
└── practice
    └── isogram
        ├── .approaches
        |   ├── for-loop
        |   |   ├── content.md
        |   |   └── snippet.txt
        |   ├── config.json
        |   └── introduction.md
        ├── .articles
        |   ├── performance
        |   |   ├── content.md
        |   |   └── snippet.md
        |   └── config.json
        ├── .docs
        |   ├── introduction.md
        |   ├── instructions.md
        |   └── hints.md
        ├── .meta
        |   ├── config.json
        |   ├── design.md
        |   ├── tests.toml
        |   └── Example.cs (example implementation)
        ├── Isogram.cs (stub implementation)
        └── IsogramTests.cs (tests)
</pre>

---

### File: `.docs/introduction.md`

**Purpose:** Introduce the setting and background for the exercise to the student.

**Presence:** Required if the exercise implements a Problem Specifications Exercise with an `introduction.md` file

If the exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/), this file's contents should match the Problem Specification Exercise's `introduction.md` file. configlet has functionality to automatically [sync the contents](/docs/building/configlet/generating-documents#document-practice-exercises-introductionmd-file) of this file.

If the exercise is _not_ based on a Problem Specifications Exercise, consider the following:

We place high value on making Exercism's content safe for everyone and so often err on the side of caution in deciding whether stories are appropriate or not. While we are careful about what we merge, we appreciate that it's hard to be aware of what may be seen as problematic, so we'll always assume you're acting in good faith and do our best to catch any issues in review in a non-confrontational way. If you'd like to check a story with us, please mention @exercism/leadership and we'll look at it together. Here are some guiding points:

- Try to make sure the story is welcoming and can be understood by everyone. If the story contains in-jokes or regional slang, try to think of alternative phrases.
- Try to write examples that are inclusive to everyone. For example, consider using names from other cultures and mixed genders.
- Ask yourself whether you know anyone personally who would take offense by the story. If that's the case, consider changing it to avoid it.

#### Example

```markdown
# Introduction

Bob is a lackadaisical teenager. In conversation, his responses are very limited.
```

---

### File: `.docs/introduction.append.md`

**Purpose:** Additional introduction text to append after the existing introduction.

**Presence:** Optional

In some (rare) cases, you might want to expand on the exercise's `introduction.md` file, for example when the exercise has implemented tests that are not covered by the existing instructions.

A track that doesn't want Bob to support non-ASCII messages, might add the following:

```markdown
# Introduction append

As part of his teenage rebellion, Bob has decided to only communicate using ASCII.
```

### File: `.docs/instructions.md`

**Purpose:** Provide instructions for the exercise.

**Presence:** Required

If the exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/), this file's contents should match the Problem Specification Exercise's `instructions.md` file (or `description.md` file if there is no `instructions.md` file). configlet has functionality to automatically [sync the contents](/docs/building/configlet/generating-documents#document-practice-exercises-instructionsmd-file) of this file.

If the exercise is _not_ based on a Problem Specifications Exercise, consider the following:

We place high value on making Exercism's content safe for everyone and so often err on the side of caution in deciding whether stories are appropriate or not. While we are careful about what we merge, we appreciate that it's hard to be aware of what may be seen as problematic, so we'll always assume you're acting in good faith and do our best to catch any issues in review in a non-confrontational way. If you'd like to check a story with us, please mention @exercism/leadership and we'll look at it together. Here are some guiding points:

- Try to make sure the story is welcoming and can be understood by everyone. If the story contains in-jokes or regional slang, try to think of alternative phrases.
- Try to write examples that are inclusive to everyone. For example, consider using names from other cultures and mixed genders.
- Ask yourself whether you know anyone personally who would take offense by the story. If that's the case, consider changing it to avoid it.

#### Example

```markdown
# Instructions

Bob answers 'Sure.' if you ask him a question, such as "How are you?".

He answers 'Whoa, chill out!' if you YELL AT HIM (in all capitals).

He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

He says 'Fine. Be that way!' if you address him without actually saying anything.

He answers 'Whatever.' to anything else.
```

### File: `.docs/instructions.append.md`

**Purpose:** Additional instructions text to append after the existing instructions.

**Presence:** Optional

In some (rare) cases, you might want to expand on the exercise's `instructions.md` file, for example when the exercise has implemented tests that are not covered by the existing instructions.

```markdown
# Instructions append

Bob's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.
```

### File: `.docs/hints.md`

**Purpose:** Provide hints to a student to help them get themselves unstuck in an exercise.

**Presence:** Optional

- If the student gets stuck, we will allow them to click a button requesting a hint, which will show the relevant part of file.
- Hints should be bullet-pointed underneath headings.
- The hints should be enough to unblock almost any student.
- The hints should not spell out the solution, but instead point to a resource describing the solution (e.g. linking to documentation for the function to use).
- The hints may use code samples to explain concepts, but not to outline the solution. e.g. in a lists exercise they might show a snippet of how a certain list function works, but not in a way that is directly copy/pasteable into the solution.
- The hints must appear as a Markdown list under a `## General` heading.
- If there are no hints, the heading should be omitted.

Viewing hints will not be a "recommended" path and we will (softly) discourage using it unless the student can't progress without it. As such, it's worth considering that the student reading it will be a little confused/overwhelmed and maybe frustrated.

#### Example

```markdown
## General

- There are many [built-in methods][integers] to simplify working with integers.

[integers]: https://ruby-doc.org/core-2.7.0/Integer.html
```

---

### File: .meta/design.md

**Purpose:** Describe the design of the exercise.

**Presence:** Optional

This file contains information on the exercise's design, which includes things like its goal, its teaching goals, what not to teach, and more.

It exists in order to inform future maintainers or contributors about the scope and limitations of an exercise, to avoid the natural trend towards making exercises more complex over time.

#### Example

```markdown
# Design

## Goal

The goal of this exercise is help students practice how to work with strings.

## Notes

This exercise does not contain any error handling tests.
```

---

### File: `.meta/config.json`

**Purpose:** Contains meta information on the exercise.

**Presence:** Required

This file contains meta information on the exercise:

- `authors`: The GitHub username(s) of the exercise's author(s) (optional)
  - Including reviewers if their reviews substantially change the exercise (to the extent where it feels like "you got there together")
- `contributors`: The GitHub username(s) of the exercise's contributor(s) (optional)
  - Including reviewers if their reviews are meaningful/actionable/actioned.
- `files`: The locations of the files used in this exercise, relative to the exercise's directory (required)
  - `solution`: the [stub implementation file(s)](./#filestubimplementation) (required)
  - `test`: the [test file(s)](./#filetests) (required)
  - `example`: the [example implementation file(s)](./#fileexampleimplementation) (required)
  - `editor`: additional files shown as read-only in the editor (optional)
  - `invalidator`: files that when changed, cause a solution to become out-of-date (optional)
- `language_versions` Language version requirements (optional)
- `blurb`: A short description of this exercise. Its length must be <= 350. Markdown is _not_ supported (required)
- `source`: The source this exercise is based on (optional)
- `source_url`: The URL of the source this exercise is based on (optional)
- `test_runner`: Indicates if solutions of this exercise should be tested in the test runner. Defaults to `true` if not specified. (optional)
- `representer`: Meta information related to how the representer processes this file (optional)
  - `version`: An integer for the version of the representer to use for the exercise (required if parent key is present)
- `icon`: The slug of the icon (see [the full list of icons][exercise-icons]). If not specified, the exercise's slug will be used (optional)
- `custom`: Any exercise-specific, non-standard data. Can be used to customize behavior of the track's tooling per exercise (optional)

If someone is both an author _and_ a contributor, only list that person as an author.

#### Example

```json
{
  "authors": ["FSharpForever"],
  "files": {
    "solution": ["Bob.fs"],
    "test": ["BobTests.fs"],
    "example": [".meta/Example.fs"]
  },
  "blurb": "Bob is a lackadaisical teenager. In conversation, his responses are very limited"
}
```

Note that:

- The order of authors and contributors is not significant and has no meaning.
- `language_versions` is a free-form string that tracks are free to use and interpret as they like.

### File: .meta/tests.toml

**Purpose:** Contains information on what tests are implemented.

**Presence:** Optional

This file contains information on which tests are being implemented, provided the exercise has any tests defined in its `canonical-data.json` file within the [problem-specifications repo][problem-specifications-exercises].

It exists to help maintainers keep track of which tests are implemented, and to (optionally) document why a certain test isn't implemented.
It can also be used to detect unimplemented tests.

The [configlet][configlet] tool handles updating/syncing of this file with the data in the [problem-specifications repo][problem-specifications-exercises] via the [configlet sync][configlet-sync] command.
When syncing, configlet will, for each unimplemented test, ask whether to include that test or not.

#### Example

```toml
# This is an auto-generated file.
#
# Regenerating this file via `configlet sync` will:
# - Recreate every `description` key/value pair
# - Recreate every `reimplements` key/value pair, where they exist in problem-specifications
# - Remove any `include = true` key/value pair (an omitted `include` key implies inclusion)
# - Preserve any other key/value pair
#
# As user-added comments (using the # character) will be removed when this file
# is regenerated, comments can be added via a `comment` key.

[3e5c30a8-87e2-4845-a815-a49671ade970]
description = "empty strand"

[a0ea42a6-06d9-4ac6-828c-7ccaccf98fec]
description = "can count one nucleotide in single-character input"

[eca0d565-ed8c-43e7-9033-6cefbf5115b5]
description = "strand with repeated nucleotide"

[40a45eac-c83f-4740-901a-20b22d15a39f]
description = "strand with multiple nucleotides"

[b4c47851-ee9e-4b0a-be70-a86e343bd851]
description = "strand with invalid nucleotides"
include = false
comment = "error handling omitted on purpose"
```

---

### File: `.approaches/introduction.md`

**Purpose:** Introduction to the most common approaches for the exercise

**Presence:** Optional

This file describes the most common approaches for the exercise.
Check the [documentation](/docs/building/tracks/approaches) for more information on what should go in this file.

#### Example

````markdown
# Introduction

The key to this exercise is to deal with C# strings being immutable, which means that a `string`'s value cannot be changed.
Therefore, to reverse a string you'll need to create a _new_ `string`.

## Using LINQ

```csharp
public static string Reverse(string input)
{
    return new string(input.Reverse().ToArray());
}
```

For more information, check the [LINQ approach][approach-linq].

## Which approach to use?

If readability is your primary concern (and it usually should be), the LINQ-based approach is hard to beat.
````

---

### File: `.approaches/config.json`

**Purpose:** Metadata for the approaches

**Presence:** Optional (required when an approach introduction or approach exists)

This file contains meta information on the exercise's approaches:

- `introduction`: The GitHub username(s) of the exercise approach introduction's author(s) (optional)

  - `authors`: The GitHub username(s) of the exercise approach introduction's author(s) (required)
    - Including reviewers if their reviews substantially change the exercise approach introduction (to the extent where it feels like "you got there together")
  - `contributors`: The GitHub username(s) of the exercise approach introduction's contributor(s) (optional)
    - Including reviewers if their reviews are meaningful/actionable/actioned.

- `approaches`: An array listing the detailed approaches (optional)
  - `uuid`: a V4 UUID that uniquely identifies the approach. The UUID must be unique both within the track as well as across all tracks, and must never change
  - `slug`: the approach's slug, which is a lowercased, kebab-case string. The slug must be unique across all approach slugs within the track. Its length must be <= 255.
  - `title`: the approach's title. Its length must be <= 255.
  - `blurb`: A short description of this approach. Its length must be <= 350. Markdown is _not_ supported (required)
  - `authors`: The GitHub username(s) of the exercise approach's author(s) (required)
    - Including reviewers if their reviews substantially change the exercise approach (to the extent where it feels like "you got there together")
  - `contributors`: The GitHub username(s) of the exercise approach's contributor(s) (optional)
    - Including reviewers if their reviews are meaningful/actionable/actioned.
  - `tags`: Specify the conditions for when a submission is linked to an approach. (optional)
    - `all`: An array of tags that must all be present on a submission (optional, unless `any` has no elements)
    - `any`: An array of tags of which at least one must be present on a submission (optional, unless `all` has no elements)
    - `not`: none of the tags must be present on a submission (optional)

#### Example

```json
{
  "introduction": {
    "authors": ["erikschierboom"]
  },
  "approaches": [
    {
      "uuid": "448fb2b4-18ab-4e55-aa54-ad4ed6d5f7f6",
      "slug": "span",
      "title": "Use Span<T>",
      "blurb": "Use Span<T> to efficiently reverse a string.",
      "authors": ["erikschierboom"]
    }
  ]
}
```

---

### File: `.approaches/<approach-slug>/content.md`

**Purpose:** Detailed description of the approach

**Presence:** Optional (required for approaches)

This file contains a detailed description of the approach.
Check the [documentation](/docs/building/tracks/approaches) for more information on what should go in this file.

#### Example

````markdown
# Span

```csharp
Span<char> chars = stackalloc char[input.Length];
for (var i = 0; i < input.Length; i++)
{
    chars[input.Length - 1 - i] = input[i];
}
return new string(chars);
```

This `Span<T>` approach uses a `for` loop.
````

---

### File: `.approaches/<approach-slug>/snippet.txt`

**Purpose:** Snippet showcasing the approach

**Presence:** Optional (required for approaches)

This file contains a small snippet that showcases the approach.
The snippet is shown on an exercise's dig deeper page.

Its number of lines must be <= 8.

Check the [documentation](/docs/building/tracks/approaches) for more information on what should go in this file.

#### Example

```csharp
Span<char> chars = stackalloc char[input.Length];
for (var i = 0; i < input.Length; i++)
{
    chars[input.Length - 1 - i] = input[i];
}
return new string(chars);
```

---

### File: `.article/config.json`

**Purpose:** Metadata for the articles

**Presence:** Optional (required when an article exists)

This file contains meta information on the exercise's articles:

- `articles`: An array listing the detailed articles (optional)
  - `uuid`: a V4 UUID that uniquely identifies the article. The UUID must be unique both within the track as well as across all tracks, and must never change
  - `slug`: the article's slug, which is a lowercased, kebab-case string. The slug must be unique across all article slugs within the track. Its length must be <= 255.
  - `title`: the article's title. Its length must be <= 255.
  - `blurb`: A short description of this article. Its length must be <= 350. Markdown is _not_ supported (required)
  - `authors`: The GitHub username(s) of the exercise article's author(s) (required)
    - Including reviewers if their reviews substantially change the exercise article (to the extent where it feels like "you got there together")
  - `contributors`: The GitHub username(s) of the exercise article's contributor(s) (optional)
    - Including reviewers if their reviews are meaningful/actionable/actioned.

#### Example

```json
{
  "articles": [
    {
      "uuid": "6db71962-62d5-448b-a980-c20ae41013ed",
      "slug": "performance",
      "title": "Optimizing performance",
      "blurb": "Explore how to most efficiently reverse a string and what the trade-offs are.",
      "authors": ["erikschierboom"]
    }
  ]
}
```

---

### File: `.articles/<article-slug>/content.md`

**Purpose:** Detailed description of the approach

**Presence:** Optional (required for approaches)

This file contains a detailed description of the approach.
Check the [documentation](/docs/building/tracks/articles) for more information on what should go in this file.

#### Example

```markdown
# Performance

In this document, we'll find out which approach is the most performant one.

## Benchmark results

| Method |      Mean |     Error |    StdDev |    Median | Allocated |
| -----: | --------: | --------: | --------: | --------: | --------: |
|   Linq | 29.133 ns | 0.5865 ns | 0.5486 ns | 28.984 ns |      80 B |
|  Array |  4.806 ns | 0.4999 ns | 1.4739 ns |  3.967 ns |         - |
```

---

### File: `.articles/<article-slug>/snippet.txt`

**Purpose:** Snippet showcasing the approach

**Presence:** Optional (required for articles)

This file contains a small snippet that showcases the article.
The snippet is shown on an exercise's dig deeper page.

Its number of lines must be <= 8.

Check the [documentation](/docs/building/tracks/articles) for more information on what should go in this file.

#### Example

```markdown
| Method |      Mean | Allocated |
| -----: | --------: | --------: |
|   Linq | 29.133 ns |      80 B |
|  Array |  4.806 ns |         - |
```

---

### File: Stub implementation

**Purpose:** Provide a starting point for students.

**Presence:** Required

- Design the stub such that a student will know where to add code.
- For compiled languages, consider having compilable code, as compiler messages can sometimes be hard to grasp for students new to the language.
- The code should be as simple as possible.
- Only use language features introduced by the prerequisites (and their prerequisites, and so on).
- The stub file is shown to the student when doing in-browser coding and is downloaded to the student's file system when using the CLI.
- The relative paths to the stub implementation file(s) must be specified in the [`.meta/config.json` file's `"files.solution"` key](./#filemetaconfigjson).

#### Example

```csharp
using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
```

---

### File: Tests

**Purpose:** Verify a solution's correctness.

**Presence:** Required

- The code should be as simple as possible.
- Only use language features introduced by the exercise's prerequisites (and their prerequisites, and so on).
- The tests file is shown to the student when doing in-browser coding and downloaded to the student's file system when using the CLI.
- Exercism favors Practice Exercises being completed via Test Driven Development. To achieve this, there are two options:
  - The test runner must run the tests in the order defined in the file AND the test suite must bail on the first failure; or
  - All but the first test should be skipped by default.
- The relative paths to the test file(s) must be specified in the [`.meta/config.json` file's `"files.test"` key](./#filemetaconfigjson).

#### Example

```csharp
using Xunit;

public class IsogramTest
{
    [Fact]
    public void Empty_string() =>
        Assert.True(Isogram.IsIsogram(""));

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Isogram_with_only_lower_case_characters() =>
        Assert.True(Isogram.IsIsogram("isogram"));

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Word_with_one_duplicated_character() =>
        Assert.False(Isogram.IsIsogram("eleven"));
}
```

---

### File: Example implementation

**Purpose:** Provide an example implementation that passes all the tests.

**Presence:** Required

- This implementation is used to verify that there exists an implementation that passed the tests. It is purposefully _not_ the target code that we want a student to aim for.
- Each track should verify that the example implementation passes the tests in their Continuous Integration setup.
- Mentors will not be shown this code.
- The example file is _not_ shown to the student when doing in-browser coding and is _not_ downloaded to the student's file system when using the CLI.
- The relative paths to the example implementation file(s) must be specified in the [`.meta/config.json` file's `"files.example"` key](./#filemetaconfigjson).

#### Example

```csharp
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var lowerCaseLetters = word.ToLower().Where(char.IsLetter).ToList();
        return lowerCaseLetters.Distinct().Count() == lowerCaseLetters.Count;
    }
}
```

---

### File: Additional files

**Purpose:** Additional project, build or supporting files required so that the tests can run.

**Presence:** Required if default files are not enough to run the tests

Some languages require additional files for the tests to run. Example of these are C#'s project files and Node's `package.json` files, without which it will not be possible to run the tests.

## Shared files

Some files are not specific to individual exercises, but are instead applicable to _all_ exercises. Check the [documentation](/docs/building/tracks/shared-files) for more information.

## Presentation

There is a difference in how exercise documentation is presented to the student when using the in-browser editor versus using the CLI. See [this document](/docs/building/tracks/presentation) for more information.

### Icon

Each exercise has an [accompanying icon][exercise-icons].
By default, the displayed icon is the one which name matches the exercise's slug.
One can override this by specifying the `icon` property in the exercise's `.meta/config.json` file.

If you're implementing an exercise from [problem-specifications metadata][problem-specifications-exercises], there probably already is an icon for that exercise.
If not, please [open an issue in the website-icons repository][website-icons-issues].

[exercise-icons]: /docs/building/tracks/icons#h-exercise-icons
[website-icons-issues]: https://github.com/exercism/website-icons/issues
[problem-specifications-exercises]: https://github.com/exercism/problem-specifications/tree/main/exercises
[configlet]: /docs/building/configlet
[configlet-sync]: /docs/building/configlet/sync
