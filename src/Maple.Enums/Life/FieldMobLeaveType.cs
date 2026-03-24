using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Reason a mob leaves (despawns from) the field.</summary>
public enum FieldMobLeaveType : byte
{
    /// <summary>Fled with remaining HP.</summary>
    [Label("Remain HP", 1)]
    RemainHP = 0,

    /// <summary>Generic removal.</summary>
    Etc = 1,

    /// <summary>Self-destructed.</summary>
    [Label("Self Destruct", 1)]
    SelfDestruct = 2,

    /// <summary>Destroyed by miss.</summary>
    [Label("Destruct By Miss", 1)]
    DestructByMiss = 3,

    /// <summary>Swallowed by skill.</summary>
    Swallow = 4,

    /// <summary>Summon duration expired.</summary>
    [Label("Summon Timeout", 1)]
    SummonTimeout = 5,

    /// <summary>No specific reason.</summary>
    None = 6,
}
