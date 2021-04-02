# Deprecated exercises

Deleting an exercise is a destructive action as it would delete all users' solutions to that exercise.
Therefore, exercises can **never** be deleted.
Instead, we allow exercises to be deprecated.

Deprecating an exercise has the following behaviours:

- Users who have downloaded or started the exercise can access their existing solution as normal
- Users who have **not** downloaded or started the exercise, will not see or be able to start it.

To help with this, we have config rules that accompany a deprecated exercise
Deprecated exercises must have the following properties set in `config.json`:

- **`uuid`** (unchanged from when it was active)
- **`slug`** (unchanged from when it was active)
- **`status`** set to `deprecated`

The following should be empty:

- `prerequisites`
- `practices`
- `concepts`

All other fields in deprecated exercises can be safely changed or removed in accordance with the wider config rules.

[configlet]: /language-tracks/configuration/configlet.md
[topics]: https://github.com/exercism/problem-specifications/blob/master/TOPICS.txt
[track-blocking-progression]: https://github.com/exercism/v2-feedback/issues/36
