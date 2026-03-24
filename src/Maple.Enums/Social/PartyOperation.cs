using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Party, expedition, and party advertisement operation codes.
/// </summary>
public enum PartyOperation : byte
{
    /// <summary>Client request to load party data.</summary>
    [Label("PartyReq_LoadParty")]
    [Label("Party Req Load Party", 1)]
    PartyReqLoadParty = 0,

    /// <summary>Client request to create a new party.</summary>
    [Label("PartyReq_CreateNewParty")]
    [Label("Party Req Create New Party", 1)]
    PartyReqCreateNewParty = 1,

    /// <summary>Client request to withdraw from a party.</summary>
    [Label("PartyReq_WithdrawParty")]
    [Label("Party Req Withdraw Party", 1)]
    PartyReqWithdrawParty = 2,

    /// <summary>Client request to join a party.</summary>
    [Label("PartyReq_JoinParty")]
    [Label("Party Req Join Party", 1)]
    PartyReqJoinParty = 3,

    /// <summary>Client request to invite a player to the party.</summary>
    [Label("PartyReq_InviteParty")]
    [Label("Party Req Invite Party", 1)]
    PartyReqInviteParty = 4,

    /// <summary>Client request to kick a member from the party.</summary>
    [Label("PartyReq_KickParty")]
    [Label("Party Req Kick Party", 1)]
    PartyReqKickParty = 5,

    /// <summary>Client request to change the party leader.</summary>
    [Label("PartyReq_ChangePartyBoss")]
    [Label("Party Req Change Party Boss", 1)]
    PartyReqChangePartyBoss = 6,

    /// <summary>Server response: party data loaded successfully.</summary>
    [Label("PartyRes_LoadParty_Done")]
    [Label("Party Res Load Party Done", 1)]
    PartyResLoadPartyDone = 7,

    /// <summary>Server response: new party created successfully.</summary>
    [Label("PartyRes_CreateNewParty_Done")]
    [Label("Party Res Create New Party Done", 1)]
    PartyResCreateNewPartyDone = 8,

    /// <summary>Create party failed: already joined a party.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("PartyRes_CreateNewParty_AlreayJoined")]
    [Label("Party Res Create New Party Already Joined", 1)]
    PartyResCreateNewPartyAlreadyJoined = 9,

    /// <summary>Create party failed: beginners cannot create parties.</summary>
    [Label("PartyRes_CreateNewParty_Beginner")]
    [Label("Party Res Create New Party Beginner", 1)]
    PartyResCreateNewPartyBeginner = 10,

    /// <summary>Create party failed: unknown error.</summary>
    [Label("PartyRes_CreateNewParty_Unknown")]
    [Label("Party Res Create New Party Unknown", 1)]
    PartyResCreateNewPartyUnknown = 11,

    /// <summary>Server response: withdrew from party successfully.</summary>
    [Label("PartyRes_WithdrawParty_Done")]
    [Label("Party Res Withdraw Party Done", 1)]
    PartyResWithdrawPartyDone = 12,

    /// <summary>Withdraw failed: not joined in a party.</summary>
    [Label("PartyRes_WithdrawParty_NotJoined")]
    [Label("Party Res Withdraw Party Not Joined", 1)]
    PartyResWithdrawPartyNotJoined = 13,

    /// <summary>Withdraw failed: unknown error.</summary>
    [Label("PartyRes_WithdrawParty_Unknown")]
    [Label("Party Res Withdraw Party Unknown", 1)]
    PartyResWithdrawPartyUnknown = 14,

    /// <summary>Server response: joined party successfully.</summary>
    [Label("PartyRes_JoinParty_Done")]
    [Label("Party Res Join Party Done", 1)]
    PartyResJoinPartyDone = 15,

    /// <summary>Server response: joined party successfully (alternate).</summary>
    [Label("PartyRes_JoinParty_Done2")]
    [Label("Party Res Join Party Done2", 1)]
    PartyResJoinPartyDone2 = 16,

    /// <summary>Join failed: already joined a party.</summary>
    [Label("PartyRes_JoinParty_AlreadyJoined")]
    [Label("Party Res Join Party Already Joined", 1)]
    PartyResJoinPartyAlreadyJoined = 17,

    /// <summary>Join failed: party is already full.</summary>
    [Label("PartyRes_JoinParty_AlreadyFull")]
    [Label("Party Res Join Party Already Full", 1)]
    PartyResJoinPartyAlreadyFull = 18,

    /// <summary>Join failed: party exceeds desired size.</summary>
    [Label("PartyRes_JoinParty_OverDesiredSize")]
    [Label("Party Res Join Party Over Desired Size", 1)]
    PartyResJoinPartyOverDesiredSize = 19,

    /// <summary>Join failed: target user not found.</summary>
    [Label("PartyRes_JoinParty_UnknownUser")]
    [Label("Party Res Join Party Unknown User", 1)]
    PartyResJoinPartyUnknownUser = 20,

    /// <summary>Join failed: unknown error.</summary>
    [Label("PartyRes_JoinParty_Unknown")]
    [Label("Party Res Join Party Unknown", 1)]
    PartyResJoinPartyUnknown = 21,

    /// <summary>Server response: party invite sent.</summary>
    [Label("PartyRes_InviteParty_Sent")]
    [Label("Party Res Invite Party Sent", 1)]
    PartyResInvitePartySent = 22,

    /// <summary>Invite failed: user is blocked.</summary>
    [Label("PartyRes_InviteParty_BlockedUser")]
    [Label("Party Res Invite Party Blocked User", 1)]
    PartyResInvitePartyBlockedUser = 23,

    /// <summary>Invite failed: user already invited.</summary>
    [Label("PartyRes_InviteParty_AlreadyInvited")]
    [Label("Party Res Invite Party Already Invited", 1)]
    PartyResInvitePartyAlreadyInvited = 24,

    /// <summary>Invite failed: user already invited by this inviter.</summary>
    [Label("PartyRes_InviteParty_AlreadyInvitedByInviter")]
    [Label("Party Res Invite Party Already Invited By Inviter", 1)]
    PartyResInvitePartyAlreadyInvitedByInviter = 25,

    /// <summary>Server response: party invite rejected.</summary>
    [Label("PartyRes_InviteParty_Rejected")]
    [Label("Party Res Invite Party Rejected", 1)]
    PartyResInvitePartyRejected = 26,

    /// <summary>Server response: party invite accepted.</summary>
    [Label("PartyRes_InviteParty_Accepted")]
    [Label("Party Res Invite Party Accepted", 1)]
    PartyResInvitePartyAccepted = 27,

    /// <summary>Server response: member kicked successfully.</summary>
    [Label("PartyRes_KickParty_Done")]
    [Label("Party Res Kick Party Done", 1)]
    PartyResKickPartyDone = 28,

    /// <summary>Kick failed: field limit restriction.</summary>
    [Label("PartyRes_KickParty_FieldLimit")]
    [Label("Party Res Kick Party Field Limit", 1)]
    PartyResKickPartyFieldLimit = 29,

    /// <summary>Kick failed: unknown error.</summary>
    [Label("PartyRes_KickParty_Unknown")]
    [Label("Party Res Kick Party Unknown", 1)]
    PartyResKickPartyUnknown = 30,

    /// <summary>Server response: party leader changed successfully.</summary>
    [Label("PartyRes_ChangePartyBoss_Done")]
    [Label("Party Res Change Party Boss Done", 1)]
    PartyResChangePartyBossDone = 31,

    /// <summary>Change leader failed: target not in same field.</summary>
    [Label("PartyRes_ChangePartyBoss_NotSameField")]
    [Label("Party Res Change Party Boss Not Same Field", 1)]
    PartyResChangePartyBossNotSameField = 32,

    /// <summary>Change leader failed: no member in same field.</summary>
    [Label("PartyRes_ChangePartyBoss_NoMemberInSameField")]
    [Label("Party Res Change Party Boss No Member In Same Field", 1)]
    PartyResChangePartyBossNoMemberInSameField = 33,

    /// <summary>Change leader failed: target not in same channel.</summary>
    [Label("PartyRes_ChangePartyBoss_NotSameChannel")]
    [Label("Party Res Change Party Boss Not Same Channel", 1)]
    PartyResChangePartyBossNotSameChannel = 34,

    /// <summary>Change leader failed: unknown error.</summary>
    [Label("PartyRes_ChangePartyBoss_Unknown")]
    [Label("Party Res Change Party Boss Unknown", 1)]
    PartyResChangePartyBossUnknown = 35,

    /// <summary>Admin restriction: cannot create party.</summary>
    [Label("PartyRes_AdminCannotCreate")]
    [Label("Party Res Admin Cannot Create", 1)]
    PartyResAdminCannotCreate = 36,

    /// <summary>Admin restriction: cannot invite to party.</summary>
    [Label("PartyRes_AdminCannotInvite")]
    [Label("Party Res Admin Cannot Invite", 1)]
    PartyResAdminCannotInvite = 37,

    /// <summary>Notification: user is migrating channels.</summary>
    [Label("PartyRes_UserMigration")]
    [Label("Party Res User Migration", 1)]
    PartyResUserMigration = 38,

    /// <summary>Notification: member changed level or job.</summary>
    [Label("PartyRes_ChangeLevelOrJob")]
    [Label("Party Res Change Level Or Job", 1)]
    PartyResChangeLevelOrJob = 39,

    /// <summary>Server response: PQ reward selected successfully.</summary>
    [Label("PartyRes_SuccessToSelectPQReward")]
    [Label("Party Res Success To Select PQ Reward", 1)]
    PartyResSuccessToSelectPQReward = 40,

    /// <summary>Server response: PQ reward selection failed.</summary>
    [Label("PartyRes_FailToSelectPQReward")]
    [Label("Party Res Fail To Select PQ Reward", 1)]
    PartyResFailToSelectPQReward = 41,

    /// <summary>Server response: PQ reward received.</summary>
    [Label("PartyRes_ReceivePQReward")]
    [Label("Party Res Receive PQ Reward", 1)]
    PartyResReceivePQReward = 42,

    /// <summary>Server response: PQ reward request failed.</summary>
    [Label("PartyRes_FailToRequestPQReward")]
    [Label("Party Res Fail To Request PQ Reward", 1)]
    PartyResFailToRequestPQReward = 43,

    /// <summary>Restriction: cannot use party in this field.</summary>
    [Label("PartyRes_CanNotInThisField")]
    [Label("Party Res Can Not In This Field", 1)]
    PartyResCanNotInThisField = 44,

    /// <summary>Server message response.</summary>
    [Label("PartyRes_ServerMsg")]
    [Label("Party Res Server Msg", 1)]
    PartyResServerMsg = 45,

    /// <summary>Party info: town portal location changed.</summary>
    [Label("PartyInfo_TownPortalChanged")]
    [Label("Party Info Town Portal Changed", 1)]
    PartyInfoTownPortalChanged = 46,

    /// <summary>Party info: mystic door/gate opened.</summary>
    [Label("PartyInfo_OpenGate")]
    [Label("Party Info Open Gate", 1)]
    PartyInfoOpenGate = 47,

    /// <summary>Client request to load expedition data.</summary>
    [Label("ExpeditionReq_Load")]
    [Label("Expedition Req Load", 1)]
    ExpeditionReqLoad = 48,

    /// <summary>Client request to create a new expedition.</summary>
    [Label("ExpeditionReq_CreateNew")]
    [Label("Expedition Req Create New", 1)]
    ExpeditionReqCreateNew = 49,

    /// <summary>Client request to invite to an expedition.</summary>
    [Label("ExpeditionReq_Invite")]
    [Label("Expedition Req Invite", 1)]
    ExpeditionReqInvite = 50,

    /// <summary>Client request to respond to an expedition invite.</summary>
    [Label("ExpeditionReq_ResponseInvite")]
    [Label("Expedition Req Response Invite", 1)]
    ExpeditionReqResponseInvite = 51,

    /// <summary>Client request to withdraw from an expedition.</summary>
    [Label("ExpeditionReq_Withdraw")]
    [Label("Expedition Req Withdraw", 1)]
    ExpeditionReqWithdraw = 52,

    /// <summary>Client request to kick from an expedition.</summary>
    [Label("ExpeditionReq_Kick")]
    [Label("Expedition Req Kick", 1)]
    ExpeditionReqKick = 53,

    /// <summary>Client request to change expedition master.</summary>
    [Label("ExpeditionReq_ChangeMaster")]
    [Label("Expedition Req Change Master", 1)]
    ExpeditionReqChangeMaster = 54,

    /// <summary>Client request to change expedition party boss.</summary>
    [Label("ExpeditionReq_ChangePartyBoss")]
    [Label("Expedition Req Change Party Boss", 1)]
    ExpeditionReqChangePartyBoss = 55,

    /// <summary>Client request to relocate an expedition member.</summary>
    [Label("ExpeditionReq_RelocateMember")]
    [Label("Expedition Req Relocate Member", 1)]
    ExpeditionReqRelocateMember = 56,

    /// <summary>Notification: expedition data loaded successfully.</summary>
    [Label("ExpeditionNoti_Load_Done")]
    [Label("Expedition Noti Load Done", 1)]
    ExpeditionNotiLoadDone = 57,

    /// <summary>Notification: expedition data load failed.</summary>
    [Label("ExpeditionNoti_Load_Fail")]
    [Label("Expedition Noti Load Fail", 1)]
    ExpeditionNotiLoadFail = 58,

    /// <summary>Notification: new expedition created successfully.</summary>
    [Label("ExpeditionNoti_CreateNew_Done")]
    [Label("Expedition Noti Create New Done", 1)]
    ExpeditionNotiCreateNewDone = 59,

    /// <summary>Notification: a player joined the expedition.</summary>
    [Label("ExpeditionNoti_Join_Done")]
    [Label("Expedition Noti Join Done", 1)]
    ExpeditionNotiJoinDone = 60,

    /// <summary>Notification: you joined an expedition.</summary>
    [Label("ExpeditionNoti_You_Joined")]
    [Label("Expedition Noti You Joined", 1)]
    ExpeditionNotiYouJoined = 61,

    /// <summary>Notification: you joined an expedition (alternate).</summary>
    [Label("ExpeditionNoti_You_Joined2")]
    [Label("Expedition Noti You Joined2", 1)]
    ExpeditionNotiYouJoined2 = 62,

    /// <summary>Notification: expedition join failed.</summary>
    [Label("ExpeditionNoti_Join_Fail")]
    [Label("Expedition Noti Join Fail", 1)]
    ExpeditionNotiJoinFail = 63,

    /// <summary>Notification: a member withdrew from the expedition.</summary>
    [Label("ExpeditionNoti_Withdraw_Done")]
    [Label("Expedition Noti Withdraw Done", 1)]
    ExpeditionNotiWithdrawDone = 64,

    /// <summary>Notification: you withdrew from the expedition.</summary>
    [Label("ExpeditionNoti_You_Withdrew")]
    [Label("Expedition Noti You Withdrew", 1)]
    ExpeditionNotiYouWithdrew = 65,

    /// <summary>Notification: a member was kicked from the expedition.</summary>
    [Label("ExpeditionNoti_Kick_Done")]
    [Label("Expedition Noti Kick Done", 1)]
    ExpeditionNotiKickDone = 66,

    /// <summary>Notification: you were kicked from the expedition.</summary>
    [Label("ExpeditionNoti_You_Kicked")]
    [Label("Expedition Noti You Kicked", 1)]
    ExpeditionNotiYouKicked = 67,

    /// <summary>Notification: expedition was removed/disbanded.</summary>
    [Label("ExpeditionNoti_Removed")]
    [Label("Expedition Noti Removed", 1)]
    ExpeditionNotiRemoved = 68,

    /// <summary>Notification: expedition master changed.</summary>
    [Label("ExpeditionNoti_MasterChanged")]
    [Label("Expedition Noti Master Changed", 1)]
    ExpeditionNotiMasterChanged = 69,

    /// <summary>Notification: expedition was modified.</summary>
    [Label("ExpeditionNoti_Modified")]
    [Label("Expedition Noti Modified", 1)]
    ExpeditionNotiModified = 70,

    /// <summary>Notification: expedition was modified (alternate).</summary>
    [Label("ExpeditionNoti_Modified2")]
    [Label("Expedition Noti Modified2", 1)]
    ExpeditionNotiModified2 = 71,

    /// <summary>Notification: expedition invite received.</summary>
    [Label("ExpeditionNoti_Invite")]
    [Label("Expedition Noti Invite", 1)]
    ExpeditionNotiInvite = 72,

    /// <summary>Notification: expedition invite response received.</summary>
    [Label("ExpeditionNoti_ResponseInvite")]
    [Label("Expedition Noti Response Invite", 1)]
    ExpeditionNotiResponseInvite = 73,

    /// <summary>Notification: advert data loaded successfully.</summary>
    [Label("AdverNoti_LoadDone")]
    [Label("Adver Noti Load Done", 1)]
    AdverNotiLoadDone = 74,

    /// <summary>Notification: advert changed.</summary>
    [Label("AdverNoti_Change")]
    [Label("Adver Noti Change", 1)]
    AdverNotiChange = 75,

    /// <summary>Notification: advert removed.</summary>
    [Label("AdverNoti_Remove")]
    [Label("Adver Noti Remove", 1)]
    AdverNotiRemove = 76,

    /// <summary>Notification: all adverts retrieved.</summary>
    [Label("AdverNoti_GetAll")]
    [Label("Adver Noti Get All", 1)]
    AdverNotiGetAll = 77,

    /// <summary>Notification: advert application received.</summary>
    [Label("AdverNoti_Apply")]
    [Label("Adver Noti Apply", 1)]
    AdverNotiApply = 78,

    /// <summary>Notification: advert application result.</summary>
    [Label("AdverNoti_ResultApply")]
    [Label("Adver Noti Result Apply", 1)]
    AdverNotiResultApply = 79,

    /// <summary>Notification: advert add failed.</summary>
    [Label("AdverNoti_AddFail")]
    [Label("Adver Noti Add Fail", 1)]
    AdverNotiAddFail = 80,

    /// <summary>Client request to add an advert.</summary>
    [Label("AdverReq_Add")]
    [Label("Adver Req Add", 1)]
    AdverReqAdd = 81,

    /// <summary>Client request to remove an advert.</summary>
    [Label("AdverReq_Remove")]
    [Label("Adver Req Remove", 1)]
    AdverReqRemove = 82,

    /// <summary>Client request to get all adverts.</summary>
    [Label("AdverReq_GetAll")]
    [Label("Adver Req Get All", 1)]
    AdverReqGetAll = 83,

    /// <summary>Client request to remove user from notification list.</summary>
    [Label("AdverReq_RemoveUserFromNotiList")]
    [Label("Adver Req Remove User From Noti List", 1)]
    AdverReqRemoveUserFromNotiList = 84,

    /// <summary>Client request to apply to an advert.</summary>
    [Label("AdverReq_Apply")]
    [Label("Adver Req Apply", 1)]
    AdverReqApply = 85,

    /// <summary>Client request to respond to an advert application.</summary>
    [Label("AdverReq_ResultApply")]
    [Label("Adver Req Result Apply", 1)]
    AdverReqResultApply = 86,
}
