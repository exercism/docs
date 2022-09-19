# Syllabus

A fully featured Exercism track has two types of exercises: Practice Exercises and Concept Exercises.
Concept Exercises and Practice Exercises are fundamentally different and complement each other well.

A track's [Concept Exercises](/docs/building/tracks/concept-exercises) are exercises designed to teach specific concepts that form the basis of a programming language.
These concepts form a _syllabus_.

This documentation contains pointers and tips on how to successfully design a syllabus for your track.

## The goal of a syllabus

The end goal of a syllabus is to lead students to be comfortable with idiomatic code in the target language.

Each individual Concept Exercise is very tightly focused.
It is a very small step that moves the student towards understanding something about the language.
It builds only on concepts that have been introduced previously.

By solving the exercise, the student begins the process of becoming familiar with the concept.
Understanding comes primarily through doing, much less so through explanations.
The explanations are only there so that the student can do what needs to be done.

We want to allow students to start writing code immediately, without having to understand everything up front.
In order to achieve this we hand-wave over details and we leave a lot of things unexplained.
We simplify and provide code stubs where possible.
This reduces the cognitive burden of getting started and provides the time and space for the knowledge to sink in.
By taking this approach we're not saying that the student doesn't need to know these things, we're saying that they don't need to know them _yet_.

Often the earliest exercises need to contain non-idiomatic code.
This is because in the beginning most of the language is still unknown.
Most of the concepts have not yet been introduced.
By allowing non-idiomatic code in the earliest exercises, students are able to take many smaller steps in familiar territory rather than a few big steps in unfamiliar territory.
The result is that they are able to reach the stage of idiomatic code more quickly and with less friction.

## Basic structure

Exercises are structured as a tree with an introductory exercise at the top as the starting point.
Later exercises teach concepts that depend on having understood concepts that are taught earlier.

## Porting and borrowing

It can be worth looking at how other language tracks have built out their concept exercises.
You can find examples of Concept Exercises from other language tracks [here](https://exercism.org/docs/building/tracks/stories).

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

On GitHub you can mention the team @exercism/learning-mode.
In Slack you can ask in the #learning-mode channel.

## Getting started

Our experience has taught us that the most pragmatic way to develop a syllabus is to grow the concept tree organically, starting with the simplest concepts.
We don't have to get everything right up front, but it's really useful to not think too far ahead.

We start with the track's easiest concepts.

Some things are easy because they are inherently simple.
Other things are not all that simple, but feel easy because they are familiar.
Familiar is good.
Familiar is not confusing.

Remember, while the endpoint is to write idiomatic code, the stepping stones to get there are not always idiomatic.
Using what is familiar — even if it is not a great example of code in that language — helps move a student more quickly toward the goal of code that is more typical of the language.

### Developing the first exercise

Rather than trying to map out the entire concept tree up front, just start with the first exercise.
Think of this exercise as the "Hello World" of concept exercises.
The goal of the first exercise is to allow the student to start learning with the least amount of friction as possible.
They are taking the very first step towards getting familiar with what code in this language looks like.
They might write a small piece of code, or perhaps just make a couple of additions to a stub in order to complete the exercise.
Try to optimize for a quick win and getting students familiar enough with the bare necessities of syntax to be able to move forward confidently.

Read more about [developing the first exercise](/docs/building/tracks/syllabus/first-exercise.md) here.

### The next exercises

The first exercise should unlock a handful of exercises that introduce fundamental concepts.
These will be things like primitives or basic types and simple operations on those types.

Read more about [developing the next exercises](/docs/building/tracks/syllabus/next-exercises.md) here.

### And then what?

This is where it often starts getting interesting.
There is so much you _could_ introduce at this point.
How do you decide what concepts to tackle next?

It kind of doesn't matter.
As long as you start somewhere that seems reasonable, it will be fine.

Read more about what we think "reasonable" means in the context of [expanding the concept tree](/docs/building/tracks/syllabus/expanding.md).

## Do not convert practice exercises

A good Concept Exercise is extremely focused, and ideally teaches only one concept.
There will usually be only one expected approach to solving it.
This is in contrast to Practice Exercises, which are open ended and lend themselves to exploration.

A good Concept Exercise is usually a bad Practice Exercise, and vice versa.
Since the goals of Practice Exercises and Concept Exercises are completely different, we do not take Practice Exercises and convert them into Concept Exercises.
We write all Concept Exercises from scratch or base them on stories that were explicitly crafted for the purpose of teaching simple concepts.

## We encourage hand-waving

Sometimes you'll feel like there is a deadlock.
Concept A requires understanding concept B, and B requires understanding A.

In this case simplify.
Hand-wave over some complexity in one so that you can get students familiar with the other.
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
It can be just a couple of lines long.

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
