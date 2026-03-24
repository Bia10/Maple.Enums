using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Anti-macro system operation codes.
/// </summary>
public enum AntiMacroOperation : byte
{
    /// <summary>Invalid character name.</summary>
    [Label("AntiMacroReq_Fail_InvalidCharacterName")]
    [Label("Req Fail Invalid Character Name", 1)]
    ReqFailInvalidCharacterName = 0,

    /// <summary>Target not attacking.</summary>
    [Label("AntiMacroReq_Fail_NotAttack")]
    [Label("Req Fail Not Attack", 1)]
    ReqFailNotAttack = 1,

    /// <summary>Cooldown not elapsed.</summary>
    [Label("AntiMacroReq_Fail_NotAvailableTime")]
    [Label("Req Fail Not Available Time", 1)]
    ReqFailNotAvailableTime = 2,

    /// <summary>Already solving a challenge.</summary>
    [Label("AntiMacroReq_Fail_SolvingQuestion")]
    [Label("Req Fail Solving Question", 1)]
    ReqFailSolvingQuestion = 3,

    /// <summary>Request queued.</summary>
    [Label("AntiMacroReq_Pended")]
    [Label("Req Pended", 1)]
    ReqPended = 4,

    /// <summary>Request accepted.</summary>
    [Label("AntiMacroReq_Success")]
    [Label("Req Success", 1)]
    ReqSuccess = 5,

    /// <summary>Response received.</summary>
    [Label("AntiMacroRes")]
    Res = 6,

    /// <summary>Answer incorrect.</summary>
    [Label("AntiMacroRes_Fail")]
    [Label("Res Fail", 1)]
    ResFail = 7,

    /// <summary>Target failed challenge.</summary>
    [Label("AntiMacroRes_TargetFail")]
    [Label("Res Target Fail", 1)]
    ResTargetFail = 8,

    /// <summary>Answer correct.</summary>
    [Label("AntiMacroRes_Success")]
    [Label("Res Success", 1)]
    ResSuccess = 9,

    /// <summary>Target passed challenge.</summary>
    [Label("AntiMacroRes_TargetSuccess")]
    [Label("Res Target Success", 1)]
    ResTargetSuccess = 10,

    /// <summary>Reward granted for passing.</summary>
    [Label("AntiMacroRes_Reward")]
    [Label("Res Reward", 1)]
    ResReward = 11,
}
