using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Result codes for the random morph (transformation) skill.
/// </summary>
public enum RandomMorphResult : byte
{
    /// <summary>Morph succeeded.</summary>
    [Label("RandomMorphRes_Done")]
    Done = 0,

    /// <summary>Morph failed.</summary>
    [Label("RandomMorphRes_Failed")]
    Failed = 1,

    /// <summary>No valid target.</summary>
    [Label("RandomMorphFailReason_NoTarget")]
    [Label("No Target", 1)]
    NoTarget = 2,

    /// <summary>Must be in town.</summary>
    [Label("RandomMorphFailReason_NotInTown")]
    [Label("Not In Town", 1)]
    NotInTown = 3,

    /// <summary>Unspecified error.</summary>
    [Label("RandomMorphFailReason_UnknownError")]
    [Label("Unknown Error", 1)]
    UnknownError = 4,
}
