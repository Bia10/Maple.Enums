using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item slot type.
/// Low-level item slot classification (equip/bundle/pet). Different from <see cref="ItemInventoryType"/>
/// which classifies inventory tabs (Equip/Consume/Install/Etc/Cash).
/// </summary>
public enum ItemSlotType : byte
{
    /// <summary>Equipment slot.</summary>
    [Label("ITEMSLOTTYPE_EQUIP")]
    Equip = 1,

    /// <summary>Stackable item slot.</summary>
    [Label("ITEMSLOTTYPE_BUNDLE")]
    Bundle = 2,

    /// <summary>Pet item slot.</summary>
    [Label("ITEMSLOTTYPE_PET")]
    Pet = 3,
}
