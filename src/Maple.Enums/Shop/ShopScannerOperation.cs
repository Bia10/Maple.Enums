using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Shop scanner (watchlist search) operation codes.
/// </summary>
public enum ShopScannerOperation : byte
{
    /// <summary>Add item to watchlist.</summary>
    [Label("ShopScannerReq_AddList")]
    [Label("Req Add List", 1)]
    ReqAddList = 0,

    /// <summary>Remove item from watchlist.</summary>
    [Label("ShopScannerReq_RemoveList")]
    [Label("Req Remove List", 1)]
    ReqRemoveList = 1,

    /// <summary>Clear entire watchlist.</summary>
    [Label("ShopScannerReq_RemoveAll")]
    [Label("Req Remove All", 1)]
    ReqRemoveAll = 2,

    /// <summary>Rename watchlist entry.</summary>
    [Label("ShopScannerReq_Rename")]
    [Label("Req Rename", 1)]
    ReqRename = 3,

    /// <summary>Search for watched items.</summary>
    [Label("ShopScannerReq_Search")]
    [Label("Req Search", 1)]
    ReqSearch = 4,

    /// <summary>Load popular items list.</summary>
    [Label("ShopScannerReq_LoadHotList")]
    [Label("Req Load Hot List", 1)]
    ReqLoadHotList = 5,

    /// <summary>Search results response.</summary>
    [Label("ShopScannerRes_SearchResult")]
    [Label("Res Search Result", 1)]
    ResSearchResult = 6,

    /// <summary>Popular list response.</summary>
    [Label("ShopScannerRes_LoadHotListResult")]
    [Label("Res Load Hot List Result", 1)]
    ResLoadHotListResult = 7,
}
