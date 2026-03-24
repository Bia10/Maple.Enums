using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item crafting quality tier.
/// Different from <see cref="ItemGrade"/> which is potential grade (Normal/Rare/Epic/Unique).
/// This describes the crafting quality of a maker-created item.
/// </summary>
public enum ItemQuality : sbyte
{
    /// <summary>Below-normal crafting result.</summary>
    [Label("ITEMQUALITY_BAD")]
    Bad = -1,

    /// <summary>Normal crafting result.</summary>
    [Label("ITEMQUALITY_DEFAULT")]
    Default = 0,

    /// <summary>Above-normal crafting result.</summary>
    [Label("ITEMQUALITY_GOOD")]
    Good = 1,

    /// <summary>High-quality crafting result.</summary>
    [Label("ITEMQUALITY_VERYGOOD")]
    [Label("Very Good", 1)]
    VeryGood = 2,

    /// <summary>Premium crafting result.</summary>
    [Label("ITEMQUALITY_PREMIUM")]
    Premium = 3,

    /// <summary>Excellent crafting result.</summary>
    [Label("ITEMQUALITY_EXCELLENT")]
    Excellent = 4,

    /// <summary>Highest-tier crafting result.</summary>
    [Label("ITEMQUALITY_SPECIAL")]
    Special = 5,
}
