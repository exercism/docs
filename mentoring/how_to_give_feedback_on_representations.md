# How to give feedback on representations

Giving feedback on a representation is different from giving feedback on a single solution.

## Representation feedback applies to multiple solutions

The key thing with representation feedback is that they apply to _multiple_ solutions.
Anything that the representer normalizes should not be commented on, as you have no way of knowing what the original syntax was for a particular solution.

As an example, many representers normalize a solution's white space.
Therefore, even though the solution shown in the representation feedback UI might have formatting issues, you shouldn't comment on it as other solutions with the same representation might not have those formatting issues.

Another example is naming of variables, functions, methods or classes.
As representers could normalize identifier names, you shouldn't comment on them.
Even if your representer currently does _not_ normalize identifier names, you still should not comment on it, as this is a normalization likely to be added to a representer later.

## Don't duplicate analyzer comments

As students will get to see both representer _and_ analyzer comments, make sure that you don't duplicate comments.
To help with this, the analyzer comments are shown on the representation feedback page.

## Draft feedback

If a representation has feedback on it and either:

- the exercise's representer version changed, or
- the representation version changed

a new representation will be created.

The feedback of the old representation likely also applies to the new representation, but we can't be sure.
Therefore, we copy the old representation's feedback as _draft_ feedback for the new representation.
The new representation's draft feedback does _not_ result its comments being applied to solutions with that representation.
Instead, the draft feedback is used to prepopulate the feedback when a supermentor wants to give feedback on the new representation.
