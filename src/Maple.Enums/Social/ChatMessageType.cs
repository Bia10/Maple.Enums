using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Chat message display/routing types used in the chat log.
/// </summary>
public enum ChatMessageType : byte
{
    /// <summary>Regular chat.</summary>
    [Label("CHAT_TYPE_NORMAL")]
    Normal = 0,

    /// <summary>Private whisper.</summary>
    [Label("CHAT_TYPE_WHISPER")]
    Whisper = 1,

    /// <summary>Party chat.</summary>
    [Label("CHAT_TYPE_GROUPPARTY")]
    [Label("Group Party", 1)]
    GroupParty = 2,

    /// <summary>Friend chat.</summary>
    [Label("CHAT_TYPE_GROUPFRIEND")]
    [Label("Group Friend", 1)]
    GroupFriend = 3,

    /// <summary>Guild chat.</summary>
    [Label("CHAT_TYPE_GROUPGUILD")]
    [Label("Group Guild", 1)]
    GroupGuild = 4,

    /// <summary>Alliance chat.</summary>
    [Label("CHAT_TYPE_GROUPALLIANCE")]
    [Label("Group Alliance", 1)]
    GroupAlliance = 5,

    /// <summary>Couple chat.</summary>
    [Label("CHAT_TYPE_COUPLE")]
    Couple = 6,

    /// <summary>Game description text.</summary>
    [Label("CHAT_TYPE_GAMEDESC")]
    [Label("Game Desc", 1)]
    GameDesc = 7,

    /// <summary>Hint/tip message.</summary>
    [Label("CHAT_TYPE_TIP")]
    Tip = 8,

    /// <summary>System notice.</summary>
    [Label("CHAT_TYPE_NOTICE")]
    Notice = 9,

    /// <summary>Secondary notice.</summary>
    [Label("CHAT_TYPE_NOTICE2")]
    Notice2 = 10,

    /// <summary>Admin/GM chat.</summary>
    [Label("CHAT_TYPE_ADMINCHAT")]
    [Label("Admin Chat", 1)]
    AdminChat = 11,

    /// <summary>System message.</summary>
    [Label("CHAT_TYPE_SYSTEM")]
    System = 12,

    /// <summary>Channel megaphone.</summary>
    [Label("CHAT_TYPE_SPEAKERCHANNEL")]
    [Label("Speaker Channel", 1)]
    SpeakerChannel = 13,

    /// <summary>World megaphone.</summary>
    [Label("CHAT_TYPE_SPEAKERWORLD")]
    [Label("Speaker World", 1)]
    SpeakerWorld = 14,

    /// <summary>Skull megaphone.</summary>
    [Label("CHAT_TYPE_SKULLSPEAKER")]
    [Label("Skull Speaker", 1)]
    SkullSpeaker = 15,

    /// <summary>Item megaphone text.</summary>
    [Label("CHAT_TYPE_ITEMSPEAKER")]
    [Label("Item Speaker", 1)]
    ItemSpeaker = 16,

    /// <summary>Item megaphone with item.</summary>
    [Label("CHAT_TYPE_ITEMSPEAKER_ITEM")]
    [Label("Item Speaker Item", 1)]
    ItemSpeakerItem = 17,

    /// <summary>Avatar megaphone.</summary>
    [Label("CHAT_TYPE_AVATARMEGAPHONE")]
    [Label("Avatar Megaphone", 1)]
    AvatarMegaphone = 18,

    /// <summary>Gachapon reward announce.</summary>
    [Label("CHAT_TYPE_GACHAPONANNOUNCE")]
    [Label("Gachapon Announce", 1)]
    GachaponAnnounce = 19,

    /// <summary>Cash gachapon announce.</summary>
    [Label("CHAT_TYPE_CASHGACHAPONANNOUNCE")]
    [Label("Cash Gachapon Announce", 1)]
    CashGachaponAnnounce = 20,

    /// <summary>Cash gachapon open announce.</summary>
    [Label("CHAT_TYPE_CASHGACHAPON_OPEN_ANNOUNCE")]
    [Label("Cash Gachapon Open Announce", 1)]
    CashGachaponOpenAnnounce = 21,

    /// <summary>Cash gachapon copy announce.</summary>
    [Label("CHAT_TYPE_CASHGACHAPON_COPY_ANNOUNCE")]
    [Label("Cash Gachapon Copy Announce", 1)]
    CashGachaponCopyAnnounce = 22,

    /// <summary>Bridge megaphone.</summary>
    [Label("CHAT_TYPE_SPEAKERBRIDGE")]
    [Label("Speaker Bridge", 1)]
    SpeakerBridge = 23,

    /// <summary>World speaker preview.</summary>
    [Label("CHAT_TYPE_SPEAKERWORLDEX_PREVIEW")]
    [Label("Speaker World Ex Preview", 1)]
    SpeakerWorldExPreview = 24,

    /// <summary>Mob speech.</summary>
    [Label("CHAT_TYPE_MOB")]
    Mob = 25,

    /// <summary>Expedition chat.</summary>
    [Label("CHAT_TYPE_EXPEDITION")]
    Expedition = 26,

    /// <summary>Sentinel / end marker.</summary>
    [Label("CHAT_TYPE_NO")]
    No = 27,
}
