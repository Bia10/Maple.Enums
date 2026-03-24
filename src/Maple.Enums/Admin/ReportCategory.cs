using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Player report category types.
/// </summary>
public enum ReportCategory : byte
{
    /// <summary>Profanity or harassment.</summary>
    [Label("TYPEID_CURSE")]
    Curse = 1,

    /// <summary>Spam or advertising.</summary>
    [Label("TYPEID_AD")]
    Advertisement = 2,

    /// <summary>Cheating or exploiting.</summary>
    [Label("TYPEID_CHEAT")]
    Cheat = 3,

    // 0x4 reserved/unused in V95.

    /// <summary>Real money trading.</summary>
    [Label("TYPEID_REALMONEYTRADE")]
    [Label("Real Money Trade", 1)]
    RealMoneyTrade = 5,

    // 0x6 reserved/unused in V95.

    /// <summary>Player impersonation.</summary>
    [Label("TYPEID_IMPERSONATION")]
    Impersonation = 7,

    /// <summary>Private info sharing.</summary>
    [Label("TYPEID_PRIVATEINFO")]
    [Label("Private Info", 1)]
    PrivateInfo = 8,

    /// <summary>Botting or macro use.</summary>
    [Label("TYPEID_MACROPROGRAM")]
    [Label("Macro Program", 1)]
    MacroProgram = 9,

    /// <summary>Admin macro detection.</summary>
    [Label("TYPEID_ADMINMACROPROGRAM")]
    [Label("Admin Macro Program", 1)]
    AdminMacroProgram = 10,
}
