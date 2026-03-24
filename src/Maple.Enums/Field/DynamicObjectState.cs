using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Dynamic map object state used by animated map objects.
/// </summary>
public enum DynamicObjectState : byte
{
    /// <summary>Object is hidden.</summary>
    [Label("DYNAMIC_OBJ_STATE_HIDE")]
    Hide = 0,

    /// <summary>Object is visible.</summary>
    [Label("DYNAMIC_OBJ_STATE_SHOW")]
    Show = 1,

    /// <summary>Object is moving.</summary>
    [Label("DYNAMIC_OBJ_STATE_MOVE")]
    Move = 2,

    /// <summary>Object animation finished.</summary>
    [Label("DYNAMIC_OBJ_STATE_END")]
    End = 3,
}
