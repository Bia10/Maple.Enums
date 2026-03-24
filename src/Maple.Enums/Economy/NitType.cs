using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character appearance component type for name/image transactions.
/// </summary>
public enum NitType : byte
{
    /// <summary>No appearance component specified.</summary>
    [Label("NIT_NONE")]
    None = 0,

    /// <summary>Hair component.</summary>
    [Label("NIT_HAIR")]
    Hair = 1,

    /// <summary>Face component.</summary>
    [Label("NIT_FACE")]
    Face = 2,

    /// <summary>Skin component.</summary>
    [Label("NIT_SKIN")]
    Skin = 3,
}
