using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Type of ferry used in continental-move (transit) maps.
/// </summary>
public enum MapBoatType : byte
{
    /// <summary>
    /// Standard ferry; boards automatically when the player enters the transit field.
    /// </summary>
    [Label("Regular Ferry", 1)]
    Regular = 0,

    /// <summary>
    /// Premium ferry that physically appears and departs on a timed schedule.
    /// </summary>
    [Label("Premium Ferry", 1)]
    Premium = 1,
}
