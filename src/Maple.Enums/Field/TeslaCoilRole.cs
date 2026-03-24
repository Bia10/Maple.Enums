using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Tesla coil summoned creature role (leader vs. follower in a triangle formation).
/// </summary>
public enum TeslaCoilRole : byte
{
    /// <summary>Initial placement state.</summary>
    [Label("TESLACOIL_START")]
    Start = 0,

    /// <summary>Triangle leader summon.</summary>
    [Label("TESLACOIL_LEADER")]
    Leader = 1,

    /// <summary>Triangle follower summon.</summary>
    [Label("TESLACOIL_FOLLOWER")]
    Follower = 2,
}
