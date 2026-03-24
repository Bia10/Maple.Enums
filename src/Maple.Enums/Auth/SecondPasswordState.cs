using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Secondary password (SPW) check state on the client.
/// </summary>
public enum SecondPasswordState : byte
{
    /// <summary>No secondary password set.</summary>
    [Label("CHECK_SPW_NONE")]
    None = 0,

    /// <summary>Secondary password is active.</summary>
    [Label("CHECK_SPW_ENABLED")]
    Enabled = 1,

    /// <summary>Secondary password is disabled.</summary>
    [Label("CHECK_SPW_DISABLED")]
    Disabled = 2,

    /// <summary>Skip secondary password check.</summary>
    [Label("CHECK_SPW_DONOTCHECK")]
    [Label("Do Not Check", 1)]
    DoNotCheck = 3,

    /// <summary>State not yet determined.</summary>
    [Label("CHECK_SPW_UNINITIALIZED")]
    Uninitialized = 255,
}
