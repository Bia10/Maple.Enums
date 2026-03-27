using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Activation state of an NPC's server-directed special action
/// (<c>CNpc.m_bSpecialAction</c>).
/// </summary>
/// <remarks>
/// Individual NPC actions are designated "special" via the boolean WZ key
/// <c>special</c> (SP[2534]) under each
/// <c>Npc.wz/{id}.img/{actionName}/</c> node.  The total count of such
/// specially flagged actions is cached in
/// <c>CNpcTemplate.nSpecialAct</c>.
/// <para>
/// At runtime, whenever the NPC's current action index falls in the
/// special range
/// (<c>actionIndex &gt;= totalActions - nSpecialAct</c>),
/// <c>CNpc.m_bSpecialAction</c> transitions to <see cref="Active"/> and
/// the client emits <c>CP_NpcSpecialAction</c> (opcode 242) carrying the
/// NPC object ID and the WZ action-name string.  The server responds with
/// <c>LP_NpcSpecialAction</c> (opcode 316) to broadcast the action to
/// nearby clients.  While <see cref="Active"/>, further incoming
/// <c>LP_NpcSpecialAction</c> packets are silently discarded by
/// <c>CNpc::OnSetSpecialAction</c>.
/// </para>
/// </remarks>
public enum NpcSpecialActionType : byte
{
    /// <summary>
    /// NPC is not currently performing a server-directed special action;
    /// the normal stand/move animation cycle is active.
    /// </summary>
    None = 0,

    /// <summary>
    /// NPC is actively playing a server-directed special action sourced
    /// from its <c>CNpcTemplate.aAct</c> list.
    /// </summary>
    [Label("Active", 1)]
    Active = 1,
}
