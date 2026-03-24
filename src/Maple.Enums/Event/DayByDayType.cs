using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Day-by-day event bonus types.
/// </summary>
public enum DayByDayType : byte
{
    /// <summary>Party experience bonus.</summary>
    [Label("DAYBYDAY_PARTYBONUS")]
    [Label("Party Bonus", 1)]
    PartyBonus = 0,

    /// <summary>Enhanced item options.</summary>
    [Label("DAYBYDAY_GOODOPTIONITEM")]
    [Label("Good Option Item", 1)]
    GoodOptionItem = 1,

    /// <summary>Quest completion bonus.</summary>
    [Label("DAYBYDAY_QUESTCOMPLETEBONUS")]
    [Label("Quest Complete Bonus", 1)]
    QuestCompleteBonus = 2,

    /// <summary>Potion price discount.</summary>
    [Label("DAYBYDAY_POTIONDISCOUNT")]
    [Label("Potion Discount", 1)]
    PotionDiscount = 3,

    /// <summary>No bonus active.</summary>
    [Label("DAYBYDAY_NO")]
    No = 4,
}
