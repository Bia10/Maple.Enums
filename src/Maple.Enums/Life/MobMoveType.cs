using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Forced mob movement type.
/// Different from <see cref="MobMoveAbility"/> which describes a mob's innate movement capability.
/// This enum describes movement actions applied to mobs by skills/attacks.
/// </summary>
public enum MobMoveType : byte
{
    /// <summary>No forced movement.</summary>
    [Label("MOBMOVE_NONE")]
    None = 0,

    /// <summary>Flinch from a normal hit.</summary>
    [Label("MOBMOVE_HIT")]
    Hit = 1,

    /// <summary>Knockback displacement.</summary>
    [Label("MOBMOVE_KNOCKBACK")]
    Knockback = 2,

    /// <summary>Pull/attract toward the attacker.</summary>
    [Label("MOBMOVE_ATTRACT")]
    Attract = 3,

    /// <summary>Faster pull/attract toward the attacker.</summary>
    [Label("MOBMOVE_ATTRACT_FASTER")]
    [Label("Attract Faster", 1)]
    AttractFaster = 4,

    /// <summary>Dragon Pulse skill displacement.</summary>
    [Label("MOBMOVE_DRAGONPULSE")]
    [Label("Dragon Pulse", 1)]
    DragonPulse = 5,

    /// <summary>Rush skill displacement.</summary>
    [Label("MOBMOVE_RUSH")]
    Rush = 6,

    /// <summary>Ninja Storm skill displacement.</summary>
    [Label("MOBMOVE_NINJASTORM")]
    [Label("Ninja Storm", 1)]
    NinjaStorm = 7,

    /// <summary>Elbow Attack skill displacement.</summary>
    [Label("MOBMOVE_ELBOWATTACK")]
    [Label("Elbow Attack", 1)]
    ElbowAttack = 8,

    /// <summary>Screw Punch skill displacement.</summary>
    [Label("MOBMOVE_SCREWPUNCH")]
    [Label("Screw Punch", 1)]
    ScrewPunch = 9,

    /// <summary>Fist skill displacement.</summary>
    [Label("MOBMOVE_FIST")]
    Fist = 10,

    /// <summary>Toss into the air.</summary>
    [Label("MOBMOVE_TOSS")]
    Toss = 11,

    /// <summary>Force mob to stop moving.</summary>
    [Label("MOBMOVE_STOP")]
    Stop = 12,

    /// <summary>Swallow/absorb the mob.</summary>
    [Label("MOBMOVE_SWALLOW")]
    Swallow = 13,

    /// <summary>Attack-rush displacement.</summary>
    [Label("MOBMOVE_ATTACK_RUSH")]
    [Label("Attack Rush", 1)]
    AttackRush = 14,
}
