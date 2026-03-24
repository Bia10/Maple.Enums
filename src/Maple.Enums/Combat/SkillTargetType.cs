using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Skill auto-target selection type
/// (V95 PDB confirmed — anonymous enum, TARGETTYPE_* prefix, game_types.h line 6041).
/// </summary>
/// <remarks>Documented original client typo in typos.md.</remarks>
public enum SkillTargetType : byte
{
    /// <summary>Targets the local player.</summary>
    [Label("TARGETTYPE_LOCALUSER")]
    [Label("Local User", 1)]
    LocalUser = 0,

    /// <summary>Targets nearest monster.</summary>
    [Label("TAEGETTYPE_NEAREASTMOB")]
    [Label("Nearest Mob", 1)]
    NearestMob = 1,

    /// <summary>Targets stunned/dazzled monster.</summary>
    [Label("TARGETTYPE_DAZZLEDMOB")]
    [Label("Dazzled Mob", 1)]
    DazzledMob = 2,

    /// <summary>Tracks moving target.</summary>
    [Label("TARGETTYPE_CHASING")]
    Chasing = 3,

    /// <summary>Targets self.</summary>
    [Label("TARGETTYPE_SELF")]
    Self = 4,
}
