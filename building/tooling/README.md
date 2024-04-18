# Track Tooling

There are two types of track tooling:

- Production: provide a key function to the learning experience of that language
- Maintenance: help with track maintenance

Tooling is (generally) written in the language of the specific track, and is built and maintained by maintainers.

## Production tooling

These tools run on Exercism's production servers.

### Track-specific production tooling

There are three pieces of track-specific production tooling:

- **[Test Runners](/docs/building/tooling/test-runners)** (essential)
- **[Representers](/docs/building/tooling/representers)** (optional)
- **[Analyzers](/docs/building/tooling/analyzers)** (optional)

### General production tooling

There are two pieces of general production tooling that can be configured for your track:

- **[Lines of Code Counter](/docs/building/tooling/lines-of-code-counter)** (optional)
- **[Snippet Extractor](/docs/building/tooling/snippet-extractor)** (optional)

### Deployment

Production tools are built as Docker images.
They are auto-deployed to Exercism's production servers using CI workflows.

## Maintenance tooling

Maintenance tooling is designed to help with maintaining the track.
They usually run locally (on the maintainer/contributor's machine) and sometimes in CI, but never in production.

Here are some examples of maintenance tooling:

- **[Test Generators](/docs/building/tooling/test-generators)**

## Implementation

Track tooling is usually (mostly) written in the track's language.

```exercism/caution
While you're free to use other languages, each additional language will make it harder to maintain or contribute to the track.
Therefore, we recommend using the track's language where possible, because it makes maintaining or contributing easier.
```
