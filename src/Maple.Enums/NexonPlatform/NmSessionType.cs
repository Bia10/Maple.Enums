using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Type of communication session established by the Nexon Messenger.
/// </summary>
public enum NmSessionType : byte
{
    /// <summary>General-purpose session.</summary>
    [Label("kSessionType_General")]
    General = 0,

    /// <summary>Chat session.</summary>
    [Label("kSessionType_Chat")]
    Chat = 1,

    /// <summary>File upload session.</summary>
    [Label("kSessionType_FileUpload")]
    FileUpload = 2,

    /// <summary>File download session.</summary>
    [Label("kSessionType_FileDownload")]
    FileDownload = 3,

    /// <summary>White-board collaboration session.</summary>
    [Label("kSessionType_WhiteBoard")]
    WhiteBoard = 4,
}
