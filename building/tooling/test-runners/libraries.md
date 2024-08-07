# Libraries

Exercism aims to teach [fluency](/docs/using/product/fluency) in the syntax, idioms, and the standard library of the language.
This explicitly does _not_ mention external (non built-in) libraries, as that falls under _proficiency_.
Exercises must thus, with few exceptions, be solvable without using libraries.

## Reasons to support libraries

There are couple of reasons why a track might still want to support using libraries:

1. The language has a minimal standard library and it is idiomatic to use libraries to add functionality.
   An example of such a language is Rust.
2. The exercise is only really solvable using libraries.
   An example of such an exercise is the [lens-person exercise](https://exercism.org/exercises/lens-person), which in many languages can only be solved using a library.
3. The library adds testing functionality.
   An example is a library that adds support for property-based testing.

## Supporting libraries in the test runner

As the test runner does not have access to the internet whilst running, it is not possible to download libraries at run time.
The **only** solution to this problem is to install/download libraries at build time, where you _do_ have access to the internet.
In practice, this means you'll need to install/download libraries within the Dockerfile.

https://github.com/exercism/prolog-test-runner/blob/ed7447a7518ede6ee3405e649f50aaec828e318b/Dockerfile

## Documentation

If your track supports additional
(/docs/building/tracks/docs)
We recommend creating a document in the track repo's `docs` directory that lists the libraries that people can use, po
