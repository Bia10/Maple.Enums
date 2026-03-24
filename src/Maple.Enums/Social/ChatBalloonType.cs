using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Chat balloon display types.
/// </summary>
public enum ChatBalloonType : ushort
{
    /// <summary>Player chat bubble.</summary>
    [Label("CHATBALLOON_CHARACTER")]
    Character = 1000,

    /// <summary>NPC chat bubble.</summary>
    [Label("CHATBALLOON_NPC")]
    Npc = 1001,

    /// <summary>Pet chat bubble.</summary>
    [Label("CHATBALLOON_PET")]
    Pet = 1002,

    /// <summary>Ad-board bubble.</summary>
    [Label("CHATBALLOON_ADBOARD")]
    [Label("Ad Board", 1)]
    AdBoard = 1003,

    /// <summary>Mob speech bubble.</summary>
    [Label("CHATBALLOON_MOB")]
    Mob = 1004,

    /// <summary>Full-screen text.</summary>
    [Label("CHATBALLOON_SCREEN")]
    Screen = 1005,
}
