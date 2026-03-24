using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Stored in Mob.wz/{id}.img/info/species (loaded as string name, converted to index).
/// </summary>
public enum MobSpecies : byte
{
    /// <summary>Beast species.</summary>
    [Label("MOBSPECIES_BEAST")]
    Beast = 0,

    /// <summary>Dragon species.</summary>
    [Label("MOBSPECIES_DRAGON")]
    Dragon = 1,

    /// <summary>Undead species.</summary>
    [Label("MOBSPECIES_UNDEAD")]
    Undead = 2,

    /// <summary>Miscellaneous/other species.</summary>
    [Label("MOBSPECIES_ETC")]
    Etc = 3,

    /// <summary>No species (invalid).</summary>
    [Label("MOBSPECIES_NO")]
    None = 4,
}
