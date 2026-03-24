using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character movement action state.
/// IMPORTANT: MA_WALK = 1 (not 0). MA_STAND = 2.
/// WZ animation names differ: "stand1" → Stand, "walk1" → Walk.
/// </summary>
/// <remarks>
/// Label indices: 0 = V95 PDB name, 2 = WZ animation name, 3 = alternate alias.
/// Index 1 is omitted because the display name matches the member name.
/// </remarks>
public enum MoveActionType : byte
{
    /// <summary>Walking movement.</summary>
    [Label("MA_WALK")]
    [Label("walk1", 2)]
    [Label("MA_MOVE", 3)]
    Walk = 1,

    /// <summary>Standing idle.</summary>
    [Label("MA_STAND")]
    [Label("stand1", 2)]
    Stand = 2,

    /// <summary>Jumping.</summary>
    [Label("MA_JUMP")]
    [Label("jump", 2)]
    Jump = 3,

    /// <summary>Alert / hit reaction.</summary>
    [Label("MA_ALERT")]
    [Label("alert", 2)]
    Alert = 4,

    /// <summary>Prone (lying down).</summary>
    [Label("MA_PRONE")]
    [Label("prone", 2)]
    Prone = 5,

    /// <summary>Flying, type 1.</summary>
    [Label("MA_FLY1")]
    [Label("fly", 2)]
    Fly1 = 6,

    /// <summary>Climbing ladder.</summary>
    [Label("MA_LADDER")]
    [Label("ladder", 2)]
    Ladder = 7,

    /// <summary>Climbing rope.</summary>
    [Label("MA_ROPE")]
    [Label("rope", 2)]
    Rope = 8,

    /// <summary>Death animation.</summary>
    [Label("MA_DEAD")]
    [Label("dead", 2)]
    Dead = 9,

    /// <summary>Sitting on chair.</summary>
    [Label("MA_SIT")]
    [Label("sit", 2)]
    Sit = 10,

    /// <summary>Alternative standing pose.</summary>
    [Label("MA_STAND0")]
    [Label("stand0", 2)]
    Stand0 = 11,

    /// <summary>Pet hungry state.</summary>
    [Label("MA_HUNGRY")]
    [Label("hungry", 2)]
    Hungry = 12,

    /// <summary>Pet rest, type 0.</summary>
    [Label("MA_REST0")]
    [Label("rest0", 2)]
    Rest0 = 13,

    /// <summary>Pet rest, type 1.</summary>
    [Label("MA_REST1")]
    [Label("rest1", 2)]
    Rest1 = 14,

    /// <summary>Hanging from platform.</summary>
    [Label("MA_HANG")]
    [Label("hang", 2)]
    Hang = 15,

    /// <summary>Mob chase movement.</summary>
    [Label("MA_CHASE")]
    Chase = 16,

    /// <summary>Flying, type 2.</summary>
    [Label("MA_FLY2")]
    Fly2 = 17,

    /// <summary>Flying type 2 with movement.</summary>
    [Label("MA_FLY2_MOVE")]
    Fly2Move = 18,

    /// <summary>Dash, type 2.</summary>
    [Label("MA_DASH2")]
    Dash2 = 19,

    /// <summary>Mechanic rocket booster.</summary>
    [Label("MA_ROCKET_BOOSTER")]
    [Label("Rocket Booster", 1)]
    RocketBooster = 20,

    /// <summary>Tesla coil triangle stance.</summary>
    [Label("MA_TESLA_COIL_TRIANGLE")]
    [Label("Tesla Coil Triangle", 1)]
    TeslaCoilTriangle = 21,
}
