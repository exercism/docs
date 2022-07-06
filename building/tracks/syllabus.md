# Syllabus

A track's [Concept Exercises](/docs/building/tracks/concept-exercises) are exercises designed to teach specific (programming) concepts.
These concepts form a _syllabus_.
This documentation contains pointers and tips on how to succesfully design a syllabus for your track.

## Think of concepts in layers

To figure out the ordering/unlocking of concepts, it can help to think of them in _layers_ (sort of like horizontal sections in the syllabus tree).
As an example, a track's first layer could consist of concepts for the basic primitive types (`strings`, `booleans` and `numbers`, with 1 exercise each).

Having identified the first layer, you can then consider which concepts could be unlocked with the concepts from the first layer.
For example, the second later could contain concepts like `arrays`, `comparison` and `conditionals`, which build on the first layer's concepts.

Any concepts that themselves depends on the concepts in the layer you're designing, should go into the next layer (3).
For example, the `for-loops` concepts shouldn't be in the second layer as it likely depends on having unlocked the `comparison` and `conditionals` concepts, which are already in the second layer.

## Collect some basic info about the exercises/concepts in a structured format

- As an intermediate step between just a list of ~20 concept names and the GitHub issues about creating the new concept/exercise for contributors to work on, I can recommend to write down some info per concept in a structured format.

For example:

```
Exercise 1 [name can be inserted here later on if the story is decided upon]
- Concept(s): [slugs of the concept or concepts that the exercise should teach]
- Content: [very short description of what should be taught]
- Out of scope: [optional in case there is something that is already known to be excluded]
- Prerequisite Concepts: [which of the concepts from other exercises above are strictly needed to understand the concept(s) in this exercise]
- Exercise Idea: [link to an existing exercise that could be ported/adapted here or some new story idea]
- Status: [e.g. have a checkbox whether the GitHub issue was created or not]
```

- Would be good to collect this in some tool that allows multiple people to edit like Google Docs.
  If this is done via a GitHub issue description, make sure all people involved in the syllabus design can edit the description.
  Having just one person that can edit and others with same "authority" over the topic only posting proposed changes in comments below usually did not work out very well/ lead to big overhead for the person with edit rights.
- Sort the exercise/concept list so that an exercise only depends on concepts taught by exercises above. Of course there is the tree/layers shape mentioned above but writing things out linearly ensures that at least there is one working unlocking path through the syllabus.
- Take some time to ponder and iterate that list of exercises so it looks like it could work out before writing out all the details needed for the actual GitHub issues per exercise.

## Handwaving is sometimes necessary

This part is for when it feels like there is a deadlock, concept A requires understanding concept B, and B requires understanding A (or more complex versions of that).
To get a sensible syllabus and unlocking, it is not always possible to explain everything 100% correct/in detail.
Sometimes it is necessary to hand wave over some aspect and then give a more thorough explanation at some later point in the syllabus.
For example in Go we needed to introduce functions rather early so students understand multiple return values because they were needed for other concepts.
However, to fully understand "pass by value/ pass by reference" someone would need a good understand of pointers. Teaching pointers needed some more concepts that came after functions.
So in functions, we waved over the pointers thing a bit and said it will be introduced in more details later.
That way we could get functions done and leave pointers for later when the student is a bit further into the track and knows all the things we need to properly teach pointers.

## Don't include concepts just because other tracks do

Not all concepts apply to all tracks.

For example Go has no enums and JavaScript has no string formatting.
There was some discussion whether those concept names should nevertheless show up in the concept tree and then describe what to do instead.
But in the end we decided against that.
I feel the concept tree should really represent the concepts that exist in the language.
So in Go, we now want to do the "constants" concepts which will then explain the patterns how constants are used as workarounds for the missing enums.
