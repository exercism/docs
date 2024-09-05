# Maintainers Repo Permissions

A track maintainer is someone who is a member of the track's GitHub team.
Becoming a member of a track team is _invitation only_.

```exercism/note
If you'd like to become a track maintainer, please open a topic on the [forum](https://forum.exercism.org/c/exercism/building-exercism/125).
```

## Maintenance category

The are five maintenance categories:

1. `wip-track`
2. `unmaintained`
3. `maintained-solitary`
4. `maintained-autonomous`
5. `maintained`

A tracks' maintenance category is determined by three variables:

1. Whether the track is active (i.e. students can join the track on the website)
2. The number of track maintainers
3. The number of track maintainers who are also in the `cross-track-maintainers` GitHub team

To determine the maintenance category, find the first category that matches the track from this table:

| Category                | Active? | Number of maintainers | Number of cross-track maintainers |
| ----------------------- | ------- | --------------------- | --------------------------------- |
| `wip-track`             | No      | Any                   | Any                               |
| `unmaintained`          | Yes     | 0                     | 0                                 |
| `maintained-solitary`   | Yes     | 1                     | 0                                 |
| `maintained-autonomous` | Yes     | > 0                   | = Number of maintainers           |
| `maintained`            | Yes     | > 0                   | < Number of maintainers           |

## Repo permissions

The maintenance category is used to set the track's GitHub repo(s) permission(s).

| Category                | Requires PR | Requires PR approval | Cross-track team reviews |
| ----------------------- | ----------- | -------------------- | ------------------------ |
| `wip-track`             | No          | No                   | No                       |
| `unmaintained`          | Yes         | Yes                  | Yes                      |
| `maintained-solitary`   | Yes         | Yes                  | Yes                      |
| `maintained-autonomous` | Yes         | No                   | No                       |
| `maintained`            | Yes         | No                   | No                       |

```exercism/caution
The `wip-track` category is the only category that allows maintainers to push to `main`.
```

```exercism/caution
Tooling repos will _always_ require PR approval, as their contents are protected via a [CODEOWNERS file](https://docs.github.com/en/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).
```
