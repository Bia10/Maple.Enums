using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Item potential option applicability filter (weapon, armor, accessory, etc.).</summary>
public enum ItemOptionType : byte
{
    /// <summary>Any equipment.</summary>
    [Label("Any Equip", 1)]
    AnyEquip = 0,

    /// <summary>Any weapon.</summary>
    [Label("Any Weapon", 1)]
    AnyWeapon = 10,

    /// <summary>Armor or accessory.</summary>
    [Label("Any Armor or Accessory", 1)]
    AnyArmorOrAccessory = 11,

    /// <summary>Armor or shield.</summary>
    [Label("Any Armor or Shield", 1)]
    AnyArmorOrShield = 20,

    /// <summary>Any accessory.</summary>
    [Label("Any Accessory", 1)]
    AnyAccessory = 40,

    /// <summary>Any hat.</summary>
    [Label("Any Cap", 1)]
    AnyCap = 51,

    /// <summary>Any top.</summary>
    [Label("Any Coat", 1)]
    AnyCoat = 52,

    /// <summary>Any bottom.</summary>
    [Label("Any Pants", 1)]
    AnyPants = 53,

    /// <summary>Any gloves.</summary>
    [Label("Any Gloves", 1)]
    AnyGloves = 54,

    /// <summary>Any shoes.</summary>
    [Label("Any Shoe", 1)]
    AnyShoe = 55,

    /// <summary>Accessory except belt.</summary>
    [Label("Any Accessory Not Belt", 1)]
    AnyAccessoryNotBelt = 90,
}
