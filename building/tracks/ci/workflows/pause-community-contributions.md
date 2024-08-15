# Pause community contributions

Some repositories don't have the resources to triage/review issues or pull requests from non-maintainer users.
The pause community solutions
If a repository has enabled this workflow, it will automatically comment on a newly opened issue or pull request if the author is _not_ member of Exercism's GitHub organisation.
The comment will suggest the user to first open a topic on the Exercism forum.

## Enabling the workflow

Add the [.github/workflows/pause-community-contributions.yml file](https://github.com/exercism/github-actions/blob/b5424c17f661f5529493258a1ad480013351aa9e/.github/workflows/pause-community-contributions.yml) into your repository.

## Disabling the workflow

Remove the workflow file from your repository.

## Source

The workflow is defined in the `.github/workflows/pause-community-contributions.yml` file.
