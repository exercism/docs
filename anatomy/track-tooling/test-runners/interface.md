# The Test Runner Interface

Test Runners have the single responsibility of taking a solution, running all tests and returning a standardised output.
All interactions with the Exercism website are handled automatically and are not part of this specification.

## Execution

- A Test Runner should provide an executable script. You can find more information in the [docker.md](./docker.md) file.
- The script will receive three parameters:
  - The slug of the exercise (e.g. `two-fer`).
  - A path to an input directory (with a trailing slash) containing the submitted solution file(s) and any other exercise file(s). This directory should be considered as read-only. It's technically possible to write into it but it's better to use `/tmp` for temporary files (e.g. for compiling sources).
  - A path to an output directory (with a trailing slash). This directory is writable.
- The script must write a `results.json` file to the output directory.
- The runner must exit with an exit code of 0 if it has run successfully, regardless of the status of the tests.

## Output format

The `results.json` file should be structured as followed:

```json
{
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

### Top level

#### Status

> key: `status`

The following overall statuses are valid:

- `pass`: All tests passed
- `fail`: At least one test failed
- `error`: To be used when the tests did not run correctly (e.g. a compile error, a syntax error)

#### Message

> key: `message`

Where the status is `error` (the tests fail to execute cleanly), the top level `message` key should be provided. It should provide the occurring error to the user. As it is the only piece of information a user will receive on how to debug their issue, it must be as clear as possible. For example, in Ruby, in the case of a syntax error, we provide the error and stack trace. In compiled languages, the compilation error should be provided. The top level `message` value is not limited in length.

When the status is not `error`, either set the value to `null` or omit the key entirely.

### Per-test

#### Name

> key: `name`

This is the name of the test in a human-readable format.

#### Command

> key: `test_code`

This is the body of the command that is being tests. It should have any `skip` annotations removed. For example, the following Ruby test:

```ruby
def test_duplicate_items_uniqs_list
  skip
  cart = ShoppingCart.new
  cart.add(:STARIC)
  cart.add(:MEDNEW)
  cart.add(:MEDNEW)
  assert_equal 'Newspaper, Rice', cart.items_list
end
```

... should return a `test_code` value of:

```ruby
"cart = ShoppingCart.new
cart.add(:STARIC)
cart.add(:MEDNEW)
cart.add(:MEDNEW)
assert_equal 'Newspaper, Rice', cart.items_list"
```

(with linebreaks replaced by `\n` to make the JSON valid).

#### Status

> key: `status`

The following per-test statuses are valid:

- `pass`: The test passed
- `fail`: The test failed
- `error`: The test errored

#### Message

> key: `message`

The per-test `message` key is used to return the results of a failed test. It should be as human-readable as possible. Whatever is written here will be displayed to the student when their test fails. If there is no error message, either set the value to `null` or omit the key entirely. It is also permissible to output test suite output here. The `message` value is not limited in length.

#### Output

> key: `output`

The per-test `output` key should be used to store and output anything that a user deliberately outputs for a test.

- It should be attached to all test results that produce user output.
- Only content outputted by a user manually should show - not automatic output by the test-runner.
- You may either capture content that is output through normal means (e.g. `puts` in Ruby, `print` in Python or `Debug.WriteLine` in C#), or you may provide a method that the user may use (e.g. the Ruby Test Runner provides a user with a globally available `debug` method that they can use, which has the same characteristics as the standard `puts` method).
- The output **must** be limited to 500 chars. Either truncating with a message of "Output was truncated. Please limit to 500 chars" or returning an error in this situation are acceptible.

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

- Auxillary JSON files compiled manually, merged with test results during the test run-time.
- Automated static analysis of the test suite, merged with test results during the test run-time.
  - This may be accomplished by AST analysis or text-parsing
