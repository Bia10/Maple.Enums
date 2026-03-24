using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Special set item effect type.
/// </summary>
public enum SpecialSetEffect : int
{
    /// <summary>Visitor cube effect.</summary>
    [Label("SPECIAL_SET_EFFECT_VISITOR_CUBE")]
    [Label("Visitor Cube", 1)]
    VisitorCube = 10000,
}
