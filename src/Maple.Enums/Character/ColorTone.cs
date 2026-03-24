using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Color tone transfer overlay types.
/// </summary>
public enum ColorTone : byte
{
    /// <summary>No color overlay.</summary>
    [Label("NO_TRANSFER")]
    [Label("No Transfer", 1)]
    NoTransfer = 0,

    /// <summary>Red tint overlay.</summary>
    [Label("RED_TONE")]
    [Label("Red Tone", 1)]
    RedTone = 1,

    /// <summary>Blue tint overlay.</summary>
    [Label("BLUE_TONE")]
    [Label("Blue Tone", 1)]
    BlueTone = 2,

    /// <summary>Debug test tone.</summary>
    [Label("TEST_TONE")]
    [Label("Test Tone", 1)]
    TestTone = 3,

    /// <summary>Sentinel / end marker.</summary>
    [Label("TONE_NO")]
    [Label("Tone No", 1)]
    ToneNo = 4,
}
