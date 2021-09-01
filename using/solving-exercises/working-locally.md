# Solving Exercises Locally

Solving exercises on your local machine allows you to do all the coding in an environment you're familiar with.

## Installing the CLI

To solve an Exercise on your local machine, you first need to install and configure the Exercism Command Line Interface using [these instructions](https://exercism.org/cli-walkthrough).

### Configuration

You need to tell the CLI who you are so we can download things correctly.
You can find your token in your [settings page](/settings/api_cli).
You can then configure the CLI using the following, replacing `<your-api-token>` for the value on the settings page:

```
exercism configure --token=<your-api-token>
```

## Downloading the Exercise

Once installed, you can use the CLI to download the exercise to your local machine using the following command (replacing `<exercise-slug>` and `<track-slug>` with the relevant values:

```
exercism download --exercise=<exercise-slug> --track=<track-slug>
```

You don't have to remember this command structure, as the exercise page lists the appropriate command for that exercise.

Once the download command has finished, the exercise's files will be downloaded to your local machine.

## Solving the Exercise

The goal of each exercise is to create an implementation that passes all the tests.
Such an implementation is known as a _solution_.

To help you with that, each exercise contains the following files:

- README.md: the instructions that explain what is expected of you
- HELP.md: information on how to run the tests and how to get help when you're stuck
- HINTS.md (optional): hints to help solve the exercise
- Test file(s): they contain the tests that verify your solution's correctness
- Stub file(s): they provide a starting point to help you get started with building your implementation

Depending on the track, there might be other files that the track tooling requires for the tests to run.

## Submitting your Solution

Once your solution passes all the tests, you can submit your solution using the following command:

```
exercism submit <implementation_file_paths>
```

This command will upload your solution to the Exercism website and print the solution page's URL.

Once again, you don't have to remember this command, as the exercise's `HELP.md` file will list the correct command.

It's possible to submit an incomplete solution which allows you to:

- See how others have completed the exercise
- Request help from a mentor

## Other CLI functionality

### Seeing all the commands

Run the help subcommand to get the full list of available commands.

```bash
exercism help
```

### Troubleshooting

Make sure you are on the latest version.

Verify which version you are on:

```bash
exercism version
```

Verify against the latest release and upgrade if your version is not the most recent.

After upgrading, double-check the version. If the version didn’t change, make sure you are running the upgraded binary.

```bash
which exercism
```

If you are still having trouble open an issue in exercism/cli on GitHub with the output of the troubleshoot command.

```bash
exercism troubleshoot
```

You can open issues on [our issue tracker](https://github.com/exercism/exercism/issues) and the community will try to help you. **Please ensure you have worked through the [Interactive Walkthrough](https://exercism.org/cli-walkthrough) before opening any issues.**
