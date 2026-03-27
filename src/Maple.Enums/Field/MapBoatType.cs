using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Type of ferry used in continental-move (transit) maps.
/// Sourced from <c>CShip.m_nShipKind</c> / WZ <c>ship/shipKind</c>.
/// </summary>
public enum MapBoatType : byte
{
    /// <summary>
    /// No ship; the map does not use a boat transport.
    /// Default when the WZ <c>ship/shipKind</c> field is absent.
    /// </summary>
    None = 0,

    /// <summary>
    /// Standard ferry; boards automatically when the player enters the transit field.
    /// </summary>
    [Label("Regular Ferry", 1)]
    Regular = 1,

    /// <summary>
    /// Premium ferry that physically appears and departs on a timed schedule.
    /// </summary>
    [Label("Premium Ferry", 1)]
    Premium = 2,
}
