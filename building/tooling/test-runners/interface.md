# The Test Runner Interface

Test Runners have the single responsibility of taking a solution, running all tests and returning a standardized output.
All interactions with the Exercism website are handled automatically and are not part of this specification.

## Execution

- A Test Runner should provide an executable script. You can find more information in the [docker.md](/docs/building/tooling/test-runners/docker) file.
- The script will receive three parameters:
  - The slug of the exercise (e.g. `two-fer`).
  - A path to an input directory (with a trailing slash) containing the submitted solution file(s) and any other exercise file(s). This directory should be considered as read-only. It's technically possible to write into it but it's better to use `/tmp` for temporary files (e.g. for compiling sources).
  - A path to an output directory (with a trailing slash). This directory is writable.
- The script must write a `results.json` file to the output directory.
- The runner must exit with an exit code of 0 if it has run successfully, regardless of the status of the tests.

### Allowed run time

The test runner gets 100% machine resources for a 20 second window per solution.
After 20 seconds, the process is halted and reports a time-out.

## Output format

The following fields are supported in `results.json` files:

### Top level

#### Version

> key: `version`, type: `number`, presence: required

> version: 1, 2, 3

The version of the spec that this file adheres to:

- `1`: For tracks which test runner cannot provide information on individual tests.
- `2`: For tracks which test runner can output individual test information. Minimal required version for tracks with Concept Exercises.
- `3`: For tracks which test runner can link individual tests to a task.

#### Status

> key: `status`, type: `string`, presence: required

> version: 1, 2, 3

The following overall statuses are valid:

- `pass`: All tests passed
- `fail`: At least one test has the status `fail` or `error`
- `error`: No test was executed correctly (this usually means e.g. a compile error, or a syntax error)

#### Message

> key: `message`, type: `string`, presence: required if `status` = `error`, or when `status` = `fail` and `version` = `1`

> version: 1, 2, 3

Where the status is `error` (no test was executed correctly), the top level `message` key should be provided. It should provide the occurring error to the user. As it is the only piece of information a user will receive on how to debug their issue, it must be as clear as possible:

- Simplify the paths to be something like `<solution-dir>/relative/path` instead of `/full/path/to`, as that will include unhelpful ECR specific data
- When possible or applicable, collapse non-user-code stacks
- Never show call stacks without context (i.e. the error message)
- Don't change the error message (if possible), as it will make it easier to search for the error

In Ruby, in the case of a syntax error, we provide the runtime error and stack trace. In compiled languages, the compilation error should be provided.

The top level `message` value is not limited in length.
When the status is not `error`, either set the value to `null` or omit the key entirely.

#### Tests

> key: `tests`, type: `array`, presence: required if `status` = `fail` or `status` = `pass`

> version: 2, 3

This is an array of the test results, specified in the "Per-test" section below.

The tests **MUST** be returned in the order they are specified in the tests file.
For languages that execute tests in a random order, this may mean re-ordering the results in line with the order specified in the tests file.

The rationale for this is that only the first failure is shown to students and therefore it is important that the correct failure is shown. Because tests are generally ordered in the tests file in a TDD way, and because for Practice Exercises the students see the tests file in the editor, aligning the results with the tests file is critical.

### Per-test

#### Name

> key: `name`, type: `string`, presence: required

> version: 2, 3

This is the name of the test in a human-readable format.

#### Test code

> key: `test_code`, type: `string`, presence: required if exercise is Concept Exercise

> version: 2, 3

This **MUST** be present for Concept Exercises and **SHOULD** be present for Practice Exercises.
The difference in this requirement comes from that fact that students are not shown the tests in Concept Exercises, so solving the exercise may be impossible without the `test_code` being shown, whereas the tests are shown for Practice Exercises.

This is the body of the command that is being tested. For example, the following Ruby test:

```ruby
def test_duplicate_items_uniqs_list
  cart = ShoppingCart.new
  cart.add(:STARIC)
  cart.add(:MEDNEW)
  cart.add(:MEDNEW)
  assert_equal 'Newspaper, Rice', cart.items_list
end
```

should return a `test_code` value of:

```ruby
"cart = ShoppingCart.new
cart.add(:STARIC)
cart.add(:MEDNEW)
cart.add(:MEDNEW)
assert_equal 'Newspaper, Rice', cart.items_list"
```

(with linebreaks replaced by `\n` to make the JSON valid).

#### Status

> key: `status`, type: `string`, presence: required

> version: 2, 3

The following per-test statuses are valid:

- `pass`: The test passed
- `fail`: The test failed
- `error`: The test errored - that is, it did not return a value

#### Message

> key: `message`, type: `string`, presence: required if `status` is `fail` or `error`

> version: 2, 3

The per-test `message` key is used to return the results of a test with a `status` of `fail` or `error`. It should be as human-readable as possible. Whatever is written here will be displayed to the student when their test does not pass. If there is no test failure message or error message, either set the value to `null` or omit the key entirely. It is also permissible to output test suite output here. The `message` value is not limited in length.

#### Output

> key: `output`, type: `string`, presence: optional

> version: 2, 3

The per-test `output` key should be used to store and output anything that a user deliberately outputs for a test.

- It should be attached to all test results that produce user output.
- Only content outputted by a user manually should show - not automatic output by the test-runner.
- You may either capture content that is output through normal means (e.g. `puts` in Ruby, `print` in Python or `Debug.WriteLine` in C#), or you may provide a method that the user may use (e.g. the Ruby Test Runner provides a user with a globally available `debug` method that they can use, which has the same characteristics as the standard `puts` method).
- The output **must** be limited to 500 chars. Either truncating with a message of "Output was truncated. Please limit to 500 chars" or returning an error in this situation are acceptable.

#### Task ID

> key: `task_id`, type: `number`, presence: optional

> version: 3

Link a test to a specific task via the task's ID, which is the number used at the start of the task heading. Only link a test to a task if it can be linked to precisely _one_ task.

At the moment, only Concept Exercises have well-defined tasks that you can link tests to, but this might change in the future.

For example, consider the following `instructions.md` file:

```
# Instructions

You're going to write some code to help Lucian cook an exquisite lasagna from his favorite cook book.

## 1. Define the expected oven time in minutes

...

## 2. Calculate the remaining oven time in minutes

...
```

These instructions defined two tasks:

1. Define the expected oven time in minutes
2. Calculate the remaining oven time in minutes

The `results.json` file could then have an entry like this:

```json
{
  "name": "Expected oven time in minutes",
  "status": "pass",
  "task_id": 1,
  "test_code": "Assert.Equal(40, Lasagna.ExpectedMinutesInOven());"
}
```

This test is now linked to the first task: "Define the expected oven time in minutes". Note that the name does _not_ have to match the task's description.

There are various ways tracks could implement this:

- Add metadata to the tests within the test file (e.g. using attributes/annotations/comments) and have the test runner read this metadata when running the tests.
- Store the test name/task ID mapping in a separate file (like the exercise's `.meta/config.json` file) and merge this information into the generated `results.json` file.

### Examples

These are example of what a valid `results.json` file can look like for the different versions:

#### v1 example

```json
{
  "version": 1,
  "status": "fail",
  "message": "Failed: test_answer\nExpected: 42, actual: 3"
}
```

#### v2 example

```json
{
  "version": 2,
  "status": "fail",
  "message": null,
  "tests": [
    {
      "name": "Test that the thing works",
      "status": "fail",
      "message": "Expected 42 but got 123123",
      "output": "Debugging information output by the user",
      "test_code": "assert_equal 42, answerToTheUltimateQuestion()"
    }
  ]
}
```

#### v3 example

```json
{
  "version": 3,
  "status": "fail",
  "message": null,
  "tests": [
    {
      "name": "Test that the thing works",
      "status": "fail",
      "message": "Expected 42 but got 123123",
      "output": "Debugging information output by the user",
      "test_code": "assert_equal 42, answerToTheUltimateQuestion()",
      "task_id": 1
    }
  ]
}
```

### UI/UX concerns

#### On test failure

When a student's solution fails a test, it should display something like:

```text
Test Code:
  <test_code>

Test Result:
  <message>
```

#### On test success

When the solution passes a test, it should display something like:

```text
Test Code:
  <test_code>
```

### How to add metadata for your language's test suite

All roads lead to Rome and there is no prescribed pattern to arrive at this.
There are several approaches taken so far:

- Auxiliary JSON files compiled manually, merged with test results during the test run-time.
- Automated static analysis of the test suite, merged with test results during the test run-time.
  - This may be accomplished by AST analysis or text-parsing
