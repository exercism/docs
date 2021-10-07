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

Here are some concepts with exercises:

| Concepts               | Exercises                                            |
| ---------------------- | ---------------------------------------------------- |
| Booleans               | [leap][leap]                                         |
| Conditionals           | [raindrops][raindrops]                               |
| Floating-point numbers | [darts][darts]                                       |
| Laziness               | [alphametics][alphametics]                           |
| Numbers                | [leap][leap]                                         |
| Strings                | [isogram][isogram],                                  |
| Trees                  | [binary-search-tree][binary-search-tree], [pov][pov] |

### Select exercises with varying degrees of difficulty

Some exercises will be more difficult to implement than others.
You should aim to implement exercises with varying degrees of difficulty: some easy ones, some intermediate ones and some hard ones.

How difficult an exercise is depends on several factors, such as the involved concepts and the track's language.
It might help to check what the exercise looks like in other tracks that have implemented the exercise, to better get feel for what the implementation could look like.

Here are some difficulties with exercises:

| Difficulty   | Exercises                                                                         |
| ------------ | --------------------------------------------------------------------------------- |
| Easy         | [darts][darts], [isogram][isogram], [leap][leap]                                  |
| Intermediate | [raindrops][raindrops]                                                            |
| Hard         | [alphametics][alphametics], [forth][forth], [react], [pov][pov], [zipper][zipper] |

### Select exercises that fit your track

Not all exercises may fit your track.
You should only select those exercises that fit your track; better to _not_ implement an exercise than to implement one that does not make sense.
As an example, the [lens-person exercise](https://github.com/exercism/problem-specifications/tree/main/exercises/lens-person) has the student working with _lenses_, which many languages don't support.

If you find an exercise that doesn't fit your track, you can add its slug to the `exercises.foregone` array in the [track config.json file](/docs/building/tracks/config-json).
This will ensure that tooling will ignore that exercise.

### Sample curriculum

To make this all a bit more concrete, this is what a sample selection of initial exercises could look like:

| Exercise                   | Difficulty   | Concepts                |
| -------------------------- | ------------ | ----------------------- |
| [hello-world][hello-world] | Easy         | None (initial exercise) |
| [darts][darts]             | Easy         | Floating-point numbers  |
| [isogram][isogram]         | Easy         | Strings                 |
| [leap][leap]               | Easy         | Numbers, booleans       |
| [raindrops][raindrops]     | Intermediate | Conditionals            |
| [alphametics][alphametics] | Hard         | Laziness                |
| [forth][forth]             | Hard         | Conditionals            |
| [react][react]             | Hard         | Conditionals            |
| [pov][pov]                 | Hard         | Conditionals            |
| [zipper][zipper]           | Hard         | Conditionals            |

## Implement exercises

Each exercise has three bits of information:

1. `description.md`: explains what the exercise is about (required)
2. `metadata.toml`: metadata like the exercise's blurb (required)
3. `canonical-data.json`: a set of input/output combinations that describe the behavior of the exercise (optional)

With this information, you should have all the information the `canonical-data.json` file, as

1. You can implement an exercise from

[alphametics]: https://github.com/exercism/problem-specifications/tree/main/exercises/alphametics
[binary-search-tree]: https://github.com/exercism/problem-specifications/tree/main/exercises/binary-search-tree
[darts]: https://github.com/exercism/problem-specifications/tree/main/exercises/darts
[forth]: https://github.com/exercism/problem-specifications/tree/main/exercises/forth
[hamming]: https://github.com/exercism/problem-specifications/tree/main/exercises/hamming
[hello-world]: https://github.com/exercism/problem-specifications/tree/main/exercises/hello-world
[isogram]: https://github.com/exercism/problem-specifications/tree/main/exercises/isogram
[leap]: https://github.com/exercism/problem-specifications/tree/main/exercises/leap
[lens-person]: https://github.com/exercism/problem-specifications/tree/main/exercises/lens-person
[pov]: https://github.com/exercism/problem-specifications/tree/main/exercises/pov
[raindrops]: https://github.com/exercism/problem-specifications/tree/main/exercises/raindrops
[react]: https://github.com/exercism/problem-specifications/tree/main/exercises/react
[two-bucket]: https://github.com/exercism/problem-specifications/tree/main/exercises/two-bucket
[zipper]: https://github.com/exercism/problem-specifications/tree/main/exercises/zipper
