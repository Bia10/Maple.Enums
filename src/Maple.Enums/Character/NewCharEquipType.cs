using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// New character equipment selection type.
/// Classifies the customization slots during character creation.
/// </summary>
public enum NewCharEquipType : byte
{
    /// <summary>Face appearance selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_FACE")]
    Face = 0,

    /// <summary>Hair style selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_HAIRSTYLE")]
    [Label("Hair Style", 1)]
    HairStyle = 1,

    /// <summary>Hair color selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_HAIRCOLOR")]
    [Label("Hair Color", 1)]
    HairColor = 2,

    /// <summary>Skin color selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_SKINCOLOR")]
    [Label("Skin Color", 1)]
    SkinColor = 3,

    /// <summary>Top/shirt clothing selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_CLOTHES")]
    Clothes = 4,

    /// <summary>Bottom/pants clothing selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_PANTS")]
    Pants = 5,

    /// <summary>Shoe/footwear selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_SHOES")]
    Shoes = 6,

    /// <summary>Starting weapon selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_WEAPON")]
    Weapon = 7,

    /// <summary>Character gender selection.</summary>
    [Label("NEWCHAR_EQUIP_TYPE_GENDER")]
    Gender = 8,
}
