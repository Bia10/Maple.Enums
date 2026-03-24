using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character body/appearance type distinguishing basic characters from pets, dragons, and mechs.
/// </summary>
public enum CharacterBodyType : byte
{
    /// <summary>Normal player avatar.</summary>
    [Label("BASIC_TYPE")]
    Basic = 0,

    /// <summary>Pet avatar.</summary>
    [Label("PET_TYPE")]
    Pet = 1,

    /// <summary>Evan dragon avatar.</summary>
    [Label("DRAGON_TYPE")]
    Dragon = 2,

    /// <summary>Mechanic mech avatar.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("MECANIC_TYPE")]
    Mechanic = 3,
}
