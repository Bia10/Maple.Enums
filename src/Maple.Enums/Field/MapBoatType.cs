using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Ship/boat kind for continental-move maps (<c>CShip.m_nShipKind</c>, WZ key <c>ship/shipKind</c>).
/// Determines whether the ship transition is a regular ferry or a premium ferry
/// that must appear and disappear explicitly.
/// </summary>
/// <remarks>
/// Loaded by <c>CShip::Init</c> (SP[1507] = "shipKind") from the <c>ship/</c> sub-property
/// of a <c>FIELDTYPE_CONTIMOVE</c> map (<c>CField_ContiMove</c>).
/// Only values 0 and 1 are handled by the client — the board-ship packet
/// (<c>CP_CField_ContiMove</c>, opcode 264) is sent only when <c>m_nShipKind &lt;= 1</c>.
/// </remarks>
public enum MapBoatType : byte
{
    /// <summary>
    /// Regular ferry that boards automatically when the player enters the
    /// continental-move field (uses <c>CShip::EnterShipMove</c> /
    /// <c>CShip::LeaveShipMove</c>).
    /// </summary>
    [Label("Regular Ferry", 1)]
    Regular = 0,

    /// <summary>
    /// Premium ferry that physically appears and disappears on a schedule
    /// (uses <c>CShip::AppearShip</c> / <c>CShip::DisappearShip</c>).
    /// The field state machine cycles through <c>Wait → Move</c> and the
    /// boat sprite is shown/hidden accordingly.
    /// </summary>
    [Label("Premium Ferry", 1)]
    Premium = 1,
}
