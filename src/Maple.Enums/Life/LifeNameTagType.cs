using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Life object name tag display type.
/// </summary>
public enum LifeNameTagType : ushort
{
    /// <summary>Player name tag.</summary>
    [Label("LIFE_NAMETAG_CHARACTER")]
    Character = 1000,

    /// <summary>NPC title tag.</summary>
    [Label("LIFE_NAMETAG_NPC_TITLE")]
    [Label("Npc Title", 1)]
    NpcTitle = 1001,

    /// <summary>NPC function tag.</summary>
    [Label("LIFE_NAMETAG_NPC_FUNC")]
    [Label("Npc Func", 1)]
    NpcFunc = 1002,

    /// <summary>Pet name tag.</summary>
    [Label("LIFE_NAMETAG_PET")]
    Pet = 1003,

    /// <summary>Guild name tag.</summary>
    [Label("LIFE_NAMETAG_GUILD")]
    Guild = 1004,

    /// <summary>Battle team tag.</summary>
    [Label("LIFE_NAMETAG_BATTLETEAM")]
    [Label("Battle Team", 1)]
    BattleTeam = 1005,

    /// <summary>Medal title tag.</summary>
    [Label("LIFE_NAMETAG_MEDAL")]
    Medal = 1006,

    /// <summary>Party raid tag.</summary>
    [Label("LIFE_NAMETAG_PARTYRAID")]
    [Label("Party Raid", 1)]
    PartyRaid = 1007,
}
