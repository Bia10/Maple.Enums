using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Used as skill-ID prefix: skillId / 10000 = job code.
/// Covers only the job codes present in the V95 client.
/// Max value 9000 fits in ushort (65535).
/// </summary>
public enum Job : ushort
{
    /// <summary>Explorer beginner.</summary>
    Beginner = 0,

    // ── Explorer Warriors ─────────────────────────────────────────────────────
    /// <summary>Warrior 1st job.</summary>
    Warrior = 100,

    /// <summary>Fighter 2nd job.</summary>
    Fighter = 110,

    /// <summary>Crusader 3rd job.</summary>
    Crusader = 111,

    /// <summary>Hero 4th job.</summary>
    Hero = 112,

    /// <summary>Page 2nd job.</summary>
    Page = 120,

    /// <summary>White Knight 3rd job.</summary>
    [Label("White Knight", 1)]
    WhiteKnight = 121,

    /// <summary>Paladin 4th job.</summary>
    Paladin = 122,

    /// <summary>Spearman 2nd job.</summary>
    Spearman = 130,

    /// <summary>Dragon Knight 3rd job.</summary>
    [Label("Dragon Knight", 1)]
    DragonKnight = 131,

    /// <summary>Dark Knight 4th job.</summary>
    [Label("Dark Knight", 1)]
    DarkKnight = 132,

    // ── Explorer Mages ────────────────────────────────────────────────────────
    /// <summary>Magician 1st job.</summary>
    Magician = 200,

    /// <summary>Fire Poison Wizard 2nd job.</summary>
    [Label("Fire Poison Wizard", 1)]
    FpWizard = 210,

    /// <summary>Fire Poison Mage 3rd job.</summary>
    [Label("Fire Poison Mage", 1)]
    FpMage = 211,

    /// <summary>Fire Poison Archmage 4th job.</summary>
    [Label("Fire Poison Archmage", 1)]
    FpArchMage = 212,

    /// <summary>Ice Lightning Wizard 2nd job.</summary>
    [Label("Ice Lightning Wizard", 1)]
    IlWizard = 220,

    /// <summary>Ice Lightning Mage 3rd job.</summary>
    [Label("Ice Lightning Mage", 1)]
    IlMage = 221,

    /// <summary>Ice Lightning Archmage 4th job.</summary>
    [Label("Ice Lightning Archmage", 1)]
    IlArchMage = 222,

    /// <summary>Cleric 2nd job.</summary>
    Cleric = 230,

    /// <summary>Priest 3rd job.</summary>
    Priest = 231,

    /// <summary>Bishop 4th job.</summary>
    Bishop = 232,

    // ── Explorer Bowmen ───────────────────────────────────────────────────────
    /// <summary>Archer 1st job.</summary>
    Archer = 300,

    /// <summary>Hunter 2nd job.</summary>
    Hunter = 310,

    /// <summary>Ranger 3rd job.</summary>
    Ranger = 311,

    /// <summary>Bowmaster 4th job.</summary>
    [Label("Bowmaster", 1)]
    BowMaster = 312,

    /// <summary>Crossbowman 2nd job.</summary>
    [Label("Cross Bowman", 1)]
    CrossBowman = 320,

    /// <summary>Sniper 3rd job.</summary>
    Sniper = 321,

    /// <summary>Marksman 4th job.</summary>
    Marksman = 322,

    // ── Explorer Thieves ──────────────────────────────────────────────────────
    /// <summary>Rogue 1st job.</summary>
    Rogue = 400,

    /// <summary>Assassin 2nd job.</summary>
    Assassin = 410,

    /// <summary>Hermit 3rd job.</summary>
    Hermit = 411,

    /// <summary>Night Lord 4th job.</summary>
    [Label("Night Lord", 1)]
    NightLord = 412,

    /// <summary>Bandit 2nd job.</summary>
    Bandit = 420,

    /// <summary>Chief Bandit 3rd job.</summary>
    [Label("Chief Bandit", 1)]
    ChiefBandit = 421,

    /// <summary>Shadower 4th job.</summary>
    Shadower = 422,

    /// <summary>Dual Blade 1st advancement.</summary>
    [Label("Blade Recruit", 1)]
    BladeRecruit = 430,

    /// <summary>Dual Blade 2nd advancement.</summary>
    [Label("Blade Acolyte", 1)]
    BladeAcolyte = 431,

    /// <summary>Dual Blade 3rd advancement.</summary>
    [Label("Blade Specialist", 1)]
    BladeSpecialist = 432,

    /// <summary>Dual Blade 4th advancement.</summary>
    [Label("Blade Lord", 1)]
    BladeLord = 433,

    /// <summary>Dual Blade 5th advancement.</summary>
    [Label("Blade Master", 1)]
    BladeMaster = 434,

    // ── Explorer Pirates ──────────────────────────────────────────────────────
    /// <summary>Pirate 1st job.</summary>
    Pirate = 500,

    /// <summary>Brawler 2nd job.</summary>
    Brawler = 510,

    /// <summary>Marauder 3rd job.</summary>
    Marauder = 511,

    /// <summary>Buccaneer 4th job.</summary>
    Buccaneer = 512,

    /// <summary>Gunslinger 2nd job.</summary>
    Gunslinger = 520,

    /// <summary>Outlaw 3rd job.</summary>
    Outlaw = 521,

    /// <summary>Corsair 4th job.</summary>
    Corsair = 522,

    // ── Special / GM ─────────────────────────────────────────────────────────
    /// <summary>Manager role.</summary>
    Manager = 800,

    /// <summary>Game Master.</summary>
    [Label("GM", 1)]
    Gm = 900,

    /// <summary>Super Game Master.</summary>
    [Label("Super GM", 1)]
    SuperGm = 910,

    /// <summary>Riding skill category.</summary>
    [Label("Riding Skills", 1)]
    RidingSkills = 8000,

    /// <summary>Additional skill category.</summary>
    [Label("Additional Skills", 1)]
    AdditionalSkills = 9000,

    // ── Cygnus Knights ────────────────────────────────────────────────────────
    /// <summary>Cygnus beginner.</summary>
    Noblesse = 1000,

    /// <summary>Dawn Warrior 1st job.</summary>
    [Label("Dawn Warrior", 1)]
    DawnWarrior1 = 1100,

    /// <summary>Dawn Warrior 2nd job.</summary>
    [Label("Dawn Warrior", 1)]
    DawnWarrior2 = 1110,

    /// <summary>Dawn Warrior 3rd job.</summary>
    [Label("Dawn Warrior", 1)]
    DawnWarrior3 = 1111,

    /// <summary>Blaze Wizard 1st job.</summary>
    [Label("Blaze Wizard", 1)]
    BlazeWizard1 = 1200,

    /// <summary>Blaze Wizard 2nd job.</summary>
    [Label("Blaze Wizard", 1)]
    BlazeWizard2 = 1210,

    /// <summary>Blaze Wizard 3rd job.</summary>
    [Label("Blaze Wizard", 1)]
    BlazeWizard3 = 1211,

    /// <summary>Wind Archer 1st job.</summary>
    [Label("Wind Archer", 1)]
    WindArcher1 = 1300,

    /// <summary>Wind Archer 2nd job.</summary>
    [Label("Wind Archer", 1)]
    WindArcher2 = 1310,

    /// <summary>Wind Archer 3rd job.</summary>
    [Label("Wind Archer", 1)]
    WindArcher3 = 1311,

    /// <summary>Night Walker 1st job.</summary>
    [Label("Night Walker", 1)]
    NightWalker1 = 1400,

    /// <summary>Night Walker 2nd job.</summary>
    [Label("Night Walker", 1)]
    NightWalker2 = 1410,

    /// <summary>Night Walker 3rd job.</summary>
    [Label("Night Walker", 1)]
    NightWalker3 = 1411,

    /// <summary>Thunder Breaker 1st job.</summary>
    [Label("Thunder Breaker", 1)]
    ThunderBreaker1 = 1500,

    /// <summary>Thunder Breaker 2nd job.</summary>
    [Label("Thunder Breaker", 1)]
    ThunderBreaker2 = 1510,

    /// <summary>Thunder Breaker 3rd job.</summary>
    [Label("Thunder Breaker", 1)]
    ThunderBreaker3 = 1511,

    // ── Heroes ────────────────────────────────────────────────────────────────
    /// <summary>Aran beginner.</summary>
    [Label("Aran", 1)]
    AranB = 2000,

    /// <summary>Aran 1st job.</summary>
    [Label("Aran", 1)]
    Aran1 = 2100,

    /// <summary>Aran 2nd job.</summary>
    [Label("Aran", 1)]
    Aran2 = 2110,

    /// <summary>Aran 3rd job.</summary>
    [Label("Aran", 1)]
    Aran3 = 2111,

    /// <summary>Aran 4th job.</summary>
    [Label("Aran", 1)]
    Aran4 = 2112,

    /// <summary>Evan beginner.</summary>
    [Label("Evan", 1)]
    EvanB = 2001,

    /// <summary>Evan 1st growth.</summary>
    [Label("Evan", 1)]
    Evan1 = 2200,

    /// <summary>Evan 2nd growth.</summary>
    [Label("Evan", 1)]
    Evan2 = 2210,

    /// <summary>Evan 3rd growth.</summary>
    [Label("Evan", 1)]
    Evan3 = 2211,

    /// <summary>Evan 4th growth.</summary>
    [Label("Evan", 1)]
    Evan4 = 2212,

    /// <summary>Evan 5th growth.</summary>
    [Label("Evan", 1)]
    Evan5 = 2213,

    /// <summary>Evan 6th growth.</summary>
    [Label("Evan", 1)]
    Evan6 = 2214,

    /// <summary>Evan 7th growth.</summary>
    [Label("Evan", 1)]
    Evan7 = 2215,

    /// <summary>Evan 8th growth.</summary>
    [Label("Evan", 1)]
    Evan8 = 2216,

    /// <summary>Evan 9th growth.</summary>
    [Label("Evan", 1)]
    Evan9 = 2217,

    /// <summary>Evan 10th growth.</summary>
    [Label("Evan", 1)]
    Evan10 = 2218,

    // ── Resistance ────────────────────────────────────────────────────────────
    /// <summary>Resistance beginner.</summary>
    Citizen = 3000,

    /// <summary>Battle Mage 1st job.</summary>
    [Label("Battle Mage", 1)]
    BattleMage1 = 3200,

    /// <summary>Battle Mage 2nd job.</summary>
    [Label("Battle Mage", 1)]
    BattleMage2 = 3210,

    /// <summary>Battle Mage 3rd job.</summary>
    [Label("Battle Mage", 1)]
    BattleMage3 = 3211,

    /// <summary>Battle Mage 4th job.</summary>
    [Label("Battle Mage", 1)]
    BattleMage4 = 3212,

    /// <summary>Wild Hunter 1st job.</summary>
    [Label("Wild Hunter", 1)]
    WildHunter1 = 3300,

    /// <summary>Wild Hunter 2nd job.</summary>
    [Label("Wild Hunter", 1)]
    WildHunter2 = 3310,

    /// <summary>Wild Hunter 3rd job.</summary>
    [Label("Wild Hunter", 1)]
    WildHunter3 = 3311,

    /// <summary>Wild Hunter 4th job.</summary>
    [Label("Wild Hunter", 1)]
    WildHunter4 = 3312,

    /// <summary>Mechanic 1st job.</summary>
    [Label("Mechanic", 1)]
    Mechanic1 = 3500,

    /// <summary>Mechanic 2nd job.</summary>
    [Label("Mechanic", 1)]
    Mechanic2 = 3510,

    /// <summary>Mechanic 3rd job.</summary>
    [Label("Mechanic", 1)]
    Mechanic3 = 3511,

    /// <summary>Mechanic 4th job.</summary>
    [Label("Mechanic", 1)]
    Mechanic4 = 3512,
}
