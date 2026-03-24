using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item stat variation option.
/// </summary>
public enum ItemVariationOption : byte
{
    /// <summary>No variation.</summary>
    [Label("ITEMVARIATION_NONE")]
    None = 0,

    /// <summary>Above-average stats.</summary>
    [Label("ITEMVARIATION_BETTER")]
    Better = 1,

    /// <summary>Standard stats.</summary>
    [Label("ITEMVARIATION_NORMAL")]
    Normal = 2,

    /// <summary>High-quality stats.</summary>
    [Label("ITEMVARIATION_GREAT")]
    Great = 3,

    /// <summary>Maximum stats.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("ITEMVARIATION_PERPECT")]
    Perfect = 4,

    /// <summary>Gachapon bonus stats.</summary>
    [Label("ITEMVARIATION_GACHAPON")]
    Gachapon = 5,
}
