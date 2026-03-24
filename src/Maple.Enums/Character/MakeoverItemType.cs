using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Makeover kit item type / category slot.
/// </summary>
public enum MakeoverItemType : byte
{
    /// <summary>Face change.</summary>
    [Label("MKT_FACE")]
    Face = 0,

    /// <summary>Hairstyle change.</summary>
    [Label("MKT_HAIR")]
    Hair = 1,

    /// <summary>Hair color change.</summary>
    [Label("MKT_HAIRCOLOR")]
    [Label("Hair Color", 1)]
    HairColor = 2,

    /// <summary>Skin color change.</summary>
    [Label("MKT_SKIN")]
    Skin = 3,

    /// <summary>Top change.</summary>
    [Label("MKT_CLOTHES")]
    Clothes = 4,

    /// <summary>Bottom change.</summary>
    [Label("MKT_PANTS")]
    Pants = 5,

    /// <summary>Shoes change.</summary>
    [Label("MKT_SHOES")]
    Shoes = 6,

    /// <summary>Weapon change.</summary>
    [Label("MKT_WEAPON")]
    Weapon = 7,

    /// <summary>Gender change.</summary>
    [Label("MKT_GENDER")]
    Gender = 8,
}
