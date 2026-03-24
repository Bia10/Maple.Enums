using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Meso / money movement type for server-side money log records.
/// </summary>
public enum MoneyLogAction : int
{
    /// <summary>No action / unset.</summary>
    [Label("None")]
    None = -1,

    /// <summary>Meso pickup from field.</summary>
    [Label("FieldIncome")]
    FieldIncome = 0,

    /// <summary>Meso drop to field.</summary>
    [Label("FieldOutgo")]
    FieldOutgo = 1,

    /// <summary>Money pocket income.</summary>
    [Label("MoneyPocketIncome")]
    MoneyPocketIncome = 2,

    /// <summary>Coupon reward income.</summary>
    [Label("CouponIncome")]
    CouponIncome = 3,

    /// <summary>Item claim fee.</summary>
    [Label("ClaimFee")]
    ClaimFee = 4,

    /// <summary>Marriage ceremony fee.</summary>
    [Label("MarriageFee")]
    MarriageFee = 5,

    /// <summary>Friend list operation fee.</summary>
    [Label("FriendFee")]
    FriendFee = 6,

    /// <summary>Guild operation fee.</summary>
    [Label("GuildFee")]
    GuildFee = 7,

    /// <summary>Mini game wager.</summary>
    [Label("MiniGame")]
    MiniGame = 8,

    /// <summary>Skill usage fee.</summary>
    [Label("SkillFee")]
    SkillFee = 9,

    /// <summary>Item maker crafting fee.</summary>
    [Label("MakerFee")]
    MakerFee = 10,

    /// <summary>NPC shop transaction.</summary>
    [Label("NPCShop")]
    NpcShop = 11,

    /// <summary>Admin shop transaction.</summary>
    [Label("AdminShop")]
    AdminShop = 12,

    /// <summary>Player shop transaction.</summary>
    [Label("UserShop")]
    UserShop = 13,

    /// <summary>Player-to-player trade.</summary>
    [Label("UserTrade")]
    UserTrade = 14,

    /// <summary>Storage (trunk) deposit/withdraw.</summary>
    [Label("Trunk")]
    Trunk = 15,

    /// <summary>Quest reward.</summary>
    [Label("Quest")]
    Quest = 16,

    /// <summary>Parcel delivery fee.</summary>
    [Label("Parcel")]
    Parcel = 17,

    /// <summary>NPC script transaction.</summary>
    [Label("Script")]
    Script = 18,

    /// <summary>Lie detector test fee.</summary>
    [Label("LieDetector")]
    LieDetector = 19,

    /// <summary>Family system fee.</summary>
    [Label("FamilyFee")]
    FamilyFee = 20,

    /// <summary>Party search advertisement fee.</summary>
    [Label("PartyAdverFee")]
    PartyAdverFee = 21,

    /// <summary>Equipment durability repair fee.</summary>
    [Label("RepairDurability")]
    RepairDurability = 22,
}
