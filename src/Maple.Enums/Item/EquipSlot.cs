using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// WZ inventory bag slot position index for equipped items.
/// Label index 2 carries the sISlot WZ string code (e.g. "Cp", "Wp").
/// Ring1 and Ring2 share the same WZ code "Ri" — the client distinguishes by slot index, not code.
/// </summary>
public enum EquipSlot : byte
{
    /// <summary>Hat/helmet.</summary>
    [Label("Cp", 2)]
    Cap = 1,

    /// <summary>Face accessory.</summary>
    [Label("Fa", 2)]
    FaceAcc = 2,

    /// <summary>Earring.</summary>
    [Label("Er", 2)]
    Earring = 3,

    /// <summary>Eye accessory.</summary>
    [Label("Ay", 2)]
    EyeAcc = 4,

    /// <summary>Top/overall.</summary>
    [Label("Ma", 2)]
    Coat = 5,

    /// <summary>Bottom.</summary>
    [Label("Pn", 2)]
    Pants = 6,

    /// <summary>Footwear.</summary>
    [Label("Sh", 2)]
    Shoes = 7,

    /// <summary>Shield/secondary.</summary>
    [Label("Su", 2)]
    Shield = 9,

    /// <summary>Weapon.</summary>
    [Label("Wp", 2)]
    Weapon = 10,

    /// <summary>Cape.</summary>
    [Label("Sr", 2)]
    Cape = 11,

    /// <summary>First ring.</summary>
    [Label("Ri", 2)]
    Ring1 = 12,

    /// <summary>Second ring.</summary>
    [Label("Ri", 2)]
    Ring2 = 13,

    /// <summary>Pendant.</summary>
    [Label("Pe", 2)]
    Pendant = 15,

    /// <summary>Gloves.</summary>
    [Label("Glv", 2)]
    Gloves = 17,

    /// <summary>Medal.</summary>
    [Label("Me", 2)]
    Medal = 49,

    /// <summary>Belt.</summary>
    [Label("Be", 2)]
    Belt = 50,
}
