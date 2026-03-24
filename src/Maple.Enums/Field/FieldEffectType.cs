using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Field-wide visual/audio effect types.
/// </summary>
public enum FieldEffectType : byte
{
    /// <summary>Summon visual effect.</summary>
    [Label("FieldEffect_Summon")]
    Summon = 0,

    /// <summary>Screen shake effect.</summary>
    [Label("FieldEffect_Tremble")]
    Tremble = 1,

    /// <summary>Map object effect.</summary>
    [Label("FieldEffect_Object")]
    Object = 2,

    /// <summary>Full-screen overlay.</summary>
    [Label("FieldEffect_Screen")]
    Screen = 3,

    /// <summary>Sound effect.</summary>
    [Label("FieldEffect_Sound")]
    Sound = 4,

    /// <summary>Mob HP bar display.</summary>
    [Label("FieldEffect_MobHPTag")]
    [Label("Mob HP Tag", 1)]
    MobHPTag = 5,

    /// <summary>Background music change.</summary>
    [Label("FieldEffect_ChangeBGM")]
    [Label("Change BGM", 1)]
    ChangeBGM = 6,

    /// <summary>Reward roulette effect.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("FieldEffect_RewordRullet")]
    [Label("Reward Roulette", 1)]
    RewardRoulette = 7,
}
