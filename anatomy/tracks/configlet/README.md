_work in progress_

# Configlet

[configlet](https://github.com/exercism/configlet) is a tool to help track maintainers with the maintenance of their track.

## Linting

The primary function of configlet is to do _linting_: checking if a track's configuration files are properly structured - both syntactically and semantically. Misconfigured tracks may not sync correctly, may look wrong on the website, or may present a suboptimal user experience, so configlet's guards play an important part in maintaining the integrity of Exercism. The full list of rules that are checked by the linter can be found [here](./linting.md).

## Usage

configlet is distributed as a standalone binary. To integrate configlet in your track, you should add one (or both) of the fetch scripts [defined here](https://github.com/exercism/configlet/tree/master/scripts), which can then be used to download the binary for your operating system/architecture.

## CI

All tracks should integrate the configlet lint functionality in their CI setup. The easiest way to do this is by using the [configlet CI GitHub action](https://github.com/exercism/github-actions/tree/master/configlet-ci).

TODO: describe other configlet features
