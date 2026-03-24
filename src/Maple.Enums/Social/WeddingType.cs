using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Wedding ceremony venue types.
/// </summary>
public enum WeddingType : byte
{
    /// <summary>Cathedral wedding.</summary>
    [Label("WT_CATHEDRAL")]
    Cathedral = 1,

    /// <summary>Vegas chapel wedding.</summary>
    [Label("WT_VEGAS")]
    Vegas = 2,

    /// <summary>Premium cathedral wedding.</summary>
    [Label("WT_CATHEDRAL_PREMIUM")]
    [Label("Cathedral Premium", 1)]
    CathedralPremium = 10,

    /// <summary>Normal cathedral wedding.</summary>
    [Label("WT_CATHEDRAL_NORMAL")]
    [Label("Cathedral Normal", 1)]
    CathedralNormal = 11,

    /// <summary>Premium Vegas wedding.</summary>
    [Label("WT_VEGAS_PREMIUM")]
    [Label("Vegas Premium", 1)]
    VegasPremium = 20,

    /// <summary>Normal Vegas wedding.</summary>
    [Label("WT_VEGAS_NORMAL")]
    [Label("Vegas Normal", 1)]
    VegasNormal = 21,
}
