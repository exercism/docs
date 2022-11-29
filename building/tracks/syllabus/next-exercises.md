# Syllabus - Next Exercises

Having implemented your first concept exercise, the next few exercises should build on that.

We like to have three to five exercises that have no prerequisites other than the `basics` concept.

Good options are the core primitives or data types of your language.
E.g. booleans, basic numeric types, strings, and atoms.

It's worth checking other tracks' concept exercises to see if there are any that are appropriate for your track.

Note that introducing a concept doesn't mean that you need to explain it fully in all its glory.
You can always defer complexity.
The language might have a dozen different numeric types that are useful in different scenarios.
The exercise can simply mention that there are others while introducing only the most commonly used integer type and most commonly used floating-point type.

Some core data types are too complex to introduce directly.
For example strings might be lists of chars.
In such a case you would need to defer the introduction of strings, and design a concept exercise for chars and another for lists.
Then you can add an exercise for strings that has both of those exercises as prerequisites.

Sometimes while working on an exercise you will realize that it's more complex than you expected.
That's totally fine.
Make a note of the concept that needs to be taught as a prerequisite.
Then pretend that such an exercise exists, and finish the exercise you're working on with that simplification in mind.
Then go back and create a new exercise for the prerequisite concept.
Remember to mark the exercise as `wip` until the prerequisite exercise has been added.

Another thing that can happen at this point is that you find that you have cyclical dependencies.
You need to introduce two concept, but each concept relies on the other.
In this case you may be able to use a stub.
Then you can explain that the dependent concept exists, but reassure them that they don't need to understand it yet.
Another option would be to give a bare minimum of an introduction, enough for the student to get past the hurdle, while reassuring that the concept will be covered in more depth later.

## Foregone exercises

If you choose **not** to implement an exercise because it doesn't fit your track (e.g. a low-level exercise for a high-level track), please mark it as _foregone_.
To do so, add the exercise's slug to the `exercises.foregone` array in your track's [config.json](/docs/building/tracks/config-json#h-foregone-exercises) file.

Besides making your choice to not implement an exercise explicit, any tooling (such as [configlet](/docs/building/configlet)) will also ignore foregone exercises.

For more information, see [the docs](/docs/building/tracks/config-json#h-foregone-exercises).
