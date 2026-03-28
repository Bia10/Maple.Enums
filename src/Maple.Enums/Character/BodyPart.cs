using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character body part slot index used to address equipment positions.
/// Stored as the integer key in the character's equipment inventory.
/// </summary>
public enum BodyPart : short
{
    /// <summary>Hair.</summary>
    [Label("BP_HAIR")]
    Hair = 0,

    /// <summary>Hat / helmet.</summary>
    [Label("BP_CAP")]
    Cap = 1,

    /// <summary>Face accessory.</summary>
    [Label("BP_FACEACC")]
    [Label("Face Acc", 1)]
    FaceAcc = 2,

    /// <summary>Eye accessory.</summary>
    [Label("BP_EYEACC")]
    [Label("Eye Acc", 1)]
    EyeAcc = 3,

    /// <summary>Earring.</summary>
    [Label("BP_EARACC")]
    [Label("Ear Acc", 1)]
    EarAcc = 4,

    /// <summary>Top / overall.</summary>
    [Label("BP_CLOTHES")]
    Clothes = 5,

    /// <summary>Bottom.</summary>
    [Label("BP_PANTS")]
    Pants = 6,

    /// <summary>Footwear.</summary>
    [Label("BP_SHOES")]
    Shoes = 7,

    /// <summary>Gloves.</summary>
    [Label("BP_GLOVES")]
    Gloves = 8,

    /// <summary>Cape.</summary>
    [Label("BP_CAPE")]
    Cape = 9,

    /// <summary>Shield / secondary weapon.</summary>
    [Label("BP_SHIELD")]
    Shield = 10,

    /// <summary>Weapon.</summary>
    [Label("BP_WEAPON")]
    Weapon = 11,

    /// <summary>First ring.</summary>
    [Label("BP_RING1")]
    Ring1 = 12,

    /// <summary>Second ring.</summary>
    [Label("BP_RING2")]
    Ring2 = 13,

    /// <summary>First pet equip.</summary>
    [Label("BP_PETWEAR")]
    [Label("Pet Wear", 1)]
    PetWear = 14,

    /// <summary>Third ring.</summary>
    [Label("BP_RING3")]
    Ring3 = 15,

    /// <summary>Fourth ring.</summary>
    [Label("BP_RING4")]
    Ring4 = 16,

    /// <summary>Pendant.</summary>
    [Label("BP_PENDANT")]
    Pendant = 17,

    /// <summary>Taming mob mount.</summary>
    [Label("BP_TAMINGMOB")]
    [Label("Taming Mob", 1)]
    TamingMob = 18,

    /// <summary>Mount saddle.</summary>
    [Label("BP_SADDLE")]
    Saddle = 19,

    /// <summary>Mob equip.</summary>
    [Label("BP_MOBEQUIP")]
    [Label("Mob Equip", 1)]
    MobEquip = 20,

    /// <summary>First pet ring label.</summary>
    [Label("BP_PETRING_LABEL")]
    [Label("Pet Ring Label", 1)]
    PetRingLabel = 21,

    /// <summary>First pet ability: item pick-up.</summary>
    [Label("BP_PETABIL_ITEM")]
    [Label("Pet Abil Item", 1)]
    PetAbilItem = 22,

    /// <summary>First pet ability: meso pick-up.</summary>
    [Label("BP_PETABIL_MESO")]
    [Label("Pet Abil Meso", 1)]
    PetAbilMeso = 23,

    /// <summary>First pet ability: HP auto-consume.</summary>
    [Label("BP_PETABIL_HPCONSUME")]
    [Label("Pet Abil Hp Consume", 1)]
    PetAbilHpConsume = 24,

    /// <summary>First pet ability: MP auto-consume.</summary>
    [Label("BP_PETABIL_MPCONSUME")]
    [Label("Pet Abil Mp Consume", 1)]
    PetAbilMpConsume = 25,

    /// <summary>First pet ability: sweep for drop.</summary>
    [Label("BP_PETABIL_SWEEPFORDROP")]
    [Label("Pet Abil Sweep For Drop", 1)]
    PetAbilSweepForDrop = 26,

    /// <summary>First pet ability: long-range pick-up.</summary>
    [Label("BP_PETABIL_LONGRANGE")]
    [Label("Pet Abil Long Range", 1)]
    PetAbilLongRange = 27,

    /// <summary>First pet ability: pick up others' drops.</summary>
    [Label("BP_PETABIL_PICKUPOTHERS")]
    [Label("Pet Abil Pickup Others", 1)]
    PetAbilPickupOthers = 28,

    /// <summary>First pet ring quote bubble.</summary>
    [Label("BP_PETRING_QUOTE")]
    [Label("Pet Ring Quote", 1)]
    PetRingQuote = 29,

    /// <summary>Second pet equip.</summary>
    [Label("BP_PETWEAR2")]
    [Label("Pet Wear 2", 1)]
    PetWear2 = 30,

    /// <summary>Second pet ring label.</summary>
    [Label("BP_PETRING_LABEL2")]
    [Label("Pet Ring Label 2", 1)]
    PetRingLabel2 = 31,

    /// <summary>Second pet ring quote bubble.</summary>
    [Label("BP_PETRING_QUOTE2")]
    [Label("Pet Ring Quote 2", 1)]
    PetRingQuote2 = 32,

    /// <summary>Second pet ability: item pick-up.</summary>
    [Label("BP_PETABIL_ITEM2")]
    [Label("Pet Abil Item 2", 1)]
    PetAbilItem2 = 33,

    /// <summary>Second pet ability: meso pick-up.</summary>
    [Label("BP_PETABIL_MESO2")]
    [Label("Pet Abil Meso 2", 1)]
    PetAbilMeso2 = 34,

    /// <summary>Second pet ability: sweep for drop.</summary>
    [Label("BP_PETABIL_SWEEPFORDROP2")]
    [Label("Pet Abil Sweep For Drop 2", 1)]
    PetAbilSweepForDrop2 = 35,

    /// <summary>Second pet ability: long-range pick-up.</summary>
    [Label("BP_PETABIL_LONGRANGE2")]
    [Label("Pet Abil Long Range 2", 1)]
    PetAbilLongRange2 = 36,

    /// <summary>Second pet ability: pick up others' drops.</summary>
    [Label("BP_PETABIL_PICKUPOTHERS2")]
    [Label("Pet Abil Pickup Others 2", 1)]
    PetAbilPickupOthers2 = 37,

    /// <summary>Third pet equip.</summary>
    [Label("BP_PETWEAR3")]
    [Label("Pet Wear 3", 1)]
    PetWear3 = 38,

    /// <summary>Third pet ring label.</summary>
    [Label("BP_PETRING_LABEL3")]
    [Label("Pet Ring Label 3", 1)]
    PetRingLabel3 = 39,

    /// <summary>Third pet ring quote bubble.</summary>
    [Label("BP_PETRING_QUOTE3")]
    [Label("Pet Ring Quote 3", 1)]
    PetRingQuote3 = 40,

    /// <summary>Third pet ability: item pick-up.</summary>
    [Label("BP_PETABIL_ITEM3")]
    [Label("Pet Abil Item 3", 1)]
    PetAbilItem3 = 41,

    /// <summary>Third pet ability: meso pick-up.</summary>
    [Label("BP_PETABIL_MESO3")]
    [Label("Pet Abil Meso 3", 1)]
    PetAbilMeso3 = 42,

    /// <summary>Third pet ability: sweep for drop.</summary>
    [Label("BP_PETABIL_SWEEPFORDROP3")]
    [Label("Pet Abil Sweep For Drop 3", 1)]
    PetAbilSweepForDrop3 = 43,

    /// <summary>Third pet ability: long-range pick-up.</summary>
    [Label("BP_PETABIL_LONGRANGE3")]
    [Label("Pet Abil Long Range 3", 1)]
    PetAbilLongRange3 = 44,

    /// <summary>Third pet ability: pick up others' drops.</summary>
    [Label("BP_PETABIL_PICKUPOTHERS3")]
    [Label("Pet Abil Pickup Others 3", 1)]
    PetAbilPickupOthers3 = 45,

    /// <summary>First pet ability: ignore items filter slot 1.</summary>
    [Label("BP_PETABIL_IGNOREITEMS1")]
    [Label("Pet Abil Ignore Items 1", 1)]
    PetAbilIgnoreItems1 = 46,

    /// <summary>Second pet ability: ignore items filter slot 2.</summary>
    [Label("BP_PETABIL_IGNOREITEMS2")]
    [Label("Pet Abil Ignore Items 2", 1)]
    PetAbilIgnoreItems2 = 47,

    /// <summary>Third pet ability: ignore items filter slot 3.</summary>
    [Label("BP_PETABIL_IGNOREITEMS3")]
    [Label("Pet Abil Ignore Items 3", 1)]
    PetAbilIgnoreItems3 = 48,

    /// <summary>Medal.</summary>
    [Label("BP_MEDAL")]
    Medal = 49,

    /// <summary>Belt.</summary>
    [Label("BP_BELT")]
    Belt = 50,

    /// <summary>Shoulder armor.</summary>
    [Label("BP_SHOULDER")]
    Shoulder = 51,

    /// <summary>Placeholder slot 3 (unused).</summary>
    [Label("BP_NOTHING3")]
    [Label("Nothing 3", 1)]
    Nothing3 = 54,

    /// <summary>Placeholder slot 2 (unused).</summary>
    [Label("BP_NOTHING2")]
    [Label("Nothing 2", 1)]
    Nothing2 = 55,

    /// <summary>Placeholder slot 1 (unused).</summary>
    [Label("BP_NOTHING1")]
    [Label("Nothing 1", 1)]
    Nothing1 = 56,

    /// <summary>Placeholder slot 0 (unused).</summary>
    [Label("BP_NOTHING0")]
    [Label("Nothing 0", 1)]
    Nothing0 = 57,

    /// <summary>Extended slot 0; also the first extra pendant position (<c>BP_EXT_PENDANT1</c>).</summary>
    [Label("BP_EXT_0")]
    [Label("Ext 0", 1)]
    Ext0 = 59,

    /// <summary>Extended slot 1.</summary>
    [Label("BP_EXT_1")]
    [Label("Ext 1", 1)]
    Ext1 = 60,

    /// <summary>Extended slot 2.</summary>
    [Label("BP_EXT_2")]
    [Label("Ext 2", 1)]
    Ext2 = 61,

    /// <summary>Extended slot 3.</summary>
    [Label("BP_EXT_3")]
    [Label("Ext 3", 1)]
    Ext3 = 62,

    /// <summary>Extended slot 4.</summary>
    [Label("BP_EXT_4")]
    [Label("Ext 4", 1)]
    Ext4 = 63,

    /// <summary>Extended slot 5.</summary>
    [Label("BP_EXT_5")]
    [Label("Ext 5", 1)]
    Ext5 = 64,

    /// <summary>Extended slot 6.</summary>
    [Label("BP_EXT_6")]
    [Label("Ext 6", 1)]
    Ext6 = 65,

    /// <summary>Sticker slot.</summary>
    [Label("BP_STICKER")]
    Sticker = 100,

    /// <summary>Dragon hat.</summary>
    [Label("DP_CAP")]
    [Label("Dragon Cap", 1)]
    DragonCap = 1000,

    /// <summary>Dragon pendant.</summary>
    [Label("DP_PENDANT")]
    [Label("Dragon Pendant", 1)]
    DragonPendant = 1001,

    /// <summary>Dragon wings.</summary>
    [Label("DP_WING")]
    [Label("Dragon Wing", 1)]
    DragonWing = 1002,

    /// <summary>Dragon shoes.</summary>
    [Label("DP_SHOES")]
    [Label("Dragon Shoes", 1)]
    DragonShoes = 1003,

    /// <summary>Mechanic engine.</summary>
    [Label("MP_ENGINE")]
    [Label("Mechanic Engine", 1)]
    MechanicEngine = 1100,

    /// <summary>Mechanic arm.</summary>
    [Label("MP_ARM")]
    [Label("Mechanic Arm", 1)]
    MechanicArm = 1101,

    /// <summary>Mechanic leg.</summary>
    [Label("MP_LEG")]
    [Label("Mechanic Leg", 1)]
    MechanicLeg = 1102,

    /// <summary>Mechanic frame.</summary>
    [Label("MP_FRAME")]
    [Label("Mechanic Frame", 1)]
    MechanicFrame = 1103,

    /// <summary>Mechanic transistor.</summary>
    [Label("MP_TRANSISTER")]
    [Label("Mechanic Transistor", 1)]
    MechanicTransistor = 1104,
}
