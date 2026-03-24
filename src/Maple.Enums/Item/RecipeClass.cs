using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Crafting recipe classification types.
/// </summary>
public enum RecipeClass : byte
{
    /// <summary>Recipe list sentinel start.</summary>
    [Label("RECIPE_CLASS_START")]
    Start = 0,

    /// <summary>Standard craftable recipe.</summary>
    [Label("RECIPE_CLASS_NORMAL")]
    Normal = 1,

    /// <summary>Hidden unlockable recipe.</summary>
    [Label("RECIPE_CLASS_HIDDEN")]
    Hidden = 2,

    /// <summary>Monster Crystal recipe.</summary>
    [Label("RECIPE_CLASS_MONSTER_CRYSTAL")]
    [Label("Monster Crystal", 1)]
    MonsterCrystal = 3,

    /// <summary>Equipment disassembly recipe.</summary>
    [Label("RECIPE_CLASS_EQUIP_DISASSEMBLE")]
    [Label("Equip Disassemble", 1)]
    EquipDisassemble = 4,

    /// <summary>Recipe list sentinel end.</summary>
    [Label("RECIPE_CLASS_END")]
    End = 5,
}
