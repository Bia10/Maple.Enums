using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Summoned creature enter/registration types.
/// </summary>
public enum SummonedEnterType : byte
{
    /// <summary>Default enter type.</summary>
    [Label("ENTER_TYPE_DEFAULT")]
    Default = 0,

    /// <summary>New summon created.</summary>
    [Label("ENTER_TYPE_CREATE_SUMMONED")]
    [Label("Create Summoned", 1)]
    CreateSummoned = 1,

    /// <summary>Existing summon re-registered.</summary>
    [Label("ENTER_TYPE_REREGISTER_SUMMONED")]
    [Label("Reregister Summoned", 1)]
    ReregisterSummoned = 2,
}
