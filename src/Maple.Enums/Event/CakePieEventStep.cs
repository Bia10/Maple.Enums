using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cake vs. Pie event phase.
/// </summary>
public enum CakePieEventStep : byte
{
    /// <summary>Event inactive.</summary>
    [Label("CakePieEvent_Step_None")]
    None = 0,

    /// <summary>Preparation phase.</summary>
    [Label("CakePieEvent_Step_Ready")]
    Ready = 1,

    /// <summary>Event in progress.</summary>
    [Label("CakePieEvent_Step_Event")]
    Event = 2,

    /// <summary>Winner announced.</summary>
    [Label("CakePieEvent_Step_Winner")]
    Winner = 3,
}
