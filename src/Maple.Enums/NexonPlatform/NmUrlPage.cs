using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Target page identifier passed to Nexon Messenger URL-open calls.
/// </summary>
public enum NmUrlPage : byte
{
    /// <summary>No page.</summary>
    [Label("kURL_NULL")]
    Null = 0,

    /// <summary>Nexon main home page.</summary>
    [Label("kURL_MainHome")]
    MainHome = 1,

    /// <summary>Web game home page.</summary>
    [Label("kURL_WebGameHome")]
    WebGameHome = 2,

    /// <summary>RPG game home page.</summary>
    [Label("kURL_RPGGameHome")]
    RpgGameHome = 3,

    /// <summary>Casual game home page.</summary>
    [Label("kURL_CasualGameHome")]
    CasualGameHome = 4,

    /// <summary>Club home page.</summary>
    [Label("kURL_ClubHome")]
    ClubHome = 5,

    /// <summary>Plaza home page.</summary>
    [Label("kURL_PlazaHome")]
    PlazaHome = 6,

    /// <summary>Item mall home page.</summary>
    [Label("kURL_ItemMallHome")]
    ItemMallHome = 7,

    /// <summary>My page (user profile).</summary>
    [Label("kURL_MyPage")]
    MyPage = 8,

    /// <summary>Support / customer service page.</summary>
    [Label("kURL_Support")]
    Support = 9,

    /// <summary>Help page.</summary>
    [Label("kURL_Help")]
    Help = 10,

    /// <summary>Registration page.</summary>
    [Label("kURL_Register")]
    Register = 11,

    /// <summary>My gift box page.</summary>
    [Label("kURL_MyGiftBox")]
    MyGiftBox = 12,

    /// <summary>NX pay bill page.</summary>
    [Label("kURL_NXPaybill")]
    NxPaybill = 13,

    /// <summary>Member popup (by OID).</summary>
    [Label("kURL_MemberPopup_OID")]
    MemberPopupByOid = 14,

    /// <summary>Terms of service agreement popup.</summary>
    [Label("kURL_AgreementPopup")]
    AgreementPopup = 15,

    /// <summary>Privacy policy popup.</summary>
    [Label("kURL_PrivacyPopup")]
    PrivacyPopup = 16,

    /// <summary>Find/search ID popup.</summary>
    [Label("kURL_SearchIDPopup")]
    SearchIdPopup = 17,

    /// <summary>Search/find password page.</summary>
    [Label("kURL_SearchPass")]
    SearchPass = 18,

    /// <summary>NX money refill for web game.</summary>
    [Label("kURL_MoneyRefillForWebGame")]
    MoneyRefillForWebGame = 19,

    /// <summary>My personal room page for web games.</summary>
    [Label("kURL_MyRoomForWegGame")]
    MyRoomForWebGame = 20,

    /// <summary>Change clothes / avatar page.</summary>
    [Label("kURL_ChangeClothes")]
    ChangeClothes = 21,

    /// <summary>Change personal info page.</summary>
    [Label("kURL_ChangeMyInfo")]
    ChangeMyInfo = 22,

    /// <summary>Mail home page.</summary>
    [Label("kURL_MailHome")]
    MailHome = 23,

    /// <summary>Write general mail page.</summary>
    [Label("kURL_WriteMail_General")]
    WriteMailGeneral = 24,

    /// <summary>Write targeted mail page.</summary>
    [Label("kURL_WriteMail_Target")]
    WriteMailTarget = 25,

    /// <summary>Member popup (by login ID).</summary>
    [Label("kURL_MemberPopup_LoginID")]
    MemberPopupByLoginId = 26,

    /// <summary>Penalty / violation info page.</summary>
    [Label("kURL_Penalty")]
    Penalty = 27,

    /// <summary>Kart box page (by OID).</summary>
    [Label("kURL_KartBox_OID")]
    KartBoxByOid = 28,

    /// <summary>Kart box page (by rider ID).</summary>
    [Label("kURL_KartBox_RiderID")]
    KartBoxByRiderId = 29,

    /// <summary>Kart box page (by rider name).</summary>
    [Label("kURL_KartBox_RiderName")]
    KartBoxByRiderName = 30,

    /// <summary>NGM (Nexon Game Manager) install guide page.</summary>
    [Label("kURL_NGMInstallGuide")]
    NgmInstallGuide = 31,
}
