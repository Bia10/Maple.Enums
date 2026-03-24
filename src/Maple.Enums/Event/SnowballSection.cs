using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Snowball event section / control states.
/// </summary>
public enum SnowballSection : byte
{
    /// <summary>Starting section.</summary>
    [Label("SNOWBALL_SECTION0")]
    Section0 = 0,

    /// <summary>First checkpoint.</summary>
    [Label("SNOWBALL_SECTION1")]
    Section1 = 1,

    /// <summary>Second checkpoint.</summary>
    [Label("SNOWBALL_SECTION2")]
    Section2 = 2,

    /// <summary>Third checkpoint.</summary>
    [Label("SNOWBALL_SECTION3")]
    Section3 = 3,

    /// <summary>Snowball stopped.</summary>
    [Label("SNOWBALL_STOP")]
    Stop = 4,

    /// <summary>Snowball restarted.</summary>
    [Label("SNOWBALL_RESTART")]
    Restart = 5,
}
