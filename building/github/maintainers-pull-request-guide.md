# The Maintainers' Guide to Pull Requests

As a maintainer, reviewing pull requests is something you'll do fairly regularly.
This documents contains some Exercism-specific pull request review guidelines.

## Concept Exercise Pull Requests

Reviewing a pull request to add a Concept Exercise can be daunting with the many rules around Concept Exercises.
For these reason, a first-pass review by a maintainer often take 2 to 3 hours and results in dozens (or even hundreds) of comments.
There are also files with similar goals/contents (e.g. the exercise and concept introduction), where getting one of those perfect first is essential before branching out too far.

To help streamline this workflow, we've developed the following recommendations.

### Recommendation: have one senior maintainer own the first-pass review

The reasons for having exactly one senior maintainer own the first-pass review are:

- There is no duplicate reviewing work being done
- The contributor and maintainer will work as a pair on the pull request, hopefully giving the contributor the feeling they're not doing this alone.
- There won't be contradictory review comments (which regularly happens when multiple maintainers review the same pull request)

### Recommendation: merge with `wip` status

Getting Concept Exercise in proper shape is hard, and often requires multiple rewrites.
Once the contributor and maintainer are both happy with the exercise, the exercise should be merged with its `status` set to `wip` (work-in-progress).
Exercises with this status won't be available to students, but (in the future) will be available for viewing to our top mentors.
These high-rep users can then test the exercise and create issues (or pull requests) to fix or improve the exercise.

The main benefit of this approach is that it removes the burden on the original contributor/maintainer pair getting everything perfect, but doesn't lead to huge pull request cycles with multiple voices (which are really hard to manage).

## Practice Exercise Pull Requests

While Practice Exercises are usually easier to review, the same recommendations used for Concept Exercises apply.

## Other Pull Requests

For non-exercise pull-requests, we have the following recommendations.

### Recommendation: one primary reviewer per pull requests

All pull requests should have one primary reviewer (whichever maintainer takes it on).
Other maintainers and/or community members should act in a secondary role.

There two main ways in which someone in a secondary role can contribute to a review:

- Proofread spelling/grammar, but only _once the first pass from the primary reviewer has happened_.
  It can be frustrating for contributors if they get a spelling/grammar review, fix it, and then a maintainer comes along and asks them to make more fundamental changes.
  In other words: proofreading is something do you _after_ the fundamental changes are sorted out (or possibly in a follow-up pull request).
- Pointing out things _in a non-actionable way to the reviewer_.
  If you comment on things that the primary reviewer should think about or might have missed, please post your comment as stating an opinion or phrased as a question.
  This makes it clear to the contributor that you're not asking them to make changes, which will make things less confusing for them.
  It will also reduce the chance of the primary reviewer feeling "undermined."
  If the primary reviewer has

### Recommendation: be mindful of the primary reviewer's workflow

### Recommendation: don't try to fix unrelated things

"Please post comments on PRs where you think there are mistakes being made or fundamental improvements that could be made, once a maintainer has had chance to review".\_ I hope that wall of text adds some value!

My 2 cents on this:
In general I agree with the comment but I don't think this "wait for the maintainer to review and then say something" advice is very practical.
The maintainer might already have merged the change by then before however wanted to do a second pass had a chance.
The contributor would have to check out any changes happening on the PR to find the exact point in time between "maintainer reviewed" and "merged" when the "giving a second opinion" can happen.
Since unsolicited reviews that confuse contributors are a general issue (I also saw this in JS and Go), maybe this would work as guideline/doc. (trying to be a bit more concise :wink:)
All pull request reviews are done by one (or more) maintainers of the track as they are responsible for signing off all changes to the repository. Maintainers doing the review also helps to avoid conflicting feedback for the PR author.
Contributors are welcome to leave a comment to offer assistance with the review (especially for bigger PRs) or to raise questions in case they notice something that looks like a mistake to them.
I might be missing something, only read the comment from Jeremy ... just sharing my current thoughts. (edited)
