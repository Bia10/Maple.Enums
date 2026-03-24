using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// MapleStory element index.
/// Used for skill nAttackElemAttr and mob aDamagedElemAttr[] array indices.
/// </summary>
public enum Element : byte
{
    /// <summary>Physical (non-elemental).</summary>
    /// <remarks>Label index 4 is the null character — WZ uses '\0' for the physical (no-element) code.</remarks>
    [Label("ELEMENT_PHYSICAL")]
    [Label("P", 2)]
    [Label("p", 3)]
    [Label("\0", 4)]
    Physical = 0,

    /// <summary>Ice element.</summary>
    [Label("ELEMENT_ICE")]
    [Label("I", 2)]
    [Label("i", 3)]
    Ice = 1,

    /// <summary>Fire element.</summary>
    [Label("ELEMENT_FIRE")]
    [Label("F", 2)]
    [Label("f", 3)]
    Fire = 2,

    /// <summary>Lightning element.</summary>
    [Label("ELEMENT_LIGHT")]
    [Label("L", 2)]
    [Label("l", 3)]
    Light = 3,

    /// <summary>Poison element.</summary>
    [Label("ELEMENT_POISON")]
    [Label("S", 2)]
    [Label("s", 3)]
    Poison = 4,

    /// <summary>Holy element.</summary>
    [Label("ELEMENT_HOLY")]
    [Label("H", 2)]
    [Label("h", 3)]
    Holy = 5,

    /// <summary>Dark element.</summary>
    [Label("ELEMENT_DARK")]
    [Label("D", 2)]
    [Label("d", 3)]
    Dark = 6,

    /// <summary>Undead element.</summary>
    [Label("ELEMENT_UNDEAD")]
    [Label("U", 2)]
    [Label("u", 3)]
    Undead = 7,
}
