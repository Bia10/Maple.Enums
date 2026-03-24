using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Pet auto-speaking trigger type.
/// Conditions under which pets automatically speak.
/// </summary>
public enum AutoSpeakingType : byte
{
    /// <summary>Pet speaks on level up.</summary>
    [Label("AUTOSPEAKING_LEVELUP")]
    [Label("Level Up", 1)]
    LevelUp = 0,

    /// <summary>Pet speaks near level up.</summary>
    [Label("AUTOSPEAKING_PRELEVELUP")]
    [Label("Pre Level Up", 1)]
    PreLevelUp = 1,

    /// <summary>Pet speaks when idle.</summary>
    [Label("AUTOSPEAKING_REST")]
    Rest = 2,

    /// <summary>Pet warns low HP.</summary>
    [Label("AUTOSPEAKING_HPALERT")]
    [Label("Hp Alert", 1)]
    HpAlert = 3,

    /// <summary>No HP potions left.</summary>
    [Label("AUTOSPEAKING_NOHPPOTION")]
    [Label("No Hp Potion", 1)]
    NoHpPotion = 4,

    /// <summary>No MP potions left.</summary>
    [Label("AUTOSPEAKING_NOMPPOTION")]
    [Label("No Mp Potion", 1)]
    NoMpPotion = 5,
}
