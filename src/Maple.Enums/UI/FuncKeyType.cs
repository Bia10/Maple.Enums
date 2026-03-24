using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Function key mapping type.
/// Classifies what a function key slot is bound to.
/// </summary>
public enum FuncKeyType : byte
{
    /// <summary>No binding.</summary>
    [Label("T_NONE")]
    None = 0,

    /// <summary>Bound to a skill.</summary>
    [Label("T_SKILL")]
    Skill = 1,

    /// <summary>Bound to an item.</summary>
    [Label("T_ITEM")]
    Item = 2,

    /// <summary>Bound to an expression.</summary>
    [Label("T_EMOTION")]
    Emotion = 3,

    /// <summary>Bound to a menu.</summary>
    [Label("T_MENU")]
    Menu = 4,

    /// <summary>Bound to basic action.</summary>
    [Label("T_BASICACTION")]
    [Label("Basic Action", 1)]
    BasicAction = 5,

    /// <summary>Bound to basic emotion.</summary>
    [Label("T_BASICEMOTION")]
    [Label("Basic Emotion", 1)]
    BasicEmotion = 6,

    /// <summary>Bound to an effect.</summary>
    [Label("T_EFFECT")]
    Effect = 7,

    /// <summary>Bound to skill macro.</summary>
    [Label("T_MACROSKILL")]
    [Label("Macro Skill", 1)]
    MacroSkill = 8,
}
