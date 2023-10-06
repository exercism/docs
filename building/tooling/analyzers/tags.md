# Analyzer Tags

Analyzer tags are used to identify _how_ a solution was solved.

These tags can then be used to:

- Link a solution to approaches
- Link a solution to concepts
- Search for solutions with certain tags

## Format

A tag is a string that is formatted as: `"<category>:<thing>"`.

We support four different categories, going from highest to lowest level:

| Category    | Description                                     | Specificity                              |                                       | Examples |
| ----------- | ----------------------------------------------- | ---------------------------------------- | ------------------------------------- | -------- |
| `paradigm`  | A [programming paradigm][programming-paradigms] | Very high-level, not track-specific      | `imperative`, `functional`            |
| `technique` | A technique being used                          | High-level, most won't be track-specific | `recursion`, `immutability`           |
| `construct` | A language construct                            | Many won't be track-specific             | `bitwise-and`, `for-loop`             |
| `uses`      | Language-specific usage, like types or methods  | Low-level, track-specific                | `DateTime.add_seconds`, `IEnumerable` |

Some example tags:

- `"paradigm:functional"`
- `"technique:recursion"`
- `"construct:bitwise-and"`
- `"uses:DateTime.add_seconds"`

## Commonly used tags

Whilst tracks are free to tag solutions as they see fit, we recommend trying to use the below list of commonly used tags when possible.
Using a common set of tags will allow us to do some nifty things, like cross-track linking of solutions.

### Paradigm

| Tag                          | Description                                                      |
| ---------------------------- | ---------------------------------------------------------------- |
| `"paradigm:declarative"`     | Uses [declarative programming][declarative-programming].         |
| `"paradigm:functional"`      | Uses [functional programming][functional-programming].           |
| `"paradigm:generic"`         | Uses [generic programming][generic-programming].                 |
| `"paradigm:imperative"`      | Uses [imperative programming][imperative-programming].           |
| `"paradigm:logic"`           | Uses [logic programming][logic-programming].                     |
| `"paradigm:meta"`            | Uses [metaprogramming][metaprogramming].                         |
| `"paradigm:object-oriented"` | Uses [object-oriented programming][object-oriented-programming]. |
| `"paradigm:procedural"`      | Uses [procedural programming][procedural-programming].           |
| `"paradigm:reflective"`      | Uses [reflective programming][reflective-programming].           |

### Techniques

| Tag                                  | Description                                                                    |
| ------------------------------------ | ------------------------------------------------------------------------------ |
| `"technique:bit-manipulation"`       | Manipulating bits, usually via bitwise operators (e.g. AND, XOR or left shift) |
| `"technique:bit-shifting"`           | Using bit shifting (special case of `"technique:bit-manipulation"`)            |
| `"technique:boolean-logic"`          | Using boolean logic (AND, OR, NOT)                                             |
| `"technique:compound-assignment"`    | Using                                                                          |
| `"technique:concurrency"`            | Running code concurrently                                                      |
| `"technique:enumeration"`            |                                                                                |
| `"technique:equality-comparison"`    |                                                                                |
| `"technique:exceptions"`             |                                                                                |
| `"technique:higher-order-functions"` |                                                                                |
| `"technique:immutability"`           |                                                                                |
| `"technique:immutable-collection"`   |                                                                                |
| `"technique:inheritance"`            | Using inheritance                                                              |
| `"technique:laziness"`               |                                                                                |
| `"technique:locks"`                  | Using locks to get exclusive access to resources                               |
| `"technique:looping"`                |                                                                                |
| `"technique:memory-management"`      |                                                                                |
| `"technique:mutexes"`                |                                                                                |
| `"technique:ordering"`               |                                                                                |
| `"technique:parallelism"`            |                                                                                |
| `"technique:performance"`            |                                                                                |
| `"technique:pointers"`               |                                                                                |
| `"technique:randomness"`             |                                                                                |
| `"technique:recursion"`              |                                                                                |
| `"technique:regular-expression"`     |                                                                                |
| `"technique:sorted-collection"`      |                                                                                |
| `"technique:sorting"`                |                                                                                |
| `"technique:type-conversion"`        |                                                                                |
| `"technique:unsafe"`                 | Using unsafe code, e.g. pointer arithmetic                                     |

### Constructs

### Uses

As this category is language-specific, there are no commonly used tags here.

[declarative-programming]: https://en.wikipedia.org/wiki/Declarative_programming
[logic-programming]: https://en.wikipedia.org/wiki/Logic_programming
[object-oriented-programming]: https://en.wikipedia.org/wiki/Object-oriented_programming
[reflective-programming]: https://en.wikipedia.org/wiki/Reflective_programming
[metaprogramming]: https://en.wikipedia.org/wiki/Metaprogramming
[generic-programming]: https://en.wikipedia.org/wiki/Generic_programming
[imperative-programming]: https://en.wikipedia.org/wiki/Imperative_programming
[functional-programming]: https://en.wikipedia.org/wiki/Functional_programming
[procedural-programming]: https://en.wikipedia.org/wiki/Procedural_programming
[programming-paradigms]: https://en.wikipedia.org/wiki/Programming_paradigm
