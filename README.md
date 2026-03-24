# Maple.Enums

![.NET](https://img.shields.io/badge/net10.0-5C2D91?logo=.NET&labelColor=gray)
![C#](https://img.shields.io/badge/C%23-14.0-239120?labelColor=gray)
[![Build Status](https://github.com/Bia10/Maple.Enums/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/Bia10/Maple.Enums/actions/workflows/dotnet.yml)
[![codecov](https://codecov.io/gh/Bia10/Maple.Enums/branch/main/graph/badge.svg)](https://codecov.io/gh/Bia10/Maple.Enums)
[![Nuget](https://img.shields.io/nuget/v/Maple.Enums?color=purple)](https://www.nuget.org/packages/Maple.Enums/)
[![License](https://img.shields.io/github/license/Bia10/Maple.Enums)](https://github.com/Bia10/Maple.Enums/blob/main/LICENSE)

A comprehensive collection of **287 strongly-typed MapleStory V95 enumerations**, reverse-engineered from the V95 client PDB (`game_types.h`). Cross-platform, trimmable and AOT/NativeAOT compatible.

[Example](#example) | [Example Catalogue](#example-catalogue) | [Public API Reference](#public-api-reference)

## Features

- **287 enums** covering jobs, stats, items, combat, fields, mobs, quests, network opcodes, and more
- **AOT-compatible** — `.NET 10`, `IsAotCompatible=true`, zero runtime reflection
- **Source-generated** via [FastEnum.Generators](https://github.com/xin9le/FastEnum) — no `Enum.GetValues` overhead
- **Triple-indexed labels** on every member:
  - Index 0 — original V95 PDB identifier (typos preserved verbatim)
  - Index 1 — human-readable display name for compound words (`WhiteKnight` → `"White Knight"`)
  - Index 2+ — WZ content string codes where applicable (`EquipSlot.Cap` → `"Cp"`)
- **Full XML documentation** on every enum and member — IntelliSense-friendly

## Install

```
dotnet add package Maple.Enums
```

## Example

```csharp
// Human-readable display label
Console.WriteLine(Job.WhiteKnight.GetDisplayLabel()); // "White Knight"
Console.WriteLine(WeaponType.OhSword.GetDisplayLabel()); // "1H Sword"
Console.WriteLine(Element.Fire.GetDisplayLabel()); // "Fire"
```

For more examples see [Example Catalogue](#example-catalogue).

## Namespace & Structure

All enums live in the single flat namespace `Maple.Enums`. Files are organised into domain subfolders for discoverability but introduce no sub-namespaces.

| Folder | Domain |
|--------|--------|
| `Auth/` | Login, PIN, security |
| `Admin/` | Admin commands, locale, region codes |
| `Character/` | Stats, jobs, movement, temporary stats |
| `Combat/` | Skills, elements, weapons, summons |
| `Economy/` | Drop ownership, meso logs, rates |
| `Event/` | Mini-games, carnival, seasonal events |
| `Field/` | Maps, portals, field limits, reactors |
| `Item/` | Inventory, equipment, cash items, crafting |
| `Life/` | Mobs, NPCs, boss IDs, mob skills |
| `NexonPlatform/` | Nexon Messenger SDK types |
| `Network/` | Packet opcodes, transfer results |
| `Pet/` | Pet abilities, actions, food results |
| `Quest/` | Quest states, job flags, areas |
| `Shop/` | NPC shop, cash shop, personal shop |
| `Social/` | Party, guild, friends, marriage, chat |
| `UI/` | Animation layers, cursor, effects, fonts |

## Documentation

- **[REFERENCE.md](src/Maple.Enums/REFERENCE.md)** — full provenance catalog: origin classification (CLIENT_CONFIRMED / CLIENT_PARTIAL / WZ_DATA / CUSTOM) for all 287 enums
- **[typos.md](src/Maple.Enums/typos.md)** — 37 preserved V95 client PDB typos documented alongside their corrected C# spellings

## Benchmarks

Benchmarks.

### Detailed Benchmarks

#### Comparison Benchmarks

##### TestBench Benchmark Results


## Example Catalogue

The following examples are available in [ReadMeTest.cs](src/Maple.Enums.XyzTest/ReadMeTest.cs).

### Example - Empty

```csharp
// Human-readable display label
Console.WriteLine(Job.WhiteKnight.GetDisplayLabel()); // "White Knight"
Console.WriteLine(WeaponType.OhSword.GetDisplayLabel()); // "1H Sword"
Console.WriteLine(Element.Fire.GetDisplayLabel()); // "Fire"
```

## Public API Reference

```csharp
[assembly: System.Reflection.AssemblyMetadata("IsAotCompatible", "True")]
[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "True")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/Bia10/Maple.Enums/")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Enums.Benchmarks")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Enums.ComparisonBenchmarks")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Enums.Test")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Enums.XyzTest")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v10.0", FrameworkDisplayName=".NET 10.0")]
namespace Maple.Enums
{
    public enum AccountMoreInfoOperation : byte
    {
        [FastEnumUtility.Label("AccountMoreInfo_First", 0)]
        First = 0,
        [FastEnumUtility.Label("AccountMoreInfo_LoadRequest", 0)]
        [FastEnumUtility.Label("Load Request", 1)]
        LoadRequest = 1,
        [FastEnumUtility.Label("AccountMoreInfo_LoadDone", 0)]
        [FastEnumUtility.Label("Load Done", 1)]
        LoadDone = 2,
        [FastEnumUtility.Label("AccountMoreInfo_UpdateRequest", 0)]
        [FastEnumUtility.Label("Update Request", 1)]
        UpdateRequest = 3,
        [FastEnumUtility.Label("AccountMoreInfo_UpdateDone", 0)]
        [FastEnumUtility.Label("Update Done", 1)]
        UpdateDone = 4,
        [FastEnumUtility.Label("AccountMoreInfo_UpdateFail", 0)]
        [FastEnumUtility.Label("Update Fail", 1)]
        UpdateFail = 5,
        [FastEnumUtility.Label("Find Friend Search Request", 1)]
        [FastEnumUtility.Label("FindFriend_SearchRequest", 0)]
        FindFriendSearchRequest = 6,
        [FastEnumUtility.Label("Find Friend Search Result", 1)]
        [FastEnumUtility.Label("FindFriend_SearchResult", 0)]
        FindFriendSearchResult = 7,
        [FastEnumUtility.Label("Find Friend Error Code No User", 1)]
        [FastEnumUtility.Label("FindFriend_ErrorCode_NoUser", 0)]
        FindFriendErrorCodeNoUser = 8,
        [FastEnumUtility.Label("Find Friend Error Code Full Point", 1)]
        [FastEnumUtility.Label("FindFriend_ErrorCode_FullPoint", 0)]
        FindFriendErrorCodeFullPoint = 9,
        [FastEnumUtility.Label("Find Friend Error Code Invite Self", 1)]
        [FastEnumUtility.Label("FindFriend_ErrorCode_InviteSelf", 0)]
        FindFriendErrorCodeInviteSelf = 10,
        [FastEnumUtility.Label("Find Friend Error Code Overflow Queue", 1)]
        [FastEnumUtility.Label("FindFriend_ErrorCode_OverflowQueue", 0)]
        FindFriendErrorCodeOverflowQueue = 12,
    }
    public enum AdminCommandType : byte
    {
        [FastEnumUtility.Label("AP_CREATE", 0)]
        Create = 0,
        [FastEnumUtility.Label("AP_REMOVE", 0)]
        Remove = 1,
        [FastEnumUtility.Label("AP_INCEXP", 0)]
        [FastEnumUtility.Label("Inc Exp", 1)]
        IncExp = 2,
        [FastEnumUtility.Label("AP_LOGOUT", 0)]
        Logout = 3,
        [FastEnumUtility.Label("AP_BLOCK", 0)]
        Block = 4,
        [FastEnumUtility.Label("AP_UNBLOCK", 0)]
        Unblock = 5,
        [FastEnumUtility.Label("AP_NORANK", 0)]
        [FastEnumUtility.Label("No Rank", 1)]
        NoRank = 6,
        [FastEnumUtility.Label("AP_SCREENSHOT", 0)]
        Screenshot = 7,
        [FastEnumUtility.Label("AP_DISCONNECT", 0)]
        Disconnect = 8,
        [FastEnumUtility.Label("AP_CENTER_BLOCK", 0)]
        [FastEnumUtility.Label("Center Block", 1)]
        CenterBlock = 9,
        [FastEnumUtility.Label("AP_PORTAL", 0)]
        Portal = 10,
        [FastEnumUtility.Label("AP_NPCVAR", 0)]
        [FastEnumUtility.Label("Npc Var", 1)]
        NpcVar = 11,
        [FastEnumUtility.Label("NPCVAR_SET", 0)]
        [FastEnumUtility.Label("Npc Var Set", 1)]
        NpcVarSet = 12,
        [FastEnumUtility.Label("NPCVAR_GET", 0)]
        [FastEnumUtility.Label("Npc Var Get", 1)]
        NpcVarGet = 13,
        [FastEnumUtility.Label("AP_BANISH_ALL", 0)]
        [FastEnumUtility.Label("Banish All", 1)]
        BanishAll = 14,
        [FastEnumUtility.Label("AP_TIMER", 0)]
        Timer = 15,
        [FastEnumUtility.Label("AP_DESC", 0)]
        Desc = 16,
        [FastEnumUtility.Label("AP_EVENT_START", 0)]
        [FastEnumUtility.Label("Event Start", 1)]
        EventStart = 17,
        [FastEnumUtility.Label("AP_HIDE", 0)]
        Hide = 18,
        [FastEnumUtility.Label("AP_USERLIST", 0)]
        [FastEnumUtility.Label("User List", 1)]
        UserList = 19,
        [FastEnumUtility.Label("AP_SENDUSER", 0)]
        [FastEnumUtility.Label("Send User", 1)]
        SendUser = 20,
        [FastEnumUtility.Label("AP_ENTRUSTEDSHOP", 0)]
        [FastEnumUtility.Label("Entrusted Shop", 1)]
        EntrustedShop = 21,
        [FastEnumUtility.Label("AP_ADMINEVENT", 0)]
        [FastEnumUtility.Label("Admin Event", 1)]
        AdminEvent = 22,
        [FastEnumUtility.Label("AP_KILL_MOB", 0)]
        [FastEnumUtility.Label("Kill Mob", 1)]
        KillMob = 23,
        [FastEnumUtility.Label("AP_QUEST_SET", 0)]
        [FastEnumUtility.Label("Quest Set", 1)]
        QuestSet = 24,
        [FastEnumUtility.Label("AP_QUEST_RESET", 0)]
        [FastEnumUtility.Label("Quest Reset", 1)]
        QuestReset = 25,
        [FastEnumUtility.Label("AP_HACKCHECKCOUNTRELOAD", 0)]
        [FastEnumUtility.Label("Hack Check Count Reload", 1)]
        HackCheckCountReload = 26,
        [FastEnumUtility.Label("AP_QUEST", 0)]
        Quest = 27,
        [FastEnumUtility.Label("AP_SUMMON", 0)]
        Summon = 28,
        [FastEnumUtility.Label("AP_MOB_HP", 0)]
        [FastEnumUtility.Label("Mob Hp", 1)]
        MobHp = 29,
        [FastEnumUtility.Label("AP_LEVEL_SET", 0)]
        [FastEnumUtility.Label("Level Set", 1)]
        LevelSet = 30,
        [FastEnumUtility.Label("AP_JOB_SET", 0)]
        [FastEnumUtility.Label("Job Set", 1)]
        JobSet = 31,
        [FastEnumUtility.Label("AP_NOCOOLTIME", 0)]
        [FastEnumUtility.Label("No Cooltime", 1)]
        NoCooltime = 32,
        [FastEnumUtility.Label("AP_APGET", 0)]
        [FastEnumUtility.Label("Ap Get", 1)]
        ApGet = 33,
        [FastEnumUtility.Label("AP_SPGET", 0)]
        [FastEnumUtility.Label("Sp Get", 1)]
        SpGet = 34,
        [FastEnumUtility.Label("AP_STR", 0)]
        Str = 35,
        [FastEnumUtility.Label("AP_DEX", 0)]
        Dex = 36,
        [FastEnumUtility.Label("AP_INT", 0)]
        Int = 37,
        [FastEnumUtility.Label("AP_LUK", 0)]
        Luk = 38,
        [FastEnumUtility.Label("AP_SKILL", 0)]
        Skill = 39,
        [FastEnumUtility.Label("AP_MMON", 0)]
        MMon = 40,
        [FastEnumUtility.Label("AP_MMOFF", 0)]
        [FastEnumUtility.Label("MM Off", 1)]
        MMOff = 41,
        [FastEnumUtility.Label("AP_SNOW", 0)]
        Snow = 42,
        [FastEnumUtility.Label("AP_WARN", 0)]
        Warn = 43,
        [FastEnumUtility.Label("AP_LOG", 0)]
        Log = 44,
        [FastEnumUtility.Label("AP_RESETMAP", 0)]
        [FastEnumUtility.Label("Reset Map", 1)]
        ResetMap = 45,
        [FastEnumUtility.Label("AP_FREEMARKETCLIP", 0)]
        [FastEnumUtility.Label("Free Market Clip", 1)]
        FreeMarketClip = 46,
        [FastEnumUtility.Label("AP_DESTROYSHOP", 0)]
        [FastEnumUtility.Label("Destroy Shop", 1)]
        DestroyShop = 47,
        [FastEnumUtility.Label("AP_SETOBJECTSTATE", 0)]
        [FastEnumUtility.Label("Set Object State", 1)]
        SetObjectState = 48,
        [FastEnumUtility.Label("AP_SHOWRANK", 0)]
        [FastEnumUtility.Label("Show Rank", 1)]
        ShowRank = 49,
        [FastEnumUtility.Label("AP_FORBIDDENMAPRELOAD", 0)]
        [FastEnumUtility.Label("Forbidden Map Reload", 1)]
        ForbiddenMapReload = 50,
        [FastEnumUtility.Label("AP_CRISP", 0)]
        Crisp = 51,
        [FastEnumUtility.Label("AP_GACHAPONBOXRELOAD", 0)]
        [FastEnumUtility.Label("Gachapon Box Reload", 1)]
        GachaponBoxReload = 52,
        [FastEnumUtility.Label("AP_GACHAPONRELOAD", 0)]
        [FastEnumUtility.Label("Gachapon Reload", 1)]
        GachaponReload = 53,
        [FastEnumUtility.Label("AP_WEATHEREVENTRELOAD", 0)]
        [FastEnumUtility.Label("Weather Event Reload", 1)]
        WeatherEventReload = 54,
        [FastEnumUtility.Label("AP_REWORDRELOAD", 0)]
        [FastEnumUtility.Label("Reward Reload", 1)]
        RewardReload = 55,
        [FastEnumUtility.Label("AP_CAKEPIERELOAD", 0)]
        [FastEnumUtility.Label("Cake Pie Reload", 1)]
        CakePieReload = 56,
        [FastEnumUtility.Label("AP_GMBOARDRELOAD", 0)]
        [FastEnumUtility.Label("Gm Board Reload", 1)]
        GmBoardReload = 57,
        [FastEnumUtility.Label("AP_PQANSWER", 0)]
        [FastEnumUtility.Label("Pq Answer", 1)]
        PqAnswer = 58,
        [FastEnumUtility.Label("AP_MOBCONTROL", 0)]
        [FastEnumUtility.Label("Mob Control", 1)]
        MobControl = 59,
        [FastEnumUtility.Label("AP_PASSIVESKILLVALUEVIEW", 0)]
        [FastEnumUtility.Label("Passive Skill Value View", 1)]
        PassiveSkillValueView = 60,
        [FastEnumUtility.Label("AP_PASSIVESKILLSET", 0)]
        [FastEnumUtility.Label("Passive Skill Set", 1)]
        PassiveSkillSet = 61,
        [FastEnumUtility.Label("AP_PASSIVESKILLUPDATE", 0)]
        [FastEnumUtility.Label("Passive Skill Update", 1)]
        PassiveSkillUpdate = 62,
        [FastEnumUtility.Label("AP_GETCOOLTIME", 0)]
        [FastEnumUtility.Label("Get Cooltime", 1)]
        GetCooltime = 63,
        [FastEnumUtility.Label("AP_FIELDUSERCOUNTLIMIT", 0)]
        [FastEnumUtility.Label("Field User Count Limit", 1)]
        FieldUserCountLimit = 64,
        [FastEnumUtility.Label("AP_SERVEROPTRELOAD", 0)]
        [FastEnumUtility.Label("Server Opt Reload", 1)]
        ServerOptReload = 65,
        [FastEnumUtility.Label("AP_STAGECHANGE", 0)]
        [FastEnumUtility.Label("Stage Change", 1)]
        StageChange = 66,
        [FastEnumUtility.Label("AP_ACTIVATESTAGECHANGE", 0)]
        [FastEnumUtility.Label("Activate Stage Change", 1)]
        ActivateStageChange = 67,
        [FastEnumUtility.Label("AP_RELOADGACHAPONBONUS", 0)]
        [FastEnumUtility.Label("Reload Gachapon Bonus", 1)]
        ReloadGachaponBonus = 68,
        [FastEnumUtility.Label("AP_RELOADVISITORLOGINFO", 0)]
        [FastEnumUtility.Label("Reload Visitor Log Info", 1)]
        ReloadVisitorLogInfo = 69,
        [FastEnumUtility.Label("AP_CUBECOMPLETE", 0)]
        [FastEnumUtility.Label("Cube Complete", 1)]
        CubeComplete = 70,
        [FastEnumUtility.Label("AP_PARTYCHECK", 0)]
        [FastEnumUtility.Label("Party Check", 1)]
        PartyCheck = 71,
        [FastEnumUtility.Label("AP_RELOADDISALLOWEDDELIVERYQUEST", 0)]
        [FastEnumUtility.Label("Reload Disallowed Delivery Quest", 1)]
        ReloadDisallowedDeliveryQuest = 72,
    }
    public enum AdminLevel
    {
        [FastEnumUtility.Label("ADMIN_LEVEL_1", 0)]
        Level1 = 0,
        [FastEnumUtility.Label("ADMIN_LEVEL_2", 0)]
        Level2 = 1,
        [FastEnumUtility.Label("ADMIN_LEVEL_3", 0)]
        Level3 = 2,
        [FastEnumUtility.Label("ADMIN_LEVEL_4", 0)]
        Level4 = 3,
        [FastEnumUtility.Label("ADMIN_LEVEL_5", 0)]
        Level5 = 4,
        [FastEnumUtility.Label("ADMIN_LEVEL_10", 0)]
        Level10 = 5,
    }
    public enum AdminShopCommodityState : byte
    {
        [FastEnumUtility.Label("AdminShopCommodity_OnSale", 0)]
        [FastEnumUtility.Label("On Sale", 1)]
        OnSale = 0,
        [FastEnumUtility.Label("AdminShopCommodity_SoldOut", 0)]
        [FastEnumUtility.Label("Sold Out", 1)]
        SoldOut = 1,
        [FastEnumUtility.Label("AdminShopCommodity_SoldOutForTheDay", 0)]
        [FastEnumUtility.Label("Sold Out For The Day", 1)]
        SoldOutForTheDay = 2,
        [FastEnumUtility.Label("AdminShopCommodity_SoldOutForThePerson", 0)]
        [FastEnumUtility.Label("Sold Out For The Person", 1)]
        SoldOutForThePerson = 3,
    }
    public enum AdminShopOperation : byte
    {
        [FastEnumUtility.Label("AdminShopReq_OpenShop", 0)]
        [FastEnumUtility.Label("Req Open Shop", 1)]
        ReqOpenShop = 0,
        [FastEnumUtility.Label("AdminShopReq_Trade", 0)]
        [FastEnumUtility.Label("Req Trade", 1)]
        ReqTrade = 1,
        [FastEnumUtility.Label("AdminShopReq_Close", 0)]
        [FastEnumUtility.Label("Req Close", 1)]
        ReqClose = 2,
        [FastEnumUtility.Label("AdminShopReq_WishItem", 0)]
        [FastEnumUtility.Label("Req Wish Item", 1)]
        ReqWishItem = 3,
        [FastEnumUtility.Label("AdminShopRes_Trade", 0)]
        [FastEnumUtility.Label("Res Trade", 1)]
        ResTrade = 4,
        [FastEnumUtility.Label("AdminShopRes_SoldOut", 0)]
        [FastEnumUtility.Label("Res Sold Out", 1)]
        ResSoldOut = 5,
    }
    public enum AdminShopTradeResult : byte
    {
        [FastEnumUtility.Label("AdminShopTradeFail_None", 0)]
        None = 0,
        [FastEnumUtility.Label("AdminShopTradeFail_WrongSN", 0)]
        [FastEnumUtility.Label("Wrong Sn", 1)]
        WrongSn = 1,
        [FastEnumUtility.Label("AdminShopTradeFail_WrongLevel", 0)]
        [FastEnumUtility.Label("Wrong Level", 1)]
        WrongLevel = 2,
        [FastEnumUtility.Label("AdminShopTradeFail_WrongPeriod", 0)]
        [FastEnumUtility.Label("Wrong Period", 1)]
        WrongPeriod = 3,
        [FastEnumUtility.Label("AdminShopTradeFail_NotEnoughMeso", 0)]
        [FastEnumUtility.Label("Not Enough Meso", 1)]
        NotEnoughMeso = 4,
        [FastEnumUtility.Label("AdminShopTradeFail_TooMuchMeso", 0)]
        [FastEnumUtility.Label("Too Much Meso", 1)]
        TooMuchMeso = 5,
        [FastEnumUtility.Label("AdminShopTradeFail_SoldOut", 0)]
        [FastEnumUtility.Label("Sold Out", 1)]
        SoldOut = 6,
        [FastEnumUtility.Label("AdminShopTradeFail_SoldOutForTheDay", 0)]
        [FastEnumUtility.Label("Sold Out For The Day", 1)]
        SoldOutForTheDay = 7,
        [FastEnumUtility.Label("AdminShopTradeFail_SoldOutForThePerson", 0)]
        [FastEnumUtility.Label("Sold Out For The Person", 1)]
        SoldOutForThePerson = 8,
        [FastEnumUtility.Label("AdminShopTradeFail_OverCount", 0)]
        [FastEnumUtility.Label("Over Count", 1)]
        OverCount = 9,
        [FastEnumUtility.Label("AdminShopTradeFail_TradeBlocked", 0)]
        [FastEnumUtility.Label("Trade Blocked", 1)]
        TradeBlocked = 10,
        [FastEnumUtility.Label("AdminShopTradeFail_Unknown", 0)]
        Unknown = 11,
    }
    public enum AffectedAreaType : byte
    {
        [FastEnumUtility.Label("Mob Skill", 1)]
        MobSkill = 0,
        [FastEnumUtility.Label("User Skill", 1)]
        UserSkill = 1,
        Smoke = 2,
        Buff = 3,
        [FastEnumUtility.Label("Blessed Mist", 1)]
        BlessedMist = 4,
    }
    public enum AnimationLayerType : byte
    {
        [FastEnumUtility.Label("AL_SETITEMEFFECT", 0)]
        [FastEnumUtility.Label("Set Item Effect", 1)]
        SetItemEffect = 0,
        [FastEnumUtility.Label("AL_SETITEMBACKGROUND", 0)]
        [FastEnumUtility.Label("Set Item Background", 1)]
        SetItemBackground = 1,
        [FastEnumUtility.Label("AL_ADMINEFFECT", 0)]
        [FastEnumUtility.Label("Admin Effect", 1)]
        AdminEffect = 2,
        [FastEnumUtility.Label("AL_ACTIVEITEMEFFECT", 0)]
        [FastEnumUtility.Label("Active Item Effect", 1)]
        ActiveItemEffect = 3,
        [FastEnumUtility.Label("AL_CARRYITEMEFFECT", 0)]
        [FastEnumUtility.Label("Carry Item Effect", 1)]
        CarryItemEffect = 4,
        [FastEnumUtility.Label("AL_COMBOCOUNTER", 0)]
        [FastEnumUtility.Label("Combo Counter", 1)]
        ComboCounter = 5,
        [FastEnumUtility.Label("AL_JUKEBOXEFFECT", 0)]
        [FastEnumUtility.Label("Jukebox Effect", 1)]
        JukeboxEffect = 6,
        [FastEnumUtility.Label("AL_COUPLEITEMEFFECT", 0)]
        [FastEnumUtility.Label("Couple Item Effect", 1)]
        CoupleItemEffect = 7,
        [FastEnumUtility.Label("AL_NEWYEARCARDEFFECT", 0)]
        [FastEnumUtility.Label("New Year Card Effect", 1)]
        NewYearCardEffect = 8,
        [FastEnumUtility.Label("AL_MAPSPECIFICEFFECT", 0)]
        [FastEnumUtility.Label("Map Specific Effect", 1)]
        MapSpecificEffect = 9,
        [FastEnumUtility.Label("AL_PORTABLESEATEFFECT", 0)]
        [FastEnumUtility.Label("Portable Seat Effect", 1)]
        PortableSeatEffect = 10,
        [FastEnumUtility.Label("AL_ACTIVEITEMFOLLOWEFFECT", 0)]
        [FastEnumUtility.Label("Active Item Follow Effect", 1)]
        ActiveItemFollowEffect = 11,
        [FastEnumUtility.Label("AL_FRIENDITEMEFFECT", 0)]
        [FastEnumUtility.Label("Friend Item Effect", 1)]
        FriendItemEffect = 12,
        [FastEnumUtility.Label("AL_DARK_FORCE", 0)]
        [FastEnumUtility.Label("Dark Force", 1)]
        DarkForce = 13,
        [FastEnumUtility.Label("AL_WEDDINGRINGEFFECT", 0)]
        [FastEnumUtility.Label("Wedding Ring Effect", 1)]
        WeddingRingEffect = 14,
        [FastEnumUtility.Label("AL_ENERGY_CHARGE", 0)]
        [FastEnumUtility.Label("Energy Charge", 1)]
        EnergyCharge = 15,
        [FastEnumUtility.Label("AL_DASH", 0)]
        Dash = 16,
        [FastEnumUtility.Label("AL_WINGS", 0)]
        Wings = 17,
        [FastEnumUtility.Label("AL_COUPLECHAIREFFECT", 0)]
        [FastEnumUtility.Label("Couple Chair Effect", 1)]
        CoupleChairEffect = 18,
    }
    public enum AntiMacroOperation : byte
    {
        [FastEnumUtility.Label("AntiMacroReq_Fail_InvalidCharacterName", 0)]
        [FastEnumUtility.Label("Req Fail Invalid Character Name", 1)]
        ReqFailInvalidCharacterName = 0,
        [FastEnumUtility.Label("AntiMacroReq_Fail_NotAttack", 0)]
        [FastEnumUtility.Label("Req Fail Not Attack", 1)]
        ReqFailNotAttack = 1,
        [FastEnumUtility.Label("AntiMacroReq_Fail_NotAvailableTime", 0)]
        [FastEnumUtility.Label("Req Fail Not Available Time", 1)]
        ReqFailNotAvailableTime = 2,
        [FastEnumUtility.Label("AntiMacroReq_Fail_SolvingQuestion", 0)]
        [FastEnumUtility.Label("Req Fail Solving Question", 1)]
        ReqFailSolvingQuestion = 3,
        [FastEnumUtility.Label("AntiMacroReq_Pended", 0)]
        [FastEnumUtility.Label("Req Pended", 1)]
        ReqPended = 4,
        [FastEnumUtility.Label("AntiMacroReq_Success", 0)]
        [FastEnumUtility.Label("Req Success", 1)]
        ReqSuccess = 5,
        [FastEnumUtility.Label("AntiMacroRes", 0)]
        Res = 6,
        [FastEnumUtility.Label("AntiMacroRes_Fail", 0)]
        [FastEnumUtility.Label("Res Fail", 1)]
        ResFail = 7,
        [FastEnumUtility.Label("AntiMacroRes_TargetFail", 0)]
        [FastEnumUtility.Label("Res Target Fail", 1)]
        ResTargetFail = 8,
        [FastEnumUtility.Label("AntiMacroRes_Success", 0)]
        [FastEnumUtility.Label("Res Success", 1)]
        ResSuccess = 9,
        [FastEnumUtility.Label("AntiMacroRes_TargetSuccess", 0)]
        [FastEnumUtility.Label("Res Target Success", 1)]
        ResTargetSuccess = 10,
        [FastEnumUtility.Label("AntiMacroRes_Reward", 0)]
        [FastEnumUtility.Label("Res Reward", 1)]
        ResReward = 11,
    }
    public enum AntiMacroRequestType : byte
    {
        [FastEnumUtility.Label("AntiMacroUserRequest", 0)]
        UserRequest = 1,
        [FastEnumUtility.Label("AntiMacroAdminRequest", 0)]
        AdminRequest = 2,
        [FastEnumUtility.Label("AntiMacroAutoRequest", 0)]
        AutoRequest = 3,
        [FastEnumUtility.Label("AntiMacroFieldRequest", 0)]
        FieldRequest = 4,
    }
    public enum AttackActionType : byte
    {
        [FastEnumUtility.Label("AAT_OneHand", 0)]
        [FastEnumUtility.Label("One Hand", 1)]
        OneHand = 1,
        [FastEnumUtility.Label("AAT_Spear_PoleArm", 0)]
        [FastEnumUtility.Label("Spear Pole Arm", 1)]
        SpearPoleArm = 2,
        [FastEnumUtility.Label("AAT_Bow", 0)]
        Bow = 3,
        [FastEnumUtility.Label("AAT_CrossBow", 0)]
        [FastEnumUtility.Label("Cross Bow", 1)]
        CrossBow = 4,
        [FastEnumUtility.Label("AAT_TowHand", 0)]
        [FastEnumUtility.Label("Two Hand", 1)]
        TwoHand = 5,
        [FastEnumUtility.Label("AAT_Staff_Wand", 0)]
        [FastEnumUtility.Label("Staff Wand", 1)]
        StaffWand = 6,
        [FastEnumUtility.Label("AAT_ThrowingGloves", 0)]
        [FastEnumUtility.Label("Throwing Gloves", 1)]
        ThrowingGloves = 7,
        [FastEnumUtility.Label("AAT_Knuckle", 0)]
        Knuckle = 8,
        [FastEnumUtility.Label("AAT_Gun", 0)]
        Gun = 9,
        [FastEnumUtility.Label("AAT_DualDagger", 0)]
        [FastEnumUtility.Label("Dual Dagger", 1)]
        DualDagger = 10,
    }
    public enum AttackIndex
    {
        [FastEnumUtility.Label("AttackIndex_Mob_Physical", 0)]
        [FastEnumUtility.Label("Mob Physical", 1)]
        MobPhysical = 0,
        [FastEnumUtility.Label("AttackIndex_Mob_Magic", 0)]
        [FastEnumUtility.Label("Mob Magic", 1)]
        MobMagic = -1,
        [FastEnumUtility.Label("AttackIndex_Counter", 0)]
        Counter = -2,
        [FastEnumUtility.Label("AttackIndex_Obstacle", 0)]
        Obstacle = -3,
        [FastEnumUtility.Label("AttackIndex_Stat", 0)]
        Stat = -4,
    }
    public enum AttackType : byte
    {
        Melee = 0,
        Shoot = 1,
        Magic = 2,
        Body = 3,
    }
    public enum AuraType : byte
    {
        [FastEnumUtility.Label("AURA_ALL", 0)]
        All = 0,
        [FastEnumUtility.Label("AURA_DARK_BLUE", 0)]
        [FastEnumUtility.Label("Dark Blue", 1)]
        DarkBlue = 1,
        [FastEnumUtility.Label("AURA_DARK_YELLOW", 0)]
        [FastEnumUtility.Label("Dark Yellow", 1)]
        DarkYellow = 2,
        [FastEnumUtility.Label("AURA_BLUE_YELOW", 0)]
        [FastEnumUtility.Label("Blue Yellow", 1)]
        BlueYellow = 3,
    }
    public enum AuthOptionCode
    {
        [FastEnumUtility.Label("AuthOption_NoOption", 0)]
        [FastEnumUtility.Label("No Option", 1)]
        NoOption = 0,
        [FastEnumUtility.Label("AuthOption_NotAllowed", 0)]
        [FastEnumUtility.Label("Not Allowed", 1)]
        NotAllowed = 1,
        [FastEnumUtility.Label("AuthOption_MaxConnected", 0)]
        [FastEnumUtility.Label("Max Connected", 1)]
        MaxConnected = 2,
        [FastEnumUtility.Label("AuthOption_Expired", 0)]
        Expired = 3,
        [FastEnumUtility.Label("AuthOption_WelcomeAddress", 0)]
        [FastEnumUtility.Label("Welcome Address", 1)]
        WelcomeAddress = 11,
        [FastEnumUtility.Label("AuthOption_WelcomeTrial", 0)]
        [FastEnumUtility.Label("Welcome Trial", 1)]
        WelcomeTrial = 13,
        [FastEnumUtility.Label("AuthOption_PrepaidExhausted", 0)]
        [FastEnumUtility.Label("Prepaid Exhausted", 1)]
        PrepaidExhausted = 19,
        [FastEnumUtility.Label("AuthOption_NotAvailableTime", 0)]
        [FastEnumUtility.Label("Not Available Time", 1)]
        NotAvailableTime = 25,
        [FastEnumUtility.Label("AuthOption_DiffrentIPNotAllowed", 0)]
        [FastEnumUtility.Label("Different Ip Not Allowed", 1)]
        DifferentIpNotAllowed = 27,
        [FastEnumUtility.Label("Account Machine Id Blocked", 1)]
        [FastEnumUtility.Label("AuthOption_AccountMachineIDBlocked", 0)]
        AccountMachineIdBlocked = 28,
    }
    public enum AutoSpeakingType : byte
    {
        [FastEnumUtility.Label("AUTOSPEAKING_LEVELUP", 0)]
        [FastEnumUtility.Label("Level Up", 1)]
        LevelUp = 0,
        [FastEnumUtility.Label("AUTOSPEAKING_PRELEVELUP", 0)]
        [FastEnumUtility.Label("Pre Level Up", 1)]
        PreLevelUp = 1,
        [FastEnumUtility.Label("AUTOSPEAKING_REST", 0)]
        Rest = 2,
        [FastEnumUtility.Label("AUTOSPEAKING_HPALERT", 0)]
        [FastEnumUtility.Label("Hp Alert", 1)]
        HpAlert = 3,
        [FastEnumUtility.Label("AUTOSPEAKING_NOHPPOTION", 0)]
        [FastEnumUtility.Label("No Hp Potion", 1)]
        NoHpPotion = 4,
        [FastEnumUtility.Label("AUTOSPEAKING_NOMPPOTION", 0)]
        [FastEnumUtility.Label("No Mp Potion", 1)]
        NoMpPotion = 5,
    }
    [System.Flags]
    public enum AvatarChangeFlag : byte
    {
        None = 0,
        [FastEnumUtility.Label("AVATAR_LOOK", 0)]
        Look = 1,
        [FastEnumUtility.Label("AVATAR_SPEED", 0)]
        Speed = 2,
        [FastEnumUtility.Label("AVATAR_CHOCO", 0)]
        Choco = 4,
    }
    public enum BackgroundType : byte
    {
        Static = 0,
        [FastEnumUtility.Label("Horizontal Scroll", 1)]
        HScroll = 1,
        [FastEnumUtility.Label("Vertical Scroll", 1)]
        VScroll = 2,
        [FastEnumUtility.Label("Horizontal Tile", 1)]
        HTile = 3,
        [FastEnumUtility.Label("Vertical Tile", 1)]
        VTile = 4,
        [FastEnumUtility.Label("Horizontal+Vertical Tile", 1)]
        HVTile = 5,
        [FastEnumUtility.Label("Horizontal Tile Scroll", 1)]
        HTileScroll = 6,
        [FastEnumUtility.Label("Vertical Tile Scroll", 1)]
        VTileScroll = 7,
    }
    public enum BattlefieldTeam : byte
    {
        [FastEnumUtility.Label("BATTLEFIELD_TEAM_NONE", 0)]
        None = 255,
        [FastEnumUtility.Label("BATTLEFIELD_TEAM_SHEEP", 0)]
        Sheep = 0,
        [FastEnumUtility.Label("BATTLEFIELD_TEAM_WOLVES", 0)]
        Wolves = 1,
        [FastEnumUtility.Label("BATTLEFIELD_TEAM_SHEEP_NAKED", 0)]
        [FastEnumUtility.Label("Sheep Naked", 1)]
        SheepNaked = 2,
    }
    public enum BodyChangeType : byte
    {
        [FastEnumUtility.Label("CHANGEBODY_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("CHANGEBODY_GHOST", 0)]
        Ghost = 1,
        [FastEnumUtility.Label("CHANGEBODY_UFO", 0)]
        Ufo = 2,
    }
    public enum BossMobId
    {
        [FastEnumUtility.Label("ZAKUM1_MOB_ID", 0)]
        Zakum1 = 8800000,
        [FastEnumUtility.Label("ZAKUM2_MOB_ID", 0)]
        Zakum2 = 8800001,
        [FastEnumUtility.Label("ZAKUM3_MOB_ID", 0)]
        Zakum3 = 8800002,
        [FastEnumUtility.Label("ZAKUMARM1_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm1", 1)]
        ZakumArm1 = 8800003,
        [FastEnumUtility.Label("ZAKUMARM2_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm2", 1)]
        ZakumArm2 = 8800004,
        [FastEnumUtility.Label("ZAKUMARM3_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm3", 1)]
        ZakumArm3 = 8800005,
        [FastEnumUtility.Label("ZAKUMARM4_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm4", 1)]
        ZakumArm4 = 8800006,
        [FastEnumUtility.Label("ZAKUMARM5_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm5", 1)]
        ZakumArm5 = 8800007,
        [FastEnumUtility.Label("ZAKUMARM6_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm6", 1)]
        ZakumArm6 = 8800008,
        [FastEnumUtility.Label("ZAKUMARM7_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm7", 1)]
        ZakumArm7 = 8800009,
        [FastEnumUtility.Label("ZAKUMARM8_MOB_ID", 0)]
        [FastEnumUtility.Label("Zakum Arm8", 1)]
        ZakumArm8 = 8800010,
        [FastEnumUtility.Label("CHAOSZAKUM1_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum1", 1)]
        ChaosZakum1 = 8800100,
        [FastEnumUtility.Label("CHAOSZAKUM2_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum2", 1)]
        ChaosZakum2 = 8800101,
        [FastEnumUtility.Label("CHAOSZAKUM3_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum3", 1)]
        ChaosZakum3 = 8800102,
        [FastEnumUtility.Label("CHAOSZAKUMARM1_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm1", 1)]
        ChaosZakumArm1 = 8800103,
        [FastEnumUtility.Label("CHAOSZAKUMARM2_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm2", 1)]
        ChaosZakumArm2 = 8800104,
        [FastEnumUtility.Label("CHAOSZAKUMARM3_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm3", 1)]
        ChaosZakumArm3 = 8800105,
        [FastEnumUtility.Label("CHAOSZAKUMARM4_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm4", 1)]
        ChaosZakumArm4 = 8800106,
        [FastEnumUtility.Label("CHAOSZAKUMARM5_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm5", 1)]
        ChaosZakumArm5 = 8800107,
        [FastEnumUtility.Label("CHAOSZAKUMARM6_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm6", 1)]
        ChaosZakumArm6 = 8800108,
        [FastEnumUtility.Label("CHAOSZAKUMARM7_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm7", 1)]
        ChaosZakumArm7 = 8800109,
        [FastEnumUtility.Label("CHAOSZAKUMARM8_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Zakum Arm8", 1)]
        ChaosZakumArm8 = 8800110,
        [FastEnumUtility.Label("HONTAIL1_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 1", 1)]
        Hontail1 = 8810000,
        [FastEnumUtility.Label("HONTAIL2_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 2", 1)]
        Hontail2 = 8810001,
        [FastEnumUtility.Label("HONTAIL3_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 3", 1)]
        Hontail3 = 8810002,
        [FastEnumUtility.Label("HONTAIL4_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 4", 1)]
        Hontail4 = 8810003,
        [FastEnumUtility.Label("HONTAIL5_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 5", 1)]
        Hontail5 = 8810004,
        [FastEnumUtility.Label("HONTAIL6_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 6", 1)]
        Hontail6 = 8810005,
        [FastEnumUtility.Label("HONTAIL7_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 7", 1)]
        Hontail7 = 8810006,
        [FastEnumUtility.Label("HONTAIL8_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 8", 1)]
        Hontail8 = 8810007,
        [FastEnumUtility.Label("HONTAIL9_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 9", 1)]
        Hontail9 = 8810008,
        [FastEnumUtility.Label("HONTAIL10_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 10", 1)]
        Hontail10 = 8810009,
        [FastEnumUtility.Label("HONTAIL11_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 11", 1)]
        Hontail11 = 8810010,
        [FastEnumUtility.Label("HONTAIL12_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 12", 1)]
        Hontail12 = 8810011,
        [FastEnumUtility.Label("HONTAIL13_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 13", 1)]
        Hontail13 = 8810012,
        [FastEnumUtility.Label("HONTAIL14_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 14", 1)]
        Hontail14 = 8810013,
        [FastEnumUtility.Label("HONTAIL15_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 15", 1)]
        Hontail15 = 8810014,
        [FastEnumUtility.Label("HONTAIL16_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 16", 1)]
        Hontail16 = 8810015,
        [FastEnumUtility.Label("HONTAIL17_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 17", 1)]
        Hontail17 = 8810016,
        [FastEnumUtility.Label("HONTAIL18_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 18", 1)]
        Hontail18 = 8810017,
        [FastEnumUtility.Label("HONTAIL19_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 19", 1)]
        Hontail19 = 8810018,
        [FastEnumUtility.Label("HONTAIL20_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 20", 1)]
        Hontail20 = 8810024,
        [FastEnumUtility.Label("HONTAIL21_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 21", 1)]
        Hontail21 = 8810025,
        [FastEnumUtility.Label("HONTAIL22_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Part 22", 1)]
        Hontail22 = 8810026,
        [FastEnumUtility.Label("HONTALE_LEFTHEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Left Head", 1)]
        HontaleLeftHead = 8810000,
        [FastEnumUtility.Label("HONTALE_RIGHTHEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Right Head", 1)]
        HontaleRightHead = 8810001,
        [FastEnumUtility.Label("HONTALE_HEAD1_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Main Head 1", 1)]
        HontaleHead1 = 8810002,
        [FastEnumUtility.Label("HONTALE_HEAD2_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Main Head 2", 1)]
        HontaleHead2 = 8810003,
        [FastEnumUtility.Label("HONTALE_HEAD3_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Main Head 3", 1)]
        HontaleHead3 = 8810004,
        [FastEnumUtility.Label("HONTALE_LEFTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Left Hand", 1)]
        HontaleLeftHand = 8810005,
        [FastEnumUtility.Label("HONTALE_RIGHTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Right Hand", 1)]
        HontaleRightHand = 8810006,
        [FastEnumUtility.Label("HONTALE_WING_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Wings", 1)]
        HontaleWing = 8810007,
        [FastEnumUtility.Label("HONTALE_LEG_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Legs", 1)]
        HontaleLeg = 8810008,
        [FastEnumUtility.Label("HONTALE_TAIL_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Tail", 1)]
        HontaleTail = 8810009,
        [FastEnumUtility.Label("DEADHONTALE_HEAD1_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Head 1", 1)]
        DeadHontaleHead1 = 8810010,
        [FastEnumUtility.Label("DEADHONTALE_HEAD2_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Head 2", 1)]
        DeadHontaleHead2 = 8810011,
        [FastEnumUtility.Label("DEADHONTALE_HEAD3_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Head 3", 1)]
        DeadHontaleHead3 = 8810012,
        [FastEnumUtility.Label("DEADHONTALE_LEFTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Left Hand", 1)]
        DeadHontaleLeftHand = 8810013,
        [FastEnumUtility.Label("DEADHONTALE_RIGHTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Right Hand", 1)]
        DeadHontaleRightHand = 8810014,
        [FastEnumUtility.Label("DEADHONTALE_WING_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Wings", 1)]
        DeadHontaleWing = 8810015,
        [FastEnumUtility.Label("DEADHONTALE_LEG_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Legs", 1)]
        DeadHontaleLeg = 8810016,
        [FastEnumUtility.Label("DEADHONTALE_TAIL_MOB_ID", 0)]
        [FastEnumUtility.Label("Dead Horntail Tail", 1)]
        DeadHontaleTail = 8810017,
        [FastEnumUtility.Label("HONTALE_SPIRIT_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Spirit Form", 1)]
        HontaleSpirit = 8810018,
        [FastEnumUtility.Label("HONTALE_SUMMONED", 0)]
        [FastEnumUtility.Label("Horntail Summoned Mob", 1)]
        HontaleSummoned = 8810026,
        [FastEnumUtility.Label("HONTALE_BASE_MOB_ID", 0)]
        [FastEnumUtility.Label("Horntail Base ID", 1)]
        HontaleBase = 8810000,
        [FastEnumUtility.Label("CHAOSHONTALE_LEFTHEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Left Head", 1)]
        ChaosHontaleLeftHead = 8810100,
        [FastEnumUtility.Label("CHAOSHONTALE_RIGHTHEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Right Head", 1)]
        ChaosHontaleRightHead = 8810101,
        [FastEnumUtility.Label("CHAOSHONTALE_HEAD1_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Head 1", 1)]
        ChaosHontaleHead1 = 8810102,
        [FastEnumUtility.Label("CHAOSHONTALE_HEAD2_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Head 2", 1)]
        ChaosHontaleHead2 = 8810103,
        [FastEnumUtility.Label("CHAOSHONTALE_HEAD3_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Head 3", 1)]
        ChaosHontaleHead3 = 8810104,
        [FastEnumUtility.Label("CHAOSHONTALE_LEFTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Left Hand", 1)]
        ChaosHontaleLeftHand = 8810105,
        [FastEnumUtility.Label("CHAOSHONTALE_RIGHTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Right Hand", 1)]
        ChaosHontaleRightHand = 8810106,
        [FastEnumUtility.Label("CHAOSHONTALE_WING_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Wings", 1)]
        ChaosHontaleWing = 8810107,
        [FastEnumUtility.Label("CHAOSHONTALE_LEG_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Legs", 1)]
        ChaosHontaleLeg = 8810108,
        [FastEnumUtility.Label("CHAOSHONTALE_TAIL_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Tail", 1)]
        ChaosHontaleTail = 8810109,
        [FastEnumUtility.Label("CHAOSHONTALE_SPIRIT_MOB1_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Spirit 1", 1)]
        ChaosHontaleSpiritMob1 = 8810118,
        [FastEnumUtility.Label("CHAOSHONTALE_SPIRIT_MOB2_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Spirit 2", 1)]
        ChaosHontaleSpiritMob2 = 8810119,
        [FastEnumUtility.Label("CHAOSHONTALE_SPIRIT_MOB3_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Spirit 3", 1)]
        ChaosHontaleSpiritMob3 = 8810120,
        [FastEnumUtility.Label("CHAOSHONTALE_SPIRIT_MOB4_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Spirit 4", 1)]
        ChaosHontaleSpiritMob4 = 8810121,
        [FastEnumUtility.Label("CHAOSHONTALE_SPIRIT_MOB5_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Spirit 5", 1)]
        ChaosHontaleSpiritMob5 = 8810122,
        [FastEnumUtility.Label("CHAOSHONTALE_SUMMONED", 0)]
        [FastEnumUtility.Label("Chaos Horntail Summoned Mob", 1)]
        ChaosHontaleSummoned = 8810130,
        [FastEnumUtility.Label("CHAOSHONTALE_BASE_MOB_ID", 0)]
        [FastEnumUtility.Label("Chaos Horntail Base ID", 1)]
        ChaosHontaleBase = 8810100,
        [FastEnumUtility.Label("BABYBOSS_FIXED_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Fixed", 1)]
        BabybossFixed = 8820000,
        [FastEnumUtility.Label("BABYBOSS_MOB_ID", 0)]
        Babyboss = 8820001,
        [FastEnumUtility.Label("BABYBOSS_MIRRORGODDESS_STATUE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Mirror Goddess Statue", 1)]
        BabybossMirrorGoddessStatue = 8820002,
        [FastEnumUtility.Label("BABYBOSS_LEFTHUMAN_STATUE_TURNTOSTONE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Human Statue Turn To Stone", 1)]
        BabybossLeftHumanStatueTurnToStone = 8820003,
        [FastEnumUtility.Label("BABYBOSS_RIGHTHUMAN_STATUE_TURNTOSTONE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Human Statue Turn To Stone", 1)]
        BabybossRightHumanStatueTurnToStone = 8820004,
        [FastEnumUtility.Label("BABYBOSS_LEFTBIRD_STATUE_TURNTOSTONE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Bird Statue Turn To Stone", 1)]
        BabybossLeftBirdStatueTurnToStone = 8820005,
        [FastEnumUtility.Label("BABYBOSS_RIGHTBIRD_STATUE_TURNTOSTONE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Bird Statue Turn To Stone", 1)]
        BabybossRightBirdStatueTurnToStone = 8820006,
        [FastEnumUtility.Label("BABYBOSS_KID_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Kid", 1)]
        BabybossKid = 8820007,
        [FastEnumUtility.Label("BABYBOSS_FIXED_SUMMONER_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Fixed Summoner", 1)]
        BabybossFixedSummoner = 8820008,
        [FastEnumUtility.Label("BABYBOSS_DUMMY0_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Dummy0", 1)]
        BabybossDummy0 = 8820009,
        [FastEnumUtility.Label("BABYBOSS_DUMMY1_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Dummy1", 1)]
        BabybossDummy1 = 8820010,
        [FastEnumUtility.Label("BABYBOSS_DUMMY2_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Dummy2", 1)]
        BabybossDummy2 = 8820011,
        [FastEnumUtility.Label("BABYBOSS_DUMMY3_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Dummy3", 1)]
        BabybossDummy3 = 8820012,
        [FastEnumUtility.Label("BABYBOSS_DUMMY4_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Dummy4", 1)]
        BabybossDummy4 = 8820013,
        [FastEnumUtility.Label("BABYBOSS_DUMMY5_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Dummy5", 1)]
        BabybossDummy5 = 8820014,
        [FastEnumUtility.Label("BABYBOSS_LEFTHUMAN_STATUE_CRUMBLE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Human Statue Crumble", 1)]
        BabybossLeftHumanStatueCrumble = 8820015,
        [FastEnumUtility.Label("BABYBOSS_RIGHTHUMAN_STATUE_CRUMBLE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Human Statue Crumble", 1)]
        BabybossRightHumanStatueCrumble = 8820016,
        [FastEnumUtility.Label("BABYBOSS_LEFTBIRD_STATUE_CRUMBLE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Bird Statue Crumble", 1)]
        BabybossLeftBirdStatueCrumble = 8820017,
        [FastEnumUtility.Label("BABYBOSS_RIGHTBIRD_STATUE_CRUMBLE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Bird Statue Crumble", 1)]
        BabybossRightBirdStatueCrumble = 8820018,
        [FastEnumUtility.Label("BABYBOSS_MIRRORGODDESS_STATUE_CRUMBLE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Mirror Goddess Statue Crumble", 1)]
        BabybossMirrorGoddessStatueCrumble = 8820019,
        [FastEnumUtility.Label("BABYBOSS_LEFTHUMAN_STATUE_CRUMBLE2_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Human Statue Crumble2", 1)]
        BabybossLeftHumanStatueCrumble2 = 8820020,
        [FastEnumUtility.Label("BABYBOSS_RIGHTHUMAN_STATUE_CRUMBLE2_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Human Statue Crumble2", 1)]
        BabybossRightHumanStatueCrumble2 = 8820021,
        [FastEnumUtility.Label("BABYBOSS_LEFTBIRD_STATUE_CRUMBLE2_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Bird Statue Crumble2", 1)]
        BabybossLeftBirdStatueCrumble2 = 8820022,
        [FastEnumUtility.Label("BABYBOSS_RIGHTBIRD_STATUE_CRUMBLE2_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Bird Statue Crumble2", 1)]
        BabybossRightBirdStatueCrumble2 = 8820023,
        [FastEnumUtility.Label("BABYBOSS_LEFTHUMAN_STATUE_CRUMBLE3_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Human Statue Crumble3", 1)]
        BabybossLeftHumanStatueCrumble3 = 8820024,
        [FastEnumUtility.Label("BABYBOSS_RIGHTHUMAN_STATUE_CRUMBLE3_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Human Statue Crumble3", 1)]
        BabybossRightHumanStatueCrumble3 = 8820025,
        [FastEnumUtility.Label("BABYBOSS_LEFTBIRD_STATUE_CRUMBLE3_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Left Bird Statue Crumble3", 1)]
        BabybossLeftBirdStatueCrumble3 = 8820026,
        [FastEnumUtility.Label("BABYBOSS_RIGHTBIRD_STATUE_CRUMBLE3_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Right Bird Statue Crumble3", 1)]
        BabybossRightBirdStatueCrumble3 = 8820027,
        [FastEnumUtility.Label("BABYBOSS_BASE_MOB_ID", 0)]
        [FastEnumUtility.Label("Babyboss Base", 1)]
        BabybossBase = 8820000,
        [FastEnumUtility.Label("BALROG_BODY_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Body", 1)]
        BalrogBody = 8830000,
        [FastEnumUtility.Label("BALROG_LEFTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Left Hand", 1)]
        BalrogLeftHand = 8830001,
        [FastEnumUtility.Label("BALROG_RIGHTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Right Hand", 1)]
        BalrogRightHand = 8830002,
        [FastEnumUtility.Label("BALROG_SPIRIT_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Spirit", 1)]
        BalrogSpirit = 8830003,
        [FastEnumUtility.Label("BALROG_LEFTDEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Left Dead", 1)]
        BalrogLeftDead = 8830004,
        [FastEnumUtility.Label("BALROG_RIGHTDEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Right Dead", 1)]
        BalrogRightDead = 8830005,
        [FastEnumUtility.Label("BALROG_LEFTDUMMY_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Left Dummy", 1)]
        BalrogLeftDummy = 8830006,
        [FastEnumUtility.Label("BALROG_BASE_MOB_ID", 0)]
        [FastEnumUtility.Label("Balrog Base", 1)]
        BalrogBase = 8830000,
        [FastEnumUtility.Label("EASYBALROG_BODY_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Body", 1)]
        EasyBalrogBody = 8830007,
        [FastEnumUtility.Label("EASYBALROG_LEFTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Left Hand", 1)]
        EasyBalrogLeftHand = 8830008,
        [FastEnumUtility.Label("EASYBALROG_RIGHTHAND_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Right Hand", 1)]
        EasyBalrogRightHand = 8830009,
        [FastEnumUtility.Label("EASYBALROG_SPIRIT_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Spirit", 1)]
        EasyBalrogSpirit = 8830010,
        [FastEnumUtility.Label("EASYBALROG_LEFTDEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Left Dead", 1)]
        EasyBalrogLeftDead = 8830011,
        [FastEnumUtility.Label("EASYBALROG_RIGHTDEAD_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Right Dead", 1)]
        EasyBalrogRightDead = 8830012,
        [FastEnumUtility.Label("EASYBALROG_LEFTDUMMY_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Left Dummy", 1)]
        EasyBalrogLeftDummy = 8830013,
        [FastEnumUtility.Label("EASYBALROG_BASE_MOB_ID", 0)]
        [FastEnumUtility.Label("Easy Balrog Base", 1)]
        EasyBalrogBase = 8830007,
        [FastEnumUtility.Label("FIXED_MOB_ID", 0)]
        Fixed = 9999999,
        [FastEnumUtility.Label("TRANSPARENT_MOB_ID", 0)]
        Transparent = 9300216,
        [FastEnumUtility.Label("MASSACRE_TRANSPARENT_MOB1_ID", 0)]
        [FastEnumUtility.Label("Massacre Transparent Mob1", 1)]
        MassacreTransparentMob1 = 9700022,
        [FastEnumUtility.Label("MASSACRE_TRANSPARENT_MOB2_ID", 0)]
        [FastEnumUtility.Label("Massacre Transparent Mob2", 1)]
        MassacreTransparentMob2 = 9700023,
        [FastEnumUtility.Label("CAPTAIN_OF_PHANTOM_SHIP_MOB_ID", 0)]
        [FastEnumUtility.Label("Captain Of Phantom Ship", 1)]
        CaptainOfPhantomShip = 9700037,
        [FastEnumUtility.Label("ADBALLOON_7TH_ANNIVERSARY_MOB_ID", 0)]
        [FastEnumUtility.Label("Ad Balloon7th Anniversary", 1)]
        AdBalloon7thAnniversary = 9500401,
    }
    public enum BridleFailReason : byte
    {
        [FastEnumUtility.Label("BRIDLE_FAIL_HP", 0)]
        Hp = 0,
        [FastEnumUtility.Label("BRIDLE_FAIL_DELAY", 0)]
        Delay = 1,
    }
    public enum BroadcastMessageType : byte
    {
        [FastEnumUtility.Label("BM_NOTICE", 0)]
        Notice = 0,
        [FastEnumUtility.Label("BM_ALERT", 0)]
        Alert = 1,
        [FastEnumUtility.Label("BM_SPEAKERCHANNEL", 0)]
        [FastEnumUtility.Label("Speaker Channel", 1)]
        SpeakerChannel = 2,
        [FastEnumUtility.Label("BM_SPEAKERWORLD", 0)]
        [FastEnumUtility.Label("Speaker World", 1)]
        SpeakerWorld = 3,
        [FastEnumUtility.Label("BM_SLIDE", 0)]
        Slide = 4,
        [FastEnumUtility.Label("BM_EVENT", 0)]
        Event = 5,
        [FastEnumUtility.Label("BM_NOTICEWITHOUTPREFIX", 0)]
        [FastEnumUtility.Label("Notice Without Prefix", 1)]
        NoticeWithoutPrefix = 6,
        [FastEnumUtility.Label("BM_UTILDLGEX", 0)]
        [FastEnumUtility.Label("Util Dlg Ex", 1)]
        UtilDlgEx = 7,
        [FastEnumUtility.Label("BM_ITEMSPEAKER", 0)]
        [FastEnumUtility.Label("Item Speaker", 1)]
        ItemSpeaker = 8,
        [FastEnumUtility.Label("BM_SPEAKERBRIDGE", 0)]
        [FastEnumUtility.Label("Speaker Bridge", 1)]
        SpeakerBridge = 9,
        [FastEnumUtility.Label("Art Speaker World", 1)]
        [FastEnumUtility.Label("BM_ARTSPEAKERWORLD", 0)]
        ArtSpeakerWorld = 10,
        [FastEnumUtility.Label("BM_BLOWWEATHER", 0)]
        [FastEnumUtility.Label("Blow Weather", 1)]
        BlowWeather = 11,
        [FastEnumUtility.Label("BM_GACHAPONANNOUNCE", 0)]
        [FastEnumUtility.Label("Gachapon Announce", 1)]
        GachaponAnnounce = 12,
        [FastEnumUtility.Label("BM_GACHAPONANNOUNCE_OPEN", 0)]
        [FastEnumUtility.Label("Gachapon Announce Open", 1)]
        GachaponAnnounceOpen = 13,
        [FastEnumUtility.Label("BM_GACHAPONANNOUNCE_COPY", 0)]
        [FastEnumUtility.Label("Gachapon Announce Copy", 1)]
        GachaponAnnounceCopy = 14,
        [FastEnumUtility.Label("BM_ULISTCLIP", 0)]
        [FastEnumUtility.Label("UList Clip", 1)]
        UListClip = 15,
        [FastEnumUtility.Label("BM_FREEMARKETCLIP", 0)]
        [FastEnumUtility.Label("Free Market Clip", 1)]
        FreeMarketClip = 16,
        [FastEnumUtility.Label("BM_DESTROYSHOP", 0)]
        [FastEnumUtility.Label("Destroy Shop", 1)]
        DestroyShop = 17,
        [FastEnumUtility.Label("BM_CASHSHOPAD", 0)]
        [FastEnumUtility.Label("Cash Shop Ad", 1)]
        CashShopAd = 18,
        [FastEnumUtility.Label("BM_HEARTSPEAKER", 0)]
        [FastEnumUtility.Label("Heart Speaker", 1)]
        HeartSpeaker = 19,
        [FastEnumUtility.Label("BM_SKULLSPEAKER", 0)]
        [FastEnumUtility.Label("Skull Speaker", 1)]
        SkullSpeaker = 20,
    }
    public enum CakePieEventStep : byte
    {
        [FastEnumUtility.Label("CakePieEvent_Step_None", 0)]
        None = 0,
        [FastEnumUtility.Label("CakePieEvent_Step_Ready", 0)]
        Ready = 1,
        [FastEnumUtility.Label("CakePieEvent_Step_Event", 0)]
        Event = 2,
        [FastEnumUtility.Label("CakePieEvent_Step_Winner", 0)]
        Winner = 3,
    }
    public enum CashCommodityType : byte
    {
        [FastEnumUtility.Label("CS_COMMODITY_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("CS_COMMODITY_LIMITED", 0)]
        Limited = 1,
        [FastEnumUtility.Label("CS_COMMODITY_LIMITED_FIRST_CASH", 0)]
        [FastEnumUtility.Label("Limited First Cash", 1)]
        LimitedFirstCash = 2,
        [FastEnumUtility.Label("CS_COMMODITY_LIMITED_NXCID", 0)]
        [FastEnumUtility.Label("Limited Nxc Id", 1)]
        LimitedNxcId = 3,
    }
    public enum CashItemFailReason : byte
    {
        [FastEnumUtility.Label("CashItemFailReason_Unknown", 0)]
        Unknown = 0,
        [FastEnumUtility.Label("CashItemFailReason_Timeout", 0)]
        Timeout = 1,
        [FastEnumUtility.Label("Cash Daemon DB Error", 1)]
        [FastEnumUtility.Label("CashItemFailReason_CashDaemonDBError", 0)]
        CashDaemonDBError = 2,
        [FastEnumUtility.Label("CashItemFailReason_NoRemainCash", 0)]
        [FastEnumUtility.Label("No Remain Cash", 1)]
        NoRemainCash = 3,
        [FastEnumUtility.Label("CashItemFailReason_GiftUnderAge", 0)]
        [FastEnumUtility.Label("Gift Under Age", 1)]
        GiftUnderAge = 4,
        [FastEnumUtility.Label("CashItemFailReason_GiftLimitOver", 0)]
        [FastEnumUtility.Label("Gift Limit Over", 1)]
        GiftLimitOver = 5,
        [FastEnumUtility.Label("CashItemFailReason_GiftSameAccount", 0)]
        [FastEnumUtility.Label("Gift Same Account", 1)]
        GiftSameAccount = 6,
        [FastEnumUtility.Label("CashItemFailReason_GiftUnknownRecipient", 0)]
        [FastEnumUtility.Label("Gift Unknown Recipient", 1)]
        GiftUnknownRecipient = 7,
        [FastEnumUtility.Label("CashItemFailReason_GiftRecipientGenderMismatch", 0)]
        [FastEnumUtility.Label("Gift Recipient Gender Mismatch", 1)]
        GiftRecipientGenderMismatch = 8,
        [FastEnumUtility.Label("CashItemFailReason_GiftRecipientLockerFull", 0)]
        [FastEnumUtility.Label("Gift Recipient Locker Full", 1)]
        GiftRecipientLockerFull = 9,
        [FastEnumUtility.Label("Buy Stored Proc Failed", 1)]
        [FastEnumUtility.Label("CashItemFailReason_BuyStoredProcFailed", 0)]
        BuyStoredProcFailed = 10,
        [FastEnumUtility.Label("CashItemFailReason_GiftStoredProcFailed", 0)]
        [FastEnumUtility.Label("Gift Stored Proc Failed", 1)]
        GiftStoredProcFailed = 11,
        [FastEnumUtility.Label("CashItemFailReason_GiftNoReceiveCharacter", 0)]
        [FastEnumUtility.Label("Gift No Receive Character", 1)]
        GiftNoReceiveCharacter = 12,
        [FastEnumUtility.Label("CashItemFailReason_GiftNoSenderCharacter", 0)]
        [FastEnumUtility.Label("Gift No Sender Character", 1)]
        GiftNoSenderCharacter = 13,
        [FastEnumUtility.Label("CashItemFailReason_InvalidCoupon", 0)]
        [FastEnumUtility.Label("Invalid Coupon", 1)]
        InvalidCoupon = 14,
        [FastEnumUtility.Label("CashItemFailReason_InvalidCoupon_UserBan", 0)]
        [FastEnumUtility.Label("Invalid Coupon User Ban", 1)]
        InvalidCouponUserBan = 15,
        [FastEnumUtility.Label("CashItemFailReason_ExpiredCoupon", 0)]
        [FastEnumUtility.Label("Expired Coupon", 1)]
        ExpiredCoupon = 16,
        [FastEnumUtility.Label("CashItemFailReason_UsedCoupon", 0)]
        [FastEnumUtility.Label("Used Coupon", 1)]
        UsedCoupon = 17,
        [FastEnumUtility.Label("CashItemFailReason_CouponForCafeOnly", 0)]
        [FastEnumUtility.Label("Coupon For Cafe Only", 1)]
        CouponForCafeOnly = 18,
        [FastEnumUtility.Label("CashItemFailReason_CouponForCafeOnly_Used", 0)]
        [FastEnumUtility.Label("Coupon For Cafe Only Used", 1)]
        CouponForCafeOnlyUsed = 19,
        [FastEnumUtility.Label("CashItemFailReason_CouponForCafeOnly_Expired", 0)]
        [FastEnumUtility.Label("Coupon For Cafe Only Expired", 1)]
        CouponForCafeOnlyExpired = 20,
        [FastEnumUtility.Label("CashItemFailReason_NotAvailableCoupon", 0)]
        [FastEnumUtility.Label("Not Available Coupon", 1)]
        NotAvailableCoupon = 21,
        [FastEnumUtility.Label("CashItemFailReason_GenderMisMatch", 0)]
        [FastEnumUtility.Label("Gender Mismatch", 1)]
        GenderMismatch = 22,
        [FastEnumUtility.Label("CashItemFailReason_GiftNormalItem", 0)]
        [FastEnumUtility.Label("Gift Normal Item", 1)]
        GiftNormalItem = 23,
        [FastEnumUtility.Label("CashItemFailReason_GiftMaplePoint", 0)]
        [FastEnumUtility.Label("Gift Maple Point", 1)]
        GiftMaplePoint = 24,
        [FastEnumUtility.Label("CashItemFailReason_NoEmptyPos", 0)]
        [FastEnumUtility.Label("No Empty Pos", 1)]
        NoEmptyPos = 25,
        [FastEnumUtility.Label("CashItemFailReason_ForPremiumUserOnly", 0)]
        [FastEnumUtility.Label("For Premium User Only", 1)]
        ForPremiumUserOnly = 26,
        [FastEnumUtility.Label("Buy Couple Stored Proc Failed", 1)]
        [FastEnumUtility.Label("CashItemFailReason_BuyCoupleStoredProcFailed", 0)]
        BuyCoupleStoredProcFailed = 27,
        [FastEnumUtility.Label("Buy Friendship Stored Proc Failed", 1)]
        [FastEnumUtility.Label("CashItemFailReason_BuyFriendshipStoredProcFailed", 0)]
        BuyFriendshipStoredProcFailed = 28,
        [FastEnumUtility.Label("CashItemFailReason_NotAvailableTime", 0)]
        [FastEnumUtility.Label("Not Available Time", 1)]
        NotAvailableTime = 29,
        [FastEnumUtility.Label("CashItemFailReason_NoStock", 0)]
        [FastEnumUtility.Label("No Stock", 1)]
        NoStock = 30,
        [FastEnumUtility.Label("CashItemFailReason_PurchaseLimitOver", 0)]
        [FastEnumUtility.Label("Purchase Limit Over", 1)]
        PurchaseLimitOver = 31,
        [FastEnumUtility.Label("CashItemFailReason_NoRemainMeso", 0)]
        [FastEnumUtility.Label("No Remain Meso", 1)]
        NoRemainMeso = 32,
        [FastEnumUtility.Label("CashItemFailReason_NotAuthorizedUser", 0)]
        [FastEnumUtility.Label("Not Authorized User", 1)]
        NotAuthorizedUser = 33,
        [FastEnumUtility.Label("CashItemFailReason_InvalidBirthDate", 0)]
        [FastEnumUtility.Label("Invalid Birth Date", 1)]
        InvalidBirthDate = 34,
        [FastEnumUtility.Label("CashItemFailReason_InvalidPassportID", 0)]
        [FastEnumUtility.Label("Invalid Passport ID", 1)]
        InvalidPassportID = 35,
        [FastEnumUtility.Label("CashItemFailReason_IncorrectSSN2", 0)]
        [FastEnumUtility.Label("Incorrect SSN2", 1)]
        IncorrectSSN2 = 36,
        [FastEnumUtility.Label("CashItemFailReason_ForNoPurchaseExpUsersOnly", 0)]
        [FastEnumUtility.Label("For No Purchase Exp Users Only", 1)]
        ForNoPurchaseExpUsersOnly = 37,
        [FastEnumUtility.Label("Already Applied", 1)]
        [FastEnumUtility.Label("CashItemFailReason_AlreadyApplied", 0)]
        AlreadyApplied = 38,
        [FastEnumUtility.Label("CashItemFailReason_WebShopUnknown", 0)]
        [FastEnumUtility.Label("Web Shop Unknown", 1)]
        WebShopUnknown = 39,
        [FastEnumUtility.Label("CashItemFailReason_WebShopInventoryCount", 0)]
        [FastEnumUtility.Label("Web Shop Inventory Count", 1)]
        WebShopInventoryCount = 40,
        [FastEnumUtility.Label("CashItemFailReason_WebShopBuyStoredProcFailed", 0)]
        [FastEnumUtility.Label("Web Shop Buy Stored Proc Failed", 1)]
        WebShopBuyStoredProcFailed = 41,
        [FastEnumUtility.Label("CashItemFailReason_WebShopInvalidOrder", 0)]
        [FastEnumUtility.Label("Web Shop Invalid Order", 1)]
        WebShopInvalidOrder = 42,
        [FastEnumUtility.Label("CashItemFailReason_GachaponLimitOver", 0)]
        [FastEnumUtility.Label("Gachapon Limit Over", 1)]
        GachaponLimitOver = 43,
        [FastEnumUtility.Label("CashItemFailReason_NoUser", 0)]
        [FastEnumUtility.Label("No User", 1)]
        NoUser = 44,
        [FastEnumUtility.Label("CashItemFailReason_WrongCommoditySN", 0)]
        [FastEnumUtility.Label("Wrong Commodity SN", 1)]
        WrongCommoditySN = 45,
        [FastEnumUtility.Label("CashItemFailReason_CouponLimitError", 0)]
        [FastEnumUtility.Label("Coupon Limit Error", 1)]
        CouponLimitError = 46,
        [FastEnumUtility.Label("Bridge Not Connected", 1)]
        [FastEnumUtility.Label("CashItemFailReason_BridgeNotConnected", 0)]
        BridgeNotConnected = 47,
        [FastEnumUtility.Label("CashItemFailReason_UnderConstruction", 0)]
        [FastEnumUtility.Label("Under Construction", 1)]
        UnderConstruction = 48,
        [FastEnumUtility.Label("Account Age Limit", 1)]
        [FastEnumUtility.Label("CashItemFailReason_Account_Age_limit", 0)]
        AccountAgeLimit = 49,
        [FastEnumUtility.Label("CashItemFailReason_GiftNoMoney", 0)]
        [FastEnumUtility.Label("Gift No Money", 1)]
        GiftNoMoney = 50,
        [FastEnumUtility.Label("CashItemFailReason_DBError", 0)]
        [FastEnumUtility.Label("DB Error", 1)]
        DBError = 51,
        [FastEnumUtility.Label("Age Limit", 1)]
        [FastEnumUtility.Label("CashItemFailReason_AgeLimit", 0)]
        AgeLimit = 52,
        [FastEnumUtility.Label("CashItemFailReason_RestrictSender", 0)]
        [FastEnumUtility.Label("Restrict Sender", 1)]
        RestrictSender = 53,
        [FastEnumUtility.Label("CashItemFailReason_RestrictReceiver", 0)]
        [FastEnumUtility.Label("Restrict Receiver", 1)]
        RestrictReceiver = 54,
        [FastEnumUtility.Label("CashItemFailReason_ExceedLimit", 0)]
        [FastEnumUtility.Label("Exceed Limit", 1)]
        ExceedLimit = 55,
        [FastEnumUtility.Label("CashItemFailReason_UnknownError", 0)]
        [FastEnumUtility.Label("Unknown Error", 1)]
        UnknownError = 56,
        [FastEnumUtility.Label("CashItemFailReason_LevelLimit_20", 0)]
        [FastEnumUtility.Label("Level Limit20", 1)]
        LevelLimit20 = 57,
        [FastEnumUtility.Label("CashItemFailReason_TransferWorldFailed_InvalidWorld_SameWorld", 0)]
        [FastEnumUtility.Label("Transfer World Failed Same World", 1)]
        TransferWorldFailedSameWorld = 58,
        [FastEnumUtility.Label("CashItemFailReason_TransferWorldFailed_InvalidWorld_NewWorld", 0)]
        [FastEnumUtility.Label("Transfer World Failed New World", 1)]
        TransferWorldFailedNewWorld = 59,
        [FastEnumUtility.Label("CashItemFailReason_TransferWorldFailed_InvalidWorld_FromNewWorld", 0)]
        [FastEnumUtility.Label("Transfer World Failed From New World", 1)]
        TransferWorldFailedFromNewWorld = 60,
        [FastEnumUtility.Label("CashItemFailReason_TransferWorldFailed_MaxCharacter", 0)]
        [FastEnumUtility.Label("Transfer World Failed Max Character", 1)]
        TransferWorldFailedMaxCharacter = 61,
        [FastEnumUtility.Label("CashItemFailReason_EventError", 0)]
        [FastEnumUtility.Label("Event Error", 1)]
        EventError = 62,
        [FastEnumUtility.Label("CashItemFailReason_OnlyNXCash", 0)]
        [FastEnumUtility.Label("Only NX Cash", 1)]
        OnlyNXCash = 63,
        [FastEnumUtility.Label("CashItemFailReason_TryAgainRandomBox", 0)]
        [FastEnumUtility.Label("Try Again Random Box", 1)]
        TryAgainRandomBox = 64,
        [FastEnumUtility.Label("Cannot Buy One ADay Item", 1)]
        [FastEnumUtility.Label("CashItemFailReason_CannotBuyOneADayItem", 0)]
        CannotBuyOneADayItem = 65,
        [FastEnumUtility.Label("CashItemFailReason_TooYoungToBuy", 0)]
        [FastEnumUtility.Label("Too Young To Buy", 1)]
        TooYoungToBuy = 66,
        [FastEnumUtility.Label("CashItemFailReason_GiftTooYoungToRecv", 0)]
        [FastEnumUtility.Label("Gift Too Young To Receive", 1)]
        GiftTooYoungToReceive = 67,
        [FastEnumUtility.Label("CashItemFailReason_LimitOverTheItem", 0)]
        [FastEnumUtility.Label("Limit Over The Item", 1)]
        LimitOverTheItem = 68,
        [FastEnumUtility.Label("Cash Lock", 1)]
        [FastEnumUtility.Label("CashItemFailReason_CashLock", 0)]
        CashLock = 69,
    }
    public enum CashItemGachaponState : byte
    {
        [FastEnumUtility.Label("CASHITEMGACHAPON_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("CASHITEMGACHAPON_OPEN_REQUEST", 0)]
        [FastEnumUtility.Label("Open Request", 1)]
        OpenRequest = 1,
        [FastEnumUtility.Label("CASHITEMGACHAPON_GET_REQUEST", 0)]
        [FastEnumUtility.Label("Get Request", 1)]
        GetRequest = 2,
        [FastEnumUtility.Label("CASHITEMGACHAPON_GET_SUCCESS", 0)]
        [FastEnumUtility.Label("Get Success", 1)]
        GetSuccess = 3,
        [FastEnumUtility.Label("CASHITEMGACHAPON_GET_FAIL", 0)]
        [FastEnumUtility.Label("Get Fail", 1)]
        GetFail = 4,
    }
    public enum CashItemOperation : byte
    {
        [FastEnumUtility.Label("CashItemReq_WebShopOrderGetList", 0)]
        [FastEnumUtility.Label("Req Web Shop Order Get List", 1)]
        ReqWebShopOrderGetList = 0,
        [FastEnumUtility.Label("CashItemReq_LoadLocker", 0)]
        [FastEnumUtility.Label("Req Load Locker", 1)]
        ReqLoadLocker = 1,
        [FastEnumUtility.Label("CashItemReq_LoadWish", 0)]
        [FastEnumUtility.Label("Req Load Wish", 1)]
        ReqLoadWish = 2,
        [FastEnumUtility.Label("CashItemReq_Buy", 0)]
        [FastEnumUtility.Label("Req Buy", 1)]
        ReqBuy = 3,
        [FastEnumUtility.Label("CashItemReq_Gift", 0)]
        [FastEnumUtility.Label("Req Gift", 1)]
        ReqGift = 4,
        [FastEnumUtility.Label("CashItemReq_SetWish", 0)]
        [FastEnumUtility.Label("Req Set Wish", 1)]
        ReqSetWish = 5,
        [FastEnumUtility.Label("CashItemReq_IncSlotCount", 0)]
        [FastEnumUtility.Label("Req Inc Slot Count", 1)]
        ReqIncSlotCount = 6,
        [FastEnumUtility.Label("CashItemReq_IncTrunkCount", 0)]
        [FastEnumUtility.Label("Req Inc Trunk Count", 1)]
        ReqIncTrunkCount = 7,
        [FastEnumUtility.Label("CashItemReq_IncCharSlotCount", 0)]
        [FastEnumUtility.Label("Req Inc Char Slot Count", 1)]
        ReqIncCharSlotCount = 8,
        [FastEnumUtility.Label("CashItemReq_IncBuyCharCount", 0)]
        [FastEnumUtility.Label("Req Inc Buy Char Count", 1)]
        ReqIncBuyCharCount = 9,
        [FastEnumUtility.Label("CashItemReq_EnableEquipSlotExt", 0)]
        [FastEnumUtility.Label("Req Enable Equip Slot Ext", 1)]
        ReqEnableEquipSlotExt = 10,
        [FastEnumUtility.Label("CashItemReq_CancelPurchase", 0)]
        [FastEnumUtility.Label("Req Cancel Purchase", 1)]
        ReqCancelPurchase = 11,
        [FastEnumUtility.Label("CashItemReq_ConfirmPurchase", 0)]
        [FastEnumUtility.Label("Req Confirm Purchase", 1)]
        ReqConfirmPurchase = 12,
        [FastEnumUtility.Label("CashItemReq_Destroy", 0)]
        [FastEnumUtility.Label("Req Destroy", 1)]
        ReqDestroy = 13,
        [FastEnumUtility.Label("CashItemReq_MoveLtoS", 0)]
        [FastEnumUtility.Label("Req Move Lto S", 1)]
        ReqMoveLtoS = 14,
        [FastEnumUtility.Label("CashItemReq_MoveStoL", 0)]
        [FastEnumUtility.Label("Req Move Sto L", 1)]
        ReqMoveStoL = 15,
        [FastEnumUtility.Label("CashItemReq_Expire", 0)]
        [FastEnumUtility.Label("Req Expire", 1)]
        ReqExpire = 16,
        [FastEnumUtility.Label("CashItemReq_Use", 0)]
        [FastEnumUtility.Label("Req Use", 1)]
        ReqUse = 17,
        [FastEnumUtility.Label("CashItemReq_StatChange", 0)]
        [FastEnumUtility.Label("Req Stat Change", 1)]
        ReqStatChange = 18,
        [FastEnumUtility.Label("CashItemReq_SkillChange", 0)]
        [FastEnumUtility.Label("Req Skill Change", 1)]
        ReqSkillChange = 19,
        [FastEnumUtility.Label("CashItemReq_SkillReset", 0)]
        [FastEnumUtility.Label("Req Skill Reset", 1)]
        ReqSkillReset = 20,
        [FastEnumUtility.Label("CashItemReq_DestroyPetItem", 0)]
        [FastEnumUtility.Label("Req Destroy Pet Item", 1)]
        ReqDestroyPetItem = 21,
        [FastEnumUtility.Label("CashItemReq_SetPetName", 0)]
        [FastEnumUtility.Label("Req Set Pet Name", 1)]
        ReqSetPetName = 22,
        [FastEnumUtility.Label("CashItemReq_SetPetLife", 0)]
        [FastEnumUtility.Label("Req Set Pet Life", 1)]
        ReqSetPetLife = 23,
        [FastEnumUtility.Label("CashItemReq_SetPetSkill", 0)]
        [FastEnumUtility.Label("Req Set Pet Skill", 1)]
        ReqSetPetSkill = 24,
        [FastEnumUtility.Label("CashItemReq_SetItemName", 0)]
        [FastEnumUtility.Label("Req Set Item Name", 1)]
        ReqSetItemName = 25,
        [FastEnumUtility.Label("CashItemReq_SendMemo", 0)]
        [FastEnumUtility.Label("Req Send Memo", 1)]
        ReqSendMemo = 26,
        [FastEnumUtility.Label("CashItemReq_GetMaplePoint", 0)]
        [FastEnumUtility.Label("Req Get Maple Point", 1)]
        ReqGetMaplePoint = 27,
        [FastEnumUtility.Label("CashItemReq_Rebate", 0)]
        [FastEnumUtility.Label("Req Rebate", 1)]
        ReqRebate = 28,
        [FastEnumUtility.Label("CashItemReq_UseCoupon", 0)]
        [FastEnumUtility.Label("Req Use Coupon", 1)]
        ReqUseCoupon = 29,
        [FastEnumUtility.Label("CashItemReq_GiftCoupon", 0)]
        [FastEnumUtility.Label("Req Gift Coupon", 1)]
        ReqGiftCoupon = 30,
        [FastEnumUtility.Label("CashItemReq_Couple", 0)]
        [FastEnumUtility.Label("Req Couple", 1)]
        ReqCouple = 31,
        [FastEnumUtility.Label("CashItemReq_BuyPackage", 0)]
        [FastEnumUtility.Label("Req Buy Package", 1)]
        ReqBuyPackage = 32,
        [FastEnumUtility.Label("CashItemReq_GiftPackage", 0)]
        [FastEnumUtility.Label("Req Gift Package", 1)]
        ReqGiftPackage = 33,
        [FastEnumUtility.Label("CashItemReq_BuyNormal", 0)]
        [FastEnumUtility.Label("Req Buy Normal", 1)]
        ReqBuyNormal = 34,
        [FastEnumUtility.Label("CashItemReq_ApplyWishListEvent", 0)]
        [FastEnumUtility.Label("Req Apply Wish List Event", 1)]
        ReqApplyWishListEvent = 35,
        [FastEnumUtility.Label("CashItemReq_MovePetStat", 0)]
        [FastEnumUtility.Label("Req Move Pet Stat", 1)]
        ReqMovePetStat = 36,
        [FastEnumUtility.Label("CashItemReq_FriendShip", 0)]
        [FastEnumUtility.Label("Req Friendship", 1)]
        ReqFriendship = 37,
        [FastEnumUtility.Label("CashItemReq_ShopScan", 0)]
        [FastEnumUtility.Label("Req Shop Scan", 1)]
        ReqShopScan = 38,
        [FastEnumUtility.Label("CashItemReq_LoadPetExceptionList", 0)]
        [FastEnumUtility.Label("Req Load Pet Exception List", 1)]
        ReqLoadPetExceptionList = 39,
        [FastEnumUtility.Label("CashItemReq_UpdatePetExceptionList", 0)]
        [FastEnumUtility.Label("Req Update Pet Exception List", 1)]
        ReqUpdatePetExceptionList = 40,
        [FastEnumUtility.Label("CashItemReq_FreeCashItem", 0)]
        [FastEnumUtility.Label("Req Free Cash Item", 1)]
        ReqFreeCashItem = 41,
        [FastEnumUtility.Label("CashItemReq_LoadFreeCashItem", 0)]
        [FastEnumUtility.Label("Req Load Free Cash Item", 1)]
        ReqLoadFreeCashItem = 42,
        [FastEnumUtility.Label("CashItemReq_Script", 0)]
        [FastEnumUtility.Label("Req Script", 1)]
        ReqScript = 43,
        [FastEnumUtility.Label("CashItemReq_PurchaseRecord", 0)]
        [FastEnumUtility.Label("Req Purchase Record", 1)]
        ReqPurchaseRecord = 44,
        [FastEnumUtility.Label("CashItemReq_TradeDone", 0)]
        [FastEnumUtility.Label("Req Trade Done", 1)]
        ReqTradeDone = 45,
        [FastEnumUtility.Label("CashItemReq_BuyDone", 0)]
        [FastEnumUtility.Label("Req Buy Done", 1)]
        ReqBuyDone = 46,
        [FastEnumUtility.Label("CashItemReq_TradeSave", 0)]
        [FastEnumUtility.Label("Req Trade Save", 1)]
        ReqTradeSave = 47,
        [FastEnumUtility.Label("CashItemReq_TradeLog", 0)]
        [FastEnumUtility.Label("Req Trade Log", 1)]
        ReqTradeLog = 48,
        [FastEnumUtility.Label("CashItemReq_EvolPet", 0)]
        [FastEnumUtility.Label("Req Evol Pet", 1)]
        ReqEvolPet = 49,
        [FastEnumUtility.Label("CashItemReq_BuyNameChange", 0)]
        [FastEnumUtility.Label("Req Buy Name Change", 1)]
        ReqBuyNameChange = 50,
        [FastEnumUtility.Label("CashItemReq_CancelChangeName", 0)]
        [FastEnumUtility.Label("Req Cancel Change Name", 1)]
        ReqCancelChangeName = 51,
        [FastEnumUtility.Label("CashItemRes_CancelNameChangeFail", 0)]
        [FastEnumUtility.Label("Res Cancel Name Change Fail", 1)]
        ResCancelNameChangeFail = 52,
        [FastEnumUtility.Label("CashItemReq_BuyTransferWorld", 0)]
        [FastEnumUtility.Label("Req Buy Transfer World", 1)]
        ReqBuyTransferWorld = 53,
        [FastEnumUtility.Label("CashItemReq_CancelTransferWorld", 0)]
        [FastEnumUtility.Label("Req Cancel Transfer World", 1)]
        ReqCancelTransferWorld = 54,
        [FastEnumUtility.Label("CashItemReq_CharacterSale", 0)]
        [FastEnumUtility.Label("Req Character Sale", 1)]
        ReqCharacterSale = 55,
        [FastEnumUtility.Label("CashItemRes_CharacterSaleSuccess", 0)]
        [FastEnumUtility.Label("Res Character Sale Success", 1)]
        ResCharacterSaleSuccess = 56,
        [FastEnumUtility.Label("CashItemRes_CharacterSaleFail", 0)]
        [FastEnumUtility.Label("Res Character Sale Fail", 1)]
        ResCharacterSaleFail = 57,
        [FastEnumUtility.Label("CashItemRes_CharacterSaleInvalidName", 0)]
        [FastEnumUtility.Label("Res Character Sale Invalid Name", 1)]
        ResCharacterSaleInvalidName = 58,
        [FastEnumUtility.Label("CashItemRes_CharacterSaleInvalidItem", 0)]
        [FastEnumUtility.Label("Res Character Sale Invalid Item", 1)]
        ResCharacterSaleInvalidItem = 59,
        [FastEnumUtility.Label("CashItemReq_ItemUpgrade", 0)]
        [FastEnumUtility.Label("Req Item Upgrade", 1)]
        ReqItemUpgrade = 60,
        [FastEnumUtility.Label("CashItemRes_ItemUpgradeSuccess", 0)]
        [FastEnumUtility.Label("Res Item Upgrade Success", 1)]
        ResItemUpgradeSuccess = 61,
        [FastEnumUtility.Label("CashItemReq_ItemUpgradeFail", 0)]
        [FastEnumUtility.Label("Req Item Upgrade Fail", 1)]
        ReqItemUpgradeFail = 62,
        [FastEnumUtility.Label("CashItemReq_ItemUpgradeReq", 0)]
        [FastEnumUtility.Label("Req Item Upgrade Req", 1)]
        ReqItemUpgradeReq = 63,
        [FastEnumUtility.Label("CashItemReq_ItemUpgradeDone", 0)]
        [FastEnumUtility.Label("Req Item Upgrade Done", 1)]
        ReqItemUpgradeDone = 64,
        [FastEnumUtility.Label("CashItemRes_ItemUpgradeDone", 0)]
        [FastEnumUtility.Label("Res Item Upgrade Done", 1)]
        ResItemUpgradeDone = 65,
        [FastEnumUtility.Label("CashItemRes_ItemUpgradeErr", 0)]
        [FastEnumUtility.Label("Res Item Upgrade Err", 1)]
        ResItemUpgradeErr = 66,
        [FastEnumUtility.Label("CashItemReq_Vega", 0)]
        [FastEnumUtility.Label("Req Vega", 1)]
        ReqVega = 67,
        [FastEnumUtility.Label("CashItemRes_VegaSuccess1", 0)]
        [FastEnumUtility.Label("Res Vega Success1", 1)]
        ResVegaSuccess1 = 68,
        [FastEnumUtility.Label("CashItemRes_VegaSuccess2", 0)]
        [FastEnumUtility.Label("Res Vega Success2", 1)]
        ResVegaSuccess2 = 69,
        [FastEnumUtility.Label("CashItemRes_VegaErr", 0)]
        [FastEnumUtility.Label("Res Vega Err", 1)]
        ResVegaErr = 70,
        [FastEnumUtility.Label("CashItemRes_VegaErr2", 0)]
        [FastEnumUtility.Label("Res Vega Err2", 1)]
        ResVegaErr2 = 71,
        [FastEnumUtility.Label("CashItemRes_VegaErr_InvalidItem", 0)]
        [FastEnumUtility.Label("Res Vega Err Invalid Item", 1)]
        ResVegaErrInvalidItem = 72,
        [FastEnumUtility.Label("CashItemRes_VegaFail", 0)]
        [FastEnumUtility.Label("Res Vega Fail", 1)]
        ResVegaFail = 73,
        [FastEnumUtility.Label("CashItemReq_CashItemGachapon", 0)]
        [FastEnumUtility.Label("Req Cash Item Gachapon", 1)]
        ReqCashItemGachapon = 74,
        [FastEnumUtility.Label("CashItemReq_CashGachaponOpen", 0)]
        [FastEnumUtility.Label("Req Cash Gachapon Open", 1)]
        ReqCashGachaponOpen = 75,
        [FastEnumUtility.Label("CashItemReq_CashGachaponCopy", 0)]
        [FastEnumUtility.Label("Req Cash Gachapon Copy", 1)]
        ReqCashGachaponCopy = 76,
        [FastEnumUtility.Label("CashItemReq_ChangeMaplePoint", 0)]
        [FastEnumUtility.Label("Req Change Maple Point", 1)]
        ReqChangeMaplePoint = 77,
        [FastEnumUtility.Label("CashItemReq_CheckFreeCashItemTable", 0)]
        [FastEnumUtility.Label("Req Check Free Cash Item Table", 1)]
        ReqCheckFreeCashItemTable = 78,
        [FastEnumUtility.Label("CashItemRes_CheckFreeCashItemTable_Done", 0)]
        [FastEnumUtility.Label("Res Check Free Cash Item Table Done", 1)]
        ResCheckFreeCashItemTableDone = 79,
        [FastEnumUtility.Label("CashItemRes_CheckFreeCashItemTable_Failed", 0)]
        [FastEnumUtility.Label("Res Check Free Cash Item Table Failed", 1)]
        ResCheckFreeCashItemTableFailed = 80,
        [FastEnumUtility.Label("CashItemReq_SetFreeCashItemTable", 0)]
        [FastEnumUtility.Label("Req Set Free Cash Item Table", 1)]
        ReqSetFreeCashItemTable = 81,
        [FastEnumUtility.Label("CashItemRes_SetFreeCashItemTable_Done", 0)]
        [FastEnumUtility.Label("Res Set Free Cash Item Table Done", 1)]
        ResSetFreeCashItemTableDone = 82,
        [FastEnumUtility.Label("CashItemRes_SetFreeCashItemTable_Failed", 0)]
        [FastEnumUtility.Label("Res Set Free Cash Item Table Failed", 1)]
        ResSetFreeCashItemTableFailed = 83,
        [FastEnumUtility.Label("CashItemRes_LimitGoodsCount_Changed", 0)]
        [FastEnumUtility.Label("Res Limit Goods Count Changed", 1)]
        ResLimitGoodsCountChanged = 84,
        [FastEnumUtility.Label("CashItemRes_WebShopOrderGetList_Done", 0)]
        [FastEnumUtility.Label("Res Web Shop Order Get List Done", 1)]
        ResWebShopOrderGetListDone = 85,
        [FastEnumUtility.Label("CashItemRes_WebShopOrderGetList_Failed", 0)]
        [FastEnumUtility.Label("Res Web Shop Order Get List Failed", 1)]
        ResWebShopOrderGetListFailed = 86,
        [FastEnumUtility.Label("CashItemRes_WebShopReceive_Done", 0)]
        [FastEnumUtility.Label("Res Web Shop Receive Done", 1)]
        ResWebShopReceiveDone = 87,
        [FastEnumUtility.Label("CashItemRes_LoadLocker_Done", 0)]
        [FastEnumUtility.Label("Res Load Locker Done", 1)]
        ResLoadLockerDone = 88,
        [FastEnumUtility.Label("CashItemRes_LoadLocker_Failed", 0)]
        [FastEnumUtility.Label("Res Load Locker Failed", 1)]
        ResLoadLockerFailed = 89,
        [FastEnumUtility.Label("CashItemRes_LoadGift_Done", 0)]
        [FastEnumUtility.Label("Res Load Gift Done", 1)]
        ResLoadGiftDone = 90,
        [FastEnumUtility.Label("CashItemRes_LoadGift_Failed", 0)]
        [FastEnumUtility.Label("Res Load Gift Failed", 1)]
        ResLoadGiftFailed = 91,
        [FastEnumUtility.Label("CashItemRes_LoadWish_Done", 0)]
        [FastEnumUtility.Label("Res Load Wish Done", 1)]
        ResLoadWishDone = 92,
        [FastEnumUtility.Label("CashItemRes_LoadWish_Failed", 0)]
        [FastEnumUtility.Label("Res Load Wish Failed", 1)]
        ResLoadWishFailed = 93,
        [FastEnumUtility.Label("CashItemRes_MapleTV_Failed_Wrong_User_Name", 0)]
        [FastEnumUtility.Label("Res Maple Tv Failed Wrong User Name", 1)]
        ResMapleTvFailedWrongUserName = 94,
        [FastEnumUtility.Label("CashItemRes_MapleTV_Failed_User_Not_Connected", 0)]
        [FastEnumUtility.Label("Res Maple Tv Failed User Not Connected", 1)]
        ResMapleTvFailedUserNotConnected = 95,
        [FastEnumUtility.Label("CashItemRes_AvatarMegaphone_Queue_Full", 0)]
        [FastEnumUtility.Label("Res Avatar Megaphone Queue Full", 1)]
        ResAvatarMegaphoneQueueFull = 96,
        [FastEnumUtility.Label("CashItemRes_AvatarMegaphone_Level_Limit", 0)]
        [FastEnumUtility.Label("Res Avatar Megaphone Level Limit", 1)]
        ResAvatarMegaphoneLevelLimit = 97,
        [FastEnumUtility.Label("CashItemRes_SetWish_Done", 0)]
        [FastEnumUtility.Label("Res Set Wish Done", 1)]
        ResSetWishDone = 98,
        [FastEnumUtility.Label("CashItemRes_SetWish_Failed", 0)]
        [FastEnumUtility.Label("Res Set Wish Failed", 1)]
        ResSetWishFailed = 99,
        [FastEnumUtility.Label("CashItemRes_Buy_Done", 0)]
        [FastEnumUtility.Label("Res Buy Done", 1)]
        ResBuyDone = 100,
        [FastEnumUtility.Label("CashItemRes_Buy_Failed", 0)]
        [FastEnumUtility.Label("Res Buy Failed", 1)]
        ResBuyFailed = 101,
        [FastEnumUtility.Label("CashItemRes_UseCoupon_Done", 0)]
        [FastEnumUtility.Label("Res Use Coupon Done", 1)]
        ResUseCouponDone = 102,
        [FastEnumUtility.Label("CashItemRes_UseCoupon_Done_NormalItem", 0)]
        [FastEnumUtility.Label("Res Use Coupon Done Normal Item", 1)]
        ResUseCouponDoneNormalItem = 103,
        [FastEnumUtility.Label("CashItemRes_GiftCoupon_Done", 0)]
        [FastEnumUtility.Label("Res Gift Coupon Done", 1)]
        ResGiftCouponDone = 104,
        [FastEnumUtility.Label("CashItemRes_UseCoupon_Failed", 0)]
        [FastEnumUtility.Label("Res Use Coupon Failed", 1)]
        ResUseCouponFailed = 105,
        [FastEnumUtility.Label("CashItemRes_UseCoupon_CashItem_Failed", 0)]
        [FastEnumUtility.Label("Res Use Coupon Cash Item Failed", 1)]
        ResUseCouponCashItemFailed = 106,
        [FastEnumUtility.Label("CashItemRes_Gift_Done", 0)]
        [FastEnumUtility.Label("Res Gift Done", 1)]
        ResGiftDone = 107,
        [FastEnumUtility.Label("CashItemRes_Gift_Failed", 0)]
        [FastEnumUtility.Label("Res Gift Failed", 1)]
        ResGiftFailed = 108,
        [FastEnumUtility.Label("CashItemRes_IncSlotCount_Done", 0)]
        [FastEnumUtility.Label("Res Inc Slot Count Done", 1)]
        ResIncSlotCountDone = 109,
        [FastEnumUtility.Label("CashItemRes_IncSlotCount_Failed", 0)]
        [FastEnumUtility.Label("Res Inc Slot Count Failed", 1)]
        ResIncSlotCountFailed = 110,
        [FastEnumUtility.Label("CashItemRes_IncTrunkCount_Done", 0)]
        [FastEnumUtility.Label("Res Inc Trunk Count Done", 1)]
        ResIncTrunkCountDone = 111,
        [FastEnumUtility.Label("CashItemRes_IncTrunkCount_Failed", 0)]
        [FastEnumUtility.Label("Res Inc Trunk Count Failed", 1)]
        ResIncTrunkCountFailed = 112,
        [FastEnumUtility.Label("CashItemRes_IncCharSlotCount_Done", 0)]
        [FastEnumUtility.Label("Res Inc Char Slot Count Done", 1)]
        ResIncCharSlotCountDone = 113,
        [FastEnumUtility.Label("CashItemRes_IncCharSlotCount_Failed", 0)]
        [FastEnumUtility.Label("Res Inc Char Slot Count Failed", 1)]
        ResIncCharSlotCountFailed = 114,
        [FastEnumUtility.Label("CashItemRes_IncBuyCharCount_Done", 0)]
        [FastEnumUtility.Label("Res Inc Buy Char Count Done", 1)]
        ResIncBuyCharCountDone = 115,
        [FastEnumUtility.Label("CashItemRes_IncBuyCharCount_Failed", 0)]
        [FastEnumUtility.Label("Res Inc Buy Char Count Failed", 1)]
        ResIncBuyCharCountFailed = 116,
        [FastEnumUtility.Label("CashItemRes_EnableEquipSlotExt_Done", 0)]
        [FastEnumUtility.Label("Res Enable Equip Slot Ext Done", 1)]
        ResEnableEquipSlotExtDone = 117,
        [FastEnumUtility.Label("CashItemRes_EnableEquipSlotExt_Failed", 0)]
        [FastEnumUtility.Label("Res Enable Equip Slot Ext Failed", 1)]
        ResEnableEquipSlotExtFailed = 118,
        [FastEnumUtility.Label("CashItemRes_MoveLtoS_Done", 0)]
        [FastEnumUtility.Label("Res Move Lto SDone", 1)]
        ResMoveLtoSDone = 119,
        [FastEnumUtility.Label("CashItemRes_MoveLtoS_Failed", 0)]
        [FastEnumUtility.Label("Res Move Lto SFailed", 1)]
        ResMoveLtoSFailed = 120,
        [FastEnumUtility.Label("CashItemRes_MoveStoL_Done", 0)]
        [FastEnumUtility.Label("Res Move Sto LDone", 1)]
        ResMoveStoLDone = 121,
        [FastEnumUtility.Label("CashItemRes_MoveStoL_Failed", 0)]
        [FastEnumUtility.Label("Res Move Sto LFailed", 1)]
        ResMoveStoLFailed = 122,
        [FastEnumUtility.Label("CashItemRes_Destroy_Done", 0)]
        [FastEnumUtility.Label("Res Destroy Done", 1)]
        ResDestroyDone = 123,
        [FastEnumUtility.Label("CashItemRes_Destroy_Failed", 0)]
        [FastEnumUtility.Label("Res Destroy Failed", 1)]
        ResDestroyFailed = 124,
        [FastEnumUtility.Label("CashItemRes_Expire_Done", 0)]
        [FastEnumUtility.Label("Res Expire Done", 1)]
        ResExpireDone = 125,
        [FastEnumUtility.Label("CashItemRes_Expire_Failed", 0)]
        [FastEnumUtility.Label("Res Expire Failed", 1)]
        ResExpireFailed = 126,
        [FastEnumUtility.Label("CashItemRes_Use_Done", 0)]
        [FastEnumUtility.Label("Res Use Done", 1)]
        ResUseDone = 127,
        [FastEnumUtility.Label("CashItemRes_Use_Failed", 0)]
        [FastEnumUtility.Label("Res Use Failed", 1)]
        ResUseFailed = 128,
        [FastEnumUtility.Label("CashItemRes_StatChange_Done", 0)]
        [FastEnumUtility.Label("Res Stat Change Done", 1)]
        ResStatChangeDone = 129,
        [FastEnumUtility.Label("CashItemRes_StatChange_Failed", 0)]
        [FastEnumUtility.Label("Res Stat Change Failed", 1)]
        ResStatChangeFailed = 130,
        [FastEnumUtility.Label("CashItemRes_SkillChange_Done", 0)]
        [FastEnumUtility.Label("Res Skill Change Done", 1)]
        ResSkillChangeDone = 131,
        [FastEnumUtility.Label("CashItemRes_SkillChange_Failed", 0)]
        [FastEnumUtility.Label("Res Skill Change Failed", 1)]
        ResSkillChangeFailed = 132,
        [FastEnumUtility.Label("CashItemRes_SkillReset_Done", 0)]
        [FastEnumUtility.Label("Res Skill Reset Done", 1)]
        ResSkillResetDone = 133,
        [FastEnumUtility.Label("CashItemRes_SkillReset_Failed", 0)]
        [FastEnumUtility.Label("Res Skill Reset Failed", 1)]
        ResSkillResetFailed = 134,
        [FastEnumUtility.Label("CashItemRes_DestroyPetItem_Done", 0)]
        [FastEnumUtility.Label("Res Destroy Pet Item Done", 1)]
        ResDestroyPetItemDone = 135,
        [FastEnumUtility.Label("CashItemRes_DestroyPetItem_Failed", 0)]
        [FastEnumUtility.Label("Res Destroy Pet Item Failed", 1)]
        ResDestroyPetItemFailed = 136,
        [FastEnumUtility.Label("CashItemRes_SetPetName_Done", 0)]
        [FastEnumUtility.Label("Res Set Pet Name Done", 1)]
        ResSetPetNameDone = 137,
        [FastEnumUtility.Label("CashItemRes_SetPetName_Failed", 0)]
        [FastEnumUtility.Label("Res Set Pet Name Failed", 1)]
        ResSetPetNameFailed = 138,
        [FastEnumUtility.Label("CashItemRes_SetPetLife_Done", 0)]
        [FastEnumUtility.Label("Res Set Pet Life Done", 1)]
        ResSetPetLifeDone = 139,
        [FastEnumUtility.Label("CashItemRes_SetPetLife_Failed", 0)]
        [FastEnumUtility.Label("Res Set Pet Life Failed", 1)]
        ResSetPetLifeFailed = 140,
        [FastEnumUtility.Label("CashItemRes_MovePetStat_Failed", 0)]
        [FastEnumUtility.Label("Res Move Pet Stat Failed", 1)]
        ResMovePetStatFailed = 141,
        [FastEnumUtility.Label("CashItemRes_MovePetStat_Done", 0)]
        [FastEnumUtility.Label("Res Move Pet Stat Done", 1)]
        ResMovePetStatDone = 142,
        [FastEnumUtility.Label("CashItemRes_SetPetSkill_Failed", 0)]
        [FastEnumUtility.Label("Res Set Pet Skill Failed", 1)]
        ResSetPetSkillFailed = 143,
        [FastEnumUtility.Label("CashItemRes_SetPetSkill_Done", 0)]
        [FastEnumUtility.Label("Res Set Pet Skill Done", 1)]
        ResSetPetSkillDone = 144,
        [FastEnumUtility.Label("CashItemRes_SendMemo_Done", 0)]
        [FastEnumUtility.Label("Res Send Memo Done", 1)]
        ResSendMemoDone = 145,
        [FastEnumUtility.Label("CashItemRes_SendMemo_Warning", 0)]
        [FastEnumUtility.Label("Res Send Memo Warning", 1)]
        ResSendMemoWarning = 146,
        [FastEnumUtility.Label("CashItemRes_SendMemo_Failed", 0)]
        [FastEnumUtility.Label("Res Send Memo Failed", 1)]
        ResSendMemoFailed = 147,
        [FastEnumUtility.Label("CashItemRes_GetMaplePoint_Done", 0)]
        [FastEnumUtility.Label("Res Get Maple Point Done", 1)]
        ResGetMaplePointDone = 148,
        [FastEnumUtility.Label("CashItemRes_GetMaplePoint_Failed", 0)]
        [FastEnumUtility.Label("Res Get Maple Point Failed", 1)]
        ResGetMaplePointFailed = 149,
        [FastEnumUtility.Label("CashItemRes_Rebate_Done", 0)]
        [FastEnumUtility.Label("Res Rebate Done", 1)]
        ResRebateDone = 150,
        [FastEnumUtility.Label("CashItemRes_Rebate_Failed", 0)]
        [FastEnumUtility.Label("Res Rebate Failed", 1)]
        ResRebateFailed = 151,
        [FastEnumUtility.Label("CashItemRes_Couple_Done", 0)]
        [FastEnumUtility.Label("Res Couple Done", 1)]
        ResCoupleDone = 152,
        [FastEnumUtility.Label("CashItemRes_Couple_Failed", 0)]
        [FastEnumUtility.Label("Res Couple Failed", 1)]
        ResCoupleFailed = 153,
        [FastEnumUtility.Label("CashItemRes_BuyPackage_Done", 0)]
        [FastEnumUtility.Label("Res Buy Package Done", 1)]
        ResBuyPackageDone = 154,
        [FastEnumUtility.Label("CashItemRes_BuyPackage_Failed", 0)]
        [FastEnumUtility.Label("Res Buy Package Failed", 1)]
        ResBuyPackageFailed = 155,
        [FastEnumUtility.Label("CashItemRes_GiftPackage_Done", 0)]
        [FastEnumUtility.Label("Res Gift Package Done", 1)]
        ResGiftPackageDone = 156,
        [FastEnumUtility.Label("CashItemRes_GiftPackage_Failed", 0)]
        [FastEnumUtility.Label("Res Gift Package Failed", 1)]
        ResGiftPackageFailed = 157,
        [FastEnumUtility.Label("CashItemRes_BuyNormal_Done", 0)]
        [FastEnumUtility.Label("Res Buy Normal Done", 1)]
        ResBuyNormalDone = 158,
        [FastEnumUtility.Label("CashItemRes_BuyNormal_Failed", 0)]
        [FastEnumUtility.Label("Res Buy Normal Failed", 1)]
        ResBuyNormalFailed = 159,
        [FastEnumUtility.Label("CashItemRes_ApplyWishListEvent_Done", 0)]
        [FastEnumUtility.Label("Res Apply Wish List Event Done", 1)]
        ResApplyWishListEventDone = 160,
        [FastEnumUtility.Label("CashItemRes_ApplyWishListEvent_Failed", 0)]
        [FastEnumUtility.Label("Res Apply Wish List Event Failed", 1)]
        ResApplyWishListEventFailed = 161,
        [FastEnumUtility.Label("CashItemRes_Friendship_Done", 0)]
        [FastEnumUtility.Label("Res Friendship Done", 1)]
        ResFriendshipDone = 162,
        [FastEnumUtility.Label("CashItemRes_Friendship_Failed", 0)]
        [FastEnumUtility.Label("Res Friendship Failed", 1)]
        ResFriendshipFailed = 163,
        [FastEnumUtility.Label("CashItemRes_LoadExceptionList_Done", 0)]
        [FastEnumUtility.Label("Res Load Exception List Done", 1)]
        ResLoadExceptionListDone = 164,
        [FastEnumUtility.Label("CashItemRes_LoadExceptionList_Failed", 0)]
        [FastEnumUtility.Label("Res Load Exception List Failed", 1)]
        ResLoadExceptionListFailed = 165,
        [FastEnumUtility.Label("CashItemRes_UpdateExceptionList_Done", 0)]
        [FastEnumUtility.Label("Res Update Exception List Done", 1)]
        ResUpdateExceptionListDone = 166,
        [FastEnumUtility.Label("CashItemRes_UpdateExceptionList_Failed", 0)]
        [FastEnumUtility.Label("Res Update Exception List Failed", 1)]
        ResUpdateExceptionListFailed = 167,
        [FastEnumUtility.Label("CashItemRes_LoadFreeCashItem_Done", 0)]
        [FastEnumUtility.Label("Res Load Free Cash Item Done", 1)]
        ResLoadFreeCashItemDone = 168,
        [FastEnumUtility.Label("CashItemRes_LoadFreeCashItem_Failed", 0)]
        [FastEnumUtility.Label("Res Load Free Cash Item Failed", 1)]
        ResLoadFreeCashItemFailed = 169,
        [FastEnumUtility.Label("CashItemRes_FreeCashItem_Done", 0)]
        [FastEnumUtility.Label("Res Free Cash Item Done", 1)]
        ResFreeCashItemDone = 170,
        [FastEnumUtility.Label("CashItemRes_FreeCashItem_Failed", 0)]
        [FastEnumUtility.Label("Res Free Cash Item Failed", 1)]
        ResFreeCashItemFailed = 171,
        [FastEnumUtility.Label("CashItemRes_Script_Done", 0)]
        [FastEnumUtility.Label("Res Script Done", 1)]
        ResScriptDone = 172,
        [FastEnumUtility.Label("CashItemRes_Script_Failed", 0)]
        [FastEnumUtility.Label("Res Script Failed", 1)]
        ResScriptFailed = 173,
        [FastEnumUtility.Label("CashItemRes_Bridge_Failed", 0)]
        [FastEnumUtility.Label("Res Bridge Failed", 1)]
        ResBridgeFailed = 174,
        [FastEnumUtility.Label("CashItemRes_PurchaseRecord_Done", 0)]
        [FastEnumUtility.Label("Res Purchase Record Done", 1)]
        ResPurchaseRecordDone = 175,
        [FastEnumUtility.Label("CashItemRes_PurchaseRecord_Failed", 0)]
        [FastEnumUtility.Label("Res Purchase Record Failed", 1)]
        ResPurchaseRecordFailed = 176,
        [FastEnumUtility.Label("CashItemRes_EvolPet_Failed", 0)]
        [FastEnumUtility.Label("Res Evol Pet Failed", 1)]
        ResEvolPetFailed = 177,
        [FastEnumUtility.Label("CashItemRes_EvolPet_Done", 0)]
        [FastEnumUtility.Label("Res Evol Pet Done", 1)]
        ResEvolPetDone = 178,
        [FastEnumUtility.Label("CashItemRes_NameChangeBuy_Done", 0)]
        [FastEnumUtility.Label("Res Name Change Buy Done", 1)]
        ResNameChangeBuyDone = 179,
        [FastEnumUtility.Label("CashItemRes_NameChangeBuy_Failed", 0)]
        [FastEnumUtility.Label("Res Name Change Buy Failed", 1)]
        ResNameChangeBuyFailed = 180,
        [FastEnumUtility.Label("CashItemRes_TransferWorld_Done", 0)]
        [FastEnumUtility.Label("Res Transfer World Done", 1)]
        ResTransferWorldDone = 181,
        [FastEnumUtility.Label("CashItemRes_TransferWorld_Failed", 0)]
        [FastEnumUtility.Label("Res Transfer World Failed", 1)]
        ResTransferWorldFailed = 182,
        [FastEnumUtility.Label("CashItemRes_CashGachaponOpen_Done", 0)]
        [FastEnumUtility.Label("Res Cash Gachapon Open Done", 1)]
        ResCashGachaponOpenDone = 183,
        [FastEnumUtility.Label("CashItemRes_CashGachaponOpen_Failed", 0)]
        [FastEnumUtility.Label("Res Cash Gachapon Open Failed", 1)]
        ResCashGachaponOpenFailed = 184,
        [FastEnumUtility.Label("CashItemRes_CashGachaponCopy_Done", 0)]
        [FastEnumUtility.Label("Res Cash Gachapon Copy Done", 1)]
        ResCashGachaponCopyDone = 185,
        [FastEnumUtility.Label("CashItemRes_CashGachaponCopy_Failed", 0)]
        [FastEnumUtility.Label("Res Cash Gachapon Copy Failed", 1)]
        ResCashGachaponCopyFailed = 186,
        [FastEnumUtility.Label("CashItemRes_ChangeMaplePoint_Done", 0)]
        [FastEnumUtility.Label("Res Change Maple Point Done", 1)]
        ResChangeMaplePointDone = 187,
        [FastEnumUtility.Label("CashItemRes_ChangeMaplePoint_Failed", 0)]
        [FastEnumUtility.Label("Res Change Maple Point Failed", 1)]
        ResChangeMaplePointFailed = 188,
        [FastEnumUtility.Label("CashItemReq_Give", 0)]
        [FastEnumUtility.Label("Req Give", 1)]
        ReqGive = 189,
        [FastEnumUtility.Label("CashItemRes_Give_Done", 0)]
        [FastEnumUtility.Label("Res Give Done", 1)]
        ResGiveDone = 190,
        [FastEnumUtility.Label("CashItemRes_Give_Failed", 0)]
        [FastEnumUtility.Label("Res Give Failed", 1)]
        ResGiveFailed = 191,
        [FastEnumUtility.Label("CashItemRes_GashItemGachapon_Failed", 0)]
        [FastEnumUtility.Label("Res Gash Item Gachapon Failed", 1)]
        ResGashItemGachaponFailed = 192,
        [FastEnumUtility.Label("CashItemRes_CashItemGachapon_Done", 0)]
        [FastEnumUtility.Label("Res Cash Item Gachapon Done", 1)]
        ResCashItemGachaponDone = 193,
    }
    public enum CashItemType : byte
    {
        [FastEnumUtility.Label("CIT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("CIT_HAIR", 0)]
        Hair = 1,
        [FastEnumUtility.Label("CIT_FACE", 0)]
        Face = 2,
        [FastEnumUtility.Label("CIT_SKIN", 0)]
        Skin = 3,
        [FastEnumUtility.Label("CIT_SHOP", 0)]
        Shop = 4,
        [FastEnumUtility.Label("CIT_SETPETLIFE", 0)]
        [FastEnumUtility.Label("Set Pet Life", 1)]
        SetPetLife = 5,
        [FastEnumUtility.Label("CIT_EMOTION", 0)]
        Emotion = 6,
        [FastEnumUtility.Label("CIT_PROTECTONDIE", 0)]
        [FastEnumUtility.Label("Protect On Die", 1)]
        ProtectOnDie = 7,
        [FastEnumUtility.Label("CIT_PET", 0)]
        Pet = 8,
        [FastEnumUtility.Label("CIT_EFFECT", 0)]
        Effect = 9,
        [FastEnumUtility.Label("CIT_BULLET", 0)]
        Bullet = 10,
        [FastEnumUtility.Label("CIT_SHOPEMPLOYEE", 0)]
        [FastEnumUtility.Label("Shop Employee", 1)]
        ShopEmployee = 11,
        [FastEnumUtility.Label("CIT_SPEAKERCHANNEL", 0)]
        [FastEnumUtility.Label("Speaker Channel", 1)]
        SpeakerChannel = 12,
        [FastEnumUtility.Label("CIT_SPEAKERWORLD", 0)]
        [FastEnumUtility.Label("Speaker World", 1)]
        SpeakerWorld = 13,
        [FastEnumUtility.Label("CIT_ITEMSPEAKER", 0)]
        [FastEnumUtility.Label("Item Speaker", 1)]
        ItemSpeaker = 14,
        [FastEnumUtility.Label("CIT_SPEAKERBRIDGE", 0)]
        [FastEnumUtility.Label("Speaker Bridge", 1)]
        SpeakerBridge = 15,
        [FastEnumUtility.Label("CIT_WEATHER", 0)]
        Weather = 16,
        [FastEnumUtility.Label("CIT_SETPETNAME", 0)]
        [FastEnumUtility.Label("Set Pet Name", 1)]
        SetPetName = 17,
        [FastEnumUtility.Label("CIT_MESSAGEBOX", 0)]
        [FastEnumUtility.Label("Message Box", 1)]
        MessageBox = 18,
        [FastEnumUtility.Label("CIT_MONEYPOCKET", 0)]
        [FastEnumUtility.Label("Money Pocket", 1)]
        MoneyPocket = 19,
        [FastEnumUtility.Label("CIT_JUKEBOX", 0)]
        Jukebox = 20,
        [FastEnumUtility.Label("CIT_SENDMEMO", 0)]
        [FastEnumUtility.Label("Send Memo", 1)]
        SendMemo = 21,
        [FastEnumUtility.Label("CIT_MAPTRANSFER", 0)]
        [FastEnumUtility.Label("Map Transfer", 1)]
        MapTransfer = 22,
        [FastEnumUtility.Label("CIT_STATCHANGE", 0)]
        [FastEnumUtility.Label("Stat Change", 1)]
        StatChange = 23,
        [FastEnumUtility.Label("CIT_SKILLCHANGE", 0)]
        [FastEnumUtility.Label("Skill Change", 1)]
        SkillChange = 24,
        [FastEnumUtility.Label("CIT_NAMING", 0)]
        Naming = 25,
        [FastEnumUtility.Label("CIT_PROTECTING", 0)]
        Protecting = 26,
        [FastEnumUtility.Label("CIT_INCUBATOR", 0)]
        Incubator = 27,
        [FastEnumUtility.Label("CIT_PETSKILL", 0)]
        [FastEnumUtility.Label("Pet Skill", 1)]
        PetSkill = 28,
        [FastEnumUtility.Label("CIT_SHOPSCANNER", 0)]
        [FastEnumUtility.Label("Shop Scanner", 1)]
        ShopScanner = 29,
        [FastEnumUtility.Label("CIT_PETFOOD", 0)]
        [FastEnumUtility.Label("Pet Food", 1)]
        PetFood = 30,
        [FastEnumUtility.Label("CIT_QUICKDELIVERY", 0)]
        [FastEnumUtility.Label("Quick Delivery", 1)]
        QuickDelivery = 31,
        [FastEnumUtility.Label("Ad Board", 1)]
        [FastEnumUtility.Label("CIT_ADBOARD", 0)]
        AdBoard = 32,
        [FastEnumUtility.Label("CIT_CONSUMEEFFECTITEM", 0)]
        [FastEnumUtility.Label("Consume Effect Item", 1)]
        ConsumeEffectItem = 33,
        [FastEnumUtility.Label("CIT_CONSUMEAREABUFFITEM", 0)]
        [FastEnumUtility.Label("Consume Area Buff Item", 1)]
        ConsumeAreaBuffItem = 34,
        [FastEnumUtility.Label("CIT_COLORLENS", 0)]
        [FastEnumUtility.Label("Color Lens", 1)]
        ColorLens = 35,
        [FastEnumUtility.Label("CIT_WEDDINGTICKET", 0)]
        [FastEnumUtility.Label("Wedding Ticket", 1)]
        WeddingTicket = 36,
        [FastEnumUtility.Label("CIT_INVITATIONTICKET", 0)]
        [FastEnumUtility.Label("Invitation Ticket", 1)]
        InvitationTicket = 37,
        [FastEnumUtility.Label("CIT_SELECTNPC", 0)]
        [FastEnumUtility.Label("Select Npc", 1)]
        SelectNpc = 38,
        [FastEnumUtility.Label("CIT_REMOTESHOP", 0)]
        [FastEnumUtility.Label("Remote Shop", 1)]
        RemoteShop = 39,
        [FastEnumUtility.Label("CIT_GACHAPONCOUPON", 0)]
        [FastEnumUtility.Label("Gachapon Coupon", 1)]
        GachaponCoupon = 40,
        [FastEnumUtility.Label("CIT_MORPH", 0)]
        Morph = 41,
        [FastEnumUtility.Label("CIT_PETEVOL", 0)]
        [FastEnumUtility.Label("Pet Evol", 1)]
        PetEvol = 42,
        [FastEnumUtility.Label("Avatar Megaphone", 1)]
        [FastEnumUtility.Label("CIT_AVATARMEGAPHONE", 0)]
        AvatarMegaphone = 43,
        [FastEnumUtility.Label("CIT_HEARTSPEAKER", 0)]
        [FastEnumUtility.Label("Heart Speaker", 1)]
        HeartSpeaker = 44,
        [FastEnumUtility.Label("CIT_SKULLSPEAKER", 0)]
        [FastEnumUtility.Label("Skull Speaker", 1)]
        SkullSpeaker = 45,
        [FastEnumUtility.Label("CIT_REMOVABLE", 0)]
        Removable = 46,
        [FastEnumUtility.Label("CIT_MAPLETV", 0)]
        [FastEnumUtility.Label("Maple Tv", 1)]
        MapleTv = 47,
        [FastEnumUtility.Label("CIT_MAPLESOLETV", 0)]
        [FastEnumUtility.Label("Maple Sole Tv", 1)]
        MapleSoleTv = 48,
        [FastEnumUtility.Label("CIT_MAPLELOVETV", 0)]
        [FastEnumUtility.Label("Maple Love Tv", 1)]
        MapleLoveTv = 49,
        [FastEnumUtility.Label("CIT_MEGATV", 0)]
        [FastEnumUtility.Label("Mega Tv", 1)]
        MegaTv = 50,
        [FastEnumUtility.Label("CIT_MEGASOLETV", 0)]
        [FastEnumUtility.Label("Mega Sole Tv", 1)]
        MegaSoleTv = 51,
        [FastEnumUtility.Label("CIT_MEGALOVETV", 0)]
        [FastEnumUtility.Label("Mega Love Tv", 1)]
        MegaLoveTv = 52,
        [FastEnumUtility.Label("CIT_CHANGECHARACTERNAME", 0)]
        [FastEnumUtility.Label("Change Character Name", 1)]
        ChangeCharacterName = 53,
        [FastEnumUtility.Label("CIT_TRANSFERWORLDCOUPON", 0)]
        [FastEnumUtility.Label("Transfer World Coupon", 1)]
        TransferWorldCoupon = 54,
        [FastEnumUtility.Label("CIT_HAIRSHOPMEMBERSHIPCOUPON", 0)]
        [FastEnumUtility.Label("Hair Shop Membership Coupon", 1)]
        HairShopMembershipCoupon = 55,
        [FastEnumUtility.Label("CIT_FACESHOPMEMBERSHIPCOUPON", 0)]
        [FastEnumUtility.Label("Face Shop Membership Coupon", 1)]
        FaceShopMembershipCoupon = 56,
        [FastEnumUtility.Label("CIT_SKINSHOPMEMBERSHIPCOUPON", 0)]
        [FastEnumUtility.Label("Skin Shop Membership Coupon", 1)]
        SkinShopMembershipCoupon = 57,
        [FastEnumUtility.Label("CIT_PETSNACK", 0)]
        [FastEnumUtility.Label("Pet Snack", 1)]
        PetSnack = 58,
        [FastEnumUtility.Label("CIT_GACHAPONBOX_MASTERKEY", 0)]
        [FastEnumUtility.Label("Gachapon Box Master Key", 1)]
        GachaponBoxMasterKey = 59,
        [FastEnumUtility.Label("CIT_GACHAPONREMOTE", 0)]
        [FastEnumUtility.Label("Gachapon Remote", 1)]
        GachaponRemote = 60,
        [FastEnumUtility.Label("Art Speaker World", 1)]
        [FastEnumUtility.Label("CIT_ARTSPEAKERWORLD", 0)]
        ArtSpeakerWorld = 61,
        [FastEnumUtility.Label("CIT_EXTENDEXPIREDATE", 0)]
        [FastEnumUtility.Label("Extend Expire Date", 1)]
        ExtendExpireDate = 62,
        [FastEnumUtility.Label("CIT_UPGRADETOMB", 0)]
        [FastEnumUtility.Label("Upgrade Tomb", 1)]
        UpgradeTomb = 63,
        [FastEnumUtility.Label("CIT_KARMASCISSORS", 0)]
        [FastEnumUtility.Label("Karma Scissors", 1)]
        KarmaScissors = 64,
        [FastEnumUtility.Label("CIT_EXPIREDPROTECTING", 0)]
        [FastEnumUtility.Label("Expired Protecting", 1)]
        ExpiredProtecting = 65,
        [FastEnumUtility.Label("CIT_CHARACTERSALE", 0)]
        [FastEnumUtility.Label("Character Sale", 1)]
        CharacterSale = 66,
        [FastEnumUtility.Label("CIT_ITEMUPGRADE", 0)]
        [FastEnumUtility.Label("Item Upgrade", 1)]
        ItemUpgrade = 67,
        [FastEnumUtility.Label("CIT_CASHITEMGACHAPON", 0)]
        [FastEnumUtility.Label("Cash Item Gachapon", 1)]
        CashItemGachapon = 68,
        [FastEnumUtility.Label("CIT_CASHGACHAPONOPEN", 0)]
        [FastEnumUtility.Label("Cash Gachapon Open", 1)]
        CashGachaponOpen = 69,
        [FastEnumUtility.Label("CIT_CHANGEMAPLEPOINT", 0)]
        [FastEnumUtility.Label("Change Maple Point", 1)]
        ChangeMaplePoint = 70,
        [FastEnumUtility.Label("CIT_VEGA", 0)]
        Vega = 71,
        [FastEnumUtility.Label("CIT_REWARD", 0)]
        Reward = 72,
        [FastEnumUtility.Label("CIT_MASTERYBOOK", 0)]
        [FastEnumUtility.Label("Mastery Book", 1)]
        MasteryBook = 73,
        [FastEnumUtility.Label("CIT_ITEM_UNRELEASE", 0)]
        [FastEnumUtility.Label("Item Unrelease", 1)]
        ItemUnrelease = 74,
        [FastEnumUtility.Label("CIT_SKILLRESET", 0)]
        [FastEnumUtility.Label("Skill Reset", 1)]
        SkillReset = 75,
        [FastEnumUtility.Label("CIT_DRAGONBALL", 0)]
        [FastEnumUtility.Label("Dragon Ball", 1)]
        DragonBall = 76,
        [FastEnumUtility.Label("CIT_RECOVERUPGRADECOUNT", 0)]
        [FastEnumUtility.Label("Recover Upgrade Count", 1)]
        RecoverUpgradeCount = 77,
        [FastEnumUtility.Label("CIT_QUESTDELIVERY", 0)]
        [FastEnumUtility.Label("Quest Delivery", 1)]
        QuestDelivery = 78,
    }
    public enum CashLimitGoodsState
    {
        [FastEnumUtility.Label("CS_LimitGoodsState_NotLimitGoods", 0)]
        [FastEnumUtility.Label("Not Limit Goods", 1)]
        NotLimitGoods = -2,
        [FastEnumUtility.Label("CS_LimitGoodsState_Enough", 0)]
        Enough = -1,
        [FastEnumUtility.Label("CS_LimitGoodsState_NoGoods", 0)]
        [FastEnumUtility.Label("No Goods", 1)]
        NoGoods = 1,
        [FastEnumUtility.Label("CS_LimitGoodsState_NotAvailableTime", 0)]
        [FastEnumUtility.Label("Not Available Time", 1)]
        NotAvailableTime = 2,
        [FastEnumUtility.Label("CS_LimitGoodsState_SearchErr", 0)]
        [FastEnumUtility.Label("Search Error", 1)]
        SearchError = 3,
    }
    public enum CashPetFoodResult : byte
    {
        [FastEnumUtility.Label("CashPetFoodRes_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("CashPetFoodRes_Fail", 0)]
        Fail = 1,
    }
    public enum CashShopPurchaseType : byte
    {
        [FastEnumUtility.Label("CS_PURCHASE_BUY", 0)]
        Buy = 0,
        [FastEnumUtility.Label("Buy Avatar", 1)]
        [FastEnumUtility.Label("CS_PURCHASE_BUY_AVATAR", 0)]
        BuyAvatar = 1,
        [FastEnumUtility.Label("CS_PURCHASE_GIFT", 0)]
        Gift = 2,
        [FastEnumUtility.Label("CS_INCREASE_SLOT", 0)]
        [FastEnumUtility.Label("Increase Slot", 1)]
        IncreaseSlot = 3,
        [FastEnumUtility.Label("CS_PURCHASE_CASHGACHAPONCOPY", 0)]
        [FastEnumUtility.Label("Cash Gachapon Copy", 1)]
        CashGachaponCopy = 4,
    }
    public enum CashStockState
    {
        [FastEnumUtility.Label("CS_StockState_Infinite", 0)]
        Infinite = -2,
        [FastEnumUtility.Label("CS_StockState_Enough", 0)]
        Enough = -1,
        [FastEnumUtility.Label("CS_StockState_NoStock", 0)]
        [FastEnumUtility.Label("No Stock", 1)]
        NoStock = 1,
        [FastEnumUtility.Label("CS_StockState_NotAvailableTime", 0)]
        [FastEnumUtility.Label("Not Available Time", 1)]
        NotAvailableTime = 2,
    }
    public enum CharacterActionType : ushort
    {
        [FastEnumUtility.Label("ACT_WALK1", 0)]
        Walk1 = 0,
        [FastEnumUtility.Label("ACT_WALK2", 0)]
        Walk2 = 1,
        [FastEnumUtility.Label("ACT_STAND1", 0)]
        Stand1 = 2,
        [FastEnumUtility.Label("ACT_STAND2", 0)]
        Stand2 = 3,
        [FastEnumUtility.Label("ACT_ALERT", 0)]
        Alert = 4,
        [FastEnumUtility.Label("ACT_SWINGO1", 0)]
        [FastEnumUtility.Label("Swing O1", 1)]
        SwingO1 = 5,
        [FastEnumUtility.Label("ACT_SWINGO2", 0)]
        [FastEnumUtility.Label("Swing O2", 1)]
        SwingO2 = 6,
        [FastEnumUtility.Label("ACT_SWINGO3", 0)]
        [FastEnumUtility.Label("Swing O3", 1)]
        SwingO3 = 7,
        [FastEnumUtility.Label("ACT_SWINGOF", 0)]
        [FastEnumUtility.Label("Swing Of", 1)]
        SwingOf = 8,
        [FastEnumUtility.Label("ACT_SWINGT1", 0)]
        [FastEnumUtility.Label("Swing T1", 1)]
        SwingT1 = 9,
        [FastEnumUtility.Label("ACT_SWINGT2", 0)]
        [FastEnumUtility.Label("Swing T2", 1)]
        SwingT2 = 10,
        [FastEnumUtility.Label("ACT_SWINGT3", 0)]
        [FastEnumUtility.Label("Swing T3", 1)]
        SwingT3 = 11,
        [FastEnumUtility.Label("ACT_SWINGTF", 0)]
        [FastEnumUtility.Label("Swing Tf", 1)]
        SwingTf = 12,
        [FastEnumUtility.Label("ACT_SWINGP1", 0)]
        [FastEnumUtility.Label("Swing P1", 1)]
        SwingP1 = 13,
        [FastEnumUtility.Label("ACT_SWINGP2", 0)]
        [FastEnumUtility.Label("Swing P2", 1)]
        SwingP2 = 14,
        [FastEnumUtility.Label("ACT_SWINGPF", 0)]
        [FastEnumUtility.Label("Swing Pf", 1)]
        SwingPf = 15,
        [FastEnumUtility.Label("ACT_STABO1", 0)]
        [FastEnumUtility.Label("Stab O1", 1)]
        StabO1 = 16,
        [FastEnumUtility.Label("ACT_STABO2", 0)]
        [FastEnumUtility.Label("Stab O2", 1)]
        StabO2 = 17,
        [FastEnumUtility.Label("ACT_STABOF", 0)]
        [FastEnumUtility.Label("Stab Of", 1)]
        StabOf = 18,
        [FastEnumUtility.Label("ACT_STABT1", 0)]
        [FastEnumUtility.Label("Stab T1", 1)]
        StabT1 = 19,
        [FastEnumUtility.Label("ACT_STABT2", 0)]
        [FastEnumUtility.Label("Stab T2", 1)]
        StabT2 = 20,
        [FastEnumUtility.Label("ACT_STABTF", 0)]
        [FastEnumUtility.Label("Stab Tf", 1)]
        StabTf = 21,
        [FastEnumUtility.Label("ACT_SWINGD1", 0)]
        [FastEnumUtility.Label("Swing D1", 1)]
        SwingD1 = 22,
        [FastEnumUtility.Label("ACT_SWINGD2", 0)]
        [FastEnumUtility.Label("Swing D2", 1)]
        SwingD2 = 23,
        [FastEnumUtility.Label("ACT_STABD1", 0)]
        [FastEnumUtility.Label("Stab D1", 1)]
        StabD1 = 24,
        [FastEnumUtility.Label("ACT_TRIPLEBLOW", 0)]
        [FastEnumUtility.Label("Triple Blow", 1)]
        TripleBlow = 25,
        [FastEnumUtility.Label("ACT_QUADBLOW", 0)]
        [FastEnumUtility.Label("Quad Blow", 1)]
        QuadBlow = 26,
        [FastEnumUtility.Label("ACT_DEATHBLOW", 0)]
        [FastEnumUtility.Label("Death Blow", 1)]
        DeathBlow = 27,
        [FastEnumUtility.Label("ACT_FINISHBLOW", 0)]
        [FastEnumUtility.Label("Finish Blow", 1)]
        FinishBlow = 28,
        [FastEnumUtility.Label("ACT_FINISHATTACK_LINK", 0)]
        [FastEnumUtility.Label("Finish Attack Link", 1)]
        FinishAttackLink = 29,
        [FastEnumUtility.Label("ACT_FINISHATTACK_LINK2", 0)]
        [FastEnumUtility.Label("Finish Attack Link2", 1)]
        FinishAttackLink2 = 30,
        [FastEnumUtility.Label("ACT_SHOOT1", 0)]
        Shoot1 = 31,
        [FastEnumUtility.Label("ACT_SHOOT2", 0)]
        Shoot2 = 32,
        [FastEnumUtility.Label("ACT_SHOOT3", 0)]
        Shoot3 = 33,
        [FastEnumUtility.Label("ACT_SHOOT4", 0)]
        Shoot4 = 34,
        [FastEnumUtility.Label("ACT_SHOOT5", 0)]
        Shoot5 = 35,
        [FastEnumUtility.Label("ACT_SHOOTF", 0)]
        [FastEnumUtility.Label("Shoot F", 1)]
        ShootF = 36,
        [FastEnumUtility.Label("ACT_MAGICATTACK1", 0)]
        [FastEnumUtility.Label("Magic Attack1", 1)]
        MagicAttack1 = 37,
        [FastEnumUtility.Label("ACT_MAGICATTACK2", 0)]
        [FastEnumUtility.Label("Magic Attack2", 1)]
        MagicAttack2 = 38,
        [FastEnumUtility.Label("ACT_MAGICATTACKF", 0)]
        [FastEnumUtility.Label("Magic Attack F", 1)]
        MagicAttackF = 39,
        [FastEnumUtility.Label("ACT_MAGICHEAL", 0)]
        [FastEnumUtility.Label("Magic Heal", 1)]
        MagicHeal = 40,
        [FastEnumUtility.Label("ACT_PRONESTAB", 0)]
        [FastEnumUtility.Label("Prone Stab", 1)]
        ProneStab = 41,
        [FastEnumUtility.Label("ACT_PRONE", 0)]
        Prone = 42,
        [FastEnumUtility.Label("ACT_FLY1", 0)]
        Fly1 = 43,
        [FastEnumUtility.Label("ACT_JUMP", 0)]
        Jump = 44,
        [FastEnumUtility.Label("ACT_LADDER", 0)]
        Ladder = 45,
        [FastEnumUtility.Label("ACT_ROPE", 0)]
        Rope = 46,
        [FastEnumUtility.Label("ACT_DEAD", 0)]
        Dead = 47,
        [FastEnumUtility.Label("ACT_SIT", 0)]
        Sit = 48,
        [FastEnumUtility.Label("ACT_SIT2", 0)]
        Sit2 = 49,
        [FastEnumUtility.Label("ACT_SIT3", 0)]
        Sit3 = 50,
        [FastEnumUtility.Label("ACT_SIT4", 0)]
        Sit4 = 51,
        [FastEnumUtility.Label("ACT_SIT5", 0)]
        Sit5 = 52,
        [FastEnumUtility.Label("ACT_SIT6", 0)]
        Sit6 = 53,
        [FastEnumUtility.Label("ACT_SIT7", 0)]
        Sit7 = 54,
        [FastEnumUtility.Label("ACT_TIRED", 0)]
        Tired = 55,
        [FastEnumUtility.Label("ACT_SIEGE2_PRONE", 0)]
        Siege2Prone = 56,
        [FastEnumUtility.Label("ACT_PRONESTAB_JAGUAR", 0)]
        [FastEnumUtility.Label("Prone Stab Jaguar", 1)]
        ProneStabJaguar = 57,
        [FastEnumUtility.Label("ACT_ALERT2", 0)]
        Alert2 = 58,
        [FastEnumUtility.Label("ACT_ALERT3", 0)]
        Alert3 = 59,
        [FastEnumUtility.Label("ACT_ALERT4", 0)]
        Alert4 = 60,
        [FastEnumUtility.Label("ACT_ALERT5", 0)]
        Alert5 = 61,
        [FastEnumUtility.Label("ACT_ALERT6", 0)]
        Alert6 = 62,
        [FastEnumUtility.Label("ACT_ALERT7", 0)]
        Alert7 = 63,
        [FastEnumUtility.Label("ACT_LADDER2", 0)]
        Ladder2 = 64,
        [FastEnumUtility.Label("ACT_ROPE2", 0)]
        Rope2 = 65,
        [FastEnumUtility.Label("ACT_SHOOT6", 0)]
        Shoot6 = 66,
        [FastEnumUtility.Label("ACT_MAGIC1", 0)]
        Magic1 = 67,
        [FastEnumUtility.Label("ACT_MAGIC2", 0)]
        Magic2 = 68,
        [FastEnumUtility.Label("ACT_MAGIC3", 0)]
        Magic3 = 69,
        [FastEnumUtility.Label("ACT_MAGIC5", 0)]
        Magic5 = 70,
        [FastEnumUtility.Label("ACT_MAGIC6", 0)]
        Magic6 = 71,
        [FastEnumUtility.Label("ACT_BURSTER1", 0)]
        Burster1 = 72,
        [FastEnumUtility.Label("ACT_BURSTER2", 0)]
        Burster2 = 73,
        [FastEnumUtility.Label("ACT_SAVAGEBLOW", 0)]
        [FastEnumUtility.Label("Savage Blow", 1)]
        SavageBlow = 74,
        [FastEnumUtility.Label("ACT_AVENGER", 0)]
        Avenger = 75,
        [FastEnumUtility.Label("ACT_ASSAULTER", 0)]
        Assaulter = 76,
        [FastEnumUtility.Label("ACT_PRONE2", 0)]
        Prone2 = 77,
        [FastEnumUtility.Label("ACT_ASSASSINATION", 0)]
        Assassination = 78,
        [FastEnumUtility.Label("ACT_ASSASSINATIONS", 0)]
        [FastEnumUtility.Label("Assassination S", 1)]
        AssassinationS = 79,
        [FastEnumUtility.Label("ACT_HUSTLE_DASH", 0)]
        [FastEnumUtility.Label("Hustle Dash", 1)]
        HustleDash = 80,
        [FastEnumUtility.Label("ACT_HUSTLE_STOP", 0)]
        [FastEnumUtility.Label("Hustle Stop", 1)]
        HustleStop = 81,
        [FastEnumUtility.Label("ACT_HUSTLE_ATTACK", 0)]
        [FastEnumUtility.Label("Hustle Attack", 1)]
        HustleAttack = 82,
        [FastEnumUtility.Label("ACT_RUSH", 0)]
        Rush = 83,
        [FastEnumUtility.Label("ACT_RUSH2", 0)]
        Rush2 = 84,
        [FastEnumUtility.Label("ACT_BRANDISH1", 0)]
        Brandish1 = 85,
        [FastEnumUtility.Label("ACT_BRANDISH2", 0)]
        Brandish2 = 86,
        [FastEnumUtility.Label("ACT_BRAVE_SLASH", 0)]
        [FastEnumUtility.Label("Brave Slash", 1)]
        BraveSlash = 87,
        [FastEnumUtility.Label("ACT_SANCTUARY", 0)]
        Sanctuary = 88,
        [FastEnumUtility.Label("ACT_METEOR", 0)]
        Meteor = 89,
        [FastEnumUtility.Label("ACT_PARALYZE", 0)]
        Paralyze = 90,
        [FastEnumUtility.Label("ACT_BLIZZARD", 0)]
        Blizzard = 91,
        [FastEnumUtility.Label("ACT_GENESIS", 0)]
        Genesis = 92,
        [FastEnumUtility.Label("ACT_NINJASTORM", 0)]
        [FastEnumUtility.Label("Ninja Storm", 1)]
        NinjaStorm = 93,
        [FastEnumUtility.Label("ACT_BLAST", 0)]
        Blast = 94,
        [FastEnumUtility.Label("ACT_HOLYSHIELD", 0)]
        [FastEnumUtility.Label("Holy Shield", 1)]
        HolyShield = 95,
        [FastEnumUtility.Label("ACT_SHOWDOWN", 0)]
        Showdown = 96,
        [FastEnumUtility.Label("ACT_RESURRECTION", 0)]
        Resurrection = 97,
        [FastEnumUtility.Label("ACT_CHAINLIGHTNING", 0)]
        [FastEnumUtility.Label("Chain Lightning", 1)]
        ChainLightning = 98,
        [FastEnumUtility.Label("ACT_SMOKESHELL", 0)]
        [FastEnumUtility.Label("Smoke Shell", 1)]
        SmokeShell = 99,
        [FastEnumUtility.Label("ACT_HANDGUN", 0)]
        Handgun = 100,
        [FastEnumUtility.Label("ACT_SOMERSAULT", 0)]
        Somersault = 101,
        [FastEnumUtility.Label("ACT_STRAIGHT", 0)]
        Straight = 102,
        [FastEnumUtility.Label("ACT_EBURSTER", 0)]
        EBurster = 103,
        [FastEnumUtility.Label("ACT_BACKSPIN", 0)]
        [FastEnumUtility.Label("Back Spin", 1)]
        BackSpin = 104,
        [FastEnumUtility.Label("ACT_EORB", 0)]
        EOrb = 105,
        [FastEnumUtility.Label("ACT_SCREW", 0)]
        Screw = 106,
        [FastEnumUtility.Label("ACT_DOUBLEUPPER", 0)]
        [FastEnumUtility.Label("Double Upper", 1)]
        DoubleUpper = 107,
        [FastEnumUtility.Label("ACT_DRAGONSTRIKE", 0)]
        [FastEnumUtility.Label("Dragon Strike", 1)]
        DragonStrike = 108,
        [FastEnumUtility.Label("ACT_DOUBLEFIRE", 0)]
        [FastEnumUtility.Label("Double Fire", 1)]
        DoubleFire = 109,
        [FastEnumUtility.Label("ACT_TRIPLEFIRE", 0)]
        [FastEnumUtility.Label("Triple Fire", 1)]
        TripleFire = 110,
        [FastEnumUtility.Label("ACT_FAKE", 0)]
        Fake = 111,
        [FastEnumUtility.Label("ACT_AIRSTRIKE", 0)]
        [FastEnumUtility.Label("Air Strike", 1)]
        AirStrike = 112,
        [FastEnumUtility.Label("ACT_EDRAIN", 0)]
        EDrain = 113,
        [FastEnumUtility.Label("ACT_OCTOPUS", 0)]
        Octopus = 114,
        [FastEnumUtility.Label("ACT_BACKSTEP", 0)]
        [FastEnumUtility.Label("Back Step", 1)]
        BackStep = 115,
        [FastEnumUtility.Label("ACT_SHOT", 0)]
        Shot = 116,
        [FastEnumUtility.Label("ACT_RECOVERY", 0)]
        Recovery = 117,
        [FastEnumUtility.Label("ACT_FIREBURNER", 0)]
        [FastEnumUtility.Label("Fire Burner", 1)]
        FireBurner = 118,
        [FastEnumUtility.Label("ACT_COOLINGEFFECT", 0)]
        [FastEnumUtility.Label("Cooling Effect", 1)]
        CoolingEffect = 119,
        [FastEnumUtility.Label("ACT_FIST", 0)]
        Fist = 120,
        [FastEnumUtility.Label("ACT_TIMELEAP", 0)]
        [FastEnumUtility.Label("Time Leap", 1)]
        TimeLeap = 121,
        [FastEnumUtility.Label("ACT_RAPIDFIRE", 0)]
        [FastEnumUtility.Label("Rapid Fire", 1)]
        RapidFire = 122,
        [FastEnumUtility.Label("ACT_HOMING", 0)]
        Homing = 123,
        [FastEnumUtility.Label("ACT_GHOST_WALK", 0)]
        [FastEnumUtility.Label("Ghost Walk", 1)]
        GhostWalk = 124,
        [FastEnumUtility.Label("ACT_GHOST_STAND", 0)]
        [FastEnumUtility.Label("Ghost Stand", 1)]
        GhostStand = 125,
        [FastEnumUtility.Label("ACT_GHOST_JUMP", 0)]
        [FastEnumUtility.Label("Ghost Jump", 1)]
        GhostJump = 126,
        [FastEnumUtility.Label("ACT_GHOST_PRONESTAB", 0)]
        [FastEnumUtility.Label("Ghost Prone Stab", 1)]
        GhostProneStab = 127,
        [FastEnumUtility.Label("ACT_GHOST_FLY", 0)]
        [FastEnumUtility.Label("Ghost Fly", 1)]
        GhostFly = 128,
        [FastEnumUtility.Label("ACT_GHOST_LADDER", 0)]
        [FastEnumUtility.Label("Ghost Ladder", 1)]
        GhostLadder = 129,
        [FastEnumUtility.Label("ACT_GHOST_ROPE", 0)]
        [FastEnumUtility.Label("Ghost Rope", 1)]
        GhostRope = 130,
        [FastEnumUtility.Label("ACT_GHOST_SIT", 0)]
        [FastEnumUtility.Label("Ghost Sit", 1)]
        GhostSit = 131,
        [FastEnumUtility.Label("ACT_CANNON", 0)]
        Cannon = 132,
        [FastEnumUtility.Label("ACT_TORPEDO", 0)]
        Torpedo = 133,
        [FastEnumUtility.Label("ACT_DARKSIGHT", 0)]
        [FastEnumUtility.Label("Dark Sight", 1)]
        DarkSight = 134,
        [FastEnumUtility.Label("ACT_BAMBOO", 0)]
        Bamboo = 135,
        [FastEnumUtility.Label("ACT_PYRAMID", 0)]
        Pyramid = 136,
        [FastEnumUtility.Label("ACT_WAVE", 0)]
        Wave = 137,
        [FastEnumUtility.Label("ACT_BLADE", 0)]
        Blade = 138,
        [FastEnumUtility.Label("ACT_SOUL_DRIVER", 0)]
        [FastEnumUtility.Label("Soul Driver", 1)]
        SoulDriver = 139,
        [FastEnumUtility.Label("ACT_FIRE_STRIKE", 0)]
        [FastEnumUtility.Label("Fire Strike", 1)]
        FireStrike = 140,
        [FastEnumUtility.Label("ACT_FLAME_GEAR", 0)]
        [FastEnumUtility.Label("Flame Gear", 1)]
        FlameGear = 141,
        [FastEnumUtility.Label("ACT_STORM_BREAK", 0)]
        [FastEnumUtility.Label("Storm Break", 1)]
        StormBreak = 142,
        [FastEnumUtility.Label("ACT_VAMPIRE", 0)]
        Vampire = 143,
        [FastEnumUtility.Label("ACT_EVENT_FLOATING", 0)]
        [FastEnumUtility.Label("Event Floating", 1)]
        EventFloating = 144,
        [FastEnumUtility.Label("ACT_SWINGT2_POLEARM", 0)]
        [FastEnumUtility.Label("Swing T2Polearm", 1)]
        SwingT2Polearm = 145,
        [FastEnumUtility.Label("ACT_SWINGP1_POLEARM", 0)]
        [FastEnumUtility.Label("Swing P1Polearm", 1)]
        SwingP1Polearm = 146,
        [FastEnumUtility.Label("ACT_SWINGP2_POLEARM", 0)]
        [FastEnumUtility.Label("Swing P2Polearm", 1)]
        SwingP2Polearm = 147,
        [FastEnumUtility.Label("ACT_DOUBLE_SWING", 0)]
        [FastEnumUtility.Label("Double Swing", 1)]
        DoubleSwing = 148,
        [FastEnumUtility.Label("ACT_TRIPLE_SWING", 0)]
        [FastEnumUtility.Label("Triple Swing", 1)]
        TripleSwing = 149,
        [FastEnumUtility.Label("ACT_FULL_SWING_DOUBLE", 0)]
        [FastEnumUtility.Label("Full Swing Double", 1)]
        FullSwingDouble = 150,
        [FastEnumUtility.Label("ACT_FULL_SWING_TRIPLE", 0)]
        [FastEnumUtility.Label("Full Swing Triple", 1)]
        FullSwingTriple = 151,
        [FastEnumUtility.Label("ACT_OVER_SWING_DOUBLE", 0)]
        [FastEnumUtility.Label("Over Swing Double", 1)]
        OverSwingDouble = 152,
        [FastEnumUtility.Label("ACT_OVER_SWING_TRIPLE", 0)]
        [FastEnumUtility.Label("Over Swing Triple", 1)]
        OverSwingTriple = 153,
        [FastEnumUtility.Label("ACT_ROLLING_SPIN", 0)]
        [FastEnumUtility.Label("Rolling Spin", 1)]
        RollingSpin = 154,
        [FastEnumUtility.Label("ACT_COMBO_SMASH", 0)]
        [FastEnumUtility.Label("Combo Smash", 1)]
        ComboSmash = 155,
        [FastEnumUtility.Label("ACT_COMBO_FENRIR", 0)]
        [FastEnumUtility.Label("Combo Fenrir", 1)]
        ComboFenrir = 156,
        [FastEnumUtility.Label("ACT_COMBO_TEMPEST", 0)]
        [FastEnumUtility.Label("Combo Tempest", 1)]
        ComboTempest = 157,
        [FastEnumUtility.Label("ACT_FINAL_CHARGE", 0)]
        [FastEnumUtility.Label("Final Charge", 1)]
        FinalCharge = 158,
        [FastEnumUtility.Label("ACT_COMBAT_STEP", 0)]
        [FastEnumUtility.Label("Combat Step", 1)]
        CombatStep = 159,
        [FastEnumUtility.Label("ACT_FINAL_BLOW", 0)]
        [FastEnumUtility.Label("Final Blow", 1)]
        FinalBlow = 160,
        [FastEnumUtility.Label("ACT_FINAL_TOSS", 0)]
        [FastEnumUtility.Label("Final Toss", 1)]
        FinalToss = 161,
        [FastEnumUtility.Label("ACT_MAGIC_MISSILE", 0)]
        [FastEnumUtility.Label("Magic Missile", 1)]
        MagicMissile = 162,
        [FastEnumUtility.Label("ACT_LIGHTINGBOLT", 0)]
        [FastEnumUtility.Label("Lighting Bolt", 1)]
        LightingBolt = 163,
        [FastEnumUtility.Label("ACT_DRAGON_BREATHE", 0)]
        [FastEnumUtility.Label("Dragon Breathe", 1)]
        DragonBreathe = 164,
        [FastEnumUtility.Label("ACT_BREATHE_PREPARE", 0)]
        [FastEnumUtility.Label("Breathe Prepare", 1)]
        BreathePrepare = 165,
        [FastEnumUtility.Label("ACT_DRAGON_ICE_BREATHE", 0)]
        [FastEnumUtility.Label("Dragon Ice Breathe", 1)]
        DragonIceBreathe = 166,
        [FastEnumUtility.Label("ACT_ICE_BREATHE_PREPARE", 0)]
        [FastEnumUtility.Label("Ice Breathe Prepare", 1)]
        IceBreathePrepare = 167,
        [FastEnumUtility.Label("ACT_BLAZE", 0)]
        Blaze = 168,
        [FastEnumUtility.Label("ACT_FIRECIRCLE", 0)]
        [FastEnumUtility.Label("Fire Circle", 1)]
        FireCircle = 169,
        [FastEnumUtility.Label("ACT_ILLUSION", 0)]
        Illusion = 170,
        [FastEnumUtility.Label("ACT_MAGICFLARE", 0)]
        [FastEnumUtility.Label("Magic Flare", 1)]
        MagicFlare = 171,
        [FastEnumUtility.Label("ACT_ELEMENTAL_RESET", 0)]
        [FastEnumUtility.Label("Elemental Reset", 1)]
        ElementalReset = 172,
        [FastEnumUtility.Label("ACT_MAGIC_REGISTANCE", 0)]
        [FastEnumUtility.Label("Magic Resistance", 1)]
        MagicResistance = 173,
        [FastEnumUtility.Label("ACT_RECOVERY_AURA", 0)]
        [FastEnumUtility.Label("Recovery Aura", 1)]
        RecoveryAura = 174,
        [FastEnumUtility.Label("ACT_MAGIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Magic Booster", 1)]
        MagicBooster = 175,
        [FastEnumUtility.Label("ACT_MAGIC_SHIELD", 0)]
        [FastEnumUtility.Label("Magic Shield", 1)]
        MagicShield = 176,
        [FastEnumUtility.Label("ACT_FLAME_WHEEL", 0)]
        [FastEnumUtility.Label("Flame Wheel", 1)]
        FlameWheel = 177,
        [FastEnumUtility.Label("ACT_KILLING_WING", 0)]
        [FastEnumUtility.Label("Killing Wing", 1)]
        KillingWing = 178,
        [FastEnumUtility.Label("ACT_ONIX_BLESSING", 0)]
        [FastEnumUtility.Label("Onix Blessing", 1)]
        OnixBlessing = 179,
        [FastEnumUtility.Label("ACT_EARTHQUAKE", 0)]
        Earthquake = 180,
        [FastEnumUtility.Label("ACT_SOULSTONE", 0)]
        [FastEnumUtility.Label("Soul Stone", 1)]
        SoulStone = 181,
        [FastEnumUtility.Label("ACT_DRAGONTHRUST", 0)]
        [FastEnumUtility.Label("Dragon Thrust", 1)]
        DragonThrust = 182,
        [FastEnumUtility.Label("ACT_GHOST_LETHERING", 0)]
        [FastEnumUtility.Label("Ghost Lethering", 1)]
        GhostLethering = 183,
        [FastEnumUtility.Label("ACT_DARKFOG", 0)]
        [FastEnumUtility.Label("Dark Fog", 1)]
        DarkFog = 184,
        [FastEnumUtility.Label("ACT_SLOW", 0)]
        Slow = 185,
        [FastEnumUtility.Label("ACT_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Maple Hero", 1)]
        MapleHero = 186,
        [FastEnumUtility.Label("ACT_AWAKENING", 0)]
        Awakening = 187,
        [FastEnumUtility.Label("ACT_FLYING_ASSAULTER", 0)]
        [FastEnumUtility.Label("Flying Assaulter", 1)]
        FlyingAssaulter = 188,
        [FastEnumUtility.Label("ACT_TRIPLE_STAB", 0)]
        [FastEnumUtility.Label("Triple Stab", 1)]
        TripleStab = 189,
        [FastEnumUtility.Label("ACT_FATAL_BLOW", 0)]
        [FastEnumUtility.Label("Fatal Blow", 1)]
        FatalBlow = 190,
        [FastEnumUtility.Label("ACT_SLASH_STORM1", 0)]
        [FastEnumUtility.Label("Slash Storm1", 1)]
        SlashStorm1 = 191,
        [FastEnumUtility.Label("ACT_SLASH_STORM2", 0)]
        [FastEnumUtility.Label("Slash Storm2", 1)]
        SlashStorm2 = 192,
        [FastEnumUtility.Label("ACT_SLASH_STORM3", 0)]
        [FastEnumUtility.Label("Slash Storm3", 1)]
        SlashStorm3 = 193,
        [FastEnumUtility.Label("ACT_FLASH_BANG", 0)]
        [FastEnumUtility.Label("Flash Bang", 1)]
        FlashBang = 194,
        [FastEnumUtility.Label("ACT_UPPER_STAB", 0)]
        [FastEnumUtility.Label("Upper Stab", 1)]
        UpperStab = 195,
        [FastEnumUtility.Label("ACT_OWL_DEAD", 0)]
        [FastEnumUtility.Label("Owl Dead", 1)]
        OwlDead = 196,
        [FastEnumUtility.Label("ACT_CHAIN_PULL", 0)]
        [FastEnumUtility.Label("Chain Pull", 1)]
        ChainPull = 197,
        [FastEnumUtility.Label("ACT_CHAIN_ATTACK", 0)]
        [FastEnumUtility.Label("Chain Attack", 1)]
        ChainAttack = 198,
        [FastEnumUtility.Label("ACT_SUDDEN_DEATH", 0)]
        [FastEnumUtility.Label("Sudden Death", 1)]
        SuddenDeath = 199,
        [FastEnumUtility.Label("ACT_MONSTER_BOMB_PREPARE", 0)]
        [FastEnumUtility.Label("Monster Bomb Prepare", 1)]
        MonsterBombPrepare = 200,
        [FastEnumUtility.Label("ACT_MONSTER_BOMB_THROW", 0)]
        [FastEnumUtility.Label("Monster Bomb Throw", 1)]
        MonsterBombThrow = 201,
        [FastEnumUtility.Label("ACT_FINAL_CUT", 0)]
        [FastEnumUtility.Label("Final Cut", 1)]
        FinalCut = 202,
        [FastEnumUtility.Label("ACT_FINAL_CUT_PREPARE", 0)]
        [FastEnumUtility.Label("Final Cut Prepare", 1)]
        FinalCutPrepare = 203,
        [FastEnumUtility.Label("ACT_CYCLONE_PRE", 0)]
        [FastEnumUtility.Label("Cyclone Pre", 1)]
        CyclonePre = 204,
        [FastEnumUtility.Label("ACT_CYCLONE", 0)]
        Cyclone = 205,
        [FastEnumUtility.Label("ACT_CYCLONE_AFTER", 0)]
        [FastEnumUtility.Label("Cyclone After", 1)]
        CycloneAfter = 206,
        [FastEnumUtility.Label("ACT_DOUBLEJUMP", 0)]
        [FastEnumUtility.Label("Double Jump", 1)]
        DoubleJump = 207,
        [FastEnumUtility.Label("ACT_KNOCKBACK", 0)]
        Knockback = 208,
        [FastEnumUtility.Label("ACT_ROCKET_BOOSTER_START", 0)]
        [FastEnumUtility.Label("Rocket Booster Start", 1)]
        RocketBoosterStart = 209,
        [FastEnumUtility.Label("ACT_ROCKET_BOOSTER", 0)]
        [FastEnumUtility.Label("Rocket Booster", 1)]
        RocketBooster = 210,
        [FastEnumUtility.Label("ACT_ROCKET_BOOSTER_END", 0)]
        [FastEnumUtility.Label("Rocket Booster End", 1)]
        RocketBoosterEnd = 211,
        [FastEnumUtility.Label("ACT_CROSS_ROAD", 0)]
        [FastEnumUtility.Label("Cross Road", 1)]
        CrossRoad = 212,
        [FastEnumUtility.Label("ACT_NEMESIS", 0)]
        Nemesis = 213,
        [FastEnumUtility.Label("ACT_WILDBEAST", 0)]
        [FastEnumUtility.Label("Wild Beast", 1)]
        WildBeast = 214,
        [FastEnumUtility.Label("ACT_SIEGE1_START", 0)]
        Siege1Start = 215,
        [FastEnumUtility.Label("ACT_SIEGE1", 0)]
        Siege1 = 216,
        [FastEnumUtility.Label("ACT_SIEGE1_STAND", 0)]
        Siege1Stand = 217,
        [FastEnumUtility.Label("ACT_SIEGE1_END", 0)]
        Siege1End = 218,
        [FastEnumUtility.Label("ACT_SIEGE2_START", 0)]
        Siege2Start = 219,
        [FastEnumUtility.Label("ACT_SIEGE2", 0)]
        Siege2 = 220,
        [FastEnumUtility.Label("ACT_SIEGE2_STAND", 0)]
        Siege2Stand = 221,
        [FastEnumUtility.Label("ACT_SIEGE2_END", 0)]
        Siege2End = 222,
        [FastEnumUtility.Label("ACT_SIEGE2_WALK", 0)]
        Siege2Walk = 223,
        [FastEnumUtility.Label("ACT_SIEGE2_LASER", 0)]
        Siege2Laser = 224,
        [FastEnumUtility.Label("ACT_SIEGE_START", 0)]
        [FastEnumUtility.Label("Siege Start", 1)]
        SiegeStart = 225,
        [FastEnumUtility.Label("ACT_SIEGE", 0)]
        Siege = 226,
        [FastEnumUtility.Label("ACT_SIEGE_STAND", 0)]
        [FastEnumUtility.Label("Siege Stand", 1)]
        SiegeStand = 227,
        [FastEnumUtility.Label("ACT_SIEGE_END", 0)]
        [FastEnumUtility.Label("Siege End", 1)]
        SiegeEnd = 228,
        [FastEnumUtility.Label("ACT_SONICBOOM", 0)]
        [FastEnumUtility.Label("Sonic Boom", 1)]
        SonicBoom = 229,
        [FastEnumUtility.Label("ACT_REVIVE", 0)]
        Revive = 230,
        [FastEnumUtility.Label("ACT_DARK_SPEAR", 0)]
        [FastEnumUtility.Label("Dark Spear", 1)]
        DarkSpear = 231,
        [FastEnumUtility.Label("ACT_DARK_CHAIN", 0)]
        [FastEnumUtility.Label("Dark Chain", 1)]
        DarkChain = 232,
        [FastEnumUtility.Label("ACT_FLAMETHROWER_START", 0)]
        [FastEnumUtility.Label("Flamethrower Start", 1)]
        FlamethrowerStart = 233,
        [FastEnumUtility.Label("ACT_FLAMETHROWER", 0)]
        Flamethrower = 234,
        [FastEnumUtility.Label("ACT_FLAMETHROWER_END", 0)]
        [FastEnumUtility.Label("Flamethrower End", 1)]
        FlamethrowerEnd = 235,
        [FastEnumUtility.Label("ACT_FLAMETHROWER2_START", 0)]
        Flamethrower2Start = 236,
        [FastEnumUtility.Label("ACT_FLAMETHROWER2", 0)]
        Flamethrower2 = 237,
        [FastEnumUtility.Label("ACT_FLAMETHROWER2_END", 0)]
        Flamethrower2End = 238,
        [FastEnumUtility.Label("ACT_MECHANIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Mechanic Booster", 1)]
        MechanicBooster = 239,
        [FastEnumUtility.Label("ACT_MSUMMON", 0)]
        MSummon = 240,
        [FastEnumUtility.Label("ACT_MSUMMON2", 0)]
        MSummon2 = 241,
        [FastEnumUtility.Label("ACT_GATLINGSHOT", 0)]
        [FastEnumUtility.Label("Gatling Shot", 1)]
        GatlingShot = 242,
        [FastEnumUtility.Label("ACT_GATLINGSHOT2", 0)]
        [FastEnumUtility.Label("Gatling Shot2", 1)]
        GatlingShot2 = 243,
        [FastEnumUtility.Label("ACT_DRILLRUSH", 0)]
        [FastEnumUtility.Label("Drill Rush", 1)]
        DrillRush = 244,
        [FastEnumUtility.Label("ACT_EARTHSLUG", 0)]
        [FastEnumUtility.Label("Earth Slug", 1)]
        EarthSlug = 245,
        [FastEnumUtility.Label("ACT_ROCKET_PUNCH", 0)]
        [FastEnumUtility.Label("Rocket Punch", 1)]
        RocketPunch = 246,
        [FastEnumUtility.Label("ACT_CLAW_CUT", 0)]
        [FastEnumUtility.Label("Claw Cut", 1)]
        ClawCut = 247,
        [FastEnumUtility.Label("ACT_SWALLOW", 0)]
        Swallow = 248,
        [FastEnumUtility.Label("ACT_SWALLOW_LOOP", 0)]
        [FastEnumUtility.Label("Swallow Loop", 1)]
        SwallowLoop = 249,
        [FastEnumUtility.Label("ACT_SWALLOW_ATTACK", 0)]
        [FastEnumUtility.Label("Swallow Attack", 1)]
        SwallowAttack = 250,
        [FastEnumUtility.Label("ACT_SWALLOW_PRE", 0)]
        [FastEnumUtility.Label("Swallow Pre", 1)]
        SwallowPre = 251,
        [FastEnumUtility.Label("ACT_FLASH_RAIN", 0)]
        [FastEnumUtility.Label("Flash Rain", 1)]
        FlashRain = 252,
        [FastEnumUtility.Label("ACT_MINE", 0)]
        Mine = 253,
        [FastEnumUtility.Label("ACT_CAPTURE", 0)]
        Capture = 254,
        [FastEnumUtility.Label("ACT_RIDE", 0)]
        Ride = 255,
        [FastEnumUtility.Label("ACT_GETOFF", 0)]
        [FastEnumUtility.Label("Get Off", 1)]
        GetOff = 256,
        [FastEnumUtility.Label("ACT_RIDE2", 0)]
        Ride2 = 257,
        [FastEnumUtility.Label("ACT_GETOFF2", 0)]
        [FastEnumUtility.Label("Get Off2", 1)]
        GetOff2 = 258,
        [FastEnumUtility.Label("ACT_MECHANIC_RUSH", 0)]
        [FastEnumUtility.Label("Mechanic Rush", 1)]
        MechanicRush = 259,
        [FastEnumUtility.Label("ACT_TANK_MSUMMON", 0)]
        [FastEnumUtility.Label("Tank MSummon", 1)]
        TankMSummon = 260,
        [FastEnumUtility.Label("ACT_TANK_MSUMMON2", 0)]
        [FastEnumUtility.Label("Tank MSummon2", 1)]
        TankMSummon2 = 261,
        [FastEnumUtility.Label("ACT_TANK_MRUSH", 0)]
        [FastEnumUtility.Label("Tank MRush", 1)]
        TankMRush = 262,
        [FastEnumUtility.Label("ACT_TANK_RBOOSTER_PRE", 0)]
        [FastEnumUtility.Label("Tank RBooster Pre", 1)]
        TankRBoosterPre = 263,
        [FastEnumUtility.Label("ACT_TANK_RBOOSTER_AFTER", 0)]
        [FastEnumUtility.Label("Tank RBooster After", 1)]
        TankRBoosterAfter = 264,
        [FastEnumUtility.Label("ACT_SHOCKWAVE", 0)]
        [FastEnumUtility.Label("Shock Wave", 1)]
        ShockWave = 265,
        [FastEnumUtility.Label("ACT_DEMOLITION", 0)]
        Demolition = 266,
        [FastEnumUtility.Label("ACT_SNATCH", 0)]
        Snatch = 267,
        [FastEnumUtility.Label("ACT_WIND_SPEAR", 0)]
        [FastEnumUtility.Label("Wind Spear", 1)]
        WindSpear = 268,
        [FastEnumUtility.Label("ACT_WIND_SHOT", 0)]
        [FastEnumUtility.Label("Wind Shot", 1)]
        WindShot = 269,
        [FastEnumUtility.Label("ACT_FLY2", 0)]
        Fly2 = 270,
        [FastEnumUtility.Label("ACT_FLY2_MOVE", 0)]
        Fly2Move = 271,
        [FastEnumUtility.Label("ACT_FLY2_SKILL", 0)]
        Fly2Skill = 272,
        [FastEnumUtility.Label("ACT_NO", 0)]
        No = 273,
    }
    public enum CharacterBodyType : byte
    {
        [FastEnumUtility.Label("BASIC_TYPE", 0)]
        Basic = 0,
        [FastEnumUtility.Label("PET_TYPE", 0)]
        Pet = 1,
        [FastEnumUtility.Label("DRAGON_TYPE", 0)]
        Dragon = 2,
        [FastEnumUtility.Label("MECANIC_TYPE", 0)]
        Mechanic = 3,
    }
    [System.Flags]
    public enum CharacterDataFlag : uint
    {
        None = 0u,
        [FastEnumUtility.Label("DBCHAR_CHARACTER", 0)]
        Character = 1u,
        [FastEnumUtility.Label("DBCHAR_MONEY", 0)]
        Money = 2u,
        [FastEnumUtility.Label("DBCHAR_ITEMSLOTEQUIP", 0)]
        [FastEnumUtility.Label("Item Slot Equip", 1)]
        ItemSlotEquip = 4u,
        [FastEnumUtility.Label("DBCHAR_ITEMSLOTCONSUME", 0)]
        [FastEnumUtility.Label("Item Slot Consume", 1)]
        ItemSlotConsume = 8u,
        [FastEnumUtility.Label("DBCHAR_ITEMSLOTINSTALL", 0)]
        [FastEnumUtility.Label("Item Slot Install", 1)]
        ItemSlotInstall = 16u,
        [FastEnumUtility.Label("DBCHAR_ITEMSLOTETC", 0)]
        [FastEnumUtility.Label("Item Slot Etc", 1)]
        ItemSlotEtc = 32u,
        [FastEnumUtility.Label("DBCHAR_ITEMSLOTCASH", 0)]
        [FastEnumUtility.Label("Item Slot Cash", 1)]
        ItemSlotCash = 64u,
        [FastEnumUtility.Label("DBCHAR_INVENTORYSIZE", 0)]
        [FastEnumUtility.Label("Inventory Size", 1)]
        InventorySize = 128u,
        [FastEnumUtility.Label("DBCHAR_SKILLRECORD", 0)]
        [FastEnumUtility.Label("Skill Record", 1)]
        SkillRecord = 256u,
        [FastEnumUtility.Label("DBCHAR_QUESTRECORD", 0)]
        [FastEnumUtility.Label("Quest Record", 1)]
        QuestRecord = 512u,
        [FastEnumUtility.Label("DBCHAR_MINIGAMERECORD", 0)]
        [FastEnumUtility.Label("Mini Game Record", 1)]
        MiniGameRecord = 1024u,
        [FastEnumUtility.Label("Couple Record", 1)]
        [FastEnumUtility.Label("DBCHAR_COUPLERECORD", 0)]
        CoupleRecord = 2048u,
        [FastEnumUtility.Label("DBCHAR_MAPTRANSFER", 0)]
        [FastEnumUtility.Label("Map Transfer", 1)]
        MapTransfer = 4096u,
        [FastEnumUtility.Label("DBCHAR_AVATAR", 0)]
        Avatar = 8192u,
        [FastEnumUtility.Label("DBCHAR_QUESTCOMPLETE", 0)]
        [FastEnumUtility.Label("Quest Complete", 1)]
        QuestComplete = 16384u,
        [FastEnumUtility.Label("DBCHAR_SKILLCOOLTIME", 0)]
        [FastEnumUtility.Label("Skill Cooltime", 1)]
        SkillCooltime = 32768u,
        [FastEnumUtility.Label("DBCHAR_MONSTERBOOKCARD", 0)]
        [FastEnumUtility.Label("Monster Book Card", 1)]
        MonsterBookCard = 65536u,
        [FastEnumUtility.Label("DBCHAR_MONSTERBOOKCOVER", 0)]
        [FastEnumUtility.Label("Monster Book Cover", 1)]
        MonsterBookCover = 131072u,
        [FastEnumUtility.Label("DBCHAR_NEWYEARCARD", 0)]
        [FastEnumUtility.Label("New Year Card", 1)]
        NewYearCard = 262144u,
        [FastEnumUtility.Label("DBCHAR_QUESTRECORDEX", 0)]
        [FastEnumUtility.Label("Quest Record Ex", 1)]
        QuestRecordEx = 524288u,
        [FastEnumUtility.Label("DBCHAR_EQUIPEXT", 0)]
        [FastEnumUtility.Label("Equip Ext", 1)]
        EquipExt = 1048576u,
        [FastEnumUtility.Label("DBCHAR_WILDHUNTERINFO", 0)]
        [FastEnumUtility.Label("Wild Hunter Info", 1)]
        WildHunterInfo = 2097152u,
        [FastEnumUtility.Label("DBCHAR_QUESTCOMPLETE_OLD", 0)]
        [FastEnumUtility.Label("Quest Complete Old", 1)]
        QuestCompleteOld = 4194304u,
        [FastEnumUtility.Label("DBCHAR_VISITORLOG", 0)]
        [FastEnumUtility.Label("Visitor Log", 1)]
        VisitorLog = 8388608u,
        [FastEnumUtility.Label("DBCHAR_ALL", 0)]
        All = 4294967295u,
        [FastEnumUtility.Label("DBCHAR_ITEMSLOT", 0)]
        [FastEnumUtility.Label("Item Slot", 1)]
        ItemSlot = 124u,
    }
    [System.Flags]
    public enum CharacterStatFlag : uint
    {
        None = 0u,
        [FastEnumUtility.Label("CS_SKIN", 0)]
        Skin = 1u,
        [FastEnumUtility.Label("CS_FACE", 0)]
        Face = 2u,
        [FastEnumUtility.Label("CS_HAIR", 0)]
        Hair = 4u,
        [FastEnumUtility.Label("CS_PETSN", 0)]
        [FastEnumUtility.Label("Pet Sn", 1)]
        PetSn = 8u,
        [FastEnumUtility.Label("CS_LEV", 0)]
        Level = 16u,
        [FastEnumUtility.Label("CS_JOB", 0)]
        Job = 32u,
        [FastEnumUtility.Label("CS_STR", 0)]
        Str = 64u,
        [FastEnumUtility.Label("CS_DEX", 0)]
        Dex = 128u,
        [FastEnumUtility.Label("CS_INT", 0)]
        Int = 256u,
        [FastEnumUtility.Label("CS_LUK", 0)]
        Luk = 512u,
        [FastEnumUtility.Label("CS_HP", 0)]
        Hp = 1024u,
        [FastEnumUtility.Label("CS_MHP", 0)]
        [FastEnumUtility.Label("Max HP", 1)]
        MaxHp = 2048u,
        [FastEnumUtility.Label("CS_MP", 0)]
        Mp = 4096u,
        [FastEnumUtility.Label("CS_MMP", 0)]
        [FastEnumUtility.Label("Max MP", 1)]
        MaxMp = 8192u,
        [FastEnumUtility.Label("CS_AP", 0)]
        Ap = 16384u,
        [FastEnumUtility.Label("CS_SP", 0)]
        Sp = 32768u,
        [FastEnumUtility.Label("CS_EXP", 0)]
        Exp = 65536u,
        [FastEnumUtility.Label("CS_POP", 0)]
        Pop = 131072u,
        [FastEnumUtility.Label("CS_MONEY", 0)]
        Money = 262144u,
        [FastEnumUtility.Label("CS_PETSN2", 0)]
        [FastEnumUtility.Label("Pet Sn2", 1)]
        PetSn2 = 524288u,
        [FastEnumUtility.Label("CS_PETSN3", 0)]
        [FastEnumUtility.Label("Pet Sn3", 1)]
        PetSn3 = 1048576u,
        [FastEnumUtility.Label("CS_TEMPEXP", 0)]
        [FastEnumUtility.Label("Temp Exp", 1)]
        TempExp = 2097152u,
    }
    public enum ChatAvailability : byte
    {
        [FastEnumUtility.Label("CHAT_UNDEF", 0)]
        Undefined = 0,
        [FastEnumUtility.Label("CHAT_DISABLE", 0)]
        Disabled = 1,
        [FastEnumUtility.Label("CHAT_LINE1", 0)]
        Line1 = 2,
        [FastEnumUtility.Label("CHAT_AVAILABLE", 0)]
        Available = 3,
    }
    public enum ChatBalloonType : ushort
    {
        [FastEnumUtility.Label("CHATBALLOON_CHARACTER", 0)]
        Character = 1000,
        [FastEnumUtility.Label("CHATBALLOON_NPC", 0)]
        Npc = 1001,
        [FastEnumUtility.Label("CHATBALLOON_PET", 0)]
        Pet = 1002,
        [FastEnumUtility.Label("Ad Board", 1)]
        [FastEnumUtility.Label("CHATBALLOON_ADBOARD", 0)]
        AdBoard = 1003,
        [FastEnumUtility.Label("CHATBALLOON_MOB", 0)]
        Mob = 1004,
        [FastEnumUtility.Label("CHATBALLOON_SCREEN", 0)]
        Screen = 1005,
    }
    public enum ChatGroupType : byte
    {
        [FastEnumUtility.Label("CG_Friend", 0)]
        Friend = 0,
        [FastEnumUtility.Label("CG_Party", 0)]
        Party = 1,
        [FastEnumUtility.Label("CG_Guild", 0)]
        Guild = 2,
        [FastEnumUtility.Label("CG_Alliance", 0)]
        Alliance = 3,
        [FastEnumUtility.Label("CG_Couple", 0)]
        Couple = 4,
        [FastEnumUtility.Label("CG_ToCouple", 0)]
        [FastEnumUtility.Label("To Couple", 1)]
        ToCouple = 5,
        [FastEnumUtility.Label("CG_Expedition", 0)]
        Expedition = 6,
    }
    public enum ChatMessageType : byte
    {
        [FastEnumUtility.Label("CHAT_TYPE_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("CHAT_TYPE_WHISPER", 0)]
        Whisper = 1,
        [FastEnumUtility.Label("CHAT_TYPE_GROUPPARTY", 0)]
        [FastEnumUtility.Label("Group Party", 1)]
        GroupParty = 2,
        [FastEnumUtility.Label("CHAT_TYPE_GROUPFRIEND", 0)]
        [FastEnumUtility.Label("Group Friend", 1)]
        GroupFriend = 3,
        [FastEnumUtility.Label("CHAT_TYPE_GROUPGUILD", 0)]
        [FastEnumUtility.Label("Group Guild", 1)]
        GroupGuild = 4,
        [FastEnumUtility.Label("CHAT_TYPE_GROUPALLIANCE", 0)]
        [FastEnumUtility.Label("Group Alliance", 1)]
        GroupAlliance = 5,
        [FastEnumUtility.Label("CHAT_TYPE_COUPLE", 0)]
        Couple = 6,
        [FastEnumUtility.Label("CHAT_TYPE_GAMEDESC", 0)]
        [FastEnumUtility.Label("Game Desc", 1)]
        GameDesc = 7,
        [FastEnumUtility.Label("CHAT_TYPE_TIP", 0)]
        Tip = 8,
        [FastEnumUtility.Label("CHAT_TYPE_NOTICE", 0)]
        Notice = 9,
        [FastEnumUtility.Label("CHAT_TYPE_NOTICE2", 0)]
        Notice2 = 10,
        [FastEnumUtility.Label("Admin Chat", 1)]
        [FastEnumUtility.Label("CHAT_TYPE_ADMINCHAT", 0)]
        AdminChat = 11,
        [FastEnumUtility.Label("CHAT_TYPE_SYSTEM", 0)]
        System = 12,
        [FastEnumUtility.Label("CHAT_TYPE_SPEAKERCHANNEL", 0)]
        [FastEnumUtility.Label("Speaker Channel", 1)]
        SpeakerChannel = 13,
        [FastEnumUtility.Label("CHAT_TYPE_SPEAKERWORLD", 0)]
        [FastEnumUtility.Label("Speaker World", 1)]
        SpeakerWorld = 14,
        [FastEnumUtility.Label("CHAT_TYPE_SKULLSPEAKER", 0)]
        [FastEnumUtility.Label("Skull Speaker", 1)]
        SkullSpeaker = 15,
        [FastEnumUtility.Label("CHAT_TYPE_ITEMSPEAKER", 0)]
        [FastEnumUtility.Label("Item Speaker", 1)]
        ItemSpeaker = 16,
        [FastEnumUtility.Label("CHAT_TYPE_ITEMSPEAKER_ITEM", 0)]
        [FastEnumUtility.Label("Item Speaker Item", 1)]
        ItemSpeakerItem = 17,
        [FastEnumUtility.Label("Avatar Megaphone", 1)]
        [FastEnumUtility.Label("CHAT_TYPE_AVATARMEGAPHONE", 0)]
        AvatarMegaphone = 18,
        [FastEnumUtility.Label("CHAT_TYPE_GACHAPONANNOUNCE", 0)]
        [FastEnumUtility.Label("Gachapon Announce", 1)]
        GachaponAnnounce = 19,
        [FastEnumUtility.Label("CHAT_TYPE_CASHGACHAPONANNOUNCE", 0)]
        [FastEnumUtility.Label("Cash Gachapon Announce", 1)]
        CashGachaponAnnounce = 20,
        [FastEnumUtility.Label("CHAT_TYPE_CASHGACHAPON_OPEN_ANNOUNCE", 0)]
        [FastEnumUtility.Label("Cash Gachapon Open Announce", 1)]
        CashGachaponOpenAnnounce = 21,
        [FastEnumUtility.Label("CHAT_TYPE_CASHGACHAPON_COPY_ANNOUNCE", 0)]
        [FastEnumUtility.Label("Cash Gachapon Copy Announce", 1)]
        CashGachaponCopyAnnounce = 22,
        [FastEnumUtility.Label("CHAT_TYPE_SPEAKERBRIDGE", 0)]
        [FastEnumUtility.Label("Speaker Bridge", 1)]
        SpeakerBridge = 23,
        [FastEnumUtility.Label("CHAT_TYPE_SPEAKERWORLDEX_PREVIEW", 0)]
        [FastEnumUtility.Label("Speaker World Ex Preview", 1)]
        SpeakerWorldExPreview = 24,
        [FastEnumUtility.Label("CHAT_TYPE_MOB", 0)]
        Mob = 25,
        [FastEnumUtility.Label("CHAT_TYPE_EXPEDITION", 0)]
        Expedition = 26,
        [FastEnumUtility.Label("CHAT_TYPE_NO", 0)]
        No = 27,
    }
    public enum ChatTargetType : byte
    {
        [FastEnumUtility.Label("ID_CHAT_TARGET_FRIEND", 0)]
        Friend = 0,
        [FastEnumUtility.Label("Friend Group", 1)]
        [FastEnumUtility.Label("ID_CHAT_TARGET_FRIEND_GROUP", 0)]
        FriendGroup = 1,
        [FastEnumUtility.Label("ID_CHAT_TARGET_PARTY", 0)]
        Party = 2,
        [FastEnumUtility.Label("ID_CHAT_TARGET_EXPEDITION", 0)]
        Expedition = 3,
        [FastEnumUtility.Label("ID_CHAT_TARGET_GUILD", 0)]
        Guild = 4,
        [FastEnumUtility.Label("ID_CHAT_TARGET_ALLIANCE", 0)]
        Alliance = 5,
        [FastEnumUtility.Label("ID_CHAT_TARGET_COUPLE", 0)]
        Couple = 6,
        [FastEnumUtility.Label("ID_CHAT_TARGET_WHISPER", 0)]
        Whisper = 7,
        [FastEnumUtility.Label("ID_CHAT_TARGET_ALL", 0)]
        All = 8,
    }
    public enum ClaimResult : byte
    {
        [FastEnumUtility.Label("ClaimRes_Success", 0)]
        Success = 1,
        [FastEnumUtility.Label("ClaimRes_Success_Sender", 0)]
        [FastEnumUtility.Label("Success Sender", 1)]
        SuccessSender = 2,
        [FastEnumUtility.Label("ClaimRes_Success_Target", 0)]
        [FastEnumUtility.Label("Success Target", 1)]
        SuccessTarget = 3,
        [FastEnumUtility.Label("ClaimRes_Fail", 0)]
        Fail = 64,
        [FastEnumUtility.Label("ClaimRes_Fail_Unknown", 0)]
        [FastEnumUtility.Label("Fail Unknown", 1)]
        FailUnknown = 65,
        [FastEnumUtility.Label("ClaimRes_Fail_InvalidCharacter", 0)]
        [FastEnumUtility.Label("Fail Invalid Character", 1)]
        FailInvalidCharacter = 66,
        [FastEnumUtility.Label("ClaimRes_Fail_NotEnoughMoney", 0)]
        [FastEnumUtility.Label("Fail Not Enough Money", 1)]
        FailNotEnoughMoney = 67,
        [FastEnumUtility.Label("ClaimRes_Fail_NotConnected", 0)]
        [FastEnumUtility.Label("Fail Not Connected", 1)]
        FailNotConnected = 68,
        [FastEnumUtility.Label("ClaimRes_Fail_OverLimit", 0)]
        [FastEnumUtility.Label("Fail Over Limit", 1)]
        FailOverLimit = 69,
        [FastEnumUtility.Label("ClaimRes_Fail_OverWeeklyLimit", 0)]
        [FastEnumUtility.Label("Fail Over Weekly Limit", 1)]
        FailOverWeeklyLimit = 70,
        [FastEnumUtility.Label("ClaimRes_Fail_UnAvailable", 0)]
        [FastEnumUtility.Label("Fail Un Available", 1)]
        FailUnAvailable = 71,
        [FastEnumUtility.Label("ClaimRes_Fail_Liar", 0)]
        [FastEnumUtility.Label("Fail Liar", 1)]
        FailLiar = 72,
    }
    public enum ClientErrorCode : uint
    {
        [FastEnumUtility.Label("EC_PATCH", 0)]
        Patch = 536870912u,
        [FastEnumUtility.Label("Disconnect Begin", 1)]
        [FastEnumUtility.Label("EC_DISCONNECT_BEGIN", 0)]
        DisconnectBegin = 553648128u,
        [FastEnumUtility.Label("Connect To Game Failed", 1)]
        [FastEnumUtility.Label("EC_CONNECT_TO_GAME_FAILED", 0)]
        ConnectToGameFailed = 553648129u,
        [FastEnumUtility.Label("Connection From Game Closed", 1)]
        [FastEnumUtility.Label("EC_CONNECTION_FROM_GAME_CLOSED", 0)]
        ConnectionFromGameClosed = 553648130u,
        [FastEnumUtility.Label("EC_FAILED_PROTOCOL_WITH_GAME", 0)]
        [FastEnumUtility.Label("Failed Protocol With Game", 1)]
        FailedProtocolWithGame = 553648131u,
        [FastEnumUtility.Label("EC_FORCE_DISCONNECT", 0)]
        [FastEnumUtility.Label("Force Disconnect", 1)]
        ForceDisconnect = 553648132u,
        [FastEnumUtility.Label("Disconnect By Malicious Process", 1)]
        [FastEnumUtility.Label("EC_DISCONNECT_BY_MALICIOUS_PROCESS", 0)]
        DisconnectByMaliciousProcess = 553648133u,
        [FastEnumUtility.Label("Disconnect End", 1)]
        [FastEnumUtility.Label("EC_DISCONNECT_END", 0)]
        DisconnectEnd = 553648134u,
        [FastEnumUtility.Label("EC_TERMINATE_BEGIN", 0)]
        [FastEnumUtility.Label("Terminate Begin", 1)]
        TerminateBegin = 570425344u,
        [FastEnumUtility.Label("Connect To Login Failed", 1)]
        [FastEnumUtility.Label("EC_CONNECT_TO_LOGIN_FAILED", 0)]
        ConnectToLoginFailed = 570425345u,
        [FastEnumUtility.Label("Connection From Login Closed", 1)]
        [FastEnumUtility.Label("EC_CONNECTION_FROM_LOGIN_CLOSED", 0)]
        ConnectionFromLoginClosed = 570425346u,
        [FastEnumUtility.Label("EC_NOT_ENOUGH_MEMORY", 0)]
        [FastEnumUtility.Label("Not Enough Memory", 1)]
        NotEnoughMemory = 570425347u,
        [FastEnumUtility.Label("EC_NO_DATA_PACKAGE", 0)]
        [FastEnumUtility.Label("No Data Package", 1)]
        NoDataPackage = 570425348u,
        [FastEnumUtility.Label("EC_INVALID_GAME_DATA_VERSION", 0)]
        [FastEnumUtility.Label("Invalid Game Data Version", 1)]
        InvalidGameDataVersion = 570425349u,
        [FastEnumUtility.Label("EC_INVALID_GAME_DATA", 0)]
        [FastEnumUtility.Label("Invalid Game Data", 1)]
        InvalidGameData = 570425350u,
        [FastEnumUtility.Label("EC_INVALID_CLIENT_VERSION", 0)]
        [FastEnumUtility.Label("Invalid Client Version", 1)]
        InvalidClientVersion = 570425351u,
        [FastEnumUtility.Label("EC_FAILED_CRITICAL_PROTOCOL_WITH_GAME", 0)]
        [FastEnumUtility.Label("Failed Critical Protocol With Game", 1)]
        FailedCriticalProtocolWithGame = 570425352u,
        [FastEnumUtility.Label("EC_WEB_LOGIN_NEEDED", 0)]
        [FastEnumUtility.Label("Web Login Needed", 1)]
        WebLoginNeeded = 570425353u,
        [FastEnumUtility.Label("Client Crc Failed", 1)]
        [FastEnumUtility.Label("EC_CLIENTCRC_FAILED", 0)]
        ClientCrcFailed = 570425354u,
        [FastEnumUtility.Label("Download Full Client", 1)]
        [FastEnumUtility.Label("EC_DOWNLOAD_FULL_CLIENT", 0)]
        DownloadFullClient = 570425355u,
        [FastEnumUtility.Label("Auth Set Locale Failed", 1)]
        [FastEnumUtility.Label("EC_AUTH_SETLOCALE_FAILED", 0)]
        AuthSetLocaleFailed = 570425356u,
        [FastEnumUtility.Label("Auth Co Init Failed", 1)]
        [FastEnumUtility.Label("EC_AUTH_COINIT_FAILED", 0)]
        AuthCoInitFailed = 570425357u,
        [FastEnumUtility.Label("EC_TERMINATE_END", 0)]
        [FastEnumUtility.Label("Terminate End", 1)]
        TerminateEnd = 570425358u,
    }
    public enum ClientPacketOpcode : ushort
    {
        [FastEnumUtility.Label("CP_CheckPassword", 0)]
        [FastEnumUtility.Label("Check Password", 1)]
        CheckPassword = 1,
        [FastEnumUtility.Label("CP_GuestIDLogin", 0)]
        [FastEnumUtility.Label("Guest ID Login", 1)]
        GuestIDLogin = 2,
        [FastEnumUtility.Label("Account Info Request", 1)]
        [FastEnumUtility.Label("CP_AccountInfoRequest", 0)]
        AccountInfoRequest = 3,
        [FastEnumUtility.Label("CP_WorldInfoRequest", 0)]
        [FastEnumUtility.Label("World Info Request", 1)]
        WorldInfoRequest = 4,
        [FastEnumUtility.Label("CP_SelectWorld", 0)]
        [FastEnumUtility.Label("Select World", 1)]
        SelectWorld = 5,
        [FastEnumUtility.Label("CP_CheckUserLimit", 0)]
        [FastEnumUtility.Label("Check User Limit", 1)]
        CheckUserLimit = 6,
        [FastEnumUtility.Label("CP_ConfirmEULA", 0)]
        [FastEnumUtility.Label("Confirm EULA", 1)]
        ConfirmEULA = 7,
        [FastEnumUtility.Label("CP_SetGender", 0)]
        [FastEnumUtility.Label("Set Gender", 1)]
        SetGender = 8,
        [FastEnumUtility.Label("CP_CheckPinCode", 0)]
        [FastEnumUtility.Label("Check Pin Code", 1)]
        CheckPinCode = 9,
        [FastEnumUtility.Label("CP_UpdatePinCode", 0)]
        [FastEnumUtility.Label("Update Pin Code", 1)]
        UpdatePinCode = 10,
        [FastEnumUtility.Label("CP_WorldRequest", 0)]
        [FastEnumUtility.Label("World Request", 1)]
        WorldRequest = 11,
        [FastEnumUtility.Label("CP_LogoutWorld", 0)]
        [FastEnumUtility.Label("Logout World", 1)]
        LogoutWorld = 12,
        [FastEnumUtility.Label("CP_ViewAllChar", 0)]
        [FastEnumUtility.Label("View All Char", 1)]
        ViewAllChar = 13,
        [FastEnumUtility.Label("CP_SelectCharacterByVAC", 0)]
        [FastEnumUtility.Label("Select Character By VAC", 1)]
        SelectCharacterByVAC = 14,
        [FastEnumUtility.Label("CP_VACFlagSet", 0)]
        [FastEnumUtility.Label("VAC Flag Set", 1)]
        VACFlagSet = 15,
        [FastEnumUtility.Label("CP_CheckNameChangePossible", 0)]
        [FastEnumUtility.Label("Check Name Change Possible", 1)]
        CheckNameChangePossible = 16,
        [FastEnumUtility.Label("CP_RegisterNewCharacter", 0)]
        [FastEnumUtility.Label("Register New Character", 1)]
        RegisterNewCharacter = 17,
        [FastEnumUtility.Label("CP_CheckTransferWorldPossible", 0)]
        [FastEnumUtility.Label("Check Transfer World Possible", 1)]
        CheckTransferWorldPossible = 18,
        [FastEnumUtility.Label("CP_SelectCharacter", 0)]
        [FastEnumUtility.Label("Select Character", 1)]
        SelectCharacter = 19,
        [FastEnumUtility.Label("CP_MigrateIn", 0)]
        [FastEnumUtility.Label("Migrate In", 1)]
        MigrateIn = 20,
        [FastEnumUtility.Label("CP_CheckDuplicatedID", 0)]
        [FastEnumUtility.Label("Check Duplicated ID", 1)]
        CheckDuplicatedID = 21,
        [FastEnumUtility.Label("CP_CreateNewCharacter", 0)]
        [FastEnumUtility.Label("Create New Character", 1)]
        CreateNewCharacter = 22,
        [FastEnumUtility.Label("CP_CreateNewCharacterInCS", 0)]
        [FastEnumUtility.Label("Create New Character In CS", 1)]
        CreateNewCharacterInCS = 23,
        [FastEnumUtility.Label("CP_DeleteCharacter", 0)]
        [FastEnumUtility.Label("Delete Character", 1)]
        DeleteCharacter = 24,
        [FastEnumUtility.Label("Alive Ack", 1)]
        [FastEnumUtility.Label("CP_AliveAck", 0)]
        AliveAck = 25,
        [FastEnumUtility.Label("CP_ExceptionLog", 0)]
        [FastEnumUtility.Label("Exception Log", 1)]
        ExceptionLog = 26,
        [FastEnumUtility.Label("CP_SecurityPacket", 0)]
        [FastEnumUtility.Label("Security Packet", 1)]
        SecurityPacket = 27,
        [FastEnumUtility.Label("CP_EnableSPWRequest", 0)]
        [FastEnumUtility.Label("Enable SPW Request", 1)]
        EnableSPWRequest = 28,
        [FastEnumUtility.Label("CP_CheckSPWRequest", 0)]
        [FastEnumUtility.Label("Check SPW Request", 1)]
        CheckSPWRequest = 29,
        [FastEnumUtility.Label("CP_EnableSPWRequestByACV", 0)]
        [FastEnumUtility.Label("Enable SPW Request By ACV", 1)]
        EnableSPWRequestByACV = 30,
        [FastEnumUtility.Label("CP_CheckSPWRequestByACV", 0)]
        [FastEnumUtility.Label("Check SPW Request By ACV", 1)]
        CheckSPWRequestByACV = 31,
        [FastEnumUtility.Label("CP_CheckOTPRequest", 0)]
        [FastEnumUtility.Label("Check OTP Request", 1)]
        CheckOTPRequest = 32,
        [FastEnumUtility.Label("CP_CheckDeleteCharacterOTP", 0)]
        [FastEnumUtility.Label("Check Delete Character OTP", 1)]
        CheckDeleteCharacterOTP = 33,
        [FastEnumUtility.Label("CP_CreateSecurityHandle", 0)]
        [FastEnumUtility.Label("Create Security Handle", 1)]
        CreateSecurityHandle = 34,
        [FastEnumUtility.Label("CP_SSOErrorLog", 0)]
        [FastEnumUtility.Label("SSO Error Log", 1)]
        SSOErrorLog = 35,
        [FastEnumUtility.Label("CP_ClientDumpLog", 0)]
        [FastEnumUtility.Label("Client Dump Log", 1)]
        ClientDumpLog = 36,
        [FastEnumUtility.Label("CP_CheckExtraCharInfo", 0)]
        [FastEnumUtility.Label("Check Extra Char Info", 1)]
        CheckExtraCharInfo = 37,
        [FastEnumUtility.Label("CP_CreateNewCharacter_Ex", 0)]
        CreateNewCharacter_Ex = 38,
        [FastEnumUtility.Label("CP_UserTransferFieldRequest", 0)]
        [FastEnumUtility.Label("User Transfer Field Request", 1)]
        UserTransferFieldRequest = 41,
        [FastEnumUtility.Label("CP_UserTransferChannelRequest", 0)]
        [FastEnumUtility.Label("User Transfer Channel Request", 1)]
        UserTransferChannelRequest = 42,
        [FastEnumUtility.Label("CP_UserMigrateToCashShopRequest", 0)]
        [FastEnumUtility.Label("User Migrate To Cash Shop Request", 1)]
        UserMigrateToCashShopRequest = 43,
        [FastEnumUtility.Label("CP_UserMove", 0)]
        [FastEnumUtility.Label("User Move", 1)]
        UserMove = 44,
        [FastEnumUtility.Label("CP_UserSitRequest", 0)]
        [FastEnumUtility.Label("User Sit Request", 1)]
        UserSitRequest = 45,
        [FastEnumUtility.Label("CP_UserPortableChairSitRequest", 0)]
        [FastEnumUtility.Label("User Portable Chair Sit Request", 1)]
        UserPortableChairSitRequest = 46,
        [FastEnumUtility.Label("CP_UserMeleeAttack", 0)]
        [FastEnumUtility.Label("User Melee Attack", 1)]
        UserMeleeAttack = 47,
        [FastEnumUtility.Label("CP_UserShootAttack", 0)]
        [FastEnumUtility.Label("User Shoot Attack", 1)]
        UserShootAttack = 48,
        [FastEnumUtility.Label("CP_UserMagicAttack", 0)]
        [FastEnumUtility.Label("User Magic Attack", 1)]
        UserMagicAttack = 49,
        [FastEnumUtility.Label("CP_UserBodyAttack", 0)]
        [FastEnumUtility.Label("User Body Attack", 1)]
        UserBodyAttack = 50,
        [FastEnumUtility.Label("CP_UserMovingShootAttackPrepare", 0)]
        [FastEnumUtility.Label("User Moving Shoot Attack Prepare", 1)]
        UserMovingShootAttackPrepare = 51,
        [FastEnumUtility.Label("CP_UserHit", 0)]
        [FastEnumUtility.Label("User Hit", 1)]
        UserHit = 52,
        [FastEnumUtility.Label("CP_UserAttackUser", 0)]
        [FastEnumUtility.Label("User Attack User", 1)]
        UserAttackUser = 53,
        [FastEnumUtility.Label("CP_UserChat", 0)]
        [FastEnumUtility.Label("User Chat", 1)]
        UserChat = 54,
        [FastEnumUtility.Label("CP_UserADBoardClose", 0)]
        [FastEnumUtility.Label("User AD Board Close", 1)]
        UserADBoardClose = 55,
        [FastEnumUtility.Label("CP_UserEmotion", 0)]
        [FastEnumUtility.Label("User Emotion", 1)]
        UserEmotion = 56,
        [FastEnumUtility.Label("CP_UserActivateEffectItem", 0)]
        [FastEnumUtility.Label("User Activate Effect Item", 1)]
        UserActivateEffectItem = 57,
        [FastEnumUtility.Label("CP_UserUpgradeTombEffect", 0)]
        [FastEnumUtility.Label("User Upgrade Tomb Effect", 1)]
        UserUpgradeTombEffect = 58,
        [FastEnumUtility.Label("CP_UserHP", 0)]
        [FastEnumUtility.Label("User HP", 1)]
        UserHP = 59,
        [FastEnumUtility.Label("CP_Premium", 0)]
        Premium = 60,
        [FastEnumUtility.Label("CP_UserBanMapByMob", 0)]
        [FastEnumUtility.Label("User Ban Map By Mob", 1)]
        UserBanMapByMob = 61,
        [FastEnumUtility.Label("CP_UserMonsterBookSetCover", 0)]
        [FastEnumUtility.Label("User Monster Book Set Cover", 1)]
        UserMonsterBookSetCover = 62,
        [FastEnumUtility.Label("CP_UserSelectNpc", 0)]
        [FastEnumUtility.Label("User Select Npc", 1)]
        UserSelectNpc = 63,
        [FastEnumUtility.Label("CP_UserRemoteShopOpenRequest", 0)]
        [FastEnumUtility.Label("User Remote Shop Open Request", 1)]
        UserRemoteShopOpenRequest = 64,
        [FastEnumUtility.Label("CP_UserScriptMessageAnswer", 0)]
        [FastEnumUtility.Label("User Script Message Answer", 1)]
        UserScriptMessageAnswer = 65,
        [FastEnumUtility.Label("CP_UserShopRequest", 0)]
        [FastEnumUtility.Label("User Shop Request", 1)]
        UserShopRequest = 66,
        [FastEnumUtility.Label("CP_UserTrunkRequest", 0)]
        [FastEnumUtility.Label("User Trunk Request", 1)]
        UserTrunkRequest = 67,
        [FastEnumUtility.Label("CP_UserEntrustedShopRequest", 0)]
        [FastEnumUtility.Label("User Entrusted Shop Request", 1)]
        UserEntrustedShopRequest = 68,
        [FastEnumUtility.Label("CP_UserStoreBankRequest", 0)]
        [FastEnumUtility.Label("User Store Bank Request", 1)]
        UserStoreBankRequest = 69,
        [FastEnumUtility.Label("CP_UserParcelRequest", 0)]
        [FastEnumUtility.Label("User Parcel Request", 1)]
        UserParcelRequest = 70,
        [FastEnumUtility.Label("CP_UserEffectLocal", 0)]
        [FastEnumUtility.Label("User Effect Local", 1)]
        UserEffectLocal = 71,
        [FastEnumUtility.Label("CP_ShopScannerRequest", 0)]
        [FastEnumUtility.Label("Shop Scanner Request", 1)]
        ShopScannerRequest = 72,
        [FastEnumUtility.Label("CP_ShopLinkRequest", 0)]
        [FastEnumUtility.Label("Shop Link Request", 1)]
        ShopLinkRequest = 73,
        [FastEnumUtility.Label("Admin Shop Request", 1)]
        [FastEnumUtility.Label("CP_AdminShopRequest", 0)]
        AdminShopRequest = 74,
        [FastEnumUtility.Label("CP_UserGatherItemRequest", 0)]
        [FastEnumUtility.Label("User Gather Item Request", 1)]
        UserGatherItemRequest = 75,
        [FastEnumUtility.Label("CP_UserSortItemRequest", 0)]
        [FastEnumUtility.Label("User Sort Item Request", 1)]
        UserSortItemRequest = 76,
        [FastEnumUtility.Label("CP_UserChangeSlotPositionRequest", 0)]
        [FastEnumUtility.Label("User Change Slot Position Request", 1)]
        UserChangeSlotPositionRequest = 77,
        [FastEnumUtility.Label("CP_UserStatChangeItemUseRequest", 0)]
        [FastEnumUtility.Label("User Stat Change Item Use Request", 1)]
        UserStatChangeItemUseRequest = 78,
        [FastEnumUtility.Label("CP_UserStatChangeItemCancelRequest", 0)]
        [FastEnumUtility.Label("User Stat Change Item Cancel Request", 1)]
        UserStatChangeItemCancelRequest = 79,
        [FastEnumUtility.Label("CP_UserStatChangeByPortableChairRequest", 0)]
        [FastEnumUtility.Label("User Stat Change By Portable Chair Request", 1)]
        UserStatChangeByPortableChairRequest = 80,
        [FastEnumUtility.Label("CP_UserMobSummonItemUseRequest", 0)]
        [FastEnumUtility.Label("User Mob Summon Item Use Request", 1)]
        UserMobSummonItemUseRequest = 81,
        [FastEnumUtility.Label("CP_UserPetFoodItemUseRequest", 0)]
        [FastEnumUtility.Label("User Pet Food Item Use Request", 1)]
        UserPetFoodItemUseRequest = 82,
        [FastEnumUtility.Label("CP_UserTamingMobFoodItemUseRequest", 0)]
        [FastEnumUtility.Label("User Taming Mob Food Item Use Request", 1)]
        UserTamingMobFoodItemUseRequest = 83,
        [FastEnumUtility.Label("CP_UserScriptItemUseRequest", 0)]
        [FastEnumUtility.Label("User Script Item Use Request", 1)]
        UserScriptItemUseRequest = 84,
        [FastEnumUtility.Label("CP_UserConsumeCashItemUseRequest", 0)]
        [FastEnumUtility.Label("User Consume Cash Item Use Request", 1)]
        UserConsumeCashItemUseRequest = 85,
        [FastEnumUtility.Label("CP_UserDestroyPetItemRequest", 0)]
        [FastEnumUtility.Label("User Destroy Pet Item Request", 1)]
        UserDestroyPetItemRequest = 86,
        [FastEnumUtility.Label("CP_UserBridleItemUseRequest", 0)]
        [FastEnumUtility.Label("User Bridle Item Use Request", 1)]
        UserBridleItemUseRequest = 87,
        [FastEnumUtility.Label("CP_UserSkillLearnItemUseRequest", 0)]
        [FastEnumUtility.Label("User Skill Learn Item Use Request", 1)]
        UserSkillLearnItemUseRequest = 88,
        [FastEnumUtility.Label("CP_UserSkillResetItemUseRequest", 0)]
        [FastEnumUtility.Label("User Skill Reset Item Use Request", 1)]
        UserSkillResetItemUseRequest = 89,
        [FastEnumUtility.Label("CP_UserShopScannerItemUseRequest", 0)]
        [FastEnumUtility.Label("User Shop Scanner Item Use Request", 1)]
        UserShopScannerItemUseRequest = 90,
        [FastEnumUtility.Label("CP_UserMapTransferItemUseRequest", 0)]
        [FastEnumUtility.Label("User Map Transfer Item Use Request", 1)]
        UserMapTransferItemUseRequest = 91,
        [FastEnumUtility.Label("CP_UserPortalScrollUseRequest", 0)]
        [FastEnumUtility.Label("User Portal Scroll Use Request", 1)]
        UserPortalScrollUseRequest = 92,
        [FastEnumUtility.Label("CP_UserUpgradeItemUseRequest", 0)]
        [FastEnumUtility.Label("User Upgrade Item Use Request", 1)]
        UserUpgradeItemUseRequest = 93,
        [FastEnumUtility.Label("CP_UserHyperUpgradeItemUseRequest", 0)]
        [FastEnumUtility.Label("User Hyper Upgrade Item Use Request", 1)]
        UserHyperUpgradeItemUseRequest = 94,
        [FastEnumUtility.Label("CP_UserItemOptionUpgradeItemUseRequest", 0)]
        [FastEnumUtility.Label("User Item Option Upgrade Item Use Request", 1)]
        UserItemOptionUpgradeItemUseRequest = 95,
        [FastEnumUtility.Label("CP_UserUIOpenItemUseRequest", 0)]
        [FastEnumUtility.Label("User UI Open Item Use Request", 1)]
        UserUIOpenItemUseRequest = 96,
        [FastEnumUtility.Label("CP_UserItemReleaseRequest", 0)]
        [FastEnumUtility.Label("User Item Release Request", 1)]
        UserItemReleaseRequest = 97,
        [FastEnumUtility.Label("CP_UserAbilityUpRequest", 0)]
        [FastEnumUtility.Label("User Ability Up Request", 1)]
        UserAbilityUpRequest = 98,
        [FastEnumUtility.Label("CP_UserAbilityMassUpRequest", 0)]
        [FastEnumUtility.Label("User Ability Mass Up Request", 1)]
        UserAbilityMassUpRequest = 99,
        [FastEnumUtility.Label("CP_UserChangeStatRequest", 0)]
        [FastEnumUtility.Label("User Change Stat Request", 1)]
        UserChangeStatRequest = 100,
        [FastEnumUtility.Label("CP_UserChangeStatRequestByItemOption", 0)]
        [FastEnumUtility.Label("User Change Stat Request By Item Option", 1)]
        UserChangeStatRequestByItemOption = 101,
        [FastEnumUtility.Label("CP_UserSkillUpRequest", 0)]
        [FastEnumUtility.Label("User Skill Up Request", 1)]
        UserSkillUpRequest = 102,
        [FastEnumUtility.Label("CP_UserSkillUseRequest", 0)]
        [FastEnumUtility.Label("User Skill Use Request", 1)]
        UserSkillUseRequest = 103,
        [FastEnumUtility.Label("CP_UserSkillCancelRequest", 0)]
        [FastEnumUtility.Label("User Skill Cancel Request", 1)]
        UserSkillCancelRequest = 104,
        [FastEnumUtility.Label("CP_UserSkillPrepareRequest", 0)]
        [FastEnumUtility.Label("User Skill Prepare Request", 1)]
        UserSkillPrepareRequest = 105,
        [FastEnumUtility.Label("CP_UserDropMoneyRequest", 0)]
        [FastEnumUtility.Label("User Drop Money Request", 1)]
        UserDropMoneyRequest = 106,
        [FastEnumUtility.Label("CP_UserGivePopularityRequest", 0)]
        [FastEnumUtility.Label("User Give Popularity Request", 1)]
        UserGivePopularityRequest = 107,
        [FastEnumUtility.Label("CP_UserPartyRequest", 0)]
        [FastEnumUtility.Label("User Party Request", 1)]
        UserPartyRequest = 108,
        [FastEnumUtility.Label("CP_UserCharacterInfoRequest", 0)]
        [FastEnumUtility.Label("User Character Info Request", 1)]
        UserCharacterInfoRequest = 109,
        [FastEnumUtility.Label("CP_UserActivatePetRequest", 0)]
        [FastEnumUtility.Label("User Activate Pet Request", 1)]
        UserActivatePetRequest = 110,
        [FastEnumUtility.Label("CP_UserTemporaryStatUpdateRequest", 0)]
        [FastEnumUtility.Label("User Temporary Stat Update Request", 1)]
        UserTemporaryStatUpdateRequest = 111,
        [FastEnumUtility.Label("CP_UserPortalScriptRequest", 0)]
        [FastEnumUtility.Label("User Portal Script Request", 1)]
        UserPortalScriptRequest = 112,
        [FastEnumUtility.Label("CP_UserPortalTeleportRequest", 0)]
        [FastEnumUtility.Label("User Portal Teleport Request", 1)]
        UserPortalTeleportRequest = 113,
        [FastEnumUtility.Label("CP_UserMapTransferRequest", 0)]
        [FastEnumUtility.Label("User Map Transfer Request", 1)]
        UserMapTransferRequest = 114,
        [FastEnumUtility.Label("CP_UserAntiMacroItemUseRequest", 0)]
        [FastEnumUtility.Label("User Anti Macro Item Use Request", 1)]
        UserAntiMacroItemUseRequest = 115,
        [FastEnumUtility.Label("CP_UserAntiMacroSkillUseRequest", 0)]
        [FastEnumUtility.Label("User Anti Macro Skill Use Request", 1)]
        UserAntiMacroSkillUseRequest = 116,
        [FastEnumUtility.Label("CP_UserAntiMacroQuestionResult", 0)]
        [FastEnumUtility.Label("User Anti Macro Question Result", 1)]
        UserAntiMacroQuestionResult = 117,
        [FastEnumUtility.Label("CP_UserClaimRequest", 0)]
        [FastEnumUtility.Label("User Claim Request", 1)]
        UserClaimRequest = 118,
        [FastEnumUtility.Label("CP_UserQuestRequest", 0)]
        [FastEnumUtility.Label("User Quest Request", 1)]
        UserQuestRequest = 119,
        [FastEnumUtility.Label("CP_UserCalcDamageStatSetRequest", 0)]
        [FastEnumUtility.Label("User Calc Damage Stat Set Request", 1)]
        UserCalcDamageStatSetRequest = 120,
        [FastEnumUtility.Label("CP_UserThrowGrenade", 0)]
        [FastEnumUtility.Label("User Throw Grenade", 1)]
        UserThrowGrenade = 121,
        [FastEnumUtility.Label("CP_UserMacroSysDataModified", 0)]
        [FastEnumUtility.Label("User Macro Sys Data Modified", 1)]
        UserMacroSysDataModified = 122,
        [FastEnumUtility.Label("CP_UserSelectNpcItemUseRequest", 0)]
        [FastEnumUtility.Label("User Select Npc Item Use Request", 1)]
        UserSelectNpcItemUseRequest = 123,
        [FastEnumUtility.Label("CP_UserLotteryItemUseRequest", 0)]
        [FastEnumUtility.Label("User Lottery Item Use Request", 1)]
        UserLotteryItemUseRequest = 124,
        [FastEnumUtility.Label("CP_UserItemMakeRequest", 0)]
        [FastEnumUtility.Label("User Item Make Request", 1)]
        UserItemMakeRequest = 125,
        [FastEnumUtility.Label("CP_UserSueCharacterRequest", 0)]
        [FastEnumUtility.Label("User Sue Character Request", 1)]
        UserSueCharacterRequest = 126,
        [FastEnumUtility.Label("CP_UserUseGachaponBoxRequest", 0)]
        [FastEnumUtility.Label("User Use Gachapon Box Request", 1)]
        UserUseGachaponBoxRequest = 127,
        [FastEnumUtility.Label("CP_UserUseGachaponRemoteRequest", 0)]
        [FastEnumUtility.Label("User Use Gachapon Remote Request", 1)]
        UserUseGachaponRemoteRequest = 128,
        [FastEnumUtility.Label("CP_UserUseWaterOfLife", 0)]
        [FastEnumUtility.Label("User Use Water Of Life", 1)]
        UserUseWaterOfLife = 129,
        [FastEnumUtility.Label("CP_UserRepairDurabilityAll", 0)]
        [FastEnumUtility.Label("User Repair Durability All", 1)]
        UserRepairDurabilityAll = 130,
        [FastEnumUtility.Label("CP_UserRepairDurability", 0)]
        [FastEnumUtility.Label("User Repair Durability", 1)]
        UserRepairDurability = 131,
        [FastEnumUtility.Label("CP_UserQuestRecordSetState", 0)]
        [FastEnumUtility.Label("User Quest Record Set State", 1)]
        UserQuestRecordSetState = 132,
        [FastEnumUtility.Label("CP_UserClientTimerEndRequest", 0)]
        [FastEnumUtility.Label("User Client Timer End Request", 1)]
        UserClientTimerEndRequest = 133,
        [FastEnumUtility.Label("CP_UserFollowCharacterRequest", 0)]
        [FastEnumUtility.Label("User Follow Character Request", 1)]
        UserFollowCharacterRequest = 134,
        [FastEnumUtility.Label("CP_UserFollowCharacterWithdraw", 0)]
        [FastEnumUtility.Label("User Follow Character Withdraw", 1)]
        UserFollowCharacterWithdraw = 135,
        [FastEnumUtility.Label("CP_UserSelectPQReward", 0)]
        [FastEnumUtility.Label("User Select PQ Reward", 1)]
        UserSelectPQReward = 136,
        [FastEnumUtility.Label("CP_UserRequestPQReward", 0)]
        [FastEnumUtility.Label("User Request PQ Reward", 1)]
        UserRequestPQReward = 137,
        [FastEnumUtility.Label("CP_SetPassenserResult", 0)]
        [FastEnumUtility.Label("Set Passenser Result", 1)]
        SetPassenserResult = 138,
        [FastEnumUtility.Label("Broadcast Msg", 1)]
        [FastEnumUtility.Label("CP_BroadcastMsg", 0)]
        BroadcastMsg = 139,
        [FastEnumUtility.Label("CP_GroupMessage", 0)]
        [FastEnumUtility.Label("Group Message", 1)]
        GroupMessage = 140,
        [FastEnumUtility.Label("CP_Whisper", 0)]
        Whisper = 141,
        [FastEnumUtility.Label("CP_CoupleMessage", 0)]
        [FastEnumUtility.Label("Couple Message", 1)]
        CoupleMessage = 142,
        [FastEnumUtility.Label("CP_Messenger", 0)]
        Messenger = 143,
        [FastEnumUtility.Label("CP_MiniRoom", 0)]
        [FastEnumUtility.Label("Mini Room", 1)]
        MiniRoom = 144,
        [FastEnumUtility.Label("CP_PartyRequest", 0)]
        [FastEnumUtility.Label("Party Request", 1)]
        PartyRequest = 145,
        [FastEnumUtility.Label("CP_PartyResult", 0)]
        [FastEnumUtility.Label("Party Result", 1)]
        PartyResult = 146,
        [FastEnumUtility.Label("CP_ExpeditionRequest", 0)]
        [FastEnumUtility.Label("Expedition Request", 1)]
        ExpeditionRequest = 147,
        [FastEnumUtility.Label("CP_PartyAdverRequest", 0)]
        [FastEnumUtility.Label("Party Adver Request", 1)]
        PartyAdverRequest = 148,
        [FastEnumUtility.Label("CP_GuildRequest", 0)]
        [FastEnumUtility.Label("Guild Request", 1)]
        GuildRequest = 149,
        [FastEnumUtility.Label("CP_GuildResult", 0)]
        [FastEnumUtility.Label("Guild Result", 1)]
        GuildResult = 150,
        [FastEnumUtility.Label("CP_Admin", 0)]
        Admin = 151,
        [FastEnumUtility.Label("CP_Log", 0)]
        Log = 152,
        [FastEnumUtility.Label("CP_FriendRequest", 0)]
        [FastEnumUtility.Label("Friend Request", 1)]
        FriendRequest = 153,
        [FastEnumUtility.Label("CP_MemoRequest", 0)]
        [FastEnumUtility.Label("Memo Request", 1)]
        MemoRequest = 154,
        [FastEnumUtility.Label("CP_MemoFlagRequest", 0)]
        [FastEnumUtility.Label("Memo Flag Request", 1)]
        MemoFlagRequest = 155,
        [FastEnumUtility.Label("CP_EnterTownPortalRequest", 0)]
        [FastEnumUtility.Label("Enter Town Portal Request", 1)]
        EnterTownPortalRequest = 156,
        [FastEnumUtility.Label("CP_EnterOpenGateRequest", 0)]
        [FastEnumUtility.Label("Enter Open Gate Request", 1)]
        EnterOpenGateRequest = 157,
        [FastEnumUtility.Label("CP_SlideRequest", 0)]
        [FastEnumUtility.Label("Slide Request", 1)]
        SlideRequest = 158,
        [FastEnumUtility.Label("CP_FuncKeyMappedModified", 0)]
        [FastEnumUtility.Label("Func Key Mapped Modified", 1)]
        FuncKeyMappedModified = 159,
        [FastEnumUtility.Label("CP_RPSGame", 0)]
        [FastEnumUtility.Label("RPS Game", 1)]
        RPSGame = 160,
        [FastEnumUtility.Label("CP_MarriageRequest", 0)]
        [FastEnumUtility.Label("Marriage Request", 1)]
        MarriageRequest = 161,
        [FastEnumUtility.Label("CP_WeddingWishListRequest", 0)]
        [FastEnumUtility.Label("Wedding Wish List Request", 1)]
        WeddingWishListRequest = 162,
        [FastEnumUtility.Label("CP_WeddingProgress", 0)]
        [FastEnumUtility.Label("Wedding Progress", 1)]
        WeddingProgress = 163,
        [FastEnumUtility.Label("CP_GuestBless", 0)]
        [FastEnumUtility.Label("Guest Bless", 1)]
        GuestBless = 164,
        [FastEnumUtility.Label("Booby Trap Alert", 1)]
        [FastEnumUtility.Label("CP_BoobyTrapAlert", 0)]
        BoobyTrapAlert = 165,
        [FastEnumUtility.Label("CP_StalkBegin", 0)]
        [FastEnumUtility.Label("Stalk Begin", 1)]
        StalkBegin = 166,
        [FastEnumUtility.Label("Alliance Request", 1)]
        [FastEnumUtility.Label("CP_AllianceRequest", 0)]
        AllianceRequest = 167,
        [FastEnumUtility.Label("Alliance Result", 1)]
        [FastEnumUtility.Label("CP_AllianceResult", 0)]
        AllianceResult = 168,
        [FastEnumUtility.Label("CP_FamilyChartRequest", 0)]
        [FastEnumUtility.Label("Family Chart Request", 1)]
        FamilyChartRequest = 169,
        [FastEnumUtility.Label("CP_FamilyInfoRequest", 0)]
        [FastEnumUtility.Label("Family Info Request", 1)]
        FamilyInfoRequest = 170,
        [FastEnumUtility.Label("CP_FamilyRegisterJunior", 0)]
        [FastEnumUtility.Label("Family Register Junior", 1)]
        FamilyRegisterJunior = 171,
        [FastEnumUtility.Label("CP_FamilyUnregisterJunior", 0)]
        [FastEnumUtility.Label("Family Unregister Junior", 1)]
        FamilyUnregisterJunior = 172,
        [FastEnumUtility.Label("CP_FamilyUnregisterParent", 0)]
        [FastEnumUtility.Label("Family Unregister Parent", 1)]
        FamilyUnregisterParent = 173,
        [FastEnumUtility.Label("CP_FamilyJoinResult", 0)]
        [FastEnumUtility.Label("Family Join Result", 1)]
        FamilyJoinResult = 174,
        [FastEnumUtility.Label("CP_FamilyUsePrivilege", 0)]
        [FastEnumUtility.Label("Family Use Privilege", 1)]
        FamilyUsePrivilege = 175,
        [FastEnumUtility.Label("CP_FamilySetPrecept", 0)]
        [FastEnumUtility.Label("Family Set Precept", 1)]
        FamilySetPrecept = 176,
        [FastEnumUtility.Label("CP_FamilySummonResult", 0)]
        [FastEnumUtility.Label("Family Summon Result", 1)]
        FamilySummonResult = 177,
        [FastEnumUtility.Label("CP_ChatBlockUserReq", 0)]
        [FastEnumUtility.Label("Chat Block User Req", 1)]
        ChatBlockUserReq = 178,
        [FastEnumUtility.Label("CP_GuildBBS", 0)]
        [FastEnumUtility.Label("Guild BBS", 1)]
        GuildBBS = 179,
        [FastEnumUtility.Label("CP_UserMigrateToITCRequest", 0)]
        [FastEnumUtility.Label("User Migrate To ITC Request", 1)]
        UserMigrateToITCRequest = 180,
        [FastEnumUtility.Label("CP_UserExpUpItemUseRequest", 0)]
        [FastEnumUtility.Label("User Exp Up Item Use Request", 1)]
        UserExpUpItemUseRequest = 181,
        [FastEnumUtility.Label("CP_UserTempExpUseRequest", 0)]
        [FastEnumUtility.Label("User Temp Exp Use Request", 1)]
        UserTempExpUseRequest = 182,
        [FastEnumUtility.Label("CP_NewYearCardRequest", 0)]
        [FastEnumUtility.Label("New Year Card Request", 1)]
        NewYearCardRequest = 183,
        [FastEnumUtility.Label("CP_RandomMorphRequest", 0)]
        [FastEnumUtility.Label("Random Morph Request", 1)]
        RandomMorphRequest = 184,
        [FastEnumUtility.Label("CP_CashItemGachaponRequest", 0)]
        [FastEnumUtility.Label("Cash Item Gachapon Request", 1)]
        CashItemGachaponRequest = 185,
        [FastEnumUtility.Label("CP_CashGachaponOpenRequest", 0)]
        [FastEnumUtility.Label("Cash Gachapon Open Request", 1)]
        CashGachaponOpenRequest = 186,
        [FastEnumUtility.Label("CP_ChangeMaplePointRequest", 0)]
        [FastEnumUtility.Label("Change Maple Point Request", 1)]
        ChangeMaplePointRequest = 187,
        [FastEnumUtility.Label("CP_TalkToTutor", 0)]
        [FastEnumUtility.Label("Talk To Tutor", 1)]
        TalkToTutor = 188,
        [FastEnumUtility.Label("CP_RequestIncCombo", 0)]
        [FastEnumUtility.Label("Request Inc Combo", 1)]
        RequestIncCombo = 189,
        [FastEnumUtility.Label("CP_MobCrcKeyChangedReply", 0)]
        [FastEnumUtility.Label("Mob Crc Key Changed Reply", 1)]
        MobCrcKeyChangedReply = 190,
        [FastEnumUtility.Label("CP_RequestSessionValue", 0)]
        [FastEnumUtility.Label("Request Session Value", 1)]
        RequestSessionValue = 191,
        [FastEnumUtility.Label("CP_UpdateGMBoard", 0)]
        [FastEnumUtility.Label("Update GM Board", 1)]
        UpdateGMBoard = 192,
        [FastEnumUtility.Label("Account More Info", 1)]
        [FastEnumUtility.Label("CP_AccountMoreInfo", 0)]
        AccountMoreInfo = 193,
        [FastEnumUtility.Label("CP_FindFriend", 0)]
        [FastEnumUtility.Label("Find Friend", 1)]
        FindFriend = 194,
        [FastEnumUtility.Label("Accept APSP Event", 1)]
        [FastEnumUtility.Label("CP_AcceptAPSPEvent", 0)]
        AcceptAPSPEvent = 195,
        [FastEnumUtility.Label("CP_UserDragonBallBoxRequest", 0)]
        [FastEnumUtility.Label("User Dragon Ball Box Request", 1)]
        UserDragonBallBoxRequest = 196,
        [FastEnumUtility.Label("CP_UserDragonBallSummonRequest", 0)]
        [FastEnumUtility.Label("User Dragon Ball Summon Request", 1)]
        UserDragonBallSummonRequest = 197,
        [FastEnumUtility.Label("CP_PetMove", 0)]
        [FastEnumUtility.Label("Pet Move", 1)]
        PetMove = 199,
        [FastEnumUtility.Label("CP_PetAction", 0)]
        [FastEnumUtility.Label("Pet Action", 1)]
        PetAction = 200,
        [FastEnumUtility.Label("CP_PetInteractionRequest", 0)]
        [FastEnumUtility.Label("Pet Interaction Request", 1)]
        PetInteractionRequest = 201,
        [FastEnumUtility.Label("CP_PetDropPickUpRequest", 0)]
        [FastEnumUtility.Label("Pet Drop Pick Up Request", 1)]
        PetDropPickUpRequest = 202,
        [FastEnumUtility.Label("CP_PetStatChangeItemUseRequest", 0)]
        [FastEnumUtility.Label("Pet Stat Change Item Use Request", 1)]
        PetStatChangeItemUseRequest = 203,
        [FastEnumUtility.Label("CP_PetUpdateExceptionListRequest", 0)]
        [FastEnumUtility.Label("Pet Update Exception List Request", 1)]
        PetUpdateExceptionListRequest = 204,
        [FastEnumUtility.Label("CP_SummonedMove", 0)]
        [FastEnumUtility.Label("Summoned Move", 1)]
        SummonedMove = 207,
        [FastEnumUtility.Label("CP_SummonedAttack", 0)]
        [FastEnumUtility.Label("Summoned Attack", 1)]
        SummonedAttack = 208,
        [FastEnumUtility.Label("CP_SummonedHit", 0)]
        [FastEnumUtility.Label("Summoned Hit", 1)]
        SummonedHit = 209,
        [FastEnumUtility.Label("CP_SummonedSkill", 0)]
        [FastEnumUtility.Label("Summoned Skill", 1)]
        SummonedSkill = 210,
        [FastEnumUtility.Label("CP_Remove", 0)]
        Remove = 211,
        [FastEnumUtility.Label("CP_DragonMove", 0)]
        [FastEnumUtility.Label("Dragon Move", 1)]
        DragonMove = 214,
        [FastEnumUtility.Label("CP_QuickslotKeyMappedModified", 0)]
        [FastEnumUtility.Label("Quickslot Key Mapped Modified", 1)]
        QuickslotKeyMappedModified = 216,
        [FastEnumUtility.Label("CP_PassiveskillInfoUpdate", 0)]
        [FastEnumUtility.Label("Passiveskill Info Update", 1)]
        PassiveskillInfoUpdate = 217,
        [FastEnumUtility.Label("CP_UpdateScreenSetting", 0)]
        [FastEnumUtility.Label("Update Screen Setting", 1)]
        UpdateScreenSetting = 218,
        [FastEnumUtility.Label("CP_UserAttackUser_Specific", 0)]
        UserAttackUser_Specific = 219,
        [FastEnumUtility.Label("CP_UserPamsSongUseRequest", 0)]
        [FastEnumUtility.Label("User Pams Song Use Request", 1)]
        UserPamsSongUseRequest = 220,
        [FastEnumUtility.Label("CP_QuestGuideRequest", 0)]
        [FastEnumUtility.Label("Quest Guide Request", 1)]
        QuestGuideRequest = 221,
        [FastEnumUtility.Label("CP_UserRepeatEffectRemove", 0)]
        [FastEnumUtility.Label("User Repeat Effect Remove", 1)]
        UserRepeatEffectRemove = 222,
        [FastEnumUtility.Label("CP_MobMove", 0)]
        [FastEnumUtility.Label("Mob Move", 1)]
        MobMove = 227,
        [FastEnumUtility.Label("CP_MobApplyCtrl", 0)]
        [FastEnumUtility.Label("Mob Apply Ctrl", 1)]
        MobApplyCtrl = 228,
        [FastEnumUtility.Label("CP_MobDropPickUpRequest", 0)]
        [FastEnumUtility.Label("Mob Drop Pick Up Request", 1)]
        MobDropPickUpRequest = 229,
        [FastEnumUtility.Label("CP_MobHitByObstacle", 0)]
        [FastEnumUtility.Label("Mob Hit By Obstacle", 1)]
        MobHitByObstacle = 230,
        [FastEnumUtility.Label("CP_MobHitByMob", 0)]
        [FastEnumUtility.Label("Mob Hit By Mob", 1)]
        MobHitByMob = 231,
        [FastEnumUtility.Label("CP_MobSelfDestruct", 0)]
        [FastEnumUtility.Label("Mob Self Destruct", 1)]
        MobSelfDestruct = 232,
        [FastEnumUtility.Label("CP_MobAttackMob", 0)]
        [FastEnumUtility.Label("Mob Attack Mob", 1)]
        MobAttackMob = 233,
        [FastEnumUtility.Label("CP_MobSkillDelayEnd", 0)]
        [FastEnumUtility.Label("Mob Skill Delay End", 1)]
        MobSkillDelayEnd = 234,
        [FastEnumUtility.Label("CP_MobTimeBombEnd", 0)]
        [FastEnumUtility.Label("Mob Time Bomb End", 1)]
        MobTimeBombEnd = 235,
        [FastEnumUtility.Label("CP_MobEscortCollision", 0)]
        [FastEnumUtility.Label("Mob Escort Collision", 1)]
        MobEscortCollision = 236,
        [FastEnumUtility.Label("CP_MobRequestEscortInfo", 0)]
        [FastEnumUtility.Label("Mob Request Escort Info", 1)]
        MobRequestEscortInfo = 237,
        [FastEnumUtility.Label("CP_MobEscortStopEndRequest", 0)]
        [FastEnumUtility.Label("Mob Escort Stop End Request", 1)]
        MobEscortStopEndRequest = 238,
        [FastEnumUtility.Label("CP_NpcMove", 0)]
        [FastEnumUtility.Label("Npc Move", 1)]
        NpcMove = 241,
        [FastEnumUtility.Label("CP_NpcSpecialAction", 0)]
        [FastEnumUtility.Label("Npc Special Action", 1)]
        NpcSpecialAction = 242,
        [FastEnumUtility.Label("CP_DropPickUpRequest", 0)]
        [FastEnumUtility.Label("Drop Pick Up Request", 1)]
        DropPickUpRequest = 246,
        [FastEnumUtility.Label("CP_ReactorHit", 0)]
        [FastEnumUtility.Label("Reactor Hit", 1)]
        ReactorHit = 249,
        [FastEnumUtility.Label("CP_ReactorTouch", 0)]
        [FastEnumUtility.Label("Reactor Touch", 1)]
        ReactorTouch = 250,
        [FastEnumUtility.Label("CP_RequireFieldObstacleStatus", 0)]
        [FastEnumUtility.Label("Require Field Obstacle Status", 1)]
        RequireFieldObstacleStatus = 251,
        [FastEnumUtility.Label("CP_EventStart", 0)]
        [FastEnumUtility.Label("Event Start", 1)]
        EventStart = 254,
        [FastEnumUtility.Label("CP_SnowBallHit", 0)]
        [FastEnumUtility.Label("Snow Ball Hit", 1)]
        SnowBallHit = 255,
        [FastEnumUtility.Label("CP_SnowBallTouch", 0)]
        [FastEnumUtility.Label("Snow Ball Touch", 1)]
        SnowBallTouch = 256,
        [FastEnumUtility.Label("CP_CoconutHit", 0)]
        [FastEnumUtility.Label("Coconut Hit", 1)]
        CoconutHit = 257,
        [FastEnumUtility.Label("CP_TournamentMatchTable", 0)]
        [FastEnumUtility.Label("Tournament Match Table", 1)]
        TournamentMatchTable = 258,
        [FastEnumUtility.Label("CP_PulleyHit", 0)]
        [FastEnumUtility.Label("Pulley Hit", 1)]
        PulleyHit = 259,
        [FastEnumUtility.Label("CP_MCarnivalRequest", 0)]
        [FastEnumUtility.Label("MCarnival Request", 1)]
        MCarnivalRequest = 262,
        [FastEnumUtility.Label("CP_CONTISTATE", 0)]
        CONTISTATE = 264,
        [FastEnumUtility.Label("CP_INVITE_PARTY_MATCH", 0)]
        INVITE_PARTY_MATCH = 266,
        [FastEnumUtility.Label("CP_CANCEL_INVITE_PARTY_MATCH", 0)]
        CANCEL_INVITE_PARTY_MATCH = 267,
        [FastEnumUtility.Label("CP_RequestFootHoldInfo", 0)]
        [FastEnumUtility.Label("Request Foot Hold Info", 1)]
        RequestFootHoldInfo = 269,
        [FastEnumUtility.Label("CP_FootHoldInfo", 0)]
        [FastEnumUtility.Label("Foot Hold Info", 1)]
        FootHoldInfo = 270,
        [FastEnumUtility.Label("CP_CashShopChargeParamRequest", 0)]
        [FastEnumUtility.Label("Cash Shop Charge Param Request", 1)]
        CashShopChargeParamRequest = 273,
        [FastEnumUtility.Label("CP_CashShopQueryCashRequest", 0)]
        [FastEnumUtility.Label("Cash Shop Query Cash Request", 1)]
        CashShopQueryCashRequest = 274,
        [FastEnumUtility.Label("CP_CashShopCashItemRequest", 0)]
        [FastEnumUtility.Label("Cash Shop Cash Item Request", 1)]
        CashShopCashItemRequest = 275,
        [FastEnumUtility.Label("CP_CashShopCheckCouponRequest", 0)]
        [FastEnumUtility.Label("Cash Shop Check Coupon Request", 1)]
        CashShopCheckCouponRequest = 276,
        [FastEnumUtility.Label("CP_CashShopGiftMateInfoRequest", 0)]
        [FastEnumUtility.Label("Cash Shop Gift Mate Info Request", 1)]
        CashShopGiftMateInfoRequest = 277,
        [FastEnumUtility.Label("CP_CheckSSN2OnCreateNewCharacter", 0)]
        [FastEnumUtility.Label("Check SSN2On Create New Character", 1)]
        CheckSSN2OnCreateNewCharacter = 279,
        [FastEnumUtility.Label("CP_CheckSPWOnCreateNewCharacter", 0)]
        [FastEnumUtility.Label("Check SPW On Create New Character", 1)]
        CheckSPWOnCreateNewCharacter = 280,
        [FastEnumUtility.Label("CP_FirstSSNOnCreateNewCharacter", 0)]
        [FastEnumUtility.Label("First SSN On Create New Character", 1)]
        FirstSSNOnCreateNewCharacter = 281,
        [FastEnumUtility.Label("CP_RaiseRefesh", 0)]
        [FastEnumUtility.Label("Raise Refesh", 1)]
        RaiseRefesh = 283,
        [FastEnumUtility.Label("CP_RaiseUIState", 0)]
        [FastEnumUtility.Label("Raise UI State", 1)]
        RaiseUIState = 284,
        [FastEnumUtility.Label("CP_RaiseIncExp", 0)]
        [FastEnumUtility.Label("Raise Inc Exp", 1)]
        RaiseIncExp = 285,
        [FastEnumUtility.Label("CP_RaiseAddPiece", 0)]
        [FastEnumUtility.Label("Raise Add Piece", 1)]
        RaiseAddPiece = 286,
        [FastEnumUtility.Label("CP_SendMateMail", 0)]
        [FastEnumUtility.Label("Send Mate Mail", 1)]
        SendMateMail = 288,
        [FastEnumUtility.Label("CP_RequestGuildBoardAuthKey", 0)]
        [FastEnumUtility.Label("Request Guild Board Auth Key", 1)]
        RequestGuildBoardAuthKey = 289,
        [FastEnumUtility.Label("CP_RequestConsultAuthKey", 0)]
        [FastEnumUtility.Label("Request Consult Auth Key", 1)]
        RequestConsultAuthKey = 290,
        [FastEnumUtility.Label("CP_RequestClassCompetitionAuthKey", 0)]
        [FastEnumUtility.Label("Request Class Competition Auth Key", 1)]
        RequestClassCompetitionAuthKey = 291,
        [FastEnumUtility.Label("CP_RequestWebBoardAuthKey", 0)]
        [FastEnumUtility.Label("Request Web Board Auth Key", 1)]
        RequestWebBoardAuthKey = 292,
        [FastEnumUtility.Label("CP_GoldHammerRequest", 0)]
        [FastEnumUtility.Label("Gold Hammer Request", 1)]
        GoldHammerRequest = 294,
        [FastEnumUtility.Label("CP_GoldHammerComplete", 0)]
        [FastEnumUtility.Label("Gold Hammer Complete", 1)]
        GoldHammerComplete = 295,
        [FastEnumUtility.Label("CP_ItemUpgradeComplete", 0)]
        [FastEnumUtility.Label("Item Upgrade Complete", 1)]
        ItemUpgradeComplete = 296,
        [FastEnumUtility.Label("CP_BATTLERECORD_ONOFF_REQUEST", 0)]
        BATTLERECORD_ONOFF_REQUEST = 299,
        [FastEnumUtility.Label("CP_MapleTVSendMessageRequest", 0)]
        [FastEnumUtility.Label("Maple TV Send Message Request", 1)]
        MapleTVSendMessageRequest = 302,
        [FastEnumUtility.Label("CP_MapleTVUpdateViewCount", 0)]
        [FastEnumUtility.Label("Maple TV Update View Count", 1)]
        MapleTVUpdateViewCount = 303,
        [FastEnumUtility.Label("CP_ITCChargeParamRequest", 0)]
        [FastEnumUtility.Label("ITC Charge Param Request", 1)]
        ITCChargeParamRequest = 306,
        [FastEnumUtility.Label("CP_ITCQueryCashRequest", 0)]
        [FastEnumUtility.Label("ITC Query Cash Request", 1)]
        ITCQueryCashRequest = 307,
        [FastEnumUtility.Label("CP_ITCItemRequest", 0)]
        [FastEnumUtility.Label("ITC Item Request", 1)]
        ITCItemRequest = 308,
        [FastEnumUtility.Label("CP_CheckDuplicatedIDInCS", 0)]
        [FastEnumUtility.Label("Check Duplicated ID In CS", 1)]
        CheckDuplicatedIDInCS = 311,
        [FastEnumUtility.Label("CP_LogoutGiftSelect", 0)]
        [FastEnumUtility.Label("Logout Gift Select", 1)]
        LogoutGiftSelect = 313,
        [FastEnumUtility.Label("CP_NO", 0)]
        NO = 314,
    }
    public enum ColorTone : byte
    {
        [FastEnumUtility.Label("NO_TRANSFER", 0)]
        [FastEnumUtility.Label("No Transfer", 1)]
        NoTransfer = 0,
        [FastEnumUtility.Label("RED_TONE", 0)]
        [FastEnumUtility.Label("Red Tone", 1)]
        RedTone = 1,
        [FastEnumUtility.Label("BLUE_TONE", 0)]
        [FastEnumUtility.Label("Blue Tone", 1)]
        BlueTone = 2,
        [FastEnumUtility.Label("TEST_TONE", 0)]
        [FastEnumUtility.Label("Test Tone", 1)]
        TestTone = 3,
        [FastEnumUtility.Label("TONE_NO", 0)]
        [FastEnumUtility.Label("Tone No", 1)]
        ToneNo = 4,
    }
    [System.Flags]
    public enum CommodityModifyFlag : uint
    {
        None = 0u,
        [FastEnumUtility.Label("CM_ITEMID", 0)]
        [FastEnumUtility.Label("Item Id", 1)]
        ItemId = 1u,
        [FastEnumUtility.Label("CM_COUNT", 0)]
        Count = 2u,
        [FastEnumUtility.Label("CM_PRICE", 0)]
        Price = 4u,
        [FastEnumUtility.Label("CM_BONUS", 0)]
        Bonus = 8u,
        [FastEnumUtility.Label("CM_PRIORITY", 0)]
        Priority = 16u,
        [FastEnumUtility.Label("CM_PERIOD", 0)]
        Period = 32u,
        [FastEnumUtility.Label("CM_MAPLEPOINT", 0)]
        [FastEnumUtility.Label("Maple Point", 1)]
        MaplePoint = 64u,
        [FastEnumUtility.Label("CM_MESO", 0)]
        Meso = 128u,
        [FastEnumUtility.Label("CM_FORPREMIUMUSER", 0)]
        [FastEnumUtility.Label("For Premium User", 1)]
        ForPremiumUser = 256u,
        [FastEnumUtility.Label("CM_COMMODITYGENDER", 0)]
        [FastEnumUtility.Label("Commodity Gender", 1)]
        CommodityGender = 512u,
        [FastEnumUtility.Label("CM_ONSALE", 0)]
        [FastEnumUtility.Label("On Sale", 1)]
        OnSale = 1024u,
        [FastEnumUtility.Label("CM_CLASS", 0)]
        Class = 2048u,
        [FastEnumUtility.Label("CM_LIMIT", 0)]
        Limit = 4096u,
        [FastEnumUtility.Label("CM_PBCASH", 0)]
        [FastEnumUtility.Label("Pb Cash", 1)]
        PbCash = 8192u,
        [FastEnumUtility.Label("CM_PBPOINT", 0)]
        [FastEnumUtility.Label("Pb Point", 1)]
        PbPoint = 16384u,
        [FastEnumUtility.Label("CM_PBGIFT", 0)]
        [FastEnumUtility.Label("Pb Gift", 1)]
        PbGift = 32768u,
        [FastEnumUtility.Label("CM_PACKAGESN", 0)]
        [FastEnumUtility.Label("Package Sn", 1)]
        PackageSn = 65536u,
        [FastEnumUtility.Label("CM_REQPOP", 0)]
        [FastEnumUtility.Label("Req Pop", 1)]
        ReqPop = 131072u,
        [FastEnumUtility.Label("CM_REQLEV", 0)]
        [FastEnumUtility.Label("Req Lev", 1)]
        ReqLev = 262144u,
        [FastEnumUtility.Label("CM_ALL", 0)]
        All = 524287u,
    }
    public enum ContiMoveState : byte
    {
        Dormant = 0,
        Wait = 1,
        Move = 3,
        [FastEnumUtility.Label("Mob Spawn", 1)]
        Event = 4,
    }
    public enum ContiMoveStateTrigger : byte
    {
        Board = 1,
        Start = 2,
        [FastEnumUtility.Label("Mob Gen", 1)]
        MobGen = 4,
        [FastEnumUtility.Label("Mob Destroy", 1)]
        MobDestroy = 5,
        End = 6,
    }
    public enum ContiMoveTarget : byte
    {
        [FastEnumUtility.Label("Start Field", 1)]
        StartField = 7,
        [FastEnumUtility.Label("Start Ship Move Field", 1)]
        StartShipMoveField = 8,
        [FastEnumUtility.Label("Wait Field", 1)]
        WaitField = 9,
        [FastEnumUtility.Label("Move Field", 1)]
        MoveField = 10,
        [FastEnumUtility.Label("End Field", 1)]
        EndField = 11,
        [FastEnumUtility.Label("End Ship Move Field", 1)]
        EndShipMoveField = 12,
    }
    public enum ConversationMessageType : byte
    {
        Say = 0,
        [FastEnumUtility.Label("Say Image", 1)]
        SayImage = 1,
        [FastEnumUtility.Label("Ask Yes/No", 1)]
        AskYesNo = 2,
        [FastEnumUtility.Label("Ask Text", 1)]
        AskText = 3,
        [FastEnumUtility.Label("Ask Number", 1)]
        AskNumber = 4,
        [FastEnumUtility.Label("Ask Menu", 1)]
        AskMenu = 5,
        [FastEnumUtility.Label("Ask Quiz", 1)]
        AskQuiz = 6,
        [FastEnumUtility.Label("Ask Speed Quiz", 1)]
        AskSpeedQuiz = 7,
        [FastEnumUtility.Label("Ask Avatar", 1)]
        AskAvatar = 8,
        [FastEnumUtility.Label("Ask Member Shop Avatar", 1)]
        AskMemberShopAvatar = 9,
        [FastEnumUtility.Label("Ask Pet", 1)]
        AskPet = 10,
        [FastEnumUtility.Label("Ask Pet All", 1)]
        AskPetAll = 11,
        Script = 12,
        [FastEnumUtility.Label("Ask Accept", 1)]
        AskAccept = 13,
        [FastEnumUtility.Label("Ask Box Text", 1)]
        AskBoxText = 14,
        [FastEnumUtility.Label("Ask Slide Menu", 1)]
        AskSlideMenu = 15,
        [FastEnumUtility.Label("Ask Center", 1)]
        AskCenter = 16,
    }
    [System.Flags]
    public enum ConversationSpeakerFlags : byte
    {
        None = 0,
        [FastEnumUtility.Label("No ESC", 1)]
        [FastEnumUtility.Label("SMP_NOESC", 0)]
        NoESC = 1,
        [FastEnumUtility.Label("NPC Replaced By User", 1)]
        [FastEnumUtility.Label("SMP_NPC_REPLACED_BY_USER", 0)]
        NPCReplacedByUser = 2,
        [FastEnumUtility.Label("NPC Replaced By NPC", 1)]
        [FastEnumUtility.Label("SMP_NPC_REPLACED_BY_NPC", 0)]
        NPCReplacedByNPC = 4,
        [FastEnumUtility.Label("Flip Image", 1)]
        [FastEnumUtility.Label("SMP_FLIPIMAGE", 0)]
        FlipImage = 8,
    }
    public enum CoupleEffectType : byte
    {
        [FastEnumUtility.Label("COUPLE_EFFECT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("COUPLE_EFFECT_PRIVATE", 0)]
        Private = 1,
        [FastEnumUtility.Label("COUPLE_EFFECT_COMMON", 0)]
        Common = 2,
    }
    public enum CursorState : byte
    {
        [FastEnumUtility.Label("CURSOR_STATE_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("CURSOR_STATE_ONNPC", 0)]
        [FastEnumUtility.Label("On Npc", 1)]
        OnNpc = 1,
        [FastEnumUtility.Label("CURSOR_STATE_ONGAMEBALOON", 0)]
        [FastEnumUtility.Label("On Game Balloon", 1)]
        OnGameBalloon = 2,
        [FastEnumUtility.Label("CURSOR_STATE_ONMINIROOMBALOON", 0)]
        [FastEnumUtility.Label("On Mini Room Balloon", 1)]
        OnMiniRoomBalloon = 3,
        [FastEnumUtility.Label("CURSOR_STATE_ONBUTTON", 0)]
        [FastEnumUtility.Label("On Button", 1)]
        OnButton = 4,
        [FastEnumUtility.Label("CURSOR_STATE_DRAGGABLE", 0)]
        Draggable = 5,
        [FastEnumUtility.Label("CURSOR_STATE_ONBTCASHSHOP", 0)]
        [FastEnumUtility.Label("On Cash Shop Button", 1)]
        OnCashShopButton = 6,
        [FastEnumUtility.Label("CURSOR_STATE_VERTICALSCROLLABLE", 0)]
        [FastEnumUtility.Label("Vertical Scrollable", 1)]
        VerticalScrollable = 7,
        [FastEnumUtility.Label("CURSOR_STATE_HORIZONTALSCROLLABLE", 0)]
        [FastEnumUtility.Label("Horizontal Scrollable", 1)]
        HorizontalScrollable = 8,
        [FastEnumUtility.Label("CURSOR_STATE_ONSCROLLVERTICAL", 0)]
        [FastEnumUtility.Label("On Scroll Vertical", 1)]
        OnScrollVertical = 9,
        [FastEnumUtility.Label("CURSOR_STATE_ONSCROLLHORIZONTAL", 0)]
        [FastEnumUtility.Label("On Scroll Horizontal", 1)]
        OnScrollHorizontal = 10,
        [FastEnumUtility.Label("CURSOR_STATE_ONDRAG", 0)]
        [FastEnumUtility.Label("On Drag", 1)]
        OnDrag = 11,
        [FastEnumUtility.Label("CURSOR_STATE_CLICK", 0)]
        Click = 12,
        [FastEnumUtility.Label("CURSOR_STATE_UNKNOWN", 0)]
        Unknown = 13,
        [FastEnumUtility.Label("CURSOR_STATE_MAGNIFYING_NORMAL", 0)]
        [FastEnumUtility.Label("Magnifying Normal", 1)]
        MagnifyingNormal = 14,
        [FastEnumUtility.Label("CURSOR_STATE_MAGNIFYING_CLICK", 0)]
        [FastEnumUtility.Label("Magnifying Click", 1)]
        MagnifyingClick = 15,
        [FastEnumUtility.Label("CURSOR_STATE_MAGNIFYING_DONE", 0)]
        [FastEnumUtility.Label("Magnifying Done", 1)]
        MagnifyingDone = 16,
        [FastEnumUtility.Label("CURSOR_STATE_NO", 0)]
        No = 17,
    }
    public enum DamageInfoType : byte
    {
        [FastEnumUtility.Label("Average Per Hit", 1)]
        [FastEnumUtility.Label("DAMAGEINFO_AVERAGE_PERHIT", 0)]
        AveragePerHit = 0,
        [FastEnumUtility.Label("Average Per Sec", 1)]
        [FastEnumUtility.Label("DAMAGEINFO_AVERAGE_PERSEC", 0)]
        AveragePerSec = 1,
        [FastEnumUtility.Label("DAMAGEINFO_MAX_DAMAGE", 0)]
        [FastEnumUtility.Label("Max Damage", 1)]
        MaxDamage = 2,
        [FastEnumUtility.Label("DAMAGEINFO_MIN_DAMAGE", 0)]
        [FastEnumUtility.Label("Min Damage", 1)]
        MinDamage = 3,
        [FastEnumUtility.Label("DAMAGEINFO_TOTAL_DAMAGE", 0)]
        [FastEnumUtility.Label("Total Damage", 1)]
        TotalDamage = 4,
        [FastEnumUtility.Label("DAMAGEINFO_TOTAL_ATTACK", 0)]
        [FastEnumUtility.Label("Total Attack", 1)]
        TotalAttack = 5,
        [FastEnumUtility.Label("Critical Attack", 1)]
        [FastEnumUtility.Label("DAMAGEINFO_CRITICAL_ATTACK", 0)]
        CriticalAttack = 6,
        [FastEnumUtility.Label("Average Hit", 1)]
        [FastEnumUtility.Label("DAMAGEINFO_AVERAGE_HIT", 0)]
        AverageHit = 7,
        [FastEnumUtility.Label("DAMAGEINFO_TOTAL_TIME", 0)]
        [FastEnumUtility.Label("Total Time", 1)]
        TotalTime = 8,
        [FastEnumUtility.Label("Basic No", 1)]
        [FastEnumUtility.Label("DAMAGEINFO_BAGICNO", 0)]
        BasicNo = 9,
        [FastEnumUtility.Label("DAMAGEINFO_EXTEND_ATTRRATE", 0)]
        [FastEnumUtility.Label("Extend Attr Rate", 1)]
        ExtendAttrRate = 10,
        [FastEnumUtility.Label("DAMAGEINFO_EXTEND_MAXCRITICAL", 0)]
        [FastEnumUtility.Label("Extend Max Critical", 1)]
        ExtendMaxCritical = 11,
        [FastEnumUtility.Label("DAMAGEINFO_EXTEND_MINCRITICAL", 0)]
        [FastEnumUtility.Label("Extend Min Critical", 1)]
        ExtendMinCritical = 12,
        [FastEnumUtility.Label("DAMAGEINFO_EXTEND_MISSHIT", 0)]
        [FastEnumUtility.Label("Extend Miss Hit", 1)]
        ExtendMissHit = 13,
        [FastEnumUtility.Label("DAMAGEINFO_EXTENDNO", 0)]
        [FastEnumUtility.Label("Extend No", 1)]
        ExtendNo = 14,
    }
    public enum DamageUpgradeAttackType : byte
    {
        [FastEnumUtility.Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_ATTACK_ERROR", 0)]
        Error = 0,
        [FastEnumUtility.Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_ATTACK_ABSOLUTE", 0)]
        Absolute = 1,
    }
    public enum DamageUpgradeDefendType : byte
    {
        [FastEnumUtility.Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_DEFEND_ERROR", 0)]
        Error = 0,
        [FastEnumUtility.Label("DAMAGE_MODIFIED_BY_ITEM_UPGRADE_DEFEND_PERCENT", 0)]
        Percent = 1,
    }
    public enum DayByDayType : byte
    {
        [FastEnumUtility.Label("DAYBYDAY_PARTYBONUS", 0)]
        [FastEnumUtility.Label("Party Bonus", 1)]
        PartyBonus = 0,
        [FastEnumUtility.Label("DAYBYDAY_GOODOPTIONITEM", 0)]
        [FastEnumUtility.Label("Good Option Item", 1)]
        GoodOptionItem = 1,
        [FastEnumUtility.Label("DAYBYDAY_QUESTCOMPLETEBONUS", 0)]
        [FastEnumUtility.Label("Quest Complete Bonus", 1)]
        QuestCompleteBonus = 2,
        [FastEnumUtility.Label("DAYBYDAY_POTIONDISCOUNT", 0)]
        [FastEnumUtility.Label("Potion Discount", 1)]
        PotionDiscount = 3,
        [FastEnumUtility.Label("DAYBYDAY_NO", 0)]
        No = 4,
    }
    public enum DragonActionType : byte
    {
        [FastEnumUtility.Label("DRAGONACT_STAND", 0)]
        Stand = 0,
        [FastEnumUtility.Label("DRAGONACT_MOVE", 0)]
        Move = 1,
        [FastEnumUtility.Label("DRAGONACT_SHOOT1", 0)]
        Shoot1 = 2,
        [FastEnumUtility.Label("DRAGONACT_MAGICMISSILE", 0)]
        [FastEnumUtility.Label("Magic Missile", 1)]
        MagicMissile = 3,
        [FastEnumUtility.Label("DRAGONACT_LIGHTING_BOLT", 0)]
        [FastEnumUtility.Label("Lightning Bolt", 1)]
        LightningBolt = 4,
        [FastEnumUtility.Label("DRAGONACT_ICE_BREATHE", 0)]
        [FastEnumUtility.Label("Ice Breathe", 1)]
        IceBreathe = 5,
        [FastEnumUtility.Label("DRAGONACT_BREATHE", 0)]
        Breathe = 6,
        [FastEnumUtility.Label("DRAGONACT_ICE_BREATHE_PREPARE", 0)]
        [FastEnumUtility.Label("Ice Breathe Prepare", 1)]
        IceBreathePrepare = 7,
        [FastEnumUtility.Label("Breathe Prepare", 1)]
        [FastEnumUtility.Label("DRAGONACT_BREATHE_PREPARE", 0)]
        BreathePrepare = 8,
        [FastEnumUtility.Label("DRAGONACT_BLAZE", 0)]
        Blaze = 9,
        [FastEnumUtility.Label("DRAGONACT_FIRE_CIRCLE", 0)]
        [FastEnumUtility.Label("Fire Circle", 1)]
        FireCircle = 10,
        [FastEnumUtility.Label("DRAGONACT_ILLUSION", 0)]
        Illusion = 11,
        [FastEnumUtility.Label("DRAGONACT_MAGICFLARE", 0)]
        [FastEnumUtility.Label("Magic Flare", 1)]
        MagicFlare = 12,
        [FastEnumUtility.Label("DRAGONACT_ELEMENTAL_RESET", 0)]
        [FastEnumUtility.Label("Elemental Reset", 1)]
        ElementalReset = 13,
        [FastEnumUtility.Label("DRAGONACT_MAGIC_REGISTANCE", 0)]
        [FastEnumUtility.Label("Magic Resistance", 1)]
        MagicResistance = 14,
        [FastEnumUtility.Label("DRAGONACT_RECOVERY_AURA", 0)]
        [FastEnumUtility.Label("Recovery Aura", 1)]
        RecoveryAura = 15,
        [FastEnumUtility.Label("DRAGONACT_MAGIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Magic Booster", 1)]
        MagicBooster = 16,
        [FastEnumUtility.Label("DRAGONACT_MAGIC_SHIELD", 0)]
        [FastEnumUtility.Label("Magic Shield", 1)]
        MagicShield = 17,
        [FastEnumUtility.Label("DRAGONACT_FLAME_WHEEL", 0)]
        [FastEnumUtility.Label("Flame Wheel", 1)]
        FlameWheel = 18,
        [FastEnumUtility.Label("DRAGONACT_KILLING_WING", 0)]
        [FastEnumUtility.Label("Killing Wing", 1)]
        KillingWing = 19,
        [FastEnumUtility.Label("DRAGONACT_ONIX_BLESSING", 0)]
        [FastEnumUtility.Label("Onix Blessing", 1)]
        OnixBlessing = 20,
        [FastEnumUtility.Label("DRAGONACT_EARTHQUAKE", 0)]
        Earthquake = 21,
        [FastEnumUtility.Label("DRAGONACT_SOULSTONE", 0)]
        [FastEnumUtility.Label("Soul Stone", 1)]
        SoulStone = 22,
        [FastEnumUtility.Label("DRAGONACT_DRAGONTHRUST", 0)]
        [FastEnumUtility.Label("Dragon Thrust", 1)]
        DragonThrust = 23,
        [FastEnumUtility.Label("DRAGONACT_GHOST_LETTERING", 0)]
        [FastEnumUtility.Label("Ghost Lettering", 1)]
        GhostLettering = 24,
        [FastEnumUtility.Label("DRAGONACT_DARKFOG", 0)]
        [FastEnumUtility.Label("Dark Fog", 1)]
        DarkFog = 25,
        [FastEnumUtility.Label("DRAGONACT_SLOW", 0)]
        Slow = 26,
        [FastEnumUtility.Label("DRAGONACT_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Maple Hero", 1)]
        MapleHero = 27,
        [FastEnumUtility.Label("DRAGONACT_AWAKENING", 0)]
        Awakening = 28,
    }
    public enum DropOwnType : byte
    {
        [FastEnumUtility.Label("User Own", 1)]
        UserOwn = 0,
        [FastEnumUtility.Label("Party Own", 1)]
        PartyOwn = 1,
        [FastEnumUtility.Label("No Own", 1)]
        NoOwn = 2,
        [FastEnumUtility.Label("Explosive No Own", 1)]
        ExplosiveNoOwn = 3,
    }
    public enum DynamicObjectState : byte
    {
        [FastEnumUtility.Label("DYNAMIC_OBJ_STATE_HIDE", 0)]
        Hide = 0,
        [FastEnumUtility.Label("DYNAMIC_OBJ_STATE_SHOW", 0)]
        Show = 1,
        [FastEnumUtility.Label("DYNAMIC_OBJ_STATE_MOVE", 0)]
        Move = 2,
        [FastEnumUtility.Label("DYNAMIC_OBJ_STATE_END", 0)]
        End = 3,
    }
    public enum EffectType : byte
    {
        [FastEnumUtility.Label("Level Up", 1)]
        LevelUp = 0,
        [FastEnumUtility.Label("Skill Use", 1)]
        SkillUse = 1,
        [FastEnumUtility.Label("Skill Affected", 1)]
        SkillAffected = 2,
        [FastEnumUtility.Label("Skill Affected Select", 1)]
        SkillAffectedSelect = 3,
        [FastEnumUtility.Label("Skill Special Affected", 1)]
        SkillSpecialAffected = 4,
        Quest = 5,
        Pet = 6,
        [FastEnumUtility.Label("Skill Special", 1)]
        SkillSpecial = 7,
        [FastEnumUtility.Label("Protect On Die Item Use", 1)]
        ProtectOnDieItemUse = 8,
        [FastEnumUtility.Label("Play Portal SE", 1)]
        PlayPortalSE = 9,
        [FastEnumUtility.Label("Job Changed", 1)]
        JobChanged = 10,
        [FastEnumUtility.Label("Quest Complete", 1)]
        QuestComplete = 11,
        [FastEnumUtility.Label("Inc Dec HP Effect", 1)]
        IncDecHPEffect = 12,
        [FastEnumUtility.Label("Buff Item Effect", 1)]
        BuffItemEffect = 13,
        [FastEnumUtility.Label("Squib Effect", 1)]
        SquibEffect = 14,
        [FastEnumUtility.Label("Monster Book Card Get", 1)]
        MonsterBookCardGet = 15,
        [FastEnumUtility.Label("Lottery Use", 1)]
        LotteryUse = 16,
        [FastEnumUtility.Label("Item Level Up", 1)]
        ItemLevelUp = 17,
        [FastEnumUtility.Label("Item Maker", 1)]
        ItemMaker = 18,
        [FastEnumUtility.Label("Exp Item Consumed", 1)]
        ExpItemConsumed = 19,
        [FastEnumUtility.Label("Reserved Effect", 1)]
        ReservedEffect = 20,
        Buff = 21,
        [FastEnumUtility.Label("Consume Effect", 1)]
        ConsumeEffect = 22,
        [FastEnumUtility.Label("Upgrade Tomb Item Use", 1)]
        UpgradeTombItemUse = 23,
        [FastEnumUtility.Label("Battlefield Item Use", 1)]
        BattlefieldItemUse = 24,
        [FastEnumUtility.Label("Avatar Oriented", 1)]
        AvatarOriented = 25,
        [FastEnumUtility.Label("Incubator Use", 1)]
        IncubatorUse = 26,
        [FastEnumUtility.Label("Play Sound With Mute BGM", 1)]
        PlaySoundWithMuteBGM = 27,
        [FastEnumUtility.Label("Soul Stone Use", 1)]
        SoulStoneUse = 28,
        [FastEnumUtility.Label("Inc Dec HP Effect Ex", 1)]
        IncDecHPEffectEx = 29,
        [FastEnumUtility.Label("Delivery Quest Item Use", 1)]
        DeliveryQuestItemUse = 30,
        [FastEnumUtility.Label("Repeat Effect Remove", 1)]
        RepeatEffectRemove = 31,
        [FastEnumUtility.Label("Evol Ring", 1)]
        EvolRing = 32,
    }
    public enum ElemResistanceTier : byte
    {
        [FastEnumUtility.Label("100%", 2)]
        [FastEnumUtility.Label("ELEMENT_ATTR_NONE", 0)]
        [FastEnumUtility.Label("Normal", 1)]
        None = 0,
        [FastEnumUtility.Label("0%", 2)]
        [FastEnumUtility.Label("ELEMENT_ATTR_DAMAGE0", 0)]
        [FastEnumUtility.Label("Immune", 1)]
        Immune = 1,
        [FastEnumUtility.Label("50%", 2)]
        [FastEnumUtility.Label("ELEMENT_ATTR_DAMAGE50", 0)]
        [FastEnumUtility.Label("Resistant", 1)]
        Resistant = 2,
        [FastEnumUtility.Label("150%", 2)]
        [FastEnumUtility.Label("ELEMENT_ATTR_DAMAGE150", 0)]
        [FastEnumUtility.Label("Weak", 1)]
        Weak = 3,
    }
    public enum Element : byte
    {
        [FastEnumUtility.Label("ELEMENT_PHYSICAL", 0)]
        [FastEnumUtility.Label("P", 2)]
        [FastEnumUtility.Label("\0", 4)]
        [FastEnumUtility.Label("p", 3)]
        Physical = 0,
        [FastEnumUtility.Label("ELEMENT_ICE", 0)]
        [FastEnumUtility.Label("I", 2)]
        [FastEnumUtility.Label("i", 3)]
        Ice = 1,
        [FastEnumUtility.Label("ELEMENT_FIRE", 0)]
        [FastEnumUtility.Label("F", 2)]
        [FastEnumUtility.Label("f", 3)]
        Fire = 2,
        [FastEnumUtility.Label("ELEMENT_LIGHT", 0)]
        [FastEnumUtility.Label("L", 2)]
        [FastEnumUtility.Label("l", 3)]
        Light = 3,
        [FastEnumUtility.Label("ELEMENT_POISON", 0)]
        [FastEnumUtility.Label("S", 2)]
        [FastEnumUtility.Label("s", 3)]
        Poison = 4,
        [FastEnumUtility.Label("ELEMENT_HOLY", 0)]
        [FastEnumUtility.Label("H", 2)]
        [FastEnumUtility.Label("h", 3)]
        Holy = 5,
        [FastEnumUtility.Label("D", 2)]
        [FastEnumUtility.Label("ELEMENT_DARK", 0)]
        [FastEnumUtility.Label("d", 3)]
        Dark = 6,
        [FastEnumUtility.Label("ELEMENT_UNDEAD", 0)]
        [FastEnumUtility.Label("U", 2)]
        [FastEnumUtility.Label("u", 3)]
        Undead = 7,
    }
    public enum EmotionType : byte
    {
        [FastEnumUtility.Label("EMT_BLINK", 0)]
        Blink = 0,
        [FastEnumUtility.Label("EMT_HIT", 0)]
        Hit = 1,
        [FastEnumUtility.Label("EMT_SMILE", 0)]
        Smile = 2,
        [FastEnumUtility.Label("EMT_TROUBLED", 0)]
        Troubled = 3,
        [FastEnumUtility.Label("EMT_CRY", 0)]
        Cry = 4,
        [FastEnumUtility.Label("EMT_ANGRY", 0)]
        Angry = 5,
        [FastEnumUtility.Label("EMT_BEWILDERED", 0)]
        Bewildered = 6,
        [FastEnumUtility.Label("EMT_STUNNED", 0)]
        Stunned = 7,
        [FastEnumUtility.Label("EMT_VOMIT", 0)]
        Vomit = 8,
        [FastEnumUtility.Label("EMT_OOPS", 0)]
        Oops = 9,
        [FastEnumUtility.Label("EMT_CHEERS", 0)]
        Cheers = 10,
        [FastEnumUtility.Label("EMT_CHU", 0)]
        Chu = 11,
        [FastEnumUtility.Label("EMT_WINK", 0)]
        Wink = 12,
        [FastEnumUtility.Label("EMT_PAIN", 0)]
        Pain = 13,
        [FastEnumUtility.Label("EMT_GLITTER", 0)]
        Glitter = 14,
        [FastEnumUtility.Label("EMT_BLAZE", 0)]
        Blaze = 15,
        [FastEnumUtility.Label("EMT_SHINE", 0)]
        Shine = 16,
        [FastEnumUtility.Label("EMT_LOVE", 0)]
        Love = 17,
        [FastEnumUtility.Label("EMT_DESPAIR", 0)]
        Despair = 18,
        [FastEnumUtility.Label("EMT_HUM", 0)]
        Hum = 19,
        [FastEnumUtility.Label("EMT_BOWING", 0)]
        Bowing = 20,
        [FastEnumUtility.Label("EMT_HOT", 0)]
        Hot = 21,
        [FastEnumUtility.Label("EMT_DAM", 0)]
        Dam = 22,
        [FastEnumUtility.Label("EMT_QBLUE", 0)]
        QBlue = 23,
    }
    public enum EnchantScrollCategory : byte
    {
        [FastEnumUtility.Label("ENCHANT_SCROLL_CATEGORY_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("ENCHANT_SCROLL_CATEGORY_NORMAL", 0)]
        Normal = 1,
        [FastEnumUtility.Label("ENCHANT_SCROLL_CATEGORY_VISITOR", 0)]
        Visitor = 2,
    }
    public enum EntrustedShopOperation : byte
    {
        [FastEnumUtility.Label("EntrustedShopReq_CheckOpenPossible", 0)]
        [FastEnumUtility.Label("Req Check Open Possible", 1)]
        ReqCheckOpenPossible = 0,
        [FastEnumUtility.Label("EntrustedShopReq_Create", 0)]
        [FastEnumUtility.Label("Req Create", 1)]
        ReqCreate = 1,
        [FastEnumUtility.Label("EntrustedShopReq_Save", 0)]
        [FastEnumUtility.Label("Req Save", 1)]
        ReqSave = 2,
        [FastEnumUtility.Label("EntrustedShopReq_CloseProcess", 0)]
        [FastEnumUtility.Label("Req Close Process", 1)]
        ReqCloseProcess = 3,
        [FastEnumUtility.Label("EntrustedShopReq_FindShopByEmployerName", 0)]
        [FastEnumUtility.Label("Req Find Shop By Employer Name", 1)]
        ReqFindShopByEmployerName = 4,
        [FastEnumUtility.Label("EntrustedShopReq_CheckIfClosed", 0)]
        [FastEnumUtility.Label("Req Check If Closed", 1)]
        ReqCheckIfClosed = 5,
        [FastEnumUtility.Label("EntrustedShopReq_GetPos", 0)]
        [FastEnumUtility.Label("Req Get Pos", 1)]
        ReqGetPos = 6,
        [FastEnumUtility.Label("EntrustedShopRes_OpenPossible", 0)]
        [FastEnumUtility.Label("Res Open Possible", 1)]
        ResOpenPossible = 7,
        [FastEnumUtility.Label("EntrustedShopRes_OpenImpossible_Using", 0)]
        [FastEnumUtility.Label("Res Open Impossible Using", 1)]
        ResOpenImpossibleUsing = 8,
        [FastEnumUtility.Label("EntrustedShopRes_OpenImpossible_Stored", 0)]
        [FastEnumUtility.Label("Res Open Impossible Stored", 1)]
        ResOpenImpossibleStored = 9,
        [FastEnumUtility.Label("EntrustedShopRes_OpenImpossible_AnotherCharacter", 0)]
        [FastEnumUtility.Label("Res Open Impossible Another Character", 1)]
        ResOpenImpossibleAnotherCharacter = 10,
        [FastEnumUtility.Label("EntrustedShopRes_OpenImpossible_Block", 0)]
        [FastEnumUtility.Label("Res Open Impossible Block", 1)]
        ResOpenImpossibleBlock = 11,
        [FastEnumUtility.Label("EntrustedShopRes_Create_Failed", 0)]
        [FastEnumUtility.Label("Res Create Failed", 1)]
        ResCreateFailed = 12,
        [FastEnumUtility.Label("EntrustedShopReq_SetMiniMapColor", 0)]
        [FastEnumUtility.Label("Req Set Mini Map Color", 1)]
        ReqSetMiniMapColor = 13,
        [FastEnumUtility.Label("EntrustedShopReq_RenameResult", 0)]
        [FastEnumUtility.Label("Req Rename Result", 1)]
        ReqRenameResult = 14,
        [FastEnumUtility.Label("EntrustedShopRes_ItemExistInStoreBank", 0)]
        [FastEnumUtility.Label("Res Item Exist In Store Bank", 1)]
        ResItemExistInStoreBank = 15,
        [FastEnumUtility.Label("EntrustedShopRes_GetPosResult", 0)]
        [FastEnumUtility.Label("Res Get Pos Result", 1)]
        ResGetPosResult = 16,
        [FastEnumUtility.Label("EntrustedShopRes_Enter", 0)]
        [FastEnumUtility.Label("Res Enter", 1)]
        ResEnter = 17,
        [FastEnumUtility.Label("EntrustedShopRes_ServerMsg", 0)]
        [FastEnumUtility.Label("Res Server Msg", 1)]
        ResServerMsg = 18,
        [FastEnumUtility.Label("Store Bank Req Load", 1)]
        [FastEnumUtility.Label("StoreBankReq_Load", 0)]
        StoreBankReqLoad = 19,
        [FastEnumUtility.Label("Store Bank Req Remove", 1)]
        [FastEnumUtility.Label("StoreBankReq_Remove", 0)]
        StoreBankReqRemove = 20,
        [FastEnumUtility.Label("Store Bank Req Check Ssn2", 1)]
        [FastEnumUtility.Label("StoreBankReq_CheckSSN2", 0)]
        StoreBankReqCheckSsn2 = 21,
        [FastEnumUtility.Label("Store Bank Res Load Done", 1)]
        [FastEnumUtility.Label("StoreBankRes_Load_Done", 0)]
        StoreBankResLoadDone = 22,
        [FastEnumUtility.Label("Store Bank Res Load Failed", 1)]
        [FastEnumUtility.Label("StoreBankRes_Load_Failed", 0)]
        StoreBankResLoadFailed = 23,
        [FastEnumUtility.Label("Store Bank Res Block", 1)]
        [FastEnumUtility.Label("StoreBankRes_Block", 0)]
        StoreBankResBlock = 24,
        [FastEnumUtility.Label("Store Bank Res Remove Done", 1)]
        [FastEnumUtility.Label("StoreBankRes_Remove_Done", 0)]
        StoreBankResRemoveDone = 25,
        [FastEnumUtility.Label("Store Bank Req Calculate Fee", 1)]
        [FastEnumUtility.Label("StoreBankReq_CalculateFee", 0)]
        StoreBankReqCalculateFee = 26,
        [FastEnumUtility.Label("Store Bank Req Get All", 1)]
        [FastEnumUtility.Label("StoreBankReq_GetAll", 0)]
        StoreBankReqGetAll = 27,
        [FastEnumUtility.Label("Store Bank Req Exit", 1)]
        [FastEnumUtility.Label("StoreBankReq_Exit", 0)]
        StoreBankReqExit = 28,
        [FastEnumUtility.Label("Store Bank Res Calculate Fee", 1)]
        [FastEnumUtility.Label("StoreBankRes_CalculateFee", 0)]
        StoreBankResCalculateFee = 29,
        [FastEnumUtility.Label("Store Bank Res Get All Done", 1)]
        [FastEnumUtility.Label("StoreBankRes_GetAll_Done", 0)]
        StoreBankResGetAllDone = 30,
        [FastEnumUtility.Label("Store Bank Res Get All Over Price", 1)]
        [FastEnumUtility.Label("StoreBankRes_GetAll_OverPrice", 0)]
        StoreBankResGetAllOverPrice = 31,
        [FastEnumUtility.Label("Store Bank Res Get All Only Item", 1)]
        [FastEnumUtility.Label("StoreBankRes_GetAll_OnlyItem", 0)]
        StoreBankResGetAllOnlyItem = 32,
        [FastEnumUtility.Label("Store Bank Res Get All No Fee", 1)]
        [FastEnumUtility.Label("StoreBankRes_GetAll_NoFee", 0)]
        StoreBankResGetAllNoFee = 33,
        [FastEnumUtility.Label("Store Bank Res Get All No Slot", 1)]
        [FastEnumUtility.Label("StoreBankRes_GetAll_NoSlot", 0)]
        StoreBankResGetAllNoSlot = 34,
        [FastEnumUtility.Label("Store Bank Res Open Store Bank Dlg", 1)]
        [FastEnumUtility.Label("StoreBankRes_OpenStoreBankDlg", 0)]
        StoreBankResOpenStoreBankDlg = 35,
        [FastEnumUtility.Label("Store Bank Res Store Bank Calculate Fee", 1)]
        [FastEnumUtility.Label("StoreBankRes_StoreBankCalculateFee", 0)]
        StoreBankResStoreBankCalculateFee = 36,
        [FastEnumUtility.Label("Store Bank Res Store Bank Load Failed", 1)]
        [FastEnumUtility.Label("StoreBankRes_StoreBankLoadFailed", 0)]
        StoreBankResStoreBankLoadFailed = 37,
        [FastEnumUtility.Label("Store Bank Res Store Bank Block", 1)]
        [FastEnumUtility.Label("StoreBankRes_StoreBankBlock", 0)]
        StoreBankResStoreBankBlock = 38,
    }
    public enum EntrustedShopWithdrawResult : byte
    {
        [FastEnumUtility.Label("ESWithdraw_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("ESWithdraw_OverPrice", 0)]
        [FastEnumUtility.Label("Over Price", 1)]
        OverPrice = 1,
        [FastEnumUtility.Label("ESWithdraw_OnlyItem", 0)]
        [FastEnumUtility.Label("Only Item", 1)]
        OnlyItem = 2,
        [FastEnumUtility.Label("ESWithdraw_NoSlot", 0)]
        [FastEnumUtility.Label("No Slot", 1)]
        NoSlot = 3,
        [FastEnumUtility.Label("ESWithdraw_Unknown", 0)]
        Unknown = 4,
        [FastEnumUtility.Label("ESWithdraw_Nothing", 0)]
        Nothing = 5,
    }
    public static class EnumDisplayExtensions
    {
        public static string GetDisplayLabel<T>(this T value)
            where T :  struct, System.Enum { }
    }
    public enum EquipCategoryType : byte
    {
        [FastEnumUtility.Label("EQUIP_TYPE_CAP", 0)]
        Cap = 0,
        [FastEnumUtility.Label("EQUIP_TYPE_FACEACC", 0)]
        [FastEnumUtility.Label("Face Accessory", 1)]
        FaceAccessory = 1,
        [FastEnumUtility.Label("EQUIP_TYPE_EYEACC", 0)]
        [FastEnumUtility.Label("Eye Accessory", 1)]
        EyeAccessory = 2,
        [FastEnumUtility.Label("EQUIP_TYPE_EARACC", 0)]
        [FastEnumUtility.Label("Ear Accessory", 1)]
        EarAccessory = 3,
        [FastEnumUtility.Label("EQUIP_TYPE_SHIRT", 0)]
        Shirt = 4,
        [FastEnumUtility.Label("EQUIP_TYPE_COAT", 0)]
        Coat = 5,
        [FastEnumUtility.Label("EQUIP_TYPE_PANTS", 0)]
        Pants = 6,
        [FastEnumUtility.Label("EQUIP_TYPE_SHOES", 0)]
        Shoes = 7,
        [FastEnumUtility.Label("EQUIP_TYPE_GLOVES", 0)]
        Gloves = 8,
        [FastEnumUtility.Label("EQUIP_TYPE_SHIELD", 0)]
        Shield = 9,
        [FastEnumUtility.Label("EQUIP_TYPE_CAPE", 0)]
        Cape = 10,
        [FastEnumUtility.Label("EQUIP_TYPE_RING", 0)]
        Ring = 11,
        [FastEnumUtility.Label("EQUIP_TYPE_PENDANT", 0)]
        Pendant = 12,
        [FastEnumUtility.Label("EQUIP_TYPE_BELT", 0)]
        Belt = 13,
    }
    public enum EquipSlot : byte
    {
        [FastEnumUtility.Label("Cp", 2)]
        Cap = 1,
        [FastEnumUtility.Label("Fa", 2)]
        FaceAcc = 2,
        [FastEnumUtility.Label("Er", 2)]
        Earring = 3,
        [FastEnumUtility.Label("Ay", 2)]
        EyeAcc = 4,
        [FastEnumUtility.Label("Ma", 2)]
        Coat = 5,
        [FastEnumUtility.Label("Pn", 2)]
        Pants = 6,
        [FastEnumUtility.Label("Sh", 2)]
        Shoes = 7,
        [FastEnumUtility.Label("Su", 2)]
        Shield = 9,
        [FastEnumUtility.Label("Wp", 2)]
        Weapon = 10,
        [FastEnumUtility.Label("Sr", 2)]
        Cape = 11,
        [FastEnumUtility.Label("Ri", 2)]
        Ring1 = 12,
        [FastEnumUtility.Label("Ri", 2)]
        Ring2 = 13,
        [FastEnumUtility.Label("Pe", 2)]
        Pendant = 15,
        [FastEnumUtility.Label("Glv", 2)]
        Gloves = 17,
        [FastEnumUtility.Label("Me", 2)]
        Medal = 49,
        [FastEnumUtility.Label("Be", 2)]
        Belt = 50,
    }
    public enum EquipUpgradeResult
    {
        [FastEnumUtility.Label("UpgradeFail", 0)]
        Fail = 0,
        [FastEnumUtility.Label("UpgradeSuccess", 0)]
        Success = 1,
        [FastEnumUtility.Label("UpgradeCursed", 0)]
        Cursed = 2,
    }
    public enum ExpeditionInviteResult : byte
    {
        [FastEnumUtility.Label("ExpeditionInviteResult_InvalidUser", 0)]
        [FastEnumUtility.Label("Invalid User", 1)]
        InvalidUser = 0,
        [FastEnumUtility.Label("ExpeditionInviteResult_Admin", 0)]
        Admin = 1,
        [FastEnumUtility.Label("ExpeditionInviteResult_InParty", 0)]
        [FastEnumUtility.Label("In Party", 1)]
        InParty = 2,
        [FastEnumUtility.Label("ExpeditionInviteResult_OutOfLevelRange", 0)]
        [FastEnumUtility.Label("Out Of Level Range", 1)]
        OutOfLevelRange = 3,
        [FastEnumUtility.Label("Blocked User", 1)]
        [FastEnumUtility.Label("ExpeditionInviteResult_BlockedUser", 0)]
        BlockedUser = 4,
        [FastEnumUtility.Label("Already Invited", 1)]
        [FastEnumUtility.Label("ExpeditionInviteResult_AlreadyInvited", 0)]
        AlreadyInvited = 5,
        [FastEnumUtility.Label("Already Invited By Inviter", 1)]
        [FastEnumUtility.Label("ExpeditionInviteResult_AlreadyInvitedbyInviter", 0)]
        AlreadyInvitedByInviter = 6,
        [FastEnumUtility.Label("ExpeditionInviteResult_Sent", 0)]
        Sent = 7,
        [FastEnumUtility.Label("ExpeditionInviteResult_Accept", 0)]
        Accept = 8,
        [FastEnumUtility.Label("ExpeditionInviteResult_Reject", 0)]
        Reject = 9,
        [FastEnumUtility.Label("ExpeditionJoinResult_Success", 0)]
        [FastEnumUtility.Label("Join Success", 1)]
        JoinSuccess = 10,
        [FastEnumUtility.Label("ExpeditionJoinResult_Full", 0)]
        [FastEnumUtility.Label("Join Full", 1)]
        JoinFull = 11,
        [FastEnumUtility.Label("ExpeditionJoinResult_NotExist", 0)]
        [FastEnumUtility.Label("Join Not Exist", 1)]
        JoinNotExist = 12,
    }
    public enum FamilyPrivilegeType : byte
    {
        [FastEnumUtility.Label("Type_Exp", 0)]
        Exp = 2,
        [FastEnumUtility.Label("Type_Drop", 0)]
        Drop = 3,
        [FastEnumUtility.Label("Type_Family", 0)]
        Family = 4,
    }
    public enum FamilyTreeNodeType : byte
    {
        [FastEnumUtility.Label("NODE_BOSS", 0)]
        Boss = 0,
        [FastEnumUtility.Label("NODE_GRANDFATHER", 0)]
        Grandfather = 1,
        [FastEnumUtility.Label("NODE_FATHER", 0)]
        Father = 2,
        [FastEnumUtility.Label("NODE_ME", 0)]
        Me = 3,
        [FastEnumUtility.Label("NODE_BROTHER", 0)]
        Brother = 4,
        [FastEnumUtility.Label("NODE_CHILD_0", 0)]
        Child0 = 5,
        [FastEnumUtility.Label("NODE_CHILD_1", 0)]
        Child1 = 6,
        [FastEnumUtility.Label("NODE_GRANDCHILD_0", 0)]
        Grandchild0 = 7,
        [FastEnumUtility.Label("NODE_GRANDCHILD_1", 0)]
        Grandchild1 = 8,
        [FastEnumUtility.Label("NODE_GRANDCHILD_2", 0)]
        Grandchild2 = 9,
        [FastEnumUtility.Label("NODE_GRANDCHILD_3", 0)]
        Grandchild3 = 10,
        [FastEnumUtility.Label("NODE_COUNT", 0)]
        Count = 11,
    }
    public enum FieldAffectAreaType : byte
    {
        [FastEnumUtility.Label("AffectArea_MobSkill", 0)]
        [FastEnumUtility.Label("Mob Skill", 1)]
        MobSkill = 0,
        [FastEnumUtility.Label("AffectArea_UserSkill", 0)]
        [FastEnumUtility.Label("User Skill", 1)]
        UserSkill = 1,
        [FastEnumUtility.Label("AffectArea_Smoke", 0)]
        Smoke = 2,
        [FastEnumUtility.Label("AffectArea_Buff", 0)]
        Buff = 3,
        [FastEnumUtility.Label("AffectArea_BlessedMist", 0)]
        [FastEnumUtility.Label("Blessed Mist", 1)]
        BlessedMist = 4,
    }
    public enum FieldCubeType : byte
    {
        [FastEnumUtility.Label("FIELD_CUBE_TYPE_ERROR", 0)]
        Error = 0,
        [FastEnumUtility.Label("FIELD_CUBE_TYPE_HUNTING", 0)]
        Hunting = 1,
        [FastEnumUtility.Label("Area Check", 1)]
        [FastEnumUtility.Label("FIELD_CUBE_TYPE_AREACHECK", 0)]
        AreaCheck = 2,
        [FastEnumUtility.Label("FIELD_CUBE_TYPE_NUM", 0)]
        Num = 3,
    }
    public enum FieldEffectType : byte
    {
        [FastEnumUtility.Label("FieldEffect_Summon", 0)]
        Summon = 0,
        [FastEnumUtility.Label("FieldEffect_Tremble", 0)]
        Tremble = 1,
        [FastEnumUtility.Label("FieldEffect_Object", 0)]
        Object = 2,
        [FastEnumUtility.Label("FieldEffect_Screen", 0)]
        Screen = 3,
        [FastEnumUtility.Label("FieldEffect_Sound", 0)]
        Sound = 4,
        [FastEnumUtility.Label("FieldEffect_MobHPTag", 0)]
        [FastEnumUtility.Label("Mob HP Tag", 1)]
        MobHPTag = 5,
        [FastEnumUtility.Label("Change BGM", 1)]
        [FastEnumUtility.Label("FieldEffect_ChangeBGM", 0)]
        ChangeBGM = 6,
        [FastEnumUtility.Label("FieldEffect_RewordRullet", 0)]
        [FastEnumUtility.Label("Reward Roulette", 1)]
        RewardRoulette = 7,
    }
    public enum FieldEventType : byte
    {
        [FastEnumUtility.Label("EVENTTYPE_HUNTING", 0)]
        Hunting = 1,
        [FastEnumUtility.Label("EVENTTYPE_OXQUIZ", 0)]
        [FastEnumUtility.Label("Ox Quiz", 1)]
        OxQuiz = 2,
        [FastEnumUtility.Label("EVENTTYPE_LADDER", 0)]
        Ladder = 3,
        [FastEnumUtility.Label("EVENTTYPE_UPLAND", 0)]
        Upland = 4,
        [FastEnumUtility.Label("EVENTTYPE_ETC", 0)]
        Etc = 5,
        [FastEnumUtility.Label("EVENTTYPE_SNOWBALL", 0)]
        Snowball = 6,
    }
    public enum FieldLifeType : byte
    {
        NPC = 0,
        Monster = 1,
    }
    public enum FieldMobAppearType : sbyte
    {
        Normal = -1,
        Regen = -2,
        Revived = -3,
        Suspended = -4,
        Delay = -5,
        Effect = 0,
    }
    public enum FieldMobLeaveType : byte
    {
        [FastEnumUtility.Label("Remain HP", 1)]
        RemainHP = 0,
        Etc = 1,
        [FastEnumUtility.Label("Self Destruct", 1)]
        SelfDestruct = 2,
        [FastEnumUtility.Label("Destruct By Miss", 1)]
        DestructByMiss = 3,
        Swallow = 4,
        [FastEnumUtility.Label("Summon Timeout", 1)]
        SummonTimeout = 5,
        None = 6,
    }
    public enum FieldObjectType : byte
    {
        User = 0,
        Summoned = 1,
        Mob = 2,
        NPC = 3,
        Employee = 4,
        Drop = 5,
        [FastEnumUtility.Label("Message Box", 1)]
        MessageBox = 6,
        [FastEnumUtility.Label("Affected Area", 1)]
        AffectedArea = 7,
        [FastEnumUtility.Label("Town Portal", 1)]
        TownPortal = 8,
        [FastEnumUtility.Label("Open Gate", 1)]
        OpenGate = 9,
        Reactor = 10,
        Etc = 11,
    }
    public enum FollowState : byte
    {
        [FastEnumUtility.Label("FS_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("FS_REQUEST", 0)]
        Request = 1,
        [FastEnumUtility.Label("FS_REFUSED", 0)]
        Refused = 2,
        [FastEnumUtility.Label("Cell Auth", 1)]
        [FastEnumUtility.Label("FS_CELLAUTH", 0)]
        CellAuth = 3,
        [FastEnumUtility.Label("FS_MATEENABLE", 0)]
        [FastEnumUtility.Label("Mate Enable", 1)]
        MateEnable = 4,
    }
    public enum FontType : byte
    {
        [FastEnumUtility.Label("Basic White", 1)]
        [FastEnumUtility.Label("FONT_BASIC_WHITE", 0)]
        BasicWhite = 0,
        [FastEnumUtility.Label("Basic Black", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BLACK", 0)]
        BasicBlack = 1,
        [FastEnumUtility.Label("Basic Gray", 1)]
        [FastEnumUtility.Label("FONT_BASIC_GRAY", 0)]
        BasicGray = 2,
        [FastEnumUtility.Label("Basic Yellow", 1)]
        [FastEnumUtility.Label("FONT_BASIC_YELLOW", 0)]
        BasicYellow = 3,
        [FastEnumUtility.Label("Basic Blue", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BLUE", 0)]
        BasicBlue = 4,
        [FastEnumUtility.Label("Basic Sky Blue", 1)]
        [FastEnumUtility.Label("FONT_BASIC_SKYBLUE", 0)]
        BasicSkyBlue = 5,
        [FastEnumUtility.Label("Basic Red", 1)]
        [FastEnumUtility.Label("FONT_BASIC_RED", 0)]
        BasicRed = 6,
        [FastEnumUtility.Label("Basic Light Green", 1)]
        [FastEnumUtility.Label("FONT_BASIC_LIGHTGREEN", 0)]
        BasicLightGreen = 7,
        [FastEnumUtility.Label("Basic Pink", 1)]
        [FastEnumUtility.Label("FONT_BASIC_PINK", 0)]
        BasicPink = 8,
        [FastEnumUtility.Label("Basic Orange", 1)]
        [FastEnumUtility.Label("FONT_BASIC_ORANGE", 0)]
        BasicOrange = 9,
        [FastEnumUtility.Label("Basic Red Violet", 1)]
        [FastEnumUtility.Label("FONT_BASIC_REDVIOLET", 0)]
        BasicRedViolet = 10,
        [FastEnumUtility.Label("Basic Dim Blue", 1)]
        [FastEnumUtility.Label("FONT_BASIC_DIMBLUE", 0)]
        BasicDimBlue = 11,
        [FastEnumUtility.Label("Basic Dim Red", 1)]
        [FastEnumUtility.Label("FONT_BASIC_DIMRED", 0)]
        BasicDimRed = 12,
        [FastEnumUtility.Label("Basic Dim Green", 1)]
        [FastEnumUtility.Label("FONT_BASIC_DIMGREEN", 0)]
        BasicDimGreen = 13,
        [FastEnumUtility.Label("Basic Brown", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BROWN", 0)]
        BasicBrown = 14,
        [FastEnumUtility.Label("Basic Light Violet", 1)]
        [FastEnumUtility.Label("FONT_BASIC_LIGHTVIOLET", 0)]
        BasicLightViolet = 15,
        [FastEnumUtility.Label("Basic Cyan", 1)]
        [FastEnumUtility.Label("FONT_BASIC_CYAN", 0)]
        BasicCyan = 16,
        [FastEnumUtility.Label("Basic Light Gray", 1)]
        [FastEnumUtility.Label("FONT_BASIC_LIGHTGRAY", 0)]
        BasicLightGray = 17,
        [FastEnumUtility.Label("Basic Dark Gray", 1)]
        [FastEnumUtility.Label("FONT_BASIC_DARKGRAY", 0)]
        BasicDarkGray = 18,
        [FastEnumUtility.Label("Basic Dim Gray", 1)]
        [FastEnumUtility.Label("FONT_BASIC_DIMGRAY", 0)]
        BasicDimGray = 19,
        [FastEnumUtility.Label("FONT_SMALL_BLACK", 0)]
        [FastEnumUtility.Label("Small Black", 1)]
        SmallBlack = 20,
        [FastEnumUtility.Label("FONT_SMALL_BLACK_B", 0)]
        [FastEnumUtility.Label("Small Black Bold", 1)]
        SmallBlackBold = 21,
        [FastEnumUtility.Label("FONT_SMALL_WHITE", 0)]
        [FastEnumUtility.Label("Small White", 1)]
        SmallWhite = 22,
        [FastEnumUtility.Label("FONT_SMALL_WHITE_B", 0)]
        [FastEnumUtility.Label("Small White Bold", 1)]
        SmallWhiteBold = 23,
        [FastEnumUtility.Label("FONT_SMALL_GRAY", 0)]
        [FastEnumUtility.Label("Small Gray", 1)]
        SmallGray = 24,
        [FastEnumUtility.Label("FONT_SMALL_GRAY_B", 0)]
        [FastEnumUtility.Label("Small Gray Bold", 1)]
        SmallGrayBold = 25,
        [FastEnumUtility.Label("FONT_SMALL_WHITEGRAY", 0)]
        [FastEnumUtility.Label("Small White Gray", 1)]
        SmallWhiteGray = 26,
        [FastEnumUtility.Label("FONT_SMALL_WHITEGRAY_B", 0)]
        [FastEnumUtility.Label("Small White Gray Bold", 1)]
        SmallWhiteGrayBold = 27,
        [FastEnumUtility.Label("FONT_SMALL_BLUE", 0)]
        [FastEnumUtility.Label("Small Blue", 1)]
        SmallBlue = 28,
        [FastEnumUtility.Label("FONT_SMALL_BLUE_B", 0)]
        [FastEnumUtility.Label("Small Blue Bold", 1)]
        SmallBlueBold = 29,
        [FastEnumUtility.Label("FONT_SMALL_SKYBLUE", 0)]
        [FastEnumUtility.Label("Small Sky Blue", 1)]
        SmallSkyBlue = 30,
        [FastEnumUtility.Label("FONT_SMALL_SKYBLUE_B", 0)]
        [FastEnumUtility.Label("Small Sky Blue Bold", 1)]
        SmallSkyBlueBold = 31,
        [FastEnumUtility.Label("FONT_SMALL_DIMBLUE", 0)]
        [FastEnumUtility.Label("Small Dim Blue", 1)]
        SmallDimBlue = 32,
        [FastEnumUtility.Label("FONT_SMALL_DIMBLUE_B", 0)]
        [FastEnumUtility.Label("Small Dim Blue Bold", 1)]
        SmallDimBlueBold = 33,
        [FastEnumUtility.Label("FONT_SMALL_RED", 0)]
        [FastEnumUtility.Label("Small Red", 1)]
        SmallRed = 34,
        [FastEnumUtility.Label("FONT_SMALL_RED_B", 0)]
        [FastEnumUtility.Label("Small Red Bold", 1)]
        SmallRedBold = 35,
        [FastEnumUtility.Label("FONT_SMALL_DIMRED", 0)]
        [FastEnumUtility.Label("Small Dim Red", 1)]
        SmallDimRed = 36,
        [FastEnumUtility.Label("FONT_SMALL_DIMRED_B", 0)]
        [FastEnumUtility.Label("Small Dim Red Bold", 1)]
        SmallDimRedBold = 37,
        [FastEnumUtility.Label("FONT_SMALL_REDVIOLET", 0)]
        [FastEnumUtility.Label("Small Red Violet", 1)]
        SmallRedViolet = 38,
        [FastEnumUtility.Label("FONT_SMALL_REDVIOLET_B", 0)]
        [FastEnumUtility.Label("Small Red Violet Bold", 1)]
        SmallRedVioletBold = 39,
        [FastEnumUtility.Label("FONT_SMALL_ORANGE", 0)]
        [FastEnumUtility.Label("Small Orange", 1)]
        SmallOrange = 40,
        [FastEnumUtility.Label("FONT_SMALL_ORANGE_B", 0)]
        [FastEnumUtility.Label("Small Orange Bold", 1)]
        SmallOrangeBold = 41,
        [FastEnumUtility.Label("FONT_SMALL_DIMGREEN", 0)]
        [FastEnumUtility.Label("Small Dim Green", 1)]
        SmallDimGreen = 42,
        [FastEnumUtility.Label("FONT_SMALL_DIMGREEN_B", 0)]
        [FastEnumUtility.Label("Small Dim Green Bold", 1)]
        SmallDimGreenBold = 43,
        [FastEnumUtility.Label("FONT_SMALL_YELLOW", 0)]
        [FastEnumUtility.Label("Small Yellow", 1)]
        SmallYellow = 44,
        [FastEnumUtility.Label("FONT_SMALL_YELLOW_B", 0)]
        [FastEnumUtility.Label("Small Yellow Bold", 1)]
        SmallYellowBold = 45,
        [FastEnumUtility.Label("FONT_SMALL_LIGHTGREEN", 0)]
        [FastEnumUtility.Label("Small Light Green", 1)]
        SmallLightGreen = 46,
        [FastEnumUtility.Label("FONT_SMALL_LIGHTGREEN_B", 0)]
        [FastEnumUtility.Label("Small Light Green Bold", 1)]
        SmallLightGreenBold = 47,
        [FastEnumUtility.Label("FONT_SMALL_DARKGRAY", 0)]
        [FastEnumUtility.Label("Small Dark Gray", 1)]
        SmallDarkGray = 48,
        [FastEnumUtility.Label("Dlg Normal", 1)]
        [FastEnumUtility.Label("FONT_DLG_NORMAL", 0)]
        DlgNormal = 49,
        [FastEnumUtility.Label("Dlg Back", 1)]
        [FastEnumUtility.Label("FONT_DLG_BACK", 0)]
        DlgBack = 50,
        [FastEnumUtility.Label("Dlg Outline", 1)]
        [FastEnumUtility.Label("FONT_DLG_OUTLINE", 0)]
        DlgOutline = 51,
        [FastEnumUtility.Label("Dlg Normal Fixed Width", 1)]
        [FastEnumUtility.Label("FONT_DLG_NORMAL_FIXED_W", 0)]
        DlgNormalFixedWidth = 52,
        [FastEnumUtility.Label("Dlg Back Fixed Width", 1)]
        [FastEnumUtility.Label("FONT_DLG_BACK_FIXED_W", 0)]
        DlgBackFixedWidth = 53,
        [FastEnumUtility.Label("Dlg Outline Fixed Width", 1)]
        [FastEnumUtility.Label("FONT_DLG_OUTLINE_FIXED_W", 0)]
        DlgOutlineFixedWidth = 54,
        [FastEnumUtility.Label("FONT_NO_WHITE", 0)]
        [FastEnumUtility.Label("Number White", 1)]
        NumberWhite = 55,
        [FastEnumUtility.Label("FONT_NO_BLACK", 0)]
        [FastEnumUtility.Label("Number Black", 1)]
        NumberBlack = 56,
        [FastEnumUtility.Label("FONT_NO_BLACK_SMALL", 0)]
        [FastEnumUtility.Label("Number Black Small", 1)]
        NumberBlackSmall = 57,
        [FastEnumUtility.Label("FONT_NO_GRAY", 0)]
        [FastEnumUtility.Label("Number Gray", 1)]
        NumberGray = 58,
        [FastEnumUtility.Label("FONT_NO_YELLOW", 0)]
        [FastEnumUtility.Label("Number Yellow", 1)]
        NumberYellow = 59,
        [FastEnumUtility.Label("FONT_NO_WHITE_BA", 0)]
        [FastEnumUtility.Label("Number White Background", 1)]
        NumberWhiteBackground = 60,
        [FastEnumUtility.Label("FONT_NO_BLACK_BA", 0)]
        [FastEnumUtility.Label("Number Black Background", 1)]
        NumberBlackBackground = 61,
        [FastEnumUtility.Label("FONT_NO_BLUE", 0)]
        [FastEnumUtility.Label("Number Blue", 1)]
        NumberBlue = 62,
        [FastEnumUtility.Label("FONT_NO_RED", 0)]
        [FastEnumUtility.Label("Number Red", 1)]
        NumberRed = 63,
        [FastEnumUtility.Label("FONT_NO_BLUE_B", 0)]
        [FastEnumUtility.Label("Number Blue Bold", 1)]
        NumberBlueBold = 64,
        [FastEnumUtility.Label("FONT_NO_RED_B", 0)]
        [FastEnumUtility.Label("Number Red Bold", 1)]
        NumberRedBold = 65,
        [FastEnumUtility.Label("Big White", 1)]
        [FastEnumUtility.Label("FONT_BIG_WHITE", 0)]
        BigWhite = 66,
        [FastEnumUtility.Label("Disabled Gray", 1)]
        [FastEnumUtility.Label("FONT_DISABLED_GRAY", 0)]
        DisabledGray = 67,
        [FastEnumUtility.Label("FONT_SMALL_DISABLED_GRAY", 0)]
        [FastEnumUtility.Label("Small Disabled Gray", 1)]
        SmallDisabledGray = 68,
        [FastEnumUtility.Label("Basic Black Bold", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BLACK_B", 0)]
        BasicBlackBold = 69,
        [FastEnumUtility.Label("Basic Blue Bold", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BLUE_B", 0)]
        BasicBlueBold = 70,
        [FastEnumUtility.Label("Basic Red Bold", 1)]
        [FastEnumUtility.Label("FONT_BASIC_RED_B", 0)]
        BasicRedBold = 71,
        [FastEnumUtility.Label("Basic Brown Bold", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BROWN_B", 0)]
        BasicBrownBold = 72,
        [FastEnumUtility.Label("FONT_SALE_RED", 0)]
        [FastEnumUtility.Label("Sale Red", 1)]
        SaleRed = 73,
        [FastEnumUtility.Label("FONT_SALE_DARKRED", 0)]
        [FastEnumUtility.Label("Sale Dark Red", 1)]
        SaleDarkRed = 74,
        [FastEnumUtility.Label("FONT_STAN_WHITE", 0)]
        [FastEnumUtility.Label("Stan White", 1)]
        StanWhite = 75,
        [FastEnumUtility.Label("FONT_STAN_BLACK", 0)]
        [FastEnumUtility.Label("Stan Black", 1)]
        StanBlack = 76,
        [FastEnumUtility.Label("FONT_STAN_BLUE", 0)]
        [FastEnumUtility.Label("Stan Blue", 1)]
        StanBlue = 77,
        [FastEnumUtility.Label("FONT_STAN_RED", 0)]
        [FastEnumUtility.Label("Stan Red", 1)]
        StanRed = 78,
        [FastEnumUtility.Label("FONT_STAN_ORANGE", 0)]
        [FastEnumUtility.Label("Stan Orange", 1)]
        StanOrange = 79,
        [FastEnumUtility.Label("FONT_STAN_WHITE_BA", 0)]
        [FastEnumUtility.Label("Stan White Background", 1)]
        StanWhiteBackground = 80,
        [FastEnumUtility.Label("FONT_STAN_BLACK_BA", 0)]
        [FastEnumUtility.Label("Stan Black Background", 1)]
        StanBlackBackground = 81,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_1", 0)]
        [FastEnumUtility.Label("Personal Shop1", 1)]
        PersonalShop1 = 82,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_2", 0)]
        [FastEnumUtility.Label("Personal Shop2", 1)]
        PersonalShop2 = 83,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_3", 0)]
        [FastEnumUtility.Label("Personal Shop3", 1)]
        PersonalShop3 = 84,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_4", 0)]
        [FastEnumUtility.Label("Personal Shop4", 1)]
        PersonalShop4 = 85,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_5", 0)]
        [FastEnumUtility.Label("Personal Shop5", 1)]
        PersonalShop5 = 86,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_6", 0)]
        [FastEnumUtility.Label("Personal Shop6", 1)]
        PersonalShop6 = 87,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_1_s", 0)]
        [FastEnumUtility.Label("Personal Shop1Small", 1)]
        PersonalShop1Small = 88,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_2_s", 0)]
        [FastEnumUtility.Label("Personal Shop2Small", 1)]
        PersonalShop2Small = 89,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_3_s", 0)]
        [FastEnumUtility.Label("Personal Shop3Small", 1)]
        PersonalShop3Small = 90,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_4_s", 0)]
        [FastEnumUtility.Label("Personal Shop4Small", 1)]
        PersonalShop4Small = 91,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_5_s", 0)]
        [FastEnumUtility.Label("Personal Shop5Small", 1)]
        PersonalShop5Small = 92,
        [FastEnumUtility.Label("FONT_PERSONALSHOP_6_s", 0)]
        [FastEnumUtility.Label("Personal Shop6Small", 1)]
        PersonalShop6Small = 93,
        [FastEnumUtility.Label("FONT_DODOOMCHE_11_WHITE", 0)]
        Dodoomche11White = 94,
        [FastEnumUtility.Label("FONT_DODOOMCHE_11_BLACK", 0)]
        Dodoomche11Black = 95,
        [FastEnumUtility.Label("FONT_DODOOMCHE_11_GRAY90", 0)]
        Dodoomche11Gray90 = 96,
        [FastEnumUtility.Label("Basic Black Big", 1)]
        [FastEnumUtility.Label("FONT_BASIC_BLACK_BIG", 0)]
        BasicBlackBig = 97,
        [FastEnumUtility.Label("FONT_NO", 0)]
        No = 98,
    }
    [System.Flags]
    public enum ForcedStatFlag : ushort
    {
        [FastEnumUtility.Label("AUTO", 0)]
        None = 0,
        [FastEnumUtility.Label("STR", 0)]
        Str = 1,
        [FastEnumUtility.Label("DEX", 0)]
        Dex = 2,
        [FastEnumUtility.Label("INT", 0)]
        Int = 4,
        [FastEnumUtility.Label("LUK", 0)]
        Luk = 8,
        [FastEnumUtility.Label("PAD", 0)]
        Pad = 16,
        [FastEnumUtility.Label("PDD", 0)]
        Pdd = 32,
        [FastEnumUtility.Label("MAD", 0)]
        Mad = 64,
        [FastEnumUtility.Label("MDD", 0)]
        Mdd = 128,
        [FastEnumUtility.Label("ACC", 0)]
        Acc = 256,
        [FastEnumUtility.Label("EVA", 0)]
        Eva = 512,
        [FastEnumUtility.Label("SPEED", 0)]
        Speed = 1024,
        [FastEnumUtility.Label("JUMP", 0)]
        Jump = 2048,
        [FastEnumUtility.Label("SPEEDMAX", 0)]
        SpeedMax = 4096,
        [FastEnumUtility.Label("ALL", 0)]
        All = 8191,
    }
    public enum FrequentActionType : byte
    {
        [FastEnumUtility.Label("Create Shop", 1)]
        [FastEnumUtility.Label("FREQUENT_ACTION_CREATE_SHOP", 0)]
        CreateShop = 0,
        [FastEnumUtility.Label("FREQUENT_ACTION_REQUEST_PQ", 0)]
        [FastEnumUtility.Label("Request Pq", 1)]
        RequestPq = 1,
        [FastEnumUtility.Label("FREQUENT_ACTION_REQUEST_HP_RECOVERY", 0)]
        [FastEnumUtility.Label("Request Hp Recovery", 1)]
        RequestHpRecovery = 2,
        [FastEnumUtility.Label("FREQUENT_ACTION_REQUEST_MP_RECOVERY", 0)]
        [FastEnumUtility.Label("Request Mp Recovery", 1)]
        RequestMpRecovery = 3,
        [FastEnumUtility.Label("FREQUENT_ACTION_NO", 0)]
        No = 4,
    }
    public enum FriendOperation : byte
    {
        [FastEnumUtility.Label("FriendReq_LoadFriend", 0)]
        [FastEnumUtility.Label("Req Load Friend", 1)]
        ReqLoadFriend = 0,
        [FastEnumUtility.Label("FriendReq_SetFriend", 0)]
        [FastEnumUtility.Label("Req Set Friend", 1)]
        ReqSetFriend = 1,
        [FastEnumUtility.Label("FriendReq_AcceptFriend", 0)]
        [FastEnumUtility.Label("Req Accept Friend", 1)]
        ReqAcceptFriend = 2,
        [FastEnumUtility.Label("FriendReq_DeleteFriend", 0)]
        [FastEnumUtility.Label("Req Delete Friend", 1)]
        ReqDeleteFriend = 3,
        [FastEnumUtility.Label("FriendReq_NotifyLogin", 0)]
        [FastEnumUtility.Label("Req Notify Login", 1)]
        ReqNotifyLogin = 4,
        [FastEnumUtility.Label("FriendReq_NotifyLogout", 0)]
        [FastEnumUtility.Label("Req Notify Logout", 1)]
        ReqNotifyLogout = 5,
        [FastEnumUtility.Label("FriendReq_IncMaxCount", 0)]
        [FastEnumUtility.Label("Req Inc Max Count", 1)]
        ReqIncMaxCount = 6,
        [FastEnumUtility.Label("FriendRes_LoadFriend_Done", 0)]
        [FastEnumUtility.Label("Res Load Friend Done", 1)]
        ResLoadFriendDone = 7,
        [FastEnumUtility.Label("FriendRes_NotifyChange_FriendInfo", 0)]
        [FastEnumUtility.Label("Res Notify Change Friend Info", 1)]
        ResNotifyChangeFriendInfo = 8,
        [FastEnumUtility.Label("FriendRes_Invite", 0)]
        [FastEnumUtility.Label("Res Invite", 1)]
        ResInvite = 9,
        [FastEnumUtility.Label("FriendRes_SetFriend_Done", 0)]
        [FastEnumUtility.Label("Res Set Friend Done", 1)]
        ResSetFriendDone = 10,
        [FastEnumUtility.Label("FriendRes_SetFriend_FullMe", 0)]
        [FastEnumUtility.Label("Res Set Friend Full Me", 1)]
        ResSetFriendFullMe = 11,
        [FastEnumUtility.Label("FriendRes_SetFriend_FullOther", 0)]
        [FastEnumUtility.Label("Res Set Friend Full Other", 1)]
        ResSetFriendFullOther = 12,
        [FastEnumUtility.Label("FriendRes_SetFriend_AlreadySet", 0)]
        [FastEnumUtility.Label("Res Set Friend Already Set", 1)]
        ResSetFriendAlreadySet = 13,
        [FastEnumUtility.Label("FriendRes_SetFriend_Master", 0)]
        [FastEnumUtility.Label("Res Set Friend Master", 1)]
        ResSetFriendMaster = 14,
        [FastEnumUtility.Label("FriendRes_SetFriend_UnknownUser", 0)]
        [FastEnumUtility.Label("Res Set Friend Unknown User", 1)]
        ResSetFriendUnknownUser = 15,
        [FastEnumUtility.Label("FriendRes_SetFriend_Unknown", 0)]
        [FastEnumUtility.Label("Res Set Friend Unknown", 1)]
        ResSetFriendUnknown = 16,
        [FastEnumUtility.Label("FriendRes_AcceptFriend_Unknown", 0)]
        [FastEnumUtility.Label("Res Accept Friend Unknown", 1)]
        ResAcceptFriendUnknown = 17,
        [FastEnumUtility.Label("FriendRes_DeleteFriend_Done", 0)]
        [FastEnumUtility.Label("Res Delete Friend Done", 1)]
        ResDeleteFriendDone = 18,
        [FastEnumUtility.Label("FriendRes_DeleteFriend_Unknown", 0)]
        [FastEnumUtility.Label("Res Delete Friend Unknown", 1)]
        ResDeleteFriendUnknown = 19,
        [FastEnumUtility.Label("FriendRes_Notify", 0)]
        [FastEnumUtility.Label("Res Notify", 1)]
        ResNotify = 20,
        [FastEnumUtility.Label("FriendRes_IncMaxCount_Done", 0)]
        [FastEnumUtility.Label("Res Inc Max Count Done", 1)]
        ResIncMaxCountDone = 21,
        [FastEnumUtility.Label("FriendRes_IncMaxCount_Unknown", 0)]
        [FastEnumUtility.Label("Res Inc Max Count Unknown", 1)]
        ResIncMaxCountUnknown = 22,
        [FastEnumUtility.Label("FriendRes_PleaseWait", 0)]
        [FastEnumUtility.Label("Res Please Wait", 1)]
        ResPleaseWait = 23,
    }
    public enum FuncKeyType : byte
    {
        [FastEnumUtility.Label("T_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("T_SKILL", 0)]
        Skill = 1,
        [FastEnumUtility.Label("T_ITEM", 0)]
        Item = 2,
        [FastEnumUtility.Label("T_EMOTION", 0)]
        Emotion = 3,
        [FastEnumUtility.Label("T_MENU", 0)]
        Menu = 4,
        [FastEnumUtility.Label("Basic Action", 1)]
        [FastEnumUtility.Label("T_BASICACTION", 0)]
        BasicAction = 5,
        [FastEnumUtility.Label("Basic Emotion", 1)]
        [FastEnumUtility.Label("T_BASICEMOTION", 0)]
        BasicEmotion = 6,
        [FastEnumUtility.Label("T_EFFECT", 0)]
        Effect = 7,
        [FastEnumUtility.Label("Macro Skill", 1)]
        [FastEnumUtility.Label("T_MACROSKILL", 0)]
        MacroSkill = 8,
    }
    public enum GachaponMessageType : byte
    {
        [FastEnumUtility.Label("GACHAPON_MSGTYPE_NOINCUBATOR", 0)]
        [FastEnumUtility.Label("No Incubator", 1)]
        NoIncubator = 0,
        [FastEnumUtility.Label("GACHAPON_MSGTYPE_NOITEM", 0)]
        [FastEnumUtility.Label("No Item", 1)]
        NoItem = 1,
        [FastEnumUtility.Label("GACHAPON_MSGTYPE_NOTOPENGACHAPON", 0)]
        [FastEnumUtility.Label("Not Open Gachapon", 1)]
        NotOpenGachapon = 2,
        [FastEnumUtility.Label("GACHAPON_MSGTYPE_INCUBATING", 0)]
        Incubating = 3,
        [FastEnumUtility.Label("GACHAPON_MSGTYPE_SUCCESS", 0)]
        Success = 4,
        [FastEnumUtility.Label("GACHAPON_MSGTYPE_NO", 0)]
        No = 5,
    }
    public enum GameObjectType : byte
    {
        [FastEnumUtility.Label("GOT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("GOT_GAMEOBJECT", 0)]
        [FastEnumUtility.Label("Game Object", 1)]
        GameObject = 1,
        [FastEnumUtility.Label("GOT_CREATURE", 0)]
        Creature = 2,
        [FastEnumUtility.Label("GOT_USER", 0)]
        User = 3,
        [FastEnumUtility.Label("GOT_NPC", 0)]
        Npc = 4,
        [FastEnumUtility.Label("GOT_MOB", 0)]
        Mob = 5,
        [FastEnumUtility.Label("GOT_PET", 0)]
        Pet = 6,
        [FastEnumUtility.Label("GOT_ITEM", 0)]
        Item = 7,
        [FastEnumUtility.Label("GOT_PORTAL", 0)]
        Portal = 8,
        [FastEnumUtility.Label("GOT_REACTOR", 0)]
        Reactor = 9,
        [FastEnumUtility.Label("GOT_EMPLOYEE", 0)]
        Employee = 10,
    }
    public enum Gender : byte
    {
        [FastEnumUtility.Label("0", 2)]
        [FastEnumUtility.Label("GENDER_MALE", 0)]
        Male = 0,
        [FastEnumUtility.Label("1", 2)]
        [FastEnumUtility.Label("GENDER_FEMALE", 0)]
        Female = 1,
        [FastEnumUtility.Label("2", 2)]
        [FastEnumUtility.Label("Both", 1)]
        [FastEnumUtility.Label("GENDER_NONE", 0)]
        None = 2,
    }
    public enum GivePopularityResult : sbyte
    {
        [FastEnumUtility.Label("GivePopularityRes_UnknownError", 0)]
        [FastEnumUtility.Label("Unknown Error", 1)]
        UnknownError = -1,
        [FastEnumUtility.Label("GivePopularityRes_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("GivePopularityRes_InvalidCharacterID", 0)]
        [FastEnumUtility.Label("Invalid Character Id", 1)]
        InvalidCharacterId = 1,
        [FastEnumUtility.Label("GivePopularityRes_LevelLow", 0)]
        [FastEnumUtility.Label("Level Low", 1)]
        LevelLow = 2,
        [FastEnumUtility.Label("Already Done Today", 1)]
        [FastEnumUtility.Label("GivePopularityRes_AlreadyDoneToday", 0)]
        AlreadyDoneToday = 3,
        [FastEnumUtility.Label("Already Done Target", 1)]
        [FastEnumUtility.Label("GivePopularityRes_AlreadyDoneTarget", 0)]
        AlreadyDoneTarget = 4,
        [FastEnumUtility.Label("GivePopularityRes_Notify", 0)]
        Notify = 5,
    }
    public enum GoldHammerResult : byte
    {
        [FastEnumUtility.Label("GoldHammerRes_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("GoldHammerRes_Fail", 0)]
        Fail = 1,
        [FastEnumUtility.Label("GoldHammerRes_Done", 0)]
        Done = 2,
        [FastEnumUtility.Label("GoldHammerRes_Err", 0)]
        Error = 3,
    }
    public enum GuildBBSOperation : byte
    {
        [FastEnumUtility.Label("GuildBBS_Register", 0)]
        Register = 0,
        [FastEnumUtility.Label("GuildBBS_Delete", 0)]
        Delete = 1,
        [FastEnumUtility.Label("GuildBBS_LoadListRequest", 0)]
        [FastEnumUtility.Label("Load List Request", 1)]
        LoadListRequest = 2,
        [FastEnumUtility.Label("GuildBBS_ViewEntryRequest", 0)]
        [FastEnumUtility.Label("View Entry Request", 1)]
        ViewEntryRequest = 3,
        [FastEnumUtility.Label("GuildBBS_RegisterComment", 0)]
        [FastEnumUtility.Label("Register Comment", 1)]
        RegisterComment = 4,
        [FastEnumUtility.Label("Delete Comment", 1)]
        [FastEnumUtility.Label("GuildBBS_DeleteComment", 0)]
        DeleteComment = 5,
        [FastEnumUtility.Label("GuildBBS_LoadListResult", 0)]
        [FastEnumUtility.Label("Load List Result", 1)]
        LoadListResult = 6,
        [FastEnumUtility.Label("GuildBBS_ViewEntryResult", 0)]
        [FastEnumUtility.Label("View Entry Result", 1)]
        ViewEntryResult = 7,
        [FastEnumUtility.Label("Entry Not Found", 1)]
        [FastEnumUtility.Label("GuildBBS_EntryNotFound", 0)]
        EntryNotFound = 8,
    }
    public enum GuildGrade : byte
    {
        None = 0,
        Master = 1,
        [FastEnumUtility.Label("Sub Master", 1)]
        SubMaster = 2,
        [FastEnumUtility.Label("Member 1", 1)]
        Member1 = 3,
        [FastEnumUtility.Label("Member 2", 1)]
        Member2 = 4,
        [FastEnumUtility.Label("Member 3", 1)]
        Member3 = 5,
    }
    public enum HackingAutoBlockReason : byte
    {
        [FastEnumUtility.Label("HackingAutoBlockReason_UserDC", 0)]
        [FastEnumUtility.Label("User Dc", 1)]
        UserDc = 10,
        [FastEnumUtility.Label("HackingAutoBlockReason_Data", 0)]
        Data = 12,
        [FastEnumUtility.Label("HackingAutoBlockReason_Start", 0)]
        Start = 20,
        [FastEnumUtility.Label("HackingAutoBlockReason_Hit", 0)]
        Hit = 21,
        [FastEnumUtility.Label("HackingAutoBlockReason_Move", 0)]
        Move = 22,
        [FastEnumUtility.Label("HackingAutoBlockReason_Packet", 0)]
        Packet = 23,
        [FastEnumUtility.Label("HackingAutoBlockReason_Position", 0)]
        Position = 24,
        [FastEnumUtility.Label("HackingAutoBlockReason_Unrandomizer", 0)]
        Unrandomizer = 25,
        [FastEnumUtility.Label("HackingAutoBlockReason_ItemVac", 0)]
        [FastEnumUtility.Label("Item Vac", 1)]
        ItemVac = 26,
        [FastEnumUtility.Label("HackingAutoBlockReason_PacketAttack", 0)]
        [FastEnumUtility.Label("Packet Attack", 1)]
        PacketAttack = 27,
        [FastEnumUtility.Label("HackingAutoBlockReason_MissHack", 0)]
        [FastEnumUtility.Label("Miss Hack", 1)]
        MissHack = 28,
        [FastEnumUtility.Label("HackingAutoBlockReason_MobVelocityCheck", 0)]
        [FastEnumUtility.Label("Mob Velocity Check", 1)]
        MobVelocityCheck = 29,
        [FastEnumUtility.Label("HackingAutoBlockReason_InvalidDamage", 0)]
        [FastEnumUtility.Label("Invalid Damage", 1)]
        InvalidDamage = 30,
        [FastEnumUtility.Label("HackingAutoBlockReason_Warp", 0)]
        Warp = 31,
        [FastEnumUtility.Label("HackingAutoBlockReason_ZeroHack", 0)]
        [FastEnumUtility.Label("Zero Hack", 1)]
        ZeroHack = 32,
        [FastEnumUtility.Label("HackingAutoBlockReason_NoDamage", 0)]
        [FastEnumUtility.Label("No Damage", 1)]
        NoDamage = 33,
        [FastEnumUtility.Label("HackingAutoBlockReason_SummonedSpeed", 0)]
        [FastEnumUtility.Label("Summoned Speed", 1)]
        SummonedSpeed = 34,
        [FastEnumUtility.Label("HackingAutoBlockReason_IntentionalMobMoveIgnore", 0)]
        [FastEnumUtility.Label("Intentional Mob Move Ignore", 1)]
        IntentionalMobMoveIgnore = 35,
        [FastEnumUtility.Label("HackingAutoBlockReason_InvalidMobMovePattern", 0)]
        [FastEnumUtility.Label("Invalid Mob Move Pattern", 1)]
        InvalidMobMovePattern = 36,
        [FastEnumUtility.Label("HackingAutoBlockReason_StrangeMobMove", 0)]
        [FastEnumUtility.Label("Strange Mob Move", 1)]
        StrangeMobMove = 37,
        [FastEnumUtility.Label("HackingAutoBlockReason_JumpHack", 0)]
        [FastEnumUtility.Label("Jump Hack", 1)]
        JumpHack = 38,
        [FastEnumUtility.Label("HackingAutoBlockReason_ImpactCheat", 0)]
        [FastEnumUtility.Label("Impact Cheat", 1)]
        ImpactCheat = 39,
        [FastEnumUtility.Label("HackingAutoBlockReason_WzEdit", 0)]
        [FastEnumUtility.Label("Wz Edit", 1)]
        WzEdit = 40,
    }
    public enum HitPeriodType
    {
        [FastEnumUtility.Label("HitPeriod_None", 0)]
        None = -1,
        [FastEnumUtility.Label("HitPeriod_Basic", 0)]
        Basic = 0,
        [FastEnumUtility.Label("HitPeriod_Poison", 0)]
        Poison = 1,
        [FastEnumUtility.Label("HitPeriod_Areal", 0)]
        Areal = 2,
        [FastEnumUtility.Label("HitPeriod_StopMotion", 0)]
        [FastEnumUtility.Label("Stop Motion", 1)]
        StopMotion = 3,
        [FastEnumUtility.Label("HitPeriod_No", 0)]
        No = 4,
    }
    public enum IirRateCategory : byte
    {
        [FastEnumUtility.Label("Drop Normal", 1)]
        [FastEnumUtility.Label("IIR_Drop_Normal", 0)]
        DropNormal = 0,
        [FastEnumUtility.Label("Drop Premium", 1)]
        [FastEnumUtility.Label("IIR_Drop_Premium", 0)]
        DropPremium = 1,
        [FastEnumUtility.Label("Exp Normal", 1)]
        [FastEnumUtility.Label("IIR_Exp_Normal", 0)]
        ExpNormal = 2,
        [FastEnumUtility.Label("Exp Premium", 1)]
        [FastEnumUtility.Label("IIR_Exp_Premium", 0)]
        ExpPremium = 3,
    }
    public enum InventoryChangeLogType : byte
    {
        [FastEnumUtility.Label("ChangeLog_NewItem", 0)]
        [FastEnumUtility.Label("New Item", 1)]
        NewItem = 0,
        [FastEnumUtility.Label("ChangeLog_ItemNumber", 0)]
        [FastEnumUtility.Label("Item Number", 1)]
        ItemNumber = 1,
        [FastEnumUtility.Label("ChangeLog_Position", 0)]
        Position = 2,
        [FastEnumUtility.Label("ChangeLog_DelItem", 0)]
        [FastEnumUtility.Label("Del Item", 1)]
        DelItem = 3,
        [FastEnumUtility.Label("ChangeLog_EXP", 0)]
        Exp = 4,
    }
    public enum ItcOperation : byte
    {
        [FastEnumUtility.Label("ITCReq_GetMaplePoint", 0)]
        [FastEnumUtility.Label("Req Get Maple Point", 1)]
        ReqGetMaplePoint = 0,
        [FastEnumUtility.Label("ITCReq_CharacterModifiedNFlush", 0)]
        [FastEnumUtility.Label("Req Character Modified NFlush", 1)]
        ReqCharacterModifiedNFlush = 1,
        [FastEnumUtility.Label("ITCReq_RegisterSaleEntry", 0)]
        [FastEnumUtility.Label("Req Register Sale Entry", 1)]
        ReqRegisterSaleEntry = 2,
        [FastEnumUtility.Label("ITCReq_SaleCurrentItemToWish", 0)]
        [FastEnumUtility.Label("Req Sale Current Item To Wish", 1)]
        ReqSaleCurrentItemToWish = 3,
        [FastEnumUtility.Label("ITCReq_RegisterBuyOrder", 0)]
        [FastEnumUtility.Label("Req Register Buy Order", 1)]
        ReqRegisterBuyOrder = 4,
        [FastEnumUtility.Label("ITCReq_GetITCList", 0)]
        [FastEnumUtility.Label("Req Get Itc List", 1)]
        ReqGetItcList = 5,
        [FastEnumUtility.Label("ITCReq_GetSearchITCList", 0)]
        [FastEnumUtility.Label("Req Get Search Itc List", 1)]
        ReqGetSearchItcList = 6,
        [FastEnumUtility.Label("ITCReq_CancelSaleItem", 0)]
        [FastEnumUtility.Label("Req Cancel Sale Item", 1)]
        ReqCancelSaleItem = 7,
        [FastEnumUtility.Label("ITCReq_MoveITCPurchaseItemLtoS", 0)]
        [FastEnumUtility.Label("Req Move Itc Purchase Item Lto S", 1)]
        ReqMoveItcPurchaseItemLtoS = 8,
        [FastEnumUtility.Label("ITCReq_SetZzim", 0)]
        [FastEnumUtility.Label("Req Set Zzim", 1)]
        ReqSetZzim = 9,
        [FastEnumUtility.Label("ITCReq_DeleteZzim", 0)]
        [FastEnumUtility.Label("Req Delete Zzim", 1)]
        ReqDeleteZzim = 10,
        [FastEnumUtility.Label("ITCReq_LoadWishSaleList", 0)]
        [FastEnumUtility.Label("Req Load Wish Sale List", 1)]
        ReqLoadWishSaleList = 11,
        [FastEnumUtility.Label("ITCReq_BuyWish", 0)]
        [FastEnumUtility.Label("Req Buy Wish", 1)]
        ReqBuyWish = 12,
        [FastEnumUtility.Label("ITCReq_CancelWish", 0)]
        [FastEnumUtility.Label("Req Cancel Wish", 1)]
        ReqCancelWish = 13,
        [FastEnumUtility.Label("ITCReq_BuyWishChargeCash", 0)]
        [FastEnumUtility.Label("Req Buy Wish Charge Cash", 1)]
        ReqBuyWishChargeCash = 14,
        [FastEnumUtility.Label("ITCReq_BuyWishCancel", 0)]
        [FastEnumUtility.Label("Req Buy Wish Cancel", 1)]
        ReqBuyWishCancel = 15,
        [FastEnumUtility.Label("ITCReq_BuyItem", 0)]
        [FastEnumUtility.Label("Req Buy Item", 1)]
        ReqBuyItem = 16,
        [FastEnumUtility.Label("ITCReq_BuyZzimItem", 0)]
        [FastEnumUtility.Label("Req Buy Zzim Item", 1)]
        ReqBuyZzimItem = 17,
        [FastEnumUtility.Label("ITCReq_RegAuction", 0)]
        [FastEnumUtility.Label("Req Reg Auction", 1)]
        ReqRegAuction = 18,
        [FastEnumUtility.Label("ITCReq_BidAuction", 0)]
        [FastEnumUtility.Label("Req Bid Auction", 1)]
        ReqBidAuction = 19,
        [FastEnumUtility.Label("ITCReq_BuyAuctionImm", 0)]
        [FastEnumUtility.Label("Req Buy Auction Imm", 1)]
        ReqBuyAuctionImm = 20,
        [FastEnumUtility.Label("ITCRes_GetITCList_Done", 0)]
        [FastEnumUtility.Label("Res Get Itc List Done", 1)]
        ResGetItcListDone = 21,
        [FastEnumUtility.Label("ITCRes_GetITCList_Failed", 0)]
        [FastEnumUtility.Label("Res Get Itc List Failed", 1)]
        ResGetItcListFailed = 22,
        [FastEnumUtility.Label("ITCRes_GetSearchITCList_Done", 0)]
        [FastEnumUtility.Label("Res Get Search Itc List Done", 1)]
        ResGetSearchItcListDone = 23,
        [FastEnumUtility.Label("ITCRes_GetSearchITCList_Failed", 0)]
        [FastEnumUtility.Label("Res Get Search Itc List Failed", 1)]
        ResGetSearchItcListFailed = 24,
        [FastEnumUtility.Label("ITCRes_GetMaplePoint_Done", 0)]
        [FastEnumUtility.Label("Res Get Maple Point Done", 1)]
        ResGetMaplePointDone = 25,
        [FastEnumUtility.Label("ITCRes_GetMaplePoint_Failed", 0)]
        [FastEnumUtility.Label("Res Get Maple Point Failed", 1)]
        ResGetMaplePointFailed = 26,
        [FastEnumUtility.Label("ITCRes_CharacterModifiedNFlush_Done", 0)]
        [FastEnumUtility.Label("Res Character Modified NFlush Done", 1)]
        ResCharacterModifiedNFlushDone = 27,
        [FastEnumUtility.Label("ITCRes_CharacterModifiedNFlush_Failed", 0)]
        [FastEnumUtility.Label("Res Character Modified NFlush Failed", 1)]
        ResCharacterModifiedNFlushFailed = 28,
        [FastEnumUtility.Label("ITCRes_RegisterSaleEntry_Done", 0)]
        [FastEnumUtility.Label("Res Register Sale Entry Done", 1)]
        ResRegisterSaleEntryDone = 29,
        [FastEnumUtility.Label("ITCRes_RegisterSaleEntry_Failed", 0)]
        [FastEnumUtility.Label("Res Register Sale Entry Failed", 1)]
        ResRegisterSaleEntryFailed = 30,
        [FastEnumUtility.Label("ITCRes_SaleCurrentItemToWish_Done", 0)]
        [FastEnumUtility.Label("Res Sale Current Item To Wish Done", 1)]
        ResSaleCurrentItemToWishDone = 31,
        [FastEnumUtility.Label("ITCRes_SaleCurrentItemToWish_Failed", 0)]
        [FastEnumUtility.Label("Res Sale Current Item To Wish Failed", 1)]
        ResSaleCurrentItemToWishFailed = 32,
        [FastEnumUtility.Label("ITCRes_GetUserPurchaseItem_Done", 0)]
        [FastEnumUtility.Label("Res Get User Purchase Item Done", 1)]
        ResGetUserPurchaseItemDone = 33,
        [FastEnumUtility.Label("ITCRes_GetUserPurchaseItem_Failed", 0)]
        [FastEnumUtility.Label("Res Get User Purchase Item Failed", 1)]
        ResGetUserPurchaseItemFailed = 34,
        [FastEnumUtility.Label("ITCRes_GetUserSaleItem_Done", 0)]
        [FastEnumUtility.Label("Res Get User Sale Item Done", 1)]
        ResGetUserSaleItemDone = 35,
        [FastEnumUtility.Label("ITCRes_GetUserSaleItem_Failed", 0)]
        [FastEnumUtility.Label("Res Get User Sale Item Failed", 1)]
        ResGetUserSaleItemFailed = 36,
        [FastEnumUtility.Label("ITCRes_CancelSaleItem_Done", 0)]
        [FastEnumUtility.Label("Res Cancel Sale Item Done", 1)]
        ResCancelSaleItemDone = 37,
        [FastEnumUtility.Label("ITCRes_CancelSaleItem_Failed", 0)]
        [FastEnumUtility.Label("Res Cancel Sale Item Failed", 1)]
        ResCancelSaleItemFailed = 38,
        [FastEnumUtility.Label("ITCRes_MoveITCPurchaseItemLtoS_Done", 0)]
        [FastEnumUtility.Label("Res Move Itc Purchase Item Lto SDone", 1)]
        ResMoveItcPurchaseItemLtoSDone = 39,
        [FastEnumUtility.Label("ITCRes_MoveITCPurchaseItemLtoS_Failed", 0)]
        [FastEnumUtility.Label("Res Move Itc Purchase Item Lto SFailed", 1)]
        ResMoveItcPurchaseItemLtoSFailed = 40,
        [FastEnumUtility.Label("ITCRes_SetZzim_Done", 0)]
        [FastEnumUtility.Label("Res Set Zzim Done", 1)]
        ResSetZzimDone = 41,
        [FastEnumUtility.Label("ITCRes_SetZzim_Failed", 0)]
        [FastEnumUtility.Label("Res Set Zzim Failed", 1)]
        ResSetZzimFailed = 42,
        [FastEnumUtility.Label("ITCRes_DeleteZzim_Done", 0)]
        [FastEnumUtility.Label("Res Delete Zzim Done", 1)]
        ResDeleteZzimDone = 43,
        [FastEnumUtility.Label("ITCRes_DeleteZzim_Failed", 0)]
        [FastEnumUtility.Label("Res Delete Zzim Failed", 1)]
        ResDeleteZzimFailed = 44,
        [FastEnumUtility.Label("ITCRes_LoadWishSaleList_Done", 0)]
        [FastEnumUtility.Label("Res Load Wish Sale List Done", 1)]
        ResLoadWishSaleListDone = 45,
        [FastEnumUtility.Label("ITCRes_LoadWishSaleList_Failed", 0)]
        [FastEnumUtility.Label("Res Load Wish Sale List Failed", 1)]
        ResLoadWishSaleListFailed = 46,
        [FastEnumUtility.Label("ITCRes_BuyWish_Done", 0)]
        [FastEnumUtility.Label("Res Buy Wish Done", 1)]
        ResBuyWishDone = 47,
        [FastEnumUtility.Label("ITCRes_BuyWish_Failed", 0)]
        [FastEnumUtility.Label("Res Buy Wish Failed", 1)]
        ResBuyWishFailed = 48,
        [FastEnumUtility.Label("ITCRes_CancelWish_Done", 0)]
        [FastEnumUtility.Label("Res Cancel Wish Done", 1)]
        ResCancelWishDone = 49,
        [FastEnumUtility.Label("ITCRes_CancelWish_Failed", 0)]
        [FastEnumUtility.Label("Res Cancel Wish Failed", 1)]
        ResCancelWishFailed = 50,
        [FastEnumUtility.Label("ITCRes_BuyItem_Done", 0)]
        [FastEnumUtility.Label("Res Buy Item Done", 1)]
        ResBuyItemDone = 51,
        [FastEnumUtility.Label("ITCRes_BuyItem_Failed", 0)]
        [FastEnumUtility.Label("Res Buy Item Failed", 1)]
        ResBuyItemFailed = 52,
        [FastEnumUtility.Label("ITCRes_BuyZzimItem_Done", 0)]
        [FastEnumUtility.Label("Res Buy Zzim Item Done", 1)]
        ResBuyZzimItemDone = 53,
        [FastEnumUtility.Label("ITCRes_BuyZzimItem_Failed", 0)]
        [FastEnumUtility.Label("Res Buy Zzim Item Failed", 1)]
        ResBuyZzimItemFailed = 54,
        [FastEnumUtility.Label("ITCRes_RegisterBuyOrder_Done", 0)]
        [FastEnumUtility.Label("Res Register Buy Order Done", 1)]
        ResRegisterBuyOrderDone = 55,
        [FastEnumUtility.Label("ITCRes_RegisterBuyOrder_Failed", 0)]
        [FastEnumUtility.Label("Res Register Buy Order Failed", 1)]
        ResRegisterBuyOrderFailed = 56,
        [FastEnumUtility.Label("ITCRes_RegAuction_Done", 0)]
        [FastEnumUtility.Label("Res Reg Auction Done", 1)]
        ResRegAuctionDone = 57,
        [FastEnumUtility.Label("ITCRes_RegAuction_Failed", 0)]
        [FastEnumUtility.Label("Res Reg Auction Failed", 1)]
        ResRegAuctionFailed = 58,
        [FastEnumUtility.Label("ITCRes_BidAuction_Done", 0)]
        [FastEnumUtility.Label("Res Bid Auction Done", 1)]
        ResBidAuctionDone = 59,
        [FastEnumUtility.Label("ITCRes_BidAuction_Failed", 0)]
        [FastEnumUtility.Label("Res Bid Auction Failed", 1)]
        ResBidAuctionFailed = 60,
        [FastEnumUtility.Label("ITCRes_GetNotifyCancelWishResult", 0)]
        [FastEnumUtility.Label("Res Get Notify Cancel Wish Result", 1)]
        ResGetNotifyCancelWishResult = 61,
        [FastEnumUtility.Label("ITCRes_GetSuccessBidInfoResult", 0)]
        [FastEnumUtility.Label("Res Get Success Bid Info Result", 1)]
        ResGetSuccessBidInfoResult = 62,
        [FastEnumUtility.Label("Fail Reason Unknown", 1)]
        [FastEnumUtility.Label("ITCFailReason_Unknown", 0)]
        FailReasonUnknown = 63,
        [FastEnumUtility.Label("Fail Reason Timeout", 1)]
        [FastEnumUtility.Label("ITCFailReason_Timeout", 0)]
        FailReasonTimeout = 64,
        [FastEnumUtility.Label("Fail Reason Db Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_DBFailed", 0)]
        FailReasonDbFailed = 65,
        [FastEnumUtility.Label("Fail Reason No Remain Cash", 1)]
        [FastEnumUtility.Label("ITCFailReason_NoRemainCash", 0)]
        FailReasonNoRemainCash = 66,
        [FastEnumUtility.Label("Fail Reason No Remain Meso", 1)]
        [FastEnumUtility.Label("ITCFailReason_NoRemainMeso", 0)]
        FailReasonNoRemainMeso = 67,
        [FastEnumUtility.Label("Fail Reason Deduct Cash Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_DeductCashFailed", 0)]
        FailReasonDeductCashFailed = 68,
        [FastEnumUtility.Label("Fail Reason Cannot Find User", 1)]
        [FastEnumUtility.Label("ITCFailReason_CannotFindUser", 0)]
        FailReasonCannotFindUser = 69,
        [FastEnumUtility.Label("Fail Reason Save Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_SaveFailed", 0)]
        FailReasonSaveFailed = 70,
        [FastEnumUtility.Label("Fail Reason No Empty Pos", 1)]
        [FastEnumUtility.Label("ITCFailReason_NoEmptyPos", 0)]
        FailReasonNoEmptyPos = 71,
        [FastEnumUtility.Label("Fail Reason Slot Max Mismatch", 1)]
        [FastEnumUtility.Label("ITCFailReason_SlotMaxMismatch", 0)]
        FailReasonSlotMaxMismatch = 72,
        [FastEnumUtility.Label("Fail Reason First Loading Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_FirstLoadingFailed", 0)]
        FailReasonFirstLoadingFailed = 73,
        [FastEnumUtility.Label("Fail Reason Item Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_ItemFailed", 0)]
        FailReasonItemFailed = 74,
        [FastEnumUtility.Label("Fail Reason Cash Charge Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_CashChargeFailed", 0)]
        FailReasonCashChargeFailed = 75,
        [FastEnumUtility.Label("Fail Reason Cash Failed", 1)]
        [FastEnumUtility.Label("ITCFailReason_CashFailed", 0)]
        FailReasonCashFailed = 76,
        [FastEnumUtility.Label("Fail Reason Duplicate Bid", 1)]
        [FastEnumUtility.Label("ITCFailReason_DuplicateBid", 0)]
        FailReasonDuplicateBid = 77,
        [FastEnumUtility.Label("Fail Reason Already Bid", 1)]
        [FastEnumUtility.Label("ITCFailReason_AlreadyBid", 0)]
        FailReasonAlreadyBid = 78,
        [FastEnumUtility.Label("Fail Reason Cannot Register Item", 1)]
        [FastEnumUtility.Label("ITCFailReason_CannotRegisterItem", 0)]
        FailReasonCannotRegisterItem = 79,
        [FastEnumUtility.Label("Fail Reason Already Cancelled Or Sold Out", 1)]
        [FastEnumUtility.Label("ITCFailReason_AlreadyCancelled_or_SoldOut", 0)]
        FailReasonAlreadyCancelledOrSoldOut = 80,
        [FastEnumUtility.Label("Fail Reason Already Sold Out", 1)]
        [FastEnumUtility.Label("ITCFailReason_AlreadySoldOut", 0)]
        FailReasonAlreadySoldOut = 81,
        [FastEnumUtility.Label("Fail Reason Durability Item", 1)]
        [FastEnumUtility.Label("ITCFailReason_DurabilityItem", 0)]
        FailReasonDurabilityItem = 82,
        [FastEnumUtility.Label("Fail Reason Throwing Star", 1)]
        [FastEnumUtility.Label("ITCFailReason_ThrowingStar", 0)]
        FailReasonThrowingStar = 83,
        [FastEnumUtility.Label("Fail Reason Low Character Level", 1)]
        [FastEnumUtility.Label("ITCFailReason_LowCharacterLevel", 0)]
        FailReasonLowCharacterLevel = 84,
    }
    public enum ItemAttackSpeed : byte
    {
        Fastest = 2,
        Faster = 3,
        Fast = 4,
        Normal = 6,
        Slow = 8,
        Slower = 9,
        Slowest = 10,
    }
    [System.Flags]
    public enum ItemEnchantCategory : byte
    {
        None = 0,
        Normal = 1,
        Visitor = 2,
    }
    public enum ItemGrade : byte
    {
        [FastEnumUtility.Label("GRADE_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("GRADE_RARE", 0)]
        Rare = 1,
        [FastEnumUtility.Label("GRADE_EPIC", 0)]
        Epic = 2,
        [FastEnumUtility.Label("GRADE_UNIQUE", 0)]
        Unique = 3,
    }
    public enum ItemInventoryType : byte
    {
        [FastEnumUtility.Label("IT_EQUIP", 0)]
        Equip = 1,
        [FastEnumUtility.Label("IT_CONSUME", 0)]
        Consume = 2,
        [FastEnumUtility.Label("IT_INSTALL", 0)]
        Install = 3,
        [FastEnumUtility.Label("IT_ETC", 0)]
        Etc = 4,
        [FastEnumUtility.Label("IT_CASH", 0)]
        Cash = 5,
    }
    public enum ItemLogSource : byte
    {
        [FastEnumUtility.Label("ITEMLOG_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("ITEMLOG_GROUND", 0)]
        Ground = 1,
        [FastEnumUtility.Label("ITEMLOG_SHOP", 0)]
        Shop = 2,
        [FastEnumUtility.Label("Cash Shop", 1)]
        [FastEnumUtility.Label("ITEMLOG_CASHSHOP", 0)]
        CashShop = 3,
        [FastEnumUtility.Label("ITEMLOG_TRUNK", 0)]
        Trunk = 4,
        [FastEnumUtility.Label("ITEMLOG_EXPIRED", 0)]
        Expired = 5,
        [FastEnumUtility.Label("ITEMLOG_EXCHANGE", 0)]
        Exchange = 6,
        [FastEnumUtility.Label("ITEMLOG_PERSONALSHOP", 0)]
        [FastEnumUtility.Label("Personal Shop", 1)]
        PersonalShop = 7,
        [FastEnumUtility.Label("Entrusted Shop", 1)]
        [FastEnumUtility.Label("ITEMLOG_ENTRUSTEDSHOP", 0)]
        EntrustedShop = 8,
        [FastEnumUtility.Label("ITEMLOG_PARCEL", 0)]
        Parcel = 9,
        [FastEnumUtility.Label("ITEMLOG_QUEST", 0)]
        Quest = 10,
        [FastEnumUtility.Label("ITEMLOG_SCRIPT", 0)]
        Script = 11,
        [FastEnumUtility.Label("ITEMLOG_ADMIN", 0)]
        Admin = 12,
        [FastEnumUtility.Label("ITEMLOG_BRIDLE", 0)]
        Bridle = 13,
        [FastEnumUtility.Label("ITEMLOG_GACHAPON", 0)]
        Gachapon = 14,
        [FastEnumUtility.Label("ITEMLOG_TIMEOVER", 0)]
        [FastEnumUtility.Label("Time Over", 1)]
        TimeOver = 15,
        [FastEnumUtility.Label("Cursed Scroll", 1)]
        [FastEnumUtility.Label("ITEMLOG_CURSEDSCROLL", 0)]
        CursedScroll = 16,
        [FastEnumUtility.Label("ITEMLOG_LOTTERY", 0)]
        Lottery = 17,
        [FastEnumUtility.Label("ITEMLOG_WEDDING", 0)]
        Wedding = 18,
        [FastEnumUtility.Label("ITEMLOG_ITEMMAKE", 0)]
        [FastEnumUtility.Label("Item Make", 1)]
        ItemMake = 19,
        [FastEnumUtility.Label("ITEMLOG_SPECIALMEDAL", 0)]
        [FastEnumUtility.Label("Special Medal", 1)]
        SpecialMedal = 20,
        [FastEnumUtility.Label("Admin Shop", 1)]
        [FastEnumUtility.Label("ITEMLOG_ADMINSHOP", 0)]
        AdminShop = 21,
        [FastEnumUtility.Label("Event Reward", 1)]
        [FastEnumUtility.Label("ITEMLOG_EVENTREWARD", 0)]
        EventReward = 22,
        [FastEnumUtility.Label("ITEMLOG_REPLACE", 0)]
        Replace = 23,
        [FastEnumUtility.Label("Aran Tutorial", 1)]
        [FastEnumUtility.Label("ITEMLOG_ARANTUTORIAL", 0)]
        AranTutorial = 24,
    }
    public enum ItemLogType : byte
    {
        [FastEnumUtility.Label("Char To Char", 1)]
        [FastEnumUtility.Label("ITEMLOG_TYPE_CHARTOCHAR", 0)]
        CharToChar = 0,
        [FastEnumUtility.Label("Char To Spot", 1)]
        [FastEnumUtility.Label("ITEMLOG_TYPE_CHARTOSPOT", 0)]
        CharToSpot = 1,
        [FastEnumUtility.Label("ITEMLOG_TYPE_SPOTTOCHAR", 0)]
        [FastEnumUtility.Label("Spot To Char", 1)]
        SpotToChar = 2,
        [FastEnumUtility.Label("ITEMLOG_TYPE_DESTROY", 0)]
        Destroy = 3,
        [FastEnumUtility.Label("ITEMLOG_TYPE_CREATE", 0)]
        Create = 4,
        [FastEnumUtility.Label("ITEMLOG_TYPE_ITEMCOUNT", 0)]
        [FastEnumUtility.Label("Item Count", 1)]
        ItemCount = 99,
    }
    public enum ItemMakerCategory : ushort
    {
        [FastEnumUtility.Label("ITEM_CATEGORY_CONSUME", 0)]
        Consume = 200,
        [FastEnumUtility.Label("ITEM_CATEGORY_INSTALL", 0)]
        Install = 300,
        [FastEnumUtility.Label("ITEM_CATEGORY_ETC", 0)]
        Etc = 400,
        [FastEnumUtility.Label("ITEM_CATEGORY_STRENGTHEN_GEM", 0)]
        [FastEnumUtility.Label("Strengthen Gem", 1)]
        StrengthenGem = 425,
        [FastEnumUtility.Label("ITEM_CATEGORY_MONSTER_CRYSTAL", 0)]
        [FastEnumUtility.Label("Monster Crystal", 1)]
        MonsterCrystal = 426,
        [FastEnumUtility.Label("ITEM_CATEGORY_HIDDEN", 0)]
        Hidden = 999,
        [FastEnumUtility.Label("Equip Disassemble", 1)]
        [FastEnumUtility.Label("ITEM_CATEGORY_EQUIP_DISASSEMBLE", 0)]
        EquipDisassemble = 998,
        [FastEnumUtility.Label("ITEM_CATEGORY_CATALYST", 0)]
        Catalyst = 4130,
    }
    public enum ItemMakerResult : byte
    {
        [FastEnumUtility.Label("ITEM_MAKER_RESULT_SUCCESS", 0)]
        Success = 0,
        [FastEnumUtility.Label("ITEM_MAKER_RESULT_DESTROYED", 0)]
        Destroyed = 1,
        [FastEnumUtility.Label("Err Unknown", 1)]
        [FastEnumUtility.Label("ITEM_MAKER_ERR_UNKNOWN", 0)]
        ErrUnknown = 2,
        [FastEnumUtility.Label("Err Empty Slot", 1)]
        [FastEnumUtility.Label("ITEM_MAKER_ERR_EMPTYSLOT", 0)]
        ErrEmptySlot = 3,
        [FastEnumUtility.Label("Err Empty Slot Equip", 1)]
        [FastEnumUtility.Label("ITEM_MAKER_ERR_EMPTYSLOT_EQUIP", 0)]
        ErrEmptySlotEquip = 4,
        [FastEnumUtility.Label("Err Empty Slot Consume", 1)]
        [FastEnumUtility.Label("ITEM_MAKER_ERR_EMPTYSLOT_COMSUME", 0)]
        ErrEmptySlotConsume = 5,
        [FastEnumUtility.Label("Err Empty Slot Install", 1)]
        [FastEnumUtility.Label("ITEM_MAKER_ERR_EMPTYSLOT_INSTALL", 0)]
        ErrEmptySlotInstall = 6,
        [FastEnumUtility.Label("Err Empty Slot Etc", 1)]
        [FastEnumUtility.Label("ITEM_MAKER_ERR_EMPTYSLOT_ETC", 0)]
        ErrEmptySlotEtc = 7,
    }
    public enum ItemOptionType : byte
    {
        [FastEnumUtility.Label("Any Equip", 1)]
        AnyEquip = 0,
        [FastEnumUtility.Label("Any Weapon", 1)]
        AnyWeapon = 10,
        [FastEnumUtility.Label("Any Armor or Accessory", 1)]
        AnyArmorOrAccessory = 11,
        [FastEnumUtility.Label("Any Armor or Shield", 1)]
        AnyArmorOrShield = 20,
        [FastEnumUtility.Label("Any Accessory", 1)]
        AnyAccessory = 40,
        [FastEnumUtility.Label("Any Cap", 1)]
        AnyCap = 51,
        [FastEnumUtility.Label("Any Coat", 1)]
        AnyCoat = 52,
        [FastEnumUtility.Label("Any Pants", 1)]
        AnyPants = 53,
        [FastEnumUtility.Label("Any Gloves", 1)]
        AnyGloves = 54,
        [FastEnumUtility.Label("Any Shoe", 1)]
        AnyShoe = 55,
        [FastEnumUtility.Label("Any Accessory Not Belt", 1)]
        AnyAccessoryNotBelt = 90,
    }
    public enum ItemQuality : sbyte
    {
        [FastEnumUtility.Label("ITEMQUALITY_BAD", 0)]
        Bad = -1,
        [FastEnumUtility.Label("ITEMQUALITY_DEFAULT", 0)]
        Default = 0,
        [FastEnumUtility.Label("ITEMQUALITY_GOOD", 0)]
        Good = 1,
        [FastEnumUtility.Label("ITEMQUALITY_VERYGOOD", 0)]
        [FastEnumUtility.Label("Very Good", 1)]
        VeryGood = 2,
        [FastEnumUtility.Label("ITEMQUALITY_PREMIUM", 0)]
        Premium = 3,
        [FastEnumUtility.Label("ITEMQUALITY_EXCELLENT", 0)]
        Excellent = 4,
        [FastEnumUtility.Label("ITEMQUALITY_SPECIAL", 0)]
        Special = 5,
    }
    public enum ItemSlotType : byte
    {
        [FastEnumUtility.Label("ITEMSLOTTYPE_EQUIP", 0)]
        Equip = 1,
        [FastEnumUtility.Label("ITEMSLOTTYPE_BUNDLE", 0)]
        Bundle = 2,
        [FastEnumUtility.Label("ITEMSLOTTYPE_PET", 0)]
        Pet = 3,
    }
    public enum ItemTransformType : byte
    {
        [FastEnumUtility.Label("ITEM_TRANSFROM_TYPE_ERROR", 0)]
        Error = 0,
        [FastEnumUtility.Label("ITEM_TRANSFROM_TYPE_RANDOM", 0)]
        Random = 1,
        [FastEnumUtility.Label("ITEM_TRANSFROM_TYPE_NORMAL", 0)]
        Normal = 2,
        [FastEnumUtility.Label("ITEM_TRANSFROM_TYPE_VISITOR", 0)]
        Visitor = 10,
    }
    public enum ItemUpgradeLimitType : byte
    {
        [FastEnumUtility.Label("ITEM_UPGRADE_LIMIT_TYPE_ERROR", 0)]
        Error = 0,
        [FastEnumUtility.Label("ITEM_UPGRADE_LIMIT_TYPE_LIMITBYOHTERITEM", 0)]
        [FastEnumUtility.Label("Limit By Other Item", 1)]
        LimitByOtherItem = 1,
    }
    public enum ItemUseBlockReason : byte
    {
        [FastEnumUtility.Label("ITEM_USE_ALLOWED", 0)]
        Allowed = 0,
        [FastEnumUtility.Label("Blocked By Unknown", 1)]
        [FastEnumUtility.Label("ITEM_USE_BLOCKED_BY_UNKNOWN", 0)]
        BlockedByUnknown = 1,
        [FastEnumUtility.Label("Blocked By Level", 1)]
        [FastEnumUtility.Label("ITEM_USE_BLOCKED_BY_LEVEL", 0)]
        BlockedByLevel = 2,
        [FastEnumUtility.Label("Blocked By Map", 1)]
        [FastEnumUtility.Label("ITEM_USE_BLOCKED_BY_MAP", 0)]
        BlockedByMap = 3,
    }
    public enum ItemVariationOption : byte
    {
        [FastEnumUtility.Label("ITEMVARIATION_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("ITEMVARIATION_BETTER", 0)]
        Better = 1,
        [FastEnumUtility.Label("ITEMVARIATION_NORMAL", 0)]
        Normal = 2,
        [FastEnumUtility.Label("ITEMVARIATION_GREAT", 0)]
        Great = 3,
        [FastEnumUtility.Label("ITEMVARIATION_PERPECT", 0)]
        Perfect = 4,
        [FastEnumUtility.Label("ITEMVARIATION_GACHAPON", 0)]
        Gachapon = 5,
    }
    public enum Job : ushort
    {
        Beginner = 0,
        Warrior = 100,
        Fighter = 110,
        Crusader = 111,
        Hero = 112,
        Page = 120,
        [FastEnumUtility.Label("White Knight", 1)]
        WhiteKnight = 121,
        Paladin = 122,
        Spearman = 130,
        [FastEnumUtility.Label("Dragon Knight", 1)]
        DragonKnight = 131,
        [FastEnumUtility.Label("Dark Knight", 1)]
        DarkKnight = 132,
        Magician = 200,
        [FastEnumUtility.Label("Fire Poison Wizard", 1)]
        FpWizard = 210,
        [FastEnumUtility.Label("Fire Poison Mage", 1)]
        FpMage = 211,
        [FastEnumUtility.Label("Fire Poison Archmage", 1)]
        FpArchMage = 212,
        [FastEnumUtility.Label("Ice Lightning Wizard", 1)]
        IlWizard = 220,
        [FastEnumUtility.Label("Ice Lightning Mage", 1)]
        IlMage = 221,
        [FastEnumUtility.Label("Ice Lightning Archmage", 1)]
        IlArchMage = 222,
        Cleric = 230,
        Priest = 231,
        Bishop = 232,
        Archer = 300,
        Hunter = 310,
        Ranger = 311,
        [FastEnumUtility.Label("Bowmaster", 1)]
        BowMaster = 312,
        [FastEnumUtility.Label("Cross Bowman", 1)]
        CrossBowman = 320,
        Sniper = 321,
        Marksman = 322,
        Rogue = 400,
        Assassin = 410,
        Hermit = 411,
        [FastEnumUtility.Label("Night Lord", 1)]
        NightLord = 412,
        Bandit = 420,
        [FastEnumUtility.Label("Chief Bandit", 1)]
        ChiefBandit = 421,
        Shadower = 422,
        [FastEnumUtility.Label("Blade Recruit", 1)]
        BladeRecruit = 430,
        [FastEnumUtility.Label("Blade Acolyte", 1)]
        BladeAcolyte = 431,
        [FastEnumUtility.Label("Blade Specialist", 1)]
        BladeSpecialist = 432,
        [FastEnumUtility.Label("Blade Lord", 1)]
        BladeLord = 433,
        [FastEnumUtility.Label("Blade Master", 1)]
        BladeMaster = 434,
        Pirate = 500,
        Brawler = 510,
        Marauder = 511,
        Buccaneer = 512,
        Gunslinger = 520,
        Outlaw = 521,
        Corsair = 522,
        Manager = 800,
        [FastEnumUtility.Label("GM", 1)]
        Gm = 900,
        [FastEnumUtility.Label("Super GM", 1)]
        SuperGm = 910,
        [FastEnumUtility.Label("Riding Skills", 1)]
        RidingSkills = 8000,
        [FastEnumUtility.Label("Additional Skills", 1)]
        AdditionalSkills = 9000,
        Noblesse = 1000,
        [FastEnumUtility.Label("Dawn Warrior", 1)]
        DawnWarrior1 = 1100,
        [FastEnumUtility.Label("Dawn Warrior", 1)]
        DawnWarrior2 = 1110,
        [FastEnumUtility.Label("Dawn Warrior", 1)]
        DawnWarrior3 = 1111,
        [FastEnumUtility.Label("Blaze Wizard", 1)]
        BlazeWizard1 = 1200,
        [FastEnumUtility.Label("Blaze Wizard", 1)]
        BlazeWizard2 = 1210,
        [FastEnumUtility.Label("Blaze Wizard", 1)]
        BlazeWizard3 = 1211,
        [FastEnumUtility.Label("Wind Archer", 1)]
        WindArcher1 = 1300,
        [FastEnumUtility.Label("Wind Archer", 1)]
        WindArcher2 = 1310,
        [FastEnumUtility.Label("Wind Archer", 1)]
        WindArcher3 = 1311,
        [FastEnumUtility.Label("Night Walker", 1)]
        NightWalker1 = 1400,
        [FastEnumUtility.Label("Night Walker", 1)]
        NightWalker2 = 1410,
        [FastEnumUtility.Label("Night Walker", 1)]
        NightWalker3 = 1411,
        [FastEnumUtility.Label("Thunder Breaker", 1)]
        ThunderBreaker1 = 1500,
        [FastEnumUtility.Label("Thunder Breaker", 1)]
        ThunderBreaker2 = 1510,
        [FastEnumUtility.Label("Thunder Breaker", 1)]
        ThunderBreaker3 = 1511,
        [FastEnumUtility.Label("Aran", 1)]
        AranB = 2000,
        [FastEnumUtility.Label("Aran", 1)]
        Aran1 = 2100,
        [FastEnumUtility.Label("Aran", 1)]
        Aran2 = 2110,
        [FastEnumUtility.Label("Aran", 1)]
        Aran3 = 2111,
        [FastEnumUtility.Label("Aran", 1)]
        Aran4 = 2112,
        [FastEnumUtility.Label("Evan", 1)]
        EvanB = 2001,
        [FastEnumUtility.Label("Evan", 1)]
        Evan1 = 2200,
        [FastEnumUtility.Label("Evan", 1)]
        Evan2 = 2210,
        [FastEnumUtility.Label("Evan", 1)]
        Evan3 = 2211,
        [FastEnumUtility.Label("Evan", 1)]
        Evan4 = 2212,
        [FastEnumUtility.Label("Evan", 1)]
        Evan5 = 2213,
        [FastEnumUtility.Label("Evan", 1)]
        Evan6 = 2214,
        [FastEnumUtility.Label("Evan", 1)]
        Evan7 = 2215,
        [FastEnumUtility.Label("Evan", 1)]
        Evan8 = 2216,
        [FastEnumUtility.Label("Evan", 1)]
        Evan9 = 2217,
        [FastEnumUtility.Label("Evan", 1)]
        Evan10 = 2218,
        Citizen = 3000,
        [FastEnumUtility.Label("Battle Mage", 1)]
        BattleMage1 = 3200,
        [FastEnumUtility.Label("Battle Mage", 1)]
        BattleMage2 = 3210,
        [FastEnumUtility.Label("Battle Mage", 1)]
        BattleMage3 = 3211,
        [FastEnumUtility.Label("Battle Mage", 1)]
        BattleMage4 = 3212,
        [FastEnumUtility.Label("Wild Hunter", 1)]
        WildHunter1 = 3300,
        [FastEnumUtility.Label("Wild Hunter", 1)]
        WildHunter2 = 3310,
        [FastEnumUtility.Label("Wild Hunter", 1)]
        WildHunter3 = 3311,
        [FastEnumUtility.Label("Wild Hunter", 1)]
        WildHunter4 = 3312,
        [FastEnumUtility.Label("Mechanic", 1)]
        Mechanic1 = 3500,
        [FastEnumUtility.Label("Mechanic", 1)]
        Mechanic2 = 3510,
        [FastEnumUtility.Label("Mechanic", 1)]
        Mechanic3 = 3511,
        [FastEnumUtility.Label("Mechanic", 1)]
        Mechanic4 = 3512,
    }
    [System.Flags]
    public enum JobCategory : byte
    {
        None = 0,
        Warrior = 1,
        Magician = 2,
        Bowman = 4,
        Thief = 8,
        Pirate = 16,
    }
    public enum JobClass : byte
    {
        [FastEnumUtility.Label("JC_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("JC_FIGHTER", 0)]
        Fighter = 1,
        [FastEnumUtility.Label("JC_WIZARD", 0)]
        Wizard = 2,
        [FastEnumUtility.Label("JC_ARCHER", 0)]
        Archer = 3,
        [FastEnumUtility.Label("JC_THIEF", 0)]
        Thief = 4,
        [FastEnumUtility.Label("JC_PIRATE", 0)]
        Pirate = 5,
        [FastEnumUtility.Label("JC_NO_WO_ADMIN", 0)]
        [FastEnumUtility.Label("No Wo Admin", 1)]
        NoWoAdmin = 6,
        [FastEnumUtility.Label("JC_MANAGER", 0)]
        Manager = 8,
        [FastEnumUtility.Label("JC_ADMIN", 0)]
        Admin = 9,
        [FastEnumUtility.Label("JC_NO", 0)]
        [FastEnumUtility.Label("No Class", 1)]
        NoClass = 10,
        [FastEnumUtility.Label("JC_SOULMASTER", 0)]
        [FastEnumUtility.Label("Soul Master", 1)]
        SoulMaster = 11,
        [FastEnumUtility.Label("Flame Wizard", 1)]
        [FastEnumUtility.Label("JC_FLAMEWIZARD", 0)]
        FlameWizard = 12,
        [FastEnumUtility.Label("JC_WINDBREAKER", 0)]
        [FastEnumUtility.Label("Wind Breaker", 1)]
        WindBreaker = 13,
        [FastEnumUtility.Label("JC_NIGHTWALKER", 0)]
        [FastEnumUtility.Label("Night Walker", 1)]
        NightWalker = 14,
        [FastEnumUtility.Label("JC_STRIKER", 0)]
        Striker = 15,
        [FastEnumUtility.Label("JC_ARAN", 0)]
        Aran = 21,
        [FastEnumUtility.Label("JC_EVAN", 0)]
        Evan = 22,
        [FastEnumUtility.Label("JC_RES_WIZARD", 0)]
        [FastEnumUtility.Label("Res BMage", 1)]
        ResBMage = 32,
        [FastEnumUtility.Label("JC_RES_ARCHER", 0)]
        [FastEnumUtility.Label("Res Wild Hunt", 1)]
        ResWildHunt = 33,
        [FastEnumUtility.Label("JC_RES_PIRATE", 0)]
        [FastEnumUtility.Label("Res Mechanic", 1)]
        ResMechanic = 35,
        [FastEnumUtility.Label("Dual Blade", 1)]
        [FastEnumUtility.Label("JC_DUAL", 0)]
        DualBlade = 43,
    }
    public enum JobLineage : byte
    {
        [FastEnumUtility.Label("JOB_RACE_NORMAL", 0)]
        Explorer = 0,
        [FastEnumUtility.Label("JOB_RACE_CYGNUS", 0)]
        Cygnus = 1,
        [FastEnumUtility.Label("JOB_RACE_THIRD", 0)]
        Heroes = 2,
        [FastEnumUtility.Label("JOB_RACE_RESISTANCE", 0)]
        Resistance = 3,
    }
    public enum JobRace : byte
    {
        [FastEnumUtility.Label("JOB_RACE_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("JOB_RACE_CYGNUS", 0)]
        Cygnus = 1,
        [FastEnumUtility.Label("JOB_RACE_THIRD", 0)]
        Third = 2,
        [FastEnumUtility.Label("JOB_RACE_RESISTANCE", 0)]
        Resistance = 3,
    }
    public enum LayerBlendType : byte
    {
        [FastEnumUtility.Label("LB_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("LB_ADD", 0)]
        Add = 1,
        [FastEnumUtility.Label("LB_INVERSE", 0)]
        Inverse = 2,
        [FastEnumUtility.Label("LB_ISOLATED", 0)]
        Isolated = 4,
    }
    public enum LeaveResult : byte
    {
        [FastEnumUtility.Label("LR_None", 0)]
        None = 0,
        [FastEnumUtility.Label("Game Server", 1)]
        [FastEnumUtility.Label("LR_GameSvr", 0)]
        GameServer = 1,
        [FastEnumUtility.Label("LR_ShopSvr", 0)]
        [FastEnumUtility.Label("Shop Server", 1)]
        ShopServer = 2,
        [FastEnumUtility.Label("LR_OtherChannel", 0)]
        [FastEnumUtility.Label("Other Channel", 1)]
        OtherChannel = 3,
        [FastEnumUtility.Label("LR_Admin", 0)]
        Admin = 4,
    }
    public enum LifeNameTagType : ushort
    {
        [FastEnumUtility.Label("LIFE_NAMETAG_CHARACTER", 0)]
        Character = 1000,
        [FastEnumUtility.Label("LIFE_NAMETAG_NPC_TITLE", 0)]
        [FastEnumUtility.Label("Npc Title", 1)]
        NpcTitle = 1001,
        [FastEnumUtility.Label("LIFE_NAMETAG_NPC_FUNC", 0)]
        [FastEnumUtility.Label("Npc Func", 1)]
        NpcFunc = 1002,
        [FastEnumUtility.Label("LIFE_NAMETAG_PET", 0)]
        Pet = 1003,
        [FastEnumUtility.Label("LIFE_NAMETAG_GUILD", 0)]
        Guild = 1004,
        [FastEnumUtility.Label("Battle Team", 1)]
        [FastEnumUtility.Label("LIFE_NAMETAG_BATTLETEAM", 0)]
        BattleTeam = 1005,
        [FastEnumUtility.Label("LIFE_NAMETAG_MEDAL", 0)]
        Medal = 1006,
        [FastEnumUtility.Label("LIFE_NAMETAG_PARTYRAID", 0)]
        [FastEnumUtility.Label("Party Raid", 1)]
        PartyRaid = 1007,
    }
    public enum LocaleId
    {
        [FastEnumUtility.Label("kLocaleID_Null", 0)]
        Null = 0,
        [FastEnumUtility.Label("kLocaleID_KR", 0)]
        Kr = 1,
        [FastEnumUtility.Label("kLocaleID_JP", 0)]
        Jp = 256,
        [FastEnumUtility.Label("kLocaleID_CN", 0)]
        Cn = 257,
        [FastEnumUtility.Label("kLocaleID_TW", 0)]
        Tw = 258,
        [FastEnumUtility.Label("kLocaleID_TH", 0)]
        Th = 259,
        [FastEnumUtility.Label("Cn Cnc", 1)]
        [FastEnumUtility.Label("kLocaleID_CN_CNC", 0)]
        CnCnc = 273,
        [FastEnumUtility.Label("Cn Ct", 1)]
        [FastEnumUtility.Label("kLocaleID_CN_CT", 0)]
        CnCt = 274,
        [FastEnumUtility.Label("kLocaleID_US", 0)]
        Us = 512,
        [FastEnumUtility.Label("kLocaleID_EU", 0)]
        Eu = 768,
        [FastEnumUtility.Label("Kr Test", 1)]
        [FastEnumUtility.Label("kLocaleID_KR_Test", 0)]
        KrTest = 268435457,
    }
    public enum LoginResult : byte
    {
        Success = 0,
        [FastEnumUtility.Label("Temp Blocked", 1)]
        TempBlocked = 1,
        Blocked = 2,
        Abandoned = 3,
        [FastEnumUtility.Label("Incorrect Password", 1)]
        IncorrectPassword = 4,
        [FastEnumUtility.Label("Not Registered", 1)]
        NotRegistered = 5,
        [FastEnumUtility.Label("DB Fail", 1)]
        DBFail = 6,
        [FastEnumUtility.Label("Already Connected", 1)]
        AlreadyConnected = 7,
        [FastEnumUtility.Label("Not Connectable World", 1)]
        NotConnectableWorld = 8,
        Unknown = 9,
        Timeout = 10,
        [FastEnumUtility.Label("Not Adult", 1)]
        NotAdult = 11,
        [FastEnumUtility.Label("Auth Fail", 1)]
        AuthFail = 12,
        [FastEnumUtility.Label("Impossible IP", 1)]
        ImpossibleIP = 13,
        [FastEnumUtility.Label("Not Authorized Nexon ID", 1)]
        NotAuthorizedNexonID = 14,
        [FastEnumUtility.Label("No Nexon ID", 1)]
        NoNexonID = 15,
        [FastEnumUtility.Label("Not Authorized", 1)]
        NotAuthorized = 16,
        [FastEnumUtility.Label("Invalid Region Info", 1)]
        InvalidRegionInfo = 17,
        [FastEnumUtility.Label("Invalid Birth Date", 1)]
        InvalidBirthDate = 18,
        [FastEnumUtility.Label("Passport Suspended", 1)]
        PassportSuspended = 19,
        [FastEnumUtility.Label("Incorrect SPW", 1)]
        IncorrectSPW = 20,
        [FastEnumUtility.Label("Web Auth Needed", 1)]
        WebAuthNeeded = 21,
        [FastEnumUtility.Label("Same Password And SPW", 1)]
        SamePasswordAndSPW = 22,
        [FastEnumUtility.Label("Same Pincode And SPW", 1)]
        SamePincodeAndSPW = 23,
        [FastEnumUtility.Label("Not Agreed EULA", 1)]
        NotAgreedEULA = 24,
        [FastEnumUtility.Label("Register Limited IP", 1)]
        RegisterLimitedIP = 25,
        [FastEnumUtility.Label("Requested Character Transfer", 1)]
        RequestedCharacterTransfer = 26,
        [FastEnumUtility.Label("Cash User Cannot Use Simple Client", 1)]
        CashUserCannotUseSimpleClient = 27,
        [FastEnumUtility.Label("Delete Character Failed On Family", 1)]
        DeleteCharacterFailedOnFamily = 29,
        [FastEnumUtility.Label("Invalid Character Name", 1)]
        InvalidCharacterName = 30,
        [FastEnumUtility.Label("Incorrect SSN", 1)]
        IncorrectSSN = 31,
        [FastEnumUtility.Label("SSN Confirm Failed", 1)]
        SSNConfirmFailed = 32,
        [FastEnumUtility.Label("SSN Not Confirmed", 1)]
        SSNNotConfirmed = 33,
        [FastEnumUtility.Label("World Too Busy", 1)]
        WorldTooBusy = 34,
        [FastEnumUtility.Label("OTP Reissuing", 1)]
        OTPReissuing = 35,
        [FastEnumUtility.Label("OTP Info Not Exist", 1)]
        OTPInfoNotExist = 36,
        [FastEnumUtility.Label("Proc Fail", 1)]
        ProcFail = 255,
    }
    public enum LoginState : byte
    {
        [FastEnumUtility.Label("LS_TITLE", 0)]
        Title = 0,
        [FastEnumUtility.Label("LS_WORLDSELECT", 0)]
        [FastEnumUtility.Label("World Select", 1)]
        WorldSelect = 1,
        [FastEnumUtility.Label("Char Select", 1)]
        [FastEnumUtility.Label("LS_CHARSELECT", 0)]
        CharSelect = 2,
        [FastEnumUtility.Label("LS_NEWCHAR_RACE", 0)]
        [FastEnumUtility.Label("New Char Race", 1)]
        NewCharRace = 3,
        [FastEnumUtility.Label("LS_NEWCHAR_NAME", 0)]
        [FastEnumUtility.Label("New Char Name", 1)]
        NewCharName = 4,
        [FastEnumUtility.Label("LS_VIEWALLCHAR", 0)]
        [FastEnumUtility.Label("View All Char", 1)]
        ViewAllChar = 5,
    }
    public enum MacroTargetType : byte
    {
        [FastEnumUtility.Label("Local User", 1)]
        [FastEnumUtility.Label("TARGETTYPE_LOCALUSER", 0)]
        LocalUser = 0,
        [FastEnumUtility.Label("Nearest Mob", 1)]
        [FastEnumUtility.Label("TAEGETTYPE_NEAREASTMOB", 0)]
        NearestMob = 1,
        [FastEnumUtility.Label("Dazzled Mob", 1)]
        [FastEnumUtility.Label("TARGETTYPE_DAZZLEDMOB", 0)]
        DazzledMob = 2,
        [FastEnumUtility.Label("TARGETTYPE_CHASING", 0)]
        Chasing = 3,
        [FastEnumUtility.Label("TARGETTYPE_SELF", 0)]
        Self = 4,
    }
    public enum MakeoverItemType : byte
    {
        [FastEnumUtility.Label("MKT_FACE", 0)]
        Face = 0,
        [FastEnumUtility.Label("MKT_HAIR", 0)]
        Hair = 1,
        [FastEnumUtility.Label("Hair Color", 1)]
        [FastEnumUtility.Label("MKT_HAIRCOLOR", 0)]
        HairColor = 2,
        [FastEnumUtility.Label("MKT_SKIN", 0)]
        Skin = 3,
        [FastEnumUtility.Label("MKT_CLOTHES", 0)]
        Clothes = 4,
        [FastEnumUtility.Label("MKT_PANTS", 0)]
        Pants = 5,
        [FastEnumUtility.Label("MKT_SHOES", 0)]
        Shoes = 6,
        [FastEnumUtility.Label("MKT_WEAPON", 0)]
        Weapon = 7,
        [FastEnumUtility.Label("MKT_GENDER", 0)]
        Gender = 8,
    }
    [System.Flags]
    public enum MapFieldLimit : uint
    {
        None = 0u,
        [FastEnumUtility.Label("No Movement Skills", 1)]
        MoveLimit = 1u,
        [FastEnumUtility.Label("No Skills", 1)]
        SkillLimit = 2u,
        [FastEnumUtility.Label("No Summons", 1)]
        SummonLimit = 4u,
        [FastEnumUtility.Label("No Mystic Door", 1)]
        MysticDoorLimit = 8u,
        [FastEnumUtility.Label("No Map Change", 1)]
        MigrateLimit = 16u,
        [FastEnumUtility.Label("No Portal Scrolls", 1)]
        PortalScrollLimit = 32u,
        [FastEnumUtility.Label("No Teleport Rock", 1)]
        TeleportItemLimit = 64u,
        [FastEnumUtility.Label("No Mini-Games", 1)]
        MiniGameLimit = 128u,
        [FastEnumUtility.Label("No Specific Portal Scrolls", 1)]
        SpecificPortalScrollLimit = 256u,
        [FastEnumUtility.Label("No Taming Mobs / Mounts", 1)]
        TamingMobLimit = 512u,
        [FastEnumUtility.Label("No Stat-Change Items", 1)]
        StatChangeItemConsumeLimit = 1024u,
        [FastEnumUtility.Label("No Party Boss Change", 1)]
        PartyBossChangeLimit = 2048u,
        [FastEnumUtility.Label("Unlimited Mob Spawns", 1)]
        NoMobCapacityLimit = 4096u,
        [FastEnumUtility.Label("No Wedding Invitation", 1)]
        WeddingInvitationLimit = 8192u,
        [FastEnumUtility.Label("No Cash Weather", 1)]
        CashWeatherConsumeLimit = 16384u,
        [FastEnumUtility.Label("No Pets", 1)]
        NoPet = 32768u,
        [FastEnumUtility.Label("Anti-Macro", 1)]
        AntiMacroLimit = 65536u,
        [FastEnumUtility.Label("No Fall Down", 1)]
        FallDownLimit = 131072u,
        [FastEnumUtility.Label("No Summon NPC", 1)]
        SummonNpcLimit = 262144u,
        [FastEnumUtility.Label("No EXP Loss", 1)]
        NoExpDecrease = 524288u,
        [FastEnumUtility.Label("No Falling Damage", 1)]
        NoDamageOnFalling = 1048576u,
        [FastEnumUtility.Label("No Parcel Open", 1)]
        ParcelOpenLimit = 2097152u,
        [FastEnumUtility.Label("No Item Drop", 1)]
        DropLimit = 4194304u,
        [FastEnumUtility.Label("No Rocket Booster", 1)]
        RocketBoosterLimit = 8388608u,
    }
    public enum MapFieldType : ushort
    {
        [FastEnumUtility.Label("Normal", 0)]
        Default = 0,
        Snowball = 1,
        [FastEnumUtility.Label("Continent Move (Boat)", 0)]
        ContiMove = 2,
        Tournament = 3,
        Coconut = 4,
        [FastEnumUtility.Label("OX Quiz", 0)]
        OxQuiz = 5,
        [FastEnumUtility.Label("Personal Time Limit", 0)]
        PersonalTimeLimit = 6,
        [FastEnumUtility.Label("Waiting Room", 0)]
        WaitingRoom = 7,
        [FastEnumUtility.Label("Guild Boss", 0)]
        GuildBoss = 8,
        [FastEnumUtility.Label("Limited View", 0)]
        LimitedView = 9,
        [FastEnumUtility.Label("Monster Carnival", 0)]
        MonsterCarnival = 10,
        [FastEnumUtility.Label("Monster Carnival (Revive)", 0)]
        MonsterCarnivalRevive = 11,
        Zakum = 12,
        [FastEnumUtility.Label("Ariant Arena", 0)]
        AriantArena = 13,
        [FastEnumUtility.Label("Mu Lung Dojo", 0)]
        Dojang = 14,
        [FastEnumUtility.Label("Monster Carnival S2", 0)]
        MonsterCarnivalS2 = 15,
        [FastEnumUtility.Label("Monster Carnival Lobby", 0)]
        MonsterCarnivalWaitingRoom = 16,
        [FastEnumUtility.Label("Cookie House", 0)]
        CookieHouse = 17,
        Balrog = 18,
        Battlefield = 19,
        [FastEnumUtility.Label("Space Gaga", 0)]
        SpaceGaga = 20,
        [FastEnumUtility.Label("Witch Tower", 0)]
        Witchtower = 21,
        [FastEnumUtility.Label("Aran Tutorial", 0)]
        AranTutorial = 22,
        Massacre = 23,
        [FastEnumUtility.Label("Massacre Result", 0)]
        MassacreResult = 24,
        [FastEnumUtility.Label("Party Raid", 0)]
        PartyRaid = 25,
        [FastEnumUtility.Label("Party Raid (Boss)", 0)]
        PartyRaidBoss = 26,
        [FastEnumUtility.Label("Party Raid Result", 0)]
        PartyRaidResult = 27,
        [FastEnumUtility.Label("No Dragon", 0)]
        NoDragon = 28,
        [FastEnumUtility.Label("Dynamic Foothold", 0)]
        DynamicFoothold = 29,
        Escort = 30,
        [FastEnumUtility.Label("Escort Result", 0)]
        EscortResult = 31,
        [FastEnumUtility.Label("Hunting Adballoon", 0)]
        HuntingAdballoon = 32,
        [FastEnumUtility.Label("Chaos Zakum", 0)]
        ChaosZakum = 33,
        [FastEnumUtility.Label("Kill Count", 0)]
        KillCount = 34,
        Cube = 35,
        Wedding = 60,
        [FastEnumUtility.Label("Wedding Photo", 0)]
        WeddingPhoto = 61,
        Tutorial = 82,
        [FastEnumUtility.Label("Protect Snowman", 0)]
        ProtectSnowman = 1000,
        [FastEnumUtility.Label("Showa Bath", 0)]
        ShowaBath = 1001,
        Pachinko = 1003,
        [FastEnumUtility.Label("Boat Race", 0)]
        BoatRace = 1004,
        [FastEnumUtility.Label("Boat Race 2", 0)]
        BoatRace2 = 1005,
        [FastEnumUtility.Label("Language School", 0)]
        LanguageSchool = 1006,
        Fishing = 1007,
        [FastEnumUtility.Label("Fishing King", 0)]
        FishingKing = 1008,
        [FastEnumUtility.Label("CN Wedding", 0)]
        CnWedding = 1009,
        [FastEnumUtility.Label("CN PvP (Single Mob)", 0)]
        CnPvpShootingOneMob = 1010,
        [FastEnumUtility.Label("CN PvP (Many Mobs)", 0)]
        CnPvpShootingManyMob = 1011,
        [FastEnumUtility.Label("CN PvP Jump", 0)]
        CnPvpJump = 1012,
        [FastEnumUtility.Label("Horntail", 0)]
        Hontail = 1013,
        [FastEnumUtility.Label("NLC Party Quest", 0)]
        NlcPq = 1014,
        [FastEnumUtility.Label("Tokyo Boss", 0)]
        TokyoBoss = 1015,
        [FastEnumUtility.Label("Tokyo Boss (Party)", 0)]
        TokyoBossParty = 1016,
        [FastEnumUtility.Label("Entrusted Fishing", 0)]
        EntrustedFishing = 1017,
        [FastEnumUtility.Label("Punch Punch", 0)]
        PunchPunch = 1018,
    }
    public enum MapPortalType : byte
    {
        [FastEnumUtility.Label("PORTALTYPE_STARTPOINT", 0)]
        [FastEnumUtility.Label("Start Point", 1)]
        StartPoint = 0,
        [FastEnumUtility.Label("PORTALTYPE_INVISIBLE", 0)]
        Invisible = 1,
        [FastEnumUtility.Label("PORTALTYPE_VISIBLE", 0)]
        Visible = 2,
        [FastEnumUtility.Label("PORTALTYPE_COLLISION", 0)]
        Collision = 3,
        [FastEnumUtility.Label("PORTALTYPE_CHANGABLE", 0)]
        Changeable = 4,
        [FastEnumUtility.Label("Changeable Invisible", 1)]
        [FastEnumUtility.Label("PORTALTYPE_CHANGABLE_INVISIBLE", 0)]
        ChangeableInvisible = 5,
        [FastEnumUtility.Label("PORTALTYPE_TOWNPORTAL_POINT", 0)]
        [FastEnumUtility.Label("Town Portal Point", 1)]
        TownPortalPoint = 6,
        [FastEnumUtility.Label("PORTALTYPE_SCRIPT", 0)]
        Script = 7,
        [FastEnumUtility.Label("PORTALTYPE_SCRIPT_INVISIBLE", 0)]
        [FastEnumUtility.Label("Script Invisible", 1)]
        ScriptInvisible = 8,
        [FastEnumUtility.Label("Collision Script", 1)]
        [FastEnumUtility.Label("PORTALTYPE_COLLISION_SCRIPT", 0)]
        CollisionScript = 9,
        [FastEnumUtility.Label("PORTALTYPE_HIDDEN", 0)]
        Hidden = 10,
        [FastEnumUtility.Label("PORTALTYPE_SCRIPT_HIDDEN", 0)]
        [FastEnumUtility.Label("Script Hidden", 1)]
        ScriptHidden = 11,
        [FastEnumUtility.Label("Collision Vertical Jump", 1)]
        [FastEnumUtility.Label("PORTALTYPE_COLLISION_VERTICAL_JUMP", 0)]
        CollisionVerticalJump = 12,
        [FastEnumUtility.Label("Collision Custom Impact", 1)]
        [FastEnumUtility.Label("PORTALTYPE_COLLISION_CUSTOM_IMPACT", 0)]
        CollisionCustomImpact = 13,
    }
    public enum MapTransferOperation : byte
    {
        [FastEnumUtility.Label("MapTransferReq_DeleteList", 0)]
        [FastEnumUtility.Label("Req Delete List", 1)]
        ReqDeleteList = 0,
        [FastEnumUtility.Label("MapTransferReq_RegisterList", 0)]
        [FastEnumUtility.Label("Req Register List", 1)]
        ReqRegisterList = 1,
        [FastEnumUtility.Label("MapTransferRes_DeleteList", 0)]
        [FastEnumUtility.Label("Res Delete List", 1)]
        ResDeleteList = 2,
        [FastEnumUtility.Label("MapTransferRes_RegisterList", 0)]
        [FastEnumUtility.Label("Res Register List", 1)]
        ResRegisterList = 3,
        [FastEnumUtility.Label("MapTransferRes_Use", 0)]
        [FastEnumUtility.Label("Res Use", 1)]
        ResUse = 4,
        [FastEnumUtility.Label("MapTransferRes_Unknown", 0)]
        [FastEnumUtility.Label("Res Unknown", 1)]
        ResUnknown = 5,
        [FastEnumUtility.Label("MapTransferRes_TargetNotExist", 0)]
        [FastEnumUtility.Label("Res Target Not Exist", 1)]
        ResTargetNotExist = 6,
        [FastEnumUtility.Label("MapTransferRes_TargetDied", 0)]
        [FastEnumUtility.Label("Res Target Died", 1)]
        ResTargetDied = 7,
        [FastEnumUtility.Label("MapTransferRes_NotAllowed", 0)]
        [FastEnumUtility.Label("Res Not Allowed", 1)]
        ResNotAllowed = 8,
        [FastEnumUtility.Label("MapTransferRes_AlreadyInMap", 0)]
        [FastEnumUtility.Label("Res Already In Map", 1)]
        ResAlreadyInMap = 9,
        [FastEnumUtility.Label("MapTransferRes_RegisterFail", 0)]
        [FastEnumUtility.Label("Res Register Fail", 1)]
        ResRegisterFail = 10,
        [FastEnumUtility.Label("MapTransferRes_LevelLimit", 0)]
        [FastEnumUtility.Label("Res Level Limit", 1)]
        ResLevelLimit = 11,
    }
    public enum MapleTvResultCode
    {
        [FastEnumUtility.Label("MapleTVResCode_Fail", 0)]
        Fail = -1,
        [FastEnumUtility.Label("MapleTVResCode_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("Is Not Gm", 1)]
        [FastEnumUtility.Label("MapleTVResCode_IsNotGM", 0)]
        IsNotGm = 1,
        [FastEnumUtility.Label("MapleTVResCode_WrongUser", 0)]
        [FastEnumUtility.Label("Wrong User", 1)]
        WrongUser = 2,
        [FastEnumUtility.Label("MapleTVResCode_TimeOut", 0)]
        Timeout = 3,
    }
    public enum MaritalStatus : byte
    {
        [FastEnumUtility.Label("MS_SINGLE", 0)]
        Single = 0,
        [FastEnumUtility.Label("MS_ENGAGED", 0)]
        Engaged = 1,
        [FastEnumUtility.Label("MS_RESERVED", 0)]
        Reserved = 2,
        [FastEnumUtility.Label("MS_MARRIED", 0)]
        Married = 3,
    }
    public enum MarriageOperation : byte
    {
        [FastEnumUtility.Label("MarriageReq_Propose", 0)]
        [FastEnumUtility.Label("Req Propose", 1)]
        ReqPropose = 0,
        [FastEnumUtility.Label("MarriageReq_CancelPropose", 0)]
        [FastEnumUtility.Label("Req Cancel Propose", 1)]
        ReqCancelPropose = 1,
        [FastEnumUtility.Label("MarriageReq_Accept", 0)]
        [FastEnumUtility.Label("Req Accept", 1)]
        ReqAccept = 2,
        [FastEnumUtility.Label("MarriageReq_BreakUp", 0)]
        [FastEnumUtility.Label("Req Break Up", 1)]
        ReqBreakUp = 3,
        [FastEnumUtility.Label("MarriageReq_Reserve", 0)]
        [FastEnumUtility.Label("Req Reserve", 1)]
        ReqReserve = 4,
        [FastEnumUtility.Label("MarriageReq_Invite", 0)]
        [FastEnumUtility.Label("Req Invite", 1)]
        ReqInvite = 5,
        [FastEnumUtility.Label("MarriageReq_Invitation", 0)]
        [FastEnumUtility.Label("Req Invitation", 1)]
        ReqInvitation = 6,
        [FastEnumUtility.Label("MarriageReq_Marry", 0)]
        [FastEnumUtility.Label("Req Marry", 1)]
        ReqMarry = 7,
        [FastEnumUtility.Label("MarriageReq_Divorce", 0)]
        [FastEnumUtility.Label("Req Divorce", 1)]
        ReqDivorce = 8,
        [FastEnumUtility.Label("MarriageReq_WishList", 0)]
        [FastEnumUtility.Label("Req Wish List", 1)]
        ReqWishList = 9,
        [FastEnumUtility.Label("MarriageReq_LoadReservation", 0)]
        [FastEnumUtility.Label("Req Load Reservation", 1)]
        ReqLoadReservation = 10,
        [FastEnumUtility.Label("MarriageRes_Engaged", 0)]
        [FastEnumUtility.Label("Res Engaged", 1)]
        ResEngaged = 11,
        [FastEnumUtility.Label("MarriageRes_Married", 0)]
        [FastEnumUtility.Label("Res Married", 1)]
        ResMarried = 12,
        [FastEnumUtility.Label("MarriageRes_BrokeUp", 0)]
        [FastEnumUtility.Label("Res Broke Up", 1)]
        ResBrokeUp = 13,
        [FastEnumUtility.Label("MarriageRes_Divorced", 0)]
        [FastEnumUtility.Label("Res Divorced", 1)]
        ResDivorced = 14,
        [FastEnumUtility.Label("MarriageRes_ShowInvitation", 0)]
        [FastEnumUtility.Label("Res Show Invitation", 1)]
        ResShowInvitation = 15,
        [FastEnumUtility.Label("MarriageRes_ReservationDone", 0)]
        [FastEnumUtility.Label("Res Reservation Done", 1)]
        ResReservationDone = 16,
        [FastEnumUtility.Label("MarriageRes_LoadReservationDone", 0)]
        [FastEnumUtility.Label("Res Load Reservation Done", 1)]
        ResLoadReservationDone = 17,
        [FastEnumUtility.Label("MarriageRes_WrongName", 0)]
        [FastEnumUtility.Label("Res Wrong Name", 1)]
        ResWrongName = 18,
        [FastEnumUtility.Label("MarriageRes_NotSameMap", 0)]
        [FastEnumUtility.Label("Res Not Same Map", 1)]
        ResNotSameMap = 19,
        [FastEnumUtility.Label("MarriageRes_RequesterNoEmptySlot", 0)]
        [FastEnumUtility.Label("Res Requester No Empty Slot", 1)]
        ResRequesterNoEmptySlot = 20,
        [FastEnumUtility.Label("MarriageRes_TargetNoEmptySlot", 0)]
        [FastEnumUtility.Label("Res Target No Empty Slot", 1)]
        ResTargetNoEmptySlot = 21,
        [FastEnumUtility.Label("MarriageRes_WrongGender", 0)]
        [FastEnumUtility.Label("Res Wrong Gender", 1)]
        ResWrongGender = 22,
        [FastEnumUtility.Label("MarriageRes_RequesterAlreadyEngaged", 0)]
        [FastEnumUtility.Label("Res Requester Already Engaged", 1)]
        ResRequesterAlreadyEngaged = 23,
        [FastEnumUtility.Label("MarriageRes_TargetAlreadyEngaged", 0)]
        [FastEnumUtility.Label("Res Target Already Engaged", 1)]
        ResTargetAlreadyEngaged = 24,
        [FastEnumUtility.Label("MarriageRes_RequesterAlreadyMarried", 0)]
        [FastEnumUtility.Label("Res Requester Already Married", 1)]
        ResRequesterAlreadyMarried = 25,
        [FastEnumUtility.Label("MarriageRes_TargetAlreadyMarried", 0)]
        [FastEnumUtility.Label("Res Target Already Married", 1)]
        ResTargetAlreadyMarried = 26,
        [FastEnumUtility.Label("MarriageRes_RequesterAlreadyInProcess", 0)]
        [FastEnumUtility.Label("Res Requester Already In Process", 1)]
        ResRequesterAlreadyInProcess = 27,
        [FastEnumUtility.Label("MarriageRes_TargetAlreadyInProcess", 0)]
        [FastEnumUtility.Label("Res Target Already In Process", 1)]
        ResTargetAlreadyInProcess = 28,
        [FastEnumUtility.Label("MarriageRes_RequesterCanceled", 0)]
        [FastEnumUtility.Label("Res Requester Canceled", 1)]
        ResRequesterCanceled = 29,
        [FastEnumUtility.Label("MarriageRes_TargetRefused", 0)]
        [FastEnumUtility.Label("Res Target Refused", 1)]
        ResTargetRefused = 30,
        [FastEnumUtility.Label("MarriageRes_ReservationCanceled", 0)]
        [FastEnumUtility.Label("Res Reservation Canceled", 1)]
        ResReservationCanceled = 31,
        [FastEnumUtility.Label("MarriageRes_CantBreakupAfterReserve", 0)]
        [FastEnumUtility.Label("Res Cant Breakup After Reserve", 1)]
        ResCantBreakupAfterReserve = 32,
        [FastEnumUtility.Label("MarriageRes_NotEnoughMoney", 0)]
        [FastEnumUtility.Label("Res Not Enough Money", 1)]
        ResNotEnoughMoney = 33,
        [FastEnumUtility.Label("MarriageRes_WrongMarriageNo", 0)]
        [FastEnumUtility.Label("Res Wrong Marriage No", 1)]
        ResWrongMarriageNo = 34,
        [FastEnumUtility.Label("MarriageRes_ReservationFail", 0)]
        [FastEnumUtility.Label("Res Reservation Fail", 1)]
        ResReservationFail = 35,
        [FastEnumUtility.Label("MarriageRes_Unknown", 0)]
        [FastEnumUtility.Label("Res Unknown", 1)]
        ResUnknown = 36,
    }
    public enum MedalQuestCategory : byte
    {
        [FastEnumUtility.Label("MEDAL_QUEST_JOB", 0)]
        Job = 0,
        [FastEnumUtility.Label("MEDAL_QUEST_NORMAL", 0)]
        Normal = 1,
        [FastEnumUtility.Label("MEDAL_QUEST_CHALLENGE", 0)]
        Challenge = 2,
        [FastEnumUtility.Label("MEDAL_QUEST_EVENT", 0)]
        Event = 3,
    }
    public enum MedalQuestState : byte
    {
        [FastEnumUtility.Label("MEDAL_QUEST_STATE_PERFORM", 0)]
        Perform = 0,
        [FastEnumUtility.Label("MEDAL_QUEST_STATE_OBTAINABLE", 0)]
        Obtainable = 1,
        [FastEnumUtility.Label("MEDAL_QUEST_STATE_NO", 0)]
        No = 2,
        [FastEnumUtility.Label("MEDAL_QUEST_STATE_COMPLETE", 0)]
        Complete = 3,
    }
    public enum MemoNotificationType : byte
    {
        [FastEnumUtility.Label("MEMO_DEFAULT", 0)]
        Default = 0,
        [FastEnumUtility.Label("Inc Pop", 1)]
        [FastEnumUtility.Label("MEMO_INCPOP", 0)]
        IncPop = 1,
        [FastEnumUtility.Label("MEMO_NOTIFY_RECEIPT_GIFT", 0)]
        [FastEnumUtility.Label("Notify Receipt Gift", 1)]
        NotifyReceiptGift = 2,
        [FastEnumUtility.Label("MEMO_INVITATION", 0)]
        Invitation = 3,
        [FastEnumUtility.Label("Broke Up", 1)]
        [FastEnumUtility.Label("MEMO_BROKEUP", 0)]
        BrokeUp = 4,
        [FastEnumUtility.Label("MEMO_DIVORCED", 0)]
        Divorced = 5,
        [FastEnumUtility.Label("From Gm", 1)]
        [FastEnumUtility.Label("MEMO_FROMGM", 0)]
        FromGm = 6,
    }
    public enum MemoOperation : byte
    {
        [FastEnumUtility.Label("MemoReq_Send", 0)]
        [FastEnumUtility.Label("Req Send", 1)]
        ReqSend = 0,
        [FastEnumUtility.Label("MemoReq_Delete", 0)]
        [FastEnumUtility.Label("Req Delete", 1)]
        ReqDelete = 1,
        [FastEnumUtility.Label("MemoReq_Load", 0)]
        [FastEnumUtility.Label("Req Load", 1)]
        ReqLoad = 2,
        [FastEnumUtility.Label("MemoRes_Load", 0)]
        [FastEnumUtility.Label("Res Load", 1)]
        ResLoad = 3,
        [FastEnumUtility.Label("MemoRes_Send_Succeed", 0)]
        [FastEnumUtility.Label("Res Send Succeed", 1)]
        ResSendSucceed = 4,
        [FastEnumUtility.Label("MemoRes_Send_Warning", 0)]
        [FastEnumUtility.Label("Res Send Warning", 1)]
        ResSendWarning = 5,
        [FastEnumUtility.Label("MemoRes_Send_ConfirmOnline", 0)]
        [FastEnumUtility.Label("Res Send Confirm Online", 1)]
        ResSendConfirmOnline = 6,
        [FastEnumUtility.Label("MemoNotify_Receive", 0)]
        [FastEnumUtility.Label("Notify Receive", 1)]
        NotifyReceive = 7,
    }
    public enum MessageType : byte
    {
        [FastEnumUtility.Label("Drop Pick Up", 1)]
        DropPickUp = 0,
        [FastEnumUtility.Label("Quest Record", 1)]
        QuestRecord = 1,
        [FastEnumUtility.Label("Cash Item Expire", 1)]
        CashItemExpire = 2,
        [FastEnumUtility.Label("Inc EXP", 1)]
        IncEXP = 3,
        [FastEnumUtility.Label("Inc SP", 1)]
        IncSP = 4,
        [FastEnumUtility.Label("Inc POP", 1)]
        IncPOP = 5,
        [FastEnumUtility.Label("Inc Money", 1)]
        IncMoney = 6,
        [FastEnumUtility.Label("Inc GP", 1)]
        IncGP = 7,
        [FastEnumUtility.Label("Give Buff", 1)]
        GiveBuff = 8,
        [FastEnumUtility.Label("General Item Expire", 1)]
        GeneralItemExpire = 9,
        System = 10,
        [FastEnumUtility.Label("Quest Record Ex", 1)]
        QuestRecordEx = 11,
        [FastEnumUtility.Label("Item Protect Expire", 1)]
        ItemProtectExpire = 12,
        [FastEnumUtility.Label("Item Expire Replace", 1)]
        ItemExpireReplace = 13,
        [FastEnumUtility.Label("Skill Expire", 1)]
        SkillExpire = 14,
    }
    public enum MessengerOperation : byte
    {
        [FastEnumUtility.Label("MSMP_Enter", 0)]
        Enter = 0,
        [FastEnumUtility.Label("MSMP_SelfEnterResult", 0)]
        [FastEnumUtility.Label("Self Enter Result", 1)]
        SelfEnterResult = 1,
        [FastEnumUtility.Label("MSMP_Leave", 0)]
        Leave = 2,
        [FastEnumUtility.Label("MSMP_Invite", 0)]
        Invite = 3,
        [FastEnumUtility.Label("Invite Result", 1)]
        [FastEnumUtility.Label("MSMP_InviteResult", 0)]
        InviteResult = 4,
        [FastEnumUtility.Label("MSMP_Blocked", 0)]
        Blocked = 5,
        [FastEnumUtility.Label("MSMP_Chat", 0)]
        Chat = 6,
        [FastEnumUtility.Label("MSMP_Avatar", 0)]
        Avatar = 7,
        [FastEnumUtility.Label("MSMP_Migrated", 0)]
        Migrated = 8,
    }
    public enum MiniGameEvent : byte
    {
        [FastEnumUtility.Label("MiniGame_UserBan", 0)]
        [FastEnumUtility.Label("User Ban", 1)]
        UserBan = 0,
        [FastEnumUtility.Label("MiniGame_UserTurn", 0)]
        [FastEnumUtility.Label("User Turn", 1)]
        UserTurn = 1,
        [FastEnumUtility.Label("MiniGame_UserGiveUp", 0)]
        [FastEnumUtility.Label("User Give Up", 1)]
        UserGiveUp = 2,
        [FastEnumUtility.Label("MiniGame_UserRetreatSuccess", 0)]
        [FastEnumUtility.Label("User Retreat Success", 1)]
        UserRetreatSuccess = 3,
        [FastEnumUtility.Label("MiniGame_UserLeave", 0)]
        [FastEnumUtility.Label("User Leave", 1)]
        UserLeave = 4,
        [FastEnumUtility.Label("MiniGame_UserLeaveEngage", 0)]
        [FastEnumUtility.Label("User Leave Engage", 1)]
        UserLeaveEngage = 5,
        [FastEnumUtility.Label("MiniGame_UserLeaveEngageCancel", 0)]
        [FastEnumUtility.Label("User Leave Engage Cancel", 1)]
        UserLeaveEngageCancel = 6,
        [FastEnumUtility.Label("MiniGame_UserEnter", 0)]
        [FastEnumUtility.Label("User Enter", 1)]
        UserEnter = 7,
        [FastEnumUtility.Label("MiniGame_UserNotEnoughMoney", 0)]
        [FastEnumUtility.Label("User Not Enough Money", 1)]
        UserNotEnoughMoney = 8,
        [FastEnumUtility.Label("MiniGame_UserMatchCard", 0)]
        [FastEnumUtility.Label("User Match Card", 1)]
        UserMatchCard = 9,
        [FastEnumUtility.Label("MiniGame_10SecAlert", 0)]
        Alert10Sec = 101,
        [FastEnumUtility.Label("Game Start", 1)]
        [FastEnumUtility.Label("MiniGame_GameStart", 0)]
        GameStart = 102,
        [FastEnumUtility.Label("MiniGame_TournamentMatchEnd", 0)]
        [FastEnumUtility.Label("Tournament Match End", 1)]
        TournamentMatchEnd = 103,
    }
    public enum MiniGameItemType : byte
    {
        [FastEnumUtility.Label("MGIT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("MGIT_OMOK", 0)]
        Omok = 1,
        [FastEnumUtility.Label("MGIT_MEMORYGAME", 0)]
        [FastEnumUtility.Label("Memory Game", 1)]
        MemoryGame = 2,
    }
    public enum MiniRoomEnterResult : byte
    {
        [FastEnumUtility.Label("MREnterResult_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("MREnterResult_NoRoom", 0)]
        [FastEnumUtility.Label("No Room", 1)]
        NoRoom = 1,
        [FastEnumUtility.Label("MREnterResult_Full", 0)]
        Full = 2,
        [FastEnumUtility.Label("MREnterResult_Busy", 0)]
        Busy = 3,
        [FastEnumUtility.Label("MREnterResult_Dead", 0)]
        Dead = 4,
        [FastEnumUtility.Label("MREnterResult_Event", 0)]
        Event = 5,
        [FastEnumUtility.Label("MREnterResult_PermissionDenied", 0)]
        [FastEnumUtility.Label("Permission Denied", 1)]
        PermissionDenied = 6,
        [FastEnumUtility.Label("MREnterResult_NoTrading", 0)]
        [FastEnumUtility.Label("No Trading", 1)]
        NoTrading = 7,
        [FastEnumUtility.Label("MREnterResult_Etc", 0)]
        Etc = 8,
        [FastEnumUtility.Label("MREnterResult_OnlyInSameField", 0)]
        [FastEnumUtility.Label("Only In Same Field", 1)]
        OnlyInSameField = 9,
        [FastEnumUtility.Label("MREnterResult_NearPortal", 0)]
        [FastEnumUtility.Label("Near Portal", 1)]
        NearPortal = 10,
        [FastEnumUtility.Label("Create Count Over", 1)]
        [FastEnumUtility.Label("MREnterResult_CreateCountOver", 0)]
        CreateCountOver = 11,
        [FastEnumUtility.Label("Create IP Count Over", 1)]
        [FastEnumUtility.Label("MREnterResult_CreateIPCountOver", 0)]
        CreateIPCountOver = 12,
        [FastEnumUtility.Label("Exist Mini Room", 1)]
        [FastEnumUtility.Label("MREnterResult_ExistMiniRoom", 0)]
        ExistMiniRoom = 13,
        [FastEnumUtility.Label("MREnterResult_NotAvailableField_Game", 0)]
        [FastEnumUtility.Label("Not Available Field Game", 1)]
        NotAvailableFieldGame = 14,
        [FastEnumUtility.Label("MREnterResult_NotAvailableField_PersonalShop", 0)]
        [FastEnumUtility.Label("Not Available Field Personal Shop", 1)]
        NotAvailableFieldPersonalShop = 15,
        [FastEnumUtility.Label("MREnterResult_NotAvailableField_EntrustedShop", 0)]
        [FastEnumUtility.Label("Not Available Field Entrusted Shop", 1)]
        NotAvailableFieldEntrustedShop = 16,
        [FastEnumUtility.Label("MREnterResult_OnBlockedList", 0)]
        [FastEnumUtility.Label("On Blocked List", 1)]
        OnBlockedList = 17,
        [FastEnumUtility.Label("Is Managing", 1)]
        [FastEnumUtility.Label("MREnterResult_IsManaging", 0)]
        IsManaging = 18,
        [FastEnumUtility.Label("MGEnterResult_Tournament", 0)]
        [FastEnumUtility.Label("Mini Game Tournament", 1)]
        MiniGameTournament = 19,
        [FastEnumUtility.Label("MGEnterResult_AlreadyPlaying", 0)]
        [FastEnumUtility.Label("Mini Game Already Playing", 1)]
        MiniGameAlreadyPlaying = 20,
        [FastEnumUtility.Label("MGEnterResult_NotEnoughMoney", 0)]
        [FastEnumUtility.Label("Mini Game Not Enough Money", 1)]
        MiniGameNotEnoughMoney = 21,
        [FastEnumUtility.Label("MGEnterResult_InvalidPassword", 0)]
        [FastEnumUtility.Label("Mini Game Invalid Password", 1)]
        MiniGameInvalidPassword = 22,
        [FastEnumUtility.Label("MREnterResult_NotAvailableField_ShopScanner", 0)]
        [FastEnumUtility.Label("Not Available Field Shop Scanner", 1)]
        NotAvailableFieldShopScanner = 23,
        [FastEnumUtility.Label("MREnterResult_Expired", 0)]
        Expired = 24,
        [FastEnumUtility.Label("MREnterResult_TooShortTimeInterval", 0)]
        [FastEnumUtility.Label("Too Short Time Interval", 1)]
        TooShortTimeInterval = 25,
    }
    public enum MiniRoomInviteResult : byte
    {
        [FastEnumUtility.Label("MRInvite_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("MRInvite_NoCharacter", 0)]
        [FastEnumUtility.Label("No Character", 1)]
        NoCharacter = 1,
        [FastEnumUtility.Label("Cannot Invite", 1)]
        [FastEnumUtility.Label("MRInvite_CannotInvite", 0)]
        CannotInvite = 2,
        [FastEnumUtility.Label("MRInvite_Rejected", 0)]
        Rejected = 3,
        [FastEnumUtility.Label("MRInvite_Blocked", 0)]
        Blocked = 4,
    }
    public enum MiniRoomLeaveType : byte
    {
        [FastEnumUtility.Label("MRLeave_UserRequest", 0)]
        [FastEnumUtility.Label("User Request", 1)]
        UserRequest = 0,
        [FastEnumUtility.Label("MRLeave_WrongPosition", 0)]
        [FastEnumUtility.Label("Wrong Position", 1)]
        WrongPosition = 1,
        [FastEnumUtility.Label("MRLeave_Closed", 0)]
        Closed = 2,
        [FastEnumUtility.Label("Host Out", 1)]
        [FastEnumUtility.Label("MRLeave_HostOut", 0)]
        HostOut = 3,
        [FastEnumUtility.Label("MRLeave_Booked", 0)]
        Booked = 4,
        [FastEnumUtility.Label("MRLeave_Kicked", 0)]
        Kicked = 5,
        [FastEnumUtility.Label("MRLeave_OpenTimeOver", 0)]
        [FastEnumUtility.Label("Open Time Over", 1)]
        OpenTimeOver = 6,
        [FastEnumUtility.Label("TRLeave_TradeDone", 0)]
        [FastEnumUtility.Label("Trade Done", 1)]
        TradeDone = 7,
        [FastEnumUtility.Label("TRLeave_TradeFail", 0)]
        [FastEnumUtility.Label("Trade Fail", 1)]
        TradeFail = 8,
        [FastEnumUtility.Label("TRLeave_TradeFail_OnlyItem", 0)]
        [FastEnumUtility.Label("Trade Fail Only Item", 1)]
        TradeFailOnlyItem = 9,
        [FastEnumUtility.Label("TRLeave_TradeFail_Expired", 0)]
        [FastEnumUtility.Label("Trade Fail Expired", 1)]
        TradeFailExpired = 10,
        [FastEnumUtility.Label("TRLeave_TradeFail_Denied", 0)]
        [FastEnumUtility.Label("Trade Fail Denied", 1)]
        TradeFailDenied = 11,
        [FastEnumUtility.Label("TRLeave_FieldError", 0)]
        [FastEnumUtility.Label("Trade Field Error", 1)]
        TradeFieldError = 12,
        [FastEnumUtility.Label("TRLeave_ItemCRCFailed", 0)]
        [FastEnumUtility.Label("Trade Item CRC Failed", 1)]
        TradeItemCRCFailed = 13,
        [FastEnumUtility.Label("PSLeave_NoMoreItem", 0)]
        [FastEnumUtility.Label("Personal Shop No More Item", 1)]
        PersonalShopNoMoreItem = 14,
        [FastEnumUtility.Label("PSLeave_KickedTimeOver", 0)]
        [FastEnumUtility.Label("Personal Shop Kicked Time Over", 1)]
        PersonalShopKickedTimeOver = 15,
        [FastEnumUtility.Label("ESLeave_Open", 0)]
        [FastEnumUtility.Label("Entrusted Shop Open", 1)]
        EntrustedShopOpen = 16,
        [FastEnumUtility.Label("ESLeave_StartManage", 0)]
        [FastEnumUtility.Label("Entrusted Shop Start Manage", 1)]
        EntrustedShopStartManage = 17,
        [FastEnumUtility.Label("ESLeave_ClosedTimeOver", 0)]
        [FastEnumUtility.Label("Entrusted Shop Closed Time Over", 1)]
        EntrustedShopClosedTimeOver = 18,
        [FastEnumUtility.Label("ESLeave_EndManage", 0)]
        [FastEnumUtility.Label("Entrusted Shop End Manage", 1)]
        EntrustedShopEndManage = 19,
        [FastEnumUtility.Label("ESLeave_DestoryByAdmin", 0)]
        [FastEnumUtility.Label("Entrusted Shop Destroy By Admin", 1)]
        EntrustedShopDestroyByAdmin = 20,
        [FastEnumUtility.Label("MGLeave_UserRequest", 0)]
        [FastEnumUtility.Label("Mini Game User Request", 1)]
        MiniGameUserRequest = 21,
    }
    public enum MiniRoomProtocol : byte
    {
        [FastEnumUtility.Label("MRP_Create", 0)]
        [FastEnumUtility.Label("Mrp Create", 1)]
        MrpCreate = 0,
        [FastEnumUtility.Label("MRP_CreateResult", 0)]
        [FastEnumUtility.Label("Mrp Create Result", 1)]
        MrpCreateResult = 1,
        [FastEnumUtility.Label("MRP_Invite", 0)]
        [FastEnumUtility.Label("Mrp Invite", 1)]
        MrpInvite = 2,
        [FastEnumUtility.Label("MRP_InviteResult", 0)]
        [FastEnumUtility.Label("Mrp Invite Result", 1)]
        MrpInviteResult = 3,
        [FastEnumUtility.Label("MRP_Enter", 0)]
        [FastEnumUtility.Label("Mrp Enter", 1)]
        MrpEnter = 4,
        [FastEnumUtility.Label("MRP_EnterResult", 0)]
        [FastEnumUtility.Label("Mrp Enter Result", 1)]
        MrpEnterResult = 5,
        [FastEnumUtility.Label("MRP_Chat", 0)]
        [FastEnumUtility.Label("Mrp Chat", 1)]
        MrpChat = 6,
        [FastEnumUtility.Label("MRP_GameMessage", 0)]
        [FastEnumUtility.Label("Mrp Game Message", 1)]
        MrpGameMessage = 7,
        [FastEnumUtility.Label("MRP_UserChat", 0)]
        [FastEnumUtility.Label("Mrp User Chat", 1)]
        MrpUserChat = 8,
        [FastEnumUtility.Label("MRP_Avatar", 0)]
        [FastEnumUtility.Label("Mrp Avatar", 1)]
        MrpAvatar = 9,
        [FastEnumUtility.Label("MRP_Leave", 0)]
        [FastEnumUtility.Label("Mrp Leave", 1)]
        MrpLeave = 10,
        [FastEnumUtility.Label("MRP_Balloon", 0)]
        [FastEnumUtility.Label("Mrp Balloon", 1)]
        MrpBalloon = 11,
        [FastEnumUtility.Label("MRP_NotAvailableField", 0)]
        [FastEnumUtility.Label("Mrp Not Available Field", 1)]
        MrpNotAvailableField = 12,
        [FastEnumUtility.Label("MRP_FreeMarketClip", 0)]
        [FastEnumUtility.Label("Mrp Free Market Clip", 1)]
        MrpFreeMarketClip = 13,
        [FastEnumUtility.Label("MRP_CheckSSN2", 0)]
        [FastEnumUtility.Label("Mrp Check Ssn2", 1)]
        MrpCheckSsn2 = 14,
        [FastEnumUtility.Label("TRP_PutItem", 0)]
        [FastEnumUtility.Label("Trp Put Item", 1)]
        TrpPutItem = 15,
        [FastEnumUtility.Label("TRP_PutMoney", 0)]
        [FastEnumUtility.Label("Trp Put Money", 1)]
        TrpPutMoney = 16,
        [FastEnumUtility.Label("TRP_Trade", 0)]
        [FastEnumUtility.Label("Trp Trade", 1)]
        TrpTrade = 17,
        [FastEnumUtility.Label("TRP_UnTrade", 0)]
        [FastEnumUtility.Label("Trp Un Trade", 1)]
        TrpUnTrade = 18,
        [FastEnumUtility.Label("TRP_MoveItemToInventory", 0)]
        [FastEnumUtility.Label("Trp Move Item To Inventory", 1)]
        TrpMoveItemToInventory = 19,
        [FastEnumUtility.Label("TRP_ItemCRC", 0)]
        [FastEnumUtility.Label("Trp Item Crc", 1)]
        TrpItemCrc = 20,
        [FastEnumUtility.Label("TRP_LimitFail", 0)]
        [FastEnumUtility.Label("Trp Limit Fail", 1)]
        TrpLimitFail = 21,
        [FastEnumUtility.Label("PSP_PutItem", 0)]
        [FastEnumUtility.Label("Psp Put Item", 1)]
        PspPutItem = 22,
        [FastEnumUtility.Label("PSP_BuyItem", 0)]
        [FastEnumUtility.Label("Psp Buy Item", 1)]
        PspBuyItem = 23,
        [FastEnumUtility.Label("PSP_BuyResult", 0)]
        [FastEnumUtility.Label("Psp Buy Result", 1)]
        PspBuyResult = 24,
        [FastEnumUtility.Label("PSP_Refresh", 0)]
        [FastEnumUtility.Label("Psp Refresh", 1)]
        PspRefresh = 25,
        [FastEnumUtility.Label("PSP_AddSoldItem", 0)]
        [FastEnumUtility.Label("Psp Add Sold Item", 1)]
        PspAddSoldItem = 26,
        [FastEnumUtility.Label("PSP_MoveItemToInventory", 0)]
        [FastEnumUtility.Label("Psp Move Item To Inventory", 1)]
        PspMoveItemToInventory = 27,
        [FastEnumUtility.Label("PSP_Ban", 0)]
        [FastEnumUtility.Label("Psp Ban", 1)]
        PspBan = 28,
        [FastEnumUtility.Label("PSP_KickedTimeOver", 0)]
        [FastEnumUtility.Label("Psp Kicked Time Over", 1)]
        PspKickedTimeOver = 29,
        [FastEnumUtility.Label("PSP_DeliverBlackList", 0)]
        [FastEnumUtility.Label("Psp Deliver Black List", 1)]
        PspDeliverBlackList = 30,
        [FastEnumUtility.Label("PSP_AddBlackList", 0)]
        [FastEnumUtility.Label("Psp Add Black List", 1)]
        PspAddBlackList = 31,
        [FastEnumUtility.Label("PSP_DeleteBlackList", 0)]
        [FastEnumUtility.Label("Psp Delete Black List", 1)]
        PspDeleteBlackList = 32,
        [FastEnumUtility.Label("ESP_PutItem", 0)]
        [FastEnumUtility.Label("Esp Put Item", 1)]
        EspPutItem = 33,
        [FastEnumUtility.Label("ESP_BuyItem", 0)]
        [FastEnumUtility.Label("Esp Buy Item", 1)]
        EspBuyItem = 34,
        [FastEnumUtility.Label("ESP_BuyResult", 0)]
        [FastEnumUtility.Label("Esp Buy Result", 1)]
        EspBuyResult = 35,
        [FastEnumUtility.Label("ESP_Refresh", 0)]
        [FastEnumUtility.Label("Esp Refresh", 1)]
        EspRefresh = 36,
        [FastEnumUtility.Label("ESP_AddSoldItem", 0)]
        [FastEnumUtility.Label("Esp Add Sold Item", 1)]
        EspAddSoldItem = 37,
        [FastEnumUtility.Label("ESP_MoveItemToInventory", 0)]
        [FastEnumUtility.Label("Esp Move Item To Inventory", 1)]
        EspMoveItemToInventory = 38,
        [FastEnumUtility.Label("ESP_GoOut", 0)]
        [FastEnumUtility.Label("Esp Go Out", 1)]
        EspGoOut = 39,
        [FastEnumUtility.Label("ESP_ArrangeItem", 0)]
        [FastEnumUtility.Label("Esp Arrange Item", 1)]
        EspArrangeItem = 40,
        [FastEnumUtility.Label("ESP_WithdrawAll", 0)]
        [FastEnumUtility.Label("Esp Withdraw All", 1)]
        EspWithdrawAll = 41,
        [FastEnumUtility.Label("ESP_WithdrawAllResult", 0)]
        [FastEnumUtility.Label("Esp Withdraw All Result", 1)]
        EspWithdrawAllResult = 42,
        [FastEnumUtility.Label("ESP_WithdrawMoney", 0)]
        [FastEnumUtility.Label("Esp Withdraw Money", 1)]
        EspWithdrawMoney = 43,
        [FastEnumUtility.Label("ESP_WithdrawMoneyResult", 0)]
        [FastEnumUtility.Label("Esp Withdraw Money Result", 1)]
        EspWithdrawMoneyResult = 44,
        [FastEnumUtility.Label("ESP_AdminChangeTitle", 0)]
        [FastEnumUtility.Label("Esp Admin Change Title", 1)]
        EspAdminChangeTitle = 45,
        [FastEnumUtility.Label("ESP_DeliverVisitList", 0)]
        [FastEnumUtility.Label("Esp Deliver Visit List", 1)]
        EspDeliverVisitList = 46,
        [FastEnumUtility.Label("ESP_DeliverBlackList", 0)]
        [FastEnumUtility.Label("Esp Deliver Black List", 1)]
        EspDeliverBlackList = 47,
        [FastEnumUtility.Label("ESP_AddBlackList", 0)]
        [FastEnumUtility.Label("Esp Add Black List", 1)]
        EspAddBlackList = 48,
        [FastEnumUtility.Label("ESP_DeleteBlackList", 0)]
        [FastEnumUtility.Label("Esp Delete Black List", 1)]
        EspDeleteBlackList = 49,
        [FastEnumUtility.Label("MGRP_TieRequest", 0)]
        [FastEnumUtility.Label("Mgrp Tie Request", 1)]
        MgrpTieRequest = 50,
        [FastEnumUtility.Label("MGRP_TieResult", 0)]
        [FastEnumUtility.Label("Mgrp Tie Result", 1)]
        MgrpTieResult = 51,
        [FastEnumUtility.Label("MGRP_GiveUpRequest", 0)]
        [FastEnumUtility.Label("Mgrp Give Up Request", 1)]
        MgrpGiveUpRequest = 52,
        [FastEnumUtility.Label("MGRP_GiveUpResult", 0)]
        [FastEnumUtility.Label("Mgrp Give Up Result", 1)]
        MgrpGiveUpResult = 53,
        [FastEnumUtility.Label("MGRP_RetreatRequest", 0)]
        [FastEnumUtility.Label("Mgrp Retreat Request", 1)]
        MgrpRetreatRequest = 54,
        [FastEnumUtility.Label("MGRP_RetreatResult", 0)]
        [FastEnumUtility.Label("Mgrp Retreat Result", 1)]
        MgrpRetreatResult = 55,
        [FastEnumUtility.Label("MGRP_LeaveEngage", 0)]
        [FastEnumUtility.Label("Mgrp Leave Engage", 1)]
        MgrpLeaveEngage = 56,
        [FastEnumUtility.Label("MGRP_LeaveEngageCancel", 0)]
        [FastEnumUtility.Label("Mgrp Leave Engage Cancel", 1)]
        MgrpLeaveEngageCancel = 57,
        [FastEnumUtility.Label("MGRP_Ready", 0)]
        [FastEnumUtility.Label("Mgrp Ready", 1)]
        MgrpReady = 58,
        [FastEnumUtility.Label("MGRP_CancelReady", 0)]
        [FastEnumUtility.Label("Mgrp Cancel Ready", 1)]
        MgrpCancelReady = 59,
        [FastEnumUtility.Label("MGRP_Ban", 0)]
        [FastEnumUtility.Label("Mgrp Ban", 1)]
        MgrpBan = 60,
        [FastEnumUtility.Label("MGRP_Start", 0)]
        [FastEnumUtility.Label("Mgrp Start", 1)]
        MgrpStart = 61,
        [FastEnumUtility.Label("MGRP_GameResult", 0)]
        [FastEnumUtility.Label("Mgrp Game Result", 1)]
        MgrpGameResult = 62,
        [FastEnumUtility.Label("MGRP_TimeOver", 0)]
        [FastEnumUtility.Label("Mgrp Time Over", 1)]
        MgrpTimeOver = 63,
        [FastEnumUtility.Label("ORP_PutStoneChecker", 0)]
        [FastEnumUtility.Label("Orp Put Stone Checker", 1)]
        OrpPutStoneChecker = 64,
        [FastEnumUtility.Label("ORP_InvalidStonePosition", 0)]
        [FastEnumUtility.Label("Orp Invalid Stone Position", 1)]
        OrpInvalidStonePosition = 65,
        [FastEnumUtility.Label("ORP_InvalidStonePosition_Normal", 0)]
        [FastEnumUtility.Label("Orp Invalid Stone Position Normal", 1)]
        OrpInvalidStonePositionNormal = 66,
        [FastEnumUtility.Label("ORP_InvalidStonePosition_By33", 0)]
        [FastEnumUtility.Label("Orp Invalid Stone Position By33", 1)]
        OrpInvalidStonePositionBy33 = 67,
        [FastEnumUtility.Label("MGP_TurnUpCard", 0)]
        [FastEnumUtility.Label("Mgp Turn Up Card", 1)]
        MgpTurnUpCard = 68,
        [FastEnumUtility.Label("MGP_MatchCard", 0)]
        [FastEnumUtility.Label("Mgp Match Card", 1)]
        MgpMatchCard = 69,
    }
    public enum MiniRoomType : byte
    {
        [FastEnumUtility.Label("MR_OmokRoom", 0)]
        [FastEnumUtility.Label("Omok Room", 1)]
        OmokRoom = 1,
        [FastEnumUtility.Label("MR_MemoryGameRoom", 0)]
        [FastEnumUtility.Label("Memory Game Room", 1)]
        MemoryGameRoom = 2,
        [FastEnumUtility.Label("MR_TradingRoom", 0)]
        [FastEnumUtility.Label("Trading Room", 1)]
        TradingRoom = 3,
        [FastEnumUtility.Label("MR_PersonalShop", 0)]
        [FastEnumUtility.Label("Personal Shop", 1)]
        PersonalShop = 4,
        [FastEnumUtility.Label("Entrusted Shop", 1)]
        [FastEnumUtility.Label("MR_EntrustedShop", 0)]
        EntrustedShop = 5,
        [FastEnumUtility.Label("Cash Trading Room", 1)]
        [FastEnumUtility.Label("MR_CashTradingRoom", 0)]
        CashTradingRoom = 6,
    }
    public enum MobActionType : byte
    {
        [FastEnumUtility.Label("MOBACT_MOVE", 0)]
        Move = 0,
        [FastEnumUtility.Label("MOBACT_STAND", 0)]
        Stand = 1,
        [FastEnumUtility.Label("MOBACT_JUMP", 0)]
        Jump = 2,
        [FastEnumUtility.Label("MOBACT_FLY", 0)]
        Fly = 3,
        [FastEnumUtility.Label("MOBACT_ROPE", 0)]
        Rope = 4,
        [FastEnumUtility.Label("MOBACT_REGEN", 0)]
        Regen = 5,
        [FastEnumUtility.Label("MOBACT_BOMB", 0)]
        Bomb = 6,
        [FastEnumUtility.Label("MOBACT_HIT1", 0)]
        Hit1 = 7,
        [FastEnumUtility.Label("MOBACT_HIT2", 0)]
        Hit2 = 8,
        [FastEnumUtility.Label("Hit F", 1)]
        [FastEnumUtility.Label("MOBACT_HITF", 0)]
        HitF = 9,
        [FastEnumUtility.Label("MOBACT_DIE1", 0)]
        Die1 = 10,
        [FastEnumUtility.Label("MOBACT_DIE2", 0)]
        Die2 = 11,
        [FastEnumUtility.Label("Die F", 1)]
        [FastEnumUtility.Label("MOBACT_DIEF", 0)]
        DieF = 12,
        [FastEnumUtility.Label("MOBACT_ATTACK1", 0)]
        Attack1 = 13,
        [FastEnumUtility.Label("MOBACT_ATTACK2", 0)]
        Attack2 = 14,
        [FastEnumUtility.Label("MOBACT_ATTACK3", 0)]
        Attack3 = 15,
        [FastEnumUtility.Label("MOBACT_ATTACK4", 0)]
        Attack4 = 16,
        [FastEnumUtility.Label("MOBACT_ATTACK5", 0)]
        Attack5 = 17,
        [FastEnumUtility.Label("MOBACT_ATTACK6", 0)]
        Attack6 = 18,
        [FastEnumUtility.Label("MOBACT_ATTACK7", 0)]
        Attack7 = 19,
        [FastEnumUtility.Label("MOBACT_ATTACK8", 0)]
        Attack8 = 20,
        [FastEnumUtility.Label("Attack F", 1)]
        [FastEnumUtility.Label("MOBACT_ATTACKF", 0)]
        AttackF = 21,
        [FastEnumUtility.Label("MOBACT_SKILL1", 0)]
        Skill1 = 22,
        [FastEnumUtility.Label("MOBACT_SKILL2", 0)]
        Skill2 = 23,
        [FastEnumUtility.Label("MOBACT_SKILL3", 0)]
        Skill3 = 24,
        [FastEnumUtility.Label("MOBACT_SKILL4", 0)]
        Skill4 = 25,
        [FastEnumUtility.Label("MOBACT_SKILL5", 0)]
        Skill5 = 26,
        [FastEnumUtility.Label("MOBACT_SKILL6", 0)]
        Skill6 = 27,
        [FastEnumUtility.Label("MOBACT_SKILL7", 0)]
        Skill7 = 28,
        [FastEnumUtility.Label("MOBACT_SKILL8", 0)]
        Skill8 = 29,
        [FastEnumUtility.Label("MOBACT_SKILL9", 0)]
        Skill9 = 30,
        [FastEnumUtility.Label("MOBACT_SKILL10", 0)]
        Skill10 = 31,
        [FastEnumUtility.Label("MOBACT_SKILL11", 0)]
        Skill11 = 32,
        [FastEnumUtility.Label("MOBACT_SKILL12", 0)]
        Skill12 = 33,
        [FastEnumUtility.Label("MOBACT_SKILL13", 0)]
        Skill13 = 34,
        [FastEnumUtility.Label("MOBACT_SKILL14", 0)]
        Skill14 = 35,
        [FastEnumUtility.Label("MOBACT_SKILL15", 0)]
        Skill15 = 36,
        [FastEnumUtility.Label("MOBACT_SKILL16", 0)]
        Skill16 = 37,
        [FastEnumUtility.Label("MOBACT_SKILLF", 0)]
        [FastEnumUtility.Label("Skill F", 1)]
        SkillF = 38,
        [FastEnumUtility.Label("MOBACT_CHASE", 0)]
        Chase = 39,
        [FastEnumUtility.Label("MOBACT_MISS", 0)]
        Miss = 40,
        [FastEnumUtility.Label("MOBACT_SAY", 0)]
        Say = 41,
        [FastEnumUtility.Label("MOBACT_EYE", 0)]
        Eye = 42,
        [FastEnumUtility.Label("MOBACT_NO", 0)]
        [FastEnumUtility.Label("No Action", 1)]
        NoAction = 43,
    }
    public enum MobAttackElement : byte
    {
        [FastEnumUtility.Label("Mob_AttackElem_None", 0)]
        None = 0,
        [FastEnumUtility.Label("Mob_AttackElem_Ice", 0)]
        Ice = 1,
        [FastEnumUtility.Label("Mob_AttackElem_Fire", 0)]
        Fire = 2,
        [FastEnumUtility.Label("Mob_AttackElem_Light", 0)]
        Light = 3,
        [FastEnumUtility.Label("Mob_AttackElem_Poison", 0)]
        Poison = 4,
        [FastEnumUtility.Label("Mob_AttackElem_Holy", 0)]
        Holy = 5,
        [FastEnumUtility.Label("Mob_AttackElem_Dark", 0)]
        Dark = 6,
    }
    public enum MobAttackRange : byte
    {
        [FastEnumUtility.Label("AT_RANGE", 0)]
        Range = 0,
        [FastEnumUtility.Label("AT_SHOOT", 0)]
        Shoot = 1,
        [FastEnumUtility.Label("AT_PIERCE", 0)]
        Pierce = 2,
        [FastEnumUtility.Label("AT_AREA1", 0)]
        Area1 = 3,
        [FastEnumUtility.Label("AT_AREA2", 0)]
        Area2 = 4,
    }
    public enum MobAttractDirection : byte
    {
        [FastEnumUtility.Label("ATTRACT_DIRECTION_LEFT", 0)]
        Left = 1,
        [FastEnumUtility.Label("ATTRACT_DIRECTION_RIGHT", 0)]
        Right = 2,
        [FastEnumUtility.Label("ATTRACT_DIRECTION_UP", 0)]
        Up = 3,
        [FastEnumUtility.Label("ATTRACT_DIRECTION_DOWN", 0)]
        Down = 4,
        [FastEnumUtility.Label("ATTRACT_DIRECTION_STAND", 0)]
        Stand = 5,
        [FastEnumUtility.Label("ATTRACT_DIRECTION_LEFT_JUMP", 0)]
        [FastEnumUtility.Label("Left Jump", 1)]
        LeftJump = 6,
        [FastEnumUtility.Label("ATTRACT_DIRECTION_RIGHT_JUMP", 0)]
        [FastEnumUtility.Label("Right Jump", 1)]
        RightJump = 7,
    }
    public enum MobBanType : sbyte
    {
        [FastEnumUtility.Label("MOBBANTYPE_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("MOBBANTYPE_COLLISION", 0)]
        Collision = 1,
        [FastEnumUtility.Label("MOBBANTYPE_USERATTACK", 0)]
        [FastEnumUtility.Label("User Attack", 1)]
        UserAttack = 2,
        [FastEnumUtility.Label("MOBBANTYPE_MOBSKILL", 0)]
        [FastEnumUtility.Label("Mob Skill", 1)]
        MobSkill = -1,
    }
    public enum MobCategory : byte
    {
        [FastEnumUtility.Label("MOBCATEGORY_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("MOBCATEGORY_ANIMAL", 0)]
        Animal = 1,
        [FastEnumUtility.Label("MOBCATEGORY_PLANT", 0)]
        Plant = 2,
        [FastEnumUtility.Label("MOBCATEGORY_FISH", 0)]
        Fish = 3,
        [FastEnumUtility.Label("MOBCATEGORY_REPTILIA", 0)]
        [FastEnumUtility.Label("Reptile", 1)]
        Reptilia = 4,
        [FastEnumUtility.Label("MOBCATEGORY_DEMON", 0)]
        Demon = 5,
        [FastEnumUtility.Label("MOBCATEGORY_SPIRIT", 0)]
        Spirit = 6,
        [FastEnumUtility.Label("MOBCATEGORY_IMMORTAL", 0)]
        Immortal = 7,
        [FastEnumUtility.Label("MOBCATEGORY_ETC", 0)]
        Etc = 8,
    }
    public enum MobDamageRandType : byte
    {
        [FastEnumUtility.Label("MOB_DAMAGERAND_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("MOB_DAMAGERAND_FAKE", 0)]
        Fake = 1,
        [FastEnumUtility.Label("MOB_DAMAGERAND_BLIND", 0)]
        Blind = 2,
        [FastEnumUtility.Label("MOB_DAMAGERAND_BLOCKING", 0)]
        Blocking = 3,
        [FastEnumUtility.Label("MOB_DAMAGERAND_GUARD", 0)]
        Guard = 4,
        [FastEnumUtility.Label("MOB_DAMAGERAND_SWALLOW_EVASION", 0)]
        [FastEnumUtility.Label("Swallow Evasion", 1)]
        SwallowEvasion = 5,
        [FastEnumUtility.Label("MOB_DAMAGERAND_NO", 0)]
        No = 6,
    }
    public enum MobDamageType : byte
    {
        [FastEnumUtility.Label("MOB_DAMAGERAND_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("MOB_DAMAGERAND_FAKE", 0)]
        Fake = 1,
        [FastEnumUtility.Label("MOB_DAMAGERAND_BLIND", 0)]
        Blind = 2,
        [FastEnumUtility.Label("MOB_DAMAGERAND_BLOCKING", 0)]
        Blocking = 3,
        [FastEnumUtility.Label("MOB_DAMAGERAND_GUARD", 0)]
        Guard = 4,
        [FastEnumUtility.Label("MOB_DAMAGERAND_SWALLOW_EVASION", 0)]
        [FastEnumUtility.Label("Swallow Evasion", 1)]
        SwallowEvasion = 5,
        [FastEnumUtility.Label("MOB_DAMAGERAND_NO", 0)]
        No = 6,
    }
    public enum MobLevelType : byte
    {
        [FastEnumUtility.Label("MOB_LEVEL_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("MOB_LEVEL_EASY", 0)]
        Easy = 1,
        [FastEnumUtility.Label("MOB_LEVEL_HARD", 0)]
        Hard = 2,
    }
    public enum MobMoveAbility : byte
    {
        [FastEnumUtility.Label("MOVEABILITY_STOP", 0)]
        [FastEnumUtility.Label("Stationary", 1)]
        Stop = 0,
        [FastEnumUtility.Label("MOVEABILITY_WALK", 0)]
        Walk = 1,
        [FastEnumUtility.Label("MOVEABILITY_WALK_RANDOM", 0)]
        [FastEnumUtility.Label("Walk (Random)", 1)]
        WalkRandom = 2,
        [FastEnumUtility.Label("MOVEABILITY_JUMP", 0)]
        Jump = 3,
        [FastEnumUtility.Label("MOVEABILITY_FLY", 0)]
        Fly = 4,
        [FastEnumUtility.Label("Fly (Random)", 1)]
        [FastEnumUtility.Label("MOVEABILITY_FLY_RANDOM", 0)]
        FlyRandom = 5,
        [FastEnumUtility.Label("MOVEABILITY_ESCORT", 0)]
        Escort = 6,
    }
    public enum MobMoveType : byte
    {
        [FastEnumUtility.Label("MOBMOVE_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("MOBMOVE_HIT", 0)]
        Hit = 1,
        [FastEnumUtility.Label("MOBMOVE_KNOCKBACK", 0)]
        Knockback = 2,
        [FastEnumUtility.Label("MOBMOVE_ATTRACT", 0)]
        Attract = 3,
        [FastEnumUtility.Label("Attract Faster", 1)]
        [FastEnumUtility.Label("MOBMOVE_ATTRACT_FASTER", 0)]
        AttractFaster = 4,
        [FastEnumUtility.Label("Dragon Pulse", 1)]
        [FastEnumUtility.Label("MOBMOVE_DRAGONPULSE", 0)]
        DragonPulse = 5,
        [FastEnumUtility.Label("MOBMOVE_RUSH", 0)]
        Rush = 6,
        [FastEnumUtility.Label("MOBMOVE_NINJASTORM", 0)]
        [FastEnumUtility.Label("Ninja Storm", 1)]
        NinjaStorm = 7,
        [FastEnumUtility.Label("Elbow Attack", 1)]
        [FastEnumUtility.Label("MOBMOVE_ELBOWATTACK", 0)]
        ElbowAttack = 8,
        [FastEnumUtility.Label("MOBMOVE_SCREWPUNCH", 0)]
        [FastEnumUtility.Label("Screw Punch", 1)]
        ScrewPunch = 9,
        [FastEnumUtility.Label("MOBMOVE_FIST", 0)]
        Fist = 10,
        [FastEnumUtility.Label("MOBMOVE_TOSS", 0)]
        Toss = 11,
        [FastEnumUtility.Label("MOBMOVE_STOP", 0)]
        Stop = 12,
        [FastEnumUtility.Label("MOBMOVE_SWALLOW", 0)]
        Swallow = 13,
        [FastEnumUtility.Label("Attack Rush", 1)]
        [FastEnumUtility.Label("MOBMOVE_ATTACK_RUSH", 0)]
        AttackRush = 14,
    }
    public enum MobPowerAttackType : byte
    {
        [FastEnumUtility.Label("MPA_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("MPA_JUMP", 0)]
        Jump = 1,
        [FastEnumUtility.Label("MPA_IMPACT", 0)]
        Impact = 2,
        [FastEnumUtility.Label("MPA_IMMEDIATE", 0)]
        Immediate = 3,
        [FastEnumUtility.Label("MPA_TELEPORT", 0)]
        Teleport = 4,
        [FastEnumUtility.Label("Hang On Back", 1)]
        [FastEnumUtility.Label("MPA_HANGONBACK", 0)]
        HangOnBack = 5,
        [FastEnumUtility.Label("MPA_ASSAULTER", 0)]
        Assaulter = 6,
        [FastEnumUtility.Label("MPA_ASSASSINATION", 0)]
        Assassination = 7,
        [FastEnumUtility.Label("MPA_RUSH", 0)]
        Rush = 8,
        [FastEnumUtility.Label("MPA_STATCHANGE", 0)]
        [FastEnumUtility.Label("Stat Change", 1)]
        StatChange = 9,
        [FastEnumUtility.Label("MPA_SITDOWN", 0)]
        [FastEnumUtility.Label("Sit Down", 1)]
        SitDown = 10,
        [FastEnumUtility.Label("MPA_STARTFALLDOWN", 0)]
        [FastEnumUtility.Label("Start Fall Down", 1)]
        StartFallDown = 11,
        [FastEnumUtility.Label("Fall Down", 1)]
        [FastEnumUtility.Label("MPA_FALLDOWN", 0)]
        FallDown = 12,
        [FastEnumUtility.Label("MPA_STARTWINGS", 0)]
        [FastEnumUtility.Label("Start Wings", 1)]
        StartWings = 13,
        [FastEnumUtility.Label("MPA_WINGS", 0)]
        Wings = 14,
        [FastEnumUtility.Label("Aran Adjust", 1)]
        [FastEnumUtility.Label("MPA_ARAN_ADJUST", 0)]
        AranAdjust = 15,
        [FastEnumUtility.Label("MPA_MOB_TOSS", 0)]
        [FastEnumUtility.Label("Mob Toss", 1)]
        MobToss = 16,
        [FastEnumUtility.Label("Flying Block", 1)]
        [FastEnumUtility.Label("MPA_FLYING_BLOCK", 0)]
        FlyingBlock = 17,
        [FastEnumUtility.Label("Dash Slide", 1)]
        [FastEnumUtility.Label("MPA_DASH_SLIDE", 0)]
        DashSlide = 18,
        [FastEnumUtility.Label("Bmage Adjust", 1)]
        [FastEnumUtility.Label("MPA_BMAGE_ADJUST", 0)]
        BmageAdjust = 19,
        [FastEnumUtility.Label("Flash Jump", 1)]
        [FastEnumUtility.Label("MPA_FLASHJUMP", 0)]
        FlashJump = 20,
        [FastEnumUtility.Label("MPA_ROCKET_BOOSTER", 0)]
        [FastEnumUtility.Label("Rocket Booster", 1)]
        RocketBooster = 21,
        [FastEnumUtility.Label("Backstep Shot", 1)]
        [FastEnumUtility.Label("MPA_BACKSTEP_SHOT", 0)]
        BackstepShot = 22,
        [FastEnumUtility.Label("MPA_MOBPOWERKNOCKBACK", 0)]
        [FastEnumUtility.Label("Mob Power Knockback", 1)]
        MobPowerKnockback = 23,
        [FastEnumUtility.Label("MPA_VERTICALJUMP", 0)]
        [FastEnumUtility.Label("Vertical Jump", 1)]
        VerticalJump = 24,
        [FastEnumUtility.Label("Custom Impact", 1)]
        [FastEnumUtility.Label("MPA_CUSTOMIMPACT", 0)]
        CustomImpact = 25,
        [FastEnumUtility.Label("Combat Step", 1)]
        [FastEnumUtility.Label("MPA_COMBATSTEP", 0)]
        CombatStep = 26,
        [FastEnumUtility.Label("MPA_HIT", 0)]
        Hit = 27,
        [FastEnumUtility.Label("MPA_TIMEBOMBATTACK", 0)]
        [FastEnumUtility.Label("Time Bomb Attack", 1)]
        TimeBombAttack = 28,
        [FastEnumUtility.Label("MPA_SNOWBALLTOUCH", 0)]
        [FastEnumUtility.Label("Snowball Touch", 1)]
        SnowballTouch = 29,
        [FastEnumUtility.Label("Buff Zone Effect", 1)]
        [FastEnumUtility.Label("MPA_BUFFZONEEFFECT", 0)]
        BuffZoneEffect = 30,
        [FastEnumUtility.Label("MPA_MOB_LADDER", 0)]
        [FastEnumUtility.Label("Mob Ladder", 1)]
        MobLadder = 31,
        [FastEnumUtility.Label("MPA_MOB_RIGHTANGLE", 0)]
        [FastEnumUtility.Label("Mob Right Angle", 1)]
        MobRightAngle = 32,
        [FastEnumUtility.Label("MPA_MOB_STOPNODE_START", 0)]
        [FastEnumUtility.Label("Mob Stop Node Start", 1)]
        MobStopNodeStart = 33,
        [FastEnumUtility.Label("MPA_MOB_BEFORE_NODE", 0)]
        [FastEnumUtility.Label("Mob Before Node", 1)]
        MobBeforeNode = 34,
        [FastEnumUtility.Label("MPA_MOB_ATTACK_RUSH", 0)]
        [FastEnumUtility.Label("Mob Attack Rush", 1)]
        MobAttackRush = 35,
        [FastEnumUtility.Label("MPA_MOB_ATTACK_RUSH_STOP", 0)]
        [FastEnumUtility.Label("Mob Attack Rush Stop", 1)]
        MobAttackRushStop = 36,
    }
    public enum MobSkillType : byte
    {
        [FastEnumUtility.Label("MOBSKILL_POWERUP", 0)]
        [FastEnumUtility.Label("Power Up", 1)]
        PowerUp = 100,
        [FastEnumUtility.Label("MOBSKILL_MAGICUP", 0)]
        [FastEnumUtility.Label("Magic Up", 1)]
        MagicUp = 101,
        [FastEnumUtility.Label("MOBSKILL_PGUARDUP", 0)]
        [FastEnumUtility.Label("Physical Guard Up", 1)]
        PhysicalGuardUp = 102,
        [FastEnumUtility.Label("MOBSKILL_MGUARDUP", 0)]
        [FastEnumUtility.Label("Magic Guard Up", 1)]
        MagicGuardUp = 103,
        [FastEnumUtility.Label("MOBSKILL_HASTE", 0)]
        Haste = 104,
        [FastEnumUtility.Label("MOBSKILL_POWERUP_M", 0)]
        [FastEnumUtility.Label("Power Up Multi", 1)]
        PowerUpMulti = 110,
        [FastEnumUtility.Label("MOBSKILL_MAGICUP_M", 0)]
        [FastEnumUtility.Label("Magic Up Multi", 1)]
        MagicUpMulti = 111,
        [FastEnumUtility.Label("MOBSKILL_PGUARDUP_M", 0)]
        [FastEnumUtility.Label("Physical Guard Up Multi", 1)]
        PhysicalGuardUpMulti = 112,
        [FastEnumUtility.Label("MOBSKILL_MGUARDUP_M", 0)]
        [FastEnumUtility.Label("Magic Guard Up Multi", 1)]
        MagicGuardUpMulti = 113,
        [FastEnumUtility.Label("Heal Multi", 1)]
        [FastEnumUtility.Label("MOBSKILL_HEAL_M", 0)]
        HealMulti = 114,
        [FastEnumUtility.Label("Haste Multi", 1)]
        [FastEnumUtility.Label("MOBSKILL_HASTE_M", 0)]
        HasteMulti = 115,
        [FastEnumUtility.Label("MOBSKILL_SEAL", 0)]
        Seal = 120,
        [FastEnumUtility.Label("MOBSKILL_DARKNESS", 0)]
        Darkness = 121,
        [FastEnumUtility.Label("MOBSKILL_WEAKNESS", 0)]
        Weakness = 122,
        [FastEnumUtility.Label("MOBSKILL_STUN", 0)]
        Stun = 123,
        [FastEnumUtility.Label("MOBSKILL_CURSE", 0)]
        Curse = 124,
        [FastEnumUtility.Label("MOBSKILL_POISON", 0)]
        Poison = 125,
        [FastEnumUtility.Label("MOBSKILL_SLOW", 0)]
        Slow = 126,
        [FastEnumUtility.Label("MOBSKILL_DISPEL", 0)]
        Dispel = 127,
        [FastEnumUtility.Label("MOBSKILL_ATTRACT", 0)]
        Attract = 128,
        [FastEnumUtility.Label("Ban Map", 1)]
        [FastEnumUtility.Label("MOBSKILL_BANMAP", 0)]
        BanMap = 129,
        [FastEnumUtility.Label("Area Fire", 1)]
        [FastEnumUtility.Label("MOBSKILL_AREA_FIRE", 0)]
        AreaFire = 130,
        [FastEnumUtility.Label("Area Poison", 1)]
        [FastEnumUtility.Label("MOBSKILL_AREA_POISON", 0)]
        AreaPoison = 131,
        [FastEnumUtility.Label("MOBSKILL_REVERSE_INPUT", 0)]
        [FastEnumUtility.Label("Reverse Input", 1)]
        ReverseInput = 132,
        [FastEnumUtility.Label("MOBSKILL_UNDEAD", 0)]
        Undead = 133,
        [FastEnumUtility.Label("MOBSKILL_STOPPORTION", 0)]
        [FastEnumUtility.Label("Stop Potion", 1)]
        StopPotion = 134,
        [FastEnumUtility.Label("MOBSKILL_STOPMOTION", 0)]
        [FastEnumUtility.Label("Stop Motion", 1)]
        StopMotion = 135,
        [FastEnumUtility.Label("MOBSKILL_FEAR", 0)]
        Fear = 136,
        [FastEnumUtility.Label("MOBSKILL_FROZEN", 0)]
        Frozen = 137,
        [FastEnumUtility.Label("MOBSKILL_PHYSICALIMMUNE", 0)]
        [FastEnumUtility.Label("Physical Immune", 1)]
        PhysicalImmune = 140,
        [FastEnumUtility.Label("MOBSKILL_MAGICIMMUNE", 0)]
        [FastEnumUtility.Label("Magic Immune", 1)]
        MagicImmune = 141,
        [FastEnumUtility.Label("Hard Skin", 1)]
        [FastEnumUtility.Label("MOBSKILL_HARDSKIN", 0)]
        HardSkin = 142,
        [FastEnumUtility.Label("MOBSKILL_PCOUNTER", 0)]
        [FastEnumUtility.Label("Physical Counter", 1)]
        PhysicalCounter = 143,
        [FastEnumUtility.Label("MOBSKILL_MCOUNTER", 0)]
        [FastEnumUtility.Label("Magic Counter", 1)]
        MagicCounter = 144,
        [FastEnumUtility.Label("MOBSKILL_PMCOUNTER", 0)]
        [FastEnumUtility.Label("Physical Magic Counter", 1)]
        PhysicalMagicCounter = 145,
        [FastEnumUtility.Label("MOBSKILL_PAD", 0)]
        [FastEnumUtility.Label("Physical Attack Damage", 1)]
        PhysicalAttackDamage = 150,
        [FastEnumUtility.Label("MOBSKILL_MAD", 0)]
        [FastEnumUtility.Label("Magic Attack Damage", 1)]
        MagicAttackDamage = 151,
        [FastEnumUtility.Label("MOBSKILL_PDR", 0)]
        [FastEnumUtility.Label("Physical Defense Rate", 1)]
        PhysicalDefenseRate = 152,
        [FastEnumUtility.Label("MOBSKILL_MDR", 0)]
        [FastEnumUtility.Label("Magic Defense Rate", 1)]
        MagicDefenseRate = 153,
        [FastEnumUtility.Label("MOBSKILL_ACC", 0)]
        Accuracy = 154,
        [FastEnumUtility.Label("MOBSKILL_EVA", 0)]
        Evasion = 155,
        [FastEnumUtility.Label("MOBSKILL_SPEED", 0)]
        Speed = 156,
        [FastEnumUtility.Label("MOBSKILL_SEALSKILL", 0)]
        [FastEnumUtility.Label("Seal Skill", 1)]
        SealSkill = 157,
        [FastEnumUtility.Label("Balrog Counter", 1)]
        [FastEnumUtility.Label("MOBSKILL_BALROGCOUNTER", 0)]
        BalrogCounter = 158,
        [FastEnumUtility.Label("MOBSILLL_SPREADSKILLFROMUSER", 0)]
        [FastEnumUtility.Label("Spread Skill From User", 1)]
        SpreadSkillFromUser = 160,
        [FastEnumUtility.Label("Heal By Damage", 1)]
        [FastEnumUtility.Label("MOBSKILL_HEALBYDAMAGE", 0)]
        HealByDamage = 161,
        [FastEnumUtility.Label("MOBSKILL_BIND", 0)]
        Bind = 162,
        [FastEnumUtility.Label("MOBSKILL_SUMMON", 0)]
        Summon = 200,
        [FastEnumUtility.Label("MOBSKILL_SUMMON_CUBE", 0)]
        [FastEnumUtility.Label("Summon Cube", 1)]
        SummonCube = 201,
    }
    public enum MobSpecies : byte
    {
        [FastEnumUtility.Label("MOBSPECIES_BEAST", 0)]
        Beast = 0,
        [FastEnumUtility.Label("MOBSPECIES_DRAGON", 0)]
        Dragon = 1,
        [FastEnumUtility.Label("MOBSPECIES_UNDEAD", 0)]
        Undead = 2,
        [FastEnumUtility.Label("MOBSPECIES_ETC", 0)]
        Etc = 3,
        [FastEnumUtility.Label("MOBSPECIES_NO", 0)]
        None = 4,
    }
    public enum MobSuspendType : byte
    {
        [FastEnumUtility.Label("SUSPEND_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("SUSPEND_INIT", 0)]
        Init = 1,
        [FastEnumUtility.Label("SUSPEND_DIE", 0)]
        Die = 2,
        [FastEnumUtility.Label("SUSPEND_BOMB", 0)]
        Bomb = 3,
        [FastEnumUtility.Label("SUSPEND_SWALLOW", 0)]
        Swallow = 4,
    }
    public enum MobTemporaryStatType : byte
    {
        [FastEnumUtility.Label("MS_PAD", 0)]
        PAD = 0,
        [FastEnumUtility.Label("MS_PDR", 0)]
        PDR = 1,
        [FastEnumUtility.Label("MS_MAD", 0)]
        MAD = 2,
        [FastEnumUtility.Label("MS_MDR", 0)]
        MDR = 3,
        [FastEnumUtility.Label("MS_ACC", 0)]
        ACC = 4,
        [FastEnumUtility.Label("MS_EVA", 0)]
        EVA = 5,
        [FastEnumUtility.Label("MS_Speed", 0)]
        Speed = 6,
        [FastEnumUtility.Label("MS_Stun", 0)]
        Stun = 7,
        [FastEnumUtility.Label("MS_Freeze", 0)]
        Freeze = 8,
        [FastEnumUtility.Label("MS_Poison", 0)]
        Poison = 9,
        [FastEnumUtility.Label("MS_Seal", 0)]
        Seal = 10,
        [FastEnumUtility.Label("MS_Darkness", 0)]
        Darkness = 11,
        [FastEnumUtility.Label("MS_PowerUp", 0)]
        [FastEnumUtility.Label("Power Up", 1)]
        PowerUp = 12,
        [FastEnumUtility.Label("MS_MagicUp", 0)]
        [FastEnumUtility.Label("Magic Up", 1)]
        MagicUp = 13,
        [FastEnumUtility.Label("MS_PGuardUp", 0)]
        [FastEnumUtility.Label("PGuard Up", 1)]
        PGuardUp = 14,
        [FastEnumUtility.Label("MGuard Up", 1)]
        [FastEnumUtility.Label("MS_MGuardUp", 0)]
        MGuardUp = 15,
        [FastEnumUtility.Label("MS_Doom", 0)]
        Doom = 16,
        [FastEnumUtility.Label("MS_Web", 0)]
        Web = 17,
        [FastEnumUtility.Label("MS_PImmune", 0)]
        PImmune = 18,
        [FastEnumUtility.Label("MS_MImmune", 0)]
        MImmune = 19,
        [FastEnumUtility.Label("MS_Showdown", 0)]
        Showdown = 20,
        [FastEnumUtility.Label("Hard Skin", 1)]
        [FastEnumUtility.Label("MS_HardSkin", 0)]
        HardSkin = 21,
        [FastEnumUtility.Label("MS_Ambush", 0)]
        Ambush = 22,
        [FastEnumUtility.Label("Damaged Elem Attr", 1)]
        [FastEnumUtility.Label("MS_DamagedElemAttr", 0)]
        DamagedElemAttr = 23,
        [FastEnumUtility.Label("MS_Venom", 0)]
        Venom = 24,
        [FastEnumUtility.Label("MS_Blind", 0)]
        Blind = 25,
        [FastEnumUtility.Label("MS_SealSkill", 0)]
        [FastEnumUtility.Label("Seal Skill", 1)]
        SealSkill = 26,
        [FastEnumUtility.Label("MS_Burned", 0)]
        Burned = 27,
        [FastEnumUtility.Label("MS_Dazzle", 0)]
        Dazzle = 28,
        [FastEnumUtility.Label("MS_PCounter", 0)]
        PCounter = 29,
        [FastEnumUtility.Label("MS_MCounter", 0)]
        MCounter = 30,
        [FastEnumUtility.Label("MS_Disable", 0)]
        Disable = 31,
        [FastEnumUtility.Label("MS_RiseByToss", 0)]
        [FastEnumUtility.Label("Rise By Toss", 1)]
        RiseByToss = 32,
        [FastEnumUtility.Label("Body Pressure", 1)]
        [FastEnumUtility.Label("MS_BodyPressure", 0)]
        BodyPressure = 33,
        [FastEnumUtility.Label("MS_Weakness", 0)]
        Weakness = 34,
        [FastEnumUtility.Label("MS_TimeBomb", 0)]
        [FastEnumUtility.Label("Time Bomb", 1)]
        TimeBomb = 35,
        [FastEnumUtility.Label("MS_MagicCrash", 0)]
        [FastEnumUtility.Label("Magic Crash", 1)]
        MagicCrash = 36,
        [FastEnumUtility.Label("Heal By Damage", 1)]
        [FastEnumUtility.Label("MS_HealByDamage", 0)]
        HealByDamage = 37,
    }
    public enum ModifyEquipType : byte
    {
        [FastEnumUtility.Label("Enchant Skill", 1)]
        [FastEnumUtility.Label("MODIFYEQUIPTYPE_ENCHANTSKILL", 0)]
        EnchantSkill = 0,
        [FastEnumUtility.Label("MODIFYEQUIPTYPE_USER", 0)]
        User = 1,
        [FastEnumUtility.Label("MODIFYEQUIPTYPE_DRAGON", 0)]
        Dragon = 2,
        [FastEnumUtility.Label("MODIFYEQUIPTYPE_MECHANIC", 0)]
        Mechanic = 3,
        [FastEnumUtility.Label("MODIFYEQUIPTYPE_PETEQUIP", 0)]
        [FastEnumUtility.Label("Pet Equip", 1)]
        PetEquip = 4,
    }
    public enum ModifyInventoryOperationType : byte
    {
        Add = 0,
        [FastEnumUtility.Label("Update Quantity", 1)]
        UpdateQuantity = 1,
        Move = 2,
        Remove = 3,
        [FastEnumUtility.Label("Update EXP", 1)]
        UpdateEXP = 4,
    }
    [System.Flags]
    public enum ModifyStatForcedType : ushort
    {
        None = 0,
        STR = 1,
        DEX = 2,
        INT = 4,
        LUK = 8,
        PAD = 16,
        PDD = 32,
        MAD = 64,
        MDD = 128,
        ACC = 256,
        EVA = 512,
        Speed = 1024,
        Jump = 2048,
        [FastEnumUtility.Label("Speed Max", 1)]
        SpeedMax = 4096,
    }
    [System.Flags]
    public enum ModifyStatType : uint
    {
        None = 0u,
        Skin = 1u,
        Face = 2u,
        Hair = 4u,
        Pet = 8u,
        Level = 16u,
        Job = 32u,
        Str = 64u,
        Dex = 128u,
        Int = 256u,
        Luk = 512u,
        Hp = 1024u,
        [FastEnumUtility.Label("Max HP", 1)]
        MaxHp = 2048u,
        Mp = 4096u,
        [FastEnumUtility.Label("Max MP", 1)]
        MaxMp = 8192u,
        Ap = 16384u,
        Sp = 32768u,
        Exp = 65536u,
        Pop = 131072u,
        Money = 262144u,
        [FastEnumUtility.Label("Pet 2", 1)]
        Pet2 = 524288u,
        [FastEnumUtility.Label("Pet 3", 1)]
        Pet3 = 1048576u,
        [FastEnumUtility.Label("Temp EXP", 1)]
        TempExp = 2097152u,
    }
    public enum MoneyLogAction
    {
        [FastEnumUtility.Label("None", 0)]
        None = -1,
        [FastEnumUtility.Label("FieldIncome", 0)]
        FieldIncome = 0,
        [FastEnumUtility.Label("FieldOutgo", 0)]
        FieldOutgo = 1,
        [FastEnumUtility.Label("MoneyPocketIncome", 0)]
        MoneyPocketIncome = 2,
        [FastEnumUtility.Label("CouponIncome", 0)]
        CouponIncome = 3,
        [FastEnumUtility.Label("ClaimFee", 0)]
        ClaimFee = 4,
        [FastEnumUtility.Label("MarriageFee", 0)]
        MarriageFee = 5,
        [FastEnumUtility.Label("FriendFee", 0)]
        FriendFee = 6,
        [FastEnumUtility.Label("GuildFee", 0)]
        GuildFee = 7,
        [FastEnumUtility.Label("MiniGame", 0)]
        MiniGame = 8,
        [FastEnumUtility.Label("SkillFee", 0)]
        SkillFee = 9,
        [FastEnumUtility.Label("MakerFee", 0)]
        MakerFee = 10,
        [FastEnumUtility.Label("NPCShop", 0)]
        NpcShop = 11,
        [FastEnumUtility.Label("AdminShop", 0)]
        AdminShop = 12,
        [FastEnumUtility.Label("UserShop", 0)]
        UserShop = 13,
        [FastEnumUtility.Label("UserTrade", 0)]
        UserTrade = 14,
        [FastEnumUtility.Label("Trunk", 0)]
        Trunk = 15,
        [FastEnumUtility.Label("Quest", 0)]
        Quest = 16,
        [FastEnumUtility.Label("Parcel", 0)]
        Parcel = 17,
        [FastEnumUtility.Label("Script", 0)]
        Script = 18,
        [FastEnumUtility.Label("LieDetector", 0)]
        LieDetector = 19,
        [FastEnumUtility.Label("FamilyFee", 0)]
        FamilyFee = 20,
        [FastEnumUtility.Label("PartyAdverFee", 0)]
        PartyAdverFee = 21,
        [FastEnumUtility.Label("RepairDurability", 0)]
        RepairDurability = 22,
    }
    public enum MonsterCarnivalMapType : byte
    {
        [FastEnumUtility.Label("MCARNIVALS2_MAPTYPE1", 0)]
        [FastEnumUtility.Label("Map Type1", 1)]
        MapType1 = 0,
        [FastEnumUtility.Label("MCARNIVALS2_MAPTYPE2", 0)]
        [FastEnumUtility.Label("Map Type2", 1)]
        MapType2 = 1,
        [FastEnumUtility.Label("MCARNIVALS2_MAPTYPE3", 0)]
        [FastEnumUtility.Label("Map Type3", 1)]
        MapType3 = 2,
        [FastEnumUtility.Label("MCARNIVALS2_MAPTYPE_NO", 0)]
        [FastEnumUtility.Label("Map Type No", 1)]
        MapTypeNo = 3,
    }
    public enum MonsterCarnivalOperation : byte
    {
        [FastEnumUtility.Label("MCarnivalReq_SummonMob", 0)]
        [FastEnumUtility.Label("Req Summon Mob", 1)]
        ReqSummonMob = 0,
        [FastEnumUtility.Label("MCarnivalReq_UseSkill", 0)]
        [FastEnumUtility.Label("Req Use Skill", 1)]
        ReqUseSkill = 1,
        [FastEnumUtility.Label("MCarnivalReq_SummonGuardian", 0)]
        [FastEnumUtility.Label("Req Summon Guardian", 1)]
        ReqSummonGuardian = 2,
        [FastEnumUtility.Label("MCarnivalRes_Fail_CPLaking", 0)]
        [FastEnumUtility.Label("Res Fail Cp Lacking", 1)]
        ResFailCpLacking = 1,
        [FastEnumUtility.Label("MCarnivalRes_Fail_MobOverflow", 0)]
        [FastEnumUtility.Label("Res Fail Mob Overflow", 1)]
        ResFailMobOverflow = 2,
        [FastEnumUtility.Label("MCarnivalRes_Fail_GuardianOverflow", 0)]
        [FastEnumUtility.Label("Res Fail Guardian Overflow", 1)]
        ResFailGuardianOverflow = 3,
        [FastEnumUtility.Label("MCarnivalRes_Fail_GuardianAlreadySummoned", 0)]
        [FastEnumUtility.Label("Res Fail Guardian Already Summoned", 1)]
        ResFailGuardianAlreadySummoned = 4,
        [FastEnumUtility.Label("MCarnivalRes_Fail_Unknown", 0)]
        [FastEnumUtility.Label("Res Fail Unknown", 1)]
        ResFailUnknown = 5,
        [FastEnumUtility.Label("MCarnivalOut_PartyBoss", 0)]
        [FastEnumUtility.Label("Out Party Boss", 1)]
        OutPartyBoss = 6,
        [FastEnumUtility.Label("MCarnivalOut_PartyMember", 0)]
        [FastEnumUtility.Label("Out Party Member", 1)]
        OutPartyMember = 7,
        [FastEnumUtility.Label("Game Res Win", 1)]
        [FastEnumUtility.Label("MCarnivalGameRes_Win", 0)]
        GameResWin = 8,
        [FastEnumUtility.Label("Game Res Lose", 1)]
        [FastEnumUtility.Label("MCarnivalGameRes_Lose", 0)]
        GameResLose = 9,
        [FastEnumUtility.Label("Game Res Draw", 1)]
        [FastEnumUtility.Label("MCarnivalGameRes_Draw", 0)]
        GameResDraw = 10,
        [FastEnumUtility.Label("Game Res Cancel", 1)]
        [FastEnumUtility.Label("MCarnivalGameRes_Cancel", 0)]
        GameResCancel = 11,
    }
    public enum MonsterCarnivalTeam : byte
    {
        [FastEnumUtility.Label("MCARNIVAL_TEAM_NONE", 0)]
        None = 255,
        [FastEnumUtility.Label("MCARNIVAL_TEAM_RED", 0)]
        Red = 0,
        [FastEnumUtility.Label("MCARNIVAL_TEAM_BLUE", 0)]
        Blue = 1,
    }
    public enum MorphActionType : byte
    {
        [FastEnumUtility.Label("MORPHACT_WALK", 0)]
        Walk = 0,
        [FastEnumUtility.Label("MORPHACT_STAND", 0)]
        Stand = 1,
        [FastEnumUtility.Label("MORPHACT_JUMP", 0)]
        Jump = 2,
        [FastEnumUtility.Label("MORPHACT_ALERT", 0)]
        Alert = 3,
        [FastEnumUtility.Label("MORPHACT_ALERT2", 0)]
        Alert2 = 4,
        [FastEnumUtility.Label("MORPHACT_ALERT3", 0)]
        Alert3 = 5,
        [FastEnumUtility.Label("MORPHACT_ALERT4", 0)]
        Alert4 = 6,
        [FastEnumUtility.Label("MORPHACT_FLY", 0)]
        Fly = 7,
        [FastEnumUtility.Label("MORPHACT_PRONE", 0)]
        Prone = 8,
        [FastEnumUtility.Label("MORPHACT_LADDER", 0)]
        Ladder = 9,
        [FastEnumUtility.Label("MORPHACT_ROPE", 0)]
        Rope = 10,
        [FastEnumUtility.Label("MORPHACT_DEAD", 0)]
        Dead = 11,
        [FastEnumUtility.Label("MORPHACT_SIT", 0)]
        Sit = 12,
        [FastEnumUtility.Label("MORPHACT_SWINGO1", 0)]
        [FastEnumUtility.Label("Swing O1", 1)]
        SwingO1 = 13,
        [FastEnumUtility.Label("MORPHACT_SWINGO2", 0)]
        [FastEnumUtility.Label("Swing O2", 1)]
        SwingO2 = 14,
        [FastEnumUtility.Label("MORPHACT_SWINGO3", 0)]
        [FastEnumUtility.Label("Swing O3", 1)]
        SwingO3 = 15,
        [FastEnumUtility.Label("MORPHACT_SWINGT1", 0)]
        [FastEnumUtility.Label("Swing T1", 1)]
        SwingT1 = 16,
        [FastEnumUtility.Label("MORPHACT_SWINGT3", 0)]
        [FastEnumUtility.Label("Swing T3", 1)]
        SwingT3 = 17,
        [FastEnumUtility.Label("MORPHACT_SHOOT1", 0)]
        Shoot1 = 18,
        [FastEnumUtility.Label("MORPHACT_SHOOTF", 0)]
        [FastEnumUtility.Label("Shoot F", 1)]
        ShootF = 19,
        [FastEnumUtility.Label("MORPHACT_PRONESTAB", 0)]
        [FastEnumUtility.Label("Prone Stab", 1)]
        ProneStab = 20,
        [FastEnumUtility.Label("MORPHACT_STABO1", 0)]
        [FastEnumUtility.Label("Stab O1", 1)]
        StabO1 = 21,
        [FastEnumUtility.Label("MORPHACT_STABO2", 0)]
        [FastEnumUtility.Label("Stab O2", 1)]
        StabO2 = 22,
        [FastEnumUtility.Label("MORPHACT_STABTF", 0)]
        [FastEnumUtility.Label("Stab TF", 1)]
        StabTF = 23,
        [FastEnumUtility.Label("MORPHACT_TIMELEAP", 0)]
        [FastEnumUtility.Label("Time Leap", 1)]
        TimeLeap = 24,
        [FastEnumUtility.Label("MORPHACT_EBURSTER", 0)]
        EBurster = 25,
        [FastEnumUtility.Label("MORPHACT_EDRAIN", 0)]
        EDrain = 26,
        [FastEnumUtility.Label("MORPHACT_LADDER2", 0)]
        Ladder2 = 27,
        [FastEnumUtility.Label("MORPHACT_ROPE2", 0)]
        Rope2 = 28,
        [FastEnumUtility.Label("MORPHACT_STORM_BREAK", 0)]
        [FastEnumUtility.Label("Storm Break", 1)]
        StormBreak = 29,
        [FastEnumUtility.Label("Double Fire", 1)]
        [FastEnumUtility.Label("MORPHACT_DOUBLEFIRE", 0)]
        DoubleFire = 30,
        [FastEnumUtility.Label("MORPHACT_SOMERSAULT", 0)]
        Somersault = 31,
        [FastEnumUtility.Label("MORPHACT_STRAIGHT", 0)]
        Straight = 32,
        [FastEnumUtility.Label("MORPHACT_SCREW", 0)]
        Screw = 33,
        [FastEnumUtility.Label("Double Upper", 1)]
        [FastEnumUtility.Label("MORPHACT_DOUBLEUPPER", 0)]
        DoubleUpper = 34,
        [FastEnumUtility.Label("Back Spin", 1)]
        [FastEnumUtility.Label("MORPHACT_BACKSPIN", 0)]
        BackSpin = 35,
        [FastEnumUtility.Label("MORPHACT_EORB", 0)]
        EOrb = 36,
        [FastEnumUtility.Label("MORPHACT_FIST", 0)]
        Fist = 37,
        [FastEnumUtility.Label("Dragon Strike", 1)]
        [FastEnumUtility.Label("MORPHACT_DRAGONSTRIKE", 0)]
        DragonStrike = 38,
        [FastEnumUtility.Label("MORPHACT_RECOVERY", 0)]
        Recovery = 39,
        [FastEnumUtility.Label("MORPHACT_WAVE", 0)]
        Wave = 40,
        [FastEnumUtility.Label("MORPHACT_FLY2", 0)]
        Fly2 = 41,
        [FastEnumUtility.Label("MORPHACT_FLY2_MOVE", 0)]
        Fly2Move = 42,
        [FastEnumUtility.Label("MORPHACT_FLY2_SKILL", 0)]
        Fly2Skill = 43,
        [FastEnumUtility.Label("MORPHACT_SHOCKWAVE", 0)]
        Shockwave = 44,
        [FastEnumUtility.Label("MORPHACT_DEMOLITION", 0)]
        Demolition = 45,
        [FastEnumUtility.Label("MORPHACT_SNATCH", 0)]
        Snatch = 46,
        [FastEnumUtility.Label("MORPHACT_WIND_SPEAR", 0)]
        [FastEnumUtility.Label("Wind Spear", 1)]
        WindSpear = 47,
        [FastEnumUtility.Label("MORPHACT_WIND_SHOT", 0)]
        [FastEnumUtility.Label("Wind Shot", 1)]
        WindShot = 48,
    }
    public enum MovableTerrainType : byte
    {
        [FastEnumUtility.Label("MOVABLE_EARTH", 0)]
        Earth = 0,
        [FastEnumUtility.Label("MOVABLE_WATER", 0)]
        Water = 1,
        [FastEnumUtility.Label("MOVABLE_BOTH", 0)]
        Both = 2,
    }
    public enum MoveActionDirection : byte
    {
        Right = 0,
        Left = 1,
    }
    public enum MoveActionType : byte
    {
        [FastEnumUtility.Label("MA_MOVE", 3)]
        [FastEnumUtility.Label("MA_WALK", 0)]
        [FastEnumUtility.Label("walk1", 2)]
        Walk = 1,
        [FastEnumUtility.Label("MA_STAND", 0)]
        [FastEnumUtility.Label("stand1", 2)]
        Stand = 2,
        [FastEnumUtility.Label("MA_JUMP", 0)]
        [FastEnumUtility.Label("jump", 2)]
        Jump = 3,
        [FastEnumUtility.Label("MA_ALERT", 0)]
        [FastEnumUtility.Label("alert", 2)]
        Alert = 4,
        [FastEnumUtility.Label("MA_PRONE", 0)]
        [FastEnumUtility.Label("prone", 2)]
        Prone = 5,
        [FastEnumUtility.Label("MA_FLY1", 0)]
        [FastEnumUtility.Label("fly", 2)]
        Fly1 = 6,
        [FastEnumUtility.Label("MA_LADDER", 0)]
        [FastEnumUtility.Label("ladder", 2)]
        Ladder = 7,
        [FastEnumUtility.Label("MA_ROPE", 0)]
        [FastEnumUtility.Label("rope", 2)]
        Rope = 8,
        [FastEnumUtility.Label("MA_DEAD", 0)]
        [FastEnumUtility.Label("dead", 2)]
        Dead = 9,
        [FastEnumUtility.Label("MA_SIT", 0)]
        [FastEnumUtility.Label("sit", 2)]
        Sit = 10,
        [FastEnumUtility.Label("MA_STAND0", 0)]
        [FastEnumUtility.Label("stand0", 2)]
        Stand0 = 11,
        [FastEnumUtility.Label("MA_HUNGRY", 0)]
        [FastEnumUtility.Label("hungry", 2)]
        Hungry = 12,
        [FastEnumUtility.Label("MA_REST0", 0)]
        [FastEnumUtility.Label("rest0", 2)]
        Rest0 = 13,
        [FastEnumUtility.Label("MA_REST1", 0)]
        [FastEnumUtility.Label("rest1", 2)]
        Rest1 = 14,
        [FastEnumUtility.Label("MA_HANG", 0)]
        [FastEnumUtility.Label("hang", 2)]
        Hang = 15,
        [FastEnumUtility.Label("MA_CHASE", 0)]
        Chase = 16,
        [FastEnumUtility.Label("MA_FLY2", 0)]
        Fly2 = 17,
        [FastEnumUtility.Label("MA_FLY2_MOVE", 0)]
        Fly2Move = 18,
        [FastEnumUtility.Label("MA_DASH2", 0)]
        Dash2 = 19,
        [FastEnumUtility.Label("MA_ROCKET_BOOSTER", 0)]
        [FastEnumUtility.Label("Rocket Booster", 1)]
        RocketBooster = 20,
        [FastEnumUtility.Label("MA_TESLA_COIL_TRIANGLE", 0)]
        [FastEnumUtility.Label("Tesla Coil Triangle", 1)]
        TeslaCoilTriangle = 21,
    }
    public enum MovePathFragmentType : byte
    {
        Normal = 0,
        Jump = 1,
        Impact = 2,
        Immediate = 3,
        Teleport = 4,
        [FastEnumUtility.Label("Hang On Back", 1)]
        HangOnBack = 5,
        Assaulter = 6,
        Assassination = 7,
        Rush = 8,
        [FastEnumUtility.Label("Stat Change", 1)]
        StatChange = 9,
        [FastEnumUtility.Label("Start Fall Down", 1)]
        StartFallDown = 10,
        [FastEnumUtility.Label("Fall Down", 1)]
        FallDown = 11,
        [FastEnumUtility.Label("Start Wings", 1)]
        StartWings = 12,
        Wings = 13,
        [FastEnumUtility.Label("Aran Adjust", 1)]
        AranAdjust = 14,
        [FastEnumUtility.Label("Mob Toss", 1)]
        MobToss = 15,
        [FastEnumUtility.Label("Flying Block", 1)]
        FlyingBlock = 16,
        [FastEnumUtility.Label("Dash Slide", 1)]
        DashSlide = 17,
        [FastEnumUtility.Label("BMage Adjust", 1)]
        BmageAdjust = 18,
        [FastEnumUtility.Label("Flash Jump", 1)]
        FlashJump = 19,
        [FastEnumUtility.Label("Rocket Booster", 1)]
        RocketBooster = 20,
        [FastEnumUtility.Label("Back Step Shot", 1)]
        BackStepShot = 21,
        [FastEnumUtility.Label("Mob Power Knock Back", 1)]
        MobPowerKnockBack = 22,
        [FastEnumUtility.Label("Vertical Jump", 1)]
        VerticalJump = 23,
        [FastEnumUtility.Label("Custom Impact", 1)]
        CustomImpact = 24,
        [FastEnumUtility.Label("Combat Step", 1)]
        CombatStep = 25,
        Hit = 26,
        [FastEnumUtility.Label("Time Bomb Attack", 1)]
        TimeBombAttack = 27,
        [FastEnumUtility.Label("Snowball Touch", 1)]
        SnowballTouch = 28,
        [FastEnumUtility.Label("Buff Zone Effect", 1)]
        BuffZoneEffect = 29,
        [FastEnumUtility.Label("Mob Ladder", 1)]
        MobLadder = 30,
        [FastEnumUtility.Label("Mob Right Angle", 1)]
        MobRightAngle = 31,
        [FastEnumUtility.Label("Mob Stop Node Start", 1)]
        MobStopNodeStart = 32,
        [FastEnumUtility.Label("Mob Before Node", 1)]
        MobBeforeNode = 33,
        [FastEnumUtility.Label("Mob Attack Rush", 1)]
        MobAttackRush = 34,
        [FastEnumUtility.Label("Mob Attack Rush Stop", 1)]
        MobAttackRushStop = 35,
    }
    public enum NewCharEquipType : byte
    {
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_FACE", 0)]
        Face = 0,
        [FastEnumUtility.Label("Hair Style", 1)]
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_HAIRSTYLE", 0)]
        HairStyle = 1,
        [FastEnumUtility.Label("Hair Color", 1)]
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_HAIRCOLOR", 0)]
        HairColor = 2,
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_SKINCOLOR", 0)]
        [FastEnumUtility.Label("Skin Color", 1)]
        SkinColor = 3,
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_CLOTHES", 0)]
        Clothes = 4,
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_PANTS", 0)]
        Pants = 5,
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_SHOES", 0)]
        Shoes = 6,
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_WEAPON", 0)]
        Weapon = 7,
        [FastEnumUtility.Label("NEWCHAR_EQUIP_TYPE_GENDER", 0)]
        Gender = 8,
    }
    public enum NewYearCardOperation : byte
    {
        [FastEnumUtility.Label("NewYearCardReq_Send", 0)]
        [FastEnumUtility.Label("Req Send", 1)]
        ReqSend = 0,
        [FastEnumUtility.Label("NewYearCardReq_Receive", 0)]
        [FastEnumUtility.Label("Req Receive", 1)]
        ReqReceive = 1,
        [FastEnumUtility.Label("NewYearCardReq_Delete", 0)]
        [FastEnumUtility.Label("Req Delete", 1)]
        ReqDelete = 2,
        [FastEnumUtility.Label("NewYearCardReq_GetUnreceivedList", 0)]
        [FastEnumUtility.Label("Req Get Unreceived List", 1)]
        ReqGetUnreceivedList = 3,
        [FastEnumUtility.Label("NewYearCardRes_Send_Done", 0)]
        [FastEnumUtility.Label("Res Send Done", 1)]
        ResSendDone = 4,
        [FastEnumUtility.Label("NewYearCardRes_Send_Failed", 0)]
        [FastEnumUtility.Label("Res Send Failed", 1)]
        ResSendFailed = 5,
        [FastEnumUtility.Label("NewYearCardRes_Receive_Done", 0)]
        [FastEnumUtility.Label("Res Receive Done", 1)]
        ResReceiveDone = 6,
        [FastEnumUtility.Label("NewYearCardRes_Receive_Failed", 0)]
        [FastEnumUtility.Label("Res Receive Failed", 1)]
        ResReceiveFailed = 7,
        [FastEnumUtility.Label("NewYearCardRes_Delete_Done", 0)]
        [FastEnumUtility.Label("Res Delete Done", 1)]
        ResDeleteDone = 8,
        [FastEnumUtility.Label("NewYearCardRes_Delete_Failed", 0)]
        [FastEnumUtility.Label("Res Delete Failed", 1)]
        ResDeleteFailed = 9,
        [FastEnumUtility.Label("NewYearCardRes_GetUnreceivedList_Done", 0)]
        [FastEnumUtility.Label("Res Get Unreceived List Done", 1)]
        ResGetUnreceivedListDone = 10,
        [FastEnumUtility.Label("NewYearCardRes_GetUnreceivedList_Failed", 0)]
        [FastEnumUtility.Label("Res Get Unreceived List Failed", 1)]
        ResGetUnreceivedListFailed = 11,
        [FastEnumUtility.Label("NewYearCardRes_NotiArrived", 0)]
        [FastEnumUtility.Label("Res Noti Arrived", 1)]
        ResNotiArrived = 12,
        [FastEnumUtility.Label("NewYearCardRes_BroadCast_AddCardInfo", 0)]
        [FastEnumUtility.Label("Res Broad Cast Add Card Info", 1)]
        ResBroadCastAddCardInfo = 13,
        [FastEnumUtility.Label("NewYearCardRes_BroadCast_RemoveCardInfo", 0)]
        [FastEnumUtility.Label("Res Broad Cast Remove Card Info", 1)]
        ResBroadCastRemoveCardInfo = 14,
        [FastEnumUtility.Label("Fail Cannot Send To Self", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_CannotSendToSelf", 0)]
        FailCannotSendToSelf = 15,
        [FastEnumUtility.Label("Fail No Free Slot", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_NoFreeSlot", 0)]
        FailNoFreeSlot = 16,
        [FastEnumUtility.Label("Fail Not A New Year Card", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_NotANewYearCard", 0)]
        FailNotANewYearCard = 17,
        [FastEnumUtility.Label("Fail Incoherent Item", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_IncoherentItem", 0)]
        FailIncoherentItem = 18,
        [FastEnumUtility.Label("Fail Target Not Exist", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_TargetNotExist", 0)]
        FailTargetNotExist = 19,
        [FastEnumUtility.Label("Fail Incoherent Data", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_IncoherentData", 0)]
        FailIncoherentData = 20,
        [FastEnumUtility.Label("Fail Db Error", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_DBError", 0)]
        FailDbError = 21,
        [FastEnumUtility.Label("Fail Unknown Error", 1)]
        [FastEnumUtility.Label("NewYearCardFailReason_UnknownError", 0)]
        FailUnknownError = 22,
    }
    public enum NexonServerType : byte
    {
        [FastEnumUtility.Label("UNDEFINED_SERVER", 0)]
        Undefined = 0,
        [FastEnumUtility.Label("LOGIN_SERVER", 0)]
        Login = 1,
        [FastEnumUtility.Label("SESSION_SERVER", 0)]
        Session = 2,
        [FastEnumUtility.Label("STAT_SERVER", 0)]
        Stat = 3,
        [FastEnumUtility.Label("GATEWAY_SERVER", 0)]
        Gateway = 4,
        [FastEnumUtility.Label("APP_SERVER", 0)]
        App = 5,
        [FastEnumUtility.Label("CHANNEL_SERVER", 0)]
        Channel = 6,
        [FastEnumUtility.Label("RELAY_SERVER", 0)]
        Relay = 7,
        [FastEnumUtility.Label("AUTH_SERVER", 0)]
        Auth = 16,
    }
    public enum NitType : byte
    {
        [FastEnumUtility.Label("NIT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("NIT_HAIR", 0)]
        Hair = 1,
        [FastEnumUtility.Label("NIT_FACE", 0)]
        Face = 2,
        [FastEnumUtility.Label("NIT_SKIN", 0)]
        Skin = 3,
    }
    public enum NmAuthCheckModuleType : byte
    {
        [FastEnumUtility.Label("kAuthCheckModuleType_Unknown", 0)]
        Unknown = 0,
        [FastEnumUtility.Label("kAuthCheckModuleType_NexonPassport", 0)]
        NexonPassport = 1,
        [FastEnumUtility.Label("kAuthCheckModuleType_SpServer", 0)]
        SpServer = 2,
    }
    [System.Flags]
    public enum NmCategoryProperty : byte
    {
        None = 0,
        [FastEnumUtility.Label("kCateProp_DefaultCategory", 0)]
        DefaultCategory = 1,
        [FastEnumUtility.Label("kCateProp_CateNotDelete", 0)]
        CategoryNotDelete = 2,
        [FastEnumUtility.Label("kCateProp_CateNotRename", 0)]
        CategoryNotRename = 4,
        [FastEnumUtility.Label("kCateProp_UserNotAdd", 0)]
        UserNotAdd = 8,
        [FastEnumUtility.Label("kCateProp_UserNotDelete", 0)]
        UserNotDelete = 16,
    }
    public enum NmGuildType : byte
    {
        [FastEnumUtility.Label("kGuildType_None", 0)]
        None = 0,
        [FastEnumUtility.Label("kGuildType_NexonDefault", 0)]
        NexonDefault = 1,
        [FastEnumUtility.Label("kGuildType_NexonNew", 0)]
        NexonNew = 2,
        [FastEnumUtility.Label("kGuildType_CSO", 0)]
        Cso = 3,
    }
    public enum NmLoginAuthReplyCode
    {
        [FastEnumUtility.Label("kLoginAuth_OK", 0)]
        Ok = 0,
        [FastEnumUtility.Label("kLoginAuth_ServerFailed", 0)]
        ServerFailed = 20000,
        [FastEnumUtility.Label("kLoginAuth_ServiceShutdown", 0)]
        ServiceShutdown = 20002,
        [FastEnumUtility.Label("kLoginAuth_NotAllowedLocale", 0)]
        NotAllowedLocale = 20003,
        [FastEnumUtility.Label("kLoginAuth_WrongID", 0)]
        WrongId = 20006,
        [FastEnumUtility.Label("kLoginAuth_BlockedIP", 0)]
        BlockedIp = 20007,
        [FastEnumUtility.Label("kLoginAuth_TempBlockedByLoginFail", 0)]
        TempBlockedByLoginFail = 20008,
        [FastEnumUtility.Label("kLoginAuth_TempBlockedByWarning", 0)]
        TempBlockedByWarning = 20009,
        [FastEnumUtility.Label("kLoginAuth_BlockedByAdmin", 0)]
        BlockedByAdmin = 20010,
        [FastEnumUtility.Label("kLoginAuth_InvalidPassport", 0)]
        InvalidPassport = 20015,
        [FastEnumUtility.Label("kLoginAuth_NotAllowedServer", 0)]
        NotAllowedServer = 20021,
        [FastEnumUtility.Label("kLoginAuth_UserNotExists", 0)]
        UserNotExists = 20025,
        [FastEnumUtility.Label("kLoginAuth_WrongPassword", 0)]
        WrongPassword = 20026,
        [FastEnumUtility.Label("kLoginAuth_WithdrawnUser", 0)]
        WithdrawnUser = 20027,
        [FastEnumUtility.Label("kLoginAuth_WrongOwner", 0)]
        WrongOwner = 20028,
        [FastEnumUtility.Label("kLoginAuth_GameServerInspection", 0)]
        GameServerInspection = 20030,
        [FastEnumUtility.Label("kLoginAuth_TempUserLoginBlocked", 0)]
        TempUserLoginBlocked = 20031,
        [FastEnumUtility.Label("kLoginAuth_NeedMatrixLogin", 0)]
        NeedMatrixLogin = 20032,
        [FastEnumUtility.Label("kLoginAuth_WrongMatrixData", 0)]
        WrongMatrixData = 20033,
        [FastEnumUtility.Label("kLoginAuth_DeactivatedAccount", 0)]
        DeactivatedAccount = 20036,
        [FastEnumUtility.Label("kLoginAuth_ModuleNotInitialized", 0)]
        ModuleNotInitialized = 30002,
        [FastEnumUtility.Label("kLoginAuth_ModuleInitializeFailed", 0)]
        ModuleInitializeFailed = 30003,
    }
    public enum NmMessengerReplyCode
    {
        [FastEnumUtility.Label("kMessengerReplyOK", 0)]
        Ok = 0,
        [FastEnumUtility.Label("kMessengerReplyNewUser", 0)]
        NewUser = 1,
        [FastEnumUtility.Label("kMessengerReplyNotMine", 0)]
        NotMine = -1,
        [FastEnumUtility.Label("kMessengerReplyWrongId", 0)]
        WrongId = -2,
        [FastEnumUtility.Label("kMessengerReplyWrongPwd", 0)]
        WrongPassword = -3,
        [FastEnumUtility.Label("kMessengerReplyWrongClientVersion", 0)]
        WrongClientVersion = -4,
        [FastEnumUtility.Label("kMessengerReplyWrongMsgVersion", 0)]
        WrongMsgVersion = -5,
        [FastEnumUtility.Label("kMessengerReplyServiceShutdown", 0)]
        ServiceShutdown = -6,
        [FastEnumUtility.Label("kMessengerReplyLockedByAnotherProcess", 0)]
        LockedByAnotherProcess = -7,
        [FastEnumUtility.Label("kMessengerReplySwitchSA", 0)]
        SwitchSa = -8,
        [FastEnumUtility.Label("kMessengerReplyWrongOwner", 0)]
        WrongOwner = -9,
        [FastEnumUtility.Label("kMessengerReplyBlockByAdmin", 0)]
        BlockedByAdmin = -10,
        [FastEnumUtility.Label("kMessengerReplyTempBlockByWarning", 0)]
        TempBlockedByWarning = -11,
        [FastEnumUtility.Label("kMessengerReplyTempBlockByLoginFail", 0)]
        TempBlockedByLoginFail = -12,
        [FastEnumUtility.Label("kMessengerReplyMabiInfoSoapFail", 0)]
        MabiInfoSoapFailed = -13,
        [FastEnumUtility.Label("kMessengerReplyWrongPassport", 0)]
        WrongPassport = -14,
        [FastEnumUtility.Label("kMessengerReplyBlockedIp", 0)]
        BlockedIp = -15,
        [FastEnumUtility.Label("kMessengerReplyTempUser", 0)]
        TempUser = -16,
        [FastEnumUtility.Label("kMessengerReplyNotAuthenticated", 0)]
        NotAuthenticated = -17,
        [FastEnumUtility.Label("kMessengerReplyInvalidExternalPassportType", 0)]
        InvalidExternalPassportType = -18,
        [FastEnumUtility.Label("kMessengerReplyExternalPassportDecoderNotImplemented", 0)]
        ExternalPassportDecoderNotImplemented = -19,
        [FastEnumUtility.Label("kMessengerReplyExternalPassportDecodingFailed", 0)]
        ExternalPassportDecodingFailed = -20,
        [FastEnumUtility.Label("kMessengerReplyWrongExternalPassport", 0)]
        WrongExternalPassport = -21,
        [FastEnumUtility.Label("kMessengerReplyServerFailed", 0)]
        ServerFailed = -99,
    }
    public enum NmP2PErrorCode
    {
        [FastEnumUtility.Label("kP2PError_OK", 0)]
        Ok = 0,
        [FastEnumUtility.Label("kP2PError_AlreadyInitialized", 0)]
        AlreadyInitialized = 1,
        [FastEnumUtility.Label("kP2PError_Failed", 0)]
        Failed = -1,
        [FastEnumUtility.Label("kP2PError_NotLoggedIn", 0)]
        NotLoggedIn = -2,
        [FastEnumUtility.Label("kP2PError_NotInitialized", 0)]
        NotInitialized = -3,
        [FastEnumUtility.Label("kP2PError_InvalidConnection", 0)]
        InvalidConnection = -4,
        [FastEnumUtility.Label("kP2PError_InvalidServerInfo", 0)]
        InvalidServerInfo = -5,
        [FastEnumUtility.Label("kP2PError_InternalError", 0)]
        InternalError = -6,
        [FastEnumUtility.Label("kP2PError_NotOnline", 0)]
        NotOnline = -7,
        [FastEnumUtility.Label("kP2PError_NotExists", 0)]
        NotExists = -8,
        [FastEnumUtility.Label("kP2PError_SenderMismatch", 0)]
        SenderMismatch = -9,
        [FastEnumUtility.Label("kP2PError_ReceiverMismatch", 0)]
        ReceiverMismatch = -10,
    }
    public enum NmP2PReplyCode
    {
        [FastEnumUtility.Label("kP2PReply_OK", 0)]
        Ok = 0,
        [FastEnumUtility.Label("kP2PReply_ServerFailed", 0)]
        ServerFailed = -1,
        [FastEnumUtility.Label("kP2PReply_CreateRelayObjectFail", 0)]
        CreateRelayObjectFailed = -2,
        [FastEnumUtility.Label("kP2PReply_NotAuthenticated", 0)]
        NotAuthenticated = -3,
        [FastEnumUtility.Label("kP2PReply_NotMine", 0)]
        NotMine = -4,
    }
    public enum NmP2PStatus : byte
    {
        [FastEnumUtility.Label("kP2PStatus_Unknown", 0)]
        Unknown = 0,
        [FastEnumUtility.Label("kP2PStatus_Online", 0)]
        Online = 10,
        [FastEnumUtility.Label("kP2PStatus_Offline", 0)]
        Offline = 11,
    }
    public enum NmSessionType : byte
    {
        [FastEnumUtility.Label("kSessionType_General", 0)]
        General = 0,
        [FastEnumUtility.Label("kSessionType_Chat", 0)]
        Chat = 1,
        [FastEnumUtility.Label("kSessionType_FileUpload", 0)]
        FileUpload = 2,
        [FastEnumUtility.Label("kSessionType_FileDownload", 0)]
        FileDownload = 3,
        [FastEnumUtility.Label("kSessionType_WhiteBoard", 0)]
        WhiteBoard = 4,
    }
    public enum NmSexType : byte
    {
        [FastEnumUtility.Label("kSex_Unknown", 0)]
        Unknown = 0,
        [FastEnumUtility.Label("kSex_Male", 0)]
        Male = 1,
        [FastEnumUtility.Label("kSex_Female", 0)]
        Female = 2,
    }
    public enum NmUrlPage : byte
    {
        [FastEnumUtility.Label("kURL_NULL", 0)]
        Null = 0,
        [FastEnumUtility.Label("kURL_MainHome", 0)]
        MainHome = 1,
        [FastEnumUtility.Label("kURL_WebGameHome", 0)]
        WebGameHome = 2,
        [FastEnumUtility.Label("kURL_RPGGameHome", 0)]
        RpgGameHome = 3,
        [FastEnumUtility.Label("kURL_CasualGameHome", 0)]
        CasualGameHome = 4,
        [FastEnumUtility.Label("kURL_ClubHome", 0)]
        ClubHome = 5,
        [FastEnumUtility.Label("kURL_PlazaHome", 0)]
        PlazaHome = 6,
        [FastEnumUtility.Label("kURL_ItemMallHome", 0)]
        ItemMallHome = 7,
        [FastEnumUtility.Label("kURL_MyPage", 0)]
        MyPage = 8,
        [FastEnumUtility.Label("kURL_Support", 0)]
        Support = 9,
        [FastEnumUtility.Label("kURL_Help", 0)]
        Help = 10,
        [FastEnumUtility.Label("kURL_Register", 0)]
        Register = 11,
        [FastEnumUtility.Label("kURL_MyGiftBox", 0)]
        MyGiftBox = 12,
        [FastEnumUtility.Label("kURL_NXPaybill", 0)]
        NxPaybill = 13,
        [FastEnumUtility.Label("kURL_MemberPopup_OID", 0)]
        MemberPopupByOid = 14,
        [FastEnumUtility.Label("kURL_AgreementPopup", 0)]
        AgreementPopup = 15,
        [FastEnumUtility.Label("kURL_PrivacyPopup", 0)]
        PrivacyPopup = 16,
        [FastEnumUtility.Label("kURL_SearchIDPopup", 0)]
        SearchIdPopup = 17,
        [FastEnumUtility.Label("kURL_SearchPass", 0)]
        SearchPass = 18,
        [FastEnumUtility.Label("kURL_MoneyRefillForWebGame", 0)]
        MoneyRefillForWebGame = 19,
        [FastEnumUtility.Label("kURL_MyRoomForWegGame", 0)]
        MyRoomForWebGame = 20,
        [FastEnumUtility.Label("kURL_ChangeClothes", 0)]
        ChangeClothes = 21,
        [FastEnumUtility.Label("kURL_ChangeMyInfo", 0)]
        ChangeMyInfo = 22,
        [FastEnumUtility.Label("kURL_MailHome", 0)]
        MailHome = 23,
        [FastEnumUtility.Label("kURL_WriteMail_General", 0)]
        WriteMailGeneral = 24,
        [FastEnumUtility.Label("kURL_WriteMail_Target", 0)]
        WriteMailTarget = 25,
        [FastEnumUtility.Label("kURL_MemberPopup_LoginID", 0)]
        MemberPopupByLoginId = 26,
        [FastEnumUtility.Label("kURL_Penalty", 0)]
        Penalty = 27,
        [FastEnumUtility.Label("kURL_KartBox_OID", 0)]
        KartBoxByOid = 28,
        [FastEnumUtility.Label("kURL_KartBox_RiderID", 0)]
        KartBoxByRiderId = 29,
        [FastEnumUtility.Label("kURL_KartBox_RiderName", 0)]
        KartBoxByRiderName = 30,
        [FastEnumUtility.Label("kURL_NGMInstallGuide", 0)]
        NgmInstallGuide = 31,
    }
    public enum NmUrlType : byte
    {
        [FastEnumUtility.Label("kURLType_NULL", 0)]
        Null = 0,
        [FastEnumUtility.Label("kURLType_Page", 0)]
        Page = 1,
        [FastEnumUtility.Label("kURLType_Game", 0)]
        Game = 2,
        [FastEnumUtility.Label("kURLType_Guild", 0)]
        Guild = 3,
        [FastEnumUtility.Label("kURLType_DirectURL", 0)]
        DirectUrl = 4,
    }
    public enum NmUserStatus : byte
    {
        [FastEnumUtility.Label("kStatus_Unknown", 0)]
        Unknown = 0,
        [FastEnumUtility.Label("kStatus_Online", 0)]
        Online = 10,
        [FastEnumUtility.Label("kStatus_Busy", 0)]
        Busy = 11,
        [FastEnumUtility.Label("kStatus_Away", 0)]
        Away = 12,
        [FastEnumUtility.Label("kStatus_AppearOffline", 0)]
        AppearOffline = 13,
        [FastEnumUtility.Label("kStatus_Offline", 0)]
        Offline = 14,
        [FastEnumUtility.Label("kStatus_GameOnline", 0)]
        GameOnline = 15,
        [FastEnumUtility.Label("kStatus_Error", 0)]
        Error = 16,
        [FastEnumUtility.Label("kStatus_Authenticated", 0)]
        Authenticated = 17,
    }
    public enum NotificationPopupType : byte
    {
        [FastEnumUtility.Label("MSMInvite", 0)]
        MessengerInvite = 0,
        [FastEnumUtility.Label("FriendReq", 0)]
        FriendRequest = 1,
        [FastEnumUtility.Label("TradeInvite", 0)]
        TradeInvite = 2,
        [FastEnumUtility.Label("CashTradeInvite", 0)]
        CashTradeInvite = 3,
        [FastEnumUtility.Label("NewMemo", 0)]
        NewMemo = 4,
        [FastEnumUtility.Label("PartyInvite", 0)]
        PartyInvite = 5,
        [FastEnumUtility.Label("AllianceInvite", 0)]
        AllianceInvite = 6,
        [FastEnumUtility.Label("QuestClear", 0)]
        QuestClear = 7,
        [FastEnumUtility.Label("GuildInvite", 0)]
        GuildInvite = 8,
        [FastEnumUtility.Label("UserAlarm", 0)]
        UserAlarm = 9,
        [FastEnumUtility.Label("ParcelAlarm", 0)]
        ParcelAlarm = 10,
        [FastEnumUtility.Label("PartyQuestAlarm", 0)]
        PartyQuestAlarm = 11,
        [FastEnumUtility.Label("FamilyInvite", 0)]
        FamilyInvite = 12,
        [FastEnumUtility.Label("PartyApply", 0)]
        PartyApply = 13,
        [FastEnumUtility.Label("ExpeditionInvite", 0)]
        ExpeditionInvite = 14,
        [FastEnumUtility.Label("ExpeditionApply", 0)]
        ExpeditionApply = 15,
        [FastEnumUtility.Label("FollowRequest", 0)]
        FollowRequest = 16,
        [FastEnumUtility.Label("NewYearCardArrived", 0)]
        NewYearCardArrived = 17,
    }
    public enum NpcActionType : byte
    {
        [FastEnumUtility.Label("NPCACT_MOVE", 0)]
        Move = 0,
        [FastEnumUtility.Label("NPCACT_STAND", 0)]
        Stand = 1,
    }
    public enum NpcQuestState : byte
    {
        [FastEnumUtility.Label("NPC_QUESTSTATE_PRESTART", 0)]
        [FastEnumUtility.Label("Pre Start", 1)]
        PreStart = 0,
        [FastEnumUtility.Label("NPC_QUESTSTATE_PERFORM", 0)]
        Perform = 1,
        [FastEnumUtility.Label("NPC_QUESTSTATE_PRECOMPLETE", 0)]
        [FastEnumUtility.Label("Pre Complete", 1)]
        PreComplete = 2,
        [FastEnumUtility.Label("NPC_QUESTSTATE_NEARSTART", 0)]
        [FastEnumUtility.Label("Near Start", 1)]
        NearStart = 3,
        [FastEnumUtility.Label("NPC_QUESTSTATE_PRESTART_SHOW_WORTHLESS", 0)]
        [FastEnumUtility.Label("Pre Start Show Worthless", 1)]
        PreStartShowWorthless = 4,
        [FastEnumUtility.Label("NPC_QUESTSTATE_PRESTART_HIDE_WORTHLESS", 0)]
        [FastEnumUtility.Label("Pre Start Hide Worthless", 1)]
        PreStartHideWorthless = 5,
        [FastEnumUtility.Label("NPC_QUESTSTATE_NONE", 0)]
        None = 6,
    }
    public enum NpcShopOperation : byte
    {
        [FastEnumUtility.Label("ShopReq_Buy", 0)]
        Buy = 0,
        [FastEnumUtility.Label("ShopReq_Sell", 0)]
        Sell = 1,
        [FastEnumUtility.Label("ShopReq_Recharge", 0)]
        Recharge = 2,
        [FastEnumUtility.Label("ShopReq_Close", 0)]
        Close = 3,
    }
    public enum NpcShopResult : byte
    {
        [FastEnumUtility.Label("Buy Success", 1)]
        [FastEnumUtility.Label("ShopRes_BuySuccess", 0)]
        BuySuccess = 0,
        [FastEnumUtility.Label("Buy No Stock", 1)]
        [FastEnumUtility.Label("ShopRes_BuyNoStock", 0)]
        BuyNoStock = 1,
        [FastEnumUtility.Label("Buy No Money", 1)]
        [FastEnumUtility.Label("ShopRes_BuyNoMoney", 0)]
        BuyNoMoney = 2,
        [FastEnumUtility.Label("Buy Unknown", 1)]
        [FastEnumUtility.Label("ShopRes_BuyUnknown", 0)]
        BuyUnknown = 3,
        [FastEnumUtility.Label("Sell Success", 1)]
        [FastEnumUtility.Label("ShopRes_SellSuccess", 0)]
        SellSuccess = 4,
        [FastEnumUtility.Label("Sell No Stock", 1)]
        [FastEnumUtility.Label("ShopRes_SellNoStock", 0)]
        SellNoStock = 5,
        [FastEnumUtility.Label("Sell Incorrect Request", 1)]
        [FastEnumUtility.Label("ShopRes_SellIncorrectRequest", 0)]
        SellIncorrectRequest = 6,
        [FastEnumUtility.Label("Sell Unknown", 1)]
        [FastEnumUtility.Label("ShopRes_SellUnkonwn", 0)]
        SellUnknown = 7,
        [FastEnumUtility.Label("Recharge Success", 1)]
        [FastEnumUtility.Label("ShopRes_RechargeSuccess", 0)]
        RechargeSuccess = 8,
        [FastEnumUtility.Label("Recharge No Stock", 1)]
        [FastEnumUtility.Label("ShopRes_RechargeNoStock", 0)]
        RechargeNoStock = 9,
        [FastEnumUtility.Label("Recharge No Money", 1)]
        [FastEnumUtility.Label("ShopRes_RechargeNoMoney", 0)]
        RechargeNoMoney = 10,
        [FastEnumUtility.Label("Recharge Incorrect Request", 1)]
        [FastEnumUtility.Label("ShopRes_RechargeIncorrectRequest", 0)]
        RechargeIncorrectRequest = 11,
        [FastEnumUtility.Label("Recharge Unknown", 1)]
        [FastEnumUtility.Label("ShopRes_RechargeUnknown", 0)]
        RechargeUnknown = 12,
        [FastEnumUtility.Label("Buy No Token", 1)]
        [FastEnumUtility.Label("ShopRes_BuyNoToken", 0)]
        BuyNoToken = 13,
        [FastEnumUtility.Label("Limit Level Less", 1)]
        [FastEnumUtility.Label("ShopRes_LimitLevel_Less", 0)]
        LimitLevelLess = 14,
        [FastEnumUtility.Label("Limit Level More", 1)]
        [FastEnumUtility.Label("ShopRes_LimitLevel_More", 0)]
        LimitLevelMore = 15,
        [FastEnumUtility.Label("Cant Buy Anymore", 1)]
        [FastEnumUtility.Label("ShopRes_CantBuyAnymore", 0)]
        CantBuyAnymore = 16,
        [FastEnumUtility.Label("ShopRes_TradeBlocked", 0)]
        [FastEnumUtility.Label("Trade Blocked", 1)]
        TradeBlocked = 17,
        [FastEnumUtility.Label("Buy Limit", 1)]
        [FastEnumUtility.Label("ShopRes_BuyLimit", 0)]
        BuyLimit = 18,
        [FastEnumUtility.Label("Server Msg", 1)]
        [FastEnumUtility.Label("ShopRes_ServerMsg", 0)]
        ServerMsg = 19,
    }
    public enum ParcelOperation : byte
    {
        [FastEnumUtility.Label("ParcelReq_OpenQuickReceive", 0)]
        [FastEnumUtility.Label("Req Open Quick Receive", 1)]
        ReqOpenQuickReceive = 0,
        [FastEnumUtility.Label("ParcelReq_Load", 0)]
        [FastEnumUtility.Label("Req Load", 1)]
        ReqLoad = 1,
        [FastEnumUtility.Label("ParcelReq_Send", 0)]
        [FastEnumUtility.Label("Req Send", 1)]
        ReqSend = 2,
        [FastEnumUtility.Label("ParcelReq_ConfirmSend", 0)]
        [FastEnumUtility.Label("Req Confirm Send", 1)]
        ReqConfirmSend = 3,
        [FastEnumUtility.Label("ParcelReq_Receive", 0)]
        [FastEnumUtility.Label("Req Receive", 1)]
        ReqReceive = 4,
        [FastEnumUtility.Label("ParcelReq_Discard", 0)]
        [FastEnumUtility.Label("Req Discard", 1)]
        ReqDiscard = 5,
        [FastEnumUtility.Label("ParcelReq_Remove", 0)]
        [FastEnumUtility.Label("Req Remove", 1)]
        ReqRemove = 6,
        [FastEnumUtility.Label("ParcelReq_Close", 0)]
        [FastEnumUtility.Label("Req Close", 1)]
        ReqClose = 7,
        [FastEnumUtility.Label("ParcelRes_Loaded", 0)]
        [FastEnumUtility.Label("Res Loaded", 1)]
        ResLoaded = 8,
        [FastEnumUtility.Label("ParcelRes_SendSuccess", 0)]
        [FastEnumUtility.Label("Res Send Success", 1)]
        ResSendSuccess = 9,
        [FastEnumUtility.Label("ParcelRes_SendErr_NotEnoughMoney", 0)]
        [FastEnumUtility.Label("Res Send Err Not Enough Money", 1)]
        ResSendErrNotEnoughMoney = 10,
        [FastEnumUtility.Label("ParcelRes_SendErr_IncorrectRequest", 0)]
        [FastEnumUtility.Label("Res Send Err Incorrect Request", 1)]
        ResSendErrIncorrectRequest = 11,
        [FastEnumUtility.Label("ParcelRes_SendErr_NoCharacter", 0)]
        [FastEnumUtility.Label("Res Send Err No Character", 1)]
        ResSendErrNoCharacter = 12,
        [FastEnumUtility.Label("ParcelRes_SendErr_SameAccount", 0)]
        [FastEnumUtility.Label("Res Send Err Same Account", 1)]
        ResSendErrSameAccount = 13,
        [FastEnumUtility.Label("ParcelRes_SendErr_NoSpaceToPeer", 0)]
        [FastEnumUtility.Label("Res Send Err No Space To Peer", 1)]
        ResSendErrNoSpaceToPeer = 14,
        [FastEnumUtility.Label("ParcelRes_SendErr_TargetUserCannotReceive", 0)]
        [FastEnumUtility.Label("Res Send Err Target User Cannot Receive", 1)]
        ResSendErrTargetUserCannotReceive = 15,
        [FastEnumUtility.Label("ParcelRes_SendErr_TargetHavingOnlyItem", 0)]
        [FastEnumUtility.Label("Res Send Err Target Having Only Item", 1)]
        ResSendErrTargetHavingOnlyItem = 16,
        [FastEnumUtility.Label("ParcelRes_SendErr_LimitMoney", 0)]
        [FastEnumUtility.Label("Res Send Err Limit Money", 1)]
        ResSendErrLimitMoney = 17,
        [FastEnumUtility.Label("ParcelRes_ConfirmSend_Success", 0)]
        [FastEnumUtility.Label("Res Confirm Send Success", 1)]
        ResConfirmSendSuccess = 18,
        [FastEnumUtility.Label("ParcelRes_ConfirmSend_Failure", 0)]
        [FastEnumUtility.Label("Res Confirm Send Failure", 1)]
        ResConfirmSendFailure = 19,
        [FastEnumUtility.Label("ParcelRes_ReceiveSuccess", 0)]
        [FastEnumUtility.Label("Res Receive Success", 1)]
        ResReceiveSuccess = 20,
        [FastEnumUtility.Label("ParcelRes_ReceiveErr_NoEmptySlot", 0)]
        [FastEnumUtility.Label("Res Receive Err No Empty Slot", 1)]
        ResReceiveErrNoEmptySlot = 21,
        [FastEnumUtility.Label("ParcelRes_ReceiveErr_HavingOnlyItem", 0)]
        [FastEnumUtility.Label("Res Receive Err Having Only Item", 1)]
        ResReceiveErrHavingOnlyItem = 22,
        [FastEnumUtility.Label("ParcelRes_RemoveSuccess", 0)]
        [FastEnumUtility.Label("Res Remove Success", 1)]
        ResRemoveSuccess = 23,
        [FastEnumUtility.Label("ParcelRes_NewParcelSent", 0)]
        [FastEnumUtility.Label("Res New Parcel Sent", 1)]
        ResNewParcelSent = 24,
        [FastEnumUtility.Label("ParcelRes_ReceivedNewParcel", 0)]
        [FastEnumUtility.Label("Res Received New Parcel", 1)]
        ResReceivedNewParcel = 25,
        [FastEnumUtility.Label("ParcelRes_OpenQuickSend", 0)]
        [FastEnumUtility.Label("Res Open Quick Send", 1)]
        ResOpenQuickSend = 26,
        [FastEnumUtility.Label("ParcelRes_DelayedNotify", 0)]
        [FastEnumUtility.Label("Res Delayed Notify", 1)]
        ResDelayedNotify = 27,
        [FastEnumUtility.Label("ParcelRes_UnknownError", 0)]
        [FastEnumUtility.Label("Res Unknown Error", 1)]
        ResUnknownError = 28,
        [FastEnumUtility.Label("ParcelRes_Expired", 0)]
        [FastEnumUtility.Label("Res Expired", 1)]
        ResExpired = 29,
        [FastEnumUtility.Label("ParcelRes_ServerMsg", 0)]
        [FastEnumUtility.Label("Res Server Msg", 1)]
        ResServerMsg = 30,
    }
    [System.Flags]
    public enum PartyAdverJobSearchFlag
    {
        None = 0,
        [FastEnumUtility.Label("All Job", 1)]
        [FastEnumUtility.Label("SEARCHING_JOB_ALLJOB", 0)]
        AllJob = 1,
        [FastEnumUtility.Label("SEARCHING_JOB_BEGINNER", 0)]
        Beginner = 2,
        [FastEnumUtility.Label("SEARCHING_JOB_WARRIOR", 0)]
        Warrior = 4,
        [FastEnumUtility.Label("SEARCHING_JOB_WARRIOR1", 0)]
        Warrior1 = 8,
        [FastEnumUtility.Label("SEARCHING_JOB_WARRIOR2", 0)]
        Warrior2 = 16,
        [FastEnumUtility.Label("SEARCHING_JOB_WARRIOR3", 0)]
        Warrior3 = 32,
        [FastEnumUtility.Label("SEARCHING_JOB_SOULMASTER", 0)]
        [FastEnumUtility.Label("Soul Master", 1)]
        SoulMaster = 64,
        [FastEnumUtility.Label("SEARCHING_JOB_ARAN", 0)]
        Aran = 128,
        [FastEnumUtility.Label("SEARCHING_JOB_WIZARD", 0)]
        Wizard = 256,
        [FastEnumUtility.Label("SEARCHING_JOB_WIZARD1", 0)]
        Wizard1 = 512,
        [FastEnumUtility.Label("SEARCHING_JOB_WIZARD2", 0)]
        Wizard2 = 1024,
        [FastEnumUtility.Label("SEARCHING_JOB_WIZARD3", 0)]
        Wizard3 = 2048,
        [FastEnumUtility.Label("Flame Wizard", 1)]
        [FastEnumUtility.Label("SEARCHING_JOB_FLAMEWIZARD", 0)]
        FlameWizard = 4096,
        [FastEnumUtility.Label("SEARCHING_JOB_EVAN", 0)]
        Evan = 8192,
        [FastEnumUtility.Label("SEARCHING_JOB_BMAGE", 0)]
        BMage = 16384,
        [FastEnumUtility.Label("SEARCHING_JOB_PIRATE", 0)]
        Pirate = 32768,
        [FastEnumUtility.Label("SEARCHING_JOB_PIRATE1", 0)]
        Pirate1 = 65536,
        [FastEnumUtility.Label("SEARCHING_JOB_PIRATE2", 0)]
        Pirate2 = 131072,
        [FastEnumUtility.Label("SEARCHING_JOB_STRIKER", 0)]
        Striker = 262144,
        [FastEnumUtility.Label("SEARCHING_JOB_MECHANIC", 0)]
        Mechanic = 524288,
        [FastEnumUtility.Label("SEARCHING_JOB_THIEF", 0)]
        Thief = 1048576,
        [FastEnumUtility.Label("SEARCHING_JOB_THIEF1", 0)]
        Thief1 = 4194304,
        [FastEnumUtility.Label("SEARCHING_JOB_THIEF2", 0)]
        Thief2 = 8388608,
        [FastEnumUtility.Label("Night Walker", 1)]
        [FastEnumUtility.Label("SEARCHING_JOB_NIGHTWALKER", 0)]
        NightWalker = 16777216,
        [FastEnumUtility.Label("Dual Blade", 1)]
        [FastEnumUtility.Label("SEARCHING_JOB_DUALBLADE", 0)]
        DualBlade = 33554432,
        [FastEnumUtility.Label("SEARCHING_JOB_BOWMAN", 0)]
        Bowman = 67108864,
        [FastEnumUtility.Label("SEARCHING_JOB_BOWMAN1", 0)]
        Bowman1 = 134217728,
        [FastEnumUtility.Label("SEARCHING_JOB_BOWMAN2", 0)]
        Bowman2 = 268435456,
        [FastEnumUtility.Label("SEARCHING_JOB_WINDBREAKER", 0)]
        [FastEnumUtility.Label("Wind Breaker", 1)]
        WindBreaker = 536870912,
        [FastEnumUtility.Label("SEARCHING_JOB_WILDHUNTER", 0)]
        [FastEnumUtility.Label("Wild Hunter", 1)]
        WildHunter = 1073741824,
    }
    public enum PartyAdverResult : byte
    {
        [FastEnumUtility.Label("Add Fail Already Exist", 1)]
        [FastEnumUtility.Label("AdverAddFailReason_AlreadyExist", 0)]
        AddFailAlreadyExist = 0,
        [FastEnumUtility.Label("Add Fail Banned By Field Set", 1)]
        [FastEnumUtility.Label("AdverAddFailReason_BannedByFieldSet", 0)]
        AddFailBannedByFieldSet = 1,
        [FastEnumUtility.Label("AdverRemoveReason_UserRequest", 0)]
        [FastEnumUtility.Label("Remove User Request", 1)]
        RemoveUserRequest = 2,
        [FastEnumUtility.Label("AdverRemoveReason_PartyRemoved", 0)]
        [FastEnumUtility.Label("Remove Party Removed", 1)]
        RemovePartyRemoved = 3,
        [FastEnumUtility.Label("AdverRemoveReason_ExpeditionRemoved", 0)]
        [FastEnumUtility.Label("Remove Expedition Removed", 1)]
        RemoveExpeditionRemoved = 4,
        [FastEnumUtility.Label("AdverRemoveReason_FullParty", 0)]
        [FastEnumUtility.Label("Remove Full Party", 1)]
        RemoveFullParty = 5,
        [FastEnumUtility.Label("AdverRemoveReason_FullExpedition", 0)]
        [FastEnumUtility.Label("Remove Full Expedition", 1)]
        RemoveFullExpedition = 6,
        [FastEnumUtility.Label("AdverRemoveReason_EnterFieldSet", 0)]
        [FastEnumUtility.Label("Remove Enter Field Set", 1)]
        RemoveEnterFieldSet = 7,
        [FastEnumUtility.Label("AdverRemoveReason_PayTaxFailed", 0)]
        [FastEnumUtility.Label("Remove Pay Tax Failed", 1)]
        RemovePayTaxFailed = 8,
        [FastEnumUtility.Label("AdverRemoveReason_TimeExpired", 0)]
        [FastEnumUtility.Label("Remove Time Expired", 1)]
        RemoveTimeExpired = 9,
        [FastEnumUtility.Label("Apply Result Apply Sent", 1)]
        [FastEnumUtility.Label("PartyAdverApplyResult_ApplySent", 0)]
        ApplyResultApplySent = 10,
        [FastEnumUtility.Label("Apply Result Already Sent", 1)]
        [FastEnumUtility.Label("PartyAdverApplyResult_AlreadySent", 0)]
        ApplyResultAlreadySent = 11,
        [FastEnumUtility.Label("Apply Result Black List", 1)]
        [FastEnumUtility.Label("PartyAdverApplyResult_BlackList", 0)]
        ApplyResultBlackList = 12,
        [FastEnumUtility.Label("Apply Result Accept", 1)]
        [FastEnumUtility.Label("PartyAdverApplyResult_Accept", 0)]
        ApplyResultAccept = 13,
        [FastEnumUtility.Label("Apply Result Reject", 1)]
        [FastEnumUtility.Label("PartyAdverApplyResult_Reject", 0)]
        ApplyResultReject = 14,
    }
    public enum PartyOperation : byte
    {
        [FastEnumUtility.Label("Party Req Load Party", 1)]
        [FastEnumUtility.Label("PartyReq_LoadParty", 0)]
        PartyReqLoadParty = 0,
        [FastEnumUtility.Label("Party Req Create New Party", 1)]
        [FastEnumUtility.Label("PartyReq_CreateNewParty", 0)]
        PartyReqCreateNewParty = 1,
        [FastEnumUtility.Label("Party Req Withdraw Party", 1)]
        [FastEnumUtility.Label("PartyReq_WithdrawParty", 0)]
        PartyReqWithdrawParty = 2,
        [FastEnumUtility.Label("Party Req Join Party", 1)]
        [FastEnumUtility.Label("PartyReq_JoinParty", 0)]
        PartyReqJoinParty = 3,
        [FastEnumUtility.Label("Party Req Invite Party", 1)]
        [FastEnumUtility.Label("PartyReq_InviteParty", 0)]
        PartyReqInviteParty = 4,
        [FastEnumUtility.Label("Party Req Kick Party", 1)]
        [FastEnumUtility.Label("PartyReq_KickParty", 0)]
        PartyReqKickParty = 5,
        [FastEnumUtility.Label("Party Req Change Party Boss", 1)]
        [FastEnumUtility.Label("PartyReq_ChangePartyBoss", 0)]
        PartyReqChangePartyBoss = 6,
        [FastEnumUtility.Label("Party Res Load Party Done", 1)]
        [FastEnumUtility.Label("PartyRes_LoadParty_Done", 0)]
        PartyResLoadPartyDone = 7,
        [FastEnumUtility.Label("Party Res Create New Party Done", 1)]
        [FastEnumUtility.Label("PartyRes_CreateNewParty_Done", 0)]
        PartyResCreateNewPartyDone = 8,
        [FastEnumUtility.Label("Party Res Create New Party Already Joined", 1)]
        [FastEnumUtility.Label("PartyRes_CreateNewParty_AlreayJoined", 0)]
        PartyResCreateNewPartyAlreadyJoined = 9,
        [FastEnumUtility.Label("Party Res Create New Party Beginner", 1)]
        [FastEnumUtility.Label("PartyRes_CreateNewParty_Beginner", 0)]
        PartyResCreateNewPartyBeginner = 10,
        [FastEnumUtility.Label("Party Res Create New Party Unknown", 1)]
        [FastEnumUtility.Label("PartyRes_CreateNewParty_Unknown", 0)]
        PartyResCreateNewPartyUnknown = 11,
        [FastEnumUtility.Label("Party Res Withdraw Party Done", 1)]
        [FastEnumUtility.Label("PartyRes_WithdrawParty_Done", 0)]
        PartyResWithdrawPartyDone = 12,
        [FastEnumUtility.Label("Party Res Withdraw Party Not Joined", 1)]
        [FastEnumUtility.Label("PartyRes_WithdrawParty_NotJoined", 0)]
        PartyResWithdrawPartyNotJoined = 13,
        [FastEnumUtility.Label("Party Res Withdraw Party Unknown", 1)]
        [FastEnumUtility.Label("PartyRes_WithdrawParty_Unknown", 0)]
        PartyResWithdrawPartyUnknown = 14,
        [FastEnumUtility.Label("Party Res Join Party Done", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_Done", 0)]
        PartyResJoinPartyDone = 15,
        [FastEnumUtility.Label("Party Res Join Party Done2", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_Done2", 0)]
        PartyResJoinPartyDone2 = 16,
        [FastEnumUtility.Label("Party Res Join Party Already Joined", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_AlreadyJoined", 0)]
        PartyResJoinPartyAlreadyJoined = 17,
        [FastEnumUtility.Label("Party Res Join Party Already Full", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_AlreadyFull", 0)]
        PartyResJoinPartyAlreadyFull = 18,
        [FastEnumUtility.Label("Party Res Join Party Over Desired Size", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_OverDesiredSize", 0)]
        PartyResJoinPartyOverDesiredSize = 19,
        [FastEnumUtility.Label("Party Res Join Party Unknown User", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_UnknownUser", 0)]
        PartyResJoinPartyUnknownUser = 20,
        [FastEnumUtility.Label("Party Res Join Party Unknown", 1)]
        [FastEnumUtility.Label("PartyRes_JoinParty_Unknown", 0)]
        PartyResJoinPartyUnknown = 21,
        [FastEnumUtility.Label("Party Res Invite Party Sent", 1)]
        [FastEnumUtility.Label("PartyRes_InviteParty_Sent", 0)]
        PartyResInvitePartySent = 22,
        [FastEnumUtility.Label("Party Res Invite Party Blocked User", 1)]
        [FastEnumUtility.Label("PartyRes_InviteParty_BlockedUser", 0)]
        PartyResInvitePartyBlockedUser = 23,
        [FastEnumUtility.Label("Party Res Invite Party Already Invited", 1)]
        [FastEnumUtility.Label("PartyRes_InviteParty_AlreadyInvited", 0)]
        PartyResInvitePartyAlreadyInvited = 24,
        [FastEnumUtility.Label("Party Res Invite Party Already Invited By Inviter", 1)]
        [FastEnumUtility.Label("PartyRes_InviteParty_AlreadyInvitedByInviter", 0)]
        PartyResInvitePartyAlreadyInvitedByInviter = 25,
        [FastEnumUtility.Label("Party Res Invite Party Rejected", 1)]
        [FastEnumUtility.Label("PartyRes_InviteParty_Rejected", 0)]
        PartyResInvitePartyRejected = 26,
        [FastEnumUtility.Label("Party Res Invite Party Accepted", 1)]
        [FastEnumUtility.Label("PartyRes_InviteParty_Accepted", 0)]
        PartyResInvitePartyAccepted = 27,
        [FastEnumUtility.Label("Party Res Kick Party Done", 1)]
        [FastEnumUtility.Label("PartyRes_KickParty_Done", 0)]
        PartyResKickPartyDone = 28,
        [FastEnumUtility.Label("Party Res Kick Party Field Limit", 1)]
        [FastEnumUtility.Label("PartyRes_KickParty_FieldLimit", 0)]
        PartyResKickPartyFieldLimit = 29,
        [FastEnumUtility.Label("Party Res Kick Party Unknown", 1)]
        [FastEnumUtility.Label("PartyRes_KickParty_Unknown", 0)]
        PartyResKickPartyUnknown = 30,
        [FastEnumUtility.Label("Party Res Change Party Boss Done", 1)]
        [FastEnumUtility.Label("PartyRes_ChangePartyBoss_Done", 0)]
        PartyResChangePartyBossDone = 31,
        [FastEnumUtility.Label("Party Res Change Party Boss Not Same Field", 1)]
        [FastEnumUtility.Label("PartyRes_ChangePartyBoss_NotSameField", 0)]
        PartyResChangePartyBossNotSameField = 32,
        [FastEnumUtility.Label("Party Res Change Party Boss No Member In Same Field", 1)]
        [FastEnumUtility.Label("PartyRes_ChangePartyBoss_NoMemberInSameField", 0)]
        PartyResChangePartyBossNoMemberInSameField = 33,
        [FastEnumUtility.Label("Party Res Change Party Boss Not Same Channel", 1)]
        [FastEnumUtility.Label("PartyRes_ChangePartyBoss_NotSameChannel", 0)]
        PartyResChangePartyBossNotSameChannel = 34,
        [FastEnumUtility.Label("Party Res Change Party Boss Unknown", 1)]
        [FastEnumUtility.Label("PartyRes_ChangePartyBoss_Unknown", 0)]
        PartyResChangePartyBossUnknown = 35,
        [FastEnumUtility.Label("Party Res Admin Cannot Create", 1)]
        [FastEnumUtility.Label("PartyRes_AdminCannotCreate", 0)]
        PartyResAdminCannotCreate = 36,
        [FastEnumUtility.Label("Party Res Admin Cannot Invite", 1)]
        [FastEnumUtility.Label("PartyRes_AdminCannotInvite", 0)]
        PartyResAdminCannotInvite = 37,
        [FastEnumUtility.Label("Party Res User Migration", 1)]
        [FastEnumUtility.Label("PartyRes_UserMigration", 0)]
        PartyResUserMigration = 38,
        [FastEnumUtility.Label("Party Res Change Level Or Job", 1)]
        [FastEnumUtility.Label("PartyRes_ChangeLevelOrJob", 0)]
        PartyResChangeLevelOrJob = 39,
        [FastEnumUtility.Label("Party Res Success To Select PQ Reward", 1)]
        [FastEnumUtility.Label("PartyRes_SuccessToSelectPQReward", 0)]
        PartyResSuccessToSelectPQReward = 40,
        [FastEnumUtility.Label("Party Res Fail To Select PQ Reward", 1)]
        [FastEnumUtility.Label("PartyRes_FailToSelectPQReward", 0)]
        PartyResFailToSelectPQReward = 41,
        [FastEnumUtility.Label("Party Res Receive PQ Reward", 1)]
        [FastEnumUtility.Label("PartyRes_ReceivePQReward", 0)]
        PartyResReceivePQReward = 42,
        [FastEnumUtility.Label("Party Res Fail To Request PQ Reward", 1)]
        [FastEnumUtility.Label("PartyRes_FailToRequestPQReward", 0)]
        PartyResFailToRequestPQReward = 43,
        [FastEnumUtility.Label("Party Res Can Not In This Field", 1)]
        [FastEnumUtility.Label("PartyRes_CanNotInThisField", 0)]
        PartyResCanNotInThisField = 44,
        [FastEnumUtility.Label("Party Res Server Msg", 1)]
        [FastEnumUtility.Label("PartyRes_ServerMsg", 0)]
        PartyResServerMsg = 45,
        [FastEnumUtility.Label("Party Info Town Portal Changed", 1)]
        [FastEnumUtility.Label("PartyInfo_TownPortalChanged", 0)]
        PartyInfoTownPortalChanged = 46,
        [FastEnumUtility.Label("Party Info Open Gate", 1)]
        [FastEnumUtility.Label("PartyInfo_OpenGate", 0)]
        PartyInfoOpenGate = 47,
        [FastEnumUtility.Label("Expedition Req Load", 1)]
        [FastEnumUtility.Label("ExpeditionReq_Load", 0)]
        ExpeditionReqLoad = 48,
        [FastEnumUtility.Label("Expedition Req Create New", 1)]
        [FastEnumUtility.Label("ExpeditionReq_CreateNew", 0)]
        ExpeditionReqCreateNew = 49,
        [FastEnumUtility.Label("Expedition Req Invite", 1)]
        [FastEnumUtility.Label("ExpeditionReq_Invite", 0)]
        ExpeditionReqInvite = 50,
        [FastEnumUtility.Label("Expedition Req Response Invite", 1)]
        [FastEnumUtility.Label("ExpeditionReq_ResponseInvite", 0)]
        ExpeditionReqResponseInvite = 51,
        [FastEnumUtility.Label("Expedition Req Withdraw", 1)]
        [FastEnumUtility.Label("ExpeditionReq_Withdraw", 0)]
        ExpeditionReqWithdraw = 52,
        [FastEnumUtility.Label("Expedition Req Kick", 1)]
        [FastEnumUtility.Label("ExpeditionReq_Kick", 0)]
        ExpeditionReqKick = 53,
        [FastEnumUtility.Label("Expedition Req Change Master", 1)]
        [FastEnumUtility.Label("ExpeditionReq_ChangeMaster", 0)]
        ExpeditionReqChangeMaster = 54,
        [FastEnumUtility.Label("Expedition Req Change Party Boss", 1)]
        [FastEnumUtility.Label("ExpeditionReq_ChangePartyBoss", 0)]
        ExpeditionReqChangePartyBoss = 55,
        [FastEnumUtility.Label("Expedition Req Relocate Member", 1)]
        [FastEnumUtility.Label("ExpeditionReq_RelocateMember", 0)]
        ExpeditionReqRelocateMember = 56,
        [FastEnumUtility.Label("Expedition Noti Load Done", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Load_Done", 0)]
        ExpeditionNotiLoadDone = 57,
        [FastEnumUtility.Label("Expedition Noti Load Fail", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Load_Fail", 0)]
        ExpeditionNotiLoadFail = 58,
        [FastEnumUtility.Label("Expedition Noti Create New Done", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_CreateNew_Done", 0)]
        ExpeditionNotiCreateNewDone = 59,
        [FastEnumUtility.Label("Expedition Noti Join Done", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Join_Done", 0)]
        ExpeditionNotiJoinDone = 60,
        [FastEnumUtility.Label("Expedition Noti You Joined", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_You_Joined", 0)]
        ExpeditionNotiYouJoined = 61,
        [FastEnumUtility.Label("Expedition Noti You Joined2", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_You_Joined2", 0)]
        ExpeditionNotiYouJoined2 = 62,
        [FastEnumUtility.Label("Expedition Noti Join Fail", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Join_Fail", 0)]
        ExpeditionNotiJoinFail = 63,
        [FastEnumUtility.Label("Expedition Noti Withdraw Done", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Withdraw_Done", 0)]
        ExpeditionNotiWithdrawDone = 64,
        [FastEnumUtility.Label("Expedition Noti You Withdrew", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_You_Withdrew", 0)]
        ExpeditionNotiYouWithdrew = 65,
        [FastEnumUtility.Label("Expedition Noti Kick Done", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Kick_Done", 0)]
        ExpeditionNotiKickDone = 66,
        [FastEnumUtility.Label("Expedition Noti You Kicked", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_You_Kicked", 0)]
        ExpeditionNotiYouKicked = 67,
        [FastEnumUtility.Label("Expedition Noti Removed", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Removed", 0)]
        ExpeditionNotiRemoved = 68,
        [FastEnumUtility.Label("Expedition Noti Master Changed", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_MasterChanged", 0)]
        ExpeditionNotiMasterChanged = 69,
        [FastEnumUtility.Label("Expedition Noti Modified", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Modified", 0)]
        ExpeditionNotiModified = 70,
        [FastEnumUtility.Label("Expedition Noti Modified2", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Modified2", 0)]
        ExpeditionNotiModified2 = 71,
        [FastEnumUtility.Label("Expedition Noti Invite", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_Invite", 0)]
        ExpeditionNotiInvite = 72,
        [FastEnumUtility.Label("Expedition Noti Response Invite", 1)]
        [FastEnumUtility.Label("ExpeditionNoti_ResponseInvite", 0)]
        ExpeditionNotiResponseInvite = 73,
        [FastEnumUtility.Label("Adver Noti Load Done", 1)]
        [FastEnumUtility.Label("AdverNoti_LoadDone", 0)]
        AdverNotiLoadDone = 74,
        [FastEnumUtility.Label("Adver Noti Change", 1)]
        [FastEnumUtility.Label("AdverNoti_Change", 0)]
        AdverNotiChange = 75,
        [FastEnumUtility.Label("Adver Noti Remove", 1)]
        [FastEnumUtility.Label("AdverNoti_Remove", 0)]
        AdverNotiRemove = 76,
        [FastEnumUtility.Label("Adver Noti Get All", 1)]
        [FastEnumUtility.Label("AdverNoti_GetAll", 0)]
        AdverNotiGetAll = 77,
        [FastEnumUtility.Label("Adver Noti Apply", 1)]
        [FastEnumUtility.Label("AdverNoti_Apply", 0)]
        AdverNotiApply = 78,
        [FastEnumUtility.Label("Adver Noti Result Apply", 1)]
        [FastEnumUtility.Label("AdverNoti_ResultApply", 0)]
        AdverNotiResultApply = 79,
        [FastEnumUtility.Label("Adver Noti Add Fail", 1)]
        [FastEnumUtility.Label("AdverNoti_AddFail", 0)]
        AdverNotiAddFail = 80,
        [FastEnumUtility.Label("Adver Req Add", 1)]
        [FastEnumUtility.Label("AdverReq_Add", 0)]
        AdverReqAdd = 81,
        [FastEnumUtility.Label("Adver Req Remove", 1)]
        [FastEnumUtility.Label("AdverReq_Remove", 0)]
        AdverReqRemove = 82,
        [FastEnumUtility.Label("Adver Req Get All", 1)]
        [FastEnumUtility.Label("AdverReq_GetAll", 0)]
        AdverReqGetAll = 83,
        [FastEnumUtility.Label("Adver Req Remove User From Noti List", 1)]
        [FastEnumUtility.Label("AdverReq_RemoveUserFromNotiList", 0)]
        AdverReqRemoveUserFromNotiList = 84,
        [FastEnumUtility.Label("Adver Req Apply", 1)]
        [FastEnumUtility.Label("AdverReq_Apply", 0)]
        AdverReqApply = 85,
        [FastEnumUtility.Label("Adver Req Result Apply", 1)]
        [FastEnumUtility.Label("AdverReq_ResultApply", 0)]
        AdverReqResultApply = 86,
    }
    public enum PartyRaidTeam : byte
    {
        [FastEnumUtility.Label("PRTeam_None", 0)]
        None = 255,
        [FastEnumUtility.Label("PRTeam_Red", 0)]
        Red = 0,
        [FastEnumUtility.Label("PRTeam_Blue", 0)]
        Blue = 1,
    }
    public enum PassiveSkillStat : byte
    {
        [FastEnumUtility.Label("MHPR", 0)]
        MaxHpRate = 0,
        [FastEnumUtility.Label("MMPR", 0)]
        MaxMpRate = 1,
        [FastEnumUtility.Label("CR", 0)]
        CriticalRate = 2,
        [FastEnumUtility.Label("CDMIN", 0)]
        CriticalDamageMin = 3,
        [FastEnumUtility.Label("ACCR", 0)]
        AccuracyRate = 4,
        [FastEnumUtility.Label("EVAR", 0)]
        EvasionRate = 5,
        [FastEnumUtility.Label("AR", 0)]
        AttackRate = 6,
        [FastEnumUtility.Label("ER", 0)]
        ElementalRate = 7,
        [FastEnumUtility.Label("PDDR", 0)]
        PhysicalDamageDecrease = 8,
        [FastEnumUtility.Label("MDDR", 0)]
        MagicalDamageDecrease = 9,
        [FastEnumUtility.Label("PDR", 0)]
        PhysicalDefenseRate = 10,
        [FastEnumUtility.Label("MDR", 0)]
        MagicalDefenseRate = 11,
        [FastEnumUtility.Label("DIPR", 0)]
        DropItemProbRate = 12,
        [FastEnumUtility.Label("PDAMR", 0)]
        PhysicalDamageRate = 13,
        [FastEnumUtility.Label("MDAMR", 0)]
        MagicalDamageRate = 14,
        [FastEnumUtility.Label("PADR", 0)]
        PhysicalAttackDamageRate = 15,
        [FastEnumUtility.Label("MADR", 0)]
        MagicalAttackDamageRate = 16,
        [FastEnumUtility.Label("EXPR", 0)]
        ExpRate = 17,
        [FastEnumUtility.Label("IMPR", 0)]
        ItemProbRate = 18,
        [FastEnumUtility.Label("ASRR", 0)]
        AbnormalStatusResistRate = 19,
        [FastEnumUtility.Label("TERR", 0)]
        TerritoryEffectRate = 20,
        [FastEnumUtility.Label("MESOR", 0)]
        MesoRate = 21,
    }
    public enum PersonalShopBuyResult : byte
    {
        [FastEnumUtility.Label("PSBuy_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("No Stock", 1)]
        [FastEnumUtility.Label("PSBuy_NoStock", 0)]
        NoStock = 1,
        [FastEnumUtility.Label("No Money", 1)]
        [FastEnumUtility.Label("PSBuy_NoMoney", 0)]
        NoMoney = 2,
        [FastEnumUtility.Label("Over Price", 1)]
        [FastEnumUtility.Label("PSBuy_OverPrice", 0)]
        OverPrice = 3,
        [FastEnumUtility.Label("Host Too Much Money", 1)]
        [FastEnumUtility.Label("PSBuy_HostTooMuchMoney", 0)]
        HostTooMuchMoney = 4,
        [FastEnumUtility.Label("No Slot", 1)]
        [FastEnumUtility.Label("PSBuy_NoSlot", 0)]
        NoSlot = 5,
        [FastEnumUtility.Label("Only Item", 1)]
        [FastEnumUtility.Label("PSBuy_OnlyItem", 0)]
        OnlyItem = 6,
        [FastEnumUtility.Label("Gender Mismatch", 1)]
        [FastEnumUtility.Label("PSBuy_GenderMismatch", 0)]
        GenderMismatch = 7,
        [FastEnumUtility.Label("PSBuy_Under7Age", 0)]
        Under7Age = 8,
        [FastEnumUtility.Label("Item Expired", 1)]
        [FastEnumUtility.Label("PSBuy_ItemExpired", 0)]
        ItemExpired = 9,
        [FastEnumUtility.Label("PSBuy_Denied", 0)]
        Denied = 10,
        [FastEnumUtility.Label("Denied User", 1)]
        [FastEnumUtility.Label("PSBuy_DeniedUser", 0)]
        DeniedUser = 11,
        [FastEnumUtility.Label("Item Crc Failed", 1)]
        [FastEnumUtility.Label("PSBuy_ItemCRCFailed", 0)]
        ItemCrcFailed = 12,
        [FastEnumUtility.Label("PSBuy_Unknown", 0)]
        Unknown = 13,
        [FastEnumUtility.Label("Money Limit", 1)]
        [FastEnumUtility.Label("PSBuy_MoneyLimit", 0)]
        MoneyLimit = 14,
    }
    [System.Flags]
    public enum PetAbilityFlag : byte
    {
        None = 0,
        [FastEnumUtility.Label("PETABIL_PICKUP_MESO", 0)]
        [FastEnumUtility.Label("Pickup Meso", 1)]
        PickupMeso = 1,
        [FastEnumUtility.Label("PETABIL_PICKUP_ITEM", 0)]
        [FastEnumUtility.Label("Pickup Item", 1)]
        PickupItem = 2,
        [FastEnumUtility.Label("PETABIL_PICKUP_OTHERS", 0)]
        [FastEnumUtility.Label("Pickup Others", 1)]
        PickupOthers = 4,
        [FastEnumUtility.Label("PETABIL_PICKUP_LONGRANGE", 0)]
        [FastEnumUtility.Label("Pickup Long Range", 1)]
        PickupLongRange = 8,
        [FastEnumUtility.Label("PETABIL_PICKUP_SWEEPFORDROP", 0)]
        [FastEnumUtility.Label("Pickup Sweep For Drop", 1)]
        PickupSweepForDrop = 16,
        [FastEnumUtility.Label("Consume HP", 1)]
        [FastEnumUtility.Label("PETABIL_CONSUME_HP", 0)]
        ConsumeHP = 32,
        [FastEnumUtility.Label("Consume MP", 1)]
        [FastEnumUtility.Label("PETABIL_CONSUME_MP", 0)]
        ConsumeMP = 64,
        [FastEnumUtility.Label("Ignore Items", 1)]
        [FastEnumUtility.Label("PETABIL_IGNORE_ITEMS", 0)]
        IgnoreItems = 128,
    }
    public enum PetActionType : byte
    {
        [FastEnumUtility.Label("PETACT_MOVE", 0)]
        Move = 0,
        [FastEnumUtility.Label("PETACT_STAND0", 0)]
        Stand0 = 1,
        [FastEnumUtility.Label("PETACT_STAND1", 0)]
        Stand1 = 2,
        [FastEnumUtility.Label("PETACT_JUMP", 0)]
        Jump = 3,
        [FastEnumUtility.Label("PETACT_FLY", 0)]
        Fly = 4,
        [FastEnumUtility.Label("PETACT_HUNGRY", 0)]
        Hungry = 5,
        [FastEnumUtility.Label("PETACT_REST0", 0)]
        Rest0 = 6,
        [FastEnumUtility.Label("PETACT_REST1", 0)]
        Rest1 = 7,
        [FastEnumUtility.Label("PETACT_HANG", 0)]
        Hang = 8,
        [FastEnumUtility.Label("PETACT_CUSTOM", 0)]
        Custom = 9,
    }
    public enum PetEffectType : byte
    {
        [FastEnumUtility.Label("Level Up", 1)]
        [FastEnumUtility.Label("PetEffect_LevelUp", 0)]
        LevelUp = 0,
        [FastEnumUtility.Label("PetEffect_Teleport", 0)]
        Teleport = 1,
        [FastEnumUtility.Label("Hang On Back", 1)]
        [FastEnumUtility.Label("PetEffect_HangOnBack", 0)]
        HangOnBack = 2,
        [FastEnumUtility.Label("PetEffect_Evolution", 0)]
        Evolution = 3,
    }
    public enum PetInteractType : byte
    {
        [FastEnumUtility.Label("INTERACT", 0)]
        Interact = 0,
        [FastEnumUtility.Label("FEED", 0)]
        Feed = 1,
        [FastEnumUtility.Label("CHAT", 0)]
        Chat = 2,
        [FastEnumUtility.Label("RANDOM", 0)]
        Random = 3,
    }
    public enum PetPositionCarrier : byte
    {
        [FastEnumUtility.Label("PPC_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("PPC_LEFT", 0)]
        Left = 1,
        [FastEnumUtility.Label("PPC_RIGHT", 0)]
        Right = 2,
        [FastEnumUtility.Label("Far Left", 1)]
        [FastEnumUtility.Label("PPC_FAR_LEFT", 0)]
        FarLeft = 3,
        [FastEnumUtility.Label("Far Right", 1)]
        [FastEnumUtility.Label("PPC_FAR_RIGHT", 0)]
        FarRight = 4,
        [FastEnumUtility.Label("Close Normal", 1)]
        [FastEnumUtility.Label("PPC_CLOSE_NORMAL", 0)]
        CloseNormal = 5,
    }
    public enum PhraseType : byte
    {
        [FastEnumUtility.Label("Phrase_None", 0)]
        None = 0,
        [FastEnumUtility.Label("Phrase_List", 0)]
        List = 1,
        [FastEnumUtility.Label("Phrase_Func0", 0)]
        Func0 = 2,
        [FastEnumUtility.Label("Phrase_Func1", 0)]
        Func1 = 3,
        [FastEnumUtility.Label("Phrase_Func2", 0)]
        Func2 = 4,
        [FastEnumUtility.Label("Phrase_Func3", 0)]
        Func3 = 5,
        [FastEnumUtility.Label("Phrase_Reward", 0)]
        Reward = 6,
        [FastEnumUtility.Label("Item Icon", 1)]
        [FastEnumUtility.Label("Phrase_ItemIcon", 0)]
        ItemIcon = 7,
        [FastEnumUtility.Label("Item Icon Outline", 1)]
        [FastEnumUtility.Label("Phrase_ItemIcon_Outline", 0)]
        ItemIconOutline = 8,
        [FastEnumUtility.Label("Item Icon Secret", 1)]
        [FastEnumUtility.Label("Phrase_ItemIcon_Secret", 0)]
        ItemIconSecret = 9,
        [FastEnumUtility.Label("Phrase_SkillIcon", 0)]
        [FastEnumUtility.Label("Skill Icon", 1)]
        SkillIcon = 10,
        [FastEnumUtility.Label("Phrase_Canvas", 0)]
        Canvas = 11,
        [FastEnumUtility.Label("Canvas Outline", 1)]
        [FastEnumUtility.Label("Phrase_Canvas_Outline", 0)]
        CanvasOutline = 12,
        [FastEnumUtility.Label("Canvas Progress Bar", 1)]
        [FastEnumUtility.Label("Phrase_Canvas_ProgressBar", 0)]
        CanvasProgressBar = 13,
        [FastEnumUtility.Label("Party Quest Keyword", 1)]
        [FastEnumUtility.Label("Phrase_PartyQuestKeyword", 0)]
        PartyQuestKeyword = 14,
        [FastEnumUtility.Label("Phrase_TimeLimitQuest", 0)]
        [FastEnumUtility.Label("Time Limit Quest", 1)]
        TimeLimitQuest = 15,
        [FastEnumUtility.Label("Daily Play Quest", 1)]
        [FastEnumUtility.Label("Phrase_DailyPlayQuest", 0)]
        DailyPlayQuest = 16,
        [FastEnumUtility.Label("Phrase_QuestSummary", 0)]
        [FastEnumUtility.Label("Quest Summary", 1)]
        QuestSummary = 17,
        [FastEnumUtility.Label("Phrase_Text", 0)]
        Text = 18,
    }
    public enum PinCodeResult : byte
    {
        [FastEnumUtility.Label("PinCodeResCode_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("Not Assigned", 1)]
        [FastEnumUtility.Label("PinCodeResCode_NotAssigned", 0)]
        NotAssigned = 1,
        [FastEnumUtility.Label("PinCodeResCode_Incorrect", 0)]
        Incorrect = 2,
        [FastEnumUtility.Label("Db Fail", 1)]
        [FastEnumUtility.Label("PinCodeResCode_DBFail", 0)]
        DbFail = 3,
        [FastEnumUtility.Label("PinCodeResCode_Assigned", 0)]
        Assigned = 4,
        [FastEnumUtility.Label("Already Connected", 1)]
        [FastEnumUtility.Label("PinCodeResCode_AlreadyConnected", 0)]
        AlreadyConnected = 7,
    }
    public enum PotentialStatType : byte
    {
        [FastEnumUtility.Label("incPAD", 0)]
        IncPad = 0,
        [FastEnumUtility.Label("incMAD", 0)]
        IncMad = 1,
        [FastEnumUtility.Label("incACC", 0)]
        IncAcc = 2,
        [FastEnumUtility.Label("incEVA", 0)]
        IncEva = 3,
        [FastEnumUtility.Label("incSpeed", 0)]
        IncSpeed = 4,
        [FastEnumUtility.Label("incJump", 0)]
        IncJump = 5,
        [FastEnumUtility.Label("incMaxHP", 0)]
        IncMaxHp = 6,
        [FastEnumUtility.Label("incMaxMP", 0)]
        IncMaxMp = 7,
        [FastEnumUtility.Label("incSTR", 0)]
        IncStr = 8,
        [FastEnumUtility.Label("incINT", 0)]
        IncInt = 9,
        [FastEnumUtility.Label("incLUK", 0)]
        IncLuk = 10,
        [FastEnumUtility.Label("incDEX", 0)]
        IncDex = 11,
        [FastEnumUtility.Label("incReqLevel", 0)]
        IncReqLevel = 12,
        [FastEnumUtility.Label("randOption", 0)]
        RandOption = 13,
        [FastEnumUtility.Label("randStat", 0)]
        RandStat = 14,
    }
    public enum PriceLogSource : byte
    {
        [FastEnumUtility.Label("PRICELOG_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("PRICELOG_PERSONALSHOP", 0)]
        [FastEnumUtility.Label("Personal Shop", 1)]
        PersonalShop = 1,
        [FastEnumUtility.Label("Entrusted Shop", 1)]
        [FastEnumUtility.Label("PRICELOG_ENTRUSTEDSHOP", 0)]
        EntrustedShop = 2,
    }
    [System.Flags]
    public enum PrivateStatusFlag : ushort
    {
        None = 0,
        [FastEnumUtility.Label("PS_PrimaryTrace", 0)]
        [FastEnumUtility.Label("Primary Trace", 1)]
        PrimaryTrace = 1,
        [FastEnumUtility.Label("PS_SecondaryTrace", 0)]
        [FastEnumUtility.Label("Secondary Trace", 1)]
        SecondaryTrace = 2,
        [FastEnumUtility.Label("Admin Client", 1)]
        [FastEnumUtility.Label("PS_AdminClient", 0)]
        AdminClient = 4,
        [FastEnumUtility.Label("Mob Move Observe", 1)]
        [FastEnumUtility.Label("PS_MobMoveObserve", 0)]
        MobMoveObserve = 8,
        [FastEnumUtility.Label("Manager Account", 1)]
        [FastEnumUtility.Label("PS_ManagerAccount", 0)]
        ManagerAccount = 16,
        [FastEnumUtility.Label("Out Source Super Gm", 1)]
        [FastEnumUtility.Label("PS_OutSourceSuperGM", 0)]
        OutSourceSuperGm = 32,
        [FastEnumUtility.Label("Out Source Gm", 1)]
        [FastEnumUtility.Label("PS_OutSourceGM", 0)]
        OutSourceGm = 64,
        [FastEnumUtility.Label("PS_UserGM", 0)]
        [FastEnumUtility.Label("User Gm", 1)]
        UserGm = 128,
        [FastEnumUtility.Label("PS_TesterAccount", 0)]
        [FastEnumUtility.Label("Tester Account", 1)]
        TesterAccount = 256,
    }
    public enum PrivilegeItemType : byte
    {
        [FastEnumUtility.Label("SP_Jump", 0)]
        Jump = 0,
        [FastEnumUtility.Label("SP_Summon", 0)]
        Summon = 1,
        [FastEnumUtility.Label("SP_IncDropRate", 0)]
        IncDropRate = 2,
        [FastEnumUtility.Label("SP_IncExpRate", 0)]
        IncExpRate = 3,
        [FastEnumUtility.Label("SP_Family", 0)]
        Family = 4,
    }
    public enum QuestAction : byte
    {
        Start = 0,
        End = 1,
    }
    public enum QuestArea : short
    {
        None = 0,
        [FastEnumUtility.Label("Maple Island", 0)]
        MapleIsland = 1,
        [FastEnumUtility.Label("Lith Harbor", 0)]
        LithHarbor = 2,
        Henesys = 3,
        Ellinia = 4,
        Perion = 5,
        [FastEnumUtility.Label("Kerning City", 0)]
        KerningCity = 6,
        Sleepywood = 7,
        [FastEnumUtility.Label("Nautilus Harbor", 0)]
        NautilusHarbor = 8,
        [FastEnumUtility.Label("Cygnus PQ", 0)]
        AmnesiacCygnus = 9,
        [FastEnumUtility.Label("Aliens PQ", 0)]
        AliensPQ = 10,
        [FastEnumUtility.Label("Ludibria PQ", 0)]
        LudibriaPQ = 11,
        [FastEnumUtility.Label("Victoria Island", 0)]
        VictoriaIsland = 20,
        Orbis = 30,
        [FastEnumUtility.Label("El Nath", 0)]
        ElNath = 31,
        Ludibrium = 32,
        [FastEnumUtility.Label("Aqua Road", 0)]
        AquaRoad = 33,
        [FastEnumUtility.Label("Omega Sector", 0)]
        OmegaSector = 34,
        [FastEnumUtility.Label("Masteria", 0)]
        MasteriaKerning = 35,
        [FastEnumUtility.Label("Nihal Desert", 0)]
        NihalDesert = 40,
        [FastEnumUtility.Label("Minar Forest", 0)]
        MinarForest = 41,
        [FastEnumUtility.Label("Mu Lung Garden", 0)]
        MuLungGarden = 42,
        [FastEnumUtility.Label("Korean Folk Town", 0)]
        KoreanFolkTown = 43,
        Ariant = 44,
        Magatia = 45,
        Singapore = 50,
        [FastEnumUtility.Label("Malaysia", 0)]
        MalaysiaBatam = 51,
        [FastEnumUtility.Label("New Leaf City", 0)]
        NewLeafCity = 52,
        [FastEnumUtility.Label("Mushroom Kingdom", 0)]
        MushroomKingdom = 53,
        Amoria = 60,
        Happyville = 61,
        [FastEnumUtility.Label("Crimsonwood Keep", 0)]
        CrimsonwoodKeep = 62,
        [FastEnumUtility.Label("Star Planet", 0)]
        StarPlanet = 63,
        [FastEnumUtility.Label("GM", 0)]
        GmQuest = 99,
    }
    public enum QuestCompleteResultType : byte
    {
        [FastEnumUtility.Label("QUEST_COMPLETESUCCESS", 0)]
        Success = 0,
        [FastEnumUtility.Label("Fail Npc", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_NPC", 0)]
        FailNpc = 1,
        [FastEnumUtility.Label("Fail Item", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_ITEM", 0)]
        FailItem = 2,
        [FastEnumUtility.Label("Fail Pre Quest", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_PREQUEST", 0)]
        FailPreQuest = 3,
        [FastEnumUtility.Label("Fail Info", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_INFO", 0)]
        FailInfo = 4,
        [FastEnumUtility.Label("Fail Other Info", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_OTHERINFO", 0)]
        FailOtherInfo = 5,
        [FastEnumUtility.Label("Fail Mob", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_MOB", 0)]
        FailMob = 6,
        [FastEnumUtility.Label("Fail Protected Item", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_PROTECTEDITEM", 0)]
        FailProtectedItem = 7,
        [FastEnumUtility.Label("Fail Pet No Exist", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_PETNOEXIST", 0)]
        FailPetNoExist = 8,
        [FastEnumUtility.Label("Fail Pet Condition", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_PETCONDITION", 0)]
        FailPetCondition = 9,
        [FastEnumUtility.Label("Fail Meso", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_MESO", 0)]
        FailMeso = 10,
        [FastEnumUtility.Label("Fail Time", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_TIME", 0)]
        FailTime = 11,
        [FastEnumUtility.Label("Fail Unknown", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_UNKNOWN", 0)]
        FailUnknown = 12,
        [FastEnumUtility.Label("Fail Morph", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_MORPH", 0)]
        FailMorph = 13,
        [FastEnumUtility.Label("Fail Buff", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_BUFF", 0)]
        FailBuff = 14,
        [FastEnumUtility.Label("Fail Except Buff", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_EXCEPTBUFF", 0)]
        FailExceptBuff = 15,
        [FastEnumUtility.Label("Fail Level", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_LEVEL", 0)]
        FailLevel = 16,
        [FastEnumUtility.Label("Fail Time Keep", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_TIMEKEEP", 0)]
        FailTimeKeep = 17,
        [FastEnumUtility.Label("Fail Day Of Week", 1)]
        [FastEnumUtility.Label("QUEST_COMPLETEFAIL_DAYOFWEEK", 0)]
        FailDayOfWeek = 18,
    }
    public enum QuestDayOfWeek : byte
    {
        [FastEnumUtility.Label("Sunday", 0)]
        Sunday = 0,
        [FastEnumUtility.Label("Monday", 0)]
        Monday = 1,
        [FastEnumUtility.Label("Tuesday", 0)]
        Tuesday = 2,
        [FastEnumUtility.Label("Wednesday", 0)]
        Wednesday = 3,
        [FastEnumUtility.Label("Thursday", 0)]
        Thursday = 4,
        [FastEnumUtility.Label("Friday", 0)]
        Friday = 5,
        [FastEnumUtility.Label("Saturday", 0)]
        Saturday = 6,
    }
    public enum QuestGuideOperation : byte
    {
        [FastEnumUtility.Label("QuestGuideReq_RewardMob", 0)]
        [FastEnumUtility.Label("Req Reward Mob", 1)]
        ReqRewardMob = 0,
        [FastEnumUtility.Label("QuestGuideRes_RewardMob", 0)]
        [FastEnumUtility.Label("Res Reward Mob", 1)]
        ResRewardMob = 1,
        [FastEnumUtility.Label("QuestGuideRes_ResetRewardMob", 0)]
        [FastEnumUtility.Label("Res Reset Reward Mob", 1)]
        ResResetRewardMob = 2,
    }
    public enum QuestIconType : byte
    {
        [FastEnumUtility.Label("QUEST_ICONTYPE_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("QUEST_ICONTYPE_PERFORM", 0)]
        Perform = 1,
        [FastEnumUtility.Label("Pre Complete", 1)]
        [FastEnumUtility.Label("QUEST_ICONTYPE_PRECOMPLETE", 0)]
        PreComplete = 2,
        [FastEnumUtility.Label("QUEST_ICONTYPE_COMPLETE", 0)]
        Complete = 3,
        [FastEnumUtility.Label("QUEST_ICONTYPE_TIMER", 0)]
        Timer = 4,
        [FastEnumUtility.Label("Perform Series", 1)]
        [FastEnumUtility.Label("QUEST_ICONTYPE_PERFORM_SERIES", 0)]
        PerformSeries = 5,
    }
    [System.Flags]
    public enum QuestJobExFlags : byte
    {
        None = 0,
        [FastEnumUtility.Label("Battle Mage", 1)]
        Bmage = 1,
        [FastEnumUtility.Label("Wild Hunter", 1)]
        WildHunter = 2,
        Mechanic = 8,
    }
    [System.Flags]
    public enum QuestJobFlags : uint
    {
        None = 0u,
        Novice = 1u,
        Swordman = 2u,
        Magician = 4u,
        Archer = 8u,
        Rogue = 16u,
        Pirate = 32u,
        Noblesse = 1024u,
        [FastEnumUtility.Label("Soul Fighter", 1)]
        SoulFighter = 2048u,
        [FastEnumUtility.Label("Flame Wizard", 1)]
        FlameWizard = 4096u,
        [FastEnumUtility.Label("Wind Breaker", 1)]
        WindBreaker = 8192u,
        [FastEnumUtility.Label("Night Walker", 1)]
        NightWalker = 16384u,
        [FastEnumUtility.Label("Thunder Breaker", 1)]
        Striker = 32768u,
        Legend = 1048576u,
        Aran = 2097152u,
        Evan = 4194304u,
    }
    public enum QuestLogAction
    {
        [FastEnumUtility.Label("QuestAccept", 0)]
        Accept = 1,
        [FastEnumUtility.Label("QuestComplete", 0)]
        Complete = 2,
        [FastEnumUtility.Label("QuestResign", 0)]
        Resign = 3,
        [FastEnumUtility.Label("QuestFail", 0)]
        Fail = 4,
    }
    public enum QuestRequestType : byte
    {
        [FastEnumUtility.Label("Lost Item", 1)]
        LostItem = 0,
        [FastEnumUtility.Label("Accept Quest", 1)]
        AcceptQuest = 1,
        [FastEnumUtility.Label("Complete Quest", 1)]
        CompleteQuest = 2,
        [FastEnumUtility.Label("Resign Quest", 1)]
        ResignQuest = 3,
        [FastEnumUtility.Label("Opening Script", 1)]
        OpeningScript = 4,
        [FastEnumUtility.Label("Complete Script", 1)]
        CompleteScript = 5,
    }
    public enum QuestResultType : byte
    {
        [FastEnumUtility.Label("Start Quest Timer", 1)]
        StartQuestTimer = 6,
        [FastEnumUtility.Label("End Quest Timer", 1)]
        EndQuestTimer = 7,
        [FastEnumUtility.Label("Start Time Keep Quest Timer", 1)]
        StartTimeKeepQuestTimer = 8,
        [FastEnumUtility.Label("End Time Keep Quest Timer", 1)]
        EndTimeKeepQuestTimer = 9,
        Success = 10,
        [FastEnumUtility.Label("Failed Unknown", 1)]
        FailedUnknown = 11,
        [FastEnumUtility.Label("Failed Inventory", 1)]
        FailedInventory = 12,
        [FastEnumUtility.Label("Failed Meso", 1)]
        FailedMeso = 13,
        [FastEnumUtility.Label("Failed Pet", 1)]
        FailedPet = 14,
        [FastEnumUtility.Label("Failed Equipped", 1)]
        FailedEquipped = 15,
        [FastEnumUtility.Label("Failed Only Item", 1)]
        FailedOnlyItem = 16,
        [FastEnumUtility.Label("Failed Time Over", 1)]
        FailedTimeOver = 17,
        [FastEnumUtility.Label("Reset Quest Timer", 1)]
        ResetQuestTimer = 18,
    }
    public enum QuestState : byte
    {
        [FastEnumUtility.Label("Not Started", 1)]
        [FastEnumUtility.Label("QUEST_STATE_NONE", 0)]
        NotStarted = 0,
        [FastEnumUtility.Label("In Progress", 1)]
        [FastEnumUtility.Label("QUEST_STATE_PERFORM", 0)]
        InProgress = 1,
        [FastEnumUtility.Label("QUEST_STATE_COMPLETE", 0)]
        Completed = 2,
        [FastEnumUtility.Label("Party Quest", 1)]
        [FastEnumUtility.Label("QUEST_STATE_PARTYQUEST", 0)]
        PartyQuest = 3,
        [FastEnumUtility.Label("QUEST_STATE_NO", 0)]
        Cannot = 4,
    }
    public enum RaceSelectType : byte
    {
        [FastEnumUtility.Label("RACE_SELECT_RESISTANCE", 0)]
        Resistance = 0,
        [FastEnumUtility.Label("RACE_SELECT_NORMAL", 0)]
        Normal = 1,
        [FastEnumUtility.Label("RACE_SELECT_CYGNUS", 0)]
        Cygnus = 2,
        [FastEnumUtility.Label("RACE_SELECT_ARAN", 0)]
        Aran = 3,
        [FastEnumUtility.Label("RACE_SELECT_EVAN", 0)]
        Evan = 4,
    }
    public enum RainbowWeekType : byte
    {
        [FastEnumUtility.Label("Boss Mob", 1)]
        [FastEnumUtility.Label("RAINBOWWEEK_BOSSMOB", 0)]
        BossMob = 0,
        [FastEnumUtility.Label("RAINBOWWEEK_MASSACRE", 0)]
        Massacre = 1,
        [FastEnumUtility.Label("RAINBOWWEEK_NO", 0)]
        No = 2,
    }
    public enum RandomMorphResult : byte
    {
        [FastEnumUtility.Label("RandomMorphRes_Done", 0)]
        Done = 0,
        [FastEnumUtility.Label("RandomMorphRes_Failed", 0)]
        Failed = 1,
        [FastEnumUtility.Label("No Target", 1)]
        [FastEnumUtility.Label("RandomMorphFailReason_NoTarget", 0)]
        NoTarget = 2,
        [FastEnumUtility.Label("Not In Town", 1)]
        [FastEnumUtility.Label("RandomMorphFailReason_NotInTown", 0)]
        NotInTown = 3,
        [FastEnumUtility.Label("RandomMorphFailReason_UnknownError", 0)]
        [FastEnumUtility.Label("Unknown Error", 1)]
        UnknownError = 4,
    }
    public enum RateType : byte
    {
        Exp = 0,
        Meso = 1,
        Drop = 2,
    }
    public enum ReactorEventType : byte
    {
        Hit = 0,
        Touch = 1,
        Skill = 2,
        Quest = 3,
        Timeout = 100,
    }
    public enum ReactorLayer : byte
    {
        [FastEnumUtility.Label("REACTOR_LAYER_NORMAL", 0)]
        Normal = 0,
        [FastEnumUtility.Label("REACTOR_LAYER_BACK", 0)]
        Back = 1,
        [FastEnumUtility.Label("REACTOR_LAYER_UPPERMOST", 0)]
        Uppermost = 2,
    }
    public enum RecipeClass : byte
    {
        [FastEnumUtility.Label("RECIPE_CLASS_START", 0)]
        Start = 0,
        [FastEnumUtility.Label("RECIPE_CLASS_NORMAL", 0)]
        Normal = 1,
        [FastEnumUtility.Label("RECIPE_CLASS_HIDDEN", 0)]
        Hidden = 2,
        [FastEnumUtility.Label("Monster Crystal", 1)]
        [FastEnumUtility.Label("RECIPE_CLASS_MONSTER_CRYSTAL", 0)]
        MonsterCrystal = 3,
        [FastEnumUtility.Label("Equip Disassemble", 1)]
        [FastEnumUtility.Label("RECIPE_CLASS_EQUIP_DISASSEMBLE", 0)]
        EquipDisassemble = 4,
        [FastEnumUtility.Label("RECIPE_CLASS_END", 0)]
        End = 5,
    }
    public enum RecoveryInfoType : byte
    {
        [FastEnumUtility.Label("RECOVERYINFO_TOTALHP_APPLY", 0)]
        [FastEnumUtility.Label("Total Hp Apply", 1)]
        TotalHpApply = 0,
        [FastEnumUtility.Label("RECOVERYINFO_TOTALHP_REQ_MERIT", 0)]
        [FastEnumUtility.Label("Total Hp Req Merit", 1)]
        TotalHpReqMerit = 1,
        [FastEnumUtility.Label("RECOVERYINFO_TOTALMP_APPLY", 0)]
        [FastEnumUtility.Label("Total Mp Apply", 1)]
        TotalMpApply = 2,
        [FastEnumUtility.Label("RECOVERYINFO_TOTALMP_REQ_MERIT", 0)]
        [FastEnumUtility.Label("Total Mp Req Merit", 1)]
        TotalMpReqMerit = 3,
        [FastEnumUtility.Label("Average Hp Apply", 1)]
        [FastEnumUtility.Label("RECOVERYINFO_AVERAGEHP_APPLY", 0)]
        AverageHpApply = 4,
        [FastEnumUtility.Label("Average Hp Req Merit", 1)]
        [FastEnumUtility.Label("RECOVERYINFO_AVERAGEHP_REQ_MERIT", 0)]
        AverageHpReqMerit = 5,
        [FastEnumUtility.Label("Average Mp Apply", 1)]
        [FastEnumUtility.Label("RECOVERYINFO_AVERAGEMP_APPLY", 0)]
        AverageMpApply = 6,
        [FastEnumUtility.Label("Average Mp Req Merit", 1)]
        [FastEnumUtility.Label("RECOVERYINFO_AVERAGEMP_REQ_MERIT", 0)]
        AverageMpReqMerit = 7,
        [FastEnumUtility.Label("RECOVERYINFO_USE_COUNT", 0)]
        [FastEnumUtility.Label("Use Count", 1)]
        UseCount = 8,
        [FastEnumUtility.Label("Forecast Use Per Hour", 1)]
        [FastEnumUtility.Label("RECOVERYINFO_FORECAST_USE_PERHOUR", 0)]
        ForecastUsePerHour = 9,
        [FastEnumUtility.Label("RECOVERYINFO_NO", 0)]
        No = 10,
    }
    public enum RegionCode
    {
        [FastEnumUtility.Label("kRegionCode_Default", 0)]
        Default = 0,
        [FastEnumUtility.Label("kRegionCode_CT1", 0)]
        Ct1 = 1,
        [FastEnumUtility.Label("kRegionCode_CT2", 0)]
        Ct2 = 2,
        [FastEnumUtility.Label("kRegionCode_CT3", 0)]
        Ct3 = 3,
        [FastEnumUtility.Label("kRegionCode_CT4", 0)]
        Ct4 = 4,
        [FastEnumUtility.Label("kRegionCode_CT5", 0)]
        Ct5 = 5,
        [FastEnumUtility.Label("kRegionCode_CT6", 0)]
        Ct6 = 6,
        [FastEnumUtility.Label("kRegionCode_CNC1", 0)]
        Cnc1 = 11,
        [FastEnumUtility.Label("kRegionCode_CNC2", 0)]
        Cnc2 = 12,
        [FastEnumUtility.Label("kRegionCode_CNC3", 0)]
        Cnc3 = 13,
        [FastEnumUtility.Label("kRegionCode_CNC4", 0)]
        Cnc4 = 14,
        [FastEnumUtility.Label("kRegionCode_CNC5", 0)]
        Cnc5 = 15,
        [FastEnumUtility.Label("kRegionCode_CNC6", 0)]
        Cnc6 = 16,
        [FastEnumUtility.Label("kRegionCode_NPNA1", 0)]
        Npna1 = 100,
        [FastEnumUtility.Label("kRegionCode_NXA1", 0)]
        Nxa1 = 200,
        [FastEnumUtility.Label("kRegionCode_NXA2", 0)]
        Nxa2 = 201,
        [FastEnumUtility.Label("kRegionCode_TW2", 0)]
        Tw2 = 300,
        [FastEnumUtility.Label("kRegionCode_TH1", 0)]
        Th1 = 400,
        [FastEnumUtility.Label("kRegionCode_JP2", 0)]
        Jp2 = 500,
        [FastEnumUtility.Label("kRegionCode_JP3", 0)]
        Jp3 = 501,
        [FastEnumUtility.Label("kRegionCode_JP4", 0)]
        Jp4 = 502,
        [FastEnumUtility.Label("kRegionCode_EU1", 0)]
        Eu1 = 600,
    }
    public enum ReportCategory : byte
    {
        [FastEnumUtility.Label("TYPEID_CURSE", 0)]
        Curse = 1,
        [FastEnumUtility.Label("TYPEID_AD", 0)]
        Advertisement = 2,
        [FastEnumUtility.Label("TYPEID_CHEAT", 0)]
        Cheat = 3,
        [FastEnumUtility.Label("Real Money Trade", 1)]
        [FastEnumUtility.Label("TYPEID_REALMONEYTRADE", 0)]
        RealMoneyTrade = 5,
        [FastEnumUtility.Label("TYPEID_IMPERSONATION", 0)]
        Impersonation = 7,
        [FastEnumUtility.Label("Private Info", 1)]
        [FastEnumUtility.Label("TYPEID_PRIVATEINFO", 0)]
        PrivateInfo = 8,
        [FastEnumUtility.Label("Macro Program", 1)]
        [FastEnumUtility.Label("TYPEID_MACROPROGRAM", 0)]
        MacroProgram = 9,
        [FastEnumUtility.Label("Admin Macro Program", 1)]
        [FastEnumUtility.Label("TYPEID_ADMINMACROPROGRAM", 0)]
        AdminMacroProgram = 10,
    }
    public enum ReservedEffectType : byte
    {
        [FastEnumUtility.Label("One Time Animation", 1)]
        [FastEnumUtility.Label("RESERVED_EFFECT_ONETIME_ANIMATION", 0)]
        OneTimeAnimation = 0,
        [FastEnumUtility.Label("RESERVED_EFFECT_SQUIB", 0)]
        Squib = 1,
        [FastEnumUtility.Label("Map Transfer", 1)]
        [FastEnumUtility.Label("RESERVED_EFFECT_MAP_TRANSFER", 0)]
        MapTransfer = 2,
        [FastEnumUtility.Label("RESERVED_EFFECT_SET_AVATAR_LOOK", 0)]
        [FastEnumUtility.Label("Set Avatar Look", 1)]
        SetAvatarLook = 3,
        [FastEnumUtility.Label("RESERVED_EFFECT_SET_AVATAR_ACTION", 0)]
        [FastEnumUtility.Label("Set Avatar Action", 1)]
        SetAvatarAction = 4,
        [FastEnumUtility.Label("RESERVED_EFFECT_SET_BGM", 0)]
        [FastEnumUtility.Label("Set Bgm", 1)]
        SetBgm = 5,
        [FastEnumUtility.Label("RESERVED_EFFECT_SET_EMOTION", 0)]
        [FastEnumUtility.Label("Set Emotion", 1)]
        SetEmotion = 6,
    }
    public enum RewardType : byte
    {
        [FastEnumUtility.Label("REWARD_LEVEL_20", 0)]
        Level20 = 0,
        [FastEnumUtility.Label("First Job Advance", 1)]
        [FastEnumUtility.Label("REWARD_FIRST_JOBADVANCE", 0)]
        FirstJobAdvance = 1,
        [FastEnumUtility.Label("REWARD_SECOND_JOBADVANCE", 0)]
        [FastEnumUtility.Label("Second Job Advance", 1)]
        SecondJobAdvance = 2,
        [FastEnumUtility.Label("Add 10 Buddy", 1)]
        [FastEnumUtility.Label("REWARD_ADD_10_BUDDY", 0)]
        Add10Buddy = 3,
        [FastEnumUtility.Label("Cygnus Level 10", 1)]
        [FastEnumUtility.Label("REWARD_CYGNUS_LEVEL_10", 0)]
        CygnusLevel10 = 4,
        [FastEnumUtility.Label("Cygnus Level 70", 1)]
        [FastEnumUtility.Label("REWARD_CYGNUS_LEVEL_70", 0)]
        CygnusLevel70 = 5,
        [FastEnumUtility.Label("Cygnus Mount", 1)]
        [FastEnumUtility.Label("REWARD_CYGNUS_MOUNT", 0)]
        CygnusMount = 6,
        [FastEnumUtility.Label("Level Up", 1)]
        [FastEnumUtility.Label("REWARD_LEVELUP", 0)]
        LevelUp = 7,
        [FastEnumUtility.Label("Aran Level Up", 1)]
        [FastEnumUtility.Label("REWARD_ARAN_LEVELUP", 0)]
        AranLevelUp = 8,
        [FastEnumUtility.Label("Aran Wedding", 1)]
        [FastEnumUtility.Label("REWARD_ARAN_WEDDING", 0)]
        AranWedding = 9,
        [FastEnumUtility.Label("Logout Gift", 1)]
        [FastEnumUtility.Label("REWARD_LOGOUT_GIFT", 0)]
        LogoutGift = 10,
        [FastEnumUtility.Label("Dual Wedding", 1)]
        [FastEnumUtility.Label("REWARD_DUAL_WEDDING", 0)]
        DualWedding = 11,
        [FastEnumUtility.Label("Level Up Ap Sp1", 1)]
        [FastEnumUtility.Label("REWARD_LEVELUP_APSP1", 0)]
        LevelUpApSp1 = 12,
        [FastEnumUtility.Label("Level Up Ap Sp2", 1)]
        [FastEnumUtility.Label("REWARD_LEVELUP_APSP2", 0)]
        LevelUpApSp2 = 13,
        [FastEnumUtility.Label("Level Up Ap Sp3", 1)]
        [FastEnumUtility.Label("REWARD_LEVELUP_APSP3", 0)]
        LevelUpApSp3 = 14,
        [FastEnumUtility.Label("REWARD_RES_WEDDING", 0)]
        [FastEnumUtility.Label("Res Wedding", 1)]
        ResWedding = 15,
    }
    public enum RockPaperScissorsOperation : byte
    {
        [FastEnumUtility.Label("RPSReq_StartGame", 0)]
        [FastEnumUtility.Label("Req Start Game", 1)]
        ReqStartGame = 0,
        [FastEnumUtility.Label("RPSReq_UserSelection", 0)]
        [FastEnumUtility.Label("Req User Selection", 1)]
        ReqUserSelection = 1,
        [FastEnumUtility.Label("RPSReq_TimeOver", 0)]
        [FastEnumUtility.Label("Req Time Over", 1)]
        ReqTimeOver = 2,
        [FastEnumUtility.Label("RPSReq_Continue", 0)]
        [FastEnumUtility.Label("Req Continue", 1)]
        ReqContinue = 3,
        [FastEnumUtility.Label("RPSReq_Quit", 0)]
        [FastEnumUtility.Label("Req Quit", 1)]
        ReqQuit = 4,
        [FastEnumUtility.Label("RPSReq_Retry", 0)]
        [FastEnumUtility.Label("Req Retry", 1)]
        ReqRetry = 5,
        [FastEnumUtility.Label("RPSRes_NotEnoughMoney", 0)]
        [FastEnumUtility.Label("Res Not Enough Money", 1)]
        ResNotEnoughMoney = 6,
        [FastEnumUtility.Label("RPSRes_NoEmptySlotForReward", 0)]
        [FastEnumUtility.Label("Res No Empty Slot For Reward", 1)]
        ResNoEmptySlotForReward = 7,
        [FastEnumUtility.Label("RPSRes_Open", 0)]
        [FastEnumUtility.Label("Res Open", 1)]
        ResOpen = 8,
        [FastEnumUtility.Label("RPSRes_StartGame", 0)]
        [FastEnumUtility.Label("Res Start Game", 1)]
        ResStartGame = 9,
        [FastEnumUtility.Label("RPSRes_TimeOver", 0)]
        [FastEnumUtility.Label("Res Time Over", 1)]
        ResTimeOver = 10,
        [FastEnumUtility.Label("RPSRes_NpcSelection", 0)]
        [FastEnumUtility.Label("Res Npc Selection", 1)]
        ResNpcSelection = 11,
        [FastEnumUtility.Label("RPSRes_Coninue", 0)]
        [FastEnumUtility.Label("Res Continue", 1)]
        ResContinue = 12,
        [FastEnumUtility.Label("RPSRes_Quit", 0)]
        [FastEnumUtility.Label("Res Quit", 1)]
        ResQuit = 13,
        [FastEnumUtility.Label("RPSRes_Retry", 0)]
        [FastEnumUtility.Label("Res Retry", 1)]
        ResRetry = 14,
    }
    public enum ScreenshotFormat : byte
    {
        [FastEnumUtility.Label("SFF_BMP", 0)]
        Bmp = 0,
        [FastEnumUtility.Label("SFF_JPG", 0)]
        Jpg = 1,
        [FastEnumUtility.Label("SFF_TGA", 0)]
        Tga = 2,
        [FastEnumUtility.Label("SFF_PNG", 0)]
        Png = 3,
        [FastEnumUtility.Label("SFF_DDS", 0)]
        Dds = 4,
        [FastEnumUtility.Label("SFF_PPM", 0)]
        Ppm = 5,
        [FastEnumUtility.Label("SFF_DIB", 0)]
        Dib = 6,
        [FastEnumUtility.Label("SFF_HDR", 0)]
        Hdr = 7,
        [FastEnumUtility.Label("SFF_PFM", 0)]
        Pfm = 8,
    }
    public enum SecondPasswordState : byte
    {
        [FastEnumUtility.Label("CHECK_SPW_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("CHECK_SPW_ENABLED", 0)]
        Enabled = 1,
        [FastEnumUtility.Label("CHECK_SPW_DISABLED", 0)]
        Disabled = 2,
        [FastEnumUtility.Label("CHECK_SPW_DONOTCHECK", 0)]
        [FastEnumUtility.Label("Do Not Check", 1)]
        DoNotCheck = 3,
        [FastEnumUtility.Label("CHECK_SPW_UNINITIALIZED", 0)]
        Uninitialized = 255,
    }
    public enum SecondaryStatType : byte
    {
        [FastEnumUtility.Label("Energy Charged", 1)]
        [FastEnumUtility.Label("TS_ENERGY_CHARGED", 0)]
        EnergyCharged = 0,
        [FastEnumUtility.Label("Dash Speed", 1)]
        [FastEnumUtility.Label("TS_DASH_SPEED", 0)]
        DashSpeed = 1,
        [FastEnumUtility.Label("Dash Jump", 1)]
        [FastEnumUtility.Label("TS_DASH_JUMP", 0)]
        DashJump = 2,
        [FastEnumUtility.Label("Ride Vehicle", 1)]
        [FastEnumUtility.Label("TS_RIDE_VEHICLE", 0)]
        RideVehicle = 3,
        [FastEnumUtility.Label("Party Booster", 1)]
        [FastEnumUtility.Label("TS_PARTY_BOOSTER", 0)]
        PartyBooster = 4,
        [FastEnumUtility.Label("Guided Bullet", 1)]
        [FastEnumUtility.Label("TS_GUIDED_BULLET", 0)]
        GuidedBullet = 5,
        [FastEnumUtility.Label("TS_UNDEAD", 0)]
        Undead = 6,
    }
    public enum SecurityPacketType : byte
    {
        [FastEnumUtility.Label("Memory Region", 1)]
        [FastEnumUtility.Label("SECURITYPACKET_MEMORYREGION", 0)]
        MemoryRegion = 0,
        [FastEnumUtility.Label("Memory Hash", 1)]
        [FastEnumUtility.Label("SECURITYPACKET_MEMORYHASH", 0)]
        MemoryHash = 1,
        [FastEnumUtility.Label("Check Client Integrity", 1)]
        [FastEnumUtility.Label("SECURITYPACKET_CHECKCLIENTINTEGRITY", 0)]
        CheckClientIntegrity = 2,
    }
    public enum ServerLockType : byte
    {
        [FastEnumUtility.Label("LT_NoCheck", 0)]
        [FastEnumUtility.Label("No Check", 1)]
        NoCheck = 0,
        [FastEnumUtility.Label("LT_Terminal", 0)]
        Terminal = 1,
        [FastEnumUtility.Label("LT_PartyAdver", 0)]
        [FastEnumUtility.Label("Party Adver", 1)]
        PartyAdver = 2,
        [FastEnumUtility.Label("LT_User", 0)]
        User = 3,
        [FastEnumUtility.Label("LT_Field", 0)]
        Field = 4,
        [FastEnumUtility.Label("Field Set", 1)]
        [FastEnumUtility.Label("LT_FieldSet", 0)]
        FieldSet = 5,
        [FastEnumUtility.Label("Field Container", 1)]
        [FastEnumUtility.Label("LT_FieldContainer", 0)]
        FieldContainer = 6,
    }
    public enum ServerMessageType : byte
    {
        [FastEnumUtility.Label("Drop Pick Up Message", 1)]
        [FastEnumUtility.Label("MS_DropPickUpMessage", 0)]
        DropPickUpMessage = 0,
        [FastEnumUtility.Label("MS_QuestRecordMessage", 0)]
        [FastEnumUtility.Label("Quest Record Message", 1)]
        QuestRecordMessage = 1,
        [FastEnumUtility.Label("Cash Item Expire Message", 1)]
        [FastEnumUtility.Label("MS_CashItemExpireMessage", 0)]
        CashItemExpireMessage = 2,
        [FastEnumUtility.Label("Inc Exp Message", 1)]
        [FastEnumUtility.Label("MS_IncEXPMessage", 0)]
        IncExpMessage = 3,
        [FastEnumUtility.Label("Inc Sp Message", 1)]
        [FastEnumUtility.Label("MS_IncSPMessage", 0)]
        IncSpMessage = 4,
        [FastEnumUtility.Label("Inc Pop Message", 1)]
        [FastEnumUtility.Label("MS_IncPOPMessage", 0)]
        IncPopMessage = 5,
        [FastEnumUtility.Label("Inc Money Message", 1)]
        [FastEnumUtility.Label("MS_IncMoneyMessage", 0)]
        IncMoneyMessage = 6,
        [FastEnumUtility.Label("Inc Gp Message", 1)]
        [FastEnumUtility.Label("MS_IncGPMessage", 0)]
        IncGpMessage = 7,
        [FastEnumUtility.Label("Give Buff Message", 1)]
        [FastEnumUtility.Label("MS_GiveBuffMessage", 0)]
        GiveBuffMessage = 8,
        [FastEnumUtility.Label("General Item Expire Message", 1)]
        [FastEnumUtility.Label("MS_GeneralItemExpireMessage", 0)]
        GeneralItemExpireMessage = 9,
        [FastEnumUtility.Label("MS_SystemMessage", 0)]
        [FastEnumUtility.Label("System Message", 1)]
        SystemMessage = 10,
        [FastEnumUtility.Label("MS_QuestRecordExMessage", 0)]
        [FastEnumUtility.Label("Quest Record Ex Message", 1)]
        QuestRecordExMessage = 11,
        [FastEnumUtility.Label("Item Protect Expire Message", 1)]
        [FastEnumUtility.Label("MS_ItemProtectExpireMessage", 0)]
        ItemProtectExpireMessage = 12,
        [FastEnumUtility.Label("Item Expire Replace Message", 1)]
        [FastEnumUtility.Label("MS_ItemExpireReplaceMessage", 0)]
        ItemExpireReplaceMessage = 13,
        [FastEnumUtility.Label("MS_SkillExpireMessage", 0)]
        [FastEnumUtility.Label("Skill Expire Message", 1)]
        SkillExpireMessage = 14,
    }
    public enum ServerPacketOpcode : ushort
    {
        [FastEnumUtility.Label("Check Password Result", 1)]
        [FastEnumUtility.Label("LP_CheckPasswordResult", 0)]
        CheckPasswordResult = 0,
        [FastEnumUtility.Label("Guest ID Login Result", 1)]
        [FastEnumUtility.Label("LP_GuestIDLoginResult", 0)]
        GuestIDLoginResult = 1,
        [FastEnumUtility.Label("Account Info Result", 1)]
        [FastEnumUtility.Label("LP_AccountInfoResult", 0)]
        AccountInfoResult = 2,
        [FastEnumUtility.Label("Check User Limit Result", 1)]
        [FastEnumUtility.Label("LP_CheckUserLimitResult", 0)]
        CheckUserLimitResult = 3,
        [FastEnumUtility.Label("LP_SetAccountResult", 0)]
        [FastEnumUtility.Label("Set Account Result", 1)]
        SetAccountResult = 4,
        [FastEnumUtility.Label("Confirm EULA Result", 1)]
        [FastEnumUtility.Label("LP_ConfirmEULAResult", 0)]
        ConfirmEULAResult = 5,
        [FastEnumUtility.Label("Check Pin Code Result", 1)]
        [FastEnumUtility.Label("LP_CheckPinCodeResult", 0)]
        CheckPinCodeResult = 6,
        [FastEnumUtility.Label("LP_UpdatePinCodeResult", 0)]
        [FastEnumUtility.Label("Update Pin Code Result", 1)]
        UpdatePinCodeResult = 7,
        [FastEnumUtility.Label("LP_ViewAllCharResult", 0)]
        [FastEnumUtility.Label("View All Char Result", 1)]
        ViewAllCharResult = 8,
        [FastEnumUtility.Label("LP_SelectCharacterByVACResult", 0)]
        [FastEnumUtility.Label("Select Character By VAC Result", 1)]
        SelectCharacterByVACResult = 9,
        [FastEnumUtility.Label("LP_WorldInformation", 0)]
        [FastEnumUtility.Label("World Information", 1)]
        WorldInformation = 10,
        [FastEnumUtility.Label("LP_SelectWorldResult", 0)]
        [FastEnumUtility.Label("Select World Result", 1)]
        SelectWorldResult = 11,
        [FastEnumUtility.Label("LP_SelectCharacterResult", 0)]
        [FastEnumUtility.Label("Select Character Result", 1)]
        SelectCharacterResult = 12,
        [FastEnumUtility.Label("Check Duplicated ID Result", 1)]
        [FastEnumUtility.Label("LP_CheckDuplicatedIDResult", 0)]
        CheckDuplicatedIDResult = 13,
        [FastEnumUtility.Label("Create New Character Result", 1)]
        [FastEnumUtility.Label("LP_CreateNewCharacterResult", 0)]
        CreateNewCharacterResult = 14,
        [FastEnumUtility.Label("Delete Character Result", 1)]
        [FastEnumUtility.Label("LP_DeleteCharacterResult", 0)]
        DeleteCharacterResult = 15,
        [FastEnumUtility.Label("LP_MigrateCommand", 0)]
        [FastEnumUtility.Label("Migrate Command", 1)]
        MigrateCommand = 16,
        [FastEnumUtility.Label("Alive Req", 1)]
        [FastEnumUtility.Label("LP_AliveReq", 0)]
        AliveReq = 17,
        [FastEnumUtility.Label("Authen Code Changed", 1)]
        [FastEnumUtility.Label("LP_AuthenCodeChanged", 0)]
        AuthenCodeChanged = 18,
        [FastEnumUtility.Label("Authen Message", 1)]
        [FastEnumUtility.Label("LP_AuthenMessage", 0)]
        AuthenMessage = 19,
        [FastEnumUtility.Label("LP_SecurityPacket", 0)]
        [FastEnumUtility.Label("Security Packet", 1)]
        SecurityPacket = 20,
        [FastEnumUtility.Label("Enable SPW Result", 1)]
        [FastEnumUtility.Label("LP_EnableSPWResult", 0)]
        EnableSPWResult = 21,
        [FastEnumUtility.Label("Delete Character OTP Request", 1)]
        [FastEnumUtility.Label("LP_DeleteCharacterOTPRequest", 0)]
        DeleteCharacterOTPRequest = 22,
        [FastEnumUtility.Label("Check Crc Result", 1)]
        [FastEnumUtility.Label("LP_CheckCrcResult", 0)]
        CheckCrcResult = 23,
        [FastEnumUtility.Label("LP_LatestConnectedWorld", 0)]
        [FastEnumUtility.Label("Latest Connected World", 1)]
        LatestConnectedWorld = 24,
        [FastEnumUtility.Label("LP_RecommendWorldMessage", 0)]
        [FastEnumUtility.Label("Recommend World Message", 1)]
        RecommendWorldMessage = 25,
        [FastEnumUtility.Label("Check Extra Char Info Result", 1)]
        [FastEnumUtility.Label("LP_CheckExtraCharInfoResult", 0)]
        CheckExtraCharInfoResult = 26,
        [FastEnumUtility.Label("Check SPW Result", 1)]
        [FastEnumUtility.Label("LP_CheckSPWResult", 0)]
        CheckSPWResult = 27,
        [FastEnumUtility.Label("Inventory Operation", 1)]
        [FastEnumUtility.Label("LP_InventoryOperation", 0)]
        InventoryOperation = 28,
        [FastEnumUtility.Label("Inventory Grow", 1)]
        [FastEnumUtility.Label("LP_InventoryGrow", 0)]
        InventoryGrow = 29,
        [FastEnumUtility.Label("LP_StatChanged", 0)]
        [FastEnumUtility.Label("Stat Changed", 1)]
        StatChanged = 30,
        [FastEnumUtility.Label("LP_TemporaryStatSet", 0)]
        [FastEnumUtility.Label("Temporary Stat Set", 1)]
        TemporaryStatSet = 31,
        [FastEnumUtility.Label("LP_TemporaryStatReset", 0)]
        [FastEnumUtility.Label("Temporary Stat Reset", 1)]
        TemporaryStatReset = 32,
        [FastEnumUtility.Label("Forced Stat Set", 1)]
        [FastEnumUtility.Label("LP_ForcedStatSet", 0)]
        ForcedStatSet = 33,
        [FastEnumUtility.Label("Forced Stat Reset", 1)]
        [FastEnumUtility.Label("LP_ForcedStatReset", 0)]
        ForcedStatReset = 34,
        [FastEnumUtility.Label("Change Skill Record Result", 1)]
        [FastEnumUtility.Label("LP_ChangeSkillRecordResult", 0)]
        ChangeSkillRecordResult = 35,
        [FastEnumUtility.Label("LP_SkillUseResult", 0)]
        [FastEnumUtility.Label("Skill Use Result", 1)]
        SkillUseResult = 36,
        [FastEnumUtility.Label("Give Popularity Result", 1)]
        [FastEnumUtility.Label("LP_GivePopularityResult", 0)]
        GivePopularityResult = 37,
        [FastEnumUtility.Label("LP_Message", 0)]
        Message = 38,
        [FastEnumUtility.Label("LP_SendOpenFullClientLink", 0)]
        [FastEnumUtility.Label("Send Open Full Client Link", 1)]
        SendOpenFullClientLink = 39,
        [FastEnumUtility.Label("LP_MemoResult", 0)]
        [FastEnumUtility.Label("Memo Result", 1)]
        MemoResult = 40,
        [FastEnumUtility.Label("LP_MapTransferResult", 0)]
        [FastEnumUtility.Label("Map Transfer Result", 1)]
        MapTransferResult = 41,
        [FastEnumUtility.Label("Anti Macro Result", 1)]
        [FastEnumUtility.Label("LP_AntiMacroResult", 0)]
        AntiMacroResult = 42,
        [FastEnumUtility.Label("Initial Quiz Start", 1)]
        [FastEnumUtility.Label("LP_InitialQuizStart", 0)]
        InitialQuizStart = 43,
        [FastEnumUtility.Label("Claim Result", 1)]
        [FastEnumUtility.Label("LP_ClaimResult", 0)]
        ClaimResult = 44,
        [FastEnumUtility.Label("LP_SetClaimSvrAvailableTime", 0)]
        [FastEnumUtility.Label("Set Claim Svr Available Time", 1)]
        SetClaimSvrAvailableTime = 45,
        [FastEnumUtility.Label("Claim Svr Status Changed", 1)]
        [FastEnumUtility.Label("LP_ClaimSvrStatusChanged", 0)]
        ClaimSvrStatusChanged = 46,
        [FastEnumUtility.Label("LP_SetTamingMobInfo", 0)]
        [FastEnumUtility.Label("Set Taming Mob Info", 1)]
        SetTamingMobInfo = 47,
        [FastEnumUtility.Label("LP_QuestClear", 0)]
        [FastEnumUtility.Label("Quest Clear", 1)]
        QuestClear = 48,
        [FastEnumUtility.Label("Entrusted Shop Check Result", 1)]
        [FastEnumUtility.Label("LP_EntrustedShopCheckResult", 0)]
        EntrustedShopCheckResult = 49,
        [FastEnumUtility.Label("LP_SkillLearnItemResult", 0)]
        [FastEnumUtility.Label("Skill Learn Item Result", 1)]
        SkillLearnItemResult = 50,
        [FastEnumUtility.Label("LP_SkillResetItemResult", 0)]
        [FastEnumUtility.Label("Skill Reset Item Result", 1)]
        SkillResetItemResult = 51,
        [FastEnumUtility.Label("Gather Item Result", 1)]
        [FastEnumUtility.Label("LP_GatherItemResult", 0)]
        GatherItemResult = 52,
        [FastEnumUtility.Label("LP_SortItemResult", 0)]
        [FastEnumUtility.Label("Sort Item Result", 1)]
        SortItemResult = 53,
        [FastEnumUtility.Label("LP_RemoteShopOpenResult", 0)]
        [FastEnumUtility.Label("Remote Shop Open Result", 1)]
        RemoteShopOpenResult = 54,
        [FastEnumUtility.Label("LP_SueCharacterResult", 0)]
        [FastEnumUtility.Label("Sue Character Result", 1)]
        SueCharacterResult = 55,
        [FastEnumUtility.Label("LP_MigrateToCashShopResult", 0)]
        [FastEnumUtility.Label("Migrate To Cash Shop Result", 1)]
        MigrateToCashShopResult = 56,
        [FastEnumUtility.Label("LP_TradeMoneyLimit", 0)]
        [FastEnumUtility.Label("Trade Money Limit", 1)]
        TradeMoneyLimit = 57,
        [FastEnumUtility.Label("LP_SetGender", 0)]
        [FastEnumUtility.Label("Set Gender", 1)]
        SetGender = 58,
        [FastEnumUtility.Label("Guild BBS", 1)]
        [FastEnumUtility.Label("LP_GuildBBS", 0)]
        GuildBBS = 59,
        [FastEnumUtility.Label("LP_PetDeadMessage", 0)]
        [FastEnumUtility.Label("Pet Dead Message", 1)]
        PetDeadMessage = 60,
        [FastEnumUtility.Label("Character Info", 1)]
        [FastEnumUtility.Label("LP_CharacterInfo", 0)]
        CharacterInfo = 61,
        [FastEnumUtility.Label("LP_PartyResult", 0)]
        [FastEnumUtility.Label("Party Result", 1)]
        PartyResult = 62,
        [FastEnumUtility.Label("Expedition Request", 1)]
        [FastEnumUtility.Label("LP_ExpeditionRequest", 0)]
        ExpeditionRequest = 63,
        [FastEnumUtility.Label("Expedition Noti", 1)]
        [FastEnumUtility.Label("LP_ExpeditionNoti", 0)]
        ExpeditionNoti = 64,
        [FastEnumUtility.Label("Friend Result", 1)]
        [FastEnumUtility.Label("LP_FriendResult", 0)]
        FriendResult = 65,
        [FastEnumUtility.Label("Guild Request", 1)]
        [FastEnumUtility.Label("LP_GuildRequest", 0)]
        GuildRequest = 66,
        [FastEnumUtility.Label("Guild Result", 1)]
        [FastEnumUtility.Label("LP_GuildResult", 0)]
        GuildResult = 67,
        [FastEnumUtility.Label("Alliance Result", 1)]
        [FastEnumUtility.Label("LP_AllianceResult", 0)]
        AllianceResult = 68,
        [FastEnumUtility.Label("LP_TownPortal", 0)]
        [FastEnumUtility.Label("Town Portal", 1)]
        TownPortal = 69,
        [FastEnumUtility.Label("LP_OpenGate", 0)]
        [FastEnumUtility.Label("Open Gate", 1)]
        OpenGate = 70,
        [FastEnumUtility.Label("Broadcast Msg", 1)]
        [FastEnumUtility.Label("LP_BroadcastMsg", 0)]
        BroadcastMsg = 71,
        [FastEnumUtility.Label("Incubator Result", 1)]
        [FastEnumUtility.Label("LP_IncubatorResult", 0)]
        IncubatorResult = 72,
        [FastEnumUtility.Label("LP_ShopScannerResult", 0)]
        [FastEnumUtility.Label("Shop Scanner Result", 1)]
        ShopScannerResult = 73,
        [FastEnumUtility.Label("LP_ShopLinkResult", 0)]
        [FastEnumUtility.Label("Shop Link Result", 1)]
        ShopLinkResult = 74,
        [FastEnumUtility.Label("LP_MarriageRequest", 0)]
        [FastEnumUtility.Label("Marriage Request", 1)]
        MarriageRequest = 75,
        [FastEnumUtility.Label("LP_MarriageResult", 0)]
        [FastEnumUtility.Label("Marriage Result", 1)]
        MarriageResult = 76,
        [FastEnumUtility.Label("LP_WeddingGiftResult", 0)]
        [FastEnumUtility.Label("Wedding Gift Result", 1)]
        WeddingGiftResult = 77,
        [FastEnumUtility.Label("LP_MarriedPartnerMapTransfer", 0)]
        [FastEnumUtility.Label("Married Partner Map Transfer", 1)]
        MarriedPartnerMapTransfer = 78,
        [FastEnumUtility.Label("Cash Pet Food Result", 1)]
        [FastEnumUtility.Label("LP_CashPetFoodResult", 0)]
        CashPetFoodResult = 79,
        [FastEnumUtility.Label("LP_SetWeekEventMessage", 0)]
        [FastEnumUtility.Label("Set Week Event Message", 1)]
        SetWeekEventMessage = 80,
        [FastEnumUtility.Label("LP_SetPotionDiscountRate", 0)]
        [FastEnumUtility.Label("Set Potion Discount Rate", 1)]
        SetPotionDiscountRate = 81,
        [FastEnumUtility.Label("Bridle Mob Catch Fail", 1)]
        [FastEnumUtility.Label("LP_BridleMobCatchFail", 0)]
        BridleMobCatchFail = 82,
        [FastEnumUtility.Label("Imitated NPC Result", 1)]
        [FastEnumUtility.Label("LP_ImitatedNPCResult", 0)]
        ImitatedNPCResult = 83,
        [FastEnumUtility.Label("Imitated NPC Data", 1)]
        [FastEnumUtility.Label("LP_ImitatedNPCData", 0)]
        ImitatedNPCData = 84,
        [FastEnumUtility.Label("LP_LimitedNPCDisableInfo", 0)]
        [FastEnumUtility.Label("Limited NPC Disable Info", 1)]
        LimitedNPCDisableInfo = 85,
        [FastEnumUtility.Label("LP_MonsterBookSetCard", 0)]
        [FastEnumUtility.Label("Monster Book Set Card", 1)]
        MonsterBookSetCard = 86,
        [FastEnumUtility.Label("LP_MonsterBookSetCover", 0)]
        [FastEnumUtility.Label("Monster Book Set Cover", 1)]
        MonsterBookSetCover = 87,
        [FastEnumUtility.Label("Hour Changed", 1)]
        [FastEnumUtility.Label("LP_HourChanged", 0)]
        HourChanged = 88,
        [FastEnumUtility.Label("LP_MiniMapOnOff", 0)]
        [FastEnumUtility.Label("Mini Map On Off", 1)]
        MiniMapOnOff = 89,
        [FastEnumUtility.Label("Consult Authkey Update", 1)]
        [FastEnumUtility.Label("LP_ConsultAuthkeyUpdate", 0)]
        ConsultAuthkeyUpdate = 90,
        [FastEnumUtility.Label("Class Competition Authkey Update", 1)]
        [FastEnumUtility.Label("LP_ClassCompetitionAuthkeyUpdate", 0)]
        ClassCompetitionAuthkeyUpdate = 91,
        [FastEnumUtility.Label("LP_WebBoardAuthkeyUpdate", 0)]
        [FastEnumUtility.Label("Web Board Authkey Update", 1)]
        WebBoardAuthkeyUpdate = 92,
        [FastEnumUtility.Label("LP_SessionValue", 0)]
        [FastEnumUtility.Label("Session Value", 1)]
        SessionValue = 93,
        [FastEnumUtility.Label("LP_PartyValue", 0)]
        [FastEnumUtility.Label("Party Value", 1)]
        PartyValue = 94,
        [FastEnumUtility.Label("Field Set Variable", 1)]
        [FastEnumUtility.Label("LP_FieldSetVariable", 0)]
        FieldSetVariable = 95,
        [FastEnumUtility.Label("Bonus Exp Rate Changed", 1)]
        [FastEnumUtility.Label("LP_BonusExpRateChanged", 0)]
        BonusExpRateChanged = 96,
        [FastEnumUtility.Label("LP_PotionDiscountRateChanged", 0)]
        [FastEnumUtility.Label("Potion Discount Rate Changed", 1)]
        PotionDiscountRateChanged = 97,
        [FastEnumUtility.Label("Family Chart Result", 1)]
        [FastEnumUtility.Label("LP_FamilyChartResult", 0)]
        FamilyChartResult = 98,
        [FastEnumUtility.Label("Family Info Result", 1)]
        [FastEnumUtility.Label("LP_FamilyInfoResult", 0)]
        FamilyInfoResult = 99,
        [FastEnumUtility.Label("Family Result", 1)]
        [FastEnumUtility.Label("LP_FamilyResult", 0)]
        FamilyResult = 100,
        [FastEnumUtility.Label("Family Join Request", 1)]
        [FastEnumUtility.Label("LP_FamilyJoinRequest", 0)]
        FamilyJoinRequest = 101,
        [FastEnumUtility.Label("Family Join Request Result", 1)]
        [FastEnumUtility.Label("LP_FamilyJoinRequestResult", 0)]
        FamilyJoinRequestResult = 102,
        [FastEnumUtility.Label("Family Join Accepted", 1)]
        [FastEnumUtility.Label("LP_FamilyJoinAccepted", 0)]
        FamilyJoinAccepted = 103,
        [FastEnumUtility.Label("Family Privilege List", 1)]
        [FastEnumUtility.Label("LP_FamilyPrivilegeList", 0)]
        FamilyPrivilegeList = 104,
        [FastEnumUtility.Label("Family Famous Point Inc Result", 1)]
        [FastEnumUtility.Label("LP_FamilyFamousPointIncResult", 0)]
        FamilyFamousPointIncResult = 105,
        [FastEnumUtility.Label("Family Notify Login Or Logout", 1)]
        [FastEnumUtility.Label("LP_FamilyNotifyLoginOrLogout", 0)]
        FamilyNotifyLoginOrLogout = 106,
        [FastEnumUtility.Label("Family Set Privilege", 1)]
        [FastEnumUtility.Label("LP_FamilySetPrivilege", 0)]
        FamilySetPrivilege = 107,
        [FastEnumUtility.Label("Family Summon Request", 1)]
        [FastEnumUtility.Label("LP_FamilySummonRequest", 0)]
        FamilySummonRequest = 108,
        [FastEnumUtility.Label("LP_NotifyLevelUp", 0)]
        [FastEnumUtility.Label("Notify Level Up", 1)]
        NotifyLevelUp = 109,
        [FastEnumUtility.Label("LP_NotifyWedding", 0)]
        [FastEnumUtility.Label("Notify Wedding", 1)]
        NotifyWedding = 110,
        [FastEnumUtility.Label("LP_NotifyJobChange", 0)]
        [FastEnumUtility.Label("Notify Job Change", 1)]
        NotifyJobChange = 111,
        [FastEnumUtility.Label("Inc Rate Changed", 1)]
        [FastEnumUtility.Label("LP_IncRateChanged", 0)]
        IncRateChanged = 112,
        [FastEnumUtility.Label("LP_MapleTVUseRes", 0)]
        [FastEnumUtility.Label("Maple TV Use Res", 1)]
        MapleTVUseRes = 113,
        [FastEnumUtility.Label("Avatar Megaphone Res", 1)]
        [FastEnumUtility.Label("LP_AvatarMegaphoneRes", 0)]
        AvatarMegaphoneRes = 114,
        [FastEnumUtility.Label("Avatar Megaphone Update Message", 1)]
        [FastEnumUtility.Label("LP_AvatarMegaphoneUpdateMessage", 0)]
        AvatarMegaphoneUpdateMessage = 115,
        [FastEnumUtility.Label("Avatar Megaphone Clear Message", 1)]
        [FastEnumUtility.Label("LP_AvatarMegaphoneClearMessage", 0)]
        AvatarMegaphoneClearMessage = 116,
        [FastEnumUtility.Label("Cancel Name Change Result", 1)]
        [FastEnumUtility.Label("LP_CancelNameChangeResult", 0)]
        CancelNameChangeResult = 117,
        [FastEnumUtility.Label("Cancel Transfer World Result", 1)]
        [FastEnumUtility.Label("LP_CancelTransferWorldResult", 0)]
        CancelTransferWorldResult = 118,
        [FastEnumUtility.Label("Destroy Shop Result", 1)]
        [FastEnumUtility.Label("LP_DestroyShopResult", 0)]
        DestroyShopResult = 119,
        [FastEnumUtility.Label("LP_FAKEGMNOTICE", 0)]
        FAKEGMNOTICE = 120,
        [FastEnumUtility.Label("LP_SuccessInUseGachaponBox", 0)]
        [FastEnumUtility.Label("Success In Use Gachapon Box", 1)]
        SuccessInUseGachaponBox = 121,
        [FastEnumUtility.Label("LP_NewYearCardRes", 0)]
        [FastEnumUtility.Label("New Year Card Res", 1)]
        NewYearCardRes = 122,
        [FastEnumUtility.Label("LP_RandomMorphRes", 0)]
        [FastEnumUtility.Label("Random Morph Res", 1)]
        RandomMorphRes = 123,
        [FastEnumUtility.Label("Cancel Name Change By Other", 1)]
        [FastEnumUtility.Label("LP_CancelNameChangeByOther", 0)]
        CancelNameChangeByOther = 124,
        [FastEnumUtility.Label("LP_SetBuyEquipExt", 0)]
        [FastEnumUtility.Label("Set Buy Equip Ext", 1)]
        SetBuyEquipExt = 125,
        [FastEnumUtility.Label("LP_SetPassenserRequest", 0)]
        [FastEnumUtility.Label("Set Passenser Request", 1)]
        SetPassenserRequest = 126,
        [FastEnumUtility.Label("LP_ScriptProgressMessage", 0)]
        [FastEnumUtility.Label("Script Progress Message", 1)]
        ScriptProgressMessage = 127,
        [FastEnumUtility.Label("Data CRC Check Failed", 1)]
        [FastEnumUtility.Label("LP_DataCRCCheckFailed", 0)]
        DataCRCCheckFailed = 128,
        [FastEnumUtility.Label("Cake Pie Event Result", 1)]
        [FastEnumUtility.Label("LP_CakePieEventResult", 0)]
        CakePieEventResult = 129,
        [FastEnumUtility.Label("LP_UpdateGMBoard", 0)]
        [FastEnumUtility.Label("Update GM Board", 1)]
        UpdateGMBoard = 130,
        [FastEnumUtility.Label("LP_ShowSlotMessage", 0)]
        [FastEnumUtility.Label("Show Slot Message", 1)]
        ShowSlotMessage = 131,
        [FastEnumUtility.Label("LP_WildHunterInfo", 0)]
        [FastEnumUtility.Label("Wild Hunter Info", 1)]
        WildHunterInfo = 132,
        [FastEnumUtility.Label("Account More Info", 1)]
        [FastEnumUtility.Label("LP_AccountMoreInfo", 0)]
        AccountMoreInfo = 133,
        [FastEnumUtility.Label("Find Friend", 1)]
        [FastEnumUtility.Label("LP_FindFirend", 0)]
        FindFriend = 134,
        [FastEnumUtility.Label("LP_StageChange", 0)]
        [FastEnumUtility.Label("Stage Change", 1)]
        StageChange = 135,
        [FastEnumUtility.Label("Dragon Ball Box", 1)]
        [FastEnumUtility.Label("LP_DragonBallBox", 0)]
        DragonBallBox = 136,
        [FastEnumUtility.Label("Ask User Whether Use Pams Song", 1)]
        [FastEnumUtility.Label("LP_AskUserWhetherUsePamsSong", 0)]
        AskUserWhetherUsePamsSong = 137,
        [FastEnumUtility.Label("LP_TransferChannel", 0)]
        [FastEnumUtility.Label("Transfer Channel", 1)]
        TransferChannel = 138,
        [FastEnumUtility.Label("Disallowed Delivery Quest List", 1)]
        [FastEnumUtility.Label("LP_DisallowedDeliveryQuestList", 0)]
        DisallowedDeliveryQuestList = 139,
        [FastEnumUtility.Label("LP_MacroSysDataInit", 0)]
        [FastEnumUtility.Label("Macro Sys Data Init", 1)]
        MacroSysDataInit = 140,
        [FastEnumUtility.Label("LP_SetField", 0)]
        [FastEnumUtility.Label("Set Field", 1)]
        SetField = 141,
        [FastEnumUtility.Label("LP_SetITC", 0)]
        [FastEnumUtility.Label("Set ITC", 1)]
        SetITC = 142,
        [FastEnumUtility.Label("LP_SetCashShop", 0)]
        [FastEnumUtility.Label("Set Cash Shop", 1)]
        SetCashShop = 143,
        [FastEnumUtility.Label("LP_SetBackgroundEffect", 0)]
        [FastEnumUtility.Label("Set Background Effect", 1)]
        SetBackgroundEffect = 144,
        [FastEnumUtility.Label("LP_SetMapObjectVisible", 0)]
        [FastEnumUtility.Label("Set Map Object Visible", 1)]
        SetMapObjectVisible = 145,
        [FastEnumUtility.Label("Clear Background Effect", 1)]
        [FastEnumUtility.Label("LP_ClearBackgroundEffect", 0)]
        ClearBackgroundEffect = 146,
        [FastEnumUtility.Label("LP_TransferFieldReqIgnored", 0)]
        [FastEnumUtility.Label("Transfer Field Req Ignored", 1)]
        TransferFieldReqIgnored = 147,
        [FastEnumUtility.Label("LP_TransferChannelReqIgnored", 0)]
        [FastEnumUtility.Label("Transfer Channel Req Ignored", 1)]
        TransferChannelReqIgnored = 148,
        [FastEnumUtility.Label("Field Specific Data", 1)]
        [FastEnumUtility.Label("LP_FieldSpecificData", 0)]
        FieldSpecificData = 149,
        [FastEnumUtility.Label("Group Message", 1)]
        [FastEnumUtility.Label("LP_GroupMessage", 0)]
        GroupMessage = 150,
        [FastEnumUtility.Label("LP_Whisper", 0)]
        Whisper = 151,
        [FastEnumUtility.Label("Couple Message", 1)]
        [FastEnumUtility.Label("LP_CoupleMessage", 0)]
        CoupleMessage = 152,
        [FastEnumUtility.Label("LP_MobSummonItemUseResult", 0)]
        [FastEnumUtility.Label("Mob Summon Item Use Result", 1)]
        MobSummonItemUseResult = 153,
        [FastEnumUtility.Label("Field Effect", 1)]
        [FastEnumUtility.Label("LP_FieldEffect", 0)]
        FieldEffect = 154,
        [FastEnumUtility.Label("Field Obstacle On Off", 1)]
        [FastEnumUtility.Label("LP_FieldObstacleOnOff", 0)]
        FieldObstacleOnOff = 155,
        [FastEnumUtility.Label("Field Obstacle On Off Status", 1)]
        [FastEnumUtility.Label("LP_FieldObstacleOnOffStatus", 0)]
        FieldObstacleOnOffStatus = 156,
        [FastEnumUtility.Label("Field Obstacle All Reset", 1)]
        [FastEnumUtility.Label("LP_FieldObstacleAllReset", 0)]
        FieldObstacleAllReset = 157,
        [FastEnumUtility.Label("Blow Weather", 1)]
        [FastEnumUtility.Label("LP_BlowWeather", 0)]
        BlowWeather = 158,
        [FastEnumUtility.Label("LP_PlayJukeBox", 0)]
        [FastEnumUtility.Label("Play Juke Box", 1)]
        PlayJukeBox = 159,
        [FastEnumUtility.Label("Admin Result", 1)]
        [FastEnumUtility.Label("LP_AdminResult", 0)]
        AdminResult = 160,
        [FastEnumUtility.Label("LP_Quiz", 0)]
        Quiz = 161,
        [FastEnumUtility.Label("LP_Desc", 0)]
        Desc = 162,
        [FastEnumUtility.Label("LP_Clock", 0)]
        Clock = 163,
        [FastEnumUtility.Label("LP_CONTIMOVE", 0)]
        CONTIMOVE = 164,
        [FastEnumUtility.Label("LP_CONTISTATE", 0)]
        CONTISTATE = 165,
        [FastEnumUtility.Label("LP_SetQuestClear", 0)]
        [FastEnumUtility.Label("Set Quest Clear", 1)]
        SetQuestClear = 166,
        [FastEnumUtility.Label("LP_SetQuestTime", 0)]
        [FastEnumUtility.Label("Set Quest Time", 1)]
        SetQuestTime = 167,
        [FastEnumUtility.Label("LP_Warn", 0)]
        Warn = 168,
        [FastEnumUtility.Label("LP_SetObjectState", 0)]
        [FastEnumUtility.Label("Set Object State", 1)]
        SetObjectState = 169,
        [FastEnumUtility.Label("Destroy Clock", 1)]
        [FastEnumUtility.Label("LP_DestroyClock", 0)]
        DestroyClock = 170,
        [FastEnumUtility.Label("LP_ShowArenaResult", 0)]
        [FastEnumUtility.Label("Show Arena Result", 1)]
        ShowArenaResult = 171,
        [FastEnumUtility.Label("LP_StalkResult", 0)]
        [FastEnumUtility.Label("Stalk Result", 1)]
        StalkResult = 172,
        [FastEnumUtility.Label("LP_MassacreIncGauge", 0)]
        [FastEnumUtility.Label("Massacre Inc Gauge", 1)]
        MassacreIncGauge = 173,
        [FastEnumUtility.Label("LP_MassacreResult", 0)]
        [FastEnumUtility.Label("Massacre Result", 1)]
        MassacreResult = 174,
        [FastEnumUtility.Label("LP_QuickslotMappedInit", 0)]
        [FastEnumUtility.Label("Quickslot Mapped Init", 1)]
        QuickslotMappedInit = 175,
        [FastEnumUtility.Label("Foot Hold Info", 1)]
        [FastEnumUtility.Label("LP_FootHoldInfo", 0)]
        FootHoldInfo = 176,
        [FastEnumUtility.Label("LP_RequestFootHoldInfo", 0)]
        [FastEnumUtility.Label("Request Foot Hold Info", 1)]
        RequestFootHoldInfo = 177,
        [FastEnumUtility.Label("Field Kill Count", 1)]
        [FastEnumUtility.Label("LP_FieldKillCount", 0)]
        FieldKillCount = 178,
        [FastEnumUtility.Label("LP_UserEnterField", 0)]
        [FastEnumUtility.Label("User Enter Field", 1)]
        UserEnterField = 179,
        [FastEnumUtility.Label("LP_UserLeaveField", 0)]
        [FastEnumUtility.Label("User Leave Field", 1)]
        UserLeaveField = 180,
        [FastEnumUtility.Label("LP_UserChat", 0)]
        [FastEnumUtility.Label("User Chat", 1)]
        UserChat = 181,
        [FastEnumUtility.Label("LP_UserChatNLCPQ", 0)]
        [FastEnumUtility.Label("User Chat NLCPQ", 1)]
        UserChatNLCPQ = 182,
        [FastEnumUtility.Label("LP_UserADBoard", 0)]
        [FastEnumUtility.Label("User AD Board", 1)]
        UserADBoard = 183,
        [FastEnumUtility.Label("LP_UserMiniRoomBalloon", 0)]
        [FastEnumUtility.Label("User Mini Room Balloon", 1)]
        UserMiniRoomBalloon = 184,
        [FastEnumUtility.Label("LP_UserConsumeItemEffect", 0)]
        [FastEnumUtility.Label("User Consume Item Effect", 1)]
        UserConsumeItemEffect = 185,
        [FastEnumUtility.Label("LP_UserItemUpgradeEffect", 0)]
        [FastEnumUtility.Label("User Item Upgrade Effect", 1)]
        UserItemUpgradeEffect = 186,
        [FastEnumUtility.Label("LP_UserItemHyperUpgradeEffect", 0)]
        [FastEnumUtility.Label("User Item Hyper Upgrade Effect", 1)]
        UserItemHyperUpgradeEffect = 187,
        [FastEnumUtility.Label("LP_UserItemOptionUpgradeEffect", 0)]
        [FastEnumUtility.Label("User Item Option Upgrade Effect", 1)]
        UserItemOptionUpgradeEffect = 188,
        [FastEnumUtility.Label("LP_UserItemReleaseEffect", 0)]
        [FastEnumUtility.Label("User Item Release Effect", 1)]
        UserItemReleaseEffect = 189,
        [FastEnumUtility.Label("LP_UserItemUnreleaseEffect", 0)]
        [FastEnumUtility.Label("User Item Unrelease Effect", 1)]
        UserItemUnreleaseEffect = 190,
        [FastEnumUtility.Label("LP_UserHitByUser", 0)]
        [FastEnumUtility.Label("User Hit By User", 1)]
        UserHitByUser = 191,
        [FastEnumUtility.Label("LP_UserTeslaTriangle", 0)]
        [FastEnumUtility.Label("User Tesla Triangle", 1)]
        UserTeslaTriangle = 192,
        [FastEnumUtility.Label("LP_UserFollowCharacter", 0)]
        [FastEnumUtility.Label("User Follow Character", 1)]
        UserFollowCharacter = 193,
        [FastEnumUtility.Label("LP_UserShowPQReward", 0)]
        [FastEnumUtility.Label("User Show PQ Reward", 1)]
        UserShowPQReward = 194,
        [FastEnumUtility.Label("LP_UserSetPhase", 0)]
        [FastEnumUtility.Label("User Set Phase", 1)]
        UserSetPhase = 195,
        [FastEnumUtility.Label("LP_SetPortalUsable", 0)]
        [FastEnumUtility.Label("Set Portal Usable", 1)]
        SetPortalUsable = 196,
        [FastEnumUtility.Label("LP_ShowPamsSongResult", 0)]
        [FastEnumUtility.Label("Show Pams Song Result", 1)]
        ShowPamsSongResult = 197,
        [FastEnumUtility.Label("LP_PetActivated", 0)]
        [FastEnumUtility.Label("Pet Activated", 1)]
        PetActivated = 198,
        [FastEnumUtility.Label("LP_PetEvol", 0)]
        [FastEnumUtility.Label("Pet Evol", 1)]
        PetEvol = 199,
        [FastEnumUtility.Label("LP_PetTransferField", 0)]
        [FastEnumUtility.Label("Pet Transfer Field", 1)]
        PetTransferField = 200,
        [FastEnumUtility.Label("LP_PetMove", 0)]
        [FastEnumUtility.Label("Pet Move", 1)]
        PetMove = 201,
        [FastEnumUtility.Label("LP_PetAction", 0)]
        [FastEnumUtility.Label("Pet Action", 1)]
        PetAction = 202,
        [FastEnumUtility.Label("LP_PetNameChanged", 0)]
        [FastEnumUtility.Label("Pet Name Changed", 1)]
        PetNameChanged = 203,
        [FastEnumUtility.Label("LP_PetLoadExceptionList", 0)]
        [FastEnumUtility.Label("Pet Load Exception List", 1)]
        PetLoadExceptionList = 204,
        [FastEnumUtility.Label("LP_PetActionCommand", 0)]
        [FastEnumUtility.Label("Pet Action Command", 1)]
        PetActionCommand = 205,
        [FastEnumUtility.Label("Dragon Enter Field", 1)]
        [FastEnumUtility.Label("LP_DragonEnterField", 0)]
        DragonEnterField = 206,
        [FastEnumUtility.Label("Dragon Move", 1)]
        [FastEnumUtility.Label("LP_DragonMove", 0)]
        DragonMove = 207,
        [FastEnumUtility.Label("Dragon Leave Field", 1)]
        [FastEnumUtility.Label("LP_DragonLeaveField", 0)]
        DragonLeaveField = 208,
        [FastEnumUtility.Label("LP_UserMove", 0)]
        [FastEnumUtility.Label("User Move", 1)]
        UserMove = 210,
        [FastEnumUtility.Label("LP_UserMeleeAttack", 0)]
        [FastEnumUtility.Label("User Melee Attack", 1)]
        UserMeleeAttack = 211,
        [FastEnumUtility.Label("LP_UserShootAttack", 0)]
        [FastEnumUtility.Label("User Shoot Attack", 1)]
        UserShootAttack = 212,
        [FastEnumUtility.Label("LP_UserMagicAttack", 0)]
        [FastEnumUtility.Label("User Magic Attack", 1)]
        UserMagicAttack = 213,
        [FastEnumUtility.Label("LP_UserBodyAttack", 0)]
        [FastEnumUtility.Label("User Body Attack", 1)]
        UserBodyAttack = 214,
        [FastEnumUtility.Label("LP_UserSkillPrepare", 0)]
        [FastEnumUtility.Label("User Skill Prepare", 1)]
        UserSkillPrepare = 215,
        [FastEnumUtility.Label("LP_UserMovingShootAttackPrepare", 0)]
        [FastEnumUtility.Label("User Moving Shoot Attack Prepare", 1)]
        UserMovingShootAttackPrepare = 216,
        [FastEnumUtility.Label("LP_UserSkillCancel", 0)]
        [FastEnumUtility.Label("User Skill Cancel", 1)]
        UserSkillCancel = 217,
        [FastEnumUtility.Label("LP_UserHit", 0)]
        [FastEnumUtility.Label("User Hit", 1)]
        UserHit = 218,
        [FastEnumUtility.Label("LP_UserEmotion", 0)]
        [FastEnumUtility.Label("User Emotion", 1)]
        UserEmotion = 219,
        [FastEnumUtility.Label("LP_UserSetActiveEffectItem", 0)]
        [FastEnumUtility.Label("User Set Active Effect Item", 1)]
        UserSetActiveEffectItem = 220,
        [FastEnumUtility.Label("LP_UserShowUpgradeTombEffect", 0)]
        [FastEnumUtility.Label("User Show Upgrade Tomb Effect", 1)]
        UserShowUpgradeTombEffect = 221,
        [FastEnumUtility.Label("LP_UserSetActivePortableChair", 0)]
        [FastEnumUtility.Label("User Set Active Portable Chair", 1)]
        UserSetActivePortableChair = 222,
        [FastEnumUtility.Label("LP_UserAvatarModified", 0)]
        [FastEnumUtility.Label("User Avatar Modified", 1)]
        UserAvatarModified = 223,
        [FastEnumUtility.Label("LP_UserEffectRemote", 0)]
        [FastEnumUtility.Label("User Effect Remote", 1)]
        UserEffectRemote = 224,
        [FastEnumUtility.Label("LP_UserTemporaryStatSet", 0)]
        [FastEnumUtility.Label("User Temporary Stat Set", 1)]
        UserTemporaryStatSet = 225,
        [FastEnumUtility.Label("LP_UserTemporaryStatReset", 0)]
        [FastEnumUtility.Label("User Temporary Stat Reset", 1)]
        UserTemporaryStatReset = 226,
        [FastEnumUtility.Label("LP_UserHP", 0)]
        [FastEnumUtility.Label("User HP", 1)]
        UserHP = 227,
        [FastEnumUtility.Label("LP_UserGuildNameChanged", 0)]
        [FastEnumUtility.Label("User Guild Name Changed", 1)]
        UserGuildNameChanged = 228,
        [FastEnumUtility.Label("LP_UserGuildMarkChanged", 0)]
        [FastEnumUtility.Label("User Guild Mark Changed", 1)]
        UserGuildMarkChanged = 229,
        [FastEnumUtility.Label("LP_UserThrowGrenade", 0)]
        [FastEnumUtility.Label("User Throw Grenade", 1)]
        UserThrowGrenade = 230,
        [FastEnumUtility.Label("LP_UserSitResult", 0)]
        [FastEnumUtility.Label("User Sit Result", 1)]
        UserSitResult = 231,
        [FastEnumUtility.Label("LP_UserEmotionLocal", 0)]
        [FastEnumUtility.Label("User Emotion Local", 1)]
        UserEmotionLocal = 232,
        [FastEnumUtility.Label("LP_UserEffectLocal", 0)]
        [FastEnumUtility.Label("User Effect Local", 1)]
        UserEffectLocal = 233,
        [FastEnumUtility.Label("LP_UserTeleport", 0)]
        [FastEnumUtility.Label("User Teleport", 1)]
        UserTeleport = 234,
        [FastEnumUtility.Label("LP_Premium", 0)]
        Premium = 235,
        [FastEnumUtility.Label("LP_MesoGive_Succeeded", 0)]
        MesoGive_Succeeded = 236,
        [FastEnumUtility.Label("LP_MesoGive_Failed", 0)]
        MesoGive_Failed = 237,
        [FastEnumUtility.Label("LP_Random_Mesobag_Succeed", 0)]
        Random_Mesobag_Succeed = 238,
        [FastEnumUtility.Label("LP_Random_Mesobag_Failed", 0)]
        Random_Mesobag_Failed = 239,
        [FastEnumUtility.Label("Field Fade In Out", 1)]
        [FastEnumUtility.Label("LP_FieldFadeInOut", 0)]
        FieldFadeInOut = 240,
        [FastEnumUtility.Label("Field Fade Out Force", 1)]
        [FastEnumUtility.Label("LP_FieldFadeOutForce", 0)]
        FieldFadeOutForce = 241,
        [FastEnumUtility.Label("LP_UserQuestResult", 0)]
        [FastEnumUtility.Label("User Quest Result", 1)]
        UserQuestResult = 242,
        [FastEnumUtility.Label("LP_NotifyHPDecByField", 0)]
        [FastEnumUtility.Label("Notify HP Dec By Field", 1)]
        NotifyHPDecByField = 243,
        [FastEnumUtility.Label("LP_UserPetSkillChanged", 0)]
        [FastEnumUtility.Label("User Pet Skill Changed", 1)]
        UserPetSkillChanged = 244,
        [FastEnumUtility.Label("LP_UserBalloonMsg", 0)]
        [FastEnumUtility.Label("User Balloon Msg", 1)]
        UserBalloonMsg = 245,
        [FastEnumUtility.Label("LP_PlayEventSound", 0)]
        [FastEnumUtility.Label("Play Event Sound", 1)]
        PlayEventSound = 246,
        [FastEnumUtility.Label("LP_PlayMinigameSound", 0)]
        [FastEnumUtility.Label("Play Minigame Sound", 1)]
        PlayMinigameSound = 247,
        [FastEnumUtility.Label("LP_UserMakerResult", 0)]
        [FastEnumUtility.Label("User Maker Result", 1)]
        UserMakerResult = 248,
        [FastEnumUtility.Label("LP_UserOpenConsultBoard", 0)]
        [FastEnumUtility.Label("User Open Consult Board", 1)]
        UserOpenConsultBoard = 249,
        [FastEnumUtility.Label("LP_UserOpenClassCompetitionPage", 0)]
        [FastEnumUtility.Label("User Open Class Competition Page", 1)]
        UserOpenClassCompetitionPage = 250,
        [FastEnumUtility.Label("LP_UserOpenUI", 0)]
        [FastEnumUtility.Label("User Open UI", 1)]
        UserOpenUI = 251,
        [FastEnumUtility.Label("LP_UserOpenUIWithOption", 0)]
        [FastEnumUtility.Label("User Open UI With Option", 1)]
        UserOpenUIWithOption = 252,
        [FastEnumUtility.Label("LP_SetDirectionMode", 0)]
        [FastEnumUtility.Label("Set Direction Mode", 1)]
        SetDirectionMode = 253,
        [FastEnumUtility.Label("LP_SetStandAloneMode", 0)]
        [FastEnumUtility.Label("Set Stand Alone Mode", 1)]
        SetStandAloneMode = 254,
        [FastEnumUtility.Label("LP_UserHireTutor", 0)]
        [FastEnumUtility.Label("User Hire Tutor", 1)]
        UserHireTutor = 255,
        [FastEnumUtility.Label("LP_UserTutorMsg", 0)]
        [FastEnumUtility.Label("User Tutor Msg", 1)]
        UserTutorMsg = 256,
        [FastEnumUtility.Label("Inc Combo", 1)]
        [FastEnumUtility.Label("LP_IncCombo", 0)]
        IncCombo = 257,
        [FastEnumUtility.Label("LP_UserRandomEmotion", 0)]
        [FastEnumUtility.Label("User Random Emotion", 1)]
        UserRandomEmotion = 258,
        [FastEnumUtility.Label("LP_ResignQuestReturn", 0)]
        [FastEnumUtility.Label("Resign Quest Return", 1)]
        ResignQuestReturn = 259,
        [FastEnumUtility.Label("LP_PassMateName", 0)]
        [FastEnumUtility.Label("Pass Mate Name", 1)]
        PassMateName = 260,
        [FastEnumUtility.Label("LP_SetRadioSchedule", 0)]
        [FastEnumUtility.Label("Set Radio Schedule", 1)]
        SetRadioSchedule = 261,
        [FastEnumUtility.Label("LP_UserOpenSkillGuide", 0)]
        [FastEnumUtility.Label("User Open Skill Guide", 1)]
        UserOpenSkillGuide = 262,
        [FastEnumUtility.Label("LP_UserNoticeMsg", 0)]
        [FastEnumUtility.Label("User Notice Msg", 1)]
        UserNoticeMsg = 263,
        [FastEnumUtility.Label("LP_UserChatMsg", 0)]
        [FastEnumUtility.Label("User Chat Msg", 1)]
        UserChatMsg = 264,
        [FastEnumUtility.Label("LP_UserBuffzoneEffect", 0)]
        [FastEnumUtility.Label("User Buffzone Effect", 1)]
        UserBuffzoneEffect = 265,
        [FastEnumUtility.Label("LP_UserGoToCommoditySN", 0)]
        [FastEnumUtility.Label("User Go To Commodity SN", 1)]
        UserGoToCommoditySN = 266,
        [FastEnumUtility.Label("LP_UserDamageMeter", 0)]
        [FastEnumUtility.Label("User Damage Meter", 1)]
        UserDamageMeter = 267,
        [FastEnumUtility.Label("LP_UserTimeBombAttack", 0)]
        [FastEnumUtility.Label("User Time Bomb Attack", 1)]
        UserTimeBombAttack = 268,
        [FastEnumUtility.Label("LP_UserPassiveMove", 0)]
        [FastEnumUtility.Label("User Passive Move", 1)]
        UserPassiveMove = 269,
        [FastEnumUtility.Label("LP_UserFollowCharacterFailed", 0)]
        [FastEnumUtility.Label("User Follow Character Failed", 1)]
        UserFollowCharacterFailed = 270,
        [FastEnumUtility.Label("LP_UserRequestVengeance", 0)]
        [FastEnumUtility.Label("User Request Vengeance", 1)]
        UserRequestVengeance = 271,
        [FastEnumUtility.Label("LP_UserRequestExJablin", 0)]
        [FastEnumUtility.Label("User Request Ex Jablin", 1)]
        UserRequestExJablin = 272,
        [FastEnumUtility.Label("LP_UserAskAPSPEvent", 0)]
        [FastEnumUtility.Label("User Ask APSP Event", 1)]
        UserAskAPSPEvent = 273,
        [FastEnumUtility.Label("LP_QuestGuideResult", 0)]
        [FastEnumUtility.Label("Quest Guide Result", 1)]
        QuestGuideResult = 274,
        [FastEnumUtility.Label("LP_UserDeliveryQuest", 0)]
        [FastEnumUtility.Label("User Delivery Quest", 1)]
        UserDeliveryQuest = 275,
        [FastEnumUtility.Label("LP_SkillCooltimeSet", 0)]
        [FastEnumUtility.Label("Skill Cooltime Set", 1)]
        SkillCooltimeSet = 276,
        [FastEnumUtility.Label("LP_SummonedEnterField", 0)]
        [FastEnumUtility.Label("Summoned Enter Field", 1)]
        SummonedEnterField = 278,
        [FastEnumUtility.Label("LP_SummonedLeaveField", 0)]
        [FastEnumUtility.Label("Summoned Leave Field", 1)]
        SummonedLeaveField = 279,
        [FastEnumUtility.Label("LP_SummonedMove", 0)]
        [FastEnumUtility.Label("Summoned Move", 1)]
        SummonedMove = 280,
        [FastEnumUtility.Label("LP_SummonedAttack", 0)]
        [FastEnumUtility.Label("Summoned Attack", 1)]
        SummonedAttack = 281,
        [FastEnumUtility.Label("LP_SummonedSkill", 0)]
        [FastEnumUtility.Label("Summoned Skill", 1)]
        SummonedSkill = 282,
        [FastEnumUtility.Label("LP_SummonedHit", 0)]
        [FastEnumUtility.Label("Summoned Hit", 1)]
        SummonedHit = 283,
        [FastEnumUtility.Label("LP_MobEnterField", 0)]
        [FastEnumUtility.Label("Mob Enter Field", 1)]
        MobEnterField = 284,
        [FastEnumUtility.Label("LP_MobLeaveField", 0)]
        [FastEnumUtility.Label("Mob Leave Field", 1)]
        MobLeaveField = 285,
        [FastEnumUtility.Label("LP_MobChangeController", 0)]
        [FastEnumUtility.Label("Mob Change Controller", 1)]
        MobChangeController = 286,
        [FastEnumUtility.Label("LP_MobMove", 0)]
        [FastEnumUtility.Label("Mob Move", 1)]
        MobMove = 287,
        [FastEnumUtility.Label("LP_MobCtrlAck", 0)]
        [FastEnumUtility.Label("Mob Ctrl Ack", 1)]
        MobCtrlAck = 288,
        [FastEnumUtility.Label("LP_MobCtrlHint", 0)]
        [FastEnumUtility.Label("Mob Ctrl Hint", 1)]
        MobCtrlHint = 289,
        [FastEnumUtility.Label("LP_MobStatSet", 0)]
        [FastEnumUtility.Label("Mob Stat Set", 1)]
        MobStatSet = 290,
        [FastEnumUtility.Label("LP_MobStatReset", 0)]
        [FastEnumUtility.Label("Mob Stat Reset", 1)]
        MobStatReset = 291,
        [FastEnumUtility.Label("LP_MobSuspendReset", 0)]
        [FastEnumUtility.Label("Mob Suspend Reset", 1)]
        MobSuspendReset = 292,
        [FastEnumUtility.Label("LP_MobAffected", 0)]
        [FastEnumUtility.Label("Mob Affected", 1)]
        MobAffected = 293,
        [FastEnumUtility.Label("LP_MobDamaged", 0)]
        [FastEnumUtility.Label("Mob Damaged", 1)]
        MobDamaged = 294,
        [FastEnumUtility.Label("LP_MobSpecialEffectBySkill", 0)]
        [FastEnumUtility.Label("Mob Special Effect By Skill", 1)]
        MobSpecialEffectBySkill = 295,
        [FastEnumUtility.Label("LP_MobHPChange", 0)]
        [FastEnumUtility.Label("Mob HP Change", 1)]
        MobHPChange = 296,
        [FastEnumUtility.Label("LP_MobCrcKeyChanged", 0)]
        [FastEnumUtility.Label("Mob Crc Key Changed", 1)]
        MobCrcKeyChanged = 297,
        [FastEnumUtility.Label("LP_MobHPIndicator", 0)]
        [FastEnumUtility.Label("Mob HP Indicator", 1)]
        MobHPIndicator = 298,
        [FastEnumUtility.Label("LP_MobCatchEffect", 0)]
        [FastEnumUtility.Label("Mob Catch Effect", 1)]
        MobCatchEffect = 299,
        [FastEnumUtility.Label("LP_MobEffectByItem", 0)]
        [FastEnumUtility.Label("Mob Effect By Item", 1)]
        MobEffectByItem = 300,
        [FastEnumUtility.Label("LP_MobSpeaking", 0)]
        [FastEnumUtility.Label("Mob Speaking", 1)]
        MobSpeaking = 301,
        [FastEnumUtility.Label("LP_MobChargeCount", 0)]
        [FastEnumUtility.Label("Mob Charge Count", 1)]
        MobChargeCount = 302,
        [FastEnumUtility.Label("LP_MobSkillDelay", 0)]
        [FastEnumUtility.Label("Mob Skill Delay", 1)]
        MobSkillDelay = 303,
        [FastEnumUtility.Label("LP_MobRequestResultEscortInfo", 0)]
        [FastEnumUtility.Label("Mob Request Result Escort Info", 1)]
        MobRequestResultEscortInfo = 304,
        [FastEnumUtility.Label("LP_MobEscortStopEndPermmision", 0)]
        [FastEnumUtility.Label("Mob Escort Stop End Permmision", 1)]
        MobEscortStopEndPermmision = 305,
        [FastEnumUtility.Label("LP_MobEscortStopSay", 0)]
        [FastEnumUtility.Label("Mob Escort Stop Say", 1)]
        MobEscortStopSay = 306,
        [FastEnumUtility.Label("LP_MobEscortReturnBefore", 0)]
        [FastEnumUtility.Label("Mob Escort Return Before", 1)]
        MobEscortReturnBefore = 307,
        [FastEnumUtility.Label("LP_MobNextAttack", 0)]
        [FastEnumUtility.Label("Mob Next Attack", 1)]
        MobNextAttack = 308,
        [FastEnumUtility.Label("LP_MobAttackedByMob", 0)]
        [FastEnumUtility.Label("Mob Attacked By Mob", 1)]
        MobAttackedByMob = 309,
        [FastEnumUtility.Label("LP_NpcEnterField", 0)]
        [FastEnumUtility.Label("Npc Enter Field", 1)]
        NpcEnterField = 311,
        [FastEnumUtility.Label("LP_NpcLeaveField", 0)]
        [FastEnumUtility.Label("Npc Leave Field", 1)]
        NpcLeaveField = 312,
        [FastEnumUtility.Label("LP_NpcChangeController", 0)]
        [FastEnumUtility.Label("Npc Change Controller", 1)]
        NpcChangeController = 313,
        [FastEnumUtility.Label("LP_NpcMove", 0)]
        [FastEnumUtility.Label("Npc Move", 1)]
        NpcMove = 314,
        [FastEnumUtility.Label("LP_NpcUpdateLimitedInfo", 0)]
        [FastEnumUtility.Label("Npc Update Limited Info", 1)]
        NpcUpdateLimitedInfo = 315,
        [FastEnumUtility.Label("LP_NpcSpecialAction", 0)]
        [FastEnumUtility.Label("Npc Special Action", 1)]
        NpcSpecialAction = 316,
        [FastEnumUtility.Label("LP_NpcSetScript", 0)]
        [FastEnumUtility.Label("Npc Set Script", 1)]
        NpcSetScript = 317,
        [FastEnumUtility.Label("Employee Enter Field", 1)]
        [FastEnumUtility.Label("LP_EmployeeEnterField", 0)]
        EmployeeEnterField = 319,
        [FastEnumUtility.Label("Employee Leave Field", 1)]
        [FastEnumUtility.Label("LP_EmployeeLeaveField", 0)]
        EmployeeLeaveField = 320,
        [FastEnumUtility.Label("Employee Mini Room Balloon", 1)]
        [FastEnumUtility.Label("LP_EmployeeMiniRoomBalloon", 0)]
        EmployeeMiniRoomBalloon = 321,
        [FastEnumUtility.Label("Drop Enter Field", 1)]
        [FastEnumUtility.Label("LP_DropEnterField", 0)]
        DropEnterField = 322,
        [FastEnumUtility.Label("Drop Release All Freeze", 1)]
        [FastEnumUtility.Label("LP_DropReleaseAllFreeze", 0)]
        DropReleaseAllFreeze = 323,
        [FastEnumUtility.Label("Drop Leave Field", 1)]
        [FastEnumUtility.Label("LP_DropLeaveField", 0)]
        DropLeaveField = 324,
        [FastEnumUtility.Label("Create Messgae Box Failed", 1)]
        [FastEnumUtility.Label("LP_CreateMessgaeBoxFailed", 0)]
        CreateMessgaeBoxFailed = 325,
        [FastEnumUtility.Label("LP_MessageBoxEnterField", 0)]
        [FastEnumUtility.Label("Message Box Enter Field", 1)]
        MessageBoxEnterField = 326,
        [FastEnumUtility.Label("LP_MessageBoxLeaveField", 0)]
        [FastEnumUtility.Label("Message Box Leave Field", 1)]
        MessageBoxLeaveField = 327,
        [FastEnumUtility.Label("Affected Area Created", 1)]
        [FastEnumUtility.Label("LP_AffectedAreaCreated", 0)]
        AffectedAreaCreated = 328,
        [FastEnumUtility.Label("Affected Area Removed", 1)]
        [FastEnumUtility.Label("LP_AffectedAreaRemoved", 0)]
        AffectedAreaRemoved = 329,
        [FastEnumUtility.Label("LP_TownPortalCreated", 0)]
        [FastEnumUtility.Label("Town Portal Created", 1)]
        TownPortalCreated = 330,
        [FastEnumUtility.Label("LP_TownPortalRemoved", 0)]
        [FastEnumUtility.Label("Town Portal Removed", 1)]
        TownPortalRemoved = 331,
        [FastEnumUtility.Label("LP_OpenGateCreated", 0)]
        [FastEnumUtility.Label("Open Gate Created", 1)]
        OpenGateCreated = 332,
        [FastEnumUtility.Label("LP_OpenGateRemoved", 0)]
        [FastEnumUtility.Label("Open Gate Removed", 1)]
        OpenGateRemoved = 333,
        [FastEnumUtility.Label("LP_ReactorChangeState", 0)]
        [FastEnumUtility.Label("Reactor Change State", 1)]
        ReactorChangeState = 334,
        [FastEnumUtility.Label("LP_ReactorMove", 0)]
        [FastEnumUtility.Label("Reactor Move", 1)]
        ReactorMove = 335,
        [FastEnumUtility.Label("LP_ReactorEnterField", 0)]
        [FastEnumUtility.Label("Reactor Enter Field", 1)]
        ReactorEnterField = 336,
        [FastEnumUtility.Label("LP_ReactorLeaveField", 0)]
        [FastEnumUtility.Label("Reactor Leave Field", 1)]
        ReactorLeaveField = 337,
        [FastEnumUtility.Label("LP_SnowBallState", 0)]
        [FastEnumUtility.Label("Snow Ball State", 1)]
        SnowBallState = 338,
        [FastEnumUtility.Label("LP_SnowBallHit", 0)]
        [FastEnumUtility.Label("Snow Ball Hit", 1)]
        SnowBallHit = 339,
        [FastEnumUtility.Label("LP_SnowBallMsg", 0)]
        [FastEnumUtility.Label("Snow Ball Msg", 1)]
        SnowBallMsg = 340,
        [FastEnumUtility.Label("LP_SnowBallTouch", 0)]
        [FastEnumUtility.Label("Snow Ball Touch", 1)]
        SnowBallTouch = 341,
        [FastEnumUtility.Label("Coconut Hit", 1)]
        [FastEnumUtility.Label("LP_CoconutHit", 0)]
        CoconutHit = 342,
        [FastEnumUtility.Label("Coconut Score", 1)]
        [FastEnumUtility.Label("LP_CoconutScore", 0)]
        CoconutScore = 343,
        [FastEnumUtility.Label("Healer Move", 1)]
        [FastEnumUtility.Label("LP_HealerMove", 0)]
        HealerMove = 344,
        [FastEnumUtility.Label("LP_PulleyStateChange", 0)]
        [FastEnumUtility.Label("Pulley State Change", 1)]
        PulleyStateChange = 345,
        [FastEnumUtility.Label("LP_MCarnivalEnter", 0)]
        [FastEnumUtility.Label("MCarnival Enter", 1)]
        MCarnivalEnter = 346,
        [FastEnumUtility.Label("LP_MCarnivalPersonalCP", 0)]
        [FastEnumUtility.Label("MCarnival Personal CP", 1)]
        MCarnivalPersonalCP = 347,
        [FastEnumUtility.Label("LP_MCarnivalTeamCP", 0)]
        [FastEnumUtility.Label("MCarnival Team CP", 1)]
        MCarnivalTeamCP = 348,
        [FastEnumUtility.Label("LP_MCarnivalResultSuccess", 0)]
        [FastEnumUtility.Label("MCarnival Result Success", 1)]
        MCarnivalResultSuccess = 349,
        [FastEnumUtility.Label("LP_MCarnivalResultFail", 0)]
        [FastEnumUtility.Label("MCarnival Result Fail", 1)]
        MCarnivalResultFail = 350,
        [FastEnumUtility.Label("LP_MCarnivalDeath", 0)]
        [FastEnumUtility.Label("MCarnival Death", 1)]
        MCarnivalDeath = 351,
        [FastEnumUtility.Label("LP_MCarnivalMemberOut", 0)]
        [FastEnumUtility.Label("MCarnival Member Out", 1)]
        MCarnivalMemberOut = 352,
        [FastEnumUtility.Label("LP_MCarnivalGameResult", 0)]
        [FastEnumUtility.Label("MCarnival Game Result", 1)]
        MCarnivalGameResult = 353,
        [FastEnumUtility.Label("Arena Score", 1)]
        [FastEnumUtility.Label("LP_ArenaScore", 0)]
        ArenaScore = 354,
        [FastEnumUtility.Label("Battlefield Enter", 1)]
        [FastEnumUtility.Label("LP_BattlefieldEnter", 0)]
        BattlefieldEnter = 355,
        [FastEnumUtility.Label("Battlefield Score", 1)]
        [FastEnumUtility.Label("LP_BattlefieldScore", 0)]
        BattlefieldScore = 356,
        [FastEnumUtility.Label("Battlefield Team Changed", 1)]
        [FastEnumUtility.Label("LP_BattlefieldTeamChanged", 0)]
        BattlefieldTeamChanged = 357,
        [FastEnumUtility.Label("LP_WitchtowerScore", 0)]
        [FastEnumUtility.Label("Witchtower Score", 1)]
        WitchtowerScore = 358,
        [FastEnumUtility.Label("Hontale Timer", 1)]
        [FastEnumUtility.Label("LP_HontaleTimer", 0)]
        HontaleTimer = 359,
        [FastEnumUtility.Label("Chaos Zakum Timer", 1)]
        [FastEnumUtility.Label("LP_ChaosZakumTimer", 0)]
        ChaosZakumTimer = 360,
        [FastEnumUtility.Label("Hontail Timer", 1)]
        [FastEnumUtility.Label("LP_HontailTimer", 0)]
        HontailTimer = 361,
        [FastEnumUtility.Label("LP_ZakumTimer", 0)]
        [FastEnumUtility.Label("Zakum Timer", 1)]
        ZakumTimer = 362,
        [FastEnumUtility.Label("LP_ScriptMessage", 0)]
        [FastEnumUtility.Label("Script Message", 1)]
        ScriptMessage = 363,
        [FastEnumUtility.Label("LP_OpenShopDlg", 0)]
        [FastEnumUtility.Label("Open Shop Dlg", 1)]
        OpenShopDlg = 364,
        [FastEnumUtility.Label("LP_ShopResult", 0)]
        [FastEnumUtility.Label("Shop Result", 1)]
        ShopResult = 365,
        [FastEnumUtility.Label("Admin Shop Result", 1)]
        [FastEnumUtility.Label("LP_AdminShopResult", 0)]
        AdminShopResult = 366,
        [FastEnumUtility.Label("Admin Shop Commodity", 1)]
        [FastEnumUtility.Label("LP_AdminShopCommodity", 0)]
        AdminShopCommodity = 367,
        [FastEnumUtility.Label("LP_TrunkResult", 0)]
        [FastEnumUtility.Label("Trunk Result", 1)]
        TrunkResult = 368,
        [FastEnumUtility.Label("LP_StoreBankGetAllResult", 0)]
        [FastEnumUtility.Label("Store Bank Get All Result", 1)]
        StoreBankGetAllResult = 369,
        [FastEnumUtility.Label("LP_StoreBankResult", 0)]
        [FastEnumUtility.Label("Store Bank Result", 1)]
        StoreBankResult = 370,
        [FastEnumUtility.Label("LP_RPSGame", 0)]
        [FastEnumUtility.Label("RPS Game", 1)]
        RPSGame = 371,
        [FastEnumUtility.Label("LP_Messenger", 0)]
        Messenger = 372,
        [FastEnumUtility.Label("LP_MiniRoom", 0)]
        [FastEnumUtility.Label("Mini Room", 1)]
        MiniRoom = 373,
        [FastEnumUtility.Label("LP_Tournament", 0)]
        Tournament = 374,
        [FastEnumUtility.Label("LP_TournamentMatchTable", 0)]
        [FastEnumUtility.Label("Tournament Match Table", 1)]
        TournamentMatchTable = 375,
        [FastEnumUtility.Label("LP_TournamentSetPrize", 0)]
        [FastEnumUtility.Label("Tournament Set Prize", 1)]
        TournamentSetPrize = 376,
        [FastEnumUtility.Label("LP_TournamentNoticeUEW", 0)]
        [FastEnumUtility.Label("Tournament Notice UEW", 1)]
        TournamentNoticeUEW = 377,
        [FastEnumUtility.Label("LP_TournamentAvatarInfo", 0)]
        [FastEnumUtility.Label("Tournament Avatar Info", 1)]
        TournamentAvatarInfo = 378,
        [FastEnumUtility.Label("LP_WeddingProgress", 0)]
        [FastEnumUtility.Label("Wedding Progress", 1)]
        WeddingProgress = 379,
        [FastEnumUtility.Label("LP_WeddingCremonyEnd", 0)]
        [FastEnumUtility.Label("Wedding Cremony End", 1)]
        WeddingCremonyEnd = 380,
        [FastEnumUtility.Label("LP_Parcel", 0)]
        Parcel = 381,
        [FastEnumUtility.Label("Cash Shop Charge Param Result", 1)]
        [FastEnumUtility.Label("LP_CashShopChargeParamResult", 0)]
        CashShopChargeParamResult = 382,
        [FastEnumUtility.Label("Cash Shop Query Cash Result", 1)]
        [FastEnumUtility.Label("LP_CashShopQueryCashResult", 0)]
        CashShopQueryCashResult = 383,
        [FastEnumUtility.Label("Cash Shop Cash Item Result", 1)]
        [FastEnumUtility.Label("LP_CashShopCashItemResult", 0)]
        CashShopCashItemResult = 384,
        [FastEnumUtility.Label("Cash Shop Purchase Exp Changed", 1)]
        [FastEnumUtility.Label("LP_CashShopPurchaseExpChanged", 0)]
        CashShopPurchaseExpChanged = 385,
        [FastEnumUtility.Label("Cash Shop Gift Mate Info Result", 1)]
        [FastEnumUtility.Label("LP_CashShopGiftMateInfoResult", 0)]
        CashShopGiftMateInfoResult = 386,
        [FastEnumUtility.Label("Cash Shop Check Duplicated ID Result", 1)]
        [FastEnumUtility.Label("LP_CashShopCheckDuplicatedIDResult", 0)]
        CashShopCheckDuplicatedIDResult = 387,
        [FastEnumUtility.Label("Cash Shop Check Name Change Possible Result", 1)]
        [FastEnumUtility.Label("LP_CashShopCheckNameChangePossibleResult", 0)]
        CashShopCheckNameChangePossibleResult = 388,
        [FastEnumUtility.Label("Cash Shop Register New Character Result", 1)]
        [FastEnumUtility.Label("LP_CashShopRegisterNewCharacterResult", 0)]
        CashShopRegisterNewCharacterResult = 389,
        [FastEnumUtility.Label("Cash Shop Check Transfer World Possible Result", 1)]
        [FastEnumUtility.Label("LP_CashShopCheckTransferWorldPossibleResult", 0)]
        CashShopCheckTransferWorldPossibleResult = 390,
        [FastEnumUtility.Label("Cash Shop Gachapon Stamp Item Result", 1)]
        [FastEnumUtility.Label("LP_CashShopGachaponStampItemResult", 0)]
        CashShopGachaponStampItemResult = 391,
        [FastEnumUtility.Label("Cash Shop Cash Item Gachapon Result", 1)]
        [FastEnumUtility.Label("LP_CashShopCashItemGachaponResult", 0)]
        CashShopCashItemGachaponResult = 392,
        [FastEnumUtility.Label("Cash Shop Cash Gachapon Open Result", 1)]
        [FastEnumUtility.Label("LP_CashShopCashGachaponOpenResult", 0)]
        CashShopCashGachaponOpenResult = 393,
        [FastEnumUtility.Label("Change Maple Point Result", 1)]
        [FastEnumUtility.Label("LP_ChangeMaplePointResult", 0)]
        ChangeMaplePointResult = 394,
        [FastEnumUtility.Label("Cash Shop One ADay", 1)]
        [FastEnumUtility.Label("LP_CashShopOneADay", 0)]
        CashShopOneADay = 395,
        [FastEnumUtility.Label("Cash Shop Notice Free Cash Item", 1)]
        [FastEnumUtility.Label("LP_CashShopNoticeFreeCashItem", 0)]
        CashShopNoticeFreeCashItem = 396,
        [FastEnumUtility.Label("Cash Shop Member Shop Result", 1)]
        [FastEnumUtility.Label("LP_CashShopMemberShopResult", 0)]
        CashShopMemberShopResult = 397,
        [FastEnumUtility.Label("Func Key Mapped Init", 1)]
        [FastEnumUtility.Label("LP_FuncKeyMappedInit", 0)]
        FuncKeyMappedInit = 398,
        [FastEnumUtility.Label("LP_PetConsumeItemInit", 0)]
        [FastEnumUtility.Label("Pet Consume Item Init", 1)]
        PetConsumeItemInit = 399,
        [FastEnumUtility.Label("LP_PetConsumeMPItemInit", 0)]
        [FastEnumUtility.Label("Pet Consume MP Item Init", 1)]
        PetConsumeMPItemInit = 400,
        [FastEnumUtility.Label("Check SSN2On Create New Character Result", 1)]
        [FastEnumUtility.Label("LP_CheckSSN2OnCreateNewCharacterResult", 0)]
        CheckSSN2OnCreateNewCharacterResult = 401,
        [FastEnumUtility.Label("Check SPW On Create New Character Result", 1)]
        [FastEnumUtility.Label("LP_CheckSPWOnCreateNewCharacterResult", 0)]
        CheckSPWOnCreateNewCharacterResult = 402,
        [FastEnumUtility.Label("First SSN On Create New Character Result", 1)]
        [FastEnumUtility.Label("LP_FirstSSNOnCreateNewCharacterResult", 0)]
        FirstSSNOnCreateNewCharacterResult = 403,
        [FastEnumUtility.Label("LP_MapleTVUpdateMessage", 0)]
        [FastEnumUtility.Label("Maple TV Update Message", 1)]
        MapleTVUpdateMessage = 405,
        [FastEnumUtility.Label("LP_MapleTVClearMessage", 0)]
        [FastEnumUtility.Label("Maple TV Clear Message", 1)]
        MapleTVClearMessage = 406,
        [FastEnumUtility.Label("LP_MapleTVSendMessageResult", 0)]
        [FastEnumUtility.Label("Maple TV Send Message Result", 1)]
        MapleTVSendMessageResult = 407,
        [FastEnumUtility.Label("Broad Set Flash Change Event", 1)]
        [FastEnumUtility.Label("LP_BroadSetFlashChangeEvent", 0)]
        BroadSetFlashChangeEvent = 408,
        [FastEnumUtility.Label("ITC Charge Param Result", 1)]
        [FastEnumUtility.Label("LP_ITCChargeParamResult", 0)]
        ITCChargeParamResult = 410,
        [FastEnumUtility.Label("ITC Query Cash Result", 1)]
        [FastEnumUtility.Label("LP_ITCQueryCashResult", 0)]
        ITCQueryCashResult = 411,
        [FastEnumUtility.Label("ITC Normal Item Result", 1)]
        [FastEnumUtility.Label("LP_ITCNormalItemResult", 0)]
        ITCNormalItemResult = 412,
        [FastEnumUtility.Label("Check Duplicated ID Result In CS", 1)]
        [FastEnumUtility.Label("LP_CheckDuplicatedIDResultInCS", 0)]
        CheckDuplicatedIDResultInCS = 413,
        [FastEnumUtility.Label("Create New Character Result In CS", 1)]
        [FastEnumUtility.Label("LP_CreateNewCharacterResultInCS", 0)]
        CreateNewCharacterResultInCS = 414,
        [FastEnumUtility.Label("Create New Character Fail In CS", 1)]
        [FastEnumUtility.Label("LP_CreateNewCharacterFailInCS", 0)]
        CreateNewCharacterFailInCS = 415,
        [FastEnumUtility.Label("Character Sale", 1)]
        [FastEnumUtility.Label("LP_CharacterSale", 0)]
        CharacterSale = 416,
        [FastEnumUtility.Label("LP_GoldHammere_s", 0)]
        GoldHammer_s = 417,
        [FastEnumUtility.Label("Gold Hammer Result", 1)]
        [FastEnumUtility.Label("LP_GoldHammerResult", 0)]
        GoldHammerResult = 418,
        [FastEnumUtility.Label("LP_GoldHammere_e", 0)]
        GoldHammer_e = 419,
        [FastEnumUtility.Label("LP_BattleRecord_s", 0)]
        BattleRecord_s = 420,
        [FastEnumUtility.Label("Battle Record Dot Damage Info", 1)]
        [FastEnumUtility.Label("LP_BattleRecordDotDamageInfo", 0)]
        BattleRecordDotDamageInfo = 421,
        [FastEnumUtility.Label("Battle Record Request Result", 1)]
        [FastEnumUtility.Label("LP_BattleRecordRequestResult", 0)]
        BattleRecordRequestResult = 422,
        [FastEnumUtility.Label("LP_BattleRecord_e", 0)]
        BattleRecord_e = 423,
        [FastEnumUtility.Label("LP_ItemUpgrade_s", 0)]
        ItemUpgrade_s = 424,
        [FastEnumUtility.Label("Item Upgrade Result", 1)]
        [FastEnumUtility.Label("LP_ItemUpgradeResult", 0)]
        ItemUpgradeResult = 425,
        [FastEnumUtility.Label("Item Upgrade Fail", 1)]
        [FastEnumUtility.Label("LP_ItemUpgradeFail", 0)]
        ItemUpgradeFail = 426,
        [FastEnumUtility.Label("LP_ItemUpgrade_e", 0)]
        ItemUpgrade_e = 427,
        [FastEnumUtility.Label("LP_Vega_s", 0)]
        Vega_s = 428,
        [FastEnumUtility.Label("LP_VegaResult", 0)]
        [FastEnumUtility.Label("Vega Result", 1)]
        VegaResult = 429,
        [FastEnumUtility.Label("LP_VegaFail", 0)]
        [FastEnumUtility.Label("Vega Fail", 1)]
        VegaFail = 430,
        [FastEnumUtility.Label("LP_Vega_e", 0)]
        Vega_e = 431,
        [FastEnumUtility.Label("LP_LogoutGift", 0)]
        [FastEnumUtility.Label("Logout Gift", 1)]
        LogoutGift = 432,
        [FastEnumUtility.Label("LP_NO", 0)]
        NO = 433,
    }
    public enum ShopCashType : byte
    {
        [FastEnumUtility.Label("CS_CASHTYPE_NX", 0)]
        NexonCash = 1,
        [FastEnumUtility.Label("CS_CASHTYPE_MP", 0)]
        MaplePoint = 2,
        [FastEnumUtility.Label("CS_CASHTYPE_PREPAID", 0)]
        PrepaidNxCash = 4,
    }
    public enum ShopScannerOperation : byte
    {
        [FastEnumUtility.Label("Req Add List", 1)]
        [FastEnumUtility.Label("ShopScannerReq_AddList", 0)]
        ReqAddList = 0,
        [FastEnumUtility.Label("Req Remove List", 1)]
        [FastEnumUtility.Label("ShopScannerReq_RemoveList", 0)]
        ReqRemoveList = 1,
        [FastEnumUtility.Label("Req Remove All", 1)]
        [FastEnumUtility.Label("ShopScannerReq_RemoveAll", 0)]
        ReqRemoveAll = 2,
        [FastEnumUtility.Label("Req Rename", 1)]
        [FastEnumUtility.Label("ShopScannerReq_Rename", 0)]
        ReqRename = 3,
        [FastEnumUtility.Label("Req Search", 1)]
        [FastEnumUtility.Label("ShopScannerReq_Search", 0)]
        ReqSearch = 4,
        [FastEnumUtility.Label("Req Load Hot List", 1)]
        [FastEnumUtility.Label("ShopScannerReq_LoadHotList", 0)]
        ReqLoadHotList = 5,
        [FastEnumUtility.Label("Res Search Result", 1)]
        [FastEnumUtility.Label("ShopScannerRes_SearchResult", 0)]
        ResSearchResult = 6,
        [FastEnumUtility.Label("Res Load Hot List Result", 1)]
        [FastEnumUtility.Label("ShopScannerRes_LoadHotListResult", 0)]
        ResLoadHotListResult = 7,
    }
    [System.Flags]
    public enum SkillCombatTargetFlag : byte
    {
        None = 0,
        [FastEnumUtility.Label("SCT_Self", 0)]
        Self = 1,
        [FastEnumUtility.Label("SCT_Party", 0)]
        Party = 2,
        [FastEnumUtility.Label("SCT_Mob", 0)]
        Mob = 4,
    }
    public enum SkillId
    {
        [FastEnumUtility.Label("NOVICE_THROW_SNAIL", 0)]
        [FastEnumUtility.Label("Novice Throw Snail", 1)]
        NoviceThrowSnail = 1000,
        [FastEnumUtility.Label("NOVICE_REGENERATION", 0)]
        [FastEnumUtility.Label("Novice Regeneration", 1)]
        NoviceRegeneration = 1001,
        [FastEnumUtility.Label("NOVICE_MOVING_WITH_ACTIVITY", 0)]
        [FastEnumUtility.Label("Novice Moving With Activity", 1)]
        NoviceMovingWithActivity = 1002,
        [FastEnumUtility.Label("NOVICE_SOUL_OF_CRAFTMAN", 0)]
        [FastEnumUtility.Label("Novice Soul Of Craftsman", 1)]
        NoviceSoulOfCraftsman = 1003,
        [FastEnumUtility.Label("NOVICE_MONSTER_RIDING", 0)]
        [FastEnumUtility.Label("Novice Monster Riding", 1)]
        NoviceMonsterRiding = 1004,
        [FastEnumUtility.Label("NOVICE_MAXLEVEL_ECHOBUFF", 0)]
        [FastEnumUtility.Label("Novice Max-Level Echo Buff", 1)]
        NoviceMaxlevelEchobuff = 1005,
        [FastEnumUtility.Label("NOVICE_DAMAGEMETER", 0)]
        [FastEnumUtility.Label("Novice Damage Meter", 1)]
        NoviceDamagemeter = 1006,
        [FastEnumUtility.Label("NOVICE_MULTI_PET", 0)]
        [FastEnumUtility.Label("Novice Multi Pet", 1)]
        NoviceMultiPet = 8,
        [FastEnumUtility.Label("NOVICE_MAKER", 0)]
        [FastEnumUtility.Label("Novice Maker", 1)]
        NoviceMaker = 1007,
        [FastEnumUtility.Label("NOVICE_BAMBOO", 0)]
        [FastEnumUtility.Label("Novice Bamboo", 1)]
        NoviceBamboo = 1009,
        [FastEnumUtility.Label("NOVICE_INVINCIBLE", 0)]
        [FastEnumUtility.Label("Novice Invincible", 1)]
        NoviceInvincible = 1010,
        [FastEnumUtility.Label("NOVICE_BERSERK", 0)]
        [FastEnumUtility.Label("Novice Berserk", 1)]
        NoviceBerserk = 1011,
        [FastEnumUtility.Label("NOVICE_BLESS_OF_NYMPH", 0)]
        [FastEnumUtility.Label("Novice Bless Of Nymph", 1)]
        NoviceBlessOfNymph = 12,
        [FastEnumUtility.Label("DISABLE_NOVICE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Novice Event Riding", 1)]
        DisableNoviceEventRiding = 1013,
        [FastEnumUtility.Label("DISABLE_NOVICE_EVENT_RIDING_DASH", 0)]
        [FastEnumUtility.Label("Disable Novice Event Riding Dash", 1)]
        DisableNoviceEventRidingDash = 1014,
        [FastEnumUtility.Label("DISABLE_NOVICE_EVENT_RIDING_REACTOR", 0)]
        [FastEnumUtility.Label("Disable Novice Event Riding Reactor", 1)]
        DisableNoviceEventRidingReactor = 1015,
        [FastEnumUtility.Label("DISABLE_NOVICE_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Novice Yeti Event Riding", 1)]
        DisableNoviceYetiEventRiding = 1017,
        [FastEnumUtility.Label("DISABLE_NOVICE_YETI_EVENT_RIDING2", 0)]
        [FastEnumUtility.Label("Disable Novice Yeti Event Riding2", 1)]
        DisableNoviceYetiEventRiding2 = 1018,
        [FastEnumUtility.Label("DISABLE_NOVICE_BROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Novice Broom Event Riding", 1)]
        DisableNoviceBroomEventRiding = 1019,
        [FastEnumUtility.Label("NOVICE_MASSACRE", 0)]
        [FastEnumUtility.Label("Novice Massacre", 1)]
        NoviceMassacre = 1020,
        [FastEnumUtility.Label("NOVICE_WOODENHORSE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Wooden Horse Event Riding", 1)]
        NoviceWoodenhorseEventRiding = 1025,
        [FastEnumUtility.Label("NOVICE_FLYING_SKILL", 0)]
        [FastEnumUtility.Label("Novice Flying Skill", 1)]
        NoviceFlyingSkill = 1026,
        [FastEnumUtility.Label("NOVICE_KROKO_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Kroko Event Riding", 1)]
        NoviceKrokoEventRiding = 1027,
        [FastEnumUtility.Label("NOVICE_NAKED_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Naked Event Riding", 1)]
        NoviceNakedEventRiding = 1028,
        [FastEnumUtility.Label("NOVICE_PINK_SCOOTER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Pink Scooter Event Riding", 1)]
        NovicePinkScooterEventRiding = 1029,
        [FastEnumUtility.Label("NOVICE_FLYING_CLOUD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Flying Cloud Event Riding", 1)]
        NoviceFlyingCloudEventRiding = 1030,
        [FastEnumUtility.Label("NOVICE_BALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Balrog Event Riding", 1)]
        NoviceBalrogEventRiding = 1031,
        [FastEnumUtility.Label("NOVICE_KART_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Kart Event Riding", 1)]
        NoviceKartEventRiding = 1033,
        [FastEnumUtility.Label("NOVICE_ZD_TIGER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Zd Tiger Event Riding", 1)]
        NoviceZdTigerEventRiding = 1034,
        [FastEnumUtility.Label("NOVICE_MISTBALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Mistbalrog Event Riding", 1)]
        NoviceMistbalrogEventRiding = 1035,
        [FastEnumUtility.Label("NOVICE_LIONS_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Lions Event Riding", 1)]
        NoviceLionsEventRiding = 1036,
        [FastEnumUtility.Label("NOVICE_UNICORN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Unicorn Event Riding", 1)]
        NoviceUnicornEventRiding = 1037,
        [FastEnumUtility.Label("NOVICE_LOWRIDER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Lowrider Event Riding", 1)]
        NoviceLowriderEventRiding = 1038,
        [FastEnumUtility.Label("NOVICE_REDTRUCK_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Redtruck Event Riding", 1)]
        NoviceRedtruckEventRiding = 1039,
        [FastEnumUtility.Label("NOVICE_GARGOYLES_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Gargoyles Event Riding", 1)]
        NoviceGargoylesEventRiding = 1040,
        [FastEnumUtility.Label("NOVICE_SPACE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Space Event Riding", 1)]
        NoviceSpaceEventRiding = 1046,
        [FastEnumUtility.Label("NOVICE_SPACE_EVENT_RIDING_DASH", 0)]
        [FastEnumUtility.Label("Novice Space Event Riding Dash", 1)]
        NoviceSpaceEventRidingDash = 1047,
        [FastEnumUtility.Label("NOVICE_SPACE_EVENT_RIDING_REACTOR", 0)]
        [FastEnumUtility.Label("Novice Space Event Riding Reactor", 1)]
        NoviceSpaceEventRidingReactor = 1048,
        [FastEnumUtility.Label("NOVICE_CHICKEN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Chicken Event Riding", 1)]
        NoviceChickenEventRiding = 1054,
        [FastEnumUtility.Label("NOVICE_HOLLY_BIRD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Holly Bird Event Riding", 1)]
        NoviceHollyBirdEventRiding = 1042,
        [FastEnumUtility.Label("NOVICE_ORANGE_MUSHROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Orange Mushroom Event Riding", 1)]
        NoviceOrangeMushroomEventRiding = 1044,
        [FastEnumUtility.Label("NOVICE_NIGHTMARE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Nightmare Event Riding", 1)]
        NoviceNightmareEventRiding = 1049,
        [FastEnumUtility.Label("NOVICE_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Yeti Event Riding", 1)]
        NoviceYetiEventRiding = 1050,
        [FastEnumUtility.Label("NOVICE_OSTRICH_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Ostrich Event Riding", 1)]
        NoviceOstrichEventRiding = 1051,
        [FastEnumUtility.Label("NOVICE_BEAR_BALOON_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Bear Baloon Event Riding", 1)]
        NoviceBearBaloonEventRiding = 1052,
        [FastEnumUtility.Label("NOVICE_TRANS_ROBOT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Trans Robot Event Riding", 1)]
        NoviceTransRobotEventRiding = 1053,
        [FastEnumUtility.Label("NOVICE_MOTORBIKE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Motorbike Event Riding", 1)]
        NoviceMotorbikeEventRiding = 1063,
        [FastEnumUtility.Label("NOVICE_POWERED_SUIT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Powered Suit Event Riding", 1)]
        NovicePoweredSuitEventRiding = 1064,
        [FastEnumUtility.Label("NOVICE_VISITOR_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Novice Visitor Event Riding", 1)]
        NoviceVisitorEventRiding = 1065,
        [FastEnumUtility.Label("NOBLELESS_VISITOR_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Nobleless Visitor Event Riding", 1)]
        NoblelessVisitorEventRiding = 10001065,
        [FastEnumUtility.Label("ARAN_VISITOR_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Aran Visitor Event Riding", 1)]
        AranVisitorEventRiding = 20001065,
        [FastEnumUtility.Label("EVAN_VISITOR_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evan Visitor Event Riding", 1)]
        EvanVisitorEventRiding = 20011065,
        [FastEnumUtility.Label("CITIZEN_VISITOR_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Visitor Event Riding", 1)]
        CitizenVisitorEventRiding = 30001065,
        [FastEnumUtility.Label("NOVICE_VISITOR_OWL_RIDING", 0)]
        [FastEnumUtility.Label("Novice Visitor Owl Riding", 1)]
        NoviceVisitorOwlRiding = 1069,
        [FastEnumUtility.Label("NOBLELESS_VISITOR_OWL_RIDING", 0)]
        [FastEnumUtility.Label("Nobleless Visitor Owl Riding", 1)]
        NoblelessVisitorOwlRiding = 10001069,
        [FastEnumUtility.Label("ARAN_VISITOR_OWL_RIDING", 0)]
        [FastEnumUtility.Label("Aran Visitor Owl Riding", 1)]
        AranVisitorOwlRiding = 20001069,
        [FastEnumUtility.Label("EVAN_VISITOR_OWL_RIDING", 0)]
        [FastEnumUtility.Label("Evan Visitor Owl Riding", 1)]
        EvanVisitorOwlRiding = 20011069,
        [FastEnumUtility.Label("CITIZEN_VISITOR_OWL_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Visitor Owl Riding", 1)]
        CitizenVisitorOwlRiding = 30001069,
        [FastEnumUtility.Label("NOVICE_VISITOR_MOTHERSHIP_RIDING", 0)]
        [FastEnumUtility.Label("Novice Visitor Mothership Riding", 1)]
        NoviceVisitorMothershipRiding = 1070,
        [FastEnumUtility.Label("NOBLELESS_VISITOR_MOTHERSHIP_RIDING", 0)]
        [FastEnumUtility.Label("Nobleless Visitor Mothership Riding", 1)]
        NoblelessVisitorMothershipRiding = 10001070,
        [FastEnumUtility.Label("ARAN_VISITOR_MOTHERSHIP_RIDING", 0)]
        [FastEnumUtility.Label("Aran Visitor Mothership Riding", 1)]
        AranVisitorMothershipRiding = 20001070,
        [FastEnumUtility.Label("EVAN_VISITOR_MOTHERSHIP_RIDING", 0)]
        [FastEnumUtility.Label("Evan Visitor Mothership Riding", 1)]
        EvanVisitorMothershipRiding = 20011070,
        [FastEnumUtility.Label("CITIZEN_VISITOR_MOTHERSHIP_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Visitor Mothership Riding", 1)]
        CitizenVisitorMothershipRiding = 30001070,
        [FastEnumUtility.Label("NOVICE_VISITOR_OS3A_RIDING", 0)]
        [FastEnumUtility.Label("Novice Visitor Os3a Riding", 1)]
        NoviceVisitorOs3aRiding = 1071,
        [FastEnumUtility.Label("NOBLELESS_VISITOR_OS3A_RIDING", 0)]
        [FastEnumUtility.Label("Nobleless Visitor Os3a Riding", 1)]
        NoblelessVisitorOs3aRiding = 10001071,
        [FastEnumUtility.Label("ARAN_VISITOR_OS3A_RIDING", 0)]
        [FastEnumUtility.Label("Aran Visitor Os3a Riding", 1)]
        AranVisitorOs3aRiding = 20001071,
        [FastEnumUtility.Label("EVAN_VISITOR_OS3A_RIDING", 0)]
        [FastEnumUtility.Label("Evan Visitor Os3a Riding", 1)]
        EvanVisitorOs3aRiding = 20011071,
        [FastEnumUtility.Label("CITIZEN_VISITOR_OS3A_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Visitor Os3a Riding", 1)]
        CitizenVisitorOs3aRiding = 30001071,
        [FastEnumUtility.Label("NOVICE_VISITOR_MORPH_SKILL_NORMAL", 0)]
        [FastEnumUtility.Label("Novice Visitor Morph Skill Normal", 1)]
        NoviceVisitorMorphSkillNormal = 1066,
        [FastEnumUtility.Label("NOVICE_VISITOR_MORPH_SKILL_SKILL", 0)]
        [FastEnumUtility.Label("Novice Visitor Morph Skill Skill", 1)]
        NoviceVisitorMorphSkillSkill = 1067,
        [FastEnumUtility.Label("NOBLELESS_VISITOR_MORPH_SKILL_NORMAL", 0)]
        [FastEnumUtility.Label("Nobleless Visitor Morph Skill Normal", 1)]
        NoblelessVisitorMorphSkillNormal = 10001066,
        [FastEnumUtility.Label("NOBLELESS_VISITOR_MORPH_SKILL_SKILL", 0)]
        [FastEnumUtility.Label("Nobleless Visitor Morph Skill Skill", 1)]
        NoblelessVisitorMorphSkillSkill = 10001067,
        [FastEnumUtility.Label("ARAN_VISITOR_MORPH_SKILL_NORMAL", 0)]
        [FastEnumUtility.Label("Aran Visitor Morph Skill Normal", 1)]
        AranVisitorMorphSkillNormal = 20001066,
        [FastEnumUtility.Label("ARAN_VISITOR_MORPH_SKILL_SKILL", 0)]
        [FastEnumUtility.Label("Aran Visitor Morph Skill Skill", 1)]
        AranVisitorMorphSkillSkill = 20001067,
        [FastEnumUtility.Label("EVAN_VISITOR_MORPH_SKILL_NORMAL", 0)]
        [FastEnumUtility.Label("Evan Visitor Morph Skill Normal", 1)]
        EvanVisitorMorphSkillNormal = 20011066,
        [FastEnumUtility.Label("EVAN_VISITOR_MORPH_SKILL_SKILL", 0)]
        [FastEnumUtility.Label("Evan Visitor Morph Skill Skill", 1)]
        EvanVisitorMorphSkillSkill = 20011067,
        [FastEnumUtility.Label("CITIZEN_VISITOR_MORPH_SKILL_NORMAL", 0)]
        [FastEnumUtility.Label("Citizen Visitor Morph Skill Normal", 1)]
        CitizenVisitorMorphSkillNormal = 30001066,
        [FastEnumUtility.Label("CITIZEN_VISITOR_MORPH_SKILL_SKILL", 0)]
        [FastEnumUtility.Label("Citizen Visitor Morph Skill Skill", 1)]
        CitizenVisitorMorphSkillSkill = 30001067,
        [FastEnumUtility.Label("NOVICE_HASTE", 0)]
        [FastEnumUtility.Label("Novice Haste", 1)]
        NoviceHaste = 8000,
        [FastEnumUtility.Label("NOVICE_MYSTIC_DOOR", 0)]
        [FastEnumUtility.Label("Novice Mystic Door", 1)]
        NoviceMysticDoor = 8001,
        [FastEnumUtility.Label("NOVICE_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Novice Sharp Eyes", 1)]
        NoviceSharpEyes = 8002,
        [FastEnumUtility.Label("NOVICE_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Novice Hyper Body", 1)]
        NoviceHyperBody = 8003,
        [FastEnumUtility.Label("NOVICE_MONSTER_HANDICAP_BEGIN", 0)]
        [FastEnumUtility.Label("Novice Monster Handicap Begin", 1)]
        NoviceMonsterHandicapBegin = 9000,
        [FastEnumUtility.Label("NOVICE_MONSTER_HANDICAP_END", 0)]
        [FastEnumUtility.Label("Novice Monster Handicap End", 1)]
        NoviceMonsterHandicapEnd = 9002,
        [FastEnumUtility.Label("WARRIOR_IRON_BODY", 0)]
        [FastEnumUtility.Label("Warrior Iron Body", 1)]
        WarriorIronBody = 1001003,
        [FastEnumUtility.Label("WARRIOR_POWER_STRIKE", 0)]
        [FastEnumUtility.Label("Warrior Power Strike", 1)]
        WarriorPowerStrike = 1001004,
        [FastEnumUtility.Label("WARRIOR_SLASH_BLAST", 0)]
        [FastEnumUtility.Label("Warrior Slash Blast", 1)]
        WarriorSlashBlast = 1001005,
        [FastEnumUtility.Label("WARRIOR_MHP_INC", 0)]
        [FastEnumUtility.Label("Warrior Max HP Inc", 1)]
        WarriorMhpInc = 1000006,
        [FastEnumUtility.Label("FIGHTER_WEAPON_MASTERY", 0)]
        [FastEnumUtility.Label("Fighter Weapon Mastery", 1)]
        FighterWeaponMastery = 1100000,
        [FastEnumUtility.Label("FIGHTER_FINAL_ATTACK", 0)]
        [FastEnumUtility.Label("Fighter Final Attack", 1)]
        FighterFinalAttack = 1100002,
        [FastEnumUtility.Label("FIGHTER_WEAPON_BOOSTER", 0)]
        [FastEnumUtility.Label("Fighter Weapon Booster", 1)]
        FighterWeaponBooster = 1101004,
        [FastEnumUtility.Label("FIGHTER_FURY", 0)]
        [FastEnumUtility.Label("Fighter Fury", 1)]
        FighterFury = 1101006,
        [FastEnumUtility.Label("FIGHTER_POWER_GUARD", 0)]
        [FastEnumUtility.Label("Fighter Power Guard", 1)]
        FighterPowerGuard = 1101007,
        [FastEnumUtility.Label("FIGHTER_GROUND_SMASH", 0)]
        [FastEnumUtility.Label("Fighter Ground Smash", 1)]
        FighterGroundSmash = 1101008,
        [FastEnumUtility.Label("FIGHTER_IMPROVE_BASIC", 0)]
        [FastEnumUtility.Label("Fighter Improve Basic", 1)]
        FighterImproveBasic = 1100009,
        [FastEnumUtility.Label("CRUSADER_UPGRADE_MP_RECOVERY", 0)]
        [FastEnumUtility.Label("Crusader Upgrade Mp Recovery", 1)]
        CrusaderUpgradeMpRecovery = 1110000,
        [FastEnumUtility.Label("CRUSADER_COMBO_ATTACK", 0)]
        [FastEnumUtility.Label("Crusader Combo Attack", 1)]
        CrusaderComboAttack = 1111002,
        [FastEnumUtility.Label("CRUSADER_PANIC", 0)]
        [FastEnumUtility.Label("Crusader Panic", 1)]
        CrusaderPanic = 1111003,
        [FastEnumUtility.Label("CRUSADER_COMA", 0)]
        [FastEnumUtility.Label("Crusader Coma", 1)]
        CrusaderComa = 1111005,
        [FastEnumUtility.Label("CRUSADER_MAGIC_CRASH", 0)]
        [FastEnumUtility.Label("Crusader Magic Crash", 1)]
        CrusaderMagicCrash = 1111007,
        [FastEnumUtility.Label("CRUSADER_SHOUT", 0)]
        [FastEnumUtility.Label("Crusader Shout", 1)]
        CrusaderShout = 1111008,
        [FastEnumUtility.Label("CRUSADER_CHANCE_ATTACK", 0)]
        [FastEnumUtility.Label("Crusader Chance Attack", 1)]
        CrusaderChanceAttack = 1110009,
        [FastEnumUtility.Label("CRUSADER_BRANDISH", 0)]
        [FastEnumUtility.Label("Crusader Brandish", 1)]
        CrusaderBrandish = 1111010,
        [FastEnumUtility.Label("HERO_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Hero Maple Hero", 1)]
        HeroMapleHero = 1121000,
        [FastEnumUtility.Label("HERO_MONSTER_MAGNET", 0)]
        [FastEnumUtility.Label("Hero Monster Magnet", 1)]
        HeroMonsterMagnet = 1121001,
        [FastEnumUtility.Label("HERO_STANCE", 0)]
        [FastEnumUtility.Label("Hero Stance", 1)]
        HeroStance = 1121002,
        [FastEnumUtility.Label("HERO_ADVANCED_COMBO", 0)]
        [FastEnumUtility.Label("Hero Advanced Combo", 1)]
        HeroAdvancedCombo = 1120003,
        [FastEnumUtility.Label("HERO_HARD_SKIN", 0)]
        [FastEnumUtility.Label("Hero Hard Skin", 1)]
        HeroHardSkin = 1120004,
        [FastEnumUtility.Label("HERO_RUSH", 0)]
        [FastEnumUtility.Label("Hero Rush", 1)]
        HeroRush = 1121006,
        [FastEnumUtility.Label("HERO_BRAVE_SLASH", 0)]
        [FastEnumUtility.Label("Hero Brave Slash", 1)]
        HeroBraveSlash = 1121008,
        [FastEnumUtility.Label("HERO_ENRAGE", 0)]
        [FastEnumUtility.Label("Hero Enrage", 1)]
        HeroEnrage = 1121010,
        [FastEnumUtility.Label("HERO_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Hero Heros Will", 1)]
        HeroHerosWill = 1121011,
        [FastEnumUtility.Label("HERO_COMBAT_MASTERY", 0)]
        [FastEnumUtility.Label("Hero Combat Mastery", 1)]
        HeroCombatMastery = 1120012,
        [FastEnumUtility.Label("PAGE_WEAPON_MASTERY", 0)]
        [FastEnumUtility.Label("Page Weapon Mastery", 1)]
        PageWeaponMastery = 1200000,
        [FastEnumUtility.Label("PAGE_FINAL_ATTACK", 0)]
        [FastEnumUtility.Label("Page Final Attack", 1)]
        PageFinalAttack = 1200002,
        [FastEnumUtility.Label("PAGE_WEAPON_BOOSTER", 0)]
        [FastEnumUtility.Label("Page Weapon Booster", 1)]
        PageWeaponBooster = 1201004,
        [FastEnumUtility.Label("PAGE_THREATEN", 0)]
        [FastEnumUtility.Label("Page Threaten", 1)]
        PageThreaten = 1201006,
        [FastEnumUtility.Label("PAGE_POWER_GUARD", 0)]
        [FastEnumUtility.Label("Page Power Guard", 1)]
        PagePowerGuard = 1201007,
        [FastEnumUtility.Label("PAGE_GROUND_SMASH", 0)]
        [FastEnumUtility.Label("Page Ground Smash", 1)]
        PageGroundSmash = 1201008,
        [FastEnumUtility.Label("PAGE_IMPROVE_BASIC", 0)]
        [FastEnumUtility.Label("Page Improve Basic", 1)]
        PageImproveBasic = 1200009,
        [FastEnumUtility.Label("KNIGHT_SHIELD_MASTERY", 0)]
        [FastEnumUtility.Label("Knight Shield Mastery", 1)]
        KnightShieldMastery = 1210001,
        [FastEnumUtility.Label("KNIGHT_CHARGE_BLOW", 0)]
        [FastEnumUtility.Label("Knight Charge Blow", 1)]
        KnightChargeBlow = 1211002,
        [FastEnumUtility.Label("KNIGHT_FIRE_CHARGE", 0)]
        [FastEnumUtility.Label("Knight Fire Charge", 1)]
        KnightFireCharge = 1211004,
        [FastEnumUtility.Label("KNIGHT_ICE_CHARGE", 0)]
        [FastEnumUtility.Label("Knight Ice Charge", 1)]
        KnightIceCharge = 1211006,
        [FastEnumUtility.Label("KNIGHT_LIGHTNING_CHARGE", 0)]
        [FastEnumUtility.Label("Knight Lightning Charge", 1)]
        KnightLightningCharge = 1211008,
        [FastEnumUtility.Label("KNIGHT_MAGIC_CRASH", 0)]
        [FastEnumUtility.Label("Knight Magic Crash", 1)]
        KnightMagicCrash = 1211009,
        [FastEnumUtility.Label("KNIGHT_RESTORATION", 0)]
        [FastEnumUtility.Label("Knight Restoration", 1)]
        KnightRestoration = 1211010,
        [FastEnumUtility.Label("KNIGHT_COMBAT_ORDERS", 0)]
        [FastEnumUtility.Label("Knight Combat Orders", 1)]
        KnightCombatOrders = 1211011,
        [FastEnumUtility.Label("PALADIN_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Paladin Maple Hero", 1)]
        PaladinMapleHero = 1221000,
        [FastEnumUtility.Label("PALADIN_STANCE", 0)]
        [FastEnumUtility.Label("Paladin Stance", 1)]
        PaladinStance = 1221002,
        [FastEnumUtility.Label("PALADIN_DIVINE_CHARGE", 0)]
        [FastEnumUtility.Label("Paladin Divine Charge", 1)]
        PaladinDivineCharge = 1221004,
        [FastEnumUtility.Label("PALADIN_HARD_SKIN", 0)]
        [FastEnumUtility.Label("Paladin Hard Skin", 1)]
        PaladinHardSkin = 1220005,
        [FastEnumUtility.Label("PALADIN_BLOCKING", 0)]
        [FastEnumUtility.Label("Paladin Blocking", 1)]
        PaladinBlocking = 1220006,
        [FastEnumUtility.Label("PALADIN_RUSH", 0)]
        [FastEnumUtility.Label("Paladin Rush", 1)]
        PaladinRush = 1221007,
        [FastEnumUtility.Label("PALADIN_BLAST", 0)]
        [FastEnumUtility.Label("Paladin Blast", 1)]
        PaladinBlast = 1221009,
        [FastEnumUtility.Label("PALADIN_ADVANCED_CHARGE", 0)]
        [FastEnumUtility.Label("Paladin Advanced Charge", 1)]
        PaladinAdvancedCharge = 1220010,
        [FastEnumUtility.Label("PALADIN_SANCTUARY", 0)]
        [FastEnumUtility.Label("Paladin Sanctuary", 1)]
        PaladinSanctuary = 1221011,
        [FastEnumUtility.Label("PALADIN_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Paladin Heros Will", 1)]
        PaladinHerosWill = 1221012,
        [FastEnumUtility.Label("PALADIN_BLESSING_ARMOR", 0)]
        [FastEnumUtility.Label("Paladin Blessing Armor", 1)]
        PaladinBlessingArmor = 1220013,
        [FastEnumUtility.Label("SPEARMAN_WEAPON_MASTERY", 0)]
        [FastEnumUtility.Label("Spearman Weapon Mastery", 1)]
        SpearmanWeaponMastery = 1300000,
        [FastEnumUtility.Label("SPEARMAN_FINAL_ATTACK", 0)]
        [FastEnumUtility.Label("Spearman Final Attack", 1)]
        SpearmanFinalAttack = 1300002,
        [FastEnumUtility.Label("SPEARMAN_WEAPON_BOOSTER", 0)]
        [FastEnumUtility.Label("Spearman Weapon Booster", 1)]
        SpearmanWeaponBooster = 1301004,
        [FastEnumUtility.Label("SPEARMAN_IRON_WALL", 0)]
        [FastEnumUtility.Label("Spearman Iron Wall", 1)]
        SpearmanIronWall = 1301006,
        [FastEnumUtility.Label("SPEARMAN_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Spearman Hyper Body", 1)]
        SpearmanHyperBody = 1301007,
        [FastEnumUtility.Label("SPEARMAN_GROUND_SMASH", 0)]
        [FastEnumUtility.Label("Spearman Ground Smash", 1)]
        SpearmanGroundSmash = 1301008,
        [FastEnumUtility.Label("SPEARMAN_IMPROVE_BASIC", 0)]
        [FastEnumUtility.Label("Spearman Improve Basic", 1)]
        SpearmanImproveBasic = 1300009,
        [FastEnumUtility.Label("DRAGONKNIGHT_ELEMENT_RESISTANCE", 0)]
        [FastEnumUtility.Label("Dragonknight Element Resistance", 1)]
        DragonknightElementResistance = 1310000,
        [FastEnumUtility.Label("DRAGONKNIGHT_DRAGON_BURSTER", 0)]
        [FastEnumUtility.Label("Dragonknight Dragon Burster", 1)]
        DragonknightDragonBurster = 1311001,
        [FastEnumUtility.Label("DRAGONKNIGHT_DRAGON_THRESHER", 0)]
        [FastEnumUtility.Label("Dragonknight Dragon Thresher", 1)]
        DragonknightDragonThresher = 1311003,
        [FastEnumUtility.Label("DRAGONKNIGHT_SACRIFICE", 0)]
        [FastEnumUtility.Label("Dragonknight Sacrifice", 1)]
        DragonknightSacrifice = 1311005,
        [FastEnumUtility.Label("DRAGONKNIGHT_DRAGON_ROAR", 0)]
        [FastEnumUtility.Label("Dragonknight Dragon Roar", 1)]
        DragonknightDragonRoar = 1311006,
        [FastEnumUtility.Label("DRAGONKNIGHT_MAGIC_CRASH", 0)]
        [FastEnumUtility.Label("Dragonknight Magic Crash", 1)]
        DragonknightMagicCrash = 1311007,
        [FastEnumUtility.Label("DRAGONKNIGHT_DRAGON_BLOOD", 0)]
        [FastEnumUtility.Label("Dragonknight Dragon Blood", 1)]
        DragonknightDragonBlood = 1311008,
        [FastEnumUtility.Label("DRAGONKNIGHT_DRAGON_JUDGEMENT", 0)]
        [FastEnumUtility.Label("Dragonknight Dragon Judgement", 1)]
        DragonknightDragonJudgement = 1310009,
        [FastEnumUtility.Label("DARKKNIGHT_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Darkknight Maple Hero", 1)]
        DarkknightMapleHero = 1321000,
        [FastEnumUtility.Label("DARKKNIGHT_MONSTER_MAGNET", 0)]
        [FastEnumUtility.Label("Darkknight Monster Magnet", 1)]
        DarkknightMonsterMagnet = 1321001,
        [FastEnumUtility.Label("DARKKNIGHT_STANCE", 0)]
        [FastEnumUtility.Label("Darkknight Stance", 1)]
        DarkknightStance = 1321002,
        [FastEnumUtility.Label("DARKKNIGHT_RUSH", 0)]
        [FastEnumUtility.Label("Darkknight Rush", 1)]
        DarkknightRush = 1321003,
        [FastEnumUtility.Label("DARKKNIGHT_HARD_SKIN", 0)]
        [FastEnumUtility.Label("Darkknight Hard Skin", 1)]
        DarkknightHardSkin = 1320005,
        [FastEnumUtility.Label("DARKKNIGHT_DARK_FORCE", 0)]
        [FastEnumUtility.Label("Darkknight Dark Force", 1)]
        DarkknightDarkForce = 1320006,
        [FastEnumUtility.Label("DARKKNIGHT_BEHOLDER", 0)]
        [FastEnumUtility.Label("Darkknight Beholder", 1)]
        DarkknightBeholder = 1321007,
        [FastEnumUtility.Label("DARKKNIGHT_BEHOLDERS_HEALING", 0)]
        [FastEnumUtility.Label("Darkknight Beholders Healing", 1)]
        DarkknightBeholdersHealing = 1320008,
        [FastEnumUtility.Label("DARKKNIGHT_BEHOLDERS_BUFF", 0)]
        [FastEnumUtility.Label("Darkknight Beholders Buff", 1)]
        DarkknightBeholdersBuff = 1320009,
        [FastEnumUtility.Label("DARKKNIGHT_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Darkknight Heros Will", 1)]
        DarkknightHerosWill = 1321010,
        [FastEnumUtility.Label("DARKKNIGHT_BEHOLDERS_REVENGE", 0)]
        [FastEnumUtility.Label("Darkknight Beholders Revenge", 1)]
        DarkknightBeholdersRevenge = 1320011,
        [FastEnumUtility.Label("MAGICIAN_MAGIC_GUARD", 0)]
        [FastEnumUtility.Label("Magician Magic Guard", 1)]
        MagicianMagicGuard = 2001002,
        [FastEnumUtility.Label("MAGICIAN_MAGIC_ARMOR", 0)]
        [FastEnumUtility.Label("Magician Magic Armor", 1)]
        MagicianMagicArmor = 2001003,
        [FastEnumUtility.Label("MAGICIAN_ENERGY_BOLT", 0)]
        [FastEnumUtility.Label("Magician Energy Bolt", 1)]
        MagicianEnergyBolt = 2001004,
        [FastEnumUtility.Label("MAGICIAN_MAGIC_CLAW", 0)]
        [FastEnumUtility.Label("Magician Magic Claw", 1)]
        MagicianMagicClaw = 2001005,
        [FastEnumUtility.Label("MAGICIAN_MMP_INC", 0)]
        [FastEnumUtility.Label("Magician Max MP Inc", 1)]
        MagicianMmpInc = 2000006,
        [FastEnumUtility.Label("WIZARD1_MP_EATER", 0)]
        [FastEnumUtility.Label("Wizard1Mp Eater", 1)]
        Wizard1MpEater = 2100000,
        [FastEnumUtility.Label("WIZARD1_MEDITATION", 0)]
        Wizard1Meditation = 2101001,
        [FastEnumUtility.Label("WIZARD1_TELEPORT", 0)]
        Wizard1Teleport = 2101002,
        [FastEnumUtility.Label("WIZARD1_SLOW", 0)]
        Wizard1Slow = 2101003,
        [FastEnumUtility.Label("WIZARD1_FIRE_ARROW", 0)]
        [FastEnumUtility.Label("Wizard1Fire Arrow", 1)]
        Wizard1FireArrow = 2101004,
        [FastEnumUtility.Label("WIZARD1_POISON_BREATH", 0)]
        [FastEnumUtility.Label("Wizard1Poison Breath", 1)]
        Wizard1PoisonBreath = 2101005,
        [FastEnumUtility.Label("WIZARD1_SPELL_MASTERY", 0)]
        [FastEnumUtility.Label("Wizard1Spell Mastery", 1)]
        Wizard1SpellMastery = 2100006,
        [FastEnumUtility.Label("MAGE1_PARTIAL_RESISTANCE", 0)]
        [FastEnumUtility.Label("Mage1Partial Resistance", 1)]
        Mage1PartialResistance = 2110000,
        [FastEnumUtility.Label("MAGE1_ELEMENT_AMPLIFICATION", 0)]
        [FastEnumUtility.Label("Mage1Element Amplification", 1)]
        Mage1ElementAmplification = 2110001,
        [FastEnumUtility.Label("MAGE1_EXPLOSION", 0)]
        Mage1Explosion = 2111002,
        [FastEnumUtility.Label("MAGE1_POISON_MIST", 0)]
        [FastEnumUtility.Label("Mage1Poison Mist", 1)]
        Mage1PoisonMist = 2111003,
        [FastEnumUtility.Label("MAGE1_SEAL", 0)]
        Mage1Seal = 2111004,
        [FastEnumUtility.Label("MAGE1_MAGIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Mage1Magic Booster", 1)]
        Mage1MagicBooster = 2111005,
        [FastEnumUtility.Label("MAGE1_MAGIC_COMPOSITION", 0)]
        [FastEnumUtility.Label("Mage1Magic Composition", 1)]
        Mage1MagicComposition = 2111006,
        [FastEnumUtility.Label("MAGE1_TELEPORT_MASTERY", 0)]
        [FastEnumUtility.Label("Mage1Teleport Mastery", 1)]
        Mage1TeleportMastery = 2111007,
        [FastEnumUtility.Label("MAGE1_ELEMENTAL_RESET", 0)]
        [FastEnumUtility.Label("Mage1Elemental Reset", 1)]
        Mage1ElementalReset = 2111008,
        [FastEnumUtility.Label("ARCHMAGE1_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Archmage1Maple Hero", 1)]
        Archmage1MapleHero = 2121000,
        [FastEnumUtility.Label("ARCHMAGE1_BIGBANG", 0)]
        Archmage1Bigbang = 2121001,
        [FastEnumUtility.Label("ARCHMAGE1_MANA_REFLECTION", 0)]
        [FastEnumUtility.Label("Archmage1Mana Reflection", 1)]
        Archmage1ManaReflection = 2121002,
        [FastEnumUtility.Label("ARCHMAGE1_FIRE_DEMON", 0)]
        [FastEnumUtility.Label("Archmage1Fire Demon", 1)]
        Archmage1FireDemon = 2121003,
        [FastEnumUtility.Label("ARCHMAGE1_INFINITY", 0)]
        Archmage1Infinity = 2121004,
        [FastEnumUtility.Label("ARCHMAGE1_IFRIT", 0)]
        Archmage1Ifrit = 2121005,
        [FastEnumUtility.Label("ARCHMAGE1_PARALYZE", 0)]
        Archmage1Paralyze = 2121006,
        [FastEnumUtility.Label("ARCHMAGE1_METEOR", 0)]
        Archmage1Meteor = 2121007,
        [FastEnumUtility.Label("ARCHMAGE1_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Archmage1Heros Will", 1)]
        Archmage1HerosWill = 2121008,
        [FastEnumUtility.Label("ARCHMAGE1_MASTER_MAGIC", 0)]
        [FastEnumUtility.Label("Archmage1Master Magic", 1)]
        Archmage1MasterMagic = 2120009,
        [FastEnumUtility.Label("WIZARD2_MP_EATER", 0)]
        [FastEnumUtility.Label("Wizard2Mp Eater", 1)]
        Wizard2MpEater = 2200000,
        [FastEnumUtility.Label("WIZARD2_MEDITATION", 0)]
        Wizard2Meditation = 2201001,
        [FastEnumUtility.Label("WIZARD2_TELEPORT", 0)]
        Wizard2Teleport = 2201002,
        [FastEnumUtility.Label("WIZARD2_SLOW", 0)]
        Wizard2Slow = 2201003,
        [FastEnumUtility.Label("WIZARD2_COLD_BEAM", 0)]
        [FastEnumUtility.Label("Wizard2Cold Beam", 1)]
        Wizard2ColdBeam = 2201004,
        [FastEnumUtility.Label("WIZARD2_THUNDER_BOLT", 0)]
        [FastEnumUtility.Label("Wizard2Thunder Bolt", 1)]
        Wizard2ThunderBolt = 2201005,
        [FastEnumUtility.Label("WIZARD2_SPELL_MASTERY", 0)]
        [FastEnumUtility.Label("Wizard2Spell Mastery", 1)]
        Wizard2SpellMastery = 2200006,
        [FastEnumUtility.Label("MAGE2_PARTIAL_RESISTANCE", 0)]
        [FastEnumUtility.Label("Mage2Partial Resistance", 1)]
        Mage2PartialResistance = 2210000,
        [FastEnumUtility.Label("MAGE2_ELEMENT_AMPLIFICATION", 0)]
        [FastEnumUtility.Label("Mage2Element Amplification", 1)]
        Mage2ElementAmplification = 2210001,
        [FastEnumUtility.Label("MAGE2_ICE_STRIKE", 0)]
        [FastEnumUtility.Label("Mage2Ice Strike", 1)]
        Mage2IceStrike = 2211002,
        [FastEnumUtility.Label("MAGE2_THUNDER_SPEAR", 0)]
        [FastEnumUtility.Label("Mage2Thunder Spear", 1)]
        Mage2ThunderSpear = 2211003,
        [FastEnumUtility.Label("MAGE2_SEAL", 0)]
        Mage2Seal = 2211004,
        [FastEnumUtility.Label("MAGE2_MAGIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Mage2Magic Booster", 1)]
        Mage2MagicBooster = 2211005,
        [FastEnumUtility.Label("MAGE2_MAGIC_COMPOSITION", 0)]
        [FastEnumUtility.Label("Mage2Magic Composition", 1)]
        Mage2MagicComposition = 2211006,
        [FastEnumUtility.Label("MAGE2_TELEPORT_MASTERY", 0)]
        [FastEnumUtility.Label("Mage2Teleport Mastery", 1)]
        Mage2TeleportMastery = 2211007,
        [FastEnumUtility.Label("MAGE2_ELEMENTAL_RESET", 0)]
        [FastEnumUtility.Label("Mage2Elemental Reset", 1)]
        Mage2ElementalReset = 2211008,
        [FastEnumUtility.Label("ARCHMAGE2_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Archmage2Maple Hero", 1)]
        Archmage2MapleHero = 2221000,
        [FastEnumUtility.Label("ARCHMAGE2_BIGBANG", 0)]
        Archmage2Bigbang = 2221001,
        [FastEnumUtility.Label("ARCHMAGE2_MANA_REFLECTION", 0)]
        [FastEnumUtility.Label("Archmage2Mana Reflection", 1)]
        Archmage2ManaReflection = 2221002,
        [FastEnumUtility.Label("ARCHMAGE2_ICE_DEMON", 0)]
        [FastEnumUtility.Label("Archmage2Ice Demon", 1)]
        Archmage2IceDemon = 2221003,
        [FastEnumUtility.Label("ARCHMAGE2_INFINITY", 0)]
        Archmage2Infinity = 2221004,
        [FastEnumUtility.Label("ARCHMAGE2_ELQUINES", 0)]
        Archmage2Elquines = 2221005,
        [FastEnumUtility.Label("ARCHMAGE2_CHAIN_LIGHTNING", 0)]
        [FastEnumUtility.Label("Archmage2Chain Lightning", 1)]
        Archmage2ChainLightning = 2221006,
        [FastEnumUtility.Label("ARCHMAGE2_BLIZZARD", 0)]
        Archmage2Blizzard = 2221007,
        [FastEnumUtility.Label("ARCHMAGE2_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Archmage2Heros Will", 1)]
        Archmage2HerosWill = 2221008,
        [FastEnumUtility.Label("ARCHMAGE2_MASTER_MAGIC", 0)]
        [FastEnumUtility.Label("Archmage2Master Magic", 1)]
        Archmage2MasterMagic = 2220009,
        [FastEnumUtility.Label("CLERIC_MP_EATER", 0)]
        [FastEnumUtility.Label("Cleric Mp Eater", 1)]
        ClericMpEater = 2300000,
        [FastEnumUtility.Label("CLERIC_TELEPORT", 0)]
        [FastEnumUtility.Label("Cleric Teleport", 1)]
        ClericTeleport = 2301001,
        [FastEnumUtility.Label("CLERIC_HEAL", 0)]
        [FastEnumUtility.Label("Cleric Heal", 1)]
        ClericHeal = 2301002,
        [FastEnumUtility.Label("CLERIC_INVINCIBLE", 0)]
        [FastEnumUtility.Label("Cleric Invincible", 1)]
        ClericInvincible = 2301003,
        [FastEnumUtility.Label("CLERIC_BLESS", 0)]
        [FastEnumUtility.Label("Cleric Bless", 1)]
        ClericBless = 2301004,
        [FastEnumUtility.Label("CLERIC_HOLY_ARROW", 0)]
        [FastEnumUtility.Label("Cleric Holy Arrow", 1)]
        ClericHolyArrow = 2301005,
        [FastEnumUtility.Label("CLERIC_SPELL_MASTERY", 0)]
        [FastEnumUtility.Label("Cleric Spell Mastery", 1)]
        ClericSpellMastery = 2300006,
        [FastEnumUtility.Label("PRIEST_ELEMENT_RESISTANCE", 0)]
        [FastEnumUtility.Label("Priest Element Resistance", 1)]
        PriestElementResistance = 2310000,
        [FastEnumUtility.Label("PRIEST_DISPEL", 0)]
        [FastEnumUtility.Label("Priest Dispel", 1)]
        PriestDispel = 2311001,
        [FastEnumUtility.Label("PRIEST_MYSTIC_DOOR", 0)]
        [FastEnumUtility.Label("Priest Mystic Door", 1)]
        PriestMysticDoor = 2311002,
        [FastEnumUtility.Label("PRIEST_HOLY_SYMBOL", 0)]
        [FastEnumUtility.Label("Priest Holy Symbol", 1)]
        PriestHolySymbol = 2311003,
        [FastEnumUtility.Label("PRIEST_SHINING_RAY", 0)]
        [FastEnumUtility.Label("Priest Shining Ray", 1)]
        PriestShiningRay = 2311004,
        [FastEnumUtility.Label("PRIEST_DOOM", 0)]
        [FastEnumUtility.Label("Priest Doom", 1)]
        PriestDoom = 2311005,
        [FastEnumUtility.Label("PRIEST_SUMMON_DRAGON", 0)]
        [FastEnumUtility.Label("Priest Summon Dragon", 1)]
        PriestSummonDragon = 2311006,
        [FastEnumUtility.Label("PRIEST_TELEPORT_MASTERY", 0)]
        [FastEnumUtility.Label("Priest Teleport Mastery", 1)]
        PriestTeleportMastery = 2311007,
        [FastEnumUtility.Label("PRIEST_HOLY_FOCUS", 0)]
        [FastEnumUtility.Label("Priest Holy Focus", 1)]
        PriestHolyFocus = 2310008,
        [FastEnumUtility.Label("BISHOP_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Bishop Maple Hero", 1)]
        BishopMapleHero = 2321000,
        [FastEnumUtility.Label("BISHOP_BIGBANG", 0)]
        [FastEnumUtility.Label("Bishop Bigbang", 1)]
        BishopBigbang = 2321001,
        [FastEnumUtility.Label("BISHOP_MANA_REFLECTION", 0)]
        [FastEnumUtility.Label("Bishop Mana Reflection", 1)]
        BishopManaReflection = 2321002,
        [FastEnumUtility.Label("BISHOP_BAHAMUT", 0)]
        [FastEnumUtility.Label("Bishop Bahamut", 1)]
        BishopBahamut = 2321003,
        [FastEnumUtility.Label("BISHOP_INFINITY", 0)]
        [FastEnumUtility.Label("Bishop Infinity", 1)]
        BishopInfinity = 2321004,
        [FastEnumUtility.Label("BISHOP_HOLY_SHIELD", 0)]
        [FastEnumUtility.Label("Bishop Holy Shield", 1)]
        BishopHolyShield = 2321005,
        [FastEnumUtility.Label("BISHOP_RESURRECTION", 0)]
        [FastEnumUtility.Label("Bishop Resurrection", 1)]
        BishopResurrection = 2321006,
        [FastEnumUtility.Label("BISHOP_ANGELS_RAY", 0)]
        [FastEnumUtility.Label("Bishop Angels Ray", 1)]
        BishopAngelsRay = 2321007,
        [FastEnumUtility.Label("BISHOP_GENESIS", 0)]
        [FastEnumUtility.Label("Bishop Genesis", 1)]
        BishopGenesis = 2321008,
        [FastEnumUtility.Label("BISHOP_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Bishop Heros Will", 1)]
        BishopHerosWill = 2321009,
        [FastEnumUtility.Label("BISHOP_MASTER_MAGIC", 0)]
        [FastEnumUtility.Label("Bishop Master Magic", 1)]
        BishopMasterMagic = 2320010,
        [FastEnumUtility.Label("ARCHER_CRITICAL_SHOT", 0)]
        [FastEnumUtility.Label("Archer Critical Shot", 1)]
        ArcherCriticalShot = 3000001,
        [FastEnumUtility.Label("ARCHER_AMAZON_EYE", 0)]
        [FastEnumUtility.Label("Archer Amazon Eye", 1)]
        ArcherAmazonEye = 3000002,
        [FastEnumUtility.Label("ARCHER_FOCUS", 0)]
        [FastEnumUtility.Label("Archer Focus", 1)]
        ArcherFocus = 3001003,
        [FastEnumUtility.Label("ARCHER_ARROW_BLOW", 0)]
        [FastEnumUtility.Label("Archer Arrow Blow", 1)]
        ArcherArrowBlow = 3001004,
        [FastEnumUtility.Label("ARCHER_DOUBLE_SHOT", 0)]
        [FastEnumUtility.Label("Archer Double Shot", 1)]
        ArcherDoubleShot = 3001005,
        [FastEnumUtility.Label("HUNTER_BOW_MASTERY", 0)]
        [FastEnumUtility.Label("Hunter Bow Mastery", 1)]
        HunterBowMastery = 3100000,
        [FastEnumUtility.Label("HUNTER_FINAL_ATTACK_BOW", 0)]
        [FastEnumUtility.Label("Hunter Final Attack Bow", 1)]
        HunterFinalAttackBow = 3100001,
        [FastEnumUtility.Label("HUNTER_BOW_BOOSTER", 0)]
        [FastEnumUtility.Label("Hunter Bow Booster", 1)]
        HunterBowBooster = 3101002,
        [FastEnumUtility.Label("HUNTER_POWER_KNOCKBACK", 0)]
        [FastEnumUtility.Label("Hunter Power Knockback", 1)]
        HunterPowerKnockback = 3101003,
        [FastEnumUtility.Label("HUNTER_SOUL_ARROW_BOW", 0)]
        [FastEnumUtility.Label("Hunter Soul Arrow Bow", 1)]
        HunterSoulArrowBow = 3101004,
        [FastEnumUtility.Label("HUNTER_ARROW_BOMB", 0)]
        [FastEnumUtility.Label("Hunter Arrow Bomb", 1)]
        HunterArrowBomb = 3101005,
        [FastEnumUtility.Label("HUNTER_IMPROVE_BASIC", 0)]
        [FastEnumUtility.Label("Hunter Improve Basic", 1)]
        HunterImproveBasic = 3100006,
        [FastEnumUtility.Label("RANGER_THRUST", 0)]
        [FastEnumUtility.Label("Ranger Thrust", 1)]
        RangerThrust = 3110000,
        [FastEnumUtility.Label("RANGER_MORTAL_BLOW", 0)]
        [FastEnumUtility.Label("Ranger Mortal Blow", 1)]
        RangerMortalBlow = 3110001,
        [FastEnumUtility.Label("RANGER_PUPPET", 0)]
        [FastEnumUtility.Label("Ranger Puppet", 1)]
        RangerPuppet = 3111002,
        [FastEnumUtility.Label("RANGER_FIRE_SHOT", 0)]
        [FastEnumUtility.Label("Ranger Fire Shot", 1)]
        RangerFireShot = 3111003,
        [FastEnumUtility.Label("RANGER_ARROW_RAIN", 0)]
        [FastEnumUtility.Label("Ranger Arrow Rain", 1)]
        RangerArrowRain = 3111004,
        [FastEnumUtility.Label("RANGER_SILVER_HAWK", 0)]
        [FastEnumUtility.Label("Ranger Silver Hawk", 1)]
        RangerSilverHawk = 3111005,
        [FastEnumUtility.Label("RANGER_STRAFE", 0)]
        [FastEnumUtility.Label("Ranger Strafe", 1)]
        RangerStrafe = 3111006,
        [FastEnumUtility.Label("RANGER_DODGE", 0)]
        [FastEnumUtility.Label("Ranger Dodge", 1)]
        RangerDodge = 3110007,
        [FastEnumUtility.Label("BOWMASTER_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Bowmaster Maple Hero", 1)]
        BowmasterMapleHero = 3121000,
        [FastEnumUtility.Label("BOWMASTER_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Bowmaster Sharp Eyes", 1)]
        BowmasterSharpEyes = 3121002,
        [FastEnumUtility.Label("BOWMASTER_DRAGON_PULSE", 0)]
        [FastEnumUtility.Label("Bowmaster Dragon Pulse", 1)]
        BowmasterDragonPulse = 3121003,
        [FastEnumUtility.Label("BOWMASTER_STORM_ARROW", 0)]
        [FastEnumUtility.Label("Bowmaster Storm Arrow", 1)]
        BowmasterStormArrow = 3121004,
        [FastEnumUtility.Label("BOWMASTER_BOW_EXPERT", 0)]
        [FastEnumUtility.Label("Bowmaster Bow Expert", 1)]
        BowmasterBowExpert = 3120005,
        [FastEnumUtility.Label("BOWMASTER_PHOENIX", 0)]
        [FastEnumUtility.Label("Bowmaster Phoenix", 1)]
        BowmasterPhoenix = 3121006,
        [FastEnumUtility.Label("BOWMASTER_HAMSTRING", 0)]
        [FastEnumUtility.Label("Bowmaster Hamstring", 1)]
        BowmasterHamstring = 3121007,
        [FastEnumUtility.Label("BOWMASTER_CONCENTRATION", 0)]
        [FastEnumUtility.Label("Bowmaster Concentration", 1)]
        BowmasterConcentration = 3121008,
        [FastEnumUtility.Label("BOWMASTER_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Bowmaster Heros Will", 1)]
        BowmasterHerosWill = 3121009,
        [FastEnumUtility.Label("BOWMASTER_VENGEANCE", 0)]
        [FastEnumUtility.Label("Bowmaster Vengeance", 1)]
        BowmasterVengeance = 3120010,
        [FastEnumUtility.Label("BOWMASTER_MARKMAN_SHIP", 0)]
        [FastEnumUtility.Label("Bowmaster Marksmanship", 1)]
        BowmasterMarkmanShip = 3120011,
        [FastEnumUtility.Label("CROSSBOWMAN_CROSSBOW_MASTERY", 0)]
        [FastEnumUtility.Label("Crossbowman Crossbow Mastery", 1)]
        CrossbowmanCrossbowMastery = 3200000,
        [FastEnumUtility.Label("CROSSBOWMAN_FINAL_ATTACK_CROSSBOW", 0)]
        [FastEnumUtility.Label("Crossbowman Final Attack Crossbow", 1)]
        CrossbowmanFinalAttackCrossbow = 3200001,
        [FastEnumUtility.Label("CROSSBOWMAN_CROSSBOW_BOOSTER", 0)]
        [FastEnumUtility.Label("Crossbowman Crossbow Booster", 1)]
        CrossbowmanCrossbowBooster = 3201002,
        [FastEnumUtility.Label("CROSSBOWMAN_POWER_KNOCKBACK", 0)]
        [FastEnumUtility.Label("Crossbowman Power Knockback", 1)]
        CrossbowmanPowerKnockback = 3201003,
        [FastEnumUtility.Label("CROSSBOWMAN_SOUL_ARROW_CROSSBOW", 0)]
        [FastEnumUtility.Label("Crossbowman Soul Arrow Crossbow", 1)]
        CrossbowmanSoulArrowCrossbow = 3201004,
        [FastEnumUtility.Label("CROSSBOWMAN_IRON_ARROW", 0)]
        [FastEnumUtility.Label("Crossbowman Iron Arrow", 1)]
        CrossbowmanIronArrow = 3201005,
        [FastEnumUtility.Label("CROSSBOWMAN_IMPROVE_BASIC", 0)]
        [FastEnumUtility.Label("Crossbowman Improve Basic", 1)]
        CrossbowmanImproveBasic = 3200006,
        [FastEnumUtility.Label("SNIPER_THRUST", 0)]
        [FastEnumUtility.Label("Sniper Thrust", 1)]
        SniperThrust = 3210000,
        [FastEnumUtility.Label("SNIPER_MORTAL_BLOW", 0)]
        [FastEnumUtility.Label("Sniper Mortal Blow", 1)]
        SniperMortalBlow = 3210001,
        [FastEnumUtility.Label("SNIPER_PUPPET", 0)]
        [FastEnumUtility.Label("Sniper Puppet", 1)]
        SniperPuppet = 3211002,
        [FastEnumUtility.Label("SNIPER_ICE_SHOT", 0)]
        [FastEnumUtility.Label("Sniper Ice Shot", 1)]
        SniperIceShot = 3211003,
        [FastEnumUtility.Label("SNIPER_ARROW_ERUPTION", 0)]
        [FastEnumUtility.Label("Sniper Arrow Eruption", 1)]
        SniperArrowEruption = 3211004,
        [FastEnumUtility.Label("SNIPER_GOLDEN_EAGLE", 0)]
        [FastEnumUtility.Label("Sniper Golden Eagle", 1)]
        SniperGoldenEagle = 3211005,
        [FastEnumUtility.Label("SNIPER_STRAFE", 0)]
        [FastEnumUtility.Label("Sniper Strafe", 1)]
        SniperStrafe = 3211006,
        [FastEnumUtility.Label("SNIPER_DODGE", 0)]
        [FastEnumUtility.Label("Sniper Dodge", 1)]
        SniperDodge = 3210007,
        [FastEnumUtility.Label("CROSSBOWMASTER_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Crossbowmaster Maple Hero", 1)]
        CrossbowmasterMapleHero = 3221000,
        [FastEnumUtility.Label("CROSSBOWMASTER_PIERCING", 0)]
        [FastEnumUtility.Label("Crossbowmaster Piercing", 1)]
        CrossbowmasterPiercing = 3221001,
        [FastEnumUtility.Label("CROSSBOWMASTER_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Crossbowmaster Sharp Eyes", 1)]
        CrossbowmasterSharpEyes = 3221002,
        [FastEnumUtility.Label("CROSSBOWMASTER_DRAGON_PULSE", 0)]
        [FastEnumUtility.Label("Crossbowmaster Dragon Pulse", 1)]
        CrossbowmasterDragonPulse = 3221003,
        [FastEnumUtility.Label("CROSSBOWMASTER_CROSSBOW_EXPERT", 0)]
        [FastEnumUtility.Label("Crossbowmaster Crossbow Expert", 1)]
        CrossbowmasterCrossbowExpert = 3220004,
        [FastEnumUtility.Label("CROSSBOWMASTER_FREEZER", 0)]
        [FastEnumUtility.Label("Crossbowmaster Freezer", 1)]
        CrossbowmasterFreezer = 3221005,
        [FastEnumUtility.Label("CROSSBOWMASTER_BLIND", 0)]
        [FastEnumUtility.Label("Crossbowmaster Blind", 1)]
        CrossbowmasterBlind = 3221006,
        [FastEnumUtility.Label("CROSSBOWMASTER_SNIPING", 0)]
        [FastEnumUtility.Label("Crossbowmaster Sniping", 1)]
        CrossbowmasterSniping = 3221007,
        [FastEnumUtility.Label("CROSSBOWMASTER_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Crossbowmaster Heros Will", 1)]
        CrossbowmasterHerosWill = 3221008,
        [FastEnumUtility.Label("CROSSBOWMASTER_MARKMAN_SHIP", 0)]
        [FastEnumUtility.Label("Crossbowmaster Marksmanship", 1)]
        CrossbowmasterMarkmanShip = 3220009,
        [FastEnumUtility.Label("CROSSBOWMASTER_ULTIMATE_STRAFE", 0)]
        [FastEnumUtility.Label("Crossbowmaster Ultimate Strafe", 1)]
        CrossbowmasterUltimateStrafe = 3220010,
        [FastEnumUtility.Label("ROGUE_NIMBLE_BODY", 0)]
        [FastEnumUtility.Label("Rogue Nimble Body", 1)]
        RogueNimbleBody = 4000000,
        [FastEnumUtility.Label("ROGUE_KEEN_EYES", 0)]
        [FastEnumUtility.Label("Rogue Keen Eyes", 1)]
        RogueKeenEyes = 4000001,
        [FastEnumUtility.Label("ROGUE_DISORDER", 0)]
        [FastEnumUtility.Label("Rogue Disorder", 1)]
        RogueDisorder = 4001002,
        [FastEnumUtility.Label("ROGUE_DARK_SIGHT", 0)]
        [FastEnumUtility.Label("Rogue Dark Sight", 1)]
        RogueDarkSight = 4001003,
        [FastEnumUtility.Label("ROGUE_DOUBLE_STAB_DAGGER", 0)]
        [FastEnumUtility.Label("Rogue Double Stab Dagger", 1)]
        RogueDoubleStabDagger = 4001334,
        [FastEnumUtility.Label("ROGUE_LUCKY_SEVEN", 0)]
        [FastEnumUtility.Label("Rogue Lucky Seven", 1)]
        RogueLuckySeven = 4001344,
        [FastEnumUtility.Label("ASSASSIN_JAVELIN_MASTERY", 0)]
        [FastEnumUtility.Label("Assassin Javelin Mastery", 1)]
        AssassinJavelinMastery = 4100000,
        [FastEnumUtility.Label("ASSASSIN_CRITICAL_THROW", 0)]
        [FastEnumUtility.Label("Assassin Critical Throw", 1)]
        AssassinCriticalThrow = 4100001,
        [FastEnumUtility.Label("ASSASSIN_JAVELIN_BOOSTER", 0)]
        [FastEnumUtility.Label("Assassin Javelin Booster", 1)]
        AssassinJavelinBooster = 4101003,
        [FastEnumUtility.Label("ASSASSIN_HASTE", 0)]
        [FastEnumUtility.Label("Assassin Haste", 1)]
        AssassinHaste = 4101004,
        [FastEnumUtility.Label("ASSASSIN_DRAIN", 0)]
        [FastEnumUtility.Label("Assassin Drain", 1)]
        AssassinDrain = 4101005,
        [FastEnumUtility.Label("ASSASSIN_SHADOW_RESISTANCE", 0)]
        [FastEnumUtility.Label("Assassin Shadow Resistance", 1)]
        AssassinShadowResistance = 4100006,
        [FastEnumUtility.Label("HERMIT_ALCHEMIST", 0)]
        [FastEnumUtility.Label("Hermit Alchemist", 1)]
        HermitAlchemist = 4110000,
        [FastEnumUtility.Label("HERMIT_MESO_UP", 0)]
        [FastEnumUtility.Label("Hermit Meso Up", 1)]
        HermitMesoUp = 4111001,
        [FastEnumUtility.Label("HERMIT_SHADOW_PARTNER", 0)]
        [FastEnumUtility.Label("Hermit Shadow Partner", 1)]
        HermitShadowPartner = 4111002,
        [FastEnumUtility.Label("HERMIT_SHADOW_WEB", 0)]
        [FastEnumUtility.Label("Hermit Shadow Web", 1)]
        HermitShadowWeb = 4111003,
        [FastEnumUtility.Label("HERMIT_SHADOW_MESO", 0)]
        [FastEnumUtility.Label("Hermit Shadow Meso", 1)]
        HermitShadowMeso = 4111004,
        [FastEnumUtility.Label("HERMIT_AVENGER", 0)]
        [FastEnumUtility.Label("Hermit Avenger", 1)]
        HermitAvenger = 4111005,
        [FastEnumUtility.Label("HERMIT_FLASH_JUMP", 0)]
        [FastEnumUtility.Label("Hermit Flash Jump", 1)]
        HermitFlashJump = 4111006,
        [FastEnumUtility.Label("HERMIT_SHADOW_MIRROR", 0)]
        [FastEnumUtility.Label("Hermit Shadow Mirror", 1)]
        HermitShadowMirror = 4111007,
        [FastEnumUtility.Label("NIGHTLORD_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Nightlord Maple Hero", 1)]
        NightlordMapleHero = 4121000,
        [FastEnumUtility.Label("NIGHTLORD_FAKE", 0)]
        [FastEnumUtility.Label("Nightlord Fake", 1)]
        NightlordFake = 4120002,
        [FastEnumUtility.Label("NIGHTLORD_SHOWDOWN", 0)]
        [FastEnumUtility.Label("Nightlord Showdown", 1)]
        NightlordShowdown = 4121003,
        [FastEnumUtility.Label("NIGHTLORD_NINJA_AMBUSH", 0)]
        [FastEnumUtility.Label("Nightlord Ninja Ambush", 1)]
        NightlordNinjaAmbush = 4121004,
        [FastEnumUtility.Label("NIGHTLORD_VENOM", 0)]
        [FastEnumUtility.Label("Nightlord Venom", 1)]
        NightlordVenom = 4120005,
        [FastEnumUtility.Label("NIGHTLORD_SPIRIT_JAVELIN", 0)]
        [FastEnumUtility.Label("Nightlord Spirit Javelin", 1)]
        NightlordSpiritJavelin = 4121006,
        [FastEnumUtility.Label("NIGHTLORD_TRIPLE_THROW", 0)]
        [FastEnumUtility.Label("Nightlord Triple Throw", 1)]
        NightlordTripleThrow = 4121007,
        [FastEnumUtility.Label("NIGHTLORD_NINJA_STORM", 0)]
        [FastEnumUtility.Label("Nightlord Ninja Storm", 1)]
        NightlordNinjaStorm = 4121008,
        [FastEnumUtility.Label("NIGHTLORD_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Nightlord Heros Will", 1)]
        NightlordHerosWill = 4121009,
        [FastEnumUtility.Label("NIGHTLORD_EXPERT_JAVELIN", 0)]
        [FastEnumUtility.Label("Nightlord Expert Javelin", 1)]
        NightlordExpertJavelin = 4120010,
        [FastEnumUtility.Label("THIEF_DAGGER_MASTERY", 0)]
        [FastEnumUtility.Label("Thief Dagger Mastery", 1)]
        ThiefDaggerMastery = 4200000,
        [FastEnumUtility.Label("THIEF_DAGGER_BOOSTER", 0)]
        [FastEnumUtility.Label("Thief Dagger Booster", 1)]
        ThiefDaggerBooster = 4201002,
        [FastEnumUtility.Label("THIEF_HASTE", 0)]
        [FastEnumUtility.Label("Thief Haste", 1)]
        ThiefHaste = 4201003,
        [FastEnumUtility.Label("THIEF_STEAL", 0)]
        [FastEnumUtility.Label("Thief Steal", 1)]
        ThiefSteal = 4201004,
        [FastEnumUtility.Label("THIEF_SAVAGE_BLOW_DAGGER", 0)]
        [FastEnumUtility.Label("Thief Savage Blow Dagger", 1)]
        ThiefSavageBlowDagger = 4201005,
        [FastEnumUtility.Label("THIEF_SHADOW_RESISTANCE", 0)]
        [FastEnumUtility.Label("Thief Shadow Resistance", 1)]
        ThiefShadowResistance = 4200006,
        [FastEnumUtility.Label("THIEFMASTER_SHIELD_MASTERY", 0)]
        [FastEnumUtility.Label("Thiefmaster Shield Mastery", 1)]
        ThiefmasterShieldMastery = 4210000,
        [FastEnumUtility.Label("THIEFMASTER_CHAKRA", 0)]
        [FastEnumUtility.Label("Thiefmaster Chakra", 1)]
        ThiefmasterChakra = 4211001,
        [FastEnumUtility.Label("THIEFMASTER_ASSAULTER", 0)]
        [FastEnumUtility.Label("Thiefmaster Assaulter", 1)]
        ThiefmasterAssaulter = 4211002,
        [FastEnumUtility.Label("THIEFMASTER_PICKPOCKET", 0)]
        [FastEnumUtility.Label("Thiefmaster Pickpocket", 1)]
        ThiefmasterPickpocket = 4211003,
        [FastEnumUtility.Label("THIEFMASTER_THIEVES", 0)]
        [FastEnumUtility.Label("Thiefmaster Thieves", 1)]
        ThiefmasterThieves = 4211004,
        [FastEnumUtility.Label("THIEFMASTER_MESO_GUARD", 0)]
        [FastEnumUtility.Label("Thiefmaster Meso Guard", 1)]
        ThiefmasterMesoGuard = 4211005,
        [FastEnumUtility.Label("THIEFMASTER_MESO_EXPLOSION", 0)]
        [FastEnumUtility.Label("Thiefmaster Meso Explosion", 1)]
        ThiefmasterMesoExplosion = 4211006,
        [FastEnumUtility.Label("THIEFMASTER_SHADOW_MIRROR", 0)]
        [FastEnumUtility.Label("Thiefmaster Shadow Mirror", 1)]
        ThiefmasterShadowMirror = 4211007,
        [FastEnumUtility.Label("THIEFMASTER_SHADOW_PARTNER", 0)]
        [FastEnumUtility.Label("Thiefmaster Shadow Partner", 1)]
        ThiefmasterShadowPartner = 4211008,
        [FastEnumUtility.Label("THIEFMASTER_FLASH_JUMP", 0)]
        [FastEnumUtility.Label("Thiefmaster Flash Jump", 1)]
        ThiefmasterFlashJump = 4211009,
        [FastEnumUtility.Label("SHADOWER_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Shadower Maple Hero", 1)]
        ShadowerMapleHero = 4221000,
        [FastEnumUtility.Label("SHADOWER_ASSASSINATION", 0)]
        [FastEnumUtility.Label("Shadower Assassination", 1)]
        ShadowerAssassination = 4221001,
        [FastEnumUtility.Label("SHADOWER_FAKE", 0)]
        [FastEnumUtility.Label("Shadower Fake", 1)]
        ShadowerFake = 4220002,
        [FastEnumUtility.Label("SHADOWER_SHOWDOWN", 0)]
        [FastEnumUtility.Label("Shadower Showdown", 1)]
        ShadowerShowdown = 4221003,
        [FastEnumUtility.Label("SHADOWER_NINJA_AMBUSH", 0)]
        [FastEnumUtility.Label("Shadower Ninja Ambush", 1)]
        ShadowerNinjaAmbush = 4221004,
        [FastEnumUtility.Label("SHADOWER_VENOM", 0)]
        [FastEnumUtility.Label("Shadower Venom", 1)]
        ShadowerVenom = 4220005,
        [FastEnumUtility.Label("SHADOWER_SMOKE_SHELL", 0)]
        [FastEnumUtility.Label("Shadower Smoke Shell", 1)]
        ShadowerSmokeShell = 4221006,
        [FastEnumUtility.Label("SHADOWER_BOOMERANG_STEP", 0)]
        [FastEnumUtility.Label("Shadower Boomerang Step", 1)]
        ShadowerBoomerangStep = 4221007,
        [FastEnumUtility.Label("SHADOWER_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Shadower Heros Will", 1)]
        ShadowerHerosWill = 4221008,
        [FastEnumUtility.Label("SHADOWER_GRID", 0)]
        [FastEnumUtility.Label("Shadower Grid", 1)]
        ShadowerGrid = 4220009,
        [FastEnumUtility.Label("DUAL1_DUAL_MASTERY", 0)]
        [FastEnumUtility.Label("Dual1Dual Mastery", 1)]
        Dual1DualMastery = 4300000,
        [FastEnumUtility.Label("DUAL1_TRIPLE_STAB", 0)]
        [FastEnumUtility.Label("Dual1Triple Stab", 1)]
        Dual1TripleStab = 4301001,
        [FastEnumUtility.Label("DUAL1_DUAL_BOOSTER", 0)]
        [FastEnumUtility.Label("Dual1Dual Booster", 1)]
        Dual1DualBooster = 4301002,
        [FastEnumUtility.Label("DUAL2_SELF_HASTE", 0)]
        [FastEnumUtility.Label("Dual2Self Haste", 1)]
        Dual2SelfHaste = 4311001,
        [FastEnumUtility.Label("DUAL2_FATAL_BLOW", 0)]
        [FastEnumUtility.Label("Dual2Fatal Blow", 1)]
        Dual2FatalBlow = 4311002,
        [FastEnumUtility.Label("DUAL2_SLASH_STORM", 0)]
        [FastEnumUtility.Label("Dual2Slash Storm", 1)]
        Dual2SlashStorm = 4311003,
        [FastEnumUtility.Label("DUAL2_SHADOW_RESISTANCE", 0)]
        [FastEnumUtility.Label("Dual2Shadow Resistance", 1)]
        Dual2ShadowResistance = 4310004,
        [FastEnumUtility.Label("DUAL3_HUSTLE_DASH", 0)]
        [FastEnumUtility.Label("Dual3Hustle Dash", 1)]
        Dual3HustleDash = 4321000,
        [FastEnumUtility.Label("DUAL3_HUSTLE_RUSH", 0)]
        [FastEnumUtility.Label("Dual3Hustle Rush", 1)]
        Dual3HustleRush = 4321001,
        [FastEnumUtility.Label("DUAL3_FLASH_BANG", 0)]
        [FastEnumUtility.Label("Dual3Flash Bang", 1)]
        Dual3FlashBang = 4321002,
        [FastEnumUtility.Label("DUAL3_FLASH_JUMP", 0)]
        [FastEnumUtility.Label("Dual3Flash Jump", 1)]
        Dual3FlashJump = 4321003,
        [FastEnumUtility.Label("DUAL4_BLOODY_STORM", 0)]
        [FastEnumUtility.Label("Dual4Bloody Storm", 1)]
        Dual4BloodyStorm = 4331000,
        [FastEnumUtility.Label("DUAL4_ADVANCED_DARK_SIGHT", 0)]
        [FastEnumUtility.Label("Dual4Advanced Dark Sight", 1)]
        Dual4AdvancedDarkSight = 4330001,
        [FastEnumUtility.Label("DUAL4_MIRROR_IMAGING", 0)]
        [FastEnumUtility.Label("Dual4Mirror Imaging", 1)]
        Dual4MirrorImaging = 4331002,
        [FastEnumUtility.Label("DUAL4_OWL_DEATH", 0)]
        [FastEnumUtility.Label("Dual4Owl Death", 1)]
        Dual4OwlDeath = 4331003,
        [FastEnumUtility.Label("DUAL4_UPPER_STAB", 0)]
        [FastEnumUtility.Label("Dual4Upper Stab", 1)]
        Dual4UpperStab = 4331004,
        [FastEnumUtility.Label("DUAL4_FLYING_ASSAULTER", 0)]
        [FastEnumUtility.Label("Dual4Flying Assaulter", 1)]
        Dual4FlyingAssaulter = 4331005,
        [FastEnumUtility.Label("DUAL5_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Dual5Maple Hero", 1)]
        Dual5MapleHero = 4341000,
        [FastEnumUtility.Label("DUAL5_VENOM", 0)]
        Dual5Venom = 4340001,
        [FastEnumUtility.Label("DUAL5_FINAL_CUT", 0)]
        [FastEnumUtility.Label("Dual5Final Cut", 1)]
        Dual5FinalCut = 4341002,
        [FastEnumUtility.Label("DUAL5_MONSTER_BOMB", 0)]
        [FastEnumUtility.Label("Dual5Monster Bomb", 1)]
        Dual5MonsterBomb = 4341003,
        [FastEnumUtility.Label("DUAL5_SUDDEN_RAID", 0)]
        [FastEnumUtility.Label("Dual5Sudden Raid", 1)]
        Dual5SuddenRaid = 4341004,
        [FastEnumUtility.Label("DUAL5_ASSASSINATION", 0)]
        Dual5Assassination = 4341005,
        [FastEnumUtility.Label("DUAL5_DUMMY_EFFECT", 0)]
        [FastEnumUtility.Label("Dual5Dummy Effect", 1)]
        Dual5DummyEffect = 4341006,
        [FastEnumUtility.Label("DUAL5_THORNS_EFFECT", 0)]
        [FastEnumUtility.Label("Dual5Thorns Effect", 1)]
        Dual5ThornsEffect = 4341007,
        [FastEnumUtility.Label("DUAL5_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Dual5Heros Will", 1)]
        Dual5HerosWill = 4341008,
        [FastEnumUtility.Label("PIRATE_QUICKMOTION", 0)]
        [FastEnumUtility.Label("Pirate Quickmotion", 1)]
        PirateQuickmotion = 5000000,
        [FastEnumUtility.Label("PIRATE_STRAIGHT", 0)]
        [FastEnumUtility.Label("Pirate Straight", 1)]
        PirateStraight = 5001001,
        [FastEnumUtility.Label("PIRATE_SOMERSAULT", 0)]
        [FastEnumUtility.Label("Pirate Somersault", 1)]
        PirateSomersault = 5001002,
        [FastEnumUtility.Label("PIRATE_DOUBLE_FIRE", 0)]
        [FastEnumUtility.Label("Pirate Double Fire", 1)]
        PirateDoubleFire = 5001003,
        [FastEnumUtility.Label("PIRATE_DASH", 0)]
        [FastEnumUtility.Label("Pirate Dash", 1)]
        PirateDash = 5001005,
        [FastEnumUtility.Label("INFIGHTER_KNUCKLE_MASTERY", 0)]
        [FastEnumUtility.Label("Infighter Knuckle Mastery", 1)]
        InfighterKnuckleMastery = 5100001,
        [FastEnumUtility.Label("INFIGHTER_BACKSPIN_BLOW", 0)]
        [FastEnumUtility.Label("Infighter Backspin Blow", 1)]
        InfighterBackspinBlow = 5101002,
        [FastEnumUtility.Label("INFIGHTER_DOUBLE_UPPER", 0)]
        [FastEnumUtility.Label("Infighter Double Upper", 1)]
        InfighterDoubleUpper = 5101003,
        [FastEnumUtility.Label("INFIGHTER_SCREW_PUNCH", 0)]
        [FastEnumUtility.Label("Infighter Screw Punch", 1)]
        InfighterScrewPunch = 5101004,
        [FastEnumUtility.Label("INFIGHTER_MP_RECOVERY", 0)]
        [FastEnumUtility.Label("Infighter Mp Recovery", 1)]
        InfighterMpRecovery = 5101005,
        [FastEnumUtility.Label("INFIGHTER_KNUCKLE_BOOSTER", 0)]
        [FastEnumUtility.Label("Infighter Knuckle Booster", 1)]
        InfighterKnuckleBooster = 5101006,
        [FastEnumUtility.Label("INFIGHTER_OAK_CASK", 0)]
        [FastEnumUtility.Label("Infighter Oak Cask", 1)]
        InfighterOakCask = 5101007,
        [FastEnumUtility.Label("INFIGHTER_MHP_INC", 0)]
        [FastEnumUtility.Label("Infighter Max HP Inc", 1)]
        InfighterMhpInc = 5100009,
        [FastEnumUtility.Label("INFIGHTER_CRITICAL_PUNCH", 0)]
        [FastEnumUtility.Label("Infighter Critical Punch", 1)]
        InfighterCriticalPunch = 5100008,
        [FastEnumUtility.Label("BUCCANEER_STUN_MASTERY", 0)]
        [FastEnumUtility.Label("Buccaneer Stun Mastery", 1)]
        BuccaneerStunMastery = 5110000,
        [FastEnumUtility.Label("BUCCANEER_ENERGY_CHARGE", 0)]
        [FastEnumUtility.Label("Buccaneer Energy Charge", 1)]
        BuccaneerEnergyCharge = 5110001,
        [FastEnumUtility.Label("BUCCANEER_ENERGY_BURSTER", 0)]
        [FastEnumUtility.Label("Buccaneer Energy Burster", 1)]
        BuccaneerEnergyBurster = 5111002,
        [FastEnumUtility.Label("BUCCANEER_ENERGY_DRAIN", 0)]
        [FastEnumUtility.Label("Buccaneer Energy Drain", 1)]
        BuccaneerEnergyDrain = 5111004,
        [FastEnumUtility.Label("BUCCANEER_TRANSFORM", 0)]
        [FastEnumUtility.Label("Buccaneer Transform", 1)]
        BuccaneerTransform = 5111005,
        [FastEnumUtility.Label("BUCCANEER_SHOCKWAVE", 0)]
        [FastEnumUtility.Label("Buccaneer Shockwave", 1)]
        BuccaneerShockwave = 5111006,
        [FastEnumUtility.Label("BUCCANEER_DICE", 0)]
        [FastEnumUtility.Label("Buccaneer Dice", 1)]
        BuccaneerDice = 5111007,
        [FastEnumUtility.Label("BUCCANEER_INFIGHTING_MASTERY", 0)]
        [FastEnumUtility.Label("Buccaneer Infighting Mastery", 1)]
        BuccaneerInfightingMastery = 5110008,
        [FastEnumUtility.Label("VIPER_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Viper Maple Hero", 1)]
        ViperMapleHero = 5121000,
        [FastEnumUtility.Label("VIPER_DRAGON_STRIKE", 0)]
        [FastEnumUtility.Label("Viper Dragon Strike", 1)]
        ViperDragonStrike = 5121001,
        [FastEnumUtility.Label("VIPER_ENERGY_ORB", 0)]
        [FastEnumUtility.Label("Viper Energy Orb", 1)]
        ViperEnergyOrb = 5121002,
        [FastEnumUtility.Label("VIPER_SUPER_TRANSFORM", 0)]
        [FastEnumUtility.Label("Viper Super Transform", 1)]
        ViperSuperTransform = 5121003,
        [FastEnumUtility.Label("VIPER_DEMOLITION", 0)]
        [FastEnumUtility.Label("Viper Demolition", 1)]
        ViperDemolition = 5121004,
        [FastEnumUtility.Label("VIPER_SNATCH", 0)]
        [FastEnumUtility.Label("Viper Snatch", 1)]
        ViperSnatch = 5121005,
        [FastEnumUtility.Label("VIPER_FIST", 0)]
        [FastEnumUtility.Label("Viper Fist", 1)]
        ViperFist = 5121007,
        [FastEnumUtility.Label("VIPER_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Viper Heros Will", 1)]
        ViperHerosWill = 5121008,
        [FastEnumUtility.Label("VIPER_WIND_BOOSTER", 0)]
        [FastEnumUtility.Label("Viper Wind Booster", 1)]
        ViperWindBooster = 5121009,
        [FastEnumUtility.Label("VIPER_TIME_LEAP", 0)]
        [FastEnumUtility.Label("Viper Time Leap", 1)]
        ViperTimeLeap = 5121010,
        [FastEnumUtility.Label("VIPER_COUNTER_ATTACK", 0)]
        [FastEnumUtility.Label("Viper Counter Attack", 1)]
        ViperCounterAttack = 5120011,
        [FastEnumUtility.Label("GUNSLINGER_GUN_MASTERY", 0)]
        [FastEnumUtility.Label("Gunslinger Gun Mastery", 1)]
        GunslingerGunMastery = 5200000,
        [FastEnumUtility.Label("GUNSLINGER_INVISIBLE_SHOT", 0)]
        [FastEnumUtility.Label("Gunslinger Invisible Shot", 1)]
        GunslingerInvisibleShot = 5201001,
        [FastEnumUtility.Label("GUNSLINGER_THROWING_BOMB", 0)]
        [FastEnumUtility.Label("Gunslinger Throwing Bomb", 1)]
        GunslingerThrowingBomb = 5201002,
        [FastEnumUtility.Label("GUNSLINGER_GUN_BOOSTER", 0)]
        [FastEnumUtility.Label("Gunslinger Gun Booster", 1)]
        GunslingerGunBooster = 5201003,
        [FastEnumUtility.Label("GUNSLINGER_FAKE_SHOT", 0)]
        [FastEnumUtility.Label("Gunslinger Fake Shot", 1)]
        GunslingerFakeShot = 5201004,
        [FastEnumUtility.Label("GUNSLINGER_WINGS", 0)]
        [FastEnumUtility.Label("Gunslinger Wings", 1)]
        GunslingerWings = 5201005,
        [FastEnumUtility.Label("GUNSLINGER_BACKSTEP_SHOT", 0)]
        [FastEnumUtility.Label("Gunslinger Backstep Shot", 1)]
        GunslingerBackstepShot = 5201006,
        [FastEnumUtility.Label("GUNSLINGER_CRITICAL_SHOT", 0)]
        [FastEnumUtility.Label("Gunslinger Critical Shot", 1)]
        GunslingerCriticalShot = 5200007,
        [FastEnumUtility.Label("VALKYRIE_TRIPLE_FIRE", 0)]
        [FastEnumUtility.Label("Valkyrie Triple Fire", 1)]
        ValkyrieTripleFire = 5210000,
        [FastEnumUtility.Label("VALKYRIE_OCTOPUS", 0)]
        [FastEnumUtility.Label("Valkyrie Octopus", 1)]
        ValkyrieOctopus = 5211001,
        [FastEnumUtility.Label("VALKYRIE_GABIOTA", 0)]
        [FastEnumUtility.Label("Valkyrie Gabiota", 1)]
        ValkyrieGabiota = 5211002,
        [FastEnumUtility.Label("VALKYRIE_FIRE_BURNER", 0)]
        [FastEnumUtility.Label("Valkyrie Fire Burner", 1)]
        ValkyrieFireBurner = 5211004,
        [FastEnumUtility.Label("VALKYRIE_COOLING_EFFECT", 0)]
        [FastEnumUtility.Label("Valkyrie Cooling Effect", 1)]
        ValkyrieCoolingEffect = 5211005,
        [FastEnumUtility.Label("VALKYRIE_HOMING", 0)]
        [FastEnumUtility.Label("Valkyrie Homing", 1)]
        ValkyrieHoming = 5211006,
        [FastEnumUtility.Label("VALKYRIE_DICE", 0)]
        [FastEnumUtility.Label("Valkyrie Dice", 1)]
        ValkyrieDice = 5211007,
        [FastEnumUtility.Label("CAPTAIN_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Captain Maple Hero", 1)]
        CaptainMapleHero = 5221000,
        [FastEnumUtility.Label("CAPTAIN_PROPERTY_UPGRADE", 0)]
        [FastEnumUtility.Label("Captain Property Upgrade", 1)]
        CaptainPropertyUpgrade = 5220001,
        [FastEnumUtility.Label("CAPTAIN_SUPPORT_OCTOPUS", 0)]
        [FastEnumUtility.Label("Captain Support Octopus", 1)]
        CaptainSupportOctopus = 5220002,
        [FastEnumUtility.Label("CAPTAIN_AIR_STRIKE", 0)]
        [FastEnumUtility.Label("Captain Air Strike", 1)]
        CaptainAirStrike = 5221003,
        [FastEnumUtility.Label("CAPTAIN_RAPID_FIRE", 0)]
        [FastEnumUtility.Label("Captain Rapid Fire", 1)]
        CaptainRapidFire = 5221004,
        [FastEnumUtility.Label("CAPTAIN_BATTLESHIP", 0)]
        [FastEnumUtility.Label("Captain Battleship", 1)]
        CaptainBattleship = 5221006,
        [FastEnumUtility.Label("CAPTAIN_BATTLESHIP_D", 0)]
        [FastEnumUtility.Label("Captain Battleship D", 1)]
        CaptainBattleshipD = 5221999,
        [FastEnumUtility.Label("CAPTAIN_BATTLESHIP_CANNON", 0)]
        [FastEnumUtility.Label("Captain Battleship Cannon", 1)]
        CaptainBattleshipCannon = 5221007,
        [FastEnumUtility.Label("CAPTAIN_BATTLESHIP_TORPEDO", 0)]
        [FastEnumUtility.Label("Captain Battleship Torpedo", 1)]
        CaptainBattleshipTorpedo = 5221008,
        [FastEnumUtility.Label("CAPTAIN_MIND_CONTROL", 0)]
        [FastEnumUtility.Label("Captain Mind Control", 1)]
        CaptainMindControl = 5221009,
        [FastEnumUtility.Label("CAPTAIN_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Captain Heros Will", 1)]
        CaptainHerosWill = 5221010,
        [FastEnumUtility.Label("CAPTAIN_ADVANCED_HOMING", 0)]
        [FastEnumUtility.Label("Captain Advanced Homing", 1)]
        CaptainAdvancedHoming = 5220011,
        [FastEnumUtility.Label("CAPTAIN_COUNTER_ATTACK", 0)]
        [FastEnumUtility.Label("Captain Counter Attack", 1)]
        CaptainCounterAttack = 5220012,
        [FastEnumUtility.Label("MANAGER_ANTIMACRO", 0)]
        [FastEnumUtility.Label("Manager Antimacro", 1)]
        ManagerAntimacro = 8001000,
        [FastEnumUtility.Label("MANAGER_TELEPORT", 0)]
        [FastEnumUtility.Label("Manager Teleport", 1)]
        ManagerTeleport = 8001001,
        [FastEnumUtility.Label("ADMIN_HASTE", 0)]
        [FastEnumUtility.Label("Admin Haste", 1)]
        AdminHaste = 9001000,
        [FastEnumUtility.Label("ADMIN_DRAGON_ROAR", 0)]
        [FastEnumUtility.Label("Admin Dragon Roar", 1)]
        AdminDragonRoar = 9001001,
        [FastEnumUtility.Label("ADMIN_TELEPORT", 0)]
        [FastEnumUtility.Label("Admin Teleport", 1)]
        AdminTeleport = 9001002,
        [FastEnumUtility.Label("ADMIN_DISPEL", 0)]
        [FastEnumUtility.Label("Admin Dispel", 1)]
        AdminDispel = 9101000,
        [FastEnumUtility.Label("ADMIN_SUPER_HASTE", 0)]
        [FastEnumUtility.Label("Admin Super Haste", 1)]
        AdminSuperHaste = 9101001,
        [FastEnumUtility.Label("ADMIN_HOLY_SYMBOL", 0)]
        [FastEnumUtility.Label("Admin Holy Symbol", 1)]
        AdminHolySymbol = 9101002,
        [FastEnumUtility.Label("ADMIN_BLESS", 0)]
        [FastEnumUtility.Label("Admin Bless", 1)]
        AdminBless = 9101003,
        [FastEnumUtility.Label("ADMIN_HIDE", 0)]
        [FastEnumUtility.Label("Admin Hide", 1)]
        AdminHide = 9101004,
        [FastEnumUtility.Label("ADMIN_RESURRECTION", 0)]
        [FastEnumUtility.Label("Admin Resurrection", 1)]
        AdminResurrection = 9101005,
        [FastEnumUtility.Label("ADMIN_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Admin Hyper Body", 1)]
        AdminHyperBody = 9101008,
        [FastEnumUtility.Label("ADMIN_ANTIMACRO", 0)]
        [FastEnumUtility.Label("Admin Antimacro", 1)]
        AdminAntimacro = 9001009,
        [FastEnumUtility.Label("NOBLESSE_THROW_SNAIL", 0)]
        [FastEnumUtility.Label("Noblesse Throw Snail", 1)]
        NoblesseThrowSnail = 10001000,
        [FastEnumUtility.Label("NOBLESSE_REGENERATION", 0)]
        [FastEnumUtility.Label("Noblesse Regeneration", 1)]
        NoblesseRegeneration = 10001001,
        [FastEnumUtility.Label("NOBLESSE_MOVING_WITH_ACTIVITY", 0)]
        [FastEnumUtility.Label("Noblesse Moving With Activity", 1)]
        NoblesseMovingWithActivity = 10001002,
        [FastEnumUtility.Label("NOBLESSE_SOUL_OF_CRAFTMAN", 0)]
        [FastEnumUtility.Label("Noblesse Soul Of Craftsman", 1)]
        NoblesseSoulOfCraftsman = 10001003,
        [FastEnumUtility.Label("NOBLESSE_MONSTER_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Monster Riding", 1)]
        NoblesseMonsterRiding = 10001004,
        [FastEnumUtility.Label("NOBLESSE_MAXLEVEL_ECHOBUFF", 0)]
        [FastEnumUtility.Label("Noblesse Max-Level Echo Buff", 1)]
        NoblesseMaxlevelEchobuff = 10001005,
        [FastEnumUtility.Label("NOBLESSE_DAMAGEMETER", 0)]
        [FastEnumUtility.Label("Noblesse Damage Meter", 1)]
        NoblesseDamagemeter = 10001006,
        [FastEnumUtility.Label("NOBLESSE_MAKER", 0)]
        [FastEnumUtility.Label("Noblesse Maker", 1)]
        NoblesseMaker = 10001007,
        [FastEnumUtility.Label("NOBLESSE_BAMBOO", 0)]
        [FastEnumUtility.Label("Noblesse Bamboo", 1)]
        NoblesseBamboo = 10001009,
        [FastEnumUtility.Label("NOBLESSE_INVINCIBLE", 0)]
        [FastEnumUtility.Label("Noblesse Invincible", 1)]
        NoblesseInvincible = 10001010,
        [FastEnumUtility.Label("NOBLESSE_BERSERK", 0)]
        [FastEnumUtility.Label("Noblesse Berserk", 1)]
        NoblesseBerserk = 10001011,
        [FastEnumUtility.Label("NOBLESSE_BLESS_OF_NYMPH", 0)]
        [FastEnumUtility.Label("Noblesse Bless Of Nymph", 1)]
        NoblesseBlessOfNymph = 10000012,
        [FastEnumUtility.Label("NOBLESSE_TUTOR", 0)]
        [FastEnumUtility.Label("Noblesse Tutor", 1)]
        NoblesseTutor = 10001013,
        [FastEnumUtility.Label("DISABLE_NOBLESSE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Noblesse Event Riding", 1)]
        DisableNoblesseEventRiding = 10001014,
        [FastEnumUtility.Label("DISABLE_NOBLESSE_EVENT_RIDING_DASH", 0)]
        [FastEnumUtility.Label("Disable Noblesse Event Riding Dash", 1)]
        DisableNoblesseEventRidingDash = 10001015,
        [FastEnumUtility.Label("DISABLE_NOBLESSE_EVENT_RIDING_REACTOR", 0)]
        [FastEnumUtility.Label("Disable Noblesse Event Riding Reactor", 1)]
        DisableNoblesseEventRidingReactor = 10001016,
        [FastEnumUtility.Label("NOBLESSE_MULTI_PET", 0)]
        [FastEnumUtility.Label("Noblesse Multi Pet", 1)]
        NoblesseMultiPet = 10000018,
        [FastEnumUtility.Label("DISABLE_NOBLESSE_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Noblesse Yeti Event Riding", 1)]
        DisableNoblesseYetiEventRiding = 10001019,
        [FastEnumUtility.Label("NOBLESSE_MASSACRE", 0)]
        [FastEnumUtility.Label("Noblesse Massacre", 1)]
        NoblesseMassacre = 10001020,
        [FastEnumUtility.Label("DISABLE_NOBLESSE_YETI_EVENT_RIDING2", 0)]
        [FastEnumUtility.Label("Disable Noblesse Yeti Event Riding2", 1)]
        DisableNoblesseYetiEventRiding2 = 10001022,
        [FastEnumUtility.Label("DISABLE_NOBLESSE_BROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Noblesse Broom Event Riding", 1)]
        DisableNoblesseBroomEventRiding = 10001023,
        [FastEnumUtility.Label("NOBLESSE_WOODENHORSE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Wooden Horse Event Riding", 1)]
        NoblesseWoodenhorseEventRiding = 10001025,
        [FastEnumUtility.Label("NOBLESSE_FLYING_SKILL", 0)]
        [FastEnumUtility.Label("Noblesse Flying Skill", 1)]
        NoblesseFlyingSkill = 10001026,
        [FastEnumUtility.Label("NOBLESSE_KROKO_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Kroko Event Riding", 1)]
        NoblesseKrokoEventRiding = 10001027,
        [FastEnumUtility.Label("NOBLESSE_NAKED_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Naked Event Riding", 1)]
        NoblesseNakedEventRiding = 10001028,
        [FastEnumUtility.Label("NOBLESSE_PINK_SCOOTER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Pink Scooter Event Riding", 1)]
        NoblessePinkScooterEventRiding = 10001029,
        [FastEnumUtility.Label("NOBLESSE_FLYING_CLOUD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Flying Cloud Event Riding", 1)]
        NoblesseFlyingCloudEventRiding = 10001030,
        [FastEnumUtility.Label("NOBLESSE_BALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Balrog Event Riding", 1)]
        NoblesseBalrogEventRiding = 10001031,
        [FastEnumUtility.Label("NOBLESSE_KART_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Kart Event Riding", 1)]
        NoblesseKartEventRiding = 10001033,
        [FastEnumUtility.Label("NOBLESSE_ZD_TIGER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Zd Tiger Event Riding", 1)]
        NoblesseZdTigerEventRiding = 10001034,
        [FastEnumUtility.Label("NOBLESSE_MISTBALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Mistbalrog Event Riding", 1)]
        NoblesseMistbalrogEventRiding = 10001035,
        [FastEnumUtility.Label("NOBLESSE_LIONS_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Lions Event Riding", 1)]
        NoblesseLionsEventRiding = 10001036,
        [FastEnumUtility.Label("NOBLESSE_UNICORN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Unicorn Event Riding", 1)]
        NoblesseUnicornEventRiding = 10001037,
        [FastEnumUtility.Label("NOBLESSE_LOWRIDER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Lowrider Event Riding", 1)]
        NoblesseLowriderEventRiding = 10001038,
        [FastEnumUtility.Label("NOBLESSE_REDTRUCK_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Redtruck Event Riding", 1)]
        NoblesseRedtruckEventRiding = 10001039,
        [FastEnumUtility.Label("NOBLESSE_GARGOYLES_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Gargoyles Event Riding", 1)]
        NoblesseGargoylesEventRiding = 10001040,
        [FastEnumUtility.Label("NOBLESSE_SPACE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Space Event Riding", 1)]
        NoblesseSpaceEventRiding = 10001046,
        [FastEnumUtility.Label("NOBLESSE_SPACE_EVENT_RIDING_DASH", 0)]
        [FastEnumUtility.Label("Noblesse Space Event Riding Dash", 1)]
        NoblesseSpaceEventRidingDash = 10001047,
        [FastEnumUtility.Label("NOBLESSE_SPACE_EVENT_RIDING_REACTOR", 0)]
        [FastEnumUtility.Label("Noblesse Space Event Riding Reactor", 1)]
        NoblesseSpaceEventRidingReactor = 10001048,
        [FastEnumUtility.Label("NOBLESSE_CHICKEN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Chicken Event Riding", 1)]
        NoblesseChickenEventRiding = 10001054,
        [FastEnumUtility.Label("NOBLESSE_HOLLY_BIRD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Holly Bird Event Riding", 1)]
        NoblesseHollyBirdEventRiding = 10001042,
        [FastEnumUtility.Label("NOBLESSE_ORANGE_MUSHROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Orange Mushroom Event Riding", 1)]
        NoblesseOrangeMushroomEventRiding = 10001044,
        [FastEnumUtility.Label("NOBLESSE_NIGHTMARE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Nightmare Event Riding", 1)]
        NoblesseNightmareEventRiding = 10001049,
        [FastEnumUtility.Label("NOBLESSE_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Yeti Event Riding", 1)]
        NoblesseYetiEventRiding = 10001050,
        [FastEnumUtility.Label("NOBLESSE_OSTRICH_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Ostrich Event Riding", 1)]
        NoblesseOstrichEventRiding = 10001051,
        [FastEnumUtility.Label("NOBLESSE_BEAR_BALOON_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Bear Baloon Event Riding", 1)]
        NoblesseBearBaloonEventRiding = 10001052,
        [FastEnumUtility.Label("NOBLESSE_TRANS_ROBOT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Trans Robot Event Riding", 1)]
        NoblesseTransRobotEventRiding = 10001053,
        [FastEnumUtility.Label("NOBLESSE_MOTORBIKE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Motorbike Event Riding", 1)]
        NoblesseMotorbikeEventRiding = 10001063,
        [FastEnumUtility.Label("NOBLESSE_POWERED_SUIT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Noblesse Powered Suit Event Riding", 1)]
        NoblessePoweredSuitEventRiding = 10001064,
        [FastEnumUtility.Label("NOBLESSE_HASTE", 0)]
        [FastEnumUtility.Label("Noblesse Haste", 1)]
        NoblesseHaste = 10008000,
        [FastEnumUtility.Label("NOBLESSE_MYSTIC_DOOR", 0)]
        [FastEnumUtility.Label("Noblesse Mystic Door", 1)]
        NoblesseMysticDoor = 10008001,
        [FastEnumUtility.Label("NOBLESSE_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Noblesse Sharp Eyes", 1)]
        NoblesseSharpEyes = 10008002,
        [FastEnumUtility.Label("NOBLESSE_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Noblesse Hyper Body", 1)]
        NoblesseHyperBody = 10008003,
        [FastEnumUtility.Label("STRIKER_QUICKMOTION", 0)]
        [FastEnumUtility.Label("Striker Quickmotion", 1)]
        StrikerQuickmotion = 15000000,
        [FastEnumUtility.Label("STRIKER_STRAIGHT", 0)]
        [FastEnumUtility.Label("Striker Straight", 1)]
        StrikerStraight = 15001001,
        [FastEnumUtility.Label("STRIKER_SOMERSAULT", 0)]
        [FastEnumUtility.Label("Striker Somersault", 1)]
        StrikerSomersault = 15001002,
        [FastEnumUtility.Label("STRIKER_DASH", 0)]
        [FastEnumUtility.Label("Striker Dash", 1)]
        StrikerDash = 15001003,
        [FastEnumUtility.Label("STRIKER_LIGHTNING", 0)]
        [FastEnumUtility.Label("Striker Lightning", 1)]
        StrikerLightning = 15001004,
        [FastEnumUtility.Label("STRIKER_KNUCKLE_MASTERY", 0)]
        [FastEnumUtility.Label("Striker Knuckle Mastery", 1)]
        StrikerKnuckleMastery = 15100001,
        [FastEnumUtility.Label("STRIKER_KNUCKLE_BOOSTER", 0)]
        [FastEnumUtility.Label("Striker Knuckle Booster", 1)]
        StrikerKnuckleBooster = 15101002,
        [FastEnumUtility.Label("STRIKER_SCREW_PUNCH", 0)]
        [FastEnumUtility.Label("Striker Screw Punch", 1)]
        StrikerScrewPunch = 15101003,
        [FastEnumUtility.Label("STRIKER_ENERGY_CHARGE", 0)]
        [FastEnumUtility.Label("Striker Energy Charge", 1)]
        StrikerEnergyCharge = 15100004,
        [FastEnumUtility.Label("STRIKER_ENERGY_BURSTER", 0)]
        [FastEnumUtility.Label("Striker Energy Burster", 1)]
        StrikerEnergyBurster = 15101005,
        [FastEnumUtility.Label("STRIKER_LIGHTNING_CHARGE", 0)]
        [FastEnumUtility.Label("Striker Lightning Charge", 1)]
        StrikerLightningCharge = 15101006,
        [FastEnumUtility.Label("STRIKER_MHP_INC", 0)]
        [FastEnumUtility.Label("Striker Max HP Inc", 1)]
        StrikerMhpInc = 15100007,
        [FastEnumUtility.Label("STRIKER_CRITICAL_PUNCH", 0)]
        [FastEnumUtility.Label("Striker Critical Punch", 1)]
        StrikerCriticalPunch = 15110000,
        [FastEnumUtility.Label("STRIKER_ENERGY_DRAIN", 0)]
        [FastEnumUtility.Label("Striker Energy Drain", 1)]
        StrikerEnergyDrain = 15111001,
        [FastEnumUtility.Label("STRIKER_TRANSFORM", 0)]
        [FastEnumUtility.Label("Striker Transform", 1)]
        StrikerTransform = 15111002,
        [FastEnumUtility.Label("STRIKER_SHOCKWAVE", 0)]
        [FastEnumUtility.Label("Striker Shockwave", 1)]
        StrikerShockwave = 15111003,
        [FastEnumUtility.Label("STRIKER_FIST", 0)]
        [FastEnumUtility.Label("Striker Fist", 1)]
        StrikerFist = 15111004,
        [FastEnumUtility.Label("STRIKER_WIND_BOOSTER", 0)]
        [FastEnumUtility.Label("Striker Wind Booster", 1)]
        StrikerWindBooster = 15111005,
        [FastEnumUtility.Label("STRIKER_SPARK", 0)]
        [FastEnumUtility.Label("Striker Spark", 1)]
        StrikerSpark = 15111006,
        [FastEnumUtility.Label("STRIKER_SHARK_WAVE", 0)]
        [FastEnumUtility.Label("Striker Shark Wave", 1)]
        StrikerSharkWave = 15111007,
        [FastEnumUtility.Label("SOULMASTER_IRON_BODY", 0)]
        [FastEnumUtility.Label("Soulmaster Iron Body", 1)]
        SoulmasterIronBody = 11001001,
        [FastEnumUtility.Label("SOULMASTER_POWER_STRIKE", 0)]
        [FastEnumUtility.Label("Soulmaster Power Strike", 1)]
        SoulmasterPowerStrike = 11001002,
        [FastEnumUtility.Label("SOULMASTER_SLASH_BLAST", 0)]
        [FastEnumUtility.Label("Soulmaster Slash Blast", 1)]
        SoulmasterSlashBlast = 11001003,
        [FastEnumUtility.Label("SOULMASTER_SOUL", 0)]
        [FastEnumUtility.Label("Soulmaster Soul", 1)]
        SoulmasterSoul = 11001004,
        [FastEnumUtility.Label("SOULMASTER_MHP_INC", 0)]
        [FastEnumUtility.Label("Soulmaster Max HP Inc", 1)]
        SoulmasterMhpInc = 11000005,
        [FastEnumUtility.Label("SOULMASTER_SWORD_MASTERY", 0)]
        [FastEnumUtility.Label("Soulmaster Sword Mastery", 1)]
        SoulmasterSwordMastery = 11100000,
        [FastEnumUtility.Label("SOULMASTER_SWORD_BOOSTER", 0)]
        [FastEnumUtility.Label("Soulmaster Sword Booster", 1)]
        SoulmasterSwordBooster = 11101001,
        [FastEnumUtility.Label("SOULMASTER_FINAL_ATTACK_SWORD", 0)]
        [FastEnumUtility.Label("Soulmaster Final Attack Sword", 1)]
        SoulmasterFinalAttackSword = 11101002,
        [FastEnumUtility.Label("SOULMASTER_FURY", 0)]
        [FastEnumUtility.Label("Soulmaster Fury", 1)]
        SoulmasterFury = 11101003,
        [FastEnumUtility.Label("SOULMASTER_SOUL_BLADE", 0)]
        [FastEnumUtility.Label("Soulmaster Soul Blade", 1)]
        SoulmasterSoulBlade = 11101004,
        [FastEnumUtility.Label("SOULMASTER_SOUL_RUSH", 0)]
        [FastEnumUtility.Label("Soulmaster Soul Rush", 1)]
        SoulmasterSoulRush = 11101005,
        [FastEnumUtility.Label("SOULMASTER_UPGRADE_MP_RECOVERY", 0)]
        [FastEnumUtility.Label("Soulmaster Upgrade Mp Recovery", 1)]
        SoulmasterUpgradeMpRecovery = 11110000,
        [FastEnumUtility.Label("SOULMASTER_COMBO_ATTACK", 0)]
        [FastEnumUtility.Label("Soulmaster Combo Attack", 1)]
        SoulmasterComboAttack = 11111001,
        [FastEnumUtility.Label("SOULMASTER_PANIC_SWORD", 0)]
        [FastEnumUtility.Label("Soulmaster Panic Sword", 1)]
        SoulmasterPanicSword = 11111002,
        [FastEnumUtility.Label("SOULMASTER_COMA_SWORD", 0)]
        [FastEnumUtility.Label("Soulmaster Coma Sword", 1)]
        SoulmasterComaSword = 11111003,
        [FastEnumUtility.Label("SOULMASTER_BRANDISH", 0)]
        [FastEnumUtility.Label("Soulmaster Brandish", 1)]
        SoulmasterBrandish = 11111004,
        [FastEnumUtility.Label("SOULMASTER_ADVANCED_COMBO", 0)]
        [FastEnumUtility.Label("Soulmaster Advanced Combo", 1)]
        SoulmasterAdvancedCombo = 11110005,
        [FastEnumUtility.Label("SOULMASTER_SOUL_DRIVER", 0)]
        [FastEnumUtility.Label("Soulmaster Soul Driver", 1)]
        SoulmasterSoulDriver = 11111006,
        [FastEnumUtility.Label("SOULMASTER_SOUL_CHARGE", 0)]
        [FastEnumUtility.Label("Soulmaster Soul Charge", 1)]
        SoulmasterSoulCharge = 11111007,
        [FastEnumUtility.Label("FLAMEWIZARD_MAGIC_GUARD", 0)]
        [FastEnumUtility.Label("Flamewizard Magic Guard", 1)]
        FlamewizardMagicGuard = 12001001,
        [FastEnumUtility.Label("FLAMEWIZARD_MAGIC_ARMOR", 0)]
        [FastEnumUtility.Label("Flamewizard Magic Armor", 1)]
        FlamewizardMagicArmor = 12001002,
        [FastEnumUtility.Label("FLAMEWIZARD_MAGIC_CLAW", 0)]
        [FastEnumUtility.Label("Flamewizard Magic Claw", 1)]
        FlamewizardMagicClaw = 12001003,
        [FastEnumUtility.Label("FLAMEWIZARD_FLAME", 0)]
        [FastEnumUtility.Label("Flamewizard Flame", 1)]
        FlamewizardFlame = 12001004,
        [FastEnumUtility.Label("FLAMEWIZARD_MMP_INC", 0)]
        [FastEnumUtility.Label("Flamewizard Max MP Inc", 1)]
        FlamewizardMmpInc = 12000005,
        [FastEnumUtility.Label("FLAMEWIZARD_MEDITATION", 0)]
        [FastEnumUtility.Label("Flamewizard Meditation", 1)]
        FlamewizardMeditation = 12101000,
        [FastEnumUtility.Label("FLAMEWIZARD_SLOW", 0)]
        [FastEnumUtility.Label("Flamewizard Slow", 1)]
        FlamewizardSlow = 12101001,
        [FastEnumUtility.Label("FLAMEWIZARD_FIRE_ARROW", 0)]
        [FastEnumUtility.Label("Flamewizard Fire Arrow", 1)]
        FlamewizardFireArrow = 12101002,
        [FastEnumUtility.Label("FLAMEWIZARD_TELEPORT", 0)]
        [FastEnumUtility.Label("Flamewizard Teleport", 1)]
        FlamewizardTeleport = 12101003,
        [FastEnumUtility.Label("FLAMEWIZARD_MAGIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Flamewizard Magic Booster", 1)]
        FlamewizardMagicBooster = 12101004,
        [FastEnumUtility.Label("FLAMEWIZARD_ELEMENTAL_RESET", 0)]
        [FastEnumUtility.Label("Flamewizard Elemental Reset", 1)]
        FlamewizardElementalReset = 12101005,
        [FastEnumUtility.Label("FLAMEWIZARD_FIRE_PILLAR", 0)]
        [FastEnumUtility.Label("Flamewizard Fire Pillar", 1)]
        FlamewizardFirePillar = 12101006,
        [FastEnumUtility.Label("FLAMEWIZARD_SPELL_MASTERY", 0)]
        [FastEnumUtility.Label("Flamewizard Spell Mastery", 1)]
        FlamewizardSpellMastery = 12100007,
        [FastEnumUtility.Label("FLAMEWIZARD_ELEMENT_RESISTANCE", 0)]
        [FastEnumUtility.Label("Flamewizard Element Resistance", 1)]
        FlamewizardElementResistance = 12110000,
        [FastEnumUtility.Label("FLAMEWIZARD_ELEMENT_AMPLIFICATION", 0)]
        [FastEnumUtility.Label("Flamewizard Element Amplification", 1)]
        FlamewizardElementAmplification = 12110001,
        [FastEnumUtility.Label("FLAMEWIZARD_SEAL", 0)]
        [FastEnumUtility.Label("Flamewizard Seal", 1)]
        FlamewizardSeal = 12111002,
        [FastEnumUtility.Label("FLAMEWIZARD_METEOR", 0)]
        [FastEnumUtility.Label("Flamewizard Meteor", 1)]
        FlamewizardMeteor = 12111003,
        [FastEnumUtility.Label("FLAMEWIZARD_IFRIT", 0)]
        [FastEnumUtility.Label("Flamewizard Ifrit", 1)]
        FlamewizardIfrit = 12111004,
        [FastEnumUtility.Label("FLAMEWIZARD_FLAME_GEAR", 0)]
        [FastEnumUtility.Label("Flamewizard Flame Gear", 1)]
        FlamewizardFlameGear = 12111005,
        [FastEnumUtility.Label("FLAMEWIZARD_FIRE_STRIKE", 0)]
        [FastEnumUtility.Label("Flamewizard Fire Strike", 1)]
        FlamewizardFireStrike = 12111006,
        [FastEnumUtility.Label("WINDBREAKER_CRITICAL_SHOT", 0)]
        [FastEnumUtility.Label("Windbreaker Critical Shot", 1)]
        WindbreakerCriticalShot = 13000000,
        [FastEnumUtility.Label("WINDBREAKER_AMAZON_EYE", 0)]
        [FastEnumUtility.Label("Windbreaker Amazon Eye", 1)]
        WindbreakerAmazonEye = 13000001,
        [FastEnumUtility.Label("WINDBREAKER_FOCUS", 0)]
        [FastEnumUtility.Label("Windbreaker Focus", 1)]
        WindbreakerFocus = 13001002,
        [FastEnumUtility.Label("WINDBREAKER_DOUBLE_SHOT", 0)]
        [FastEnumUtility.Label("Windbreaker Double Shot", 1)]
        WindbreakerDoubleShot = 13001003,
        [FastEnumUtility.Label("WINDBREAKER_STORM", 0)]
        [FastEnumUtility.Label("Windbreaker Storm", 1)]
        WindbreakerStorm = 13001004,
        [FastEnumUtility.Label("WINDBREAKER_BOW_MASTERY", 0)]
        [FastEnumUtility.Label("Windbreaker Bow Mastery", 1)]
        WindbreakerBowMastery = 13100000,
        [FastEnumUtility.Label("WINDBREAKER_BOW_BOOSTER", 0)]
        [FastEnumUtility.Label("Windbreaker Bow Booster", 1)]
        WindbreakerBowBooster = 13101001,
        [FastEnumUtility.Label("WINDBREAKER_FINAL_ATTACK_BOW", 0)]
        [FastEnumUtility.Label("Windbreaker Final Attack Bow", 1)]
        WindbreakerFinalAttackBow = 13101002,
        [FastEnumUtility.Label("WINDBREAKER_SOUL_ARROW_BOW", 0)]
        [FastEnumUtility.Label("Windbreaker Soul Arrow Bow", 1)]
        WindbreakerSoulArrowBow = 13101003,
        [FastEnumUtility.Label("WINDBREAKER_THRUST", 0)]
        [FastEnumUtility.Label("Windbreaker Thrust", 1)]
        WindbreakerThrust = 13100004,
        [FastEnumUtility.Label("WINDBREAKER_STORM_BREAK", 0)]
        [FastEnumUtility.Label("Windbreaker Storm Break", 1)]
        WindbreakerStormBreak = 13101005,
        [FastEnumUtility.Label("WINDBREAKER_WIND_WALK", 0)]
        [FastEnumUtility.Label("Windbreaker Wind Walk", 1)]
        WindbreakerWindWalk = 13101006,
        [FastEnumUtility.Label("WINDBREAKER_ARROW_RAIN", 0)]
        [FastEnumUtility.Label("Windbreaker Arrow Rain", 1)]
        WindbreakerArrowRain = 13111000,
        [FastEnumUtility.Label("WINDBREAKER_STRAFE", 0)]
        [FastEnumUtility.Label("Windbreaker Strafe", 1)]
        WindbreakerStrafe = 13111001,
        [FastEnumUtility.Label("WINDBREAKER_STORM_ARROW", 0)]
        [FastEnumUtility.Label("Windbreaker Storm Arrow", 1)]
        WindbreakerStormArrow = 13111002,
        [FastEnumUtility.Label("WINDBREAKER_BOW_EXPERT", 0)]
        [FastEnumUtility.Label("Windbreaker Bow Expert", 1)]
        WindbreakerBowExpert = 13110003,
        [FastEnumUtility.Label("WINDBREAKER_PUPPET", 0)]
        [FastEnumUtility.Label("Windbreaker Puppet", 1)]
        WindbreakerPuppet = 13111004,
        [FastEnumUtility.Label("WINDBREAKER_ALBATROSS", 0)]
        [FastEnumUtility.Label("Windbreaker Albatross", 1)]
        WindbreakerAlbatross = 13111005,
        [FastEnumUtility.Label("WINDBREAKER_WIND_SPEAR", 0)]
        [FastEnumUtility.Label("Windbreaker Wind Spear", 1)]
        WindbreakerWindSpear = 13111006,
        [FastEnumUtility.Label("WINDBREAKER_WIND_SHOT", 0)]
        [FastEnumUtility.Label("Windbreaker Wind Shot", 1)]
        WindbreakerWindShot = 13111007,
        [FastEnumUtility.Label("NIGHTWALKER_NIMBLE_BODY", 0)]
        [FastEnumUtility.Label("Nightwalker Nimble Body", 1)]
        NightwalkerNimbleBody = 14000000,
        [FastEnumUtility.Label("NIGHTWALKER_KEEN_EYES", 0)]
        [FastEnumUtility.Label("Nightwalker Keen Eyes", 1)]
        NightwalkerKeenEyes = 14000001,
        [FastEnumUtility.Label("NIGHTWALKER_DISORDER", 0)]
        [FastEnumUtility.Label("Nightwalker Disorder", 1)]
        NightwalkerDisorder = 14001002,
        [FastEnumUtility.Label("NIGHTWALKER_DARK_SIGHT", 0)]
        [FastEnumUtility.Label("Nightwalker Dark Sight", 1)]
        NightwalkerDarkSight = 14001003,
        [FastEnumUtility.Label("NIGHTWALKER_LUCKY_SEVEN", 0)]
        [FastEnumUtility.Label("Nightwalker Lucky Seven", 1)]
        NightwalkerLuckySeven = 14001004,
        [FastEnumUtility.Label("NIGHTWALKER_DARKNESS", 0)]
        [FastEnumUtility.Label("Nightwalker Darkness", 1)]
        NightwalkerDarkness = 14001005,
        [FastEnumUtility.Label("NIGHTWALKER_JAVELIN_MASTERY", 0)]
        [FastEnumUtility.Label("Nightwalker Javelin Mastery", 1)]
        NightwalkerJavelinMastery = 14100000,
        [FastEnumUtility.Label("NIGHTWALKER_CRITICAL_THROW", 0)]
        [FastEnumUtility.Label("Nightwalker Critical Throw", 1)]
        NightwalkerCriticalThrow = 14100001,
        [FastEnumUtility.Label("NIGHTWALKER_JAVELIN_BOOSTER", 0)]
        [FastEnumUtility.Label("Nightwalker Javelin Booster", 1)]
        NightwalkerJavelinBooster = 14101002,
        [FastEnumUtility.Label("NIGHTWALKER_HASTE", 0)]
        [FastEnumUtility.Label("Nightwalker Haste", 1)]
        NightwalkerHaste = 14101003,
        [FastEnumUtility.Label("NIGHTWALKER_FLASH_JUMP", 0)]
        [FastEnumUtility.Label("Nightwalker Flash Jump", 1)]
        NightwalkerFlashJump = 14101004,
        [FastEnumUtility.Label("NIGHTWALKER_VANISH", 0)]
        [FastEnumUtility.Label("Nightwalker Vanish", 1)]
        NightwalkerVanish = 14100005,
        [FastEnumUtility.Label("NIGHTWALKER_VAMPIRE", 0)]
        [FastEnumUtility.Label("Nightwalker Vampire", 1)]
        NightwalkerVampire = 14101006,
        [FastEnumUtility.Label("NIGHTWALKER_SHADOW_PARTNER", 0)]
        [FastEnumUtility.Label("Nightwalker Shadow Partner", 1)]
        NightwalkerShadowPartner = 14111000,
        [FastEnumUtility.Label("NIGHTWALKER_SHADOW_WEB", 0)]
        [FastEnumUtility.Label("Nightwalker Shadow Web", 1)]
        NightwalkerShadowWeb = 14111001,
        [FastEnumUtility.Label("NIGHTWALKER_AVENGER", 0)]
        [FastEnumUtility.Label("Nightwalker Avenger", 1)]
        NightwalkerAvenger = 14111002,
        [FastEnumUtility.Label("NIGHTWALKER_ALCHEMIST", 0)]
        [FastEnumUtility.Label("Nightwalker Alchemist", 1)]
        NightwalkerAlchemist = 14110003,
        [FastEnumUtility.Label("NIGHTWALKER_VENOM", 0)]
        [FastEnumUtility.Label("Nightwalker Venom", 1)]
        NightwalkerVenom = 14110004,
        [FastEnumUtility.Label("NIGHTWALKER_TRIPLE_THROW", 0)]
        [FastEnumUtility.Label("Nightwalker Triple Throw", 1)]
        NightwalkerTripleThrow = 14111005,
        [FastEnumUtility.Label("NIGHTWALKER_POISON_BOMB", 0)]
        [FastEnumUtility.Label("Nightwalker Poison Bomb", 1)]
        NightwalkerPoisonBomb = 14111006,
        [FastEnumUtility.Label("LEGEND_THROW_SNAIL", 0)]
        [FastEnumUtility.Label("Legend Throw Snail", 1)]
        LegendThrowSnail = 20001000,
        [FastEnumUtility.Label("LEGEND_REGENERATION", 0)]
        [FastEnumUtility.Label("Legend Regeneration", 1)]
        LegendRegeneration = 20001001,
        [FastEnumUtility.Label("LEGEND_MOVING_WITH_ACTIVITY", 0)]
        [FastEnumUtility.Label("Legend Moving With Activity", 1)]
        LegendMovingWithActivity = 20001002,
        [FastEnumUtility.Label("LEGEND_SOUL_OF_CRAFTMAN", 0)]
        [FastEnumUtility.Label("Legend Soul Of Craftsman", 1)]
        LegendSoulOfCraftsman = 20001003,
        [FastEnumUtility.Label("LEGEND_MONSTER_RIDING", 0)]
        [FastEnumUtility.Label("Legend Monster Riding", 1)]
        LegendMonsterRiding = 20001004,
        [FastEnumUtility.Label("LEGEND_MAXLEVEL_ECHOBUFF", 0)]
        [FastEnumUtility.Label("Legend Max-Level Echo Buff", 1)]
        LegendMaxlevelEchobuff = 20001005,
        [FastEnumUtility.Label("LEGEND_DAMAGEMETER", 0)]
        [FastEnumUtility.Label("Legend Damage Meter", 1)]
        LegendDamagemeter = 20001006,
        [FastEnumUtility.Label("LEGEND_MAKER", 0)]
        [FastEnumUtility.Label("Legend Maker", 1)]
        LegendMaker = 20001007,
        [FastEnumUtility.Label("LEGEND_BAMBOO", 0)]
        [FastEnumUtility.Label("Legend Bamboo", 1)]
        LegendBamboo = 20001009,
        [FastEnumUtility.Label("LEGEND_INVINCIBLE", 0)]
        [FastEnumUtility.Label("Legend Invincible", 1)]
        LegendInvincible = 20001010,
        [FastEnumUtility.Label("LEGEND_BERSERK", 0)]
        [FastEnumUtility.Label("Legend Berserk", 1)]
        LegendBerserk = 20001011,
        [FastEnumUtility.Label("LEGEND_BLESS_OF_NYMPH", 0)]
        [FastEnumUtility.Label("Legend Bless Of Nymph", 1)]
        LegendBlessOfNymph = 20000012,
        [FastEnumUtility.Label("LEGEND_TUTOR", 0)]
        [FastEnumUtility.Label("Legend Tutor", 1)]
        LegendTutor = 20001013,
        [FastEnumUtility.Label("LEGEND_DOUBLE_SWING", 0)]
        [FastEnumUtility.Label("Legend Double Swing", 1)]
        LegendDoubleSwing = 20000014,
        [FastEnumUtility.Label("LEGEND_TRIPLE_SWING", 0)]
        [FastEnumUtility.Label("Legend Triple Swing", 1)]
        LegendTripleSwing = 20000015,
        [FastEnumUtility.Label("LEGEND_FINAL_BLOW", 0)]
        [FastEnumUtility.Label("Legend Final Blow", 1)]
        LegendFinalBlow = 20000016,
        [FastEnumUtility.Label("LEGEND_COMBO_ABILITY", 0)]
        [FastEnumUtility.Label("Legend Combo Ability", 1)]
        LegendComboAbility = 20000017,
        [FastEnumUtility.Label("LEGEND_COMBO_CRITICAL", 0)]
        [FastEnumUtility.Label("Legend Combo Critical", 1)]
        LegendComboCritical = 20000018,
        [FastEnumUtility.Label("DISABLE_LEGEND_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Legend Yeti Event Riding", 1)]
        DisableLegendYetiEventRiding = 20001019,
        [FastEnumUtility.Label("LEGEND_MASSACRE", 0)]
        [FastEnumUtility.Label("Legend Massacre", 1)]
        LegendMassacre = 20001020,
        [FastEnumUtility.Label("DISABLE_LEGEND_YETI_EVENT_RIDING2", 0)]
        [FastEnumUtility.Label("Disable Legend Yeti Event Riding2", 1)]
        DisableLegendYetiEventRiding2 = 20001022,
        [FastEnumUtility.Label("DISABLE_LEGEND_BROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Legend Broom Event Riding", 1)]
        DisableLegendBroomEventRiding = 20001023,
        [FastEnumUtility.Label("LEGEND_MULTI_PET", 0)]
        [FastEnumUtility.Label("Legend Multi Pet", 1)]
        LegendMultiPet = 20000024,
        [FastEnumUtility.Label("LEGEND_WOODENHORSE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Wooden Horse Event Riding", 1)]
        LegendWoodenhorseEventRiding = 20001025,
        [FastEnumUtility.Label("LEGEND_FLYING_SKILL", 0)]
        [FastEnumUtility.Label("Legend Flying Skill", 1)]
        LegendFlyingSkill = 20001026,
        [FastEnumUtility.Label("LEGEND_KROKO_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Kroko Event Riding", 1)]
        LegendKrokoEventRiding = 20001027,
        [FastEnumUtility.Label("LEGEND_NAKED_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Naked Event Riding", 1)]
        LegendNakedEventRiding = 20001028,
        [FastEnumUtility.Label("LEGEND_PINK_SCOOTER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Pink Scooter Event Riding", 1)]
        LegendPinkScooterEventRiding = 20001029,
        [FastEnumUtility.Label("LEGEND_FLYING_CLOUD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Flying Cloud Event Riding", 1)]
        LegendFlyingCloudEventRiding = 20001030,
        [FastEnumUtility.Label("LEGEND_BALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Balrog Event Riding", 1)]
        LegendBalrogEventRiding = 20001031,
        [FastEnumUtility.Label("LEGEND_KART_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Kart Event Riding", 1)]
        LegendKartEventRiding = 20001033,
        [FastEnumUtility.Label("LEGEND_ZD_TIGER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Zd Tiger Event Riding", 1)]
        LegendZdTigerEventRiding = 20001034,
        [FastEnumUtility.Label("LEGEND_MISTBALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Mistbalrog Event Riding", 1)]
        LegendMistbalrogEventRiding = 20001035,
        [FastEnumUtility.Label("LEGEND_LIONS_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Lions Event Riding", 1)]
        LegendLionsEventRiding = 20001036,
        [FastEnumUtility.Label("LEGEND_UNICORN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Unicorn Event Riding", 1)]
        LegendUnicornEventRiding = 20001037,
        [FastEnumUtility.Label("LEGEND_LOWRIDER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Lowrider Event Riding", 1)]
        LegendLowriderEventRiding = 20001038,
        [FastEnumUtility.Label("LEGEND_REDTRUCK_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Redtruck Event Riding", 1)]
        LegendRedtruckEventRiding = 20001039,
        [FastEnumUtility.Label("LEGEND_GARGOYLES_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Gargoyles Event Riding", 1)]
        LegendGargoylesEventRiding = 20001040,
        [FastEnumUtility.Label("LEGEND_SPACE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Space Event Riding", 1)]
        LegendSpaceEventRiding = 20001046,
        [FastEnumUtility.Label("LEGEND_SPACE_EVENT_RIDING_DASH", 0)]
        [FastEnumUtility.Label("Legend Space Event Riding Dash", 1)]
        LegendSpaceEventRidingDash = 20001047,
        [FastEnumUtility.Label("LEGEND_SPACE_EVENT_RIDING_REACTOR", 0)]
        [FastEnumUtility.Label("Legend Space Event Riding Reactor", 1)]
        LegendSpaceEventRidingReactor = 20001048,
        [FastEnumUtility.Label("LEGEND_CHICKEN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Chicken Event Riding", 1)]
        LegendChickenEventRiding = 20001054,
        [FastEnumUtility.Label("LEGEND_HOLLY_BIRD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Holly Bird Event Riding", 1)]
        LegendHollyBirdEventRiding = 20001042,
        [FastEnumUtility.Label("LEGEND_ORANGE_MUSHROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Orange Mushroom Event Riding", 1)]
        LegendOrangeMushroomEventRiding = 20001044,
        [FastEnumUtility.Label("LEGEND_NIGHTMARE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Nightmare Event Riding", 1)]
        LegendNightmareEventRiding = 20001049,
        [FastEnumUtility.Label("LEGEND_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Yeti Event Riding", 1)]
        LegendYetiEventRiding = 20001050,
        [FastEnumUtility.Label("LEGEND_OSTRICH_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Ostrich Event Riding", 1)]
        LegendOstrichEventRiding = 20001051,
        [FastEnumUtility.Label("LEGEND_BEAR_BALOON_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Bear Baloon Event Riding", 1)]
        LegendBearBaloonEventRiding = 20001052,
        [FastEnumUtility.Label("LEGEND_TRANS_ROBOT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Trans Robot Event Riding", 1)]
        LegendTransRobotEventRiding = 20001053,
        [FastEnumUtility.Label("LEGEND_MOTORBIKE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Motorbike Event Riding", 1)]
        LegendMotorbikeEventRiding = 20001063,
        [FastEnumUtility.Label("LEGEND_POWERED_SUIT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Legend Powered Suit Event Riding", 1)]
        LegendPoweredSuitEventRiding = 20001064,
        [FastEnumUtility.Label("LEGEND_HASTE", 0)]
        [FastEnumUtility.Label("Legend Haste", 1)]
        LegendHaste = 20008000,
        [FastEnumUtility.Label("LEGEND_MYSTIC_DOOR", 0)]
        [FastEnumUtility.Label("Legend Mystic Door", 1)]
        LegendMysticDoor = 20008001,
        [FastEnumUtility.Label("LEGEND_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Legend Sharp Eyes", 1)]
        LegendSharpEyes = 20008002,
        [FastEnumUtility.Label("LEGEND_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Legend Hyper Body", 1)]
        LegendHyperBody = 20008003,
        [FastEnumUtility.Label("ARAN_COMBO_ABILITY", 0)]
        [FastEnumUtility.Label("Aran Combo Ability", 1)]
        AranComboAbility = 21000000,
        [FastEnumUtility.Label("ARAN_COMBAT_STEP", 0)]
        [FastEnumUtility.Label("Aran Combat Step", 1)]
        AranCombatStep = 21001001,
        [FastEnumUtility.Label("ARAN_DOUBLE_SWING", 0)]
        [FastEnumUtility.Label("Aran Double Swing", 1)]
        AranDoubleSwing = 21000002,
        [FastEnumUtility.Label("ARAN_POLEARM_BOOSTER", 0)]
        [FastEnumUtility.Label("Aran Polearm Booster", 1)]
        AranPolearmBooster = 21001003,
        [FastEnumUtility.Label("ARAN_POLEARM_MASTERY", 0)]
        [FastEnumUtility.Label("Aran Polearm Mastery", 1)]
        AranPolearmMastery = 21100000,
        [FastEnumUtility.Label("ARAN_TRIPLE_SWING", 0)]
        [FastEnumUtility.Label("Aran Triple Swing", 1)]
        AranTripleSwing = 21100001,
        [FastEnumUtility.Label("ARAN_FINAL_CHARGE", 0)]
        [FastEnumUtility.Label("Aran Final Charge", 1)]
        AranFinalCharge = 21100002,
        [FastEnumUtility.Label("ARAN_BODY_PRESSURE", 0)]
        [FastEnumUtility.Label("Aran Body Pressure", 1)]
        AranBodyPressure = 21101003,
        [FastEnumUtility.Label("ARAN_COMBO_SMASH", 0)]
        [FastEnumUtility.Label("Aran Combo Smash", 1)]
        AranComboSmash = 21100004,
        [FastEnumUtility.Label("ARAN_COMBO_DRAIN", 0)]
        [FastEnumUtility.Label("Aran Combo Drain", 1)]
        AranComboDrain = 21100005,
        [FastEnumUtility.Label("ARAN_COMBO_CRITICAL", 0)]
        [FastEnumUtility.Label("Aran Combo Critical", 1)]
        AranComboCritical = 21110000,
        [FastEnumUtility.Label("ARAN_SMART_KNOCKBACK", 0)]
        [FastEnumUtility.Label("Aran Smart Knockback", 1)]
        AranSmartKnockback = 21111001,
        [FastEnumUtility.Label("ARAN_FULL_SWING", 0)]
        [FastEnumUtility.Label("Aran Full Swing", 1)]
        AranFullSwing = 21110002,
        [FastEnumUtility.Label("ARAN_FINAL_TOSS", 0)]
        [FastEnumUtility.Label("Aran Final Toss", 1)]
        AranFinalToss = 21110003,
        [FastEnumUtility.Label("ARAN_COMBO_FENRIR", 0)]
        [FastEnumUtility.Label("Aran Combo Fenrir", 1)]
        AranComboFenrir = 21110004,
        [FastEnumUtility.Label("ARAN_SNOW_CHARGE", 0)]
        [FastEnumUtility.Label("Aran Snow Charge", 1)]
        AranSnowCharge = 21111005,
        [FastEnumUtility.Label("ARAN_ROLLING_SPIN", 0)]
        [FastEnumUtility.Label("Aran Rolling Spin", 1)]
        AranRollingSpin = 21110006,
        [FastEnumUtility.Label("ARAN_FULL_SWING_DS", 0)]
        [FastEnumUtility.Label("Aran Full Swing Ds", 1)]
        AranFullSwingDs = 21110007,
        [FastEnumUtility.Label("ARAN_FULL_SWING_TS", 0)]
        [FastEnumUtility.Label("Aran Full Swing Ts", 1)]
        AranFullSwingTs = 21110008,
        [FastEnumUtility.Label("ARAN_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Aran Maple Hero", 1)]
        AranMapleHero = 21121000,
        [FastEnumUtility.Label("ARAN_HIGH_MASTERY", 0)]
        [FastEnumUtility.Label("Aran High Mastery", 1)]
        AranHighMastery = 21120001,
        [FastEnumUtility.Label("ARAN_OVER_SWING", 0)]
        [FastEnumUtility.Label("Aran Over Swing", 1)]
        AranOverSwing = 21120002,
        [FastEnumUtility.Label("ARAN_FREEZE_STANDING", 0)]
        [FastEnumUtility.Label("Aran Freeze Standing", 1)]
        AranFreezeStanding = 21121003,
        [FastEnumUtility.Label("ARAN_HIGH_DEFENSE", 0)]
        [FastEnumUtility.Label("Aran High Defense", 1)]
        AranHighDefense = 21120004,
        [FastEnumUtility.Label("ARAN_FINAL_BLOW", 0)]
        [FastEnumUtility.Label("Aran Final Blow", 1)]
        AranFinalBlow = 21120005,
        [FastEnumUtility.Label("ARAN_COMBO_TEMPEST", 0)]
        [FastEnumUtility.Label("Aran Combo Tempest", 1)]
        AranComboTempest = 21120006,
        [FastEnumUtility.Label("ARAN_COMBO_BARRIER", 0)]
        [FastEnumUtility.Label("Aran Combo Barrier", 1)]
        AranComboBarrier = 21120007,
        [FastEnumUtility.Label("ARAN_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Aran Heros Will", 1)]
        AranHerosWill = 21121008,
        [FastEnumUtility.Label("ARAN_OVER_SWING_DS", 0)]
        [FastEnumUtility.Label("Aran Over Swing Ds", 1)]
        AranOverSwingDs = 21120009,
        [FastEnumUtility.Label("ARAN_OVER_SWING_TS", 0)]
        [FastEnumUtility.Label("Aran Over Swing Ts", 1)]
        AranOverSwingTs = 21120010,
        [FastEnumUtility.Label("EVANJR_THROW_SNAIL", 0)]
        [FastEnumUtility.Label("Evanjr Throw Snail", 1)]
        EvanjrThrowSnail = 20011000,
        [FastEnumUtility.Label("EVANJR_REGENERATION", 0)]
        [FastEnumUtility.Label("Evanjr Regeneration", 1)]
        EvanjrRegeneration = 20011001,
        [FastEnumUtility.Label("EVANJR_MOVING_WITH_ACTIVITY", 0)]
        [FastEnumUtility.Label("Evanjr Moving With Activity", 1)]
        EvanjrMovingWithActivity = 20011002,
        [FastEnumUtility.Label("EVANJR_SOUL_OF_CRAFTMAN", 0)]
        [FastEnumUtility.Label("Evanjr Soul Of Craftsman", 1)]
        EvanjrSoulOfCraftsman = 20011003,
        [FastEnumUtility.Label("EVANJR_MONSTER_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Monster Riding", 1)]
        EvanjrMonsterRiding = 20011004,
        [FastEnumUtility.Label("EVANJR_MAXLEVEL_ECHOBUFF", 0)]
        [FastEnumUtility.Label("Evanjr Max-Level Echo Buff", 1)]
        EvanjrMaxlevelEchobuff = 20011005,
        [FastEnumUtility.Label("EVANJR_DAMAGEMETER", 0)]
        [FastEnumUtility.Label("Evanjr Damage Meter", 1)]
        EvanjrDamagemeter = 20011006,
        [FastEnumUtility.Label("EVANJR_MAKER", 0)]
        [FastEnumUtility.Label("Evanjr Maker", 1)]
        EvanjrMaker = 20011007,
        [FastEnumUtility.Label("EVANJR_BAMBOO", 0)]
        [FastEnumUtility.Label("Evanjr Bamboo", 1)]
        EvanjrBamboo = 20011009,
        [FastEnumUtility.Label("EVANJR_INVINCIBLE", 0)]
        [FastEnumUtility.Label("Evanjr Invincible", 1)]
        EvanjrInvincible = 20011010,
        [FastEnumUtility.Label("EVANJR_BERSERK", 0)]
        [FastEnumUtility.Label("Evanjr Berserk", 1)]
        EvanjrBerserk = 20011011,
        [FastEnumUtility.Label("EVANJR_BLESS_OF_NYMPH", 0)]
        [FastEnumUtility.Label("Evanjr Bless Of Nymph", 1)]
        EvanjrBlessOfNymph = 20010012,
        [FastEnumUtility.Label("DISABLE_EVANJR_YETI_EVENT_RIDING2", 0)]
        [FastEnumUtility.Label("Disable Evanjr Yeti Event Riding2", 1)]
        DisableEvanjrYetiEventRiding2 = 20011018,
        [FastEnumUtility.Label("DISABLE_EVANJR_BROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Disable Evanjr Broom Event Riding", 1)]
        DisableEvanjrBroomEventRiding = 20011019,
        [FastEnumUtility.Label("EVANJR_MASSACRE", 0)]
        [FastEnumUtility.Label("Evanjr Massacre", 1)]
        EvanjrMassacre = 20011020,
        [FastEnumUtility.Label("EVANJR_MULTI_PET", 0)]
        [FastEnumUtility.Label("Evanjr Multi Pet", 1)]
        EvanjrMultiPet = 20011024,
        [FastEnumUtility.Label("EVANJR_WOODENHORSE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Wooden Horse Event Riding", 1)]
        EvanjrWoodenhorseEventRiding = 20011025,
        [FastEnumUtility.Label("EVANJR_FLYING_SKILL", 0)]
        [FastEnumUtility.Label("Evanjr Flying Skill", 1)]
        EvanjrFlyingSkill = 20011026,
        [FastEnumUtility.Label("EVANJR_KROKO_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Kroko Event Riding", 1)]
        EvanjrKrokoEventRiding = 20011027,
        [FastEnumUtility.Label("EVANJR_NAKED_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Naked Event Riding", 1)]
        EvanjrNakedEventRiding = 20011028,
        [FastEnumUtility.Label("EVANJR_PINK_SCOOTER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Pink Scooter Event Riding", 1)]
        EvanjrPinkScooterEventRiding = 20011029,
        [FastEnumUtility.Label("EVANJR_FLYING_CLOUD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Flying Cloud Event Riding", 1)]
        EvanjrFlyingCloudEventRiding = 20011030,
        [FastEnumUtility.Label("EVANJR_BALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Balrog Event Riding", 1)]
        EvanjrBalrogEventRiding = 20011031,
        [FastEnumUtility.Label("EVANJR_KART_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Kart Event Riding", 1)]
        EvanjrKartEventRiding = 20011033,
        [FastEnumUtility.Label("EVANJR_ZD_TIGER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Zd Tiger Event Riding", 1)]
        EvanjrZdTigerEventRiding = 20011034,
        [FastEnumUtility.Label("EVANJR_MISTBALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Mistbalrog Event Riding", 1)]
        EvanjrMistbalrogEventRiding = 20011035,
        [FastEnumUtility.Label("EVANJR_HOLLY_BIRD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Holly Bird Event Riding", 1)]
        EvanjrHollyBirdEventRiding = 20011042,
        [FastEnumUtility.Label("EVANJR_ORANGE_MUSHROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Orange Mushroom Event Riding", 1)]
        EvanjrOrangeMushroomEventRiding = 20011044,
        [FastEnumUtility.Label("EVANJR_NIGHTMARE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Nightmare Event Riding", 1)]
        EvanjrNightmareEventRiding = 20011049,
        [FastEnumUtility.Label("EVANJR_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Yeti Event Riding", 1)]
        EvanjrYetiEventRiding = 20011050,
        [FastEnumUtility.Label("EVANJR_OSTRICH_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Ostrich Event Riding", 1)]
        EvanjrOstrichEventRiding = 20011051,
        [FastEnumUtility.Label("EVANJR_BEAR_BALOON_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Bear Baloon Event Riding", 1)]
        EvanjrBearBaloonEventRiding = 20011052,
        [FastEnumUtility.Label("EVANJR_TRANS_ROBOT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Trans Robot Event Riding", 1)]
        EvanjrTransRobotEventRiding = 20011053,
        [FastEnumUtility.Label("EVANJR_MOTORBIKE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Motorbike Event Riding", 1)]
        EvanjrMotorbikeEventRiding = 20011063,
        [FastEnumUtility.Label("EVANJR_POWERED_SUIT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Powered Suit Event Riding", 1)]
        EvanjrPoweredSuitEventRiding = 20011064,
        [FastEnumUtility.Label("EVANJR_LIONS_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Lions Event Riding", 1)]
        EvanjrLionsEventRiding = 20011036,
        [FastEnumUtility.Label("EVANJR_UNICORN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Unicorn Event Riding", 1)]
        EvanjrUnicornEventRiding = 20011037,
        [FastEnumUtility.Label("EVANJR_LOWRIDER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Lowrider Event Riding", 1)]
        EvanjrLowriderEventRiding = 20011038,
        [FastEnumUtility.Label("EVANJR_REDTRUCK_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Redtruck Event Riding", 1)]
        EvanjrRedtruckEventRiding = 20011039,
        [FastEnumUtility.Label("EVANJR_GARGOYLES_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Gargoyles Event Riding", 1)]
        EvanjrGargoylesEventRiding = 20011040,
        [FastEnumUtility.Label("EVANJR_SPACE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Space Event Riding", 1)]
        EvanjrSpaceEventRiding = 20011046,
        [FastEnumUtility.Label("EVANJR_SPACE_EVENT_RIDING_DASH", 0)]
        [FastEnumUtility.Label("Evanjr Space Event Riding Dash", 1)]
        EvanjrSpaceEventRidingDash = 20011047,
        [FastEnumUtility.Label("EVANJR_SPACE_EVENT_RIDING_REACTOR", 0)]
        [FastEnumUtility.Label("Evanjr Space Event Riding Reactor", 1)]
        EvanjrSpaceEventRidingReactor = 20011048,
        [FastEnumUtility.Label("EVANJR_CHICKEN_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Evanjr Chicken Event Riding", 1)]
        EvanjrChickenEventRiding = 20011054,
        [FastEnumUtility.Label("EVANJR_HASTE", 0)]
        [FastEnumUtility.Label("Evanjr Haste", 1)]
        EvanjrHaste = 20018000,
        [FastEnumUtility.Label("EVANJR_MYSTIC_DOOR", 0)]
        [FastEnumUtility.Label("Evanjr Mystic Door", 1)]
        EvanjrMysticDoor = 20018001,
        [FastEnumUtility.Label("EVANJR_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Evanjr Sharp Eyes", 1)]
        EvanjrSharpEyes = 20018002,
        [FastEnumUtility.Label("EVANJR_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Evanjr Hyper Body", 1)]
        EvanjrHyperBody = 20018003,
        [FastEnumUtility.Label("EVAN_DRAGON_SOUL", 0)]
        [FastEnumUtility.Label("Evan Dragon Soul", 1)]
        EvanDragonSoul = 22000000,
        [FastEnumUtility.Label("EVAN_MAGIC_MISSILE", 0)]
        [FastEnumUtility.Label("Evan Magic Missile", 1)]
        EvanMagicMissile = 22001001,
        [FastEnumUtility.Label("EVAN_FIRECIRCLE", 0)]
        [FastEnumUtility.Label("Evan Firecircle", 1)]
        EvanFirecircle = 22101000,
        [FastEnumUtility.Label("EVAN_TELEPORT", 0)]
        [FastEnumUtility.Label("Evan Teleport", 1)]
        EvanTeleport = 22101001,
        [FastEnumUtility.Label("EVAN_LIGHTING_BOLT", 0)]
        [FastEnumUtility.Label("Evan Lighting Bolt", 1)]
        EvanLightingBolt = 22111000,
        [FastEnumUtility.Label("EVAN_MAGIC_GUARD", 0)]
        [FastEnumUtility.Label("Evan Magic Guard", 1)]
        EvanMagicGuard = 22111001,
        [FastEnumUtility.Label("EVAN_ICE_BREATH", 0)]
        [FastEnumUtility.Label("Evan Ice Breath", 1)]
        EvanIceBreath = 22121000,
        [FastEnumUtility.Label("EVAN_ELEMENTAL_RESET", 0)]
        [FastEnumUtility.Label("Evan Elemental Reset", 1)]
        EvanElementalReset = 22121001,
        [FastEnumUtility.Label("EVAN_SPELL_MASTERY", 0)]
        [FastEnumUtility.Label("Evan Spell Mastery", 1)]
        EvanSpellMastery = 22120002,
        [FastEnumUtility.Label("EVAN_MAGIC_FLAIR", 0)]
        [FastEnumUtility.Label("Evan Magic Flair", 1)]
        EvanMagicFlair = 22131000,
        [FastEnumUtility.Label("EVAN_MAGIC_SHIELD", 0)]
        [FastEnumUtility.Label("Evan Magic Shield", 1)]
        EvanMagicShield = 22131001,
        [FastEnumUtility.Label("EVAN_MAGIC_CRITICAL", 0)]
        [FastEnumUtility.Label("Evan Magic Critical", 1)]
        EvanMagicCritical = 22140000,
        [FastEnumUtility.Label("EVAN_DRAGON_THRUST", 0)]
        [FastEnumUtility.Label("Evan Dragon Thrust", 1)]
        EvanDragonThrust = 22141001,
        [FastEnumUtility.Label("EVAN_MAGIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Evan Magic Booster", 1)]
        EvanMagicBooster = 22141002,
        [FastEnumUtility.Label("EVAN_SLOW", 0)]
        [FastEnumUtility.Label("Evan Slow", 1)]
        EvanSlow = 22141003,
        [FastEnumUtility.Label("EVAN_ELEMENT_AMPLIFICATION", 0)]
        [FastEnumUtility.Label("Evan Element Amplification", 1)]
        EvanElementAmplification = 22150000,
        [FastEnumUtility.Label("EVAN_BREATH", 0)]
        [FastEnumUtility.Label("Evan Breath", 1)]
        EvanBreath = 22151001,
        [FastEnumUtility.Label("EVAN_KILLING_WING", 0)]
        [FastEnumUtility.Label("Evan Killing Wing", 1)]
        EvanKillingWing = 22151002,
        [FastEnumUtility.Label("EVAN_MAGIC_REGISTANCE", 0)]
        [FastEnumUtility.Label("Evan Magic Registance", 1)]
        EvanMagicRegistance = 22151003,
        [FastEnumUtility.Label("EVAN_DRAGON_FURY", 0)]
        [FastEnumUtility.Label("Evan Dragon Fury", 1)]
        EvanDragonFury = 22160000,
        [FastEnumUtility.Label("EVAN_EARTHQUAKE", 0)]
        [FastEnumUtility.Label("Evan Earthquake", 1)]
        EvanEarthquake = 22161001,
        [FastEnumUtility.Label("EVAN_GHOST_LETTERING", 0)]
        [FastEnumUtility.Label("Evan Ghost Lettering", 1)]
        EvanGhostLettering = 22161002,
        [FastEnumUtility.Label("EVAN_RECOVERY_AURA", 0)]
        [FastEnumUtility.Label("Evan Recovery Aura", 1)]
        EvanRecoveryAura = 22161003,
        [FastEnumUtility.Label("EVAN_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Evan Maple Hero", 1)]
        EvanMapleHero = 22171000,
        [FastEnumUtility.Label("EVAN_MAGIC_MASTERY", 0)]
        [FastEnumUtility.Label("Evan Magic Mastery", 1)]
        EvanMagicMastery = 22170001,
        [FastEnumUtility.Label("EVAN_ILLUSION", 0)]
        [FastEnumUtility.Label("Evan Illusion", 1)]
        EvanIllusion = 22171002,
        [FastEnumUtility.Label("EVAN_FLAME_WHEEL", 0)]
        [FastEnumUtility.Label("Evan Flame Wheel", 1)]
        EvanFlameWheel = 22171003,
        [FastEnumUtility.Label("EVAN_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Evan Heros Will", 1)]
        EvanHerosWill = 22171004,
        [FastEnumUtility.Label("EVAN_ONIX_BLESSING", 0)]
        [FastEnumUtility.Label("Evan Onix Blessing", 1)]
        EvanOnixBlessing = 22181000,
        [FastEnumUtility.Label("EVAN_BLAZE", 0)]
        [FastEnumUtility.Label("Evan Blaze", 1)]
        EvanBlaze = 22181001,
        [FastEnumUtility.Label("EVAN_DARK_FOG", 0)]
        [FastEnumUtility.Label("Evan Dark Fog", 1)]
        EvanDarkFog = 22181002,
        [FastEnumUtility.Label("EVAN_SOUL_STONE", 0)]
        [FastEnumUtility.Label("Evan Soul Stone", 1)]
        EvanSoulStone = 22181003,
        [FastEnumUtility.Label("CITIZEN_CRISTAL_THROW", 0)]
        [FastEnumUtility.Label("Citizen Cristal Throw", 1)]
        CitizenCristalThrow = 30001000,
        [FastEnumUtility.Label("CITIZEN_SNEAK", 0)]
        [FastEnumUtility.Label("Citizen Sneak", 1)]
        CitizenSneak = 30001001,
        [FastEnumUtility.Label("CITIZEN_EFFICIENCY", 0)]
        [FastEnumUtility.Label("Citizen Efficiency", 1)]
        CitizenEfficiency = 30000002,
        [FastEnumUtility.Label("CITIZEN_SOUL_OF_CRAFTMAN", 0)]
        [FastEnumUtility.Label("Citizen Soul Of Craftsman", 1)]
        CitizenSoulOfCraftsman = 30001003,
        [FastEnumUtility.Label("CITIZEN_MONSTER_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Monster Riding", 1)]
        CitizenMonsterRiding = 30001004,
        [FastEnumUtility.Label("CITIZEN_MAXLEVEL_ECHOBUFF", 0)]
        [FastEnumUtility.Label("Citizen Max-Level Echo Buff", 1)]
        CitizenMaxlevelEchobuff = 30001005,
        [FastEnumUtility.Label("CITIZEN_DAMAGEMETER", 0)]
        [FastEnumUtility.Label("Citizen Damage Meter", 1)]
        CitizenDamagemeter = 30001006,
        [FastEnumUtility.Label("CITIZEN_MAKER", 0)]
        [FastEnumUtility.Label("Citizen Maker", 1)]
        CitizenMaker = 30001007,
        [FastEnumUtility.Label("CITIZEN_BAMBOO", 0)]
        [FastEnumUtility.Label("Citizen Bamboo", 1)]
        CitizenBamboo = 30001009,
        [FastEnumUtility.Label("CITIZEN_INVINCIBLE", 0)]
        [FastEnumUtility.Label("Citizen Invincible", 1)]
        CitizenInvincible = 30001010,
        [FastEnumUtility.Label("CITIZEN_BERSERK", 0)]
        [FastEnumUtility.Label("Citizen Berserk", 1)]
        CitizenBerserk = 30001011,
        [FastEnumUtility.Label("CITIZEN_BLESS_OF_NYMPH", 0)]
        [FastEnumUtility.Label("Citizen Bless Of Nymph", 1)]
        CitizenBlessOfNymph = 30000012,
        [FastEnumUtility.Label("CITIZEN_TUTOR", 0)]
        [FastEnumUtility.Label("Citizen Tutor", 1)]
        CitizenTutor = 30001013,
        [FastEnumUtility.Label("CITIZEN_MASSACRE", 0)]
        [FastEnumUtility.Label("Citizen Massacre", 1)]
        CitizenMassacre = 30001020,
        [FastEnumUtility.Label("CITIZEN_CRITICAL", 0)]
        [FastEnumUtility.Label("Citizen Critical", 1)]
        CitizenCritical = 30000022,
        [FastEnumUtility.Label("CITIZEN_MULTI_PET", 0)]
        [FastEnumUtility.Label("Citizen Multi Pet", 1)]
        CitizenMultiPet = 30001024,
        [FastEnumUtility.Label("CITIZEN_WOODENHORSE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Wooden Horse Event Riding", 1)]
        CitizenWoodenhorseEventRiding = 30001025,
        [FastEnumUtility.Label("CITIZEN_FLYING_SKILL", 0)]
        [FastEnumUtility.Label("Citizen Flying Skill", 1)]
        CitizenFlyingSkill = 30001026,
        [FastEnumUtility.Label("CITIZEN_KROKO_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Kroko Event Riding", 1)]
        CitizenKrokoEventRiding = 30001027,
        [FastEnumUtility.Label("CITIZEN_NAKED_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Naked Event Riding", 1)]
        CitizenNakedEventRiding = 30001028,
        [FastEnumUtility.Label("CITIZEN_PINK_SCOOTER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Pink Scooter Event Riding", 1)]
        CitizenPinkScooterEventRiding = 30001029,
        [FastEnumUtility.Label("CITIZEN_FLYING_CLOUD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Flying Cloud Event Riding", 1)]
        CitizenFlyingCloudEventRiding = 30001030,
        [FastEnumUtility.Label("CITIZEN_BALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Balrog Event Riding", 1)]
        CitizenBalrogEventRiding = 30001031,
        [FastEnumUtility.Label("CITIZEN_KART_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Kart Event Riding", 1)]
        CitizenKartEventRiding = 30001033,
        [FastEnumUtility.Label("CITIZEN_ZD_TIGER_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Zd Tiger Event Riding", 1)]
        CitizenZdTigerEventRiding = 30001034,
        [FastEnumUtility.Label("CITIZEN_MISTBALROG_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Mistbalrog Event Riding", 1)]
        CitizenMistbalrogEventRiding = 30001035,
        [FastEnumUtility.Label("CITIZEN_HOLLY_BIRD_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Holly Bird Event Riding", 1)]
        CitizenHollyBirdEventRiding = 30001042,
        [FastEnumUtility.Label("CITIZEN_ORANGE_MUSHROOM_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Orange Mushroom Event Riding", 1)]
        CitizenOrangeMushroomEventRiding = 30001044,
        [FastEnumUtility.Label("CITIZEN_NIGHTMARE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Nightmare Event Riding", 1)]
        CitizenNightmareEventRiding = 30001049,
        [FastEnumUtility.Label("CITIZEN_YETI_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Yeti Event Riding", 1)]
        CitizenYetiEventRiding = 30001050,
        [FastEnumUtility.Label("CITIZEN_OSTRICH_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Ostrich Event Riding", 1)]
        CitizenOstrichEventRiding = 30001051,
        [FastEnumUtility.Label("CITIZEN_BEAR_BALOON_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Bear Baloon Event Riding", 1)]
        CitizenBearBaloonEventRiding = 30001052,
        [FastEnumUtility.Label("CITIZEN_TRANS_ROBOT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Trans Robot Event Riding", 1)]
        CitizenTransRobotEventRiding = 30001053,
        [FastEnumUtility.Label("CITIZEN_MOTORBIKE_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Motorbike Event Riding", 1)]
        CitizenMotorbikeEventRiding = 30001063,
        [FastEnumUtility.Label("CITIZEN_POWERED_SUIT_EVENT_RIDING", 0)]
        [FastEnumUtility.Label("Citizen Powered Suit Event Riding", 1)]
        CitizenPoweredSuitEventRiding = 30001064,
        [FastEnumUtility.Label("CITIZEN_HASTE", 0)]
        [FastEnumUtility.Label("Citizen Haste", 1)]
        CitizenHaste = 30008000,
        [FastEnumUtility.Label("CITIZEN_MYSTIC_DOOR", 0)]
        [FastEnumUtility.Label("Citizen Mystic Door", 1)]
        CitizenMysticDoor = 30008001,
        [FastEnumUtility.Label("CITIZEN_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Citizen Sharp Eyes", 1)]
        CitizenSharpEyes = 30008002,
        [FastEnumUtility.Label("CITIZEN_HYPER_BODY", 0)]
        [FastEnumUtility.Label("Citizen Hyper Body", 1)]
        CitizenHyperBody = 30008003,
        [FastEnumUtility.Label("WILDHUNTER_CAPTURE", 0)]
        [FastEnumUtility.Label("Wildhunter Capture", 1)]
        WildhunterCapture = 30001061,
        [FastEnumUtility.Label("WILDHUNTER_SUMMON_MONSTER", 0)]
        [FastEnumUtility.Label("Wildhunter Summon Monster", 1)]
        WildhunterSummonMonster = 30001062,
        [FastEnumUtility.Label("MECHANIC_RUSH", 0)]
        [FastEnumUtility.Label("Mechanic Rush", 1)]
        MechanicRush = 30001068,
        [FastEnumUtility.Label("BMAGE_TRIPLE_BLOW", 0)]
        [FastEnumUtility.Label("Bmage Triple Blow", 1)]
        BmageTripleBlow = 32001000,
        [FastEnumUtility.Label("BMAGE_FINISH_ATTACK", 0)]
        [FastEnumUtility.Label("Bmage Finish Attack", 1)]
        BmageFinishAttack = 32001001,
        [FastEnumUtility.Label("BMAGE_TELEPORT", 0)]
        [FastEnumUtility.Label("Bmage Teleport", 1)]
        BmageTeleport = 32001002,
        [FastEnumUtility.Label("BMAGE_AURA_DARK", 0)]
        [FastEnumUtility.Label("Bmage Aura Dark", 1)]
        BmageAuraDark = 32001003,
        [FastEnumUtility.Label("BMAGE_FINISH_ATTACK1", 0)]
        [FastEnumUtility.Label("Bmage Finish Attack1", 1)]
        BmageFinishAttack1 = 32001007,
        [FastEnumUtility.Label("BMAGE_FINISH_ATTACK2", 0)]
        [FastEnumUtility.Label("Bmage Finish Attack2", 1)]
        BmageFinishAttack2 = 32001008,
        [FastEnumUtility.Label("BMAGE_FINISH_ATTACK3", 0)]
        [FastEnumUtility.Label("Bmage Finish Attack3", 1)]
        BmageFinishAttack3 = 32001009,
        [FastEnumUtility.Label("BMAGE_FINISH_ATTACK4", 0)]
        [FastEnumUtility.Label("Bmage Finish Attack4", 1)]
        BmageFinishAttack4 = 32001010,
        [FastEnumUtility.Label("BMAGE_FINISH_ATTACK5", 0)]
        [FastEnumUtility.Label("Bmage Finish Attack5", 1)]
        BmageFinishAttack5 = 32001011,
        [FastEnumUtility.Label("BMAGE_QUAD_BLOW", 0)]
        [FastEnumUtility.Label("Bmage Quad Blow", 1)]
        BmageQuadBlow = 32101000,
        [FastEnumUtility.Label("BMAGE_DARK_BOW", 0)]
        [FastEnumUtility.Label("Bmage Dark Bow", 1)]
        BmageDarkBow = 32101001,
        [FastEnumUtility.Label("BMAGE_AURA_BLUE", 0)]
        [FastEnumUtility.Label("Bmage Aura Blue", 1)]
        BmageAuraBlue = 32101002,
        [FastEnumUtility.Label("BMAGE_AURA_YELLOW", 0)]
        [FastEnumUtility.Label("Bmage Aura Yellow", 1)]
        BmageAuraYellow = 32101003,
        [FastEnumUtility.Label("BMAGE_BLOOD_DRAIN", 0)]
        [FastEnumUtility.Label("Bmage Blood Drain", 1)]
        BmageBloodDrain = 32101004,
        [FastEnumUtility.Label("BMAGE_STAFF_BOOSTER", 0)]
        [FastEnumUtility.Label("Bmage Staff Booster", 1)]
        BmageStaffBooster = 32101005,
        [FastEnumUtility.Label("BMAGE_SPELL_MASTERY", 0)]
        [FastEnumUtility.Label("Bmage Spell Mastery", 1)]
        BmageSpellMastery = 32100006,
        [FastEnumUtility.Label("BMAGE_AURA_BLUE_ADVANCED", 0)]
        [FastEnumUtility.Label("Bmage Aura Blue Advanced", 1)]
        BmageAuraBlueAdvanced = 32110000,
        [FastEnumUtility.Label("BMAGE_STAFF_MASTERY", 0)]
        [FastEnumUtility.Label("Bmage Staff Mastery", 1)]
        BmageStaffMastery = 32110001,
        [FastEnumUtility.Label("BMAGE_DEATH_BLOW", 0)]
        [FastEnumUtility.Label("Bmage Death Blow", 1)]
        BmageDeathBlow = 32111002,
        [FastEnumUtility.Label("BMAGE_DARK_SPEAR", 0)]
        [FastEnumUtility.Label("Bmage Dark Spear", 1)]
        BmageDarkSpear = 32111003,
        [FastEnumUtility.Label("BMAGE_CONVERSION", 0)]
        [FastEnumUtility.Label("Bmage Conversion", 1)]
        BmageConversion = 32111004,
        [FastEnumUtility.Label("BMAGE_SUPER_BODY", 0)]
        [FastEnumUtility.Label("Bmage Super Body", 1)]
        BmageSuperBody = 32111005,
        [FastEnumUtility.Label("BMAGE_REVIVE", 0)]
        [FastEnumUtility.Label("Bmage Revive", 1)]
        BmageRevive = 32111006,
        [FastEnumUtility.Label("BMAGE_SUPER_BODY_DARK", 0)]
        [FastEnumUtility.Label("Bmage Super Body Dark", 1)]
        BmageSuperBodyDark = 32110007,
        [FastEnumUtility.Label("BMAGE_SUPER_BODY_YELLOW", 0)]
        [FastEnumUtility.Label("Bmage Super Body Yellow", 1)]
        BmageSuperBodyYellow = 32110008,
        [FastEnumUtility.Label("BMAGE_SUPER_BODY_BLUE", 0)]
        [FastEnumUtility.Label("Bmage Super Body Blue", 1)]
        BmageSuperBodyBlue = 32110009,
        [FastEnumUtility.Label("BMAGE_TELEPORT_MASTERY", 0)]
        [FastEnumUtility.Label("Bmage Teleport Mastery", 1)]
        BmageTeleportMastery = 32111010,
        [FastEnumUtility.Label("BMAGE_ADVENCED_DARK_CHAIN", 0)]
        [FastEnumUtility.Label("Bmage Advenced Dark Chain", 1)]
        BmageAdvencedDarkChain = 32111011,
        [FastEnumUtility.Label("BMAGE_AURA_DARK_ADVANCED", 0)]
        [FastEnumUtility.Label("Bmage Aura Dark Advanced", 1)]
        BmageAuraDarkAdvanced = 32120000,
        [FastEnumUtility.Label("BMAGE_AURA_YELLOW_ADVANCED", 0)]
        [FastEnumUtility.Label("Bmage Aura Yellow Advanced", 1)]
        BmageAuraYellowAdvanced = 32120001,
        [FastEnumUtility.Label("BMAGE_FINISH_BLOW", 0)]
        [FastEnumUtility.Label("Bmage Finish Blow", 1)]
        BmageFinishBlow = 32121002,
        [FastEnumUtility.Label("BMAGE_CYCLONE", 0)]
        [FastEnumUtility.Label("Bmage Cyclone", 1)]
        BmageCyclone = 32121003,
        [FastEnumUtility.Label("BMAGE_NEMESIS", 0)]
        [FastEnumUtility.Label("Bmage Nemesis", 1)]
        BmageNemesis = 32121004,
        [FastEnumUtility.Label("BMAGE_STANCE", 0)]
        [FastEnumUtility.Label("Bmage Stance", 1)]
        BmageStance = 32121005,
        [FastEnumUtility.Label("BMAGE_SHELTER", 0)]
        [FastEnumUtility.Label("Bmage Shelter", 1)]
        BmageShelter = 32121006,
        [FastEnumUtility.Label("BMAGE_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Bmage Maple Hero", 1)]
        BmageMapleHero = 32121007,
        [FastEnumUtility.Label("BMAGE_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Bmage Heros Will", 1)]
        BmageHerosWill = 32121008,
        [FastEnumUtility.Label("BMAGE_ENERGIZE", 0)]
        [FastEnumUtility.Label("Bmage Energize", 1)]
        BmageEnergize = 32120009,
        [FastEnumUtility.Label("WILDHUNTER_RAPID_SHOOT", 0)]
        [FastEnumUtility.Label("Wildhunter Rapid Shoot", 1)]
        WildhunterRapidShoot = 33001000,
        [FastEnumUtility.Label("WILDHUNTER_JAGUAR_RIDING", 0)]
        [FastEnumUtility.Label("Wildhunter Jaguar Riding", 1)]
        WildhunterJaguarRiding = 33001001,
        [FastEnumUtility.Label("WILDHUNTER_DOUBLE_JUMP", 0)]
        [FastEnumUtility.Label("Wildhunter Double Jump", 1)]
        WildhunterDoubleJump = 33001002,
        [FastEnumUtility.Label("WILDHUNTER_CROSSBOW_BOOSTER", 0)]
        [FastEnumUtility.Label("Wildhunter Crossbow Booster", 1)]
        WildhunterCrossbowBooster = 33001003,
        [FastEnumUtility.Label("WILDHUNTER_CROSSBOW_MASTERY", 0)]
        [FastEnumUtility.Label("Wildhunter Crossbow Mastery", 1)]
        WildhunterCrossbowMastery = 33100000,
        [FastEnumUtility.Label("WILDHUNTER_BOMB_SHOOT", 0)]
        [FastEnumUtility.Label("Wildhunter Bomb Shoot", 1)]
        WildhunterBombShoot = 33101001,
        [FastEnumUtility.Label("WILDHUNTER_JAGUAR_NUCKBACK", 0)]
        [FastEnumUtility.Label("Wildhunter Jaguar Nuckback", 1)]
        WildhunterJaguarNuckback = 33101002,
        [FastEnumUtility.Label("WILDHUNTER_SOUL_ARROW_CROSSBOW", 0)]
        [FastEnumUtility.Label("Wildhunter Soul Arrow Crossbow", 1)]
        WildhunterSoulArrowCrossbow = 33101003,
        [FastEnumUtility.Label("WILDHUNTER_MINE", 0)]
        [FastEnumUtility.Label("Wildhunter Mine", 1)]
        WildhunterMine = 33101004,
        [FastEnumUtility.Label("WILDHUNTER_SWALLOW", 0)]
        [FastEnumUtility.Label("Wildhunter Swallow", 1)]
        WildhunterSwallow = 33101005,
        [FastEnumUtility.Label("WILDHUNTER_SWALLOW_DUMMY_BUFF", 0)]
        [FastEnumUtility.Label("Wildhunter Swallow Dummy Buff", 1)]
        WildhunterSwallowDummyBuff = 33101006,
        [FastEnumUtility.Label("WILDHUNTER_SWALLOW_DUMMY_ATTACK", 0)]
        [FastEnumUtility.Label("Wildhunter Swallow Dummy Attack", 1)]
        WildhunterSwallowDummyAttack = 33101007,
        [FastEnumUtility.Label("WILDHUNTER_MINE_DUMMY_SUMMONED", 0)]
        [FastEnumUtility.Label("Wildhunter Mine Dummy Summoned", 1)]
        WildhunterMineDummySummoned = 33101008,
        [FastEnumUtility.Label("WILDHUNTER_FINAL_ATTACK", 0)]
        [FastEnumUtility.Label("Wildhunter Final Attack", 1)]
        WildhunterFinalAttack = 33100009,
        [FastEnumUtility.Label("WILDHUNTER_RIDING_MASTERY", 0)]
        [FastEnumUtility.Label("Wildhunter Riding Mastery", 1)]
        WildhunterRidingMastery = 33110000,
        [FastEnumUtility.Label("WILDHUNTER_FIVE_SHOOT", 0)]
        [FastEnumUtility.Label("Wildhunter Five Shoot", 1)]
        WildhunterFiveShoot = 33111001,
        [FastEnumUtility.Label("WILDHUNTER_CROSS_ROAD", 0)]
        [FastEnumUtility.Label("Wildhunter Cross Road", 1)]
        WildhunterCrossRoad = 33111002,
        [FastEnumUtility.Label("WILDHUNTER_TRAP", 0)]
        [FastEnumUtility.Label("Wildhunter Trap", 1)]
        WildhunterTrap = 33111003,
        [FastEnumUtility.Label("WILDHUNTER_BLIND", 0)]
        [FastEnumUtility.Label("Wildhunter Blind", 1)]
        WildhunterBlind = 33111004,
        [FastEnumUtility.Label("WILDHUNTER_SILVER_HAWK", 0)]
        [FastEnumUtility.Label("Wildhunter Silver Hawk", 1)]
        WildhunterSilverHawk = 33111005,
        [FastEnumUtility.Label("WILDHUNTER_CLAW_CUT", 0)]
        [FastEnumUtility.Label("Wildhunter Claw Cut", 1)]
        WildhunterClawCut = 33111006,
        [FastEnumUtility.Label("WILDHUNTER_CROSSBOW_EXPERT", 0)]
        [FastEnumUtility.Label("Wildhunter Crossbow Expert", 1)]
        WildhunterCrossbowExpert = 33120000,
        [FastEnumUtility.Label("WILDHUNTER_FLASH_RAIN", 0)]
        [FastEnumUtility.Label("Wildhunter Flash Rain", 1)]
        WildhunterFlashRain = 33121001,
        [FastEnumUtility.Label("WILDHUNTER_ELRECTRONICSHOCK", 0)]
        [FastEnumUtility.Label("Wildhunter Elrectronicshock", 1)]
        WildhunterElrectronicshock = 33121002,
        [FastEnumUtility.Label("WILDHUNTER_SNIPING", 0)]
        [FastEnumUtility.Label("Wildhunter Sniping", 1)]
        WildhunterSniping = 33121003,
        [FastEnumUtility.Label("WILDHUNTER_SHARP_EYES", 0)]
        [FastEnumUtility.Label("Wildhunter Sharp Eyes", 1)]
        WildhunterSharpEyes = 33121004,
        [FastEnumUtility.Label("WILDHUNTER_NERVEGAS", 0)]
        [FastEnumUtility.Label("Wildhunter Nervegas", 1)]
        WildhunterNervegas = 33121005,
        [FastEnumUtility.Label("WILDHUNTER_MOREWILD", 0)]
        [FastEnumUtility.Label("Wildhunter Morewild", 1)]
        WildhunterMorewild = 33121006,
        [FastEnumUtility.Label("WILDHUNTER_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Wildhunter Maple Hero", 1)]
        WildhunterMapleHero = 33121007,
        [FastEnumUtility.Label("WILDHUNTER_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Wildhunter Heros Will", 1)]
        WildhunterHerosWill = 33121008,
        [FastEnumUtility.Label("WILDHUNTER_WILD_SHOOT", 0)]
        [FastEnumUtility.Label("Wildhunter Wild Shoot", 1)]
        WildhunterWildShoot = 33121009,
        [FastEnumUtility.Label("WILDHUNTER_WILD_INSTINCT", 0)]
        [FastEnumUtility.Label("Wildhunter Wild Instinct", 1)]
        WildhunterWildInstinct = 33120010,
        [FastEnumUtility.Label("MECHANIC_FLAMETHROWER", 0)]
        [FastEnumUtility.Label("Mechanic Flamethrower", 1)]
        MechanicFlamethrower = 35001001,
        [FastEnumUtility.Label("MECHANIC_FLAMETHROWER_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Flamethrower Dummy", 1)]
        MechanicFlamethrowerDummy = 35000001,
        [FastEnumUtility.Label("MECHANIC_HN07", 0)]
        [FastEnumUtility.Label("Mechanic Hn07", 1)]
        MechanicHn07 = 35001002,
        [FastEnumUtility.Label("MECHANIC_DRILL_RUSH", 0)]
        [FastEnumUtility.Label("Mechanic Drill Rush", 1)]
        MechanicDrillRush = 35001003,
        [FastEnumUtility.Label("MECHANIC_GATLING", 0)]
        [FastEnumUtility.Label("Mechanic Gatling", 1)]
        MechanicGatling = 35001004,
        [FastEnumUtility.Label("MECHANIC_GUN_MASTERY", 0)]
        [FastEnumUtility.Label("Mechanic Gun Mastery", 1)]
        MechanicGunMastery = 35100000,
        [FastEnumUtility.Label("MECHANIC_GATLING_ROBOT_G007", 0)]
        [FastEnumUtility.Label("Mechanic Gatling Robot G007", 1)]
        MechanicGatlingRobotG007 = 35101001,
        [FastEnumUtility.Label("MECHANIC_EARTH_SLUG", 0)]
        [FastEnumUtility.Label("Mechanic Earth Slug", 1)]
        MechanicEarthSlug = 35101003,
        [FastEnumUtility.Label("MECHANIC_ROCKET_BOOSTER", 0)]
        [FastEnumUtility.Label("Mechanic Rocket Booster", 1)]
        MechanicRocketBooster = 35101004,
        [FastEnumUtility.Label("MECHANIC_ROCKET_BOOSTER_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Rocket Booster Dummy", 1)]
        MechanicRocketBoosterDummy = 35100004,
        [FastEnumUtility.Label("MECHANIC_OPEN_GATE", 0)]
        [FastEnumUtility.Label("Mechanic Open Gate", 1)]
        MechanicOpenGate = 35101005,
        [FastEnumUtility.Label("MECHANIC_BOOSTER", 0)]
        [FastEnumUtility.Label("Mechanic Booster", 1)]
        MechanicBooster = 35101006,
        [FastEnumUtility.Label("MECHANIC_PERFECT_ARMOR", 0)]
        [FastEnumUtility.Label("Mechanic Perfect Armor", 1)]
        MechanicPerfectArmor = 35101007,
        [FastEnumUtility.Label("MECHANIC_WEAPONMASTERY", 0)]
        [FastEnumUtility.Label("Mechanic Weaponmastery", 1)]
        MechanicWeaponmastery = 35100008,
        [FastEnumUtility.Label("MECHANIC_FLAMETHROWER_UP", 0)]
        [FastEnumUtility.Label("Mechanic Flamethrower Up", 1)]
        MechanicFlamethrowerUp = 35101009,
        [FastEnumUtility.Label("MECHANIC_FLAMETHROWER_UP_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Flamethrower Up Dummy", 1)]
        MechanicFlamethrowerUpDummy = 35100009,
        [FastEnumUtility.Label("MECHANIC_GATLING_UP", 0)]
        [FastEnumUtility.Label("Mechanic Gatling Up", 1)]
        MechanicGatlingUp = 35101010,
        [FastEnumUtility.Label("MECHANIC_SATELITE", 0)]
        [FastEnumUtility.Label("Mechanic Satelite", 1)]
        MechanicSatelite = 35111001,
        [FastEnumUtility.Label("MECHANIC_TESLA_COIL", 0)]
        [FastEnumUtility.Label("Mechanic Tesla Coil", 1)]
        MechanicTeslaCoil = 35111002,
        [FastEnumUtility.Label("MECHANIC_SIEGE1", 0)]
        [FastEnumUtility.Label("Mechanic Siege1", 1)]
        MechanicSiege1 = 35111004,
        [FastEnumUtility.Label("MECHANIC_SIEGE1_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Siege1Dummy", 1)]
        MechanicSiege1Dummy = 35110004,
        [FastEnumUtility.Label("MECHANIC_VELOCITY_CONTROLER", 0)]
        [FastEnumUtility.Label("Mechanic Velocity Controler", 1)]
        MechanicVelocityControler = 35111005,
        [FastEnumUtility.Label("MECHANIC_SATELITE2", 0)]
        [FastEnumUtility.Label("Mechanic Satelite2", 1)]
        MechanicSatelite2 = 35111009,
        [FastEnumUtility.Label("MECHANIC_SATELITE3", 0)]
        [FastEnumUtility.Label("Mechanic Satelite3", 1)]
        MechanicSatelite3 = 35111010,
        [FastEnumUtility.Label("MECHANIC_HEALING_ROBOT_H_LX", 0)]
        [FastEnumUtility.Label("Mechanic Healing Robot HLx", 1)]
        MechanicHealingRobotHLx = 35111011,
        [FastEnumUtility.Label("MECHANIC_DICE", 0)]
        [FastEnumUtility.Label("Mechanic Dice", 1)]
        MechanicDice = 35111013,
        [FastEnumUtility.Label("MECHANIC_METAL_FIST_MASTERY", 0)]
        [FastEnumUtility.Label("Mechanic Metal Fist Mastery", 1)]
        MechanicMetalFistMastery = 35110014,
        [FastEnumUtility.Label("MECHANIC_ROCKET_PUNCH", 0)]
        [FastEnumUtility.Label("Mechanic Rocket Punch", 1)]
        MechanicRocketPunch = 35111015,
        [FastEnumUtility.Label("MECHANIC_HN07_UPGRADE", 0)]
        [FastEnumUtility.Label("Mechanic Hn07Upgrade", 1)]
        MechanicHn07Upgrade = 35120000,
        [FastEnumUtility.Label("MECHANIC_MASTERY", 0)]
        [FastEnumUtility.Label("Mechanic Mastery", 1)]
        MechanicMastery = 35120001,
        [FastEnumUtility.Label("MECHANIC_ROBOROBO_UPGRADE", 0)]
        [FastEnumUtility.Label("Mechanic Roborobo Upgrade", 1)]
        MechanicRoboroboUpgrade = 35120002,
        [FastEnumUtility.Label("MECHANIC_SG88", 0)]
        [FastEnumUtility.Label("Mechanic Sg88", 1)]
        MechanicSg88 = 35121003,
        [FastEnumUtility.Label("MECHANIC_CANON", 0)]
        [FastEnumUtility.Label("Mechanic Canon", 1)]
        MechanicCanon = 35121004,
        [FastEnumUtility.Label("MECHANIC_SIEGE2", 0)]
        [FastEnumUtility.Label("Mechanic Siege2", 1)]
        MechanicSiege2 = 35121005,
        [FastEnumUtility.Label("MECHANIC_SIEGE2_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Siege2Dummy", 1)]
        MechanicSiege2Dummy = 35120005,
        [FastEnumUtility.Label("MECHANIC_SAFETY", 0)]
        [FastEnumUtility.Label("Mechanic Safety", 1)]
        MechanicSafety = 35121006,
        [FastEnumUtility.Label("MECHANIC_MAPLE_HERO", 0)]
        [FastEnumUtility.Label("Mechanic Maple Hero", 1)]
        MechanicMapleHero = 35121007,
        [FastEnumUtility.Label("MECHANIC_HEROS_WILL", 0)]
        [FastEnumUtility.Label("Mechanic Heros Will", 1)]
        MechanicHerosWill = 35121008,
        [FastEnumUtility.Label("MECHANIC_ROBOROBO", 0)]
        [FastEnumUtility.Label("Mechanic Roborobo", 1)]
        MechanicRoborobo = 35121009,
        [FastEnumUtility.Label("MECHANIC_AR_01", 0)]
        [FastEnumUtility.Label("Mechanic Ar01", 1)]
        MechanicAr01 = 35121010,
        [FastEnumUtility.Label("MECHANIC_ROBOROBO_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Roborobo Dummy", 1)]
        MechanicRoboroboDummy = 35121011,
        [FastEnumUtility.Label("MECHANIC_LASER", 0)]
        [FastEnumUtility.Label("Mechanic Laser", 1)]
        MechanicLaser = 35121012,
        [FastEnumUtility.Label("MECHANIC_SIEGE2_SPECIAL", 0)]
        [FastEnumUtility.Label("Mechanic Siege2Special", 1)]
        MechanicSiege2Special = 35121013,
        [FastEnumUtility.Label("MECHANIC_SIEGE2_SPECIAL_DUMMY", 0)]
        [FastEnumUtility.Label("Mechanic Siege2Special Dummy", 1)]
        MechanicSiege2SpecialDummy = 35120013,
        [FastEnumUtility.Label("UNRECORDED_DEADLYATTACK", 0)]
        [FastEnumUtility.Label("Unrecorded Deadlyattack", 1)]
        UnrecordedDeadlyattack = 90000000,
        [FastEnumUtility.Label("UNRECORDED_STUN", 0)]
        [FastEnumUtility.Label("Unrecorded Stun", 1)]
        UnrecordedStun = 90001001,
        [FastEnumUtility.Label("UNRECORDED_SLOW", 0)]
        [FastEnumUtility.Label("Unrecorded Slow", 1)]
        UnrecordedSlow = 90001002,
        [FastEnumUtility.Label("UNRECORDED_POISON", 0)]
        [FastEnumUtility.Label("Unrecorded Poison", 1)]
        UnrecordedPoison = 90001003,
        [FastEnumUtility.Label("UNRECORDED_BLIND", 0)]
        [FastEnumUtility.Label("Unrecorded Blind", 1)]
        UnrecordedBlind = 90001004,
        [FastEnumUtility.Label("UNRECORDED_SEAL", 0)]
        [FastEnumUtility.Label("Unrecorded Seal", 1)]
        UnrecordedSeal = 90001005,
        [FastEnumUtility.Label("UNRECORDED_FREEZE", 0)]
        [FastEnumUtility.Label("Unrecorded Freeze", 1)]
        UnrecordedFreeze = 90001006,
        [FastEnumUtility.Label("GUILD_MESOUP", 0)]
        [FastEnumUtility.Label("Guild Mesoup", 1)]
        GuildMesoup = 91000000,
        [FastEnumUtility.Label("GUILD_EXPERIENCEUP", 0)]
        [FastEnumUtility.Label("Guild Experienceup", 1)]
        GuildExperienceup = 91000001,
        [FastEnumUtility.Label("GUILD_DEFENCEUP", 0)]
        [FastEnumUtility.Label("Guild Defenceup", 1)]
        GuildDefenceup = 91000002,
        [FastEnumUtility.Label("GUILD_ATTNMAGUP", 0)]
        [FastEnumUtility.Label("Guild Attnmagup", 1)]
        GuildAttnmagup = 91000003,
        [FastEnumUtility.Label("GUILD_AGILITYUP", 0)]
        [FastEnumUtility.Label("Guild Agilityup", 1)]
        GuildAgilityup = 91000004,
        [FastEnumUtility.Label("GUILD_BUSINESSEFFICENYUP", 0)]
        [FastEnumUtility.Label("Guild Businessefficenyup", 1)]
        GuildBusinessefficenyup = 91000005,
        [FastEnumUtility.Label("GUILD_REGULARSUPPORT", 0)]
        [FastEnumUtility.Label("Guild Regularsupport", 1)]
        GuildRegularsupport = 91000006,
    }
    public enum SkillSubType : byte
    {
        [FastEnumUtility.Label("Active", 0)]
        Regular = 0,
        Mastery = 1,
        Booster = 2,
        [FastEnumUtility.Label("Final Attack", 0)]
        FinalAttack = 3,
        [FastEnumUtility.Label("Serial Attack", 0)]
        SerialAttack = 4,
    }
    public enum SkillTargetType : byte
    {
        [FastEnumUtility.Label("Local User", 1)]
        [FastEnumUtility.Label("TARGETTYPE_LOCALUSER", 0)]
        LocalUser = 0,
        [FastEnumUtility.Label("Nearest Mob", 1)]
        [FastEnumUtility.Label("TAEGETTYPE_NEAREASTMOB", 0)]
        NearestMob = 1,
        [FastEnumUtility.Label("Dazzled Mob", 1)]
        [FastEnumUtility.Label("TARGETTYPE_DAZZLEDMOB", 0)]
        DazzledMob = 2,
        [FastEnumUtility.Label("TARGETTYPE_CHASING", 0)]
        Chasing = 3,
        [FastEnumUtility.Label("TARGETTYPE_SELF", 0)]
        Self = 4,
    }
    public enum SkillUseCheckResult : byte
    {
        [FastEnumUtility.Label("CanUseSkill", 0)]
        CanUseSkill = 1,
        [FastEnumUtility.Label("NoHPForSkill", 0)]
        NoHpForSkill = 2,
        [FastEnumUtility.Label("NoMPForSkill", 0)]
        NoMpForSkill = 3,
        [FastEnumUtility.Label("NoMesoForSkill", 0)]
        NoMesoForSkill = 4,
    }
    public enum SkinColor : byte
    {
        Light = 0,
        Tanned = 1,
        Dark = 2,
        Pale = 3,
        [FastEnumUtility.Label("Ghost White", 1)]
        GhostWhite = 4,
        Green = 5,
        [FastEnumUtility.Label("Custom 9", 1)]
        Custom9 = 9,
        [FastEnumUtility.Label("Custom 10", 1)]
        Custom10 = 10,
        [FastEnumUtility.Label("Custom 11", 1)]
        Custom11 = 11,
    }
    public enum SnowballSection : byte
    {
        [FastEnumUtility.Label("SNOWBALL_SECTION0", 0)]
        Section0 = 0,
        [FastEnumUtility.Label("SNOWBALL_SECTION1", 0)]
        Section1 = 1,
        [FastEnumUtility.Label("SNOWBALL_SECTION2", 0)]
        Section2 = 2,
        [FastEnumUtility.Label("SNOWBALL_SECTION3", 0)]
        Section3 = 3,
        [FastEnumUtility.Label("SNOWBALL_STOP", 0)]
        Stop = 4,
        [FastEnumUtility.Label("SNOWBALL_RESTART", 0)]
        Restart = 5,
    }
    public enum SoundEffectType : byte
    {
        [FastEnumUtility.Label("Mob Damage", 1)]
        [FastEnumUtility.Label("SE_MOB_DAMAGE", 0)]
        MobDamage = 0,
        [FastEnumUtility.Label("Mob Die", 1)]
        [FastEnumUtility.Label("SE_MOB_DIE", 0)]
        MobDie = 1,
        [FastEnumUtility.Label("Mob Attack1", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK1", 0)]
        MobAttack1 = 2,
        [FastEnumUtility.Label("Mob Attack2", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK2", 0)]
        MobAttack2 = 3,
        [FastEnumUtility.Label("Mob Attack3", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK3", 0)]
        MobAttack3 = 4,
        [FastEnumUtility.Label("Mob Attack4", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK4", 0)]
        MobAttack4 = 5,
        [FastEnumUtility.Label("Mob Attack5", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK5", 0)]
        MobAttack5 = 6,
        [FastEnumUtility.Label("Mob Attack6", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK6", 0)]
        MobAttack6 = 7,
        [FastEnumUtility.Label("Mob Attack7", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK7", 0)]
        MobAttack7 = 8,
        [FastEnumUtility.Label("Mob Attack8", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACK8", 0)]
        MobAttack8 = 9,
        [FastEnumUtility.Label("Mob Attack F", 1)]
        [FastEnumUtility.Label("SE_MOB_ATTACKF", 0)]
        MobAttackF = 10,
        [FastEnumUtility.Label("Mob Char Damage1", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE1", 0)]
        MobCharDamage1 = 11,
        [FastEnumUtility.Label("Mob Char Damage2", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE2", 0)]
        MobCharDamage2 = 12,
        [FastEnumUtility.Label("Mob Char Damage3", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE3", 0)]
        MobCharDamage3 = 13,
        [FastEnumUtility.Label("Mob Char Damage4", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE4", 0)]
        MobCharDamage4 = 14,
        [FastEnumUtility.Label("Mob Char Damage5", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE5", 0)]
        MobCharDamage5 = 15,
        [FastEnumUtility.Label("Mob Char Damage6", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE6", 0)]
        MobCharDamage6 = 16,
        [FastEnumUtility.Label("Mob Char Damage7", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE7", 0)]
        MobCharDamage7 = 17,
        [FastEnumUtility.Label("Mob Char Damage8", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGE8", 0)]
        MobCharDamage8 = 18,
        [FastEnumUtility.Label("Mob Char Damage F", 1)]
        [FastEnumUtility.Label("SE_MOB_CHARDAMAGEF", 0)]
        MobCharDamageF = 19,
        [FastEnumUtility.Label("Mob Skill1", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL1", 0)]
        MobSkill1 = 20,
        [FastEnumUtility.Label("Mob Skill2", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL2", 0)]
        MobSkill2 = 21,
        [FastEnumUtility.Label("Mob Skill3", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL3", 0)]
        MobSkill3 = 22,
        [FastEnumUtility.Label("Mob Skill4", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL4", 0)]
        MobSkill4 = 23,
        [FastEnumUtility.Label("Mob Skill5", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL5", 0)]
        MobSkill5 = 24,
        [FastEnumUtility.Label("Mob Skill6", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL6", 0)]
        MobSkill6 = 25,
        [FastEnumUtility.Label("Mob Skill7", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL7", 0)]
        MobSkill7 = 26,
        [FastEnumUtility.Label("Mob Skill8", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL8", 0)]
        MobSkill8 = 27,
        [FastEnumUtility.Label("Mob Skill9", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL9", 0)]
        MobSkill9 = 28,
        [FastEnumUtility.Label("Mob Skill10", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL10", 0)]
        MobSkill10 = 29,
        [FastEnumUtility.Label("Mob Skill11", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL11", 0)]
        MobSkill11 = 30,
        [FastEnumUtility.Label("Mob Skill12", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL12", 0)]
        MobSkill12 = 31,
        [FastEnumUtility.Label("Mob Skill13", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL13", 0)]
        MobSkill13 = 32,
        [FastEnumUtility.Label("Mob Skill14", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL14", 0)]
        MobSkill14 = 33,
        [FastEnumUtility.Label("Mob Skill15", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL15", 0)]
        MobSkill15 = 34,
        [FastEnumUtility.Label("Mob Skill16", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILL16", 0)]
        MobSkill16 = 35,
        [FastEnumUtility.Label("Mob Skill F", 1)]
        [FastEnumUtility.Label("SE_MOB_SKILLF", 0)]
        MobSkillF = 36,
        [FastEnumUtility.Label("Mob Bomb", 1)]
        [FastEnumUtility.Label("SE_MOB_BOMB", 0)]
        MobBomb = 37,
        [FastEnumUtility.Label("Mob Regen", 1)]
        [FastEnumUtility.Label("SE_MOB_REGEN", 0)]
        MobRegen = 38,
        [FastEnumUtility.Label("SE_WEAPON_ATTACK", 0)]
        [FastEnumUtility.Label("Weapon Attack", 1)]
        WeaponAttack = 39,
        [FastEnumUtility.Label("SE_WEAPON_ATTACK2", 0)]
        [FastEnumUtility.Label("Weapon Attack2", 1)]
        WeaponAttack2 = 40,
        [FastEnumUtility.Label("Item Use", 1)]
        [FastEnumUtility.Label("SE_ITEM_USE", 0)]
        ItemUse = 41,
        [FastEnumUtility.Label("SE_SKILL_USE", 0)]
        [FastEnumUtility.Label("Skill Use", 1)]
        SkillUse = 42,
        [FastEnumUtility.Label("SE_SKILL_USE2", 0)]
        [FastEnumUtility.Label("Skill Use2", 1)]
        SkillUse2 = 43,
        [FastEnumUtility.Label("SE_SKILL_USE3", 0)]
        [FastEnumUtility.Label("Skill Use3", 1)]
        SkillUse3 = 44,
        [FastEnumUtility.Label("SE_SKILL_USE4", 0)]
        [FastEnumUtility.Label("Skill Use4", 1)]
        SkillUse4 = 45,
        [FastEnumUtility.Label("SE_SKILL_USE5", 0)]
        [FastEnumUtility.Label("Skill Use5", 1)]
        SkillUse5 = 46,
        [FastEnumUtility.Label("SE_SKILL_LOOP", 0)]
        [FastEnumUtility.Label("Skill Loop", 1)]
        SkillLoop = 47,
        [FastEnumUtility.Label("SE_SKILL_SUMMONED", 0)]
        [FastEnumUtility.Label("Skill Summoned", 1)]
        SkillSummoned = 48,
        [FastEnumUtility.Label("SE_SKILL_ATTACK1", 0)]
        [FastEnumUtility.Label("Skill Attack1", 1)]
        SkillAttack1 = 49,
        [FastEnumUtility.Label("SE_SKILL_DIE", 0)]
        [FastEnumUtility.Label("Skill Die", 1)]
        SkillDie = 50,
        [FastEnumUtility.Label("SE_SKILL_DAMAGE", 0)]
        [FastEnumUtility.Label("Skill Damage", 1)]
        SkillDamage = 51,
        [FastEnumUtility.Label("SE_SKILL_HIT", 0)]
        [FastEnumUtility.Label("Skill Hit", 1)]
        SkillHit = 52,
        [FastEnumUtility.Label("SE_SKILL_DELAYEDHIT", 0)]
        [FastEnumUtility.Label("Skill Delayed Hit", 1)]
        SkillDelayedHit = 53,
        [FastEnumUtility.Label("SE_SKILL_GETOFF", 0)]
        [FastEnumUtility.Label("Skill Get Off", 1)]
        SkillGetOff = 54,
        [FastEnumUtility.Label("Reactor Hit", 1)]
        [FastEnumUtility.Label("SE_REACTOR_HIT", 0)]
        ReactorHit = 55,
    }
    public enum SpecialSetEffect
    {
        [FastEnumUtility.Label("SPECIAL_SET_EFFECT_VISITOR_CUBE", 0)]
        [FastEnumUtility.Label("Visitor Cube", 1)]
        VisitorCube = 10000,
    }
    public enum SpeedQuizType : byte
    {
        [FastEnumUtility.Label("TYPE_SPEED_QUIZ_NPC", 0)]
        Npc = 0,
        [FastEnumUtility.Label("TYPE_SPEED_QUIZ_MOB", 0)]
        Mob = 1,
        [FastEnumUtility.Label("TYPE_SPEED_QUIZ_ITEM", 0)]
        Item = 2,
    }
    public enum SueCharacterResult
    {
        [FastEnumUtility.Label("SueCharacterRes_Success", 0)]
        Success = 0,
        [FastEnumUtility.Label("Invalid Character Id", 1)]
        [FastEnumUtility.Label("SueCharacterRes_InvalidCharacterID", 0)]
        InvalidCharacterId = 1,
        [FastEnumUtility.Label("Already Done Today", 1)]
        [FastEnumUtility.Label("SueCharacterRes_AlreadyDoneToday", 0)]
        AlreadyDoneToday = 2,
        [FastEnumUtility.Label("SueCharacterRes_Notify", 0)]
        Notify = 3,
        [FastEnumUtility.Label("SueCharacterRes_UnknownError", 0)]
        [FastEnumUtility.Label("Unknown Error", 1)]
        UnknownError = -1,
    }
    public enum SummonedActionType : byte
    {
        [FastEnumUtility.Label("SUMMONEDACT_STAND", 0)]
        Stand = 0,
        [FastEnumUtility.Label("SUMMONEDACT_MOVE", 0)]
        Move = 1,
        [FastEnumUtility.Label("SUMMONEDACT_FLY", 0)]
        Fly = 2,
        [FastEnumUtility.Label("SUMMONEDACT_SUMMONED", 0)]
        Summoned = 3,
        [FastEnumUtility.Label("SUMMONEDACT_ATTACK1", 0)]
        Attack1 = 4,
        [FastEnumUtility.Label("SUMMONEDACT_ATTACK2", 0)]
        Attack2 = 5,
        [FastEnumUtility.Label("Attack Triangle", 1)]
        [FastEnumUtility.Label("SUMMONEDACT_ATTACK_TRIANGLE", 0)]
        AttackTriangle = 6,
        [FastEnumUtility.Label("SUMMONEDACT_SKILL1", 0)]
        Skill1 = 7,
        [FastEnumUtility.Label("SUMMONEDACT_SKILL2", 0)]
        Skill2 = 8,
        [FastEnumUtility.Label("SUMMONEDACT_SKILL3", 0)]
        Skill3 = 9,
        [FastEnumUtility.Label("SUMMONEDACT_SKILL4", 0)]
        Skill4 = 10,
        [FastEnumUtility.Label("SUMMONEDACT_SKILL5", 0)]
        Skill5 = 11,
        [FastEnumUtility.Label("SUMMONEDACT_SKILL6", 0)]
        Skill6 = 12,
        [FastEnumUtility.Label("SUMMONEDACT_HEAL", 0)]
        Heal = 13,
        [FastEnumUtility.Label("SUMMONEDACT_SUBSUMMON", 0)]
        [FastEnumUtility.Label("Sub Summon", 1)]
        SubSummon = 14,
        [FastEnumUtility.Label("SUMMONEDACT_HIT", 0)]
        Hit = 15,
        [FastEnumUtility.Label("SUMMONEDACT_DIE", 0)]
        Die = 16,
        [FastEnumUtility.Label("SUMMONEDACT_SAY", 0)]
        Say = 17,
        [FastEnumUtility.Label("SUMMONEDACT_PREPARE", 0)]
        Prepare = 18,
    }
    public enum SummonedAssistType : byte
    {
        None = 0,
        Attack = 1,
        Heal = 2,
        [FastEnumUtility.Label("Attack Ex", 1)]
        AttackEx = 3,
        Summon = 4,
        [FastEnumUtility.Label("Attack Manual", 1)]
        AttackManual = 5,
        [FastEnumUtility.Label("Attack Counter", 1)]
        AttackCounter = 6,
    }
    public enum SummonedAttackAiType : byte
    {
        [FastEnumUtility.Label("AI_ATTACK", 0)]
        Attack = 0,
        [FastEnumUtility.Label("AI_SELFDESTRUCT", 0)]
        [FastEnumUtility.Label("Self Destruct", 1)]
        SelfDestruct = 1,
        [FastEnumUtility.Label("AI_HEAL", 0)]
        Heal = 2,
        [FastEnumUtility.Label("AI_TESLACOIL_TRIANGLE", 0)]
        [FastEnumUtility.Label("Tesla Coil Triangle", 1)]
        TeslaCoilTriangle = 3,
    }
    public enum SummonedAttackState : byte
    {
        [FastEnumUtility.Label("AS_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("AS_BEFOREHIT", 0)]
        [FastEnumUtility.Label("Before Hit", 1)]
        BeforeHit = 1,
        [FastEnumUtility.Label("AS_HIT", 0)]
        Hit = 2,
        [FastEnumUtility.Label("AS_WAITING", 0)]
        Waiting = 3,
        [FastEnumUtility.Label("AS_LEAVE", 0)]
        Leave = 4,
    }
    public enum SummonedEnterType : byte
    {
        [FastEnumUtility.Label("ENTER_TYPE_DEFAULT", 0)]
        Default = 0,
        [FastEnumUtility.Label("Create Summoned", 1)]
        [FastEnumUtility.Label("ENTER_TYPE_CREATE_SUMMONED", 0)]
        CreateSummoned = 1,
        [FastEnumUtility.Label("ENTER_TYPE_REREGISTER_SUMMONED", 0)]
        [FastEnumUtility.Label("Reregister Summoned", 1)]
        ReregisterSummoned = 2,
    }
    public enum SummonedLeaveType : byte
    {
        [FastEnumUtility.Label("LEAVE_TYPE_UPDATE", 0)]
        Update = 0,
        [FastEnumUtility.Label("LEAVE_TYPE_SUMMONED_DEAD", 0)]
        [FastEnumUtility.Label("Summoned Dead", 1)]
        SummonedDead = 1,
        [FastEnumUtility.Label("LEAVE_TYPE_MYSTERY", 0)]
        Mystery = 2,
        [FastEnumUtility.Label("LEAVE_TYPE_DEFAULT", 0)]
        Default = 3,
        [FastEnumUtility.Label("LEAVE_TYPE_LEAVE_FIELD", 0)]
        [FastEnumUtility.Label("Leave Field", 1)]
        LeaveField = 4,
        [FastEnumUtility.Label("LEAVE_TYPE_SELF_DESTRUCT", 0)]
        [FastEnumUtility.Label("Self Destruct", 1)]
        SelfDestruct = 5,
        [FastEnumUtility.Label("LEAVE_TYPE_GABIOTA", 0)]
        Gabiota = 6,
        [FastEnumUtility.Label("Enter Forbidden Map", 1)]
        [FastEnumUtility.Label("LEAVE_TYPE_ENTER_FORBIDEN_MAP", 0)]
        EnterForbiddenMap = 7,
        [FastEnumUtility.Label("Enter Event Field", 1)]
        [FastEnumUtility.Label("LEAVE_TYPE_ENTER_EVENT_FIELD", 0)]
        EnterEventField = 8,
        [FastEnumUtility.Label("LEAVE_TYPE_USER_DEAD", 0)]
        [FastEnumUtility.Label("User Dead", 1)]
        UserDead = 9,
        [FastEnumUtility.Label("LEAVE_TYPE_ON_REMOVE", 0)]
        [FastEnumUtility.Label("On Remove", 1)]
        OnRemove = 10,
        [FastEnumUtility.Label("LEAVE_TYPE_TESLACOIL_ERROR", 0)]
        [FastEnumUtility.Label("Tesla Coil Error", 1)]
        TeslaCoilError = 11,
        [FastEnumUtility.Label("LEAVE_TYPE_NOT_ABLE_MULTIPLE", 0)]
        [FastEnumUtility.Label("Not Able Multiple", 1)]
        NotAbleMultiple = 12,
        [FastEnumUtility.Label("Did Not Self Destruct", 1)]
        [FastEnumUtility.Label("LEAVE_TYPE_DIDNT_SELFDESTRUCT", 0)]
        DidNotSelfDestruct = 13,
        [FastEnumUtility.Label("LEAVE_TYPE_SUMMONED_COUNT_OVER", 0)]
        [FastEnumUtility.Label("Summoned Count Over", 1)]
        SummonedCountOver = 14,
    }
    public enum TamingMobId
    {
        [FastEnumUtility.Label("Red Draco", 1)]
        [FastEnumUtility.Label("TAMINGMOB_RED_DRACO", 0)]
        RedDraco = 1902002,
        [FastEnumUtility.Label("TAMINGMOB_RYUHO_50", 0)]
        Ryuho50 = 1902015,
        [FastEnumUtility.Label("TAMINGMOB_RYUHO_100", 0)]
        Ryuho100 = 1902016,
        [FastEnumUtility.Label("TAMINGMOB_RYUHO_150", 0)]
        Ryuho150 = 1902017,
        [FastEnumUtility.Label("TAMINGMOB_RYUHO_200", 0)]
        Ryuho200 = 1902018,
        [FastEnumUtility.Label("TAMINGMOB_MIR_1", 0)]
        Mir1 = 1902040,
        [FastEnumUtility.Label("TAMINGMOB_MIR_2", 0)]
        Mir2 = 1902041,
        [FastEnumUtility.Label("TAMINGMOB_MIR_3", 0)]
        Mir3 = 1902042,
    }
    public enum TemporaryStatType : byte
    {
        [FastEnumUtility.Label("CTS_PAD", 0)]
        PAD = 0,
        [FastEnumUtility.Label("CTS_PDD", 0)]
        PDD = 1,
        [FastEnumUtility.Label("CTS_MAD", 0)]
        MAD = 2,
        [FastEnumUtility.Label("CTS_MDD", 0)]
        MDD = 3,
        [FastEnumUtility.Label("CTS_ACC", 0)]
        ACC = 4,
        [FastEnumUtility.Label("CTS_EVA", 0)]
        EVA = 5,
        [FastEnumUtility.Label("CTS_Craft", 0)]
        Craft = 6,
        [FastEnumUtility.Label("CTS_Speed", 0)]
        Speed = 7,
        [FastEnumUtility.Label("CTS_Jump", 0)]
        Jump = 8,
        [FastEnumUtility.Label("CTS_MagicGuard", 0)]
        [FastEnumUtility.Label("Magic Guard", 1)]
        MagicGuard = 9,
        [FastEnumUtility.Label("CTS_DarkSight", 0)]
        [FastEnumUtility.Label("Dark Sight", 1)]
        DarkSight = 10,
        [FastEnumUtility.Label("CTS_Booster", 0)]
        Booster = 11,
        [FastEnumUtility.Label("CTS_PowerGuard", 0)]
        [FastEnumUtility.Label("Power Guard", 1)]
        PowerGuard = 12,
        [FastEnumUtility.Label("CTS_MaxHP", 0)]
        [FastEnumUtility.Label("Max HP", 1)]
        MaxHP = 13,
        [FastEnumUtility.Label("CTS_MaxMP", 0)]
        [FastEnumUtility.Label("Max MP", 1)]
        MaxMP = 14,
        [FastEnumUtility.Label("CTS_Invincible", 0)]
        Invincible = 15,
        [FastEnumUtility.Label("CTS_SoulArrow", 0)]
        [FastEnumUtility.Label("Soul Arrow", 1)]
        SoulArrow = 16,
        [FastEnumUtility.Label("CTS_Stun", 0)]
        Stun = 17,
        [FastEnumUtility.Label("CTS_Poison", 0)]
        Poison = 18,
        [FastEnumUtility.Label("CTS_Seal", 0)]
        Seal = 19,
        [FastEnumUtility.Label("CTS_Darkness", 0)]
        Darkness = 20,
        [FastEnumUtility.Label("CTS_ComboCounter", 0)]
        [FastEnumUtility.Label("Combo Counter", 1)]
        ComboCounter = 21,
        [FastEnumUtility.Label("CTS_WeaponCharge", 0)]
        [FastEnumUtility.Label("Weapon Charge", 1)]
        WeaponCharge = 22,
        [FastEnumUtility.Label("CTS_DragonBlood", 0)]
        [FastEnumUtility.Label("Dragon Blood", 1)]
        DragonBlood = 23,
        [FastEnumUtility.Label("CTS_HolySymbol", 0)]
        [FastEnumUtility.Label("Holy Symbol", 1)]
        HolySymbol = 24,
        [FastEnumUtility.Label("CTS_MesoUp", 0)]
        [FastEnumUtility.Label("Meso Up", 1)]
        MesoUp = 25,
        [FastEnumUtility.Label("CTS_ShadowPartner", 0)]
        [FastEnumUtility.Label("Shadow Partner", 1)]
        ShadowPartner = 26,
        [FastEnumUtility.Label("CTS_PickPocket", 0)]
        [FastEnumUtility.Label("Pick Pocket", 1)]
        PickPocket = 27,
        [FastEnumUtility.Label("CTS_MesoGuard", 0)]
        [FastEnumUtility.Label("Meso Guard", 1)]
        MesoGuard = 28,
        [FastEnumUtility.Label("CTS_Thaw", 0)]
        Thaw = 29,
        [FastEnumUtility.Label("CTS_Weakness", 0)]
        Weakness = 30,
        [FastEnumUtility.Label("CTS_Curse", 0)]
        Curse = 31,
        [FastEnumUtility.Label("CTS_Slow", 0)]
        Slow = 32,
        [FastEnumUtility.Label("CTS_Morph", 0)]
        Morph = 33,
        [FastEnumUtility.Label("CTS_Regen", 0)]
        Regen = 34,
        [FastEnumUtility.Label("Basic Stat Up", 1)]
        [FastEnumUtility.Label("CTS_BasicStatUp", 0)]
        BasicStatUp = 35,
        [FastEnumUtility.Label("CTS_Stance", 0)]
        Stance = 36,
        [FastEnumUtility.Label("CTS_SharpEyes", 0)]
        [FastEnumUtility.Label("Sharp Eyes", 1)]
        SharpEyes = 37,
        [FastEnumUtility.Label("CTS_ManaReflection", 0)]
        [FastEnumUtility.Label("Mana Reflection", 1)]
        ManaReflection = 38,
        [FastEnumUtility.Label("CTS_Attract", 0)]
        Attract = 39,
        [FastEnumUtility.Label("CTS_SpiritJavelin", 0)]
        [FastEnumUtility.Label("Spirit Javelin", 1)]
        SpiritJavelin = 40,
        [FastEnumUtility.Label("CTS_Infinity", 0)]
        Infinity = 41,
        [FastEnumUtility.Label("CTS_Holyshield", 0)]
        [FastEnumUtility.Label("Holy Shield", 1)]
        HolyShield = 42,
        [FastEnumUtility.Label("CTS_HamString", 0)]
        [FastEnumUtility.Label("Ham String", 1)]
        HamString = 43,
        [FastEnumUtility.Label("CTS_Blind", 0)]
        Blind = 44,
        [FastEnumUtility.Label("CTS_Concentration", 0)]
        Concentration = 45,
        [FastEnumUtility.Label("Ban Map", 1)]
        [FastEnumUtility.Label("CTS_BanMap", 0)]
        BanMap = 46,
        [FastEnumUtility.Label("CTS_MaxLevelBuff", 0)]
        [FastEnumUtility.Label("Max Level Buff", 1)]
        MaxLevelBuff = 47,
        [FastEnumUtility.Label("CTS_MesoUpByItem", 0)]
        [FastEnumUtility.Label("Meso Up By Item", 1)]
        MesoUpByItem = 48,
        [FastEnumUtility.Label("CTS_Ghost", 0)]
        Ghost = 49,
        [FastEnumUtility.Label("CTS_Barrier", 0)]
        Barrier = 50,
        [FastEnumUtility.Label("CTS_ReverseInput", 0)]
        [FastEnumUtility.Label("Reverse Input", 1)]
        ReverseInput = 51,
        [FastEnumUtility.Label("CTS_ItemUpByItem", 0)]
        [FastEnumUtility.Label("Item Up By Item", 1)]
        ItemUpByItem = 52,
        [FastEnumUtility.Label("CTS_RespectPImmune", 0)]
        [FastEnumUtility.Label("Respect PImmune", 1)]
        RespectPImmune = 53,
        [FastEnumUtility.Label("CTS_RespectMImmune", 0)]
        [FastEnumUtility.Label("Respect MImmune", 1)]
        RespectMImmune = 54,
        [FastEnumUtility.Label("CTS_DefenseAtt", 0)]
        [FastEnumUtility.Label("Defense Att", 1)]
        DefenseAtt = 55,
        [FastEnumUtility.Label("CTS_DefenseState", 0)]
        [FastEnumUtility.Label("Defense State", 1)]
        DefenseState = 56,
        [FastEnumUtility.Label("CTS_IncEffectHPPotion", 0)]
        [FastEnumUtility.Label("Inc Effect HP Potion", 1)]
        IncEffectHPPotion = 57,
        [FastEnumUtility.Label("CTS_IncEffectMPPotion", 0)]
        [FastEnumUtility.Label("Inc Effect MP Potion", 1)]
        IncEffectMPPotion = 58,
        [FastEnumUtility.Label("CTS_DojangBerserk", 0)]
        [FastEnumUtility.Label("Dojang Berserk", 1)]
        DojangBerserk = 59,
        [FastEnumUtility.Label("CTS_DojangInvincible", 0)]
        [FastEnumUtility.Label("Dojang Invincible", 1)]
        DojangInvincible = 60,
        [FastEnumUtility.Label("CTS_Spark", 0)]
        Spark = 61,
        [FastEnumUtility.Label("CTS_DojangShield", 0)]
        [FastEnumUtility.Label("Dojang Shield", 1)]
        DojangShield = 62,
        [FastEnumUtility.Label("CTS_SoulMasterFinal", 0)]
        [FastEnumUtility.Label("Soul Master Final", 1)]
        SoulMasterFinal = 63,
        [FastEnumUtility.Label("CTS_WindBreakerFinal", 0)]
        [FastEnumUtility.Label("Wind Breaker Final", 1)]
        WindBreakerFinal = 64,
        [FastEnumUtility.Label("CTS_ElementalReset", 0)]
        [FastEnumUtility.Label("Elemental Reset", 1)]
        ElementalReset = 65,
        [FastEnumUtility.Label("CTS_WindWalk", 0)]
        [FastEnumUtility.Label("Wind Walk", 1)]
        WindWalk = 66,
        [FastEnumUtility.Label("CTS_EventRate", 0)]
        [FastEnumUtility.Label("Event Rate", 1)]
        EventRate = 67,
        [FastEnumUtility.Label("CTS_ComboAbilityBuff", 0)]
        [FastEnumUtility.Label("Combo Ability Buff", 1)]
        ComboAbilityBuff = 68,
        [FastEnumUtility.Label("CTS_ComboDrain", 0)]
        [FastEnumUtility.Label("Combo Drain", 1)]
        ComboDrain = 69,
        [FastEnumUtility.Label("CTS_ComboBarrier", 0)]
        [FastEnumUtility.Label("Combo Barrier", 1)]
        ComboBarrier = 70,
        [FastEnumUtility.Label("Body Pressure", 1)]
        [FastEnumUtility.Label("CTS_BodyPressure", 0)]
        BodyPressure = 71,
        [FastEnumUtility.Label("CTS_SmartKnockback", 0)]
        [FastEnumUtility.Label("Smart Knockback", 1)]
        SmartKnockback = 72,
        [FastEnumUtility.Label("CTS_RepeatEffect", 0)]
        [FastEnumUtility.Label("Repeat Effect", 1)]
        RepeatEffect = 73,
        [FastEnumUtility.Label("CTS_ExpBuffRate", 0)]
        [FastEnumUtility.Label("Exp Buff Rate", 1)]
        ExpBuffRate = 74,
        [FastEnumUtility.Label("CTS_StopPortion", 0)]
        [FastEnumUtility.Label("Stop Potion", 1)]
        StopPotion = 75,
        [FastEnumUtility.Label("CTS_StopMotion", 0)]
        [FastEnumUtility.Label("Stop Motion", 1)]
        StopMotion = 76,
        [FastEnumUtility.Label("CTS_Fear", 0)]
        Fear = 77,
        [FastEnumUtility.Label("CTS_EvanSlow", 0)]
        [FastEnumUtility.Label("Evan Slow", 1)]
        EvanSlow = 78,
        [FastEnumUtility.Label("CTS_MagicShield", 0)]
        [FastEnumUtility.Label("Magic Shield", 1)]
        MagicShield = 79,
        [FastEnumUtility.Label("CTS_MagicResistance", 0)]
        [FastEnumUtility.Label("Magic Resistance", 1)]
        MagicResistance = 80,
        [FastEnumUtility.Label("CTS_SoulStone", 0)]
        [FastEnumUtility.Label("Soul Stone", 1)]
        SoulStone = 81,
        [FastEnumUtility.Label("CTS_Flying", 0)]
        Flying = 82,
        [FastEnumUtility.Label("CTS_Frozen", 0)]
        Frozen = 83,
        [FastEnumUtility.Label("Assist Charge", 1)]
        [FastEnumUtility.Label("CTS_AssistCharge", 0)]
        AssistCharge = 84,
        [FastEnumUtility.Label("CTS_Enrage", 0)]
        Enrage = 85,
        [FastEnumUtility.Label("CTS_SuddenDeath", 0)]
        [FastEnumUtility.Label("Sudden Death", 1)]
        SuddenDeath = 86,
        [FastEnumUtility.Label("CTS_NotDamaged", 0)]
        [FastEnumUtility.Label("Not Damaged", 1)]
        NotDamaged = 87,
        [FastEnumUtility.Label("CTS_FinalCut", 0)]
        [FastEnumUtility.Label("Final Cut", 1)]
        FinalCut = 88,
        [FastEnumUtility.Label("CTS_ThornsEffect", 0)]
        [FastEnumUtility.Label("Thorns Effect", 1)]
        ThornsEffect = 89,
        [FastEnumUtility.Label("CTS_SwallowAttackDamage", 0)]
        [FastEnumUtility.Label("Swallow Attack Damage", 1)]
        SwallowAttackDamage = 90,
        [FastEnumUtility.Label("CTS_MorewildDamageUp", 0)]
        [FastEnumUtility.Label("Morewild Damage Up", 1)]
        MorewildDamageUp = 91,
        [FastEnumUtility.Label("CTS_Mine", 0)]
        Mine = 92,
        [FastEnumUtility.Label("CTS_EMHP", 0)]
        EMHP = 93,
        [FastEnumUtility.Label("CTS_EMMP", 0)]
        EMMP = 94,
        [FastEnumUtility.Label("CTS_EPAD", 0)]
        EPAD = 95,
        [FastEnumUtility.Label("CTS_EPDD", 0)]
        EPDD = 96,
        [FastEnumUtility.Label("CTS_EMDD", 0)]
        EMDD = 97,
        [FastEnumUtility.Label("CTS_Guard", 0)]
        Guard = 98,
        [FastEnumUtility.Label("CTS_SafetyDamage", 0)]
        [FastEnumUtility.Label("Safety Damage", 1)]
        SafetyDamage = 99,
        [FastEnumUtility.Label("CTS_SafetyAbsorb", 0)]
        [FastEnumUtility.Label("Safety Absorb", 1)]
        SafetyAbsorb = 100,
        [FastEnumUtility.Label("CTS_Cyclone", 0)]
        Cyclone = 101,
        [FastEnumUtility.Label("CTS_SwallowCritical", 0)]
        [FastEnumUtility.Label("Swallow Critical", 1)]
        SwallowCritical = 102,
        [FastEnumUtility.Label("CTS_SwallowMaxMP", 0)]
        [FastEnumUtility.Label("Swallow Max MP", 1)]
        SwallowMaxMP = 103,
        [FastEnumUtility.Label("CTS_SwallowDefence", 0)]
        [FastEnumUtility.Label("Swallow Defence", 1)]
        SwallowDefence = 104,
        [FastEnumUtility.Label("CTS_SwallowEvasion", 0)]
        [FastEnumUtility.Label("Swallow Evasion", 1)]
        SwallowEvasion = 105,
        [FastEnumUtility.Label("CTS_Conversion", 0)]
        Conversion = 106,
        [FastEnumUtility.Label("CTS_Revive", 0)]
        Revive = 107,
        [FastEnumUtility.Label("CTS_Sneak", 0)]
        Sneak = 108,
        [FastEnumUtility.Label("CTS_Mechanic", 0)]
        Mechanic = 109,
        [FastEnumUtility.Label("CTS_Aura", 0)]
        Aura = 110,
        [FastEnumUtility.Label("CTS_DarkAura", 0)]
        [FastEnumUtility.Label("Dark Aura", 1)]
        DarkAura = 111,
        [FastEnumUtility.Label("Blue Aura", 1)]
        [FastEnumUtility.Label("CTS_BlueAura", 0)]
        BlueAura = 112,
        [FastEnumUtility.Label("CTS_YellowAura", 0)]
        [FastEnumUtility.Label("Yellow Aura", 1)]
        YellowAura = 113,
        [FastEnumUtility.Label("CTS_SuperBody", 0)]
        [FastEnumUtility.Label("Super Body", 1)]
        SuperBody = 114,
        [FastEnumUtility.Label("CTS_MorewildMaxHP", 0)]
        [FastEnumUtility.Label("Morewild Max HP", 1)]
        MorewildMaxHP = 115,
        [FastEnumUtility.Label("CTS_Dice", 0)]
        Dice = 116,
        [FastEnumUtility.Label("Blessing Armor", 1)]
        [FastEnumUtility.Label("CTS_BlessingArmor", 0)]
        BlessingArmor = 117,
        [FastEnumUtility.Label("CTS_DamR", 0)]
        [FastEnumUtility.Label("Dam R", 1)]
        DamR = 118,
        [FastEnumUtility.Label("CTS_TeleportMasteryOn", 0)]
        [FastEnumUtility.Label("Teleport Mastery On", 1)]
        TeleportMasteryOn = 119,
        [FastEnumUtility.Label("CTS_CombatOrders", 0)]
        [FastEnumUtility.Label("Combat Orders", 1)]
        CombatOrders = 120,
        [FastEnumUtility.Label("CTS_Beholder", 0)]
        Beholder = 121,
        [FastEnumUtility.Label("CTS_EnergyCharged", 0)]
        [FastEnumUtility.Label("Energy Charged", 1)]
        EnergyCharged = 122,
        [FastEnumUtility.Label("CTS_Dash_Speed", 0)]
        [FastEnumUtility.Label("Dash Speed", 1)]
        DashSpeed = 123,
        [FastEnumUtility.Label("CTS_Dash_Jump", 0)]
        [FastEnumUtility.Label("Dash Jump", 1)]
        DashJump = 124,
        [FastEnumUtility.Label("CTS_RideVehicle", 0)]
        [FastEnumUtility.Label("Ride Vehicle", 1)]
        RideVehicle = 125,
        [FastEnumUtility.Label("CTS_PartyBooster", 0)]
        [FastEnumUtility.Label("Party Booster", 1)]
        PartyBooster = 126,
        [FastEnumUtility.Label("CTS_GuidedBullet", 0)]
        [FastEnumUtility.Label("Guided Bullet", 1)]
        GuidedBullet = 127,
        [FastEnumUtility.Label("CTS_Undead", 0)]
        Undead = 128,
        [FastEnumUtility.Label("CTS_SummonBomb", 0)]
        [FastEnumUtility.Label("Summon Bomb", 1)]
        SummonBomb = 129,
    }
    public enum TeslaCoilRole : byte
    {
        [FastEnumUtility.Label("TESLACOIL_START", 0)]
        Start = 0,
        [FastEnumUtility.Label("TESLACOIL_LEADER", 0)]
        Leader = 1,
        [FastEnumUtility.Label("TESLACOIL_FOLLOWER", 0)]
        Follower = 2,
    }
    public enum TooltipType : byte
    {
        [FastEnumUtility.Label("TT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("TT_STRING", 0)]
        String = 1,
        [FastEnumUtility.Label("TT_STRING2", 0)]
        String2 = 2,
        [FastEnumUtility.Label("TT_WORLDMAP", 0)]
        [FastEnumUtility.Label("World Map", 1)]
        WorldMap = 3,
        [FastEnumUtility.Label("TT_EQUIP", 0)]
        Equip = 4,
        [FastEnumUtility.Label("TT_BUNDLE", 0)]
        Bundle = 5,
        [FastEnumUtility.Label("TT_PET", 0)]
        Pet = 6,
        [FastEnumUtility.Label("TT_SKILL", 0)]
        Skill = 7,
        [FastEnumUtility.Label("TT_RING", 0)]
        Ring = 8,
        [FastEnumUtility.Label("TT_PACKAGE", 0)]
        Package = 9,
        [FastEnumUtility.Label("Slot Inc", 1)]
        [FastEnumUtility.Label("TT_SLOTINC", 0)]
        SlotInc = 10,
        [FastEnumUtility.Label("Macro Sys Skill", 1)]
        [FastEnumUtility.Label("TT_MACROSYSSKILL", 0)]
        MacroSysSkill = 11,
    }
    public enum TradeMoneyType : byte
    {
        [FastEnumUtility.Label("Drop Money", 1)]
        [FastEnumUtility.Label("TMP_DropMoney", 0)]
        DropMoney = 0,
        [FastEnumUtility.Label("TMP_TradeMoney", 0)]
        [FastEnumUtility.Label("Trade Money", 1)]
        TradeMoney = 1,
        [FastEnumUtility.Label("Shop Buy", 1)]
        [FastEnumUtility.Label("TMP_ShopBuy", 0)]
        ShopBuy = 2,
        [FastEnumUtility.Label("Shop Trade", 1)]
        [FastEnumUtility.Label("TMP_ShopTrade", 0)]
        ShopTrade = 3,
        [FastEnumUtility.Label("Parcel Money", 1)]
        [FastEnumUtility.Label("TMP_ParcelMoney", 0)]
        ParcelMoney = 4,
    }
    public enum TransferChannelResult : byte
    {
        [FastEnumUtility.Label("TC_DONE", 0)]
        Done = 0,
        [FastEnumUtility.Label("Game Server Disconnected", 1)]
        [FastEnumUtility.Label("TC_GAMESVR_DISCONNECTED", 0)]
        GameServerDisconnected = 1,
        [FastEnumUtility.Label("Shop Server Disconnected", 1)]
        [FastEnumUtility.Label("TC_SHOPSVR_DISCONNECTED", 0)]
        ShopServerDisconnected = 2,
        [FastEnumUtility.Label("Itc Server Disconnected", 1)]
        [FastEnumUtility.Label("TC_ITCSVR_DISCONNECTED", 0)]
        ItcServerDisconnected = 3,
        [FastEnumUtility.Label("Itc Server Over Limit User", 1)]
        [FastEnumUtility.Label("TC_ITCSVR_OVERLIMITUSER", 0)]
        ItcServerOverLimitUser = 4,
        [FastEnumUtility.Label("Itc Server Low Level User", 1)]
        [FastEnumUtility.Label("TC_ITCSVR_LOWLEVELUSER", 0)]
        ItcServerLowLevelUser = 5,
    }
    public enum TransferFieldResult : byte
    {
        [FastEnumUtility.Label("TF_DONE", 0)]
        Done = 0,
        [FastEnumUtility.Label("Disabled Portal", 1)]
        [FastEnumUtility.Label("TF_DISABLED_PORTAL", 0)]
        DisabledPortal = 1,
        [FastEnumUtility.Label("Not Connected Area", 1)]
        [FastEnumUtility.Label("TF_NOT_CONNECTED_AREA", 0)]
        NotConnectedArea = 2,
        [FastEnumUtility.Label("Not Allowed Level", 1)]
        [FastEnumUtility.Label("TF_NOT_ALLOWED_LEVEL", 0)]
        NotAllowedLevel = 3,
        [FastEnumUtility.Label("Not Allowed Level Item", 1)]
        [FastEnumUtility.Label("TF_NOT_ALLOWED_LEVEL_ITEM", 0)]
        NotAllowedLevelItem = 4,
        [FastEnumUtility.Label("Not Allowed Level MD", 1)]
        [FastEnumUtility.Label("TF_NOT_ALLOWED_LEVEL_MD", 0)]
        NotAllowedLevelMD = 5,
        [FastEnumUtility.Label("Party Only", 1)]
        [FastEnumUtility.Label("TF_PARTY_ONLY", 0)]
        PartyOnly = 6,
        [FastEnumUtility.Label("Expedition Only", 1)]
        [FastEnumUtility.Label("TF_EXPEDITION_ONLY", 0)]
        ExpeditionOnly = 7,
        [FastEnumUtility.Label("Not Available Shop", 1)]
        [FastEnumUtility.Label("TF_NOT_AVAILABLE_SHOP", 0)]
        NotAvailableShop = 8,
    }
    public enum TrunkOperation : byte
    {
        [FastEnumUtility.Label("Req Load", 1)]
        [FastEnumUtility.Label("TrunkReq_Load", 0)]
        ReqLoad = 0,
        [FastEnumUtility.Label("Req Save", 1)]
        [FastEnumUtility.Label("TrunkReq_Save", 0)]
        ReqSave = 1,
        [FastEnumUtility.Label("Req Close", 1)]
        [FastEnumUtility.Label("TrunkReq_Close", 0)]
        ReqClose = 2,
        [FastEnumUtility.Label("Req Check SSN2", 1)]
        [FastEnumUtility.Label("TrunkReq_CheckSSN2", 0)]
        ReqCheckSSN2 = 3,
        [FastEnumUtility.Label("Req Get Item", 1)]
        [FastEnumUtility.Label("TrunkReq_GetItem", 0)]
        ReqGetItem = 4,
        [FastEnumUtility.Label("Req Put Item", 1)]
        [FastEnumUtility.Label("TrunkReq_PutItem", 0)]
        ReqPutItem = 5,
        [FastEnumUtility.Label("Req Sort Item", 1)]
        [FastEnumUtility.Label("TrunkReq_SortItem", 0)]
        ReqSortItem = 6,
        [FastEnumUtility.Label("Req Money", 1)]
        [FastEnumUtility.Label("TrunkReq_Money", 0)]
        ReqMoney = 7,
        [FastEnumUtility.Label("Req Close Dialog", 1)]
        [FastEnumUtility.Label("TrunkReq_CloseDialog", 0)]
        ReqCloseDialog = 8,
        [FastEnumUtility.Label("Res Get Success", 1)]
        [FastEnumUtility.Label("TrunkRes_GetSuccess", 0)]
        ResGetSuccess = 9,
        [FastEnumUtility.Label("Res Get Unknown", 1)]
        [FastEnumUtility.Label("TrunkRes_GetUnknown", 0)]
        ResGetUnknown = 10,
        [FastEnumUtility.Label("Res Get No Money", 1)]
        [FastEnumUtility.Label("TrunkRes_GetNoMoney", 0)]
        ResGetNoMoney = 11,
        [FastEnumUtility.Label("Res Get Having Only Item", 1)]
        [FastEnumUtility.Label("TruncRes_GetHavingOnlyItem", 0)]
        ResGetHavingOnlyItem = 12,
        [FastEnumUtility.Label("Res Put Success", 1)]
        [FastEnumUtility.Label("TrunkRes_PutSuccess", 0)]
        ResPutSuccess = 13,
        [FastEnumUtility.Label("Res Put Incorrect Request", 1)]
        [FastEnumUtility.Label("TrunkRes_PutIncorrectRequest", 0)]
        ResPutIncorrectRequest = 14,
        [FastEnumUtility.Label("Res Sort Item", 1)]
        [FastEnumUtility.Label("TrunkRes_SortItem", 0)]
        ResSortItem = 15,
        [FastEnumUtility.Label("Res Put No Money", 1)]
        [FastEnumUtility.Label("TrunkRes_PutNoMoney", 0)]
        ResPutNoMoney = 16,
        [FastEnumUtility.Label("Res Put No Space", 1)]
        [FastEnumUtility.Label("TrunkRes_PutNoSpace", 0)]
        ResPutNoSpace = 17,
        [FastEnumUtility.Label("Res Put Unknown", 1)]
        [FastEnumUtility.Label("TrunkRes_PutUnknown", 0)]
        ResPutUnknown = 18,
        [FastEnumUtility.Label("Res Money Success", 1)]
        [FastEnumUtility.Label("TrunkRes_MoneySuccess", 0)]
        ResMoneySuccess = 19,
        [FastEnumUtility.Label("Res Money Unknown", 1)]
        [FastEnumUtility.Label("TrunkRes_MoneyUnknown", 0)]
        ResMoneyUnknown = 20,
        [FastEnumUtility.Label("Res Check SSN2", 1)]
        [FastEnumUtility.Label("TrunkRes_TrunkCheckSSN2", 0)]
        ResCheckSSN2 = 21,
        [FastEnumUtility.Label("Res Open Trunk Dialog", 1)]
        [FastEnumUtility.Label("TrunkRes_OpenTrunkDlg", 0)]
        ResOpenTrunkDialog = 22,
        [FastEnumUtility.Label("Res Trade Blocked", 1)]
        [FastEnumUtility.Label("TrunkRes_TradeBlocked", 0)]
        ResTradeBlocked = 23,
        [FastEnumUtility.Label("Res Server Msg", 1)]
        [FastEnumUtility.Label("TrunkRes_ServerMsg", 0)]
        ResServerMsg = 24,
    }
    public enum TwoStateIndex : byte
    {
        [FastEnumUtility.Label("Energy Charged", 1)]
        [FastEnumUtility.Label("TS_ENERGY_CHARGED", 0)]
        EnergyCharged = 0,
        [FastEnumUtility.Label("Dash Speed", 1)]
        [FastEnumUtility.Label("TS_DASH_SPEED", 0)]
        DashSpeed = 1,
        [FastEnumUtility.Label("Dash Jump", 1)]
        [FastEnumUtility.Label("TS_DASH_JUMP", 0)]
        DashJump = 2,
        [FastEnumUtility.Label("Ride Vehicle", 1)]
        [FastEnumUtility.Label("TS_RIDE_VEHICLE", 0)]
        RideVehicle = 3,
        [FastEnumUtility.Label("Party Booster", 1)]
        [FastEnumUtility.Label("TS_PARTY_BOOSTER", 0)]
        PartyBooster = 4,
        [FastEnumUtility.Label("Guided Bullet", 1)]
        [FastEnumUtility.Label("TS_GUIDED_BULLET", 0)]
        GuidedBullet = 5,
        [FastEnumUtility.Label("TS_UNDEAD", 0)]
        Undead = 6,
    }
    public enum UserEffectType : byte
    {
        [FastEnumUtility.Label("Level Up", 1)]
        [FastEnumUtility.Label("UserEffect_LevelUp", 0)]
        LevelUp = 0,
        [FastEnumUtility.Label("Skill Use", 1)]
        [FastEnumUtility.Label("UserEffect_SkillUse", 0)]
        SkillUse = 1,
        [FastEnumUtility.Label("Skill Affected", 1)]
        [FastEnumUtility.Label("UserEffect_SkillAffected", 0)]
        SkillAffected = 2,
        [FastEnumUtility.Label("Skill Affected Select", 1)]
        [FastEnumUtility.Label("UserEffect_SkillAffected_Select", 0)]
        SkillAffectedSelect = 3,
        [FastEnumUtility.Label("Skill Special Affected", 1)]
        [FastEnumUtility.Label("UserEffect_SkillSpecialAffected", 0)]
        SkillSpecialAffected = 4,
        [FastEnumUtility.Label("UserEffect_Quest", 0)]
        Quest = 5,
        [FastEnumUtility.Label("UserEffect_Pet", 0)]
        Pet = 6,
        [FastEnumUtility.Label("Skill Special", 1)]
        [FastEnumUtility.Label("UserEffect_SkillSpecial", 0)]
        SkillSpecial = 7,
        [FastEnumUtility.Label("Protect On Die Item Use", 1)]
        [FastEnumUtility.Label("UserEffect_ProtectOnDieItemUse", 0)]
        ProtectOnDieItemUse = 8,
        [FastEnumUtility.Label("Play Portal Sound Effect", 1)]
        [FastEnumUtility.Label("UserEffect_PlayPortalSE", 0)]
        PlayPortalSoundEffect = 9,
        [FastEnumUtility.Label("Job Changed", 1)]
        [FastEnumUtility.Label("UserEffect_JobChanged", 0)]
        JobChanged = 10,
        [FastEnumUtility.Label("Quest Complete", 1)]
        [FastEnumUtility.Label("UserEffect_QuestComplete", 0)]
        QuestComplete = 11,
        [FastEnumUtility.Label("Inc Dec Hp Effect", 1)]
        [FastEnumUtility.Label("UserEffect_IncDecHPEffect", 0)]
        IncDecHpEffect = 12,
        [FastEnumUtility.Label("Buff Item Effect", 1)]
        [FastEnumUtility.Label("UserEffect_BuffItemEffect", 0)]
        BuffItemEffect = 13,
        [FastEnumUtility.Label("Squib Effect", 1)]
        [FastEnumUtility.Label("UserEffect_SquibEffect", 0)]
        SquibEffect = 14,
        [FastEnumUtility.Label("Monster Book Card Get", 1)]
        [FastEnumUtility.Label("UserEffect_MonsterBookCardGet", 0)]
        MonsterBookCardGet = 15,
        [FastEnumUtility.Label("Lottery Use", 1)]
        [FastEnumUtility.Label("UserEffect_LotteryUse", 0)]
        LotteryUse = 16,
        [FastEnumUtility.Label("Item Level Up", 1)]
        [FastEnumUtility.Label("UserEffect_ItemLevelUp", 0)]
        ItemLevelUp = 17,
        [FastEnumUtility.Label("Item Maker", 1)]
        [FastEnumUtility.Label("UserEffect_ItemMaker", 0)]
        ItemMaker = 18,
        [FastEnumUtility.Label("Exp Item Consumed", 1)]
        [FastEnumUtility.Label("UserEffect_ExpItemConsumed", 0)]
        ExpItemConsumed = 19,
        [FastEnumUtility.Label("Reserved Effect", 1)]
        [FastEnumUtility.Label("UserEffect_ReservedEffect", 0)]
        ReservedEffect = 20,
        [FastEnumUtility.Label("UserEffect_Buff", 0)]
        Buff = 21,
        [FastEnumUtility.Label("Consume Effect", 1)]
        [FastEnumUtility.Label("UserEffect_ConsumeEffect", 0)]
        ConsumeEffect = 22,
        [FastEnumUtility.Label("Upgrade Tomb Item Use", 1)]
        [FastEnumUtility.Label("UserEffect_UpgradeTombItemUse", 0)]
        UpgradeTombItemUse = 23,
        [FastEnumUtility.Label("Battlefield Item Use", 1)]
        [FastEnumUtility.Label("UserEffect_BattlefieldItemUse", 0)]
        BattlefieldItemUse = 24,
        [FastEnumUtility.Label("Avatar Oriented", 1)]
        [FastEnumUtility.Label("UserEffect_AvatarOriented", 0)]
        AvatarOriented = 25,
        [FastEnumUtility.Label("Incubator Use", 1)]
        [FastEnumUtility.Label("UserEffect_IncubatorUse", 0)]
        IncubatorUse = 26,
        [FastEnumUtility.Label("Play Sound With Mute Bgm", 1)]
        [FastEnumUtility.Label("UserEffect_PlaySoundWithMuteBGM", 0)]
        PlaySoundWithMuteBgm = 27,
        [FastEnumUtility.Label("Soul Stone Use", 1)]
        [FastEnumUtility.Label("UserEffect_SoulStoneUse", 0)]
        SoulStoneUse = 28,
        [FastEnumUtility.Label("Inc Dec Hp Effect Ex", 1)]
        [FastEnumUtility.Label("UserEffect_IncDecHPEffect_EX", 0)]
        IncDecHpEffectEx = 29,
        [FastEnumUtility.Label("Delivery Quest Item Use", 1)]
        [FastEnumUtility.Label("UserEffect_DeliveryQuestItemUse", 0)]
        DeliveryQuestItemUse = 30,
        [FastEnumUtility.Label("Repeat Effect Remove", 1)]
        [FastEnumUtility.Label("UserEffect_RepeatEffectRemove", 0)]
        RepeatEffectRemove = 31,
        [FastEnumUtility.Label("Evol Ring", 1)]
        [FastEnumUtility.Label("UserEffect_EvolRing", 0)]
        EvolRing = 32,
    }
    public enum VideoState : byte
    {
        [FastEnumUtility.Label("VIDEO_STATE_UNAVAILABLE", 0)]
        Unavailable = 0,
        [FastEnumUtility.Label("VIDEO_STATE_IDLE", 0)]
        Idle = 1,
        [FastEnumUtility.Label("VIDEO_STATE_READY", 0)]
        Ready = 2,
        [FastEnumUtility.Label("VIDEO_STATE_PLAY", 0)]
        Play = 3,
        [FastEnumUtility.Label("VIDEO_STATE_PAUSE", 0)]
        Pause = 4,
        [FastEnumUtility.Label("VIDEO_STATE_END", 0)]
        End = 5,
    }
    [System.Flags]
    public enum WeaponAttackFlag
    {
        None = 0,
        [FastEnumUtility.Label("1H Sword", 1)]
        [FastEnumUtility.Label("AI_OH_SWORD", 0)]
        OhSword = 1,
        [FastEnumUtility.Label("1H Axe", 1)]
        [FastEnumUtility.Label("AI_OH_AXE", 0)]
        OhAxe = 2,
        [FastEnumUtility.Label("1H Mace", 1)]
        [FastEnumUtility.Label("AI_OH_MACE", 0)]
        OhMace = 4,
        [FastEnumUtility.Label("AI_DAGGER", 0)]
        Dagger = 8,
        [FastEnumUtility.Label("AI_WAND", 0)]
        Wand = 16,
        [FastEnumUtility.Label("AI_STAFF", 0)]
        Staff = 32,
        [FastEnumUtility.Label("AI_BAREHAND", 0)]
        [FastEnumUtility.Label("Bare Hand", 1)]
        BareHand = 64,
        [FastEnumUtility.Label("2H Sword", 1)]
        [FastEnumUtility.Label("AI_TH_SWORD", 0)]
        ThSword = 128,
        [FastEnumUtility.Label("2H Axe", 1)]
        [FastEnumUtility.Label("AI_TH_AXE", 0)]
        ThAxe = 256,
        [FastEnumUtility.Label("2H Mace", 1)]
        [FastEnumUtility.Label("AI_TH_MACE", 0)]
        ThMace = 512,
        [FastEnumUtility.Label("AI_SPEAR", 0)]
        Spear = 1024,
        [FastEnumUtility.Label("AI_POLEARM", 0)]
        Polearm = 2048,
        [FastEnumUtility.Label("AI_BOW", 0)]
        Bow = 4096,
        [FastEnumUtility.Label("AI_CROSSBOW", 0)]
        Crossbow = 8192,
        [FastEnumUtility.Label("AI_THROWINGGLOVE", 0)]
        [FastEnumUtility.Label("Throwing Glove", 1)]
        ThrowingGlove = 16384,
        [FastEnumUtility.Label("AI_KNUCKLE", 0)]
        Knuckle = 32768,
        [FastEnumUtility.Label("AI_GUN", 0)]
        Gun = 65536,
    }
    public enum WeaponType : sbyte
    {
        [FastEnumUtility.Label("Any Weapon", 1)]
        [FastEnumUtility.Label("WT_NOTCHECK_SUBWEPPON", 0)]
        NotCheckSubWeapon = -1,
        [FastEnumUtility.Label("WT_NONE", 0)]
        None = 0,
        [FastEnumUtility.Label("1H Sword", 1)]
        [FastEnumUtility.Label("WT_OH_SWORD", 0)]
        OhSword = 30,
        [FastEnumUtility.Label("1H Axe", 1)]
        [FastEnumUtility.Label("WT_OH_AXE", 0)]
        OhAxe = 31,
        [FastEnumUtility.Label("1H Mace", 1)]
        [FastEnumUtility.Label("WT_OH_MACE", 0)]
        OhMace = 32,
        [FastEnumUtility.Label("WT_DAGGER", 0)]
        Dagger = 33,
        [FastEnumUtility.Label("Sub-Dagger", 1)]
        [FastEnumUtility.Label("WT_SUB_DAGGER", 0)]
        SubDagger = 34,
        [FastEnumUtility.Label("WT_WAND", 0)]
        Wand = 37,
        [FastEnumUtility.Label("WT_STAFF", 0)]
        Staff = 38,
        [FastEnumUtility.Label("Bare Hand", 1)]
        [FastEnumUtility.Label("WT_BAREHAND", 0)]
        BareHand = 39,
        [FastEnumUtility.Label("2H Sword", 1)]
        [FastEnumUtility.Label("WT_TH_SWORD", 0)]
        ThSword = 40,
        [FastEnumUtility.Label("2H Axe", 1)]
        [FastEnumUtility.Label("WT_TH_AXE", 0)]
        ThAxe = 41,
        [FastEnumUtility.Label("2H Mace", 1)]
        [FastEnumUtility.Label("WT_TH_MACE", 0)]
        ThMace = 42,
        [FastEnumUtility.Label("WT_SPEAR", 0)]
        Spear = 43,
        [FastEnumUtility.Label("WT_POLEARM", 0)]
        Polearm = 44,
        [FastEnumUtility.Label("WT_BOW", 0)]
        Bow = 45,
        [FastEnumUtility.Label("WT_CROSSBOW", 0)]
        Crossbow = 46,
        [FastEnumUtility.Label("WT_THROWINGGLOVE", 0)]
        Claw = 47,
        [FastEnumUtility.Label("WT_KNUCKLE", 0)]
        Knuckle = 48,
        [FastEnumUtility.Label("WT_GUN", 0)]
        Gun = 49,
    }
    public enum WeddingType : byte
    {
        [FastEnumUtility.Label("WT_CATHEDRAL", 0)]
        Cathedral = 1,
        [FastEnumUtility.Label("WT_VEGAS", 0)]
        Vegas = 2,
        [FastEnumUtility.Label("Cathedral Premium", 1)]
        [FastEnumUtility.Label("WT_CATHEDRAL_PREMIUM", 0)]
        CathedralPremium = 10,
        [FastEnumUtility.Label("Cathedral Normal", 1)]
        [FastEnumUtility.Label("WT_CATHEDRAL_NORMAL", 0)]
        CathedralNormal = 11,
        [FastEnumUtility.Label("Vegas Premium", 1)]
        [FastEnumUtility.Label("WT_VEGAS_PREMIUM", 0)]
        VegasPremium = 20,
        [FastEnumUtility.Label("Vegas Normal", 1)]
        [FastEnumUtility.Label("WT_VEGAS_NORMAL", 0)]
        VegasNormal = 21,
    }
    public enum WeddingWishListOperation : byte
    {
        [FastEnumUtility.Label("Req Give Load", 1)]
        [FastEnumUtility.Label("WeddingWLReq_GiveLoad", 0)]
        ReqGiveLoad = 0,
        [FastEnumUtility.Label("Req Give Save", 1)]
        [FastEnumUtility.Label("WeddingWLReq_GiveSave", 0)]
        ReqGiveSave = 1,
        [FastEnumUtility.Label("Req Give Close", 1)]
        [FastEnumUtility.Label("WeddingWLReq_GiveClose", 0)]
        ReqGiveClose = 2,
        [FastEnumUtility.Label("Req Recv Load", 1)]
        [FastEnumUtility.Label("WeddingWLReq_RecvLoad", 0)]
        ReqRecvLoad = 3,
        [FastEnumUtility.Label("Req Recv Save", 1)]
        [FastEnumUtility.Label("WeddingWLReq_RecvSave", 0)]
        ReqRecvSave = 4,
        [FastEnumUtility.Label("Req Recv Close", 1)]
        [FastEnumUtility.Label("WeddingWLReq_RecvClose", 0)]
        ReqRecvClose = 5,
        [FastEnumUtility.Label("Req Put Item", 1)]
        [FastEnumUtility.Label("WeddingWLReq_PutItem", 0)]
        ReqPutItem = 6,
        [FastEnumUtility.Label("Req Get Item", 1)]
        [FastEnumUtility.Label("WeddingWLReq_GetItem", 0)]
        ReqGetItem = 7,
        [FastEnumUtility.Label("Req Close Dialog", 1)]
        [FastEnumUtility.Label("WeddingWLReq_CloseDialog", 0)]
        ReqCloseDialog = 8,
        [FastEnumUtility.Label("Res Open Give Wish List Dlg", 1)]
        [FastEnumUtility.Label("WeddingWLRes_OpenGiveWishListDlg", 0)]
        ResOpenGiveWishListDlg = 9,
        [FastEnumUtility.Label("Res Open Recv Wish List Dlg", 1)]
        [FastEnumUtility.Label("WeddingWLRes_OpenRecvWishListDlg", 0)]
        ResOpenRecvWishListDlg = 10,
        [FastEnumUtility.Label("Res Put Success", 1)]
        [FastEnumUtility.Label("WeddingWLRes_PutSuccess", 0)]
        ResPutSuccess = 11,
        [FastEnumUtility.Label("Res Put No Space", 1)]
        [FastEnumUtility.Label("WeddingWLRes_PutNoSpace", 0)]
        ResPutNoSpace = 12,
        [FastEnumUtility.Label("Res Put Incorrect Request", 1)]
        [FastEnumUtility.Label("WeddingWLRes_PutIncorrectRequest", 0)]
        ResPutIncorrectRequest = 13,
        [FastEnumUtility.Label("Res Put Unknown", 1)]
        [FastEnumUtility.Label("WeddingWLRes_PutUnknown", 0)]
        ResPutUnknown = 14,
        [FastEnumUtility.Label("Res Get Success", 1)]
        [FastEnumUtility.Label("WeddingWLRes_GetSuccess", 0)]
        ResGetSuccess = 15,
        [FastEnumUtility.Label("Res Get Unknown", 1)]
        [FastEnumUtility.Label("WeddingWLRes_GetUnknown", 0)]
        ResGetUnknown = 16,
        [FastEnumUtility.Label("Res Get Having Only Item", 1)]
        [FastEnumUtility.Label("WeddingWLRes_GetHavingOnlyItem", 0)]
        ResGetHavingOnlyItem = 17,
    }
    [System.Flags]
    public enum WhisperOperation : byte
    {
        [FastEnumUtility.Label("WP_Location", 0)]
        Location = 1,
        [FastEnumUtility.Label("WP_Whisper", 0)]
        Whisper = 2,
        [FastEnumUtility.Label("WP_Request", 0)]
        Request = 4,
        [FastEnumUtility.Label("WP_Result", 0)]
        Result = 8,
        [FastEnumUtility.Label("WP_Receive", 0)]
        Receive = 16,
        [FastEnumUtility.Label("WP_Blocked", 0)]
        Blocked = 32,
        [FastEnumUtility.Label("Location Friend", 1)]
        [FastEnumUtility.Label("WP_Location_F", 0)]
        LocationFriend = 64,
        [FastEnumUtility.Label("WP_Manager", 0)]
        Manager = 128,
    }
    public enum WhiteScrollOption : byte
    {
        [FastEnumUtility.Label("Not Set", 1)]
        [FastEnumUtility.Label("WHITE_SCROLL_NOT_SET", 0)]
        NotSet = 0,
        [FastEnumUtility.Label("No Use", 1)]
        [FastEnumUtility.Label("WHITE_SCROLL_NO_USE", 0)]
        NoUse = 1,
        [FastEnumUtility.Label("WHITE_SCROLL_USE", 0)]
        Use = 2,
    }
    public enum WorldMoneyLogType : byte
    {
        [FastEnumUtility.Label("IssuedOnDrop", 0)]
        IssuedOnDrop = 0,
        [FastEnumUtility.Label("IssuedOnShop", 0)]
        IssuedOnShop = 1,
        [FastEnumUtility.Label("IssuedOnAdminShop", 0)]
        IssuedOnAdminShop = 2,
        [FastEnumUtility.Label("IssuedOnQuest", 0)]
        IssuedOnQuest = 3,
        [FastEnumUtility.Label("IssuedOnScript", 0)]
        IssuedOnScript = 4,
        [FastEnumUtility.Label("IssuedOnCoupon", 0)]
        IssuedOnCoupon = 5,
        [FastEnumUtility.Label("IssuedOnLieDetector", 0)]
        IssuedOnLieDetector = 6,
        [FastEnumUtility.Label("IssuedOnMiniGame", 0)]
        IssuedOnMiniGame = 7,
        [FastEnumUtility.Label("IssuedOnMoneyPocket", 0)]
        IssuedOnMoneyPocket = 8,
        [FastEnumUtility.Label("RecalledByShop", 0)]
        RecalledByShop = 100,
        [FastEnumUtility.Label("RecalledByAdminShop", 0)]
        RecalledByAdminShop = 101,
        [FastEnumUtility.Label("RecalledByTax", 0)]
        RecalledByTax = 102,
        [FastEnumUtility.Label("RecalledByQuest", 0)]
        RecalledByQuest = 103,
        [FastEnumUtility.Label("RecalledByScript", 0)]
        RecalledByScript = 104,
        [FastEnumUtility.Label("RecalledByExpire", 0)]
        RecalledByExpire = 105,
        [FastEnumUtility.Label("RecalledByItemMaker", 0)]
        RecalledByItemMaker = 106,
        [FastEnumUtility.Label("RecalledByLieDetector", 0)]
        RecalledByLieDetector = 107,
        [FastEnumUtility.Label("RecalledByMiniGame", 0)]
        RecalledByMiniGame = 108,
        [FastEnumUtility.Label("RecalledByClaim", 0)]
        RecalledByClaim = 109,
        [FastEnumUtility.Label("RecalledByMarriage", 0)]
        RecalledByMarriage = 110,
        [FastEnumUtility.Label("RecalledByFamily", 0)]
        RecalledByFamily = 111,
        [FastEnumUtility.Label("RecalledByFriend", 0)]
        RecalledByFriend = 112,
        [FastEnumUtility.Label("RecalledByGuild", 0)]
        RecalledByGuild = 113,
        [FastEnumUtility.Label("RecalledBySkill", 0)]
        RecalledBySkill = 114,
        [FastEnumUtility.Label("RecalledByPartyAdver", 0)]
        RecalledByPartyAdver = 115,
        [FastEnumUtility.Label("RecalledByRepairDurability", 0)]
        RecalledByRepairDurability = 116,
    }
}
```

## License

MIT
