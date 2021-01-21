_work in progress_

# Concepts

Concepts are the things that a programmer would need to understand to be fluent in a language. Concepts are taught by Concept Exercises and are used as prerequisites for Concept- _and_ Practice Exercises.

## Metadata

Concept metadata is defined in the `concepts` key in the [config.json file](./config-json.md#concepts). The metadata defines the concept's UUID, slug and more.

### Example

```json
{
  "concepts": [
    {
      "uuid": "b9a421b2-c5ff-4213-bd6d-b886da31ea0d",
      "slug": "numbers",
      "name": "Numbers",
      "blurb": "C# has two types of numbers: integers and floating-point numbers."
    }
  ]
}
```

## Files

Each concept has its own directory within the track's `concepts` directory. The name of the concept's directory must match the `slug` property of the concept, as defined in the [config.json file](./config-json.md#concept). Each concept directory must contain the following files:

- `about.md`: provide information about the concept for a student who has completed the corresponding concept exercise to learn from and refer back to.
- `introduction.md`: provide a brief introduction to a student who has not yet completed the corresponding concept exercise.
- `links.json`: provide helpful links that provide more reading or information about a concept.

### Example

<pre>
concepts
└── numbers
    ├── about.md
    ├── introduction.md
    └── links.json
</pre>

### File: about.md

**Purpose:** Provide information about the concept for a student who has completed the corresponding concept exercise to learn from and refer back to.

Once the student completes the exercise they will be shown this file, which should provide them with a summary of the concept. If the concept introduces new syntax, syntax samples should be included. At a minimum, this file should contain all information that is introduced in the exercise's [`.docs/introduction.md` document](./concept-exercises#filedocsintroductionmd).

This document can also link to any additional resources that might be interesting to the student in the context of the exercise, such as:

- Popular usages for a feature
- Common pitfalls in a feature's use (e.g. casual use of multiple **threads**)
- Limitations on use that may catch out the unsuspecting developer
- Alternative approaches addressed in other exercises
- Compromises made for ease of learning or to accommodate the Exercism environment, e.g. multiple classes in single file
- Similar features with which the concept may be confused
- Performance characteristics and memory usage

#### Example

````markdown
One of the key aspects of working with numbers in C# is the distinction between [integers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) (numbers with no digits after the decimal separator) and [floating-point numbers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) (numbers with zero or more digits after the decimal separator).

The two most commonly used numeric types in C# are `int` (a 32-bit integer) and `double` (a 64-bit floating-point number).

```csharp
int i = 123;
double d = 54.29;
```

Both integers and floating-point numbers can use the `_` character as a _digit separator_, which can help when defining large numbers:

```csharp
int largeInt = 1_000_000;
// => 1000000

double largeDouble = 9_876_543.21;
// => 9876543.21
```
````

### File: introduction.md

**Purpose:** Provide a brief introduction to a student who has not yet completed the corresponding concept exercise.

This file is shown if a student has not yet completed the corresponding concept exercise. It should provide a brief introduction to the concept.

- Only information that is needed to understand the fundamentals of the concept should be provided. Extra information should be left for the `about.md` document.
- Links should be used sparingly, if at all. While a link explaining a complex topic like recursion might be useful, for most concepts the links will provide more information than needed so explaining things concisely inline should be the aim.
- Proper technical terms should be used so that the student can easily search for more information.
- Code examples should only be used to introduce new syntax (students should not need to search the web for examples of syntax). In other cases provide descriptions or links instead of code.

#### Example

````markdown
One of the key aspects of working with numbers in C# is the distinction between integers and floating-point numbers (numbers with zero or more digits after the decimal separator).

The two most commonly used numeric types in C# are `int` (a 32-bit integer) and `double` (a 64-bit floating-point number).

```csharp
int i = 123;
double d = 54.29;
```
````

### File: links.json

**Purpose:** Provide helpful links that provide more reading or information about a concept.

These might be official docs, a great tutorial, etc. These links do _not_ replace the more contextual links within a concept's `about.md` file, but provide a quick set of overarching reference points for a student.

Each link must contain the following fields:

- `url`: the URL it links to.
- `description`: a description of the link, which is shown as the link text.

Links can also optionally have an `icon_url` field, which can be used to customize the icon shown when the link is displayed. If not specified, the icon defaults to the favicon.

```json
[
  {
    "url": "https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp-local",
    "description": "Numbers in C#"
  },
  {
    "url": "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
    "description": "Integral numeric types",
    "icon_url": "http://test.org/icon.png"
  }
]
```
