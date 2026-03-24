using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character gender.
/// Value 2 is GENDER_NONE in the client, meaning gender-neutral / no restriction.
/// </summary>
public enum Gender : byte
{
    /// <summary>Male character.</summary>
    [Label("GENDER_MALE")]
    [Label("0", 2)]
    Male = 0,

    /// <summary>Female character.</summary>
    [Label("GENDER_FEMALE")]
    [Label("1", 2)]
    Female = 1,

    /// <summary>Gender-neutral / unisex.</summary>
    [Label("GENDER_NONE")]
    [Label("Both", 1)]
    [Label("2", 2)]
    None = 2,
}
