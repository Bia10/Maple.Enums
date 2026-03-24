using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Nexon Messenger guild account type.
/// </summary>
public enum NmGuildType : byte
{
    /// <summary>No guild type set.</summary>
    [Label("kGuildType_None")]
    None = 0,

    /// <summary>Default Nexon guild account type.</summary>
    [Label("kGuildType_NexonDefault")]
    NexonDefault = 1,

    /// <summary>New Nexon guild account type.</summary>
    [Label("kGuildType_NexonNew")]
    NexonNew = 2,

    /// <summary>CSO guild account type.</summary>
    [Label("kGuildType_CSO")]
    Cso = 3,
}
