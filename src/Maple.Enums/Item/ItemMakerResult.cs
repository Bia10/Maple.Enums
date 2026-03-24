using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item maker (crafting) result codes.
/// </summary>
public enum ItemMakerResult : byte
{
    /// <summary>Crafting succeeded.</summary>
    [Label("ITEM_MAKER_RESULT_SUCCESS")]
    Success = 0,

    /// <summary>Item destroyed on craft.</summary>
    [Label("ITEM_MAKER_RESULT_DESTROYED")]
    Destroyed = 1,

    /// <summary>Unknown error.</summary>
    [Label("ITEM_MAKER_ERR_UNKNOWN")]
    [Label("Err Unknown", 1)]
    ErrUnknown = 2,

    /// <summary>No inventory space.</summary>
    [Label("ITEM_MAKER_ERR_EMPTYSLOT")]
    [Label("Err Empty Slot", 1)]
    ErrEmptySlot = 3,

    /// <summary>No equip slot space.</summary>
    [Label("ITEM_MAKER_ERR_EMPTYSLOT_EQUIP")]
    [Label("Err Empty Slot Equip", 1)]
    ErrEmptySlotEquip = 4,

    /// <summary>No consume slot space.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("ITEM_MAKER_ERR_EMPTYSLOT_COMSUME")]
    [Label("Err Empty Slot Consume", 1)]
    ErrEmptySlotConsume = 5,

    /// <summary>No setup slot space.</summary>
    [Label("ITEM_MAKER_ERR_EMPTYSLOT_INSTALL")]
    [Label("Err Empty Slot Install", 1)]
    ErrEmptySlotInstall = 6,

    /// <summary>No etc slot space.</summary>
    [Label("ITEM_MAKER_ERR_EMPTYSLOT_ETC")]
    [Label("Err Empty Slot Etc", 1)]
    ErrEmptySlotEtc = 7,
}
