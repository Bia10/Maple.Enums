using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob skill types used by monster skill attacks.
/// </summary>
public enum MobSkillType : byte
{
    /// <summary>Increase own physical attack power.</summary>
    [Label("MOBSKILL_POWERUP")]
    [Label("Power Up", 1)]
    PowerUp = 100,

    /// <summary>Increase own magic attack power.</summary>
    [Label("MOBSKILL_MAGICUP")]
    [Label("Magic Up", 1)]
    MagicUp = 101,

    /// <summary>Increase own physical defense.</summary>
    [Label("MOBSKILL_PGUARDUP")]
    [Label("Physical Guard Up", 1)]
    PhysicalGuardUp = 102,

    /// <summary>Increase own magic defense.</summary>
    [Label("MOBSKILL_MGUARDUP")]
    [Label("Magic Guard Up", 1)]
    MagicGuardUp = 103,

    /// <summary>Increase own movement speed.</summary>
    [Label("MOBSKILL_HASTE")]
    Haste = 104,

    /// <summary>AoE physical attack power buff for nearby mobs.</summary>
    [Label("MOBSKILL_POWERUP_M")]
    [Label("Power Up Multi", 1)]
    PowerUpMulti = 110,

    /// <summary>AoE magic attack power buff for nearby mobs.</summary>
    [Label("MOBSKILL_MAGICUP_M")]
    [Label("Magic Up Multi", 1)]
    MagicUpMulti = 111,

    /// <summary>AoE physical defense buff for nearby mobs.</summary>
    [Label("MOBSKILL_PGUARDUP_M")]
    [Label("Physical Guard Up Multi", 1)]
    PhysicalGuardUpMulti = 112,

    /// <summary>AoE magic defense buff for nearby mobs.</summary>
    [Label("MOBSKILL_MGUARDUP_M")]
    [Label("Magic Guard Up Multi", 1)]
    MagicGuardUpMulti = 113,

    /// <summary>AoE heal for nearby mobs.</summary>
    [Label("MOBSKILL_HEAL_M")]
    [Label("Heal Multi", 1)]
    HealMulti = 114,

    /// <summary>AoE movement speed buff for nearby mobs.</summary>
    [Label("MOBSKILL_HASTE_M")]
    [Label("Haste Multi", 1)]
    HasteMulti = 115,

    /// <summary>Seal debuff — disables player skills.</summary>
    [Label("MOBSKILL_SEAL")]
    Seal = 120,

    /// <summary>Darkness debuff — reduces player accuracy.</summary>
    [Label("MOBSKILL_DARKNESS")]
    Darkness = 121,

    /// <summary>Weakness debuff — reduces player stats.</summary>
    [Label("MOBSKILL_WEAKNESS")]
    Weakness = 122,

    /// <summary>Stun debuff — prevents player from acting.</summary>
    [Label("MOBSKILL_STUN")]
    Stun = 123,

    /// <summary>Curse debuff — increased EXP loss on death.</summary>
    [Label("MOBSKILL_CURSE")]
    Curse = 124,

    /// <summary>Poison debuff — periodic damage over time.</summary>
    [Label("MOBSKILL_POISON")]
    Poison = 125,

    /// <summary>Slow debuff — reduces player movement speed.</summary>
    [Label("MOBSKILL_SLOW")]
    Slow = 126,

    /// <summary>Dispel — removes player buffs.</summary>
    [Label("MOBSKILL_DISPEL")]
    Dispel = 127,

    /// <summary>Attract — pulls player toward the mob.</summary>
    [Label("MOBSKILL_ATTRACT")]
    Attract = 128,

    /// <summary>Banish — teleports player to another map.</summary>
    [Label("MOBSKILL_BANMAP")]
    [Label("Ban Map", 1)]
    BanMap = 129,

    /// <summary>Area fire — creates a fire damage zone.</summary>
    [Label("MOBSKILL_AREA_FIRE")]
    [Label("Area Fire", 1)]
    AreaFire = 130,

    /// <summary>Area poison — creates a poison damage zone.</summary>
    [Label("MOBSKILL_AREA_POISON")]
    [Label("Area Poison", 1)]
    AreaPoison = 131,

    /// <summary>Reverse input — inverts player controls.</summary>
    [Label("MOBSKILL_REVERSE_INPUT")]
    [Label("Reverse Input", 1)]
    ReverseInput = 132,

    /// <summary>Undead status — healing effects deal damage instead.</summary>
    [Label("MOBSKILL_UNDEAD")]
    Undead = 133,

    /// <summary>Disable potion use.</summary>
    /// <remarks>Documented original client typo: "STOPPORTION" → "STOPPOTION"; see typos.md.</remarks>
    [Label("MOBSKILL_STOPPORTION")]
    [Label("Stop Potion", 1)]
    StopPotion = 134,

    /// <summary>Freeze player in place.</summary>
    [Label("MOBSKILL_STOPMOTION")]
    [Label("Stop Motion", 1)]
    StopMotion = 135,

    /// <summary>Fear debuff — prevents attacking or using skills.</summary>
    [Label("MOBSKILL_FEAR")]
    Fear = 136,

    /// <summary>Frozen debuff — encases player in ice.</summary>
    [Label("MOBSKILL_FROZEN")]
    Frozen = 137,

    /// <summary>Physical attack immunity.</summary>
    [Label("MOBSKILL_PHYSICALIMMUNE")]
    [Label("Physical Immune", 1)]
    PhysicalImmune = 140,

    /// <summary>Magic attack immunity.</summary>
    [Label("MOBSKILL_MAGICIMMUNE")]
    [Label("Magic Immune", 1)]
    MagicImmune = 141,

    /// <summary>Hard skin — flat damage reduction.</summary>
    [Label("MOBSKILL_HARDSKIN")]
    [Label("Hard Skin", 1)]
    HardSkin = 142,

    /// <summary>Reflect physical damage back to attacker.</summary>
    [Label("MOBSKILL_PCOUNTER")]
    [Label("Physical Counter", 1)]
    PhysicalCounter = 143,

    /// <summary>Reflect magic damage back to attacker.</summary>
    [Label("MOBSKILL_MCOUNTER")]
    [Label("Magic Counter", 1)]
    MagicCounter = 144,

    /// <summary>Reflect all damage back to attacker.</summary>
    [Label("MOBSKILL_PMCOUNTER")]
    [Label("Physical Magic Counter", 1)]
    PhysicalMagicCounter = 145,

    /// <summary>Boost own physical attack damage.</summary>
    [Label("MOBSKILL_PAD")]
    [Label("Physical Attack Damage", 1)]
    PhysicalAttackDamage = 150,

    /// <summary>Boost own magic attack damage.</summary>
    [Label("MOBSKILL_MAD")]
    [Label("Magic Attack Damage", 1)]
    MagicAttackDamage = 151,

    /// <summary>Boost own physical defense rate.</summary>
    [Label("MOBSKILL_PDR")]
    [Label("Physical Defense Rate", 1)]
    PhysicalDefenseRate = 152,

    /// <summary>Boost own magic defense rate.</summary>
    [Label("MOBSKILL_MDR")]
    [Label("Magic Defense Rate", 1)]
    MagicDefenseRate = 153,

    /// <summary>Boost own accuracy.</summary>
    [Label("MOBSKILL_ACC")]
    Accuracy = 154,

    /// <summary>Boost own evasion.</summary>
    [Label("MOBSKILL_EVA")]
    Evasion = 155,

    /// <summary>Boost own movement speed.</summary>
    [Label("MOBSKILL_SPEED")]
    Speed = 156,

    /// <summary>Seal a specific player skill.</summary>
    [Label("MOBSKILL_SEALSKILL")]
    [Label("Seal Skill", 1)]
    SealSkill = 157,

    /// <summary>Balrog-specific counter attack.</summary>
    [Label("MOBSKILL_BALROGCOUNTER")]
    [Label("Balrog Counter", 1)]
    BalrogCounter = 158,

    /// <summary>Copy and spread a skill from a player.</summary>
    [Label("MOBSILLL_SPREADSKILLFROMUSER")]
    [Label("Spread Skill From User", 1)]
    SpreadSkillFromUser = 160,

    /// <summary>Heal HP when dealing damage.</summary>
    [Label("MOBSKILL_HEALBYDAMAGE")]
    [Label("Heal By Damage", 1)]
    HealByDamage = 161,

    /// <summary>Bind/root player in place.</summary>
    [Label("MOBSKILL_BIND")]
    Bind = 162,

    /// <summary>Summon other mobs.</summary>
    [Label("MOBSKILL_SUMMON")]
    Summon = 200,

    /// <summary>Summon cube-type mobs.</summary>
    [Label("MOBSKILL_SUMMON_CUBE")]
    [Label("Summon Cube", 1)]
    SummonCube = 201,
}
