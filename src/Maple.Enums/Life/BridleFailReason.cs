using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Reason a bridle (spirit item) activation failed.
/// </summary>
public enum BridleFailReason : byte
{
    /// <summary>Mob HP too high to capture.</summary>
    [Label("BRIDLE_FAIL_HP")]
    Hp = 0,

    /// <summary>Capture cooldown active.</summary>
    [Label("BRIDLE_FAIL_DELAY")]
    Delay = 1,
}
