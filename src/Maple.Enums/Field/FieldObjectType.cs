using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Field (map) object type used by the object pool system.</summary>
public enum FieldObjectType : byte
{
    /// <summary>Player character.</summary>
    User = 0,

    /// <summary>Summoned creature.</summary>
    Summoned = 1,

    /// <summary>Monster.</summary>
    Mob = 2,

    /// <summary>Non-player character.</summary>
    NPC = 3,

    /// <summary>Hired merchant.</summary>
    Employee = 4,

    /// <summary>Dropped item.</summary>
    Drop = 5,

    /// <summary>Message box object.</summary>
    [Label("Message Box", 1)]
    MessageBox = 6,

    /// <summary>Area-of-effect zone.</summary>
    [Label("Affected Area", 1)]
    AffectedArea = 7,

    /// <summary>Mystic door portal.</summary>
    [Label("Town Portal", 1)]
    TownPortal = 8,

    /// <summary>Mechanic gate.</summary>
    [Label("Open Gate", 1)]
    OpenGate = 9,

    /// <summary>Interactive reactor.</summary>
    Reactor = 10,

    /// <summary>Miscellaneous object.</summary>
    Etc = 11,
}
