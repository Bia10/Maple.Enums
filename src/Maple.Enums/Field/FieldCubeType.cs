using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Field cube area type (hunting zone / area-check marker).
/// </summary>
public enum FieldCubeType : byte
{
    /// <summary>Invalid cube type.</summary>
    [Label("FIELD_CUBE_TYPE_ERROR")]
    Error = 0,

    /// <summary>Hunting zone cube.</summary>
    [Label("FIELD_CUBE_TYPE_HUNTING")]
    Hunting = 1,

    /// <summary>Area check cube.</summary>
    [Label("FIELD_CUBE_TYPE_AREACHECK")]
    [Label("Area Check", 1)]
    AreaCheck = 2,

    /// <summary>Sentinel count.</summary>
    [Label("FIELD_CUBE_TYPE_NUM")]
    Num = 3,
}
