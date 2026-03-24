using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Sound effect type.
/// Covers mob, weapon, item, skill, and reactor sound effects.
/// </summary>
public enum SoundEffectType : byte
{
    /// <summary>Mob takes damage.</summary>
    [Label("SE_MOB_DAMAGE")]
    [Label("Mob Damage", 1)]
    MobDamage = 0,

    /// <summary>Mob death.</summary>
    [Label("SE_MOB_DIE")]
    [Label("Mob Die", 1)]
    MobDie = 1,

    /// <summary>Mob attack, slot 1.</summary>
    [Label("SE_MOB_ATTACK1")]
    [Label("Mob Attack1", 1)]
    MobAttack1 = 2,

    /// <summary>Mob attack, slot 2.</summary>
    [Label("SE_MOB_ATTACK2")]
    [Label("Mob Attack2", 1)]
    MobAttack2 = 3,

    /// <summary>Mob attack, slot 3.</summary>
    [Label("SE_MOB_ATTACK3")]
    [Label("Mob Attack3", 1)]
    MobAttack3 = 4,

    /// <summary>Mob attack, slot 4.</summary>
    [Label("SE_MOB_ATTACK4")]
    [Label("Mob Attack4", 1)]
    MobAttack4 = 5,

    /// <summary>Mob attack, slot 5.</summary>
    [Label("SE_MOB_ATTACK5")]
    [Label("Mob Attack5", 1)]
    MobAttack5 = 6,

    /// <summary>Mob attack, slot 6.</summary>
    [Label("SE_MOB_ATTACK6")]
    [Label("Mob Attack6", 1)]
    MobAttack6 = 7,

    /// <summary>Mob attack, slot 7.</summary>
    [Label("SE_MOB_ATTACK7")]
    [Label("Mob Attack7", 1)]
    MobAttack7 = 8,

    /// <summary>Mob attack, slot 8.</summary>
    [Label("SE_MOB_ATTACK8")]
    [Label("Mob Attack8", 1)]
    MobAttack8 = 9,

    /// <summary>Mob attack, fixed/fallback.</summary>
    [Label("SE_MOB_ATTACKF")]
    [Label("Mob Attack F", 1)]
    MobAttackF = 10,

    /// <summary>Mob hits player, slot 1.</summary>
    [Label("SE_MOB_CHARDAMAGE1")]
    [Label("Mob Char Damage1", 1)]
    MobCharDamage1 = 11,

    /// <summary>Mob hits player, slot 2.</summary>
    [Label("SE_MOB_CHARDAMAGE2")]
    [Label("Mob Char Damage2", 1)]
    MobCharDamage2 = 12,

    /// <summary>Mob hits player, slot 3.</summary>
    [Label("SE_MOB_CHARDAMAGE3")]
    [Label("Mob Char Damage3", 1)]
    MobCharDamage3 = 13,

    /// <summary>Mob hits player, slot 4.</summary>
    [Label("SE_MOB_CHARDAMAGE4")]
    [Label("Mob Char Damage4", 1)]
    MobCharDamage4 = 14,

    /// <summary>Mob hits player, slot 5.</summary>
    [Label("SE_MOB_CHARDAMAGE5")]
    [Label("Mob Char Damage5", 1)]
    MobCharDamage5 = 15,

    /// <summary>Mob hits player, slot 6.</summary>
    [Label("SE_MOB_CHARDAMAGE6")]
    [Label("Mob Char Damage6", 1)]
    MobCharDamage6 = 16,

    /// <summary>Mob hits player, slot 7.</summary>
    [Label("SE_MOB_CHARDAMAGE7")]
    [Label("Mob Char Damage7", 1)]
    MobCharDamage7 = 17,

    /// <summary>Mob hits player, slot 8.</summary>
    [Label("SE_MOB_CHARDAMAGE8")]
    [Label("Mob Char Damage8", 1)]
    MobCharDamage8 = 18,

    /// <summary>Mob hits player, fixed/fallback.</summary>
    [Label("SE_MOB_CHARDAMAGEF")]
    [Label("Mob Char Damage F", 1)]
    MobCharDamageF = 19,

    /// <summary>Mob skill cast, slot 1.</summary>
    [Label("SE_MOB_SKILL1")]
    [Label("Mob Skill1", 1)]
    MobSkill1 = 20,

    /// <summary>Mob skill cast, slot 2.</summary>
    [Label("SE_MOB_SKILL2")]
    [Label("Mob Skill2", 1)]
    MobSkill2 = 21,

    /// <summary>Mob skill cast, slot 3.</summary>
    [Label("SE_MOB_SKILL3")]
    [Label("Mob Skill3", 1)]
    MobSkill3 = 22,

    /// <summary>Mob skill cast, slot 4.</summary>
    [Label("SE_MOB_SKILL4")]
    [Label("Mob Skill4", 1)]
    MobSkill4 = 23,

    /// <summary>Mob skill cast, slot 5.</summary>
    [Label("SE_MOB_SKILL5")]
    [Label("Mob Skill5", 1)]
    MobSkill5 = 24,

    /// <summary>Mob skill cast, slot 6.</summary>
    [Label("SE_MOB_SKILL6")]
    [Label("Mob Skill6", 1)]
    MobSkill6 = 25,

    /// <summary>Mob skill cast, slot 7.</summary>
    [Label("SE_MOB_SKILL7")]
    [Label("Mob Skill7", 1)]
    MobSkill7 = 26,

    /// <summary>Mob skill cast, slot 8.</summary>
    [Label("SE_MOB_SKILL8")]
    [Label("Mob Skill8", 1)]
    MobSkill8 = 27,

    /// <summary>Mob skill cast, slot 9.</summary>
    [Label("SE_MOB_SKILL9")]
    [Label("Mob Skill9", 1)]
    MobSkill9 = 28,

    /// <summary>Mob skill cast, slot 10.</summary>
    [Label("SE_MOB_SKILL10")]
    [Label("Mob Skill10", 1)]
    MobSkill10 = 29,

    /// <summary>Mob skill cast, slot 11.</summary>
    [Label("SE_MOB_SKILL11")]
    [Label("Mob Skill11", 1)]
    MobSkill11 = 30,

    /// <summary>Mob skill cast, slot 12.</summary>
    [Label("SE_MOB_SKILL12")]
    [Label("Mob Skill12", 1)]
    MobSkill12 = 31,

    /// <summary>Mob skill cast, slot 13.</summary>
    [Label("SE_MOB_SKILL13")]
    [Label("Mob Skill13", 1)]
    MobSkill13 = 32,

    /// <summary>Mob skill cast, slot 14.</summary>
    [Label("SE_MOB_SKILL14")]
    [Label("Mob Skill14", 1)]
    MobSkill14 = 33,

    /// <summary>Mob skill cast, slot 15.</summary>
    [Label("SE_MOB_SKILL15")]
    [Label("Mob Skill15", 1)]
    MobSkill15 = 34,

    /// <summary>Mob skill cast, slot 16.</summary>
    [Label("SE_MOB_SKILL16")]
    [Label("Mob Skill16", 1)]
    MobSkill16 = 35,

    /// <summary>Mob skill cast, fixed/fallback.</summary>
    [Label("SE_MOB_SKILLF")]
    [Label("Mob Skill F", 1)]
    MobSkillF = 36,

    /// <summary>Mob self-destruct / bomb.</summary>
    [Label("SE_MOB_BOMB")]
    [Label("Mob Bomb", 1)]
    MobBomb = 37,

    /// <summary>Mob respawn / regen.</summary>
    [Label("SE_MOB_REGEN")]
    [Label("Mob Regen", 1)]
    MobRegen = 38,

    /// <summary>Player weapon swing.</summary>
    [Label("SE_WEAPON_ATTACK")]
    [Label("Weapon Attack", 1)]
    WeaponAttack = 39,

    /// <summary>Player weapon swing, alt.</summary>
    [Label("SE_WEAPON_ATTACK2")]
    [Label("Weapon Attack2", 1)]
    WeaponAttack2 = 40,

    /// <summary>Consumable item use.</summary>
    [Label("SE_ITEM_USE")]
    [Label("Item Use", 1)]
    ItemUse = 41,

    /// <summary>Skill cast, slot 1.</summary>
    [Label("SE_SKILL_USE")]
    [Label("Skill Use", 1)]
    SkillUse = 42,

    /// <summary>Skill cast, slot 2.</summary>
    [Label("SE_SKILL_USE2")]
    [Label("Skill Use2", 1)]
    SkillUse2 = 43,

    /// <summary>Skill cast, slot 3.</summary>
    [Label("SE_SKILL_USE3")]
    [Label("Skill Use3", 1)]
    SkillUse3 = 44,

    /// <summary>Skill cast, slot 4.</summary>
    [Label("SE_SKILL_USE4")]
    [Label("Skill Use4", 1)]
    SkillUse4 = 45,

    /// <summary>Skill cast, slot 5.</summary>
    [Label("SE_SKILL_USE5")]
    [Label("Skill Use5", 1)]
    SkillUse5 = 46,

    /// <summary>Skill looping ambient sound.</summary>
    [Label("SE_SKILL_LOOP")]
    [Label("Skill Loop", 1)]
    SkillLoop = 47,

    /// <summary>Summon spawn sound.</summary>
    [Label("SE_SKILL_SUMMONED")]
    [Label("Skill Summoned", 1)]
    SkillSummoned = 48,

    /// <summary>Summon attack sound.</summary>
    [Label("SE_SKILL_ATTACK1")]
    [Label("Skill Attack1", 1)]
    SkillAttack1 = 49,

    /// <summary>Summon death / despawn.</summary>
    [Label("SE_SKILL_DIE")]
    [Label("Skill Die", 1)]
    SkillDie = 50,

    /// <summary>Skill damage tick.</summary>
    [Label("SE_SKILL_DAMAGE")]
    [Label("Skill Damage", 1)]
    SkillDamage = 51,

    /// <summary>Skill direct hit.</summary>
    [Label("SE_SKILL_HIT")]
    [Label("Skill Hit", 1)]
    SkillHit = 52,

    /// <summary>Skill delayed hit.</summary>
    [Label("SE_SKILL_DELAYEDHIT")]
    [Label("Skill Delayed Hit", 1)]
    SkillDelayedHit = 53,

    /// <summary>Dismount / skill cancel.</summary>
    [Label("SE_SKILL_GETOFF")]
    [Label("Skill Get Off", 1)]
    SkillGetOff = 54,

    /// <summary>Reactor hit.</summary>
    [Label("SE_REACTOR_HIT")]
    [Label("Reactor Hit", 1)]
    ReactorHit = 55,
}
