using FastEnumUtility;

namespace Maple.Enums;

/// <summary>User visual effect type dispatched by the client rendering system.</summary>
public enum EffectType : byte
{
    /// <summary>Level up effect.</summary>
    [Label("Level Up", 1)]
    LevelUp = 0,

    /// <summary>Skill cast effect.</summary>
    [Label("Skill Use", 1)]
    SkillUse = 1,

    /// <summary>Skill hit on target.</summary>
    [Label("Skill Affected", 1)]
    SkillAffected = 2,

    /// <summary>Selective skill hit effect.</summary>
    [Label("Skill Affected Select", 1)]
    SkillAffectedSelect = 3,

    /// <summary>Special skill target effect.</summary>
    [Label("Skill Special Affected", 1)]
    SkillSpecialAffected = 4,

    /// <summary>Quest-related effect.</summary>
    Quest = 5,

    /// <summary>Pet action effect.</summary>
    Pet = 6,

    /// <summary>Special skill visual.</summary>
    [Label("Skill Special", 1)]
    SkillSpecial = 7,

    /// <summary>Death protection item used.</summary>
    [Label("Protect On Die Item Use", 1)]
    ProtectOnDieItemUse = 8,

    /// <summary>Portal sound effect.</summary>
    [Label("Play Portal SE", 1)]
    PlayPortalSE = 9,

    /// <summary>Job advancement effect.</summary>
    [Label("Job Changed", 1)]
    JobChanged = 10,

    /// <summary>Quest completion effect.</summary>
    [Label("Quest Complete", 1)]
    QuestComplete = 11,

    /// <summary>HP increase/decrease visual.</summary>
    [Label("Inc Dec HP Effect", 1)]
    IncDecHPEffect = 12,

    /// <summary>Buff item activation.</summary>
    [Label("Buff Item Effect", 1)]
    BuffItemEffect = 13,

    /// <summary>Squib visual effect.</summary>
    [Label("Squib Effect", 1)]
    SquibEffect = 14,

    /// <summary>Monster book card obtained.</summary>
    [Label("Monster Book Card Get", 1)]
    MonsterBookCardGet = 15,

    /// <summary>Lottery item used.</summary>
    [Label("Lottery Use", 1)]
    LotteryUse = 16,

    /// <summary>Item level up effect.</summary>
    [Label("Item Level Up", 1)]
    ItemLevelUp = 17,

    /// <summary>Item crafting effect.</summary>
    [Label("Item Maker", 1)]
    ItemMaker = 18,

    /// <summary>EXP item consumed.</summary>
    [Label("Exp Item Consumed", 1)]
    ExpItemConsumed = 19,

    /// <summary>Reserved system effect.</summary>
    [Label("Reserved Effect", 1)]
    ReservedEffect = 20,

    /// <summary>Buff activation visual.</summary>
    Buff = 21,

    /// <summary>Consume item visual.</summary>
    [Label("Consume Effect", 1)]
    ConsumeEffect = 22,

    /// <summary>Tombstone upgrade item used.</summary>
    [Label("Upgrade Tomb Item Use", 1)]
    UpgradeTombItemUse = 23,

    /// <summary>Battlefield item used.</summary>
    [Label("Battlefield Item Use", 1)]
    BattlefieldItemUse = 24,

    /// <summary>Avatar-oriented visual.</summary>
    [Label("Avatar Oriented", 1)]
    AvatarOriented = 25,

    /// <summary>Incubator item used.</summary>
    [Label("Incubator Use", 1)]
    IncubatorUse = 26,

    /// <summary>Sound with muted BGM.</summary>
    [Label("Play Sound With Mute BGM", 1)]
    PlaySoundWithMuteBGM = 27,

    /// <summary>Soul stone revival used.</summary>
    [Label("Soul Stone Use", 1)]
    SoulStoneUse = 28,

    /// <summary>Extended HP change visual.</summary>
    [Label("Inc Dec HP Effect Ex", 1)]
    IncDecHPEffectEx = 29,

    /// <summary>Delivery quest item used.</summary>
    [Label("Delivery Quest Item Use", 1)]
    DeliveryQuestItemUse = 30,

    /// <summary>Repeating effect removed.</summary>
    [Label("Repeat Effect Remove", 1)]
    RepeatEffectRemove = 31,

    /// <summary>Evolution ring effect.</summary>
    [Label("Evol Ring", 1)]
    EvolRing = 32,
}
