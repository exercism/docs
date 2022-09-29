# Mentoring Notes

There are two types of mentoring notes:

1. Exercise-specific notes (shown for one specific exercise in the track)
2. Track-specific notes (shown for _all_ exercises in the track)

The aim for these notes is to:

- Make mentoring an exercise easier for mentors
- Make mentoring an exercise consistent across mentors

## What do Mentoring Notes contain?

Exercise-specific mentoring notes often contain:

- Examples of reasonable solutions
- Common suggestions/pitfalls
- Talking points

Track-specific mentoring notes often contain:

- Common suggestions/pitfalls (that apply to _all_ exercises)
- Links to useful resources (like a style guide)

## How to add Mentoring Notes

Mentoring notes are stored in the [website-copy repo][website-copy] using the following file naming patterns:

- Exercise mentoring notes: `tracks/<track-slug>/exercises/<exercise-slug>/mentoring.md`
- Track mentoring notes: `tracks/<track-slug>/mentoring.md`

To add mentoring notes, submit a PR to add a file following the above file naming patterns.

### Why are Mentoring Notes not in the track repo?

Maintaining a track is quite different from writing mentoring notes and requires different skills.
Therefore, the people writing mentoring notes should not necessarily be the same people that are maintaining a track.

If we would store the mentoring notes within the track's repo, maintainers would have to sign off on any mentoring note PRs before they can be merged (or at least they'd be notified for each mentoring note change).
Storing the mentoring notes in the [website-copy repo][website-copy] allows us to:

- Reduce the burden on track maintainers
- Also have different people reviewing mentoring notes than the track maintainers (they _can_ overlap)
- Allow for quicker iteration on mentoring notes (track maintainers are often quite strict when merging PRs)

[website-copy]: https://github.com/exercism/website-copy/
