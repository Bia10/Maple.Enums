using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Day-of-week ordinal for quest time requirements (Quest.wz Check node: dayOfWeek).
/// Sunday = 0 matches the SYSTEMTIME / C++ convention used by the client.
/// </summary>
public enum QuestDayOfWeek : byte
{
    /// <summary>Sunday quest window.</summary>
    [Label("Sunday")]
    Sunday = 0,

    /// <summary>Monday quest window.</summary>
    [Label("Monday")]
    Monday = 1,

    /// <summary>Tuesday quest window.</summary>
    [Label("Tuesday")]
    Tuesday = 2,

    /// <summary>Wednesday quest window.</summary>
    [Label("Wednesday")]
    Wednesday = 3,

    /// <summary>Thursday quest window.</summary>
    [Label("Thursday")]
    Thursday = 4,

    /// <summary>Friday quest window.</summary>
    [Label("Friday")]
    Friday = 5,

    /// <summary>Saturday quest window.</summary>
    [Label("Saturday")]
    Saturday = 6,
}
