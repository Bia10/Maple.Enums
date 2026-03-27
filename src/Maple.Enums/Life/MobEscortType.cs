using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Escort sub-type of a mob template (<c>CMobTemplate.nEscortType</c>,
/// WZ key <c>info/escort</c>).
/// Determines whether a mob participates in an escort mission and in which
/// capacity.
/// </summary>
/// <remarks>
/// Loaded by <c>CMobTemplate::RegisterMob</c> into <c>CMobTemplate.nEscortType</c>
/// from <c>Mob.wz/{id}.img/info/escort</c>.
/// Escort targets always use movement ability 6 (<c>nMoveAbility = 6</c>,
/// path-following).  The client branches on <c>nEscortType == 1</c>
/// throughout <c>CMob</c> for combat eligibility, damage timing,
/// chase-target selection, and the escort-stop action loop.
/// </remarks>
public enum MobEscortType : byte
{
    /// <summary>
    /// Standard mob — not part of any escort sequence.
    /// Default value when the <c>escort</c> WZ key is absent.
    /// </summary>
    None = 0,

    /// <summary>
    /// Escort target — a mob that players must protect while it follows
    /// a scripted path.  Enables special movement logic
    /// (<c>CVecCtrlMob::EscortDest</c>), modified hit-rate timers,
    /// escort-stop dialogue (<c>LP_MobEscortStopSay</c>, opcode 306),
    /// and the client-side escort-stop action repeat loop.
    /// </summary>
    [Label("Escort Target", 1)]
    EscortTarget = 1,
}
