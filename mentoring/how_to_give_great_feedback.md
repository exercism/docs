# How to give great feedback

[video:vimeo/595884449]()

At this stage you should have chosen a solution to mentor.
If you haven't, work your way through [Choosing a solution to mentor](/docs/mentoring/choosing-a-solution) first, then come back here.

## Your first feedback

You're about to give your first feedback to a student.
This can be exciting but also pretty daunting.
A lot of (the best!) mentors suffer from [Impostor Syndrome](https://en.wikipedia.org/wiki/Impostor_syndrome) at this stage, and give up before they start.
If you feel like that, it's totally understandable, but also almost always unnecessary.
By the fact you're worrying about whether your feedback is going to be good enough, it's likely that you'll give thoughtful humble comments that students really appreciate.
And in the worst case, a student can always end the discussion, and wait for another mentor, so let's give it a go!

## Mindset

The first thing to keep in mind is having the right mindset as a mentor.
Students are hoping you can help improve their knowledge, and tell them things that they don't know.
Your job isn't to "mark" their work, it's to use their solution as a basis for unlocking ideas that they are not familiar with or are struggling with.

It's also worth remembering that most Exercism users are experienced developers learning a new language.
So although their code might look bad, that may well be because they don't know how to write this language.
Similar code in a different language might be totally idiomatic and correct.
Conversations tend to go much better when they are approached as two peers discussing a topic, rather than one person showing off their knowledge to another.

## Addressing the student's request vs teaching a new idea

When a student submits a solution for mentoring, they are promoted to tell the mentor what they are hoping to get from it.
It's really important that you as the mentor read that and try and address it in your feedback.

However, one of the key values of mentoring on Exercism is that mentors can help students discover ideas they had no idea about.
So you might look at a student's solution, read their comment which asks if there are any tweaks they could make, and think "Wow - you really don't have a grasp on this exercise at all".
It might be that they've totally missed the point of the exercise.
In your time as a mentor, you'll see some incredibly "overfit" solutions where students make the tests pass but totally miss the point of the challenge.
Or see incredibly complex solutions that can be rewritten in a couple of lines of code.

Your job as a mentor is to help take the student forward **from where they start**.
What's the biggest thing you could do to help unlock an idea or unblock their thinking?
You'll find that if you can explain an idea to a student and set a lightbulb off in their head, it'll be an incredibly rewarding discussion.

## Don't just give the solution away

The aim in mentoring is **not** for a student to get to the optimal solution, it is for a student to learn new things.
Simply giving a student the correct answer is neither useful nor helpful.
Exercism encourages students to go and look at other people's solutions and learn from them, so you giving them a good solution doesn't add any value.
The value you add as a mentor is helping them think differently, helping them see things in a different light.

Different mentors have different approaches to whether they give "hints" or "explanations".
As a general rule, aim for somewhere between the two.
Ensure that you tell the student enough that they can understand what they should try, but try not to just give them the answer and tell them why it works.

For example, imagine you see an `if` statement in Ruby that would be much more nicely written using the [ternary operator](https://en.wikipedia.org/wiki/%3F:):

```
# Student's code
if a
  b = 1
else
  b = 2
end

# Mentor's suggestion
b = a ? 1 : 2
```

You could just say "Write `b = a ? 1 : 2` instead of the `if` statement on L10."
But that wouldn't be helping a student understand the why or have a lightbulb moment of their own.

Instead it would be much better to introduce the idea of a ternary, and pose the student a challenge.
For example: "I think you could reduce the Lines 10-14 down to one line using the Ternary Operator. How might that look?"
A student will then have to play with that and solve it themselves, but you've given them enough info to work with.

On the other end of the scale, saying "Reduce lines 10-14 to one line" wouldn't give a student any indication of how that's achievable, and so could be incredibly frustrating for them.
So try to ensure you give enough information for a student to progress.

## How much feedback should you give

Different mentors have different styles, but our default suggestion is to give the most important one to three pieces of feedback on any iteration.
If the student submits a new iteration with those solved, then you could give another one to three pieces of feedback.
By breaking things up in that way, a student will not feel overwhelmed, but will also have enough to do to make meaningful changes each time.

As you gain experience mentoring, you will get a feel for the different ways students react to different feedback, and develop a style that fits your personality.

## Unsure of something? Chat to other mentors?

One of the best things about being an Exercism mentor is the community of other mentors you can learn from.
If you've got a question about a solution, or just want to bounce ideas with other mentors, jump into our [Slack Workspace](https://exercism-team.slack.com/) and ask away!
You'll probably find people you can help there too 🙂
