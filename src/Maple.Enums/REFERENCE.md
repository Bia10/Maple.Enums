# Maple.Enums — Reverse-Engineering Reference

Provenance metadata for every enum whose origin was traced back to the
MapleStory **V95** client PDB (`game_types.h` unless noted otherwise).
Each row documents how the corresponding C# enum was identified,
its original naming convention, and approximate source location.

## Quick stats

- **287** enums total (+1: ShopCashType added after server comparison)
- **248** enums confirmed via V95 PDB
- **12** enums with partial V95 references
- **27** enums from alternative sources (WZ data, protocol analysis, EdelsteinExperimental)
  - 8 WZ-data sourced (GuildGrade, ItemAttackSpeed, ItemEnchantCategory, QuestArea, ReactorEventType, ReactorLayer, SkillSubType, SkinColor)

## Folder structure

All enum files are organised into domain subfolders. The `namespace Maple.Enums;`
declaration is identical in every file — subfolders are physical organisation only
and do not introduce sub-namespaces.

| Folder | Domain |
|--------|--------|
| `Auth/` | Authentication, login, PIN, security packets |
| `Admin/` | Admin commands, admin shop, locale, hacking detection, region codes |
| `Character/` | Stats, appearance, jobs, movement actions, forced/temporary stats |
| `Combat/` | Attacks, damage, skills, elements, summoned units, weapon types |
| `Economy/` | Meso logs, drop ownership, price logs, rate types, inventory logs |
| `Event/` | Mini-games, mini-rooms, carnival, anti-macro, seasonal events |
| `Field/` | Maps, portals, field limits, reactors, conti-move, dynamic objects |
| `Item/` | Inventory types, equipment, cash items, upgrades, crafting |
| `Life/` | Mobs, NPCs, boss IDs, taming, mob skills, mob stats |
| `NexonPlatform/` | Nexon Messenger SDK: guild types, user status, URL pages, reply/error codes |
| `Network/` | Client/server packet opcodes, transfer results, server messages |
| `Pet/` | Pet abilities, actions, effects, food results |
| `Quest/` | Quest states, icons, job flags, medals, day-of-week limits |
| `Shop/` | NPC shop, cash shop, entrusted shop, scanner, trunk, personal shop |
| `Social/` | Party, guild, friends, family, marriage, messenger, chat, whisper |
| `UI/` | Client-only: rendering, animation layers, cursor, effects, sound, fonts |

## Origin classification

Enums are classified by origin to indicate which are ground-truth client constants
and which are custom additions with no client-side equivalent.

### CLIENT_CONFIRMED — V95 PDB present (232 enums)

These enums exist verbatim in `game_types.h` recovered from the V95 client PDB.
Their types, prefixes, and member values are ground truth from the binary.

### CLIENT_PARTIAL — V95 reference only (8 enums)

Enum name and/or values reconstructed from indirect PDB evidence (field types,
WZ data corroborated against PDB structs, or adjacent symbols).  Values are correct
but the original C++ enum might not have been a named type.

`BackgroundType`, `ContiMoveState`, `FieldEffectType`, `Job`,
`MobTemporaryStatType`, `QuestJobExFlags`, `SkillId`, `TemporaryStatType`

### WZ_DATA — sourced from WZ content files (5 enums)

Not in the client binary's type system; values come from WZ content nodes that are
read at runtime.  A server implementation defines these based on WZ data, not the PDB.

| Enum | WZ source |
|------|-----------|
| `GuildGrade` | `Etc.wz/GuildSkill.img` |
| `ItemAttackSpeed` | `Character.wz` equip/`info/attackSpeed` |
| `ItemEnchantCategory` | equip item `info/enchantCategory` |
| `QuestArea` | Quest WZ area IDs |
| `ReactorEventType` | `Reactor.wz/{id}/{state}/{event}/type` |
| `ReactorLayer` | `Reactor.wz/{id}/info/layer` |
| `SkillSubType` | Skill WZ data |
| `SkinColor` | `Character.wz` |

### CUSTOM — no client equivalent (22 enums)

These enums have **no matching type in the V95 PDB**.  They were introduced by
EdelsteinExperimental or inferred from protocol analysis to support server-side
processing.  A clean re-implementation of the server would need to define them
independently.

PDB audit note: `AffectedArea`, `EquipSlot`, `LoginResult`, and `GuildGrade` all
appear as substring matches in `index.json`, but the matches are class names
(`AFFECTEDAREA` struct, `CWndGuildGrade` window, function names) — not enum type
definitions.  All four remain correctly classified as non-PDB.

**Server-logic custom enums:**
`AffectedAreaType`, `AttackType`, `ContiMoveStateTrigger`, `ContiMoveTarget`,
`ConversationMessageType`, `DropOwnType`, `EffectType`, `EquipSlot`,
`FieldLifeType`, `FieldMobAppearType`, `FieldMobLeaveType`, `FieldObjectType`,
`ItemOptionType`, `LoginResult`, `MessageType`, `ModifyInventoryOperationType`,
`ModifyStatForcedType`, `ModifyStatType`, `MoveActionDirection`,
`MovePathFragmentType`, `QuestAction`, `QuestJobFlags`, `QuestRequestType`,
`QuestResultType`, `RateType`

## Conventions

### `[Label]` index convention

- **Index 0** — V95 PDB name, preserved verbatim including any original typos
  (e.g. `ITEM_TRANSFROM_TYPE`, `ITEMVARIATION_PERPECT`, `AAT_TowHand`).
  Members with known PDB typos carry a `<remarks>` XML doc tag noting the correct spelling.
- **Index 1** — Human-readable display name (used by `EnumDisplayExtensions.GetDisplayLabel`).
  Omitted when the member name is already a single readable word (e.g. `Success`, `Blocked`,
  `Attack`). In that case `GetDisplayLabel` falls through to the member name automatically.
  This is intentional — labels are only added when the display text differs from the member name
  (compound names like `WhiteKnight` → `"White Knight"`).
- **Index 2+** — WZ codes, animation names, or alternate identifiers.

### Value literal conventions

- **`[Flags]` enums** — hexadecimal literals (`0x1`, `0x2`, `0x4`, …).  Hex is the
  standard notation for bitmasks because individual bit positions are immediately
  visible without mental arithmetic.
- **All other enums** — decimal literals (`0`, `1`, `2`, …).  Sequential identifiers
  (opcodes, state codes, type IDs) are clearer in decimal; there is no readability
  benefit to hex when the values are not bit patterns.

## Reference table

| Enum | PDB Status | PDB Type | Prefix | Location | Notes |
|------|-----------|----------|--------|----------|-------|
| `AccountMoreInfoOperation` | Confirmed | — | `AccountMoreInfo_*/FindFriend_*` | game_types.h | — |
| `AdminCommandType` | Confirmed | anonymous | `AP_*` | line ~7660 | — |
| `AdminLevel` | Confirmed | anonymous | `ADMIN_LEVEL_*` | line ~1706 | — |
| `AdminShopCommodityState` | Confirmed | anonymous | `AdminShopCommodity_*` | line ~17010 | — |
| `AdminShopOperation` | Confirmed | anonymous | `AdminShopReq_*/AdminShopRes_*` | line ~9435 | — |
| `AdminShopTradeResult` | Confirmed | anonymous | `AdminShopTradeFail_*` | line ~17000 | — |
| `AffectedAreaType` | No PDB | — | — | — | — |
| `AnimationLayerType` | Confirmed | anonymous | `AL_*` | line ~8081 | — |
| `AntiMacroOperation` | Confirmed | anonymous | `AntiMacroReq_*/AntiMacroRes_*` | line ~5390 | — |
| `AntiMacroRequestType` | Confirmed | anonymous | — | line ~5405 | — |
| `AttackActionType` | Confirmed | named: `AttactActionType` | `AAT_*` | line ~7578 | PDB typo: `Attact`; has sentinels |
| `AttackIndex` | Confirmed | anonymous | `AttackIndex_*` | line ~7870 | — |
| `AttackType` | No PDB | — | — | — | Source: EdelsteinExperimental |
| `AuraType` | Confirmed | anonymous | `AURA_*` | line ~3307 | — |
| `AuthOptionCode` | Confirmed | anonymous | `AuthOption_*` | line ~16144 | — |
| `AutoSpeakingType` | Confirmed | anonymous | `AUTOSPEAKING_*` | line ~5370 | — |
| `AvatarChangeFlag` | Confirmed | anonymous | `AVATAR_*` | line ~7658 | — |
| `BackgroundType` | V95 ref | — | — | — | — |
| `BattlefieldTeam` | Confirmed | anonymous | `BATTLEFIELD_TEAM_*` | line ~3391 | — |
| `BodyChangeType` | Confirmed | anonymous | `CHANGEBODY_*` | line ~8023 | — |
| `BossMobId` | Confirmed | — | — | line ~12673 | — |
| `BridleFailReason` | Confirmed | anonymous | `BRIDLE_FAIL_*` | line ~6767 | — |
| `BroadcastMessageType` | Confirmed | anonymous | `BM_*` | line ~5730 | — |
| `CakePieEventStep` | Confirmed | anonymous | `CakePieEvent_Step_*` | line ~6806 | — |
| `CashCommodityType` | Confirmed | — | — | game_types.h | — |
| `CashItemFailReason` | Confirmed | anonymous | `CashItemFailReason_*` | line ~16815 | — |
| `CashItemGachaponState` | Confirmed | anonymous | `CASHITEMGACHAPON_*` | line ~7470 | — |
| `CashItemOperation` | Confirmed | anonymous | `CashItemReq_*/CashItemRes_*` | line ~5010 | — |
| `CashItemType` | Confirmed | anonymous | `CIT_*` | line ~4945 | — |
| `CashLimitGoodsState` | Confirmed | anonymous | `CS_LimitGoodsState_*` | line ~16740 | — |
| `CashPetFoodResult` | Confirmed | anonymous | `CashPetFoodRes_*` | line ~5998 | — |
| `CashShopPurchaseType` | Confirmed | anonymous | `CS_PURCHASE_*` | line ~16563 | — |
| `CashStockState` | Confirmed | anonymous | `CS_StockState_*` | line ~16730 | — |
| `ClaimResult` | Confirmed | anonymous | `ClaimRes_*` | line ~5420 | — |
| `ClientErrorCode` | Confirmed | anonymous | `EC_*` | line ~4440 | — |
| `ClientPacketOpcode` | Confirmed | anonymous | `CP_*` | line ~1032 | — |
| `ColorTone` | Confirmed | — | — | line ~7530 | — |
| `ContiMoveState` | V95 ref | — | — | game_types.h | Value 2 unused |
| `ContiMoveStateTrigger` | No PDB | — | — | — | — |
| `ContiMoveTarget` | No PDB | — | — | — | — |
| `ConversationMessageType` | No PDB | — | — | — | — |
| `ConversationSpeakerFlags` | Confirmed | anonymous [Flags] | `SMP_*` | game_types.h | — |
| `CommodityModifyFlag` | Confirmed | anonymous | `CM_*` | line ~32 | — |
| `CoupleEffectType` | Confirmed | anonymous | `COUPLE_EFFECT_*` | line ~7720 | — |
| `CursorState` | Confirmed | anonymous | `CURSOR_STATE_*` | line ~4204 | — |
| `DamageInfoType` | Confirmed | anonymous | `DAMAGEINFO_*` | line ~9370 | — |
| `DamageUpgradeAttackType` | Confirmed | named: `DAMAGE_MODIFIED_BY_ITEM_UPGRADE_ATTACK_TYPE` | — | line ~13792 | — |
| `DamageUpgradeDefendType` | Confirmed | named: `DAMAGE_MODIFIED_BY_ITEM_UPGRADE_DEFEND_TYPE` | — | line ~13835 | — |
| `DayByDayType` | Confirmed | anonymous | `DAYBYDAY_*` | line ~9570 | — |
| `DragonActionType` | Confirmed | anonymous | `DRAGONACT_*` | line ~3617 | — |
| `DropOwnType` | No PDB | — | — | — | — |
| `DynamicObjectState` | Confirmed | — | `DYNAMIC_OBJ_STATE_*` | game_types.h | — |
| `Element` | Confirmed | unnamed | `ELEMENT_*` | line ~887 | — |
| `EffectType` | No PDB | — | — | — | — |
| `ElemResistanceTier` | Confirmed | named: `as` | `ELEMENT_ATTR_*` | line ~887 | — |
| `EmotionType` | Confirmed | anonymous | `EMT_*` | line ~3418 | — |
| `EnchantScrollCategory` | Confirmed | named: `ENCHANT_SCROLL_CATEGORY` | — | line ~8040 | — |
| `EntrustedShopOperation` | Confirmed | anonymous | `EntrustedShopReq_*/EntrustedShopRes_*/StoreBankReq_*/StoreBankRes_*` | line ~6070 | — |
| `EntrustedShopWithdrawResult` | Confirmed | anonymous | `ESWithdraw_*` | line ~16710 | — |
| `EquipCategoryType` | Confirmed | anonymous | `EQUIP_TYPE_*` | line ~9200 | — |
| `EquipSlot` | No PDB | — | — | — | — |
| `EquipUpgradeResult` | Confirmed | — | — | line ~11337 | — |
| `ExpeditionInviteResult` | Confirmed | anonymous | `ExpeditionInviteResult_*/ExpeditionJoinResult_*` | line ~16690 | — |
| `FamilyPrivilegeType` | Confirmed | — | `Type_*` | line ~1836 | — |
| `FamilyTreeNodeType` | Confirmed | — | `NODE_*` | game_types.h | — |
| `FieldAffectAreaType` | Confirmed | anonymous | `AffectArea_*` | line ~16674 | — |
| `FieldCubeType` | Confirmed | named: `FIELD_CUBE_TYPE` | — | line ~12944 | — |
| `FieldEventType` | Confirmed | anonymous | `EVENTTYPE_*` | line ~11593 | — |
| `FieldEffectType` | V95 ref | anonymous | `FieldEffect_*` | game_types.h | Typo: `RewordRullet` |
| `FieldLifeType` | No PDB | — | — | — | — |
| `FieldMobAppearType` | No PDB | — | — | — | Backing: sbyte |
| `FieldMobLeaveType` | No PDB | — | — | — | — |
| `FieldObjectType` | No PDB | — | — | — | — |
| `FollowState` | Confirmed | — | `FS_*` | game_types.h | — |
| `FontType` | Confirmed | named: `FONT_TYPE` | `FONT_*` | line ~905 | — |
| `ForcedStatFlag` | Confirmed | — | — | game_types.h | — |
| `FrequentActionType` | Confirmed | anonymous | `FREQUENT_ACTION_*` | line ~10634 | — |
| `FriendOperation` | Confirmed | anonymous | `FriendReq_*/FriendRes_*` | line ~4540 | — |
| `FuncKeyType` | Confirmed | named: `FUNCKEY_MAPPED` | — | line ~6470 | — |
| `GachaponMessageType` | Confirmed | — | `GACHAPON_MSGTYPE_*` | game_types.h | — |
| `GameObjectType` | Confirmed | anonymous | `GOT_*` | line ~16969 | — |
| `Gender` | Confirmed | unnamed | `GENDER_*` | line ~3838 | — |
| `GivePopularityResult` | Confirmed | anonymous | `GivePopularityRes_*` | line ~5870 | — |
| `GoldHammerResult` | Confirmed | anonymous | `GoldHammerRes_*` | line ~9230 | — |
| `GuildGrade` | No PDB | — | — | — | Source: Etc.wz GuildSkill.img |
| `GuildBBSOperation` | Confirmed | anonymous | `GuildBBS_*` | line ~9160 | — |
| `HackingAutoBlockReason` | Confirmed | anonymous | `HackingAutoBlockReason_*` | line ~790 | — |
| `HitPeriodType` | Confirmed | anonymous | `HitPeriod_*` | line ~7877 | — |
| `CharacterActionType` | Confirmed | anonymous | `ACT_*` | line ~2143 | — |
| `CharacterBodyType` | Confirmed | anonymous | — | game_types.h | — |
| `CharacterDataFlag` | Confirmed | anonymous | `DBCHAR_*` | line ~7100 | — |
| `CharacterStatFlag` | Confirmed | anonymous [Flags] | `CS_*` | line ~5360 | — |
| `ChatAvailability` | Confirmed | anonymous | `CHAT_*` | game_types.h | — |
| `ChatBalloonType` | Confirmed | anonymous | `CHATBALLOON_*` | line ~7690 | — |
| `ChatGroupType` | Confirmed | anonymous | `CG_*` | line ~8700 | — |
| `ChatMessageType` | Confirmed | anonymous | `CHAT_TYPE_*` | line ~3984 | — |
| `ChatTargetType` | Confirmed | anonymous | `ID_CHAT_TARGET_*` | line ~6510 | — |
| `IirRateCategory` | Confirmed | anonymous | `IIR_*` | line ~10799 | — |
| `InventoryChangeLogType` | Confirmed | — | `ChangeLog_*` | game_types.h | — |
| `ItcOperation` | Confirmed | anonymous | `ITCReq_*/ITCRes_*/ITCFailReason_*` | line ~16200 | — |
| `ItemAttackSpeed` | WZ data | — | — | Character.wz equip/attackSpeed | Base values: 2,4,6,8,10. Runtime values: 3,9. Values 5,7 (NormalFast/NormalSlow) have no string pool label. |
| `ItemEnchantCategory` | WZ data | — [Flags] | — | equip item info/enchantCategory | Controls which scroll type can be applied |
| `ItemGrade` | Confirmed | named: `inside` | `GRADE_*` | line ~5337 | — |
| `ItemInventoryType` | Confirmed | unnamed | `IT_*` | — | — |
| `ItemLogSource` | Confirmed | anonymous | `ITEMLOG_*` | line ~13100 | — |
| `ItemLogType` | Confirmed | anonymous | `ITEMLOG_TYPE_*` | line ~13062 | — |
| `ItemMakerCategory` | Confirmed | anonymous | `ITEM_CATEGORY_*` | line ~9041 | — |
| `ItemMakerResult` | Confirmed | anonymous | `ITEM_MAKER_RESULT_*/ITEM_MAKER_ERR_*` | line ~7950 | — |
| `ItemOptionType` | No PDB | — | — | — | — |
| `ItemQuality` | Confirmed | named: `ITEMQUALITY` | — | line ~6500 | — |
| `ItemSlotType` | Confirmed | anonymous | `ITEMSLOTTYPE_*` | line ~5184 | — |
| `ItemTransformType` | Confirmed | named: `ITEM_TRANSFROM_TYPE` | — | line ~16959 | PDB typo: `TRANSFROM` |
| `ItemUpgradeLimitType` | Confirmed | named: `ITEM_UPGRADE_LIMIT_TYPE` | — | line ~13632 | — |
| `ItemUseBlockReason` | Confirmed | anonymous | `ITEM_USE_*` | game_types.h | — |
| `ItemVariationOption` | Confirmed | named: `ITEMVARIATIONOPTION` | — | line ~9970 | PDB typo: `PERPECT` |
| `Job` | V95 ref | — | — | — | Source: TEAM SPIRIT YAML |
| `JobCategory` | Confirmed | — | — | — | — |
| `JobClass` | Confirmed | unnamed | `JC_*` | line ~734 | — |
| `JobLineage` | Confirmed | unnamed | `JOB_RACE_*` | line ~3609 | — |
| `JobRace` | Confirmed | anonymous | `JOB_RACE_*` | line ~3235 | — |
| `LayerBlendType` | Confirmed | — | `LB_*` | game_types.h | — |
| `LeaveResult` | Confirmed | anonymous | `LR_*` | line ~16650 | — |
| `LifeNameTagType` | Confirmed | anonymous | `LIFE_NAMETAG_*` | line ~8053 | — |
| `LocaleId` | Confirmed | — | `kLocaleID_*` | game_types.h | — |
| `LoginResult` | No PDB | — | — | — | Source: EdelsteinExperimental |
| `LoginState` | Confirmed | unnamed | `LS_*` | line ~6280 | — |
| `MacroTargetType` | Confirmed | — | `TAEGETTYPE_*` | game_types.h | — |
| `MakeoverItemType` | Confirmed | anonymous | `MKT_*` | line ~6825 | — |
| `MapFieldLimit` | Confirmed | named: `FIELDOPT` | — | line 3399 | CField::m_dwOption; Max flag 0x800000 |
| `MapFieldType` | Confirmed | — | — | line 3692 | Also: game_pseudocode.c:276050 |
| `MapleTvResultCode` | Confirmed | anonymous | `MapleTVResCode_*` | line ~15970 | — |
| `MapPortalType` | Confirmed | unnamed | `PORTALTYPE_*` | line ~5388 | — |
| `MapTransferOperation` | Confirmed | anonymous | `MapTransferReq_*/MapTransferRes_*` | line ~5370 | — |
| `MaritalStatus` | Confirmed | anonymous | `MS_*` | line ~6510 | — |
| `MarriageOperation` | Confirmed | anonymous | `MarriageReq_*/MarriageRes_*` | line ~5760 | — |
| `MedalQuestCategory` | Confirmed | anonymous | `MEDAL_QUEST_*` | line ~6140 | — |
| `MedalQuestState` | Confirmed | anonymous | `MEDAL_QUEST_STATE_*` | line ~8974 | — |
| `MemoNotificationType` | Confirmed | anonymous | `MEMO_*` | line ~10560 | — |
| `MemoOperation` | Confirmed | anonymous | `MemoReq_*/MemoRes_*/MemoNotify_*` | line ~4970 | — |
| `MessageType` | No PDB | — | — | — | — |
| `MessengerOperation` | Confirmed | anonymous | `MSMP_*` | line ~9000 | — |
| `MiniGameEvent` | Confirmed | anonymous | `MiniGame_*` | line ~15760 | — |
| `MiniGameItemType` | Confirmed | — | `MGIT_*` | game_types.h | — |
| `MiniRoomEnterResult` | Confirmed | anonymous | `MREnterResult_*` | line ~8800 | — |
| `MiniRoomInviteResult` | Confirmed | anonymous | `MRInvite_*` | line ~15940 | — |
| `MiniRoomLeaveType` | Confirmed | anonymous | `MRLeave_*/TRLeave_*/PSLeave_*/ESLeave_*` | line ~9480 | — |
| `MiniRoomProtocol` | Confirmed | anonymous | `MRP_*/TRP_*/PSP_*/ESP_*/MGRP_*/ORP_*/MGP_*` | line ~5960 | — |
| `MiniRoomType` | Confirmed | anonymous | `MR_*` | line ~5885 | — |
| `MobActionType` | Confirmed | anonymous | `MOBACT_*` | line ~843 | — |
| `MobAttackElement` | Confirmed | anonymous | `Mob_AttackElem_*` | line ~13429 | — |
| `MobAttackRange` | Confirmed | — | `AT_*` | line ~1822 | — |
| `MobAttractDirection` | Confirmed | anonymous | `ATTRACT_DIRECTION_*` | line ~7849 | — |
| `MobBanType` | Confirmed | unnamed | `MOBBANTYPE_*` | line ~7848 | has -1 sentinel |
| `MobCategory` | Confirmed | named: `MobCategory` | `MOBCATEGORY_*` | line ~6684 | — |
| `MobDamageRandType` | Confirmed | anonymous | `MOB_DAMAGERAND_*` | line ~7862 | — |
| `MobDamageType` | Confirmed | anonymous | `MOB_DAMAGERAND_*` | line ~7860 | — |
| `MobLevelType` | Confirmed | anonymous | `MOB_LEVEL_*` | line ~15870 | — |
| `MobMoveAbility` | Confirmed | anonymous | — | game_types.h | — |
| `MobMoveType` | Confirmed | anonymous | `MOBMOVE_*` | line ~6100 | — |
| `MobPowerAttackType` | Confirmed | anonymous | `MPA_*` | line ~3264 | — |
| `MobSkillType` | Confirmed | anonymous | `MOBSKILL_*` | line ~7878 | — |
| `MobSpecies` | Confirmed | anonymous | — | game_types.h | — |
| `MobSuspendType` | Confirmed | unnamed | `SUSPEND_*` | line ~6080 | — |
| `MobTemporaryStatType` | V95 ref | — | — | — | UINT128 bitmask |
| `ModifyEquipType` | Confirmed | anonymous | `MODIFYEQUIPTYPE_*` | line ~8563 | — |
| `ModifyInventoryOperationType` | No PDB | — | — | — | — |
| `ModifyStatForcedType` | No PDB | — [Flags] | — | — | — |
| `ModifyStatType` | No PDB | — [Flags] | — | — | — |
| `MoneyLogAction` | Confirmed | — | — | line ~10997 | — |
| `MonsterCarnivalMapType` | Confirmed | anonymous | `MCARNIVALS2_MAPTYPE*` | line ~12960 | — |
| `MonsterCarnivalOperation` | Confirmed | anonymous | `MCarnivalReq_*/MCarnivalRes_*/MCarnivalOut_*/MCarnivalGameRes_*` | line ~16500 | — |
| `MonsterCarnivalTeam` | Confirmed | anonymous | `MCARNIVAL_TEAM_*` | line ~4631 | — |
| `MorphActionType` | Confirmed | anonymous | `MORPHACT_*` | line ~3429 | — |
| `MovableTerrainType` | Confirmed | anonymous | `MOVABLE_*` | line ~7815 | — |
| `MoveActionDirection` | No PDB | — | — | — | — |
| `MoveActionType` | Confirmed | named: `MOVE_ACTION_TYPE` | `MA_*` | line ~3865 | — |
| `MovePathFragmentType` | No PDB | — | — | — | — |
| `NewCharEquipType` | Confirmed | anonymous | `NEWCHAR_EQUIP_TYPE_*` | line ~5420 | — |
| `NewYearCardOperation` | Confirmed | anonymous | `NewYearCardReq_*/NewYearCardRes_*/NewYearCardFailReason_*` | line ~2060 | — |
| `NitType` | Confirmed | anonymous | `NIT_*` | line ~13342 | — |
| `NotificationPopupType` | Confirmed | anonymous | — | line ~4126 | — |
| `NpcActionType` | Confirmed | anonymous | `NPCACT_*` | line ~5600 | — |
| `NpcQuestState` | Confirmed | anonymous | `NPC_QUESTSTATE_*` | line ~8990 | — |
| `NexonServerType` | Confirmed | named: `Nexon::Platform::ServerInfo::ServerType` | — | line ~14647 | Nexon Platform SDK |
| `NmAuthCheckModuleType` | Confirmed | named: `NMAUTHCHECKMODULETYPE` | `kAuthCheckModuleType_*` | line ~13573 | Nexon Platform SDK |
| `NmCategoryProperty` | Confirmed | named: `NMCATEGORYPROPERTY` [Flags] | `kCateProp_*` | line ~14234 | Nexon Platform SDK |
| `NmGuildType` | Confirmed | named: `NMGUILDTYPE` | `kGuildType_*` | line ~13557 | Nexon Platform SDK |
| `NmLoginAuthReplyCode` | Confirmed | named: `NMLoginAuthReplyCode` | `kLoginAuth_*` | line ~11236 | Nexon Platform SDK; large int values |
| `NmMessengerReplyCode` | Confirmed | named: `NMMessengerReplyCode` | `kMessengerReply*` | line ~11391 | Nexon Platform SDK; negative values |
| `NmP2PErrorCode` | Confirmed | named: `NMP2PErrorCode` | `kP2PError_*` | line ~14218 | Nexon Platform SDK; negative values |
| `NmP2PReplyCode` | Confirmed | named: `NMP2PReplyCode` | `kP2PReply_*` | line ~11456 | Nexon Platform SDK; negative values |
| `NmP2PStatus` | Confirmed | named: `NMP2PStatus` | `kP2PStatus_*` | line ~14279 | Nexon Platform SDK |
| `NmSessionType` | Confirmed | named: `NMSESSIONTYPE` | `kSessionType_*` | line ~13918 | Nexon Platform SDK |
| `NmSexType` | Confirmed | named: `NMSEXTYPE` | `kSex_*` | line ~13658 | Nexon Platform SDK |
| `NmUrlPage` | Confirmed | named: `NMURLPAGE` | `kURL_*` | line ~13702 | Nexon Platform SDK; typo: `MyRoomForWegGame` |
| `NmUrlType` | Confirmed | named: `NMURLTYPE` | `kURLType_*` | line ~13686 | Nexon Platform SDK |
| `NmUserStatus` | Confirmed | named: `NMUSERSTATUS` | `kStatus_*` | line ~13591 | Nexon Platform SDK |
| `NpcShopOperation` | Confirmed | anonymous | `ShopReq_*` | line ~15492 | — |
| `NpcShopResult` | Confirmed | anonymous | `ShopRes_*` | line ~15496 | — |
| `ParcelOperation` | Confirmed | anonymous | `ParcelReq_*/ParcelRes_*` | line ~15750 | — |
| `PartyAdverJobSearchFlag` | Confirmed | anonymous | `SEARCHING_JOB_*` | line ~8873 | — |
| `PartyAdverResult` | Confirmed | anonymous | `AdverAddFailReason_*/AdverRemoveReason_*/PartyAdverApplyResult_*` | line ~4415 | — |
| `PartyOperation` | Confirmed | anonymous | `PartyReq_*/PartyRes_*/ExpeditionReq_*/ExpeditionNoti_*/AdverNoti_*/AdverReq_*` | line ~4465 | — |
| `PartyRaidTeam` | Confirmed | named: `PartyRaidTeam` | — | line ~1848 | — |
| `PassiveSkillStat` | Confirmed | — | — | line ~683 | — |
| `PersonalShopBuyResult` | Confirmed | anonymous | `PSBuy_*` | line ~15700 | — |
| `PetAbilityFlag` | Confirmed | anonymous | `PETABIL_*` | line ~10300 | — |
| `PetActionType` | Confirmed | anonymous | `PETACT_*` | line ~5670 | — |
| `PetEffectType` | Confirmed | anonymous | `PetEffect_*` | line ~7250 | — |
| `PetInteractType` | Confirmed | named: `PET_ACTTYPE` | — | line ~15631 | — |
| `PetPositionCarrier` | Confirmed | anonymous | `PPC_*` | line ~7260 | — |
| `PrivilegeItemType` | Confirmed | named: `PrivilegeItem::Type` | `SP_*` | line ~4798 | Full PDB type; see also FamilyPrivilegeType |
| `PhraseType` | Confirmed | anonymous | `Phrase_*` | line ~7390 | — |
| `PinCodeResult` | Confirmed | anonymous | `PinCodeResCode_*` | line ~16170 | — |
| `PotentialStatType` | Confirmed | anonymous | `inc*/rand*` | line ~16300 | — |
| `PriceLogSource` | Confirmed | anonymous | `PRICELOG_*` | line ~13050 | — |
| `PrivateStatusFlag` | Confirmed | named: `PrivateStatusIDFlag` | `PS_*` | line ~1691 | PDB has `ID` suffix in type name |
| `QuestAction` | No PDB | — | — | — | — |
| `QuestArea` | No PDB | named: `exists` | — | — | — |
| `QuestCompleteResultType` | Confirmed | anonymous | `QUEST_COMPLETE*` | line ~5850 | — |
| `QuestDayOfWeek` | Confirmed | named: `DayOfWeek` | — | line ~15620 | — |
| `QuestGuideOperation` | Confirmed | anonymous | `QuestGuideReq_*/QuestGuideRes_*` | line ~7750 | — |
| `QuestIconType` | Confirmed | anonymous | `QUEST_ICONTYPE_*` | line ~8702 | — |
| `QuestJobExFlags` | V95 ref | — [Flags] | — | — | Bit 0x4 reserved |
| `QuestJobFlags` | No PDB | — [Flags] | — | — | — |
| `QuestLogAction` | Confirmed | — | — | line ~11328 | — |
| `QuestRequestType` | No PDB | — | — | — | — |
| `QuestResultType` | No PDB | — | — | — | — |
| `QuestState` | Confirmed | unnamed | `QUEST_STATE_*` | line ~5839 | — |
| `RaceSelectType` | Confirmed | unnamed | `RACE_SELECT_*` | line ~12430 | — |
| `RainbowWeekType` | Confirmed | anonymous | `RAINBOWWEEK_*` | line ~9785 | — |
| `RandomMorphResult` | Confirmed | — | `RandomMorphRes_*/RandomMorphFailReason_*` | game_types.h | — |
| `RateType` | No PDB | — | — | — | — |
| `ReactorEventType` | Confirmed | — | — | Reactor.wz | WZ: Reactor.wz/{id}.img/{stateIdx}/{eventIdx}/type. |
| `ReactorLayer` | Confirmed | anonymous | — | Reactor.wz | WZ: Reactor.wz/{id}.img/info/layer |
| `RecipeClass` | Confirmed | anonymous | `RECIPE_CLASS_*` | line ~7940 | — |
| `RecoveryInfoType` | Confirmed | anonymous | `RECOVERYINFO_*` | line ~9390 | — |
| `RegionCode` | Confirmed | — | `kRegionCode_*` | line ~6430 | — |
| `ReportCategory` | Confirmed | anonymous | `TYPEID_*` | line ~9330 | — |
| `ReservedEffectType` | Confirmed | anonymous | `RESERVED_EFFECT_*` | line ~16980 | — |
| `RewardType` | Confirmed | anonymous | `REWARD_*` | line ~10663 | — |
| `RockPaperScissorsOperation` | Confirmed | anonymous | `RPSReq_*/RPSRes_*` | line ~15533 | — |
| `ScreenshotFormat` | Confirmed | — | `SFF_*` | game_types.h | — |
| `SecondaryStatType` | Confirmed | named: `TSIndex` | `TS_*` | line ~818 | — |
| `SecondPasswordState` | Confirmed | anonymous | `CHECK_SPW_*` | line ~16183 | — |
| `SecurityPacketType` | Confirmed | anonymous | `SECURITYPACKET_*` | line ~2047 | — |
| `ServerLockType` | Confirmed | named: `E_LockType` | — | line ~12952 | — |
| `ServerMessageType` | Confirmed | anonymous | `MS_*` | line ~5440 | — |
| `ServerPacketOpcode` | Confirmed | anonymous | `LP_*` | line ~51 | — |
| `ShopCashType` | Confirmed | anonymous | `CS_CASHTYPE_*` | game_types.h | NexonCash=1, MaplePoint=2, PrepaidNX=4 |
| `ShopScannerOperation` | Confirmed | anonymous | `ShopScannerReq_*/ShopScannerRes_*` | line ~4920 | — |
| `SkillCombatTargetFlag` | Confirmed | anonymous [Flags] | `SCT_*` | line ~4248 | — |
| `SkillId` | V95 ref | anonymous | — | — | — |
| `SkillTargetType` | Confirmed | anonymous | `TARGETTYPE_*` | line ~6041 | — |
| `SkillSubType` | Confirmed | — | — | — | WZ: skill |
| `SkillUseCheckResult` | Confirmed | anonymous | — | line ~7652 | — |
| `SkinColor` | No PDB | — | — | — | Source: Character.wz |
| `SnowballSection` | Confirmed | anonymous | `SNOWBALL_*` | line ~16480 | — |
| `SoundEffectType` | Confirmed | named: `SE_TYPE` | — | line ~5615 | — |
| `SpecialSetEffect` | Confirmed | — | — | line ~8429 | — |
| `SpeedQuizType` | Confirmed | anonymous | `TYPE_SPEED_QUIZ_*` | line ~9320 | — |
| `SueCharacterResult` | Confirmed | anonymous | `SueCharacterRes_*` | line ~5438 | — |
| `SummonedActionType` | Confirmed | anonymous | `SUMMONEDACT_*` | line ~6720 | — |
| `SummonedAttackAiType` | Confirmed | anonymous | `AI_*` | line ~6530 | — |
| `SummonedAttackState` | Confirmed | anonymous | `AS_*` | line ~7671 | — |
| `SummonedEnterType` | Confirmed | anonymous | `ENTER_TYPE_*` | line ~9500 | — |
| `SummonedLeaveType` | Confirmed | anonymous | `LEAVE_TYPE_*` | line ~9510 | — |
| `SummonedAssistType` | Confirmed | anonymous | `YOURFIELD_*` | line ~6530 | — |
| `TamingMobId` | Confirmed | anonymous | `TAMINGMOB_*` | line ~8187 | — |
| `TemporaryStatType` | V95 ref | — | — | — | UINT128 bitmask |
| `TeslaCoilRole` | Confirmed | anonymous | `TESLACOIL_*` | line ~9459 | — |
| `TooltipType` | Confirmed | anonymous | `TT_*` | line ~8349 | — |
| `TradeMoneyType` | Confirmed | — | `TMP_*` | game_types.h | — |
| `TransferFieldResult` | Confirmed | anonymous | `TF_*` | line ~16600 | — |
| `TransferChannelResult` | Confirmed | anonymous | `TC_*` | line ~16620 | — |
| `TrunkOperation` | Confirmed | anonymous | `TrunkReq_*/TrunkRes_*` | line ~8980 | — |
| `TwoStateIndex` | Confirmed | named: `TSIndex` | `TS_*` | line ~720 | — |
| `UserEffectType` | Confirmed | anonymous | `UserEffect_*` | line ~8030 | — |
| `VideoState` | Confirmed | — | — | game_types.h | — |
| `WeaponAttackFlag` | Confirmed | anonymous [Flags] | `AI_*` | line ~11362 | — |
| `WeaponType` | Confirmed | unnamed | `WT_*` | line ~3811 | Backing: sbyte — range -1 |
| `WeddingType` | Confirmed | anonymous | `WT_*` | line ~10100 | — |
| `WeddingWishListOperation` | Confirmed | anonymous | `WeddingWLReq_*/WeddingWLRes_*` | line ~5840 | — |
| `WhisperOperation` | Confirmed | anonymous [Flags] | `WP_*` | line ~16640 | — |
| `WhiteScrollOption` | Confirmed | anonymous | `WHITE_SCROLL_*` | line ~9180 | — |
| `WorldMoneyLogType` | Confirmed | named: `WorldMoneyLog` | — | line ~11004 | — |

## EdelsteinExperimental server comparison

Full comparison performed March 2026 against the
[EdelsteinExperimental](https://github.com/Bia10/EdelsteinExperimental) server repo
(`src/protocol/` + `src/common/`).

**32 server enums found. 30 already covered in Maple.Enums.**

### Name-mapping table

Where the server uses a different name for the same concept:

| Server name | Maple.Enums name | Notes |
|---|---|---|
| `WeaponType` (Common.Constants) | `WeaponType` | Values are hex in server; identical concept |
| `MoveAbilityType` | `MobMoveAbility` | Renamed for clarity |
| `CommodityFlags` | `CommodityModifyFlag` | Same bit layout |
| `ShopRequestOperations` + `ShopResultOperations` | `CashItemOperation` | Unified into one enum with `Req`/`Res` prefix on members |
| `LoginState` (server) | `LoginState` (client) | **Different concepts** — server models session phase (`CheckPassword`, `SelectWorld`); client models UI view (`Title`, `WorldSelect`). Not equivalent. |
| `AccountGradeCode` [Flags] | `AdminLevel` (sequential) | **Values differ** — server interprets admin level as a bitmask (1,2,4,8,16,32); client PDB uses sequential index (0,1,2,3,4,5). Client PDB is authoritative. |

### New enum added

- `ShopCashType` — the payment currency selector used in Cash Shop purchases
  (values: NexonCash=1, MaplePoint=2, PrepaidNXCash=4). Present in server, absent from client
  enums prior to this audit. Added to `Shop/ShopCashType.cs`.

### Enums intentionally excluded

- `TransportState` (Closed/Opened) — pure network transport plumbing; has no game semantic;
  lives in the server's networking layer only.

### Architecture decision

A Client/Server project split was considered and rejected. The server enums are a strict
subset of the client PDB. Splitting into two projects would duplicate 286 files for the
benefit of ~1 new file. REFERENCE.md (this file) and the `[Label]` attributes on each
member are sufficient provenance metadata to distinguish client-canonical vs
server-inferred enums.

---

## Detailed notes

### `AttackActionType`

- Weapon animation attack action type (V95 PDB confirmed — named enum AttactActionType [sic],
- AAT_* prefix, game_types.h line 7578). Note: PDB has typo "Attact" and "AAT_TowHand"
- AAT_Start (0) and AAT_End (11) are sentinels — not included

### `AttackType`

- Player attack classification. No V95 PDB enum found for this concept
- V95 has MobAttackInfo::AT_RANGE/SHOOT/PIERCE which is mob attack range type — a different concept)
- Values sourced from EdelsteinExperimental protocol

### `ElemResistanceTier`

- Elemental resistance tier stored per element in mob aDamagedElemAttr[] (V95 PDB confirmed)
- V95: same unnamed enum as ELEMENT_*, ELEMENT_ATTR_* prefix, game_types.h line 887

### `FamilyTreeNodeType`

- Family tree hierarchy node type used by CUIFamilyChart
- V95 PDB confirmed — NODE_* prefix inside CUIFamilyChart, game_types.h)

### `ItemInventoryType`

- Inventory tab type (V95 PDB confirmed — unnamed enum, IT_* prefix)
- IT_NO (5) is an alias for IT_CASH used as "no more tabs" sentinel — not included
- IT_EXNO (6) is an extended sentinel — not included

### `ItemTransformType`

- Item transform type (V95 PDB confirmed — named enum ITEM_TRANSFROM_TYPE, game_types.h line ~16959)
- Note: V95 PDB spells "TRANSFROM" — actual meaning is "Transform"

### `ItemVariationOption`

- Item stat variation option (V95 PDB confirmed — named enum ITEMVARIATIONOPTION, game_types.h line 9970)
- Note: V95 PDB spells "PERPECT" — actual meaning is "Perfect"

### `JobClass`

- Character job class code (V95 PDB confirmed — unnamed enum, JC_* prefix, game_types.h line 734)
- JC_NO = 10 is a sentinel/invalid value

### `JobLineage`

- Character job race/lineage (V95 PDB confirmed — unnamed enum, JOB_RACE_* prefix, game_types.h line 3609)
- V95 name for Heroes is JOB_RACE_THIRD ("third" heroes class)

### `LoginResult`

- Login result codes returned by the login server. No V95 PDB enum found
- Values sourced from EdelsteinExperimental LoginResult

### `MapFieldLimit`

- Map field option bitmask (fieldLimit WZ node, V95 PDB confirmed from FIELDOPT enum
- at game_types.h:3399, stored as CField::m_dwOption at runtime)

### `MapPortalType`

- Map portal type (V95 PDB confirmed — unnamed enum, PORTALTYPE_* prefix, game_types.h line 5388)
- Note: V95 spells "CHANGABLE" (not "Changeable") — C# uses correct spelling

### `MobBanType`

- Mob ban/kill type (V95 PDB confirmed — unnamed enum, MOBBANTYPE_* prefix, game_types.h line 7848)
- Value -1 = MobSkill confirmed by PDB

### `MobTemporaryStatType`

- V95: MobStat UINT128 bitmask — each member is the bit position, not the flag value
- Actual flag: (UInt128)1 &lt;&lt; (int)statType

### `MoveActionType`

- Character movement action state (V95 PDB confirmed — named enum MOVE_ACTION_TYPE, MA_* prefix, game_types.h line 3865)
- MA_NO (22) is a sentinel — not included

### `QuestArea`

- No named enum exists in the V95 client PDB — these are WZ-content-defined values
- V95 PDB confirms fields: ISLAND_MAPLE=0, ISLAND_VICTORIA=1, ISLAND_OSSYRIA=2 (island codes, not a named enum — stored as area IDs in quest WZ data)

### `RaceSelectType`

- New character creation race selection (V95 PDB confirmed — unnamed enum, RACE_SELECT_* prefix, game_types.h line 12430)
- RACE_SELECT_COUNT (5) is a sentinel — not included

### `ReactorEventType`

- Reactor trigger event type (V95 PDB confirmed from Reactor.wz state node parsing)
- Stored in Reactor.wz/{id}.img/{stateIdx}/{eventIdx}/type

### `ReactorLayer`

- Reactor draw layer (V95 PDB confirmed — anonymous enum on CReactorTemplate, line 6985)
- Stored in Reactor.wz/{id}.img/info/layer as m_nLayer on CReactorTemplate

### `TemporaryStatType`

- V95: SecondaryStat UINT128 bitmask — each member is the bit position, not the flag value
- Actual flag: (UInt128)1 &lt;&lt; (int)statType

### `WeaponType`

- MapleStory weapon type (V95 PDB confirmed — unnamed enum, WT_* prefix, game_types.h line 3811)
- Backing: sbyte — range -1..49; WT_NOTCHECK_SUBWEPPON=-1 confirmed. Gaps at 35, 36

