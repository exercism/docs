# Reputation

Reputation is the system that allows people to acquire "trust" within the Exercism ecosystem.

Reputation is a measure of how much an individual has contributed to Exercism, both through contribution to the platform (e.g. through creation of software, exercises and docs) and contribution to the community (e.g. mentoring).

Reputation cannot be "spent" or "used". However, achieving certain Reputation thresholds gives access to new privileges and ways to contribute. Put simply, the more reputation an individual has, the more we feel we can trust them, and so the more power they receive. Reputation is also a publicly-viewable measure of how much you have given to Exercism.

## Purpose

The purpose of the reputation system is to:

1. Maximize growth-centric interactions between students and mentors
2. Maximize the desire of mentors to want to contribute

## Acquisition of Reputation

Reputation can be acquired in a variety of ways:

| Action                            | Reputation |
| --------------------------------- | ---------- |
| Mentoring a solution successfully | 5          |
| Publishing a solution             | 1-3        |
| Writing an exercise               | 20         |
| Updating an exercise              | 10         |
| Writing a concept                 | 10         |
| Updating a concept                | 5          |
| Creating a pull request           | 3-100      |
| Reviewing a pull request          | 1-20       |
| Merging a pull request            | 1-5        |

### Mentoring a solution successfully

For each successfully mentored solution (discussion was finished), `5` reputation is awarded.

### Publishing a solution

For each published solution, reputation is awarded dependent on the exercise's difficulty:

| Label    | Reputation |
| -------- | ---------- |
| `easy`   | 1          |
| `medium` | 2          |
| `hard`   | 3          |

### Writing an exercise

For each exercise where the user is listed as an author, `20` reputation is awarded.

### Updating an exercise

For each exercise where the user is listed as a contributor, `10` reputation is awarded.

### Writing a concept

For each concept where the user is listed as an author, `10` reputation is awarded.

### Updating a concept

For each concept where the user is listed as a contributor, `5` reputation is awarded.

### Creating a pull request

By default, `12` reputation is awarded when a pull request is merged that was opened by the user.

Depending on the content of the pull request, a maintainer can award more (or less) reputation by adding one of the following labels to the pull request:

| Label           | Reputation    | Examples                                                                                                                                                                                                                                                                                                                                                            |
| --------------- | ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `x:rep/tiny`    | 3 (~5 mins)   | <ul><li>Fixing a single typo or link</li><li>Removing a blank line or adding a line break</li><li>Changing/adding a single code comment</li></ul>                                                                                                                                                                                                                   |
| `x:rep/small`   | 5 (~10 mins)  | <ul><li>Fixing a single test case, task or example</li><li>Fixing multiple typos or links in a single file</li><li>Clarifying content by adding a few lines to a file</li></ul>                                                                                                                                                                                     |
| `x:rep/medium`  | 12 (~30 mins) | <ul><li>Syncing an exercise with problem-specifications (incl. edits)</li><li>Adding one or more test cases from scratch</li><li>Improving multiple files in an exercise</li><li>Adding mentor notes for an exercise from scratch</li><li>Fixing a small bug in a test runner/analyzer/representer</li><li>Adding analyzer comments for a single exericse</li></ul> |
| `x:rep/large`   | 30 (~2 hrs)   | <ul><li>Adding a new concept or practice exercise</li><li>Adding new concept documentation</li><li>Substantial re-writing of an existing concept or exercise</li><li>Adding new CI scripts or other automation</li></ul>                                                                                                                                            |
| `x:rep/massive` | 100 (~5 hrs)  | <ul><li>Creating a test-runner, analyzer, representer or generator from scratch</li><li>Major refactors to those tools</li><li>Creating major documentation from scratch (e.g. contribution or testing guides)</li></ul>                                                                                                                                            |

The examples above can serve as rough orientation when to apply which label but maintainers are free to use their own judgement.

- The estimated number of time spent should be interpreted as the average time a _maintainer_ would spend on doing the PR.
- If more than one label is specified, the label with the highest reputation value determines the awarded reputation.
- If a pull request is still open, no reputation is awarded (yet).
- If a pull request is closed _without_ merging, no reputation is awarded.

_For backwards compatibility purposes, we also support using the `x:size` labels to determine the awarded reputation._

### Reviewing a pull requests

For each merged or closed pull request reviewed by the user, `5` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- Review reputation is only awarded once per user per pull request.
- The user that opened the pull request does _not_ get reputation for reviewing their own pull request.

- The reputation awarded for a pull request review changes if one of the following labels are added to the pull request:

  | Label           | Reputation |
  | --------------- | ---------- |
  | `x:rep/tiny`    | 1          |
  | `x:rep/small`   | 2          |
  | `x:rep/medium`  | 5          |
  | `x:rep/large`   | 10         |
  | `x:rep/massive` | 20         |

  It is _not_ possible to use different reputation "sizes" for a pull request author and reviewer.
  Both are based on the same `x:rep` label.

  If more than one label is specified, the label with the highest reputation value determines the awarded reputation.

  _For backwards compatibility purposes, we also support using the `x:size` labels to determine the awarded reputation._

### Merging a pull request

For each pull request that was merged by the user, `1` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- If a pull request is closed _without_ merging, no reputation is awarded.
- The user that opened the pull request does _not_ get reputation for merging their own pull request.
- If the pull request does not have any reviews, `5` reputation is awarded instead.

### Opening an issue

By default, **no reputation is awarded** when an issue is opened.

Depending on the content of the issue, a maintainer can choose to award reputation by adding one of the following labels to the issue:

| Label           | Reputation    | Examples                                                                                                                                                                                                                                                                                                                                                            |
| --------------- | ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `x:rep/tiny`    | 3 (~5 mins)   | <ul><li>Fixing a single typo or link</li><li>Removing a blank line or adding a line break</li><li>Changing/adding a single code comment</li></ul>                                                                                                                                                                                                                   |
| `x:rep/small`   | 5 (~10 mins)  | <ul><li>Fixing a single test case, task or example</li><li>Fixing multiple typos or links in a single file</li><li>Clarifying content by adding a few lines to a file</li></ul>                                                                                                                                                                                     |
| `x:rep/medium`  | 12 (~30 mins) | <ul><li>Syncing an exercise with problem-specifications (incl. edits)</li><li>Adding one or more test cases from scratch</li><li>Improving multiple files in an exercise</li><li>Adding mentor notes for an exercise from scratch</li><li>Fixing a small bug in a test runner/analyzer/representer</li><li>Adding analyzer comments for a single exericse</li></ul> |
| `x:rep/large`   | 30 (~2 hrs)   | <ul><li>Fully-fleshed out Concept Exercise</li></ul>                                                                                                                                                                                                                                                                                                                |
| `x:rep/massive` | 100 (~5 hrs)  | <ul><li>Designing a track curriculum</li></ul>                                                                                                                                                                                                                                                                                                                      |

The examples above can serve as rough orientation when to apply which label, but maintainers are free to use their own judgement.

- The reputation should reflect the amount of effort that _maintainer_ would spend to create the issue.

- If more than one label is specified, the label with the highest reputation value determines the awarded reputation.
