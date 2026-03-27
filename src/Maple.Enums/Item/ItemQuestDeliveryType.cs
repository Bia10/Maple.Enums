using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest stage that a delivery item is associated with.
/// </summary>
public enum ItemQuestDeliveryType : byte
{
    /// <summary>
    /// Item is used to accept a delivery quest that has not yet been started.
    /// </summary>
    [Label("Accept", 1)]
    Accept = 0,

    /// <summary>
    /// Item is used to complete a delivery quest that is already in progress.
    /// </summary>
    [Label("Complete", 1)]
    Complete = 1,
}
