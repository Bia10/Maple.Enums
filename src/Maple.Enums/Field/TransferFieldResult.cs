using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Map transfer (field warp) result codes.
/// </summary>
public enum TransferFieldResult : byte
{
    /// <summary>Transfer succeeded.</summary>
    [Label("TF_DONE")]
    Done = 0,

    /// <summary>Portal is disabled.</summary>
    [Label("TF_DISABLED_PORTAL")]
    [Label("Disabled Portal", 1)]
    DisabledPortal = 1,

    /// <summary>Maps are not linked.</summary>
    [Label("TF_NOT_CONNECTED_AREA")]
    [Label("Not Connected Area", 1)]
    NotConnectedArea = 2,

    /// <summary>Level requirement not met.</summary>
    [Label("TF_NOT_ALLOWED_LEVEL")]
    [Label("Not Allowed Level", 1)]
    NotAllowedLevel = 3,

    /// <summary>Item level requirement not met.</summary>
    [Label("TF_NOT_ALLOWED_LEVEL_ITEM")]
    [Label("Not Allowed Level Item", 1)]
    NotAllowedLevelItem = 4,

    /// <summary>Monster Dungeon level gate.</summary>
    [Label("TF_NOT_ALLOWED_LEVEL_MD")]
    [Label("Not Allowed Level MD", 1)]
    NotAllowedLevelMD = 5,

    /// <summary>Party required to enter.</summary>
    [Label("TF_PARTY_ONLY")]
    [Label("Party Only", 1)]
    PartyOnly = 6,

    /// <summary>Expedition required to enter.</summary>
    [Label("TF_EXPEDITION_ONLY")]
    [Label("Expedition Only", 1)]
    ExpeditionOnly = 7,

    /// <summary>Cannot warp while in shop.</summary>
    [Label("TF_NOT_AVAILABLE_SHOP")]
    [Label("Not Available Shop", 1)]
    NotAvailableShop = 8,
}
