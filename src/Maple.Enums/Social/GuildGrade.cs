using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Guild member rank as stored in Etc.wz GuildSkill.img and guild-related data.
/// </summary>
public enum GuildGrade : byte
{
    /// <summary>No rank.</summary>
    None = 0,

    /// <summary>Guild master.</summary>
    Master = 1,

    /// <summary>Sub-master (Jr. Master).</summary>
    [Label("Sub Master", 1)]
    SubMaster = 2,

    /// <summary>Rank 1 member.</summary>
    [Label("Member 1", 1)]
    Member1 = 3,

    /// <summary>Rank 2 member.</summary>
    [Label("Member 2", 1)]
    Member2 = 4,

    /// <summary>Rank 3 member.</summary>
    [Label("Member 3", 1)]
    Member3 = 5,
}
