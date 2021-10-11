# Choosing a solution to mentor

[video:vimeo/595885125]()

The first decision you need to make as a mentor is which solution to mentor.

## Working with the Queue

You can find a list of all solutions that have been submitted for mentoring in the [Mentoring Queue](/mentoring/queue).
The UI should look something like this:

![Mentoring queue](https://exercism-static.s3.eu-west-1.amazonaws.com/docs/mentor_queue.png)

At the top of the queue panel, you will find a text box that allows you to filter by the student's name.
To the right of this, you can the sort requests by oldest first, most recent first, student name or exercise name.
On the right-hand side of the interface, you can filter by language or exercise name.
You can also choose to only show exercises that you have completed yourself (enabled by default), which is often wise as you may struggle to give great feedback if you have not wrestled with solving the exercise yourself.
The list of exercises with outstanding mentorship requests can be used to further filter the request list.
Do this by selecting the exercise name (visible in the bottom right section of the screenshot above).

The main table displays the exercise, the student and when they requested mentoring.
Hovering on a row gives you more details about the student.
You can view their name, location, and reputation (which is an indicator of whether they are a contributor or mentor themselves) as well as how many times they've been mentored before.
You'll also see a short blurb they've written explaining what they're looking to get out of the track.
As you start mentoring people, you'll also see whether you've mentored them before and if you've favorited them.

The blurb on the tooltip is a first indicator about whether this student is right for you.
Does your expertise match their knowledge gaps?
If they say they're looking to get good at functional programming, can you help with that?
If they're new to the language and looking to learn the basics, then if you have **any** real experience, you'll probably be able to help, but if they've been programming in that language for years and trying to hit expert-level, you'll need to have a pretty solid grasp of the language yourself.

Once you've found a solution that looks like it might be a good fit for you to mentor, we can take the next step and have a look at the code.
So click on that solution and enter the Mentoring Discussion UI!

## The Mentoring Discussion UI

At this stage you're looking at someone's solution but haven't yet committed to mentoring it.
You first have the opportunity to read their code and get some other information before starting.

**If you're new to this UI, it might feel a little overwhelming as there is a lot of information, but don't worry - it'll soon become familiar.**

### The student's code

On the left hand side of the screen you will see the student's code.
The UI will look something like this:

[TODO: Image of mentor discussion with areas marked].

1. The main part of the left side contains the student's code.
   By default you'll be seeing their most recent iteration.
   If they've submitted multiple iterations, you can switch through these using the numbers in circles at the bottom left or using the `Previous` and `Next` buttons located at the bottom right of this panel.
   If they've only submitted one iteration, you won't see those icons.

2. At the top of the student's code, you can use the tabs to switch between the student's code, the instructions, and the tests.
   This is useful for reminding yourself what the student has been asked to do in this exercise.

3. You'll also see an indicator as to whether the tests have passed or failed (located at the top right of this left panel), as well as buttons to download the student's code or copy the student's code to your clipboard.
   If they failed, clicking on this indicator will open a modal that shows you the specific details of their test run, so you can see what they did wrong.

The right hand side of the screen holds a panel containing the mentorship interaction. At the top of this panel, you'll see three tabs.
The "Discussion" tab will contain the information about the user (username, name, reputation, personal blurb).
Below that you'll see a comment from the user about what it is that they want to learn from this specific solution.
(For some older solutions, this might be missing).
This is a key indicator as to whether this solution is right for you.
Can you answer their question?
Can you fulfill their hopes for this exercise?

The second tab is your "Scratchpad".
You can write code in it, so that you can reference it in your comment.
It can help identify the code that is important when reviewing this exercise.
This can help your explanations be simpler and clearer.

The third tab is called "Guidance".
If you click on this you'll see some information that might be useful for you:

- **The Exemplar solution** Try to guide the student towards this solution.
  It is the best place for them to reach at this point during the Track.
  You may discover that your approach differs significantly from the exemplar solution.
  This may be due to you being familiar with more advanced techniques than the student.
  Keep in mind that you can only expect the student to be familiar with the concepts they have learned while completing the learning path to the exercise they are working on.
   Consider this fact when providing your feedback and try not to overwhelm your student with knowledge they may not be prepared for yet.
- **Mentor notes:** These are community-written notes that help point other mentors towards the best way to mentor an exercise.
  We'd really love you to contribute your experience back to these notes.
- **Automated feedback:** This is feedback that our analyzers have determined might be useful for you to give to a student.
  We'll discuss this more later.
- **Your solution:** A link back to your own solution, which you can use as a reference for how you solved the exercise.

## Start mentoring

If you've read the code, checked the guidance, and feel you can be helpful, then it's time to get going!
Click the "Start mentoring" button and you'll be prompted to write your feedback.

Have a read of [How to give great feedback](/docs/mentoring/how-to-give-great-feedback) next!
