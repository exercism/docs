# Chesterton's Fence

Hello :wave:
You're probably here because someone directed you to this post in response to you suggesting an idea about how Exercism could be improved.
Before our team invests time into exploring your idea, they're hoping you'll read this and consider whether your idea might have been thought of before, what pitfalls it might contain.
**By adding those considerations and potential pitfalls to your suggestion, and considering why your idea might not have already been implemented, you are likely to get a faster and more positive response.**

## So what does "Chesterton's Fence" mean?

Chesterton's Fence is an idea inspired by a quote from the writer G.K. Chesterton's 1929 book, The Thing.
It became well-known as it was quoted by John F. Kennedy.
This is the original quote:

> There exists in such a case a certain institution or law; let us say, for the sake of simplicity, a fence or gate erected across a road.
> The more modern type of reformer goes gaily up to it and says, “I don’t see the use of this; let us clear it away.”
> To which the more intelligent type of reformer will do well to answer: “If you don’t see the use of it, I certainly won’t let you clear it away. Go away and think. Then, when you can come back and tell me that you do see the use of it, I may allow you to destroy it."

The idea of Chesterton's Fence is that you if don't understand why something is there, you probably don't understand why it should be removed.
Equally, if you don't understand why something **isn't** there, you probably don't understand why it's been left out.

A simple rule to remember is: **"Do not remove a fence until you know why it was put up in the first place."**

## This Notion is Relevant to Exercism how?

At Exercism, we’re fortunate to have loads of people joining our community all the time, and posting their thoughts and ideas. 
Many of those ideas are new, innovative, exciting, and unblock our thinking.
So if you have an idea or a suggestion, we welcome it!

However, more often people post ideas that have been discussed many times before. 
Responding to those ideas, and readdressing or rejustifying our decisions can be extremely draining on our team. 
This article aims to help protect that time and energy.

Exercism has been designed, engineered and built by thousands of very talented individuals.
It is a very intentional product - things are there because they've been designed to be there, and things are often left out because they've been designed to be left out.
Nearly everything with Exercism has been debated, discussed and re-enginnered many times.

So before posting your idea, please ask yourself whether we might have already considered it, and why we might have done things differently to what you're suggesting.
And remember, the more obvious your idea seems - the more likely it's been discussed and debated many times over -- so when you present it, present it with the potential caveats and pitfalls in place.
If you have an instinct to say "why not **just** ...", then it almost certainly falls into this category.

Don't ever be scared of posting, but please think things through carefully first!

## Do you have an example?

A common frustration is that students submit code to mentors that does not pass the tests.
An equally common suggestion is "Why not just automatically run the tests in the CLI before someone submits their code?"
It seems like a great idea - the CLI can just call a command to run the tests, and not let the student submit if they're broken.

So firstly, what does it mean to "just call a command to run the tests".
It means writing a script for each of the 52 languages on Exercism that can run the tests and check the outcome.
That's a bit of effort, but doable.

But it also means writing that script so that it runs on Windows, MacOSX and Linux --  in any and all possible versions/configurations. That's a lot (if not an unbounded) amount of work.
"Why does it have to be _every_ configuration?" you may ask?
Well, because you're actively blocking someone from using Exercism unless they can run this script.
That also means that it can never fail.
If for some reason the script doesn't run, then the student is entirely blocked.
A bug in one of those `52*3*n` scripts means a student can't use the track any more on that OS.
How do you test that?
You can't.

But, you say, you could just add a `--skip-tests` flag.
That's a good suggestion, but it leads us back to our starting point that people can choose to bypass the tests whenever they want.
Except now we're in a situation where it's marginally less likely that broken tests are submitted so mentors have a lower expectation of that, meaning it's more jarring and confusing when the tests **are** broken.

"But people wouldn't do that generally" you may argue. True, for some languages where it takes 0.5s to run the tests.
But for languages that take 20s to run the tests, having to wait an extra 20s to submit is incredibly frustrating for students, and so skipping the final tests would become common-place. 

Regardless of where this conversation ends up, it's clear that there's a lot more complexity involved here than it first seems. There are technical challenges to consider, workflow problems to think about, and the realisation that tracks differ widely enough something that is quick and easy for one is painful for another.

So rather than posing the suggestion of "why not run the tests before submission", let's ask a question: "Why do people post solutions that don't pass the tests?"
And then things get interesting.
The general answer is because they're stuck or confused.
And they need help.
Which means that submitting broken tests is a really important heuristic for mentors that this student _needs help_.
Yes, it's frustrating because mentors don't immediately know if the code is "correct" or not. However, they can download the code and run it to verify it (which most mentors do on non-trivial solutions) and then know with 100% certainty whether it is correct or not.
And the students who are stuck and need help don't end up more stuck, needing more help, but get to a mentor who can see and suggest corrections more quickly.

_Note: We're actually solving this by running the tests server-side - a large and expensive undertaking, but one worth the effort for the improved student experience, and crucially saving our mentors time and energy._

## Anything else?

Two things:

1. [This article in Second Order Thinking](https://fs.blog/2020/03/chestertons-fence/) is a good read. The quote "Do not remove a fence until you know why it was put up in the first place" is from this post.
2. Your idea really might be new and great. Don't be scared or embarrassed to suggest it!
