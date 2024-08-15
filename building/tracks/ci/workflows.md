# Workflows

GitHub Actions uses the concept of _workflows_, which are scripts that run automatically whenever a specific event occurs (e.g. pushing a commit).

Each GitHub Actions workflow is defined in a `.yml` file in the `.github/workflows` directory.
For information on workflows, check the following docs:

- [Workflow syntax](https://docs.github.com/en/actions/writing-workflows/workflow-syntax-for-github-actions)
- [Choosing when your workflow runs](https://docs.github.com/en/actions/writing-workflows/choosing-when-your-workflow-runs/triggering-a-workflow)
- [Choosing where your workflow runs](https://docs.github.com/en/actions/writing-workflows/choosing-where-your-workflow-runs)
- [Choose what your workflow does](https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does)
- [Writing workflows](https://docs.github.com/en/actions/writing-workflows)
- [Best practices](/docs/building/github/gha-best-practices)

## Shared workflows

Some workflows are shared across repositories.

```exercism/caution
The shared workflows are automatically synced (from the [org-wide-files repo](https://github.com/exercism/org-wide-files/)).
You should thus not manually change their contents.
```

### General workflows

- [Sync labels](/docs/building/tracks/ci/workflows/sync-labels): sync the repository's labels from file

### Track-specific workflows

- [configlet](/docs/building/tracks/ci/workflows/configlet): checks if the track's (configuration) files are properly structured - both syntactically and semantically
- [No important files changed](/docs/building/tracks/ci/workflows/no-important-files-changed): comments on pull requests that would cause re-testing of existing solutions
- [Test](/docs/building/tracks/new/setup-continuous-integration#h-test-workflow): verify the track's exercises

### Tooling-specific workflows

- [Deploy](/docs/building/tracks/ci/workflows/deploy): deploy the track tooling Docker image to Docker Hub and ECR

### Optional workflows

There are also some workflows that tracks might opt-into:

- [Pause community contributions](/docs/building/tracks/ci/workflows/pause-community-contributions): auto-comment on newly issues and PRs created by users who are not member of the Exercism GitHub organisation

## Custom workflows

Maintainers are free to add custom workflows to their repos.
Examples of such workflows could be:

- [Linting of shell scripts](https://github.com/exercism/configlet/blob/3baa09608c8ac327315c887608c13a68ae8ac359/.github/workflows/shellcheck.yml)
- [Auto-commenting on pull requests](https://github.com/exercism/elixir/blob/b737f80cc93fcfdec6c53acb7361819834782470/.github/workflows/pr-comment.yml)
- Etc.
