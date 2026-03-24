using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// MapleStory weapon type.
/// </summary>
public enum WeaponType : sbyte
{
    /// <summary>Skip sub-weapon check.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("WT_NOTCHECK_SUBWEPPON")]
    [Label("Any Weapon", 1)]
    NotCheckSubWeapon = -1,

    /// <summary>No weapon equipped.</summary>
    [Label("WT_NONE")]
    None = 0,

    /// <summary>One-handed sword.</summary>
    [Label("WT_OH_SWORD")]
    [Label("1H Sword", 1)]
    OhSword = 30,

    /// <summary>One-handed axe.</summary>
    [Label("WT_OH_AXE")]
    [Label("1H Axe", 1)]
    OhAxe = 31,

    /// <summary>One-handed mace.</summary>
    [Label("WT_OH_MACE")]
    [Label("1H Mace", 1)]
    OhMace = 32,

    /// <summary>Dagger.</summary>
    [Label("WT_DAGGER")]
    Dagger = 33,

    /// <summary>Sub-weapon dagger.</summary>
    [Label("WT_SUB_DAGGER")]
    [Label("Sub-Dagger", 1)]
    SubDagger = 34,

    /// <summary>Wand.</summary>
    [Label("WT_WAND")]
    Wand = 37,

    /// <summary>Staff.</summary>
    [Label("WT_STAFF")]
    Staff = 38,

    /// <summary>Bare hand (no weapon).</summary>
    [Label("WT_BAREHAND")]
    [Label("Bare Hand", 1)]
    BareHand = 39,

    /// <summary>Two-handed sword.</summary>
    [Label("WT_TH_SWORD")]
    [Label("2H Sword", 1)]
    ThSword = 40,

    /// <summary>Two-handed axe.</summary>
    [Label("WT_TH_AXE")]
    [Label("2H Axe", 1)]
    ThAxe = 41,

    /// <summary>Two-handed mace.</summary>
    [Label("WT_TH_MACE")]
    [Label("2H Mace", 1)]
    ThMace = 42,

    /// <summary>Spear.</summary>
    [Label("WT_SPEAR")]
    Spear = 43,

    /// <summary>Polearm.</summary>
    [Label("WT_POLEARM")]
    Polearm = 44,

    /// <summary>Bow.</summary>
    [Label("WT_BOW")]
    Bow = 45,

    /// <summary>Crossbow.</summary>
    [Label("WT_CROSSBOW")]
    Crossbow = 46,

    /// <summary>Throwing star claw.</summary>
    [Label("WT_THROWINGGLOVE")]
    Claw = 47,

    /// <summary>Knuckle.</summary>
    [Label("WT_KNUCKLE")]
    Knuckle = 48,

    /// <summary>Gun.</summary>
    [Label("WT_GUN")]
    Gun = 49,
}
