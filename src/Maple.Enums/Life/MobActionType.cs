using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob animation action type.
/// </summary>
public enum MobActionType : byte
{
    /// <summary>Movement animation.</summary>
    [Label("MOBACT_MOVE")]
    Move = 0,

    /// <summary>Idle standing animation.</summary>
    [Label("MOBACT_STAND")]
    Stand = 1,

    /// <summary>Jump animation.</summary>
    [Label("MOBACT_JUMP")]
    Jump = 2,

    /// <summary>Flight animation.</summary>
    [Label("MOBACT_FLY")]
    Fly = 3,

    /// <summary>Rope/ladder climbing animation.</summary>
    [Label("MOBACT_ROPE")]
    Rope = 4,

    /// <summary>Health regeneration animation.</summary>
    [Label("MOBACT_REGEN")]
    Regen = 5,

    /// <summary>Self-destruct/bomb animation.</summary>
    [Label("MOBACT_BOMB")]
    Bomb = 6,

    /// <summary>Primary hit reaction animation.</summary>
    [Label("MOBACT_HIT1")]
    Hit1 = 7,

    /// <summary>Secondary hit reaction animation.</summary>
    [Label("MOBACT_HIT2")]
    Hit2 = 8,

    /// <summary>Final hit reaction animation.</summary>
    [Label("MOBACT_HITF")]
    [Label("Hit F", 1)]
    HitF = 9,

    /// <summary>Primary death animation.</summary>
    [Label("MOBACT_DIE1")]
    Die1 = 10,

    /// <summary>Secondary death animation.</summary>
    [Label("MOBACT_DIE2")]
    Die2 = 11,

    /// <summary>Final death animation.</summary>
    [Label("MOBACT_DIEF")]
    [Label("Die F", 1)]
    DieF = 12,

    /// <summary>Attack animation 1.</summary>
    [Label("MOBACT_ATTACK1")]
    Attack1 = 13,

    /// <summary>Attack animation 2.</summary>
    [Label("MOBACT_ATTACK2")]
    Attack2 = 14,

    /// <summary>Attack animation 3.</summary>
    [Label("MOBACT_ATTACK3")]
    Attack3 = 15,

    /// <summary>Attack animation 4.</summary>
    [Label("MOBACT_ATTACK4")]
    Attack4 = 16,

    /// <summary>Attack animation 5.</summary>
    [Label("MOBACT_ATTACK5")]
    Attack5 = 17,

    /// <summary>Attack animation 6.</summary>
    [Label("MOBACT_ATTACK6")]
    Attack6 = 18,

    /// <summary>Attack animation 7.</summary>
    [Label("MOBACT_ATTACK7")]
    Attack7 = 19,

    /// <summary>Attack animation 8.</summary>
    [Label("MOBACT_ATTACK8")]
    Attack8 = 20,

    /// <summary>Follow-up/final attack animation.</summary>
    [Label("MOBACT_ATTACKF")]
    [Label("Attack F", 1)]
    AttackF = 21,

    /// <summary>Skill animation 1.</summary>
    [Label("MOBACT_SKILL1")]
    Skill1 = 22,

    /// <summary>Skill animation 2.</summary>
    [Label("MOBACT_SKILL2")]
    Skill2 = 23,

    /// <summary>Skill animation 3.</summary>
    [Label("MOBACT_SKILL3")]
    Skill3 = 24,

    /// <summary>Skill animation 4.</summary>
    [Label("MOBACT_SKILL4")]
    Skill4 = 25,

    /// <summary>Skill animation 5.</summary>
    [Label("MOBACT_SKILL5")]
    Skill5 = 26,

    /// <summary>Skill animation 6.</summary>
    [Label("MOBACT_SKILL6")]
    Skill6 = 27,

    /// <summary>Skill animation 7.</summary>
    [Label("MOBACT_SKILL7")]
    Skill7 = 28,

    /// <summary>Skill animation 8.</summary>
    [Label("MOBACT_SKILL8")]
    Skill8 = 29,

    /// <summary>Skill animation 9.</summary>
    [Label("MOBACT_SKILL9")]
    Skill9 = 30,

    /// <summary>Skill animation 10.</summary>
    [Label("MOBACT_SKILL10")]
    Skill10 = 31,

    /// <summary>Skill animation 11.</summary>
    [Label("MOBACT_SKILL11")]
    Skill11 = 32,

    /// <summary>Skill animation 12.</summary>
    [Label("MOBACT_SKILL12")]
    Skill12 = 33,

    /// <summary>Skill animation 13.</summary>
    [Label("MOBACT_SKILL13")]
    Skill13 = 34,

    /// <summary>Skill animation 14.</summary>
    [Label("MOBACT_SKILL14")]
    Skill14 = 35,

    /// <summary>Skill animation 15.</summary>
    [Label("MOBACT_SKILL15")]
    Skill15 = 36,

    /// <summary>Skill animation 16.</summary>
    [Label("MOBACT_SKILL16")]
    Skill16 = 37,

    /// <summary>Follow-up/final skill animation.</summary>
    [Label("MOBACT_SKILLF")]
    [Label("Skill F", 1)]
    SkillF = 38,

    /// <summary>Chase/pursuit animation.</summary>
    [Label("MOBACT_CHASE")]
    Chase = 39,

    /// <summary>Miss/dodge animation.</summary>
    [Label("MOBACT_MISS")]
    Miss = 40,

    /// <summary>Speech/dialogue animation.</summary>
    [Label("MOBACT_SAY")]
    Say = 41,

    /// <summary>Eye movement/blink animation.</summary>
    [Label("MOBACT_EYE")]
    Eye = 42,

    /// <summary>No action (null state).</summary>
    [Label("MOBACT_NO")]
    [Label("No Action", 1)]
    NoAction = 43,
}
