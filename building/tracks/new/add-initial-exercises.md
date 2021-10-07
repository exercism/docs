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

Some exercises have students work with strings, others with numbers, and others with strings, numbers and classes.
There is a lot of variety

### Select exercises with varying degrees of difficulty

Some exercises will be more difficult to implement than others.
You should aim to implement exercises with varying degrees of difficulty: some easy ones, some intermediate ones and some hard ones.

How difficult an exercise is depends on several factors, such as the involved concepts and the track's language.
It might help to check what the exercise looks like in other tracks that have implemented the exercise, to better get feel for what the implementation could look like.

### Select exercises that fit your track

Not all exercises may fit your track.
You should only select those exercises that fit your track; better to _not_ implement an exercise than to implement one that does not make sense.
As an example, the [lens-person exercise](https://github.com/exercism/problem-specifications/tree/main/exercises/lens-person) has the student working with _lenses_, which many languages don't support.

If you find an exercise that doesn't fit your track, you can add its slug to the `exercises.foregone` array in the [track config.json file](/docs/building/tracks/config-json).
This will ensure that tooling will ignore that exercise.

### Sample curriculum

Exercise | Difficulty | Concepts

- Easy: [darts](https://github.com/exercism/problem-specifications/tree/main/exercises/darts), [hamming](https://github.com/exercism/problem-specifications/tree/main/exercises/hamming), [isogram](https://github.com/exercism/problem-specifications/tree/main/exercises/isogram), [leap](https://github.com/exercism/problem-specifications/tree/main/exercises/leap)
- Intermediate: [raindrops](https://github.com/exercism/problem-specifications/tree/main/exercises/raindrops), [raindrops](https://github.com/exercism/problem-specifications/tree/main/exercises/raindrops)
- Hard: [alphametics](https://github.com/exercism/problem-specifications/tree/main/exercises/alphametics), [forth](https://github.com/exercism/problem-specifications/tree/main/exercises/forth), [react](https://github.com/exercism/problem-specifications/tree/main/exercises/react), [pov](https://github.com/exercism/problem-specifications/tree/main/exercises/pov), [two-bucket](https://github.com/exercism/problem-specifications/tree/main/exercises/two-bucket), [zipper](https://github.com/exercism/problem-specifications/tree/main/exercises/zipper)

## Implement exercises

Each exercise has three bits of information:

1. `description.md`: explains what the exercise is about (required)
2. `metadata.toml`: metadata like the exercise's blurb (required)
3. `canonical-data.json`: a set of input/output combinations that describe the behavior of the exercise (optional)

With this information, you should have all the information the `canonical-data.json` file, as

1. You can implement an exercise from
