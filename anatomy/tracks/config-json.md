_work in progress_

# config.json

The `config.json` file describes the track's configuration. It contains vital information like the track's exercises and concepts.

## Metadata

The following top-level properties contain general track metadata:

- `language`: the track's language (e.g. `"C#"`)
- `slug`: the track's language as a lowercased, kebab-case string (e.g. `"csharp"`)
- `active`: a `boolean` value indicating if the track is active (i.e. students can join the track on the website)
- `blurb`: a short description of the language
- `version`: the version of the `config.json` file (currently fixed to `3`)
- `online_editor`: an object describing settings used for the online editor:
  - `indent_style`: either `"space"` or `"tab"`
  - `indent_size`: the indentation size as an integer (e.g. `4`)

Example:

```json
{
  "language": "C#",
  "slug": "csharp",
  "active": true,
  "blurb": "C# is a modern, object-oriented language with lots of great features, such as type-inference and async/await. The tooling is excellent, and there is extensive, well-written documentation.",
  "version": 3,
  "online_editor": {
    "indent_style": "space",
    "indent_size": 4
  }
}
```

## Exercises

The top-level `exercises` key is an object with two keys:

- `concept`: this is an array listing the track's concept exercises
- `practice`: this is an array listing the track's practice exercises

### Concept exercises

Each concept exercise is an entry in the `exercises.concept` array. The following fields make up a concept exercise:

- `uuid`: a V4 UUID that uniquely identifies the exercise across all tracks
- `slug`: the exercise's slug, which is a lowercased, kebab-case string. The slug must be unique across all concept _and_ practice exercise slugs within the track
- `name`: the exercise's name
- `concepts`: an array of concept slugs that are taught by this concept exercise
- `prerequisites`: an array of concept slugs that must be unlocked before a student can start this exercise

Example:

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

### Practice exercises

Each concept exercise is an entry in the `exercises.practice` array. The following fields make up a concept exercise:

- `uuid`: a V4 UUID that uniquely identifies the exercise across all tracks
- `slug`: the exercise's slug, which is a lowercased, kebab-case string. The slug must be unique across all concept _and_ practice exercise slugs within the track
- `name`: the exercise's name
- `prerequisites`: an array of concept slugs that must be unlocked before a student can start this exercise
- `difficulty`: a number indicating the difficulty of the exercise. The number must be in the range of 0 (easiest) to 10 (hardest).

Example:

```json
{
  "exercises": {
    "concept": [
      {
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "slug": "leap",
        "name": "Leap",
        "prerequisites": ["if-statements", "numbers"],
        "difficulty": 1
      },
      ...
    ]
  }
}
```

## Concepts

Each concept is an entry in the top-level `concepts` array. The following fields make up a concept:

- `uuid`: a V4 UUID that uniquely identifies the concept across all tracks
- `slug`: the concept's slug, which is a lowercased, kebab-case string. The slug must be unique across all concepts within the track
- `name`: the concept's name
- `blurb`: a short description of the concept

Example:

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

## Key features

The language's key features succinctly describe what the most important features of the language are.

The key features are specified in the top-level `key_features` field which is defined as an array of objects with the following fields:

- `title`: a concise header for the key feature. Its length must be <= 25. Markdown is _not_ supported.
- `content`: a description of the key feature. Its length must be <= 100. Markdown is _not_ supported.
- `icon`: the icon to show for the feature. The following icons can be used:
  - TODO: list icons

At most 6 key features can be specified.

Example:

```json
{
  "key_features": [
    {
      "title": "Modern",
      "content": "C# is a modern, fast-evolving language.",
      "icon": "features-oop"
    },
    ...
  ]
}
```

## Tags

Tracks can be annotated with tags, which allows searching for tracks with a certain tag combination.

Tags are specified in the top-level `tags` field which is defined as an array of strings. The following tags can be used (grouped by category):

### Compilation target

- `compiles_to/binary`: the language compiles to a binary
- `compiles_to/bytecode`: the language compiles to bytecode
- `compiles_to/javascript`: the language compiles to JavaScript

### Paradigms

- `paradigm/declarative`: the language supports a declarative style of programming
- `paradigm/functional`: the language supports a function style of programming
- `paradigm/imperative`: the language supports an imperative style of programming
- `paradigm/logic`: the language supports a logic-based style of programming
- `paradigm/object_oriented`: the language supports an object-oriented style of programming
- `paradigm/procedural`: the language supports a procedural style of programming

### Typing

- `typing/static`: the language uses static typing
- `typing/dynamic`: the language uses dynamic typing

Note that it is perfectly fine to include multiple tags from a single category.

Example

```json
{
  "tags": [
    "compiles_to/bytecode",
    "runtime/common_language_runtime",
    "paradigm/declarative",
    "paradigm/functional",
    "paradigm/object_oriented",
    "typing/static"
  ]
}
```

### Example

This is an example of what a valid `config.json` file can look like:

```json
{
  "language": "C#",
  "slug": "csharp",
  "active": true,
  "blurb": "C# is a modern, object-oriented language with lots of great features, such as type-inference and async/await. The tooling is excellent, and there is extensive, well-written documentation.",
  "version": 3,
  "online_editor": {
    "indent_style": "space",
    "indent_size": 4
  },
  "exercises": {
    "concept": [
      {
        "slug": "lucians-luscious-lasagna",
        "name": "Lucian's Luscious Lasagna",
        "uuid": "7d358894-4fbd-4c91-b49f-d68f1c5aa6bc",
        "concepts": ["basics"],
        "prerequisites": []
      },
      {
        "slug": "cars-assemble",
        "name": "Cars, Assemble!",
        "uuid": "93fbc7cf-3a7e-4450-ad22-e30129c36bb9",
        "concepts": ["if-statements", "numbers"],
        "prerequisites": ["basics"]
      }
    ],
    "practice": [
      {
        "slug": "hello-world",
        "name": "Hello, World!",
        "uuid": "6c88f46b-5acb-4fae-a6ec-b48ae3f8168f",
        "prerequisites": ["basics"],
        "difficulty": 1
      },
      {
        "slug": "leap",
        "name": "Leap",
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "prerequisites": ["if-statements", "numbers"],
        "difficulty": 2
      }
    ]
  },
  "concepts": [
    {
      "uuid": "2eb4a463-355f-46ef-ac55-a75ec5afdf86",
      "slug": "basics",
      "name": "Basics",
      "blurb": "C# is a statically-typed language, which means that everything has a type at compile-time"
    },
    {
      "uuid": "4466e33e-dcd2-4b1f-9d9d-2c4315bf5188",
      "slug": "if-statements",
      "name": "If Statements",
      "blurb": "An `if` statement can be used to conditionally execute code."
    },
    {
      "uuid": "b9a421b2-c5ff-4213-bd6d-b886da31ea0d",
      "slug": "numbers",
      "name": "Numbers",
      "blurb": "C# has two types of numbers: integers and floating-point numbers."
    }
  ],
  "key_features": [
    {
      "icon": "features-oop",
      "title": "Modern",
      "content": "C# is a modern, fast-evolving language."
    },
    {
      "icon": "features-strongly-typed",
      "title": "Cross-platform",
      "content": "C# runs on almost any platform and chipset."
    },
    {
      "icon": "features-functional",
      "title": "Multi-paradigm",
      "content": "C# is primarily an object-oriented language, but also has lots of functional features."
    },
    {
      "icon": "features-lazy",
      "title": "General purpose",
      "content": "C# can be used for a wide variety of workloads, like websites, console applications, and even games."
    },
    {
      "icon": "features-declarative",
      "title": "Tooling",
      "content": "C# has excellent tooling, with linting and advanced refactoring options built-in."
    },
    {
      "icon": "features-generic",
      "title": "Documentation",
      "content": "Documentation is excellent and exhaustive, making it easy to get started with C#."
    }
  ],
  "tags": [
    "compiles_to/bytecode",
    "runtime/common_language_runtime",
    "paradigm/declarative",
    "paradigm/functional",
    "paradigm/object_oriented",
    "typing/static"
  ]
}
```
