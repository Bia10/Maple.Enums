using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Result of checking whether a skill can be used.
/// </summary>
public enum SkillUseCheckResult : byte
{
    /// <summary>Skill can be used.</summary>
    [Label("CanUseSkill")]
    CanUseSkill = 1,

    /// <summary>Insufficient HP.</summary>
    [Label("NoHPForSkill")]
    NoHpForSkill = 2,

    /// <summary>Insufficient MP.</summary>
    [Label("NoMPForSkill")]
    NoMpForSkill = 3,

    /// <summary>Insufficient mesos.</summary>
    [Label("NoMesoForSkill")]
    NoMesoForSkill = 4,
}
