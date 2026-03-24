using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Weapon animation attack action type.
/// </summary>
public enum AttackActionType : byte
{
    /// <summary>One-handed weapon swing.</summary>
    [Label("AAT_OneHand")]
    [Label("One Hand", 1)]
    OneHand = 1,

    /// <summary>Spear or polearm thrust.</summary>
    [Label("AAT_Spear_PoleArm")]
    [Label("Spear Pole Arm", 1)]
    SpearPoleArm = 2,

    /// <summary>Bow shot.</summary>
    [Label("AAT_Bow")]
    Bow = 3,

    /// <summary>Crossbow shot.</summary>
    [Label("AAT_CrossBow")]
    [Label("Cross Bow", 1)]
    CrossBow = 4,

    /// <summary>Two-handed weapon swing.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("AAT_TowHand")]
    [Label("Two Hand", 1)]
    TwoHand = 5,

    /// <summary>Staff or wand cast.</summary>
    [Label("AAT_Staff_Wand")]
    [Label("Staff Wand", 1)]
    StaffWand = 6,

    /// <summary>Throwing star/knife.</summary>
    [Label("AAT_ThrowingGloves")]
    [Label("Throwing Gloves", 1)]
    ThrowingGloves = 7,

    /// <summary>Knuckle punch.</summary>
    [Label("AAT_Knuckle")]
    Knuckle = 8,

    /// <summary>Gun shot.</summary>
    [Label("AAT_Gun")]
    Gun = 9,

    /// <summary>Dual dagger slash.</summary>
    [Label("AAT_DualDagger")]
    [Label("Dual Dagger", 1)]
    DualDagger = 10,
}
