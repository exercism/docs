# Tests pass locally but not online?

Sometimes your tests will pass locally on your machine but not online.

There are normally a few reasons for this:

## You've not unskipped all the tests

Many Exercism exercises come with some tests skipped.
The aim is for you to solve each test in sequence, unskipping the next as you go.
By the time you get to the end of the exercise, all the tests should be unskipped and passing the tests and you will have a fully working solution.
Check the docs on the [track you're working on](/docs/tracks) for specific details on how skips work in that language.

When we run the tests online, we unskip everything first.
If you've not skipped everything locally, we might therefore find some edge-cases that you've not considered, and the tests will fail.

## We're using different versions to each other

Exercism's test runners use a specific language version.
It might not be the most up to date version of the language, as we have to manually update our test runners when new language versions are released.

If the tests fail online, please check the output (by clicking on the "Failed") word and try and highlight what might be wrong.
If you determine that the problem is down to a version mismatch, please open an issue on the relevant test-runner repository on GitHub.
That normally follows the pattern of `https://github.com/exercism/$SLUG-test-runner` (e.g. `https://github.com/exercism/ruby-test-runner`).
