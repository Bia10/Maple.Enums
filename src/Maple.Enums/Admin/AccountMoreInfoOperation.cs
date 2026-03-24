using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Account "more info" panel operation codes including find-friend sub-operations.
/// </summary>
public enum AccountMoreInfoOperation : byte
{
    /// <summary>Initial/default state.</summary>
    [Label("AccountMoreInfo_First")]
    First = 0,

    /// <summary>Client requests info load.</summary>
    [Label("AccountMoreInfo_LoadRequest")]
    [Label("Load Request", 1)]
    LoadRequest = 1,

    /// <summary>Info load completed.</summary>
    [Label("AccountMoreInfo_LoadDone")]
    [Label("Load Done", 1)]
    LoadDone = 2,

    /// <summary>Client requests info update.</summary>
    [Label("AccountMoreInfo_UpdateRequest")]
    [Label("Update Request", 1)]
    UpdateRequest = 3,

    /// <summary>Info update completed.</summary>
    [Label("AccountMoreInfo_UpdateDone")]
    [Label("Update Done", 1)]
    UpdateDone = 4,

    /// <summary>Info update failed.</summary>
    [Label("AccountMoreInfo_UpdateFail")]
    [Label("Update Fail", 1)]
    UpdateFail = 5,

    /// <summary>Find-friend search request.</summary>
    [Label("FindFriend_SearchRequest")]
    [Label("Find Friend Search Request", 1)]
    FindFriendSearchRequest = 6,

    /// <summary>Find-friend search result.</summary>
    [Label("FindFriend_SearchResult")]
    [Label("Find Friend Search Result", 1)]
    FindFriendSearchResult = 7,

    /// <summary>Target user not found.</summary>
    [Label("FindFriend_ErrorCode_NoUser")]
    [Label("Find Friend Error Code No User", 1)]
    FindFriendErrorCodeNoUser = 8,

    /// <summary>Friend points full.</summary>
    [Label("FindFriend_ErrorCode_FullPoint")]
    [Label("Find Friend Error Code Full Point", 1)]
    FindFriendErrorCodeFullPoint = 9,

    /// <summary>Cannot invite yourself.</summary>
    [Label("FindFriend_ErrorCode_InviteSelf")]
    [Label("Find Friend Error Code Invite Self", 1)]
    FindFriendErrorCodeInviteSelf = 10,

    /// <summary>Invite queue overflow.</summary>
    [Label("FindFriend_ErrorCode_OverflowQueue")]
    [Label("Find Friend Error Code Overflow Queue", 1)]
    FindFriendErrorCodeOverflowQueue = 12,
}
