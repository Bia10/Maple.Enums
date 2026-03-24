using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Source of an equipment modification (scroll, user drag, dragon/mechanic auto-equip, pet equip).
/// </summary>
public enum ModifyEquipType : byte
{
    /// <summary>Equipped via enchant scroll or skill.</summary>
    [Label("MODIFYEQUIPTYPE_ENCHANTSKILL")]
    [Label("Enchant Skill", 1)]
    EnchantSkill = 0,

    /// <summary>Equipped manually by the user (drag-and-drop).</summary>
    [Label("MODIFYEQUIPTYPE_USER")]
    User = 1,

    /// <summary>Auto-equipped by Evan's Dragon.</summary>
    [Label("MODIFYEQUIPTYPE_DRAGON")]
    Dragon = 2,

    /// <summary>Auto-equipped by Mechanic.</summary>
    [Label("MODIFYEQUIPTYPE_MECHANIC")]
    Mechanic = 3,

    /// <summary>Equipped as a pet equip item.</summary>
    [Label("MODIFYEQUIPTYPE_PETEQUIP")]
    [Label("Pet Equip", 1)]
    PetEquip = 4,
}
