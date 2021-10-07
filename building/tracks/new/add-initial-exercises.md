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

### Select exercises with varying degrees of difficulty

### Select exercises that fit your track

Not all exercises may fit your track.
You should only select exercises 
For example, the [grep exercise](https://github.com/exercism/problem-specifications/tree/main/exercises/grep) has the student working with files

## Implement exercises

Each exercise has three bits of information:

1. `description.md`: explains what the exercise is about (required)
2. `metadata.toml`: metadata like the exercise's blurb (required)
3. `canonical-data.json`: a set of input/output combinations that describe the behavior of the exercise (optional)

With this information, you should have all the information the `canonical-data.json` file, as 

1. You can implement an exercise from
