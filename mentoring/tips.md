# Mentoring Tips

## Mentoring Notes

One of the biggest helps to mentoring can be to have a file to hold notes for each exercise you mentor.
You may find that many solutions can benefit from the same suggestions, so, by keeping notes,
you don't need to keep writing up the same suggestions from memory.
And, by having the suggestions in one place, you can keep refining them over time to make them clearer.

If you're not sure how to get started with your notes, you may find a `mentoring.md` file for your track's
exercise under [exercism/website-copy/tracks][website-copy].
If it exists, it may include examples of reasonable solutions, along with common suggestions and talking points
to prompt further discussion.
If it doesn't exist, you may want to go back and create one after you've made your own file of notes for that exercise.

Also, even if you only mentor one language now, you may mentor more in the future.
It may help to organize your mentoring notes by track as well as by exercise name, as different tracks will likely require
different suggestions for the same exercise.

Mentoring notes are handy, whether you mentor the exercise frequently or infrequently.
If you mentor the exerise frequently, it saves a lot of typing from scratch, when you can just copy-and-paste from your notes.
If you mentor the exerise infrequently, it can remind you of suggestions to make that you may have forgotten in the weeks or months
since you last mentored it.

It's okay for mentoring notes to differ between mentors.
Here is one way to structure them, but it is not the _only_ way.

Congratulate the mentee on passing the tests (if they passed them).

If the exercises has been sitting in the queue for a few days, maybe address that with something like:

>Sorry it took a while for someone to get back to you.
>There is currently a shortage of active JavaScript mentors for `Resistor Color Duo`.

Itemize what you like about the mentee's solution.
For example:

- I like this solution is succinct and readable.

- I like the use of `indexOf`.

- I like this uses the `(first * 10) + second` approach to avoid casting between number to string back to number.

- I like this does not use looping/iteration.

- I like the destructured parameter.

Next could come your frequent suggestions.

~~~~exercism/note
It can be very helpful for the mentee if a link is provided for each new language feature you introduce.
For example:

>It's not necessary for this exercise, but perhaps consider converting the function to an [arrow function](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions).
~~~~

Although we don't want to give away the solution, sometimes a mentee learns best by example.
To put a snippet of code in a collapsed details section can provide that example, which the mentee can choose to expand or not.
For example:

&lt;details&gt;&lt;summary&gt;Spoiler Example&lt;/summary&gt;

&lt;pre&gt;

export const decodedValue = ([firstColor, secondColor]) =>
  COLORS.indexOf(firstColor) * 10 + COLORS.indexOf(secondColor)

&lt;/pre&gt;

&lt;/details&gt;

Toward the end of the notes you might include a link to a published solution which represents the suggestions in full.

At the very bottom of your notes you may want to put extended explanations that mentees sometimes ask for.
These explanations don't come up often, but it can still be good to record them the first time you use them,
so the next time, which could be weeks or months away, you won't have to come up with the explanation from scratch.
For example, sometimes a mentee will ask about how the multiplication approach would work for Resistor Color Duo
if black was the first band for a leading zero:

>Black for a first band is a good point to consider, so let's consider it.
>The resister color is meant to represent the amount of ohms for the resistor,
>and a leading zero would not be used for a multi-band resistor.
>So black would not be a first band.
>Besides, `parseInt` or `Number` will also remove the leading zero.

An optional cateory of data to keep in mentoring notes is a record of benchmarks for various solutions or approaches.

## Benchmarking

A common concern for mentees is how performant their solution is.
This is especially the case for "lower-level" languages such as C, C++, Go, and Rust.
Along with how idiomatic their code is, mentees of other languages are also often concerned with the efficiency of their code.

~~~~exercism/notes
Benchmarking is not something that a mentor is _expected_ to do.
However, mentees are often particularly impressed by how a benchmark of their solution compares with other approaches.
~~~~

Go is a particularly friendly track for benchmarking, as benchmarks are often included in the test file.
Other languages may require some research to determine what method would work best for you.
For instance, if you only use the online editor, then you would be looking for a place to run benchmarks online.
For example, [JSBench.me][jsbench-me] is an online benchmarker for JavaScript.

If you run code locally, then you have the option of downloading benchmarking software you can run on your machine.
For example, Rust can use [Criterion][criterion], or [cargo bench][cargo-bench] with [benchmark tests][rust-benchmark-tests].

There are at least a couple ways to keep track of benchmarks.
One way is to keep a running list of all the ones you benchmark, but that can get unwieldy if the list gets long.
Another way is to keep a list of repesentative benchmarks for different approaches.
Mentees often want to see the code for the faster approaches, so if a faster approach is published,
it will likely be much appreciated to provide the link to it.

~~~~exercism/caution
If providing a link to a solution you benchmarked, be sure to provide a link to the published solution and not to the mentoring session.
Not all solutions that are mentored get published.
~~~~

[website-copy]: https://github.com/exercism/website-copy/tree/main/tracks
[jsbench-me]: https://jsbench.me/
[criterion]: https://crates.io/crates/criterion
[cargo-bench]: https://doc.rust-lang.org/cargo/commands/cargo-bench.html
[rust-benchmark-tests]: https://doc.rust-lang.org/unstable-book/library-features/test.html
