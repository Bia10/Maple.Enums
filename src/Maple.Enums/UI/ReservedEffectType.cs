using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Reserved user effect sub-types (used with UserEffect_ReservedEffect).
/// </summary>
public enum ReservedEffectType : byte
{
    /// <summary>One-shot animation effect.</summary>
    [Label("RESERVED_EFFECT_ONETIME_ANIMATION")]
    [Label("One Time Animation", 1)]
    OneTimeAnimation = 0,

    /// <summary>Squib particle effect.</summary>
    [Label("RESERVED_EFFECT_SQUIB")]
    Squib = 1,

    /// <summary>Map transition effect.</summary>
    [Label("RESERVED_EFFECT_MAP_TRANSFER")]
    [Label("Map Transfer", 1)]
    MapTransfer = 2,

    /// <summary>Change avatar appearance.</summary>
    [Label("RESERVED_EFFECT_SET_AVATAR_LOOK")]
    [Label("Set Avatar Look", 1)]
    SetAvatarLook = 3,

    /// <summary>Change avatar action.</summary>
    [Label("RESERVED_EFFECT_SET_AVATAR_ACTION")]
    [Label("Set Avatar Action", 1)]
    SetAvatarAction = 4,

    /// <summary>Change background music.</summary>
    [Label("RESERVED_EFFECT_SET_BGM")]
    [Label("Set Bgm", 1)]
    SetBgm = 5,

    /// <summary>Change facial expression.</summary>
    [Label("RESERVED_EFFECT_SET_EMOTION")]
    [Label("Set Emotion", 1)]
    SetEmotion = 6,
}
