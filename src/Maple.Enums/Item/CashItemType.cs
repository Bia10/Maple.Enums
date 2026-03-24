using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash item type classification.
/// Categorizes cash shop items by their function/usage.
/// </summary>
public enum CashItemType : byte
{
    /// <summary>No type.</summary>
    [Label("CIT_NONE")]
    None = 0,

    /// <summary>Hair coupon.</summary>
    [Label("CIT_HAIR")]
    Hair = 1,

    /// <summary>Face coupon.</summary>
    [Label("CIT_FACE")]
    Face = 2,

    /// <summary>Skin coupon.</summary>
    [Label("CIT_SKIN")]
    Skin = 3,

    /// <summary>Personal shop permit.</summary>
    [Label("CIT_SHOP")]
    Shop = 4,

    /// <summary>Set pet lifespan.</summary>
    [Label("CIT_SETPETLIFE")]
    [Label("Set Pet Life", 1)]
    SetPetLife = 5,

    /// <summary>Facial expression.</summary>
    [Label("CIT_EMOTION")]
    Emotion = 6,

    /// <summary>Death EXP protection.</summary>
    [Label("CIT_PROTECTONDIE")]
    [Label("Protect On Die", 1)]
    ProtectOnDie = 7,

    /// <summary>Pet item.</summary>
    [Label("CIT_PET")]
    Pet = 8,

    /// <summary>Visual effect.</summary>
    [Label("CIT_EFFECT")]
    Effect = 9,

    /// <summary>Throwing star/bullet.</summary>
    [Label("CIT_BULLET")]
    Bullet = 10,

    /// <summary>Shop store clerk.</summary>
    [Label("CIT_SHOPEMPLOYEE")]
    [Label("Shop Employee", 1)]
    ShopEmployee = 11,

    /// <summary>Channel megaphone.</summary>
    [Label("CIT_SPEAKERCHANNEL")]
    [Label("Speaker Channel", 1)]
    SpeakerChannel = 12,

    /// <summary>World megaphone.</summary>
    [Label("CIT_SPEAKERWORLD")]
    [Label("Speaker World", 1)]
    SpeakerWorld = 13,

    /// <summary>Item megaphone.</summary>
    [Label("CIT_ITEMSPEAKER")]
    [Label("Item Speaker", 1)]
    ItemSpeaker = 14,

    /// <summary>Bridge megaphone.</summary>
    [Label("CIT_SPEAKERBRIDGE")]
    [Label("Speaker Bridge", 1)]
    SpeakerBridge = 15,

    /// <summary>Weather effect.</summary>
    [Label("CIT_WEATHER")]
    Weather = 16,

    /// <summary>Rename pet.</summary>
    [Label("CIT_SETPETNAME")]
    [Label("Set Pet Name", 1)]
    SetPetName = 17,

    /// <summary>Message box.</summary>
    [Label("CIT_MESSAGEBOX")]
    [Label("Message Box", 1)]
    MessageBox = 18,

    /// <summary>Meso magnet.</summary>
    [Label("CIT_MONEYPOCKET")]
    [Label("Money Pocket", 1)]
    MoneyPocket = 19,

    /// <summary>Jukebox item.</summary>
    [Label("CIT_JUKEBOX")]
    Jukebox = 20,

    /// <summary>Send note/memo.</summary>
    [Label("CIT_SENDMEMO")]
    [Label("Send Memo", 1)]
    SendMemo = 21,

    /// <summary>Map teleport item.</summary>
    [Label("CIT_MAPTRANSFER")]
    [Label("Map Transfer", 1)]
    MapTransfer = 22,

    /// <summary>AP/stat reset.</summary>
    [Label("CIT_STATCHANGE")]
    [Label("Stat Change", 1)]
    StatChange = 23,

    /// <summary>SP reset.</summary>
    [Label("CIT_SKILLCHANGE")]
    [Label("Skill Change", 1)]
    SkillChange = 24,

    /// <summary>Name change item.</summary>
    [Label("CIT_NAMING")]
    Naming = 25,

    /// <summary>Item protection scroll.</summary>
    [Label("CIT_PROTECTING")]
    Protecting = 26,

    /// <summary>Pet incubator.</summary>
    [Label("CIT_INCUBATOR")]
    Incubator = 27,

    /// <summary>Pet skill item.</summary>
    [Label("CIT_PETSKILL")]
    [Label("Pet Skill", 1)]
    PetSkill = 28,

    /// <summary>Owl of Minerva.</summary>
    [Label("CIT_SHOPSCANNER")]
    [Label("Shop Scanner", 1)]
    ShopScanner = 29,

    /// <summary>Pet food.</summary>
    [Label("CIT_PETFOOD")]
    [Label("Pet Food", 1)]
    PetFood = 30,

    /// <summary>Quick delivery service.</summary>
    [Label("CIT_QUICKDELIVERY")]
    [Label("Quick Delivery", 1)]
    QuickDelivery = 31,

    /// <summary>Advertisement board.</summary>
    [Label("CIT_ADBOARD")]
    [Label("Ad Board", 1)]
    AdBoard = 32,

    /// <summary>Consumable effect item.</summary>
    [Label("CIT_CONSUMEEFFECTITEM")]
    [Label("Consume Effect Item", 1)]
    ConsumeEffectItem = 33,

    /// <summary>Area buff item.</summary>
    [Label("CIT_CONSUMEAREABUFFITEM")]
    [Label("Consume Area Buff Item", 1)]
    ConsumeAreaBuffItem = 34,

    /// <summary>Eye color lens.</summary>
    [Label("CIT_COLORLENS")]
    [Label("Color Lens", 1)]
    ColorLens = 35,

    /// <summary>Wedding ticket.</summary>
    [Label("CIT_WEDDINGTICKET")]
    [Label("Wedding Ticket", 1)]
    WeddingTicket = 36,

    /// <summary>Wedding invitation.</summary>
    [Label("CIT_INVITATIONTICKET")]
    [Label("Invitation Ticket", 1)]
    InvitationTicket = 37,

    /// <summary>NPC teleport.</summary>
    [Label("CIT_SELECTNPC")]
    [Label("Select Npc", 1)]
    SelectNpc = 38,

    /// <summary>Remote shop access.</summary>
    [Label("CIT_REMOTESHOP")]
    [Label("Remote Shop", 1)]
    RemoteShop = 39,

    /// <summary>Gachapon coupon.</summary>
    [Label("CIT_GACHAPONCOUPON")]
    [Label("Gachapon Coupon", 1)]
    GachaponCoupon = 40,

    /// <summary>Transformation item.</summary>
    [Label("CIT_MORPH")]
    Morph = 41,

    /// <summary>Pet evolution item.</summary>
    [Label("CIT_PETEVOL")]
    [Label("Pet Evol", 1)]
    PetEvol = 42,

    /// <summary>Avatar megaphone.</summary>
    [Label("CIT_AVATARMEGAPHONE")]
    [Label("Avatar Megaphone", 1)]
    AvatarMegaphone = 43,

    /// <summary>Heart megaphone.</summary>
    [Label("CIT_HEARTSPEAKER")]
    [Label("Heart Speaker", 1)]
    HeartSpeaker = 44,

    /// <summary>Skull megaphone.</summary>
    [Label("CIT_SKULLSPEAKER")]
    [Label("Skull Speaker", 1)]
    SkullSpeaker = 45,

    /// <summary>Removable cash item.</summary>
    [Label("CIT_REMOVABLE")]
    Removable = 46,

    /// <summary>Maple TV message.</summary>
    [Label("CIT_MAPLETV")]
    [Label("Maple Tv", 1)]
    MapleTv = 47,

    /// <summary>Maple TV solo message.</summary>
    [Label("CIT_MAPLESOLETV")]
    [Label("Maple Sole Tv", 1)]
    MapleSoleTv = 48,

    /// <summary>Maple TV love message.</summary>
    [Label("CIT_MAPLELOVETV")]
    [Label("Maple Love Tv", 1)]
    MapleLoveTv = 49,

    /// <summary>Mega TV message.</summary>
    [Label("CIT_MEGATV")]
    [Label("Mega Tv", 1)]
    MegaTv = 50,

    /// <summary>Mega TV solo message.</summary>
    [Label("CIT_MEGASOLETV")]
    [Label("Mega Sole Tv", 1)]
    MegaSoleTv = 51,

    /// <summary>Mega TV love message.</summary>
    [Label("CIT_MEGALOVETV")]
    [Label("Mega Love Tv", 1)]
    MegaLoveTv = 52,

    /// <summary>Character name change.</summary>
    [Label("CIT_CHANGECHARACTERNAME")]
    [Label("Change Character Name", 1)]
    ChangeCharacterName = 53,

    /// <summary>World transfer coupon.</summary>
    [Label("CIT_TRANSFERWORLDCOUPON")]
    [Label("Transfer World Coupon", 1)]
    TransferWorldCoupon = 54,

    /// <summary>Hair shop membership.</summary>
    [Label("CIT_HAIRSHOPMEMBERSHIPCOUPON")]
    [Label("Hair Shop Membership Coupon", 1)]
    HairShopMembershipCoupon = 55,

    /// <summary>Face shop membership.</summary>
    [Label("CIT_FACESHOPMEMBERSHIPCOUPON")]
    [Label("Face Shop Membership Coupon", 1)]
    FaceShopMembershipCoupon = 56,

    /// <summary>Skin shop membership.</summary>
    [Label("CIT_SKINSHOPMEMBERSHIPCOUPON")]
    [Label("Skin Shop Membership Coupon", 1)]
    SkinShopMembershipCoupon = 57,

    /// <summary>Pet snack.</summary>
    [Label("CIT_PETSNACK")]
    [Label("Pet Snack", 1)]
    PetSnack = 58,

    /// <summary>Gachapon master key.</summary>
    [Label("CIT_GACHAPONBOX_MASTERKEY")]
    [Label("Gachapon Box Master Key", 1)]
    GachaponBoxMasterKey = 59,

    /// <summary>Remote gachapon access.</summary>
    [Label("CIT_GACHAPONREMOTE")]
    [Label("Gachapon Remote", 1)]
    GachaponRemote = 60,

    /// <summary>Art world megaphone.</summary>
    [Label("CIT_ARTSPEAKERWORLD")]
    [Label("Art Speaker World", 1)]
    ArtSpeakerWorld = 61,

    /// <summary>Extend expiry date.</summary>
    [Label("CIT_EXTENDEXPIREDATE")]
    [Label("Extend Expire Date", 1)]
    ExtendExpireDate = 62,

    /// <summary>Tombstone upgrade.</summary>
    [Label("CIT_UPGRADETOMB")]
    [Label("Upgrade Tomb", 1)]
    UpgradeTomb = 63,

    /// <summary>Karma scissors.</summary>
    [Label("CIT_KARMASCISSORS")]
    [Label("Karma Scissors", 1)]
    KarmaScissors = 64,

    /// <summary>Expire protection scroll.</summary>
    [Label("CIT_EXPIREDPROTECTING")]
    [Label("Expired Protecting", 1)]
    ExpiredProtecting = 65,

    /// <summary>Character sale coupon.</summary>
    [Label("CIT_CHARACTERSALE")]
    [Label("Character Sale", 1)]
    CharacterSale = 66,

    /// <summary>Item upgrade scroll.</summary>
    [Label("CIT_ITEMUPGRADE")]
    [Label("Item Upgrade", 1)]
    ItemUpgrade = 67,

    /// <summary>Cash item gachapon.</summary>
    [Label("CIT_CASHITEMGACHAPON")]
    [Label("Cash Item Gachapon", 1)]
    CashItemGachapon = 68,

    /// <summary>Open cash gachapon.</summary>
    [Label("CIT_CASHGACHAPONOPEN")]
    [Label("Cash Gachapon Open", 1)]
    CashGachaponOpen = 69,

    /// <summary>Maple Point conversion.</summary>
    [Label("CIT_CHANGEMAPLEPOINT")]
    [Label("Change Maple Point", 1)]
    ChangeMaplePoint = 70,

    /// <summary>Vega's spell scroll.</summary>
    [Label("CIT_VEGA")]
    Vega = 71,

    /// <summary>Reward item.</summary>
    [Label("CIT_REWARD")]
    Reward = 72,

    /// <summary>Mastery book.</summary>
    [Label("CIT_MASTERYBOOK")]
    [Label("Mastery Book", 1)]
    MasteryBook = 73,

    /// <summary>Item untradeable lock.</summary>
    [Label("CIT_ITEM_UNRELEASE")]
    [Label("Item Unrelease", 1)]
    ItemUnrelease = 74,

    /// <summary>Skill reset item.</summary>
    [Label("CIT_SKILLRESET")]
    [Label("Skill Reset", 1)]
    SkillReset = 75,

    /// <summary>Dragon ball item.</summary>
    [Label("CIT_DRAGONBALL")]
    [Label("Dragon Ball", 1)]
    DragonBall = 76,

    /// <summary>Recover upgrade slots.</summary>
    [Label("CIT_RECOVERUPGRADECOUNT")]
    [Label("Recover Upgrade Count", 1)]
    RecoverUpgradeCount = 77,

    /// <summary>Quest delivery item.</summary>
    [Label("CIT_QUESTDELIVERY")]
    [Label("Quest Delivery", 1)]
    QuestDelivery = 78,
}
