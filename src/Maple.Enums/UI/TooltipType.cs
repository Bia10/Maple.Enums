using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Tooltip type.
/// Classifies what kind of tooltip to render.
/// </summary>
public enum TooltipType : byte
{
    /// <summary>No tooltip.</summary>
    [Label("TT_NONE")]
    None = 0,

    /// <summary>Plain text tooltip.</summary>
    [Label("TT_STRING")]
    String = 1,

    /// <summary>Secondary text tooltip.</summary>
    [Label("TT_STRING2")]
    String2 = 2,

    /// <summary>World map tooltip.</summary>
    [Label("TT_WORLDMAP")]
    [Label("World Map", 1)]
    WorldMap = 3,

    /// <summary>Equipment item tooltip.</summary>
    [Label("TT_EQUIP")]
    Equip = 4,

    /// <summary>Bundle (use/etc) item tooltip.</summary>
    [Label("TT_BUNDLE")]
    Bundle = 5,

    /// <summary>Pet item tooltip.</summary>
    [Label("TT_PET")]
    Pet = 6,

    /// <summary>Skill tooltip.</summary>
    [Label("TT_SKILL")]
    Skill = 7,

    /// <summary>Ring item tooltip.</summary>
    [Label("TT_RING")]
    Ring = 8,

    /// <summary>Package item tooltip.</summary>
    [Label("TT_PACKAGE")]
    Package = 9,

    /// <summary>Inventory slot expansion tooltip.</summary>
    [Label("TT_SLOTINC")]
    [Label("Slot Inc", 1)]
    SlotInc = 10,

    /// <summary>Macro system skill tooltip.</summary>
    [Label("TT_MACROSYSSKILL")]
    [Label("Macro Sys Skill", 1)]
    MacroSysSkill = 11,
}
