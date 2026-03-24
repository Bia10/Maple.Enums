using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob temporary stat (buff/debuff) bit position index.
/// </summary>
public enum MobTemporaryStatType : byte
{
    /// <summary>Physical Attack Damage modifier.</summary>
    [Label("MS_PAD")]
    PAD = 0,

    /// <summary>Physical Defense Rate modifier.</summary>
    [Label("MS_PDR")]
    PDR = 1,

    /// <summary>Magic Attack Damage modifier.</summary>
    [Label("MS_MAD")]
    MAD = 2,

    /// <summary>Magic Defense Rate modifier.</summary>
    [Label("MS_MDR")]
    MDR = 3,

    /// <summary>Accuracy modifier.</summary>
    [Label("MS_ACC")]
    ACC = 4,

    /// <summary>Evasion modifier.</summary>
    [Label("MS_EVA")]
    EVA = 5,

    /// <summary>Movement speed modifier.</summary>
    [Label("MS_Speed")]
    Speed = 6,

    /// <summary>Stun status — cannot act.</summary>
    [Label("MS_Stun")]
    Stun = 7,

    /// <summary>Freeze status — immobilized by ice.</summary>
    [Label("MS_Freeze")]
    Freeze = 8,

    /// <summary>Poison status — periodic damage over time.</summary>
    [Label("MS_Poison")]
    Poison = 9,

    /// <summary>Seal status — skills disabled.</summary>
    [Label("MS_Seal")]
    Seal = 10,

    /// <summary>Darkness status — reduced accuracy.</summary>
    [Label("MS_Darkness")]
    Darkness = 11,

    /// <summary>Physical power buff.</summary>
    [Label("MS_PowerUp")]
    [Label("Power Up", 1)]
    PowerUp = 12,

    /// <summary>Magic power buff.</summary>
    [Label("MS_MagicUp")]
    [Label("Magic Up", 1)]
    MagicUp = 13,

    /// <summary>Physical guard buff.</summary>
    [Label("MS_PGuardUp")]
    [Label("PGuard Up", 1)]
    PGuardUp = 14,

    /// <summary>Magic guard buff.</summary>
    [Label("MS_MGuardUp")]
    [Label("MGuard Up", 1)]
    MGuardUp = 15,

    /// <summary>Doom — transformed into a weaker form.</summary>
    [Label("MS_Doom")]
    Doom = 16,

    /// <summary>Web — slowed movement.</summary>
    [Label("MS_Web")]
    Web = 17,

    /// <summary>Physical attack immunity.</summary>
    [Label("MS_PImmune")]
    PImmune = 18,

    /// <summary>Magic attack immunity.</summary>
    [Label("MS_MImmune")]
    MImmune = 19,

    /// <summary>Showdown taunt — increased EXP/drop from mob.</summary>
    [Label("MS_Showdown")]
    Showdown = 20,

    /// <summary>Hard skin — flat damage reduction.</summary>
    [Label("MS_HardSkin")]
    [Label("Hard Skin", 1)]
    HardSkin = 21,

    /// <summary>Ambush — hidden/stealth status.</summary>
    [Label("MS_Ambush")]
    Ambush = 22,

    /// <summary>Elemental damage attribute modifier.</summary>
    [Label("MS_DamagedElemAttr")]
    [Label("Damaged Elem Attr", 1)]
    DamagedElemAttr = 23,

    /// <summary>Venom — damage-over-time poison.</summary>
    [Label("MS_Venom")]
    Venom = 24,

    /// <summary>Blind — reduced accuracy.</summary>
    [Label("MS_Blind")]
    Blind = 25,

    /// <summary>Specific skill seal.</summary>
    [Label("MS_SealSkill")]
    [Label("Seal Skill", 1)]
    SealSkill = 26,

    /// <summary>Burn — fire damage over time.</summary>
    [Label("MS_Burned")]
    Burned = 27,

    /// <summary>Dazzle — disorientation effect.</summary>
    [Label("MS_Dazzle")]
    Dazzle = 28,

    /// <summary>Physical damage counter/reflect.</summary>
    [Label("MS_PCounter")]
    PCounter = 29,

    /// <summary>Magic damage counter/reflect.</summary>
    [Label("MS_MCounter")]
    MCounter = 30,

    /// <summary>Disable — fully incapacitated.</summary>
    [Label("MS_Disable")]
    Disable = 31,

    /// <summary>Rise by toss — launched airborne.</summary>
    [Label("MS_RiseByToss")]
    [Label("Rise By Toss", 1)]
    RiseByToss = 32,

    /// <summary>Body Pressure contact damage effect.</summary>
    [Label("MS_BodyPressure")]
    [Label("Body Pressure", 1)]
    BodyPressure = 33,

    /// <summary>Weakness — reduced stats.</summary>
    [Label("MS_Weakness")]
    Weakness = 34,

    /// <summary>Time bomb — detonates after a delay.</summary>
    [Label("MS_TimeBomb")]
    [Label("Time Bomb", 1)]
    TimeBomb = 35,

    /// <summary>Magic Crash — dispels mob buffs.</summary>
    [Label("MS_MagicCrash")]
    [Label("Magic Crash", 1)]
    MagicCrash = 36,

    /// <summary>Heal when dealing damage.</summary>
    [Label("MS_HealByDamage")]
    [Label("Heal By Damage", 1)]
    HealByDamage = 37,
}
