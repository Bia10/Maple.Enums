using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Elemental resistance tier stored per element in mob aDamagedElemAttr[].
/// </summary>
public enum ElemResistanceTier : byte
{
    /// <summary>Normal damage (100%).</summary>
    [Label("ELEMENT_ATTR_NONE")]
    [Label("Normal", 1)]
    [Label("100%", 2)]
    None = 0,

    /// <summary>Complete immunity (0%).</summary>
    [Label("ELEMENT_ATTR_DAMAGE0")]
    [Label("Immune", 1)]
    [Label("0%", 2)]
    Immune = 1,

    /// <summary>Half damage (50%).</summary>
    [Label("ELEMENT_ATTR_DAMAGE50")]
    [Label("Resistant", 1)]
    [Label("50%", 2)]
    Resistant = 2,

    /// <summary>Extra damage (150%).</summary>
    [Label("ELEMENT_ATTR_DAMAGE150")]
    [Label("Weak", 1)]
    [Label("150%", 2)]
    Weak = 3,
}
