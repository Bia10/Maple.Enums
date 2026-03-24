using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Drop ownership type controlling who can pick up a dropped item.</summary>
public enum DropOwnType : byte
{
    /// <summary>Dropped for a specific user.</summary>
    [Label("User Own", 1)]
    UserOwn = 0,

    /// <summary>Dropped for party members.</summary>
    [Label("Party Own", 1)]
    PartyOwn = 1,

    /// <summary>Free-for-all drop.</summary>
    [Label("No Own", 1)]
    NoOwn = 2,

    /// <summary>Exploding free-for-all drop.</summary>
    [Label("Explosive No Own", 1)]
    ExplosiveNoOwn = 3,
}
