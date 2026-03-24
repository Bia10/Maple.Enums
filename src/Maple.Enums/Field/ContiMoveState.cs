using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Continental move (ship/transport) state machine.
/// Value 2 is unused in V95 — gap between Wait (1) and Move (3) matches the client.
/// </summary>
public enum ContiMoveState : byte
{
    /// <summary>Ship inactive.</summary>
    Dormant = 0,

    /// <summary>Waiting for passengers.</summary>
    Wait = 1,

    /// <summary>Ship in transit.</summary>
    Move = 3,

    /// <summary>Mob spawn event active.</summary>
    [Label("Mob Spawn", 1)]
    Event = 4,
}
