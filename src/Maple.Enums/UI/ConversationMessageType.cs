using FastEnumUtility;

namespace Maple.Enums;

/// <summary>NPC conversation dialogue mode (say, ask yes/no, ask text, avatar selection, etc.).</summary>
public enum ConversationMessageType : byte
{
    /// <summary>NPC dialogue text.</summary>
    Say = 0,

    /// <summary>Dialogue with image.</summary>
    [Label("Say Image", 1)]
    SayImage = 1,

    /// <summary>Yes/No prompt.</summary>
    [Label("Ask Yes/No", 1)]
    AskYesNo = 2,

    /// <summary>Text input prompt.</summary>
    [Label("Ask Text", 1)]
    AskText = 3,

    /// <summary>Number input prompt.</summary>
    [Label("Ask Number", 1)]
    AskNumber = 4,

    /// <summary>Selection menu.</summary>
    [Label("Ask Menu", 1)]
    AskMenu = 5,

    /// <summary>Quiz question.</summary>
    [Label("Ask Quiz", 1)]
    AskQuiz = 6,

    /// <summary>Timed quiz question.</summary>
    [Label("Ask Speed Quiz", 1)]
    AskSpeedQuiz = 7,

    /// <summary>Avatar style selection.</summary>
    [Label("Ask Avatar", 1)]
    AskAvatar = 8,

    /// <summary>Membership avatar selection.</summary>
    [Label("Ask Member Shop Avatar", 1)]
    AskMemberShopAvatar = 9,

    /// <summary>Pet selection prompt.</summary>
    [Label("Ask Pet", 1)]
    AskPet = 10,

    /// <summary>All-pet selection prompt.</summary>
    [Label("Ask Pet All", 1)]
    AskPetAll = 11,

    /// <summary>Script-driven dialogue.</summary>
    Script = 12,

    /// <summary>Accept/decline prompt.</summary>
    [Label("Ask Accept", 1)]
    AskAccept = 13,

    /// <summary>Multi-line text input.</summary>
    [Label("Ask Box Text", 1)]
    AskBoxText = 14,

    /// <summary>Slide-style menu.</summary>
    [Label("Ask Slide Menu", 1)]
    AskSlideMenu = 15,

    /// <summary>Centered dialogue.</summary>
    [Label("Ask Center", 1)]
    AskCenter = 16,
}
