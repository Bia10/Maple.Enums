using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Map field type (fieldType WZ node).
/// </summary>
public enum MapFieldType : ushort
{
    // ── Standard Range (0–35) ─────────────────────────────────────────────
    /// <summary>Standard map.</summary>
    [Label("Normal")]
    Default = 0,

    /// <summary>Snowball event.</summary>
    Snowball = 1,

    /// <summary>Continent boat.</summary>
    [Label("Continent Move (Boat)")]
    ContiMove = 2,

    /// <summary>Tournament map.</summary>
    Tournament = 3,

    /// <summary>Coconut event.</summary>
    Coconut = 4,

    /// <summary>OX quiz map.</summary>
    [Label("OX Quiz")]
    OxQuiz = 5,

    /// <summary>Time-limited map.</summary>
    [Label("Personal Time Limit")]
    PersonalTimeLimit = 6,

    /// <summary>Waiting room.</summary>
    [Label("Waiting Room")]
    WaitingRoom = 7,

    /// <summary>Guild boss map.</summary>
    [Label("Guild Boss")]
    GuildBoss = 8,

    /// <summary>Limited view map.</summary>
    [Label("Limited View")]
    LimitedView = 9,

    /// <summary>Monster Carnival map.</summary>
    [Label("Monster Carnival")]
    MonsterCarnival = 10,

    /// <summary>Monster Carnival revive.</summary>
    [Label("Monster Carnival (Revive)")]
    MonsterCarnivalRevive = 11,

    /// <summary>Zakum boss map.</summary>
    Zakum = 12,

    /// <summary>Ariant arena map.</summary>
    [Label("Ariant Arena")]
    AriantArena = 13,

    /// <summary>Mu Lung Dojo map.</summary>
    [Label("Mu Lung Dojo")]
    Dojang = 14,

    /// <summary>Monster Carnival season 2.</summary>
    [Label("Monster Carnival S2")]
    MonsterCarnivalS2 = 15,

    /// <summary>Monster Carnival lobby.</summary>
    [Label("Monster Carnival Lobby")]
    MonsterCarnivalWaitingRoom = 16,

    /// <summary>Cookie House map.</summary>
    [Label("Cookie House")]
    CookieHouse = 17,

    /// <summary>Balrog boss map.</summary>
    Balrog = 18,

    /// <summary>Battlefield map.</summary>
    Battlefield = 19,

    /// <summary>Space Gaga map.</summary>
    [Label("Space Gaga")]
    SpaceGaga = 20,

    /// <summary>Witch Tower map.</summary>
    [Label("Witch Tower")]
    Witchtower = 21,

    /// <summary>Aran tutorial map.</summary>
    [Label("Aran Tutorial")]
    AranTutorial = 22,

    /// <summary>Massacre event map.</summary>
    Massacre = 23,

    /// <summary>Massacre result map.</summary>
    [Label("Massacre Result")]
    MassacreResult = 24,

    /// <summary>Party raid map.</summary>
    [Label("Party Raid")]
    PartyRaid = 25,

    /// <summary>Party raid boss.</summary>
    [Label("Party Raid (Boss)")]
    PartyRaidBoss = 26,

    /// <summary>Party raid result.</summary>
    [Label("Party Raid Result")]
    PartyRaidResult = 27,

    /// <summary>Disables dragon mount.</summary>
    [Label("No Dragon")]
    NoDragon = 28,

    /// <summary>Dynamic foothold map.</summary>
    [Label("Dynamic Foothold")]
    DynamicFoothold = 29,

    /// <summary>Escort mission map.</summary>
    Escort = 30,

    /// <summary>Escort result map.</summary>
    [Label("Escort Result")]
    EscortResult = 31,

    /// <summary>Ad balloon hunting.</summary>
    [Label("Hunting Adballoon")]
    HuntingAdballoon = 32,

    /// <summary>Chaos Zakum boss.</summary>
    [Label("Chaos Zakum")]
    ChaosZakum = 33,

    /// <summary>Kill count map.</summary>
    [Label("Kill Count")]
    KillCount = 34,

    /// <summary>Cube event map.</summary>
    Cube = 35,

    // ── Wedding Range (60–61) ─────────────────────────────────────────────
    /// <summary>Wedding ceremony map.</summary>
    Wedding = 60,

    /// <summary>Wedding photo map.</summary>
    [Label("Wedding Photo")]
    WeddingPhoto = 61,

    // ── Factory Special Case (82) ─────────────────────────────────────────
    // V95 tutorial WZ maps write fieldType = 82.  The PDB enum constant
    // FIELDTYPE_TUTORIAL = 1002 is NOT the WZ value — 1002 > 1001 falls to
    // LABEL_78 in the CField factory and produces a plain CField (same as
    // Default).  Catalog §14 factory special case, game_pseudocode.c:276050.
    /// <summary>Tutorial map.</summary>
    Tutorial = 82,

    // ── 1000-Series (Special Events) ─────────────────────────────────────
    /// <summary>Protect snowman event.</summary>
    [Label("Protect Snowman")]
    ProtectSnowman = 1000,

    /// <summary>Showa bath map.</summary>
    [Label("Showa Bath")]
    ShowaBath = 1001,

    /// <summary>Pachinko mini-game.</summary>
    Pachinko = 1003,

    /// <summary>Boat race event.</summary>
    [Label("Boat Race")]
    BoatRace = 1004,

    /// <summary>Boat race variant.</summary>
    [Label("Boat Race 2")]
    BoatRace2 = 1005,

    /// <summary>Language school map.</summary>
    [Label("Language School")]
    LanguageSchool = 1006,

    /// <summary>Fishing map.</summary>
    Fishing = 1007,

    /// <summary>Fishing King event.</summary>
    [Label("Fishing King")]
    FishingKing = 1008,

    /// <summary>CN wedding map.</summary>
    [Label("CN Wedding")]
    CnWedding = 1009,

    /// <summary>CN PvP single mob.</summary>
    [Label("CN PvP (Single Mob)")]
    CnPvpShootingOneMob = 1010,

    /// <summary>CN PvP many mobs.</summary>
    [Label("CN PvP (Many Mobs)")]
    CnPvpShootingManyMob = 1011,

    /// <summary>CN PvP jump map.</summary>
    [Label("CN PvP Jump")]
    CnPvpJump = 1012,

    /// <summary>Horntail boss map.</summary>
    /// <remarks>V95 PDB spells "Hontail"; see BossMobId and typos.md.</remarks>
    [Label("Horntail")]
    Hontail = 1013,

    /// <summary>NLC party quest.</summary>
    [Label("NLC Party Quest")]
    NlcPq = 1014,

    /// <summary>Tokyo boss map.</summary>
    [Label("Tokyo Boss")]
    TokyoBoss = 1015,

    /// <summary>Tokyo boss party.</summary>
    [Label("Tokyo Boss (Party)")]
    TokyoBossParty = 1016,

    /// <summary>Entrusted fishing map.</summary>
    [Label("Entrusted Fishing")]
    EntrustedFishing = 1017,

    /// <summary>Punch Punch event.</summary>
    [Label("Punch Punch")]
    PunchPunch = 1018,
}
