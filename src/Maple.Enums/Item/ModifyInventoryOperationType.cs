using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Inventory modification operation sent in inventory update packets.</summary>
public enum ModifyInventoryOperationType : byte
{
    /// <summary>Add a new item to the inventory.</summary>
    Add = 0,

    /// <summary>Update the stack quantity of an existing item.</summary>
    [Label("Update Quantity", 1)]
    UpdateQuantity = 1,

    /// <summary>Move an item to a different inventory slot.</summary>
    Move = 2,

    /// <summary>Remove an item from the inventory.</summary>
    Remove = 3,

    /// <summary>Update the EXP value on an item (e.g. crush ring).</summary>
    [Label("Update EXP", 1)]
    UpdateEXP = 4,
}
