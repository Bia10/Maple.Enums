using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest guide sub-protocol for the reward mob system.
/// </summary>
public enum QuestGuideOperation : byte
{
    /// <summary>Request reward mob info.</summary>
    [Label("QuestGuideReq_RewardMob")]
    [Label("Req Reward Mob", 1)]
    ReqRewardMob = 0,

    /// <summary>Reward mob response.</summary>
    [Label("QuestGuideRes_RewardMob")]
    [Label("Res Reward Mob", 1)]
    ResRewardMob = 1,

    /// <summary>Reset reward mob.</summary>
    [Label("QuestGuideRes_ResetRewardMob")]
    [Label("Res Reset Reward Mob", 1)]
    ResResetRewardMob = 2,
}
