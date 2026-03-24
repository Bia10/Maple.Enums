using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Popularity/fame change result.
/// Result codes when giving fame to another player.
/// </summary>
public enum GivePopularityResult : sbyte
{
    /// <summary>Unknown error.</summary>
    [Label("GivePopularityRes_UnknownError")]
    [Label("Unknown Error", 1)]
    UnknownError = -1,

    /// <summary>Fame given successfully.</summary>
    [Label("GivePopularityRes_Success")]
    Success = 0,

    /// <summary>Invalid target character.</summary>
    [Label("GivePopularityRes_InvalidCharacterID")]
    [Label("Invalid Character Id", 1)]
    InvalidCharacterId = 1,

    /// <summary>Level too low.</summary>
    [Label("GivePopularityRes_LevelLow")]
    [Label("Level Low", 1)]
    LevelLow = 2,

    /// <summary>Already famed today.</summary>
    [Label("GivePopularityRes_AlreadyDoneToday")]
    [Label("Already Done Today", 1)]
    AlreadyDoneToday = 3,

    /// <summary>Already famed this target.</summary>
    [Label("GivePopularityRes_AlreadyDoneTarget")]
    [Label("Already Done Target", 1)]
    AlreadyDoneTarget = 4,

    /// <summary>Fame notification.</summary>
    [Label("GivePopularityRes_Notify")]
    Notify = 5,
}
