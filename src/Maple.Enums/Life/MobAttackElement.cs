using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob attack element type.
/// Elemental classification for mob attacks (subset of <see cref="Element"/> without Physical/Undead).
/// </summary>
public enum MobAttackElement : byte
{
    /// <summary>No elemental attribute.</summary>
    [Label("Mob_AttackElem_None")]
    None = 0,

    /// <summary>Ice element attack.</summary>
    [Label("Mob_AttackElem_Ice")]
    Ice = 1,

    /// <summary>Fire element attack.</summary>
    [Label("Mob_AttackElem_Fire")]
    Fire = 2,

    /// <summary>Lightning element attack.</summary>
    [Label("Mob_AttackElem_Light")]
    Light = 3,

    /// <summary>Poison element attack.</summary>
    [Label("Mob_AttackElem_Poison")]
    Poison = 4,

    /// <summary>Holy element attack.</summary>
    [Label("Mob_AttackElem_Holy")]
    Holy = 5,

    /// <summary>Dark element attack.</summary>
    [Label("Mob_AttackElem_Dark")]
    Dark = 6,
}
