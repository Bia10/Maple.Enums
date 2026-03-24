using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character body transform / metamorphosis type (ghost / UFO morph).
/// Distinct from <see cref="CharacterBodyType"/> which describes avatar components.
/// </summary>
public enum BodyChangeType : byte
{
    /// <summary>Normal body.</summary>
    [Label("CHANGEBODY_NONE")]
    None = 0,

    /// <summary>Ghost morph on death.</summary>
    [Label("CHANGEBODY_GHOST")]
    Ghost = 1,

    /// <summary>UFO morph transform.</summary>
    [Label("CHANGEBODY_UFO")]
    Ufo = 2,
}
