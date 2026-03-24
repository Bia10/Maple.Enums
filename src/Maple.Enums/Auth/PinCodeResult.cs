using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// PIN code verification result codes.
/// </summary>
public enum PinCodeResult : byte
{
    /// <summary>PIN verification succeeded.</summary>
    [Label("PinCodeResCode_Success")]
    Success = 0,

    /// <summary>No PIN has been assigned yet.</summary>
    [Label("PinCodeResCode_NotAssigned")]
    [Label("Not Assigned", 1)]
    NotAssigned = 1,

    /// <summary>Entered PIN is incorrect.</summary>
    [Label("PinCodeResCode_Incorrect")]
    Incorrect = 2,

    /// <summary>Database error during PIN check.</summary>
    [Label("PinCodeResCode_DBFail")]
    [Label("Db Fail", 1)]
    DbFail = 3,

    /// <summary>PIN has already been assigned.</summary>
    [Label("PinCodeResCode_Assigned")]
    Assigned = 4,

    // 0x5, 0x6 reserved/unused in V95.

    /// <summary>Account is already connected elsewhere.</summary>
    [Label("PinCodeResCode_AlreadyConnected")]
    [Label("Already Connected", 1)]
    AlreadyConnected = 7,
}
