# Set up Continuous Integration

Setting up Continuous Integration (CI) for your track is very important, as it helps automatically catch mistakes.

## GitHub Actions

Our tracks (and other repositories) use [GitHub Actions](https://docs.github.com/en/actions) to run their CI.
GitHub Actions uses the concept of _workflows_, which are scripts that run automatically whenever a specific event occurs (e.g. pushing a commit).
For more information on workflow, check the [workflows docs](/docs/building/tracks/ci/workflows).

## Test workflow

Each track comes with a `test.yml` workflow.
This workflow should verify that the track's exercises are in proper shape.
The workflow is setup to run automatically (in GitHub Actions terminology: is _triggered_) when a push is made to the `main` branch or to a pull request's branch.

The workflow itself should not do much, except for:

- Checking out the code (already implemented)
- Installing dependencies (e.g. installing an SDK, optional)
- Running the verify exercises script (already implemented)

## Implement the verify exercises script

As mentioned, the exercises are verified via a script, namely the `bin/verify-exercises` (bash) script.
This script is _almost_ done, and does the following:

- Loops over all exercise directories
- For each exercise directory, it then:
  - Copies the example/exemplar solution to the (stub) solution files (already implemented)
  - Calls the `unskip_tests` function in which you can unskip tests in your test files (optional)
  - Calls the `run_tests` function in which you should run the tests (required)

The `run_tests` and `unskip_tests` functions are the only things that you need to implement.

### Unskip tests

If your track supports skipping tests, we must ensure that no tests are skipped when verifying an exercise's example/exemplar solution.
In general, there are two ways in which tracks support "unskipping" tests:

1. Removing annotations/code/text from the test files.
   For example, changing `test.skip` to `test`.
2. Providing an environment variable.
   For example, setting `SKIP_TESTS=false`.

If skipping tests is file-based (the first option mentioned above), edit the `unskip_tests` function to modify the test files (the existing code already handles the looping over the test files).

```exercism/note
The `unskip_test` function runs on a copy of an exercise directory, so feel free to modify the files as you see fit.
```

If unskipping tests requires an environment variable to be set, make sure that it is set in the `run_tests` function.

### Run tests

The `run_tests` function is responsible for running the tests of an exercise.
When the function is called, the example/exemplar files will already have been copied to (stub) solution files, so you only need to call the right command to run the tests.

The function must return a zero as the exit code if all tests pass, otherwise return a non-zero exit code.

```exercism/note
The `run_tests` function runs on a copy of an exercise directory, so feel free to modify the files as you see fit.
```

### Option 1: use language tooling

The default option for the verify exercises script is to use the language's tooling (SDK/binary/etc.).
It assumes (and possibly checks) that the language tooling is installed, a

This is what the [`bin/verify-exercises` file](https://github.com/exercism/arturo/blob/79560f853f5cb8e2f3f0a07cbb8fcce8438ee996/bin/verify-exercises) looks file for the Arturo track:

```bash
#!/usr/bin/env bash

# Synopsis:
# Test the track's exercises.

# Example: verify all exercises
# ./bin/verify-exercises

# Example: verify single exercise
# ./bin/verify-exercises two-fer

set -eo pipefail

required_tool() {
    command -v "${1}" >/dev/null 2>&1 ||
        die "${1} is required but not installed. Please install it and make sure it's in your PATH."
}

required_tool jq

copy_example_or_examplar_to_solution() {
    jq -c '[.files.solution, .files.exemplar // .files.example] | transpose | map({src: .[1], dst: .[0]}) | .[]' .meta/config.json | while read -r src_and_dst; do
        cp "$(echo "${src_and_dst}" | jq -r '.src')" "$(echo "${src_and_dst}" | jq -r '.dst')"
    done
}

unskip_tests() {
    jq -r '.files.test[]' .meta/config.json | while read -r test_file; do
        sed -i 's/test.skip/test/g' "${test_file}"
    done
}

run_tests() {
    arturo tester.art
}

verify_exercise() {
    local dir
    local slug
    local tmp_dir

    dir=$(realpath "${1}")
    slug=$(basename "${dir}")
    tmp_dir=$(mktemp -d -t "exercism-verify-${slug}-XXXXX")

    echo "Verifying ${slug} exercise..."

    (
        cp -r "${dir}/." "${tmp_dir}"
        cd "${tmp_dir}"

        copy_example_or_examplar_to_solution
        unskip_tests
        run_tests
    )
}

exercise_slug="${1:-*}"

shopt -s nullglob
for exercise_dir in ./exercises/{concept,practice}/${exercise_slug}/; do
    if [ -d "${exercise_dir}" ]; then
        verify_exercise "${exercise_dir}"
    fi
done
```

It uses `sed` to unskip tests:

```bash
sed -i 's/test.skip/test/g' "${test_file}"
```

and runs the tests via the `arturo` command:

```bash
arturo tester.art
```

### Option 2: use the test runner Docker image

In this option, we're using the fact that each track must have a test runner which already knows how to verify exercises.
To enable this option, we first need to download (pull) the track's test runner Docker image and then run the `bin/verify-exercises` script, which is modified to use the test runner Docker image to run the tests.

```exercism/note
The main benefit of this approach is that it best mimics how tests are being run in production (on the website).
With the approach, it is less likely that things will fail in production that passed in CI.
The downside of this approach is that it likely is slower, due to having to pull the Docker image and the overhead of Docker.
```

````

## Implement the test workflow

Now that the `verify-exercises` script is

There are three options when implementing this workflow:

### Option 1: install track-specific tooling (e.g. an SDK) in the GitHub Actions runner instance

In this approach, any track-specific tooling (e.g. an SDK) is installed directly in the GitHub Actions runner instance.
Once done, you then run the `bin/verify-exercises` script (which assumes the track tooling is installed).

For an example, see the [Arturo track's `test.yml` workflow](https://github.com/exercism/arturo/blob/79560f853f5cb8e2f3f0a07cbb8fcce8438ee996/.github/workflows/test.yml):

```yml
name: Test

on:
  push:
    branches: [main]
  pull_request:
    branches: [main]
  workflow_dispatch:

jobs:
  ci:
    runs-on: ubuntu-22.04

    steps:
      - name: Checkout repository
        uses: actions/checkout@692973e3d937129bcbf40652eb9f2f61becf3332

      - name: Install dependencies
        run: |
          sudo apt-get update
          sudo apt-get install libgtk-3-dev libwebkit2gtk-4.0-dev libmpfr-dev

      - name: Install Arturo
        run: bin/install-arturo
        env:
          GH_TOKEN: ${{ github.token }}

      - name: Verify all exercises
        run: bin/verify-exercises
````

#### Option 2: running the verify exercises script within test runner Docker image

In this option, we're using the fact that each track must have a test runner which has all dependencies already installed
To enable this option, we need to set the workflow's container to the test runner:

```yml
container:
  image: exercism/vimscript-test-runner
```

This will then automatically pull the test runner Docker image when the workflow executes, and run the `verify-exercises` script within that Docker container.

```exercism/note
The main benefit of this approach is that it better mimics how tests are being run in production (on the website).
With the approach, it is less likely that things will fail in production that passed in CI.
The downside of this approach is that it likely is slower, due to having to pull the Docker image and the overhead of Docker.
```

For an example, see the [vimscript track's `test.yml` workflow](https://github.com/exercism/vimscript/blob/e599cd6e02cbcab2c38c5112caed8bef6cdb3c38/.github/workflows/test.yml).

```yml
name: Verify Exercises

on:
  push:
    branches: [main]
  pull_request:
  workflow_dispatch:

jobs:
  ci:
    runs-on: ubuntu-24.04
    container:
      image: exercism/vimscript-test-runner

    steps:
      - name: Checkout repository
        uses: actions/checkout@692973e3d937129bcbf40652eb9f2f61becf3332

      - name: Verify all exercises
        run: bin/verify-exercises
```

### Option 3: download the test runner Docker image and change verify exercises script

In this option, we're using the fact that each track must have a test runner which already knows how to verify exercises.
To enable this option, we first need to download (pull) the track's test runner Docker image and then run the `bin/verify-exercises` script, which is modified to use the test runner Docker image to run the tests.

```exercism/note
The main benefit of this approach is that it best mimics how tests are being run in production (on the website).
With the approach, it is less likely that things will fail in production that passed in CI.
The downside of this approach is that it likely is slower, due to having to pull the Docker image and the overhead of Docker.
```

For an example, see the [Standard ML track's `test.yml` workflow](https://github.com/exercism/sml/blob/e63e93ee50d8d7f0944ff4b7ad385819b86e1693/.github/workflows/ci.yml).

```yml
name: sml / ci

on:
  pull_request:
  push:
    branches: [main]
  workflow_dispatch:

jobs:
  ci:
    runs-on: ubuntu-22.04

    steps:
      - name: Checkout code
        uses: actions/checkout@692973e3d937129bcbf40652eb9f2f61becf3332

      - run: docker pull exercism/sml-test-runner

      - name: Run tests for all exercises
        run: sh ./bin/test
```
