using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Emotion IDs sent in the <c>CP_SendEmotionChange</c> packet (opcode 56).
/// Selects the face expression played on a character.
/// Maps directly to Character.wz face expression node names.
/// </summary>
public enum Emotion : byte
{
    /// <summary>Reset to default resting face.</summary>
    [Label("EMT_DEFAULT")]
    [Label("Default", 1)]
    [Label("default", 2)]
    Default = 0,

    /// <summary>Hit / pain expression.</summary>
    [Label("EMT_HIT")]
    [Label("Hit", 1)]
    [Label("hit", 2)]
    Hit = 1,

    /// <summary>Smile expression.</summary>
    [Label("EMT_SMILE")]
    [Label("Smile", 1)]
    [Label("smile", 2)]
    Smile = 2,

    /// <summary>Troubled / worried expression.</summary>
    [Label("EMT_TROUBLED")]
    [Label("Troubled", 1)]
    [Label("troubled", 2)]
    Troubled = 3,

    /// <summary>Crying expression.</summary>
    [Label("EMT_CRY")]
    [Label("Cry", 1)]
    [Label("cry", 2)]
    Cry = 4,

    /// <summary>Angry expression.</summary>
    [Label("EMT_ANGRY")]
    [Label("Angry", 1)]
    [Label("angry", 2)]
    Angry = 5,

    /// <summary>Bewildered / confused expression.</summary>
    [Label("EMT_BEWILDERED")]
    [Label("Bewildered", 1)]
    [Label("bewildered", 2)]
    Bewildered = 6,

    /// <summary>Stunned expression.</summary>
    [Label("EMT_STUNNED")]
    [Label("Stunned", 1)]
    [Label("stunned", 2)]
    Stunned = 7,
}
