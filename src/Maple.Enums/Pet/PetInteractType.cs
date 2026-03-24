using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Pet interaction action type.
/// </summary>
public enum PetInteractType : byte
{
    /// <summary>General pet interaction.</summary>
    [Label("INTERACT")]
    Interact = 0,

    /// <summary>Feed the pet.</summary>
    [Label("FEED")]
    Feed = 1,

    /// <summary>Chat with the pet.</summary>
    [Label("CHAT")]
    Chat = 2,

    /// <summary>Random interaction type.</summary>
    [Label("RANDOM")]
    Random = 3,
}
