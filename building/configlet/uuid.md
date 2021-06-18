# Generating UUIDs

Exercises, tracks and concepts are identified by a UUID. [configlet](../) can generate new, valid UUIDs.

## Usage

The `uuid` command can be used to generate one or more UUIDs.

```
configlet [global-options] uuid [command-options]

Options for uuid:
  -n, --num <int>              Number of UUIDs to generate

Global options:
  -h, --help                   Show this help message and exit
      --version                Show this tool's version information and exit
  -t, --track-dir <dir>        Specify a track directory to use instead of the current directory
  -v, --verbosity <verbosity>  The verbosity of output. Allowed values: q[uiet], n[ormal], d[etailed]
```

## Example

```
$ configlet uuid --num 5
3823f890-be49-4700-baac-e19de8fda76f
c12309a2-8bd6-4b9c-a511-e1ee4083f492
26167ad5-fe20-43d4-8b1f-3bbb9618c36e
5df11ac0-e612-4223-b0f8-f6cd2cb15cb1
e42b94bb-9c90-47f2-aebb-03cdbc27bf3b
```
