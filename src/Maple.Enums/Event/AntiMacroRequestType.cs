using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Anti-macro challenge trigger request type.
/// </summary>
public enum AntiMacroRequestType : byte
{
    /// <summary>Triggered by another player.</summary>
    [Label("AntiMacroUserRequest")]
    UserRequest = 1,

    /// <summary>Triggered by a GM.</summary>
    [Label("AntiMacroAdminRequest")]
    AdminRequest = 2,

    /// <summary>Triggered automatically by server.</summary>
    [Label("AntiMacroAutoRequest")]
    AutoRequest = 3,

    /// <summary>Triggered by field rule.</summary>
    [Label("AntiMacroFieldRequest")]
    FieldRequest = 4,
}
