using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Continental move (ship/transport) map target identifier.</summary>
public enum ContiMoveTarget : byte
{
    /// <summary>Departure station map.</summary>
    [Label("Start Field", 1)]
    StartField = 7,

    /// <summary>Boarding vessel map.</summary>
    [Label("Start Ship Move Field", 1)]
    StartShipMoveField = 8,

    /// <summary>Waiting area map.</summary>
    [Label("Wait Field", 1)]
    WaitField = 9,

    /// <summary>In-transit vessel map.</summary>
    [Label("Move Field", 1)]
    MoveField = 10,

    /// <summary>Arrival station map.</summary>
    [Label("End Field", 1)]
    EndField = 11,

    /// <summary>Disembark vessel map.</summary>
    [Label("End Ship Move Field", 1)]
    EndShipMoveField = 12,
}
