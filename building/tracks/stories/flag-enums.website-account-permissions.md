# Website account permissions

## Story

In this exercise you'll be checking permissions of user accounts on an internet forum. The forum supports three different permissions:

- Read
- Write
- Delete

There are three types of accounts, each with different default permissions:

- Guests: can read posts.
- Users: can read and write posts.
- Moderators: can read, write and delete posts.

Sometimes individual permissions are modified, for example giving a guest account the permission to also write posts.

## Tasks

These are example tasks that fit the website permissions exercise:

- Get default permissions for an account type
- Grant a permission
- Revoke a permission
- Check for a permission

## Implementations

- [C#: attack-of-the-trolls][implementation-csharp] (reference implementation)

## Related

- [`concepts/bitwise_manipulation`][concepts-bitwise_manipulation]
- [`types/bit`][types-bit]

[concepts-bitwise_manipulation]: https://github.com/exercism/v3/blob/main/reference/concepts/bitwise_manipulation.md
[types-bit]: https://github.com/exercism/v3/blob/main/reference/types/bit.md
[implementation-csharp]: https://github.com/exercism/csharp/blob/main/exercises/concept/attack-of-the-trolls/.docs/instructions.md
