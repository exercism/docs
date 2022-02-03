# Deprecated exercises

Deleting an exercise is a destructive action as it would delete all users' solutions to that exercise.
Therefore, exercises can **never** be deleted.
Instead, we allow exercises to be deprecated.

Deprecating an exercise has the following behaviors:

- Users who have downloaded or started the exercise can access their existing solution as normal
- Users who have **not** downloaded or started the exercise, will not see or be able to start it.

## Deprecating an exercise

To deprecate an exercise, simply change its `config.json` entry as follows:

- **`status`**: set to `"deprecated"`
- **`prerequisites`**: set to `[]`
- **`practices`**: set to `[]` (Practice Exercises only)
- **`concepts`**: set to `[]` (Concept Exercises only)

**All other properties must remain the same.**

**All exercise files must remain untouched.**

[configlet]: /language-tracks/configuration/configlet.md
[topics]: https://github.com/exercism/problem-specifications/blob/master/TOPICS.txt
[track-blocking-progression]: https://github.com/exercism/v2-feedback/issues/36
