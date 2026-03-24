using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Pet visual effect types.
/// </summary>
public enum PetEffectType : byte
{
    /// <summary>Pet level-up visual effect.</summary>
    [Label("PetEffect_LevelUp")]
    [Label("Level Up", 1)]
    LevelUp = 0,

    /// <summary>Pet teleport visual effect.</summary>
    [Label("PetEffect_Teleport")]
    Teleport = 1,

    /// <summary>Pet hang-on-back visual effect.</summary>
    [Label("PetEffect_HangOnBack")]
    [Label("Hang On Back", 1)]
    HangOnBack = 2,

    /// <summary>Pet evolution visual effect.</summary>
    [Label("PetEffect_Evolution")]
    Evolution = 3,
}
