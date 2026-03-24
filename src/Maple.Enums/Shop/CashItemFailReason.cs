using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash item purchase/gift failure reason codes.
/// </summary>
public enum CashItemFailReason : byte
{
    /// <summary>Unknown failure reason.</summary>
    [Label("CashItemFailReason_Unknown")]
    Unknown = 0,

    /// <summary>Request timed out.</summary>
    [Label("CashItemFailReason_Timeout")]
    Timeout = 1,

    /// <summary>Cash daemon DB error.</summary>
    [Label("CashItemFailReason_CashDaemonDBError")]
    [Label("Cash Daemon DB Error", 1)]
    CashDaemonDBError = 2,

    /// <summary>Insufficient cash balance.</summary>
    [Label("CashItemFailReason_NoRemainCash")]
    [Label("No Remain Cash", 1)]
    NoRemainCash = 3,

    /// <summary>Gifter is underage.</summary>
    [Label("CashItemFailReason_GiftUnderAge")]
    [Label("Gift Under Age", 1)]
    GiftUnderAge = 4,

    /// <summary>Gift limit exceeded.</summary>
    [Label("CashItemFailReason_GiftLimitOver")]
    [Label("Gift Limit Over", 1)]
    GiftLimitOver = 5,

    /// <summary>Gift to same account.</summary>
    [Label("CashItemFailReason_GiftSameAccount")]
    [Label("Gift Same Account", 1)]
    GiftSameAccount = 6,

    /// <summary>Unknown gift recipient.</summary>
    [Label("CashItemFailReason_GiftUnknownRecipient")]
    [Label("Gift Unknown Recipient", 1)]
    GiftUnknownRecipient = 7,

    /// <summary>Recipient gender mismatch.</summary>
    [Label("CashItemFailReason_GiftRecipientGenderMismatch")]
    [Label("Gift Recipient Gender Mismatch", 1)]
    GiftRecipientGenderMismatch = 8,

    /// <summary>Recipient locker full.</summary>
    [Label("CashItemFailReason_GiftRecipientLockerFull")]
    [Label("Gift Recipient Locker Full", 1)]
    GiftRecipientLockerFull = 9,

    /// <summary>Buy stored proc failed.</summary>
    [Label("CashItemFailReason_BuyStoredProcFailed")]
    [Label("Buy Stored Proc Failed", 1)]
    BuyStoredProcFailed = 10,

    /// <summary>Gift stored proc failed.</summary>
    [Label("CashItemFailReason_GiftStoredProcFailed")]
    [Label("Gift Stored Proc Failed", 1)]
    GiftStoredProcFailed = 11,

    /// <summary>No receiving character.</summary>
    [Label("CashItemFailReason_GiftNoReceiveCharacter")]
    [Label("Gift No Receive Character", 1)]
    GiftNoReceiveCharacter = 12,

    /// <summary>No sender character.</summary>
    [Label("CashItemFailReason_GiftNoSenderCharacter")]
    [Label("Gift No Sender Character", 1)]
    GiftNoSenderCharacter = 13,

    /// <summary>Invalid coupon code.</summary>
    [Label("CashItemFailReason_InvalidCoupon")]
    [Label("Invalid Coupon", 1)]
    InvalidCoupon = 14,

    /// <summary>Coupon user banned.</summary>
    [Label("CashItemFailReason_InvalidCoupon_UserBan")]
    [Label("Invalid Coupon User Ban", 1)]
    InvalidCouponUserBan = 15,

    /// <summary>Coupon expired.</summary>
    [Label("CashItemFailReason_ExpiredCoupon")]
    [Label("Expired Coupon", 1)]
    ExpiredCoupon = 16,

    /// <summary>Coupon already used.</summary>
    [Label("CashItemFailReason_UsedCoupon")]
    [Label("Used Coupon", 1)]
    UsedCoupon = 17,

    /// <summary>Cafe-only coupon.</summary>
    [Label("CashItemFailReason_CouponForCafeOnly")]
    [Label("Coupon For Cafe Only", 1)]
    CouponForCafeOnly = 18,

    /// <summary>Cafe coupon already used.</summary>
    [Label("CashItemFailReason_CouponForCafeOnly_Used")]
    [Label("Coupon For Cafe Only Used", 1)]
    CouponForCafeOnlyUsed = 19,

    /// <summary>Cafe coupon expired.</summary>
    [Label("CashItemFailReason_CouponForCafeOnly_Expired")]
    [Label("Coupon For Cafe Only Expired", 1)]
    CouponForCafeOnlyExpired = 20,

    /// <summary>Coupon not available.</summary>
    [Label("CashItemFailReason_NotAvailableCoupon")]
    [Label("Not Available Coupon", 1)]
    NotAvailableCoupon = 21,

    /// <summary>Gender mismatch.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("CashItemFailReason_GenderMisMatch")]
    [Label("Gender Mismatch", 1)]
    GenderMismatch = 22,

    /// <summary>Cannot gift normal item.</summary>
    [Label("CashItemFailReason_GiftNormalItem")]
    [Label("Gift Normal Item", 1)]
    GiftNormalItem = 23,

    /// <summary>Cannot gift Maple Points.</summary>
    [Label("CashItemFailReason_GiftMaplePoint")]
    [Label("Gift Maple Point", 1)]
    GiftMaplePoint = 24,

    /// <summary>No empty inventory slot.</summary>
    [Label("CashItemFailReason_NoEmptyPos")]
    [Label("No Empty Pos", 1)]
    NoEmptyPos = 25,

    /// <summary>Premium users only.</summary>
    [Label("CashItemFailReason_ForPremiumUserOnly")]
    [Label("For Premium User Only", 1)]
    ForPremiumUserOnly = 26,

    /// <summary>Couple buy proc failed.</summary>
    [Label("CashItemFailReason_BuyCoupleStoredProcFailed")]
    [Label("Buy Couple Stored Proc Failed", 1)]
    BuyCoupleStoredProcFailed = 27,

    /// <summary>Friendship buy proc failed.</summary>
    [Label("CashItemFailReason_BuyFriendshipStoredProcFailed")]
    [Label("Buy Friendship Stored Proc Failed", 1)]
    BuyFriendshipStoredProcFailed = 28,

    /// <summary>Not available now.</summary>
    [Label("CashItemFailReason_NotAvailableTime")]
    [Label("Not Available Time", 1)]
    NotAvailableTime = 29,

    /// <summary>Item out of stock.</summary>
    [Label("CashItemFailReason_NoStock")]
    [Label("No Stock", 1)]
    NoStock = 30,

    /// <summary>Purchase limit exceeded.</summary>
    [Label("CashItemFailReason_PurchaseLimitOver")]
    [Label("Purchase Limit Over", 1)]
    PurchaseLimitOver = 31,

    /// <summary>Insufficient meso balance.</summary>
    [Label("CashItemFailReason_NoRemainMeso")]
    [Label("No Remain Meso", 1)]
    NoRemainMeso = 32,

    /// <summary>User not authorized.</summary>
    [Label("CashItemFailReason_NotAuthorizedUser")]
    [Label("Not Authorized User", 1)]
    NotAuthorizedUser = 33,

    /// <summary>Invalid birth date.</summary>
    [Label("CashItemFailReason_InvalidBirthDate")]
    [Label("Invalid Birth Date", 1)]
    InvalidBirthDate = 34,

    /// <summary>Invalid passport ID.</summary>
    [Label("CashItemFailReason_InvalidPassportID")]
    [Label("Invalid Passport ID", 1)]
    InvalidPassportID = 35,

    /// <summary>Incorrect SSN verification.</summary>
    [Label("CashItemFailReason_IncorrectSSN2")]
    [Label("Incorrect SSN2", 1)]
    IncorrectSSN2 = 36,

    /// <summary>New spenders only.</summary>
    [Label("CashItemFailReason_ForNoPurchaseExpUsersOnly")]
    [Label("For No Purchase Exp Users Only", 1)]
    ForNoPurchaseExpUsersOnly = 37,

    /// <summary>Already applied.</summary>
    [Label("CashItemFailReason_AlreadyApplied")]
    [Label("Already Applied", 1)]
    AlreadyApplied = 38,

    /// <summary>Web shop unknown error.</summary>
    [Label("CashItemFailReason_WebShopUnknown")]
    [Label("Web Shop Unknown", 1)]
    WebShopUnknown = 39,

    /// <summary>Web shop inventory full.</summary>
    [Label("CashItemFailReason_WebShopInventoryCount")]
    [Label("Web Shop Inventory Count", 1)]
    WebShopInventoryCount = 40,

    /// <summary>Web shop buy proc failed.</summary>
    [Label("CashItemFailReason_WebShopBuyStoredProcFailed")]
    [Label("Web Shop Buy Stored Proc Failed", 1)]
    WebShopBuyStoredProcFailed = 41,

    /// <summary>Web shop invalid order.</summary>
    [Label("CashItemFailReason_WebShopInvalidOrder")]
    [Label("Web Shop Invalid Order", 1)]
    WebShopInvalidOrder = 42,

    /// <summary>Gachapon limit exceeded.</summary>
    [Label("CashItemFailReason_GachaponLimitOver")]
    [Label("Gachapon Limit Over", 1)]
    GachaponLimitOver = 43,

    /// <summary>User not found.</summary>
    [Label("CashItemFailReason_NoUser")]
    [Label("No User", 1)]
    NoUser = 44,

    /// <summary>Wrong commodity serial.</summary>
    [Label("CashItemFailReason_WrongCommoditySN")]
    [Label("Wrong Commodity SN", 1)]
    WrongCommoditySN = 45,

    /// <summary>Coupon limit error.</summary>
    [Label("CashItemFailReason_CouponLimitError")]
    [Label("Coupon Limit Error", 1)]
    CouponLimitError = 46,

    /// <summary>Bridge not connected.</summary>
    [Label("CashItemFailReason_BridgeNotConnected")]
    [Label("Bridge Not Connected", 1)]
    BridgeNotConnected = 47,

    /// <summary>Service under construction.</summary>
    [Label("CashItemFailReason_UnderConstruction")]
    [Label("Under Construction", 1)]
    UnderConstruction = 48,

    /// <summary>Account age restricted.</summary>
    [Label("CashItemFailReason_Account_Age_limit")]
    [Label("Account Age Limit", 1)]
    AccountAgeLimit = 49,

    /// <summary>Gift insufficient funds.</summary>
    [Label("CashItemFailReason_GiftNoMoney")]
    [Label("Gift No Money", 1)]
    GiftNoMoney = 50,

    /// <summary>Database error.</summary>
    [Label("CashItemFailReason_DBError")]
    [Label("DB Error", 1)]
    DBError = 51,

    /// <summary>Age restricted.</summary>
    [Label("CashItemFailReason_AgeLimit")]
    [Label("Age Limit", 1)]
    AgeLimit = 52,

    /// <summary>Sender restricted.</summary>
    [Label("CashItemFailReason_RestrictSender")]
    [Label("Restrict Sender", 1)]
    RestrictSender = 53,

    /// <summary>Receiver restricted.</summary>
    [Label("CashItemFailReason_RestrictReceiver")]
    [Label("Restrict Receiver", 1)]
    RestrictReceiver = 54,

    /// <summary>Limit exceeded.</summary>
    [Label("CashItemFailReason_ExceedLimit")]
    [Label("Exceed Limit", 1)]
    ExceedLimit = 55,

    /// <summary>Unknown error.</summary>
    [Label("CashItemFailReason_UnknownError")]
    [Label("Unknown Error", 1)]
    UnknownError = 56,

    /// <summary>Below level 20.</summary>
    [Label("CashItemFailReason_LevelLimit_20")]
    [Label("Level Limit20", 1)]
    LevelLimit20 = 57,

    /// <summary>Transfer to same world.</summary>
    [Label("CashItemFailReason_TransferWorldFailed_InvalidWorld_SameWorld")]
    [Label("Transfer World Failed Same World", 1)]
    TransferWorldFailedSameWorld = 58,

    /// <summary>Invalid target world.</summary>
    [Label("CashItemFailReason_TransferWorldFailed_InvalidWorld_NewWorld")]
    [Label("Transfer World Failed New World", 1)]
    TransferWorldFailedNewWorld = 59,

    /// <summary>Cannot leave new world.</summary>
    [Label("CashItemFailReason_TransferWorldFailed_InvalidWorld_FromNewWorld")]
    [Label("Transfer World Failed From New World", 1)]
    TransferWorldFailedFromNewWorld = 60,

    /// <summary>World character cap reached.</summary>
    [Label("CashItemFailReason_TransferWorldFailed_MaxCharacter")]
    [Label("Transfer World Failed Max Character", 1)]
    TransferWorldFailedMaxCharacter = 61,

    /// <summary>Event error.</summary>
    [Label("CashItemFailReason_EventError")]
    [Label("Event Error", 1)]
    EventError = 62,

    /// <summary>NX Cash only.</summary>
    [Label("CashItemFailReason_OnlyNXCash")]
    [Label("Only NX Cash", 1)]
    OnlyNXCash = 63,

    /// <summary>Retry random box.</summary>
    [Label("CashItemFailReason_TryAgainRandomBox")]
    [Label("Try Again Random Box", 1)]
    TryAgainRandomBox = 64,

    /// <summary>Daily purchase limit reached.</summary>
    [Label("CashItemFailReason_CannotBuyOneADayItem")]
    [Label("Cannot Buy One ADay Item", 1)]
    CannotBuyOneADayItem = 65,

    /// <summary>Too young to buy.</summary>
    [Label("CashItemFailReason_TooYoungToBuy")]
    [Label("Too Young To Buy", 1)]
    TooYoungToBuy = 66,

    /// <summary>Recipient too young.</summary>
    [Label("CashItemFailReason_GiftTooYoungToRecv")]
    [Label("Gift Too Young To Receive", 1)]
    GiftTooYoungToReceive = 67,

    /// <summary>Item limit exceeded.</summary>
    [Label("CashItemFailReason_LimitOverTheItem")]
    [Label("Limit Over The Item", 1)]
    LimitOverTheItem = 68,

    /// <summary>Cash shop locked.</summary>
    [Label("CashItemFailReason_CashLock")]
    [Label("Cash Lock", 1)]
    CashLock = 69,
}
