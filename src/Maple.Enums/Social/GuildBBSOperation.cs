using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Guild bulletin board operation types.
/// </summary>
public enum GuildBBSOperation : byte
{
    /// <summary>Register a post.</summary>
    [Label("GuildBBS_Register")]
    Register = 0,

    /// <summary>Delete a post.</summary>
    [Label("GuildBBS_Delete")]
    Delete = 1,

    /// <summary>Request post list.</summary>
    [Label("GuildBBS_LoadListRequest")]
    [Label("Load List Request", 1)]
    LoadListRequest = 2,

    /// <summary>Request post details.</summary>
    [Label("GuildBBS_ViewEntryRequest")]
    [Label("View Entry Request", 1)]
    ViewEntryRequest = 3,

    /// <summary>Post a comment.</summary>
    [Label("GuildBBS_RegisterComment")]
    [Label("Register Comment", 1)]
    RegisterComment = 4,

    /// <summary>Delete a comment.</summary>
    [Label("GuildBBS_DeleteComment")]
    [Label("Delete Comment", 1)]
    DeleteComment = 5,

    /// <summary>Post list result.</summary>
    [Label("GuildBBS_LoadListResult")]
    [Label("Load List Result", 1)]
    LoadListResult = 6,

    /// <summary>Post detail result.</summary>
    [Label("GuildBBS_ViewEntryResult")]
    [Label("View Entry Result", 1)]
    ViewEntryResult = 7,

    /// <summary>Post not found.</summary>
    [Label("GuildBBS_EntryNotFound")]
    [Label("Entry Not Found", 1)]
    EntryNotFound = 8,
}
