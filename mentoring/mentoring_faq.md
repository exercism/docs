# Mentoring FAQ


[What qualifies someone to be a mentor?](#what-qualifies-someone-to-be-a-mentor)

[Can I mentor a language while I'm still learning it?](#can-i-mentor-a-language-while-im-still-learning-it)

[Can I mentor more than one language?](#can-i-mentor-more-than-one-language)

[Should I try to mentor every solution in the queue?](#should-i-try-to-mentor-every-solution-in-the-queue)

[What if a solution has been sitting in the queue for days, even weeks?](#what-if-a-solution-has-been-sitting-in-the-queue-for-days-even-weeks)

[What if I have nothing to suggest about a solution?](#what-if-i-have-nothing-to-suggest-about-a-solution)

[Should I mentor an exercise I've never solved?](#should-i-mentor-an-exercise-ive-never-solved)

[Should I mentor an exercise I've solved, but solved in a different language?](#should-i-mentor-an-exercise-ive-solved-but-solved-in-a-different-language)

[Do I have to mentor a solution once I've seen it?](#do-i-have-to-mentor-a-solution-once-ive-seen-it)

[What if the student does not understand after I've explained something several times?](#what-if-the-student-does-not-understand-after-ive-explained-something-several-times)

[How do I respond if the student gets defensive about my suggestion(s)?](#how-do-i-respond-if-the-student-gets-defensive-about-my-suggestions)

[Should the student have the last word, even if I think they're wrong?](#should-the-student-have-the-last-word-even-if-i-think-theyre-wrong)


## What qualifies someone to be a mentor?

You don't need to be an expert in a language to mentor that language.
You only need to be a little less of a novice than the person you're mentoring.
If there is someting in a solution that you think could be done in a different way, you can suggest it.
It doesn't necessarily have to be a _better_ way, just an idiomatic alternative.
That leaves the choice of whether to use the suggestion or not with the student,
but at least the student now has more options to choose from.

## Can I mentor a language while I'm still learning it?

Ideally, you never stop learning a language you know.
Some languages put out an updated version every few weeks or months.
Not only may there be new language features to learn, but there may be existing features you're unaware of.
Sometimes a student may use a feature, and that will be the first time you've ever seen it.
So mentoring can be a good way to learn more about a language.

## Can I mentor more than one language?

You can mentor as many languages as you feel comfortable with.
It's okay to mentor multiple languages you feel strong in, as well as a language you're still learning.

## Should I try to mentor every solution in the queue?

If you can't think of something substantive or constructive to say about a solution at the time,
it may be better for the student if you leave the mentoring request for another mentor,
even if that student will need to wait longer for a response.

## What if a solution has been sitting in the queue for days, even weeks?

The solution may be for an exercise that was hard for you, which you either may
not have solved, or solved but felt you didn't solve very well.
In that case, you might look over the solution to see if there is anything you can learn from it.
If so, you can tell the student what you learned from their solution.

Or you may wish for the student to explain their solution to you.
That is kind of a "reverse mentoring", but some students may be happy to explain their solution
when asked politely and respectfully.
You could then ask if they considered another approach and why did they choose the approach they did.

Or, you still may not understand the solution overall, but you may see some things you can address.
For example, you might point out to consider using meaningful names for function parameters,
if they used just `n` or `m`.

If you're not comfortable doing any of those things, it's okay to leave the request unanswered.
Mentoring is voluntary.
Just because you're mentoring a language doesn't mean you have to mentor every exercise for that language.

## What if I have nothing to suggest about a solution?

It's okay to say what you like about a solution.
In fact, saying what you specifically like about a solution is a good way to start any mentoring encounter.
After doing that, if you have no suggestions for alternative ways to approach the exercise,
it's fine to just tell the student, "Well done!"
If the student submitted more than one iteration,
you may be able to point out in what ways the most recent iteration is an improvement.

## Should I mentor an exercise I've never solved?

Sometimes, looking at a student's solution will inspire you to solve the exercise yourself,
especially if the approach used in the solution is one that makes the exercise seem simpler
than approaches you may have already considered.
After solving the exercise, if the mentoring request that inspired you is no longer available,
you will at least be ready for the next time.

## Should I mentor an exercise I've solved, but solved in a different language?

Given that what is idiomatic in one language may not be idiomatic in another language,
it is likely best to have solved the exercise in the language being mentored.
If the solutions between two languages are very similar, and you know both languages well enough
to know what is idiomatic in each, then it shouldn't take long to transpose the solution in one
lanaguage to the other.
If the mentoring request is no longer available after transposing the solution,
you will at least be ready for the next time.

## Do I have to mentor a solution once I've seen it?

You may look at a solution and realize you don't want to mentor it.

- The student may have asked a question that you don't know the answer for.
- The code may be so confusing, you don't know where to start a critique.
- The code may signal that the student is an absolute beginner who will need a lot of basic guidance
that you may have neither the time nor patience for.
- The student's comment may be such that it signals the student may be unpleasant or laborious to interact with.

Nothing obligates you to click the "Start mentoring" button if you think the particular mentoring request is not for you.


## What if the student does not understand after I've explained something several times?


There may be times when a student seems almost willfully resistant to understanding your explanations.
If you feel you've exhausted all the ways you know to explain something, you may decide
to finish the discussion with a comment that the student resubmit their mentoring request so it
can be handled by another mentor who may be more successful in explaining the difficult point(s).


## How do I respond if the student gets defensive about my suggestion(s)?

Sometimes a student will say they used a more laborious approach than necessary as a way to learn
more about a language feature, even though that feature is not best suited for the exercise.
Since Exercism is a platform for learning and not a competitive coding site, that is a justifiable reason
for not using the most elegant or efficient approach.
You might make some suggestions on how they used their approach,
if you see they could have implemented their approach more idiomatically.
In any case, you can suggest that they can submit another iteration based on the feedback,
or they can end the discussion to free up a mentoring slot.

A student may adhere to a programming paradigm that may not be best suited for the language or the exercise.
For example, they may always want to use the object-oriented paradigm,
and fragment a relatively simple and straightforward solution into a little explosion of classes
with labyrinthine control flow through multiple methods.
To the extent that the student is a dogmatic follower of the paradigm, it is usually fruitless to attempt
to persuade them of a different approach.
You can try, and they may respond to your suggestion, but if the student digs in, it may be best to move on.

The student may outright reject a suggestion.
For example, you may suggest using `reduce` instead of `map` and `join`,
since `reduce` is onlay one iteration instead of one iteration for `map` and another for `join`.
But the student may reject that, because they find `map` and `join` to be more readable.
It's okay to agree with the student that `map` and `join` can be more readable than `reduce`.
You can suggest they may become more comfortable with `reduce` after more time to get used to it,
and there is nothing _wrong_ with using `map` and `join`.

It's okay to agree with a student to the extent they are correct,
and it's okay to make an attempt to correct any misconception or exagerration the student may have expressed.

## Should the student have the last word, even if I think they're wrong?

For example, you may suggest a student should not use [magic numbers][magic-number] such as `60` and `24`
when solving the `Clock` exercise, but suggest defining them as constants with meaningful names.
The student may respond that, given the context, it's obvious what `60`and `24` stand for.
You've made your suggestion and the student has dismissed it.
There may be nothing to gain, and perhaps goodwill to be lost, by arguing about it.


[magic-number]: https://en.wikipedia.org/wiki/Magic_number_(programming)
