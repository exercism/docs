_work in progress_

# Configlet

[configlet](https://github.com/exercism/configlet) is a tool to help track maintainers with the maintenance of their track.

## Linting

The primary function of configlet is to do _linting_: checking if a track's configuration files are properly structured - both syntactically and semantically. Misconfigured tracks may not sync correctly, may look wrong on the website, or may present a suboptimal user experience, so configlet's guards play an important part in maintaining the integrity of Exercism. The full list of rules that are checked by the linter can be found [here](./linting.md).

## Generating documents

The secondary function of configlet is to generate documents. There are two types of documents that configlet can generate:

1. A Concept Exercise's [`introduction.md` file](./generating-documents.md#documentconceptexercisesintroductionmdfile).
1. A Practice Exercise's [`README.md` file](./generating-documents.md#documentpracticeexercisesreadmemdfile).

How these documents are generated can be found [here](./generating-documents.md).

## Usage

configlet is distributed as a standalone binary. Each track should have a `bin/fetch-configlet` script, and might have a `bin/fetch-configlet.ps1` script too. The first is a bash script, and the second is a PowerShell script.

Running one of these scripts downloads the latest version of configlet to the `bin` directory. You can then use configlet by running `bin/configlet` or `bin/configlet.exe` respectively.

## CI

All tracks should integrate the configlet lint functionality in their CI setup. The easiest way to do this is by using the [configlet CI GitHub action](https://github.com/exercism/github-actions/tree/master/configlet-ci).

TODO: describe other configlet features
