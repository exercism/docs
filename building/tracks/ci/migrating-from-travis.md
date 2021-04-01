# Migrating from Travis

Here is an example `.travis.yml` (taken from the `elm` track):

```yml
sudo: false
language: node_js
node_js:
  - lts/*
script:
  - bin/fetch-configlet
  - bin/configlet lint
  - bin/build.sh
```

In order to convert this quickly to GitHub Actions, take the following steps:

## Determine the template variables

| variable                    | value                                |
| --------------------------- | ------------------------------------ |
| `<track>`                   | `elm`                                |
| `<image-name>`              | `ubuntu-latest`                      |
| `<action to setup tooling>` | `actions/setup-node@v1`              |
| `<install dependencies>`    | `npm ci` (happens inside `build.sh`) |
| `<code-extensions>`         | `.elm`                               |

> Found the setup action via [this search](https://github.com/actions/?q=setup+node&type=&language=).
> Found the image name by looking at [default distribution for Travis](https://blog.travis-ci.com/2019-04-15-xenial-default-build-environment).

## Determine the steps

- `bin/fetch-configlet`: don't need this anymore when using [`configlet.yml`][workflow-template-configlet-yml] workflow
- `bin/configlet lint`: don't need this anymore when using [`configlet.yml`][workflow-template-configlet-yml] workflow
- `bin/build.sh`: single script that does everything

## Prepare the "scripts"

This track uses the `bin` folder, so inside the `bin` folder, create the following files:

```bash
# bin/pr
bin/build.sh
```

```bash
# bin/pr-check
echo "No checks yet"
```

```bash
# bin/ci
bin/build.sh
```

```bash
# bin/ci-check
echo "No checks yet"
```

Creating these as _separate_ binaries will allow for optimisation later. No need to in-line anything right now.

## Fill in the templates

Here is the diff for [`workflows/ci.yml`][workflow-template-ci-yml].

```diff
# # .github/workflows/ci.yml

  # This workflow will do a clean install of node dependencies and run tests across different versions
  #
- # Replace <track> with the track name
- # Replace <image-name> with an image to run the jobs on
- # Replace <action to setup tooling> with a github action to setup tooling on the image
- # Replace <install dependencies> with a cli command to install the dependencies
- # Replace <code-extensions> with file extensions that should trigger the workflow
- #
- # Find Github Actions to setup tooling here:
- # - https://github.com/actions/?q=setup&type=&language=
- # - https://github.com/actions/starter-workflows/tree/main/ci
- # - https://github.com/marketplace?type=actions&query=setup
- #
  # Requires scripts:
- # - scripts/ci-check
- # - scripts/ci
+ # - bin/ci-check
+ # - bin/ci

- name: <track> / main
+ name: elm / main

  on:
    push:
      branches: [main]
    workflow_dispatch:

  jobs:
    precheck:
-     runs-on: <image-name>
+     runs-on: ubuntu-latest

      steps:
        - uses: actions/checkout@v2
-       - name: Use <setup tooling>
-         uses: <action to setup tooling>
+       - name: Use Node LTS
+         uses: actions/setup-node@v1
          with:
-           # here, use the LTS/stable version of the track's tooling
-           # node-version: 12.x
+           node-version: 12.x

        - name: Install project dependencies
-         run: <install dependencies>
+         run: npm ci

-       - name: Run exercism/<track> ci pre-check (checks config, lint code) for all exercises
-         run: scripts/ci-check
+       - name: Run exercism/elm ci pre-check (checks config, lint code) for all exercises
+         run: bin/ci-check

    ci:
-     runs-on: <image-name>
+     runs-on: ubuntu-latest

      strategy:
        matrix:
-         # here, add all SUPPORTED versions only
-         # version: [10.x, 12.x, 14.x]
+         version: [10.x, 12.x, 14.x]

      steps:
        - uses: actions/checkout@v2
-       - name: Use <setup tooling> ${{ matrix.version }}
-         uses: <action to setup tooling>
+       - name: Use Node ${{ matrix.version }}
+         uses: actions/setup-node@v1
          with:
-           # below: see how to inject the version
-           # node-version: ${{ matrix.version }}
+           node-version: ${{ matrix.version }}

        - name: Install project dependencies
-         run: <install dependencies>
+         run: npm ci

-       - name: Run exercism/<track> ci (runs tests) for all exercises
-         run: scripts/ci
+       - name: Run exercism/elm ci (runs tests) for all exercises
+         run: bin/ci
```

[`workflows/pr.yml`][workflow-template-pr-ci-yml] has the same changes, with the notable exception of the bash-fu that calls the `pr-check` and `pr` scripts with each changed file as argument:

```diff
# # .github/workflows/pr.yml

# # ...

-       - name: Run exercism/<track> ci pre-check (stub files, config integrity) for changed exercises
+       - name: Run exercism/elm ci pre-check (stub files, config integrity) for changed exercises
          run: |
            PULL_REQUEST_URL=$(jq -r ".pull_request.url" "$GITHUB_EVENT_PATH")
            curl --url $"${PULL_REQUEST_URL}/files" --header 'authorization: Bearer ${{ secrets.GITHUB_TOKEN }}' | \
-             jq -c '.[] | select(.status == "added" or .status == "modified") | select(.filename | match("\\.(<code-extensions>|md|json)$")) | .filename' | \
+             jq -c '.[] | select(.status == "added" or .status == "modified") | select(.filename | match("\\.(elm|md|json)$")) | .filename' | \
-             xargs -r scripts/pr-check
+             xargs -r bin/pr-check

  # ...
```

## Now it should work

This is enough to convert to GitHub Actions, with the possibility to optimise your scripts.

1. From `build.sh`, remove steps that should run only once, and extract them to the `ci-check.sh` and `pre-check.sh` files (hint, you can create `lint.sh`, and call that from both "scripts")
2. To `pr.sh` and `pr-check.sh`, add optimisations that use the input arguments to determine which files or exercises to check.
3. Add additional checks
4. Add documentation how to run checks locally, and what each one tries to accomplish.

[workflow-template-pr-ci-yml]: https://github.com/exercism/docs/tree/main/reference/templates/ci/pr.ci.yml
[workflow-template-ci-yml]: https://github.com/exercism/docs/tree/main/reference/templates/ci/ci.yml
[workflow-template-configlet-yml]: https://github.com/exercism/docs/tree/main/reference/templates/ci/configlet.yml
