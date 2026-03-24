using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Money types involved in trade / shop operations.
/// </summary>
public enum TradeMoneyType : byte
{
    /// <summary>Meso dropped on ground.</summary>
    [Label("TMP_DropMoney")]
    [Label("Drop Money", 1)]
    DropMoney = 0,

    /// <summary>Meso in player trade.</summary>
    [Label("TMP_TradeMoney")]
    [Label("Trade Money", 1)]
    TradeMoney = 1,

    /// <summary>Meso for NPC shop purchase.</summary>
    [Label("TMP_ShopBuy")]
    [Label("Shop Buy", 1)]
    ShopBuy = 2,

    /// <summary>Meso for NPC shop sale.</summary>
    [Label("TMP_ShopTrade")]
    [Label("Shop Trade", 1)]
    ShopTrade = 3,

    /// <summary>Meso via parcel delivery.</summary>
    [Label("TMP_ParcelMoney")]
    [Label("Parcel Money", 1)]
    ParcelMoney = 4,
}
