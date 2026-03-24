using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Morph/transform animation action type.
/// </summary>
public enum MorphActionType : byte
{
    /// <summary>Walking animation.</summary>
    [Label("MORPHACT_WALK")]
    Walk = 0,

    /// <summary>Standing idle animation.</summary>
    [Label("MORPHACT_STAND")]
    Stand = 1,

    /// <summary>Jumping animation.</summary>
    [Label("MORPHACT_JUMP")]
    Jump = 2,

    /// <summary>Alert/hit reaction, variant 1.</summary>
    [Label("MORPHACT_ALERT")]
    Alert = 3,

    /// <summary>Alert/hit reaction, variant 2.</summary>
    [Label("MORPHACT_ALERT2")]
    Alert2 = 4,

    /// <summary>Alert/hit reaction, variant 3.</summary>
    [Label("MORPHACT_ALERT3")]
    Alert3 = 5,

    /// <summary>Alert/hit reaction, variant 4.</summary>
    [Label("MORPHACT_ALERT4")]
    Alert4 = 6,

    /// <summary>Flying animation.</summary>
    [Label("MORPHACT_FLY")]
    Fly = 7,

    /// <summary>Prone (lying down) animation.</summary>
    [Label("MORPHACT_PRONE")]
    Prone = 8,

    /// <summary>Climbing a ladder.</summary>
    [Label("MORPHACT_LADDER")]
    Ladder = 9,

    /// <summary>Climbing a rope.</summary>
    [Label("MORPHACT_ROPE")]
    Rope = 10,

    /// <summary>Death animation.</summary>
    [Label("MORPHACT_DEAD")]
    Dead = 11,

    /// <summary>Sitting animation.</summary>
    [Label("MORPHACT_SIT")]
    Sit = 12,

    /// <summary>One-handed swing attack, type 1.</summary>
    [Label("MORPHACT_SWINGO1")]
    [Label("Swing O1", 1)]
    SwingO1 = 13,

    /// <summary>One-handed swing attack, type 2.</summary>
    [Label("MORPHACT_SWINGO2")]
    [Label("Swing O2", 1)]
    SwingO2 = 14,

    /// <summary>One-handed swing attack, type 3.</summary>
    [Label("MORPHACT_SWINGO3")]
    [Label("Swing O3", 1)]
    SwingO3 = 15,

    /// <summary>Two-handed weapon swing, type 1.</summary>
    [Label("MORPHACT_SWINGT1")]
    [Label("Swing T1", 1)]
    SwingT1 = 16,

    /// <summary>Two-handed weapon swing, type 3.</summary>
    [Label("MORPHACT_SWINGT3")]
    [Label("Swing T3", 1)]
    SwingT3 = 17,

    /// <summary>Ranged attack, type 1.</summary>
    [Label("MORPHACT_SHOOT1")]
    Shoot1 = 18,

    /// <summary>Ranged attack, final/finishing.</summary>
    [Label("MORPHACT_SHOOTF")]
    [Label("Shoot F", 1)]
    ShootF = 19,

    /// <summary>Stabbing while prone.</summary>
    [Label("MORPHACT_PRONESTAB")]
    [Label("Prone Stab", 1)]
    ProneStab = 20,

    /// <summary>One-handed stab, type 1.</summary>
    [Label("MORPHACT_STABO1")]
    [Label("Stab O1", 1)]
    StabO1 = 21,

    /// <summary>One-handed stab, type 2.</summary>
    [Label("MORPHACT_STABO2")]
    [Label("Stab O2", 1)]
    StabO2 = 22,

    /// <summary>Two-handed stab, final/finishing.</summary>
    [Label("MORPHACT_STABTF")]
    [Label("Stab TF", 1)]
    StabTF = 23,

    /// <summary>Time Leap skill animation.</summary>
    [Label("MORPHACT_TIMELEAP")]
    [Label("Time Leap", 1)]
    TimeLeap = 24,

    /// <summary>Energy Burster skill animation.</summary>
    [Label("MORPHACT_EBURSTER")]
    EBurster = 25,

    /// <summary>Energy Drain skill animation.</summary>
    [Label("MORPHACT_EDRAIN")]
    EDrain = 26,

    /// <summary>Alternative ladder climbing animation.</summary>
    [Label("MORPHACT_LADDER2")]
    Ladder2 = 27,

    /// <summary>Alternative rope climbing animation.</summary>
    [Label("MORPHACT_ROPE2")]
    Rope2 = 28,

    /// <summary>Storm Break skill animation.</summary>
    [Label("MORPHACT_STORM_BREAK")]
    [Label("Storm Break", 1)]
    StormBreak = 29,

    /// <summary>Double Fire skill animation.</summary>
    [Label("MORPHACT_DOUBLEFIRE")]
    [Label("Double Fire", 1)]
    DoubleFire = 30,

    /// <summary>Somersault Kick skill animation.</summary>
    [Label("MORPHACT_SOMERSAULT")]
    Somersault = 31,

    /// <summary>Straight punch skill animation.</summary>
    [Label("MORPHACT_STRAIGHT")]
    Straight = 32,

    /// <summary>Corkscrew Blow skill animation.</summary>
    [Label("MORPHACT_SCREW")]
    Screw = 33,

    /// <summary>Double Uppercut skill animation.</summary>
    [Label("MORPHACT_DOUBLEUPPER")]
    [Label("Double Upper", 1)]
    DoubleUpper = 34,

    /// <summary>Back Spin Kick skill animation.</summary>
    [Label("MORPHACT_BACKSPIN")]
    [Label("Back Spin", 1)]
    BackSpin = 35,

    /// <summary>Energy Orb skill animation.</summary>
    [Label("MORPHACT_EORB")]
    EOrb = 36,

    /// <summary>Fist attack animation.</summary>
    [Label("MORPHACT_FIST")]
    Fist = 37,

    /// <summary>Dragon Strike skill animation.</summary>
    [Label("MORPHACT_DRAGONSTRIKE")]
    [Label("Dragon Strike", 1)]
    DragonStrike = 38,

    /// <summary>Recovery/healing animation.</summary>
    [Label("MORPHACT_RECOVERY")]
    Recovery = 39,

    /// <summary>Wave skill animation.</summary>
    [Label("MORPHACT_WAVE")]
    Wave = 40,

    /// <summary>Flying animation, type 2.</summary>
    [Label("MORPHACT_FLY2")]
    Fly2 = 41,

    /// <summary>Flying type 2 with movement.</summary>
    [Label("MORPHACT_FLY2_MOVE")]
    Fly2Move = 42,

    /// <summary>Flying type 2 skill attack.</summary>
    [Label("MORPHACT_FLY2_SKILL")]
    Fly2Skill = 43,

    /// <summary>Shockwave skill animation.</summary>
    [Label("MORPHACT_SHOCKWAVE")]
    Shockwave = 44,

    /// <summary>Demolition skill animation.</summary>
    [Label("MORPHACT_DEMOLITION")]
    Demolition = 45,

    /// <summary>Snatch skill animation.</summary>
    [Label("MORPHACT_SNATCH")]
    Snatch = 46,

    /// <summary>Wind Spear skill animation.</summary>
    [Label("MORPHACT_WIND_SPEAR")]
    [Label("Wind Spear", 1)]
    WindSpear = 47,

    /// <summary>Wind Shot skill animation.</summary>
    [Label("MORPHACT_WIND_SHOT")]
    [Label("Wind Shot", 1)]
    WindShot = 48,
}
