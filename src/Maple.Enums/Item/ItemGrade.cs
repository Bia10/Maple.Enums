using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item potential grade.
/// No Legendary grade in V95.
/// </summary>
public enum ItemGrade : byte
{
    /// <summary>No potential.</summary>
    [Label("GRADE_NORMAL")]
    Normal = 0,

    /// <summary>Rare potential.</summary>
    [Label("GRADE_RARE")]
    Rare = 1,

    /// <summary>Epic potential.</summary>
    [Label("GRADE_EPIC")]
    Epic = 2,

    /// <summary>Unique potential.</summary>
    [Label("GRADE_UNIQUE")]
    Unique = 3,
}
