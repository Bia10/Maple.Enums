using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest area code from QuestInfo.img/{id}/area.
/// Used to group quests into tabs in the in-game Quest Journal.
/// Distinct from quest area codes, which use a separate numbering scheme.
/// Values should be populated from WZ data enumeration of actual quest area numbers.
/// </summary>
public enum QuestArea : short
{
    /// <summary>No area assigned.</summary>
    None = 0,

    /// <summary>Maple Island starter zone.</summary>
    [Label("Maple Island")]
    MapleIsland = 1,

    /// <summary>Lith Harbor port town.</summary>
    [Label("Lith Harbor")]
    LithHarbor = 2,

    /// <summary>Henesys bowman town.</summary>
    Henesys = 3,

    /// <summary>Ellinia magic forest.</summary>
    Ellinia = 4,

    /// <summary>Perion warrior village.</summary>
    Perion = 5,

    /// <summary>Kerning City streets.</summary>
    [Label("Kerning City")]
    KerningCity = 6,

    /// <summary>Sleepywood dungeon town.</summary>
    Sleepywood = 7,

    /// <summary>Nautilus Harbor ship.</summary>
    [Label("Nautilus Harbor")]
    NautilusHarbor = 8,

    /// <summary>Cygnus party quest.</summary>
    [Label("Cygnus PQ")]
    AmnesiacCygnus = 9,

    /// <summary>Aliens party quest.</summary>
    [Label("Aliens PQ")]
    AliensPQ = 10,

    /// <summary>Ludibrium party quest.</summary>
    [Label("Ludibria PQ")]
    LudibriaPQ = 11,

    /// <summary>Victoria Island region.</summary>
    [Label("Victoria Island")]
    VictoriaIsland = 20,

    /// <summary>Orbis cloud city.</summary>
    Orbis = 30,

    /// <summary>El Nath mountains.</summary>
    [Label("El Nath")]
    ElNath = 31,

    /// <summary>Ludibrium toy city.</summary>
    Ludibrium = 32,

    /// <summary>Aqua Road underwater.</summary>
    [Label("Aqua Road")]
    AquaRoad = 33,

    /// <summary>Omega Sector base.</summary>
    [Label("Omega Sector")]
    OmegaSector = 34,

    /// <summary>Masteria continent.</summary>
    [Label("Masteria")]
    MasteriaKerning = 35,

    /// <summary>Nihal Desert region.</summary>
    [Label("Nihal Desert")]
    NihalDesert = 40,

    /// <summary>Minar Forest area.</summary>
    [Label("Minar Forest")]
    MinarForest = 41,

    /// <summary>Mu Lung Garden.</summary>
    [Label("Mu Lung Garden")]
    MuLungGarden = 42,

    /// <summary>Korean Folk Town.</summary>
    [Label("Korean Folk Town")]
    KoreanFolkTown = 43,

    /// <summary>Ariant desert town.</summary>
    Ariant = 44,

    /// <summary>Magatia alchemy town.</summary>
    Magatia = 45,

    /// <summary>Singapore CBD area.</summary>
    Singapore = 50,

    /// <summary>Malaysia Kampung zone.</summary>
    [Label("Malaysia")]
    MalaysiaBatam = 51,

    /// <summary>New Leaf City.</summary>
    [Label("New Leaf City")]
    NewLeafCity = 52,

    /// <summary>Mushroom Kingdom area.</summary>
    [Label("Mushroom Kingdom")]
    MushroomKingdom = 53,

    /// <summary>Amoria wedding town.</summary>
    Amoria = 60,

    /// <summary>Happyville event town.</summary>
    Happyville = 61,

    /// <summary>Crimsonwood Keep dungeon.</summary>
    [Label("Crimsonwood Keep")]
    CrimsonwoodKeep = 62,

    /// <summary>Star Planet social hub.</summary>
    [Label("Star Planet")]
    StarPlanet = 63,

    /// <summary>Game Master quests.</summary>
    [Label("GM")]
    GmQuest = 99,
}
