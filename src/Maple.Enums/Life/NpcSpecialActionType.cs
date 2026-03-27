using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Activation state of an NPC's special action, which is triggered by the server
/// outside the NPC's normal stand/move animation cycle.
/// </summary>
public enum NpcSpecialActionType : byte
{
    /// <summary>
    /// NPC is in its normal stand/move animation cycle; no special action is active.
    /// </summary>
    None = 0,

    /// <summary>
    /// NPC is playing a server-directed special action.
    /// Further special-action requests are ignored until the action completes.
    /// </summary>
    [Label("Active", 1)]
    Active = 1,
}
