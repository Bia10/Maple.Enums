using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Buddy list (friend list) operation codes.
/// </summary>
public enum FriendOperation : byte
{
    /// <summary>Load buddy list.</summary>
    [Label("FriendReq_LoadFriend")]
    [Label("Req Load Friend", 1)]
    ReqLoadFriend = 0,

    /// <summary>Send friend request.</summary>
    [Label("FriendReq_SetFriend")]
    [Label("Req Set Friend", 1)]
    ReqSetFriend = 1,

    /// <summary>Accept friend request.</summary>
    [Label("FriendReq_AcceptFriend")]
    [Label("Req Accept Friend", 1)]
    ReqAcceptFriend = 2,

    /// <summary>Remove a friend.</summary>
    [Label("FriendReq_DeleteFriend")]
    [Label("Req Delete Friend", 1)]
    ReqDeleteFriend = 3,

    /// <summary>Notify friend logged in.</summary>
    [Label("FriendReq_NotifyLogin")]
    [Label("Req Notify Login", 1)]
    ReqNotifyLogin = 4,

    /// <summary>Notify friend logged out.</summary>
    [Label("FriendReq_NotifyLogout")]
    [Label("Req Notify Logout", 1)]
    ReqNotifyLogout = 5,

    /// <summary>Increase buddy list capacity.</summary>
    [Label("FriendReq_IncMaxCount")]
    [Label("Req Inc Max Count", 1)]
    ReqIncMaxCount = 6,

    /// <summary>Buddy list loaded.</summary>
    [Label("FriendRes_LoadFriend_Done")]
    [Label("Res Load Friend Done", 1)]
    ResLoadFriendDone = 7,

    /// <summary>Friend info changed.</summary>
    [Label("FriendRes_NotifyChange_FriendInfo")]
    [Label("Res Notify Change Friend Info", 1)]
    ResNotifyChangeFriendInfo = 8,

    /// <summary>Friend invitation received.</summary>
    [Label("FriendRes_Invite")]
    [Label("Res Invite", 1)]
    ResInvite = 9,

    /// <summary>Friend added.</summary>
    [Label("FriendRes_SetFriend_Done")]
    [Label("Res Set Friend Done", 1)]
    ResSetFriendDone = 10,

    /// <summary>My buddy list full.</summary>
    [Label("FriendRes_SetFriend_FullMe")]
    [Label("Res Set Friend Full Me", 1)]
    ResSetFriendFullMe = 11,

    /// <summary>Their buddy list full.</summary>
    [Label("FriendRes_SetFriend_FullOther")]
    [Label("Res Set Friend Full Other", 1)]
    ResSetFriendFullOther = 12,

    /// <summary>Already friends.</summary>
    [Label("FriendRes_SetFriend_AlreadySet")]
    [Label("Res Set Friend Already Set", 1)]
    ResSetFriendAlreadySet = 13,

    /// <summary>Target is a GM.</summary>
    [Label("FriendRes_SetFriend_Master")]
    [Label("Res Set Friend Master", 1)]
    ResSetFriendMaster = 14,

    /// <summary>Unknown user.</summary>
    [Label("FriendRes_SetFriend_UnknownUser")]
    [Label("Res Set Friend Unknown User", 1)]
    ResSetFriendUnknownUser = 15,

    /// <summary>Unknown error.</summary>
    [Label("FriendRes_SetFriend_Unknown")]
    [Label("Res Set Friend Unknown", 1)]
    ResSetFriendUnknown = 16,

    /// <summary>Accept failed, unknown.</summary>
    [Label("FriendRes_AcceptFriend_Unknown")]
    [Label("Res Accept Friend Unknown", 1)]
    ResAcceptFriendUnknown = 17,

    /// <summary>Friend removed.</summary>
    [Label("FriendRes_DeleteFriend_Done")]
    [Label("Res Delete Friend Done", 1)]
    ResDeleteFriendDone = 18,

    /// <summary>Delete failed, unknown.</summary>
    [Label("FriendRes_DeleteFriend_Unknown")]
    [Label("Res Delete Friend Unknown", 1)]
    ResDeleteFriendUnknown = 19,

    /// <summary>General notification.</summary>
    [Label("FriendRes_Notify")]
    [Label("Res Notify", 1)]
    ResNotify = 20,

    /// <summary>Capacity increased.</summary>
    [Label("FriendRes_IncMaxCount_Done")]
    [Label("Res Inc Max Count Done", 1)]
    ResIncMaxCountDone = 21,

    /// <summary>Capacity increase failed.</summary>
    [Label("FriendRes_IncMaxCount_Unknown")]
    [Label("Res Inc Max Count Unknown", 1)]
    ResIncMaxCountUnknown = 22,

    /// <summary>Please wait.</summary>
    [Label("FriendRes_PleaseWait")]
    [Label("Res Please Wait", 1)]
    ResPleaseWait = 23,
}
