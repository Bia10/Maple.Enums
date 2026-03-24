using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character data flags for DB/migration operations.
/// Bitmask indicating which character data sections to load/save.
/// </summary>
[Flags]
public enum CharacterDataFlag : uint
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Base character info.</summary>
    [Label("DBCHAR_CHARACTER")]
    Character = 0x1,

    /// <summary>Meso balance.</summary>
    [Label("DBCHAR_MONEY")]
    Money = 0x2,

    /// <summary>Equip inventory.</summary>
    [Label("DBCHAR_ITEMSLOTEQUIP")]
    [Label("Item Slot Equip", 1)]
    ItemSlotEquip = 0x4,

    /// <summary>Use/consume inventory.</summary>
    [Label("DBCHAR_ITEMSLOTCONSUME")]
    [Label("Item Slot Consume", 1)]
    ItemSlotConsume = 0x8,

    /// <summary>Setup/install inventory.</summary>
    [Label("DBCHAR_ITEMSLOTINSTALL")]
    [Label("Item Slot Install", 1)]
    ItemSlotInstall = 0x10,

    /// <summary>Etc inventory.</summary>
    [Label("DBCHAR_ITEMSLOTETC")]
    [Label("Item Slot Etc", 1)]
    ItemSlotEtc = 0x20,

    /// <summary>Cash inventory.</summary>
    [Label("DBCHAR_ITEMSLOTCASH")]
    [Label("Item Slot Cash", 1)]
    ItemSlotCash = 0x40,

    /// <summary>Inventory slot counts.</summary>
    [Label("DBCHAR_INVENTORYSIZE")]
    [Label("Inventory Size", 1)]
    InventorySize = 0x80,

    /// <summary>Learned skills.</summary>
    [Label("DBCHAR_SKILLRECORD")]
    [Label("Skill Record", 1)]
    SkillRecord = 0x100,

    /// <summary>Active quest data.</summary>
    [Label("DBCHAR_QUESTRECORD")]
    [Label("Quest Record", 1)]
    QuestRecord = 0x200,

    /// <summary>Mini-game win/loss records.</summary>
    [Label("DBCHAR_MINIGAMERECORD")]
    [Label("Mini Game Record", 1)]
    MiniGameRecord = 0x400,

    /// <summary>Couple ring records.</summary>
    [Label("DBCHAR_COUPLERECORD")]
    [Label("Couple Record", 1)]
    CoupleRecord = 0x800,

    /// <summary>Saved teleport locations.</summary>
    [Label("DBCHAR_MAPTRANSFER")]
    [Label("Map Transfer", 1)]
    MapTransfer = 0x1000,

    /// <summary>Avatar appearance data.</summary>
    [Label("DBCHAR_AVATAR")]
    Avatar = 0x2000,

    /// <summary>Completed quest list.</summary>
    [Label("DBCHAR_QUESTCOMPLETE")]
    [Label("Quest Complete", 1)]
    QuestComplete = 0x4000,

    /// <summary>Skill cooldown timers.</summary>
    [Label("DBCHAR_SKILLCOOLTIME")]
    [Label("Skill Cooltime", 1)]
    SkillCooltime = 0x8000,

    /// <summary>Monster book cards.</summary>
    [Label("DBCHAR_MONSTERBOOKCARD")]
    [Label("Monster Book Card", 1)]
    MonsterBookCard = 0x10000,

    /// <summary>Monster book cover.</summary>
    [Label("DBCHAR_MONSTERBOOKCOVER")]
    [Label("Monster Book Cover", 1)]
    MonsterBookCover = 0x20000,

    /// <summary>New Year card data.</summary>
    [Label("DBCHAR_NEWYEARCARD")]
    [Label("New Year Card", 1)]
    NewYearCard = 0x40000,

    /// <summary>Extended quest data.</summary>
    [Label("DBCHAR_QUESTRECORDEX")]
    [Label("Quest Record Ex", 1)]
    QuestRecordEx = 0x80000,

    /// <summary>Extended equip slots.</summary>
    [Label("DBCHAR_EQUIPEXT")]
    [Label("Equip Ext", 1)]
    EquipExt = 0x100000,

    /// <summary>Wild Hunter jaguar info.</summary>
    [Label("DBCHAR_WILDHUNTERINFO")]
    [Label("Wild Hunter Info", 1)]
    WildHunterInfo = 0x200000,

    /// <summary>Legacy completed quests.</summary>
    [Label("DBCHAR_QUESTCOMPLETE_OLD")]
    [Label("Quest Complete Old", 1)]
    QuestCompleteOld = 0x400000,

    /// <summary>Visitor log entries.</summary>
    [Label("DBCHAR_VISITORLOG")]
    [Label("Visitor Log", 1)]
    VisitorLog = 0x800000,

    /// <summary>All data sections.</summary>
    [Label("DBCHAR_ALL")]
    All = 0xFFFFFFFF,

    /// <summary>All inventory tabs combined.</summary>
    [Label("DBCHAR_ITEMSLOT")]
    [Label("Item Slot", 1)]
    ItemSlot = ItemSlotEquip | ItemSlotConsume | ItemSlotInstall | ItemSlotEtc | ItemSlotCash,
}
