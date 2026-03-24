using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob category.
/// </summary>
public enum MobCategory : byte
{
    /// <summary>Uncategorized.</summary>
    [Label("MOBCATEGORY_NONE")]
    None = 0,

    /// <summary>Animal-type mob.</summary>
    [Label("MOBCATEGORY_ANIMAL")]
    Animal = 1,

    /// <summary>Plant-type mob.</summary>
    [Label("MOBCATEGORY_PLANT")]
    Plant = 2,

    /// <summary>Fish / aquatic mob.</summary>
    [Label("MOBCATEGORY_FISH")]
    Fish = 3,

    /// <summary>Reptile-type mob.</summary>
    [Label("MOBCATEGORY_REPTILIA")]
    [Label("Reptile", 1)]
    Reptilia = 4,

    /// <summary>Demon-type mob.</summary>
    [Label("MOBCATEGORY_DEMON")]
    Demon = 5,

    /// <summary>Spirit / ghost-type mob.</summary>
    [Label("MOBCATEGORY_SPIRIT")]
    Spirit = 6,

    /// <summary>Immortal / undead mob.</summary>
    [Label("MOBCATEGORY_IMMORTAL")]
    Immortal = 7,

    /// <summary>Miscellaneous / other.</summary>
    [Label("MOBCATEGORY_ETC")]
    Etc = 8,
}
