using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Terrain type that a mob can traverse.
/// </summary>
public enum MovableTerrainType : byte
{
    /// <summary>Land/ground terrain only.</summary>
    [Label("MOVABLE_EARTH")]
    Earth = 0,

    /// <summary>Water terrain only.</summary>
    [Label("MOVABLE_WATER")]
    Water = 1,

    /// <summary>Both land and water terrain.</summary>
    [Label("MOVABLE_BOTH")]
    Both = 2,
}
