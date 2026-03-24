using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Login result codes returned by the login server.</summary>
public enum LoginResult : byte
{
    /// <summary>Login successful.</summary>
    Success = 0,

    /// <summary>Temporarily blocked.</summary>
    [Label("Temp Blocked", 1)]
    TempBlocked = 1,

    /// <summary>Account blocked.</summary>
    Blocked = 2,

    /// <summary>Account abandoned.</summary>
    Abandoned = 3,

    /// <summary>Wrong password.</summary>
    [Label("Incorrect Password", 1)]
    IncorrectPassword = 4,

    /// <summary>Account not registered.</summary>
    [Label("Not Registered", 1)]
    NotRegistered = 5,

    /// <summary>Database failure.</summary>
    [Label("DB Fail", 1)]
    DBFail = 6,

    /// <summary>Already logged in.</summary>
    [Label("Already Connected", 1)]
    AlreadyConnected = 7,

    /// <summary>World unavailable.</summary>
    [Label("Not Connectable World", 1)]
    NotConnectableWorld = 8,

    /// <summary>Unknown error.</summary>
    Unknown = 9,

    /// <summary>Connection timed out.</summary>
    Timeout = 10,

    /// <summary>Adult verification needed.</summary>
    [Label("Not Adult", 1)]
    NotAdult = 11,

    /// <summary>Authentication failed.</summary>
    [Label("Auth Fail", 1)]
    AuthFail = 12,

    /// <summary>Blocked IP address.</summary>
    [Label("Impossible IP", 1)]
    ImpossibleIP = 13,

    /// <summary>Unauthorized Nexon ID.</summary>
    [Label("Not Authorized Nexon ID", 1)]
    NotAuthorizedNexonID = 14,

    /// <summary>No Nexon ID linked.</summary>
    [Label("No Nexon ID", 1)]
    NoNexonID = 15,

    /// <summary>Not authorized.</summary>
    [Label("Not Authorized", 1)]
    NotAuthorized = 16,

    /// <summary>Invalid region.</summary>
    [Label("Invalid Region Info", 1)]
    InvalidRegionInfo = 17,

    /// <summary>Invalid birth date.</summary>
    [Label("Invalid Birth Date", 1)]
    InvalidBirthDate = 18,

    /// <summary>Passport suspended.</summary>
    [Label("Passport Suspended", 1)]
    PassportSuspended = 19,

    /// <summary>Wrong secondary password.</summary>
    [Label("Incorrect SPW", 1)]
    IncorrectSPW = 20,

    /// <summary>Web auth required.</summary>
    [Label("Web Auth Needed", 1)]
    WebAuthNeeded = 21,

    /// <summary>Password matches SPW.</summary>
    [Label("Same Password And SPW", 1)]
    SamePasswordAndSPW = 22,

    /// <summary>PIN matches SPW.</summary>
    [Label("Same Pincode And SPW", 1)]
    SamePincodeAndSPW = 23,

    /// <summary>EULA not accepted.</summary>
    [Label("Not Agreed EULA", 1)]
    NotAgreedEULA = 24,

    /// <summary>Registration IP limited.</summary>
    [Label("Register Limited IP", 1)]
    RegisterLimitedIP = 25,

    /// <summary>Character transfer pending.</summary>
    [Label("Requested Character Transfer", 1)]
    RequestedCharacterTransfer = 26,

    /// <summary>Cash user needs full client.</summary>
    [Label("Cash User Cannot Use Simple Client", 1)]
    CashUserCannotUseSimpleClient = 27,

    // Value 28 is unused in the V95 client.

    /// <summary>Delete blocked by family.</summary>
    [Label("Delete Character Failed On Family", 1)]
    DeleteCharacterFailedOnFamily = 29,

    /// <summary>Invalid character name.</summary>
    [Label("Invalid Character Name", 1)]
    InvalidCharacterName = 30,

    /// <summary>Wrong SSN.</summary>
    [Label("Incorrect SSN", 1)]
    IncorrectSSN = 31,

    /// <summary>SSN confirm failed.</summary>
    [Label("SSN Confirm Failed", 1)]
    SSNConfirmFailed = 32,

    /// <summary>SSN not confirmed.</summary>
    [Label("SSN Not Confirmed", 1)]
    SSNNotConfirmed = 33,

    /// <summary>World too busy.</summary>
    [Label("World Too Busy", 1)]
    WorldTooBusy = 34,

    /// <summary>OTP being reissued.</summary>
    [Label("OTP Reissuing", 1)]
    OTPReissuing = 35,

    /// <summary>OTP info missing.</summary>
    [Label("OTP Info Not Exist", 1)]
    OTPInfoNotExist = 36,

    /// <summary>Processing failed.</summary>
    [Label("Proc Fail", 1)]
    ProcFail = 255,
}
