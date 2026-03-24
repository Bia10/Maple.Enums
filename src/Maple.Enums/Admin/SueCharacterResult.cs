using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Sue (report) character result codes.
/// </summary>
public enum SueCharacterResult : int
{
    /// <summary>Report submitted successfully.</summary>
    [Label("SueCharacterRes_Success")]
    Success = 0,

    /// <summary>Invalid target character.</summary>
    [Label("SueCharacterRes_InvalidCharacterID")]
    [Label("Invalid Character Id", 1)]
    InvalidCharacterId = 1,

    /// <summary>Already reported today.</summary>
    [Label("SueCharacterRes_AlreadyDoneToday")]
    [Label("Already Done Today", 1)]
    AlreadyDoneToday = 2,

    /// <summary>Notification sent to target.</summary>
    [Label("SueCharacterRes_Notify")]
    Notify = 3,

    /// <summary>Unknown error occurred.</summary>
    [Label("SueCharacterRes_UnknownError")]
    [Label("Unknown Error", 1)]
    UnknownError = -1,
}
