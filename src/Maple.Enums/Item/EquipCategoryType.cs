using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Equipment category types for equip slots.
/// </summary>
public enum EquipCategoryType : byte
{
    /// <summary>Hat/helmet slot.</summary>
    [Label("EQUIP_TYPE_CAP")]
    Cap = 0,

    /// <summary>Face accessory slot.</summary>
    [Label("EQUIP_TYPE_FACEACC")]
    [Label("Face Accessory", 1)]
    FaceAccessory = 1,

    /// <summary>Eye accessory slot.</summary>
    [Label("EQUIP_TYPE_EYEACC")]
    [Label("Eye Accessory", 1)]
    EyeAccessory = 2,

    /// <summary>Earring slot.</summary>
    [Label("EQUIP_TYPE_EARACC")]
    [Label("Ear Accessory", 1)]
    EarAccessory = 3,

    /// <summary>Top armor slot.</summary>
    [Label("EQUIP_TYPE_SHIRT")]
    Shirt = 4,

    /// <summary>Overall armor slot.</summary>
    [Label("EQUIP_TYPE_COAT")]
    Coat = 5,

    /// <summary>Bottom armor slot.</summary>
    [Label("EQUIP_TYPE_PANTS")]
    Pants = 6,

    /// <summary>Footwear slot.</summary>
    [Label("EQUIP_TYPE_SHOES")]
    Shoes = 7,

    /// <summary>Gloves slot.</summary>
    [Label("EQUIP_TYPE_GLOVES")]
    Gloves = 8,

    /// <summary>Shield/secondary slot.</summary>
    [Label("EQUIP_TYPE_SHIELD")]
    Shield = 9,

    /// <summary>Cape slot.</summary>
    [Label("EQUIP_TYPE_CAPE")]
    Cape = 10,

    /// <summary>Ring slot.</summary>
    [Label("EQUIP_TYPE_RING")]
    Ring = 11,

    /// <summary>Pendant slot.</summary>
    [Label("EQUIP_TYPE_PENDANT")]
    Pendant = 12,

    /// <summary>Belt slot.</summary>
    [Label("EQUIP_TYPE_BELT")]
    Belt = 13,
}
