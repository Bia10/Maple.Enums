using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Two-state secondary stat index.
/// These are secondary stats tracked separately from the main TemporaryStatType bitmask.
/// </summary>
public enum TwoStateIndex : byte
{
    /// <summary>Aran combo energy charge.</summary>
    [Label("TS_ENERGY_CHARGED")]
    [Label("Energy Charged", 1)]
    EnergyCharged = 0,

    /// <summary>Pirate dash speed buff.</summary>
    [Label("TS_DASH_SPEED")]
    [Label("Dash Speed", 1)]
    DashSpeed = 1,

    /// <summary>Pirate dash jump buff.</summary>
    [Label("TS_DASH_JUMP")]
    [Label("Dash Jump", 1)]
    DashJump = 2,

    /// <summary>Mount / vehicle ride.</summary>
    [Label("TS_RIDE_VEHICLE")]
    [Label("Ride Vehicle", 1)]
    RideVehicle = 3,

    /// <summary>Party booster effect.</summary>
    [Label("TS_PARTY_BOOSTER")]
    [Label("Party Booster", 1)]
    PartyBooster = 4,

    /// <summary>Wild Hunter guided bullet.</summary>
    [Label("TS_GUIDED_BULLET")]
    [Label("Guided Bullet", 1)]
    GuidedBullet = 5,

    /// <summary>Undead (zombie) state.</summary>
    [Label("TS_UNDEAD")]
    Undead = 6,
}
