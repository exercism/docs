# Reputation

Reputation is the system that allows people to acquire "trust" within the Exericsm ecosystem.

Reputation is a measure of how much an individual has contributed to Exercism, both through contribution to the platform (e.g. through creation of software, exercises and docs) and contribution to the community (e.g. mentoring).

Reputation cannot be "spent" or "used". However, achieving certain Reputation thresholds gives access to new privileges and ways to contribute. Put simply, the more reputation an individual has, the more we feel we can trust them, and so the more power they receive. Reputation is also a publicly-viewable measure of how much you have given to Exercism.

## Purpose

The purpose of the reputation system is to:

1. Maximise growth-centric interactions between students and mentors
2. Maximise the desire of mentors to want to contribute

## Acquisition of Reputation

Reputation can be acquired in a variety of ways:

1. Mentoring others' solutions successfully
2. Writing exercises
3. Updating exercises
4. Creating pull requests
5. Reviewing pull requests
6. Merging pull requests
7. Writing analysers
8. Updating analysers
9. Creating documentation
10. Updating documentation

### 1. Mentoring others' solutions successfully

Algorithm for determining the allocation of reputation points per mentoring interaction is yet to be determined.

### 2. Writing exercises

For each exercise where the user is listed as an author, `20` reputation is awarded.

### 3. Updating exercises

For each exercise where the user is listed as a contributor, `10` reputation is awarded.

### 4. Creating pull requests

For each merged pull request that was opened by the user, `12` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- If a pull request is closed _without_ merging, no reputation is awarded.
- In exceptional circumstances (either tiny PRs changing a few lines, or large PRs that will have taken a greater than normal of effort) is possible to award more (or less) reputation for a merged pull request by adding one of the following labels to the pull request:

  - The `reputation/contributed_code/major` label will bump the awarded reputation to `30`
  - The `reputation/contributed_code/minor` label will bump the awarded reputation to `5`

  If both labels are specified, the `reputation/contributed_code/major` label is used to determine the awarded reputation.

### 5. Reviewing pull requests

For each merged or closed pull request reviewed by the user, `5` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- Review reputation is only awarded once per user per pull request.
- The user that opened the pull request does _not_ get reputation for reviewing their own pull request.

- The reputation awarded for a pull request review changes if one of the following labels are added to the pull request:

  - The `reputation/contributed_code/major` label will bump the awarded reputation to `10`
  - The `reputation/contributed_code/minor` label will bump the awarded reputation to `2`

  If both labels are specified, the `reputation/contributed_code/major` label is used to determine the awarded reputation.

### 6. Merging pull requests

For each pull request that was merged by the user, `1` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- If a pull request is closed _without_ merging, no reputation is awarded.
- The user that opened the pull request does _not_ get reputation for merging their own pull request.
- If the pull request does not have any reviews, `5` reputation is awarded instead.

## Ideas for consideration

- Assigning more reputation where the back-and-forth between student and mentor is longer. Encourages mentors to stick it through and thoroughly deal with the solution.
