# Take-A-Number Machine

## Story

You are writing an embedded system for a Take-A-Number machine. It is a very simple model. It can give out consecutive numbers and report what was the last number given out.

## Tasks

- Start the machine.
- Make the machine report its state (last given out number).
- Make the machine give out a number.
- Make the machine stop when asked to.
- Ensure the machine can handle unexpected messages.

## Implementations

- [Elixir: processes][implementation-elixir] (reference implementation)

## Related

- [`concepts/actor-model`][concepts/actor-model]
- [`types/pid`][types/pid]

[concepts/actor-model]: https://github.com/exercism/v3/blob/main/reference/concepts/actor_model.md
[types/pid]: https://github.com/exercism/v3/blob/main/reference/types/pid.md
[implementation-elixir]: https://github.com/exercism/elixir/blob/main/exercises/concept/take-a-number/.docs/instructions.md
