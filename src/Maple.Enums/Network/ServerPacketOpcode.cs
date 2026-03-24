using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Server-to-client (send) packet opcodes.
/// </summary>
public enum ServerPacketOpcode : ushort
{
    /// <summary>Login result.</summary>
    [Label("LP_CheckPasswordResult")]
    [Label("Check Password Result", 1)]
    CheckPasswordResult = 0,

    /// <summary>Guest login result.</summary>
    [Label("LP_GuestIDLoginResult")]
    [Label("Guest ID Login Result", 1)]
    GuestIDLoginResult = 1,

    /// <summary>Account info response.</summary>
    [Label("LP_AccountInfoResult")]
    [Label("Account Info Result", 1)]
    AccountInfoResult = 2,

    /// <summary>User limit check.</summary>
    [Label("LP_CheckUserLimitResult")]
    [Label("Check User Limit Result", 1)]
    CheckUserLimitResult = 3,

    /// <summary>Account setup result.</summary>
    [Label("LP_SetAccountResult")]
    [Label("Set Account Result", 1)]
    SetAccountResult = 4,

    /// <summary>EULA confirmation result.</summary>
    [Label("LP_ConfirmEULAResult")]
    [Label("Confirm EULA Result", 1)]
    ConfirmEULAResult = 5,

    /// <summary>PIN check result.</summary>
    [Label("LP_CheckPinCodeResult")]
    [Label("Check Pin Code Result", 1)]
    CheckPinCodeResult = 6,

    /// <summary>PIN update result.</summary>
    [Label("LP_UpdatePinCodeResult")]
    [Label("Update Pin Code Result", 1)]
    UpdatePinCodeResult = 7,

    /// <summary>View all characters.</summary>
    [Label("LP_ViewAllCharResult")]
    [Label("View All Char Result", 1)]
    ViewAllCharResult = 8,

    /// <summary>VAC character select.</summary>
    [Label("LP_SelectCharacterByVACResult")]
    [Label("Select Character By VAC Result", 1)]
    SelectCharacterByVACResult = 9,

    /// <summary>World list info.</summary>
    [Label("LP_WorldInformation")]
    [Label("World Information", 1)]
    WorldInformation = 10,

    /// <summary>World select result.</summary>
    [Label("LP_SelectWorldResult")]
    [Label("Select World Result", 1)]
    SelectWorldResult = 11,

    /// <summary>Character select result.</summary>
    [Label("LP_SelectCharacterResult")]
    [Label("Select Character Result", 1)]
    SelectCharacterResult = 12,

    /// <summary>Name check result.</summary>
    [Label("LP_CheckDuplicatedIDResult")]
    [Label("Check Duplicated ID Result", 1)]
    CheckDuplicatedIDResult = 13,

    /// <summary>Character creation result.</summary>
    [Label("LP_CreateNewCharacterResult")]
    [Label("Create New Character Result", 1)]
    CreateNewCharacterResult = 14,

    /// <summary>Character deletion result.</summary>
    [Label("LP_DeleteCharacterResult")]
    [Label("Delete Character Result", 1)]
    DeleteCharacterResult = 15,

    /// <summary>Channel migration command.</summary>
    [Label("LP_MigrateCommand")]
    [Label("Migrate Command", 1)]
    MigrateCommand = 16,

    /// <summary>Keep-alive ping.</summary>
    [Label("LP_AliveReq")]
    [Label("Alive Req", 1)]
    AliveReq = 17,

    /// <summary>Auth code changed.</summary>
    [Label("LP_AuthenCodeChanged")]
    [Label("Authen Code Changed", 1)]
    AuthenCodeChanged = 18,

    /// <summary>Auth message.</summary>
    [Label("LP_AuthenMessage")]
    [Label("Authen Message", 1)]
    AuthenMessage = 19,

    /// <summary>Security check packet.</summary>
    [Label("LP_SecurityPacket")]
    [Label("Security Packet", 1)]
    SecurityPacket = 20,

    /// <summary>Second password result.</summary>
    [Label("LP_EnableSPWResult")]
    [Label("Enable SPW Result", 1)]
    EnableSPWResult = 21,

    /// <summary>Delete character OTP.</summary>
    [Label("LP_DeleteCharacterOTPRequest")]
    [Label("Delete Character OTP Request", 1)]
    DeleteCharacterOTPRequest = 22,

    /// <summary>CRC check result.</summary>
    [Label("LP_CheckCrcResult")]
    [Label("Check Crc Result", 1)]
    CheckCrcResult = 23,

    /// <summary>Last connected world.</summary>
    [Label("LP_LatestConnectedWorld")]
    [Label("Latest Connected World", 1)]
    LatestConnectedWorld = 24,

    /// <summary>Recommended world.</summary>
    [Label("LP_RecommendWorldMessage")]
    [Label("Recommend World Message", 1)]
    RecommendWorldMessage = 25,

    /// <summary>Extra character info.</summary>
    [Label("LP_CheckExtraCharInfoResult")]
    [Label("Check Extra Char Info Result", 1)]
    CheckExtraCharInfoResult = 26,

    /// <summary>Second password check.</summary>
    [Label("LP_CheckSPWResult")]
    [Label("Check SPW Result", 1)]
    CheckSPWResult = 27,

    /// <summary>Inventory modified.</summary>
    [Label("LP_InventoryOperation")]
    [Label("Inventory Operation", 1)]
    InventoryOperation = 28,

    /// <summary>Inventory slots expanded.</summary>
    [Label("LP_InventoryGrow")]
    [Label("Inventory Grow", 1)]
    InventoryGrow = 29,

    /// <summary>Stats updated.</summary>
    [Label("LP_StatChanged")]
    [Label("Stat Changed", 1)]
    StatChanged = 30,

    /// <summary>Buff applied.</summary>
    [Label("LP_TemporaryStatSet")]
    [Label("Temporary Stat Set", 1)]
    TemporaryStatSet = 31,

    /// <summary>Buff removed.</summary>
    [Label("LP_TemporaryStatReset")]
    [Label("Temporary Stat Reset", 1)]
    TemporaryStatReset = 32,

    /// <summary>Forced stat applied.</summary>
    [Label("LP_ForcedStatSet")]
    [Label("Forced Stat Set", 1)]
    ForcedStatSet = 33,

    /// <summary>Forced stat removed.</summary>
    [Label("LP_ForcedStatReset")]
    [Label("Forced Stat Reset", 1)]
    ForcedStatReset = 34,

    /// <summary>Skill level changed.</summary>
    [Label("LP_ChangeSkillRecordResult")]
    [Label("Change Skill Record Result", 1)]
    ChangeSkillRecordResult = 35,

    /// <summary>Skill use result.</summary>
    [Label("LP_SkillUseResult")]
    [Label("Skill Use Result", 1)]
    SkillUseResult = 36,

    /// <summary>Fame result.</summary>
    [Label("LP_GivePopularityResult")]
    [Label("Give Popularity Result", 1)]
    GivePopularityResult = 37,

    /// <summary>General message.</summary>
    [Label("LP_Message")]
    Message = 38,

    /// <summary>Open client link.</summary>
    [Label("LP_SendOpenFullClientLink")]
    [Label("Send Open Full Client Link", 1)]
    SendOpenFullClientLink = 39,

    /// <summary>Memo result.</summary>
    [Label("LP_MemoResult")]
    [Label("Memo Result", 1)]
    MemoResult = 40,

    /// <summary>Teleport rock result.</summary>
    [Label("LP_MapTransferResult")]
    [Label("Map Transfer Result", 1)]
    MapTransferResult = 41,

    /// <summary>Anti-macro result.</summary>
    [Label("LP_AntiMacroResult")]
    [Label("Anti Macro Result", 1)]
    AntiMacroResult = 42,

    /// <summary>Initial quiz started.</summary>
    [Label("LP_InitialQuizStart")]
    [Label("Initial Quiz Start", 1)]
    InitialQuizStart = 43,

    /// <summary>Claim result.</summary>
    [Label("LP_ClaimResult")]
    [Label("Claim Result", 1)]
    ClaimResult = 44,

    /// <summary>Claim server time.</summary>
    [Label("LP_SetClaimSvrAvailableTime")]
    [Label("Set Claim Svr Available Time", 1)]
    SetClaimSvrAvailableTime = 45,

    /// <summary>Claim server status.</summary>
    [Label("LP_ClaimSvrStatusChanged")]
    [Label("Claim Svr Status Changed", 1)]
    ClaimSvrStatusChanged = 46,

    /// <summary>Mount info set.</summary>
    [Label("LP_SetTamingMobInfo")]
    [Label("Set Taming Mob Info", 1)]
    SetTamingMobInfo = 47,

    /// <summary>Quest cleared.</summary>
    [Label("LP_QuestClear")]
    [Label("Quest Clear", 1)]
    QuestClear = 48,

    /// <summary>Hired shop check.</summary>
    [Label("LP_EntrustedShopCheckResult")]
    [Label("Entrusted Shop Check Result", 1)]
    EntrustedShopCheckResult = 49,

    /// <summary>Skill book result.</summary>
    [Label("LP_SkillLearnItemResult")]
    [Label("Skill Learn Item Result", 1)]
    SkillLearnItemResult = 50,

    /// <summary>Skill reset result.</summary>
    [Label("LP_SkillResetItemResult")]
    [Label("Skill Reset Item Result", 1)]
    SkillResetItemResult = 51,

    /// <summary>Gather items result.</summary>
    [Label("LP_GatherItemResult")]
    [Label("Gather Item Result", 1)]
    GatherItemResult = 52,

    /// <summary>Sort items result.</summary>
    [Label("LP_SortItemResult")]
    [Label("Sort Item Result", 1)]
    SortItemResult = 53,

    /// <summary>Remote shop result.</summary>
    [Label("LP_RemoteShopOpenResult")]
    [Label("Remote Shop Open Result", 1)]
    RemoteShopOpenResult = 54,

    /// <summary>Report player result.</summary>
    [Label("LP_SueCharacterResult")]
    [Label("Sue Character Result", 1)]
    SueCharacterResult = 55,

    /// <summary>Cash shop migration.</summary>
    [Label("LP_MigrateToCashShopResult")]
    [Label("Migrate To Cash Shop Result", 1)]
    MigrateToCashShopResult = 56,

    /// <summary>Trade meso limit.</summary>
    [Label("LP_TradeMoneyLimit")]
    [Label("Trade Money Limit", 1)]
    TradeMoneyLimit = 57,

    /// <summary>Set gender.</summary>
    [Label("LP_SetGender")]
    [Label("Set Gender", 1)]
    SetGender = 58,

    /// <summary>Guild board.</summary>
    [Label("LP_GuildBBS")]
    [Label("Guild BBS", 1)]
    GuildBBS = 59,

    /// <summary>Pet died.</summary>
    [Label("LP_PetDeadMessage")]
    [Label("Pet Dead Message", 1)]
    PetDeadMessage = 60,

    /// <summary>Character info.</summary>
    [Label("LP_CharacterInfo")]
    [Label("Character Info", 1)]
    CharacterInfo = 61,

    /// <summary>Party result.</summary>
    [Label("LP_PartyResult")]
    [Label("Party Result", 1)]
    PartyResult = 62,

    /// <summary>Expedition request.</summary>
    [Label("LP_ExpeditionRequest")]
    [Label("Expedition Request", 1)]
    ExpeditionRequest = 63,

    /// <summary>Expedition notification.</summary>
    [Label("LP_ExpeditionNoti")]
    [Label("Expedition Noti", 1)]
    ExpeditionNoti = 64,

    /// <summary>Friend list result.</summary>
    [Label("LP_FriendResult")]
    [Label("Friend Result", 1)]
    FriendResult = 65,

    /// <summary>Guild request.</summary>
    [Label("LP_GuildRequest")]
    [Label("Guild Request", 1)]
    GuildRequest = 66,

    /// <summary>Guild result.</summary>
    [Label("LP_GuildResult")]
    [Label("Guild Result", 1)]
    GuildResult = 67,

    /// <summary>Alliance result.</summary>
    [Label("LP_AllianceResult")]
    [Label("Alliance Result", 1)]
    AllianceResult = 68,

    /// <summary>Mystic Door info.</summary>
    [Label("LP_TownPortal")]
    [Label("Town Portal", 1)]
    TownPortal = 69,

    /// <summary>Gate opened.</summary>
    [Label("LP_OpenGate")]
    [Label("Open Gate", 1)]
    OpenGate = 70,

    /// <summary>Broadcast message.</summary>
    [Label("LP_BroadcastMsg")]
    [Label("Broadcast Msg", 1)]
    BroadcastMsg = 71,

    /// <summary>Incubator result.</summary>
    [Label("LP_IncubatorResult")]
    [Label("Incubator Result", 1)]
    IncubatorResult = 72,

    /// <summary>Shop scanner result.</summary>
    [Label("LP_ShopScannerResult")]
    [Label("Shop Scanner Result", 1)]
    ShopScannerResult = 73,

    /// <summary>Shop link result.</summary>
    [Label("LP_ShopLinkResult")]
    [Label("Shop Link Result", 1)]
    ShopLinkResult = 74,

    /// <summary>Marriage proposal.</summary>
    [Label("LP_MarriageRequest")]
    [Label("Marriage Request", 1)]
    MarriageRequest = 75,

    /// <summary>Marriage result.</summary>
    [Label("LP_MarriageResult")]
    [Label("Marriage Result", 1)]
    MarriageResult = 76,

    /// <summary>Wedding gift result.</summary>
    [Label("LP_WeddingGiftResult")]
    [Label("Wedding Gift Result", 1)]
    WeddingGiftResult = 77,

    /// <summary>Spouse map transfer.</summary>
    [Label("LP_MarriedPartnerMapTransfer")]
    [Label("Married Partner Map Transfer", 1)]
    MarriedPartnerMapTransfer = 78,

    /// <summary>Cash pet food result.</summary>
    [Label("LP_CashPetFoodResult")]
    [Label("Cash Pet Food Result", 1)]
    CashPetFoodResult = 79,

    /// <summary>Weekly event message.</summary>
    [Label("LP_SetWeekEventMessage")]
    [Label("Set Week Event Message", 1)]
    SetWeekEventMessage = 80,

    /// <summary>Potion discount set.</summary>
    [Label("LP_SetPotionDiscountRate")]
    [Label("Set Potion Discount Rate", 1)]
    SetPotionDiscountRate = 81,

    /// <summary>Monster catch failed.</summary>
    [Label("LP_BridleMobCatchFail")]
    [Label("Bridle Mob Catch Fail", 1)]
    BridleMobCatchFail = 82,

    /// <summary>Imitated NPC result.</summary>
    [Label("LP_ImitatedNPCResult")]
    [Label("Imitated NPC Result", 1)]
    ImitatedNPCResult = 83,

    /// <summary>Imitated NPC data.</summary>
    [Label("LP_ImitatedNPCData")]
    [Label("Imitated NPC Data", 1)]
    ImitatedNPCData = 84,

    /// <summary>Limited NPC disabled.</summary>
    [Label("LP_LimitedNPCDisableInfo")]
    [Label("Limited NPC Disable Info", 1)]
    LimitedNPCDisableInfo = 85,

    /// <summary>Monster book card.</summary>
    [Label("LP_MonsterBookSetCard")]
    [Label("Monster Book Set Card", 1)]
    MonsterBookSetCard = 86,

    /// <summary>Monster book cover.</summary>
    [Label("LP_MonsterBookSetCover")]
    [Label("Monster Book Set Cover", 1)]
    MonsterBookSetCover = 87,

    /// <summary>Hour changed.</summary>
    [Label("LP_HourChanged")]
    [Label("Hour Changed", 1)]
    HourChanged = 88,

    /// <summary>Minimap toggled.</summary>
    [Label("LP_MiniMapOnOff")]
    [Label("Mini Map On Off", 1)]
    MiniMapOnOff = 89,

    /// <summary>Consult auth key.</summary>
    [Label("LP_ConsultAuthkeyUpdate")]
    [Label("Consult Authkey Update", 1)]
    ConsultAuthkeyUpdate = 90,

    /// <summary>Class competition auth.</summary>
    [Label("LP_ClassCompetitionAuthkeyUpdate")]
    [Label("Class Competition Authkey Update", 1)]
    ClassCompetitionAuthkeyUpdate = 91,

    /// <summary>Web board auth key.</summary>
    [Label("LP_WebBoardAuthkeyUpdate")]
    [Label("Web Board Authkey Update", 1)]
    WebBoardAuthkeyUpdate = 92,

    /// <summary>Session value set.</summary>
    [Label("LP_SessionValue")]
    [Label("Session Value", 1)]
    SessionValue = 93,

    /// <summary>Party value set.</summary>
    [Label("LP_PartyValue")]
    [Label("Party Value", 1)]
    PartyValue = 94,

    /// <summary>Field variable set.</summary>
    [Label("LP_FieldSetVariable")]
    [Label("Field Set Variable", 1)]
    FieldSetVariable = 95,

    /// <summary>Bonus EXP changed.</summary>
    [Label("LP_BonusExpRateChanged")]
    [Label("Bonus Exp Rate Changed", 1)]
    BonusExpRateChanged = 96,

    /// <summary>Potion discount changed.</summary>
    [Label("LP_PotionDiscountRateChanged")]
    [Label("Potion Discount Rate Changed", 1)]
    PotionDiscountRateChanged = 97,

    /// <summary>Family chart result.</summary>
    [Label("LP_FamilyChartResult")]
    [Label("Family Chart Result", 1)]
    FamilyChartResult = 98,

    /// <summary>Family info result.</summary>
    [Label("LP_FamilyInfoResult")]
    [Label("Family Info Result", 1)]
    FamilyInfoResult = 99,

    /// <summary>Family result.</summary>
    [Label("LP_FamilyResult")]
    [Label("Family Result", 1)]
    FamilyResult = 100,

    /// <summary>Family join request.</summary>
    [Label("LP_FamilyJoinRequest")]
    [Label("Family Join Request", 1)]
    FamilyJoinRequest = 101,

    /// <summary>Family join result.</summary>
    [Label("LP_FamilyJoinRequestResult")]
    [Label("Family Join Request Result", 1)]
    FamilyJoinRequestResult = 102,

    /// <summary>Family join accepted.</summary>
    [Label("LP_FamilyJoinAccepted")]
    [Label("Family Join Accepted", 1)]
    FamilyJoinAccepted = 103,

    /// <summary>Family privileges.</summary>
    [Label("LP_FamilyPrivilegeList")]
    [Label("Family Privilege List", 1)]
    FamilyPrivilegeList = 104,

    /// <summary>Family rep gained.</summary>
    [Label("LP_FamilyFamousPointIncResult")]
    [Label("Family Famous Point Inc Result", 1)]
    FamilyFamousPointIncResult = 105,

    /// <summary>Family login notify.</summary>
    [Label("LP_FamilyNotifyLoginOrLogout")]
    [Label("Family Notify Login Or Logout", 1)]
    FamilyNotifyLoginOrLogout = 106,

    /// <summary>Family privilege set.</summary>
    [Label("LP_FamilySetPrivilege")]
    [Label("Family Set Privilege", 1)]
    FamilySetPrivilege = 107,

    /// <summary>Family summon request.</summary>
    [Label("LP_FamilySummonRequest")]
    [Label("Family Summon Request", 1)]
    FamilySummonRequest = 108,

    /// <summary>Level-up notification.</summary>
    [Label("LP_NotifyLevelUp")]
    [Label("Notify Level Up", 1)]
    NotifyLevelUp = 109,

    /// <summary>Wedding notification.</summary>
    [Label("LP_NotifyWedding")]
    [Label("Notify Wedding", 1)]
    NotifyWedding = 110,

    /// <summary>Job change notification.</summary>
    [Label("LP_NotifyJobChange")]
    [Label("Notify Job Change", 1)]
    NotifyJobChange = 111,

    /// <summary>Rate increase changed.</summary>
    [Label("LP_IncRateChanged")]
    [Label("Inc Rate Changed", 1)]
    IncRateChanged = 112,

    /// <summary>Maple TV result.</summary>
    [Label("LP_MapleTVUseRes")]
    [Label("Maple TV Use Res", 1)]
    MapleTVUseRes = 113,

    /// <summary>Avatar megaphone result.</summary>
    [Label("LP_AvatarMegaphoneRes")]
    [Label("Avatar Megaphone Res", 1)]
    AvatarMegaphoneRes = 114,

    /// <summary>Avatar megaphone update.</summary>
    [Label("LP_AvatarMegaphoneUpdateMessage")]
    [Label("Avatar Megaphone Update Message", 1)]
    AvatarMegaphoneUpdateMessage = 115,

    /// <summary>Avatar megaphone clear.</summary>
    [Label("LP_AvatarMegaphoneClearMessage")]
    [Label("Avatar Megaphone Clear Message", 1)]
    AvatarMegaphoneClearMessage = 116,

    /// <summary>Cancel name change.</summary>
    [Label("LP_CancelNameChangeResult")]
    [Label("Cancel Name Change Result", 1)]
    CancelNameChangeResult = 117,

    /// <summary>Cancel world transfer.</summary>
    [Label("LP_CancelTransferWorldResult")]
    [Label("Cancel Transfer World Result", 1)]
    CancelTransferWorldResult = 118,

    /// <summary>Shop destroyed.</summary>
    [Label("LP_DestroyShopResult")]
    [Label("Destroy Shop Result", 1)]
    DestroyShopResult = 119,

    /// <summary>Fake GM notice.</summary>
    [Label("LP_FAKEGMNOTICE")]
    FAKEGMNOTICE = 120,

    /// <summary>Gachapon success.</summary>
    [Label("LP_SuccessInUseGachaponBox")]
    [Label("Success In Use Gachapon Box", 1)]
    SuccessInUseGachaponBox = 121,

    /// <summary>New Year card result.</summary>
    [Label("LP_NewYearCardRes")]
    [Label("New Year Card Res", 1)]
    NewYearCardRes = 122,

    /// <summary>Random morph result.</summary>
    [Label("LP_RandomMorphRes")]
    [Label("Random Morph Res", 1)]
    RandomMorphRes = 123,

    /// <summary>Name change cancelled.</summary>
    [Label("LP_CancelNameChangeByOther")]
    [Label("Cancel Name Change By Other", 1)]
    CancelNameChangeByOther = 124,

    /// <summary>Equip purchase extended.</summary>
    [Label("LP_SetBuyEquipExt")]
    [Label("Set Buy Equip Ext", 1)]
    SetBuyEquipExt = 125,

    /// <summary>Passenger request.</summary>
    [Label("LP_SetPassenserRequest")]
    [Label("Set Passenser Request", 1)]
    SetPassenserRequest = 126,

    /// <summary>Script progress message.</summary>
    [Label("LP_ScriptProgressMessage")]
    [Label("Script Progress Message", 1)]
    ScriptProgressMessage = 127,

    /// <summary>Data CRC failed.</summary>
    [Label("LP_DataCRCCheckFailed")]
    [Label("Data CRC Check Failed", 1)]
    DataCRCCheckFailed = 128,

    /// <summary>Cake vs Pie event.</summary>
    [Label("LP_CakePieEventResult")]
    [Label("Cake Pie Event Result", 1)]
    CakePieEventResult = 129,

    /// <summary>GM board updated.</summary>
    [Label("LP_UpdateGMBoard")]
    [Label("Update GM Board", 1)]
    UpdateGMBoard = 130,

    /// <summary>Slot message shown.</summary>
    [Label("LP_ShowSlotMessage")]
    [Label("Show Slot Message", 1)]
    ShowSlotMessage = 131,

    /// <summary>Wild Hunter info.</summary>
    [Label("LP_WildHunterInfo")]
    [Label("Wild Hunter Info", 1)]
    WildHunterInfo = 132,

    /// <summary>Account extra info.</summary>
    [Label("LP_AccountMoreInfo")]
    [Label("Account More Info", 1)]
    AccountMoreInfo = 133,

    /// <summary>Find friend.</summary>
    /// <remarks>Documented original client typo: "FindFirend" → "FindFriend"; see typos.md.</remarks>
    [Label("LP_FindFirend")]
    [Label("Find Friend", 1)]
    FindFriend = 134,

    /// <summary>Stage changed.</summary>
    [Label("LP_StageChange")]
    [Label("Stage Change", 1)]
    StageChange = 135,

    /// <summary>Dragon Ball box.</summary>
    [Label("LP_DragonBallBox")]
    [Label("Dragon Ball Box", 1)]
    DragonBallBox = 136,

    /// <summary>Pam's Song prompt.</summary>
    [Label("LP_AskUserWhetherUsePamsSong")]
    [Label("Ask User Whether Use Pams Song", 1)]
    AskUserWhetherUsePamsSong = 137,

    /// <summary>Channel transfer.</summary>
    [Label("LP_TransferChannel")]
    [Label("Transfer Channel", 1)]
    TransferChannel = 138,

    /// <summary>Blocked delivery quests.</summary>
    [Label("LP_DisallowedDeliveryQuestList")]
    [Label("Disallowed Delivery Quest List", 1)]
    DisallowedDeliveryQuestList = 139,

    /// <summary>Macro system init.</summary>
    [Label("LP_MacroSysDataInit")]
    [Label("Macro Sys Data Init", 1)]
    MacroSysDataInit = 140,

    /// <summary>Enter/change map.</summary>
    [Label("LP_SetField")]
    [Label("Set Field", 1)]
    SetField = 141,

    /// <summary>Enter trade center.</summary>
    [Label("LP_SetITC")]
    [Label("Set ITC", 1)]
    SetITC = 142,

    /// <summary>Enter cash shop.</summary>
    [Label("LP_SetCashShop")]
    [Label("Set Cash Shop", 1)]
    SetCashShop = 143,

    /// <summary>Background effect set.</summary>
    [Label("LP_SetBackgroundEffect")]
    [Label("Set Background Effect", 1)]
    SetBackgroundEffect = 144,

    /// <summary>Map object visibility.</summary>
    [Label("LP_SetMapObjectVisible")]
    [Label("Set Map Object Visible", 1)]
    SetMapObjectVisible = 145,

    /// <summary>Background effect cleared.</summary>
    [Label("LP_ClearBackgroundEffect")]
    [Label("Clear Background Effect", 1)]
    ClearBackgroundEffect = 146,

    /// <summary>Map transfer denied.</summary>
    [Label("LP_TransferFieldReqIgnored")]
    [Label("Transfer Field Req Ignored", 1)]
    TransferFieldReqIgnored = 147,

    /// <summary>Channel transfer denied.</summary>
    [Label("LP_TransferChannelReqIgnored")]
    [Label("Transfer Channel Req Ignored", 1)]
    TransferChannelReqIgnored = 148,

    /// <summary>Map-specific data.</summary>
    [Label("LP_FieldSpecificData")]
    [Label("Field Specific Data", 1)]
    FieldSpecificData = 149,

    /// <summary>Group message.</summary>
    [Label("LP_GroupMessage")]
    [Label("Group Message", 1)]
    GroupMessage = 150,

    /// <summary>Whisper message.</summary>
    [Label("LP_Whisper")]
    Whisper = 151,

    /// <summary>Couple message.</summary>
    [Label("LP_CoupleMessage")]
    [Label("Couple Message", 1)]
    CoupleMessage = 152,

    /// <summary>Monster summon result.</summary>
    [Label("LP_MobSummonItemUseResult")]
    [Label("Mob Summon Item Use Result", 1)]
    MobSummonItemUseResult = 153,

    /// <summary>Field effect.</summary>
    [Label("LP_FieldEffect")]
    [Label("Field Effect", 1)]
    FieldEffect = 154,

    /// <summary>Field obstacle toggled.</summary>
    [Label("LP_FieldObstacleOnOff")]
    [Label("Field Obstacle On Off", 1)]
    FieldObstacleOnOff = 155,

    /// <summary>Obstacle toggle status.</summary>
    [Label("LP_FieldObstacleOnOffStatus")]
    [Label("Field Obstacle On Off Status", 1)]
    FieldObstacleOnOffStatus = 156,

    /// <summary>All obstacles reset.</summary>
    [Label("LP_FieldObstacleAllReset")]
    [Label("Field Obstacle All Reset", 1)]
    FieldObstacleAllReset = 157,

    /// <summary>Weather effect.</summary>
    [Label("LP_BlowWeather")]
    [Label("Blow Weather", 1)]
    BlowWeather = 158,

    /// <summary>Jukebox play.</summary>
    [Label("LP_PlayJukeBox")]
    [Label("Play Juke Box", 1)]
    PlayJukeBox = 159,

    /// <summary>GM command result.</summary>
    [Label("LP_AdminResult")]
    [Label("Admin Result", 1)]
    AdminResult = 160,

    /// <summary>Quiz event.</summary>
    [Label("LP_Quiz")]
    Quiz = 161,

    /// <summary>Description shown.</summary>
    [Label("LP_Desc")]
    Desc = 162,

    /// <summary>Clock displayed.</summary>
    [Label("LP_Clock")]
    Clock = 163,

    /// <summary>Ship movement.</summary>
    [Label("LP_CONTIMOVE")]
    CONTIMOVE = 164,

    /// <summary>Ship state.</summary>
    [Label("LP_CONTISTATE")]
    CONTISTATE = 165,

    /// <summary>Quest clear set.</summary>
    [Label("LP_SetQuestClear")]
    [Label("Set Quest Clear", 1)]
    SetQuestClear = 166,

    /// <summary>Quest timer set.</summary>
    [Label("LP_SetQuestTime")]
    [Label("Set Quest Time", 1)]
    SetQuestTime = 167,

    /// <summary>Warning message.</summary>
    [Label("LP_Warn")]
    Warn = 168,

    /// <summary>Object state set.</summary>
    [Label("LP_SetObjectState")]
    [Label("Set Object State", 1)]
    SetObjectState = 169,

    /// <summary>Clock removed.</summary>
    [Label("LP_DestroyClock")]
    [Label("Destroy Clock", 1)]
    DestroyClock = 170,

    /// <summary>Arena results.</summary>
    [Label("LP_ShowArenaResult")]
    [Label("Show Arena Result", 1)]
    ShowArenaResult = 171,

    /// <summary>Stalk result.</summary>
    [Label("LP_StalkResult")]
    [Label("Stalk Result", 1)]
    StalkResult = 172,

    /// <summary>Massacre gauge up.</summary>
    [Label("LP_MassacreIncGauge")]
    [Label("Massacre Inc Gauge", 1)]
    MassacreIncGauge = 173,

    /// <summary>Massacre result.</summary>
    [Label("LP_MassacreResult")]
    [Label("Massacre Result", 1)]
    MassacreResult = 174,

    /// <summary>Quickslots initialized.</summary>
    [Label("LP_QuickslotMappedInit")]
    [Label("Quickslot Mapped Init", 1)]
    QuickslotMappedInit = 175,

    /// <summary>Foothold info.</summary>
    [Label("LP_FootHoldInfo")]
    [Label("Foot Hold Info", 1)]
    FootHoldInfo = 176,

    /// <summary>Foothold info request.</summary>
    [Label("LP_RequestFootHoldInfo")]
    [Label("Request Foot Hold Info", 1)]
    RequestFootHoldInfo = 177,

    /// <summary>Field kill count.</summary>
    [Label("LP_FieldKillCount")]
    [Label("Field Kill Count", 1)]
    FieldKillCount = 178,

    /// <summary>Player spawned.</summary>
    [Label("LP_UserEnterField")]
    [Label("User Enter Field", 1)]
    UserEnterField = 179,

    /// <summary>Player despawned.</summary>
    [Label("LP_UserLeaveField")]
    [Label("User Leave Field", 1)]
    UserLeaveField = 180,

    /// <summary>Chat message.</summary>
    [Label("LP_UserChat")]
    [Label("User Chat", 1)]
    UserChat = 181,

    /// <summary>NLC PQ chat.</summary>
    [Label("LP_UserChatNLCPQ")]
    [Label("User Chat NLCPQ", 1)]
    UserChatNLCPQ = 182,

    /// <summary>Ad board shown.</summary>
    [Label("LP_UserADBoard")]
    [Label("User AD Board", 1)]
    UserADBoard = 183,

    /// <summary>Mini-room balloon.</summary>
    [Label("LP_UserMiniRoomBalloon")]
    [Label("User Mini Room Balloon", 1)]
    UserMiniRoomBalloon = 184,

    /// <summary>Consume item effect.</summary>
    [Label("LP_UserConsumeItemEffect")]
    [Label("User Consume Item Effect", 1)]
    UserConsumeItemEffect = 185,

    /// <summary>Scroll upgrade effect.</summary>
    [Label("LP_UserItemUpgradeEffect")]
    [Label("User Item Upgrade Effect", 1)]
    UserItemUpgradeEffect = 186,

    /// <summary>Hyper upgrade effect.</summary>
    [Label("LP_UserItemHyperUpgradeEffect")]
    [Label("User Item Hyper Upgrade Effect", 1)]
    UserItemHyperUpgradeEffect = 187,

    /// <summary>Option upgrade effect.</summary>
    [Label("LP_UserItemOptionUpgradeEffect")]
    [Label("User Item Option Upgrade Effect", 1)]
    UserItemOptionUpgradeEffect = 188,

    /// <summary>Seal release effect.</summary>
    [Label("LP_UserItemReleaseEffect")]
    [Label("User Item Release Effect", 1)]
    UserItemReleaseEffect = 189,

    /// <summary>Seal lock effect.</summary>
    [Label("LP_UserItemUnreleaseEffect")]
    [Label("User Item Unrelease Effect", 1)]
    UserItemUnreleaseEffect = 190,

    /// <summary>PvP hit received.</summary>
    [Label("LP_UserHitByUser")]
    [Label("User Hit By User", 1)]
    UserHitByUser = 191,

    /// <summary>Tesla coil triangle.</summary>
    [Label("LP_UserTeslaTriangle")]
    [Label("User Tesla Triangle", 1)]
    UserTeslaTriangle = 192,

    /// <summary>Follow character.</summary>
    [Label("LP_UserFollowCharacter")]
    [Label("User Follow Character", 1)]
    UserFollowCharacter = 193,

    /// <summary>PQ reward shown.</summary>
    [Label("LP_UserShowPQReward")]
    [Label("User Show PQ Reward", 1)]
    UserShowPQReward = 194,

    /// <summary>Phase set.</summary>
    [Label("LP_UserSetPhase")]
    [Label("User Set Phase", 1)]
    UserSetPhase = 195,

    /// <summary>Portal usability set.</summary>
    [Label("LP_SetPortalUsable")]
    [Label("Set Portal Usable", 1)]
    SetPortalUsable = 196,

    /// <summary>Pam's Song result.</summary>
    [Label("LP_ShowPamsSongResult")]
    [Label("Show Pams Song Result", 1)]
    ShowPamsSongResult = 197,

    /// <summary>Pet activated.</summary>
    [Label("LP_PetActivated")]
    [Label("Pet Activated", 1)]
    PetActivated = 198,

    /// <summary>Pet evolved.</summary>
    [Label("LP_PetEvol")]
    [Label("Pet Evol", 1)]
    PetEvol = 199,

    /// <summary>Pet map transfer.</summary>
    [Label("LP_PetTransferField")]
    [Label("Pet Transfer Field", 1)]
    PetTransferField = 200,

    /// <summary>Pet moved.</summary>
    [Label("LP_PetMove")]
    [Label("Pet Move", 1)]
    PetMove = 201,

    /// <summary>Pet action.</summary>
    [Label("LP_PetAction")]
    [Label("Pet Action", 1)]
    PetAction = 202,

    /// <summary>Pet renamed.</summary>
    [Label("LP_PetNameChanged")]
    [Label("Pet Name Changed", 1)]
    PetNameChanged = 203,

    /// <summary>Pet exception list.</summary>
    [Label("LP_PetLoadExceptionList")]
    [Label("Pet Load Exception List", 1)]
    PetLoadExceptionList = 204,

    /// <summary>Pet command response.</summary>
    [Label("LP_PetActionCommand")]
    [Label("Pet Action Command", 1)]
    PetActionCommand = 205,

    /// <summary>Dragon spawned.</summary>
    [Label("LP_DragonEnterField")]
    [Label("Dragon Enter Field", 1)]
    DragonEnterField = 206,

    /// <summary>Dragon moved.</summary>
    [Label("LP_DragonMove")]
    [Label("Dragon Move", 1)]
    DragonMove = 207,

    /// <summary>Dragon despawned.</summary>
    [Label("LP_DragonLeaveField")]
    [Label("Dragon Leave Field", 1)]
    DragonLeaveField = 208,

    /// <summary>Player moved.</summary>
    [Label("LP_UserMove")]
    [Label("User Move", 1)]
    UserMove = 210,

    /// <summary>Melee attack.</summary>
    [Label("LP_UserMeleeAttack")]
    [Label("User Melee Attack", 1)]
    UserMeleeAttack = 211,

    /// <summary>Ranged attack.</summary>
    [Label("LP_UserShootAttack")]
    [Label("User Shoot Attack", 1)]
    UserShootAttack = 212,

    /// <summary>Magic attack.</summary>
    [Label("LP_UserMagicAttack")]
    [Label("User Magic Attack", 1)]
    UserMagicAttack = 213,

    /// <summary>Body attack.</summary>
    [Label("LP_UserBodyAttack")]
    [Label("User Body Attack", 1)]
    UserBodyAttack = 214,

    /// <summary>Skill prepare.</summary>
    [Label("LP_UserSkillPrepare")]
    [Label("User Skill Prepare", 1)]
    UserSkillPrepare = 215,

    /// <summary>Moving shot prepare.</summary>
    [Label("LP_UserMovingShootAttackPrepare")]
    [Label("User Moving Shoot Attack Prepare", 1)]
    UserMovingShootAttackPrepare = 216,

    /// <summary>Skill cancelled.</summary>
    [Label("LP_UserSkillCancel")]
    [Label("User Skill Cancel", 1)]
    UserSkillCancel = 217,

    /// <summary>Player hit.</summary>
    [Label("LP_UserHit")]
    [Label("User Hit", 1)]
    UserHit = 218,

    /// <summary>Emotion displayed.</summary>
    [Label("LP_UserEmotion")]
    [Label("User Emotion", 1)]
    UserEmotion = 219,

    /// <summary>Effect item set.</summary>
    [Label("LP_UserSetActiveEffectItem")]
    [Label("User Set Active Effect Item", 1)]
    UserSetActiveEffectItem = 220,

    /// <summary>Upgrade tomb effect.</summary>
    [Label("LP_UserShowUpgradeTombEffect")]
    [Label("User Show Upgrade Tomb Effect", 1)]
    UserShowUpgradeTombEffect = 221,

    /// <summary>Portable chair set.</summary>
    [Label("LP_UserSetActivePortableChair")]
    [Label("User Set Active Portable Chair", 1)]
    UserSetActivePortableChair = 222,

    /// <summary>Avatar changed.</summary>
    [Label("LP_UserAvatarModified")]
    [Label("User Avatar Modified", 1)]
    UserAvatarModified = 223,

    /// <summary>Remote user effect.</summary>
    [Label("LP_UserEffectRemote")]
    [Label("User Effect Remote", 1)]
    UserEffectRemote = 224,

    /// <summary>Remote buff applied.</summary>
    [Label("LP_UserTemporaryStatSet")]
    [Label("User Temporary Stat Set", 1)]
    UserTemporaryStatSet = 225,

    /// <summary>Remote buff removed.</summary>
    [Label("LP_UserTemporaryStatReset")]
    [Label("User Temporary Stat Reset", 1)]
    UserTemporaryStatReset = 226,

    /// <summary>Player HP shown.</summary>
    [Label("LP_UserHP")]
    [Label("User HP", 1)]
    UserHP = 227,

    /// <summary>Guild name changed.</summary>
    [Label("LP_UserGuildNameChanged")]
    [Label("User Guild Name Changed", 1)]
    UserGuildNameChanged = 228,

    /// <summary>Guild mark changed.</summary>
    [Label("LP_UserGuildMarkChanged")]
    [Label("User Guild Mark Changed", 1)]
    UserGuildMarkChanged = 229,

    /// <summary>Grenade thrown.</summary>
    [Label("LP_UserThrowGrenade")]
    [Label("User Throw Grenade", 1)]
    UserThrowGrenade = 230,

    /// <summary>Sit result.</summary>
    [Label("LP_UserSitResult")]
    [Label("User Sit Result", 1)]
    UserSitResult = 231,

    /// <summary>Local emotion displayed.</summary>
    [Label("LP_UserEmotionLocal")]
    [Label("User Emotion Local", 1)]
    UserEmotionLocal = 232,

    /// <summary>Local user effect.</summary>
    [Label("LP_UserEffectLocal")]
    [Label("User Effect Local", 1)]
    UserEffectLocal = 233,

    /// <summary>Player teleported.</summary>
    [Label("LP_UserTeleport")]
    [Label("User Teleport", 1)]
    UserTeleport = 234,

    /// <summary>Premium status.</summary>
    [Label("LP_Premium")]
    Premium = 235,

    /// <summary>Meso give success.</summary>
    [Label("LP_MesoGive_Succeeded")]
    MesoGive_Succeeded = 236,

    /// <summary>Meso give failed.</summary>
    [Label("LP_MesoGive_Failed")]
    MesoGive_Failed = 237,

    /// <summary>Meso bag success.</summary>
    [Label("LP_Random_Mesobag_Succeed")]
    Random_Mesobag_Succeed = 238,

    /// <summary>Meso bag failed.</summary>
    [Label("LP_Random_Mesobag_Failed")]
    Random_Mesobag_Failed = 239,

    /// <summary>Field fade effect.</summary>
    [Label("LP_FieldFadeInOut")]
    [Label("Field Fade In Out", 1)]
    FieldFadeInOut = 240,

    /// <summary>Forced field fade.</summary>
    [Label("LP_FieldFadeOutForce")]
    [Label("Field Fade Out Force", 1)]
    FieldFadeOutForce = 241,

    /// <summary>Quest result.</summary>
    [Label("LP_UserQuestResult")]
    [Label("User Quest Result", 1)]
    UserQuestResult = 242,

    /// <summary>HP drain notify.</summary>
    [Label("LP_NotifyHPDecByField")]
    [Label("Notify HP Dec By Field", 1)]
    NotifyHPDecByField = 243,

    /// <summary>Pet skill changed.</summary>
    [Label("LP_UserPetSkillChanged")]
    [Label("User Pet Skill Changed", 1)]
    UserPetSkillChanged = 244,

    /// <summary>Balloon message.</summary>
    [Label("LP_UserBalloonMsg")]
    [Label("User Balloon Msg", 1)]
    UserBalloonMsg = 245,

    /// <summary>Event sound played.</summary>
    [Label("LP_PlayEventSound")]
    [Label("Play Event Sound", 1)]
    PlayEventSound = 246,

    /// <summary>Minigame sound played.</summary>
    [Label("LP_PlayMinigameSound")]
    [Label("Play Minigame Sound", 1)]
    PlayMinigameSound = 247,

    /// <summary>Maker result.</summary>
    [Label("LP_UserMakerResult")]
    [Label("User Maker Result", 1)]
    UserMakerResult = 248,

    /// <summary>Consult board opened.</summary>
    [Label("LP_UserOpenConsultBoard")]
    [Label("User Open Consult Board", 1)]
    UserOpenConsultBoard = 249,

    /// <summary>Class competition opened.</summary>
    [Label("LP_UserOpenClassCompetitionPage")]
    [Label("User Open Class Competition Page", 1)]
    UserOpenClassCompetitionPage = 250,

    /// <summary>Open UI window.</summary>
    [Label("LP_UserOpenUI")]
    [Label("User Open UI", 1)]
    UserOpenUI = 251,

    /// <summary>Open UI with options.</summary>
    [Label("LP_UserOpenUIWithOption")]
    [Label("User Open UI With Option", 1)]
    UserOpenUIWithOption = 252,

    /// <summary>Direction mode set.</summary>
    [Label("LP_SetDirectionMode")]
    [Label("Set Direction Mode", 1)]
    SetDirectionMode = 253,

    /// <summary>Standalone mode set.</summary>
    [Label("LP_SetStandAloneMode")]
    [Label("Set Stand Alone Mode", 1)]
    SetStandAloneMode = 254,

    /// <summary>Hire tutor.</summary>
    [Label("LP_UserHireTutor")]
    [Label("User Hire Tutor", 1)]
    UserHireTutor = 255,

    /// <summary>Tutor message.</summary>
    [Label("LP_UserTutorMsg")]
    [Label("User Tutor Msg", 1)]
    UserTutorMsg = 256,

    /// <summary>Combo increased.</summary>
    [Label("LP_IncCombo")]
    [Label("Inc Combo", 1)]
    IncCombo = 257,

    /// <summary>Random emotion.</summary>
    [Label("LP_UserRandomEmotion")]
    [Label("User Random Emotion", 1)]
    UserRandomEmotion = 258,

    /// <summary>Quest resigned.</summary>
    [Label("LP_ResignQuestReturn")]
    [Label("Resign Quest Return", 1)]
    ResignQuestReturn = 259,

    /// <summary>Pass mate name.</summary>
    [Label("LP_PassMateName")]
    [Label("Pass Mate Name", 1)]
    PassMateName = 260,

    /// <summary>Radio schedule set.</summary>
    [Label("LP_SetRadioSchedule")]
    [Label("Set Radio Schedule", 1)]
    SetRadioSchedule = 261,

    /// <summary>Skill guide opened.</summary>
    [Label("LP_UserOpenSkillGuide")]
    [Label("User Open Skill Guide", 1)]
    UserOpenSkillGuide = 262,

    /// <summary>Notice message.</summary>
    [Label("LP_UserNoticeMsg")]
    [Label("User Notice Msg", 1)]
    UserNoticeMsg = 263,

    /// <summary>Chat system message.</summary>
    [Label("LP_UserChatMsg")]
    [Label("User Chat Msg", 1)]
    UserChatMsg = 264,

    /// <summary>Buff zone effect.</summary>
    [Label("LP_UserBuffzoneEffect")]
    [Label("User Buffzone Effect", 1)]
    UserBuffzoneEffect = 265,

    /// <summary>Go to commodity.</summary>
    [Label("LP_UserGoToCommoditySN")]
    [Label("User Go To Commodity SN", 1)]
    UserGoToCommoditySN = 266,

    /// <summary>Damage meter.</summary>
    [Label("LP_UserDamageMeter")]
    [Label("User Damage Meter", 1)]
    UserDamageMeter = 267,

    /// <summary>Time bomb attack.</summary>
    [Label("LP_UserTimeBombAttack")]
    [Label("User Time Bomb Attack", 1)]
    UserTimeBombAttack = 268,

    /// <summary>Passive movement.</summary>
    [Label("LP_UserPassiveMove")]
    [Label("User Passive Move", 1)]
    UserPassiveMove = 269,

    /// <summary>Follow failed.</summary>
    [Label("LP_UserFollowCharacterFailed")]
    [Label("User Follow Character Failed", 1)]
    UserFollowCharacterFailed = 270,

    /// <summary>Vengeance requested.</summary>
    [Label("LP_UserRequestVengeance")]
    [Label("User Request Vengeance", 1)]
    UserRequestVengeance = 271,

    /// <summary>Extra Jablin requested.</summary>
    [Label("LP_UserRequestExJablin")]
    [Label("User Request Ex Jablin", 1)]
    UserRequestExJablin = 272,

    /// <summary>AP/SP event prompt.</summary>
    [Label("LP_UserAskAPSPEvent")]
    [Label("User Ask APSP Event", 1)]
    UserAskAPSPEvent = 273,

    /// <summary>Quest guide result.</summary>
    [Label("LP_QuestGuideResult")]
    [Label("Quest Guide Result", 1)]
    QuestGuideResult = 274,

    /// <summary>Delivery quest.</summary>
    [Label("LP_UserDeliveryQuest")]
    [Label("User Delivery Quest", 1)]
    UserDeliveryQuest = 275,

    /// <summary>Skill cooldown set.</summary>
    [Label("LP_SkillCooltimeSet")]
    [Label("Skill Cooltime Set", 1)]
    SkillCooltimeSet = 276,

    /// <summary>Summon spawned.</summary>
    [Label("LP_SummonedEnterField")]
    [Label("Summoned Enter Field", 1)]
    SummonedEnterField = 278,

    /// <summary>Summon despawned.</summary>
    [Label("LP_SummonedLeaveField")]
    [Label("Summoned Leave Field", 1)]
    SummonedLeaveField = 279,

    /// <summary>Summon moved.</summary>
    [Label("LP_SummonedMove")]
    [Label("Summoned Move", 1)]
    SummonedMove = 280,

    /// <summary>Summon attacked.</summary>
    [Label("LP_SummonedAttack")]
    [Label("Summoned Attack", 1)]
    SummonedAttack = 281,

    /// <summary>Summon skill used.</summary>
    [Label("LP_SummonedSkill")]
    [Label("Summoned Skill", 1)]
    SummonedSkill = 282,

    /// <summary>Summon hit.</summary>
    [Label("LP_SummonedHit")]
    [Label("Summoned Hit", 1)]
    SummonedHit = 283,

    /// <summary>Monster spawned.</summary>
    [Label("LP_MobEnterField")]
    [Label("Mob Enter Field", 1)]
    MobEnterField = 284,

    /// <summary>Monster despawned.</summary>
    [Label("LP_MobLeaveField")]
    [Label("Mob Leave Field", 1)]
    MobLeaveField = 285,

    /// <summary>Monster controller changed.</summary>
    [Label("LP_MobChangeController")]
    [Label("Mob Change Controller", 1)]
    MobChangeController = 286,

    /// <summary>Monster moved.</summary>
    [Label("LP_MobMove")]
    [Label("Mob Move", 1)]
    MobMove = 287,

    /// <summary>Monster control ack.</summary>
    [Label("LP_MobCtrlAck")]
    [Label("Mob Ctrl Ack", 1)]
    MobCtrlAck = 288,

    /// <summary>Monster control hint.</summary>
    [Label("LP_MobCtrlHint")]
    [Label("Mob Ctrl Hint", 1)]
    MobCtrlHint = 289,

    /// <summary>Monster stat applied.</summary>
    [Label("LP_MobStatSet")]
    [Label("Mob Stat Set", 1)]
    MobStatSet = 290,

    /// <summary>Monster stat removed.</summary>
    [Label("LP_MobStatReset")]
    [Label("Mob Stat Reset", 1)]
    MobStatReset = 291,

    /// <summary>Monster suspend reset.</summary>
    [Label("LP_MobSuspendReset")]
    [Label("Mob Suspend Reset", 1)]
    MobSuspendReset = 292,

    /// <summary>Monster affected.</summary>
    [Label("LP_MobAffected")]
    [Label("Mob Affected", 1)]
    MobAffected = 293,

    /// <summary>Monster damaged.</summary>
    [Label("LP_MobDamaged")]
    [Label("Mob Damaged", 1)]
    MobDamaged = 294,

    /// <summary>Monster skill effect.</summary>
    [Label("LP_MobSpecialEffectBySkill")]
    [Label("Mob Special Effect By Skill", 1)]
    MobSpecialEffectBySkill = 295,

    /// <summary>Monster HP changed.</summary>
    [Label("LP_MobHPChange")]
    [Label("Mob HP Change", 1)]
    MobHPChange = 296,

    /// <summary>Monster CRC key changed.</summary>
    [Label("LP_MobCrcKeyChanged")]
    [Label("Mob Crc Key Changed", 1)]
    MobCrcKeyChanged = 297,

    /// <summary>Monster HP bar.</summary>
    [Label("LP_MobHPIndicator")]
    [Label("Mob HP Indicator", 1)]
    MobHPIndicator = 298,

    /// <summary>Monster catch effect.</summary>
    [Label("LP_MobCatchEffect")]
    [Label("Mob Catch Effect", 1)]
    MobCatchEffect = 299,

    /// <summary>Monster item effect.</summary>
    [Label("LP_MobEffectByItem")]
    [Label("Mob Effect By Item", 1)]
    MobEffectByItem = 300,

    /// <summary>Monster speaking.</summary>
    [Label("LP_MobSpeaking")]
    [Label("Mob Speaking", 1)]
    MobSpeaking = 301,

    /// <summary>Monster charge count.</summary>
    [Label("LP_MobChargeCount")]
    [Label("Mob Charge Count", 1)]
    MobChargeCount = 302,

    /// <summary>Monster skill delay.</summary>
    [Label("LP_MobSkillDelay")]
    [Label("Mob Skill Delay", 1)]
    MobSkillDelay = 303,

    /// <summary>Escort info result.</summary>
    [Label("LP_MobRequestResultEscortInfo")]
    [Label("Mob Request Result Escort Info", 1)]
    MobRequestResultEscortInfo = 304,

    /// <summary>Escort stop permission.</summary>
    [Label("LP_MobEscortStopEndPermmision")]
    [Label("Mob Escort Stop End Permmision", 1)]
    MobEscortStopEndPermmision = 305,

    /// <summary>Escort stop dialogue.</summary>
    [Label("LP_MobEscortStopSay")]
    [Label("Mob Escort Stop Say", 1)]
    MobEscortStopSay = 306,

    /// <summary>Escort return before.</summary>
    [Label("LP_MobEscortReturnBefore")]
    [Label("Mob Escort Return Before", 1)]
    MobEscortReturnBefore = 307,

    /// <summary>Monster next attack.</summary>
    [Label("LP_MobNextAttack")]
    [Label("Mob Next Attack", 1)]
    MobNextAttack = 308,

    /// <summary>Monster hit by monster.</summary>
    [Label("LP_MobAttackedByMob")]
    [Label("Mob Attacked By Mob", 1)]
    MobAttackedByMob = 309,

    /// <summary>NPC spawned.</summary>
    [Label("LP_NpcEnterField")]
    [Label("Npc Enter Field", 1)]
    NpcEnterField = 311,

    /// <summary>NPC despawned.</summary>
    [Label("LP_NpcLeaveField")]
    [Label("Npc Leave Field", 1)]
    NpcLeaveField = 312,

    /// <summary>NPC controller changed.</summary>
    [Label("LP_NpcChangeController")]
    [Label("Npc Change Controller", 1)]
    NpcChangeController = 313,

    /// <summary>NPC moved.</summary>
    [Label("LP_NpcMove")]
    [Label("Npc Move", 1)]
    NpcMove = 314,

    /// <summary>NPC limited info updated.</summary>
    [Label("LP_NpcUpdateLimitedInfo")]
    [Label("Npc Update Limited Info", 1)]
    NpcUpdateLimitedInfo = 315,

    /// <summary>NPC special action.</summary>
    [Label("LP_NpcSpecialAction")]
    [Label("Npc Special Action", 1)]
    NpcSpecialAction = 316,

    /// <summary>NPC script set.</summary>
    [Label("LP_NpcSetScript")]
    [Label("Npc Set Script", 1)]
    NpcSetScript = 317,

    /// <summary>Hired merchant spawned.</summary>
    [Label("LP_EmployeeEnterField")]
    [Label("Employee Enter Field", 1)]
    EmployeeEnterField = 319,

    /// <summary>Hired merchant despawned.</summary>
    [Label("LP_EmployeeLeaveField")]
    [Label("Employee Leave Field", 1)]
    EmployeeLeaveField = 320,

    /// <summary>Merchant room balloon.</summary>
    [Label("LP_EmployeeMiniRoomBalloon")]
    [Label("Employee Mini Room Balloon", 1)]
    EmployeeMiniRoomBalloon = 321,

    /// <summary>Item dropped.</summary>
    [Label("LP_DropEnterField")]
    [Label("Drop Enter Field", 1)]
    DropEnterField = 322,

    /// <summary>Drop freeze released.</summary>
    [Label("LP_DropReleaseAllFreeze")]
    [Label("Drop Release All Freeze", 1)]
    DropReleaseAllFreeze = 323,

    /// <summary>Drop removed.</summary>
    [Label("LP_DropLeaveField")]
    [Label("Drop Leave Field", 1)]
    DropLeaveField = 324,

    /// <summary>Message box failed.</summary>
    [Label("LP_CreateMessgaeBoxFailed")]
    [Label("Create Messgae Box Failed", 1)]
    CreateMessgaeBoxFailed = 325,

    /// <summary>Message box spawned.</summary>
    [Label("LP_MessageBoxEnterField")]
    [Label("Message Box Enter Field", 1)]
    MessageBoxEnterField = 326,

    /// <summary>Message box removed.</summary>
    [Label("LP_MessageBoxLeaveField")]
    [Label("Message Box Leave Field", 1)]
    MessageBoxLeaveField = 327,

    /// <summary>Affected area created.</summary>
    [Label("LP_AffectedAreaCreated")]
    [Label("Affected Area Created", 1)]
    AffectedAreaCreated = 328,

    /// <summary>Affected area removed.</summary>
    [Label("LP_AffectedAreaRemoved")]
    [Label("Affected Area Removed", 1)]
    AffectedAreaRemoved = 329,

    /// <summary>Mystic Door created.</summary>
    [Label("LP_TownPortalCreated")]
    [Label("Town Portal Created", 1)]
    TownPortalCreated = 330,

    /// <summary>Mystic Door removed.</summary>
    [Label("LP_TownPortalRemoved")]
    [Label("Town Portal Removed", 1)]
    TownPortalRemoved = 331,

    /// <summary>Gate created.</summary>
    [Label("LP_OpenGateCreated")]
    [Label("Open Gate Created", 1)]
    OpenGateCreated = 332,

    /// <summary>Gate removed.</summary>
    [Label("LP_OpenGateRemoved")]
    [Label("Open Gate Removed", 1)]
    OpenGateRemoved = 333,

    /// <summary>Reactor state changed.</summary>
    [Label("LP_ReactorChangeState")]
    [Label("Reactor Change State", 1)]
    ReactorChangeState = 334,

    /// <summary>Reactor moved.</summary>
    [Label("LP_ReactorMove")]
    [Label("Reactor Move", 1)]
    ReactorMove = 335,

    /// <summary>Reactor spawned.</summary>
    [Label("LP_ReactorEnterField")]
    [Label("Reactor Enter Field", 1)]
    ReactorEnterField = 336,

    /// <summary>Reactor despawned.</summary>
    [Label("LP_ReactorLeaveField")]
    [Label("Reactor Leave Field", 1)]
    ReactorLeaveField = 337,

    /// <summary>Snowball state.</summary>
    [Label("LP_SnowBallState")]
    [Label("Snow Ball State", 1)]
    SnowBallState = 338,

    /// <summary>Snowball hit.</summary>
    [Label("LP_SnowBallHit")]
    [Label("Snow Ball Hit", 1)]
    SnowBallHit = 339,

    /// <summary>Snowball message.</summary>
    [Label("LP_SnowBallMsg")]
    [Label("Snow Ball Msg", 1)]
    SnowBallMsg = 340,

    /// <summary>Snowball touched.</summary>
    [Label("LP_SnowBallTouch")]
    [Label("Snow Ball Touch", 1)]
    SnowBallTouch = 341,

    /// <summary>Coconut hit.</summary>
    [Label("LP_CoconutHit")]
    [Label("Coconut Hit", 1)]
    CoconutHit = 342,

    /// <summary>Coconut score.</summary>
    [Label("LP_CoconutScore")]
    [Label("Coconut Score", 1)]
    CoconutScore = 343,

    /// <summary>Healer moved.</summary>
    [Label("LP_HealerMove")]
    [Label("Healer Move", 1)]
    HealerMove = 344,

    /// <summary>Pulley state changed.</summary>
    [Label("LP_PulleyStateChange")]
    [Label("Pulley State Change", 1)]
    PulleyStateChange = 345,

    /// <summary>Monster Carnival enter.</summary>
    [Label("LP_MCarnivalEnter")]
    [Label("MCarnival Enter", 1)]
    MCarnivalEnter = 346,

    /// <summary>Carnival personal CP.</summary>
    [Label("LP_MCarnivalPersonalCP")]
    [Label("MCarnival Personal CP", 1)]
    MCarnivalPersonalCP = 347,

    /// <summary>Carnival team CP.</summary>
    [Label("LP_MCarnivalTeamCP")]
    [Label("MCarnival Team CP", 1)]
    MCarnivalTeamCP = 348,

    /// <summary>Carnival win.</summary>
    [Label("LP_MCarnivalResultSuccess")]
    [Label("MCarnival Result Success", 1)]
    MCarnivalResultSuccess = 349,

    /// <summary>Carnival loss.</summary>
    [Label("LP_MCarnivalResultFail")]
    [Label("MCarnival Result Fail", 1)]
    MCarnivalResultFail = 350,

    /// <summary>Carnival death.</summary>
    [Label("LP_MCarnivalDeath")]
    [Label("MCarnival Death", 1)]
    MCarnivalDeath = 351,

    /// <summary>Carnival member left.</summary>
    [Label("LP_MCarnivalMemberOut")]
    [Label("MCarnival Member Out", 1)]
    MCarnivalMemberOut = 352,

    /// <summary>Carnival game result.</summary>
    [Label("LP_MCarnivalGameResult")]
    [Label("MCarnival Game Result", 1)]
    MCarnivalGameResult = 353,

    /// <summary>Arena score.</summary>
    [Label("LP_ArenaScore")]
    [Label("Arena Score", 1)]
    ArenaScore = 354,

    /// <summary>Battlefield entered.</summary>
    [Label("LP_BattlefieldEnter")]
    [Label("Battlefield Enter", 1)]
    BattlefieldEnter = 355,

    /// <summary>Battlefield score.</summary>
    [Label("LP_BattlefieldScore")]
    [Label("Battlefield Score", 1)]
    BattlefieldScore = 356,

    /// <summary>Battlefield team changed.</summary>
    [Label("LP_BattlefieldTeamChanged")]
    [Label("Battlefield Team Changed", 1)]
    BattlefieldTeamChanged = 357,

    /// <summary>Witch Tower score.</summary>
    [Label("LP_WitchtowerScore")]
    [Label("Witchtower Score", 1)]
    WitchtowerScore = 358,

    /// <summary>Horntail timer.</summary>
    [Label("LP_HontaleTimer")]
    [Label("Hontale Timer", 1)]
    HontaleTimer = 359,

    /// <summary>Chaos Zakum timer.</summary>
    [Label("LP_ChaosZakumTimer")]
    [Label("Chaos Zakum Timer", 1)]
    ChaosZakumTimer = 360,

    /// <summary>Horntail timer (alt).</summary>
    [Label("LP_HontailTimer")]
    [Label("Hontail Timer", 1)]
    HontailTimer = 361,

    /// <summary>Zakum timer.</summary>
    [Label("LP_ZakumTimer")]
    [Label("Zakum Timer", 1)]
    ZakumTimer = 362,

    /// <summary>NPC script message.</summary>
    [Label("LP_ScriptMessage")]
    [Label("Script Message", 1)]
    ScriptMessage = 363,

    /// <summary>Shop dialog opened.</summary>
    [Label("LP_OpenShopDlg")]
    [Label("Open Shop Dlg", 1)]
    OpenShopDlg = 364,

    /// <summary>Shop result.</summary>
    [Label("LP_ShopResult")]
    [Label("Shop Result", 1)]
    ShopResult = 365,

    /// <summary>Admin shop result.</summary>
    [Label("LP_AdminShopResult")]
    [Label("Admin Shop Result", 1)]
    AdminShopResult = 366,

    /// <summary>Admin shop commodity.</summary>
    [Label("LP_AdminShopCommodity")]
    [Label("Admin Shop Commodity", 1)]
    AdminShopCommodity = 367,

    /// <summary>Storage result.</summary>
    [Label("LP_TrunkResult")]
    [Label("Trunk Result", 1)]
    TrunkResult = 368,

    /// <summary>Bank withdraw all.</summary>
    [Label("LP_StoreBankGetAllResult")]
    [Label("Store Bank Get All Result", 1)]
    StoreBankGetAllResult = 369,

    /// <summary>Bank result.</summary>
    [Label("LP_StoreBankResult")]
    [Label("Store Bank Result", 1)]
    StoreBankResult = 370,

    /// <summary>Rock-Paper-Scissors.</summary>
    [Label("LP_RPSGame")]
    [Label("RPS Game", 1)]
    RPSGame = 371,

    /// <summary>Messenger.</summary>
    [Label("LP_Messenger")]
    Messenger = 372,

    /// <summary>Mini-room.</summary>
    [Label("LP_MiniRoom")]
    [Label("Mini Room", 1)]
    MiniRoom = 373,

    /// <summary>Tournament.</summary>
    [Label("LP_Tournament")]
    Tournament = 374,

    /// <summary>Tournament bracket.</summary>
    [Label("LP_TournamentMatchTable")]
    [Label("Tournament Match Table", 1)]
    TournamentMatchTable = 375,

    /// <summary>Tournament prize set.</summary>
    [Label("LP_TournamentSetPrize")]
    [Label("Tournament Set Prize", 1)]
    TournamentSetPrize = 376,

    /// <summary>Tournament notice.</summary>
    [Label("LP_TournamentNoticeUEW")]
    [Label("Tournament Notice UEW", 1)]
    TournamentNoticeUEW = 377,

    /// <summary>Tournament avatar info.</summary>
    [Label("LP_TournamentAvatarInfo")]
    [Label("Tournament Avatar Info", 1)]
    TournamentAvatarInfo = 378,

    /// <summary>Wedding progress.</summary>
    [Label("LP_WeddingProgress")]
    [Label("Wedding Progress", 1)]
    WeddingProgress = 379,

    /// <summary>Wedding ceremony end.</summary>
    [Label("LP_WeddingCremonyEnd")]
    [Label("Wedding Cremony End", 1)]
    WeddingCremonyEnd = 380,

    /// <summary>Parcel delivery.</summary>
    [Label("LP_Parcel")]
    Parcel = 381,

    /// <summary>Cash charge params.</summary>
    [Label("LP_CashShopChargeParamResult")]
    [Label("Cash Shop Charge Param Result", 1)]
    CashShopChargeParamResult = 382,

    /// <summary>Cash balance query.</summary>
    [Label("LP_CashShopQueryCashResult")]
    [Label("Cash Shop Query Cash Result", 1)]
    CashShopQueryCashResult = 383,

    /// <summary>Cash item result.</summary>
    [Label("LP_CashShopCashItemResult")]
    [Label("Cash Shop Cash Item Result", 1)]
    CashShopCashItemResult = 384,

    /// <summary>Cash purchase EXP.</summary>
    [Label("LP_CashShopPurchaseExpChanged")]
    [Label("Cash Shop Purchase Exp Changed", 1)]
    CashShopPurchaseExpChanged = 385,

    /// <summary>Gift recipient info.</summary>
    [Label("LP_CashShopGiftMateInfoResult")]
    [Label("Cash Shop Gift Mate Info Result", 1)]
    CashShopGiftMateInfoResult = 386,

    /// <summary>Cash name check.</summary>
    [Label("LP_CashShopCheckDuplicatedIDResult")]
    [Label("Cash Shop Check Duplicated ID Result", 1)]
    CashShopCheckDuplicatedIDResult = 387,

    /// <summary>Name change check.</summary>
    [Label("LP_CashShopCheckNameChangePossibleResult")]
    [Label("Cash Shop Check Name Change Possible Result", 1)]
    CashShopCheckNameChangePossibleResult = 388,

    /// <summary>Cash character register.</summary>
    [Label("LP_CashShopRegisterNewCharacterResult")]
    [Label("Cash Shop Register New Character Result", 1)]
    CashShopRegisterNewCharacterResult = 389,

    /// <summary>World transfer check.</summary>
    [Label("LP_CashShopCheckTransferWorldPossibleResult")]
    [Label("Cash Shop Check Transfer World Possible Result", 1)]
    CashShopCheckTransferWorldPossibleResult = 390,

    /// <summary>Gachapon stamp result.</summary>
    [Label("LP_CashShopGachaponStampItemResult")]
    [Label("Cash Shop Gachapon Stamp Item Result", 1)]
    CashShopGachaponStampItemResult = 391,

    /// <summary>Cash Gachapon result.</summary>
    [Label("LP_CashShopCashItemGachaponResult")]
    [Label("Cash Shop Cash Item Gachapon Result", 1)]
    CashShopCashItemGachaponResult = 392,

    /// <summary>Gachapon open result.</summary>
    [Label("LP_CashShopCashGachaponOpenResult")]
    [Label("Cash Shop Cash Gachapon Open Result", 1)]
    CashShopCashGachaponOpenResult = 393,

    /// <summary>Maple Point changed.</summary>
    [Label("LP_ChangeMaplePointResult")]
    [Label("Change Maple Point Result", 1)]
    ChangeMaplePointResult = 394,

    /// <summary>Cash daily item.</summary>
    [Label("LP_CashShopOneADay")]
    [Label("Cash Shop One ADay", 1)]
    CashShopOneADay = 395,

    /// <summary>Free cash item notice.</summary>
    [Label("LP_CashShopNoticeFreeCashItem")]
    [Label("Cash Shop Notice Free Cash Item", 1)]
    CashShopNoticeFreeCashItem = 396,

    /// <summary>Member shop result.</summary>
    [Label("LP_CashShopMemberShopResult")]
    [Label("Cash Shop Member Shop Result", 1)]
    CashShopMemberShopResult = 397,

    /// <summary>Key bindings init.</summary>
    [Label("LP_FuncKeyMappedInit")]
    [Label("Func Key Mapped Init", 1)]
    FuncKeyMappedInit = 398,

    /// <summary>Pet auto-consume init.</summary>
    [Label("LP_PetConsumeItemInit")]
    [Label("Pet Consume Item Init", 1)]
    PetConsumeItemInit = 399,

    /// <summary>Pet MP consume init.</summary>
    [Label("LP_PetConsumeMPItemInit")]
    [Label("Pet Consume MP Item Init", 1)]
    PetConsumeMPItemInit = 400,

    /// <summary>SSN check result.</summary>
    [Label("LP_CheckSSN2OnCreateNewCharacterResult")]
    [Label("Check SSN2On Create New Character Result", 1)]
    CheckSSN2OnCreateNewCharacterResult = 401,

    /// <summary>SPW creation check.</summary>
    [Label("LP_CheckSPWOnCreateNewCharacterResult")]
    [Label("Check SPW On Create New Character Result", 1)]
    CheckSPWOnCreateNewCharacterResult = 402,

    /// <summary>First SSN check.</summary>
    [Label("LP_FirstSSNOnCreateNewCharacterResult")]
    [Label("First SSN On Create New Character Result", 1)]
    FirstSSNOnCreateNewCharacterResult = 403,

    /// <summary>Maple TV updated.</summary>
    [Label("LP_MapleTVUpdateMessage")]
    [Label("Maple TV Update Message", 1)]
    MapleTVUpdateMessage = 405,

    /// <summary>Maple TV cleared.</summary>
    [Label("LP_MapleTVClearMessage")]
    [Label("Maple TV Clear Message", 1)]
    MapleTVClearMessage = 406,

    /// <summary>Maple TV send result.</summary>
    [Label("LP_MapleTVSendMessageResult")]
    [Label("Maple TV Send Message Result", 1)]
    MapleTVSendMessageResult = 407,

    /// <summary>Flash event changed.</summary>
    [Label("LP_BroadSetFlashChangeEvent")]
    [Label("Broad Set Flash Change Event", 1)]
    BroadSetFlashChangeEvent = 408,

    /// <summary>ITC charge params.</summary>
    [Label("LP_ITCChargeParamResult")]
    [Label("ITC Charge Param Result", 1)]
    ITCChargeParamResult = 410,

    /// <summary>ITC cash query.</summary>
    [Label("LP_ITCQueryCashResult")]
    [Label("ITC Query Cash Result", 1)]
    ITCQueryCashResult = 411,

    /// <summary>ITC item result.</summary>
    [Label("LP_ITCNormalItemResult")]
    [Label("ITC Normal Item Result", 1)]
    ITCNormalItemResult = 412,

    /// <summary>Cash shop name check.</summary>
    [Label("LP_CheckDuplicatedIDResultInCS")]
    [Label("Check Duplicated ID Result In CS", 1)]
    CheckDuplicatedIDResultInCS = 413,

    /// <summary>Cash shop char created.</summary>
    [Label("LP_CreateNewCharacterResultInCS")]
    [Label("Create New Character Result In CS", 1)]
    CreateNewCharacterResultInCS = 414,

    /// <summary>Cash shop char failed.</summary>
    [Label("LP_CreateNewCharacterFailInCS")]
    [Label("Create New Character Fail In CS", 1)]
    CreateNewCharacterFailInCS = 415,

    /// <summary>Character sale.</summary>
    [Label("LP_CharacterSale")]
    [Label("Character Sale", 1)]
    CharacterSale = 416,

    /// <summary>Golden Hammer start.</summary>
    /// <remarks>Documented original client typo: "GoldHammere" → "GoldHammer"; see typos.md.</remarks>
    [Label("LP_GoldHammere_s")]
    GoldHammer_s = 417,

    /// <summary>Golden Hammer result.</summary>
    [Label("LP_GoldHammerResult")]
    [Label("Gold Hammer Result", 1)]
    GoldHammerResult = 418,

    /// <summary>Golden Hammer end.</summary>
    /// <remarks>Documented original client typo: "GoldHammere" → "GoldHammer"; see typos.md.</remarks>
    [Label("LP_GoldHammere_e")]
    GoldHammer_e = 419,

    /// <summary>Battle record start.</summary>
    [Label("LP_BattleRecord_s")]
    BattleRecord_s = 420,

    /// <summary>DoT damage info.</summary>
    [Label("LP_BattleRecordDotDamageInfo")]
    [Label("Battle Record Dot Damage Info", 1)]
    BattleRecordDotDamageInfo = 421,

    /// <summary>Battle record result.</summary>
    [Label("LP_BattleRecordRequestResult")]
    [Label("Battle Record Request Result", 1)]
    BattleRecordRequestResult = 422,

    /// <summary>Battle record end.</summary>
    [Label("LP_BattleRecord_e")]
    BattleRecord_e = 423,

    /// <summary>Item upgrade start.</summary>
    [Label("LP_ItemUpgrade_s")]
    ItemUpgrade_s = 424,

    /// <summary>Item upgrade result.</summary>
    [Label("LP_ItemUpgradeResult")]
    [Label("Item Upgrade Result", 1)]
    ItemUpgradeResult = 425,

    /// <summary>Item upgrade failed.</summary>
    [Label("LP_ItemUpgradeFail")]
    [Label("Item Upgrade Fail", 1)]
    ItemUpgradeFail = 426,

    /// <summary>Item upgrade end.</summary>
    [Label("LP_ItemUpgrade_e")]
    ItemUpgrade_e = 427,

    /// <summary>Vega Scroll start.</summary>
    [Label("LP_Vega_s")]
    Vega_s = 428,

    /// <summary>Vega Scroll result.</summary>
    [Label("LP_VegaResult")]
    [Label("Vega Result", 1)]
    VegaResult = 429,

    /// <summary>Vega Scroll failed.</summary>
    [Label("LP_VegaFail")]
    [Label("Vega Fail", 1)]
    VegaFail = 430,

    /// <summary>Vega Scroll end.</summary>
    [Label("LP_Vega_e")]
    Vega_e = 431,

    /// <summary>Logout gift.</summary>
    [Label("LP_LogoutGift")]
    [Label("Logout Gift", 1)]
    LogoutGift = 432,

    /// <summary>Opcode count sentinel.</summary>
    [Label("LP_NO")]
    NO = 433,
}
