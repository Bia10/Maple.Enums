using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Entrusted shop (hired merchant) withdrawal result codes.
/// </summary>
public enum EntrustedShopWithdrawResult : byte
{
    /// <summary>Withdrawal succeeded.</summary>
    [Label("ESWithdraw_Success")]
    Success = 0,

    /// <summary>Amount exceeds meso cap.</summary>
    [Label("ESWithdraw_OverPrice")]
    [Label("Over Price", 1)]
    OverPrice = 1,

    /// <summary>Items only, no mesos.</summary>
    [Label("ESWithdraw_OnlyItem")]
    [Label("Only Item", 1)]
    OnlyItem = 2,

    /// <summary>No inventory space.</summary>
    [Label("ESWithdraw_NoSlot")]
    [Label("No Slot", 1)]
    NoSlot = 3,

    /// <summary>Unknown error.</summary>
    [Label("ESWithdraw_Unknown")]
    Unknown = 4,

    /// <summary>Nothing to withdraw.</summary>
    [Label("ESWithdraw_Nothing")]
    Nothing = 5,
}
