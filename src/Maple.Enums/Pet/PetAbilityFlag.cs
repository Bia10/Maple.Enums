using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Pet ability flags for pet pickup/consume behavior.
/// </summary>
[Flags]
public enum PetAbilityFlag : byte
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Pet automatically picks up mesos.</summary>
    [Label("PETABIL_PICKUP_MESO")]
    [Label("Pickup Meso", 1)]
    PickupMeso = 0x1,

    /// <summary>Pet automatically picks up items.</summary>
    [Label("PETABIL_PICKUP_ITEM")]
    [Label("Pickup Item", 1)]
    PickupItem = 0x2,

    /// <summary>Pet picks up items dropped by other players.</summary>
    [Label("PETABIL_PICKUP_OTHERS")]
    [Label("Pickup Others", 1)]
    PickupOthers = 0x4,

    /// <summary>Pet picks up items from a longer range.</summary>
    [Label("PETABIL_PICKUP_LONGRANGE")]
    [Label("Pickup Long Range", 1)]
    PickupLongRange = 0x8,

    /// <summary>Pet sweeps the area for dropped items.</summary>
    [Label("PETABIL_PICKUP_SWEEPFORDROP")]
    [Label("Pickup Sweep For Drop", 1)]
    PickupSweepForDrop = 0x10,

    /// <summary>Pet auto-consumes HP recovery items.</summary>
    [Label("PETABIL_CONSUME_HP")]
    [Label("Consume HP", 1)]
    ConsumeHP = 0x20,

    /// <summary>Pet auto-consumes MP recovery items.</summary>
    [Label("PETABIL_CONSUME_MP")]
    [Label("Consume MP", 1)]
    ConsumeMP = 0x40,

    /// <summary>Pet ignores specified items during pickup.</summary>
    [Label("PETABIL_IGNORE_ITEMS")]
    [Label("Ignore Items", 1)]
    IgnoreItems = 0x80,
}
