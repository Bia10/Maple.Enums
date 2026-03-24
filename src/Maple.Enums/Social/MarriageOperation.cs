using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Marriage (engagement/wedding) operation codes.
/// </summary>
public enum MarriageOperation : byte
{
    /// <summary>Request marriage proposal.</summary>
    [Label("MarriageReq_Propose")]
    [Label("Req Propose", 1)]
    ReqPropose = 0,

    /// <summary>Cancel proposal request.</summary>
    [Label("MarriageReq_CancelPropose")]
    [Label("Req Cancel Propose", 1)]
    ReqCancelPropose = 1,

    /// <summary>Accept proposal request.</summary>
    [Label("MarriageReq_Accept")]
    [Label("Req Accept", 1)]
    ReqAccept = 2,

    /// <summary>Request break-up.</summary>
    [Label("MarriageReq_BreakUp")]
    [Label("Req Break Up", 1)]
    ReqBreakUp = 3,

    /// <summary>Request wedding reservation.</summary>
    [Label("MarriageReq_Reserve")]
    [Label("Req Reserve", 1)]
    ReqReserve = 4,

    /// <summary>Request send invitation.</summary>
    [Label("MarriageReq_Invite")]
    [Label("Req Invite", 1)]
    ReqInvite = 5,

    /// <summary>Request invitation details.</summary>
    [Label("MarriageReq_Invitation")]
    [Label("Req Invitation", 1)]
    ReqInvitation = 6,

    /// <summary>Request marriage ceremony.</summary>
    [Label("MarriageReq_Marry")]
    [Label("Req Marry", 1)]
    ReqMarry = 7,

    /// <summary>Request divorce.</summary>
    [Label("MarriageReq_Divorce")]
    [Label("Req Divorce", 1)]
    ReqDivorce = 8,

    /// <summary>Request wedding wish list.</summary>
    [Label("MarriageReq_WishList")]
    [Label("Req Wish List", 1)]
    ReqWishList = 9,

    /// <summary>Load reservation request.</summary>
    [Label("MarriageReq_LoadReservation")]
    [Label("Req Load Reservation", 1)]
    ReqLoadReservation = 10,

    /// <summary>Engagement confirmed.</summary>
    [Label("MarriageRes_Engaged")]
    [Label("Res Engaged", 1)]
    ResEngaged = 11,

    /// <summary>Marriage confirmed.</summary>
    [Label("MarriageRes_Married")]
    [Label("Res Married", 1)]
    ResMarried = 12,

    /// <summary>Break-up confirmed.</summary>
    [Label("MarriageRes_BrokeUp")]
    [Label("Res Broke Up", 1)]
    ResBrokeUp = 13,

    /// <summary>Divorce confirmed.</summary>
    [Label("MarriageRes_Divorced")]
    [Label("Res Divorced", 1)]
    ResDivorced = 14,

    /// <summary>Show wedding invitation.</summary>
    [Label("MarriageRes_ShowInvitation")]
    [Label("Res Show Invitation", 1)]
    ResShowInvitation = 15,

    /// <summary>Reservation completed.</summary>
    [Label("MarriageRes_ReservationDone")]
    [Label("Res Reservation Done", 1)]
    ResReservationDone = 16,

    /// <summary>Reservation loaded.</summary>
    [Label("MarriageRes_LoadReservationDone")]
    [Label("Res Load Reservation Done", 1)]
    ResLoadReservationDone = 17,

    /// <summary>Invalid character name.</summary>
    [Label("MarriageRes_WrongName")]
    [Label("Res Wrong Name", 1)]
    ResWrongName = 18,

    /// <summary>Not on same map.</summary>
    [Label("MarriageRes_NotSameMap")]
    [Label("Res Not Same Map", 1)]
    ResNotSameMap = 19,

    /// <summary>Requester inventory full.</summary>
    [Label("MarriageRes_RequesterNoEmptySlot")]
    [Label("Res Requester No Empty Slot", 1)]
    ResRequesterNoEmptySlot = 20,

    /// <summary>Target inventory full.</summary>
    [Label("MarriageRes_TargetNoEmptySlot")]
    [Label("Res Target No Empty Slot", 1)]
    ResTargetNoEmptySlot = 21,

    /// <summary>Invalid gender pairing.</summary>
    [Label("MarriageRes_WrongGender")]
    [Label("Res Wrong Gender", 1)]
    ResWrongGender = 22,

    /// <summary>Requester already engaged.</summary>
    [Label("MarriageRes_RequesterAlreadyEngaged")]
    [Label("Res Requester Already Engaged", 1)]
    ResRequesterAlreadyEngaged = 23,

    /// <summary>Target already engaged.</summary>
    [Label("MarriageRes_TargetAlreadyEngaged")]
    [Label("Res Target Already Engaged", 1)]
    ResTargetAlreadyEngaged = 24,

    /// <summary>Requester already married.</summary>
    [Label("MarriageRes_RequesterAlreadyMarried")]
    [Label("Res Requester Already Married", 1)]
    ResRequesterAlreadyMarried = 25,

    /// <summary>Target already married.</summary>
    [Label("MarriageRes_TargetAlreadyMarried")]
    [Label("Res Target Already Married", 1)]
    ResTargetAlreadyMarried = 26,

    /// <summary>Requester already in process.</summary>
    [Label("MarriageRes_RequesterAlreadyInProcess")]
    [Label("Res Requester Already In Process", 1)]
    ResRequesterAlreadyInProcess = 27,

    /// <summary>Target already in process.</summary>
    [Label("MarriageRes_TargetAlreadyInProcess")]
    [Label("Res Target Already In Process", 1)]
    ResTargetAlreadyInProcess = 28,

    /// <summary>Requester canceled.</summary>
    [Label("MarriageRes_RequesterCanceled")]
    [Label("Res Requester Canceled", 1)]
    ResRequesterCanceled = 29,

    /// <summary>Target refused proposal.</summary>
    [Label("MarriageRes_TargetRefused")]
    [Label("Res Target Refused", 1)]
    ResTargetRefused = 30,

    /// <summary>Reservation canceled.</summary>
    [Label("MarriageRes_ReservationCanceled")]
    [Label("Res Reservation Canceled", 1)]
    ResReservationCanceled = 31,

    /// <summary>Cannot break up post-reserve.</summary>
    [Label("MarriageRes_CantBreakupAfterReserve")]
    [Label("Res Cant Breakup After Reserve", 1)]
    ResCantBreakupAfterReserve = 32,

    /// <summary>Insufficient mesos.</summary>
    [Label("MarriageRes_NotEnoughMoney")]
    [Label("Res Not Enough Money", 1)]
    ResNotEnoughMoney = 33,

    /// <summary>Invalid marriage number.</summary>
    [Label("MarriageRes_WrongMarriageNo")]
    [Label("Res Wrong Marriage No", 1)]
    ResWrongMarriageNo = 34,

    /// <summary>Reservation failed.</summary>
    [Label("MarriageRes_ReservationFail")]
    [Label("Res Reservation Fail", 1)]
    ResReservationFail = 35,

    /// <summary>Unknown error.</summary>
    [Label("MarriageRes_Unknown")]
    [Label("Res Unknown", 1)]
    ResUnknown = 36,
}
