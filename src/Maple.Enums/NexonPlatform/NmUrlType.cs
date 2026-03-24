using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Category of URL passed to a Nexon Messenger URL-open call.
/// </summary>
public enum NmUrlType : byte
{
    /// <summary>No URL.</summary>
    [Label("kURLType_NULL")]
    Null = 0,

    /// <summary>Standard web page.</summary>
    [Label("kURLType_Page")]
    Page = 1,

    /// <summary>Game URL.</summary>
    [Label("kURLType_Game")]
    Game = 2,

    /// <summary>Guild page URL.</summary>
    [Label("kURLType_Guild")]
    Guild = 3,

    /// <summary>Direct URL (no page type wrapping).</summary>
    [Label("kURLType_DirectURL")]
    DirectUrl = 4,
}
