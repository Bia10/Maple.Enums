using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Chat availability / restriction level for a character.
/// </summary>
public enum ChatAvailability : byte
{
    /// <summary>Not yet determined.</summary>
    [Label("CHAT_UNDEF")]
    Undefined = 0,

    /// <summary>Chat disabled.</summary>
    [Label("CHAT_DISABLE")]
    Disabled = 1,

    /// <summary>Restricted to line 1.</summary>
    [Label("CHAT_LINE1")]
    Line1 = 2,

    /// <summary>Fully available.</summary>
    [Label("CHAT_AVAILABLE")]
    Available = 3,
}
