using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Weapon type flags for mob AI attack range checks (AI_* prefix represents weapon categories).
/// </summary>
[Flags]
public enum WeaponAttackFlag : int
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>One-handed sword.</summary>
    [Label("AI_OH_SWORD")]
    [Label("1H Sword", 1)]
    OhSword = 0x1,

    /// <summary>One-handed axe.</summary>
    [Label("AI_OH_AXE")]
    [Label("1H Axe", 1)]
    OhAxe = 0x2,

    /// <summary>One-handed mace.</summary>
    [Label("AI_OH_MACE")]
    [Label("1H Mace", 1)]
    OhMace = 0x4,

    /// <summary>Dagger.</summary>
    [Label("AI_DAGGER")]
    Dagger = 0x8,

    /// <summary>Wand.</summary>
    [Label("AI_WAND")]
    Wand = 0x10,

    /// <summary>Staff.</summary>
    [Label("AI_STAFF")]
    Staff = 0x20,

    /// <summary>Bare hand (no weapon).</summary>
    [Label("AI_BAREHAND")]
    [Label("Bare Hand", 1)]
    BareHand = 0x40,

    /// <summary>Two-handed sword.</summary>
    [Label("AI_TH_SWORD")]
    [Label("2H Sword", 1)]
    ThSword = 0x80,

    /// <summary>Two-handed axe.</summary>
    [Label("AI_TH_AXE")]
    [Label("2H Axe", 1)]
    ThAxe = 0x100,

    /// <summary>Two-handed mace.</summary>
    [Label("AI_TH_MACE")]
    [Label("2H Mace", 1)]
    ThMace = 0x200,

    /// <summary>Spear.</summary>
    [Label("AI_SPEAR")]
    Spear = 0x400,

    /// <summary>Polearm.</summary>
    [Label("AI_POLEARM")]
    Polearm = 0x800,

    /// <summary>Bow.</summary>
    [Label("AI_BOW")]
    Bow = 0x1000,

    /// <summary>Crossbow.</summary>
    [Label("AI_CROSSBOW")]
    Crossbow = 0x2000,

    /// <summary>Throwing star claw.</summary>
    [Label("AI_THROWINGGLOVE")]
    [Label("Throwing Glove", 1)]
    ThrowingGlove = 0x4000,

    /// <summary>Knuckle.</summary>
    [Label("AI_KNUCKLE")]
    Knuckle = 0x8000,

    /// <summary>Gun.</summary>
    [Label("AI_GUN")]
    Gun = 0x10000,
}
