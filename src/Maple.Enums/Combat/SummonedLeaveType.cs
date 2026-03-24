using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Summoned creature leave/removal reasons.
/// </summary>
public enum SummonedLeaveType : byte
{
    /// <summary>Update/refresh summoned state.</summary>
    [Label("LEAVE_TYPE_UPDATE")]
    Update = 0,

    /// <summary>Summoned creature died.</summary>
    [Label("LEAVE_TYPE_SUMMONED_DEAD")]
    [Label("Summoned Dead", 1)]
    SummonedDead = 1,

    /// <summary>Unknown/mystery removal.</summary>
    [Label("LEAVE_TYPE_MYSTERY")]
    Mystery = 2,

    /// <summary>Default removal reason.</summary>
    [Label("LEAVE_TYPE_DEFAULT")]
    Default = 3,

    /// <summary>Owner left the field.</summary>
    [Label("LEAVE_TYPE_LEAVE_FIELD")]
    [Label("Leave Field", 1)]
    LeaveField = 4,

    /// <summary>Self-destruct timer expired.</summary>
    [Label("LEAVE_TYPE_SELF_DESTRUCT")]
    [Label("Self Destruct", 1)]
    SelfDestruct = 5,

    /// <summary>Corsair Gaviota skill ended.</summary>
    [Label("LEAVE_TYPE_GABIOTA")]
    Gabiota = 6,

    /// <summary>Entered a map that forbids summons.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("LEAVE_TYPE_ENTER_FORBIDEN_MAP")]
    [Label("Enter Forbidden Map", 1)]
    EnterForbiddenMap = 7,

    /// <summary>Entered an event field.</summary>
    [Label("LEAVE_TYPE_ENTER_EVENT_FIELD")]
    [Label("Enter Event Field", 1)]
    EnterEventField = 8,

    /// <summary>Owner died.</summary>
    [Label("LEAVE_TYPE_USER_DEAD")]
    [Label("User Dead", 1)]
    UserDead = 9,

    /// <summary>Explicitly removed by server.</summary>
    [Label("LEAVE_TYPE_ON_REMOVE")]
    [Label("On Remove", 1)]
    OnRemove = 10,

    /// <summary>Tesla coil placement error.</summary>
    [Label("LEAVE_TYPE_TESLACOIL_ERROR")]
    [Label("Tesla Coil Error", 1)]
    TeslaCoilError = 11,

    /// <summary>Multiple summons not allowed.</summary>
    [Label("LEAVE_TYPE_NOT_ABLE_MULTIPLE")]
    [Label("Not Able Multiple", 1)]
    NotAbleMultiple = 12,

    /// <summary>Did not self-destruct in time.</summary>
    [Label("LEAVE_TYPE_DIDNT_SELFDESTRUCT")]
    [Label("Did Not Self Destruct", 1)]
    DidNotSelfDestruct = 13,

    /// <summary>Maximum summoned count exceeded.</summary>
    [Label("LEAVE_TYPE_SUMMONED_COUNT_OVER")]
    [Label("Summoned Count Over", 1)]
    SummonedCountOver = 14,
}
