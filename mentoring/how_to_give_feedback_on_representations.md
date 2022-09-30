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
