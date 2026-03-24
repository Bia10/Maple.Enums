using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// User visual effect types displayed on characters.
/// </summary>
public enum UserEffectType : byte
{
    /// <summary>Level up flash.</summary>
    [Label("UserEffect_LevelUp")]
    [Label("Level Up", 1)]
    LevelUp = 0,

    /// <summary>Skill cast animation.</summary>
    [Label("UserEffect_SkillUse")]
    [Label("Skill Use", 1)]
    SkillUse = 1,

    /// <summary>Hit by skill effect.</summary>
    [Label("UserEffect_SkillAffected")]
    [Label("Skill Affected", 1)]
    SkillAffected = 2,

    /// <summary>Selected skill hit effect.</summary>
    [Label("UserEffect_SkillAffected_Select")]
    [Label("Skill Affected Select", 1)]
    SkillAffectedSelect = 3,

    /// <summary>Special skill hit effect.</summary>
    [Label("UserEffect_SkillSpecialAffected")]
    [Label("Skill Special Affected", 1)]
    SkillSpecialAffected = 4,

    /// <summary>Quest progress effect.</summary>
    [Label("UserEffect_Quest")]
    Quest = 5,

    /// <summary>Pet action effect.</summary>
    [Label("UserEffect_Pet")]
    Pet = 6,

    /// <summary>Special skill animation.</summary>
    [Label("UserEffect_SkillSpecial")]
    [Label("Skill Special", 1)]
    SkillSpecial = 7,

    /// <summary>Safety charm activation.</summary>
    [Label("UserEffect_ProtectOnDieItemUse")]
    [Label("Protect On Die Item Use", 1)]
    ProtectOnDieItemUse = 8,

    /// <summary>Portal entry sound.</summary>
    [Label("UserEffect_PlayPortalSE")]
    [Label("Play Portal Sound Effect", 1)]
    PlayPortalSoundEffect = 9,

    /// <summary>Job advancement effect.</summary>
    [Label("UserEffect_JobChanged")]
    [Label("Job Changed", 1)]
    JobChanged = 10,

    /// <summary>Quest completion effect.</summary>
    [Label("UserEffect_QuestComplete")]
    [Label("Quest Complete", 1)]
    QuestComplete = 11,

    /// <summary>HP change display.</summary>
    [Label("UserEffect_IncDecHPEffect")]
    [Label("Inc Dec Hp Effect", 1)]
    IncDecHpEffect = 12,

    /// <summary>Buff item glow.</summary>
    [Label("UserEffect_BuffItemEffect")]
    [Label("Buff Item Effect", 1)]
    BuffItemEffect = 13,

    /// <summary>Firecracker / squib effect.</summary>
    [Label("UserEffect_SquibEffect")]
    [Label("Squib Effect", 1)]
    SquibEffect = 14,

    /// <summary>Monster Book card obtained.</summary>
    [Label("UserEffect_MonsterBookCardGet")]
    [Label("Monster Book Card Get", 1)]
    MonsterBookCardGet = 15,

    /// <summary>Gachapon use effect.</summary>
    [Label("UserEffect_LotteryUse")]
    [Label("Lottery Use", 1)]
    LotteryUse = 16,

    /// <summary>Equipment level up glow.</summary>
    [Label("UserEffect_ItemLevelUp")]
    [Label("Item Level Up", 1)]
    ItemLevelUp = 17,

    /// <summary>Item crafting effect.</summary>
    [Label("UserEffect_ItemMaker")]
    [Label("Item Maker", 1)]
    ItemMaker = 18,

    /// <summary>EXP coupon consumed.</summary>
    [Label("UserEffect_ExpItemConsumed")]
    [Label("Exp Item Consumed", 1)]
    ExpItemConsumed = 19,

    /// <summary>Reserved placeholder effect.</summary>
    [Label("UserEffect_ReservedEffect")]
    [Label("Reserved Effect", 1)]
    ReservedEffect = 20,

    /// <summary>Generic buff effect.</summary>
    [Label("UserEffect_Buff")]
    Buff = 21,

    /// <summary>Consumable use effect.</summary>
    [Label("UserEffect_ConsumeEffect")]
    [Label("Consume Effect", 1)]
    ConsumeEffect = 22,

    /// <summary>Upgrade tombstone used.</summary>
    [Label("UserEffect_UpgradeTombItemUse")]
    [Label("Upgrade Tomb Item Use", 1)]
    UpgradeTombItemUse = 23,

    /// <summary>Battlefield item effect.</summary>
    [Label("UserEffect_BattlefieldItemUse")]
    [Label("Battlefield Item Use", 1)]
    BattlefieldItemUse = 24,

    /// <summary>Avatar-oriented effect.</summary>
    [Label("UserEffect_AvatarOriented")]
    [Label("Avatar Oriented", 1)]
    AvatarOriented = 25,

    /// <summary>Monster incubator effect.</summary>
    [Label("UserEffect_IncubatorUse")]
    [Label("Incubator Use", 1)]
    IncubatorUse = 26,

    /// <summary>Sound with BGM muted.</summary>
    [Label("UserEffect_PlaySoundWithMuteBGM")]
    [Label("Play Sound With Mute Bgm", 1)]
    PlaySoundWithMuteBgm = 27,

    /// <summary>Soul stone revive effect.</summary>
    [Label("UserEffect_SoulStoneUse")]
    [Label("Soul Stone Use", 1)]
    SoulStoneUse = 28,

    /// <summary>Extended HP change display.</summary>
    [Label("UserEffect_IncDecHPEffect_EX")]
    [Label("Inc Dec Hp Effect Ex", 1)]
    IncDecHpEffectEx = 29,

    /// <summary>Delivery quest item used.</summary>
    [Label("UserEffect_DeliveryQuestItemUse")]
    [Label("Delivery Quest Item Use", 1)]
    DeliveryQuestItemUse = 30,

    /// <summary>Repeating effect removed.</summary>
    [Label("UserEffect_RepeatEffectRemove")]
    [Label("Repeat Effect Remove", 1)]
    RepeatEffectRemove = 31,

    /// <summary>Evolution ring effect.</summary>
    [Label("UserEffect_EvolRing")]
    [Label("Evol Ring", 1)]
    EvolRing = 32,
}
