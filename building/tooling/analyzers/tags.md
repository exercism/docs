# Analyzer Tags

Analyzer tags are used to identify _how_ a solution was solved.

These tags can then be used to:

- Link a solution to approaches
- Link a solution to concepts
- Search for solutions with certain tags

## Format

A tag is a string that is formatted as: `<category>:<thing>`.

We support four different categories, going from highest to lowest level:

| Category    | Description                                     | Specificity                              | Examples                              |
| ----------- | ----------------------------------------------- | ---------------------------------------- | ------------------------------------- |
| `paradigm`  | A [programming paradigm][programming-paradigms] | Very high-level, not track-specific      | `imperative`, `functional`            |
| `technique` | A technique being used                          | High-level, most won't be track-specific | `recursion`, `immutability`           |
| `construct` | A language construct                            | Many won't be track-specific             | `bitwise-and`, `for-loop`             |
| `uses`      | Language-specific usage, like types or methods  | Low-level, track-specific                | `DateTime.add_seconds`, `IEnumerable` |

Some example tags:

- `paradigm:functional`
- `technique:recursion`
- `construct:bitwise-and`
- `uses:DateTime.add_seconds`

## Commonly used tags

Whilst tracks are free to tag solutions as they see fit, we recommend trying to use the below list of commonly used tags when possible.
Using a common set of tags will allow us to do some nifty things, like cross-track linking of solutions.

### Paradigm

| Tag                        | Description                                                      |
| -------------------------- | ---------------------------------------------------------------- |
| `paradigm:declarative`     | Uses [declarative programming][declarative-programming].         |
| `paradigm:functional`      | Uses [functional programming][functional-programming].           |
| `paradigm:generic`         | Uses [generic programming][generic-programming].                 |
| `paradigm:imperative`      | Uses [imperative programming][imperative-programming].           |
| `paradigm:logic`           | Uses [logic programming][logic-programming].                     |
| `paradigm:meta`            | Uses [metaprogramming][metaprogramming].                         |
| `paradigm:object-oriented` | Uses [object-oriented programming][object-oriented-programming]. |
| `paradigm:procedural`      | Uses [procedural programming][procedural-programming].           |
| `paradigm:reflective`      | Uses [reflective programming][reflective-programming].           |
| `paradigm:stack-oriented`  | Uses [stack-oriented programming][stack-oriented-programming].   |

### Techniques

| Tag                                | Description                                                                    |
| ---------------------------------- | ------------------------------------------------------------------------------ |
| `technique:bit-manipulation`       | Manipulating bits, usually via bitwise operators (e.g. AND, XOR or left shift) |
| `technique:bit-shifting`           | Using bit shifting (special case of `technique:bit-manipulation`)              |
| `technique:boolean-logic`          | Using boolean logic (AND, OR, NOT)                                             |
| `technique:concurrency`            | Using concurrency                                                              |
| `technique:enumeration`            | Enumerating over values                                                        |
| `technique:exceptions`             | Working with exceptions                                                        |
| `technique:higher-order-functions` | Using higher-order functions                                                   |
| `technique:immutability`           | Using immutability                                                             |
| `technique:immutable-collection`   | Using immutable collections (special case of `technique:immutability`)         |
| `technique:inheritance`            | Using inheritance                                                              |
| `technique:laziness`               | Using laziness, where values are produced only when needed                     |
| `technique:locks`                  | Using locks to get exclusive access to resources                               |
| `technique:looping`                | Using loops                                                                    |
| `technique:memory-management`      | Managing memory                                                                |
| `technique:ordering`               | Ordering data                                                                  |
| `technique:parallelism`            | Running code in parallel                                                       |
| `technique:pointers`               | Using pointers                                                                 |
| `technique:randomness`             | Using randomness                                                               |
| `technique:recursion`              | Using recursion                                                                |
| `technique:regular-expression`     | Using regular expressions                                                      |
| `technique:short-circuiting`       | Use short-circuiting to prevent unnecessary evaluation                         |
| `technique:sorted-collection`      | Using sorted collections (special case of `technique:sorting`)                 |
| `technique:sorting`                | Sorting data                                                                   |
| `technique:type-conversion`        | Converting values from one type to another type                                |
| `technique:unsafe`                 | Using unsafe code, e.g. pointer arithmetic                                     |

### Constructs

| Tag                                          | Description                                                     |
| -------------------------------------------- | --------------------------------------------------------------- |
| `construct:abstract-method`                  | An abstract method                                              |
| `construct:assignment`                       | Assign/bind a value to a variable/name                          |
| `construct:catch`                            | Catch an exception                                              |
| `construct:constant`                         | A constant (immutable) value                                    |
| `construct:constructor`                      | A constructor                                                   |
| `construct:default-interface-implementation` | A default implementation in an interface                        |
| `construct:default`                          | A default value (e.g. for a parameter)                          |
| `construct:equality`                         | Compare equality of two values                                  |
| `construct:event`                            | An event                                                        |
| `construct:explicit-conversion`              | Exlicitly convert from one type to another type (aka "casting") |
| `construct:extension-method`                 | An extension method                                             |
| `construct:field`                            | A field                                                         |
| `construct:generic-function`                 | A function that is parameterized with one or more types         |
| `construct:generic-method`                   | A method that is parameterized with one or more types           |
| `construct:generic-type`                     | A type that is parameterized with one or more types             |
| `construct:getter`                           | A getter                                                        |
| `construct:implicit-conversion`              | Implicitly convert from one type to another type                |
| `construct:import`                           | Import functionality (e.g. from a namespace/module)             |
| `construct:indexer`                          | An indexer                                                      |
| `construct:inequality`                       | Compare inequality of two values                                |
| `construct:invocation`                       | An invocation of a method/function                              |
| `construct:lambda`                           | A lambda (aka an "anonymous function")                          |
| `construct:logical-and`                      | A logical AND                                                   |
| `construct:logical-not`                      | A logical NOT                                                   |
| `construct:logical-or`                       | A logical OR                                                    |
| `construct:method-overloading`               | Method overloading                                              |
| `construct:method-override`                  | An overridden method                                            |
| `construct:method`                           | A method                                                        |
| `construct:module`                           | A module (grouping of code)                                     |
| `construct:multiple-dispatch`                | Multiple dispatch                                               |
| `construct:named-argument`                   | An argument passed by name                                      |
| `construct:namespace`                        | A namespace (grouping of code)                                  |
| `construct:nested-function`                  | A nested function                                               |
| `construct:nested-type`                      | A nested type                                                   |
| `construct:nullability`                      | Nullability, dealing with `null` values                         |
| `construct:operator-overloading`             | Operator overloading                                            |
| `construct:optional-parameter`               | An optional parameter (doesn't have to be passed)               |
| `construct:parameter`                        | A parameter                                                     |
| `construct:pattern-matching`                 | Pattern matching                                                |
| `construct:property`                         | A property (getter/setter)                                      |
| `construct:setter`                           | A setter                                                        |
| `construct:throw`                            | Throw/raise an exception                                        |
| `construct:try`                              | Explicitly handle an exception                                  |
| `construct:type-inference`                   | Automatically infer the type of a value                         |
| `construct:type-test`                        | Test if a value has a specific type                             |
| `construct:varargs`                          | Allow passing in zero or more values for a parameter            |
| `construct:variable`                         | A variable                                                      |
| `construct:virtual-method`                   | A virtual method                                                |
| `construct:visibility-modifiers`             | Determine the visibility of a method/function                   |

#### Control flow

| Tag                              | Description                                  |
| -------------------------------- | -------------------------------------------- |
| `construct:async-await`          | An `async`/`await` statement                 |
| `construct:break`                | Break from a loop                            |
| `construct:conditional-access`   | Conditionally access a method                |
| `construct:conditional-operator` | A ternary conditional operator               |
| `construct:continue`             | Continue to the next iteration of a loop     |
| `construct:do-while-loop`        | A `do-while` loop                            |
| `construct:else`                 | An `else` statement                          |
| `construct:finally`              | Ensure that a certain code block always runs |
| `construct:for-loop`             | A `for` loop                                 |
| `construct:foreach`              | A `foreach` loop                             |
| `construct:if`                   | An `if` statement                            |
| `construct:return`               | Return from a function/method                |
| `construct:switch`               | A `switch`                                   |
| `construct:while-loop`           | A `while` loop                               |
| `construct:yield`                | Yield a value in a loop                      |

#### Arithmetic

| Tag                                        | Description                                  |
| ------------------------------------------ | -------------------------------------------- |
| `construct:add-assignment`                 | Addition and assignment combined             |
| `construct:add`                            | Addition                                     |
| `construct:bitwise-and-assignment`         | Bitwise AND and assignment combined          |
| `construct:bitwise-and`                    | Bitwise AND                                  |
| `construct:bitwise-left-shift-assignment`  | Bitwise left shift and assignment combined   |
| `construct:bitwise-left-shift`             | Bitwise left shift                           |
| `construct:bitwise-not`                    | Bitwise NOT                                  |
| `construct:bitwise-or-assignment`          | Bitwise OR and assignment combined           |
| `construct:bitwise-or`                     | Bitwise OR                                   |
| `construct:bitwise-right-shift-assignment` | Bitwise right shift and assignment combined  |
| `construct:bitwise-right-shift`            | Bitwise right shift                          |
| `construct:bitwise-xor-assignment`         | Bitwise XOR and assignment combined          |
| `construct:bitwise-xor`                    | Bitwise XOR                                  |
| `construct:checked-arithmetic`             | Checked arithmetic (guard against overflows) |
| `construct:divide-assignment`              | Division and assignment combined             |
| `construct:divide`                         | Division                                     |
| `construct:modulo-assignment`              | Division remainder and assignment combined   |
| `construct:modulo`                         | Division remainder                           |
| `construct:multiply-assignment`            | Multiplication and assignment combined       |
| `construct:multiply`                       | Multiplication                               |
| `construct:overflow`                       | Arithmetic overflow                          |
| `construct:postfix-decrement`              | Decrement a value using postfix notation     |
| `construct:postfix-increment`              | Increment a value using postfix notation     |
| `construct:prefix-decrement`               | Decrement a value using prefix notation      |
| `construct:prefix-increment`               | Increment a value using prefix notation      |
| `construct:subtract-assignment`            | Subtraction and assignment combined          |
| `construct:subtract`                       | Subtraction                                  |
| `construct:unary-minus`                    | Unary minus                                  |
| `construct:unary-plus`                     | Unary plus                                   |

#### Value types

| Tag                   | Description                                                |
| --------------------- | ---------------------------------------------------------- |
| `construct:boolean`   | A boolean                                                  |
| `construct:char`      | A character                                                |
| `construct:date-time` | A combination of date + time                               |
| `construct:date`      | A date (no time)                                           |
| `construct:enum`      | An enum (enumeration of values)                            |
| `construct:null`      | Represents the absence of a value (something called `nil`) |
| `construct:number`    | A number (signed or unsigned)                              |
| `construct:string`    | A string                                                   |
| `construct:time`      | A time (no date)                                           |

#### Integral types

| Tag                         | Description                                           |
| --------------------------- | ----------------------------------------------------- |
| `construct:big-integer`     | A big integer                                         |
| `construct:byte`            | An unsigned 8-bit integer                             |
| `construct:int`             | A signed 32-bit integer                               |
| `construct:integral-number` | An integral number (integer)                          |
| `construct:long`            | A signed 64-bit integer                               |
| `construct:nint`            | A signed platform-specific integer (32- or 64-bit)    |
| `construct:nuint`           | An unsigned platform-specific integer (32- or 64-bit) |
| `construct:sbyte`           | A signed 8-bit integer                                |
| `construct:short`           | A signed 16-bit integer                               |
| `construct:uint`            | An unsigned 32-bit integer                            |
| `construct:ulong`           | An unsigned 64-bit integer                            |
| `construct:ushort`          | An unsigned 16-bit integer                            |

#### Floating-point types

| Tag                               | Description                     |
| --------------------------------- | ------------------------------- |
| `construct:decimal`               | A 128-bit floating-point number |
| `construct:double`                | A 64-bit floating-point number  |
| `construct:float`                 | A 32-bit floating-point number  |
| `construct:floating-point-number` | A floating-point number         |

#### Composite types

| Tag                                | Description                                                      |
| ---------------------------------- | ---------------------------------------------------------------- |
| `construct:abstract-class`         | An abstract class                                                |
| `construct:class`                  | A class                                                          |
| `construct:exception`              | An exception                                                     |
| `construct:interface`              | An interface                                                     |
| `construct:option`                 | An option type                                                   |
| `construct:record`                 | A record (usually immutable)                                     |
| `construct:struct`                 | A struct                                                         |
| `construct:sum-type`               | A sum type                                                       |
| `construct:tuple`                  | A tuple                                                          |
| `construct:union-type`             | A union type                                                     |
| `construct:user-defined-exception` | A user-defined exception (special case of `construct:exception`) |

#### Collection types

| Tag                                 | Description                                         |
| ----------------------------------- | --------------------------------------------------- |
| `construct:array`                   | An array                                            |
| `construct:bit-array`               | A bit array (similar to an array but works on bits) |
| `construct:dictionary`              | A dictionary (aka map)                              |
| `construct:jagged-array`            | A jagged array (an array of arrays)                 |
| `construct:linked-list`             | A linked list (special case of `construct:list`)    |
| `construct:list`                    | A list                                              |
| `construct:multi-dimensional-array` | An array with multiple dimensions                   |
| `construct:queue`                   | A queue                                             |
| `construct:set`                     | A set                                               |
| `construct:stack`                   | A stack                                             |

#### Notation

| Tag                                    | Description                                     |
| -------------------------------------- | ----------------------------------------------- |
| `construct:binary-number`              | A number in binary notation                     |
| `construct:hexadecimal-number`         | A number in hexadecimal notation                |
| `construct:multiline-string`           | A multiline string                              |
| `construct:octal-number`               | A number in octal notation                      |
| `construct:scientific-notation-number` | A number in scientific notation                 |
| `construct:string-interpolation`       | An interpolated string                          |
| `construct:underscored-number`         | A number using underscores as a digit separator |
| `construct:verbatim-string`            | A verbatim string (no escape sequences)         |

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
[stack-oriented-programming]: https://en.wikipedia.org/wiki/Stack-oriented_programming
