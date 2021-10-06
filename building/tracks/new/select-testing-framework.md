# Select testing framework

All of the exercises are based on providing a failing test suite for people to run and make pass, so we need to pick a testing framework.
If there are multiple testing frameworks available, we'll need to figure out which one is the best fit.

## Considerations

1. Ease of getting started.
1. Cross-platform support (MacOS, Linux, Windows).

For people who are going to be doing the exercises, it's important to get them up and running as quickly as possible.

In general we prefer tools in the standard library if they're available, and if not we aim for a third party library that is widely used.
If there is a choice between several common libraries, then consider a few factors:

- Is one of them easier to install?
- Is one of them easier to get help with or search for resources about?
- Is one of them simpler than the other either in syntax or conceptually?

Remember that all Exercism exercises are by nature very small, so there's no need for the complexity that real-world projects sometimes require.

## Document the decisions

As you make these decisions, document them in the track repository's `README.md` for
contributors and future maintainers. In particular, when someone submits a contribution
that goes against one of these decisions, it's very helpful to be able to point to not just
the conclusion, but also a bit about why that decision was made. That makes it easier to
decide whether to just close the issue or pull request from the contributor, or whether
it's time to re-evaluate the decision based on new information.

The harder the decision was to make, the more important it is to document it thoroughly.
(e.g. What trade-offs did you consider? What tipped your gut feeling in one direction or the other? What sealed the deal?)
