using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Map field option bitmask (fieldLimit WZ node).
/// Setting a bit DISABLES the corresponding action.
/// </summary>
[Flags]
public enum MapFieldLimit : uint
{
    /// <summary>No restrictions.</summary>
    None = 0,

    /// <summary>Disables movement skills.</summary>
    [Label("No Movement Skills", 1)]
    MoveLimit = 0x000001,

    /// <summary>Disables all skills.</summary>
    [Label("No Skills", 1)]
    SkillLimit = 0x000002,

    /// <summary>Disables summons.</summary>
    [Label("No Summons", 1)]
    SummonLimit = 0x000004,

    /// <summary>Disables Mystic Door.</summary>
    [Label("No Mystic Door", 1)]
    MysticDoorLimit = 0x000008,

    /// <summary>Disables map change.</summary>
    [Label("No Map Change", 1)]
    MigrateLimit = 0x000010,

    /// <summary>Disables portal scrolls.</summary>
    [Label("No Portal Scrolls", 1)]
    PortalScrollLimit = 0x000020,

    /// <summary>Disables teleport rocks.</summary>
    [Label("No Teleport Rock", 1)]
    TeleportItemLimit = 0x000040,

    /// <summary>Disables mini-games.</summary>
    [Label("No Mini-Games", 1)]
    MiniGameLimit = 0x000080,

    /// <summary>Disables specific scrolls.</summary>
    [Label("No Specific Portal Scrolls", 1)]
    SpecificPortalScrollLimit = 0x000100,

    /// <summary>Disables mounts.</summary>
    [Label("No Taming Mobs / Mounts", 1)]
    TamingMobLimit = 0x000200,

    /// <summary>Disables stat-change items.</summary>
    [Label("No Stat-Change Items", 1)]
    StatChangeItemConsumeLimit = 0x000400,

    /// <summary>Disables party boss change.</summary>
    [Label("No Party Boss Change", 1)]
    PartyBossChangeLimit = 0x000800,

    /// <summary>Unlimited mob spawns.</summary>
    [Label("Unlimited Mob Spawns", 1)]
    NoMobCapacityLimit = 0x001000,

    /// <summary>Disables wedding invites.</summary>
    [Label("No Wedding Invitation", 1)]
    WeddingInvitationLimit = 0x002000,

    /// <summary>Disables cash weather.</summary>
    [Label("No Cash Weather", 1)]
    CashWeatherConsumeLimit = 0x004000,

    /// <summary>Disables pets.</summary>
    [Label("No Pets", 1)]
    NoPet = 0x008000,

    /// <summary>Enables anti-macro.</summary>
    [Label("Anti-Macro", 1)]
    AntiMacroLimit = 0x010000,

    /// <summary>Disables fall-down.</summary>
    [Label("No Fall Down", 1)]
    FallDownLimit = 0x020000,

    /// <summary>Disables NPC summon.</summary>
    [Label("No Summon NPC", 1)]
    SummonNpcLimit = 0x040000,

    /// <summary>No EXP loss on death.</summary>
    [Label("No EXP Loss", 1)]
    NoExpDecrease = 0x080000,

    /// <summary>No fall damage.</summary>
    [Label("No Falling Damage", 1)]
    NoDamageOnFalling = 0x100000,

    /// <summary>Disables parcel open.</summary>
    [Label("No Parcel Open", 1)]
    ParcelOpenLimit = 0x200000,

    /// <summary>Disables item drops.</summary>
    [Label("No Item Drop", 1)]
    DropLimit = 0x400000,

    /// <summary>Disables rocket booster.</summary>
    [Label("No Rocket Booster", 1)]
    RocketBoosterLimit = 0x800000,
}
