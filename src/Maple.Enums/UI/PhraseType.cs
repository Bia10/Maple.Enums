using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// NPC dialogue phrase / text element types.
/// </summary>
public enum PhraseType : byte
{
    /// <summary>No phrase type.</summary>
    [Label("Phrase_None")]
    None = 0,

    /// <summary>List-type phrase element.</summary>
    [Label("Phrase_List")]
    List = 1,

    /// <summary>Function phrase type 0.</summary>
    [Label("Phrase_Func0")]
    Func0 = 2,

    /// <summary>Function phrase type 1.</summary>
    [Label("Phrase_Func1")]
    Func1 = 3,

    /// <summary>Function phrase type 2.</summary>
    [Label("Phrase_Func2")]
    Func2 = 4,

    /// <summary>Function phrase type 3.</summary>
    [Label("Phrase_Func3")]
    Func3 = 5,

    /// <summary>Reward description element.</summary>
    [Label("Phrase_Reward")]
    Reward = 6,

    /// <summary>Item icon display element.</summary>
    [Label("Phrase_ItemIcon")]
    [Label("Item Icon", 1)]
    ItemIcon = 7,

    /// <summary>Item icon with outline border.</summary>
    [Label("Phrase_ItemIcon_Outline")]
    [Label("Item Icon Outline", 1)]
    ItemIconOutline = 8,

    /// <summary>Hidden or secret item icon element.</summary>
    [Label("Phrase_ItemIcon_Secret")]
    [Label("Item Icon Secret", 1)]
    ItemIconSecret = 9,

    /// <summary>Skill icon display element.</summary>
    [Label("Phrase_SkillIcon")]
    [Label("Skill Icon", 1)]
    SkillIcon = 10,

    /// <summary>Canvas image element.</summary>
    [Label("Phrase_Canvas")]
    Canvas = 11,

    /// <summary>Canvas image with outline border.</summary>
    [Label("Phrase_Canvas_Outline")]
    [Label("Canvas Outline", 1)]
    CanvasOutline = 12,

    /// <summary>Canvas with progress bar overlay.</summary>
    [Label("Phrase_Canvas_ProgressBar")]
    [Label("Canvas Progress Bar", 1)]
    CanvasProgressBar = 13,

    /// <summary>Party quest keyword highlight.</summary>
    [Label("Phrase_PartyQuestKeyword")]
    [Label("Party Quest Keyword", 1)]
    PartyQuestKeyword = 14,

    /// <summary>Time-limited quest indicator.</summary>
    [Label("Phrase_TimeLimitQuest")]
    [Label("Time Limit Quest", 1)]
    TimeLimitQuest = 15,

    /// <summary>Daily play quest indicator.</summary>
    [Label("Phrase_DailyPlayQuest")]
    [Label("Daily Play Quest", 1)]
    DailyPlayQuest = 16,

    /// <summary>Quest summary display element.</summary>
    [Label("Phrase_QuestSummary")]
    [Label("Quest Summary", 1)]
    QuestSummary = 17,

    /// <summary>Plain text element.</summary>
    [Label("Phrase_Text")]
    Text = 18,
}
