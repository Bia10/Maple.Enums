using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Hacking auto-block reason code sent by the server's anti-cheat system.
/// </summary>
public enum HackingAutoBlockReason : byte
{
    /// <summary>Disconnected by anti-cheat.</summary>
    [Label("HackingAutoBlockReason_UserDC")]
    [Label("User Dc", 1)]
    UserDc = 10,

    /// <summary>Invalid data detected.</summary>
    [Label("HackingAutoBlockReason_Data")]
    Data = 12,

    /// <summary>Suspicious game start.</summary>
    [Label("HackingAutoBlockReason_Start")]
    Start = 20,

    /// <summary>Abnormal hit pattern.</summary>
    [Label("HackingAutoBlockReason_Hit")]
    Hit = 21,

    /// <summary>Abnormal movement.</summary>
    [Label("HackingAutoBlockReason_Move")]
    Move = 22,

    /// <summary>Invalid packet detected.</summary>
    [Label("HackingAutoBlockReason_Packet")]
    Packet = 23,

    /// <summary>Invalid position.</summary>
    [Label("HackingAutoBlockReason_Position")]
    Position = 24,

    /// <summary>RNG manipulation.</summary>
    [Label("HackingAutoBlockReason_Unrandomizer")]
    Unrandomizer = 25,

    /// <summary>Item vacuum hack.</summary>
    [Label("HackingAutoBlockReason_ItemVac")]
    [Label("Item Vac", 1)]
    ItemVac = 26,

    /// <summary>Packet-based attack.</summary>
    [Label("HackingAutoBlockReason_PacketAttack")]
    [Label("Packet Attack", 1)]
    PacketAttack = 27,

    /// <summary>Miss manipulation.</summary>
    [Label("HackingAutoBlockReason_MissHack")]
    [Label("Miss Hack", 1)]
    MissHack = 28,

    /// <summary>Mob speed anomaly.</summary>
    [Label("HackingAutoBlockReason_MobVelocityCheck")]
    [Label("Mob Velocity Check", 1)]
    MobVelocityCheck = 29,

    /// <summary>Invalid damage value.</summary>
    [Label("HackingAutoBlockReason_InvalidDamage")]
    [Label("Invalid Damage", 1)]
    InvalidDamage = 30,

    /// <summary>Unauthorized warp.</summary>
    [Label("HackingAutoBlockReason_Warp")]
    Warp = 31,

    /// <summary>Zero-damage exploit.</summary>
    [Label("HackingAutoBlockReason_ZeroHack")]
    [Label("Zero Hack", 1)]
    ZeroHack = 32,

    /// <summary>Invincibility hack.</summary>
    [Label("HackingAutoBlockReason_NoDamage")]
    [Label("No Damage", 1)]
    NoDamage = 33,

    /// <summary>Summon speed anomaly.</summary>
    [Label("HackingAutoBlockReason_SummonedSpeed")]
    [Label("Summoned Speed", 1)]
    SummonedSpeed = 34,

    /// <summary>Ignoring mob movement.</summary>
    [Label("HackingAutoBlockReason_IntentionalMobMoveIgnore")]
    [Label("Intentional Mob Move Ignore", 1)]
    IntentionalMobMoveIgnore = 35,

    /// <summary>Invalid mob pathing.</summary>
    [Label("HackingAutoBlockReason_InvalidMobMovePattern")]
    [Label("Invalid Mob Move Pattern", 1)]
    InvalidMobMovePattern = 36,

    /// <summary>Unusual mob movement.</summary>
    [Label("HackingAutoBlockReason_StrangeMobMove")]
    [Label("Strange Mob Move", 1)]
    StrangeMobMove = 37,

    /// <summary>Jump height exploit.</summary>
    [Label("HackingAutoBlockReason_JumpHack")]
    [Label("Jump Hack", 1)]
    JumpHack = 38,

    /// <summary>Impact cheat detected.</summary>
    [Label("HackingAutoBlockReason_ImpactCheat")]
    [Label("Impact Cheat", 1)]
    ImpactCheat = 39,

    /// <summary>Modified WZ data.</summary>
    [Label("HackingAutoBlockReason_WzEdit")]
    [Label("Wz Edit", 1)]
    WzEdit = 40,
}
