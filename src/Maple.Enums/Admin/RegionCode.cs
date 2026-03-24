using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Region / billing-zone code used alongside <see cref="LocaleId"/>.
/// </summary>
public enum RegionCode : int
{
    /// <summary>Default / unset.</summary>
    [Label("kRegionCode_Default")]
    Default = 0,

    /// <summary>China Telecom 1.</summary>
    [Label("kRegionCode_CT1")]
    Ct1 = 1,

    /// <summary>China Telecom 2.</summary>
    [Label("kRegionCode_CT2")]
    Ct2 = 2,

    /// <summary>China Telecom 3.</summary>
    [Label("kRegionCode_CT3")]
    Ct3 = 3,

    /// <summary>China Telecom 4.</summary>
    [Label("kRegionCode_CT4")]
    Ct4 = 4,

    /// <summary>China Telecom 5.</summary>
    [Label("kRegionCode_CT5")]
    Ct5 = 5,

    /// <summary>China Telecom 6.</summary>
    [Label("kRegionCode_CT6")]
    Ct6 = 6,

    /// <summary>China Netcom 1.</summary>
    [Label("kRegionCode_CNC1")]
    Cnc1 = 11,

    /// <summary>China Netcom 2.</summary>
    [Label("kRegionCode_CNC2")]
    Cnc2 = 12,

    /// <summary>China Netcom 3.</summary>
    [Label("kRegionCode_CNC3")]
    Cnc3 = 13,

    /// <summary>China Netcom 4.</summary>
    [Label("kRegionCode_CNC4")]
    Cnc4 = 14,

    /// <summary>China Netcom 5.</summary>
    [Label("kRegionCode_CNC5")]
    Cnc5 = 15,

    /// <summary>China Netcom 6.</summary>
    [Label("kRegionCode_CNC6")]
    Cnc6 = 16,

    /// <summary>Nexon Partners North America 1.</summary>
    [Label("kRegionCode_NPNA1")]
    Npna1 = 100,

    /// <summary>Nexon America 1.</summary>
    [Label("kRegionCode_NXA1")]
    Nxa1 = 200,

    /// <summary>Nexon America 2.</summary>
    [Label("kRegionCode_NXA2")]
    Nxa2 = 201,

    /// <summary>Taiwan 2.</summary>
    [Label("kRegionCode_TW2")]
    Tw2 = 300,

    /// <summary>Thailand 1.</summary>
    [Label("kRegionCode_TH1")]
    Th1 = 400,

    /// <summary>Japan 2.</summary>
    [Label("kRegionCode_JP2")]
    Jp2 = 500,

    /// <summary>Japan 3.</summary>
    [Label("kRegionCode_JP3")]
    Jp3 = 501,

    /// <summary>Japan 4.</summary>
    [Label("kRegionCode_JP4")]
    Jp4 = 502,

    /// <summary>Europe 1.</summary>
    [Label("kRegionCode_EU1")]
    Eu1 = 600,
}
