using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Equipment upgrade (scroll) result logged to the server.
/// </summary>
public enum EquipUpgradeResult : int
{
    /// <summary>Scroll failed, no change.</summary>
    [Label("UpgradeFail")]
    Fail = 0,

    /// <summary>Scroll succeeded.</summary>
    [Label("UpgradeSuccess")]
    Success = 1,

    /// <summary>Scroll destroyed the item.</summary>
    [Label("UpgradeCursed")]
    Cursed = 2,
}
