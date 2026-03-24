using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Game object type classification.
/// </summary>
public enum GameObjectType : byte
{
    /// <summary>No object.</summary>
    [Label("GOT_NONE")]
    None = 0,

    /// <summary>Generic game object.</summary>
    [Label("GOT_GAMEOBJECT")]
    [Label("Game Object", 1)]
    GameObject = 1,

    /// <summary>Living creature base.</summary>
    [Label("GOT_CREATURE")]
    Creature = 2,

    /// <summary>Player character.</summary>
    [Label("GOT_USER")]
    User = 3,

    /// <summary>Non-player character.</summary>
    [Label("GOT_NPC")]
    Npc = 4,

    /// <summary>Monster.</summary>
    [Label("GOT_MOB")]
    Mob = 5,

    /// <summary>Pet companion.</summary>
    [Label("GOT_PET")]
    Pet = 6,

    /// <summary>Item entity.</summary>
    [Label("GOT_ITEM")]
    Item = 7,

    /// <summary>Map portal.</summary>
    [Label("GOT_PORTAL")]
    Portal = 8,

    /// <summary>Interactive reactor.</summary>
    [Label("GOT_REACTOR")]
    Reactor = 9,

    /// <summary>Hired merchant.</summary>
    [Label("GOT_EMPLOYEE")]
    Employee = 10,
}
