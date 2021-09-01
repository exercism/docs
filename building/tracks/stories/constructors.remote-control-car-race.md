# Remote control car race

## Story

In this exercise you'll be organizing races between various types of remote controlled cars. Each car has its own speed and battery drain characteristics.

Cars start with full (100%) batteries. Each time you drive the car using the remote control, it covers the car's speed in meters and decreases the remaining battery percentage by its battery drain.

If a car's battery is below its battery drain percentage, you can't drive the car anymore.

Each race track has its own distance. Cars are tested by checking if they can finish the track without running out of battery.

## Tasks

These are example tasks that fit the remote control car race exercise:

- Creating a remote controlled car
- Creating a race track
- Drive the car
- Check for a drained battery
- Create the Nitro remote control car
- Check if a remote control car can finish a race

## Implementations

- [C#: need-for-speed][implementation-csharp] (reference implementation)

## Related

- [`concepts/constructors`][concepts-constructors]
- [`concepts/object`][concepts-objects]
- [`types/class`][types-class]

[concepts-constructors]: https://github.com/exercism/v3/blob/main/reference/concepts/constructors.md
[concepts-objects]: https://github.com/exercism/v3/blob/main/reference/concepts/objects.md
[types-class]: https://github.com/exercism/v3/blob/main/reference/types/class.md
[implementation-csharp]: https://github.com/exercism/csharp/blob/main/exercises/concept/need-for-speed/.docs/instructions.md
