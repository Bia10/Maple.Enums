using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Locale / region identifier for the NM (NetMarble) locale system.
/// </summary>
public enum LocaleId : int
{
    /// <summary>Null / unset.</summary>
    [Label("kLocaleID_Null")]
    Null = 0,

    /// <summary>Korea.</summary>
    [Label("kLocaleID_KR")]
    Kr = 1,

    /// <summary>Japan.</summary>
    [Label("kLocaleID_JP")]
    Jp = 256,

    /// <summary>China.</summary>
    [Label("kLocaleID_CN")]
    Cn = 257,

    /// <summary>Taiwan.</summary>
    [Label("kLocaleID_TW")]
    Tw = 258,

    /// <summary>Thailand.</summary>
    [Label("kLocaleID_TH")]
    Th = 259,

    /// <summary>China Netcom.</summary>
    [Label("kLocaleID_CN_CNC")]
    [Label("Cn Cnc", 1)]
    CnCnc = 273,

    /// <summary>China Telecom.</summary>
    [Label("kLocaleID_CN_CT")]
    [Label("Cn Ct", 1)]
    CnCt = 274,

    /// <summary>United States.</summary>
    [Label("kLocaleID_US")]
    Us = 512,

    /// <summary>Europe.</summary>
    [Label("kLocaleID_EU")]
    Eu = 768,

    /// <summary>Korea test server.</summary>
    [Label("kLocaleID_KR_Test")]
    [Label("Kr Test", 1)]
    KrTest = 268435457,
}
