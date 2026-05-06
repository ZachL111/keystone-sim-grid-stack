# Review Journal

The review surface for `keystone-sim-grid-stack` is deliberately narrow: one fixture, one scoring rule, and one local check.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 133, lane `watch`
- `stress`: `state drift`, score 195, lane `ship`
- `edge`: `review cost`, score 180, lane `ship`
- `recovery`: `decision risk`, score 211, lane `ship`
- `stale`: `input pressure`, score 127, lane `watch`

## Note

The useful failure mode here is a wrong decision on a named case, not a vague style disagreement.
