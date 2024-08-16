# The Representer Interface

All interactions with the Exercism website are handled automatically.
Representers have the single responsibility of taking a solution and returning a representation of it.
See the [introduction](/docs/building/tooling/representers#introduction) for more information.

## Execution

- A Representer should provide an executable script. You can find more information in the [docker.md](/docs/building/tooling/representers/docker) file.
- The script will receive three parameters:
  - The slug of the exercise (e.g. `two-fer`).
  - A path to a directory containing the submitted file(s) (with a trailing slash).
  - A path to an output directory (with a trailing slash). This directory is writable.
- The script must write a `representation.txt` file to the output directory.
- The script must write a `representation.json` file to the output directory.
- The script must write a `mapping.json` file to the output directory.

### Allowed run time

The representer gets 100% machine resources for a 20 second window per solution.
After 20 seconds, the process is halted and reports a time-out.

```exercism/note
We highly recommend following our [Performance Best Practices document](/docs/building/tooling/best-practices#h-performance) to reduce the chance of timeouts.
```

## Output format

### representation.txt

The `representation.txt` file contains some sort of canonical representation. This representation can take many forms, but is usually an AST:

```ruby
s(:class,
  s(:const, nil, :PLACEHOLDER_1), nil,
  s(:begin,
    s(:def, :PLACEHOLDER_2,
      s(:args),
      s(:begin,
        s(:lvasgn, :PLACEHOLDER_3,
          s(:str, "foo")),
        s(:lvasgn, :PLACEHOLDER_4,
          s(:str, "foo")),
        s(:return,
          s(:lvar, :PLACEHOLDER_3)))),
    s(:def, :PLACEHOLDER_3,
      s(:args),
      s(:const, nil, :PLACEHOLDER_1))))
```

The representation could also just be (normalized) source code:

```ruby
class PLACEHOLDER_1
  def PLACEHOLDER_2
    PLACEHOLDER_3 = "foo"
    PLACEHOLDER_4 = "foo"
    return PLACEHOLDER_3
  end

  def PLACEHOLDER_3
    PLACEHOLDER_1
  end
end
```

### mapping.json

The `mapping.json` file maps placeholders to their original values:

```json
{
  "PLACEHOLDER_1": "TwoFer",
  "PLACEHOLDER_2": "two_fer",
  "PLACEHOLDER_3": "foo",
  "PLACEHOLDER_4": "bar"
}
```

It is important to note that all identical names must be replaced with the same placeholder, irrespective of scope.

### representation.json

The `representation.json` file contains metadata:

- `version`: the version number of the representer (defaults to `1`)

Example:

```json
{ "version": 2 }
```
