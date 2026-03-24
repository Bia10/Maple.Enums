using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Family privilege type.
/// Also stored as PrivilegeItem::Type with SP_* prefix at line 4798.
/// </summary>
public enum FamilyPrivilegeType : byte
{
    /// <summary>Experience boost privilege.</summary>
    [Label("Type_Exp")]
    Exp = 2,

    /// <summary>Drop rate boost privilege.</summary>
    [Label("Type_Drop")]
    Drop = 3,

    /// <summary>Family-wide privilege.</summary>
    [Label("Type_Family")]
    Family = 4,
}
