using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// In-game memo notification category (type of auto-sent memo message).
/// </summary>
public enum MemoNotificationType : byte
{
    /// <summary>Default memo type.</summary>
    [Label("MEMO_DEFAULT")]
    Default = 0,

    /// <summary>Fame increase memo.</summary>
    [Label("MEMO_INCPOP")]
    [Label("Inc Pop", 1)]
    IncPop = 1,

    /// <summary>Gift received memo.</summary>
    [Label("MEMO_NOTIFY_RECEIPT_GIFT")]
    [Label("Notify Receipt Gift", 1)]
    NotifyReceiptGift = 2,

    /// <summary>Invitation memo.</summary>
    [Label("MEMO_INVITATION")]
    Invitation = 3,

    /// <summary>Break-up notification.</summary>
    [Label("MEMO_BROKEUP")]
    [Label("Broke Up", 1)]
    BrokeUp = 4,

    /// <summary>Divorce notification.</summary>
    [Label("MEMO_DIVORCED")]
    Divorced = 5,

    /// <summary>GM message memo.</summary>
    [Label("MEMO_FROMGM")]
    [Label("From Gm", 1)]
    FromGm = 6,
}
