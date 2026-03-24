using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Achievement/milestone reward type.
/// </summary>
public enum RewardType : byte
{
    /// <summary>Reach level 20 reward.</summary>
    [Label("REWARD_LEVEL_20")]
    Level20 = 0,

    /// <summary>First job advancement.</summary>
    [Label("REWARD_FIRST_JOBADVANCE")]
    [Label("First Job Advance", 1)]
    FirstJobAdvance = 1,

    /// <summary>Second job advancement.</summary>
    [Label("REWARD_SECOND_JOBADVANCE")]
    [Label("Second Job Advance", 1)]
    SecondJobAdvance = 2,

    /// <summary>Buddy list expansion.</summary>
    [Label("REWARD_ADD_10_BUDDY")]
    [Label("Add 10 Buddy", 1)]
    Add10Buddy = 3,

    /// <summary>Cygnus reaches level 10.</summary>
    [Label("REWARD_CYGNUS_LEVEL_10")]
    [Label("Cygnus Level 10", 1)]
    CygnusLevel10 = 4,

    /// <summary>Cygnus reaches level 70.</summary>
    [Label("REWARD_CYGNUS_LEVEL_70")]
    [Label("Cygnus Level 70", 1)]
    CygnusLevel70 = 5,

    /// <summary>Cygnus mount unlock.</summary>
    [Label("REWARD_CYGNUS_MOUNT")]
    [Label("Cygnus Mount", 1)]
    CygnusMount = 6,

    /// <summary>Generic level up reward.</summary>
    [Label("REWARD_LEVELUP")]
    [Label("Level Up", 1)]
    LevelUp = 7,

    /// <summary>Aran level up reward.</summary>
    [Label("REWARD_ARAN_LEVELUP")]
    [Label("Aran Level Up", 1)]
    AranLevelUp = 8,

    /// <summary>Aran wedding reward.</summary>
    [Label("REWARD_ARAN_WEDDING")]
    [Label("Aran Wedding", 1)]
    AranWedding = 9,

    /// <summary>Logout gift reward.</summary>
    [Label("REWARD_LOGOUT_GIFT")]
    [Label("Logout Gift", 1)]
    LogoutGift = 10,

    /// <summary>Dual Blade wedding reward.</summary>
    [Label("REWARD_DUAL_WEDDING")]
    [Label("Dual Wedding", 1)]
    DualWedding = 11,

    /// <summary>Level up AP/SP tier 1.</summary>
    [Label("REWARD_LEVELUP_APSP1")]
    [Label("Level Up Ap Sp1", 1)]
    LevelUpApSp1 = 12,

    /// <summary>Level up AP/SP tier 2.</summary>
    [Label("REWARD_LEVELUP_APSP2")]
    [Label("Level Up Ap Sp2", 1)]
    LevelUpApSp2 = 13,

    /// <summary>Level up AP/SP tier 3.</summary>
    [Label("REWARD_LEVELUP_APSP3")]
    [Label("Level Up Ap Sp3", 1)]
    LevelUpApSp3 = 14,

    /// <summary>Resistance wedding reward.</summary>
    [Label("REWARD_RES_WEDDING")]
    [Label("Res Wedding", 1)]
    ResWedding = 15,
}
