using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Summoned attack AI type.
/// Classifies the attack behavior of summoned creatures.
/// </summary>
public enum SummonedAttackAiType : byte
{
    /// <summary>Basic attack AI.</summary>
    [Label("AI_ATTACK")]
    Attack = 0,

    /// <summary>Self-destruct on contact.</summary>
    [Label("AI_SELFDESTRUCT")]
    [Label("Self Destruct", 1)]
    SelfDestruct = 1,

    /// <summary>Healing pulse AI.</summary>
    [Label("AI_HEAL")]
    Heal = 2,

    /// <summary>Tesla coil formation AI.</summary>
    [Label("AI_TESLACOIL_TRIANGLE")]
    [Label("Tesla Coil Triangle", 1)]
    TeslaCoilTriangle = 3,
}
