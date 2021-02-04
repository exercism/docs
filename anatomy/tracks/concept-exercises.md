# Concept Exercises

[Concept Exercises](../../product/concept-exercises.md) are exercises designed to teach specific (programming) concepts.

## Metadata

Concept Exercise metadata is defined in the `exercises.concept` key in the [config.json file](./config-json.md#concept-exercises). The metadata defines the exercise's UUID, slug and more.

### Example

```json
{
  "exercises": {
    "concept": [
      {
        "uuid": "93fbc7cf-3a7e-4450-ad22-e30129c36bb9",
        "slug": "cars-assemble",
        "name": "Cars, Assemble!",
        "concepts": ["if-statements", "numbers"],
        "prerequisites": ["basics"]
      }
    ]
  }
}
```

## Files

Each Concept Exercise has its own directory within the track's `exercises/concept` directory. The name of the Concept Exercise directory must match the `slug` property of the Concept Exercise, as defined in the [config.json file](./config-json.md#concept-exercises).

A Concept Exercise has three types of files:

### Documentation files

These files are presented to the student to help explain the exercise.

- `.docs/introduction.md`: introduce the concept(s) that the exercise teaches to the student (required)
- `.docs/instructions.md`: provide instructions for the exercise (required)
- `.docs/hints.md`: provide hints to a student to help them get themselves unstuck in an exercise (required)

### Metadata files

These files are _not_ presented to the student, but used to define metadata of the exercise.

- `.meta/config.json`: contains meta information on the exercise (required)
- `.meta/design.md`: describe the design of the exercise (required)

### Exercise files

The language-specific files, like the implementation and test files. The names of these files are track-specific.

- Test suite: verify a solution's correctness (required)
- Stub implementation: provide a starting point for students (required)
- Exemplar implementation: provide an idiomatic implementation that passes all the tests (required)
- Additional files: ensure that the tests can run (optional)

### Example

<pre>
exercises
└── concept
    └── cars-assemble
        ├── .docs
        |   ├── introduction.md
        |   ├── instructions.md
        |   └── hints.md
        ├── .meta
        |   ├── config.json        
        |   ├── design.md
        |   └── Exemplar.cs (exemplar implementation)
        ├── CarsAssemble.cs (stub implementation)
        └── CarsAssemblyTests.cs (tests)
</pre>

---

### File: `.docs/introduction.md`

**Purpose:** Introduce the concept(s) that the exercise teaches to the student.

**Presence:** Required

- The information provided should give the student just enough context to figure out the solution themselves.
- Only information that is needed to understand the fundamentals of the concept and solve the exercise should be provided. Extra information should be left for the concept's `about.md` document.
- Links should be used sparingly, if at all. While a link explaining a complex topic like recursion might be useful, for most concepts the links will provide more information than needed so explaining things concisely inline should be the aim.
- Proper technical terms should be used so that the student can easily search for more information.
- Code examples should only be used to introduce new syntax (students should not need to search the web for examples of syntax). In other cases provide descriptions or links instead of code.

As an example, the introduction to a "strings" exercise might describe a string as just a "Sequence of Unicode characters" or a "series of bytes", tell the users how to create a string, and explain that a string has methods that can be used to manipulate it. Unless the student needs to understand more nuanced details in order to solve the exercise, this type of brief explanation (along with an example of its syntax) should be sufficient information for the student to solve the exercise.

#### Example

````markdown
There are two primary ways to assign objects to names in Ruby - using variables or constants. Variables are always written in snake case. A variable can reference different objects over its lifetime. For example, `my_first_variable` can be defined and redefined many times using the `=` operator:

```ruby
my_first_variable = 1
my_first_variable = "Some string"
my_first_variable = SomeComplexObject.new
```
````

---

### File: `.docs/introduction.md.tpl`

**Purpose:** Template to generate an `introduction.md` file from.

**Presence:** Optional

The `introduction.md` document introduces the exercise's concept(s) to the student. Each concept also has its _own_ [`introduction.md` document](./concepts#fileintroductionmd), which is not shown outside the context of an exercise.

If the concept's introduction should be included verbatim in the exercise's introduction, an `introduction.md.tpl` file can be used. This file allows refering to concept introductions through placeholders: `%{concept:<concept-slug>}`.

[configlet](./configlet/generating.md) can generate an `introduction.md` file from a template file. The generated file will have the concept placeholders replaced by the concept's `introduction.md` contents.

The Exercism website only knows about the `introduction.md` document. It is the track's responsibility to generate the `introduction.md` when a template file is used.

Tracks can decide per exercise whether to use a template or not. In some cases, using the concept's introduction verbatim might not be optimal. Always go with what provides the best learning experience to the student.

#### Example

```markdown
%{concept:variables}
```

---

### File: `.docs/instructions.md`

**Purpose:** Provide instructions for the exercise.

**Presence:** Required

This file is split into two parts.

1. The first part explains the "story" or "theme" of the exercise. It should generally contain no code samples.
2. The second part provides clear instructions of what a student needs to do to, in the form of one or more tasks.

Each task must conform to the following standard:

- Start with a second-level heading starting with a number (e.g. `## 1. Do X`, `## 2. Do Y`).
- The heading should describe _what_ to implement, not _how_ to implement it (e.g. `## 1. Check if an appointment has already passed`).
- Describe which function/method the student needs to define/implement (e.g. `Implement method X(...) that takes an A and returns a Z`),
- Provide an example usage of that function in code. These examples should be different to those given in the tests.

We place high value on making Exercism's content safe for everyone and so often err on the side of caution in deciding whether stories are appropriate or not. While we are careful about what we merge, we appreciate that it's hard to be aware of what may be seen as problematic, so we'll always assume you're acting in good faith and do our best to catch any issues in review in a non-confrontational way. If you'd like to check a story with us, please mention @exercism/leadership and we'll look at it together. Here are some guiding points:

- Try to make sure the story is welcoming and can be understood by everyone. If the story contains in-jokes or regional slang, try to think of alternative phrases.
- Try to write examples that are inclusive to everyone. For example, consider using names from other cultures and mixed genders.
- Ask yourself whether you know anyone personally who would take offense by the story. If that's the case, consider changing it to avoid it.

#### Example

````markdown
In this exercise you're going to write some code to help you cook a brilliant lasagna from your favorite cooking book.

## 1. Calculate the remaining oven time in minutes

Define the `Lasagna#remaining_minutes_in_oven` method that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected oven time in minutes from the previous task.

```ruby
lasagna = Lasagna.new
lasagna.remaining_minutes_in_oven(30)
# => 10
```
````

---

### File: `.docs/hints.md`

**Purpose:** Provide hints to a student to help them get themselves unstuck in an exercise.

**Presence:** Required

- If the student gets stuck, we will allow them to click a button requesting a hint, which will show the relevant part of file.
- Hints should be bullet-pointed underneath headings.
- The hints should be enough to unblock almost any student.
- The hints should not spell out the solution, but instead point to a resource describing the solution (e.g. linking to documentation for the function to use).
- The hints may use code samples to explain concepts, but not to outline the solution. e.g. in a lists exercise they might show a snippet of how a certain list function works, but not in a way that is directly copy/pasteable into the solution.
- General hints about the exercise can appear as a Markdown list under the `## General` heading.
- Task-specific hints should appear as a Markdown list underneath headings that match their task heading in the `instructions.md` (e.g. `## 2. Do Y`).
- If there are no General hints or no hints for a specific task, the headings should be omitted. Every heading must be following by a Markdown list.
- Prioritize task-specific hints over general hints, as task-specific hints are more likely to unblock the student than general hints.
- Task headings should describe the _what_ of the task, not the _how_.
- Task headings should use regular sentence casing (e.g. `## 2. Check if a book can be borrowed`).
- Tasks should be explicit about what method/function/type to implemented and its expected value (e.g. `` Implement the 'canBorrowBook' function to check if a book can be borrowed. The function takes a book as its parameter and returns `true` if the book has not already been borrowed; otherwise, return `false` ``).

Viewing hints will not be a "recommended" path and we will (softly) discourage using it unless the student can't progress without it. As such, it's worth considering that the student reading it will be a little confused/overwhelmed and maybe frustrated.

#### Example

```markdown
## General

- You need to define a [constant][constant] which should contain the [integer][integers] value specified in the recipe.

## 1. Calculate the remaining oven time in minutes

- You need to define a [method][methods] with a single parameter for the actual time so far.

[constants]: https://www.rubyguides.com/2017/07/ruby-constants/
[integers]: https://ruby-doc.org/core-2.7.0/Integer.html
[methods]: https://launchschool.com/books/ruby/read/methods
```

---

### File: .meta/design.md

**Purpose:** Describe the design of the exercise.

**Presence:** Required

This file contains information on the exercise's design, which includes things like its goal, its teaching goals, what not to teach, and more. This information can be extracted from the exercise's corresponding GitHub issue.

It exists in order to inform future maintainers or contributors about the scope and limitations of an exercise, to avoid the natural trend towards making exercises more complex over time.

#### Example

```markdown
## Goal

The goal of this exercise is to teach the student the basics of programming in Ruby.

## Learning objectives

- Know what a variable is.
- Know how to define a variable.
- Know how to update a variable.

## Out of scope

- Memory and performance characteristics.
- Method overloads.

## Concepts

The Concepts this exercise unlocks are:

- `basics`: know what a variable is; know how to define a variable; know how to update a variable.

## Prerequisites

There are no prerequisites.
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
- `forked_from`: Which exercise(s) it was forked from (required if the exercise is forked)
- `files`: The files used in this exercises (keys for `solution`, `test`, and `exemplar`, which point to the locations of the files specified in the "Stub implementation", "Tests", and "Examplar Implementation" sections listed below)
- `language_versions`: Language version requirements (optional)
- `source`: The source this exercise is based on (optional)
- `source_url`: The URL of the source this exercise is based on (optional)

If someone is both an author _and_ a contributor, only list that person as an author.

#### Minimal Example

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
    "exemplar": [".meta/Exemplar.fs"]
  }
}
```

#### Full Example

Assume that the user FSharpForever has written an exercise called `basics` for the F# track. PythonProfessor adapts the exercise for the Python track. Later on, the user PythonPerfection improves the exercise.

```json
{
  "contributors": [
    {
      "github_username": "PythonPerfection",
      "exercism_username": "PythonPerfection"
    }
  ],
  "authors": [
    {
      "github_username": "PythonProfessor",
      "exercism_username": "PythonProfessor"
    }
  ],
  "files": {
    "solution": ["lasagna.py"],
    "test": ["lasagna_test.py"],
    "exemplar": [".meta/exemplar.py"]
  },
  "forked_from": ["fsharp/basics"],
  "language_versions": ">=3.7",
  "source": "Wikipedia",
  "source_url": "https://en.wikipedia.org/wiki/Lasagne"
}
```

Note that:

- The order of authors and contributors is not significant and has no meaning.
- If you are forking an exercise, do not reference original authors or contributors. Just ensure that `forked_from` is correct.
- While not common, it _is_ possible to fork from multiple exercises.
- `language_versions` is a free-form string that tracks are free to use and interpret as they like.

---

### File: Stub implementation

**Purpose:** Provide a starting point for students.

**Presence:** Required

- Design the stub such that a student will know where to add code.
- Define stubs for any syntax that is not introduced in the exercise. For most exercises, this means defining stub function/methods.
- For compiled languages, consider having compilable code, as compiler messages can sometimes be hard to grasp for students new to the language.
- The code should be as simple as possible.
- Only use language features introduced by the exercise or its prerequisites (and their prerequisites, and so on).
- The stub file is shown to the student when doing in-browser coding and is downloaded to the student's file system when using the CLI.
- The relative paths to the stub implementation file(s) must be specified in the [`.meta/config.json` file's `"files.solution"` key](./#filemetaconfigjson).

#### Example

```ruby
class Lasagna
  def remaining_minutes_in_oven(actual_minutes_in_oven)
    raise NotImplementedError, 'Please implement the Lasagna#remaining_minutes_in_oven method'
  end

  def preparation_time_in_minutes(layers)
    raise NotImplementedError, 'Please implement the Lasagna#preparation_time_in_minutes method'
  end
end
```

---

### File: Tests

**Purpose:** Verify a solution's correctness.

**Presence:** Required

- The tests should not use the examples from the `instructions.md` file.
- The code should be as simple as possible.
- Only use language features introduced by the exercise's prerequisites (and their prerequisites, and so on).
- All but the first test should be skipped by default. How this is done differs between languages.
- The tests file is _not_ shown to the student when doing in-browser coding, but _is_ downloaded to the student's file system when using the CLI.
- The relative paths to the test file(s) must be specified in the [`.meta/config.json` file's `"files.test"` key](./#filemetaconfigjson).

#### Example

```ruby
require 'minitest/autorun'
require_relative 'lasagna'

class LasagnaTest < Minitest::Test
  def test_remaining_minutes_in_oven
    assert_equal 15, Lasagna.new.remaining_minutes_in_oven(25)
  end

  def test_preparation_time_in_minutes_with_one_layer
    skip
    assert_equal 2, Lasagna.new.preparation_time_in_minutes(1)
  end

  def test_preparation_time_in_minutes_with_multiple_layers
    skip
    assert_equal 8, Lasagna.new.preparation_time_in_minutes(4)
  end
end
```

---

### File: Exemplar implementation

**Purpose:** Provide the target implementation that a student should aim for.

**Presence:** Required

- This implementation is the target code that we want a student to aim for.
- Mentors will be shown this code as the "target" when writing feedback
- The implementation should only use language features introduced by the exercise or its prerequisites (and their prerequisites, and so on).
- The exemplar file is _not_ shown to the student when doing in-browser coding and is _not_ downloaded to the student's file system when using the CLI.
- The exemplar file will be shown to mentors when commenting on solutions or representations.
- The relative paths to the example implementation file(s) must be specified in the [`.meta/config.json` file's `"files.exemplar"` key](./#filemetaconfigjson).

#### Example

```ruby
class Lasagna
  EXPECTED_MINUTES_IN_OVEN = 40
  PREPARATION_MINUTES_PER_LAYER = 2

  def remaining_minutes_in_oven(actual_minutes_in_oven)
    EXPECTED_MINUTES_IN_OVEN - actual_minutes_in_oven
  end

  def preparation_time_in_minutes(layers)
    layers * PREPARATION_MINUTES_PER_LAYER
  end
end
```

---

### File: Additional files

**Purpose:** Ensure that the tests can run.

**Presence:** Required if default files are not enough to run the tests

Some languages require additional files for the tests to run. Example of these are C#'s project files and Node's `package.json` files, without which it will not be possible to run the tests.

## Shared files

Some files are not specific to individual exercises, but are instead applicable to _all_ exercises. Check the [documentation](./shared-files.md) for more information.

## Presentation

There is a difference in how exercise documentation is presented to the student when using the in-browser editor versus using the CLI. See [this document](./presentation.md) for more information.
