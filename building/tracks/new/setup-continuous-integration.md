# Set up Continuous Integration

Setting up Continuous Integration (CI) for your track is very important, as it helps to automatically catch mistakes.

Our tracks all use [GitHub Actions](https://docs.github.com/en/actions) to run their CI.
GitHub actions uses the concept of _workflows_, which are scripts that are run automatically whenever a specific event occurs (e.g. pushing a commit).

Each workflow corresponds to a file in `.github/workflows`.
Each new track repository comes pre-loaded with three workflows:

- `test.yml`: this workflow should run the tests for each exercise the track has implemented
- `configlet.yml`: this workflow runs the [configlet tool](/docs/building/configlet), which checks if a track's (configuration) files are properly structured - both syntactically and semantically.
- `sync-labels.yml`: this workflow automatically syncs the repository's labels from a `labels.yml` file

Of these three workflows, only the first workflow will need some manual work.
To find out what needs to happen, please check the `test.yml` file's contents, which has TODO comments to help you.
