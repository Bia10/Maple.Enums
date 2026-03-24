using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash pet food use result code.
/// </summary>
public enum CashPetFoodResult : byte
{
    /// <summary>Pet fed successfully.</summary>
    [Label("CashPetFoodRes_Success")]
    Success = 0,

    /// <summary>Feeding failed.</summary>
    [Label("CashPetFoodRes_Fail")]
    Fail = 1,
}
