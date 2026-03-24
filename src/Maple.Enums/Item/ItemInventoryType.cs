using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Inventory tab type.
/// </summary>
public enum ItemInventoryType : byte
{
    /// <summary>Equipment tab.</summary>
    [Label("IT_EQUIP")]
    Equip = 1,

    /// <summary>Use items tab.</summary>
    [Label("IT_CONSUME")]
    Consume = 2,

    /// <summary>Setup items tab.</summary>
    [Label("IT_INSTALL")]
    Install = 3,

    /// <summary>Etc items tab.</summary>
    [Label("IT_ETC")]
    Etc = 4,

    /// <summary>Cash items tab.</summary>
    [Label("IT_CASH")]
    Cash = 5,
}
