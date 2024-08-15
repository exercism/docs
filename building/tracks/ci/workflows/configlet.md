# configlet workflow

The configlet uses the [configlet tool](/docs/building/configlet) to check if a track's (configuration) files are properly structured - both syntactically and semantically.
It does this by running [`configlet lint`](/docs/building/configlet/lint).

## Enable checking file formatting

Tracks can use [`configlet fmt`](/docs/building/configlet/format) to format the track's various configuration files.
The same command can also be used to check if all configuration files are formatted correctly.

The `configlet` workflow supports verifying whether the configuration files are formatted correctly, but this is optional and disabled by default.
To opt-into verifying configuration files' formatting, follow these steps:

1. Create a `.github/org-wide-files-config.toml` file with the following contents

```toml
[configlet]
fmt = true
```

2. After this file is merged into `main`, a PR will automatically be opened that modifies the `configlet.yml` workflow as follows:

```diff
  jobs:
    configlet:
      uses: exercism/github-actions/.github/workflows/configlet.yml@main
+     with:
+       fmt: true
```

3. Once this PR is merged, the `configlet` workflow will also verify the track's configuration files' formatting.

## Source

The workflow is defined in the `.github/workflows/configlet.yml` file.
