using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Background tile/scroll animation type as stored in Map.wz Back layer nodes.
/// </summary>
public enum BackgroundType : byte
{
    /// <summary>Static, non-scrolling background.</summary>
    Static = 0,

    /// <summary>Horizontally scrolling background.</summary>
    [Label("Horizontal Scroll", 1)]
    HScroll = 1,

    /// <summary>Vertically scrolling background.</summary>
    [Label("Vertical Scroll", 1)]
    VScroll = 2,

    /// <summary>Horizontal tile (no scroll).</summary>
    [Label("Horizontal Tile", 1)]
    HTile = 3,

    /// <summary>Vertical tile (no scroll).</summary>
    [Label("Vertical Tile", 1)]
    VTile = 4,

    /// <summary>Horizontal+vertical tile (no scroll).</summary>
    [Label("Horizontal+Vertical Tile", 1)]
    HVTile = 5,

    /// <summary>Horizontal tile with scroll.</summary>
    [Label("Horizontal Tile Scroll", 1)]
    HTileScroll = 6,

    /// <summary>Vertical tile with scroll.</summary>
    [Label("Vertical Tile Scroll", 1)]
    VTileScroll = 7,
}
