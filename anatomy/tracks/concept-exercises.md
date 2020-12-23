_work in progress_

# Concept Exercises

The `exercises/concepts` directory contains the concept-exercise files. Each concept exercise listed in the [config.json file](./config.json#concept-exercises) should have its own directory within the `exercises/concepts` directory, named after the concept exercise's slug. Each concept exercise directory contains at least the following files:

TODO: describe files

Example:

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
        |   └── Example.cs (track-specific)
        ├── CarsAssemble.cs (track-specific)
        ├── CarsAssemble.csproj (track-specific)
        └── CarsAssembleTests.cs (track-specific)
</pre>
