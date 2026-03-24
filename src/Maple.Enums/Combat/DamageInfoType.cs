using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Damage meter information display categories.
/// </summary>
public enum DamageInfoType : byte
{
    /// <summary>Average damage per hit.</summary>
    [Label("DAMAGEINFO_AVERAGE_PERHIT")]
    [Label("Average Per Hit", 1)]
    AveragePerHit = 0,

    /// <summary>Average damage per second.</summary>
    [Label("DAMAGEINFO_AVERAGE_PERSEC")]
    [Label("Average Per Sec", 1)]
    AveragePerSec = 1,

    /// <summary>Highest single hit damage.</summary>
    [Label("DAMAGEINFO_MAX_DAMAGE")]
    [Label("Max Damage", 1)]
    MaxDamage = 2,

    /// <summary>Lowest single hit damage.</summary>
    [Label("DAMAGEINFO_MIN_DAMAGE")]
    [Label("Min Damage", 1)]
    MinDamage = 3,

    /// <summary>Cumulative damage dealt.</summary>
    [Label("DAMAGEINFO_TOTAL_DAMAGE")]
    [Label("Total Damage", 1)]
    TotalDamage = 4,

    /// <summary>Total number of attacks.</summary>
    [Label("DAMAGEINFO_TOTAL_ATTACK")]
    [Label("Total Attack", 1)]
    TotalAttack = 5,

    /// <summary>Critical hit count.</summary>
    [Label("DAMAGEINFO_CRITICAL_ATTACK")]
    [Label("Critical Attack", 1)]
    CriticalAttack = 6,

    /// <summary>Average hit count.</summary>
    [Label("DAMAGEINFO_AVERAGE_HIT")]
    [Label("Average Hit", 1)]
    AverageHit = 7,

    /// <summary>Elapsed combat time.</summary>
    [Label("DAMAGEINFO_TOTAL_TIME")]
    [Label("Total Time", 1)]
    TotalTime = 8,

    /// <summary>Base stat count.</summary>
    [Label("DAMAGEINFO_BAGICNO")]
    [Label("Basic No", 1)]
    BasicNo = 9,

    /// <summary>Extended attribute rate.</summary>
    [Label("DAMAGEINFO_EXTEND_ATTRRATE")]
    [Label("Extend Attr Rate", 1)]
    ExtendAttrRate = 10,

    /// <summary>Extended max critical value.</summary>
    [Label("DAMAGEINFO_EXTEND_MAXCRITICAL")]
    [Label("Extend Max Critical", 1)]
    ExtendMaxCritical = 11,

    /// <summary>Extended min critical value.</summary>
    [Label("DAMAGEINFO_EXTEND_MINCRITICAL")]
    [Label("Extend Min Critical", 1)]
    ExtendMinCritical = 12,

    /// <summary>Extended miss count.</summary>
    [Label("DAMAGEINFO_EXTEND_MISSHIT")]
    [Label("Extend Miss Hit", 1)]
    ExtendMissHit = 13,

    /// <summary>Extended stat count.</summary>
    [Label("DAMAGEINFO_EXTENDNO")]
    [Label("Extend No", 1)]
    ExtendNo = 14,
}
