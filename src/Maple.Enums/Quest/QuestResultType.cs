using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Quest result code sent by the server (success, failure reasons, timer control).</summary>
public enum QuestResultType : byte
{
    /// <summary>Start quest countdown timer.</summary>
    [Label("Start Quest Timer", 1)]
    StartQuestTimer = 6,

    /// <summary>End quest countdown timer.</summary>
    [Label("End Quest Timer", 1)]
    EndQuestTimer = 7,

    /// <summary>Start persistent quest timer.</summary>
    [Label("Start Time Keep Quest Timer", 1)]
    StartTimeKeepQuestTimer = 8,

    /// <summary>End persistent quest timer.</summary>
    [Label("End Time Keep Quest Timer", 1)]
    EndTimeKeepQuestTimer = 9,

    /// <summary>Quest action succeeded.</summary>
    Success = 10,

    /// <summary>Failed for unknown reason.</summary>
    [Label("Failed Unknown", 1)]
    FailedUnknown = 11,

    /// <summary>Inventory space insufficient.</summary>
    [Label("Failed Inventory", 1)]
    FailedInventory = 12,

    /// <summary>Insufficient meso currency.</summary>
    [Label("Failed Meso", 1)]
    FailedMeso = 13,

    /// <summary>Pet requirement not met.</summary>
    [Label("Failed Pet", 1)]
    FailedPet = 14,

    /// <summary>Equipped item conflict.</summary>
    [Label("Failed Equipped", 1)]
    FailedEquipped = 15,

    /// <summary>Unique item already owned.</summary>
    [Label("Failed Only Item", 1)]
    FailedOnlyItem = 16,

    /// <summary>Quest timer expired.</summary>
    [Label("Failed Time Over", 1)]
    FailedTimeOver = 17,

    /// <summary>Reset quest countdown timer.</summary>
    [Label("Reset Quest Timer", 1)]
    ResetQuestTimer = 18,
}
