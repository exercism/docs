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

The syllabus, and therefore the concept tree, should represent the concepts that exist in the language.

Don't include concepts just because other tracks do.

In some cases it might be tempting to put a concept in because people often have to work around it by using concepts that do exist.
Rather than doing this, introduce the concept that the language _does_ use, and consider adding an exercise that explains how to use it in that type of situation.

For example, in Go there are no enums.
Instead the Go concept tree introduces constants, and teaches how to use constants in the type of situation where you might use enums in other languages.

## Asking for help
Don't hesitate to ask for help.
It's better to ask up front or while working on an exercise rather than discussing during code review.

## Getting started

### Developing the first exercise

Rather than trying to map out the entire concept tree up front, just start with the first exercise.
The goal of the first exercise is to show the student what a small piece of code looks like.
Most of the code will be provided as a stub.
The student should only need to make a couple of additions in order to complete the exercise.

Read more about [developing the first exercise](/docs/building/tracks/syllabus/first-exercise.md) here.

### The next exercises

The first exercise should unlock a handful of exercises that introduce fundamental concepts.
This will be things like primitives or basic types and simple operations on those types.

Read more about [developing the next exercises](/docs/building/tracks/syllabus/next-exercises.md) here.

### And then what?

This is where it often starts getting interesting.
There is so much you _could_ introduce at this point.
How do you decide what concepts to tackle next?

It kind of doesn't matter.
As long as you start somewhere that seems reasonable, it will be fine.

Read more about what we think "reasonable" means in the context of [expanding the concept tree](/docs/building/tracks/syllabus/expanding.md).

## We encourage handwaving

Sometimes you'll feel like there is a deadlock.
Concept A requires understanding concept B, and B requires understanding A.

In this case simplify.
Handwave over some complexity in one so that you can get students familiar with the other.
It's perfectly fine to say that something will be introduced in more depth later, and that for now the student just needs to understand this one bit.

Concepts are understood more deeply in stages and over time.

## Selecting stories

A concept exercise always has a story.

If you're forking an exercise from another track, then the exercise will already have a story.
In that case, you're all set.

To see if there are any existing stories you can use or exercises you can fork, check out the [list of stories](docs/building/tracks/stories).

If you have a concept but no story then our recommendation is to write a small, simple code example that uses the concept that you're introducing.
Then reverse engineer a story onto the code.
Keep the story stupidly simple.
It doesn't have to be good fiction.
It doesn't need a strong plot or character development.

Bounce ideas for stories with the Exercism team.
We have a lot of experience coming up with suitable stories.

Once you have a story you will likely need to tweak the code a bit to get it to fit the story.

## Contributions from the community

Working on a syllabus involves two separate but intertwined activities:

1. Syllabus design: selecting and ordering concepts
2. Exercise implementation: writing documentation and creating exercises to teach those concepts

We've found that it's both fun and enriching to get the wider community to contribute to implementing exercises.
The syllabus design itself, though, is easier to tackle with a small team of contributors who are all engaged in building up an understanding of the full syllabus with all of its intricacies.

That said, we recommend that the syllabus design team implements the first five or six concepts first, before opening up for community contributions.
This helps ensure that the people on the core team of syllabus designers understand the process themselves before having to review pull requests from people in the broader community.

It's also easier to create issues for these higher-order concepts and tends to be more fun for community members to work on them, since there are fewer constraints to worry about.

## Creating issues

We still haven't figured out how to best create issues for creating concept exercises.

In some tracks we've tried creating separate exercises for the concept itself and the exercise.
In others we've tried making issues that have a checklist to work through.
Overall, we think this is still too intimidating, and we'd like to find a better way.

Please talk to us about the process as you start making issues, and we will do our best to help figure out how to proceed.

We will update the documentation as we learn better ways of tackling this.
