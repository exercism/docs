# Sync labels workflow

The sync labels workflow is defined in the `.github/workflows/sync-labels.yml` file.
The goal of this workflow is to add/update/delete the repository's [GitHub labels](https://docs.github.com/en/issues/using-labels-and-milestones-to-track-work/managing-labels).
The labels themselves are defined in the `.github/labels.yml` file.
Whenever the `.github/labels.yml` file changes, the sync labels workflow will automatically update the repository's labels.

## Customizing labels

The labels defined in `.github/labels.yml` come in two forms:

- Shared labels: these are labels used by _all_ Exercism repositories, and they're defined in the [org-wide-files repo](https://github.com/exercism/org-wide-files/blob/main/global-files/.github/labels.yml)
- Track-specific labels: these are defined in an `.appends/.github/labels.yml` file

To add track-specific labels, you'll need to add them to the `.appends/.github/labels.yml` file (see [this example](https://github.com/exercism/python/blob/main/.appends/.github/labels.yml)).
Once you've merged the changes to `main`, a pull request will automatically be opened to change the `.github/labels.yml` file.
After merging that PR, the labels will be automatically updated (see description above).

```exercism/caution
Never manually edit the `.github/labels.yml` file, as those changes will be overwritten the next time labels are synced.
```
