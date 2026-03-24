using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Gachapon UI message types.
/// </summary>
public enum GachaponMessageType : byte
{
    /// <summary>No incubator item found.</summary>
    [Label("GACHAPON_MSGTYPE_NOINCUBATOR")]
    [Label("No Incubator", 1)]
    NoIncubator = 0,

    /// <summary>No item to dispense.</summary>
    [Label("GACHAPON_MSGTYPE_NOITEM")]
    [Label("No Item", 1)]
    NoItem = 1,

    /// <summary>Gachapon not open.</summary>
    [Label("GACHAPON_MSGTYPE_NOTOPENGACHAPON")]
    [Label("Not Open Gachapon", 1)]
    NotOpenGachapon = 2,

    /// <summary>Currently incubating.</summary>
    [Label("GACHAPON_MSGTYPE_INCUBATING")]
    Incubating = 3,

    /// <summary>Dispense succeeded.</summary>
    [Label("GACHAPON_MSGTYPE_SUCCESS")]
    Success = 4,

    /// <summary>Generic refusal.</summary>
    [Label("GACHAPON_MSGTYPE_NO")]
    No = 5,
}
