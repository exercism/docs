# Libraries

Exercism aims to teach [fluency](/docs/using/product/fluency) in the syntax, idioms, and the standard library of the language.
This explicitly does _not_ mention external (non built-in) libraries, as that falls under _proficiency_.
Exercises must thus, with few exceptions, be solvable without using libraries.

## Reasons to support libraries

There are couple of reasons why a track might still want to support libraries:

1. The language has a (very) minimal standard library.
   An example of such a language is Rust.
2. The library adds testing functionality.
   An example is a library that adds support for property-based testing.
3. The exercise can only be solved using a library.
   An example of such an exercise is the [lens-person exercise](https://exercism.org/exercises/lens-person), which in most languages can only be solved using a library.

## Supporting libraries in the test runner

As the test runner does not have access to the internet whilst running, it is not possible to download libraries at run time.
The **only** solution to this problem is to install/download libraries at build time, where you _do_ have access to the internet.
In practice, this means you'll need to install/download libraries within the Dockerfile.

As an example, the [Prolog test runner's Dockerfile](https://github.com/exercism/prolog-test-runner/blob/ed7447a7518ede6ee3405e649f50aaec828e318b/Dockerfile) installs the `date_time` library:

```dockerfile
RUN swipl pack install date_time -y
```

## Documentation

If your track supports libraries, this should be documented in a [track doc](/docs/building/tracks/docs).
Please also link to this document (using its full URL) from the [`exercises/shared/.docs/help.md` document](/docs/building/tracks/shared-files#file-help-md).
