# Docs

Each track must have a `docs` directory with the following (required) files:

```
docs
├── ABOUT.md
├── INSTALLATION.md
├── LEARNING.md
├── SNIPPET.txt
├── RESOURCES.md
└── TESTS.md
```

---

## File: `ABOUT.md`

**Purpose:** A short introduction to the language.

**Displayed on:** The track page, provided the student has not joined the track.

### Example

```markdown
# About

[F#](http://www.tryfsharp.org/Explore) is a strongly-typed, functional language that is part of Microsoft's .NET language stack.

Although F# is great for data science problems, it can elegantly handle almost every problem you throw at it.

As F# runs on the .NET runtime, you get access to the entire .NET ecosystem, including all packages on [nuget.org](https://www.nuget.org/).

Integration with existing .NET code is further simplified due to F# also allowing you to write object-oriented code.

The home page for F# is [fsharp.org](http://fsharp.org/) and a great introduction to F# can be found at the [F# for fun and profit](http://fsharpforfunandprofit.com/) website.
```

Check [this page](https://exercism.org/tracks/fsharp) to see what this looks like when rendered (note: you must not have already joined the track).

## File: `INSTALLATION.md`

**Purpose:** Describe what the student needs to install to allow working on the track on their local system using the CLI.

**Displayed on:** The track's documentation page at `https://exercism.org/docs/tracks/<track>/installation`.

### Example

````markdown
# Installation

## Installing .NET

The F# track is built on top of the [.NET](https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet) platform, which runs on Windows, Linux and macOS. To build .NET projects, you can use the .NET Command Line Interface (CLI). This CLI is part of the .NET SDK, which you can install by following the [installation instructions](https://dotnet.microsoft.com/download/dotnet/5.0). Note: the F# track requires SDK version 5.0 or greater.

After completing the installation, you can verify if the CLI was installed succesfully by running this command in a terminal:

```bash
dotnet --version
```

It the output is a version greater than or equal to `5.0.100`, the .NET SDK has been installed succesfully.

## Using an IDE

If you want a more full-featured editing experience, you probably want to to use an IDE. These are the most popular IDE's that support building .NET projects:

- [Visual Studio 2019](https://www.visualstudio.com/downloads/)
- [Visual Studio Code](https://code.visualstudio.com/download) with the [Ionide-fsharp extension](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fsharp)
- [Visual Studio for Mac](https://www.visualstudio.com/vs/visual-studio-mac/)
- [Project Rider](https://www.jetbrains.com/rider/download/)

Note: as the .NET project format differs significantly from earlier versions, older IDE's (like Visual Studio 2015) are not supported.
````

Check [this page](https://exercism.org/docs/tracks/fsharp/installation) to see what this looks like when rendered.

## File: `LEARNING.md`

**Purpose:** Links to learning resources.

**Displayed on:** The track's documentation page at `https://exercism.org/docs/tracks/<track>/learning`.

### Example

```markdown
# Learning F#

## Websites

- The [F# Hello World tutorial](https://dotnet.microsoft.com/learn/languages/fsharp-hello-world-tutorial/intro) is a nice and gentle introduction to working with F#.
- The [F# for Fun and Profit](http://fsharpforfunandprofit.com/) website has tons of great F# content. From a [gentle introduction](http://fsharpforfunandprofit.com/posts/key-concepts/) to the world of F# to more advanced concepts, it's all covered. Bonus: all content is also available as an [eBook](https://www.gitbook.com/book/swlaschin/fsharpforfunandprofit/details).
- The [Tour of F#](https://docs.microsoft.com/en-us/dotnet/fsharp/tour) page nicely demonstrates many of the core F# language features.
- The [F# Foundation](http://fsharp.org/) is a non-profit organisation which aim is to promote F#. The website has lots of links to great F# content. Perhaps even more interesting is their [mentorship program](http://fsharp.org/mentorship/index.html), where you can apply to learn F# from an experienced F# mentor.

## Videos

- [F# for the Practical Developer](https://www.youtube.com/watch?v=7z_q06HQLes) is a nice introduction to F#.
- [F# - Why you should give an F](https://www.youtube.com/watch?v=kKkFabSzZvU) has Daniel Chambers give a sweet introduction into F#, neatly highlighting most F#'s features.
- In [A tour of F#](https://www.youtube.com/watch?v=15tK48Xes0k), Phillip Carter gives a great introduction to the F# language.
- [Dr. Don Syme - Introduction to F#](https://channel9.msdn.com/Series/C9-Lectures-Dr-Don-Syme-Introduction-to-F-/C9-Lectures-Dr-Don-Syme-Introduction-to-F-1-of-3) has Don Syme, the designer of F#, give an introduction to F#.
- If you're a C# developer, you might like [F# for C# developers](https://vimeo.com/78908217) by Phil Trelford.
- [PluralSight](https://www.pluralsight.com/) has several [great](https://www.pluralsight.com/courses/fsintro) [introduction](https://www.pluralsight.com/courses/fsharp-jumpstart) [courses](https://www.pluralsight.com/courses/fsharp-fundamentals). The downside: PluralSight is a paid service, but you can request a [free trial](https://www.pluralsight.com/pricing).

## Books

- [Beginning F# 4.0](https://books.google.nl/books?id=puQgDAAAQBAJ&redir_esc=y)
- [Real-World Functional Programming](https://books.google.nl/books?id=KfooAQAAMAAJ&q=isbn:1933988924&dq=isbn:1933988924&hl=en&sa=X&ved=0ahUKEwj-4eCii43RAhWdYFAKHdmnAEIQ6AEIHDAA)

## Misc

- The [F# mentorship program](https://fsharp.org/mentorship/about.html) offers free mentorship by very proficient F# users.
```

Check [this page](https://exercism.org/docs/tracks/fsharp/learning) to see what this looks like when rendered.

## File: `SNIPPET.txt`

**Purpose:** Showcase the language via a small snippet.

**Displayed on:** The track page, provided the student has not joined the track.

The snippet should be relatively small (10-ish lines).

### Example

```fsharp
module HelloWorld

let hello = "Hello, World!"
```

Check [this page](https://exercism.org/tracks/fsharp) to see what this looks like when rendered (note: you must not have already joined the track).

## File: `RESOURCES.md`

**Purpose:** Links to useful resources.

**Displayed on:** The track's documentation page at `https://exercism.org/docs/tracks/<track>/resources`.

### Example

```markdown
# Recommended Learning Resources

## Blogs

- Sergey Tihon's [F# Weekly blog](https://sergeytihon.wordpress.com/) is a weekly-updated website that lists recent F# news and articles.
- Mark Seemann's [blog](http://blog.ploeh.dk/) also has lots of interesting F# articles, usually focusing on how to design your application.
- Scott Wlaschin's [F# for fun and profit](https://fsharpforfunandprofit.com/) is a blog for experienced developers. He describes complex patterns and concepts clearly and with a good sense of humor. Also, check out his talks on F# and functional programming topics.

## Social media

- [StackOverflow ](http://stackoverflow.com/questions/tagged/f%23) can be used to search for your problem and see if it has been answered already. You can also ask and answer questions.
- The [F# channel](https://functionalprogramming.slack.com/messages/fsharp/) of the [functionalprogramming slack account](https://functionalprogramming.slack.com/). To join, go to [fpchat-invite.herokuapp.com](https://fpchat-invite.herokuapp.com/).
- The [F# slack account](https://fsharp.slack.com). To join, you have to [become a member of the F# foundation](http://fsharp.org/guides/slack/).
- [/r/fsharp](https://www.reddit.com/r/fsharp) is the F# subreddit.
- The [Gitter channel](https://gitter.im/exercism/xfsharp) can be used to ask questions and get support for any issues related to the F# track.

## Videos

- The [Community for F#](https://www.youtube.com/channel/UCCQPh0mSMaVpRcKUeWPotSA/feed) YouTube channel has got lots of F# videos.
- There are several great [F# courses](https://www.pluralsight.com/search?q=*&categories=course&roles=software-development%7C&subjects=f%23) on PluralSight. The downside: PluralSight is a paid service, but you can request a [free trial](https://www.pluralsight.com/pricing).

## Books

- [Expert F# 4.0](https://books.google.nl/books?id=L_0PogEACAAJ&dq=isbn:1484207424&hl=en&sa=X&ved=0ahUKEwjs__-hi43RAhWIMFAKHUJPASwQ6AEIHDAA)
```

Check [this page](https://exercism.org/docs/tracks/fsharp/tests) to see what this looks like when rendered.

## File: `TESTS.md`

**Purpose:** Describe everything related to running tests in the track.

**Displayed on:** The track's documentation page at `https://exercism.org/docs/tracks/<track>/tests`.

### Example

````markdown
# Tests

## Running Tests

To run the tests, execute the following command:

```bash
dotnet test
```

## Solving the exercise

Solving an exercise means making all its tests pass. By default, only one test (the first one) is executed when you run the tests. This is intentional, as it allows you to focus on just making that one test pass. Once it passes, you can enable the next test by removing `Skip = "Remove this Skip property to run this test"` from the test's `[<Fact>]` or `[<Theory>]` attribute. When all tests have been enabled and your implementation makes them all pass, you'll have solved the exercise!

To help you get started, each exercise comes with a stub implementation file. You can use this file as a starting point for building your solution. Feel free to remove or change this file if you think it is the right thing to do.

## Using packages

You should be able to solve most exercises without using any external packages. However, for the exercises where you do want to use an external package, you can add it to your project by running the following command:

```bash
dotnet add package [package-name]
```
````

Check [this page](https://exercism.org/docs/tracks/fsharp/installation) to see what this looks like when rendered.
