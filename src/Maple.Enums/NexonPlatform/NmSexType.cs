using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Gender recorded on a Nexon Messenger user account.
/// </summary>
public enum NmSexType : byte
{
    /// <summary>Sex is unknown.</summary>
    [Label("kSex_Unknown")]
    Unknown = 0,

    /// <summary>Male.</summary>
    [Label("kSex_Male")]
    Male = 1,

    /// <summary>Female.</summary>
    [Label("kSex_Female")]
    Female = 2,
}
