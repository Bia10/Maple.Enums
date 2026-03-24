namespace Maple.Enums;

/// <summary>
/// Enchant scroll category bitmask.
/// Stored in equip item info/enchantCategory WZ node.
/// Controls which type of enhancement scroll can be applied to the item.
/// Used as a bitmask: NORMAL | VISITOR is valid. Max 0x02 fits in byte.
/// </summary>
[Flags]
public enum ItemEnchantCategory : byte
{
    /// <summary>No enchant category.</summary>
    None = 0,

    /// <summary>Standard upgrade scrolls.</summary>
    Normal = 0x1,

    /// <summary>Visitor-only scrolls.</summary>
    Visitor = 0x2,
}
