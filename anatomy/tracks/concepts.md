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

- `about.md`: provide information about the concept for a student who has completed the corresponding concept exercise to learn from and refer back to (required)
- `introduction.md`: provide a brief introduction to a student who has not yet completed the corresponding concept exercise (required)
- `links.json`: provide helpful links that provide more reading or information about a concept (required)

### Example

<pre>
concepts
└── numbers
    ├── about.md
    ├── introduction.md
    └── links.json
</pre>

### File: about.md

**Purpose:** Provide more detailed information about the Concept for a student who has completed the corresponding Concept Exercise to learn from and refer back to.

**Presence:** Required

After completing the corresponding Concept Exercise (otherwise known as "learning" a Concept), the content of the Concept page will change from the introduction.md to the about.md. It should provide them with comprehensive information on what they need to know to be fluent in the concept. At a minimum, this file should contain all information that is introduced in the Concepts' [`introduction.md` document](./concepts.md#file-introductionmd).

If the Concept introduces new syntax, syntax samples should be included. The student should not have to follow a lot of links to gain the knowledge that the file tries to convey. Instead the `about.md` should contain enough information to be understandable within its content.

`about.md` is not limited to the scope of the corresponding Concept Exercise. The content can require knowledge of other concepts that will be introduced later on. If other Concepts are mentioned, their respective introductions should be linked (how?).

Here some examples of what could be covered.

- Popular usages for a Concept
- Common pitfalls in a Concept's use (e.g. casual use of multiple **threads**)
- Limitations on use that may catch out the unsuspecting developer
- Alternative approaches addressed in other Concepts (e.g. the ••recursion** Concept might reference that the **Higher Order Functions** Concept offers an alternative approach to similar problems).
- Compromises made for ease of learning or to accommodate the Exercism environment, e.g. multiple classes in single file
- Similar features with which the Concept may be confused
- Performance characteristics and memory usage, when a common consideration within that language.

It is **not** the aim of the `about.md` file to provide a complete set of information on the Concept. As an example, imagine a language that has some older features for which experienced programmers (and maybe even the official docs/specs) recommend they should not be used anymore. Providing details on such features would out of scope for the `about.md` file because they are not relevant to gain fluency. However, maintainers may choose to add a short block to acknowledge the old standards if a student might commonly come across those standards in the wild. However, this block should be commonly demarketed as such.

The `about.md` file MUST be clearly structured, especially when it contains a lot of information. In the future there will also be support for marking parts as "advanced topics" to point them out to interested students without overloading others.

#### Example

````markdown
# About

There are two different kinds of numbers in Elixir - integers and floats.

Floats are numbers with one or more digits behind the decimal separator. They use the 64-bit double precision floating-point format.

```elixir
float = 3.45
# => 3.45
```

Elixir also supports the scientific notation for floats.

```elixir
1.25e-2
# => 0.0125
```

## Rounding errors

Floats are infamous for their rounding errors.

```elixir
0.1 + 0.2
# => 0.30000000000000004
```

However, those kind of errors are not specific to Elixir. They happen in all programming languages. This is because all data on our computers is stored and processed as binary code. In binary, only fractions whose denominator can be expressed as `2^n` (e.g. `1/4`, `3/8`, `5/16`) can be expressed exactly. Other fractions are expressed as estimations.

```elixir
# 3/4
Float.ratio(0.75)
# => {3, 4}

# 3/5
Float.ratio(0.6)
# => {5404319552844595, 9007199254740992}
```

You can learn more about this problem at [0.30000000000000004.com][0.30000000000000004.com]. The [Float Toy page][evanw.github.io-float-toy] has a nice, graphical explanation how a floating-point number's bits are converted to an actual floating-point value.
````

### File: introduction.md

**Purpose:** Provide a brief introduction to a student who has not yet completed the corresponding concept exercise.

**Presence:** Required

This file is shown if a student has not yet completed the corresponding concept exercise. It should provide a brief introduction to the concept.

- Only information that is needed to understand the fundamentals of the concept should be provided. Extra information should be left for the `about.md` document.
- Links should be used sparingly, if at all. While a link explaining a complex topic like recursion might be useful, for most concepts the links will provide more information than needed so explaining things concisely inline should be the aim.
- Proper technical terms should be used so that the student can easily search for more information.
- Code examples should only be used to introduce new syntax (students should not need to search the web for examples of syntax). In other cases provide descriptions or links instead of code.

#### Example

````markdown
# Introduction

One of the key aspects of working with numbers in C# is the distinction between integers and floating-point numbers (numbers with zero or more digits after the decimal separator).

The two most commonly used numeric types in C# are `int` (a 32-bit integer) and `double` (a 64-bit floating-point number).

```csharp
int i = 123;
double d = 54.29;
```
````

### File: links.json

**Purpose:** Provide helpful links that provide more reading or information about a concept.

**Presence:** Required

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
