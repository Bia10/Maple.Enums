namespace Maple.Enums;

/// <summary>
/// Type of a life entry in a map's life list, sourced from the
/// <c>Map.wz/{mapId}/life/{id}/type</c> WZ field.
/// </summary>
/// <remarks>
/// WZ values are string literals (<c>"m"</c> for mob, <c>"n"</c> for NPC);
/// the numeric mapping follows convention used across server implementations.
/// </remarks>
public enum LifeType : byte
{
    /// <summary>Monster (<c>"m"</c> in WZ).</summary>
    Mob = 0,

    /// <summary>Non-player character (<c>"n"</c> in WZ).</summary>
    Npc = 1,
}
