using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// In-game event field type (hunting, OX quiz, ladder, etc.).
/// </summary>
public enum FieldEventType : byte
{
    /// <summary>Hunting event.</summary>
    [Label("EVENTTYPE_HUNTING")]
    Hunting = 1,

    /// <summary>OX quiz event.</summary>
    [Label("EVENTTYPE_OXQUIZ")]
    [Label("Ox Quiz", 1)]
    OxQuiz = 2,

    /// <summary>Vertical ladder race.</summary>
    [Label("EVENTTYPE_LADDER")]
    Ladder = 3,

    /// <summary>Upland event.</summary>
    [Label("EVENTTYPE_UPLAND")]
    Upland = 4,

    /// <summary>Miscellaneous event.</summary>
    [Label("EVENTTYPE_ETC")]
    Etc = 5,

    /// <summary>Snowball fight event.</summary>
    [Label("EVENTTYPE_SNOWBALL")]
    Snowball = 6,
}
