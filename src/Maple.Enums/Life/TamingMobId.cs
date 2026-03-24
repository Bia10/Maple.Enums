using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Well-known taming mob (mount) item IDs.
/// </summary>
public enum TamingMobId : int
{
    /// <summary>Red Draco dragon mount.</summary>
    [Label("TAMINGMOB_RED_DRACO")]
    [Label("Red Draco", 1)]
    RedDraco = 1902002,

    /// <summary>Ryuho mount (Lv. 50).</summary>
    [Label("TAMINGMOB_RYUHO_50")]
    Ryuho50 = 1902015,

    /// <summary>Ryuho mount (Lv. 100).</summary>
    [Label("TAMINGMOB_RYUHO_100")]
    Ryuho100 = 1902016,

    /// <summary>Ryuho mount (Lv. 150).</summary>
    [Label("TAMINGMOB_RYUHO_150")]
    Ryuho150 = 1902017,

    /// <summary>Ryuho mount (Lv. 200).</summary>
    [Label("TAMINGMOB_RYUHO_200")]
    Ryuho200 = 1902018,

    /// <summary>Evan's dragon Mir (stage 1).</summary>
    [Label("TAMINGMOB_MIR_1")]
    Mir1 = 1902040,

    /// <summary>Evan's dragon Mir (stage 2).</summary>
    [Label("TAMINGMOB_MIR_2")]
    Mir2 = 1902041,

    /// <summary>Evan's dragon Mir (stage 3).</summary>
    [Label("TAMINGMOB_MIR_3")]
    Mir3 = 1902042,
}
