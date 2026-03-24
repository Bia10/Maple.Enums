using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// GM/admin slash-command operation types.
/// </summary>
public enum AdminCommandType : byte
{
    /// <summary>Spawn item or NPC.</summary>
    [Label("AP_CREATE")]
    Create = 0,

    /// <summary>Remove spawned object.</summary>
    [Label("AP_REMOVE")]
    Remove = 1,

    /// <summary>Grant experience points.</summary>
    [Label("AP_INCEXP")]
    [Label("Inc Exp", 1)]
    IncExp = 2,

    /// <summary>Force player logout.</summary>
    [Label("AP_LOGOUT")]
    Logout = 3,

    /// <summary>Block a player.</summary>
    [Label("AP_BLOCK")]
    Block = 4,

    /// <summary>Unblock a player.</summary>
    [Label("AP_UNBLOCK")]
    Unblock = 5,

    /// <summary>Remove from rankings.</summary>
    [Label("AP_NORANK")]
    [Label("No Rank", 1)]
    NoRank = 6,

    /// <summary>Take screenshot.</summary>
    [Label("AP_SCREENSHOT")]
    Screenshot = 7,

    /// <summary>Disconnect a player.</summary>
    [Label("AP_DISCONNECT")]
    Disconnect = 8,

    /// <summary>Block via center server.</summary>
    [Label("AP_CENTER_BLOCK")]
    [Label("Center Block", 1)]
    CenterBlock = 9,

    /// <summary>Warp to portal.</summary>
    [Label("AP_PORTAL")]
    Portal = 10,

    /// <summary>NPC variable operations.</summary>
    [Label("AP_NPCVAR")]
    [Label("Npc Var", 1)]
    NpcVar = 11,

    /// <summary>Set NPC variable value.</summary>
    [Label("NPCVAR_SET")]
    [Label("Npc Var Set", 1)]
    NpcVarSet = 12,

    /// <summary>Get NPC variable value.</summary>
    [Label("NPCVAR_GET")]
    [Label("Npc Var Get", 1)]
    NpcVarGet = 13,

    /// <summary>Banish all players from map.</summary>
    [Label("AP_BANISH_ALL")]
    [Label("Banish All", 1)]
    BanishAll = 14,

    /// <summary>Set or clear map timer.</summary>
    [Label("AP_TIMER")]
    Timer = 15,

    /// <summary>Show description text.</summary>
    [Label("AP_DESC")]
    Desc = 16,

    /// <summary>Start GM event.</summary>
    [Label("AP_EVENT_START")]
    [Label("Event Start", 1)]
    EventStart = 17,

    /// <summary>Toggle GM hide.</summary>
    [Label("AP_HIDE")]
    Hide = 18,

    /// <summary>List online users.</summary>
    [Label("AP_USERLIST")]
    [Label("User List", 1)]
    UserList = 19,

    /// <summary>Warp player to location.</summary>
    [Label("AP_SENDUSER")]
    [Label("Send User", 1)]
    SendUser = 20,

    /// <summary>Manage entrusted shop.</summary>
    [Label("AP_ENTRUSTEDSHOP")]
    [Label("Entrusted Shop", 1)]
    EntrustedShop = 21,

    /// <summary>Trigger admin event.</summary>
    [Label("AP_ADMINEVENT")]
    [Label("Admin Event", 1)]
    AdminEvent = 22,

    /// <summary>Kill all mobs on map.</summary>
    [Label("AP_KILL_MOB")]
    [Label("Kill Mob", 1)]
    KillMob = 23,

    /// <summary>Set quest state.</summary>
    [Label("AP_QUEST_SET")]
    [Label("Quest Set", 1)]
    QuestSet = 24,

    /// <summary>Reset quest progress.</summary>
    [Label("AP_QUEST_RESET")]
    [Label("Quest Reset", 1)]
    QuestReset = 25,

    /// <summary>Reload hack-check counts.</summary>
    [Label("AP_HACKCHECKCOUNTRELOAD")]
    [Label("Hack Check Count Reload", 1)]
    HackCheckCountReload = 26,

    /// <summary>Query quest info.</summary>
    [Label("AP_QUEST")]
    Quest = 27,

    /// <summary>Summon a mob.</summary>
    [Label("AP_SUMMON")]
    Summon = 28,

    /// <summary>Display mob HP.</summary>
    [Label("AP_MOB_HP")]
    [Label("Mob Hp", 1)]
    MobHp = 29,

    /// <summary>Set player level.</summary>
    [Label("AP_LEVEL_SET")]
    [Label("Level Set", 1)]
    LevelSet = 30,

    /// <summary>Set player job.</summary>
    [Label("AP_JOB_SET")]
    [Label("Job Set", 1)]
    JobSet = 31,

    /// <summary>Toggle cooldown bypass.</summary>
    [Label("AP_NOCOOLTIME")]
    [Label("No Cooltime", 1)]
    NoCooltime = 32,

    /// <summary>Grant ability points.</summary>
    [Label("AP_APGET")]
    [Label("Ap Get", 1)]
    ApGet = 33,

    /// <summary>Grant skill points.</summary>
    [Label("AP_SPGET")]
    [Label("Sp Get", 1)]
    SpGet = 34,

    /// <summary>Set STR stat.</summary>
    [Label("AP_STR")]
    Str = 35,

    /// <summary>Set DEX stat.</summary>
    [Label("AP_DEX")]
    Dex = 36,

    /// <summary>Set INT stat.</summary>
    [Label("AP_INT")]
    Int = 37,

    /// <summary>Set LUK stat.</summary>
    [Label("AP_LUK")]
    Luk = 38,

    /// <summary>Set skill level.</summary>
    [Label("AP_SKILL")]
    Skill = 39,

    /// <summary>Enable mob monitoring.</summary>
    [Label("AP_MMON")]
    MMon = 40,

    /// <summary>Disable mob monitoring.</summary>
    [Label("AP_MMOFF")]
    [Label("MM Off", 1)]
    MMOff = 41,

    /// <summary>Toggle snow effect.</summary>
    [Label("AP_SNOW")]
    Snow = 42,

    /// <summary>Send warning to player.</summary>
    [Label("AP_WARN")]
    Warn = 43,

    /// <summary>Write to server log.</summary>
    [Label("AP_LOG")]
    Log = 44,

    /// <summary>Reset current map.</summary>
    [Label("AP_RESETMAP")]
    [Label("Reset Map", 1)]
    ResetMap = 45,

    /// <summary>Clip free market listings.</summary>
    [Label("AP_FREEMARKETCLIP")]
    [Label("Free Market Clip", 1)]
    FreeMarketClip = 46,

    /// <summary>Destroy player shop.</summary>
    [Label("AP_DESTROYSHOP")]
    [Label("Destroy Shop", 1)]
    DestroyShop = 47,

    /// <summary>Set field object state.</summary>
    [Label("AP_SETOBJECTSTATE")]
    [Label("Set Object State", 1)]
    SetObjectState = 48,

    /// <summary>Display ranking info.</summary>
    [Label("AP_SHOWRANK")]
    [Label("Show Rank", 1)]
    ShowRank = 49,

    /// <summary>Reload forbidden map list.</summary>
    [Label("AP_FORBIDDENMAPRELOAD")]
    [Label("Forbidden Map Reload", 1)]
    ForbiddenMapReload = 50,

    /// <summary>Crisp packet debug.</summary>
    [Label("AP_CRISP")]
    Crisp = 51,

    /// <summary>Reload gachapon box data.</summary>
    [Label("AP_GACHAPONBOXRELOAD")]
    [Label("Gachapon Box Reload", 1)]
    GachaponBoxReload = 52,

    /// <summary>Reload gachapon data.</summary>
    [Label("AP_GACHAPONRELOAD")]
    [Label("Gachapon Reload", 1)]
    GachaponReload = 53,

    /// <summary>Reload weather events.</summary>
    [Label("AP_WEATHEREVENTRELOAD")]
    [Label("Weather Event Reload", 1)]
    WeatherEventReload = 54,

    /// <summary>Reload reward tables.</summary>
    [Label("AP_REWORDRELOAD")]
    [Label("Reward Reload", 1)]
    RewardReload = 55,

    /// <summary>Reload cake/pie event.</summary>
    [Label("AP_CAKEPIERELOAD")]
    [Label("Cake Pie Reload", 1)]
    CakePieReload = 56,

    /// <summary>Reload GM board.</summary>
    [Label("AP_GMBOARDRELOAD")]
    [Label("Gm Board Reload", 1)]
    GmBoardReload = 57,

    /// <summary>Set PQ answer key.</summary>
    [Label("AP_PQANSWER")]
    [Label("Pq Answer", 1)]
    PqAnswer = 58,

    /// <summary>Toggle mob control.</summary>
    [Label("AP_MOBCONTROL")]
    [Label("Mob Control", 1)]
    MobControl = 59,

    /// <summary>View passive skill values.</summary>
    [Label("AP_PASSIVESKILLVALUEVIEW")]
    [Label("Passive Skill Value View", 1)]
    PassiveSkillValueView = 60,

    /// <summary>Set passive skill level.</summary>
    [Label("AP_PASSIVESKILLSET")]
    [Label("Passive Skill Set", 1)]
    PassiveSkillSet = 61,

    /// <summary>Update passive skills.</summary>
    [Label("AP_PASSIVESKILLUPDATE")]
    [Label("Passive Skill Update", 1)]
    PassiveSkillUpdate = 62,

    /// <summary>Query skill cooltime.</summary>
    [Label("AP_GETCOOLTIME")]
    [Label("Get Cooltime", 1)]
    GetCooltime = 63,

    /// <summary>Set map user limit.</summary>
    [Label("AP_FIELDUSERCOUNTLIMIT")]
    [Label("Field User Count Limit", 1)]
    FieldUserCountLimit = 64,

    /// <summary>Reload server options.</summary>
    [Label("AP_SERVEROPTRELOAD")]
    [Label("Server Opt Reload", 1)]
    ServerOptReload = 65,

    /// <summary>Change event stage.</summary>
    [Label("AP_STAGECHANGE")]
    [Label("Stage Change", 1)]
    StageChange = 66,

    /// <summary>Activate stage change.</summary>
    [Label("AP_ACTIVATESTAGECHANGE")]
    [Label("Activate Stage Change", 1)]
    ActivateStageChange = 67,

    /// <summary>Reload gachapon bonus.</summary>
    [Label("AP_RELOADGACHAPONBONUS")]
    [Label("Reload Gachapon Bonus", 1)]
    ReloadGachaponBonus = 68,

    /// <summary>Reload visitor log info.</summary>
    [Label("AP_RELOADVISITORLOGINFO")]
    [Label("Reload Visitor Log Info", 1)]
    ReloadVisitorLogInfo = 69,

    /// <summary>Complete cube upgrade.</summary>
    [Label("AP_CUBECOMPLETE")]
    [Label("Cube Complete", 1)]
    CubeComplete = 70,

    /// <summary>Check party composition.</summary>
    [Label("AP_PARTYCHECK")]
    [Label("Party Check", 1)]
    PartyCheck = 71,

    /// <summary>Reload blocked delivery quests.</summary>
    [Label("AP_RELOADDISALLOWEDDELIVERYQUEST")]
    [Label("Reload Disallowed Delivery Quest", 1)]
    ReloadDisallowedDeliveryQuest = 72,
}
