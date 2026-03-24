using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Identifies which authentication module the Nexon Platform used to verify a login.
/// </summary>
public enum NmAuthCheckModuleType : byte
{
    /// <summary>Auth module type is unknown.</summary>
    [Label("kAuthCheckModuleType_Unknown")]
    Unknown = 0,

    /// <summary>Nexon Passport authentication module.</summary>
    [Label("kAuthCheckModuleType_NexonPassport")]
    NexonPassport = 1,

    /// <summary>SP Server authentication module.</summary>
    [Label("kAuthCheckModuleType_SpServer")]
    SpServer = 2,
}
