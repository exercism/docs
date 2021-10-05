# RPG Quest Logic

## Story

In this exercise, you'll be implementing the quest logic for a new RPG game a friend is developing. The game's main character is Annalyn, a brave girl with a fierce and loyal pet dog. Unfortunately, disaster strikes, as her best friend was kidnapped while searching for berries in the forest. Annalyn will try to find and free her best friend, optionally taking her dog with her on this quest.

After some time spent following her best friend's trail, she finds the camp in which her best friend is imprisoned. It turns out there are two kidnappers: a mighty knight and a cunning archer.

Having found the kidnappers, Annalyn considers which of the following actions she can engage in:

- _Fast attack_
- _Spy_
- _Signal prisoner_
- _Free prisoner_

## Tasks

These are example tasks that fit the story of Annalyn rescuing her best friend:

- Implement check for _Fast attack_: a fast attack can be made if the knight is sleeping, as it takes time for him to get his armor on, so he will be vulnerable.
- Implement check for _Spy_: the group can be spied upon if at least one of them is awake. Otherwise, spying is a waste of time.
- Implement check for _Signal prisoner_: the prisoner can be signaled using bird sounds if the prisoner is awake and the archer is sleeping, as archers are trained in bird signaling so they could intercept the message.
- Implement check for _Free prisoner_: Annalyn can try sneaking into the camp to free the prisoner.
  This is a risky thing to do and can only succeed in one of two ways:
  - If Annalyn has her pet dog with her she can rescue the prisoner if the archer is asleep.
    The knight is scared of the dog and the archer will not have time to get ready before Annalyn and the prisoner can escape.
  - If Annalyn does not have her dog then she and the prisoner must be very sneaky!
    Annalyn can free the prisoner if the prisoner is awake and the knight and archer are both sleeping, but if the prisoner is sleeping they can't be rescued: the prisoner would be startled by Annalyn's sudden appearance and wake up the knight and archer.

## Terminology

These are recommendations, not rules, for recurring terminology in the instructions (including stub commentary)

- The main character is **Annalyn** and her pronouns are **she/her**. If you need to indicate the character, use the name or refer to her by her pronoun(s).
- Instead of `boolean` (or equivalent data type), use **can {action}** or **can perform {action}**
- The prisoner is her best friend, and their pronouns are **they/their**.
- Do _not_ refer to **Annalyn**, the **prisoner**, the **archer**, the **knight** or Annalyn's **pet dog** by pronoun, as the meaning will most likely be ambiguous; instead use the indicators as emphasized.

## Implementations

- [F#: booleans][implementation-fsharp]
- [JavaScript: booleans][implementation-javascript] (reference implementation)
- [Julia: boolean-logic][implementation-julia]

## Related

- [`types/boolean`][types-boolean]

[types-boolean]: https://github.com/exercism/v3/blob/main/reference/types/boolean.md
[javascript-concept-booleans]: https://github.com/exercism/javascript/blob/main/exercises/concept/booleans
[implementation-fsharp]: https://github.com/exercism/fsharp/blob/main/exercises/concept/annalyns-infiltration/.docs/instructions.md
[implementation-javascript]: https://github.com/exercism/javascript/blob/main/exercises/concept/booleans/.docs/instructions.md
[implementation-julia]: https://github.com/exercism/julia/blob/main/exercises/concept/annalyns-infiltration/.docs/instructions.md
