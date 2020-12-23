_work in progress_

# Concepts

The `concepts` directory contains concept-specific information. Each concept listed in the [config.json file](./config.json#concepts) should have its own directory within the `concepts` directory, named after the concept's slug. Each concept directory contains the following files:

- `about.md`: provide information about the concept for a student to learn from.
- `introduction.md`: provide information about the concept for use in the introduction of an exercise. (pending agreement on https://github.com/exercism/v3/issues/2767)
- `links.json`: provide helpful links that provide more reading or information about a concept.

Example:

<pre>
concepts
└── numbers
    ├── about.md.md
    ├── introduction.md (pending agreement on https://github.com/exercism/v3/issues/2767)
    └── links.json
</pre>

## Links

The `links.json` file contains an array of objects with the following fields:

- `url`: the URL of the resource to link to
- `description`: the description of the link that is displayed on the website

Example:

```json
[
  {
    "url": "https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/strings",
    "description": "Strings"
  },
  ...
]
```
