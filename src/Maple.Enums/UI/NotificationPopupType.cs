using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Notification popup (fade window) types shown to the player.
/// </summary>
public enum NotificationPopupType : byte
{
    /// <summary>Messenger invitation popup.</summary>
    [Label("MSMInvite")]
    MessengerInvite = 0,

    /// <summary>Friend request popup.</summary>
    [Label("FriendReq")]
    FriendRequest = 1,

    /// <summary>Trade invitation popup.</summary>
    [Label("TradeInvite")]
    TradeInvite = 2,

    /// <summary>Cash trade invitation popup.</summary>
    [Label("CashTradeInvite")]
    CashTradeInvite = 3,

    /// <summary>New memo/note received popup.</summary>
    [Label("NewMemo")]
    NewMemo = 4,

    /// <summary>Party invitation popup.</summary>
    [Label("PartyInvite")]
    PartyInvite = 5,

    /// <summary>Alliance invitation popup.</summary>
    [Label("AllianceInvite")]
    AllianceInvite = 6,

    /// <summary>Quest completion popup.</summary>
    [Label("QuestClear")]
    QuestClear = 7,

    /// <summary>Guild invitation popup.</summary>
    [Label("GuildInvite")]
    GuildInvite = 8,

    /// <summary>User alarm notification popup.</summary>
    [Label("UserAlarm")]
    UserAlarm = 9,

    /// <summary>Parcel/mail alarm notification popup.</summary>
    [Label("ParcelAlarm")]
    ParcelAlarm = 10,

    /// <summary>Party quest alarm popup.</summary>
    [Label("PartyQuestAlarm")]
    PartyQuestAlarm = 11,

    /// <summary>Family invitation popup.</summary>
    [Label("FamilyInvite")]
    FamilyInvite = 12,

    /// <summary>Party application popup.</summary>
    [Label("PartyApply")]
    PartyApply = 13,

    /// <summary>Expedition invitation popup.</summary>
    [Label("ExpeditionInvite")]
    ExpeditionInvite = 14,

    /// <summary>Expedition application popup.</summary>
    [Label("ExpeditionApply")]
    ExpeditionApply = 15,

    /// <summary>Follow request popup.</summary>
    [Label("FollowRequest")]
    FollowRequest = 16,

    /// <summary>New Year card arrival popup.</summary>
    [Label("NewYearCardArrived")]
    NewYearCardArrived = 17,
}
