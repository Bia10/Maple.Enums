using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// NPC conversation speaker mode parameter flags.
/// </summary>
[Flags]
public enum ConversationSpeakerFlags : byte
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Disable ESC to close.</summary>
    [Label("SMP_NOESC")]
    [Label("No ESC", 1)]
    NoESC = 0x1,

    /// <summary>Show player avatar instead of NPC.</summary>
    [Label("SMP_NPC_REPLACED_BY_USER")]
    [Label("NPC Replaced By User", 1)]
    NPCReplacedByUser = 0x2,

    /// <summary>Show different NPC sprite.</summary>
    [Label("SMP_NPC_REPLACED_BY_NPC")]
    [Label("NPC Replaced By NPC", 1)]
    NPCReplacedByNPC = 0x4,

    /// <summary>Mirror/flip the speaker image.</summary>
    [Label("SMP_FLIPIMAGE")]
    [Label("Flip Image", 1)]
    FlipImage = 0x8,
}
