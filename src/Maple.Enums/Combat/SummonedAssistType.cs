using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Summoned creature AI assist behavior type.</summary>
public enum SummonedAssistType : byte
{
    /// <summary>No assist behavior.</summary>
    None = 0,

    /// <summary>Auto-attack nearby mobs.</summary>
    Attack = 1,

    /// <summary>Auto-heal party members.</summary>
    Heal = 2,

    /// <summary>Enhanced auto-attack.</summary>
    [Label("Attack Ex", 1)]
    AttackEx = 3,

    /// <summary>Summon sub-creature.</summary>
    Summon = 4,

    /// <summary>Player-directed attack.</summary>
    [Label("Attack Manual", 1)]
    AttackManual = 5,

    /// <summary>Counter-attack on hit.</summary>
    [Label("Attack Counter", 1)]
    AttackCounter = 6,
}
