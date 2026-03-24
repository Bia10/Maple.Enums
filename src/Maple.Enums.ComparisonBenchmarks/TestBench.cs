using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace Maple.Enums.ComparisonBenchmarks;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory, BenchmarkLogicalGroupRule.ByParams)]
[BenchmarkCategory("0")]
public class TestBench
{
    [Params(25_000)]
    public int Count { get; set; }

    [Benchmark(Baseline = true)]
    public string MapleEnums______()
    {
        return Job.WhiteKnight.GetDisplayLabel();
    }
}
