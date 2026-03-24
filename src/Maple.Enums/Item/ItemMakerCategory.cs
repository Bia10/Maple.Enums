using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item Maker crafting category code.
/// </summary>
public enum ItemMakerCategory : ushort
{
    /// <summary>Consumable crafting.</summary>
    [Label("ITEM_CATEGORY_CONSUME")]
    Consume = 200,

    /// <summary>Setup item crafting.</summary>
    [Label("ITEM_CATEGORY_INSTALL")]
    Install = 300,

    /// <summary>Etc item crafting.</summary>
    [Label("ITEM_CATEGORY_ETC")]
    Etc = 400,

    /// <summary>Strengthen gem crafting.</summary>
    [Label("ITEM_CATEGORY_STRENGTHEN_GEM")]
    [Label("Strengthen Gem", 1)]
    StrengthenGem = 425,

    /// <summary>Monster crystal crafting.</summary>
    [Label("ITEM_CATEGORY_MONSTER_CRYSTAL")]
    [Label("Monster Crystal", 1)]
    MonsterCrystal = 426,

    /// <summary>Hidden recipe.</summary>
    [Label("ITEM_CATEGORY_HIDDEN")]
    Hidden = 999,

    /// <summary>Equip disassembly.</summary>
    [Label("ITEM_CATEGORY_EQUIP_DISASSEMBLE")]
    [Label("Equip Disassemble", 1)]
    EquipDisassemble = 998,

    /// <summary>Catalyst crafting.</summary>
    [Label("ITEM_CATEGORY_CATALYST")]
    Catalyst = 4130,
}
