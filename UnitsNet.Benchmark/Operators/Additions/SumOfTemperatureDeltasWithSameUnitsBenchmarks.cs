﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using UnitsNet.Units;

namespace UnitsNet.Benchmark.Operators.Additions;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net48)]
[SimpleJob(RuntimeMoniker.Net80)]
public class SumOfTemperatureDeltasWithSameUnitsBenchmarks
{
    private static readonly double Value = 1.23;

    private TemperatureDelta[] _quantities;

    [Params(10, 1000)]
    public int NbOperations { get; set; }

    [Params(TemperatureDeltaUnit.Kelvin, TemperatureDeltaUnit.DegreeCelsius, TemperatureDeltaUnit.DegreeFahrenheit)]
    public TemperatureDeltaUnit Unit { get; set; }

    [GlobalSetup]
    public void PrepareQuantities()
    {
        _quantities = Enumerable.Range(0, NbOperations).Select(_ => TemperatureDelta.From(Value, Unit)).ToArray();
    }

    [Benchmark(Baseline = true)]
    public TemperatureDelta SumOfDeltas()
    {
#if NET
        return UnitsNet.GenericMath.GenericMathExtensions.Sum(_quantities);
#else
        TemperatureDelta sum = TemperatureDelta.Zero;
        foreach (TemperatureDelta quantity in _quantities)
        {
            sum = quantity + sum;
        }

        return sum;
#endif
    }

    [Benchmark(Baseline = false)]
    public TemperatureDelta SumOfVolumesInBaseUnit()
    {
        return _quantities.Sum(TemperatureDelta.BaseUnit);
    }

    [Benchmark(Baseline = false)]
    public TemperatureDelta SumOfTemperatureDeltasInDegreeFahrenheit()
    {
        return _quantities.Sum(TemperatureDeltaUnit.DegreeFahrenheit);
    }
}
