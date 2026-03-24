using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Pet animation action type.
/// </summary>
public enum PetActionType : byte
{
    /// <summary>Pet is moving.</summary>
    [Label("PETACT_MOVE")]
    Move = 0,

    /// <summary>Primary standing idle animation.</summary>
    [Label("PETACT_STAND0")]
    Stand0 = 1,

    /// <summary>Secondary standing idle animation.</summary>
    [Label("PETACT_STAND1")]
    Stand1 = 2,

    /// <summary>Pet is jumping.</summary>
    [Label("PETACT_JUMP")]
    Jump = 3,

    /// <summary>Pet is flying.</summary>
    [Label("PETACT_FLY")]
    Fly = 4,

    /// <summary>Pet is hungry (low fullness).</summary>
    [Label("PETACT_HUNGRY")]
    Hungry = 5,

    /// <summary>Primary resting animation.</summary>
    [Label("PETACT_REST0")]
    Rest0 = 6,

    /// <summary>Secondary resting animation.</summary>
    [Label("PETACT_REST1")]
    Rest1 = 7,

    /// <summary>Pet is hanging (e.g. on a rope).</summary>
    [Label("PETACT_HANG")]
    Hang = 8,

    /// <summary>Custom user-defined pet action.</summary>
    [Label("PETACT_CUSTOM")]
    Custom = 9,
}
