using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Server-side lock type controlling field / user access.
/// </summary>
public enum ServerLockType : byte
{
    /// <summary>No lock checking.</summary>
    [Label("LT_NoCheck")]
    [Label("No Check", 1)]
    NoCheck = 0,

    /// <summary>Terminal-level lock.</summary>
    [Label("LT_Terminal")]
    Terminal = 1,

    /// <summary>Party search lock.</summary>
    [Label("LT_PartyAdver")]
    [Label("Party Adver", 1)]
    PartyAdver = 2,

    /// <summary>Per-user lock.</summary>
    [Label("LT_User")]
    User = 3,

    /// <summary>Per-map lock.</summary>
    [Label("LT_Field")]
    Field = 4,

    /// <summary>Field-set group lock.</summary>
    [Label("LT_FieldSet")]
    [Label("Field Set", 1)]
    FieldSet = 5,

    /// <summary>Field container lock.</summary>
    [Label("LT_FieldContainer")]
    [Label("Field Container", 1)]
    FieldContainer = 6,
}
