# New Passport

## Story

Your passport is about to expire, so you head out to the city office and face the many things that can go wrong (closed building, info desk on coffee break, wrong form color) and learn how to deal with successive tasks that either return a valid result or an error.

## Tasks

The student implements a function to handle successive failures or successes in four different tasks:

- Get into the building, receive a timestamp or an error if the building is closed
- Go to the info desk and find out which counter to go to, receive the counter number or an error if the desk is on coffee break (in which case, try 15 minutes later)
- Get your form stamped, receive a checksum or an error if you have the wrong form color
- Get your new passport

The errors may be actual errors, option/maybe types, or labelled values (`{:ok, result}` or `{:error, reason}` in Elixir).

## Implementations

- [Elixir: new-passport][implementation-elixir] (reference implementation)

[implementation-elixir]: https://github.com/exercism/elixir/blob/main/exercises/concept/new-passport/.docs/instructions.md
