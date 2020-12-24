_work in progress_

# Concept Exercises

Concept Exercises are exercises designed to teach specific (programming) concepts.

## As metadata in the config.json file

Concept Exercise metadata is defined in the `exercise.concept` key in the [config.json file](./config-json.md#concept-exercises). This metadata includes things like the exercise's UUID, name and concepts and looks as follows:

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
      },
      ...
    ]
  }
}
```

## As files in the Concept Exercise's directory

Each Concept Exercise has its own directory within the track's `exercises/concept` directory. The name of the Concept Exercise directory must match the `slug` property of the Concept Exercise, as defined in the [config.json file](./config-json.md#concept-exercises).

### Documentation files

The purpose of the documentation files is explained both in this document and in the [Anatomy of a Concept Exercise video][anatomy-of-a-concept-exercise-video].

In the browser, these files will show at the relevant times. When used via the CLI, the `introduction.md` and `instructions.md` will be concatenated along with the track's `cli.md` document into a `README.md` file, which will sit alongside a `HINTS.md` file.

#### File: .docs/introduction.md

**Purpose:** Introduce the concept(s) that the exercise teaches to the student.

- The information provided should give the student just enough context to figure out the solution themselves.
- Only information that is needed to understand the fundamentals of the concept and solve the exercise should be provided. Extra information should be left for the concept's `about.md` document.
- Links should be used sparingly, if at all. While a link explaining a complex topic like recursion might be useful, for most concepts the links will provide more information than needed so explaining things concisely inline should be the aim.
- Proper technical terms should be used so that the student can easily search for more information.
- Code examples should only be used to introduce new syntax (students should not need to search the web for examples of syntax). In other cases provide descriptions or links instead of code.

As an example, the introduction to a "strings" exercise might describe a string as just a "Sequence of Unicode characters" or a "series of bytes", tell the users how to create a string, and explain that a string has methods that can be used to manipulate it. Unless the student needs to understand more nuanced details in order to solve the exercise, this type of brief explanation (along with an example of its syntax) should be sufficient information for the student to solve the exercise.

For more information, check [this example introduction.md file][docs-introduction.md]. Notice how the example file's introduction is very minimal, but that the language-specific keywords are enclosed in backticks and an example of the newly introduced syntax is included.

#### File: .docs/instructions.md

**Purpose:** Provide instructions for the exercise.

This file is split into two parts.

1. The first part explains the "story" or "theme" of the exercise. It should generally contain no code samples.
2. The second part provides clear instructions of what a student needs to do to, in the form of one or more tasks.

Each task must conform to the following standard:

- Start with a second-level heading starting with a number (e.g. `### 1. Do X`, `### 2. Do Y`).
- The heading should describe _what_ to implement, not _how_ to implement it (e.g. `### 1. Check if an appointment has already passed`).
- Describe which function/method the student needs to define/implement (e.g. `Implement method X(...) that takes an A and returns a Z`),
- Provide an example usage of that function in code. These examples should be different to those given in the tests.

We place high value on making Exercism's content safe for everyone and so often err on the side of caution in deciding whether stories are appropriate or not. While we are careful about what we merge, we appreciate that it's hard to be aware of what may be seen as problematic, so we'll always assume you're acting in good faith and do our best to catch any issues in review in a non-confrontational way. If you'd like to check a story with us, please mention @exercism/leadership and we'll look at it together. Here are some guiding points:

- Try to make sure the story is welcoming and can be understood by everyone. If the story contains in-jokes or regional slang, try to think of alternative phrases.
- Try to write examples that are inclusive to everyone. For example, consider using names from other cultures and mixed genders.
- Ask yourself whether you know anyone personally who would take offense by the story. If that's the case, consider changing it to avoid it.

For more information, check [this example instructions.md file][docs-instructions.md]. Notice how the example file has a clear distinction between the story at the top and the tasks with code samples below.

#### File: .docs/hints.md

**Purpose:** Provide hints to a student to help them get themselves unstuck in an exercise.

- If the student gets stuck, we will allow them to click a button requesting a hint, which will show the relevant part of file.
- Hints should be bullet-pointed underneath headings.
- The hints should be enough to unblock almost any student.
- The hints should not spell out the solution, but instead point to a resource describing the solution (e.g. linking to documentation for the function to use).
- The hints may use code samples to explain concepts, but not to outline the solution. e.g. in a lists exercise they might show a snippet of how a certain list function works, but not in a way that is directly copy/pasteable into the solution.
- General hints about the exercise can appear under the `### General` heading.
- Task-specific hints should appear underneath headings that match their task heading in the `instructions.md` (e.g. `### 2. Do Y`).
- Task headings should describe the _what_ of the task, not the _how_.
- Task headings should use regular sentence casing (e.g. `### 2. Check if a book can be borrowed`).
- Tasks should be explicit about what method/function/type to implemented and its expected value (e.g. `` Implement the 'canBorrowBook' function to check if a book can be borrowed. The function takes a book as its parameter and returns `true` if the book has not already been borrowed; otherwise, return `false` ``).

Viewing hints will not be a "recommended" path and we will (softly) discourage using it unless the student can't progress without it. As such, it's worth considering that the student reading it will be a little confused/overwhelmed and maybe frustrated.

For more information, check [this example hints.md file][docs-hints.md]. Notice how the example file has general and task-specific hints and how the hints don't give away the answer but instead link to (external) resources.

#### File: .docs/source.md (required if there are third-party sources)

**Purpose:** Describe the third-party source(s) of the exercise.

This file contains third-party references and sources of the exercise. Only required if there are any such sources, but not if the exercise was completely designed from scratch for Exercism.

For more information, check [this example source.md file][meta-source.md].

#### File: .meta/design.md

**Purpose:** Describe the design of the exercise.

This file contains information on the exercise's design, which includes things like its goal, its teaching goals, what not to teach, and more. This information can be extracted from the exercise's corresponding GitHub issue.

It exists in order to inform future maintainers or contributors about the scope and limitations of an exercise, to avoid the natural trend towards making exercises more complex over time.

For more information, check [this example design.md file][meta-design.md].

#### File: .meta/config.json

**Purpose:** Contains meta information on the exercise.

This file contains meta information on the exercise:

- The exercise's author(s) (required)
  - Including reviewers if their reviews substantially change the exercise (to the extent where it feels like "you got there together")
- The exercise's contributor(s) (optional)
  - Including reviewers if their reviews are meaningful/actionable/actioned.
- Which exercise(s) it was forked from (required if the exercise is forked)
- Language version requirements (optional)

If someone is both an author _and_ a contributor, only list that person as an author.

##### Example

Assume that the user FSharpForever has written an exercise called `basics` for the F# track. PythonProfessor adapts the exercise for the Python track. Later on, the user PythonPerfection improves the exercise.

_Python `basics` exercise `.meta/config.json` file (fork)_

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
  "forked_from": ["fsharp/basics"],
  "language_versions": ">=3.7"
}
```

_F# `basics` exercise `.meta/config.json` file (source)_

```json
{
  "authors": [
    {
      "github_username": "FSharpForever",
      "exercism_username": "FSharpForever"
    }
  ]
}
```

Note that:

- The order of authors and contributors is not significant and has no meaning.
- If you are forking an exercise, do not reference original authors or contributors. Just ensure that `forked_from` is correct.
- While not common, it _is_ possible to fork from multiple exercises.
- `language_versions` is a free-form string that tracks are free to use and interpret as they like.

### Code files

**Purpose:** Implement the exercise.

What these files look like depends on your track. At a minimum, the following track-specific files must be added:

#### File: stub implementation

**Purpose:** Provide a starting point for students.

- Design the stub such that a student will know where to add code.
- Define stubs for any syntax that is not introduced in the exercise. For most exercises, this means defining stub function/methods.
- For compiled languages, consider having compilable code, as compiler messages can sometimes be hard to grasp for students new to the language.
- The code should be as simple as possible.
- Only use language features introduced by the exercise or its prerequisites (and their prerequisites, and so on).
- The stub file is shown to the student when doing in-browser coding and is downloaded to the student's file system when using the CLI.

#### Example:

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

#### File: tests

**Purpose:** Verify a solution's correctness.

- The tests should not use the examples from the `instructions.md` file.
- The code should be as simple as possible.
- Only use language features introduced by the exercise's prerequisites (and their prerequisites, and so on).
- All but the first test should be skipped by default. How this is done differs between languages.
- The tests file is _not_ shown to the student when doing in-browser coding, but _is_ downloaded to the student's file system when using the CLI.

```ruby
require 'minitest/autorun'
require_relative 'lasagna'

class LasagnaTest < Minitest::Test
  def test_remaining_minutes_in_oven
    assert_equal 15, Lasagna.new.remaining_minutes_in_oven(25)
  end

  def test_preparation_time_in_minutes_with_one_layer
    assert_equal 2, Lasagna.new.preparation_time_in_minutes(1)
  end

  def test_preparation_time_in_minutes_with_multiple_layers
    assert_equal 8, Lasagna.new.preparation_time_in_minutes(4)
  end
end
```

#### File: example implementation

**Purpose:** Provide an idiomatic implementation that passes all the tests.

- This implementation is the target code that we want a student to aim for.
- Mentors will be shown this code as the "target" when writing feedback
- The implementation should only use language features introduced by the exercise or its prerequisites (and their prerequisites, and so on).
- The example file is _not_ shown to the student when doing in-browser coding and is _not_ downloaded to the student's file system when using the CLI.

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

#### File: additional files (required if default files are not enough to run the tests)

**Purpose:** Ensure that the tests can run.

Some languages require additional files for the tests to run. Example of these are C#'s project files and Node's `package.json` files, without which it will not be possible to run the tests.

### Example

The directory listing below shows what this might looks like on disk:

<pre>
exercises
└── concept
    └── cars-assemble
        ├── .docs
        |   ├── introduction.md
        |   ├── instructions.md
        |   ├── hints.md
        |   └── source.md (required if there are third-party sources)
        ├── .meta
        |   ├── config.json        
        |   ├── design.md
        |   └── Example.cs (example implementation)
        ├── CarsAssemble.cs (stub implementation)
        ├── CarsAssemble.csproj (additional file)
        └── CarsAssemblyTests.cs (tests)
</pre>
