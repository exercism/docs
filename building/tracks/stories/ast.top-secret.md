# Top Secret

## Story

You are fighting against corporate espionage with the help of a secret informer that encodes secret messages through her code.

## Tasks

The student implements a function to decode messages from some source code in the following steps:

- Turn source code into an AST
- Parse a single node: if the node is a function definition, return the function name
- Extend the parsing: only return a number of characters equal to the number of arguments the function receives
- Decode the message: traverse all the nodes and concatenate the returned strings

## Implementations

- [Elixir: top-secret][implementation-elixir] (reference implementation)

[implementation-elixir]: https://github.com/exercism/elixir/blob/main/exercises/concept/top-secret/.docs/instructions.md
