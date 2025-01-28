# Test-Driven Development (TDD)

Test-Driven Development (sometimes called Test-First Development or Test-Driven Design) is the practice of writing the unit tests first, before you write a single line of implementation code.

## On Exercism, the tests _are_ the requirements!

All Practice Exercises you work on (those ones that don't teach you a new concept) will have some instructions describing in general terms what you need to do.
By design, these instructions do not account for programming-language-specific implementation details because they are shared by all of Exercism's 70+ language tracks.
Some language tracks will append more specific details for you, but not all of them do.

When you start working on a Practice Exercise, give the instructions a careful read.
They will give you a broad overview of how you go about implementing a solution.
But you will have to read the _tests_ to understand the full and exact requirements:

- Must the result be a particular kind of data structure?
- Must the result be sorted in some order?
- How are you expected to handle exceptions? And so on.

You have solved an exercise when all the provided tests run and pass.
In other words, your solution is not just an interpretation of the instructions that "looks right", your solution is a program that _satisfies the given tests_.
**The tests represent the complete requirements for the exercise.**

## How does Exercism apply TDD?

We've done the work of writing a unit test suite for you.
Your goal is to write a solution that contains just enough code to make all those unit tests pass.

Keep this in mind: the TDD approach will help you get to the solution, but you don't need to stop there.
If you want to extend your solution beyond the requirements, you are welcome to do so.
Should you choose to work with a mentor (and we encourage you to do that once you get the tests passing), they can help you refactor and refine your initial implementation, or even propose new unit tests.

## Working in the online editor

When you're working in the code editor on Exercism's website, you can read the tests but you are not able to edit them.
All tests will be executed each time you run them, regardless of any "skip" mechanisms noted in the test file.

When there are multiple tests that fail, the website initially only displays the results of the first failure.
You can click on other failures to expand them, too!
Sometimes the first result may not be the most informative.

Don't be discouraged by a large number of failing tests.
Focus on making them pass one-by-one.

## Working locally

Many tracks use "skipped" tests in their test files.
Initially, only the first test is "active" and the remaining are inactive (how this happens varies by track).
When you run the test suite in your environment, only the first test runs.
We do this to encourage you to follow this workflow:

1. Before adding any new code, run the test suite: you should see a failing test.
1. Add _just enough_ code to pass the test.
1. Run the test suite.
1. If the test still fails, repeat step 2.
1. Once the test passes, refactor your code as desired, ensuring all active tests still pass.
   Refactoring might include:
    - removing any duplicated code,
    - splitting long functions into smaller ones,
    - adding comments, etc.
1. "Unskip" the next test and repeat from step 1.

Repeat these steps until you have unskipped all the tests.
Once all the tests are passing, congratulations, you have solved the exercise!

Exactly how tests are "unskipped" (or activated) depends on the track.
For some tracks, it might be commenting or removing an annotation.
For some tracks, it might be changing an attribute from true to false.
Take the time to read [the documentation for your track][track-docs]; it will explain these details.

For tracks that don't skip the tests, applying this workflow may be as straightforward as commenting out the tests and uncommenting them one-by-one.

## Rationale for Test-Driven Development

While it may seem like "putting the cart before the horse", there are several good reasons why you might want to write unit tests before writing the implementation code.

1. Design.
   It forces you to think first about your program's [interface][api] (how it exposes its functionality to the world), instead of jumping straight into how you will implement the code.
   Having a well-designed (and testable!) interface is often more important than having an efficient implementation.

1. Discipline.
   Writing tests is often seen as a chore or an afterthought; writing the tests _first_ guarantees that at the end of the day you will have written enough unit tests to cover most or all of your code's functionality (rather than possibly never getting around to it).

1. Less Work.
   If you apply a tight cycle of write one test, then write the code to implement that test, then write the next test, your code ends up growing organically.
   This often (though not always) leads to less wasted effort; you end up writing all the code you need, and none of the code you don't need.

## Further reading

- [About Test-First Teaching][test-first] at the archived TestFirst\.org site.
- [Test-driven development][tdd-wiki] at Wikipedia.
- [Test Driven Development][tdd-python] on the Python track.

[track-docs]: https://exercism.org/docs/tracks
[test-first]: https://web.archive.org/web/20220918221108/http://testfirst.org/about
[tdd-wiki]: https://en.wikipedia.org/wiki/Test-driven_development
[tdd-python]: https://exercism.org/docs/tracks/python/test-driven-development
[api]: https://en.wikipedia.org/wiki/API
