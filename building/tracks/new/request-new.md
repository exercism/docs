# Request a new Language Track

Please follow the instructions below to request a new Language Track.

If you wish to request a new track, **you must post in the [Support category on the Exercism Community Forum][forum-support]** to discuss this with the team.

Before opening the post, it's worth considering:
- Is it a programming language?
- Does Exercism already support the language?
- Has anyone else asked for it?
- Will you be available to actively build and launch the track?

## Is it a programming language?

At Exercism we provide a learning platform for developers who want to practice a programming language or learn a new one.

If the language is a general purpose programming language, then we'll probably be interested in having the track on Exercism.
We do not create tracks for tools, libraries, frameworks, or technologies.

## Does Exercism already support the language?

Please [check the list of track repositories][track-repositories] to find both active and inactive tracks.
If you find a repository for your language, check the `active` key's value in the repository's `config.json` file for its status:

- `true`: the track is active and listed on the website's [tracks page][exercism-tracks].
- `false`: the track is inactive and not listed on the website.
  The track still requires work for it to become active.
  If you'd like to help out, please open an issue on that repository to say hello.

## Has someone else asked for it?

Do a search in the [issues of the generic-track repository][generic-track-repo] for the name of the language to see if the language was already requested.
Remember to check both open and closed issues.

## Will you be available to actively build and launch the track?

Exercism is a not-for-profit organization, and all the language tracks are built by volunteers.
We will only create a track if there is at least one volunteer who has offered to take the lead on building it.

The minimum to launch a track is:
- 20 practice exercises (these can be based on specifications in the [problem-specifications][problem-specifications] repository.
- Continuous integration that checks that the exercises can be solved.
- A bit of configuration and documentation.

We are available to guide you along the way, and you can also get help from the community of folks who have done this for other languages.

## It doesn't exist - I want to create it!

Awesome!! Please create a new post in the [Exercism Forum][forum-support] so we can discuss the details.

[forum-support]: https://forum.exercism.org/c/support/8
[generic-track-repo]: https://github.com/exercism/generic-track/issues
[preblem-specifications]: https://github.com/exercism/problem-specifications
