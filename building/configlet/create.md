# Configlet creating files

When adding a new approach, article or exercise, you'll have to create files with very specific names.
They also require configuration files to be added or updated.
With the `create` command, [configlet](/docs/building/configlet) can do all this for you.

## Usage

The `create` command can be used to create the files required to add a new approach, article or exercise, as well as modify any configuration files.

```shell
configlet [global-options] create [command-options]

Options for create:
      --approach <slug>           The slug of the approach
      --article <slug>            The slug of the article
      --practice-exercise <slug>  The slug of the practice exercise
      --concept-exercise <slug>   The slug of the concept exercise
  -e, --exercise <slug>           Only operate on this exercise
  -o, --offline                   Do not update the cached 'problem-specifications' data
```

## Create Practice Exercise

To create a practice exercise, one has to specify its slug:

```shell
configlet create --practice-exercise collatz-conjecture
```

This will create the practice exercise's required files, as specified in the [Practice Exercises docs](/docs/building/tracks/practice-exercises).
If the practice exercise is defined in the [Problem Specifications repo](https://github.com/exercism/problem-specifications/), configlet will sync the docs and metadata from there.

Of course, this is just the first step towards creating an exercise.
You'll then have to:

- Add tests to the tests file
- Add an example implementation
- Define the stub file's contents
- Within the exercise's `.meta/config.json` file:
  - Add the GitHub username of the exercise's authors to the `authors` key
- Within the track's `config.json` file:
  - Check/update the exercise's difficulty
  - Add concepts to the `practices` key (only required when the track has concept exercises)
  - Add concepts to the `prerequisites` key (only required when the track has concept exercises)

```exercism/note
Some tracks have implemented an exercise/test _generator_, which is a tool that can generate the test file's contents based on the exercise's `canonical-data.json` found in the [Problem Specifications repo](https://github.com/exercism/problem-specifications/).
Make sure to read the track's documentation to see if there is a generator that you can use.
```

## Create Concept Exercise

To create a concept exercise, one has to specify its slug:

```shell
configlet create --concept-exercise bird-watcher
```

This will create the concept exercise's required files, as specified in the [Concept Exercises docs](/docs/building/tracks/concept-exercises).

Of course, this is just the first step towards creating an exercise.
You'll then have to:

- Add tests to the tests file
- Add an exemplar implementation
- Define the stub file's contents
- Write the introduction in `.docs/introduction.md`
- Write the instructions in `.docs/instructions.md`
- Within the exercise's `.meta/config.json` file:
  - Add the GitHub username of the exercise's authors to the `authors` key
- Within the track's `config.json` file:
  - Check/update the exercise's difficulty
  - Add concepts to the `concepts` key
  - Add concepts to the `prerequisites` key

## Create Approach

To create an approach's files, one has to specify the slug of the approach and its exercise:

```shell
configlet create --approach recursion --exercise collatz-conjecture
```

This will create the approach's required files, as specified in the [Approaches docs](/docs/building/tracks/approaches).

## Create Article

To create an article's files, one has to specify the slug of the article and its exercise:

```shell
configlet create --article performance --exercise collatz-conjecture
```

This will create the article's required files, as specified in the [Articles docs](/docs/building/tracks/articles).
