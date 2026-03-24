namespace Maple.Enums;

/// <summary>
/// Weapon attack speed tier.
/// WZ base values stored in Character.wz equip info/attackSpeed are the even values (2, 4, 6, 8, 10).
/// Odd values (3, 9) occur at runtime when booster skills adjust speed by one tier.
/// Values 5 and 7 (intermediate Normal tiers) exist internally but have no distinct display label.
/// </summary>
public enum ItemAttackSpeed : byte
{
    /// <summary>Fastest attack speed tier.</summary>
    Fastest = 2,

    /// <summary>Faster than fast; runtime tier reached by boosting a Fast weapon.</summary>
    Faster = 3,

    /// <summary>Fast attack speed tier.</summary>
    Fast = 4,

    // NOTE: is not named in combat engine but allowed value!
    // NormalFast = 5

    /// <summary>Normal (default) attack speed tier.</summary>
    Normal = 6,

    // NOTE: is not named in combat engine but allowed value!
    // NormalSlow = 7

    /// <summary>Slow attack speed tier.</summary>
    Slow = 8,

    /// <summary>Slower than slow; runtime tier reached by boosting a Slowest weapon.</summary>
    Slower = 9,

    /// <summary>Slowest attack speed tier.</summary>
    Slowest = 10,
}
