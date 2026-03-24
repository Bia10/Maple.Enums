using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob suspend state.
/// Describes why a mob is in a suspended animation state.
/// </summary>
public enum MobSuspendType : byte
{
    /// <summary>No suspend state.</summary>
    [Label("SUSPEND_NONE")]
    None = 0,

    /// <summary>Suspended during initialization.</summary>
    [Label("SUSPEND_INIT")]
    Init = 1,

    /// <summary>Suspended during death animation.</summary>
    [Label("SUSPEND_DIE")]
    Die = 2,

    /// <summary>Suspended during bomb/self-destruct.</summary>
    [Label("SUSPEND_BOMB")]
    Bomb = 3,

    /// <summary>Suspended while being swallowed.</summary>
    [Label("SUSPEND_SWALLOW")]
    Swallow = 4,
}
