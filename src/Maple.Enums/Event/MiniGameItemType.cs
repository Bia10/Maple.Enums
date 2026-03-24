using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini-game item slot type used in Omok / Memory Game mini-rooms.
/// </summary>
public enum MiniGameItemType : byte
{
    /// <summary>No mini-game item.</summary>
    [Label("MGIT_NONE")]
    None = 0,

    /// <summary>Omok (Five-in-a-Row) game piece.</summary>
    [Label("MGIT_OMOK")]
    Omok = 1,

    /// <summary>Memory/match card game piece.</summary>
    [Label("MGIT_MEMORYGAME")]
    [Label("Memory Game", 1)]
    MemoryGame = 2,
}
