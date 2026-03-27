using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Indicates whether a mob participates in an escort mission as a protected target.
/// </summary>
public enum MobEscortType : byte
{
    /// <summary>
    /// Standard mob; not part of any escort sequence.
    /// </summary>
    None = 0,

    /// <summary>
    /// Mob that players must protect while it follows a scripted path.
    /// Uses path-following movement and triggers escort-stop dialogue when attacked.
    /// </summary>
    [Label("Escort Target", 1)]
    EscortTarget = 1,
}
