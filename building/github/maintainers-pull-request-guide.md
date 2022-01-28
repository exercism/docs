# The Maintainers' Guide to Pull Requests

As a maintainer, reviewing pull requests is something you'll do fairly regularly.
This document contains some Exercism-specific pull request review guidelines.

## Reviewing Concept Exercise Pull Requests

Reviewing a Concept Exercise pull request can be daunting with the many rules around Concept Exercises.
For this reason, a first-pass review by a maintainer often take 2 to 3 hours and results in dozens (or even hundreds) of comments.
There are also files with similar goals/contents (e.g. the exercise and concept introduction), where focusing on getting one of those perfect first is essential before branching out too far.

To help streamline this workflow, we've developed the following recommendations.

### Recommendation: have one senior maintainer own the first-pass review

The reasons for having exactly one senior maintainer own the first-pass review are:

- There is no duplicate reviewing work being done
- The contributor and maintainer will work as a pair on the pull request, hopefully giving the contributor the feeling they're not doing this alone
- There won't be contradictory review comments from other maintainers

### Recommendation: merge with `wip` status

Once the contributor and maintainer are both happy with the exercise, the exercise should be merged with its `status` set to `wip` (work-in-progress).
Exercises with this status won't be available to students, but will be available for viewing to our top mentors (once we've implemented this sometime in the future).
These high-rep users can then test the exercise and create issues or pull requests to fix or improve the exercise.

The main benefits of this approach are:

- It removes the burden on the original contributor/maintainer pair getting everything perfect
- It doesn't lead to huge pull request cycles with multiple voices (which are really hard to manage)

## Reviewing Practice Exercise Pull Requests

The Concept Exercise review recommendations also apply to Practice Exercise reviews (although the latter are usually easier to review).

### Recommendation: consider whether the change actually belongs in problems-specifications

Some of the contents of a Practice Exercise (such as its introduction) comes from its (shared) metadata as defined in the [problems-specifications repo][problem-specifications].
When reviewing a pull request changing such content, consider whether the change might benefit other tracks too.
If so, suggest that the contributor open a pull request to the corresponding file in the [problems-specifications repo][problem-specifications]

## Reviewing Other Pull Requests

For other, non-exercise, pull-requests, we have the following recommendations.

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

### Recommendation: don't commment on unrelated things

When reviewing a pull request, _only_ comment on things directly related to the pull request.
Instead, if you've a separate problem/improvement, please open an issue or create a separate (follow-up) pull request.

[problem-specifications]: https://github.com/exercism/problem-specifications
