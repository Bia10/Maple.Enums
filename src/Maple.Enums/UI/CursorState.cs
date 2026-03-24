using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mouse cursor states.
/// </summary>
public enum CursorState : byte
{
    /// <summary>Default arrow cursor.</summary>
    [Label("CURSOR_STATE_NORMAL")]
    Normal = 0,

    /// <summary>Hovering over NPC.</summary>
    [Label("CURSOR_STATE_ONNPC")]
    [Label("On Npc", 1)]
    OnNpc = 1,

    /// <summary>Hovering over game balloon.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("CURSOR_STATE_ONGAMEBALOON")]
    [Label("On Game Balloon", 1)]
    OnGameBalloon = 2,

    /// <summary>Hovering over mini-room balloon.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("CURSOR_STATE_ONMINIROOMBALOON")]
    [Label("On Mini Room Balloon", 1)]
    OnMiniRoomBalloon = 3,

    /// <summary>Hovering over button.</summary>
    [Label("CURSOR_STATE_ONBUTTON")]
    [Label("On Button", 1)]
    OnButton = 4,

    /// <summary>Draggable element.</summary>
    [Label("CURSOR_STATE_DRAGGABLE")]
    Draggable = 5,

    /// <summary>Cash shop button hover.</summary>
    [Label("CURSOR_STATE_ONBTCASHSHOP")]
    [Label("On Cash Shop Button", 1)]
    OnCashShopButton = 6,

    /// <summary>Vertical scroll available.</summary>
    [Label("CURSOR_STATE_VERTICALSCROLLABLE")]
    [Label("Vertical Scrollable", 1)]
    VerticalScrollable = 7,

    /// <summary>Horizontal scroll available.</summary>
    [Label("CURSOR_STATE_HORIZONTALSCROLLABLE")]
    [Label("Horizontal Scrollable", 1)]
    HorizontalScrollable = 8,

    /// <summary>On vertical scrollbar.</summary>
    [Label("CURSOR_STATE_ONSCROLLVERTICAL")]
    [Label("On Scroll Vertical", 1)]
    OnScrollVertical = 9,

    /// <summary>On horizontal scrollbar.</summary>
    [Label("CURSOR_STATE_ONSCROLLHORIZONTAL")]
    [Label("On Scroll Horizontal", 1)]
    OnScrollHorizontal = 10,

    /// <summary>Actively dragging.</summary>
    [Label("CURSOR_STATE_ONDRAG")]
    [Label("On Drag", 1)]
    OnDrag = 11,

    /// <summary>Mouse click state.</summary>
    [Label("CURSOR_STATE_CLICK")]
    Click = 12,

    /// <summary>Unknown cursor state.</summary>
    [Label("CURSOR_STATE_UNKNOWN")]
    Unknown = 13,

    /// <summary>Magnifying glass idle.</summary>
    [Label("CURSOR_STATE_MAGNIFYING_NORMAL")]
    [Label("Magnifying Normal", 1)]
    MagnifyingNormal = 14,

    /// <summary>Magnifying glass clicked.</summary>
    [Label("CURSOR_STATE_MAGNIFYING_CLICK")]
    [Label("Magnifying Click", 1)]
    MagnifyingClick = 15,

    /// <summary>Magnifying complete.</summary>
    [Label("CURSOR_STATE_MAGNIFYING_DONE")]
    [Label("Magnifying Done", 1)]
    MagnifyingDone = 16,

    /// <summary>Sentinel / end marker.</summary>
    [Label("CURSOR_STATE_NO")]
    No = 17,
}
