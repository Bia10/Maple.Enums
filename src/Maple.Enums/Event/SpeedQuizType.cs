using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Speed quiz question category types.
/// </summary>
public enum SpeedQuizType : byte
{
    /// <summary>NPC name category.</summary>
    [Label("TYPE_SPEED_QUIZ_NPC")]
    Npc = 0,

    /// <summary>Monster name category.</summary>
    [Label("TYPE_SPEED_QUIZ_MOB")]
    Mob = 1,

    /// <summary>Item name category.</summary>
    [Label("TYPE_SPEED_QUIZ_ITEM")]
    Item = 2,
}
