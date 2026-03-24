using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Map portal type.
/// </summary>
public enum MapPortalType : byte
{
    /// <summary>Spawn point portal.</summary>
    [Label("PORTALTYPE_STARTPOINT")]
    [Label("Start Point", 1)]
    StartPoint = 0,

    /// <summary>Invisible portal.</summary>
    [Label("PORTALTYPE_INVISIBLE")]
    Invisible = 1,

    /// <summary>Visible portal.</summary>
    [Label("PORTALTYPE_VISIBLE")]
    Visible = 2,

    /// <summary>Collision-triggered portal.</summary>
    [Label("PORTALTYPE_COLLISION")]
    Collision = 3,

    /// <summary>Changeable portal.</summary>
    /// <remarks>Documented original client typo: "CHANGABLE" → "CHANGEABLE"; see typos.md.</remarks>
    [Label("PORTALTYPE_CHANGABLE")]
    Changeable = 4,

    /// <summary>Invisible changeable portal.</summary>
    /// <remarks>Documented original client typo: "CHANGABLE" → "CHANGEABLE"; see typos.md.</remarks>
    [Label("PORTALTYPE_CHANGABLE_INVISIBLE")]
    [Label("Changeable Invisible", 1)]
    ChangeableInvisible = 5,

    /// <summary>Town portal point.</summary>
    [Label("PORTALTYPE_TOWNPORTAL_POINT")]
    [Label("Town Portal Point", 1)]
    TownPortalPoint = 6,

    /// <summary>Script-triggered portal.</summary>
    [Label("PORTALTYPE_SCRIPT")]
    Script = 7,

    /// <summary>Invisible script portal.</summary>
    [Label("PORTALTYPE_SCRIPT_INVISIBLE")]
    [Label("Script Invisible", 1)]
    ScriptInvisible = 8,

    /// <summary>Collision script portal.</summary>
    [Label("PORTALTYPE_COLLISION_SCRIPT")]
    [Label("Collision Script", 1)]
    CollisionScript = 9,

    /// <summary>Hidden portal.</summary>
    [Label("PORTALTYPE_HIDDEN")]
    Hidden = 10,

    /// <summary>Hidden script portal.</summary>
    [Label("PORTALTYPE_SCRIPT_HIDDEN")]
    [Label("Script Hidden", 1)]
    ScriptHidden = 11,

    /// <summary>Vertical jump portal.</summary>
    [Label("PORTALTYPE_COLLISION_VERTICAL_JUMP")]
    [Label("Collision Vertical Jump", 1)]
    CollisionVerticalJump = 12,

    /// <summary>Custom impact portal.</summary>
    [Label("PORTALTYPE_COLLISION_CUSTOM_IMPACT")]
    [Label("Collision Custom Impact", 1)]
    CollisionCustomImpact = 13,
}
