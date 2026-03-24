using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Recovery info display categories for HP/MP stats.
/// </summary>
public enum RecoveryInfoType : byte
{
    /// <summary>Total HP applied.</summary>
    [Label("RECOVERYINFO_TOTALHP_APPLY")]
    [Label("Total Hp Apply", 1)]
    TotalHpApply = 0,

    /// <summary>Total HP merit cost.</summary>
    [Label("RECOVERYINFO_TOTALHP_REQ_MERIT")]
    [Label("Total Hp Req Merit", 1)]
    TotalHpReqMerit = 1,

    /// <summary>Total MP applied.</summary>
    [Label("RECOVERYINFO_TOTALMP_APPLY")]
    [Label("Total Mp Apply", 1)]
    TotalMpApply = 2,

    /// <summary>Total MP merit cost.</summary>
    [Label("RECOVERYINFO_TOTALMP_REQ_MERIT")]
    [Label("Total Mp Req Merit", 1)]
    TotalMpReqMerit = 3,

    /// <summary>Average HP applied.</summary>
    [Label("RECOVERYINFO_AVERAGEHP_APPLY")]
    [Label("Average Hp Apply", 1)]
    AverageHpApply = 4,

    /// <summary>Average HP merit cost.</summary>
    [Label("RECOVERYINFO_AVERAGEHP_REQ_MERIT")]
    [Label("Average Hp Req Merit", 1)]
    AverageHpReqMerit = 5,

    /// <summary>Average MP applied.</summary>
    [Label("RECOVERYINFO_AVERAGEMP_APPLY")]
    [Label("Average Mp Apply", 1)]
    AverageMpApply = 6,

    /// <summary>Average MP merit cost.</summary>
    [Label("RECOVERYINFO_AVERAGEMP_REQ_MERIT")]
    [Label("Average Mp Req Merit", 1)]
    AverageMpReqMerit = 7,

    /// <summary>Recovery item use count.</summary>
    [Label("RECOVERYINFO_USE_COUNT")]
    [Label("Use Count", 1)]
    UseCount = 8,

    /// <summary>Projected use per hour.</summary>
    [Label("RECOVERYINFO_FORECAST_USE_PERHOUR")]
    [Label("Forecast Use Per Hour", 1)]
    ForecastUsePerHour = 9,

    /// <summary>No recovery info.</summary>
    [Label("RECOVERYINFO_NO")]
    No = 10,
}
