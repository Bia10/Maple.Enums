using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Marital status.
/// Marriage/engagement state for characters.
/// </summary>
public enum MaritalStatus : byte
{
    /// <summary>Not married.</summary>
    [Label("MS_SINGLE")]
    Single = 0,

    /// <summary>Currently engaged.</summary>
    [Label("MS_ENGAGED")]
    Engaged = 1,

    /// <summary>Wedding reserved.</summary>
    [Label("MS_RESERVED")]
    Reserved = 2,

    /// <summary>Currently married.</summary>
    [Label("MS_MARRIED")]
    Married = 3,
}
