using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Privilege item type granted via the Family system.
/// </summary>
/// <seealso cref="FamilyPrivilegeType"/>
public enum PrivilegeItemType : byte
{
    /// <summary>Jump boost privilege.</summary>
    [Label("SP_Jump")]
    Jump = 0,

    /// <summary>Monster summoning privilege.</summary>
    [Label("SP_Summon")]
    Summon = 1,

    /// <summary>Increased item drop rate privilege.</summary>
    [Label("SP_IncDropRate")]
    IncDropRate = 2,

    /// <summary>Increased experience rate privilege.</summary>
    [Label("SP_IncExpRate")]
    IncExpRate = 3,

    /// <summary>Family-wide privilege.</summary>
    [Label("SP_Family")]
    Family = 4,
}
