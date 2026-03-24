using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini-room (trade/game room/shop) protocol operation codes.
/// </summary>
public enum MiniRoomProtocol : byte
{
    /// <summary>Create a new mini-room.</summary>
    [Label("MRP_Create")]
    [Label("Mrp Create", 1)]
    MrpCreate = 0,

    /// <summary>Result of room creation request.</summary>
    [Label("MRP_CreateResult")]
    [Label("Mrp Create Result", 1)]
    MrpCreateResult = 1,

    /// <summary>Invite a player to the room.</summary>
    [Label("MRP_Invite")]
    [Label("Mrp Invite", 1)]
    MrpInvite = 2,

    /// <summary>Result of the invitation.</summary>
    [Label("MRP_InviteResult")]
    [Label("Mrp Invite Result", 1)]
    MrpInviteResult = 3,

    /// <summary>Enter an existing room.</summary>
    [Label("MRP_Enter")]
    [Label("Mrp Enter", 1)]
    MrpEnter = 4,

    /// <summary>Result of entering a room.</summary>
    [Label("MRP_EnterResult")]
    [Label("Mrp Enter Result", 1)]
    MrpEnterResult = 5,

    /// <summary>Send a chat message in the room.</summary>
    [Label("MRP_Chat")]
    [Label("Mrp Chat", 1)]
    MrpChat = 6,

    /// <summary>Game event notification message.</summary>
    [Label("MRP_GameMessage")]
    [Label("Mrp Game Message", 1)]
    MrpGameMessage = 7,

    /// <summary>User-to-user chat in the room.</summary>
    [Label("MRP_UserChat")]
    [Label("Mrp User Chat", 1)]
    MrpUserChat = 8,

    /// <summary>Update avatar display in the room.</summary>
    [Label("MRP_Avatar")]
    [Label("Mrp Avatar", 1)]
    MrpAvatar = 9,

    /// <summary>Leave the mini-room.</summary>
    [Label("MRP_Leave")]
    [Label("Mrp Leave", 1)]
    MrpLeave = 10,

    /// <summary>Display a speech balloon in the room.</summary>
    [Label("MRP_Balloon")]
    [Label("Mrp Balloon", 1)]
    MrpBalloon = 11,

    /// <summary>Current field does not allow mini-rooms.</summary>
    [Label("MRP_NotAvailableField")]
    [Label("Mrp Not Available Field", 1)]
    MrpNotAvailableField = 12,

    /// <summary>Free Market entrance shortcut.</summary>
    [Label("MRP_FreeMarketClip")]
    [Label("Mrp Free Market Clip", 1)]
    MrpFreeMarketClip = 13,

    /// <summary>Secondary SSN verification check.</summary>
    [Label("MRP_CheckSSN2")]
    [Label("Mrp Check Ssn2", 1)]
    MrpCheckSsn2 = 14,

    /// <summary>Place an item in the trade window.</summary>
    [Label("TRP_PutItem")]
    [Label("Trp Put Item", 1)]
    TrpPutItem = 15,

    /// <summary>Place mesos in the trade window.</summary>
    [Label("TRP_PutMoney")]
    [Label("Trp Put Money", 1)]
    TrpPutMoney = 16,

    /// <summary>Confirm and execute the trade.</summary>
    [Label("TRP_Trade")]
    [Label("Trp Trade", 1)]
    TrpTrade = 17,

    /// <summary>Cancel the trade.</summary>
    [Label("TRP_UnTrade")]
    [Label("Trp Un Trade", 1)]
    TrpUnTrade = 18,

    /// <summary>Move an item back to inventory from trade.</summary>
    [Label("TRP_MoveItemToInventory")]
    [Label("Trp Move Item To Inventory", 1)]
    TrpMoveItemToInventory = 19,

    /// <summary>Trade item integrity CRC check.</summary>
    [Label("TRP_ItemCRC")]
    [Label("Trp Item Crc", 1)]
    TrpItemCrc = 20,

    /// <summary>Trade limit exceeded.</summary>
    [Label("TRP_LimitFail")]
    [Label("Trp Limit Fail", 1)]
    TrpLimitFail = 21,

    /// <summary>List an item in the personal shop.</summary>
    [Label("PSP_PutItem")]
    [Label("Psp Put Item", 1)]
    PspPutItem = 22,

    /// <summary>Buy an item from a personal shop.</summary>
    [Label("PSP_BuyItem")]
    [Label("Psp Buy Item", 1)]
    PspBuyItem = 23,

    /// <summary>Result of a personal shop purchase.</summary>
    [Label("PSP_BuyResult")]
    [Label("Psp Buy Result", 1)]
    PspBuyResult = 24,

    /// <summary>Refresh personal shop item list.</summary>
    [Label("PSP_Refresh")]
    [Label("Psp Refresh", 1)]
    PspRefresh = 25,

    /// <summary>Notify owner of a sold item.</summary>
    [Label("PSP_AddSoldItem")]
    [Label("Psp Add Sold Item", 1)]
    PspAddSoldItem = 26,

    /// <summary>Move item from shop back to inventory.</summary>
    [Label("PSP_MoveItemToInventory")]
    [Label("Psp Move Item To Inventory", 1)]
    PspMoveItemToInventory = 27,

    /// <summary>Ban a player from the personal shop.</summary>
    [Label("PSP_Ban")]
    [Label("Psp Ban", 1)]
    PspBan = 28,

    /// <summary>Kick player after time limit in shop.</summary>
    [Label("PSP_KickedTimeOver")]
    [Label("Psp Kicked Time Over", 1)]
    PspKickedTimeOver = 29,

    /// <summary>Send the personal shop block list.</summary>
    [Label("PSP_DeliverBlackList")]
    [Label("Psp Deliver Black List", 1)]
    PspDeliverBlackList = 30,

    /// <summary>Add a player to the shop block list.</summary>
    [Label("PSP_AddBlackList")]
    [Label("Psp Add Black List", 1)]
    PspAddBlackList = 31,

    /// <summary>Remove a player from the shop block list.</summary>
    [Label("PSP_DeleteBlackList")]
    [Label("Psp Delete Black List", 1)]
    PspDeleteBlackList = 32,

    /// <summary>List an item in the entrusted shop.</summary>
    [Label("ESP_PutItem")]
    [Label("Esp Put Item", 1)]
    EspPutItem = 33,

    /// <summary>Buy an item from an entrusted shop.</summary>
    [Label("ESP_BuyItem")]
    [Label("Esp Buy Item", 1)]
    EspBuyItem = 34,

    /// <summary>Result of an entrusted shop purchase.</summary>
    [Label("ESP_BuyResult")]
    [Label("Esp Buy Result", 1)]
    EspBuyResult = 35,

    /// <summary>Refresh entrusted shop item list.</summary>
    [Label("ESP_Refresh")]
    [Label("Esp Refresh", 1)]
    EspRefresh = 36,

    /// <summary>Notify owner of a sold entrusted shop item.</summary>
    [Label("ESP_AddSoldItem")]
    [Label("Esp Add Sold Item", 1)]
    EspAddSoldItem = 37,

    /// <summary>Move item from entrusted shop to inventory.</summary>
    [Label("ESP_MoveItemToInventory")]
    [Label("Esp Move Item To Inventory", 1)]
    EspMoveItemToInventory = 38,

    /// <summary>Leave the entrusted shop.</summary>
    [Label("ESP_GoOut")]
    [Label("Esp Go Out", 1)]
    EspGoOut = 39,

    /// <summary>Rearrange items in the entrusted shop.</summary>
    [Label("ESP_ArrangeItem")]
    [Label("Esp Arrange Item", 1)]
    EspArrangeItem = 40,

    /// <summary>Withdraw all items from entrusted shop.</summary>
    [Label("ESP_WithdrawAll")]
    [Label("Esp Withdraw All", 1)]
    EspWithdrawAll = 41,

    /// <summary>Result of withdrawing all items.</summary>
    [Label("ESP_WithdrawAllResult")]
    [Label("Esp Withdraw All Result", 1)]
    EspWithdrawAllResult = 42,

    /// <summary>Withdraw mesos from entrusted shop earnings.</summary>
    [Label("ESP_WithdrawMoney")]
    [Label("Esp Withdraw Money", 1)]
    EspWithdrawMoney = 43,

    /// <summary>Result of mesos withdrawal.</summary>
    [Label("ESP_WithdrawMoneyResult")]
    [Label("Esp Withdraw Money Result", 1)]
    EspWithdrawMoneyResult = 44,

    /// <summary>GM changes the entrusted shop title.</summary>
    [Label("ESP_AdminChangeTitle")]
    [Label("Esp Admin Change Title", 1)]
    EspAdminChangeTitle = 45,

    /// <summary>Send the entrusted shop visitor list.</summary>
    [Label("ESP_DeliverVisitList")]
    [Label("Esp Deliver Visit List", 1)]
    EspDeliverVisitList = 46,

    /// <summary>Send the entrusted shop block list.</summary>
    [Label("ESP_DeliverBlackList")]
    [Label("Esp Deliver Black List", 1)]
    EspDeliverBlackList = 47,

    /// <summary>Add a player to the entrusted shop block list.</summary>
    [Label("ESP_AddBlackList")]
    [Label("Esp Add Black List", 1)]
    EspAddBlackList = 48,

    /// <summary>Remove a player from the entrusted shop block list.</summary>
    [Label("ESP_DeleteBlackList")]
    [Label("Esp Delete Black List", 1)]
    EspDeleteBlackList = 49,

    /// <summary>Request a tie/draw in the mini-game.</summary>
    [Label("MGRP_TieRequest")]
    [Label("Mgrp Tie Request", 1)]
    MgrpTieRequest = 50,

    /// <summary>Result of the tie request.</summary>
    [Label("MGRP_TieResult")]
    [Label("Mgrp Tie Result", 1)]
    MgrpTieResult = 51,

    /// <summary>Request to forfeit the mini-game.</summary>
    [Label("MGRP_GiveUpRequest")]
    [Label("Mgrp Give Up Request", 1)]
    MgrpGiveUpRequest = 52,

    /// <summary>Result of the forfeit request.</summary>
    [Label("MGRP_GiveUpResult")]
    [Label("Mgrp Give Up Result", 1)]
    MgrpGiveUpResult = 53,

    /// <summary>Request to retreat from the mini-game.</summary>
    [Label("MGRP_RetreatRequest")]
    [Label("Mgrp Retreat Request", 1)]
    MgrpRetreatRequest = 54,

    /// <summary>Result of the retreat request.</summary>
    [Label("MGRP_RetreatResult")]
    [Label("Mgrp Retreat Result", 1)]
    MgrpRetreatResult = 55,

    /// <summary>Leave during an active game.</summary>
    [Label("MGRP_LeaveEngage")]
    [Label("Mgrp Leave Engage", 1)]
    MgrpLeaveEngage = 56,

    /// <summary>Cancel leave during an active game.</summary>
    [Label("MGRP_LeaveEngageCancel")]
    [Label("Mgrp Leave Engage Cancel", 1)]
    MgrpLeaveEngageCancel = 57,

    /// <summary>Signal ready to start the game.</summary>
    [Label("MGRP_Ready")]
    [Label("Mgrp Ready", 1)]
    MgrpReady = 58,

    /// <summary>Cancel ready status.</summary>
    [Label("MGRP_CancelReady")]
    [Label("Mgrp Cancel Ready", 1)]
    MgrpCancelReady = 59,

    /// <summary>Ban a player from the mini-game room.</summary>
    [Label("MGRP_Ban")]
    [Label("Mgrp Ban", 1)]
    MgrpBan = 60,

    /// <summary>Start the mini-game.</summary>
    [Label("MGRP_Start")]
    [Label("Mgrp Start", 1)]
    MgrpStart = 61,

    /// <summary>Mini-game round result.</summary>
    [Label("MGRP_GameResult")]
    [Label("Mgrp Game Result", 1)]
    MgrpGameResult = 62,

    /// <summary>Mini-game turn time expired.</summary>
    [Label("MGRP_TimeOver")]
    [Label("Mgrp Time Over", 1)]
    MgrpTimeOver = 63,

    /// <summary>Place a stone or checker on the Omok board.</summary>
    [Label("ORP_PutStoneChecker")]
    [Label("Orp Put Stone Checker", 1)]
    OrpPutStoneChecker = 64,

    /// <summary>Invalid stone placement position.</summary>
    [Label("ORP_InvalidStonePosition")]
    [Label("Orp Invalid Stone Position", 1)]
    OrpInvalidStonePosition = 65,

    /// <summary>Invalid stone position (normal rule).</summary>
    [Label("ORP_InvalidStonePosition_Normal")]
    [Label("Orp Invalid Stone Position Normal", 1)]
    OrpInvalidStonePositionNormal = 66,

    /// <summary>Invalid stone position (3×3 rule violation).</summary>
    [Label("ORP_InvalidStonePosition_By33")]
    [Label("Orp Invalid Stone Position By33", 1)]
    OrpInvalidStonePositionBy33 = 67,

    /// <summary>Flip a card face-up in memory game.</summary>
    [Label("MGP_TurnUpCard")]
    [Label("Mgp Turn Up Card", 1)]
    MgpTurnUpCard = 68,

    /// <summary>Attempt to match a pair of cards.</summary>
    [Label("MGP_MatchCard")]
    [Label("Mgp Match Card", 1)]
    MgpMatchCard = 69,
}
