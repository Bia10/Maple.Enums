using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Secondary temporary stat index.
/// Secondary stat types tracked separately from the main CTS_ bit-position system.
/// Different from <see cref="TemporaryStatType"/> which is the primary CTS_ bit-position index.
/// </summary>
public enum SecondaryStatType : byte
{
    /// <summary>Energy charge (Marauder/Buccaneer).</summary>
    [Label("TS_ENERGY_CHARGED")]
    [Label("Energy Charged", 1)]
    EnergyCharged = 0,

    /// <summary>Dash speed boost (Pirate).</summary>
    [Label("TS_DASH_SPEED")]
    [Label("Dash Speed", 1)]
    DashSpeed = 1,

    /// <summary>Dash jump boost (Pirate).</summary>
    [Label("TS_DASH_JUMP")]
    [Label("Dash Jump", 1)]
    DashJump = 2,

    /// <summary>Mount/vehicle riding state.</summary>
    [Label("TS_RIDE_VEHICLE")]
    [Label("Ride Vehicle", 1)]
    RideVehicle = 3,

    /// <summary>Party-wide speed boost.</summary>
    [Label("TS_PARTY_BOOSTER")]
    [Label("Party Booster", 1)]
    PartyBooster = 4,

    /// <summary>Homing bullet (Captain).</summary>
    [Label("TS_GUIDED_BULLET")]
    [Label("Guided Bullet", 1)]
    GuidedBullet = 5,

    /// <summary>Undead state (Dark Knight).</summary>
    [Label("TS_UNDEAD")]
    Undead = 6,
}
