# GitHub Actions: Best Practices

This _working_ document serves as a collection of best practices for making use of GitHub Actions.
If you have any suggestions or additions, [please open a pull request on GitHub!](https://github.com/exercism/docs/edit/main/building/tracks/ci/gha-best-practices.md)

- [Collection of Best Practices](#collection-of-best-practices)
  - [Set timeouts for workflows](#set-timeouts-for-workflows)
  - [Consider if (third-party) actions are really needed](#consider-if-third-party-actions-are-really-needed)
  - [Limit scope of workflow token](#limit-scope-of-workflow-token)
  - [Pin actions to SHAs](#pin-actions-to-shas)
  - [Consider setting up a concurrency strategy](#consider-setting-up-a-concurrency-strategy)
  - [Consider which triggers are really needed](#consider-which-triggers-are-really-needed)
- [Workflow Checklist](#workflow-checklist)

## Collection of Best Practices

### Set timeouts for workflows

By default, GitHub Actions kills workflows after 6 hours if they have not finished by then.
Many workflows don't need nearly as much time to finish but sometimes unexpected errors occur or a job starts hanging until the workflow run is killed. Therefore it's recommended to [specify a shorter timeout](https://docs.github.com/en/actions/learn-github-actions/workflow-syntax-for-github-actions#jobsjob_idtimeout-minutes).

The ideal timeout depends on the individual workflow but 30 minutes are typically more than enough for the workflows used in Exercism repos.

This has the following advantages:

- PRs won't be pending CI for half the day, issues can be caught early or workflow runs can be restarted.
- The number of overall parallel builds is limited, hanging jobs will not cause issues for other PRs if they are cancelled early.

#### Example

```yml
jobs:
  configlet:
    timeout-minutes: 30
    runs-on: ubuntu-latest
    steps:
    - [...]
```

### Consider if (third-party) actions are really needed

Actions should be treated like dependencies in your favourite programming language[^1], they are code written by third party authors outside of the control of Exercism.
Even if you trust the authors of the action, there may be a hostile takeover of the repository which will indirectly give those people access to Exercism repos, including write access.

Therefore, you should carefully consider if introducing a new action is really worth it or if you could embed the code directly in the workflow, e.g. using the pre-installed [`gh` cli](https://cli.github.com/manual/) or the [`github-script` action](https://github.com/actions/github-script).

Also consider if the action is actively maintained, e.g. by checking recent repo activity or ensuring that the action is part of an organisation rather than an individual account.

Actions published by [GitHub](https://github.com/actions/) or the Exercism org can generally be considered as safe(ish) to include without special consideration.

[^1]: unless the language uses the npm ecosystem.

### Limit scope of workflow token

By default, the access token given to the workflow has wide-ranging permissions, both for reading and writing.

The [principle of least privilege](https://en.wikipedia.org/wiki/Principle_of_least_privilege) should also be applied to workflows.

You can specify which permissions a workflow needs on a [per-workflow basis](https://docs.github.com/en/actions/learn-github-actions/workflow-syntax-for-github-actions#permissions).

#### Example

If a workflow only needs to read the contents of a repo but not write to it, e.g. because it's a normal CI check, you can restrict the token as follows:

```yml
permissions:
  contents: read
```

Check the [GitHub Docs](https://docs.github.com/en/actions/learn-github-actions/workflow-syntax-for-github-actions#permissions) for the full list of permissions.

### Pin actions to SHAs

### Consider setting up a concurrency strategy

### Consider which triggers are really needed

## Workflow Checklist

You can use the following checklist to check if a workflow follows the best practices.
The checklist is not meant to be complete but instead focus on the most important items.



<details><summary>Copy-pastable version, e.g. for PRs</summary>

```yml
```

</details>
