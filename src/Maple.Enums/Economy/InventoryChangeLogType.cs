using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Inventory change log type used by the item change log system.
/// </summary>
public enum InventoryChangeLogType : byte
{
    /// <summary>New item acquired.</summary>
    [Label("ChangeLog_NewItem")]
    [Label("New Item", 1)]
    NewItem = 0,

    /// <summary>Item quantity changed.</summary>
    [Label("ChangeLog_ItemNumber")]
    [Label("Item Number", 1)]
    ItemNumber = 1,

    /// <summary>Item position changed.</summary>
    [Label("ChangeLog_Position")]
    Position = 2,

    /// <summary>Item deleted.</summary>
    [Label("ChangeLog_DelItem")]
    [Label("Del Item", 1)]
    DelItem = 3,

    /// <summary>Item EXP changed.</summary>
    [Label("ChangeLog_EXP")]
    Exp = 4,
}
