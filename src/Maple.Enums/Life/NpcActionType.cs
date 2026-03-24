using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// NPC animation action type.
/// </summary>
public enum NpcActionType : byte
{
    /// <summary>NPC movement animation.</summary>
    [Label("NPCACT_MOVE")]
    Move = 0,

    /// <summary>NPC standing/idle animation.</summary>
    [Label("NPCACT_STAND")]
    Stand = 1,
}
