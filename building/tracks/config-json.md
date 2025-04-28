# config.json

The `config.json` file describes the track's configuration. It contains vital information like the track's exercises and concepts.

## Metadata

The following top-level properties contain general track metadata:

- `language`: the track's language (e.g. `"C#"`). Its length must be <= 255. (required)
- `slug`: the track's language as a lowercased, kebab-case string (e.g. `"csharp"`). Its length must be <= 255. (required)
- `active`: a `boolean` value indicating if the track is active (i.e. students can join the track on the website) (required)
- `blurb`: a short description of the language. Its length must be <= 400. (required)
- `version`: the version of the `config.json` file (currently fixed to `3`) (required)
- `online_editor`: an object describing settings used for the online editor: (required)
  - `indent_style`: either `"space"` or `"tab"` (required)
  - `indent_size`: the indentation size as an integer (e.g. `4`) (required)
  - `highlightjs_language`: the language identifier for Highlight.js (see the [full list of identifiers](https://github.com/highlightjs/highlight.js/blob/main/SUPPORTED_LANGUAGES.md)) (optional)
- `status`: an object describing which v3 features should be enabled: (required)
  - `concept_exercises`: a `boolean` value indicating if [Concept Exercises](/docs/building/tracks/concept-exercises) have been built (required). When `true` the Exercism website interface changes to indicate that concept exercises are available for the track.
  - `test_runner`: a `boolean` value indicating if a [test runner](/docs/building/tooling/test-runners) has been implemented (required). When `true` we put submitted solutions through our testing infrastructure and show the results on the website. The website also allows students to initiate a test run from within the online editor.
  - `representer`: a `boolean` value indicating if a [representer](/docs/building/tooling/representers) has been implemented (required)
  - `analyzer`: a `boolean` value indicating if an [analyzer](/docs/building/tooling/analyzers) has been implemented (required)
- `files`: The patterns for the locations of the files used in an exercise, relative to the exercise's directory. (optional)
  - `solution`: stub implementation file(s) pattern (optional)
  - `test`: test file(s) pattern (optional)
  - `example`: example implementation file(s) pattern (optional)
  - `exemplar`: exemplar implementation file(s) pattern (optional)
  - `editor`: additional read-only editor file(s) patterns (optional)
- `test_runner`: an object describing the track's test runner (if any): (required if `status.test_runner` is `true`)
  - `average_run_time`: an integer `number` value for the number of seconds the test runner takes on average to run (e.g. `4`) (required if `status.test_runner` is `true`)
- `approaches`: an object with metadata on the track's approaches: (required if the track has any approaches)
  - `snippet_extension`: a string value used for the snippet file's extension (e.g. `rb`) (required if the track has any approaches)

### Files

This key is used to specify track-wide file locations. Rather than maintainers having to manually set the `files` key in the _exercises_' `config.json` files, [configlet](/docs/building/configlet) can automatically populate it using these track-wide patterns.

The file patterns defined in the `files` object support the following placeholders:

- `%{kebab_slug}`: the `kebab-case` exercise slug (e.g. `bit-manipulation`)
- `%{snake_slug}`: the `snake_case` exercise slug (e.g. `bit_manipulation`)
- `%{camel_slug}`: the `camelCase` exercise slug (e.g. `bitManipulation`)
- `%{pascal_slug}`: the `PascalCase` exercise slug (e.g. `BitManipulation`)

Support will be added to [configlet](/docs/building/configlet) to use these pattern to populate the `files` key in an exercise's `.meta/config.json` file.

### Example

<!-- prettier-ignore-start -->
```json
{
  "language": "C#",
  "slug": "csharp",
  "active": true,
  "status": {
    "concept_exercises": true,
    "test_runner": true,
    "representer": false,
    "analyzer": false
  },
  "blurb": "C# is a modern, object-oriented language with lots of great features, such as type-inference and async/await. The tooling is excellent, and there is extensive, well-written documentation.",
  "version": 3,
  "online_editor": {
    "indent_style": "space",
    "indent_size": 4,
    "highlightjs_language": "csharp"
  },
  "test_runner": {
    "average_run_time": 2
  },
  "files": {
    "solution": [
      "%{pascal_slug}.cs"
    ],
    "test": [
      "%{pascal_slug}Tests.cs"
    ],
    "example": [
      ".meta/Example.cs"
    ],
    "exemplar": [
      ".meta/Exemplar.cs"
    ]
  }
}
```
<!-- prettier-ignore-end -->

## Exercises

The top-level `exercises` key is an object with three possible keys:

- `concept`: this is an array listing the track's concept exercises
- `practice`: this is an array listing the track's practice exercises
- `foregone`: this is an array listing the slugs of exercises the track won't implement

### Concept exercises

Each concept exercise is an entry in the `exercises.concept` array.
Exercises are ordered on the website in the same order they are listed in this file, and should match the typical order in which they should be solved.
The following fields make up a concept exercise:

- `uuid`: a V4 UUID that uniquely identifies the exercise. The UUID must be unique both within the track as well as across all tracks, and must never change
- `slug`: the exercise's slug, which is a lowercased, kebab-case string. The slug must be unique across all concept _and_ practice exercise slugs within the track. Its length must be <= 255.
- `name`: the exercise's name. Its length must be <= 255.
- `concepts`: an array of concept slugs that are taught by this concept exercise
- `prerequisites`: an array of concept slugs that must be unlocked before a student can start this exercise
- `status` (optional): the exercise's status, which is one of `"wip"`, `"beta"` `"active"`, or `"deprecated"`; defaults to `"active"` if not specified
  - `wip`: A work-in-progress exercise not ready for public consumption. Exercises with this tag will not be shown to students on the UI or be used for unlocking logic. They may appear for maintainers.
  - `beta`: This signifies active exercises that are new and which we would like feedback on. We show a beta label on the site for these exercise, with a Call To Action of "Please give us feedback."
  - `active`: The normal state of active exercises
  - `deprecated`: Exercises that are no longer shown to students who have not started them (not usable at this stage). See [Deprecated Exercises](/docs/building/tracks/deprecated-exercises) for more information.

#### Example

<!-- prettier-ignore-start -->
```json
{
  "exercises": {
    "concept": [
      {
        "slug": "cars-assemble",
        "name": "Cars, Assemble!",
        "uuid": "93fbc7cf-3a7e-4450-ad22-e30129c36bb9",
        "concepts": [
          "if-statements",
          "numbers"
        ],
        "prerequisites": [
          "basics"
        ]
      },
      ...
    ]
  }
}
```
<!-- prettier-ignore-end -->

#### Example of work-in-progress

<!-- prettier-ignore-start -->
```json
{
  "exercises": {
    "concept": [
      {
        "slug": "cars-assemble",
        "name": "Cars, Assemble!",
        "uuid": "93fbc7cf-3a7e-4450-ad22-e30129c36bb9",
        "concepts": [
          "if-statements",
          "numbers"
        ],
        "prerequisites": [
          "basics"
        ],
        "status": "wip"
      },
      ...
    ]
  }
}
```
<!-- prettier-ignore-end -->

### Practice exercises

Each practice exercise is an entry in the `exercises.practice` array. The following fields make up a practice exercise:

- `uuid`: a V4 UUID that uniquely identifies the exercise. The UUID must be unique both within the track as well as across all tracks, and must never change
- `slug`: the exercise's slug, which is a lowercased, kebab-case string. The slug must be unique across all concept _and_ practice exercise slugs within the track. Its length must be <= 255.
- `name`: the exercise's name. Its length must be <= 255.
- `practices`: an array of concept slugs that the exercise is helping students practice
- `prerequisites`: an array of concept slugs that must be unlocked before a student can start the exercise
- `difficulty`: a number indicating the difficulty of the exercise. The number must be in the range of 1 (easiest) to 10 (hardest). The website interprets the difficulty as follows:
  - 1,2,3: easy
  - 4,5,6,7: medium
  - 8,9,10: hard
- `status` (optional): the exercise's status, which is either `"wip"`, `"beta"`, `"active"` or `"deprecated"`; defaults to `"active"` if not specified
  - `wip`: A work-in-progress exercise not ready for public consumption. Exercises with this tag will not be shown to students on the UI or be used for unlocking logic. They may appear for maintainers.
  - `beta`: This signifies active exercises that are new and which we would like feedback on. We show a beta label on the site for these exercise, with a Call To Action of "Please give us feedback"
  - `active`: The normal state of active exercises
  - `deprecated`: Exercises that are no longer shown to students who have not started them (not usable at this stage).

The "Recommended Order" of the Practice Exercises on the website corresponds with the order of the exercises in the `practice` array.

#### Example

<!-- prettier-ignore-start -->
```json
{
  "exercises": {
    "practice": [
      {
        "slug": "leap",
        "name": "Leap",
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "practices": [
          "if-statements",
          "numbers",
          "operator-precedence"
        ],
        "prerequisites": [
          "if-statements",
          "numbers"
        ],
        "difficulty": 1
      },
      ...
    ]
  }
}
```
<!-- prettier-ignore-end -->

#### Example of beta

<!-- prettier-ignore-start -->
```json
{
  "exercises": {
    "practice": [
      {
        "slug": "leap",
        "name": "Leap",
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "practices": [
          "if-statements",
          "numbers",
          "operator-precedence"
        ],
        "prerequisites": [
          "if-statements",
          "numbers"
        ],
        "difficulty": 1,
        "status": "beta"
      },
      ...
    ]
  }
}
```
<!-- prettier-ignore-end -->

### Foregone exercises

If a track knows that it doesn't want to implement an exercise defined in the [Problem Specifications repo](https://github.com/exercism/problem-specifications), the slug of that exercise can be added to the `exercises.foregone` key. [configlet](/docs/building/configlet) will ignore foregone exercises when outputting the track's unimplemented exercises.

Reasons for why an track might _not_ want to implement an exercise could be:

- The exercise can't reasonably be implemented by the language. As an example, the [lens-person exercise](https://github.com/exercism/problem-specifications/blob/main/exercises/lens-person/description.md) requires the language to support _lenses_.
- The exercise's topic doesn't fit the language. For example, for some high-level languages, a low-level bit-manipulation exercise might not make sense.

#### Example

<!-- prettier-ignore-start -->
```json
{
  "exercises": {
    "foregone": [
      "lens-person"
    ]
  }
}
```
<!-- prettier-ignore-end -->

## Concepts

Each concept is an entry in the top-level `concepts` array. The following fields make up a concept:

- `uuid`: a V4 UUID that uniquely identifies the concept. The UUID must be unique both within the track as well as across all tracks, and must never change
- `slug`: the concept's slug, which is a lowercased, kebab-case string. The slug must be unique across all concepts within the track. Its length must be <= 255.
- `name`: the concept's name. Its length must be <= 255.
- `tags`: Specify the conditions for when a submission is linked to an approach. (optional)
  - `all`: An array of tags that must all be present on a submission (optional, unless `any` has no elements)
  - `any`: An array of tags of which at least one must be present on a submission (optional, unless `all` has no elements)
  - `not`: none of the tags must be present on a submission (optional)

### Example

<!-- prettier-ignore-start -->
```json
{
  "concepts": [
    {
      "uuid": "b9a421b2-c5ff-4213-bd6d-b886da31ea0d",
      "slug": "numbers",
      "name": "Numbers",
      "tags": {
        "all": [
          "concept:number"
        ]
      }
    }
  ]
}
```
<!-- prettier-ignore-end -->

## Key features

The language's key features succinctly describe what the most important features of the language are.
They are intended to promote the more interesting features of a language to potential students.
Titles should strive to use as little technical jargon as possible, bearing in mind that students might not be familiar with what language-specific jargon means before learning that language.

The key features are specified in the top-level `key_features` field which is defined as an array of objects with the following fields:

- `title`: a concise header for the key feature. Its length must be <= 25. Markdown is _not_ supported.
- `content`: a description of the key feature. Its length must be <= 100. Markdown is _not_ supported.
- `icon`: the icon to show for the feature. You can choose an icon that you think fits, regardless of its name. The following icons can be used:
  - `community`
  - `concurrency`
  - `cross-platform`
  - `documentation`
  - `dynamically-typed`
  - `easy`
  - `embeddable`
  - `evolving`
  - `expressive`
  - `extensible`
  - `fast`
  - `fun`
  - `functional`
  - `garbage-collected`
  - `general-purpose`
  - `homoiconic`
  - `immutable`
  - `interactive`
  - `interop`
  - `multi-paradigm`
  - `portable`
  - `powerful`
  - `productive`
  - `safe`
  - `scientific`
  - `small`
  - `stable`
  - `statically-typed`
  - `tooling`
  - `web`
  - `widely-used`

You can check the visual appearance of these icons on the [key feature icons section][key-feature-icons].

Exactly 6 key features must be specified.

### Example

<!-- prettier-ignore-start -->
```json
{
  "key_features": [
    {
      "title": "Fault-tolerant",
      "content": "Elixir runs on the Erlang VM, known for running low-latency, distributed and fault-tolerant systems.",
      "icon": "safe"
    },
    ...
  ],
}
```
<!-- prettier-ignore-end -->

## Tags

Tracks can be annotated with tags, which allows searching for tracks with a certain tag combination.

A track should choose their tags based on the general usage of their language. For example, imagine a student thinking: "I'd like to do machine learning, what language should I pick?", or "I'd like to learn functional programming, which language should I choose?". If your language would be a good candidate, give it that tag. If your language supports some functional ideas but they're rarely used, or a few people do Machine Learning in it, but it's rare, then do not apply those tags.

Tags are specified in the top-level `tags` field which is defined as an array of strings. The following tags can be used (grouped by category):

### Paradigms

- `paradigm/array`: the language is an array programming language
- `paradigm/declarative`: the language supports a declarative style of programming
- `paradigm/functional`: the language supports a function style of programming
- `paradigm/imperative`: the language supports an imperative style of programming
- `paradigm/logic`: the language supports a logic-based style of programming
- `paradigm/object_oriented`: the language supports an object-oriented style of programming
- `paradigm/procedural`: the language supports a procedural style of programming
- `paradigm/stack-oriented`: the language supports a stack-oriented style of programming

### Typing

- `typing/static`: the language uses static typing
- `typing/gradual`: the language uses gradual typing
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
- `runtime/wasmtime`: runs on Wasmtime (WebAssembly)

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

<!-- prettier-ignore-start -->
```json
{
  "tags": [
    "paradigm/declarative",
    "paradigm/functional",
    "paradigm/object_oriented",
    "platform/linux",
    "platform/windows",
    "runtime/jvm"
  ]
}
```
<!-- prettier-ignore-end -->

### Example

This is an example of what a valid `config.json` file can look like:

<!-- prettier-ignore-start -->
```json
{
  "language": "C#",
  "slug": "csharp",
  "active": true,
  "status": {
    "concept_exercises": true,
    "test_runner": true,
    "representer": false,
    "analyzer": false
  },
  "blurb": "C# is a modern, object-oriented language with lots of great features, such as type-inference and async/await. The tooling is excellent, and there is extensive, well-written documentation.",
  "version": 3,
  "online_editor": {
    "indent_style": "space",
    "indent_size": 4,
    "highlightjs_language": "csharp"
  },
  "test_runner": {
    "average_run_time": 2
  },
  "files": {
    "solution": [
      "%{pascal_slug}.cs"
    ],
    "test": [
      "%{pascal_slug}Tests.cs"
    ],
    "example": [
      ".meta/Example.cs"
    ],
    "exemplar": [
      ".meta/Exemplar.cs"
    ]
  },
  "exercises": {
    "concept": [
      {
        "slug": "lucians-luscious-lasagna",
        "name": "Lucian's Luscious Lasagna",
        "uuid": "7d358894-4fbd-4c91-b49f-d68f1c5aa6bc",
        "concepts": [
          "basics"
        ],
        "prerequisites": []
      },
      {
        "slug": "cars-assemble",
        "name": "Cars, Assemble!",
        "uuid": "93fbc7cf-3a7e-4450-ad22-e30129c36bb9",
        "concepts": [
          "if-statements",
          "numbers"
        ],
        "prerequisites": [
          "basics"
        ],
        "status": "wip"
      }
    ],
    "practice": [
      {
        "slug": "hello-world",
        "name": "Hello, World!",
        "uuid": "6c88f46b-5acb-4fae-a6ec-b48ae3f8168f",
        "practices": [
          "strings"
        ],
        "prerequisites": [
          "basics"
        ],
        "difficulty": 1
      },
      {
        "slug": "leap",
        "name": "Leap",
        "uuid": "8ba15933-29a2-49b1-a9ce-70474bad3007",
        "practices": [
          "if-statements",
          "numbers",
          "operator-precedence"
        ],
        "prerequisites": [
          "if-statements",
          "numbers"
        ],
        "difficulty": 2,
        "status": "beta"
      }
    ]
  },
  "concepts": [
    {
      "uuid": "2eb4a463-355f-46ef-ac55-a75ec5afdf86",
      "slug": "basics",
      "name": "Basics"
    },
    {
      "uuid": "4466e33e-dcd2-4b1f-9d9d-2c4315bf5188",
      "slug": "if-statements",
      "name": "If Statements"
    },
    {
      "uuid": "b9a421b2-c5ff-4213-bd6d-b886da31ea0d",
      "slug": "numbers",
      "name": "Numbers"
    },
    {
      "uuid": "7a86561d-173b-45c0-a53c-1ffd7b9ff259",
      "slug": "strings",
      "name": "Strings"
    }
  ],
  "key_features": [
    {
      "title": "Modern",
      "content": "C# is a modern, fast-evolving language.",
      "icon": "expressive"
    },
    {
      "title": "Cross-platform",
      "content": "C# runs on almost any platform and chipset.",
      "icon": "cross-platform"
    },
    {
      "title": "Multi-paradigm",
      "content": "C# is primarily an object-oriented language, but also has lots of functional features.",
      "icon": "multi-paradigm"
    },
    {
      "title": "General purpose",
      "content": "C# can be used for a wide variety of workloads, like websites, console applications, and even games.",
      "icon": "general-purpose"
    },
    {
      "title": "Tooling",
      "content": "C# has excellent tooling, with linting and advanced refactoring options built-in.",
      "icon": "tooling"
    },
    {
      "title": "Documentation",
      "content": "Documentation is excellent and exhaustive, making it easy to get started with C#.",
      "icon": "documentation"
    }
  ],
  "tags": [
    "paradigm/declarative",
    "paradigm/functional",
    "paradigm/object_oriented",
    "platform/linux",
    "platform/windows",
    "runtime/jvm"
  ]
}
```
<!-- prettier-ignore-end -->

[key-feature-icons]: /docs/building/tracks/icons#h-key-feature-icons
