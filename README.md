# PhysicsCalculator

NuGet package for Physics calculation support of most(ly) used equations.

## Install

Install via [NuGet](https://www.nuget.org/packages/PhysicsCalculator) package manager console:
```
PM> Install-Package PhysicsCalculator
```

Or clone the repository & pull in the projects directly.

## About PhysicsCalculator

Supported physics equations (all return 8 bytes size floating-point `double`):
- `Kinematics`:
  - `AverageVelocity(r, t)`, where r - change in position vector, t - time
  - `AverageAcceleration(v, t)`, where v - difference in velocity vector, t - time
  - `TimeFromAverageAcceleration(v, v0, a)`, where v and v0 - velocities, a - average acceleration
  - `AngularVelocity(theta, t)`, where theta - angular rotation, t - time

- `SpecialRelativity`:
  - `LenghtInvariant(x1, y1, z1, x2, y2, z2)`, where x1, y1, z1, x2, y2, z2 - coordinates
  - `TimeIntervalInvariant(t1, t2)`, where t1, t2 - time
  - `LorentzFactor(v)`, where v - relative velocity between frames in the x-direction
  - `TimeDilation(t, v)`, where t - time in observers own frame of reference, v - speed of the moving object
  - `LengthContraction(l0, v)`, where l0 - length measured by the observers on reference frame, v - speed of the object

Supported constants:
  - `SpeedOfLight` (in m/s)

#### Built with

- C# & .NET5

## License

MIT License.