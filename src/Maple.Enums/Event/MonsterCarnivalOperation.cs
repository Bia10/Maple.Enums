using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Monster Carnival request/response operation types.
/// </summary>
/// <remarks>
/// Request (Req*) and Response (Res*) codes intentionally share numeric values because they
/// are distinguished by packet direction, not value. <c>Enum.ToString()</c> may return the
/// request name for a response value — callers must track context themselves.
/// </remarks>
public enum MonsterCarnivalOperation : byte
{
    /// <summary>Request to summon a mob.</summary>
    [Label("MCarnivalReq_SummonMob")]
    [Label("Req Summon Mob", 1)]
    ReqSummonMob = 0,

    /// <summary>Request to use a carnival skill.</summary>
    [Label("MCarnivalReq_UseSkill")]
    [Label("Req Use Skill", 1)]
    ReqUseSkill = 1,

    /// <summary>Request to summon a guardian.</summary>
    [Label("MCarnivalReq_SummonGuardian")]
    [Label("Req Summon Guardian", 1)]
    ReqSummonGuardian = 2,

    /// <summary>Failure: insufficient Carnival Points.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("MCarnivalRes_Fail_CPLaking")]
    [Label("Res Fail Cp Lacking", 1)]
    ResFailCpLacking = 1,

    /// <summary>Failure: mob count exceeded.</summary>
    [Label("MCarnivalRes_Fail_MobOverflow")]
    [Label("Res Fail Mob Overflow", 1)]
    ResFailMobOverflow = 2,

    /// <summary>Failure: guardian count exceeded.</summary>
    [Label("MCarnivalRes_Fail_GuardianOverflow")]
    [Label("Res Fail Guardian Overflow", 1)]
    ResFailGuardianOverflow = 3,

    /// <summary>Failure: guardian already summoned at this position.</summary>
    [Label("MCarnivalRes_Fail_GuardianAlreadySummoned")]
    [Label("Res Fail Guardian Already Summoned", 1)]
    ResFailGuardianAlreadySummoned = 4,

    /// <summary>Failure: unknown error.</summary>
    [Label("MCarnivalRes_Fail_Unknown")]
    [Label("Res Fail Unknown", 1)]
    ResFailUnknown = 5,

    /// <summary>Party leader left the carnival.</summary>
    [Label("MCarnivalOut_PartyBoss")]
    [Label("Out Party Boss", 1)]
    OutPartyBoss = 6,

    /// <summary>Party member left the carnival.</summary>
    [Label("MCarnivalOut_PartyMember")]
    [Label("Out Party Member", 1)]
    OutPartyMember = 7,

    /// <summary>Game result: victory.</summary>
    [Label("MCarnivalGameRes_Win")]
    [Label("Game Res Win", 1)]
    GameResWin = 8,

    /// <summary>Game result: defeat.</summary>
    [Label("MCarnivalGameRes_Lose")]
    [Label("Game Res Lose", 1)]
    GameResLose = 9,

    /// <summary>Game result: draw.</summary>
    [Label("MCarnivalGameRes_Draw")]
    [Label("Game Res Draw", 1)]
    GameResDraw = 10,

    /// <summary>Game result: cancelled.</summary>
    [Label("MCarnivalGameRes_Cancel")]
    [Label("Game Res Cancel", 1)]
    GameResCancel = 11,
}
