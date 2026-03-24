using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Continental move (ship/transport) state machine transition trigger.</summary>
public enum ContiMoveStateTrigger : byte
{
    /// <summary>Player boards ship.</summary>
    Board = 1,

    /// <summary>Ship departs.</summary>
    Start = 2,

    // Value 3 is unused in V95.

    /// <summary>Mobs spawn on ship.</summary>
    [Label("Mob Gen", 1)]
    MobGen = 4,

    /// <summary>Mobs cleared.</summary>
    [Label("Mob Destroy", 1)]
    MobDestroy = 5,

    /// <summary>Ship arrives.</summary>
    End = 6,
}
