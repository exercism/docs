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
- `status`: an object describing which v3 features should be enabled:
  - `concept_exercises`: a `boolean` value indicating if [Concept Exercises](./concept-exercises.md) have been built
  - `test_runner`: a `boolean` value indicating if a [test runner](../track-tooling/test-runners/README.md) has been implemented
  - `representer`: a `boolean` value indicating if a [representer](../track-tooling/representers/README.md) has been implemented
  - `analyzer`: a `boolean` value indicating if an [analyzer](../track-tooling/analyzers/README.md) has been implemented

### Example

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
  "status": {
    "concept_exercises": true,
    "test_runner": true,
    "representer": false,
    "analyzer": false
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
- `status` (optional): the exercise's status, which is one of `"wip"`, `"beta"` `"active"`, or `"deprecated"`; defaults to `"active"` if not specified
  - `wip`: A work-in-progress exercise not ready for public consumption. Exercises with this tag will not be shown to students on the UI or be used for unlocking logic. They may appear for maintainers.
  - `beta`: This signifies active exercises that are new and which we would like feedback on. We show a beta label on the site for these exercise, with a Call To Action of "Please give us feedback."
  - `active`: The normal state of active exercises
  - `deprecated`: Exercises that are no longer shown to students who have not started them (not usable at this stage).

#### Example

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

#### Example of work-in-progress

```json
{
  "exercises": {
    "concept": [
      {
        "uuid": "93fbc7cf-3a7e-4450-ad22-e30129c36bb9",
        "slug": "cars-assemble",
        "name": "Cars, Assemble!",
        "concepts": ["if-statements", "numbers"],
        "prerequisites": ["basics"],
        "status": "wip"
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
- `practices`: an array of concept slugs that the exercise is helping students practice
- `prerequisites`: an array of concept slugs that must be unlocked before a student can start the exercise
- `difficulty`: a number indicating the difficulty of the exercise. The number must be in the range of 0 (easiest) to 10 (hardest)
- `status` (optional): the exercise's status, which is either `"wip"`, `"beta"`, `"active"` or `"deprecated"`; defaults to `"active"` if not specified
  - `wip`: A work-in-progress exercise not ready for public consumption. Exercises with this tag will not be shown to students on the UI or be used for unlocking logic. They may appear for maintainers.
  - `beta`: This signifies active exercises that are new and which we would like feedback on. We show a beta label on the site for these exercise, with a Call To Action of "Please give us feedback"
  - `active`: The normal state of active exercises
  - `deprecated`: Exercises that are no longer shown to students who have not started them (not usable at this stage).

The "Recommended Order" of the Practice Exercises on the website corresponds with the order of the exercises in the `practice` array.

#### Example

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
      },
      ...
    ]
  }
}
```

#### Example of beta

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
        "difficulty": 1,
        "status": "beta"
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
- `blurb`: a short description of the concept. Markdown is _not_ supported.

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

## Key features

The language's key features succinctly describe what the most important features of the language are.

The key features are specified in the top-level `key_features` field which is defined as an array of objects with the following fields:

- `title`: a concise header for the key feature. Its length must be <= 25. Markdown is _not_ supported.
- `content`: a description of the key feature. Its length must be <= 100. Markdown is _not_ supported.
- `icon`: the icon to show for the feature. The following icons can be used:
  - TODO: list icons

Exactly 6 key features must be specified.

### Example

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

A track should choose their tags based on the general usage of their language. For example, imagine a student thinking: "I'd like to do machine learning, what language should I pick?", or "I'd like to learn functional programming, which language should I choose?". If your language would be a good candidate, give it that tag. If your language supports some functional ideas but they're rarely used, or a few people do Machine Learning in it, but it's rare, then do not apply those tags.

Tags are specified in the top-level `tags` field which is defined as an array of strings. The following tags can be used (grouped by category):

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
- `typing/strong`: the language uses strong typing
- `typing/weak`: the language uses weak typing

## Execution mode

- `execution_mode/compiled`: code is compiled first before being executed
- `execution_mode/interpreted`: code is interpreted directly

## Platform

- `platform/windows`: runs on Windows
- `platform/mac`: runs on Mac
- `platform/linux`: runs on Linux
- `platform/ios`: runs on iOS
- `platform/android`: runs on Android
- `platform/web`: runs on Browser

## Runtime

- `runtime/standalone_executable`: runs as standalone executable
- `runtime/language_specific`: runs on language-specific runtime
- `runtime/clr`: runs on Common Language Runtime (.NET)
- `runtime/jvm`: runs on JVM (Java)
- `runtime/beam`: runs on BEAM (Erlang)

## Used for

- `used_for/artificial_intelligence`: Artificial Intelligence
- `used_for/backends`: Backends
- `used_for/cross_platform_development`: Cross-platform development
- `used_for/embedded_systems`: Embedded systems
- `used_for/financial_systems`: Financial systems
- `used_for/frontends`: Frontends
- `used_for/games`: Games
- `used_for/guis`: GUIs
- `used_for/mobile`: Mobile
- `used_for/robotics`: Robotics
- `used_for/scientific_calculations`: Scientific calculations
- `used_for/scripts`: Scripts
- `used_for/web_development`: Web development

Note that it is perfectly fine to include multiple tags from a single category.

Example

```json
{
  "tags": [
    "runtime/jvm",
    "platform/windows",
    "platform/linux",
    "paradigm/declarative",
    "paradigm/functional",
    "paradigm/object_oriented"
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
  "status": {
    "concept_exercises": true,
    "test_runner": true,
    "representer": false,
    "analyzer": false
  },
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
        "prerequisites": ["basics"],
        "status": "wip"
      }
    ],
    "practice": [
      {
        "slug": "hello-world",
        "name": "Hello, World!",
        "uuid": "6c88f46b-5acb-4fae-a6ec-b48ae3f8168f",
        "practices": ["strings"],
        "prerequisites": ["basics"],
        "difficulty": 1
      },
      {
        "slug": "leap",
        "name": "Leap",
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "practices": ["if-statements", "numbers", "operator-precedence"],
        "prerequisites": ["if-statements", "numbers"],
        "difficulty": 2,
        "status": "beta"
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
    },
    {
      "uuid": "7a86561d-173b-45c0-a53c-1ffd7b9ff259",
      "slug": "strings",
      "name": "Strings",
      "blurb": "C# strings are immutable sequences of Unicode characters."
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
    "runtime/jvm",
    "platform/windows",
    "platform/linux",
    "paradigm/declarative",
    "paradigm/functional",
    "paradigm/object_oriented"
  ]
}
```
