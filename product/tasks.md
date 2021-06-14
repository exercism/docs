# Tasks

Tasks are GitHub issues that we'd like people to help out with, from proofreading text to building Concept Exercises.
They are presented on the website and link to the corresponding issues on GitHub.
Each task is tagged with one or more properties, which are populated from the issue's labels.
The user can then filter tasks based on their properties.

## Tags

For an issue to be considered a task, it has to be labelled with one or more task-specific labels.
Maintainers can thus choose to only make some issues show up as tasks.

Each task label is defined as: `x:<type>/<value>` and five task types are supported:

- `action`
- `knowledge`
- `module`
- `size`
- `type`

### Action tag

The `x:action/<value>` labels describe what sort of work the contributor will be engaged in when working on the issue.

| Tag                  | Description                            |
| -------------------- | -------------------------------------- |
| `x:action/create`    | Work on something from scratch         |
| `x:action/fix`       | Fix an issue                           |
| `x:action/improve`   | Improve existing functionality/content |
| `x:action/proofread` | Proofread text                         |
| `x:action/sync`      | Sync content with its latest version   |

### Knowledge tag

The `x:knowledge/<value>` labels describe how much Exercism knowledge is required by the contributor.

| Tag                        | Description                                |
| -------------------------- | ------------------------------------------ |
| `x:knowledge/none`         | No existing Exercism knowledge required    |
| `x:knowledge/elementary`   | Little Exercism knowledge required         |
| `x:knowledge/intermediate` | Quite a bit of Exercism knowledge required |
| `x:knowledge/advanced`     | Comprehensive Exercism knowledge required  |

### Module tag

The `x:module/<value>` labels indicate what part of Exercism the contributor will be working on.

| Tag                          | Description                 |
| ---------------------------- | --------------------------- |
| `x:module/analyzer`          | Work on Analyzers           |
| `x:module/concept`           | Work on Concepts            |
| `x:module/concept-exercise`  | Work on Concept Exercises   |
| `x:module/generator`         | Work on Exercise generators |
| `x:module/practice-exercise` | Work on Practice Exercises  |
| `x:module/representer`       | Work on Representers        |
| `x:module/test-runner`       | Work on Test Runners        |

### Size tag

The `x:size/<value>` labels describe the expected amount of work for a contributor.

| Tag              | Description            |
| ---------------- | ---------------------- |
| `x:size/tiny`    | Tiny amount of work    |
| `x:size/small`   | Small amount of work   |
| `x:size/medium`  | Medium amount of work  |
| `x:size/large`   | Large amount of work   |
| `x:size/massive` | Massive amount of work |

### Type tag

The `x:type/<value>` labels describe how much Exercism knowledge is required by the contributor.

| Tag              | Description                                                    |
| ---------------- | -------------------------------------------------------------- |
| `x:type/ci`      | Work on Continuous Integration (e.g. GitHub Actions workflows) |
| `x:type/coding`  | Work on code that will run in production                       |
| `x:type/content` | Work on content (e.g. exercises, concepts)                     |
| `x:type/docker`  | Work on Dockerfiles                                            |
| `x:type/docs`    | Work on Documentation                                          |

## Claimed vs unclaimed tags

To hide a task due to someone already working on it, an issue can add the `x:status/claimed` label.
