using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Party advertisement add/remove failure reasons and apply results.
/// </summary>
public enum PartyAdverResult : byte
{
    /// <summary>Add failed: advertisement already exists.</summary>
    [Label("AdverAddFailReason_AlreadyExist")]
    [Label("Add Fail Already Exist", 1)]
    AddFailAlreadyExist = 0,

    /// <summary>Add failed: banned by field set restrictions.</summary>
    [Label("AdverAddFailReason_BannedByFieldSet")]
    [Label("Add Fail Banned By Field Set", 1)]
    AddFailBannedByFieldSet = 1,

    /// <summary>Removed by user request.</summary>
    [Label("AdverRemoveReason_UserRequest")]
    [Label("Remove User Request", 1)]
    RemoveUserRequest = 2,

    /// <summary>Removed because party was disbanded.</summary>
    [Label("AdverRemoveReason_PartyRemoved")]
    [Label("Remove Party Removed", 1)]
    RemovePartyRemoved = 3,

    /// <summary>Removed because expedition was disbanded.</summary>
    [Label("AdverRemoveReason_ExpeditionRemoved")]
    [Label("Remove Expedition Removed", 1)]
    RemoveExpeditionRemoved = 4,

    /// <summary>Removed because party is full.</summary>
    [Label("AdverRemoveReason_FullParty")]
    [Label("Remove Full Party", 1)]
    RemoveFullParty = 5,

    /// <summary>Removed because expedition is full.</summary>
    [Label("AdverRemoveReason_FullExpedition")]
    [Label("Remove Full Expedition", 1)]
    RemoveFullExpedition = 6,

    /// <summary>Removed upon entering a field set.</summary>
    [Label("AdverRemoveReason_EnterFieldSet")]
    [Label("Remove Enter Field Set", 1)]
    RemoveEnterFieldSet = 7,

    /// <summary>Removed because tax payment failed.</summary>
    [Label("AdverRemoveReason_PayTaxFailed")]
    [Label("Remove Pay Tax Failed", 1)]
    RemovePayTaxFailed = 8,

    /// <summary>Removed because advertisement expired.</summary>
    [Label("AdverRemoveReason_TimeExpired")]
    [Label("Remove Time Expired", 1)]
    RemoveTimeExpired = 9,

    /// <summary>Application sent successfully.</summary>
    [Label("PartyAdverApplyResult_ApplySent")]
    [Label("Apply Result Apply Sent", 1)]
    ApplyResultApplySent = 10,

    /// <summary>Application was already sent.</summary>
    [Label("PartyAdverApplyResult_AlreadySent")]
    [Label("Apply Result Already Sent", 1)]
    ApplyResultAlreadySent = 11,

    /// <summary>Application rejected: user is blacklisted.</summary>
    [Label("PartyAdverApplyResult_BlackList")]
    [Label("Apply Result Black List", 1)]
    ApplyResultBlackList = 12,

    /// <summary>Application accepted.</summary>
    [Label("PartyAdverApplyResult_Accept")]
    [Label("Apply Result Accept", 1)]
    ApplyResultAccept = 13,

    /// <summary>Application rejected.</summary>
    [Label("PartyAdverApplyResult_Reject")]
    [Label("Apply Result Reject", 1)]
    ApplyResultReject = 14,
}
