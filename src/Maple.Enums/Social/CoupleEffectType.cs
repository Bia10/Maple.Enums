using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Couple/friendship/wedding ring effect visibility types.
/// </summary>
public enum CoupleEffectType : byte
{
    /// <summary>No ring effect.</summary>
    [Label("COUPLE_EFFECT_NONE")]
    None = 0,

    /// <summary>Visible only to couple.</summary>
    [Label("COUPLE_EFFECT_PRIVATE")]
    Private = 1,

    /// <summary>Visible to everyone.</summary>
    [Label("COUPLE_EFFECT_COMMON")]
    Common = 2,
}
