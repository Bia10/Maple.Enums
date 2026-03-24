using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Reactor draw layer.
/// Controls the render order relative to mobs and map objects.
/// Max value 2 fits in byte.
/// </summary>
public enum ReactorLayer : byte
{
    /// <summary>Standard mob draw layer.</summary>
    [Label("REACTOR_LAYER_NORMAL")]
    Normal = 0,

    /// <summary>Behind all objects.</summary>
    [Label("REACTOR_LAYER_BACK")]
    Back = 1,

    /// <summary>Above all objects.</summary>
    [Label("REACTOR_LAYER_UPPERMOST")]
    Uppermost = 2,
}
