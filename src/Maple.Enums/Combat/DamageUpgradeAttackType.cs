using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// How scroll upgrade modifies attack damage — absolute bonus vs. no modification.
/// </summary>
public enum DamageUpgradeAttackType : byte
{
    /// <summary>No modification applied.</summary>
    [Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_ATTACK_ERROR")]
    Error = 0,

    /// <summary>Flat attack bonus.</summary>
    [Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_ATTACK_ABSOLUTE")]
    Absolute = 1,
}
