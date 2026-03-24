using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item transform type.
/// </summary>
/// <remarks>Documented original client typo in typos.md.</remarks>
public enum ItemTransformType : byte
{
    /// <summary>Invalid transform.</summary>
    [Label("ITEM_TRANSFROM_TYPE_ERROR")]
    Error = 0,

    /// <summary>Random transform.</summary>
    [Label("ITEM_TRANSFROM_TYPE_RANDOM")]
    Random = 1,

    /// <summary>Normal transform.</summary>
    [Label("ITEM_TRANSFROM_TYPE_NORMAL")]
    Normal = 2,

    /// <summary>Visitor transform.</summary>
    [Label("ITEM_TRANSFROM_TYPE_VISITOR")]
    Visitor = 10,
}
