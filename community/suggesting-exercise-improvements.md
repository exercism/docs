# Suggesting Exercise Improvements

So you've found something you'd like to improve about an exercise.
Firstly, thank you for caring, and for making the time to tell us! 💙

When changing an exercise, there's a few things to consider, and they're slightly different for Learning Exercises (those that teach topics in the Syllabus) and Practice Exercises (the rest).
We go into the extra differences in those below.

However, firstly there's a couple of generic things to consider.

### Changing an exercise has consequences

There are quite a few consequences in changing an exercise:
1. Firstly, adding new tests may well break existing solutions.
  This has the consequence of outdating thousands of people's work, which is frustrating for them if the extra tests aren't highlighting any existing bugs.
2. It also has the consequence of us having to retest everyone's work, which has both an enviromental and financially cost.
3. Finally, this work involves one or more maintainers taking the time to review the changes, which means they're not able to make other improvements to the track during that time.

For all these reasons, we are careful to only change exercises where there's a strong identifiable benefit.

### Avoid trending towards entropy

The aim of exercises' test suites is not to be comprehensive about all possible cases.
Our exercises are not productive software nor are they designed to imitate real-world usecases.
They are designed to be toy-problems to help you gain **fluency in a programming language**.
We therefore deliberately trying to cover every edge-case, forcing lots of input validation, or other such real-world situations.
If your suggested improvement is to catch and edge-case or to check input-validation, it's unlikely to be accepted unless it makes a substantial difference to the exercise.

## Learning Exercises

Learning Exercises are designed with one goal: to teach concepts. 
All changes to an exercise will first and foremost be considered against whether they improve the teaching of the concepts.

Learning Exercises are (especially) not designed to be exhaustive in their tests.
They can also often be slightly contrived or obtuse to avoid using concepts a student has not yet learned, or so as not to overwhelm a student.

If your suggested change is about improving an exercise, but could potentially distract from the learning of the concept, it will probably get rejected.
If the change makes the learning easier, it'll be strongly considered.
If it sits somewhere in between, it may be accepted, but is unlikely to be prioritised.

## Practice Exercises

The main thing to understand about Practice Exercises is that nearly all of them live in a central repository (known as "Problem Specifications").
Making a change to an exercise therefore has knock-on effects over all tracks.
That means a good change is extra powerful as it'll help all languages. 
But it also increases the burden of the change, as multiple cross-track maintainers need to agree the change for it to be accepted, and then each language's maintainers need to pull the changes downstream into their tracks.

Changes to exercises can also mean that the concepts they're linked to in syllabuses become muddier, or that exercises need extra features to solve, which changes where they become unlocked.
This also needs to be considered across tracks before changes are accepted.

While we do have mechanisms for only some tracks to have certain test-cases, we tend to discourage it, as this forking can offer confusion to both maintainers and students. 
So when proposing changes to Practice Exercises, please consider the bigger picture across tracks.

## How to get your changes accepted

Although there's a lot of reasons that we don't accept suggestions, a lot of the time people come up with great ideas that we do accept!

We're also nearly always open to changes in wording that add clarity, especially in Learning Exercises.

To give your suggestions the best shot of being approved, please write out your suggestions showing that you've considered the following:
- The tangible improvement that this change makes (ideally with code examples of what your change enables/stops).
- The impact on existing solutions, and why this is worth it.
- Any changes to the concepts taught or used.
- An understanding of why things might be the way they are (Please read our post on [Chesterton's Fence](https://exercism.org/docs/community/being-a-good-community-member/chestertons-fence))

And please remember to express opinions as opinions and facts as facts. 
That tends to lead to the most productive conversations.

Thanks again for taking the time to make a suggestion and for reading this document!
