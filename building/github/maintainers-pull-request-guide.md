# The Maintainers' Guide to Pull Requests

As a maintainer, reviewing pull requests is something you'll do fairly regularly.
This document contains some Exercism-specific pull request review guidelines.

## Reviewing Exercise Pull Requests

Reviewing a pull request for a Concept Exercise or Practice Exercise can be daunting with the many rules around these types of exercise.
For this reason, a first-pass review by a maintainer often takes two to three hours and results in dozens of comments.
For Concept Exercises, there are also files with similar goals/contents (e.g. the exercise and concept introduction), where focusing on getting one of those perfect first is essential before branching out too far.

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

### Recommendation: consider whether the change actually belongs in problems-specifications

Some of the contents of a Practice Exercise (such as its introduction) comes from its (shared) metadata as defined in the [problems-specifications repo][problem-specifications].
When reviewing a pull request changing such content, consider whether the change might benefit other tracks too.
If so, suggest that the contributor open a pull request to the corresponding file in the [problems-specifications repo][problem-specifications]

## General Reviewing Recommendations

### Recommendation: one primary reviewer per pull request

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

### Recommendation: don't comment on unrelated things

When reviewing a pull request, _only_ comment on things directly related to the pull request.
For anything else, please open an issue or create a separate (follow-up) pull request.

### Recommendation: link to documentation

When possible, always try to link to documentation that explains the reason _why_ you're commenting on something.
This greatly helps reduce the change of things becoming argumentative.

### Recommendation: request help from other teams

If you'd like to request help reviewing a pull request, we have to specific teams you can ping:

- `@exercism/reviewers`: for any general reviews
- `@exercism/github-actions`: for any questions regarding [GitHub actions][github-actions]

[problem-specifications]: https://github.com/exercism/problem-specifications
[github-actions]: https://docs.github.com/en/actions
