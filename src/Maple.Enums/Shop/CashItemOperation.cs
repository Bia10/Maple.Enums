using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash shop item operation request and response codes.
/// </summary>
public enum CashItemOperation : byte
{
    /// <summary>Get web shop orders.</summary>
    [Label("CashItemReq_WebShopOrderGetList")]
    [Label("Req Web Shop Order Get List", 1)]
    ReqWebShopOrderGetList = 0,

    /// <summary>Load cash locker.</summary>
    [Label("CashItemReq_LoadLocker")]
    [Label("Req Load Locker", 1)]
    ReqLoadLocker = 1,

    /// <summary>Load wish list.</summary>
    [Label("CashItemReq_LoadWish")]
    [Label("Req Load Wish", 1)]
    ReqLoadWish = 2,

    /// <summary>Buy cash item.</summary>
    [Label("CashItemReq_Buy")]
    [Label("Req Buy", 1)]
    ReqBuy = 3,

    /// <summary>Gift cash item.</summary>
    [Label("CashItemReq_Gift")]
    [Label("Req Gift", 1)]
    ReqGift = 4,

    /// <summary>Set wish list.</summary>
    [Label("CashItemReq_SetWish")]
    [Label("Req Set Wish", 1)]
    ReqSetWish = 5,

    /// <summary>Increase inventory slots.</summary>
    [Label("CashItemReq_IncSlotCount")]
    [Label("Req Inc Slot Count", 1)]
    ReqIncSlotCount = 6,

    /// <summary>Increase trunk slots.</summary>
    [Label("CashItemReq_IncTrunkCount")]
    [Label("Req Inc Trunk Count", 1)]
    ReqIncTrunkCount = 7,

    /// <summary>Increase character slots.</summary>
    [Label("CashItemReq_IncCharSlotCount")]
    [Label("Req Inc Char Slot Count", 1)]
    ReqIncCharSlotCount = 8,

    /// <summary>Increase buyable characters.</summary>
    [Label("CashItemReq_IncBuyCharCount")]
    [Label("Req Inc Buy Char Count", 1)]
    ReqIncBuyCharCount = 9,

    /// <summary>Enable equip slot extension.</summary>
    [Label("CashItemReq_EnableEquipSlotExt")]
    [Label("Req Enable Equip Slot Ext", 1)]
    ReqEnableEquipSlotExt = 10,

    /// <summary>Cancel pending purchase.</summary>
    [Label("CashItemReq_CancelPurchase")]
    [Label("Req Cancel Purchase", 1)]
    ReqCancelPurchase = 11,

    /// <summary>Confirm pending purchase.</summary>
    [Label("CashItemReq_ConfirmPurchase")]
    [Label("Req Confirm Purchase", 1)]
    ReqConfirmPurchase = 12,

    /// <summary>Destroy cash item.</summary>
    [Label("CashItemReq_Destroy")]
    [Label("Req Destroy", 1)]
    ReqDestroy = 13,

    /// <summary>Move locker to slot.</summary>
    [Label("CashItemReq_MoveLtoS")]
    [Label("Req Move Lto S", 1)]
    ReqMoveLtoS = 14,

    /// <summary>Move slot to locker.</summary>
    [Label("CashItemReq_MoveStoL")]
    [Label("Req Move Sto L", 1)]
    ReqMoveStoL = 15,

    /// <summary>Expire cash item.</summary>
    [Label("CashItemReq_Expire")]
    [Label("Req Expire", 1)]
    ReqExpire = 16,

    /// <summary>Use cash item.</summary>
    [Label("CashItemReq_Use")]
    [Label("Req Use", 1)]
    ReqUse = 17,

    /// <summary>Change character stats.</summary>
    [Label("CashItemReq_StatChange")]
    [Label("Req Stat Change", 1)]
    ReqStatChange = 18,

    /// <summary>Change character skill.</summary>
    [Label("CashItemReq_SkillChange")]
    [Label("Req Skill Change", 1)]
    ReqSkillChange = 19,

    /// <summary>Reset character skills.</summary>
    [Label("CashItemReq_SkillReset")]
    [Label("Req Skill Reset", 1)]
    ReqSkillReset = 20,

    /// <summary>Destroy pet item.</summary>
    [Label("CashItemReq_DestroyPetItem")]
    [Label("Req Destroy Pet Item", 1)]
    ReqDestroyPetItem = 21,

    /// <summary>Set pet name.</summary>
    [Label("CashItemReq_SetPetName")]
    [Label("Req Set Pet Name", 1)]
    ReqSetPetName = 22,

    /// <summary>Set pet lifespan.</summary>
    [Label("CashItemReq_SetPetLife")]
    [Label("Req Set Pet Life", 1)]
    ReqSetPetLife = 23,

    /// <summary>Set pet skill.</summary>
    [Label("CashItemReq_SetPetSkill")]
    [Label("Req Set Pet Skill", 1)]
    ReqSetPetSkill = 24,

    /// <summary>Set item name.</summary>
    [Label("CashItemReq_SetItemName")]
    [Label("Req Set Item Name", 1)]
    ReqSetItemName = 25,

    /// <summary>Send memo message.</summary>
    [Label("CashItemReq_SendMemo")]
    [Label("Req Send Memo", 1)]
    ReqSendMemo = 26,

    /// <summary>Get Maple Points.</summary>
    [Label("CashItemReq_GetMaplePoint")]
    [Label("Req Get Maple Point", 1)]
    ReqGetMaplePoint = 27,

    /// <summary>Request rebate.</summary>
    [Label("CashItemReq_Rebate")]
    [Label("Req Rebate", 1)]
    ReqRebate = 28,

    /// <summary>Use coupon code.</summary>
    [Label("CashItemReq_UseCoupon")]
    [Label("Req Use Coupon", 1)]
    ReqUseCoupon = 29,

    /// <summary>Gift coupon code.</summary>
    [Label("CashItemReq_GiftCoupon")]
    [Label("Req Gift Coupon", 1)]
    ReqGiftCoupon = 30,

    /// <summary>Create couple ring.</summary>
    [Label("CashItemReq_Couple")]
    [Label("Req Couple", 1)]
    ReqCouple = 31,

    /// <summary>Buy item package.</summary>
    [Label("CashItemReq_BuyPackage")]
    [Label("Req Buy Package", 1)]
    ReqBuyPackage = 32,

    /// <summary>Gift item package.</summary>
    [Label("CashItemReq_GiftPackage")]
    [Label("Req Gift Package", 1)]
    ReqGiftPackage = 33,

    /// <summary>Buy normal item.</summary>
    [Label("CashItemReq_BuyNormal")]
    [Label("Req Buy Normal", 1)]
    ReqBuyNormal = 34,

    /// <summary>Apply wish list event.</summary>
    [Label("CashItemReq_ApplyWishListEvent")]
    [Label("Req Apply Wish List Event", 1)]
    ReqApplyWishListEvent = 35,

    /// <summary>Move pet stats.</summary>
    [Label("CashItemReq_MovePetStat")]
    [Label("Req Move Pet Stat", 1)]
    ReqMovePetStat = 36,

    /// <summary>Create friendship ring.</summary>
    [Label("CashItemReq_FriendShip")]
    [Label("Req Friendship", 1)]
    ReqFriendship = 37,

    /// <summary>Scan cash shop.</summary>
    [Label("CashItemReq_ShopScan")]
    [Label("Req Shop Scan", 1)]
    ReqShopScan = 38,

    /// <summary>Load pet exception list.</summary>
    [Label("CashItemReq_LoadPetExceptionList")]
    [Label("Req Load Pet Exception List", 1)]
    ReqLoadPetExceptionList = 39,

    /// <summary>Update pet exception list.</summary>
    [Label("CashItemReq_UpdatePetExceptionList")]
    [Label("Req Update Pet Exception List", 1)]
    ReqUpdatePetExceptionList = 40,

    /// <summary>Claim free cash item.</summary>
    [Label("CashItemReq_FreeCashItem")]
    [Label("Req Free Cash Item", 1)]
    ReqFreeCashItem = 41,

    /// <summary>Load free cash items.</summary>
    [Label("CashItemReq_LoadFreeCashItem")]
    [Label("Req Load Free Cash Item", 1)]
    ReqLoadFreeCashItem = 42,

    /// <summary>Execute cash script.</summary>
    [Label("CashItemReq_Script")]
    [Label("Req Script", 1)]
    ReqScript = 43,

    /// <summary>Get purchase record.</summary>
    [Label("CashItemReq_PurchaseRecord")]
    [Label("Req Purchase Record", 1)]
    ReqPurchaseRecord = 44,

    /// <summary>Complete trade request.</summary>
    [Label("CashItemReq_TradeDone")]
    [Label("Req Trade Done", 1)]
    ReqTradeDone = 45,

    /// <summary>Complete buy request.</summary>
    [Label("CashItemReq_BuyDone")]
    [Label("Req Buy Done", 1)]
    ReqBuyDone = 46,

    /// <summary>Save trade data.</summary>
    [Label("CashItemReq_TradeSave")]
    [Label("Req Trade Save", 1)]
    ReqTradeSave = 47,

    /// <summary>Get trade log.</summary>
    [Label("CashItemReq_TradeLog")]
    [Label("Req Trade Log", 1)]
    ReqTradeLog = 48,

    /// <summary>Evolve pet.</summary>
    [Label("CashItemReq_EvolPet")]
    [Label("Req Evol Pet", 1)]
    ReqEvolPet = 49,

    /// <summary>Buy name change.</summary>
    [Label("CashItemReq_BuyNameChange")]
    [Label("Req Buy Name Change", 1)]
    ReqBuyNameChange = 50,

    /// <summary>Cancel name change.</summary>
    [Label("CashItemReq_CancelChangeName")]
    [Label("Req Cancel Change Name", 1)]
    ReqCancelChangeName = 51,

    /// <summary>Name change cancel failed.</summary>
    [Label("CashItemRes_CancelNameChangeFail")]
    [Label("Res Cancel Name Change Fail", 1)]
    ResCancelNameChangeFail = 52,

    /// <summary>Buy world transfer.</summary>
    [Label("CashItemReq_BuyTransferWorld")]
    [Label("Req Buy Transfer World", 1)]
    ReqBuyTransferWorld = 53,

    /// <summary>Cancel world transfer.</summary>
    [Label("CashItemReq_CancelTransferWorld")]
    [Label("Req Cancel Transfer World", 1)]
    ReqCancelTransferWorld = 54,

    /// <summary>Request character sale.</summary>
    [Label("CashItemReq_CharacterSale")]
    [Label("Req Character Sale", 1)]
    ReqCharacterSale = 55,

    /// <summary>Character sale succeeded.</summary>
    [Label("CashItemRes_CharacterSaleSuccess")]
    [Label("Res Character Sale Success", 1)]
    ResCharacterSaleSuccess = 56,

    /// <summary>Character sale failed.</summary>
    [Label("CashItemRes_CharacterSaleFail")]
    [Label("Res Character Sale Fail", 1)]
    ResCharacterSaleFail = 57,

    /// <summary>Sale invalid name.</summary>
    [Label("CashItemRes_CharacterSaleInvalidName")]
    [Label("Res Character Sale Invalid Name", 1)]
    ResCharacterSaleInvalidName = 58,

    /// <summary>Sale invalid item.</summary>
    [Label("CashItemRes_CharacterSaleInvalidItem")]
    [Label("Res Character Sale Invalid Item", 1)]
    ResCharacterSaleInvalidItem = 59,

    /// <summary>Request item upgrade.</summary>
    [Label("CashItemReq_ItemUpgrade")]
    [Label("Req Item Upgrade", 1)]
    ReqItemUpgrade = 60,

    /// <summary>Item upgrade succeeded.</summary>
    [Label("CashItemRes_ItemUpgradeSuccess")]
    [Label("Res Item Upgrade Success", 1)]
    ResItemUpgradeSuccess = 61,

    /// <summary>Item upgrade failure report.</summary>
    [Label("CashItemReq_ItemUpgradeFail")]
    [Label("Req Item Upgrade Fail", 1)]
    ReqItemUpgradeFail = 62,

    /// <summary>Item upgrade sub-request.</summary>
    [Label("CashItemReq_ItemUpgradeReq")]
    [Label("Req Item Upgrade Req", 1)]
    ReqItemUpgradeReq = 63,

    /// <summary>Item upgrade completed.</summary>
    [Label("CashItemReq_ItemUpgradeDone")]
    [Label("Req Item Upgrade Done", 1)]
    ReqItemUpgradeDone = 64,

    /// <summary>Item upgrade result.</summary>
    [Label("CashItemRes_ItemUpgradeDone")]
    [Label("Res Item Upgrade Done", 1)]
    ResItemUpgradeDone = 65,

    /// <summary>Item upgrade error.</summary>
    [Label("CashItemRes_ItemUpgradeErr")]
    [Label("Res Item Upgrade Err", 1)]
    ResItemUpgradeErr = 66,

    /// <summary>Request Vega scroll.</summary>
    [Label("CashItemReq_Vega")]
    [Label("Req Vega", 1)]
    ReqVega = 67,

    /// <summary>Vega scroll success phase 1.</summary>
    [Label("CashItemRes_VegaSuccess1")]
    [Label("Res Vega Success1", 1)]
    ResVegaSuccess1 = 68,

    /// <summary>Vega scroll success phase 2.</summary>
    [Label("CashItemRes_VegaSuccess2")]
    [Label("Res Vega Success2", 1)]
    ResVegaSuccess2 = 69,

    /// <summary>Vega scroll error.</summary>
    [Label("CashItemRes_VegaErr")]
    [Label("Res Vega Err", 1)]
    ResVegaErr = 70,

    /// <summary>Vega scroll error (alt).</summary>
    [Label("CashItemRes_VegaErr2")]
    [Label("Res Vega Err2", 1)]
    ResVegaErr2 = 71,

    /// <summary>Vega invalid item error.</summary>
    [Label("CashItemRes_VegaErr_InvalidItem")]
    [Label("Res Vega Err Invalid Item", 1)]
    ResVegaErrInvalidItem = 72,

    /// <summary>Vega scroll failed.</summary>
    [Label("CashItemRes_VegaFail")]
    [Label("Res Vega Fail", 1)]
    ResVegaFail = 73,

    /// <summary>Request cash gachapon.</summary>
    [Label("CashItemReq_CashItemGachapon")]
    [Label("Req Cash Item Gachapon", 1)]
    ReqCashItemGachapon = 74,

    /// <summary>Open cash gachapon.</summary>
    [Label("CashItemReq_CashGachaponOpen")]
    [Label("Req Cash Gachapon Open", 1)]
    ReqCashGachaponOpen = 75,

    /// <summary>Copy gachapon item.</summary>
    [Label("CashItemReq_CashGachaponCopy")]
    [Label("Req Cash Gachapon Copy", 1)]
    ReqCashGachaponCopy = 76,

    /// <summary>Exchange Maple Points.</summary>
    [Label("CashItemReq_ChangeMaplePoint")]
    [Label("Req Change Maple Point", 1)]
    ReqChangeMaplePoint = 77,

    /// <summary>Check free item table.</summary>
    [Label("CashItemReq_CheckFreeCashItemTable")]
    [Label("Req Check Free Cash Item Table", 1)]
    ReqCheckFreeCashItemTable = 78,

    /// <summary>Free item table checked.</summary>
    [Label("CashItemRes_CheckFreeCashItemTable_Done")]
    [Label("Res Check Free Cash Item Table Done", 1)]
    ResCheckFreeCashItemTableDone = 79,

    /// <summary>Free item check failed.</summary>
    [Label("CashItemRes_CheckFreeCashItemTable_Failed")]
    [Label("Res Check Free Cash Item Table Failed", 1)]
    ResCheckFreeCashItemTableFailed = 80,

    /// <summary>Set free item table.</summary>
    [Label("CashItemReq_SetFreeCashItemTable")]
    [Label("Req Set Free Cash Item Table", 1)]
    ReqSetFreeCashItemTable = 81,

    /// <summary>Free item table set.</summary>
    [Label("CashItemRes_SetFreeCashItemTable_Done")]
    [Label("Res Set Free Cash Item Table Done", 1)]
    ResSetFreeCashItemTableDone = 82,

    /// <summary>Free item table set failed.</summary>
    [Label("CashItemRes_SetFreeCashItemTable_Failed")]
    [Label("Res Set Free Cash Item Table Failed", 1)]
    ResSetFreeCashItemTableFailed = 83,

    /// <summary>Limit goods count changed.</summary>
    [Label("CashItemRes_LimitGoodsCount_Changed")]
    [Label("Res Limit Goods Count Changed", 1)]
    ResLimitGoodsCountChanged = 84,

    /// <summary>Web shop orders loaded.</summary>
    [Label("CashItemRes_WebShopOrderGetList_Done")]
    [Label("Res Web Shop Order Get List Done", 1)]
    ResWebShopOrderGetListDone = 85,

    /// <summary>Web shop orders failed.</summary>
    [Label("CashItemRes_WebShopOrderGetList_Failed")]
    [Label("Res Web Shop Order Get List Failed", 1)]
    ResWebShopOrderGetListFailed = 86,

    /// <summary>Web shop item received.</summary>
    [Label("CashItemRes_WebShopReceive_Done")]
    [Label("Res Web Shop Receive Done", 1)]
    ResWebShopReceiveDone = 87,

    /// <summary>Cash locker loaded.</summary>
    [Label("CashItemRes_LoadLocker_Done")]
    [Label("Res Load Locker Done", 1)]
    ResLoadLockerDone = 88,

    /// <summary>Cash locker load failed.</summary>
    [Label("CashItemRes_LoadLocker_Failed")]
    [Label("Res Load Locker Failed", 1)]
    ResLoadLockerFailed = 89,

    /// <summary>Gift list loaded.</summary>
    [Label("CashItemRes_LoadGift_Done")]
    [Label("Res Load Gift Done", 1)]
    ResLoadGiftDone = 90,

    /// <summary>Gift list load failed.</summary>
    [Label("CashItemRes_LoadGift_Failed")]
    [Label("Res Load Gift Failed", 1)]
    ResLoadGiftFailed = 91,

    /// <summary>Wish list loaded.</summary>
    [Label("CashItemRes_LoadWish_Done")]
    [Label("Res Load Wish Done", 1)]
    ResLoadWishDone = 92,

    /// <summary>Wish list load failed.</summary>
    [Label("CashItemRes_LoadWish_Failed")]
    [Label("Res Load Wish Failed", 1)]
    ResLoadWishFailed = 93,

    /// <summary>Maple TV wrong user name.</summary>
    [Label("CashItemRes_MapleTV_Failed_Wrong_User_Name")]
    [Label("Res Maple Tv Failed Wrong User Name", 1)]
    ResMapleTvFailedWrongUserName = 94,

    /// <summary>Maple TV user not connected.</summary>
    [Label("CashItemRes_MapleTV_Failed_User_Not_Connected")]
    [Label("Res Maple Tv Failed User Not Connected", 1)]
    ResMapleTvFailedUserNotConnected = 95,

    /// <summary>Avatar megaphone queue full.</summary>
    [Label("CashItemRes_AvatarMegaphone_Queue_Full")]
    [Label("Res Avatar Megaphone Queue Full", 1)]
    ResAvatarMegaphoneQueueFull = 96,

    /// <summary>Avatar megaphone level limit.</summary>
    [Label("CashItemRes_AvatarMegaphone_Level_Limit")]
    [Label("Res Avatar Megaphone Level Limit", 1)]
    ResAvatarMegaphoneLevelLimit = 97,

    /// <summary>Wish list saved.</summary>
    [Label("CashItemRes_SetWish_Done")]
    [Label("Res Set Wish Done", 1)]
    ResSetWishDone = 98,

    /// <summary>Wish list save failed.</summary>
    [Label("CashItemRes_SetWish_Failed")]
    [Label("Res Set Wish Failed", 1)]
    ResSetWishFailed = 99,

    /// <summary>Purchase succeeded.</summary>
    [Label("CashItemRes_Buy_Done")]
    [Label("Res Buy Done", 1)]
    ResBuyDone = 100,

    /// <summary>Purchase failed.</summary>
    [Label("CashItemRes_Buy_Failed")]
    [Label("Res Buy Failed", 1)]
    ResBuyFailed = 101,

    /// <summary>Coupon redeemed.</summary>
    [Label("CashItemRes_UseCoupon_Done")]
    [Label("Res Use Coupon Done", 1)]
    ResUseCouponDone = 102,

    /// <summary>Coupon normal item granted.</summary>
    [Label("CashItemRes_UseCoupon_Done_NormalItem")]
    [Label("Res Use Coupon Done Normal Item", 1)]
    ResUseCouponDoneNormalItem = 103,

    /// <summary>Coupon gifted.</summary>
    [Label("CashItemRes_GiftCoupon_Done")]
    [Label("Res Gift Coupon Done", 1)]
    ResGiftCouponDone = 104,

    /// <summary>Coupon redemption failed.</summary>
    [Label("CashItemRes_UseCoupon_Failed")]
    [Label("Res Use Coupon Failed", 1)]
    ResUseCouponFailed = 105,

    /// <summary>Coupon cash item failed.</summary>
    [Label("CashItemRes_UseCoupon_CashItem_Failed")]
    [Label("Res Use Coupon Cash Item Failed", 1)]
    ResUseCouponCashItemFailed = 106,

    /// <summary>Gift sent.</summary>
    [Label("CashItemRes_Gift_Done")]
    [Label("Res Gift Done", 1)]
    ResGiftDone = 107,

    /// <summary>Gift send failed.</summary>
    [Label("CashItemRes_Gift_Failed")]
    [Label("Res Gift Failed", 1)]
    ResGiftFailed = 108,

    /// <summary>Slot count increased.</summary>
    [Label("CashItemRes_IncSlotCount_Done")]
    [Label("Res Inc Slot Count Done", 1)]
    ResIncSlotCountDone = 109,

    /// <summary>Slot count increase failed.</summary>
    [Label("CashItemRes_IncSlotCount_Failed")]
    [Label("Res Inc Slot Count Failed", 1)]
    ResIncSlotCountFailed = 110,

    /// <summary>Trunk count increased.</summary>
    [Label("CashItemRes_IncTrunkCount_Done")]
    [Label("Res Inc Trunk Count Done", 1)]
    ResIncTrunkCountDone = 111,

    /// <summary>Trunk count increase failed.</summary>
    [Label("CashItemRes_IncTrunkCount_Failed")]
    [Label("Res Inc Trunk Count Failed", 1)]
    ResIncTrunkCountFailed = 112,

    /// <summary>Character slots increased.</summary>
    [Label("CashItemRes_IncCharSlotCount_Done")]
    [Label("Res Inc Char Slot Count Done", 1)]
    ResIncCharSlotCountDone = 113,

    /// <summary>Character slots increase failed.</summary>
    [Label("CashItemRes_IncCharSlotCount_Failed")]
    [Label("Res Inc Char Slot Count Failed", 1)]
    ResIncCharSlotCountFailed = 114,

    /// <summary>Buy character count increased.</summary>
    [Label("CashItemRes_IncBuyCharCount_Done")]
    [Label("Res Inc Buy Char Count Done", 1)]
    ResIncBuyCharCountDone = 115,

    /// <summary>Buy character count failed.</summary>
    [Label("CashItemRes_IncBuyCharCount_Failed")]
    [Label("Res Inc Buy Char Count Failed", 1)]
    ResIncBuyCharCountFailed = 116,

    /// <summary>Equip slot extension enabled.</summary>
    [Label("CashItemRes_EnableEquipSlotExt_Done")]
    [Label("Res Enable Equip Slot Ext Done", 1)]
    ResEnableEquipSlotExtDone = 117,

    /// <summary>Equip slot extension failed.</summary>
    [Label("CashItemRes_EnableEquipSlotExt_Failed")]
    [Label("Res Enable Equip Slot Ext Failed", 1)]
    ResEnableEquipSlotExtFailed = 118,

    /// <summary>Locker to slot moved.</summary>
    [Label("CashItemRes_MoveLtoS_Done")]
    [Label("Res Move Lto SDone", 1)]
    ResMoveLtoSDone = 119,

    /// <summary>Locker to slot failed.</summary>
    [Label("CashItemRes_MoveLtoS_Failed")]
    [Label("Res Move Lto SFailed", 1)]
    ResMoveLtoSFailed = 120,

    /// <summary>Slot to locker moved.</summary>
    [Label("CashItemRes_MoveStoL_Done")]
    [Label("Res Move Sto LDone", 1)]
    ResMoveStoLDone = 121,

    /// <summary>Slot to locker failed.</summary>
    [Label("CashItemRes_MoveStoL_Failed")]
    [Label("Res Move Sto LFailed", 1)]
    ResMoveStoLFailed = 122,

    /// <summary>Item destroyed.</summary>
    [Label("CashItemRes_Destroy_Done")]
    [Label("Res Destroy Done", 1)]
    ResDestroyDone = 123,

    /// <summary>Item destroy failed.</summary>
    [Label("CashItemRes_Destroy_Failed")]
    [Label("Res Destroy Failed", 1)]
    ResDestroyFailed = 124,

    /// <summary>Item expired.</summary>
    [Label("CashItemRes_Expire_Done")]
    [Label("Res Expire Done", 1)]
    ResExpireDone = 125,

    /// <summary>Item expire failed.</summary>
    [Label("CashItemRes_Expire_Failed")]
    [Label("Res Expire Failed", 1)]
    ResExpireFailed = 126,

    /// <summary>Item used.</summary>
    [Label("CashItemRes_Use_Done")]
    [Label("Res Use Done", 1)]
    ResUseDone = 127,

    /// <summary>Item use failed.</summary>
    [Label("CashItemRes_Use_Failed")]
    [Label("Res Use Failed", 1)]
    ResUseFailed = 128,

    /// <summary>Stat change applied.</summary>
    [Label("CashItemRes_StatChange_Done")]
    [Label("Res Stat Change Done", 1)]
    ResStatChangeDone = 129,

    /// <summary>Stat change failed.</summary>
    [Label("CashItemRes_StatChange_Failed")]
    [Label("Res Stat Change Failed", 1)]
    ResStatChangeFailed = 130,

    /// <summary>Skill change applied.</summary>
    [Label("CashItemRes_SkillChange_Done")]
    [Label("Res Skill Change Done", 1)]
    ResSkillChangeDone = 131,

    /// <summary>Skill change failed.</summary>
    [Label("CashItemRes_SkillChange_Failed")]
    [Label("Res Skill Change Failed", 1)]
    ResSkillChangeFailed = 132,

    /// <summary>Skill reset applied.</summary>
    [Label("CashItemRes_SkillReset_Done")]
    [Label("Res Skill Reset Done", 1)]
    ResSkillResetDone = 133,

    /// <summary>Skill reset failed.</summary>
    [Label("CashItemRes_SkillReset_Failed")]
    [Label("Res Skill Reset Failed", 1)]
    ResSkillResetFailed = 134,

    /// <summary>Pet item destroyed.</summary>
    [Label("CashItemRes_DestroyPetItem_Done")]
    [Label("Res Destroy Pet Item Done", 1)]
    ResDestroyPetItemDone = 135,

    /// <summary>Pet item destroy failed.</summary>
    [Label("CashItemRes_DestroyPetItem_Failed")]
    [Label("Res Destroy Pet Item Failed", 1)]
    ResDestroyPetItemFailed = 136,

    /// <summary>Pet name set.</summary>
    [Label("CashItemRes_SetPetName_Done")]
    [Label("Res Set Pet Name Done", 1)]
    ResSetPetNameDone = 137,

    /// <summary>Pet name set failed.</summary>
    [Label("CashItemRes_SetPetName_Failed")]
    [Label("Res Set Pet Name Failed", 1)]
    ResSetPetNameFailed = 138,

    /// <summary>Pet lifespan set.</summary>
    [Label("CashItemRes_SetPetLife_Done")]
    [Label("Res Set Pet Life Done", 1)]
    ResSetPetLifeDone = 139,

    /// <summary>Pet lifespan set failed.</summary>
    [Label("CashItemRes_SetPetLife_Failed")]
    [Label("Res Set Pet Life Failed", 1)]
    ResSetPetLifeFailed = 140,

    /// <summary>Pet stat move failed.</summary>
    [Label("CashItemRes_MovePetStat_Failed")]
    [Label("Res Move Pet Stat Failed", 1)]
    ResMovePetStatFailed = 141,

    /// <summary>Pet stat moved.</summary>
    [Label("CashItemRes_MovePetStat_Done")]
    [Label("Res Move Pet Stat Done", 1)]
    ResMovePetStatDone = 142,

    /// <summary>Pet skill set failed.</summary>
    [Label("CashItemRes_SetPetSkill_Failed")]
    [Label("Res Set Pet Skill Failed", 1)]
    ResSetPetSkillFailed = 143,

    /// <summary>Pet skill set.</summary>
    [Label("CashItemRes_SetPetSkill_Done")]
    [Label("Res Set Pet Skill Done", 1)]
    ResSetPetSkillDone = 144,

    /// <summary>Memo sent.</summary>
    [Label("CashItemRes_SendMemo_Done")]
    [Label("Res Send Memo Done", 1)]
    ResSendMemoDone = 145,

    /// <summary>Memo send warning.</summary>
    [Label("CashItemRes_SendMemo_Warning")]
    [Label("Res Send Memo Warning", 1)]
    ResSendMemoWarning = 146,

    /// <summary>Memo send failed.</summary>
    [Label("CashItemRes_SendMemo_Failed")]
    [Label("Res Send Memo Failed", 1)]
    ResSendMemoFailed = 147,

    /// <summary>Maple Points retrieved.</summary>
    [Label("CashItemRes_GetMaplePoint_Done")]
    [Label("Res Get Maple Point Done", 1)]
    ResGetMaplePointDone = 148,

    /// <summary>Maple Points retrieval failed.</summary>
    [Label("CashItemRes_GetMaplePoint_Failed")]
    [Label("Res Get Maple Point Failed", 1)]
    ResGetMaplePointFailed = 149,

    /// <summary>Rebate applied.</summary>
    [Label("CashItemRes_Rebate_Done")]
    [Label("Res Rebate Done", 1)]
    ResRebateDone = 150,

    /// <summary>Rebate failed.</summary>
    [Label("CashItemRes_Rebate_Failed")]
    [Label("Res Rebate Failed", 1)]
    ResRebateFailed = 151,

    /// <summary>Couple ring created.</summary>
    [Label("CashItemRes_Couple_Done")]
    [Label("Res Couple Done", 1)]
    ResCoupleDone = 152,

    /// <summary>Couple ring failed.</summary>
    [Label("CashItemRes_Couple_Failed")]
    [Label("Res Couple Failed", 1)]
    ResCoupleFailed = 153,

    /// <summary>Package purchased.</summary>
    [Label("CashItemRes_BuyPackage_Done")]
    [Label("Res Buy Package Done", 1)]
    ResBuyPackageDone = 154,

    /// <summary>Package purchase failed.</summary>
    [Label("CashItemRes_BuyPackage_Failed")]
    [Label("Res Buy Package Failed", 1)]
    ResBuyPackageFailed = 155,

    /// <summary>Package gifted.</summary>
    [Label("CashItemRes_GiftPackage_Done")]
    [Label("Res Gift Package Done", 1)]
    ResGiftPackageDone = 156,

    /// <summary>Package gift failed.</summary>
    [Label("CashItemRes_GiftPackage_Failed")]
    [Label("Res Gift Package Failed", 1)]
    ResGiftPackageFailed = 157,

    /// <summary>Normal item purchased.</summary>
    [Label("CashItemRes_BuyNormal_Done")]
    [Label("Res Buy Normal Done", 1)]
    ResBuyNormalDone = 158,

    /// <summary>Normal purchase failed.</summary>
    [Label("CashItemRes_BuyNormal_Failed")]
    [Label("Res Buy Normal Failed", 1)]
    ResBuyNormalFailed = 159,

    /// <summary>Wish list event applied.</summary>
    [Label("CashItemRes_ApplyWishListEvent_Done")]
    [Label("Res Apply Wish List Event Done", 1)]
    ResApplyWishListEventDone = 160,

    /// <summary>Wish list event failed.</summary>
    [Label("CashItemRes_ApplyWishListEvent_Failed")]
    [Label("Res Apply Wish List Event Failed", 1)]
    ResApplyWishListEventFailed = 161,

    /// <summary>Friendship ring created.</summary>
    [Label("CashItemRes_Friendship_Done")]
    [Label("Res Friendship Done", 1)]
    ResFriendshipDone = 162,

    /// <summary>Friendship ring failed.</summary>
    [Label("CashItemRes_Friendship_Failed")]
    [Label("Res Friendship Failed", 1)]
    ResFriendshipFailed = 163,

    /// <summary>Exception list loaded.</summary>
    [Label("CashItemRes_LoadExceptionList_Done")]
    [Label("Res Load Exception List Done", 1)]
    ResLoadExceptionListDone = 164,

    /// <summary>Exception list load failed.</summary>
    [Label("CashItemRes_LoadExceptionList_Failed")]
    [Label("Res Load Exception List Failed", 1)]
    ResLoadExceptionListFailed = 165,

    /// <summary>Exception list updated.</summary>
    [Label("CashItemRes_UpdateExceptionList_Done")]
    [Label("Res Update Exception List Done", 1)]
    ResUpdateExceptionListDone = 166,

    /// <summary>Exception list update failed.</summary>
    [Label("CashItemRes_UpdateExceptionList_Failed")]
    [Label("Res Update Exception List Failed", 1)]
    ResUpdateExceptionListFailed = 167,

    /// <summary>Free items loaded.</summary>
    [Label("CashItemRes_LoadFreeCashItem_Done")]
    [Label("Res Load Free Cash Item Done", 1)]
    ResLoadFreeCashItemDone = 168,

    /// <summary>Free items load failed.</summary>
    [Label("CashItemRes_LoadFreeCashItem_Failed")]
    [Label("Res Load Free Cash Item Failed", 1)]
    ResLoadFreeCashItemFailed = 169,

    /// <summary>Free item claimed.</summary>
    [Label("CashItemRes_FreeCashItem_Done")]
    [Label("Res Free Cash Item Done", 1)]
    ResFreeCashItemDone = 170,

    /// <summary>Free item claim failed.</summary>
    [Label("CashItemRes_FreeCashItem_Failed")]
    [Label("Res Free Cash Item Failed", 1)]
    ResFreeCashItemFailed = 171,

    /// <summary>Script executed.</summary>
    [Label("CashItemRes_Script_Done")]
    [Label("Res Script Done", 1)]
    ResScriptDone = 172,

    /// <summary>Script execution failed.</summary>
    [Label("CashItemRes_Script_Failed")]
    [Label("Res Script Failed", 1)]
    ResScriptFailed = 173,

    /// <summary>Bridge operation failed.</summary>
    [Label("CashItemRes_Bridge_Failed")]
    [Label("Res Bridge Failed", 1)]
    ResBridgeFailed = 174,

    /// <summary>Purchase record retrieved.</summary>
    [Label("CashItemRes_PurchaseRecord_Done")]
    [Label("Res Purchase Record Done", 1)]
    ResPurchaseRecordDone = 175,

    /// <summary>Purchase record failed.</summary>
    [Label("CashItemRes_PurchaseRecord_Failed")]
    [Label("Res Purchase Record Failed", 1)]
    ResPurchaseRecordFailed = 176,

    /// <summary>Pet evolution failed.</summary>
    [Label("CashItemRes_EvolPet_Failed")]
    [Label("Res Evol Pet Failed", 1)]
    ResEvolPetFailed = 177,

    /// <summary>Pet evolution succeeded.</summary>
    [Label("CashItemRes_EvolPet_Done")]
    [Label("Res Evol Pet Done", 1)]
    ResEvolPetDone = 178,

    /// <summary>Name change purchased.</summary>
    [Label("CashItemRes_NameChangeBuy_Done")]
    [Label("Res Name Change Buy Done", 1)]
    ResNameChangeBuyDone = 179,

    /// <summary>Name change purchase failed.</summary>
    [Label("CashItemRes_NameChangeBuy_Failed")]
    [Label("Res Name Change Buy Failed", 1)]
    ResNameChangeBuyFailed = 180,

    /// <summary>World transfer completed.</summary>
    [Label("CashItemRes_TransferWorld_Done")]
    [Label("Res Transfer World Done", 1)]
    ResTransferWorldDone = 181,

    /// <summary>World transfer failed.</summary>
    [Label("CashItemRes_TransferWorld_Failed")]
    [Label("Res Transfer World Failed", 1)]
    ResTransferWorldFailed = 182,

    /// <summary>Gachapon opened.</summary>
    [Label("CashItemRes_CashGachaponOpen_Done")]
    [Label("Res Cash Gachapon Open Done", 1)]
    ResCashGachaponOpenDone = 183,

    /// <summary>Gachapon open failed.</summary>
    [Label("CashItemRes_CashGachaponOpen_Failed")]
    [Label("Res Cash Gachapon Open Failed", 1)]
    ResCashGachaponOpenFailed = 184,

    /// <summary>Gachapon item copied.</summary>
    [Label("CashItemRes_CashGachaponCopy_Done")]
    [Label("Res Cash Gachapon Copy Done", 1)]
    ResCashGachaponCopyDone = 185,

    /// <summary>Gachapon copy failed.</summary>
    [Label("CashItemRes_CashGachaponCopy_Failed")]
    [Label("Res Cash Gachapon Copy Failed", 1)]
    ResCashGachaponCopyFailed = 186,

    /// <summary>Maple Points exchanged.</summary>
    [Label("CashItemRes_ChangeMaplePoint_Done")]
    [Label("Res Change Maple Point Done", 1)]
    ResChangeMaplePointDone = 187,

    /// <summary>Maple Points exchange failed.</summary>
    [Label("CashItemRes_ChangeMaplePoint_Failed")]
    [Label("Res Change Maple Point Failed", 1)]
    ResChangeMaplePointFailed = 188,

    /// <summary>Give cash item.</summary>
    [Label("CashItemReq_Give")]
    [Label("Req Give", 1)]
    ReqGive = 189,

    /// <summary>Item given.</summary>
    [Label("CashItemRes_Give_Done")]
    [Label("Res Give Done", 1)]
    ResGiveDone = 190,

    /// <summary>Item give failed.</summary>
    [Label("CashItemRes_Give_Failed")]
    [Label("Res Give Failed", 1)]
    ResGiveFailed = 191,

    /// <summary>Cash gachapon failed.</summary>
    [Label("CashItemRes_GashItemGachapon_Failed")]
    [Label("Res Gash Item Gachapon Failed", 1)]
    ResGashItemGachaponFailed = 192,

    /// <summary>Cash gachapon succeeded.</summary>
    [Label("CashItemRes_CashItemGachapon_Done")]
    [Label("Res Cash Item Gachapon Done", 1)]
    ResCashItemGachaponDone = 193,
}
