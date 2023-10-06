# Analyzer Guidance

This document provides guidance when implementing an analyzer.

## General

- Analyze _all_ submitted files, except tests/invalidator/editor/example/exemplar files
- Don't aim for 100% correctness, which will be near impossible to achieve.
  It's okay if the analyzer can't find all issues or is unable to infer certain tags.

## Compilation

If your language requires a compilation step, consider these points:

- Compiling the solution will usually allow for higher fidelity.
  For example, the definitive type of any value is only known _after_ compilation.
  Do be aware of the trade-offs (e.g. slower to run and more memory usage).
- Consider in-memory compilation (if possible), to improve performance.

## Testing

- Have an extensive test suite
- Use golden tests to verify the behavior of the analyzer.
  These tests should use the Docker image that will be deployed to verify the analyzer.
- Consider having tests for each approach.
  You want the analyzer to work well for these solutions, and it will help assigning tags to the approaches later on.
