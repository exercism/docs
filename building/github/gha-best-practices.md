# GitHub Actions: Best Practices

This _working_ document serves as a collection of best practices for making use of GitHub Actions.
If you have any suggestions or additions, [please open a pull request on GitHub!](https://github.com/exercism/docs/edit/main/building/github/gha-best-practices.md)

- [Collection of Best Practices](#collection-of-best-practices)
  - [Set timeouts for workflows](#set-timeouts-for-workflows)
  - [Consider if (third-party) actions are really needed](#consider-if-third-party-actions-are-really-needed)
  - [Limit scope of workflow token](#limit-scope-of-workflow-token)
  - [Pin actions to SHAs](#pin-actions-to-shas)
  - [Consider setting up a concurrency strategy](#consider-setting-up-a-concurrency-strategy)
  - [Consider which triggers are really needed](#consider-which-triggers-are-really-needed)
  - [Read the "Security hardening for GitHub Actions" guide](#read-the-security-hardening-for-github-actions-guide)
- [Workflow Checklist](#workflow-checklist)

## Collection of Best Practices

### Set timeouts for workflows

By default, GitHub Actions kills workflows after 6 hours if they have not finished by then.
Many workflows don't need nearly as much time to finish, but sometimes unexpected errors occur or a job hangs until the workflow run is killed 6 hours after starting it.
Therefore it's recommended to [specify a shorter timeout](https://docs.github.com/en/actions/learn-github-actions/workflow-syntax-for-github-actions#jobsjob_idtimeout-minutes).

The ideal timeout depends on the individual workflow but 30 minutes is typically more than enough for the workflows used in Exercism repos.

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

Therefore, you should carefully consider if introducing a new action is really worth it or if it's better to move the code into a (new) action under Exercism's control.

Also consider if the action is actively maintained, e.g. by checking recent repo activity or ensuring that the action is part of an organisation rather than an individual account.

Actions published by [GitHub](https://github.com/actions/) or the Exercism org can generally be considered as safe(ish) to include without special consideration.

[^1]: unless the language uses the npm ecosystem.

### Limit scope of workflow token

By default, the access token given to the workflow has wide-ranging permissions, both for reading and writing.

The [principle of least privilege](https://en.wikipedia.org/wiki/Principle_of_least_privilege) should also be applied to workflows.

You can specify which permissions a workflow needs on a [per-workflow basis](https://docs.github.com/en/actions/security-guides/automatic-token-authentication#modifying-the-permissions-for-the-github_token).

#### Example

If a workflow only needs to read the contents of a repo but not write to it, e.g. because it's a normal CI check, you can restrict the token as follows:

```yml
permissions:
  contents: read
```

Check the [GitHub Docs](https://docs.github.com/en/actions/learn-github-actions/workflow-syntax-for-github-actions#permissions) for the full list of permissions.

### Pin actions to SHAs

### Consider setting up a concurrency strategy

It's often not necessary or useful to run CI on intermediate commits if a newer commit has been pushed in the meantime.

You can configure a [concurrency strategy](https://docs.github.com/en/actions/learn-github-actions/workflow-syntax-for-github-actions#concurrency) in order to automatically cancel running workflows in the same context.

#### Example

To cancel intermediate builds in a PR, you can use the following concurrency settings:

```yml
concurrency: 
  group: ${{ github.workflow }}-${{ github.ref }}
  cancel-in-progress: ${{ startsWith(github.ref, 'refs/pull/') }}
```

<details><summary>Third Party Notice</summary>

The example above is based on [PkgTemplates.jl's CI workflow](https://github.com/invenia/PkgTemplates.jl/blob/cb02b3416b1adcac8006dd4905947e0f2d6994aa/.github/workflows/CI.yml#L10-L14), published under the [MIT license](https://github.com/invenia/PkgTemplates.jl/blob/cb02b3416b1adcac8006dd4905947e0f2d6994aa/LICENSE):

> MIT License
> 
> Copyright (c) 2017-2020 Chris de Graaf, Invenia Technical Computing Corporation
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy
> of this software and associated documentation files (the "Software"), to deal
> in the Software without restriction, including without limitation the rights
> to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
> copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
> 
> The above copyright notice and this permission notice shall be included in all
> copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
> IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
> AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
> OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
> SOFTWARE.


</details>

### Consider which triggers are really needed

### Read the "Security hardening for GitHub Actions" guide

The practices mentioned above are by no means exhaustive.
For a comprehensive guide on good security practices for using GitHub Actions safely, check out [GitHub's security guide](https://docs.github.com/en/actions/security-guides/security-hardening-for-github-actions#using-third-party-actions).

## Workflow Checklist

You can use the following checklist to check if a workflow follows the best practices.
The checklist is not meant to be complete but instead focuses on the most important items.



<details><summary>Copy-pastable version, e.g. for PRs</summary>

```yml
```

</details>
