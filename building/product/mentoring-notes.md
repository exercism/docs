# Mentoring Notes

Mentoring notes are exercise-specific notes aimed to:

- Make mentoring an exercise easier for mentors
- Make mentoring an exercise consistent across mentors

## What do Mentoring Notes contain?

Mentoring notes often contain:

- Examples of reasonable solutions
- Common suggestions/pitfalls
- Talking points

## How to add Mentoring Notes

Mentoring notes are stored in the [website-copy repo][website-copy] within a `tracks/<track-slug>/exercises/<exercise-slug>/mentoring.md` file.
To add mentoring notes, submit a PR to add a file following the above file naming pattern.

### Why are Mentoring Notes not in the track repo?

Maintaining a track is quite different from writing mentoring notes and requires different skills.
Therefore, the people writing mentoring notes should not necessarily be the same people that are maintaining a track.

If we would store the mentoring notes within the track's repo, maintainers would have to sign off on any mentoring note PRs before they can be merged (or at least they'd be notified for each mentoring note change).
Storing the mentoring notes in the [website-copy repo][website-copy] allows us to:

- Reduce the burden on track maintainers
- Also have different people reviewing mentoring notes than the track maintainers (they _can_ overlap)
- Allow for quicker iteration on mentoring notes (track maintainers are often quite strict when merging PRs)

[website-copy]: https://github.com/exercism/website-copy/
