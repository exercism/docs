# Practice Exercises

[Practice Exercises](../../product/practice-exercises.md) are exercises designed to allow students to solve an arbitary problem, with the aim of them making use of the concepts they have learnt so far.

## Metadata

Practice Exercise metadata is defined in the `exercises.practice` key in the [config.json file](./config-json.md#practice-exercises). The metadata defines the exercise's UUID, slug and more.

### Example

```json
{
  "exercises": {
    "practice": [
      {
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "slug": "leap",
        "name": "Leap",
        "prerequisites": ["if-statements", "numbers"],
        "difficulty": 1
      }
    ]
  }
}
```

## Files

Each Practice Exercise has its own directory within the track's `exercises/practice` directory. The name of the Practice Exercise directory must match the `slug` property of the Practice Exercise, as defined in the [config.json file](./config-json.md#concept-exercises).

A Practice Exercise has three types of files.

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
        ├── .docs
        |   ├── introduction.md
        |   ├── instructions.md
        |   └── hints.md
        ├── .meta
        |   ├── config.json        
        |   ├── design.md
        |   └── Example.cs (example implementation)
        ├── Isogram.cs (stub implementation)
        └── IsogramTests.cs (tests)
</pre>

---

### File: `.docs/introduction.md`

**Purpose:** Introduce the setting and background for the exercise to the student.

**Presence:** Required if the exercise implements a Problem Specifications Exercise with an `introduction.md` file

If the exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/), this file's contents should match the Problem Specification Exercise's `introduction.md` file. configlet has functionality to automatically (sync the contents)[./configlet/generating-documents.md#documentpracticeexercisesintroductionmdfile] of this file.

If the exercise is _not_ based on a Problem Specifications Exercise, consider the following:

We place high value on making Exercism's content safe for everyone and so often err on the side of caution in deciding whether stories are appropriate or not. While we are careful about what we merge, we appreciate that it's hard to be aware of what may be seen as problematic, so we'll always assume you're acting in good faith and do our best to catch any issues in review in a non-confrontational way. If you'd like to check a story with us, please mention @exercism/leadership and we'll look at it together. Here are some guiding points:

- Try to make sure the story is welcoming and can be understood by everyone. If the story contains in-jokes or regional slang, try to think of alternative phrases.
- Try to write examples that are inclusive to everyone. For example, consider using names from other cultures and mixed genders.
- Ask yourself whether you know anyone personally who would take offense by the story. If that's the case, consider changing it to avoid it.

#### Example

```markdown
Bob is a lackadaisical teenager. In conversation, his responses are very limited.
```

---

### File: `.docs/introduction.append.md`

**Purpose:** Additional introduction text to append after the existing introduction.

**Presence:** Optional

In some (rare) cases, you might want to expand on the exercise's `introduction.md` file, for example when the exercise has implemented tests that are not covered by the existing instructions.

```markdown
Bob has been having a tough time lately though, so you want to help Bob.
```

### File: `.docs/instructions.md`

**Purpose:** Provide instructions for the exercise.

**Presence:** Required

If the exercise implements a [Problem Specifications Exercise](https://github.com/exercism/problem-specifications/), this file's contents should match the Problem Specification Exercise's `instructions.md` file (or `description.md` file if there is no `instructions.md` file). configlet has functionality to automatically (sync the contents)[./configlet/generating-documents.md#documentpracticeexercisesinstructionsmdfile] of this file.

If the exercise is _not_ based on a Problem Specifications Exercise, consider the following:

We place high value on making Exercism's content safe for everyone and so often err on the side of caution in deciding whether stories are appropriate or not. While we are careful about what we merge, we appreciate that it's hard to be aware of what may be seen as problematic, so we'll always assume you're acting in good faith and do our best to catch any issues in review in a non-confrontational way. If you'd like to check a story with us, please mention @exercism/leadership and we'll look at it together. Here are some guiding points:

- Try to make sure the story is welcoming and can be understood by everyone. If the story contains in-jokes or regional slang, try to think of alternative phrases.
- Try to write examples that are inclusive to everyone. For example, consider using names from other cultures and mixed genders.
- Ask yourself whether you know anyone personally who would take offense by the story. If that's the case, consider changing it to avoid it.

#### Example

```markdown
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
Bob's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.
```

### File: `.docs/hints.md`

**Purpose:** Provide hints to a student to help them get themselves unstuck in an exercise.

**Presence:** Required

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

- There are many [built-in methods](integers) to simplify working with integers.

[integers]: https://ruby-doc.org/core-2.7.0/Integer.html
```

---

### File: .meta/design.md

**Purpose:** Describe the design of the exercise.

**Presence:** Required

This file contains information on the exercise's design, which includes things like its goal, its teaching goals, what not to teach, and more.

It exists in order to inform future maintainers or contributors about the scope and limitations of an exercise, to avoid the natural trend towards making exercises more complex over time.

#### Example

```markdown
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

- `authors`: The exercise's author(s) (required)
  - Including reviewers if their reviews substantially change the exercise (to the extent where it feels like "you got there together")
- `contributors`: The exercise's contributor(s) (optional)
  - Including reviewers if their reviews are meaningful/actionable/actioned.
- `files`: The files used in this exercises (keys for `solution`, `test`, and `example`, which point to the locations of the files specified in the "Stub implementation", "Tests", and "Example Implementation" sections listed below)
- `language_versions` Language version requirements (optional)
- `source`: The source this exercise is based on (optional)
- `source_url`: The URL of the source this exercise is based on (optional)

If someone is both an author _and_ a contributor, only list that person as an author.

#### Example

```json
{
  "authors": [
    {
      "github_username": "FSharpForever",
      "exercism_username": "FSharpForever"
    }
  ],
  "files": {
    "solution": ["Lasagna.fs"],
    "test": ["LasagnaTests.fs"],
    "example": [".meta/Example.fs"]
  }
}
```

Note that:

- The order of authors and contributors is not significant and has no meaning.
- `language_versions` is a free-form string that tracks are free to use and interpret as they like.

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
- All but the first test should be skipped by default. How this is done differs between languages.
- The tests file is _not_ shown to the student when doing in-browser coding, but _is_ downloaded to the student's file system when using the CLI.
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

Some files are not specific to individual exercises, but are instead applicable to _all_ exercises. Check the [documentation](./shared-files.md) for more information.

## Presentation

There is a difference in how exercise documentation is presented to the student when using the in-browser editor versus using the CLI. See [this document](./presentation.md) for more information.
