using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Avatar/character animation layer type.
/// Specifies which animation layer to display an effect on.
/// </summary>
public enum AnimationLayerType : byte
{
    /// <summary>Set item visual effect.</summary>
    [Label("AL_SETITEMEFFECT")]
    [Label("Set Item Effect", 1)]
    SetItemEffect = 0,

    /// <summary>Set item background glow.</summary>
    [Label("AL_SETITEMBACKGROUND")]
    [Label("Set Item Background", 1)]
    SetItemBackground = 1,

    /// <summary>GM / admin aura effect.</summary>
    [Label("AL_ADMINEFFECT")]
    [Label("Admin Effect", 1)]
    AdminEffect = 2,

    /// <summary>Active equip item effect.</summary>
    [Label("AL_ACTIVEITEMEFFECT")]
    [Label("Active Item Effect", 1)]
    ActiveItemEffect = 3,

    /// <summary>Carry item effect.</summary>
    [Label("AL_CARRYITEMEFFECT")]
    [Label("Carry Item Effect", 1)]
    CarryItemEffect = 4,

    /// <summary>Aran combo counter display.</summary>
    [Label("AL_COMBOCOUNTER")]
    [Label("Combo Counter", 1)]
    ComboCounter = 5,

    /// <summary>Jukebox music note effect.</summary>
    [Label("AL_JUKEBOXEFFECT")]
    [Label("Jukebox Effect", 1)]
    JukeboxEffect = 6,

    /// <summary>Couple ring item effect.</summary>
    [Label("AL_COUPLEITEMEFFECT")]
    [Label("Couple Item Effect", 1)]
    CoupleItemEffect = 7,

    /// <summary>New Year card effect.</summary>
    [Label("AL_NEWYEARCARDEFFECT")]
    [Label("New Year Card Effect", 1)]
    NewYearCardEffect = 8,

    /// <summary>Map-specific overlay effect.</summary>
    [Label("AL_MAPSPECIFICEFFECT")]
    [Label("Map Specific Effect", 1)]
    MapSpecificEffect = 9,

    /// <summary>Portable seat effect.</summary>
    [Label("AL_PORTABLESEATEFFECT")]
    [Label("Portable Seat Effect", 1)]
    PortableSeatEffect = 10,

    /// <summary>Active item follow effect.</summary>
    [Label("AL_ACTIVEITEMFOLLOWEFFECT")]
    [Label("Active Item Follow Effect", 1)]
    ActiveItemFollowEffect = 11,

    /// <summary>Friend ring item effect.</summary>
    [Label("AL_FRIENDITEMEFFECT")]
    [Label("Friend Item Effect", 1)]
    FriendItemEffect = 12,

    /// <summary>Dark Knight dark force aura.</summary>
    [Label("AL_DARK_FORCE")]
    [Label("Dark Force", 1)]
    DarkForce = 13,

    /// <summary>Wedding ring effect.</summary>
    [Label("AL_WEDDINGRINGEFFECT")]
    [Label("Wedding Ring Effect", 1)]
    WeddingRingEffect = 14,

    /// <summary>Aran energy charge aura.</summary>
    [Label("AL_ENERGY_CHARGE")]
    [Label("Energy Charge", 1)]
    EnergyCharge = 15,

    /// <summary>Pirate dash trail.</summary>
    [Label("AL_DASH")]
    Dash = 16,

    /// <summary>Wing / flying effect.</summary>
    [Label("AL_WINGS")]
    Wings = 17,

    /// <summary>Couple chair shared effect.</summary>
    [Label("AL_COUPLECHAIREFFECT")]
    [Label("Couple Chair Effect", 1)]
    CoupleChairEffect = 18,
}
