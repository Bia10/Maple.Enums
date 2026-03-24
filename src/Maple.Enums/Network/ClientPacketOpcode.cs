using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Client-to-server (recv) packet opcodes.
/// </summary>
public enum ClientPacketOpcode : ushort
{
    /// <summary>Login authentication.</summary>
    [Label("CP_CheckPassword")]
    [Label("Check Password", 1)]
    CheckPassword = 1,

    /// <summary>Guest login.</summary>
    [Label("CP_GuestIDLogin")]
    [Label("Guest ID Login", 1)]
    GuestIDLogin = 2,

    /// <summary>Account info request.</summary>
    [Label("CP_AccountInfoRequest")]
    [Label("Account Info Request", 1)]
    AccountInfoRequest = 3,

    /// <summary>World list request.</summary>
    [Label("CP_WorldInfoRequest")]
    [Label("World Info Request", 1)]
    WorldInfoRequest = 4,

    /// <summary>Select world.</summary>
    [Label("CP_SelectWorld")]
    [Label("Select World", 1)]
    SelectWorld = 5,

    /// <summary>Check user limit.</summary>
    [Label("CP_CheckUserLimit")]
    [Label("Check User Limit", 1)]
    CheckUserLimit = 6,

    /// <summary>EULA confirmation.</summary>
    [Label("CP_ConfirmEULA")]
    [Label("Confirm EULA", 1)]
    ConfirmEULA = 7,

    /// <summary>Set account gender.</summary>
    [Label("CP_SetGender")]
    [Label("Set Gender", 1)]
    SetGender = 8,

    /// <summary>Check PIN code.</summary>
    [Label("CP_CheckPinCode")]
    [Label("Check Pin Code", 1)]
    CheckPinCode = 9,

    /// <summary>Update PIN code.</summary>
    [Label("CP_UpdatePinCode")]
    [Label("Update Pin Code", 1)]
    UpdatePinCode = 10,

    /// <summary>World info request.</summary>
    [Label("CP_WorldRequest")]
    [Label("World Request", 1)]
    WorldRequest = 11,

    /// <summary>Logout from world.</summary>
    [Label("CP_LogoutWorld")]
    [Label("Logout World", 1)]
    LogoutWorld = 12,

    /// <summary>View all characters.</summary>
    [Label("CP_ViewAllChar")]
    [Label("View All Char", 1)]
    ViewAllChar = 13,

    /// <summary>Select character via VAC.</summary>
    [Label("CP_SelectCharacterByVAC")]
    [Label("Select Character By VAC", 1)]
    SelectCharacterByVAC = 14,

    /// <summary>Set VAC flag.</summary>
    [Label("CP_VACFlagSet")]
    [Label("VAC Flag Set", 1)]
    VACFlagSet = 15,

    /// <summary>Check name change eligibility.</summary>
    [Label("CP_CheckNameChangePossible")]
    [Label("Check Name Change Possible", 1)]
    CheckNameChangePossible = 16,

    /// <summary>Register new character.</summary>
    [Label("CP_RegisterNewCharacter")]
    [Label("Register New Character", 1)]
    RegisterNewCharacter = 17,

    /// <summary>Check world transfer eligibility.</summary>
    [Label("CP_CheckTransferWorldPossible")]
    [Label("Check Transfer World Possible", 1)]
    CheckTransferWorldPossible = 18,

    /// <summary>Select character.</summary>
    [Label("CP_SelectCharacter")]
    [Label("Select Character", 1)]
    SelectCharacter = 19,

    /// <summary>Channel migration.</summary>
    [Label("CP_MigrateIn")]
    [Label("Migrate In", 1)]
    MigrateIn = 20,

    /// <summary>Check duplicate character name.</summary>
    [Label("CP_CheckDuplicatedID")]
    [Label("Check Duplicated ID", 1)]
    CheckDuplicatedID = 21,

    /// <summary>Create new character.</summary>
    [Label("CP_CreateNewCharacter")]
    [Label("Create New Character", 1)]
    CreateNewCharacter = 22,

    /// <summary>Create character in Cash Shop.</summary>
    [Label("CP_CreateNewCharacterInCS")]
    [Label("Create New Character In CS", 1)]
    CreateNewCharacterInCS = 23,

    /// <summary>Delete character.</summary>
    [Label("CP_DeleteCharacter")]
    [Label("Delete Character", 1)]
    DeleteCharacter = 24,

    /// <summary>Keep-alive acknowledgement.</summary>
    [Label("CP_AliveAck")]
    [Label("Alive Ack", 1)]
    AliveAck = 25,

    /// <summary>Client exception log.</summary>
    [Label("CP_ExceptionLog")]
    [Label("Exception Log", 1)]
    ExceptionLog = 26,

    /// <summary>Security packet.</summary>
    [Label("CP_SecurityPacket")]
    [Label("Security Packet", 1)]
    SecurityPacket = 27,

    /// <summary>Enable second password.</summary>
    [Label("CP_EnableSPWRequest")]
    [Label("Enable SPW Request", 1)]
    EnableSPWRequest = 28,

    /// <summary>Check second password.</summary>
    [Label("CP_CheckSPWRequest")]
    [Label("Check SPW Request", 1)]
    CheckSPWRequest = 29,

    /// <summary>Enable second password via VAC.</summary>
    [Label("CP_EnableSPWRequestByACV")]
    [Label("Enable SPW Request By ACV", 1)]
    EnableSPWRequestByACV = 30,

    /// <summary>Check second password via VAC.</summary>
    [Label("CP_CheckSPWRequestByACV")]
    [Label("Check SPW Request By ACV", 1)]
    CheckSPWRequestByACV = 31,

    /// <summary>Check OTP.</summary>
    [Label("CP_CheckOTPRequest")]
    [Label("Check OTP Request", 1)]
    CheckOTPRequest = 32,

    /// <summary>OTP check for character deletion.</summary>
    [Label("CP_CheckDeleteCharacterOTP")]
    [Label("Check Delete Character OTP", 1)]
    CheckDeleteCharacterOTP = 33,

    /// <summary>Create security handle.</summary>
    [Label("CP_CreateSecurityHandle")]
    [Label("Create Security Handle", 1)]
    CreateSecurityHandle = 34,

    /// <summary>SSO error log.</summary>
    [Label("CP_SSOErrorLog")]
    [Label("SSO Error Log", 1)]
    SSOErrorLog = 35,

    /// <summary>Client crash dump log.</summary>
    [Label("CP_ClientDumpLog")]
    [Label("Client Dump Log", 1)]
    ClientDumpLog = 36,

    /// <summary>Check extra character info.</summary>
    [Label("CP_CheckExtraCharInfo")]
    [Label("Check Extra Char Info", 1)]
    CheckExtraCharInfo = 37,

    /// <summary>Create character (extended).</summary>
    [Label("CP_CreateNewCharacter_Ex")]
    CreateNewCharacter_Ex = 38,

    /// <summary>Transfer to another field.</summary>
    [Label("CP_UserTransferFieldRequest")]
    [Label("User Transfer Field Request", 1)]
    UserTransferFieldRequest = 41,

    /// <summary>Transfer to another channel.</summary>
    [Label("CP_UserTransferChannelRequest")]
    [Label("User Transfer Channel Request", 1)]
    UserTransferChannelRequest = 42,

    /// <summary>Migrate to Cash Shop.</summary>
    [Label("CP_UserMigrateToCashShopRequest")]
    [Label("User Migrate To Cash Shop Request", 1)]
    UserMigrateToCashShopRequest = 43,

    /// <summary>Player movement.</summary>
    [Label("CP_UserMove")]
    [Label("User Move", 1)]
    UserMove = 44,

    /// <summary>Sit on chair.</summary>
    [Label("CP_UserSitRequest")]
    [Label("User Sit Request", 1)]
    UserSitRequest = 45,

    /// <summary>Sit on portable chair.</summary>
    [Label("CP_UserPortableChairSitRequest")]
    [Label("User Portable Chair Sit Request", 1)]
    UserPortableChairSitRequest = 46,

    /// <summary>Melee attack.</summary>
    [Label("CP_UserMeleeAttack")]
    [Label("User Melee Attack", 1)]
    UserMeleeAttack = 47,

    /// <summary>Ranged attack.</summary>
    [Label("CP_UserShootAttack")]
    [Label("User Shoot Attack", 1)]
    UserShootAttack = 48,

    /// <summary>Magic attack.</summary>
    [Label("CP_UserMagicAttack")]
    [Label("User Magic Attack", 1)]
    UserMagicAttack = 49,

    /// <summary>Body attack.</summary>
    [Label("CP_UserBodyAttack")]
    [Label("User Body Attack", 1)]
    UserBodyAttack = 50,

    /// <summary>Prepare moving shoot attack.</summary>
    [Label("CP_UserMovingShootAttackPrepare")]
    [Label("User Moving Shoot Attack Prepare", 1)]
    UserMovingShootAttackPrepare = 51,

    /// <summary>Player hit by damage.</summary>
    [Label("CP_UserHit")]
    [Label("User Hit", 1)]
    UserHit = 52,

    /// <summary>PvP attack.</summary>
    [Label("CP_UserAttackUser")]
    [Label("User Attack User", 1)]
    UserAttackUser = 53,

    /// <summary>Chat message.</summary>
    [Label("CP_UserChat")]
    [Label("User Chat", 1)]
    UserChat = 54,

    /// <summary>Close ad board.</summary>
    [Label("CP_UserADBoardClose")]
    [Label("User AD Board Close", 1)]
    UserADBoardClose = 55,

    /// <summary>Emotion expression.</summary>
    [Label("CP_UserEmotion")]
    [Label("User Emotion", 1)]
    UserEmotion = 56,

    /// <summary>Activate effect item.</summary>
    [Label("CP_UserActivateEffectItem")]
    [Label("User Activate Effect Item", 1)]
    UserActivateEffectItem = 57,

    /// <summary>Upgrade tomb effect.</summary>
    [Label("CP_UserUpgradeTombEffect")]
    [Label("User Upgrade Tomb Effect", 1)]
    UserUpgradeTombEffect = 58,

    /// <summary>Report current HP.</summary>
    [Label("CP_UserHP")]
    [Label("User HP", 1)]
    UserHP = 59,

    /// <summary>Premium service request.</summary>
    [Label("CP_Premium")]
    Premium = 60,

    /// <summary>Ban map by mob interaction.</summary>
    [Label("CP_UserBanMapByMob")]
    [Label("User Ban Map By Mob", 1)]
    UserBanMapByMob = 61,

    /// <summary>Set monster book cover.</summary>
    [Label("CP_UserMonsterBookSetCover")]
    [Label("User Monster Book Set Cover", 1)]
    UserMonsterBookSetCover = 62,

    /// <summary>Click NPC.</summary>
    [Label("CP_UserSelectNpc")]
    [Label("User Select Npc", 1)]
    UserSelectNpc = 63,

    /// <summary>Open remote shop.</summary>
    [Label("CP_UserRemoteShopOpenRequest")]
    [Label("User Remote Shop Open Request", 1)]
    UserRemoteShopOpenRequest = 64,

    /// <summary>NPC script dialogue answer.</summary>
    [Label("CP_UserScriptMessageAnswer")]
    [Label("User Script Message Answer", 1)]
    UserScriptMessageAnswer = 65,

    /// <summary>NPC shop request.</summary>
    [Label("CP_UserShopRequest")]
    [Label("User Shop Request", 1)]
    UserShopRequest = 66,

    /// <summary>Storage trunk request.</summary>
    [Label("CP_UserTrunkRequest")]
    [Label("User Trunk Request", 1)]
    UserTrunkRequest = 67,

    /// <summary>Entrusted shop request.</summary>
    [Label("CP_UserEntrustedShopRequest")]
    [Label("User Entrusted Shop Request", 1)]
    UserEntrustedShopRequest = 68,

    /// <summary>Store bank request.</summary>
    [Label("CP_UserStoreBankRequest")]
    [Label("User Store Bank Request", 1)]
    UserStoreBankRequest = 69,

    /// <summary>Parcel delivery request.</summary>
    [Label("CP_UserParcelRequest")]
    [Label("User Parcel Request", 1)]
    UserParcelRequest = 70,

    /// <summary>Local effect trigger.</summary>
    [Label("CP_UserEffectLocal")]
    [Label("User Effect Local", 1)]
    UserEffectLocal = 71,

    /// <summary>Owl of Minerva scan.</summary>
    [Label("CP_ShopScannerRequest")]
    [Label("Shop Scanner Request", 1)]
    ShopScannerRequest = 72,

    /// <summary>Shop link request.</summary>
    [Label("CP_ShopLinkRequest")]
    [Label("Shop Link Request", 1)]
    ShopLinkRequest = 73,

    /// <summary>Admin shop request.</summary>
    [Label("CP_AdminShopRequest")]
    [Label("Admin Shop Request", 1)]
    AdminShopRequest = 74,

    /// <summary>Gather inventory items.</summary>
    [Label("CP_UserGatherItemRequest")]
    [Label("User Gather Item Request", 1)]
    UserGatherItemRequest = 75,

    /// <summary>Sort inventory items.</summary>
    [Label("CP_UserSortItemRequest")]
    [Label("User Sort Item Request", 1)]
    UserSortItemRequest = 76,

    /// <summary>Move inventory slot.</summary>
    [Label("CP_UserChangeSlotPositionRequest")]
    [Label("User Change Slot Position Request", 1)]
    UserChangeSlotPositionRequest = 77,

    /// <summary>Use stat-change item.</summary>
    [Label("CP_UserStatChangeItemUseRequest")]
    [Label("User Stat Change Item Use Request", 1)]
    UserStatChangeItemUseRequest = 78,

    /// <summary>Cancel stat-change item.</summary>
    [Label("CP_UserStatChangeItemCancelRequest")]
    [Label("User Stat Change Item Cancel Request", 1)]
    UserStatChangeItemCancelRequest = 79,

    /// <summary>Chair stat change request.</summary>
    [Label("CP_UserStatChangeByPortableChairRequest")]
    [Label("User Stat Change By Portable Chair Request", 1)]
    UserStatChangeByPortableChairRequest = 80,

    /// <summary>Use mob summon item.</summary>
    [Label("CP_UserMobSummonItemUseRequest")]
    [Label("User Mob Summon Item Use Request", 1)]
    UserMobSummonItemUseRequest = 81,

    /// <summary>Use pet food.</summary>
    [Label("CP_UserPetFoodItemUseRequest")]
    [Label("User Pet Food Item Use Request", 1)]
    UserPetFoodItemUseRequest = 82,

    /// <summary>Use taming mob food.</summary>
    [Label("CP_UserTamingMobFoodItemUseRequest")]
    [Label("User Taming Mob Food Item Use Request", 1)]
    UserTamingMobFoodItemUseRequest = 83,

    /// <summary>Use script item.</summary>
    [Label("CP_UserScriptItemUseRequest")]
    [Label("User Script Item Use Request", 1)]
    UserScriptItemUseRequest = 84,

    /// <summary>Use cash consume item.</summary>
    [Label("CP_UserConsumeCashItemUseRequest")]
    [Label("User Consume Cash Item Use Request", 1)]
    UserConsumeCashItemUseRequest = 85,

    /// <summary>Destroy pet item.</summary>
    [Label("CP_UserDestroyPetItemRequest")]
    [Label("User Destroy Pet Item Request", 1)]
    UserDestroyPetItemRequest = 86,

    /// <summary>Use bridle item.</summary>
    [Label("CP_UserBridleItemUseRequest")]
    [Label("User Bridle Item Use Request", 1)]
    UserBridleItemUseRequest = 87,

    /// <summary>Use skill book.</summary>
    [Label("CP_UserSkillLearnItemUseRequest")]
    [Label("User Skill Learn Item Use Request", 1)]
    UserSkillLearnItemUseRequest = 88,

    /// <summary>Use skill reset scroll.</summary>
    [Label("CP_UserSkillResetItemUseRequest")]
    [Label("User Skill Reset Item Use Request", 1)]
    UserSkillResetItemUseRequest = 89,

    /// <summary>Use shop scanner item.</summary>
    [Label("CP_UserShopScannerItemUseRequest")]
    [Label("User Shop Scanner Item Use Request", 1)]
    UserShopScannerItemUseRequest = 90,

    /// <summary>Use map transfer item.</summary>
    [Label("CP_UserMapTransferItemUseRequest")]
    [Label("User Map Transfer Item Use Request", 1)]
    UserMapTransferItemUseRequest = 91,

    /// <summary>Use portal scroll.</summary>
    [Label("CP_UserPortalScrollUseRequest")]
    [Label("User Portal Scroll Use Request", 1)]
    UserPortalScrollUseRequest = 92,

    /// <summary>Use upgrade scroll.</summary>
    [Label("CP_UserUpgradeItemUseRequest")]
    [Label("User Upgrade Item Use Request", 1)]
    UserUpgradeItemUseRequest = 93,

    /// <summary>Use hyper upgrade scroll.</summary>
    [Label("CP_UserHyperUpgradeItemUseRequest")]
    [Label("User Hyper Upgrade Item Use Request", 1)]
    UserHyperUpgradeItemUseRequest = 94,

    /// <summary>Use item option upgrade.</summary>
    [Label("CP_UserItemOptionUpgradeItemUseRequest")]
    [Label("User Item Option Upgrade Item Use Request", 1)]
    UserItemOptionUpgradeItemUseRequest = 95,

    /// <summary>Use UI-opening item.</summary>
    [Label("CP_UserUIOpenItemUseRequest")]
    [Label("User UI Open Item Use Request", 1)]
    UserUIOpenItemUseRequest = 96,

    /// <summary>Release item seal.</summary>
    [Label("CP_UserItemReleaseRequest")]
    [Label("User Item Release Request", 1)]
    UserItemReleaseRequest = 97,

    /// <summary>Assign ability point.</summary>
    [Label("CP_UserAbilityUpRequest")]
    [Label("User Ability Up Request", 1)]
    UserAbilityUpRequest = 98,

    /// <summary>Mass ability point assignment.</summary>
    [Label("CP_UserAbilityMassUpRequest")]
    [Label("User Ability Mass Up Request", 1)]
    UserAbilityMassUpRequest = 99,

    /// <summary>Change stat request.</summary>
    [Label("CP_UserChangeStatRequest")]
    [Label("User Change Stat Request", 1)]
    UserChangeStatRequest = 100,

    /// <summary>Change stat by item option.</summary>
    [Label("CP_UserChangeStatRequestByItemOption")]
    [Label("User Change Stat Request By Item Option", 1)]
    UserChangeStatRequestByItemOption = 101,

    /// <summary>Skill level up.</summary>
    [Label("CP_UserSkillUpRequest")]
    [Label("User Skill Up Request", 1)]
    UserSkillUpRequest = 102,

    /// <summary>Use skill.</summary>
    [Label("CP_UserSkillUseRequest")]
    [Label("User Skill Use Request", 1)]
    UserSkillUseRequest = 103,

    /// <summary>Cancel skill.</summary>
    [Label("CP_UserSkillCancelRequest")]
    [Label("User Skill Cancel Request", 1)]
    UserSkillCancelRequest = 104,

    /// <summary>Prepare skill.</summary>
    [Label("CP_UserSkillPrepareRequest")]
    [Label("User Skill Prepare Request", 1)]
    UserSkillPrepareRequest = 105,

    /// <summary>Drop meso.</summary>
    [Label("CP_UserDropMoneyRequest")]
    [Label("User Drop Money Request", 1)]
    UserDropMoneyRequest = 106,

    /// <summary>Give fame.</summary>
    [Label("CP_UserGivePopularityRequest")]
    [Label("User Give Popularity Request", 1)]
    UserGivePopularityRequest = 107,

    /// <summary>Party request (user context).</summary>
    [Label("CP_UserPartyRequest")]
    [Label("User Party Request", 1)]
    UserPartyRequest = 108,

    /// <summary>View character info.</summary>
    [Label("CP_UserCharacterInfoRequest")]
    [Label("User Character Info Request", 1)]
    UserCharacterInfoRequest = 109,

    /// <summary>Activate/deactivate pet.</summary>
    [Label("CP_UserActivatePetRequest")]
    [Label("User Activate Pet Request", 1)]
    UserActivatePetRequest = 110,

    /// <summary>Update temporary stat.</summary>
    [Label("CP_UserTemporaryStatUpdateRequest")]
    [Label("User Temporary Stat Update Request", 1)]
    UserTemporaryStatUpdateRequest = 111,

    /// <summary>Portal script trigger.</summary>
    [Label("CP_UserPortalScriptRequest")]
    [Label("User Portal Script Request", 1)]
    UserPortalScriptRequest = 112,

    /// <summary>Portal teleport.</summary>
    [Label("CP_UserPortalTeleportRequest")]
    [Label("User Portal Teleport Request", 1)]
    UserPortalTeleportRequest = 113,

    /// <summary>Map transfer request.</summary>
    [Label("CP_UserMapTransferRequest")]
    [Label("User Map Transfer Request", 1)]
    UserMapTransferRequest = 114,

    /// <summary>Anti-macro item use.</summary>
    [Label("CP_UserAntiMacroItemUseRequest")]
    [Label("User Anti Macro Item Use Request", 1)]
    UserAntiMacroItemUseRequest = 115,

    /// <summary>Anti-macro skill use.</summary>
    [Label("CP_UserAntiMacroSkillUseRequest")]
    [Label("User Anti Macro Skill Use Request", 1)]
    UserAntiMacroSkillUseRequest = 116,

    /// <summary>Anti-macro answer.</summary>
    [Label("CP_UserAntiMacroQuestionResult")]
    [Label("User Anti Macro Question Result", 1)]
    UserAntiMacroQuestionResult = 117,

    /// <summary>Report/claim request.</summary>
    [Label("CP_UserClaimRequest")]
    [Label("User Claim Request", 1)]
    UserClaimRequest = 118,

    /// <summary>Quest request.</summary>
    [Label("CP_UserQuestRequest")]
    [Label("User Quest Request", 1)]
    UserQuestRequest = 119,

    /// <summary>Set damage calc stat.</summary>
    [Label("CP_UserCalcDamageStatSetRequest")]
    [Label("User Calc Damage Stat Set Request", 1)]
    UserCalcDamageStatSetRequest = 120,

    /// <summary>Throw grenade.</summary>
    [Label("CP_UserThrowGrenade")]
    [Label("User Throw Grenade", 1)]
    UserThrowGrenade = 121,

    /// <summary>Macro skill data changed.</summary>
    [Label("CP_UserMacroSysDataModified")]
    [Label("User Macro Sys Data Modified", 1)]
    UserMacroSysDataModified = 122,

    /// <summary>Use NPC-select item.</summary>
    [Label("CP_UserSelectNpcItemUseRequest")]
    [Label("User Select Npc Item Use Request", 1)]
    UserSelectNpcItemUseRequest = 123,

    /// <summary>Use lottery item.</summary>
    [Label("CP_UserLotteryItemUseRequest")]
    [Label("User Lottery Item Use Request", 1)]
    UserLotteryItemUseRequest = 124,

    /// <summary>Item Maker craft.</summary>
    [Label("CP_UserItemMakeRequest")]
    [Label("User Item Make Request", 1)]
    UserItemMakeRequest = 125,

    /// <summary>Sue/report character.</summary>
    [Label("CP_UserSueCharacterRequest")]
    [Label("User Sue Character Request", 1)]
    UserSueCharacterRequest = 126,

    /// <summary>Use Gachapon box.</summary>
    [Label("CP_UserUseGachaponBoxRequest")]
    [Label("User Use Gachapon Box Request", 1)]
    UserUseGachaponBoxRequest = 127,

    /// <summary>Use remote Gachapon.</summary>
    [Label("CP_UserUseGachaponRemoteRequest")]
    [Label("User Use Gachapon Remote Request", 1)]
    UserUseGachaponRemoteRequest = 128,

    /// <summary>Use Water of Life.</summary>
    [Label("CP_UserUseWaterOfLife")]
    [Label("User Use Water Of Life", 1)]
    UserUseWaterOfLife = 129,

    /// <summary>Repair all durability.</summary>
    [Label("CP_UserRepairDurabilityAll")]
    [Label("User Repair Durability All", 1)]
    UserRepairDurabilityAll = 130,

    /// <summary>Repair single item durability.</summary>
    [Label("CP_UserRepairDurability")]
    [Label("User Repair Durability", 1)]
    UserRepairDurability = 131,

    /// <summary>Set quest record state.</summary>
    [Label("CP_UserQuestRecordSetState")]
    [Label("User Quest Record Set State", 1)]
    UserQuestRecordSetState = 132,

    /// <summary>Client timer ended.</summary>
    [Label("CP_UserClientTimerEndRequest")]
    [Label("User Client Timer End Request", 1)]
    UserClientTimerEndRequest = 133,

    /// <summary>Follow character request.</summary>
    [Label("CP_UserFollowCharacterRequest")]
    [Label("User Follow Character Request", 1)]
    UserFollowCharacterRequest = 134,

    /// <summary>Stop following character.</summary>
    [Label("CP_UserFollowCharacterWithdraw")]
    [Label("User Follow Character Withdraw", 1)]
    UserFollowCharacterWithdraw = 135,

    /// <summary>Select PQ reward.</summary>
    [Label("CP_UserSelectPQReward")]
    [Label("User Select PQ Reward", 1)]
    UserSelectPQReward = 136,

    /// <summary>Request PQ reward.</summary>
    [Label("CP_UserRequestPQReward")]
    [Label("User Request PQ Reward", 1)]
    UserRequestPQReward = 137,

    /// <summary>Set passenger result.</summary>
    [Label("CP_SetPassenserResult")]
    [Label("Set Passenser Result", 1)]
    SetPassenserResult = 138,

    /// <summary>Broadcast message.</summary>
    [Label("CP_BroadcastMsg")]
    [Label("Broadcast Msg", 1)]
    BroadcastMsg = 139,

    /// <summary>Group chat message.</summary>
    [Label("CP_GroupMessage")]
    [Label("Group Message", 1)]
    GroupMessage = 140,

    /// <summary>Whisper message.</summary>
    [Label("CP_Whisper")]
    Whisper = 141,

    /// <summary>Couple chat message.</summary>
    [Label("CP_CoupleMessage")]
    [Label("Couple Message", 1)]
    CoupleMessage = 142,

    /// <summary>Messenger operation.</summary>
    [Label("CP_Messenger")]
    Messenger = 143,

    /// <summary>Mini room operation.</summary>
    [Label("CP_MiniRoom")]
    [Label("Mini Room", 1)]
    MiniRoom = 144,

    /// <summary>Party request.</summary>
    [Label("CP_PartyRequest")]
    [Label("Party Request", 1)]
    PartyRequest = 145,

    /// <summary>Party result.</summary>
    [Label("CP_PartyResult")]
    [Label("Party Result", 1)]
    PartyResult = 146,

    /// <summary>Expedition request.</summary>
    [Label("CP_ExpeditionRequest")]
    [Label("Expedition Request", 1)]
    ExpeditionRequest = 147,

    /// <summary>Party advertisement.</summary>
    [Label("CP_PartyAdverRequest")]
    [Label("Party Adver Request", 1)]
    PartyAdverRequest = 148,

    /// <summary>Guild request.</summary>
    [Label("CP_GuildRequest")]
    [Label("Guild Request", 1)]
    GuildRequest = 149,

    /// <summary>Guild result.</summary>
    [Label("CP_GuildResult")]
    [Label("Guild Result", 1)]
    GuildResult = 150,

    /// <summary>Admin command.</summary>
    [Label("CP_Admin")]
    Admin = 151,

    /// <summary>Server log.</summary>
    [Label("CP_Log")]
    Log = 152,

    /// <summary>Friend request.</summary>
    [Label("CP_FriendRequest")]
    [Label("Friend Request", 1)]
    FriendRequest = 153,

    /// <summary>Memo request.</summary>
    [Label("CP_MemoRequest")]
    [Label("Memo Request", 1)]
    MemoRequest = 154,

    /// <summary>Memo flag request.</summary>
    [Label("CP_MemoFlagRequest")]
    [Label("Memo Flag Request", 1)]
    MemoFlagRequest = 155,

    /// <summary>Enter mystic door.</summary>
    [Label("CP_EnterTownPortalRequest")]
    [Label("Enter Town Portal Request", 1)]
    EnterTownPortalRequest = 156,

    /// <summary>Enter open gate.</summary>
    [Label("CP_EnterOpenGateRequest")]
    [Label("Enter Open Gate Request", 1)]
    EnterOpenGateRequest = 157,

    /// <summary>Slide request.</summary>
    [Label("CP_SlideRequest")]
    [Label("Slide Request", 1)]
    SlideRequest = 158,

    /// <summary>Key binding changed.</summary>
    [Label("CP_FuncKeyMappedModified")]
    [Label("Func Key Mapped Modified", 1)]
    FuncKeyMappedModified = 159,

    /// <summary>Rock-Paper-Scissors game.</summary>
    [Label("CP_RPSGame")]
    [Label("RPS Game", 1)]
    RPSGame = 160,

    /// <summary>Marriage request.</summary>
    [Label("CP_MarriageRequest")]
    [Label("Marriage Request", 1)]
    MarriageRequest = 161,

    /// <summary>Wedding wish list.</summary>
    [Label("CP_WeddingWishListRequest")]
    [Label("Wedding Wish List Request", 1)]
    WeddingWishListRequest = 162,

    /// <summary>Wedding progress update.</summary>
    [Label("CP_WeddingProgress")]
    [Label("Wedding Progress", 1)]
    WeddingProgress = 163,

    /// <summary>Wedding guest blessing.</summary>
    [Label("CP_GuestBless")]
    [Label("Guest Bless", 1)]
    GuestBless = 164,

    /// <summary>Booby trap alert.</summary>
    [Label("CP_BoobyTrapAlert")]
    [Label("Booby Trap Alert", 1)]
    BoobyTrapAlert = 165,

    /// <summary>Begin stalking.</summary>
    [Label("CP_StalkBegin")]
    [Label("Stalk Begin", 1)]
    StalkBegin = 166,

    /// <summary>Alliance request.</summary>
    [Label("CP_AllianceRequest")]
    [Label("Alliance Request", 1)]
    AllianceRequest = 167,

    /// <summary>Alliance result.</summary>
    [Label("CP_AllianceResult")]
    [Label("Alliance Result", 1)]
    AllianceResult = 168,

    /// <summary>Family chart request.</summary>
    [Label("CP_FamilyChartRequest")]
    [Label("Family Chart Request", 1)]
    FamilyChartRequest = 169,

    /// <summary>Family info request.</summary>
    [Label("CP_FamilyInfoRequest")]
    [Label("Family Info Request", 1)]
    FamilyInfoRequest = 170,

    /// <summary>Register family junior.</summary>
    [Label("CP_FamilyRegisterJunior")]
    [Label("Family Register Junior", 1)]
    FamilyRegisterJunior = 171,

    /// <summary>Unregister family junior.</summary>
    [Label("CP_FamilyUnregisterJunior")]
    [Label("Family Unregister Junior", 1)]
    FamilyUnregisterJunior = 172,

    /// <summary>Unregister family parent.</summary>
    [Label("CP_FamilyUnregisterParent")]
    [Label("Family Unregister Parent", 1)]
    FamilyUnregisterParent = 173,

    /// <summary>Family join result.</summary>
    [Label("CP_FamilyJoinResult")]
    [Label("Family Join Result", 1)]
    FamilyJoinResult = 174,

    /// <summary>Use family privilege.</summary>
    [Label("CP_FamilyUsePrivilege")]
    [Label("Family Use Privilege", 1)]
    FamilyUsePrivilege = 175,

    /// <summary>Set family precept.</summary>
    [Label("CP_FamilySetPrecept")]
    [Label("Family Set Precept", 1)]
    FamilySetPrecept = 176,

    /// <summary>Family summon result.</summary>
    [Label("CP_FamilySummonResult")]
    [Label("Family Summon Result", 1)]
    FamilySummonResult = 177,

    /// <summary>Block chat user.</summary>
    [Label("CP_ChatBlockUserReq")]
    [Label("Chat Block User Req", 1)]
    ChatBlockUserReq = 178,

    /// <summary>Guild BBS operation.</summary>
    [Label("CP_GuildBBS")]
    [Label("Guild BBS", 1)]
    GuildBBS = 179,

    /// <summary>Migrate to ITC.</summary>
    [Label("CP_UserMigrateToITCRequest")]
    [Label("User Migrate To ITC Request", 1)]
    UserMigrateToITCRequest = 180,

    /// <summary>Use EXP-up item.</summary>
    [Label("CP_UserExpUpItemUseRequest")]
    [Label("User Exp Up Item Use Request", 1)]
    UserExpUpItemUseRequest = 181,

    /// <summary>Use temporary EXP item.</summary>
    [Label("CP_UserTempExpUseRequest")]
    [Label("User Temp Exp Use Request", 1)]
    UserTempExpUseRequest = 182,

    /// <summary>New Year card request.</summary>
    [Label("CP_NewYearCardRequest")]
    [Label("New Year Card Request", 1)]
    NewYearCardRequest = 183,

    /// <summary>Random morph request.</summary>
    [Label("CP_RandomMorphRequest")]
    [Label("Random Morph Request", 1)]
    RandomMorphRequest = 184,

    /// <summary>Cash item Gachapon request.</summary>
    [Label("CP_CashItemGachaponRequest")]
    [Label("Cash Item Gachapon Request", 1)]
    CashItemGachaponRequest = 185,

    /// <summary>Open cash Gachapon.</summary>
    [Label("CP_CashGachaponOpenRequest")]
    [Label("Cash Gachapon Open Request", 1)]
    CashGachaponOpenRequest = 186,

    /// <summary>Change Maple Points.</summary>
    [Label("CP_ChangeMaplePointRequest")]
    [Label("Change Maple Point Request", 1)]
    ChangeMaplePointRequest = 187,

    /// <summary>Talk to tutor NPC.</summary>
    [Label("CP_TalkToTutor")]
    [Label("Talk To Tutor", 1)]
    TalkToTutor = 188,

    /// <summary>Increment combo counter.</summary>
    [Label("CP_RequestIncCombo")]
    [Label("Request Inc Combo", 1)]
    RequestIncCombo = 189,

    /// <summary>Mob CRC key changed reply.</summary>
    [Label("CP_MobCrcKeyChangedReply")]
    [Label("Mob Crc Key Changed Reply", 1)]
    MobCrcKeyChangedReply = 190,

    /// <summary>Session value request.</summary>
    [Label("CP_RequestSessionValue")]
    [Label("Request Session Value", 1)]
    RequestSessionValue = 191,

    /// <summary>Update GM board.</summary>
    [Label("CP_UpdateGMBoard")]
    [Label("Update GM Board", 1)]
    UpdateGMBoard = 192,

    /// <summary>Account more info.</summary>
    [Label("CP_AccountMoreInfo")]
    [Label("Account More Info", 1)]
    AccountMoreInfo = 193,

    /// <summary>Find friend.</summary>
    [Label("CP_FindFriend")]
    [Label("Find Friend", 1)]
    FindFriend = 194,

    /// <summary>Accept AP/SP event.</summary>
    [Label("CP_AcceptAPSPEvent")]
    [Label("Accept APSP Event", 1)]
    AcceptAPSPEvent = 195,

    /// <summary>Use Dragon Ball box.</summary>
    [Label("CP_UserDragonBallBoxRequest")]
    [Label("User Dragon Ball Box Request", 1)]
    UserDragonBallBoxRequest = 196,

    /// <summary>Summon Dragon Ball.</summary>
    [Label("CP_UserDragonBallSummonRequest")]
    [Label("User Dragon Ball Summon Request", 1)]
    UserDragonBallSummonRequest = 197,

    /// <summary>Pet movement.</summary>
    [Label("CP_PetMove")]
    [Label("Pet Move", 1)]
    PetMove = 199,

    /// <summary>Pet action.</summary>
    [Label("CP_PetAction")]
    [Label("Pet Action", 1)]
    PetAction = 200,

    /// <summary>Pet interaction.</summary>
    [Label("CP_PetInteractionRequest")]
    [Label("Pet Interaction Request", 1)]
    PetInteractionRequest = 201,

    /// <summary>Pet drop pickup.</summary>
    [Label("CP_PetDropPickUpRequest")]
    [Label("Pet Drop Pick Up Request", 1)]
    PetDropPickUpRequest = 202,

    /// <summary>Pet stat-change item use.</summary>
    [Label("CP_PetStatChangeItemUseRequest")]
    [Label("Pet Stat Change Item Use Request", 1)]
    PetStatChangeItemUseRequest = 203,

    /// <summary>Update pet exception list.</summary>
    [Label("CP_PetUpdateExceptionListRequest")]
    [Label("Pet Update Exception List Request", 1)]
    PetUpdateExceptionListRequest = 204,

    /// <summary>Summon movement.</summary>
    [Label("CP_SummonedMove")]
    [Label("Summoned Move", 1)]
    SummonedMove = 207,

    /// <summary>Summon attack.</summary>
    [Label("CP_SummonedAttack")]
    [Label("Summoned Attack", 1)]
    SummonedAttack = 208,

    /// <summary>Summon hit.</summary>
    [Label("CP_SummonedHit")]
    [Label("Summoned Hit", 1)]
    SummonedHit = 209,

    /// <summary>Summon skill.</summary>
    [Label("CP_SummonedSkill")]
    [Label("Summoned Skill", 1)]
    SummonedSkill = 210,

    /// <summary>Remove object.</summary>
    [Label("CP_Remove")]
    Remove = 211,

    /// <summary>Dragon movement.</summary>
    [Label("CP_DragonMove")]
    [Label("Dragon Move", 1)]
    DragonMove = 214,

    /// <summary>Quickslot keys changed.</summary>
    [Label("CP_QuickslotKeyMappedModified")]
    [Label("Quickslot Key Mapped Modified", 1)]
    QuickslotKeyMappedModified = 216,

    /// <summary>Passive skill info update.</summary>
    [Label("CP_PassiveskillInfoUpdate")]
    [Label("Passiveskill Info Update", 1)]
    PassiveskillInfoUpdate = 217,

    /// <summary>Update screen setting.</summary>
    [Label("CP_UpdateScreenSetting")]
    [Label("Update Screen Setting", 1)]
    UpdateScreenSetting = 218,

    /// <summary>Targeted PvP attack.</summary>
    [Label("CP_UserAttackUser_Specific")]
    UserAttackUser_Specific = 219,

    /// <summary>Use Pam's Song.</summary>
    [Label("CP_UserPamsSongUseRequest")]
    [Label("User Pams Song Use Request", 1)]
    UserPamsSongUseRequest = 220,

    /// <summary>Quest guide request.</summary>
    [Label("CP_QuestGuideRequest")]
    [Label("Quest Guide Request", 1)]
    QuestGuideRequest = 221,

    /// <summary>Remove repeat effect.</summary>
    [Label("CP_UserRepeatEffectRemove")]
    [Label("User Repeat Effect Remove", 1)]
    UserRepeatEffectRemove = 222,

    /// <summary>Mob movement.</summary>
    [Label("CP_MobMove")]
    [Label("Mob Move", 1)]
    MobMove = 227,

    /// <summary>Mob control apply.</summary>
    [Label("CP_MobApplyCtrl")]
    [Label("Mob Apply Ctrl", 1)]
    MobApplyCtrl = 228,

    /// <summary>Mob drop pickup.</summary>
    [Label("CP_MobDropPickUpRequest")]
    [Label("Mob Drop Pick Up Request", 1)]
    MobDropPickUpRequest = 229,

    /// <summary>Mob hit by obstacle.</summary>
    [Label("CP_MobHitByObstacle")]
    [Label("Mob Hit By Obstacle", 1)]
    MobHitByObstacle = 230,

    /// <summary>Mob hit by mob.</summary>
    [Label("CP_MobHitByMob")]
    [Label("Mob Hit By Mob", 1)]
    MobHitByMob = 231,

    /// <summary>Mob self-destruct.</summary>
    [Label("CP_MobSelfDestruct")]
    [Label("Mob Self Destruct", 1)]
    MobSelfDestruct = 232,

    /// <summary>Mob attack mob.</summary>
    [Label("CP_MobAttackMob")]
    [Label("Mob Attack Mob", 1)]
    MobAttackMob = 233,

    /// <summary>Mob skill delay end.</summary>
    [Label("CP_MobSkillDelayEnd")]
    [Label("Mob Skill Delay End", 1)]
    MobSkillDelayEnd = 234,

    /// <summary>Mob time bomb end.</summary>
    [Label("CP_MobTimeBombEnd")]
    [Label("Mob Time Bomb End", 1)]
    MobTimeBombEnd = 235,

    /// <summary>Mob escort collision.</summary>
    [Label("CP_MobEscortCollision")]
    [Label("Mob Escort Collision", 1)]
    MobEscortCollision = 236,

    /// <summary>Request escort info.</summary>
    [Label("CP_MobRequestEscortInfo")]
    [Label("Mob Request Escort Info", 1)]
    MobRequestEscortInfo = 237,

    /// <summary>Mob escort stop end.</summary>
    [Label("CP_MobEscortStopEndRequest")]
    [Label("Mob Escort Stop End Request", 1)]
    MobEscortStopEndRequest = 238,

    /// <summary>NPC movement.</summary>
    [Label("CP_NpcMove")]
    [Label("Npc Move", 1)]
    NpcMove = 241,

    /// <summary>NPC special action.</summary>
    [Label("CP_NpcSpecialAction")]
    [Label("Npc Special Action", 1)]
    NpcSpecialAction = 242,

    /// <summary>Pick up drop.</summary>
    [Label("CP_DropPickUpRequest")]
    [Label("Drop Pick Up Request", 1)]
    DropPickUpRequest = 246,

    /// <summary>Hit reactor.</summary>
    [Label("CP_ReactorHit")]
    [Label("Reactor Hit", 1)]
    ReactorHit = 249,

    /// <summary>Touch reactor.</summary>
    [Label("CP_ReactorTouch")]
    [Label("Reactor Touch", 1)]
    ReactorTouch = 250,

    /// <summary>Request field obstacle status.</summary>
    [Label("CP_RequireFieldObstacleStatus")]
    [Label("Require Field Obstacle Status", 1)]
    RequireFieldObstacleStatus = 251,

    /// <summary>Start event.</summary>
    [Label("CP_EventStart")]
    [Label("Event Start", 1)]
    EventStart = 254,

    /// <summary>Hit snowball.</summary>
    [Label("CP_SnowBallHit")]
    [Label("Snow Ball Hit", 1)]
    SnowBallHit = 255,

    /// <summary>Touch snowball.</summary>
    [Label("CP_SnowBallTouch")]
    [Label("Snow Ball Touch", 1)]
    SnowBallTouch = 256,

    /// <summary>Hit coconut.</summary>
    [Label("CP_CoconutHit")]
    [Label("Coconut Hit", 1)]
    CoconutHit = 257,

    /// <summary>Tournament match table.</summary>
    [Label("CP_TournamentMatchTable")]
    [Label("Tournament Match Table", 1)]
    TournamentMatchTable = 258,

    /// <summary>Hit pulley.</summary>
    [Label("CP_PulleyHit")]
    [Label("Pulley Hit", 1)]
    PulleyHit = 259,

    /// <summary>Monster Carnival request.</summary>
    [Label("CP_MCarnivalRequest")]
    [Label("MCarnival Request", 1)]
    MCarnivalRequest = 262,

    /// <summary>Continent move state.</summary>
    [Label("CP_CONTISTATE")]
    CONTISTATE = 264,

    /// <summary>Invite party match.</summary>
    [Label("CP_INVITE_PARTY_MATCH")]
    INVITE_PARTY_MATCH = 266,

    /// <summary>Cancel party match invite.</summary>
    [Label("CP_CANCEL_INVITE_PARTY_MATCH")]
    CANCEL_INVITE_PARTY_MATCH = 267,

    /// <summary>Request foothold info.</summary>
    [Label("CP_RequestFootHoldInfo")]
    [Label("Request Foot Hold Info", 1)]
    RequestFootHoldInfo = 269,

    /// <summary>Foothold info.</summary>
    [Label("CP_FootHoldInfo")]
    [Label("Foot Hold Info", 1)]
    FootHoldInfo = 270,

    /// <summary>Cash Shop charge params.</summary>
    [Label("CP_CashShopChargeParamRequest")]
    [Label("Cash Shop Charge Param Request", 1)]
    CashShopChargeParamRequest = 273,

    /// <summary>Cash Shop query cash.</summary>
    [Label("CP_CashShopQueryCashRequest")]
    [Label("Cash Shop Query Cash Request", 1)]
    CashShopQueryCashRequest = 274,

    /// <summary>Cash Shop item request.</summary>
    [Label("CP_CashShopCashItemRequest")]
    [Label("Cash Shop Cash Item Request", 1)]
    CashShopCashItemRequest = 275,

    /// <summary>Cash Shop coupon check.</summary>
    [Label("CP_CashShopCheckCouponRequest")]
    [Label("Cash Shop Check Coupon Request", 1)]
    CashShopCheckCouponRequest = 276,

    /// <summary>Cash Shop gift recipient info.</summary>
    [Label("CP_CashShopGiftMateInfoRequest")]
    [Label("Cash Shop Gift Mate Info Request", 1)]
    CashShopGiftMateInfoRequest = 277,

    /// <summary>SSN2 check on character creation.</summary>
    [Label("CP_CheckSSN2OnCreateNewCharacter")]
    [Label("Check SSN2On Create New Character", 1)]
    CheckSSN2OnCreateNewCharacter = 279,

    /// <summary>SPW check on character creation.</summary>
    [Label("CP_CheckSPWOnCreateNewCharacter")]
    [Label("Check SPW On Create New Character", 1)]
    CheckSPWOnCreateNewCharacter = 280,

    /// <summary>First SSN on character creation.</summary>
    [Label("CP_FirstSSNOnCreateNewCharacter")]
    [Label("First SSN On Create New Character", 1)]
    FirstSSNOnCreateNewCharacter = 281,

    /// <summary>Raise UI refresh.</summary>
    [Label("CP_RaiseRefesh")]
    [Label("Raise Refesh", 1)]
    RaiseRefesh = 283,

    /// <summary>Raise UI state.</summary>
    [Label("CP_RaiseUIState")]
    [Label("Raise UI State", 1)]
    RaiseUIState = 284,

    /// <summary>Raise increase EXP.</summary>
    [Label("CP_RaiseIncExp")]
    [Label("Raise Inc Exp", 1)]
    RaiseIncExp = 285,

    /// <summary>Raise add piece.</summary>
    [Label("CP_RaiseAddPiece")]
    [Label("Raise Add Piece", 1)]
    RaiseAddPiece = 286,

    /// <summary>Send mate mail.</summary>
    [Label("CP_SendMateMail")]
    [Label("Send Mate Mail", 1)]
    SendMateMail = 288,

    /// <summary>Guild board auth key.</summary>
    [Label("CP_RequestGuildBoardAuthKey")]
    [Label("Request Guild Board Auth Key", 1)]
    RequestGuildBoardAuthKey = 289,

    /// <summary>Consult auth key.</summary>
    [Label("CP_RequestConsultAuthKey")]
    [Label("Request Consult Auth Key", 1)]
    RequestConsultAuthKey = 290,

    /// <summary>Class competition auth key.</summary>
    [Label("CP_RequestClassCompetitionAuthKey")]
    [Label("Request Class Competition Auth Key", 1)]
    RequestClassCompetitionAuthKey = 291,

    /// <summary>Web board auth key.</summary>
    [Label("CP_RequestWebBoardAuthKey")]
    [Label("Request Web Board Auth Key", 1)]
    RequestWebBoardAuthKey = 292,

    /// <summary>Gold Hammer request.</summary>
    [Label("CP_GoldHammerRequest")]
    [Label("Gold Hammer Request", 1)]
    GoldHammerRequest = 294,

    /// <summary>Gold Hammer complete.</summary>
    [Label("CP_GoldHammerComplete")]
    [Label("Gold Hammer Complete", 1)]
    GoldHammerComplete = 295,

    /// <summary>Item upgrade complete.</summary>
    [Label("CP_ItemUpgradeComplete")]
    [Label("Item Upgrade Complete", 1)]
    ItemUpgradeComplete = 296,

    /// <summary>Battle record on/off toggle.</summary>
    [Label("CP_BATTLERECORD_ONOFF_REQUEST")]
    BATTLERECORD_ONOFF_REQUEST = 299,

    /// <summary>Send Maple TV message.</summary>
    [Label("CP_MapleTVSendMessageRequest")]
    [Label("Maple TV Send Message Request", 1)]
    MapleTVSendMessageRequest = 302,

    /// <summary>Update Maple TV view count.</summary>
    [Label("CP_MapleTVUpdateViewCount")]
    [Label("Maple TV Update View Count", 1)]
    MapleTVUpdateViewCount = 303,

    /// <summary>ITC charge params.</summary>
    [Label("CP_ITCChargeParamRequest")]
    [Label("ITC Charge Param Request", 1)]
    ITCChargeParamRequest = 306,

    /// <summary>ITC query cash.</summary>
    [Label("CP_ITCQueryCashRequest")]
    [Label("ITC Query Cash Request", 1)]
    ITCQueryCashRequest = 307,

    /// <summary>ITC item request.</summary>
    [Label("CP_ITCItemRequest")]
    [Label("ITC Item Request", 1)]
    ITCItemRequest = 308,

    /// <summary>Check duplicate ID in Cash Shop.</summary>
    [Label("CP_CheckDuplicatedIDInCS")]
    [Label("Check Duplicated ID In CS", 1)]
    CheckDuplicatedIDInCS = 311,

    /// <summary>Logout gift selection.</summary>
    [Label("CP_LogoutGiftSelect")]
    [Label("Logout Gift Select", 1)]
    LogoutGiftSelect = 313,

    /// <summary>Sentinel / end marker.</summary>
    [Label("CP_NO")]
    NO = 314,
}
