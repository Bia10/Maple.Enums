using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Entrusted shop and store bank operation codes.
/// </summary>
public enum EntrustedShopOperation : byte
{
    /// <summary>Check if shop can open.</summary>
    [Label("EntrustedShopReq_CheckOpenPossible")]
    [Label("Req Check Open Possible", 1)]
    ReqCheckOpenPossible = 0,

    /// <summary>Request shop creation.</summary>
    [Label("EntrustedShopReq_Create")]
    [Label("Req Create", 1)]
    ReqCreate = 1,

    /// <summary>Save shop data.</summary>
    [Label("EntrustedShopReq_Save")]
    [Label("Req Save", 1)]
    ReqSave = 2,

    /// <summary>Request shop close.</summary>
    [Label("EntrustedShopReq_CloseProcess")]
    [Label("Req Close Process", 1)]
    ReqCloseProcess = 3,

    /// <summary>Find shop by owner name.</summary>
    [Label("EntrustedShopReq_FindShopByEmployerName")]
    [Label("Req Find Shop By Employer Name", 1)]
    ReqFindShopByEmployerName = 4,

    /// <summary>Check if shop is closed.</summary>
    [Label("EntrustedShopReq_CheckIfClosed")]
    [Label("Req Check If Closed", 1)]
    ReqCheckIfClosed = 5,

    /// <summary>Get shop position.</summary>
    [Label("EntrustedShopReq_GetPos")]
    [Label("Req Get Pos", 1)]
    ReqGetPos = 6,

    /// <summary>Shop can be opened.</summary>
    [Label("EntrustedShopRes_OpenPossible")]
    [Label("Res Open Possible", 1)]
    ResOpenPossible = 7,

    /// <summary>Blocked: already in use.</summary>
    [Label("EntrustedShopRes_OpenImpossible_Using")]
    [Label("Res Open Impossible Using", 1)]
    ResOpenImpossibleUsing = 8,

    /// <summary>Blocked: items stored.</summary>
    [Label("EntrustedShopRes_OpenImpossible_Stored")]
    [Label("Res Open Impossible Stored", 1)]
    ResOpenImpossibleStored = 9,

    /// <summary>Blocked: another character.</summary>
    [Label("EntrustedShopRes_OpenImpossible_AnotherCharacter")]
    [Label("Res Open Impossible Another Character", 1)]
    ResOpenImpossibleAnotherCharacter = 10,

    /// <summary>Blocked: general restriction.</summary>
    [Label("EntrustedShopRes_OpenImpossible_Block")]
    [Label("Res Open Impossible Block", 1)]
    ResOpenImpossibleBlock = 11,

    /// <summary>Shop creation failed.</summary>
    [Label("EntrustedShopRes_Create_Failed")]
    [Label("Res Create Failed", 1)]
    ResCreateFailed = 12,

    /// <summary>Set minimap shop color.</summary>
    [Label("EntrustedShopReq_SetMiniMapColor")]
    [Label("Req Set Mini Map Color", 1)]
    ReqSetMiniMapColor = 13,

    /// <summary>Shop rename result.</summary>
    [Label("EntrustedShopReq_RenameResult")]
    [Label("Req Rename Result", 1)]
    ReqRenameResult = 14,

    /// <summary>Items exist in store bank.</summary>
    [Label("EntrustedShopRes_ItemExistInStoreBank")]
    [Label("Res Item Exist In Store Bank", 1)]
    ResItemExistInStoreBank = 15,

    /// <summary>Shop position result.</summary>
    [Label("EntrustedShopRes_GetPosResult")]
    [Label("Res Get Pos Result", 1)]
    ResGetPosResult = 16,

    /// <summary>Entered shop.</summary>
    [Label("EntrustedShopRes_Enter")]
    [Label("Res Enter", 1)]
    ResEnter = 17,

    /// <summary>Server message response.</summary>
    [Label("EntrustedShopRes_ServerMsg")]
    [Label("Res Server Msg", 1)]
    ResServerMsg = 18,

    /// <summary>Load store bank.</summary>
    [Label("StoreBankReq_Load")]
    [Label("Store Bank Req Load", 1)]
    StoreBankReqLoad = 19,

    /// <summary>Remove from store bank.</summary>
    [Label("StoreBankReq_Remove")]
    [Label("Store Bank Req Remove", 1)]
    StoreBankReqRemove = 20,

    /// <summary>Verify store bank SSN.</summary>
    [Label("StoreBankReq_CheckSSN2")]
    [Label("Store Bank Req Check Ssn2", 1)]
    StoreBankReqCheckSsn2 = 21,

    /// <summary>Store bank loaded.</summary>
    [Label("StoreBankRes_Load_Done")]
    [Label("Store Bank Res Load Done", 1)]
    StoreBankResLoadDone = 22,

    /// <summary>Store bank load failed.</summary>
    [Label("StoreBankRes_Load_Failed")]
    [Label("Store Bank Res Load Failed", 1)]
    StoreBankResLoadFailed = 23,

    /// <summary>Store bank blocked.</summary>
    [Label("StoreBankRes_Block")]
    [Label("Store Bank Res Block", 1)]
    StoreBankResBlock = 24,

    /// <summary>Store bank item removed.</summary>
    [Label("StoreBankRes_Remove_Done")]
    [Label("Store Bank Res Remove Done", 1)]
    StoreBankResRemoveDone = 25,

    /// <summary>Calculate withdrawal fee.</summary>
    [Label("StoreBankReq_CalculateFee")]
    [Label("Store Bank Req Calculate Fee", 1)]
    StoreBankReqCalculateFee = 26,

    /// <summary>Retrieve all stored items.</summary>
    [Label("StoreBankReq_GetAll")]
    [Label("Store Bank Req Get All", 1)]
    StoreBankReqGetAll = 27,

    /// <summary>Exit store bank.</summary>
    [Label("StoreBankReq_Exit")]
    [Label("Store Bank Req Exit", 1)]
    StoreBankReqExit = 28,

    /// <summary>Fee calculation result.</summary>
    [Label("StoreBankRes_CalculateFee")]
    [Label("Store Bank Res Calculate Fee", 1)]
    StoreBankResCalculateFee = 29,

    /// <summary>All items retrieved.</summary>
    [Label("StoreBankRes_GetAll_Done")]
    [Label("Store Bank Res Get All Done", 1)]
    StoreBankResGetAllDone = 30,

    /// <summary>Fee exceeds meso limit.</summary>
    [Label("StoreBankRes_GetAll_OverPrice")]
    [Label("Store Bank Res Get All Over Price", 1)]
    StoreBankResGetAllOverPrice = 31,

    /// <summary>Items only, no mesos.</summary>
    [Label("StoreBankRes_GetAll_OnlyItem")]
    [Label("Store Bank Res Get All Only Item", 1)]
    StoreBankResGetAllOnlyItem = 32,

    /// <summary>No fee required.</summary>
    [Label("StoreBankRes_GetAll_NoFee")]
    [Label("Store Bank Res Get All No Fee", 1)]
    StoreBankResGetAllNoFee = 33,

    /// <summary>No inventory space.</summary>
    [Label("StoreBankRes_GetAll_NoSlot")]
    [Label("Store Bank Res Get All No Slot", 1)]
    StoreBankResGetAllNoSlot = 34,

    /// <summary>Open store bank dialog.</summary>
    [Label("StoreBankRes_OpenStoreBankDlg")]
    [Label("Store Bank Res Open Store Bank Dlg", 1)]
    StoreBankResOpenStoreBankDlg = 35,

    /// <summary>Store bank fee result.</summary>
    [Label("StoreBankRes_StoreBankCalculateFee")]
    [Label("Store Bank Res Store Bank Calculate Fee", 1)]
    StoreBankResStoreBankCalculateFee = 36,

    /// <summary>Store bank load failed.</summary>
    [Label("StoreBankRes_StoreBankLoadFailed")]
    [Label("Store Bank Res Store Bank Load Failed", 1)]
    StoreBankResStoreBankLoadFailed = 37,

    /// <summary>Store bank access blocked.</summary>
    [Label("StoreBankRes_StoreBankBlock")]
    [Label("Store Bank Res Store Bank Block", 1)]
    StoreBankResStoreBankBlock = 38,
}
