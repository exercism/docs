# The Contributors' Guide to Pull Requests

Before creating a pull request, please read the [how to make a great Pull Request][how-to-make-a-great-pr] guide which aims to help you with the non-technical side of pull requests so that you have a great experience and help our maintaining team at the same time.

This documents contains some additional, Exercism-specific guidelines for different types of pull requests.

## Exercise Pull Requests

Creating a pull request for a Concept Exercise or Practice Exercise can be daunting with the many rules around these types of exercises.
For this reason, it can take a maintainer 2 to 3 hours to review and can result in dozens of comments.

To help you, there'll be one primary reviewer commenting on your pull request.

Don't be discouraged by the number of review comments; it is perfectly normal for an exercise to go through several rewrites before arriving at something both you and the primary reviewer are happy with.

Here are some recommendations to help streamline the process even more.

### Recommendation: read the documentation

Before creating a pull request for an exercise, be sure to read the [concept exercise documentation][concept-exercises] respectively [practice exercise documentation][concept-exercises].
Reading the documentation beforehand helps immensely, as reviews will have less comments and your pull request will be merged much sooner.

### Recommendation: examine existing exercises (if any)

If the track has any existing exercises, take the time to study them a bit to discover what they look like and how they're structured.

## Practice Exercise Pull Requests

### Recommendation: consider whether the change actually belongs in problems-specifications

Some of the contents of a Practice Exercise (such as its introduction) comes from its (shared) metadata as defined in the [problems-specifications repo][problem-specifications].
If you're intending to update such content, consider whether the change might benefit other tracks too.
If so, please open a pull request to the exercise's metadata in the [problems-specifications repo][problem-specifications] instead.

## General recommendations

### Recommendation: refrain from doing unsollicited reviews

All pull request reviews are done by one (or more) maintainers of the track, as they are responsible for signing off all changes to the repository.
Maintainers doing the review also helps to avoid conflicting feedback for the pull request author.

You are of course welcome to leave a comment to offer assistance with the review (especially for bigger pull request) or to raise questions in case you notice something that looks like a mistake.

[how-to-make-a-great-pr]: /docs/community/being-a-good-community-member/pull-requests
[problem-specifications]: https://github.com/exercism/problem-specifications
[concept-exercises]: https://exercism.org/docs/building/tracks/concept-exercises
[practice-exercises]: https://exercism.org/docs/building/tracks/practice-exercises
