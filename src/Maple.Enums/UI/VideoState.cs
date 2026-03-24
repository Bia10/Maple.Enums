using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Video / logo playback state used by the CLogo class.
/// </summary>
public enum VideoState : byte
{
    /// <summary>Video not available.</summary>
    [Label("VIDEO_STATE_UNAVAILABLE")]
    Unavailable = 0,

    /// <summary>Player idle, not started.</summary>
    [Label("VIDEO_STATE_IDLE")]
    Idle = 1,

    /// <summary>Video loaded and ready.</summary>
    [Label("VIDEO_STATE_READY")]
    Ready = 2,

    /// <summary>Video playing.</summary>
    [Label("VIDEO_STATE_PLAY")]
    Play = 3,

    /// <summary>Video paused.</summary>
    [Label("VIDEO_STATE_PAUSE")]
    Pause = 4,

    /// <summary>Playback finished.</summary>
    [Label("VIDEO_STATE_END")]
    End = 5,
}
