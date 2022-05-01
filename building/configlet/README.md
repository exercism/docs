# Configlet

[configlet](https://github.com/exercism/configlet) is a tool to help track maintainers with the maintenance of their track.

## Linting

The primary function of configlet is to do _linting_: checking if a track's (configuration) files are properly structured - both syntactically and semantically.
Misconfigured tracks may not sync correctly, may look wrong on the website, or may present a suboptimal user experience, so configlet's guards play an important part in maintaining the integrity of Exercism.
The full list of rules that are checked by the linter can be found [here](/docs/building/configlet/lint.md).

## Generating documents

The secondary function of configlet is to generate documents. There are two types of documents that configlet can generate:

1. A Concept Exercise's [`introduction.md` file](/docs/building/configlet/generating-documents.md#document-concept-exercises-introductionmd-file).
1. A Practice Exercise's [`instructions.md` file](/docs/building/configlet/generating-documents.md#document-practice-exercises-instructionsmd-file).

How these documents are generated can be found [here](/docs/building/configlet/generating-documents.md).

## Syncing exercise data with the problem-specifications repo

The tertiary function of configlet is to various data for practice exercises. 

A [Practice Exercise](/docs/building/tracks/practice-exercises.md) on an Exercism track is often implemented from a specification in the [`exercism/problem-specifications`](https://github.com/exercism/problem-specifications) repo.

Exercism deliberately requires that every exercise has its own copy of certain files (like `.docs/instructions.md`), even when that exercise exists in `problem-specifications`.
Therefore configlet has a `sync` command, which can check that such Practice Exercises on a track are in sync with that upstream source, and can update them when updates are available.

There are three kinds of data that can be updated from `problem-specifications`: documentation, metadata, and tests.
There is also one kind of data that can be populated from the track-level `config.json` file: filepaths in exercise config files.

Note that in `configlet` releases `4.0.0-alpha.34` and earlier, the `sync` command operated only on tests.

To keep track of which tests are implemented for a specific practice exercise, the exercise _must_ contain a `.meta/tests.toml` file.
Tests in this file are identified by their UUID and each test has a boolean value that indicates if it is implemented by that exercise.

You can find the details about how to sync the different parts of an exercise [here](/docs/building/configlet/sync.md).

## Generating UUIDs

Exercises, tracks and concepts are identified by a UUID.

How to generate UUIDs can be found [here](/docs/building/configlet/uuid.md).

## Formatting

Configlet has a `fmt` command to help with consistent formatting of the JSON files in the track repo.
The `fmt` command currently only operates on the exercise `.meta/config.json` files but it is likely to operate on all the track JSON files in the future.
You can learn more about the format command [here](/docs/building/configlet/format.md).

## Installation

configlet is distributed as a standalone binary. Each track should have a `bin/fetch-configlet` script, and might have a `bin/fetch-configlet.ps1` script too. The first is a bash script, and the second is a PowerShell script.

Running one of these scripts downloads the latest version of configlet to the `bin` directory. You can then use configlet by running `bin/configlet` or `bin/configlet.exe` respectively.

## CI

All tracks should integrate the configlet lint functionality in their CI setup.
The easiest way to do this is by using the [configlet CI GitHub action](https://github.com/exercism/github-actions/tree/main/configlet-ci).
