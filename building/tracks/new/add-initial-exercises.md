# Add initial exercises

Once you've implemented the `hello-world` exercise, the next task is to implement 20+ other exercises.

## Exercise types

There are two types of exercises you can implement:

- Concept Exercises: they are designed to teach one or more concepts to a student. Check the [documentation](/docs/building/tracks/concept-exercises) for more information.
- Practice Exercises: they are designed to practice learned concepts. Check the [documentation](/docs/building/tracks/practice-exercises) for more information.

In general, we recommend new tracks start with implementing Practice Exercises, as they're easier to implement and require less thinking upfront.
Concept Exercises can always be added later, once you're track is up-and-running properly.

## Choose exercises

To help tracks implement Practice Exercises, we've created the [exercism/problem-specifications repository](https://github.com/exercism/problem-specifications).
This repository contains [metadata for over 100+ Practice Exercises](https://github.com/exercism/problem-specifications/tree/main/exercises), which different tracks can then use to implement their track-specific version of these exercises from.
For this reason, you'll see the same exercises implemented across many different tracks.

So how do you select the 20+ from this list of 100+ exercises?
Here are some guidelines.

### Select exercises that have students practice a wide variety of concepts

There is a lot of variety in concepts used in the 100+ exercises.
You should aim to implement exercises that have students practice a wide variety of concepts.
So instead of implementing 20 exercises that focus on strings, try to implement exercises that focus on different concepts.

Here are some concepts with sample exercises:

| Concepts               | Exercises                                                                            |
| ---------------------- | ------------------------------------------------------------------------------------ |
| Bit manipulation       | [allergies][allergies], [secret-handshake][secret-handshake]                         |
| Booleans               | [leap][leap]                                                                         |
| Classes                | [circular-buffer][circular-buffer], [robot-name][robot-name]                         |
| Concurrency            | [bank-account][bank-account]                                                         |
| Conditionals           | [raindrops][raindrops]                                                               |
| Dates and time         | [gigasecond][gigasecond], [meetup][meetup]                                           |
| Equality               | [clock][clock]                                                                       |
| Floating-point numbers | [darts][darts], [space-age][space-age]                                               |
| Laziness               | [alphametics][alphametics], [zebra-puzzle][zebra-puzzle]                             |
| Lists                  | [resistor-color][resistor-color], [spiral-matrix][spiral-matrix]                     |
| Loops                  | [collatz-conjecture][collatz-conjecture], [protein-translation][protein-translation] |
| Maps                   | [nucleotide-count][nucleotide-count]                                                 |
| Numbers                | [leap][leap], [grains][grains]                                                       |
| Randomness             | [dnd-character][dnd-character], [robot-name][robot-name]                             |
| Strings                | [bob][bob], [isogram][isogram],                                                      |
| Trees                  | [binary-search-tree][binary-search-tree], [pov][pov]                                 |

### Select exercises with varying degrees of difficulty

Some exercises will be more difficult to implement than others.
You should aim to implement exercises with varying degrees of difficulty: some easy ones, some intermediate ones and some hard ones.

How difficult an exercise is depends on several factors, such as the involved concepts and the track's language.
It might help to check what the exercise looks like in other tracks that have implemented the exercise, to better get a feel for what the implementation could look like.

Here are some difficulties with exercises:

| Difficulty   | Exercises                                                                                                                                                      |
| ------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Easy         | [darts][darts], [gigasecond][gigasecond], [isogram][isogram], [leap][leap], [resistor-color][resistor-color], [space-age][space-age]                           |
| Intermediate | [allergies][allergies], [bob][bob], [meetup][meetup], [protein-translation][protein-translation], [raindrops][raindrops], [secret-handshake][secret-handshake] |
| Hard         | [alphametics][alphametics], [forth][forth], [react], [pov][pov], [zebra-puzzle][zebra-puzzle], [zipper][zipper]                                                |

### Select exercises that fit your track

Not all exercises may fit your track.
You should only select those exercises that fit your track; better to _not_ implement an exercise than to implement one that does not make sense.
As an example, the [lens-person exercise](https://github.com/exercism/problem-specifications/tree/main/exercises/lens-person) has the student working with _lenses_, which many languages don't support.

If you find an exercise that doesn't fit your track, you can add its slug to the `exercises.foregone` array in the [track config.json file](/docs/building/tracks/config-json).
This will ensure that tooling will ignore that exercise.

### Sample curriculum

To make this all a bit more concrete, this is what a sample selection of initial exercises could look like:

| Exercise                                 | Difficulty   | Concepts                              |
| ---------------------------------------- | ------------ | ------------------------------------- |
| [hello-world][hello-world]               | Easy         | None (initial exercise)               |
| [leap][leap]                             | Easy         | Numbers, Booleans                     |
| [gigasecond][gigasecond]                 | Easy         | Dates and time                        |
| [isogram][isogram]                       | Easy         | Strings                               |
| [resistor-color][resistor-color]         | Easy         | Lists                                 |
| [nucleotide-count][nucleotide-count]     | Easy         | Maps                                  |
| [collatz-conjecture][collatz-conjecture] | Easy         | Loops                                 |
| [darts][darts]                           | Easy         | Floating-point numbers                |
| [two-fer][two-fer]                       | Easy         | String formatting, Optional arguments |
| [high-scores][high-scores]               | Easy         | Collection processing                 |
| [raindrops][raindrops]                   | Intermediate | Conditionals                          |
| [bob][bob]                               | Intermediate | Strings                               |
| [allergies][allergies]                   | Intermediate | Bit manipulation                      |
| [series][series]                         | Intermediate | Exceptions                            |
| [circular-buffer][circular-buffer]       | Intermediate | Classes                               |
| [meetup][meetup]                         | Intermediate | Dates and time                        |
| [yacht][yacht]                           | Intermediate | Lists                                 |
| [dominoes][dominoes]                     | Hard         | Tuples, Laziness                      |
| [diamond][diamond]                       | Hard         | String formatting                     |
| [alphametics][alphametics]               | Hard         | Laziness                              |
| [forth][forth]                           | Hard         | Parsing                               |

## Implement exercises

Having selected the exercises you want include in your track, the next step is to implement them.
Each of the above-mentioned exercises has three bits of information:

1. `description.md`: explains what the exercise is about (required)
2. `metadata.toml`: metadata like the exercise's blurb (required)
3. `canonical-data.json`: a set of input/output combinations that describe the behavior of the exercise (optional)

There are two options when implementing one of the above exercises:

1. Implement the exercise from scratch, using the test cases in the `canonical-data.json` file.
2. Port an implementation of the exercise from another track.

The second option can be particularly appealing, as it can give you results quickly.
Keep in mind, though, that you should tweak the implementation to best fit your track.
As an example, some tracks do not use classes but only work with functions.
If your track usually works with objects though, you should adapt the implementation to what best fits your track.

[allergies]: https://github.com/exercism/problem-specifications/tree/main/exercises/allergies
[alphametics]: https://github.com/exercism/problem-specifications/tree/main/exercises/alphametics
[bank-account]: https://github.com/exercism/problem-specifications/tree/main/exercises/bank-account
[binary-search-tree]: https://github.com/exercism/problem-specifications/tree/main/exercises/binary-search-tree
[bob]: https://github.com/exercism/problem-specifications/tree/main/exercises/bob
[circular-buffer]: https://github.com/exercism/problem-specifications/tree/main/exercises/circular-buffer
[clock]: https://github.com/exercism/problem-specifications/tree/main/exercises/clock
[collatz-conjecture]: https://github.com/exercism/problem-specifications/tree/main/exercises/collatz-conjecture
[darts]: https://github.com/exercism/problem-specifications/tree/main/exercises/darts
[diamond]: https://github.com/exercism/problem-specifications/tree/main/exercises/diamond
[dnd-character]: https://github.com/exercism/problem-specifications/tree/main/exercises/dnd-character
[dominoes]: https://github.com/exercism/problem-specifications/tree/main/exercises/dominoes
[forth]: https://github.com/exercism/problem-specifications/tree/main/exercises/forth
[gigasecond]: https://github.com/exercism/problem-specifications/tree/main/exercises/gigasecond
[grains]: https://github.com/exercism/problem-specifications/tree/main/exercises/grains
[hamming]: https://github.com/exercism/problem-specifications/tree/main/exercises/hamming
[hello-world]: https://github.com/exercism/problem-specifications/tree/main/exercises/hello-world
[high-scores]: https://github.com/exercism/problem-specifications/tree/main/exercises/high-scores
[isogram]: https://github.com/exercism/problem-specifications/tree/main/exercises/isogram
[leap]: https://github.com/exercism/problem-specifications/tree/main/exercises/leap
[lens-person]: https://github.com/exercism/problem-specifications/tree/main/exercises/lens-person
[meetup]: https://github.com/exercism/problem-specifications/tree/main/exercises/meetup
[nucleotide-count]: https://github.com/exercism/problem-specifications/tree/main/exercises/nucleotide-count
[pov]: https://github.com/exercism/problem-specifications/tree/main/exercises/pov
[protein-translation]: https://github.com/exercism/problem-specifications/tree/main/exercises/protein-translation
[raindrops]: https://github.com/exercism/problem-specifications/tree/main/exercises/raindrops
[react]: https://github.com/exercism/problem-specifications/tree/main/exercises/react
[resistor-color]: https://github.com/exercism/problem-specifications/tree/main/exercises/resistor-color
[robot-name]: https://github.com/exercism/problem-specifications/tree/main/exercises/robot-name
[secret-handshake]: https://github.com/exercism/problem-specifications/tree/main/exercises/secret-handshake
[series]: https://github.com/exercism/problem-specifications/tree/main/exercises/series
[space-age]: https://github.com/exercism/problem-specifications/tree/main/exercises/space-age
[spiral-matrix]: https://github.com/exercism/problem-specifications/tree/main/exercises/spiral-matrix
[two-bucket]: https://github.com/exercism/problem-specifications/tree/main/exercises/two-bucket
[two-fer]: https://github.com/exercism/problem-specifications/tree/main/exercises/two-fer
[yacht]: https://github.com/exercism/problem-specifications/tree/main/exercises/yacht
[zebra-puzzle]: https://github.com/exercism/problem-specifications/tree/main/exercises/zebra-puzzle
[zipper]: https://github.com/exercism/problem-specifications/tree/main/exercises/zipper
