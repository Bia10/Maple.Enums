using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item price log source (personal shop vs entrusted shop trades).
/// </summary>
public enum PriceLogSource : byte
{
    /// <summary>No price log source.</summary>
    [Label("PRICELOG_NONE")]
    None = 0,

    /// <summary>Trade originated from a personal shop.</summary>
    [Label("PRICELOG_PERSONALSHOP")]
    [Label("Personal Shop", 1)]
    PersonalShop = 1,

    /// <summary>Trade originated from an entrusted shop.</summary>
    [Label("PRICELOG_ENTRUSTEDSHOP")]
    [Label("Entrusted Shop", 1)]
    EntrustedShop = 2,
}
