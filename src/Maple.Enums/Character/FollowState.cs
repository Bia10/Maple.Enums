using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Follow (in-game escort / accompany) relationship state.
/// </summary>
public enum FollowState : byte
{
    /// <summary>No follow active.</summary>
    [Label("FS_NORMAL")]
    Normal = 0,

    /// <summary>Follow request sent.</summary>
    [Label("FS_REQUEST")]
    Request = 1,

    /// <summary>Follow request declined.</summary>
    [Label("FS_REFUSED")]
    Refused = 2,

    /// <summary>Cell phone auth required.</summary>
    [Label("FS_CELLAUTH")]
    [Label("Cell Auth", 1)]
    CellAuth = 3,

    /// <summary>Mate follow enabled.</summary>
    [Label("FS_MATEENABLE")]
    [Label("Mate Enable", 1)]
    MateEnable = 4,
}
