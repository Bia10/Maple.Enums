using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Claim (report/sue) result codes.
/// </summary>
public enum ClaimResult : byte
{
    /// <summary>Report filed successfully.</summary>
    [Label("ClaimRes_Success")]
    Success = 1,

    /// <summary>Sender notified of success.</summary>
    [Label("ClaimRes_Success_Sender")]
    [Label("Success Sender", 1)]
    SuccessSender = 2,

    /// <summary>Target notified of report.</summary>
    [Label("ClaimRes_Success_Target")]
    [Label("Success Target", 1)]
    SuccessTarget = 3,

    /// <summary>Report failed.</summary>
    [Label("ClaimRes_Fail")]
    Fail = 64,

    /// <summary>Unknown failure.</summary>
    [Label("ClaimRes_Fail_Unknown")]
    [Label("Fail Unknown", 1)]
    FailUnknown = 65,

    /// <summary>Invalid target character.</summary>
    [Label("ClaimRes_Fail_InvalidCharacter")]
    [Label("Fail Invalid Character", 1)]
    FailInvalidCharacter = 66,

    /// <summary>Insufficient mesos for report.</summary>
    [Label("ClaimRes_Fail_NotEnoughMoney")]
    [Label("Fail Not Enough Money", 1)]
    FailNotEnoughMoney = 67,

    /// <summary>Target not online.</summary>
    [Label("ClaimRes_Fail_NotConnected")]
    [Label("Fail Not Connected", 1)]
    FailNotConnected = 68,

    /// <summary>Daily report limit reached.</summary>
    [Label("ClaimRes_Fail_OverLimit")]
    [Label("Fail Over Limit", 1)]
    FailOverLimit = 69,

    /// <summary>Weekly report limit reached.</summary>
    [Label("ClaimRes_Fail_OverWeeklyLimit")]
    [Label("Fail Over Weekly Limit", 1)]
    FailOverWeeklyLimit = 70,

    /// <summary>Feature unavailable.</summary>
    [Label("ClaimRes_Fail_UnAvailable")]
    [Label("Fail Un Available", 1)]
    FailUnAvailable = 71,

    /// <summary>False report penalty.</summary>
    [Label("ClaimRes_Fail_Liar")]
    [Label("Fail Liar", 1)]
    FailLiar = 72,
}
