using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item Trading Company (ITC/auction marketplace) request/response/failure-reason operation codes.
/// </summary>
public enum ItcOperation : byte
{
    /// <summary>Get Maple Points balance.</summary>
    [Label("ITCReq_GetMaplePoint")]
    [Label("Req Get Maple Point", 1)]
    ReqGetMaplePoint = 0,

    /// <summary>Flush modified character data.</summary>
    [Label("ITCReq_CharacterModifiedNFlush")]
    [Label("Req Character Modified NFlush", 1)]
    ReqCharacterModifiedNFlush = 1,

    /// <summary>Register item for sale.</summary>
    [Label("ITCReq_RegisterSaleEntry")]
    [Label("Req Register Sale Entry", 1)]
    ReqRegisterSaleEntry = 2,

    /// <summary>List current item to wishlist.</summary>
    [Label("ITCReq_SaleCurrentItemToWish")]
    [Label("Req Sale Current Item To Wish", 1)]
    ReqSaleCurrentItemToWish = 3,

    /// <summary>Register buy order.</summary>
    [Label("ITCReq_RegisterBuyOrder")]
    [Label("Req Register Buy Order", 1)]
    ReqRegisterBuyOrder = 4,

    /// <summary>Get marketplace listing.</summary>
    [Label("ITCReq_GetITCList")]
    [Label("Req Get Itc List", 1)]
    ReqGetItcList = 5,

    /// <summary>Search marketplace.</summary>
    [Label("ITCReq_GetSearchITCList")]
    [Label("Req Get Search Itc List", 1)]
    ReqGetSearchItcList = 6,

    /// <summary>Cancel item sale.</summary>
    [Label("ITCReq_CancelSaleItem")]
    [Label("Req Cancel Sale Item", 1)]
    ReqCancelSaleItem = 7,

    /// <summary>Move purchase to inventory.</summary>
    [Label("ITCReq_MoveITCPurchaseItemLtoS")]
    [Label("Req Move Itc Purchase Item Lto S", 1)]
    ReqMoveItcPurchaseItemLtoS = 8,

    /// <summary>Add to favorites.</summary>
    [Label("ITCReq_SetZzim")]
    [Label("Req Set Zzim", 1)]
    ReqSetZzim = 9,

    /// <summary>Remove from favorites.</summary>
    [Label("ITCReq_DeleteZzim")]
    [Label("Req Delete Zzim", 1)]
    ReqDeleteZzim = 10,

    /// <summary>Load wishlist sales.</summary>
    [Label("ITCReq_LoadWishSaleList")]
    [Label("Req Load Wish Sale List", 1)]
    ReqLoadWishSaleList = 11,

    /// <summary>Buy wishlist item.</summary>
    [Label("ITCReq_BuyWish")]
    [Label("Req Buy Wish", 1)]
    ReqBuyWish = 12,

    /// <summary>Cancel wishlist item.</summary>
    [Label("ITCReq_CancelWish")]
    [Label("Req Cancel Wish", 1)]
    ReqCancelWish = 13,

    /// <summary>Charge cash for wish buy.</summary>
    [Label("ITCReq_BuyWishChargeCash")]
    [Label("Req Buy Wish Charge Cash", 1)]
    ReqBuyWishChargeCash = 14,

    /// <summary>Cancel wish purchase.</summary>
    [Label("ITCReq_BuyWishCancel")]
    [Label("Req Buy Wish Cancel", 1)]
    ReqBuyWishCancel = 15,

    /// <summary>Buy item directly.</summary>
    [Label("ITCReq_BuyItem")]
    [Label("Req Buy Item", 1)]
    ReqBuyItem = 16,

    /// <summary>Buy favorited item.</summary>
    [Label("ITCReq_BuyZzimItem")]
    [Label("Req Buy Zzim Item", 1)]
    ReqBuyZzimItem = 17,

    /// <summary>Register auction item.</summary>
    [Label("ITCReq_RegAuction")]
    [Label("Req Reg Auction", 1)]
    ReqRegAuction = 18,

    /// <summary>Place auction bid.</summary>
    [Label("ITCReq_BidAuction")]
    [Label("Req Bid Auction", 1)]
    ReqBidAuction = 19,

    /// <summary>Buy auction immediately.</summary>
    [Label("ITCReq_BuyAuctionImm")]
    [Label("Req Buy Auction Imm", 1)]
    ReqBuyAuctionImm = 20,

    /// <summary>Listing retrieved.</summary>
    [Label("ITCRes_GetITCList_Done")]
    [Label("Res Get Itc List Done", 1)]
    ResGetItcListDone = 21,

    /// <summary>Listing retrieval failed.</summary>
    [Label("ITCRes_GetITCList_Failed")]
    [Label("Res Get Itc List Failed", 1)]
    ResGetItcListFailed = 22,

    /// <summary>Search results retrieved.</summary>
    [Label("ITCRes_GetSearchITCList_Done")]
    [Label("Res Get Search Itc List Done", 1)]
    ResGetSearchItcListDone = 23,

    /// <summary>Search failed.</summary>
    [Label("ITCRes_GetSearchITCList_Failed")]
    [Label("Res Get Search Itc List Failed", 1)]
    ResGetSearchItcListFailed = 24,

    /// <summary>Points balance retrieved.</summary>
    [Label("ITCRes_GetMaplePoint_Done")]
    [Label("Res Get Maple Point Done", 1)]
    ResGetMaplePointDone = 25,

    /// <summary>Points retrieval failed.</summary>
    [Label("ITCRes_GetMaplePoint_Failed")]
    [Label("Res Get Maple Point Failed", 1)]
    ResGetMaplePointFailed = 26,

    /// <summary>Character data flushed.</summary>
    [Label("ITCRes_CharacterModifiedNFlush_Done")]
    [Label("Res Character Modified NFlush Done", 1)]
    ResCharacterModifiedNFlushDone = 27,

    /// <summary>Character flush failed.</summary>
    [Label("ITCRes_CharacterModifiedNFlush_Failed")]
    [Label("Res Character Modified NFlush Failed", 1)]
    ResCharacterModifiedNFlushFailed = 28,

    /// <summary>Sale registered.</summary>
    [Label("ITCRes_RegisterSaleEntry_Done")]
    [Label("Res Register Sale Entry Done", 1)]
    ResRegisterSaleEntryDone = 29,

    /// <summary>Sale registration failed.</summary>
    [Label("ITCRes_RegisterSaleEntry_Failed")]
    [Label("Res Register Sale Entry Failed", 1)]
    ResRegisterSaleEntryFailed = 30,

    /// <summary>Listed to wishlist.</summary>
    [Label("ITCRes_SaleCurrentItemToWish_Done")]
    [Label("Res Sale Current Item To Wish Done", 1)]
    ResSaleCurrentItemToWishDone = 31,

    /// <summary>Wishlist listing failed.</summary>
    [Label("ITCRes_SaleCurrentItemToWish_Failed")]
    [Label("Res Sale Current Item To Wish Failed", 1)]
    ResSaleCurrentItemToWishFailed = 32,

    /// <summary>Purchase history loaded.</summary>
    [Label("ITCRes_GetUserPurchaseItem_Done")]
    [Label("Res Get User Purchase Item Done", 1)]
    ResGetUserPurchaseItemDone = 33,

    /// <summary>Purchase history failed.</summary>
    [Label("ITCRes_GetUserPurchaseItem_Failed")]
    [Label("Res Get User Purchase Item Failed", 1)]
    ResGetUserPurchaseItemFailed = 34,

    /// <summary>Sale history loaded.</summary>
    [Label("ITCRes_GetUserSaleItem_Done")]
    [Label("Res Get User Sale Item Done", 1)]
    ResGetUserSaleItemDone = 35,

    /// <summary>Sale history failed.</summary>
    [Label("ITCRes_GetUserSaleItem_Failed")]
    [Label("Res Get User Sale Item Failed", 1)]
    ResGetUserSaleItemFailed = 36,

    /// <summary>Sale cancelled.</summary>
    [Label("ITCRes_CancelSaleItem_Done")]
    [Label("Res Cancel Sale Item Done", 1)]
    ResCancelSaleItemDone = 37,

    /// <summary>Sale cancel failed.</summary>
    [Label("ITCRes_CancelSaleItem_Failed")]
    [Label("Res Cancel Sale Item Failed", 1)]
    ResCancelSaleItemFailed = 38,

    /// <summary>Moved to inventory.</summary>
    [Label("ITCRes_MoveITCPurchaseItemLtoS_Done")]
    [Label("Res Move Itc Purchase Item Lto SDone", 1)]
    ResMoveItcPurchaseItemLtoSDone = 39,

    /// <summary>Move to inventory failed.</summary>
    [Label("ITCRes_MoveITCPurchaseItemLtoS_Failed")]
    [Label("Res Move Itc Purchase Item Lto SFailed", 1)]
    ResMoveItcPurchaseItemLtoSFailed = 40,

    /// <summary>Added to favorites.</summary>
    [Label("ITCRes_SetZzim_Done")]
    [Label("Res Set Zzim Done", 1)]
    ResSetZzimDone = 41,

    /// <summary>Add favorite failed.</summary>
    [Label("ITCRes_SetZzim_Failed")]
    [Label("Res Set Zzim Failed", 1)]
    ResSetZzimFailed = 42,

    /// <summary>Removed from favorites.</summary>
    [Label("ITCRes_DeleteZzim_Done")]
    [Label("Res Delete Zzim Done", 1)]
    ResDeleteZzimDone = 43,

    /// <summary>Remove favorite failed.</summary>
    [Label("ITCRes_DeleteZzim_Failed")]
    [Label("Res Delete Zzim Failed", 1)]
    ResDeleteZzimFailed = 44,

    /// <summary>Wishlist loaded.</summary>
    [Label("ITCRes_LoadWishSaleList_Done")]
    [Label("Res Load Wish Sale List Done", 1)]
    ResLoadWishSaleListDone = 45,

    /// <summary>Wishlist load failed.</summary>
    [Label("ITCRes_LoadWishSaleList_Failed")]
    [Label("Res Load Wish Sale List Failed", 1)]
    ResLoadWishSaleListFailed = 46,

    /// <summary>Wish item purchased.</summary>
    [Label("ITCRes_BuyWish_Done")]
    [Label("Res Buy Wish Done", 1)]
    ResBuyWishDone = 47,

    /// <summary>Wish purchase failed.</summary>
    [Label("ITCRes_BuyWish_Failed")]
    [Label("Res Buy Wish Failed", 1)]
    ResBuyWishFailed = 48,

    /// <summary>Wish cancelled.</summary>
    [Label("ITCRes_CancelWish_Done")]
    [Label("Res Cancel Wish Done", 1)]
    ResCancelWishDone = 49,

    /// <summary>Wish cancel failed.</summary>
    [Label("ITCRes_CancelWish_Failed")]
    [Label("Res Cancel Wish Failed", 1)]
    ResCancelWishFailed = 50,

    /// <summary>Item purchased.</summary>
    [Label("ITCRes_BuyItem_Done")]
    [Label("Res Buy Item Done", 1)]
    ResBuyItemDone = 51,

    /// <summary>Purchase failed.</summary>
    [Label("ITCRes_BuyItem_Failed")]
    [Label("Res Buy Item Failed", 1)]
    ResBuyItemFailed = 52,

    /// <summary>Favorite item purchased.</summary>
    [Label("ITCRes_BuyZzimItem_Done")]
    [Label("Res Buy Zzim Item Done", 1)]
    ResBuyZzimItemDone = 53,

    /// <summary>Favorite purchase failed.</summary>
    [Label("ITCRes_BuyZzimItem_Failed")]
    [Label("Res Buy Zzim Item Failed", 1)]
    ResBuyZzimItemFailed = 54,

    /// <summary>Buy order registered.</summary>
    [Label("ITCRes_RegisterBuyOrder_Done")]
    [Label("Res Register Buy Order Done", 1)]
    ResRegisterBuyOrderDone = 55,

    /// <summary>Buy order failed.</summary>
    [Label("ITCRes_RegisterBuyOrder_Failed")]
    [Label("Res Register Buy Order Failed", 1)]
    ResRegisterBuyOrderFailed = 56,

    /// <summary>Auction registered.</summary>
    [Label("ITCRes_RegAuction_Done")]
    [Label("Res Reg Auction Done", 1)]
    ResRegAuctionDone = 57,

    /// <summary>Auction registration failed.</summary>
    [Label("ITCRes_RegAuction_Failed")]
    [Label("Res Reg Auction Failed", 1)]
    ResRegAuctionFailed = 58,

    /// <summary>Bid placed.</summary>
    [Label("ITCRes_BidAuction_Done")]
    [Label("Res Bid Auction Done", 1)]
    ResBidAuctionDone = 59,

    /// <summary>Bid failed.</summary>
    [Label("ITCRes_BidAuction_Failed")]
    [Label("Res Bid Auction Failed", 1)]
    ResBidAuctionFailed = 60,

    /// <summary>Wish cancel notification.</summary>
    [Label("ITCRes_GetNotifyCancelWishResult")]
    [Label("Res Get Notify Cancel Wish Result", 1)]
    ResGetNotifyCancelWishResult = 61,

    /// <summary>Winning bid info.</summary>
    [Label("ITCRes_GetSuccessBidInfoResult")]
    [Label("Res Get Success Bid Info Result", 1)]
    ResGetSuccessBidInfoResult = 62,

    /// <summary>Unknown failure.</summary>
    [Label("ITCFailReason_Unknown")]
    [Label("Fail Reason Unknown", 1)]
    FailReasonUnknown = 63,

    /// <summary>Operation timed out.</summary>
    [Label("ITCFailReason_Timeout")]
    [Label("Fail Reason Timeout", 1)]
    FailReasonTimeout = 64,

    /// <summary>Database error.</summary>
    [Label("ITCFailReason_DBFailed")]
    [Label("Fail Reason Db Failed", 1)]
    FailReasonDbFailed = 65,

    /// <summary>Insufficient cash.</summary>
    [Label("ITCFailReason_NoRemainCash")]
    [Label("Fail Reason No Remain Cash", 1)]
    FailReasonNoRemainCash = 66,

    /// <summary>Insufficient mesos.</summary>
    [Label("ITCFailReason_NoRemainMeso")]
    [Label("Fail Reason No Remain Meso", 1)]
    FailReasonNoRemainMeso = 67,

    /// <summary>Cash deduction failed.</summary>
    [Label("ITCFailReason_DeductCashFailed")]
    [Label("Fail Reason Deduct Cash Failed", 1)]
    FailReasonDeductCashFailed = 68,

    /// <summary>User not found.</summary>
    [Label("ITCFailReason_CannotFindUser")]
    [Label("Fail Reason Cannot Find User", 1)]
    FailReasonCannotFindUser = 69,

    /// <summary>Save failed.</summary>
    [Label("ITCFailReason_SaveFailed")]
    [Label("Fail Reason Save Failed", 1)]
    FailReasonSaveFailed = 70,

    /// <summary>No inventory space.</summary>
    [Label("ITCFailReason_NoEmptyPos")]
    [Label("Fail Reason No Empty Pos", 1)]
    FailReasonNoEmptyPos = 71,

    /// <summary>Slot count mismatch.</summary>
    [Label("ITCFailReason_SlotMaxMismatch")]
    [Label("Fail Reason Slot Max Mismatch", 1)]
    FailReasonSlotMaxMismatch = 72,

    /// <summary>Initial load failed.</summary>
    [Label("ITCFailReason_FirstLoadingFailed")]
    [Label("Fail Reason First Loading Failed", 1)]
    FailReasonFirstLoadingFailed = 73,

    /// <summary>Item operation failed.</summary>
    [Label("ITCFailReason_ItemFailed")]
    [Label("Fail Reason Item Failed", 1)]
    FailReasonItemFailed = 74,

    /// <summary>Cash charge failed.</summary>
    [Label("ITCFailReason_CashChargeFailed")]
    [Label("Fail Reason Cash Charge Failed", 1)]
    FailReasonCashChargeFailed = 75,

    /// <summary>Cash operation failed.</summary>
    [Label("ITCFailReason_CashFailed")]
    [Label("Fail Reason Cash Failed", 1)]
    FailReasonCashFailed = 76,

    /// <summary>Duplicate bid.</summary>
    [Label("ITCFailReason_DuplicateBid")]
    [Label("Fail Reason Duplicate Bid", 1)]
    FailReasonDuplicateBid = 77,

    /// <summary>Already bid on this.</summary>
    [Label("ITCFailReason_AlreadyBid")]
    [Label("Fail Reason Already Bid", 1)]
    FailReasonAlreadyBid = 78,

    /// <summary>Item cannot be registered.</summary>
    [Label("ITCFailReason_CannotRegisterItem")]
    [Label("Fail Reason Cannot Register Item", 1)]
    FailReasonCannotRegisterItem = 79,

    /// <summary>Already cancelled or sold.</summary>
    [Label("ITCFailReason_AlreadyCancelled_or_SoldOut")]
    [Label("Fail Reason Already Cancelled Or Sold Out", 1)]
    FailReasonAlreadyCancelledOrSoldOut = 80,

    /// <summary>Already sold out.</summary>
    [Label("ITCFailReason_AlreadySoldOut")]
    [Label("Fail Reason Already Sold Out", 1)]
    FailReasonAlreadySoldOut = 81,

    /// <summary>Durability item blocked.</summary>
    [Label("ITCFailReason_DurabilityItem")]
    [Label("Fail Reason Durability Item", 1)]
    FailReasonDurabilityItem = 82,

    /// <summary>Throwing star blocked.</summary>
    [Label("ITCFailReason_ThrowingStar")]
    [Label("Fail Reason Throwing Star", 1)]
    FailReasonThrowingStar = 83,

    /// <summary>Character level too low.</summary>
    [Label("ITCFailReason_LowCharacterLevel")]
    [Label("Fail Reason Low Character Level", 1)]
    FailReasonLowCharacterLevel = 84,
}
