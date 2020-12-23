_work in progress_

# Configlet

[configlet](https://github.com/exercism/configlet) is a tool to help track maintainers with the maintenance of their track. The current version of configlet works with v2 tracks, but a version that works with v3 tracks is [under development](https://github.com/exercism/canonical-data-syncer). This document will only describe the v3 version of configlet.

## Linting

The primary function of configlet is to do _linting_: checking if a track is properly configured. If this is not the case, the track won't work properly (or at all). The full list of rules that are checked by the linter can be found [here](https://github.com/exercism/canonical-data-syncer/blob/master/linting.md).

## Usage

configlet is distributed as a standalone binary. To integrate configlet in your track, you should add one (or both) of the fetch scripts [defined here](https://github.com/exercism/configlet/tree/master/scripts), which can then be used to download the binary for your operating system/architecture.

## CI

All tracks should integrate the configlet lint functionality in their CI setup. The easiest way to do this is by using the [configlet CI GitHub action](https://github.com/exercism/github-actions/tree/master/configlet-ci).

TODO: describe other configlet features
