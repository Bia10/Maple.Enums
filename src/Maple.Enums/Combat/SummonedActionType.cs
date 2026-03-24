using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Summoned creature action type.
/// </summary>
public enum SummonedActionType : byte
{
    /// <summary>Idle stance.</summary>
    [Label("SUMMONEDACT_STAND")]
    Stand = 0,

    /// <summary>Walking movement.</summary>
    [Label("SUMMONEDACT_MOVE")]
    Move = 1,

    /// <summary>Flying movement.</summary>
    [Label("SUMMONEDACT_FLY")]
    Fly = 2,

    /// <summary>Spawn animation.</summary>
    [Label("SUMMONEDACT_SUMMONED")]
    Summoned = 3,

    /// <summary>Primary attack.</summary>
    [Label("SUMMONEDACT_ATTACK1")]
    Attack1 = 4,

    /// <summary>Secondary attack.</summary>
    [Label("SUMMONEDACT_ATTACK2")]
    Attack2 = 5,

    /// <summary>Tesla coil triangle attack.</summary>
    [Label("SUMMONEDACT_ATTACK_TRIANGLE")]
    [Label("Attack Triangle", 1)]
    AttackTriangle = 6,

    /// <summary>Skill animation slot 1.</summary>
    [Label("SUMMONEDACT_SKILL1")]
    Skill1 = 7,

    /// <summary>Skill animation slot 2.</summary>
    [Label("SUMMONEDACT_SKILL2")]
    Skill2 = 8,

    /// <summary>Skill animation slot 3.</summary>
    [Label("SUMMONEDACT_SKILL3")]
    Skill3 = 9,

    /// <summary>Skill animation slot 4.</summary>
    [Label("SUMMONEDACT_SKILL4")]
    Skill4 = 10,

    /// <summary>Skill animation slot 5.</summary>
    [Label("SUMMONEDACT_SKILL5")]
    Skill5 = 11,

    /// <summary>Skill animation slot 6.</summary>
    [Label("SUMMONEDACT_SKILL6")]
    Skill6 = 12,

    /// <summary>Healing action.</summary>
    [Label("SUMMONEDACT_HEAL")]
    Heal = 13,

    /// <summary>Spawn sub-summon.</summary>
    [Label("SUMMONEDACT_SUBSUMMON")]
    [Label("Sub Summon", 1)]
    SubSummon = 14,

    /// <summary>Taking damage.</summary>
    [Label("SUMMONEDACT_HIT")]
    Hit = 15,

    /// <summary>Death animation.</summary>
    [Label("SUMMONEDACT_DIE")]
    Die = 16,

    /// <summary>Speech or emote.</summary>
    [Label("SUMMONEDACT_SAY")]
    Say = 17,

    /// <summary>Pre-attack windup.</summary>
    [Label("SUMMONEDACT_PREPARE")]
    Prepare = 18,
}
