using BenchmarkDotNet.Attributes;

namespace Maple.Enums.Benchmarks;

public class EnumDisplayBench
{
    [Benchmark]
    public string GetDisplayLabel_Job() => Job.WhiteKnight.GetDisplayLabel();

    [Benchmark]
    public string GetDisplayLabel_WeaponType() => WeaponType.OhSword.GetDisplayLabel();

    [Benchmark]
    public string GetDisplayLabel_Element() => Element.Fire.GetDisplayLabel();
}
