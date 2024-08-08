# Set up Continuous Integration

Setting up Continuous Integration (CI) for your track is very important, as it helps automatically catch mistakes.

## GitHub Actions

Our tracks (and other repositories) use [GitHub Actions](https://docs.github.com/en/actions) to run their CI.
GitHub Actions uses the concept of _workflows_, which are scripts that run automatically whenever a specific event occurs (e.g. pushing a commit).

Each GitHub Actions workflow is defined in a `.yml` file in the `.github/workflows` directory.
For information on workflows, check the following docs:

- [Workflow syntax](https://docs.github.com/en/actions/writing-workflows/workflow-syntax-for-github-actions)
- [Choosing when your workflow runs](https://docs.github.com/en/actions/writing-workflows/choosing-when-your-workflow-runs/triggering-a-workflow)
- [Choosing where your workflow runs](https://docs.github.com/en/actions/writing-workflows/choosing-where-your-workflow-runs)
- [Choose what your workflow does](https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does)
- [Writing workflows](https://docs.github.com/en/actions/writing-workflows)
- [Best practices](/docs/building/github/gha-best-practices)

## Pre-defined workflows

A track repository contains several pre-defined workflows:

- `configlet.yml`: runs the [configlet tool](/docs/building/configlet), which checks if a track's (configuration) files are properly structured - both syntactically and semantically
- `no-important-files-changed.yml`: checks if pull requests would cause all existing solutions of one or more changes exercises to be re-run
- `sync-labels.yml`: automatically syncs the repository's labels from a `labels.yml` file
- `test.yml`: verify the track's exercises

Of these workflows, _only_ the `test.yml` workflow requires manual work.
The other workflows should not be changed (we keep them up-to-date automatically).

## Implement script to verify exercises

Track repos start with an _almost_ functioning `bin/verify-exercises` bash script, which does the following:

- Loops over all exercise directories
- For each exercise directory, it then:
  - Copies the example/exemplar solution to the (stub) solution files (already implemented)
  - Calls the `unskip_tests` function in which you can unskip tests in your test files (optional)
  - Calls the `run_tests` function in which you should run the tests (required)

### Unskipping tests

The `unskip_tests` and `run_tests` functions are the only things that you need to implement.

### Running tetss

### Example: Arturo track

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

## Implement the test workflow

The goal of the `test.yml` workflow is to verify that the track's exercises are in proper shape.
More specifically, this means checking that each exercise's example/exemplar solution passes the exercise's tests.

#### Example: using bash

#### Example: invoking test runner Docker image

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

#### Example: running in test runner Docker image

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
