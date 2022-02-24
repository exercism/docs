# FAQs

## Who is behind Exercism?

Exercism's two co-founders are [Katrina Owen][katrina-owen] and [Jeremy Walker][jeremy-walker].

Exercism was originally founded by [Katrina][kytrinyx], a polyglot developer and winner of the "Ruby Hero" award who accidentally became a developer while pursuing a degree in molecular biology.
She began nitpicking code back in 2006 while volunteering at JavaRanch, and got hooked.
When programming, her focus is on automation, workflow optimization, and refactoring.
She cares deeply about open source and contributes to several projects outside of Exercism.

In 2016, [Jeremy][ihid] joined as co-founder, and he is currently Exercism's CEO.
Jeremy is a social entrepreneur and software developer, passionate about equality and creating opportunity for everyone.
In addition to Exercism, he is the co-founder of the [Wellbeing and Teambuilding platform][kaido], Kaido.

In addition to this [leadership team](/team), Exercism has a [small full- and part-time team](/team/staff), and is supported by thousands of wonderful volunteers who have crafted the various language tracks and exercises that made Exercism so popular.

Learn more about our [mentors](/team/mentors), our [track maintainers](/team/maintainers) and our thousands of [contributors](/team/contributors).

## What's with the name "Exercism"?

Despite being one vowel away from "exorcism", the name has nothing to do with demons or fixing "evil code".

Instead, it's a pun on exercise.
The way Katrina came to think about each exercise is that they are small, trivial, and seemingly simple.
However, when it comes to solving an exercise, the devil is often in the details.
In other words, that simple exercise is suddenly more challenging once you think about the finer details.

To learn more about what it means for the devil to be in the details, check out the [Overkill][overkill] and [Succession][succession] talks by Katrina.

## The Basics

## I'm lost. Where do I go?

You're in luck.
Here's a [step-by-step guide][getting-started] to get you started.

If something is still unclear for you or not working then it might be the same for others so we'd appreciate you letting us know.
Refer to [Opening an Issue][opening-an-issue] below for instructions on how you can help us help others.

## I get the error "Sorry, we could not authenticate you from GitHub" when trying to log in. What should I do?

This means that GitHub isn't willing to verify who you are.
That can be because you chose not to give permission or it might be because your GitHub account is not properly configured.
A common problem is that you haven't verified your email address on GitHub.
You can check that in your [GitHub email settings][email-settings].

## How do I delete my account?

You can delete your account by following the link at the bottom of your [settings page][settings].
If your issue is with emails and notifications you can adjust that in [your personal preferences][personal-settings].

## What happened to my Team from the old site?

We now have a [dedicated Teams site][dedicated-teams].

## How do I unlock exercises?

By default, tracks with Learning Exercises require you to solve Learning Exercises to unlock other exercises (each should take around 5 minutes to solve if you are fluent in a language).
This is called [Learning Mode][learning-mode].

While we recommend using Learning Mode to progress through a track, you could [switch to Practice Mode][switching-modes] to unlock all exercises.
For more information, see [unlocking exercises][unlocking-exercises].

## Why have my unlocked exercises in the old site become locked?

By default, tracks with Learning Exercises require you to solve Learning Exercises to unlock other exercises (each should take around 5 minutes to solve if you are fluent in a language).
This is called [Learning Mode][learning-mode], and it is the default for any user from the old site.
If you are a returning user, who used a previous version of Exercism, you may find that exercises that were previously available have now become locked.

While we recommend using Learning Mode to progress through a track, you could [switch to Practice Mode][switching-modes] to unlock all exercises.
For more information, see [unlocking exercises][unlocking-exercises].

## Exercism Command-line Client

## I can't submit! What should I do?

The new site has a brand new command-line client, and also needs some extra metadata for your exercise.
Read about how to [upgrade your command-line client and migrate your solutions for the new site][upgrade-cli].

If that doesn't help, or you didn't use the old version of the command-line client, please read through the [command-line client Walkthrough][cli-walkthrough].
If that doesn't help either, [open an issue][new-cli-issue] and we will help you get it sorted out.

## How do I check the version of my command-line client?

The version command `exercism version` outputs the running version of the Exercism command-line client.
By running the version command with the latest flag `exercism version --latest` you can check if there is a newer version available.

## How do I upgrade to the latest version of the command-line client?

The command `exercism upgrade` will upgrade to the latest available version of the command-line client if one is available.

## I get permission denied errors when upgrading! What should I do?

If you are receiving permission denied errors when trying to upgrade the command-line client, chances are the binary was installed via a system package manager (e.g Homebrew) or has been installed into a directory that you no longer have write access to.

If your command-line client was installed via a package manager please use your package manager for upgrading, as opposed to running the `exercism upgrade` command.

If your command-line client was installed manually, please check the path of the Exercism command-line client `which exercism` on Linux and MacOs, `where exercism` on Windows and ensure that the returned path is a directory you created.
If so, use the tools provided by your system to change the permissions of the directory to grant write access to your user and trying upgrading again.
If you are not sure if you created the directory, or the returned path is a system path, please use your system tools to uninstall the command-line client and reinstall using the [interactive walkthrough][interactive-walkthrough].

## I get the "16-bit MS-DOS Subsystem" error dialog after upgrading on Windows. What should I do?

Prior to version 3.0.5 of the Exercism command-line client, there was a bug in the upgrade command that would replace the command-line client binary file with a single text file causing the "16-bit MS-DOS Subsystem" error.
To resolve this issue remove the corrupt binary and reinstall the command-line client using the [interactive walkthrough][interactive-walkthrough].

## Mentored Mode

## My queue hasn't updated in a while - is there something wrong?

While wait times can be longer than normal for a number of reasons (number of mentors, time of year), it can also appear that the queue is not updating.
This is not unusual and you should see movement fairly soon.
If you your wait is far longer than the average, refer to [Opening an Issue][opening-an-issue] below.

## How many mentors does my track have? I only see a handful on the website.

The website only shows mentors who have provided bio information for the website, not the actual number of mentors who are actively reviewing solutions.
Rest assured, there are mentors working through their queues so hang in there!

## I submitted the wrong solution / file. What can I do?

On the exercise page in question, navigate to "Your Iterations".
If the unwanted iteration is folded, click the circled arrow.
In the "dots" menu, select "Delete iteration".

## How can I report abuse or examples of bad mentoring?

Please check our [Code of Conduct][coc] for more information about our expectations of conduct.
If you would like to report something, please reach out to us at [abuse@exercism.org][mail-abuse] and we will try to fix or resolve the issue respecting both you and your privacy.

## Improving Exercism

## This is great! How do I get involved?

There are a few different ways - becoming a mentor, managing a language track or reporting (or addressing!) issues on GitHub.
You can see more on the [How to Contribute page][contribute].

## How do new language tracks get added to the site?

A new language track gets created when a member of the community takes the lead on it and becomes a maintainer of the track.
If you'd like to get involved in helping set one up, there are [instructions here][new-language-request].

## Opening an Issue

Before submitting an issue, be sure to check the relevant GitHub issue tracker to see if it has already been reported or resolved:

1. [The Exercism Website or Product][website-copy]
2. [The Command-Line Interface (CLI) Client][cli-client-issues]
3. [Exercises][languages] - Select your language and then look at the issues tab

You can search through issues (remove the `is:open` filter to include closed/resolved issues).
Try a few different keywords.

## What if my issue is not listed here or in GitHub?

If your problem hasn't been resolved or reported, then create an issue in the appropriate repository by selecting the green **New issue** button.

Make sure to include the following information:

1. The output of the `exercism troubleshoot` command (for CLI issues)
1. Details on the issue you are experiencing
1. Instructions on how to reproduce the issue
1. If applicable, reference to any related issue using its issue number (formatted like #1203)

## What if there is an issue with language on the website?

If your issue pertains to an exercise in your language track, then please find the correct language track [from this list][from-this-list] and submit an issue there.
Please specify if the issue is with the instructions or something language specific, using the template below.

If you have spotted a typo or if you have a suggestion for clearer language or instructions on the general website, then [create an issue for Exercism Website Copy][website-copy-new-issue] with the following information:

1. Link to the page where the issue is
1. Explanation of what the mistake is or what is unclear
1. Your proposed change

[cli-client-issues]: https://github.com/exercism/CLI/issues
[cli-walkthrough]: https://exercism.org/cli-walkthrough
[coc]: https://exercism.org/code-of-conduct
[contribute]: https://exercism.org/contribute
[dedicated-teams]: https://teams.exercism.org
[email-settings]: https://github.com/settings/emails
[from-this-list]: https://github.com/search?q=topic%3Aexercism-track+org%3Aexercism+fork%3Atrue
[getting-started]: https://exercism.org/getting-started
[ihid]: https://ihid.info
[interactive-walkthrough]: https://exercism.org/cli-walkthrough
[jeremy-walker]: https://ihid.info
[kaido]: https://kaido.org
[katrina-owen]: http://www.kytrinyx.com/
[kytrinyx]: http://www.kytrinyx.com/
[languages]: https://github.com/search?q=topic%3Aexercism-track+org%3Aexercism&type=Repositories
[learning-mode]: /docs/building/product/unlocking-exercises#h-learning-mode-vs-practice-mode

[mail-abuse]: mailto:abuse@exercism.org?subject=%5BCoC%5D]
[new-cli-issue]: https://github.com/exercism/CLI/issues/new
[new-language-request]: https://github.com/exercism/request-new-language-track/blob/main/README.md
[opening-an-issue]: #opening-an-issue
[overkill]: http://www.kytrinyx.com/talks/overkill
[personal-settings]: https://exercism.org/my/settings/preferences/edit
[settings]: https://exercism.org/my/settings
[succession]: http://www.kytrinyx.com/talks/succession
[switching-modes]: /docs/building/product/unlocking-exercises#h-switching-modes
[unlocking-exercises]: /docs/building/product/unlocking-exercises
[upgrade-cli]: https://github.com/exercism/website-copy/blob/main/pages/cli_v1_to_v2.md
[website-copy]: https://github.com/exercism/website-copy/issues
[website-copy-new-issue]: https://github.com/exercism/website-copy/issues/new
