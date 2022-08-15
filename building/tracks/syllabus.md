# Syllabus

A track's [Concept Exercises](/docs/building/tracks/concept-exercises) are exercises designed to teach specific (programming) concepts.
These concepts form a _syllabus_.
This documentation contains pointers and tips on how to succesfully design a syllabus for your track.

## The goal of a syllabus

We want to allow students to start writing code immediately, without having to understand everything up front.
In order to achieve this we hand-wave over details and we leave a lot of things unexplained.
We simplify where possible and we provide code stubs.
This reduces the cognitive burden of getting started and provides the time and space for the knowledge to sink in.
By taking this approach we're not saying that the student doesn't need to know these things, we're saying that they don't need to know them _yet_.

## Basic structure

Exercises are structured as a graph.
Later exercises teach concepts that depend on having understood concepts that are taught earlier.

## Porting and borrowing

It can be worth looking at how other language tracks have built out their concept exercises.
That said, if you decide to use other exercises as a starting point for your own, be careful to ensure that the resulting exercise is about the concept as it exists in your language.
Sometimes concepts differ subtly, sometimes radically.
Sometimes concepts don't exist at all.

Don't include concepts just because other tracks do.
Not all concepts apply to all tracks.

The syllabus, and therefore the concept tree, should represent the concepts that exist in the language.

In some cases it might be tempting to put a concept in because people often have to work around it by using concepts that do exist.
Rather than doing this, introduce the concept that the language _does_ use, and consider adding an exercise that explains how to use it in that type of situation.

For example, in Go there are no enums.
Instead the Go concept tree introduces constants, and teaches how to use constants in the type of situation where you might use enums in other languages.

## Contributions from the community

Working on a syllabus involves two separate but intertwined activities:

1. Syllabus design: selecting and ordering concepts
2. Exercise implementation: writing documentation and creating exercises to teach those concepts

We've found that it's both fun and enriching to get the wider community to contribute to implementing exercises.
The syllabus design itself, though, is easier to tackle with a small team of contributors who are all engaged in building up an understanding of the full syllabus with all of its intricacies.

That said, we recommend that the syllabus design team implements the first five or six concepts first, before opening up for community contributions.
There are two reasons for this.
The first is that it helps ensure that the core team of syllabus designers understand the process themselves before having to review pull requests from people the broader community.
The second is that it's easier and more fun to be able to make an exercise without having to worry about the constraints of students not knowing _anything_ yet.
It's also easier to create issues for these higher-order concepts.

## Getting started

### The first exercise

Rather than trying to map out the entire concept tree up front, just start with the first exercise.
The goal of the first exercise is to show the student what a small piece of code looks like.
Most of the code will be provided as a stub.
The student should only need to make a couple of additions in order to complete the exercise.

The introduction should explain _just enough_ that the student can look at the code and identify what the different parts are.
E.g. This is a function declaration. These are function parameters. This is an import.

They don't need a deep understanding of any of it, but they should also not be left wondering what something is.

The student should only need to actively _use_ one or two concepts.

### The next exercises

The first exercise should unlock a handful of exercises that introduce fundamental concepts.
This will be things like primitives or basic types and simple operations on those types.
This might be things like:
- numeric types and arithmetic operations
- booleans and boolean comparisons
- strings and some simple ways of operating on them

Remember that you can always defer complexity.
The language might have a dozen different numeric types that are useful in different scenarios.
The exercise can simply mention that there are others while introducing only the most commonly used integer type and most commonly used float type.

Sometimes while working on an exercise you will realize that it's more complex than you expected.
That's totally fine.
Make a note of the concept that needs to be taught as a prerequisite.
Then pretend that that exercise exists, and finish the exercise with that simplification in mind.
Then go back and create a new exercise for the prerequisite concept.

### And what next?

This is where it often starts getting interesting.
There is so much you _could_ introduce at this point.
How do you decide what concepts to tackle next?

It kind of doesn't matter.
As long as you start somewhere that seems reasonable, it will be fine.
You'll discover pre-requisites, and make a note to insert a concept before the exercise you're working on.

If you're at a loss for what to choose next, take a look at one or two of the simplest practice exercises that exist for your track.
Identify the concepts that are used, and pick one that hasn't been covered yet in the syllabus.

## We encourage handwaving

Sometimes you'll feel like there is a deadlock.
Concept A requires understanding concept B, and B requires understanding A.

In this case simplify.
Handwave over some complexity in one so that you can get students familiar with the other.
It's perfectly fine to say that something will be introduced in more depth later, and that for now the student just needs to understand this one bit.

Concepts are understood more deeply in stages and over time.

