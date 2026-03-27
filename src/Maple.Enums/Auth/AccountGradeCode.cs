using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Account grade bitmask stored in <c>CWvsContext.m_nGradeCode</c>.
/// Read from the <c>AccountInfoResult</c> packet as a single byte (<c>Decode1</c>).
/// Each set bit grants the corresponding admin tier; multiple bits may be combined.
/// </summary>
[Flags]
public enum AccountGradeCode : byte
{
    /// <summary>No admin tier granted.</summary>
    None = 0,

    /// <summary>Admin level 1 (bit 0). Lowest GM tier.</summary>
    [Label("Admin Level 1", 1)]
    AdminLevel1 = 0x1,

    /// <summary>Admin level 2 (bit 1).</summary>
    [Label("Admin Level 2", 1)]
    AdminLevel2 = 0x2,

    /// <summary>Admin level 3 (bit 2).</summary>
    [Label("Admin Level 3", 1)]
    AdminLevel3 = 0x4,

    /// <summary>Admin level 4 (bit 3).</summary>
    [Label("Admin Level 4", 1)]
    AdminLevel4 = 0x8,

    /// <summary>Admin level 5 (bit 4).</summary>
    [Label("Admin Level 5", 1)]
    AdminLevel5 = 0x10,

    /// <summary>Admin level 10 (bit 5). Restriction override tier.</summary>
    [Label("Admin Level 10", 1)]
    AdminLevel10 = 0x20,
}
