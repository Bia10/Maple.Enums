using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Chat group types for group messaging.
/// </summary>
public enum ChatGroupType : byte
{
    /// <summary>Friend chat.</summary>
    [Label("CG_Friend")]
    Friend = 0,

    /// <summary>Party chat.</summary>
    [Label("CG_Party")]
    Party = 1,

    /// <summary>Guild chat.</summary>
    [Label("CG_Guild")]
    Guild = 2,

    /// <summary>Alliance chat.</summary>
    [Label("CG_Alliance")]
    Alliance = 3,

    /// <summary>Couple ring chat.</summary>
    [Label("CG_Couple")]
    Couple = 4,

    /// <summary>Message to couple.</summary>
    [Label("CG_ToCouple")]
    [Label("To Couple", 1)]
    ToCouple = 5,

    /// <summary>Expedition chat.</summary>
    [Label("CG_Expedition")]
    Expedition = 6,
}
