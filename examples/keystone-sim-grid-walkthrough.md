# Keystone Sim Grid Stack Walkthrough

This note is the quickest way to read the extra review model in `keystone-sim-grid-stack`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 133 | watch |
| stress | state drift | 195 | ship |
| edge | review cost | 180 | ship |
| recovery | decision risk | 211 | ship |
| stale | input pressure | 127 | watch |

Start with `recovery` and `stale`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`recovery` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
