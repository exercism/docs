# Syncing

If a track implements an exercise for which test data exists, the exercise _must_ contain a `.meta/tests.toml` file. The goal of this file is to keep track of which tests are implemented by the exercise. Tests in this file are identified by their UUID and each test has a boolean value that indicates if it is implemented by that exercise.

The `sync` command will compare the tests specified in the `tests.toml` files against the tests that are defined in the exercise's canonical data. It then interactively gives the maintainer the option to include or exclude test cases that are currently missing, updating the `tests.toml` file accordingly.

## Usage

The `sync` command can be used to sync the test data.

```
configlet [global-options] sync [command-options]

Global options:
  -h, --help                   Show this help message and exit
      --version                Show this tool's version information and exit
  -t, --track-dir <dir>        Specify a track directory to use instead of the current directory
  -v, --verbosity <verbosity>  The verbosity of output. Allowed values: q[uiet], n[ormal], d[etailed]

Options for sync:
  -e, --exercise <slug>        Only sync this exercise
  -c, --check                  Terminates with a non-zero exit code if one or more tests are missing. Doesn't update the tests
  -m, --mode <mode>            What to do with missing test cases. Allowed values: c[hoose], i[nclude], e[xclude]
  -p, --prob-specs-dir <dir>   Use this `problem-specifications` directory, rather than cloning temporarily
  -o, --offline                Do not check that the directory specified by `-p, --prob-specs-dir` is up-to-date
```

## Example

A `tests.toml` file for a track's `two-fer` exercise looks like this:

```toml
[canonical-tests]

# no name given
"19709124-b82e-4e86-a722-9e5c5ebf3952" = true

# a name given
"3451eebd-123f-4256-b667-7b109affce32" = true

# another name given
"653611c6-be9f-4935-ab42-978e25fe9a10" = false
```

In this case, the track has chosen to implement two of the three available tests.

## Test generators

If a track uses a _test generator_ to generate an exercise's test suite, it _must_ use the contents of the `tests.toml` file to determine which tests to include in the generated test suite.
