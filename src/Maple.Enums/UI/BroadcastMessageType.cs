using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Broadcast message type.
/// Server-side message delivery modes.
/// </summary>
public enum BroadcastMessageType : byte
{
    /// <summary>Server notice in chat.</summary>
    [Label("BM_NOTICE")]
    Notice = 0,

    /// <summary>Pop-up alert dialog.</summary>
    [Label("BM_ALERT")]
    Alert = 1,

    /// <summary>Megaphone (channel).</summary>
    [Label("BM_SPEAKERCHANNEL")]
    [Label("Speaker Channel", 1)]
    SpeakerChannel = 2,

    /// <summary>Super megaphone (world).</summary>
    [Label("BM_SPEAKERWORLD")]
    [Label("Speaker World", 1)]
    SpeakerWorld = 3,

    /// <summary>Scrolling ticker text.</summary>
    [Label("BM_SLIDE")]
    Slide = 4,

    /// <summary>Event notification.</summary>
    [Label("BM_EVENT")]
    Event = 5,

    /// <summary>Notice without prefix.</summary>
    [Label("BM_NOTICEWITHOUTPREFIX")]
    [Label("Notice Without Prefix", 1)]
    NoticeWithoutPrefix = 6,

    /// <summary>Extended dialog message.</summary>
    [Label("BM_UTILDLGEX")]
    [Label("Util Dlg Ex", 1)]
    UtilDlgEx = 7,

    /// <summary>Item megaphone with item.</summary>
    [Label("BM_ITEMSPEAKER")]
    [Label("Item Speaker", 1)]
    ItemSpeaker = 8,

    /// <summary>Bridge megaphone.</summary>
    [Label("BM_SPEAKERBRIDGE")]
    [Label("Speaker Bridge", 1)]
    SpeakerBridge = 9,

    /// <summary>Art mega (world).</summary>
    [Label("BM_ARTSPEAKERWORLD")]
    [Label("Art Speaker World", 1)]
    ArtSpeakerWorld = 10,

    /// <summary>Weather effect message.</summary>
    [Label("BM_BLOWWEATHER")]
    [Label("Blow Weather", 1)]
    BlowWeather = 11,

    /// <summary>Gachapon reward announce.</summary>
    [Label("BM_GACHAPONANNOUNCE")]
    [Label("Gachapon Announce", 1)]
    GachaponAnnounce = 12,

    /// <summary>Gachapon open announce.</summary>
    [Label("BM_GACHAPONANNOUNCE_OPEN")]
    [Label("Gachapon Announce Open", 1)]
    GachaponAnnounceOpen = 13,

    /// <summary>Gachapon copy announce.</summary>
    [Label("BM_GACHAPONANNOUNCE_COPY")]
    [Label("Gachapon Announce Copy", 1)]
    GachaponAnnounceCopy = 14,

    /// <summary>User list clipboard.</summary>
    [Label("BM_ULISTCLIP")]
    [Label("UList Clip", 1)]
    UListClip = 15,

    /// <summary>Free market clipboard.</summary>
    [Label("BM_FREEMARKETCLIP")]
    [Label("Free Market Clip", 1)]
    FreeMarketClip = 16,

    /// <summary>Destroy shop broadcast.</summary>
    [Label("BM_DESTROYSHOP")]
    [Label("Destroy Shop", 1)]
    DestroyShop = 17,

    /// <summary>Cash shop advertisement.</summary>
    [Label("BM_CASHSHOPAD")]
    [Label("Cash Shop Ad", 1)]
    CashShopAd = 18,

    /// <summary>Heart megaphone.</summary>
    [Label("BM_HEARTSPEAKER")]
    [Label("Heart Speaker", 1)]
    HeartSpeaker = 19,

    /// <summary>Skull megaphone.</summary>
    [Label("BM_SKULLSPEAKER")]
    [Label("Skull Speaker", 1)]
    SkullSpeaker = 20,
}
