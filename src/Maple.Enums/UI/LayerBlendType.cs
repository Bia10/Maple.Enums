using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Layer blend mode used by the renderer for sprite / UI layers.
/// </summary>
public enum LayerBlendType : byte
{
    /// <summary>Normal blending.</summary>
    [Label("LB_NORMAL")]
    Normal = 0,

    /// <summary>Additive blending.</summary>
    [Label("LB_ADD")]
    Add = 1,

    /// <summary>Inverse blending.</summary>
    [Label("LB_INVERSE")]
    Inverse = 2,

    /// <summary>Isolated blending.</summary>
    [Label("LB_ISOLATED")]
    Isolated = 4,
}
