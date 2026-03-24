using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Login authentication option/restriction codes returned after auth check.
/// </summary>
public enum AuthOptionCode : int
{
    /// <summary>No restriction.</summary>
    [Label("AuthOption_NoOption")]
    [Label("No Option", 1)]
    NoOption = 0,

    /// <summary>Login not allowed.</summary>
    [Label("AuthOption_NotAllowed")]
    [Label("Not Allowed", 1)]
    NotAllowed = 1,

    /// <summary>Max connections reached.</summary>
    [Label("AuthOption_MaxConnected")]
    [Label("Max Connected", 1)]
    MaxConnected = 2,

    /// <summary>Account expired.</summary>
    [Label("AuthOption_Expired")]
    Expired = 3,

    /// <summary>Welcome address prompt.</summary>
    [Label("AuthOption_WelcomeAddress")]
    [Label("Welcome Address", 1)]
    WelcomeAddress = 11,

    /// <summary>Trial account welcome.</summary>
    [Label("AuthOption_WelcomeTrial")]
    [Label("Welcome Trial", 1)]
    WelcomeTrial = 13,

    /// <summary>Prepaid time exhausted.</summary>
    [Label("AuthOption_PrepaidExhausted")]
    [Label("Prepaid Exhausted", 1)]
    PrepaidExhausted = 19,

    /// <summary>Outside allowed hours.</summary>
    [Label("AuthOption_NotAvailableTime")]
    [Label("Not Available Time", 1)]
    NotAvailableTime = 25,

    /// <summary>IP mismatch blocked.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("AuthOption_DiffrentIPNotAllowed")]
    [Label("Different Ip Not Allowed", 1)]
    DifferentIpNotAllowed = 27,

    /// <summary>Machine ID blocked.</summary>
    [Label("AuthOption_AccountMachineIDBlocked")]
    [Label("Account Machine Id Blocked", 1)]
    AccountMachineIdBlocked = 28,
}
