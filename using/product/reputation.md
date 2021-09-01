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

For each succesfully mentored solution (discussion was finished), `5` reputation is awarded.

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

For each merged pull request that was opened by the user, `12` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- If a pull request is closed _without_ merging, no reputation is awarded.
- In exceptional circumstances (either tiny PRs changing a few lines, or large PRs that will have taken a greater than normal of effort) is possible to award more (or less) reputation for a merged pull request by adding one of the following labels to the pull request:

  | Label            | Reputation |
  | ---------------- | ---------- |
  | `x:size/tiny`    | 3          |
  | `x:size/small`   | 5          |
  | `x:size/medium`  | 12         |
  | `x:size/large`   | 30         |
  | `x:size/massive` | 100        |

  If more than one label is specified, the label with the highest reputation value determines the awarded reputation.

  Note that an `x:size` label on an **issue** never affects the awarded reputation - even if a merged pull request lacks an `x:size` label, and closes an issue that has one.

### Reviewing a pull requests

For each merged or closed pull request reviewed by the user, `5` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- Review reputation is only awarded once per user per pull request.
- The user that opened the pull request does _not_ get reputation for reviewing their own pull request.

- The reputation awarded for a pull request review changes if one of the following labels are added to the pull request:

  | Label            | Reputation |
  | ---------------- | ---------- |
  | `x:size/tiny`    | 1          |
  | `x:size/small`   | 2          |
  | `x:size/medium`  | 5          |
  | `x:size/large`   | 10         |
  | `x:size/massive` | 20         |

  If more than one label is specified, the label with the highest reputation value determines the awarded reputation.

### Merging a pull request

For each pull request that was merged by the user, `1` reputation is awarded.

- If a pull request is still open, no reputation is awarded (yet).
- If a pull request is closed _without_ merging, no reputation is awarded.
- The user that opened the pull request does _not_ get reputation for merging their own pull request.
- If the pull request does not have any reviews, `5` reputation is awarded instead.
