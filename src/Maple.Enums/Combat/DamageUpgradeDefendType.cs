using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// How scroll upgrade modifies defense — percent vs. no modification.
/// </summary>
public enum DamageUpgradeDefendType : byte
{
    /// <summary>No modification applied.</summary>
    [Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_DEFEND_ERROR")]
    Error = 0,

    /// <summary>Percent defense bonus.</summary>
    [Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_DEFEND_PERCENT")]
    Percent = 1,
}
