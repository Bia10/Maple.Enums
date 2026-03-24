using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Facial expression / emotion type.
/// </summary>
public enum EmotionType : byte
{
    /// <summary>Eye blink.</summary>
    [Label("EMT_BLINK")]
    Blink = 0,

    /// <summary>Damage taken face.</summary>
    [Label("EMT_HIT")]
    Hit = 1,

    /// <summary>Happy face.</summary>
    [Label("EMT_SMILE")]
    Smile = 2,

    /// <summary>Troubled face.</summary>
    [Label("EMT_TROUBLED")]
    Troubled = 3,

    /// <summary>Crying face.</summary>
    [Label("EMT_CRY")]
    Cry = 4,

    /// <summary>Angry face.</summary>
    [Label("EMT_ANGRY")]
    Angry = 5,

    /// <summary>Bewildered face.</summary>
    [Label("EMT_BEWILDERED")]
    Bewildered = 6,

    /// <summary>Stunned face.</summary>
    [Label("EMT_STUNNED")]
    Stunned = 7,

    /// <summary>Nauseous face.</summary>
    [Label("EMT_VOMIT")]
    Vomit = 8,

    /// <summary>Oops face.</summary>
    [Label("EMT_OOPS")]
    Oops = 9,

    /// <summary>Cheering face.</summary>
    [Label("EMT_CHEERS")]
    Cheers = 10,

    /// <summary>Kissing face.</summary>
    [Label("EMT_CHU")]
    Chu = 11,

    /// <summary>Winking face.</summary>
    [Label("EMT_WINK")]
    Wink = 12,

    /// <summary>Pain face.</summary>
    [Label("EMT_PAIN")]
    Pain = 13,

    /// <summary>Sparkling face.</summary>
    [Label("EMT_GLITTER")]
    Glitter = 14,

    /// <summary>Fired-up face.</summary>
    [Label("EMT_BLAZE")]
    Blaze = 15,

    /// <summary>Shining face.</summary>
    [Label("EMT_SHINE")]
    Shine = 16,

    /// <summary>Love-struck face.</summary>
    [Label("EMT_LOVE")]
    Love = 17,

    /// <summary>Despairing face.</summary>
    [Label("EMT_DESPAIR")]
    Despair = 18,

    /// <summary>Humming face.</summary>
    [Label("EMT_HUM")]
    Hum = 19,

    /// <summary>Bowing face.</summary>
    [Label("EMT_BOWING")]
    Bowing = 20,

    /// <summary>Overheated face.</summary>
    [Label("EMT_HOT")]
    Hot = 21,

    /// <summary>Frustrated face.</summary>
    [Label("EMT_DAM")]
    Dam = 22,

    /// <summary>Depressed face.</summary>
    [Label("EMT_QBLUE")]
    QBlue = 23,
}
