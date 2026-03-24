using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Macro skill target type used by the skill macro system.
/// </summary>
public enum MacroTargetType : byte
{
    /// <summary>Target local player.</summary>
    [Label("TARGETTYPE_LOCALUSER")]
    [Label("Local User", 1)]
    LocalUser = 0,

    /// <summary>Target nearest mob.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("TAEGETTYPE_NEAREASTMOB")]
    [Label("Nearest Mob", 1)]
    NearestMob = 1,

    /// <summary>Target stunned mob.</summary>
    [Label("TARGETTYPE_DAZZLEDMOB")]
    [Label("Dazzled Mob", 1)]
    DazzledMob = 2,

    /// <summary>Target chasing mob.</summary>
    [Label("TARGETTYPE_CHASING")]
    Chasing = 3,

    /// <summary>Target self.</summary>
    [Label("TARGETTYPE_SELF")]
    Self = 4,
}
