using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Skill identifier.
/// Formula: <c>skillId / 10000</c> gives the job code; the job prefix groups skills by job.
/// Values use hexadecimal to match the V95 PDB constants verbatim.
/// Most novice-category skills follow sequential IDs starting at 0x3E8 (1000),
/// except a small set (e.g. <see cref="NoviceMultiPet"/>, <see cref="NoviceBlessOfNymph"/>)
/// that have non-sequential ids documented inline.
/// </summary>
public enum SkillId : int
{
    /// <summary>Throw snail shells.</summary>
    [Label("NOVICE_THROW_SNAIL")]
    [Label("Novice Throw Snail", 1)]
    NoviceThrowSnail = 1000,

    /// <summary>Recover HP over time.</summary>
    [Label("NOVICE_REGENERATION")]
    [Label("Novice Regeneration", 1)]
    NoviceRegeneration = 1001,

    /// <summary>Recover while moving.</summary>
    [Label("NOVICE_MOVING_WITH_ACTIVITY")]
    [Label("Novice Moving With Activity", 1)]
    NoviceMovingWithActivity = 1002,

    /// <summary>Crafting proficiency boost.</summary>
    [Label("NOVICE_SOUL_OF_CRAFTMAN")]
    [Label("Novice Soul Of Craftsman", 1)]
    NoviceSoulOfCraftsman = 1003,

    /// <summary>Mount a tamed monster.</summary>
    [Label("NOVICE_MONSTER_RIDING")]
    [Label("Novice Monster Riding", 1)]
    NoviceMonsterRiding = 1004,

    /// <summary>Max-level echo buff.</summary>
    [Label("NOVICE_MAXLEVEL_ECHOBUFF")]
    [Label("Novice Max-Level Echo Buff", 1)]
    NoviceMaxlevelEchobuff = 1005,

    /// <summary>Display damage dealt.</summary>
    [Label("NOVICE_DAMAGEMETER")]
    [Label("Novice Damage Meter", 1)]
    NoviceDamagemeter = 1006,

    // NoviceMultiPet and NoviceBlessOfNymph have non-sequential IDs (8, 12)
    // that fall outside the 0x3E8+ novice skill range — these are the actual game IDs.

    /// <summary>Equip multiple pets.</summary>
    [Label("NOVICE_MULTI_PET")]
    [Label("Novice Multi Pet", 1)]
    NoviceMultiPet = 8,

    /// <summary>Craft items via Maker.</summary>
    [Label("NOVICE_MAKER")]
    [Label("Novice Maker", 1)]
    NoviceMaker = 1007,

    /// <summary>Bamboo rain attack.</summary>
    [Label("NOVICE_BAMBOO")]
    [Label("Novice Bamboo", 1)]
    NoviceBamboo = 1009,

    /// <summary>Temporary invincibility.</summary>
    [Label("NOVICE_INVINCIBLE")]
    [Label("Novice Invincible", 1)]
    NoviceInvincible = 1010,

    /// <summary>Enter berserk state.</summary>
    [Label("NOVICE_BERSERK")]
    [Label("Novice Berserk", 1)]
    NoviceBerserk = 1011,

    /// <summary>Nymph's blessing buff.</summary>
    [Label("NOVICE_BLESS_OF_NYMPH")]
    [Label("Novice Bless Of Nymph", 1)]
    NoviceBlessOfNymph = 12,

    /// <summary>Ride event mount (disabled).</summary>
    [Label("DISABLE_NOVICE_EVENT_RIDING")]
    [Label("Disable Novice Event Riding", 1)]
    DisableNoviceEventRiding = 1013,

    /// <summary>Dash on event mount (disabled).</summary>
    [Label("DISABLE_NOVICE_EVENT_RIDING_DASH")]
    [Label("Disable Novice Event Riding Dash", 1)]
    DisableNoviceEventRidingDash = 1014,

    /// <summary>Interact on event mount (disabled).</summary>
    [Label("DISABLE_NOVICE_EVENT_RIDING_REACTOR")]
    [Label("Disable Novice Event Riding Reactor", 1)]
    DisableNoviceEventRidingReactor = 1015,

    /// <summary>Ride Yeti mount (disabled).</summary>
    [Label("DISABLE_NOVICE_YETI_EVENT_RIDING")]
    [Label("Disable Novice Yeti Event Riding", 1)]
    DisableNoviceYetiEventRiding = 1017,

    /// <summary>Ride Yeti mount variant (disabled).</summary>
    [Label("DISABLE_NOVICE_YETI_EVENT_RIDING2")]
    [Label("Disable Novice Yeti Event Riding2", 1)]
    DisableNoviceYetiEventRiding2 = 1018,

    /// <summary>Ride broomstick mount (disabled).</summary>
    [Label("DISABLE_NOVICE_BROOM_EVENT_RIDING")]
    [Label("Disable Novice Broom Event Riding", 1)]
    DisableNoviceBroomEventRiding = 1019,

    /// <summary>Party bonus EXP skill.</summary>
    [Label("NOVICE_MASSACRE")]
    [Label("Novice Massacre", 1)]
    NoviceMassacre = 1020,

    /// <summary>Ride wooden horse mount.</summary>
    [Label("NOVICE_WOODENHORSE_EVENT_RIDING")]
    [Label("Novice Wooden Horse Event Riding", 1)]
    NoviceWoodenhorseEventRiding = 1025,

    /// <summary>Enable flight ability.</summary>
    [Label("NOVICE_FLYING_SKILL")]
    [Label("Novice Flying Skill", 1)]
    NoviceFlyingSkill = 1026,

    /// <summary>Ride crocodile mount.</summary>
    [Label("NOVICE_KROKO_EVENT_RIDING")]
    [Label("Novice Kroko Event Riding", 1)]
    NoviceKrokoEventRiding = 1027,

    /// <summary>Ride streaker mount.</summary>
    [Label("NOVICE_NAKED_EVENT_RIDING")]
    [Label("Novice Naked Event Riding", 1)]
    NoviceNakedEventRiding = 1028,

    /// <summary>Ride pink scooter mount.</summary>
    [Label("NOVICE_PINK_SCOOTER_EVENT_RIDING")]
    [Label("Novice Pink Scooter Event Riding", 1)]
    NovicePinkScooterEventRiding = 1029,

    /// <summary>Ride nimbus cloud mount.</summary>
    [Label("NOVICE_FLYING_CLOUD_EVENT_RIDING")]
    [Label("Novice Flying Cloud Event Riding", 1)]
    NoviceFlyingCloudEventRiding = 1030,

    /// <summary>Ride Balrog mount.</summary>
    [Label("NOVICE_BALROG_EVENT_RIDING")]
    [Label("Novice Balrog Event Riding", 1)]
    NoviceBalrogEventRiding = 1031,

    /// <summary>Ride go-kart mount.</summary>
    [Label("NOVICE_KART_EVENT_RIDING")]
    [Label("Novice Kart Event Riding", 1)]
    NoviceKartEventRiding = 1033,

    /// <summary>Ride tiger mount.</summary>
    [Label("NOVICE_ZD_TIGER_EVENT_RIDING")]
    [Label("Novice Zd Tiger Event Riding", 1)]
    NoviceZdTigerEventRiding = 1034,

    /// <summary>Ride Mist Balrog mount.</summary>
    [Label("NOVICE_MISTBALROG_EVENT_RIDING")]
    [Label("Novice Mistbalrog Event Riding", 1)]
    NoviceMistbalrogEventRiding = 1035,

    /// <summary>Ride lion mount.</summary>
    [Label("NOVICE_LIONS_EVENT_RIDING")]
    [Label("Novice Lions Event Riding", 1)]
    NoviceLionsEventRiding = 1036,

    /// <summary>Ride unicorn mount.</summary>
    [Label("NOVICE_UNICORN_EVENT_RIDING")]
    [Label("Novice Unicorn Event Riding", 1)]
    NoviceUnicornEventRiding = 1037,

    /// <summary>Ride low-rider mount.</summary>
    [Label("NOVICE_LOWRIDER_EVENT_RIDING")]
    [Label("Novice Lowrider Event Riding", 1)]
    NoviceLowriderEventRiding = 1038,

    /// <summary>Ride red truck mount.</summary>
    [Label("NOVICE_REDTRUCK_EVENT_RIDING")]
    [Label("Novice Redtruck Event Riding", 1)]
    NoviceRedtruckEventRiding = 1039,

    /// <summary>Ride gargoyle mount.</summary>
    [Label("NOVICE_GARGOYLES_EVENT_RIDING")]
    [Label("Novice Gargoyles Event Riding", 1)]
    NoviceGargoylesEventRiding = 1040,

    /// <summary>Ride spaceship mount.</summary>
    [Label("NOVICE_SPACE_EVENT_RIDING")]
    [Label("Novice Space Event Riding", 1)]
    NoviceSpaceEventRiding = 1046,

    /// <summary>Dash on spaceship mount.</summary>
    [Label("NOVICE_SPACE_EVENT_RIDING_DASH")]
    [Label("Novice Space Event Riding Dash", 1)]
    NoviceSpaceEventRidingDash = 1047,

    /// <summary>Interact on spaceship mount.</summary>
    [Label("NOVICE_SPACE_EVENT_RIDING_REACTOR")]
    [Label("Novice Space Event Riding Reactor", 1)]
    NoviceSpaceEventRidingReactor = 1048,

    /// <summary>Ride chicken mount.</summary>
    [Label("NOVICE_CHICKEN_EVENT_RIDING")]
    [Label("Novice Chicken Event Riding", 1)]
    NoviceChickenEventRiding = 1054,

    /// <summary>Ride holly bird mount.</summary>
    [Label("NOVICE_HOLLY_BIRD_EVENT_RIDING")]
    [Label("Novice Holly Bird Event Riding", 1)]
    NoviceHollyBirdEventRiding = 1042,

    /// <summary>Ride Orange Mushroom mount.</summary>
    [Label("NOVICE_ORANGE_MUSHROOM_EVENT_RIDING")]
    [Label("Novice Orange Mushroom Event Riding", 1)]
    NoviceOrangeMushroomEventRiding = 1044,

    /// <summary>Ride Nightmare mount.</summary>
    [Label("NOVICE_NIGHTMARE_EVENT_RIDING")]
    [Label("Novice Nightmare Event Riding", 1)]
    NoviceNightmareEventRiding = 1049,

    /// <summary>Ride Yeti mount.</summary>
    [Label("NOVICE_YETI_EVENT_RIDING")]
    [Label("Novice Yeti Event Riding", 1)]
    NoviceYetiEventRiding = 1050,

    /// <summary>Ride ostrich mount.</summary>
    [Label("NOVICE_OSTRICH_EVENT_RIDING")]
    [Label("Novice Ostrich Event Riding", 1)]
    NoviceOstrichEventRiding = 1051,

    /// <summary>Ride bear balloon mount.</summary>
    [Label("NOVICE_BEAR_BALOON_EVENT_RIDING")]
    [Label("Novice Bear Baloon Event Riding", 1)]
    NoviceBearBaloonEventRiding = 1052,

    /// <summary>Ride transformer mount.</summary>
    [Label("NOVICE_TRANS_ROBOT_EVENT_RIDING")]
    [Label("Novice Trans Robot Event Riding", 1)]
    NoviceTransRobotEventRiding = 1053,

    /// <summary>Ride motorbike mount.</summary>
    [Label("NOVICE_MOTORBIKE_EVENT_RIDING")]
    [Label("Novice Motorbike Event Riding", 1)]
    NoviceMotorbikeEventRiding = 1063,

    /// <summary>Ride power suit mount.</summary>
    [Label("NOVICE_POWERED_SUIT_EVENT_RIDING")]
    [Label("Novice Powered Suit Event Riding", 1)]
    NovicePoweredSuitEventRiding = 1064,

    /// <summary>Ride Visitor mount.</summary>
    [Label("NOVICE_VISITOR_EVENT_RIDING")]
    [Label("Novice Visitor Event Riding", 1)]
    NoviceVisitorEventRiding = 1065,

    /// <summary>Ride Visitor mount.</summary>
    [Label("NOBLELESS_VISITOR_EVENT_RIDING")]
    [Label("Nobleless Visitor Event Riding", 1)]
    NoblelessVisitorEventRiding = 10001065,

    /// <summary>Ride Visitor mount.</summary>
    [Label("ARAN_VISITOR_EVENT_RIDING")]
    [Label("Aran Visitor Event Riding", 1)]
    AranVisitorEventRiding = 20001065,

    /// <summary>Ride Visitor mount.</summary>
    [Label("EVAN_VISITOR_EVENT_RIDING")]
    [Label("Evan Visitor Event Riding", 1)]
    EvanVisitorEventRiding = 20011065,

    /// <summary>Ride Visitor mount.</summary>
    [Label("CITIZEN_VISITOR_EVENT_RIDING")]
    [Label("Citizen Visitor Event Riding", 1)]
    CitizenVisitorEventRiding = 30001065,

    /// <summary>Ride Visitor owl mount.</summary>
    [Label("NOVICE_VISITOR_OWL_RIDING")]
    [Label("Novice Visitor Owl Riding", 1)]
    NoviceVisitorOwlRiding = 1069,

    /// <summary>Ride Visitor owl mount.</summary>
    [Label("NOBLELESS_VISITOR_OWL_RIDING")]
    [Label("Nobleless Visitor Owl Riding", 1)]
    NoblelessVisitorOwlRiding = 10001069,

    /// <summary>Ride Visitor owl mount.</summary>
    [Label("ARAN_VISITOR_OWL_RIDING")]
    [Label("Aran Visitor Owl Riding", 1)]
    AranVisitorOwlRiding = 20001069,

    /// <summary>Ride Visitor owl mount.</summary>
    [Label("EVAN_VISITOR_OWL_RIDING")]
    [Label("Evan Visitor Owl Riding", 1)]
    EvanVisitorOwlRiding = 20011069,

    /// <summary>Ride Visitor owl mount.</summary>
    [Label("CITIZEN_VISITOR_OWL_RIDING")]
    [Label("Citizen Visitor Owl Riding", 1)]
    CitizenVisitorOwlRiding = 30001069,

    /// <summary>Ride Visitor mothership.</summary>
    [Label("NOVICE_VISITOR_MOTHERSHIP_RIDING")]
    [Label("Novice Visitor Mothership Riding", 1)]
    NoviceVisitorMothershipRiding = 1070,

    /// <summary>Ride Visitor mothership.</summary>
    [Label("NOBLELESS_VISITOR_MOTHERSHIP_RIDING")]
    [Label("Nobleless Visitor Mothership Riding", 1)]
    NoblelessVisitorMothershipRiding = 10001070,

    /// <summary>Ride Visitor mothership.</summary>
    [Label("ARAN_VISITOR_MOTHERSHIP_RIDING")]
    [Label("Aran Visitor Mothership Riding", 1)]
    AranVisitorMothershipRiding = 20001070,

    /// <summary>Ride Visitor mothership.</summary>
    [Label("EVAN_VISITOR_MOTHERSHIP_RIDING")]
    [Label("Evan Visitor Mothership Riding", 1)]
    EvanVisitorMothershipRiding = 20011070,

    /// <summary>Ride Visitor mothership.</summary>
    [Label("CITIZEN_VISITOR_MOTHERSHIP_RIDING")]
    [Label("Citizen Visitor Mothership Riding", 1)]
    CitizenVisitorMothershipRiding = 30001070,

    /// <summary>Ride Visitor OS3A mount.</summary>
    [Label("NOVICE_VISITOR_OS3A_RIDING")]
    [Label("Novice Visitor Os3a Riding", 1)]
    NoviceVisitorOs3aRiding = 1071,

    /// <summary>Ride Visitor OS3A mount.</summary>
    [Label("NOBLELESS_VISITOR_OS3A_RIDING")]
    [Label("Nobleless Visitor Os3a Riding", 1)]
    NoblelessVisitorOs3aRiding = 10001071,

    /// <summary>Ride Visitor OS3A mount.</summary>
    [Label("ARAN_VISITOR_OS3A_RIDING")]
    [Label("Aran Visitor Os3a Riding", 1)]
    AranVisitorOs3aRiding = 20001071,

    /// <summary>Ride Visitor OS3A mount.</summary>
    [Label("EVAN_VISITOR_OS3A_RIDING")]
    [Label("Evan Visitor Os3a Riding", 1)]
    EvanVisitorOs3aRiding = 20011071,

    /// <summary>Ride Visitor OS3A mount.</summary>
    [Label("CITIZEN_VISITOR_OS3A_RIDING")]
    [Label("Citizen Visitor Os3a Riding", 1)]
    CitizenVisitorOs3aRiding = 30001071,

    /// <summary>Visitor normal morph.</summary>
    [Label("NOVICE_VISITOR_MORPH_SKILL_NORMAL")]
    [Label("Novice Visitor Morph Skill Normal", 1)]
    NoviceVisitorMorphSkillNormal = 1066,

    /// <summary>Visitor skill morph.</summary>
    [Label("NOVICE_VISITOR_MORPH_SKILL_SKILL")]
    [Label("Novice Visitor Morph Skill Skill", 1)]
    NoviceVisitorMorphSkillSkill = 1067,

    /// <summary>Visitor normal morph.</summary>
    [Label("NOBLELESS_VISITOR_MORPH_SKILL_NORMAL")]
    [Label("Nobleless Visitor Morph Skill Normal", 1)]
    NoblelessVisitorMorphSkillNormal = 10001066,

    /// <summary>Visitor skill morph.</summary>
    [Label("NOBLELESS_VISITOR_MORPH_SKILL_SKILL")]
    [Label("Nobleless Visitor Morph Skill Skill", 1)]
    NoblelessVisitorMorphSkillSkill = 10001067,

    /// <summary>Visitor normal morph.</summary>
    [Label("ARAN_VISITOR_MORPH_SKILL_NORMAL")]
    [Label("Aran Visitor Morph Skill Normal", 1)]
    AranVisitorMorphSkillNormal = 20001066,

    /// <summary>Visitor skill morph.</summary>
    [Label("ARAN_VISITOR_MORPH_SKILL_SKILL")]
    [Label("Aran Visitor Morph Skill Skill", 1)]
    AranVisitorMorphSkillSkill = 20001067,

    /// <summary>Visitor normal morph.</summary>
    [Label("EVAN_VISITOR_MORPH_SKILL_NORMAL")]
    [Label("Evan Visitor Morph Skill Normal", 1)]
    EvanVisitorMorphSkillNormal = 20011066,

    /// <summary>Visitor skill morph.</summary>
    [Label("EVAN_VISITOR_MORPH_SKILL_SKILL")]
    [Label("Evan Visitor Morph Skill Skill", 1)]
    EvanVisitorMorphSkillSkill = 20011067,

    /// <summary>Visitor normal morph.</summary>
    [Label("CITIZEN_VISITOR_MORPH_SKILL_NORMAL")]
    [Label("Citizen Visitor Morph Skill Normal", 1)]
    CitizenVisitorMorphSkillNormal = 30001066,

    /// <summary>Visitor skill morph.</summary>
    [Label("CITIZEN_VISITOR_MORPH_SKILL_SKILL")]
    [Label("Citizen Visitor Morph Skill Skill", 1)]
    CitizenVisitorMorphSkillSkill = 30001067,

    /// <summary>Increase speed and jump.</summary>
    [Label("NOVICE_HASTE")]
    [Label("Novice Haste", 1)]
    NoviceHaste = 8000,

    /// <summary>Open town portal.</summary>
    [Label("NOVICE_MYSTIC_DOOR")]
    [Label("Novice Mystic Door", 1)]
    NoviceMysticDoor = 8001,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("NOVICE_SHARP_EYES")]
    [Label("Novice Sharp Eyes", 1)]
    NoviceSharpEyes = 8002,

    /// <summary>Increase max HP and MP.</summary>
    [Label("NOVICE_HYPER_BODY")]
    [Label("Novice Hyper Body", 1)]
    NoviceHyperBody = 8003,

    /// <summary>Start monster handicap.</summary>
    [Label("NOVICE_MONSTER_HANDICAP_BEGIN")]
    [Label("Novice Monster Handicap Begin", 1)]
    NoviceMonsterHandicapBegin = 9000,

    /// <summary>End monster handicap.</summary>
    [Label("NOVICE_MONSTER_HANDICAP_END")]
    [Label("Novice Monster Handicap End", 1)]
    NoviceMonsterHandicapEnd = 9002,

    /// <summary>Boost weapon defense.</summary>
    [Label("WARRIOR_IRON_BODY")]
    [Label("Warrior Iron Body", 1)]
    WarriorIronBody = 1001003,

    /// <summary>Strong melee strike.</summary>
    [Label("WARRIOR_POWER_STRIKE")]
    [Label("Warrior Power Strike", 1)]
    WarriorPowerStrike = 1001004,

    /// <summary>Slash multiple enemies.</summary>
    [Label("WARRIOR_SLASH_BLAST")]
    [Label("Warrior Slash Blast", 1)]
    WarriorSlashBlast = 1001005,

    /// <summary>Increase max HP.</summary>
    [Label("WARRIOR_MHP_INC")]
    [Label("Warrior Max HP Inc", 1)]
    WarriorMhpInc = 1000006,

    /// <summary>Boost weapon proficiency.</summary>
    [Label("FIGHTER_WEAPON_MASTERY")]
    [Label("Fighter Weapon Mastery", 1)]
    FighterWeaponMastery = 1100000,

    /// <summary>Extra hit after attack.</summary>
    [Label("FIGHTER_FINAL_ATTACK")]
    [Label("Fighter Final Attack", 1)]
    FighterFinalAttack = 1100002,

    /// <summary>Boost attack speed.</summary>
    [Label("FIGHTER_WEAPON_BOOSTER")]
    [Label("Fighter Weapon Booster", 1)]
    FighterWeaponBooster = 1101004,

    /// <summary>Boost party attack power.</summary>
    [Label("FIGHTER_FURY")]
    [Label("Fighter Fury", 1)]
    FighterFury = 1101006,

    /// <summary>Reflect damage to attacker.</summary>
    [Label("FIGHTER_POWER_GUARD")]
    [Label("Fighter Power Guard", 1)]
    FighterPowerGuard = 1101007,

    /// <summary>Smash ground area attack.</summary>
    [Label("FIGHTER_GROUND_SMASH")]
    [Label("Fighter Ground Smash", 1)]
    FighterGroundSmash = 1101008,

    /// <summary>Improve basic abilities.</summary>
    [Label("FIGHTER_IMPROVE_BASIC")]
    [Label("Fighter Improve Basic", 1)]
    FighterImproveBasic = 1100009,

    /// <summary>Improve MP recovery.</summary>
    [Label("CRUSADER_UPGRADE_MP_RECOVERY")]
    [Label("Crusader Upgrade Mp Recovery", 1)]
    CrusaderUpgradeMpRecovery = 1110000,

    /// <summary>Build combo orb attacks.</summary>
    [Label("CRUSADER_COMBO_ATTACK")]
    [Label("Crusader Combo Attack", 1)]
    CrusaderComboAttack = 1111002,

    /// <summary>Lower enemy accuracy.</summary>
    [Label("CRUSADER_PANIC")]
    [Label("Crusader Panic", 1)]
    CrusaderPanic = 1111003,

    /// <summary>Stun enemies with sword.</summary>
    [Label("CRUSADER_COMA")]
    [Label("Crusader Coma", 1)]
    CrusaderComa = 1111005,

    /// <summary>Cancel enemy buffs.</summary>
    [Label("CRUSADER_MAGIC_CRASH")]
    [Label("Crusader Magic Crash", 1)]
    CrusaderMagicCrash = 1111007,

    /// <summary>Stun nearby enemies.</summary>
    [Label("CRUSADER_SHOUT")]
    [Label("Crusader Shout", 1)]
    CrusaderShout = 1111008,

    /// <summary>Bonus damage on stunned.</summary>
    [Label("CRUSADER_CHANCE_ATTACK")]
    [Label("Crusader Chance Attack", 1)]
    CrusaderChanceAttack = 1110009,

    /// <summary>Wide-range sword slash.</summary>
    [Label("CRUSADER_BRANDISH")]
    [Label("Crusader Brandish", 1)]
    CrusaderBrandish = 1111010,

    /// <summary>Boost all party stats.</summary>
    [Label("HERO_MAPLE_HERO")]
    [Label("Hero Maple Hero", 1)]
    HeroMapleHero = 1121000,

    /// <summary>Pull enemies closer.</summary>
    [Label("HERO_MONSTER_MAGNET")]
    [Label("Hero Monster Magnet", 1)]
    HeroMonsterMagnet = 1121001,

    /// <summary>Resist knockback attacks.</summary>
    [Label("HERO_STANCE")]
    [Label("Hero Stance", 1)]
    HeroStance = 1121002,

    /// <summary>Enhanced combo system.</summary>
    [Label("HERO_ADVANCED_COMBO")]
    [Label("Hero Advanced Combo", 1)]
    HeroAdvancedCombo = 1120003,

    /// <summary>Reduce physical damage.</summary>
    [Label("HERO_HARD_SKIN")]
    [Label("Hero Hard Skin", 1)]
    HeroHardSkin = 1120004,

    /// <summary>Charge through enemies.</summary>
    [Label("HERO_RUSH")]
    [Label("Hero Rush", 1)]
    HeroRush = 1121006,

    /// <summary>Powerful finishing slash.</summary>
    [Label("HERO_BRAVE_SLASH")]
    [Label("Hero Brave Slash", 1)]
    HeroBraveSlash = 1121008,

    /// <summary>Boost attack greatly.</summary>
    [Label("HERO_ENRAGE")]
    [Label("Hero Enrage", 1)]
    HeroEnrage = 1121010,

    /// <summary>Remove all debuffs.</summary>
    [Label("HERO_HEROS_WILL")]
    [Label("Hero Heros Will", 1)]
    HeroHerosWill = 1121011,

    /// <summary>Boost combat proficiency.</summary>
    [Label("HERO_COMBAT_MASTERY")]
    [Label("Hero Combat Mastery", 1)]
    HeroCombatMastery = 1120012,

    /// <summary>Boost weapon proficiency.</summary>
    [Label("PAGE_WEAPON_MASTERY")]
    [Label("Page Weapon Mastery", 1)]
    PageWeaponMastery = 1200000,

    /// <summary>Extra hit after attack.</summary>
    [Label("PAGE_FINAL_ATTACK")]
    [Label("Page Final Attack", 1)]
    PageFinalAttack = 1200002,

    /// <summary>Boost attack speed.</summary>
    [Label("PAGE_WEAPON_BOOSTER")]
    [Label("Page Weapon Booster", 1)]
    PageWeaponBooster = 1201004,

    /// <summary>Lower enemy stats.</summary>
    [Label("PAGE_THREATEN")]
    [Label("Page Threaten", 1)]
    PageThreaten = 1201006,

    /// <summary>Reflect damage to attacker.</summary>
    [Label("PAGE_POWER_GUARD")]
    [Label("Page Power Guard", 1)]
    PagePowerGuard = 1201007,

    /// <summary>Smash ground area attack.</summary>
    [Label("PAGE_GROUND_SMASH")]
    [Label("Page Ground Smash", 1)]
    PageGroundSmash = 1201008,

    /// <summary>Improve basic abilities.</summary>
    [Label("PAGE_IMPROVE_BASIC")]
    [Label("Page Improve Basic", 1)]
    PageImproveBasic = 1200009,

    /// <summary>Boost shield proficiency.</summary>
    [Label("KNIGHT_SHIELD_MASTERY")]
    [Label("Knight Shield Mastery", 1)]
    KnightShieldMastery = 1210001,

    /// <summary>Charged elemental strike.</summary>
    [Label("KNIGHT_CHARGE_BLOW")]
    [Label("Knight Charge Blow", 1)]
    KnightChargeBlow = 1211002,

    /// <summary>Imbue weapon with fire.</summary>
    [Label("KNIGHT_FIRE_CHARGE")]
    [Label("Knight Fire Charge", 1)]
    KnightFireCharge = 1211004,

    /// <summary>Imbue weapon with ice.</summary>
    [Label("KNIGHT_ICE_CHARGE")]
    [Label("Knight Ice Charge", 1)]
    KnightIceCharge = 1211006,

    /// <summary>Imbue weapon with lightning.</summary>
    [Label("KNIGHT_LIGHTNING_CHARGE")]
    [Label("Knight Lightning Charge", 1)]
    KnightLightningCharge = 1211008,

    /// <summary>Cancel enemy buffs.</summary>
    [Label("KNIGHT_MAGIC_CRASH")]
    [Label("Knight Magic Crash", 1)]
    KnightMagicCrash = 1211009,

    /// <summary>Heal party HP over time.</summary>
    [Label("KNIGHT_RESTORATION")]
    [Label("Knight Restoration", 1)]
    KnightRestoration = 1211010,

    /// <summary>Boost party skill levels.</summary>
    [Label("KNIGHT_COMBAT_ORDERS")]
    [Label("Knight Combat Orders", 1)]
    KnightCombatOrders = 1211011,

    /// <summary>Boost all party stats.</summary>
    [Label("PALADIN_MAPLE_HERO")]
    [Label("Paladin Maple Hero", 1)]
    PaladinMapleHero = 1221000,

    /// <summary>Resist knockback attacks.</summary>
    [Label("PALADIN_STANCE")]
    [Label("Paladin Stance", 1)]
    PaladinStance = 1221002,

    /// <summary>Imbue weapon with holy.</summary>
    [Label("PALADIN_DIVINE_CHARGE")]
    [Label("Paladin Divine Charge", 1)]
    PaladinDivineCharge = 1221004,

    /// <summary>Reduce physical damage.</summary>
    [Label("PALADIN_HARD_SKIN")]
    [Label("Paladin Hard Skin", 1)]
    PaladinHardSkin = 1220005,

    /// <summary>Block attacks with shield.</summary>
    [Label("PALADIN_BLOCKING")]
    [Label("Paladin Blocking", 1)]
    PaladinBlocking = 1220006,

    /// <summary>Charge through enemies.</summary>
    [Label("PALADIN_RUSH")]
    [Label("Paladin Rush", 1)]
    PaladinRush = 1221007,

    /// <summary>Charged holy blast.</summary>
    [Label("PALADIN_BLAST")]
    [Label("Paladin Blast", 1)]
    PaladinBlast = 1221009,

    /// <summary>Enhanced charge mastery.</summary>
    [Label("PALADIN_ADVANCED_CHARGE")]
    [Label("Paladin Advanced Charge", 1)]
    PaladinAdvancedCharge = 1220010,

    /// <summary>Heal party with holy.</summary>
    [Label("PALADIN_SANCTUARY")]
    [Label("Paladin Sanctuary", 1)]
    PaladinSanctuary = 1221011,

    /// <summary>Remove all debuffs.</summary>
    [Label("PALADIN_HEROS_WILL")]
    [Label("Paladin Heros Will", 1)]
    PaladinHerosWill = 1221012,

    /// <summary>Bless party defense.</summary>
    [Label("PALADIN_BLESSING_ARMOR")]
    [Label("Paladin Blessing Armor", 1)]
    PaladinBlessingArmor = 1220013,

    /// <summary>Boost weapon proficiency.</summary>
    [Label("SPEARMAN_WEAPON_MASTERY")]
    [Label("Spearman Weapon Mastery", 1)]
    SpearmanWeaponMastery = 1300000,

    /// <summary>Extra hit after attack.</summary>
    [Label("SPEARMAN_FINAL_ATTACK")]
    [Label("Spearman Final Attack", 1)]
    SpearmanFinalAttack = 1300002,

    /// <summary>Boost attack speed.</summary>
    [Label("SPEARMAN_WEAPON_BOOSTER")]
    [Label("Spearman Weapon Booster", 1)]
    SpearmanWeaponBooster = 1301004,

    /// <summary>Boost party defense.</summary>
    [Label("SPEARMAN_IRON_WALL")]
    [Label("Spearman Iron Wall", 1)]
    SpearmanIronWall = 1301006,

    /// <summary>Increase max HP and MP.</summary>
    [Label("SPEARMAN_HYPER_BODY")]
    [Label("Spearman Hyper Body", 1)]
    SpearmanHyperBody = 1301007,

    /// <summary>Smash ground area attack.</summary>
    [Label("SPEARMAN_GROUND_SMASH")]
    [Label("Spearman Ground Smash", 1)]
    SpearmanGroundSmash = 1301008,

    /// <summary>Improve basic abilities.</summary>
    [Label("SPEARMAN_IMPROVE_BASIC")]
    [Label("Spearman Improve Basic", 1)]
    SpearmanImproveBasic = 1300009,

    /// <summary>Resist elemental damage.</summary>
    [Label("DRAGONKNIGHT_ELEMENT_RESISTANCE")]
    [Label("Dragonknight Element Resistance", 1)]
    DragonknightElementResistance = 1310000,

    /// <summary>Dragon spear burst.</summary>
    [Label("DRAGONKNIGHT_DRAGON_BURSTER")]
    [Label("Dragonknight Dragon Burster", 1)]
    DragonknightDragonBurster = 1311001,

    /// <summary>Dragon polearm sweep.</summary>
    [Label("DRAGONKNIGHT_DRAGON_THRESHER")]
    [Label("Dragonknight Dragon Thresher", 1)]
    DragonknightDragonThresher = 1311003,

    /// <summary>Trade HP for damage.</summary>
    [Label("DRAGONKNIGHT_SACRIFICE")]
    [Label("Dragonknight Sacrifice", 1)]
    DragonknightSacrifice = 1311005,

    /// <summary>Roar stunning all enemies.</summary>
    [Label("DRAGONKNIGHT_DRAGON_ROAR")]
    [Label("Dragonknight Dragon Roar", 1)]
    DragonknightDragonRoar = 1311006,

    /// <summary>Cancel enemy buffs.</summary>
    [Label("DRAGONKNIGHT_MAGIC_CRASH")]
    [Label("Dragonknight Magic Crash", 1)]
    DragonknightMagicCrash = 1311007,

    /// <summary>Trade HP for power.</summary>
    [Label("DRAGONKNIGHT_DRAGON_BLOOD")]
    [Label("Dragonknight Dragon Blood", 1)]
    DragonknightDragonBlood = 1311008,

    /// <summary>Dragon judgement strike.</summary>
    [Label("DRAGONKNIGHT_DRAGON_JUDGEMENT")]
    [Label("Dragonknight Dragon Judgement", 1)]
    DragonknightDragonJudgement = 1310009,

    /// <summary>Boost all party stats.</summary>
    [Label("DARKKNIGHT_MAPLE_HERO")]
    [Label("Darkknight Maple Hero", 1)]
    DarkknightMapleHero = 1321000,

    /// <summary>Pull enemies closer.</summary>
    [Label("DARKKNIGHT_MONSTER_MAGNET")]
    [Label("Darkknight Monster Magnet", 1)]
    DarkknightMonsterMagnet = 1321001,

    /// <summary>Resist knockback attacks.</summary>
    [Label("DARKKNIGHT_STANCE")]
    [Label("Darkknight Stance", 1)]
    DarkknightStance = 1321002,

    /// <summary>Charge through enemies.</summary>
    [Label("DARKKNIGHT_RUSH")]
    [Label("Darkknight Rush", 1)]
    DarkknightRush = 1321003,

    /// <summary>Reduce physical damage.</summary>
    [Label("DARKKNIGHT_HARD_SKIN")]
    [Label("Darkknight Hard Skin", 1)]
    DarkknightHardSkin = 1320005,

    /// <summary>Dark power weapon buff.</summary>
    [Label("DARKKNIGHT_DARK_FORCE")]
    [Label("Darkknight Dark Force", 1)]
    DarkknightDarkForce = 1320006,

    /// <summary>Summon Beholder familiar.</summary>
    [Label("DARKKNIGHT_BEHOLDER")]
    [Label("Darkknight Beholder", 1)]
    DarkknightBeholder = 1321007,

    /// <summary>Beholder heals master.</summary>
    [Label("DARKKNIGHT_BEHOLDERS_HEALING")]
    [Label("Darkknight Beholders Healing", 1)]
    DarkknightBeholdersHealing = 1320008,

    /// <summary>Beholder buffs master.</summary>
    [Label("DARKKNIGHT_BEHOLDERS_BUFF")]
    [Label("Darkknight Beholders Buff", 1)]
    DarkknightBeholdersBuff = 1320009,

    /// <summary>Remove all debuffs.</summary>
    [Label("DARKKNIGHT_HEROS_WILL")]
    [Label("Darkknight Heros Will", 1)]
    DarkknightHerosWill = 1321010,

    /// <summary>Beholder retaliates attacks.</summary>
    [Label("DARKKNIGHT_BEHOLDERS_REVENGE")]
    [Label("Darkknight Beholders Revenge", 1)]
    DarkknightBeholdersRevenge = 1320011,

    /// <summary>Absorb damage with MP.</summary>
    [Label("MAGICIAN_MAGIC_GUARD")]
    [Label("Magician Magic Guard", 1)]
    MagicianMagicGuard = 2001002,

    /// <summary>Boost magic defense.</summary>
    [Label("MAGICIAN_MAGIC_ARMOR")]
    [Label("Magician Magic Armor", 1)]
    MagicianMagicArmor = 2001003,

    /// <summary>Fire energy projectile.</summary>
    [Label("MAGICIAN_ENERGY_BOLT")]
    [Label("Magician Energy Bolt", 1)]
    MagicianEnergyBolt = 2001004,

    /// <summary>Magic claw attack.</summary>
    [Label("MAGICIAN_MAGIC_CLAW")]
    [Label("Magician Magic Claw", 1)]
    MagicianMagicClaw = 2001005,

    /// <summary>Increase max MP.</summary>
    [Label("MAGICIAN_MMP_INC")]
    [Label("Magician Max MP Inc", 1)]
    MagicianMmpInc = 2000006,

    /// <summary>Absorb enemy MP passively.</summary>
    [Label("WIZARD1_MP_EATER")]
    [Label("Wizard1Mp Eater", 1)]
    Wizard1MpEater = 2100000,

    /// <summary>Boost party magic attack.</summary>
    [Label("WIZARD1_MEDITATION")]
    Wizard1Meditation = 2101001,

    /// <summary>Teleport short distance.</summary>
    [Label("WIZARD1_TELEPORT")]
    Wizard1Teleport = 2101002,

    /// <summary>Slow enemy movement.</summary>
    [Label("WIZARD1_SLOW")]
    Wizard1Slow = 2101003,

    /// <summary>Fire arrow projectile.</summary>
    [Label("WIZARD1_FIRE_ARROW")]
    [Label("Wizard1Fire Arrow", 1)]
    Wizard1FireArrow = 2101004,

    /// <summary>Poison breath attack.</summary>
    [Label("WIZARD1_POISON_BREATH")]
    [Label("Wizard1Poison Breath", 1)]
    Wizard1PoisonBreath = 2101005,

    /// <summary>Boost spell proficiency.</summary>
    [Label("WIZARD1_SPELL_MASTERY")]
    [Label("Wizard1Spell Mastery", 1)]
    Wizard1SpellMastery = 2100006,

    /// <summary>Resist elemental damage.</summary>
    [Label("MAGE1_PARTIAL_RESISTANCE")]
    [Label("Mage1Partial Resistance", 1)]
    Mage1PartialResistance = 2110000,

    /// <summary>Amplify elemental damage.</summary>
    [Label("MAGE1_ELEMENT_AMPLIFICATION")]
    [Label("Mage1Element Amplification", 1)]
    Mage1ElementAmplification = 2110001,

    /// <summary>Fire explosion attack.</summary>
    [Label("MAGE1_EXPLOSION")]
    Mage1Explosion = 2111002,

    /// <summary>Create poison mist cloud.</summary>
    [Label("MAGE1_POISON_MIST")]
    [Label("Mage1Poison Mist", 1)]
    Mage1PoisonMist = 2111003,

    /// <summary>Seal enemy skills.</summary>
    [Label("MAGE1_SEAL")]
    Mage1Seal = 2111004,

    /// <summary>Boost casting speed.</summary>
    [Label("MAGE1_MAGIC_BOOSTER")]
    [Label("Mage1Magic Booster", 1)]
    Mage1MagicBooster = 2111005,

    /// <summary>Combine element attacks.</summary>
    [Label("MAGE1_MAGIC_COMPOSITION")]
    [Label("Mage1Magic Composition", 1)]
    Mage1MagicComposition = 2111006,

    /// <summary>Enhanced teleport range.</summary>
    [Label("MAGE1_TELEPORT_MASTERY")]
    [Label("Mage1Teleport Mastery", 1)]
    Mage1TeleportMastery = 2111007,

    /// <summary>Reset elemental penalty.</summary>
    [Label("MAGE1_ELEMENTAL_RESET")]
    [Label("Mage1Elemental Reset", 1)]
    Mage1ElementalReset = 2111008,

    /// <summary>Boost all party stats.</summary>
    [Label("ARCHMAGE1_MAPLE_HERO")]
    [Label("Archmage1Maple Hero", 1)]
    Archmage1MapleHero = 2121000,

    /// <summary>Massive AoE magic blast.</summary>
    [Label("ARCHMAGE1_BIGBANG")]
    Archmage1Bigbang = 2121001,

    /// <summary>Reflect magic damage.</summary>
    [Label("ARCHMAGE1_MANA_REFLECTION")]
    [Label("Archmage1Mana Reflection", 1)]
    Archmage1ManaReflection = 2121002,

    /// <summary>Summon Fire Demon.</summary>
    [Label("ARCHMAGE1_FIRE_DEMON")]
    [Label("Archmage1Fire Demon", 1)]
    Archmage1FireDemon = 2121003,

    /// <summary>Unlimited MP temporarily.</summary>
    [Label("ARCHMAGE1_INFINITY")]
    Archmage1Infinity = 2121004,

    /// <summary>Summon Ifrit familiar.</summary>
    [Label("ARCHMAGE1_IFRIT")]
    Archmage1Ifrit = 2121005,

    /// <summary>Paralyze enemies with ice.</summary>
    [Label("ARCHMAGE1_PARALYZE")]
    Archmage1Paralyze = 2121006,

    /// <summary>Call down meteor shower.</summary>
    [Label("ARCHMAGE1_METEOR")]
    Archmage1Meteor = 2121007,

    /// <summary>Remove all debuffs.</summary>
    [Label("ARCHMAGE1_HEROS_WILL")]
    [Label("Archmage1Heros Will", 1)]
    Archmage1HerosWill = 2121008,

    /// <summary>Master magic proficiency.</summary>
    [Label("ARCHMAGE1_MASTER_MAGIC")]
    [Label("Archmage1Master Magic", 1)]
    Archmage1MasterMagic = 2120009,

    /// <summary>Absorb enemy MP passively.</summary>
    [Label("WIZARD2_MP_EATER")]
    [Label("Wizard2Mp Eater", 1)]
    Wizard2MpEater = 2200000,

    /// <summary>Boost party magic attack.</summary>
    [Label("WIZARD2_MEDITATION")]
    Wizard2Meditation = 2201001,

    /// <summary>Teleport short distance.</summary>
    [Label("WIZARD2_TELEPORT")]
    Wizard2Teleport = 2201002,

    /// <summary>Slow enemy movement.</summary>
    [Label("WIZARD2_SLOW")]
    Wizard2Slow = 2201003,

    /// <summary>Ice beam attack.</summary>
    [Label("WIZARD2_COLD_BEAM")]
    [Label("Wizard2Cold Beam", 1)]
    Wizard2ColdBeam = 2201004,

    /// <summary>Lightning bolt attack.</summary>
    [Label("WIZARD2_THUNDER_BOLT")]
    [Label("Wizard2Thunder Bolt", 1)]
    Wizard2ThunderBolt = 2201005,

    /// <summary>Boost spell proficiency.</summary>
    [Label("WIZARD2_SPELL_MASTERY")]
    [Label("Wizard2Spell Mastery", 1)]
    Wizard2SpellMastery = 2200006,

    /// <summary>Resist elemental damage.</summary>
    [Label("MAGE2_PARTIAL_RESISTANCE")]
    [Label("Mage2Partial Resistance", 1)]
    Mage2PartialResistance = 2210000,

    /// <summary>Amplify elemental damage.</summary>
    [Label("MAGE2_ELEMENT_AMPLIFICATION")]
    [Label("Mage2Element Amplification", 1)]
    Mage2ElementAmplification = 2210001,

    /// <summary>Wide ice strike attack.</summary>
    [Label("MAGE2_ICE_STRIKE")]
    [Label("Mage2Ice Strike", 1)]
    Mage2IceStrike = 2211002,

    /// <summary>Lightning spear attack.</summary>
    [Label("MAGE2_THUNDER_SPEAR")]
    [Label("Mage2Thunder Spear", 1)]
    Mage2ThunderSpear = 2211003,

    /// <summary>Seal enemy skills.</summary>
    [Label("MAGE2_SEAL")]
    Mage2Seal = 2211004,

    /// <summary>Boost casting speed.</summary>
    [Label("MAGE2_MAGIC_BOOSTER")]
    [Label("Mage2Magic Booster", 1)]
    Mage2MagicBooster = 2211005,

    /// <summary>Combine element attacks.</summary>
    [Label("MAGE2_MAGIC_COMPOSITION")]
    [Label("Mage2Magic Composition", 1)]
    Mage2MagicComposition = 2211006,

    /// <summary>Enhanced teleport range.</summary>
    [Label("MAGE2_TELEPORT_MASTERY")]
    [Label("Mage2Teleport Mastery", 1)]
    Mage2TeleportMastery = 2211007,

    /// <summary>Reset elemental penalty.</summary>
    [Label("MAGE2_ELEMENTAL_RESET")]
    [Label("Mage2Elemental Reset", 1)]
    Mage2ElementalReset = 2211008,

    /// <summary>Boost all party stats.</summary>
    [Label("ARCHMAGE2_MAPLE_HERO")]
    [Label("Archmage2Maple Hero", 1)]
    Archmage2MapleHero = 2221000,

    /// <summary>Massive AoE magic blast.</summary>
    [Label("ARCHMAGE2_BIGBANG")]
    Archmage2Bigbang = 2221001,

    /// <summary>Reflect magic damage.</summary>
    [Label("ARCHMAGE2_MANA_REFLECTION")]
    [Label("Archmage2Mana Reflection", 1)]
    Archmage2ManaReflection = 2221002,

    /// <summary>Summon Ice Demon.</summary>
    [Label("ARCHMAGE2_ICE_DEMON")]
    [Label("Archmage2Ice Demon", 1)]
    Archmage2IceDemon = 2221003,

    /// <summary>Unlimited MP temporarily.</summary>
    [Label("ARCHMAGE2_INFINITY")]
    Archmage2Infinity = 2221004,

    /// <summary>Summon Elquines familiar.</summary>
    [Label("ARCHMAGE2_ELQUINES")]
    Archmage2Elquines = 2221005,

    /// <summary>Chain lightning attack.</summary>
    [Label("ARCHMAGE2_CHAIN_LIGHTNING")]
    [Label("Archmage2Chain Lightning", 1)]
    Archmage2ChainLightning = 2221006,

    /// <summary>Call down blizzard storm.</summary>
    [Label("ARCHMAGE2_BLIZZARD")]
    Archmage2Blizzard = 2221007,

    /// <summary>Remove all debuffs.</summary>
    [Label("ARCHMAGE2_HEROS_WILL")]
    [Label("Archmage2Heros Will", 1)]
    Archmage2HerosWill = 2221008,

    /// <summary>Master magic proficiency.</summary>
    [Label("ARCHMAGE2_MASTER_MAGIC")]
    [Label("Archmage2Master Magic", 1)]
    Archmage2MasterMagic = 2220009,

    /// <summary>Absorb enemy MP passively.</summary>
    [Label("CLERIC_MP_EATER")]
    [Label("Cleric Mp Eater", 1)]
    ClericMpEater = 2300000,

    /// <summary>Teleport short distance.</summary>
    [Label("CLERIC_TELEPORT")]
    [Label("Cleric Teleport", 1)]
    ClericTeleport = 2301001,

    /// <summary>Heal party members.</summary>
    [Label("CLERIC_HEAL")]
    [Label("Cleric Heal", 1)]
    ClericHeal = 2301002,

    /// <summary>Temporary invincibility.</summary>
    [Label("CLERIC_INVINCIBLE")]
    [Label("Cleric Invincible", 1)]
    ClericInvincible = 2301003,

    /// <summary>Boost party stats.</summary>
    [Label("CLERIC_BLESS")]
    [Label("Cleric Bless", 1)]
    ClericBless = 2301004,

    /// <summary>Holy arrow attack.</summary>
    [Label("CLERIC_HOLY_ARROW")]
    [Label("Cleric Holy Arrow", 1)]
    ClericHolyArrow = 2301005,

    /// <summary>Boost spell proficiency.</summary>
    [Label("CLERIC_SPELL_MASTERY")]
    [Label("Cleric Spell Mastery", 1)]
    ClericSpellMastery = 2300006,

    /// <summary>Resist elemental damage.</summary>
    [Label("PRIEST_ELEMENT_RESISTANCE")]
    [Label("Priest Element Resistance", 1)]
    PriestElementResistance = 2310000,

    /// <summary>Remove party debuffs.</summary>
    [Label("PRIEST_DISPEL")]
    [Label("Priest Dispel", 1)]
    PriestDispel = 2311001,

    /// <summary>Open town portal.</summary>
    [Label("PRIEST_MYSTIC_DOOR")]
    [Label("Priest Mystic Door", 1)]
    PriestMysticDoor = 2311002,

    /// <summary>Boost party EXP gain.</summary>
    [Label("PRIEST_HOLY_SYMBOL")]
    [Label("Priest Holy Symbol", 1)]
    PriestHolySymbol = 2311003,

    /// <summary>Holy light ray attack.</summary>
    [Label("PRIEST_SHINING_RAY")]
    [Label("Priest Shining Ray", 1)]
    PriestShiningRay = 2311004,

    /// <summary>Turn enemies into snails.</summary>
    [Label("PRIEST_DOOM")]
    [Label("Priest Doom", 1)]
    PriestDoom = 2311005,

    /// <summary>Summon holy dragon.</summary>
    [Label("PRIEST_SUMMON_DRAGON")]
    [Label("Priest Summon Dragon", 1)]
    PriestSummonDragon = 2311006,

    /// <summary>Enhanced teleport range.</summary>
    [Label("PRIEST_TELEPORT_MASTERY")]
    [Label("Priest Teleport Mastery", 1)]
    PriestTeleportMastery = 2311007,

    /// <summary>Boost holy skill damage.</summary>
    [Label("PRIEST_HOLY_FOCUS")]
    [Label("Priest Holy Focus", 1)]
    PriestHolyFocus = 2310008,

    /// <summary>Boost all party stats.</summary>
    [Label("BISHOP_MAPLE_HERO")]
    [Label("Bishop Maple Hero", 1)]
    BishopMapleHero = 2321000,

    /// <summary>Massive AoE magic blast.</summary>
    [Label("BISHOP_BIGBANG")]
    [Label("Bishop Bigbang", 1)]
    BishopBigbang = 2321001,

    /// <summary>Reflect magic damage.</summary>
    [Label("BISHOP_MANA_REFLECTION")]
    [Label("Bishop Mana Reflection", 1)]
    BishopManaReflection = 2321002,

    /// <summary>Summon Bahamut dragon.</summary>
    [Label("BISHOP_BAHAMUT")]
    [Label("Bishop Bahamut", 1)]
    BishopBahamut = 2321003,

    /// <summary>Unlimited MP temporarily.</summary>
    [Label("BISHOP_INFINITY")]
    [Label("Bishop Infinity", 1)]
    BishopInfinity = 2321004,

    /// <summary>Shield party from status.</summary>
    [Label("BISHOP_HOLY_SHIELD")]
    [Label("Bishop Holy Shield", 1)]
    BishopHolyShield = 2321005,

    /// <summary>Revive fallen party members.</summary>
    [Label("BISHOP_RESURRECTION")]
    [Label("Bishop Resurrection", 1)]
    BishopResurrection = 2321006,

    /// <summary>Angel's ray heal attack.</summary>
    [Label("BISHOP_ANGELS_RAY")]
    [Label("Bishop Angels Ray", 1)]
    BishopAngelsRay = 2321007,

    /// <summary>Ultimate holy AoE attack.</summary>
    [Label("BISHOP_GENESIS")]
    [Label("Bishop Genesis", 1)]
    BishopGenesis = 2321008,

    /// <summary>Remove all debuffs.</summary>
    [Label("BISHOP_HEROS_WILL")]
    [Label("Bishop Heros Will", 1)]
    BishopHerosWill = 2321009,

    /// <summary>Master magic proficiency.</summary>
    [Label("BISHOP_MASTER_MAGIC")]
    [Label("Bishop Master Magic", 1)]
    BishopMasterMagic = 2320010,

    /// <summary>Boost critical hit chance.</summary>
    [Label("ARCHER_CRITICAL_SHOT")]
    [Label("Archer Critical Shot", 1)]
    ArcherCriticalShot = 3000001,

    /// <summary>Increase accuracy range.</summary>
    [Label("ARCHER_AMAZON_EYE")]
    [Label("Archer Amazon Eye", 1)]
    ArcherAmazonEye = 3000002,

    /// <summary>Boost accuracy and avoid.</summary>
    [Label("ARCHER_FOCUS")]
    [Label("Archer Focus", 1)]
    ArcherFocus = 3001003,

    /// <summary>Basic arrow attack.</summary>
    [Label("ARCHER_ARROW_BLOW")]
    [Label("Archer Arrow Blow", 1)]
    ArcherArrowBlow = 3001004,

    /// <summary>Fire two arrows.</summary>
    [Label("ARCHER_DOUBLE_SHOT")]
    [Label("Archer Double Shot", 1)]
    ArcherDoubleShot = 3001005,

    /// <summary>Boost bow proficiency.</summary>
    [Label("HUNTER_BOW_MASTERY")]
    [Label("Hunter Bow Mastery", 1)]
    HunterBowMastery = 3100000,

    /// <summary>Extra bow hit after attack.</summary>
    [Label("HUNTER_FINAL_ATTACK_BOW")]
    [Label("Hunter Final Attack Bow", 1)]
    HunterFinalAttackBow = 3100001,

    /// <summary>Boost bow attack speed.</summary>
    [Label("HUNTER_BOW_BOOSTER")]
    [Label("Hunter Bow Booster", 1)]
    HunterBowBooster = 3101002,

    /// <summary>Knock enemies backward.</summary>
    [Label("HUNTER_POWER_KNOCKBACK")]
    [Label("Hunter Power Knockback", 1)]
    HunterPowerKnockback = 3101003,

    /// <summary>Fire without consuming arrows.</summary>
    [Label("HUNTER_SOUL_ARROW_BOW")]
    [Label("Hunter Soul Arrow Bow", 1)]
    HunterSoulArrowBow = 3101004,

    /// <summary>Exploding arrow attack.</summary>
    [Label("HUNTER_ARROW_BOMB")]
    [Label("Hunter Arrow Bomb", 1)]
    HunterArrowBomb = 3101005,

    /// <summary>Improve basic abilities.</summary>
    [Label("HUNTER_IMPROVE_BASIC")]
    [Label("Hunter Improve Basic", 1)]
    HunterImproveBasic = 3100006,

    /// <summary>Boost movement with gear.</summary>
    [Label("RANGER_THRUST")]
    [Label("Ranger Thrust", 1)]
    RangerThrust = 3110000,

    /// <summary>Chance to instant-kill.</summary>
    [Label("RANGER_MORTAL_BLOW")]
    [Label("Ranger Mortal Blow", 1)]
    RangerMortalBlow = 3110001,

    /// <summary>Deploy decoy puppet.</summary>
    [Label("RANGER_PUPPET")]
    [Label("Ranger Puppet", 1)]
    RangerPuppet = 3111002,

    /// <summary>Fire-element arrow shot.</summary>
    [Label("RANGER_FIRE_SHOT")]
    [Label("Ranger Fire Shot", 1)]
    RangerFireShot = 3111003,

    /// <summary>Rain arrows from sky.</summary>
    [Label("RANGER_ARROW_RAIN")]
    [Label("Ranger Arrow Rain", 1)]
    RangerArrowRain = 3111004,

    /// <summary>Summon Silver Hawk.</summary>
    [Label("RANGER_SILVER_HAWK")]
    [Label("Ranger Silver Hawk", 1)]
    RangerSilverHawk = 3111005,

    /// <summary>Rapid multi-arrow attack.</summary>
    [Label("RANGER_STRAFE")]
    [Label("Ranger Strafe", 1)]
    RangerStrafe = 3111006,

    /// <summary>Chance to dodge attacks.</summary>
    [Label("RANGER_DODGE")]
    [Label("Ranger Dodge", 1)]
    RangerDodge = 3110007,

    /// <summary>Boost all party stats.</summary>
    [Label("BOWMASTER_MAPLE_HERO")]
    [Label("Bowmaster Maple Hero", 1)]
    BowmasterMapleHero = 3121000,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("BOWMASTER_SHARP_EYES")]
    [Label("Bowmaster Sharp Eyes", 1)]
    BowmasterSharpEyes = 3121002,

    /// <summary>Push enemies with dragon.</summary>
    [Label("BOWMASTER_DRAGON_PULSE")]
    [Label("Bowmaster Dragon Pulse", 1)]
    BowmasterDragonPulse = 3121003,

    /// <summary>Rapid-fire arrow volley.</summary>
    [Label("BOWMASTER_STORM_ARROW")]
    [Label("Bowmaster Storm Arrow", 1)]
    BowmasterStormArrow = 3121004,

    /// <summary>Master bow proficiency.</summary>
    [Label("BOWMASTER_BOW_EXPERT")]
    [Label("Bowmaster Bow Expert", 1)]
    BowmasterBowExpert = 3120005,

    /// <summary>Summon Phoenix familiar.</summary>
    [Label("BOWMASTER_PHOENIX")]
    [Label("Bowmaster Phoenix", 1)]
    BowmasterPhoenix = 3121006,

    /// <summary>Slow enemies on hit.</summary>
    [Label("BOWMASTER_HAMSTRING")]
    [Label("Bowmaster Hamstring", 1)]
    BowmasterHamstring = 3121007,

    /// <summary>Focus for max damage.</summary>
    [Label("BOWMASTER_CONCENTRATION")]
    [Label("Bowmaster Concentration", 1)]
    BowmasterConcentration = 3121008,

    /// <summary>Remove all debuffs.</summary>
    [Label("BOWMASTER_HEROS_WILL")]
    [Label("Bowmaster Heros Will", 1)]
    BowmasterHerosWill = 3121009,

    /// <summary>Counter-attack on hit.</summary>
    [Label("BOWMASTER_VENGEANCE")]
    [Label("Bowmaster Vengeance", 1)]
    BowmasterVengeance = 3120010,

    /// <summary>Boost ranged damage.</summary>
    [Label("BOWMASTER_MARKMAN_SHIP")]
    [Label("Bowmaster Marksmanship", 1)]
    BowmasterMarkmanShip = 3120011,

    /// <summary>Boost crossbow proficiency.</summary>
    [Label("CROSSBOWMAN_CROSSBOW_MASTERY")]
    [Label("Crossbowman Crossbow Mastery", 1)]
    CrossbowmanCrossbowMastery = 3200000,

    /// <summary>Extra crossbow hit after attack.</summary>
    [Label("CROSSBOWMAN_FINAL_ATTACK_CROSSBOW")]
    [Label("Crossbowman Final Attack Crossbow", 1)]
    CrossbowmanFinalAttackCrossbow = 3200001,

    /// <summary>Boost crossbow attack speed.</summary>
    [Label("CROSSBOWMAN_CROSSBOW_BOOSTER")]
    [Label("Crossbowman Crossbow Booster", 1)]
    CrossbowmanCrossbowBooster = 3201002,

    /// <summary>Knock enemies backward.</summary>
    [Label("CROSSBOWMAN_POWER_KNOCKBACK")]
    [Label("Crossbowman Power Knockback", 1)]
    CrossbowmanPowerKnockback = 3201003,

    /// <summary>Fire without consuming bolts.</summary>
    [Label("CROSSBOWMAN_SOUL_ARROW_CROSSBOW")]
    [Label("Crossbowman Soul Arrow Crossbow", 1)]
    CrossbowmanSoulArrowCrossbow = 3201004,

    /// <summary>Piercing iron arrow.</summary>
    [Label("CROSSBOWMAN_IRON_ARROW")]
    [Label("Crossbowman Iron Arrow", 1)]
    CrossbowmanIronArrow = 3201005,

    /// <summary>Improve basic abilities.</summary>
    [Label("CROSSBOWMAN_IMPROVE_BASIC")]
    [Label("Crossbowman Improve Basic", 1)]
    CrossbowmanImproveBasic = 3200006,

    /// <summary>Boost movement with gear.</summary>
    [Label("SNIPER_THRUST")]
    [Label("Sniper Thrust", 1)]
    SniperThrust = 3210000,

    /// <summary>Chance to instant-kill.</summary>
    [Label("SNIPER_MORTAL_BLOW")]
    [Label("Sniper Mortal Blow", 1)]
    SniperMortalBlow = 3210001,

    /// <summary>Deploy decoy puppet.</summary>
    [Label("SNIPER_PUPPET")]
    [Label("Sniper Puppet", 1)]
    SniperPuppet = 3211002,

    /// <summary>Ice-element arrow shot.</summary>
    [Label("SNIPER_ICE_SHOT")]
    [Label("Sniper Ice Shot", 1)]
    SniperIceShot = 3211003,

    /// <summary>Erupting arrow volley.</summary>
    [Label("SNIPER_ARROW_ERUPTION")]
    [Label("Sniper Arrow Eruption", 1)]
    SniperArrowEruption = 3211004,

    /// <summary>Summon Golden Eagle.</summary>
    [Label("SNIPER_GOLDEN_EAGLE")]
    [Label("Sniper Golden Eagle", 1)]
    SniperGoldenEagle = 3211005,

    /// <summary>Rapid multi-arrow attack.</summary>
    [Label("SNIPER_STRAFE")]
    [Label("Sniper Strafe", 1)]
    SniperStrafe = 3211006,

    /// <summary>Chance to dodge attacks.</summary>
    [Label("SNIPER_DODGE")]
    [Label("Sniper Dodge", 1)]
    SniperDodge = 3210007,

    /// <summary>Boost all party stats.</summary>
    [Label("CROSSBOWMASTER_MAPLE_HERO")]
    [Label("Crossbowmaster Maple Hero", 1)]
    CrossbowmasterMapleHero = 3221000,

    /// <summary>Pierce through enemies.</summary>
    [Label("CROSSBOWMASTER_PIERCING")]
    [Label("Crossbowmaster Piercing", 1)]
    CrossbowmasterPiercing = 3221001,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("CROSSBOWMASTER_SHARP_EYES")]
    [Label("Crossbowmaster Sharp Eyes", 1)]
    CrossbowmasterSharpEyes = 3221002,

    /// <summary>Push enemies with dragon.</summary>
    [Label("CROSSBOWMASTER_DRAGON_PULSE")]
    [Label("Crossbowmaster Dragon Pulse", 1)]
    CrossbowmasterDragonPulse = 3221003,

    /// <summary>Master crossbow proficiency.</summary>
    [Label("CROSSBOWMASTER_CROSSBOW_EXPERT")]
    [Label("Crossbowmaster Crossbow Expert", 1)]
    CrossbowmasterCrossbowExpert = 3220004,

    /// <summary>Summon Freezer familiar.</summary>
    [Label("CROSSBOWMASTER_FREEZER")]
    [Label("Crossbowmaster Freezer", 1)]
    CrossbowmasterFreezer = 3221005,

    /// <summary>Blind enemies on hit.</summary>
    [Label("CROSSBOWMASTER_BLIND")]
    [Label("Crossbowmaster Blind", 1)]
    CrossbowmasterBlind = 3221006,

    /// <summary>One-shot snipe attack.</summary>
    [Label("CROSSBOWMASTER_SNIPING")]
    [Label("Crossbowmaster Sniping", 1)]
    CrossbowmasterSniping = 3221007,

    /// <summary>Remove all debuffs.</summary>
    [Label("CROSSBOWMASTER_HEROS_WILL")]
    [Label("Crossbowmaster Heros Will", 1)]
    CrossbowmasterHerosWill = 3221008,

    /// <summary>Boost ranged damage.</summary>
    [Label("CROSSBOWMASTER_MARKMAN_SHIP")]
    [Label("Crossbowmaster Marksmanship", 1)]
    CrossbowmasterMarkmanShip = 3220009,

    /// <summary>Enhanced rapid-fire attack.</summary>
    [Label("CROSSBOWMASTER_ULTIMATE_STRAFE")]
    [Label("Crossbowmaster Ultimate Strafe", 1)]
    CrossbowmasterUltimateStrafe = 3220010,

    /// <summary>Boost avoid and accuracy.</summary>
    [Label("ROGUE_NIMBLE_BODY")]
    [Label("Rogue Nimble Body", 1)]
    RogueNimbleBody = 4000000,

    /// <summary>Increase throwing range.</summary>
    [Label("ROGUE_KEEN_EYES")]
    [Label("Rogue Keen Eyes", 1)]
    RogueKeenEyes = 4000001,

    /// <summary>Lower enemy stats.</summary>
    [Label("ROGUE_DISORDER")]
    [Label("Rogue Disorder", 1)]
    RogueDisorder = 4001002,

    /// <summary>Turn invisible.</summary>
    [Label("ROGUE_DARK_SIGHT")]
    [Label("Rogue Dark Sight", 1)]
    RogueDarkSight = 4001003,

    /// <summary>Double dagger stab.</summary>
    [Label("ROGUE_DOUBLE_STAB_DAGGER")]
    [Label("Rogue Double Stab Dagger", 1)]
    RogueDoubleStabDagger = 4001334,

    /// <summary>Throw two stars.</summary>
    [Label("ROGUE_LUCKY_SEVEN")]
    [Label("Rogue Lucky Seven", 1)]
    RogueLuckySeven = 4001344,

    /// <summary>Boost star proficiency.</summary>
    [Label("ASSASSIN_JAVELIN_MASTERY")]
    [Label("Assassin Javelin Mastery", 1)]
    AssassinJavelinMastery = 4100000,

    /// <summary>Boost star critical rate.</summary>
    [Label("ASSASSIN_CRITICAL_THROW")]
    [Label("Assassin Critical Throw", 1)]
    AssassinCriticalThrow = 4100001,

    /// <summary>Boost throwing speed.</summary>
    [Label("ASSASSIN_JAVELIN_BOOSTER")]
    [Label("Assassin Javelin Booster", 1)]
    AssassinJavelinBooster = 4101003,

    /// <summary>Increase speed and jump.</summary>
    [Label("ASSASSIN_HASTE")]
    [Label("Assassin Haste", 1)]
    AssassinHaste = 4101004,

    /// <summary>Absorb enemy HP.</summary>
    [Label("ASSASSIN_DRAIN")]
    [Label("Assassin Drain", 1)]
    AssassinDrain = 4101005,

    /// <summary>Resist status effects.</summary>
    [Label("ASSASSIN_SHADOW_RESISTANCE")]
    [Label("Assassin Shadow Resistance", 1)]
    AssassinShadowResistance = 4100006,

    /// <summary>Boost potion recovery.</summary>
    [Label("HERMIT_ALCHEMIST")]
    [Label("Hermit Alchemist", 1)]
    HermitAlchemist = 4110000,

    /// <summary>Increase meso drops.</summary>
    [Label("HERMIT_MESO_UP")]
    [Label("Hermit Meso Up", 1)]
    HermitMesoUp = 4111001,

    /// <summary>Shadow mirror attacks.</summary>
    [Label("HERMIT_SHADOW_PARTNER")]
    [Label("Hermit Shadow Partner", 1)]
    HermitShadowPartner = 4111002,

    /// <summary>Trap enemies in web.</summary>
    [Label("HERMIT_SHADOW_WEB")]
    [Label("Hermit Shadow Web", 1)]
    HermitShadowWeb = 4111003,

    /// <summary>Throw meso to attack.</summary>
    [Label("HERMIT_SHADOW_MESO")]
    [Label("Hermit Shadow Meso", 1)]
    HermitShadowMeso = 4111004,

    /// <summary>Throw giant star.</summary>
    [Label("HERMIT_AVENGER")]
    [Label("Hermit Avenger", 1)]
    HermitAvenger = 4111005,

    /// <summary>Flash jump forward.</summary>
    [Label("HERMIT_FLASH_JUMP")]
    [Label("Hermit Flash Jump", 1)]
    HermitFlashJump = 4111006,

    /// <summary>Mirror image evasion.</summary>
    [Label("HERMIT_SHADOW_MIRROR")]
    [Label("Hermit Shadow Mirror", 1)]
    HermitShadowMirror = 4111007,

    /// <summary>Boost all party stats.</summary>
    [Label("NIGHTLORD_MAPLE_HERO")]
    [Label("Nightlord Maple Hero", 1)]
    NightlordMapleHero = 4121000,

    /// <summary>Create shadow decoy.</summary>
    [Label("NIGHTLORD_FAKE")]
    [Label("Nightlord Fake", 1)]
    NightlordFake = 4120002,

    /// <summary>Boost drops from target.</summary>
    [Label("NIGHTLORD_SHOWDOWN")]
    [Label("Nightlord Showdown", 1)]
    NightlordShowdown = 4121003,

    /// <summary>HP drain over time.</summary>
    [Label("NIGHTLORD_NINJA_AMBUSH")]
    [Label("Nightlord Ninja Ambush", 1)]
    NightlordNinjaAmbush = 4121004,

    /// <summary>Apply venom to attacks.</summary>
    [Label("NIGHTLORD_VENOM")]
    [Label("Nightlord Venom", 1)]
    NightlordVenom = 4120005,

    /// <summary>Unlimited throwing stars.</summary>
    [Label("NIGHTLORD_SPIRIT_JAVELIN")]
    [Label("Nightlord Spirit Javelin", 1)]
    NightlordSpiritJavelin = 4121006,

    /// <summary>Throw three stars.</summary>
    [Label("NIGHTLORD_TRIPLE_THROW")]
    [Label("Nightlord Triple Throw", 1)]
    NightlordTripleThrow = 4121007,

    /// <summary>AoE star attack.</summary>
    [Label("NIGHTLORD_NINJA_STORM")]
    [Label("Nightlord Ninja Storm", 1)]
    NightlordNinjaStorm = 4121008,

    /// <summary>Remove all debuffs.</summary>
    [Label("NIGHTLORD_HEROS_WILL")]
    [Label("Nightlord Heros Will", 1)]
    NightlordHerosWill = 4121009,

    /// <summary>Master star proficiency.</summary>
    [Label("NIGHTLORD_EXPERT_JAVELIN")]
    [Label("Nightlord Expert Javelin", 1)]
    NightlordExpertJavelin = 4120010,

    /// <summary>Boost dagger proficiency.</summary>
    [Label("THIEF_DAGGER_MASTERY")]
    [Label("Thief Dagger Mastery", 1)]
    ThiefDaggerMastery = 4200000,

    /// <summary>Boost dagger attack speed.</summary>
    [Label("THIEF_DAGGER_BOOSTER")]
    [Label("Thief Dagger Booster", 1)]
    ThiefDaggerBooster = 4201002,

    /// <summary>Increase speed and jump.</summary>
    [Label("THIEF_HASTE")]
    [Label("Thief Haste", 1)]
    ThiefHaste = 4201003,

    /// <summary>Steal items from enemies.</summary>
    [Label("THIEF_STEAL")]
    [Label("Thief Steal", 1)]
    ThiefSteal = 4201004,

    /// <summary>Six-hit dagger combo.</summary>
    [Label("THIEF_SAVAGE_BLOW_DAGGER")]
    [Label("Thief Savage Blow Dagger", 1)]
    ThiefSavageBlowDagger = 4201005,

    /// <summary>Resist status effects.</summary>
    [Label("THIEF_SHADOW_RESISTANCE")]
    [Label("Thief Shadow Resistance", 1)]
    ThiefShadowResistance = 4200006,

    /// <summary>Boost shield proficiency.</summary>
    [Label("THIEFMASTER_SHIELD_MASTERY")]
    [Label("Thiefmaster Shield Mastery", 1)]
    ThiefmasterShieldMastery = 4210000,

    /// <summary>Convert MP to HP.</summary>
    [Label("THIEFMASTER_CHAKRA")]
    [Label("Thiefmaster Chakra", 1)]
    ThiefmasterChakra = 4211001,

    /// <summary>Dash attack through enemy.</summary>
    [Label("THIEFMASTER_ASSAULTER")]
    [Label("Thiefmaster Assaulter", 1)]
    ThiefmasterAssaulter = 4211002,

    /// <summary>Drop meso on attacks.</summary>
    [Label("THIEFMASTER_PICKPOCKET")]
    [Label("Thiefmaster Pickpocket", 1)]
    ThiefmasterPickpocket = 4211003,

    /// <summary>Band of Thieves attack.</summary>
    [Label("THIEFMASTER_THIEVES")]
    [Label("Thiefmaster Thieves", 1)]
    ThiefmasterThieves = 4211004,

    /// <summary>Use meso to reduce damage.</summary>
    [Label("THIEFMASTER_MESO_GUARD")]
    [Label("Thiefmaster Meso Guard", 1)]
    ThiefmasterMesoGuard = 4211005,

    /// <summary>Detonate dropped meso.</summary>
    [Label("THIEFMASTER_MESO_EXPLOSION")]
    [Label("Thiefmaster Meso Explosion", 1)]
    ThiefmasterMesoExplosion = 4211006,

    /// <summary>Mirror image evasion.</summary>
    [Label("THIEFMASTER_SHADOW_MIRROR")]
    [Label("Thiefmaster Shadow Mirror", 1)]
    ThiefmasterShadowMirror = 4211007,

    /// <summary>Shadow mirror attacks.</summary>
    [Label("THIEFMASTER_SHADOW_PARTNER")]
    [Label("Thiefmaster Shadow Partner", 1)]
    ThiefmasterShadowPartner = 4211008,

    /// <summary>Flash jump forward.</summary>
    [Label("THIEFMASTER_FLASH_JUMP")]
    [Label("Thiefmaster Flash Jump", 1)]
    ThiefmasterFlashJump = 4211009,

    /// <summary>Boost all party stats.</summary>
    [Label("SHADOWER_MAPLE_HERO")]
    [Label("Shadower Maple Hero", 1)]
    ShadowerMapleHero = 4221000,

    /// <summary>Deadly dagger strike.</summary>
    [Label("SHADOWER_ASSASSINATION")]
    [Label("Shadower Assassination", 1)]
    ShadowerAssassination = 4221001,

    /// <summary>Create shadow decoy.</summary>
    [Label("SHADOWER_FAKE")]
    [Label("Shadower Fake", 1)]
    ShadowerFake = 4220002,

    /// <summary>Boost drops from target.</summary>
    [Label("SHADOWER_SHOWDOWN")]
    [Label("Shadower Showdown", 1)]
    ShadowerShowdown = 4221003,

    /// <summary>HP drain over time.</summary>
    [Label("SHADOWER_NINJA_AMBUSH")]
    [Label("Shadower Ninja Ambush", 1)]
    ShadowerNinjaAmbush = 4221004,

    /// <summary>Apply venom to attacks.</summary>
    [Label("SHADOWER_VENOM")]
    [Label("Shadower Venom", 1)]
    ShadowerVenom = 4220005,

    /// <summary>Create smoke screen.</summary>
    [Label("SHADOWER_SMOKE_SHELL")]
    [Label("Shadower Smoke Shell", 1)]
    ShadowerSmokeShell = 4221006,

    /// <summary>Boomerang dagger attack.</summary>
    [Label("SHADOWER_BOOMERANG_STEP")]
    [Label("Shadower Boomerang Step", 1)]
    ShadowerBoomerangStep = 4221007,

    /// <summary>Remove all debuffs.</summary>
    [Label("SHADOWER_HEROS_WILL")]
    [Label("Shadower Heros Will", 1)]
    ShadowerHerosWill = 4221008,

    /// <summary>Advanced body evasion.</summary>
    [Label("SHADOWER_GRID")]
    [Label("Shadower Grid", 1)]
    ShadowerGrid = 4220009,

    /// <summary>Boost dual blade proficiency.</summary>
    [Label("DUAL1_DUAL_MASTERY")]
    [Label("Dual1Dual Mastery", 1)]
    Dual1DualMastery = 4300000,

    /// <summary>Triple blade stab attack.</summary>
    [Label("DUAL1_TRIPLE_STAB")]
    [Label("Dual1Triple Stab", 1)]
    Dual1TripleStab = 4301001,

    /// <summary>Boost dual blade speed.</summary>
    [Label("DUAL1_DUAL_BOOSTER")]
    [Label("Dual1Dual Booster", 1)]
    Dual1DualBooster = 4301002,

    /// <summary>Self speed and jump buff.</summary>
    [Label("DUAL2_SELF_HASTE")]
    [Label("Dual2Self Haste", 1)]
    Dual2SelfHaste = 4311001,

    /// <summary>Fatal blade combo.</summary>
    [Label("DUAL2_FATAL_BLOW")]
    [Label("Dual2Fatal Blow", 1)]
    Dual2FatalBlow = 4311002,

    /// <summary>Slash storm AoE attack.</summary>
    [Label("DUAL2_SLASH_STORM")]
    [Label("Dual2Slash Storm", 1)]
    Dual2SlashStorm = 4311003,

    /// <summary>Resist status effects.</summary>
    [Label("DUAL2_SHADOW_RESISTANCE")]
    [Label("Dual2Shadow Resistance", 1)]
    Dual2ShadowResistance = 4310004,

    /// <summary>Quick dash forward.</summary>
    [Label("DUAL3_HUSTLE_DASH")]
    [Label("Dual3Hustle Dash", 1)]
    Dual3HustleDash = 4321000,

    /// <summary>Rush through enemies.</summary>
    [Label("DUAL3_HUSTLE_RUSH")]
    [Label("Dual3Hustle Rush", 1)]
    Dual3HustleRush = 4321001,

    /// <summary>Blind enemies with flash.</summary>
    [Label("DUAL3_FLASH_BANG")]
    [Label("Dual3Flash Bang", 1)]
    Dual3FlashBang = 4321002,

    /// <summary>Flash jump forward.</summary>
    [Label("DUAL3_FLASH_JUMP")]
    [Label("Dual3Flash Jump", 1)]
    Dual3FlashJump = 4321003,

    /// <summary>Bloody storm AoE attack.</summary>
    [Label("DUAL4_BLOODY_STORM")]
    [Label("Dual4Bloody Storm", 1)]
    Dual4BloodyStorm = 4331000,

    /// <summary>Enhanced dark sight skill.</summary>
    [Label("DUAL4_ADVANCED_DARK_SIGHT")]
    [Label("Dual4Advanced Dark Sight", 1)]
    Dual4AdvancedDarkSight = 4330001,

    /// <summary>Shadow clone attacks.</summary>
    [Label("DUAL4_MIRROR_IMAGING")]
    [Label("Dual4Mirror Imaging", 1)]
    Dual4MirrorImaging = 4331002,

    /// <summary>Owl of Minerva attack.</summary>
    [Label("DUAL4_OWL_DEATH")]
    [Label("Dual4Owl Death", 1)]
    Dual4OwlDeath = 4331003,

    /// <summary>Upward blade stab.</summary>
    [Label("DUAL4_UPPER_STAB")]
    [Label("Dual4Upper Stab", 1)]
    Dual4UpperStab = 4331004,

    /// <summary>Aerial dash attack.</summary>
    [Label("DUAL4_FLYING_ASSAULTER")]
    [Label("Dual4Flying Assaulter", 1)]
    Dual4FlyingAssaulter = 4331005,

    /// <summary>Boost all party stats.</summary>
    [Label("DUAL5_MAPLE_HERO")]
    [Label("Dual5Maple Hero", 1)]
    Dual5MapleHero = 4341000,

    /// <summary>Apply venom to attacks.</summary>
    [Label("DUAL5_VENOM")]
    Dual5Venom = 4340001,

    /// <summary>Ultimate slash attack.</summary>
    [Label("DUAL5_FINAL_CUT")]
    [Label("Dual5Final Cut", 1)]
    Dual5FinalCut = 4341002,

    /// <summary>Throw monster bomb.</summary>
    [Label("DUAL5_MONSTER_BOMB")]
    [Label("Dual5Monster Bomb", 1)]
    Dual5MonsterBomb = 4341003,

    /// <summary>Sudden shadow AoE raid.</summary>
    [Label("DUAL5_SUDDEN_RAID")]
    [Label("Dual5Sudden Raid", 1)]
    Dual5SuddenRaid = 4341004,

    /// <summary>Deadly dagger strike.</summary>
    [Label("DUAL5_ASSASSINATION")]
    Dual5Assassination = 4341005,

    /// <summary>Create shadow dummy.</summary>
    [Label("DUAL5_DUMMY_EFFECT")]
    [Label("Dual5Dummy Effect", 1)]
    Dual5DummyEffect = 4341006,

    /// <summary>Thorns counterattack effect.</summary>
    [Label("DUAL5_THORNS_EFFECT")]
    [Label("Dual5Thorns Effect", 1)]
    Dual5ThornsEffect = 4341007,

    /// <summary>Remove all debuffs.</summary>
    [Label("DUAL5_HEROS_WILL")]
    [Label("Dual5Heros Will", 1)]
    Dual5HerosWill = 4341008,

    /// <summary>Boost speed and accuracy.</summary>
    [Label("PIRATE_QUICKMOTION")]
    [Label("Pirate Quickmotion", 1)]
    PirateQuickmotion = 5000000,

    /// <summary>Straight punch attack.</summary>
    [Label("PIRATE_STRAIGHT")]
    [Label("Pirate Straight", 1)]
    PirateStraight = 5001001,

    /// <summary>Somersault kick attack.</summary>
    [Label("PIRATE_SOMERSAULT")]
    [Label("Pirate Somersault", 1)]
    PirateSomersault = 5001002,

    /// <summary>Fire two bullets.</summary>
    [Label("PIRATE_DOUBLE_FIRE")]
    [Label("Pirate Double Fire", 1)]
    PirateDoubleFire = 5001003,

    /// <summary>Quick dash forward.</summary>
    [Label("PIRATE_DASH")]
    [Label("Pirate Dash", 1)]
    PirateDash = 5001005,

    /// <summary>Boost knuckle proficiency.</summary>
    [Label("INFIGHTER_KNUCKLE_MASTERY")]
    [Label("Infighter Knuckle Mastery", 1)]
    InfighterKnuckleMastery = 5100001,

    /// <summary>Spinning back attack.</summary>
    [Label("INFIGHTER_BACKSPIN_BLOW")]
    [Label("Infighter Backspin Blow", 1)]
    InfighterBackspinBlow = 5101002,

    /// <summary>Double uppercut punch.</summary>
    [Label("INFIGHTER_DOUBLE_UPPER")]
    [Label("Infighter Double Upper", 1)]
    InfighterDoubleUpper = 5101003,

    /// <summary>Corkscrewing punch.</summary>
    [Label("INFIGHTER_SCREW_PUNCH")]
    [Label("Infighter Screw Punch", 1)]
    InfighterScrewPunch = 5101004,

    /// <summary>Boost MP recovery rate.</summary>
    [Label("INFIGHTER_MP_RECOVERY")]
    [Label("Infighter Mp Recovery", 1)]
    InfighterMpRecovery = 5101005,

    /// <summary>Boost knuckle attack speed.</summary>
    [Label("INFIGHTER_KNUCKLE_BOOSTER")]
    [Label("Infighter Knuckle Booster", 1)]
    InfighterKnuckleBooster = 5101006,

    /// <summary>Oak barrel roll stun.</summary>
    [Label("INFIGHTER_OAK_CASK")]
    [Label("Infighter Oak Cask", 1)]
    InfighterOakCask = 5101007,

    /// <summary>Increase max HP.</summary>
    [Label("INFIGHTER_MHP_INC")]
    [Label("Infighter Max HP Inc", 1)]
    InfighterMhpInc = 5100009,

    /// <summary>Boost punch critical rate.</summary>
    [Label("INFIGHTER_CRITICAL_PUNCH")]
    [Label("Infighter Critical Punch", 1)]
    InfighterCriticalPunch = 5100008,

    /// <summary>Master stunning enemies.</summary>
    [Label("BUCCANEER_STUN_MASTERY")]
    [Label("Buccaneer Stun Mastery", 1)]
    BuccaneerStunMastery = 5110000,

    /// <summary>Charge energy for power.</summary>
    [Label("BUCCANEER_ENERGY_CHARGE")]
    [Label("Buccaneer Energy Charge", 1)]
    BuccaneerEnergyCharge = 5110001,

    /// <summary>Energy burst AoE attack.</summary>
    [Label("BUCCANEER_ENERGY_BURSTER")]
    [Label("Buccaneer Energy Burster", 1)]
    BuccaneerEnergyBurster = 5111002,

    /// <summary>Drain energy from enemies.</summary>
    [Label("BUCCANEER_ENERGY_DRAIN")]
    [Label("Buccaneer Energy Drain", 1)]
    BuccaneerEnergyDrain = 5111004,

    /// <summary>Transform into super form.</summary>
    [Label("BUCCANEER_TRANSFORM")]
    [Label("Buccaneer Transform", 1)]
    BuccaneerTransform = 5111005,

    /// <summary>Shockwave AoE attack.</summary>
    [Label("BUCCANEER_SHOCKWAVE")]
    [Label("Buccaneer Shockwave", 1)]
    BuccaneerShockwave = 5111006,

    /// <summary>Roll dice for random buff.</summary>
    [Label("BUCCANEER_DICE")]
    [Label("Buccaneer Dice", 1)]
    BuccaneerDice = 5111007,

    /// <summary>Boost brawling proficiency.</summary>
    [Label("BUCCANEER_INFIGHTING_MASTERY")]
    [Label("Buccaneer Infighting Mastery", 1)]
    BuccaneerInfightingMastery = 5110008,

    /// <summary>Boost all party stats.</summary>
    [Label("VIPER_MAPLE_HERO")]
    [Label("Viper Maple Hero", 1)]
    ViperMapleHero = 5121000,

    /// <summary>Dragon strike AoE attack.</summary>
    [Label("VIPER_DRAGON_STRIKE")]
    [Label("Viper Dragon Strike", 1)]
    ViperDragonStrike = 5121001,

    /// <summary>Throw energy orb.</summary>
    [Label("VIPER_ENERGY_ORB")]
    [Label("Viper Energy Orb", 1)]
    ViperEnergyOrb = 5121002,

    /// <summary>Enhanced transformation.</summary>
    [Label("VIPER_SUPER_TRANSFORM")]
    [Label("Viper Super Transform", 1)]
    ViperSuperTransform = 5121003,

    /// <summary>Demolition punch attack.</summary>
    [Label("VIPER_DEMOLITION")]
    [Label("Viper Demolition", 1)]
    ViperDemolition = 5121004,

    /// <summary>Snatch and throw enemy.</summary>
    [Label("VIPER_SNATCH")]
    [Label("Viper Snatch", 1)]
    ViperSnatch = 5121005,

    /// <summary>Barrage of fists attack.</summary>
    [Label("VIPER_FIST")]
    [Label("Viper Fist", 1)]
    ViperFist = 5121007,

    /// <summary>Remove all debuffs.</summary>
    [Label("VIPER_HEROS_WILL")]
    [Label("Viper Heros Will", 1)]
    ViperHerosWill = 5121008,

    /// <summary>Boost speed with wind.</summary>
    [Label("VIPER_WIND_BOOSTER")]
    [Label("Viper Wind Booster", 1)]
    ViperWindBooster = 5121009,

    /// <summary>Reset all cooldowns.</summary>
    [Label("VIPER_TIME_LEAP")]
    [Label("Viper Time Leap", 1)]
    ViperTimeLeap = 5121010,

    /// <summary>Counter on being hit.</summary>
    [Label("VIPER_COUNTER_ATTACK")]
    [Label("Viper Counter Attack", 1)]
    ViperCounterAttack = 5120011,

    /// <summary>Boost gun proficiency.</summary>
    [Label("GUNSLINGER_GUN_MASTERY")]
    [Label("Gunslinger Gun Mastery", 1)]
    GunslingerGunMastery = 5200000,

    /// <summary>Hidden bullet attack.</summary>
    [Label("GUNSLINGER_INVISIBLE_SHOT")]
    [Label("Gunslinger Invisible Shot", 1)]
    GunslingerInvisibleShot = 5201001,

    /// <summary>Throw grenade bomb.</summary>
    [Label("GUNSLINGER_THROWING_BOMB")]
    [Label("Gunslinger Throwing Bomb", 1)]
    GunslingerThrowingBomb = 5201002,

    /// <summary>Boost gun attack speed.</summary>
    [Label("GUNSLINGER_GUN_BOOSTER")]
    [Label("Gunslinger Gun Booster", 1)]
    GunslingerGunBooster = 5201003,

    /// <summary>Feint shot retreat.</summary>
    [Label("GUNSLINGER_FAKE_SHOT")]
    [Label("Gunslinger Fake Shot", 1)]
    GunslingerFakeShot = 5201004,

    /// <summary>Short flight ability.</summary>
    [Label("GUNSLINGER_WINGS")]
    [Label("Gunslinger Wings", 1)]
    GunslingerWings = 5201005,

    /// <summary>Retreating gun shot.</summary>
    [Label("GUNSLINGER_BACKSTEP_SHOT")]
    [Label("Gunslinger Backstep Shot", 1)]
    GunslingerBackstepShot = 5201006,

    /// <summary>Boost critical hit chance.</summary>
    [Label("GUNSLINGER_CRITICAL_SHOT")]
    [Label("Gunslinger Critical Shot", 1)]
    GunslingerCriticalShot = 5200007,

    /// <summary>Fire three bullets.</summary>
    [Label("VALKYRIE_TRIPLE_FIRE")]
    [Label("Valkyrie Triple Fire", 1)]
    ValkyrieTripleFire = 5210000,

    /// <summary>Summon Octopus.</summary>
    [Label("VALKYRIE_OCTOPUS")]
    [Label("Valkyrie Octopus", 1)]
    ValkyrieOctopus = 5211001,

    /// <summary>Summon Gaviota bird.</summary>
    [Label("VALKYRIE_GABIOTA")]
    [Label("Valkyrie Gabiota", 1)]
    ValkyrieGabiota = 5211002,

    /// <summary>Flamethrower attack.</summary>
    [Label("VALKYRIE_FIRE_BURNER")]
    [Label("Valkyrie Fire Burner", 1)]
    ValkyrieFireBurner = 5211004,

    /// <summary>Ice splash slow attack.</summary>
    [Label("VALKYRIE_COOLING_EFFECT")]
    [Label("Valkyrie Cooling Effect", 1)]
    ValkyrieCoolingEffect = 5211005,

    /// <summary>Homing missile attack.</summary>
    [Label("VALKYRIE_HOMING")]
    [Label("Valkyrie Homing", 1)]
    ValkyrieHoming = 5211006,

    /// <summary>Roll dice for random buff.</summary>
    [Label("VALKYRIE_DICE")]
    [Label("Valkyrie Dice", 1)]
    ValkyrieDice = 5211007,

    /// <summary>Boost all party stats.</summary>
    [Label("CAPTAIN_MAPLE_HERO")]
    [Label("Captain Maple Hero", 1)]
    CaptainMapleHero = 5221000,

    /// <summary>Boost elemental mastery.</summary>
    [Label("CAPTAIN_PROPERTY_UPGRADE")]
    [Label("Captain Property Upgrade", 1)]
    CaptainPropertyUpgrade = 5220001,

    /// <summary>Summon support Octopus.</summary>
    [Label("CAPTAIN_SUPPORT_OCTOPUS")]
    [Label("Captain Support Octopus", 1)]
    CaptainSupportOctopus = 5220002,

    /// <summary>Aerial battleship strike.</summary>
    [Label("CAPTAIN_AIR_STRIKE")]
    [Label("Captain Air Strike", 1)]
    CaptainAirStrike = 5221003,

    /// <summary>Rapid-fire bullet barrage.</summary>
    [Label("CAPTAIN_RAPID_FIRE")]
    [Label("Captain Rapid Fire", 1)]
    CaptainRapidFire = 5221004,

    /// <summary>Board the Battleship.</summary>
    [Label("CAPTAIN_BATTLESHIP")]
    [Label("Captain Battleship", 1)]
    CaptainBattleship = 5221006,

    /// <summary>Battleship durability buff.</summary>
    [Label("CAPTAIN_BATTLESHIP_D")]
    [Label("Captain Battleship D", 1)]
    CaptainBattleshipD = 5221999,

    /// <summary>Battleship cannon attack.</summary>
    [Label("CAPTAIN_BATTLESHIP_CANNON")]
    [Label("Captain Battleship Cannon", 1)]
    CaptainBattleshipCannon = 5221007,

    /// <summary>Battleship torpedo attack.</summary>
    [Label("CAPTAIN_BATTLESHIP_TORPEDO")]
    [Label("Captain Battleship Torpedo", 1)]
    CaptainBattleshipTorpedo = 5221008,

    /// <summary>Mind control an enemy.</summary>
    [Label("CAPTAIN_MIND_CONTROL")]
    [Label("Captain Mind Control", 1)]
    CaptainMindControl = 5221009,

    /// <summary>Remove all debuffs.</summary>
    [Label("CAPTAIN_HEROS_WILL")]
    [Label("Captain Heros Will", 1)]
    CaptainHerosWill = 5221010,

    /// <summary>Enhanced homing missiles.</summary>
    [Label("CAPTAIN_ADVANCED_HOMING")]
    [Label("Captain Advanced Homing", 1)]
    CaptainAdvancedHoming = 5220011,

    /// <summary>Counter on being hit.</summary>
    [Label("CAPTAIN_COUNTER_ATTACK")]
    [Label("Captain Counter Attack", 1)]
    CaptainCounterAttack = 5220012,

    /// <summary>Anti-macro detection skill.</summary>
    [Label("MANAGER_ANTIMACRO")]
    [Label("Manager Antimacro", 1)]
    ManagerAntimacro = 8001000,

    /// <summary>Teleport short distance.</summary>
    [Label("MANAGER_TELEPORT")]
    [Label("Manager Teleport", 1)]
    ManagerTeleport = 8001001,

    /// <summary>Increase speed and jump.</summary>
    [Label("ADMIN_HASTE")]
    [Label("Admin Haste", 1)]
    AdminHaste = 9001000,

    /// <summary>Roar stunning all enemies.</summary>
    [Label("ADMIN_DRAGON_ROAR")]
    [Label("Admin Dragon Roar", 1)]
    AdminDragonRoar = 9001001,

    /// <summary>Teleport short distance.</summary>
    [Label("ADMIN_TELEPORT")]
    [Label("Admin Teleport", 1)]
    AdminTeleport = 9001002,

    /// <summary>Remove party debuffs.</summary>
    [Label("ADMIN_DISPEL")]
    [Label("Admin Dispel", 1)]
    AdminDispel = 9101000,

    /// <summary>Enhanced speed buff.</summary>
    [Label("ADMIN_SUPER_HASTE")]
    [Label("Admin Super Haste", 1)]
    AdminSuperHaste = 9101001,

    /// <summary>Boost party EXP gain.</summary>
    [Label("ADMIN_HOLY_SYMBOL")]
    [Label("Admin Holy Symbol", 1)]
    AdminHolySymbol = 9101002,

    /// <summary>Boost party stats.</summary>
    [Label("ADMIN_BLESS")]
    [Label("Admin Bless", 1)]
    AdminBless = 9101003,

    /// <summary>GM hide from view.</summary>
    [Label("ADMIN_HIDE")]
    [Label("Admin Hide", 1)]
    AdminHide = 9101004,

    /// <summary>Revive fallen party members.</summary>
    [Label("ADMIN_RESURRECTION")]
    [Label("Admin Resurrection", 1)]
    AdminResurrection = 9101005,

    /// <summary>Increase max HP and MP.</summary>
    [Label("ADMIN_HYPER_BODY")]
    [Label("Admin Hyper Body", 1)]
    AdminHyperBody = 9101008,

    /// <summary>Anti-macro detection skill.</summary>
    [Label("ADMIN_ANTIMACRO")]
    [Label("Admin Antimacro", 1)]
    AdminAntimacro = 9001009,

    /// <summary>Throw snail shells.</summary>
    [Label("NOBLESSE_THROW_SNAIL")]
    [Label("Noblesse Throw Snail", 1)]
    NoblesseThrowSnail = 10001000,

    /// <summary>Recover HP over time.</summary>
    [Label("NOBLESSE_REGENERATION")]
    [Label("Noblesse Regeneration", 1)]
    NoblesseRegeneration = 10001001,

    /// <summary>Recover while moving.</summary>
    [Label("NOBLESSE_MOVING_WITH_ACTIVITY")]
    [Label("Noblesse Moving With Activity", 1)]
    NoblesseMovingWithActivity = 10001002,

    /// <summary>Crafting proficiency boost.</summary>
    [Label("NOBLESSE_SOUL_OF_CRAFTMAN")]
    [Label("Noblesse Soul Of Craftsman", 1)]
    NoblesseSoulOfCraftsman = 10001003,

    /// <summary>Mount a tamed monster.</summary>
    [Label("NOBLESSE_MONSTER_RIDING")]
    [Label("Noblesse Monster Riding", 1)]
    NoblesseMonsterRiding = 10001004,

    /// <summary>Max-level echo buff.</summary>
    [Label("NOBLESSE_MAXLEVEL_ECHOBUFF")]
    [Label("Noblesse Max-Level Echo Buff", 1)]
    NoblesseMaxlevelEchobuff = 10001005,

    /// <summary>Display damage dealt.</summary>
    [Label("NOBLESSE_DAMAGEMETER")]
    [Label("Noblesse Damage Meter", 1)]
    NoblesseDamagemeter = 10001006,

    /// <summary>Craft items via Maker.</summary>
    [Label("NOBLESSE_MAKER")]
    [Label("Noblesse Maker", 1)]
    NoblesseMaker = 10001007,

    /// <summary>Bamboo rain attack.</summary>
    [Label("NOBLESSE_BAMBOO")]
    [Label("Noblesse Bamboo", 1)]
    NoblesseBamboo = 10001009,

    /// <summary>Temporary invincibility.</summary>
    [Label("NOBLESSE_INVINCIBLE")]
    [Label("Noblesse Invincible", 1)]
    NoblesseInvincible = 10001010,

    /// <summary>Enter berserk state.</summary>
    [Label("NOBLESSE_BERSERK")]
    [Label("Noblesse Berserk", 1)]
    NoblesseBerserk = 10001011,

    /// <summary>Nymph's blessing buff.</summary>
    [Label("NOBLESSE_BLESS_OF_NYMPH")]
    [Label("Noblesse Bless Of Nymph", 1)]
    NoblesseBlessOfNymph = 10000012,

    /// <summary>Tutorial guidance skill.</summary>
    [Label("NOBLESSE_TUTOR")]
    [Label("Noblesse Tutor", 1)]
    NoblesseTutor = 10001013,

    /// <summary>Ride event mount (disabled).</summary>
    [Label("DISABLE_NOBLESSE_EVENT_RIDING")]
    [Label("Disable Noblesse Event Riding", 1)]
    DisableNoblesseEventRiding = 10001014,

    /// <summary>Dash on event mount (disabled).</summary>
    [Label("DISABLE_NOBLESSE_EVENT_RIDING_DASH")]
    [Label("Disable Noblesse Event Riding Dash", 1)]
    DisableNoblesseEventRidingDash = 10001015,

    /// <summary>Interact on event mount (disabled).</summary>
    [Label("DISABLE_NOBLESSE_EVENT_RIDING_REACTOR")]
    [Label("Disable Noblesse Event Riding Reactor", 1)]
    DisableNoblesseEventRidingReactor = 10001016,

    /// <summary>Equip multiple pets.</summary>
    [Label("NOBLESSE_MULTI_PET")]
    [Label("Noblesse Multi Pet", 1)]
    NoblesseMultiPet = 10000018,

    /// <summary>Ride Yeti mount (disabled).</summary>
    [Label("DISABLE_NOBLESSE_YETI_EVENT_RIDING")]
    [Label("Disable Noblesse Yeti Event Riding", 1)]
    DisableNoblesseYetiEventRiding = 10001019,

    /// <summary>Party bonus EXP skill.</summary>
    [Label("NOBLESSE_MASSACRE")]
    [Label("Noblesse Massacre", 1)]
    NoblesseMassacre = 10001020,

    /// <summary>Ride Yeti mount variant (disabled).</summary>
    [Label("DISABLE_NOBLESSE_YETI_EVENT_RIDING2")]
    [Label("Disable Noblesse Yeti Event Riding2", 1)]
    DisableNoblesseYetiEventRiding2 = 10001022,

    /// <summary>Ride broomstick mount (disabled).</summary>
    [Label("DISABLE_NOBLESSE_BROOM_EVENT_RIDING")]
    [Label("Disable Noblesse Broom Event Riding", 1)]
    DisableNoblesseBroomEventRiding = 10001023,

    /// <summary>Ride wooden horse mount.</summary>
    [Label("NOBLESSE_WOODENHORSE_EVENT_RIDING")]
    [Label("Noblesse Wooden Horse Event Riding", 1)]
    NoblesseWoodenhorseEventRiding = 10001025,

    /// <summary>Enable flight ability.</summary>
    [Label("NOBLESSE_FLYING_SKILL")]
    [Label("Noblesse Flying Skill", 1)]
    NoblesseFlyingSkill = 10001026,

    /// <summary>Ride crocodile mount.</summary>
    [Label("NOBLESSE_KROKO_EVENT_RIDING")]
    [Label("Noblesse Kroko Event Riding", 1)]
    NoblesseKrokoEventRiding = 10001027,

    /// <summary>Ride streaker mount.</summary>
    [Label("NOBLESSE_NAKED_EVENT_RIDING")]
    [Label("Noblesse Naked Event Riding", 1)]
    NoblesseNakedEventRiding = 10001028,

    /// <summary>Ride pink scooter mount.</summary>
    [Label("NOBLESSE_PINK_SCOOTER_EVENT_RIDING")]
    [Label("Noblesse Pink Scooter Event Riding", 1)]
    NoblessePinkScooterEventRiding = 10001029,

    /// <summary>Ride nimbus cloud mount.</summary>
    [Label("NOBLESSE_FLYING_CLOUD_EVENT_RIDING")]
    [Label("Noblesse Flying Cloud Event Riding", 1)]
    NoblesseFlyingCloudEventRiding = 10001030,

    /// <summary>Ride Balrog mount.</summary>
    [Label("NOBLESSE_BALROG_EVENT_RIDING")]
    [Label("Noblesse Balrog Event Riding", 1)]
    NoblesseBalrogEventRiding = 10001031,

    /// <summary>Ride go-kart mount.</summary>
    [Label("NOBLESSE_KART_EVENT_RIDING")]
    [Label("Noblesse Kart Event Riding", 1)]
    NoblesseKartEventRiding = 10001033,

    /// <summary>Ride tiger mount.</summary>
    [Label("NOBLESSE_ZD_TIGER_EVENT_RIDING")]
    [Label("Noblesse Zd Tiger Event Riding", 1)]
    NoblesseZdTigerEventRiding = 10001034,

    /// <summary>Ride Mist Balrog mount.</summary>
    [Label("NOBLESSE_MISTBALROG_EVENT_RIDING")]
    [Label("Noblesse Mistbalrog Event Riding", 1)]
    NoblesseMistbalrogEventRiding = 10001035,

    /// <summary>Ride lion mount.</summary>
    [Label("NOBLESSE_LIONS_EVENT_RIDING")]
    [Label("Noblesse Lions Event Riding", 1)]
    NoblesseLionsEventRiding = 10001036,

    /// <summary>Ride unicorn mount.</summary>
    [Label("NOBLESSE_UNICORN_EVENT_RIDING")]
    [Label("Noblesse Unicorn Event Riding", 1)]
    NoblesseUnicornEventRiding = 10001037,

    /// <summary>Ride low-rider mount.</summary>
    [Label("NOBLESSE_LOWRIDER_EVENT_RIDING")]
    [Label("Noblesse Lowrider Event Riding", 1)]
    NoblesseLowriderEventRiding = 10001038,

    /// <summary>Ride red truck mount.</summary>
    [Label("NOBLESSE_REDTRUCK_EVENT_RIDING")]
    [Label("Noblesse Redtruck Event Riding", 1)]
    NoblesseRedtruckEventRiding = 10001039,

    /// <summary>Ride gargoyle mount.</summary>
    [Label("NOBLESSE_GARGOYLES_EVENT_RIDING")]
    [Label("Noblesse Gargoyles Event Riding", 1)]
    NoblesseGargoylesEventRiding = 10001040,

    /// <summary>Ride spaceship mount.</summary>
    [Label("NOBLESSE_SPACE_EVENT_RIDING")]
    [Label("Noblesse Space Event Riding", 1)]
    NoblesseSpaceEventRiding = 10001046,

    /// <summary>Dash on spaceship mount.</summary>
    [Label("NOBLESSE_SPACE_EVENT_RIDING_DASH")]
    [Label("Noblesse Space Event Riding Dash", 1)]
    NoblesseSpaceEventRidingDash = 10001047,

    /// <summary>Interact on spaceship mount.</summary>
    [Label("NOBLESSE_SPACE_EVENT_RIDING_REACTOR")]
    [Label("Noblesse Space Event Riding Reactor", 1)]
    NoblesseSpaceEventRidingReactor = 10001048,

    /// <summary>Ride chicken mount.</summary>
    [Label("NOBLESSE_CHICKEN_EVENT_RIDING")]
    [Label("Noblesse Chicken Event Riding", 1)]
    NoblesseChickenEventRiding = 10001054,

    /// <summary>Ride holly bird mount.</summary>
    [Label("NOBLESSE_HOLLY_BIRD_EVENT_RIDING")]
    [Label("Noblesse Holly Bird Event Riding", 1)]
    NoblesseHollyBirdEventRiding = 10001042,

    /// <summary>Ride Orange Mushroom mount.</summary>
    [Label("NOBLESSE_ORANGE_MUSHROOM_EVENT_RIDING")]
    [Label("Noblesse Orange Mushroom Event Riding", 1)]
    NoblesseOrangeMushroomEventRiding = 10001044,

    /// <summary>Ride Nightmare mount.</summary>
    [Label("NOBLESSE_NIGHTMARE_EVENT_RIDING")]
    [Label("Noblesse Nightmare Event Riding", 1)]
    NoblesseNightmareEventRiding = 10001049,

    /// <summary>Ride Yeti mount.</summary>
    [Label("NOBLESSE_YETI_EVENT_RIDING")]
    [Label("Noblesse Yeti Event Riding", 1)]
    NoblesseYetiEventRiding = 10001050,

    /// <summary>Ride ostrich mount.</summary>
    [Label("NOBLESSE_OSTRICH_EVENT_RIDING")]
    [Label("Noblesse Ostrich Event Riding", 1)]
    NoblesseOstrichEventRiding = 10001051,

    /// <summary>Ride bear balloon mount.</summary>
    [Label("NOBLESSE_BEAR_BALOON_EVENT_RIDING")]
    [Label("Noblesse Bear Baloon Event Riding", 1)]
    NoblesseBearBaloonEventRiding = 10001052,

    /// <summary>Ride transformer mount.</summary>
    [Label("NOBLESSE_TRANS_ROBOT_EVENT_RIDING")]
    [Label("Noblesse Trans Robot Event Riding", 1)]
    NoblesseTransRobotEventRiding = 10001053,

    /// <summary>Ride motorbike mount.</summary>
    [Label("NOBLESSE_MOTORBIKE_EVENT_RIDING")]
    [Label("Noblesse Motorbike Event Riding", 1)]
    NoblesseMotorbikeEventRiding = 10001063,

    /// <summary>Ride power suit mount.</summary>
    [Label("NOBLESSE_POWERED_SUIT_EVENT_RIDING")]
    [Label("Noblesse Powered Suit Event Riding", 1)]
    NoblessePoweredSuitEventRiding = 10001064,

    /// <summary>Increase speed and jump.</summary>
    [Label("NOBLESSE_HASTE")]
    [Label("Noblesse Haste", 1)]
    NoblesseHaste = 10008000,

    /// <summary>Open town portal.</summary>
    [Label("NOBLESSE_MYSTIC_DOOR")]
    [Label("Noblesse Mystic Door", 1)]
    NoblesseMysticDoor = 10008001,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("NOBLESSE_SHARP_EYES")]
    [Label("Noblesse Sharp Eyes", 1)]
    NoblesseSharpEyes = 10008002,

    /// <summary>Increase max HP and MP.</summary>
    [Label("NOBLESSE_HYPER_BODY")]
    [Label("Noblesse Hyper Body", 1)]
    NoblesseHyperBody = 10008003,

    /// <summary>Boost speed and accuracy.</summary>
    [Label("STRIKER_QUICKMOTION")]
    [Label("Striker Quickmotion", 1)]
    StrikerQuickmotion = 15000000,

    /// <summary>Straight punch attack.</summary>
    [Label("STRIKER_STRAIGHT")]
    [Label("Striker Straight", 1)]
    StrikerStraight = 15001001,

    /// <summary>Somersault kick attack.</summary>
    [Label("STRIKER_SOMERSAULT")]
    [Label("Striker Somersault", 1)]
    StrikerSomersault = 15001002,

    /// <summary>Quick dash forward.</summary>
    [Label("STRIKER_DASH")]
    [Label("Striker Dash", 1)]
    StrikerDash = 15001003,

    /// <summary>Activate lightning power.</summary>
    [Label("STRIKER_LIGHTNING")]
    [Label("Striker Lightning", 1)]
    StrikerLightning = 15001004,

    /// <summary>Boost knuckle proficiency.</summary>
    [Label("STRIKER_KNUCKLE_MASTERY")]
    [Label("Striker Knuckle Mastery", 1)]
    StrikerKnuckleMastery = 15100001,

    /// <summary>Boost knuckle attack speed.</summary>
    [Label("STRIKER_KNUCKLE_BOOSTER")]
    [Label("Striker Knuckle Booster", 1)]
    StrikerKnuckleBooster = 15101002,

    /// <summary>Corkscrewing punch.</summary>
    [Label("STRIKER_SCREW_PUNCH")]
    [Label("Striker Screw Punch", 1)]
    StrikerScrewPunch = 15101003,

    /// <summary>Charge energy for power.</summary>
    [Label("STRIKER_ENERGY_CHARGE")]
    [Label("Striker Energy Charge", 1)]
    StrikerEnergyCharge = 15100004,

    /// <summary>Energy burst AoE attack.</summary>
    [Label("STRIKER_ENERGY_BURSTER")]
    [Label("Striker Energy Burster", 1)]
    StrikerEnergyBurster = 15101005,

    /// <summary>Imbue weapon with lightning.</summary>
    [Label("STRIKER_LIGHTNING_CHARGE")]
    [Label("Striker Lightning Charge", 1)]
    StrikerLightningCharge = 15101006,

    /// <summary>Increase max HP.</summary>
    [Label("STRIKER_MHP_INC")]
    [Label("Striker Max HP Inc", 1)]
    StrikerMhpInc = 15100007,

    /// <summary>Boost punch critical rate.</summary>
    [Label("STRIKER_CRITICAL_PUNCH")]
    [Label("Striker Critical Punch", 1)]
    StrikerCriticalPunch = 15110000,

    /// <summary>Drain energy from enemies.</summary>
    [Label("STRIKER_ENERGY_DRAIN")]
    [Label("Striker Energy Drain", 1)]
    StrikerEnergyDrain = 15111001,

    /// <summary>Transform into super form.</summary>
    [Label("STRIKER_TRANSFORM")]
    [Label("Striker Transform", 1)]
    StrikerTransform = 15111002,

    /// <summary>Shockwave AoE attack.</summary>
    [Label("STRIKER_SHOCKWAVE")]
    [Label("Striker Shockwave", 1)]
    StrikerShockwave = 15111003,

    /// <summary>Barrage of fists attack.</summary>
    [Label("STRIKER_FIST")]
    [Label("Striker Fist", 1)]
    StrikerFist = 15111004,

    /// <summary>Boost speed with wind.</summary>
    [Label("STRIKER_WIND_BOOSTER")]
    [Label("Striker Wind Booster", 1)]
    StrikerWindBooster = 15111005,

    /// <summary>Spark lightning attack.</summary>
    [Label("STRIKER_SPARK")]
    [Label("Striker Spark", 1)]
    StrikerSpark = 15111006,

    /// <summary>Summon shark wave.</summary>
    [Label("STRIKER_SHARK_WAVE")]
    [Label("Striker Shark Wave", 1)]
    StrikerSharkWave = 15111007,

    /// <summary>Boost weapon defense.</summary>
    [Label("SOULMASTER_IRON_BODY")]
    [Label("Soulmaster Iron Body", 1)]
    SoulmasterIronBody = 11001001,

    /// <summary>Strong melee strike.</summary>
    [Label("SOULMASTER_POWER_STRIKE")]
    [Label("Soulmaster Power Strike", 1)]
    SoulmasterPowerStrike = 11001002,

    /// <summary>Slash multiple enemies.</summary>
    [Label("SOULMASTER_SLASH_BLAST")]
    [Label("Soulmaster Slash Blast", 1)]
    SoulmasterSlashBlast = 11001003,

    /// <summary>Activate soul power.</summary>
    [Label("SOULMASTER_SOUL")]
    [Label("Soulmaster Soul", 1)]
    SoulmasterSoul = 11001004,

    /// <summary>Increase max HP.</summary>
    [Label("SOULMASTER_MHP_INC")]
    [Label("Soulmaster Max HP Inc", 1)]
    SoulmasterMhpInc = 11000005,

    /// <summary>Boost sword proficiency.</summary>
    [Label("SOULMASTER_SWORD_MASTERY")]
    [Label("Soulmaster Sword Mastery", 1)]
    SoulmasterSwordMastery = 11100000,

    /// <summary>Boost sword attack speed.</summary>
    [Label("SOULMASTER_SWORD_BOOSTER")]
    [Label("Soulmaster Sword Booster", 1)]
    SoulmasterSwordBooster = 11101001,

    /// <summary>Extra sword hit after attack.</summary>
    [Label("SOULMASTER_FINAL_ATTACK_SWORD")]
    [Label("Soulmaster Final Attack Sword", 1)]
    SoulmasterFinalAttackSword = 11101002,

    /// <summary>Boost party attack power.</summary>
    [Label("SOULMASTER_FURY")]
    [Label("Soulmaster Fury", 1)]
    SoulmasterFury = 11101003,

    /// <summary>Soul-powered blade attack.</summary>
    [Label("SOULMASTER_SOUL_BLADE")]
    [Label("Soulmaster Soul Blade", 1)]
    SoulmasterSoulBlade = 11101004,

    /// <summary>Soul charge through enemies.</summary>
    [Label("SOULMASTER_SOUL_RUSH")]
    [Label("Soulmaster Soul Rush", 1)]
    SoulmasterSoulRush = 11101005,

    /// <summary>Improve MP recovery.</summary>
    [Label("SOULMASTER_UPGRADE_MP_RECOVERY")]
    [Label("Soulmaster Upgrade Mp Recovery", 1)]
    SoulmasterUpgradeMpRecovery = 11110000,

    /// <summary>Build combo orb attacks.</summary>
    [Label("SOULMASTER_COMBO_ATTACK")]
    [Label("Soulmaster Combo Attack", 1)]
    SoulmasterComboAttack = 11111001,

    /// <summary>Lower enemy accuracy.</summary>
    [Label("SOULMASTER_PANIC_SWORD")]
    [Label("Soulmaster Panic Sword", 1)]
    SoulmasterPanicSword = 11111002,

    /// <summary>Stun enemies with sword.</summary>
    [Label("SOULMASTER_COMA_SWORD")]
    [Label("Soulmaster Coma Sword", 1)]
    SoulmasterComaSword = 11111003,

    /// <summary>Wide-range sword slash.</summary>
    [Label("SOULMASTER_BRANDISH")]
    [Label("Soulmaster Brandish", 1)]
    SoulmasterBrandish = 11111004,

    /// <summary>Enhanced combo system.</summary>
    [Label("SOULMASTER_ADVANCED_COMBO")]
    [Label("Soulmaster Advanced Combo", 1)]
    SoulmasterAdvancedCombo = 11110005,

    /// <summary>Soul projectile attack.</summary>
    [Label("SOULMASTER_SOUL_DRIVER")]
    [Label("Soulmaster Soul Driver", 1)]
    SoulmasterSoulDriver = 11111006,

    /// <summary>Charge soul power.</summary>
    [Label("SOULMASTER_SOUL_CHARGE")]
    [Label("Soulmaster Soul Charge", 1)]
    SoulmasterSoulCharge = 11111007,

    /// <summary>Absorb damage with MP.</summary>
    [Label("FLAMEWIZARD_MAGIC_GUARD")]
    [Label("Flamewizard Magic Guard", 1)]
    FlamewizardMagicGuard = 12001001,

    /// <summary>Boost magic defense.</summary>
    [Label("FLAMEWIZARD_MAGIC_ARMOR")]
    [Label("Flamewizard Magic Armor", 1)]
    FlamewizardMagicArmor = 12001002,

    /// <summary>Magic claw attack.</summary>
    [Label("FLAMEWIZARD_MAGIC_CLAW")]
    [Label("Flamewizard Magic Claw", 1)]
    FlamewizardMagicClaw = 12001003,

    /// <summary>Activate flame power.</summary>
    [Label("FLAMEWIZARD_FLAME")]
    [Label("Flamewizard Flame", 1)]
    FlamewizardFlame = 12001004,

    /// <summary>Increase max MP.</summary>
    [Label("FLAMEWIZARD_MMP_INC")]
    [Label("Flamewizard Max MP Inc", 1)]
    FlamewizardMmpInc = 12000005,

    /// <summary>Boost party magic attack.</summary>
    [Label("FLAMEWIZARD_MEDITATION")]
    [Label("Flamewizard Meditation", 1)]
    FlamewizardMeditation = 12101000,

    /// <summary>Slow enemy movement.</summary>
    [Label("FLAMEWIZARD_SLOW")]
    [Label("Flamewizard Slow", 1)]
    FlamewizardSlow = 12101001,

    /// <summary>Fire arrow projectile.</summary>
    [Label("FLAMEWIZARD_FIRE_ARROW")]
    [Label("Flamewizard Fire Arrow", 1)]
    FlamewizardFireArrow = 12101002,

    /// <summary>Teleport short distance.</summary>
    [Label("FLAMEWIZARD_TELEPORT")]
    [Label("Flamewizard Teleport", 1)]
    FlamewizardTeleport = 12101003,

    /// <summary>Boost casting speed.</summary>
    [Label("FLAMEWIZARD_MAGIC_BOOSTER")]
    [Label("Flamewizard Magic Booster", 1)]
    FlamewizardMagicBooster = 12101004,

    /// <summary>Reset elemental penalty.</summary>
    [Label("FLAMEWIZARD_ELEMENTAL_RESET")]
    [Label("Flamewizard Elemental Reset", 1)]
    FlamewizardElementalReset = 12101005,

    /// <summary>Summon fire pillar.</summary>
    [Label("FLAMEWIZARD_FIRE_PILLAR")]
    [Label("Flamewizard Fire Pillar", 1)]
    FlamewizardFirePillar = 12101006,

    /// <summary>Boost spell proficiency.</summary>
    [Label("FLAMEWIZARD_SPELL_MASTERY")]
    [Label("Flamewizard Spell Mastery", 1)]
    FlamewizardSpellMastery = 12100007,

    /// <summary>Resist elemental damage.</summary>
    [Label("FLAMEWIZARD_ELEMENT_RESISTANCE")]
    [Label("Flamewizard Element Resistance", 1)]
    FlamewizardElementResistance = 12110000,

    /// <summary>Amplify elemental damage.</summary>
    [Label("FLAMEWIZARD_ELEMENT_AMPLIFICATION")]
    [Label("Flamewizard Element Amplification", 1)]
    FlamewizardElementAmplification = 12110001,

    /// <summary>Seal enemy skills.</summary>
    [Label("FLAMEWIZARD_SEAL")]
    [Label("Flamewizard Seal", 1)]
    FlamewizardSeal = 12111002,

    /// <summary>Call down meteor shower.</summary>
    [Label("FLAMEWIZARD_METEOR")]
    [Label("Flamewizard Meteor", 1)]
    FlamewizardMeteor = 12111003,

    /// <summary>Summon Ifrit familiar.</summary>
    [Label("FLAMEWIZARD_IFRIT")]
    [Label("Flamewizard Ifrit", 1)]
    FlamewizardIfrit = 12111004,

    /// <summary>Spinning flame gear.</summary>
    [Label("FLAMEWIZARD_FLAME_GEAR")]
    [Label("Flamewizard Flame Gear", 1)]
    FlamewizardFlameGear = 12111005,

    /// <summary>Powerful fire strike.</summary>
    [Label("FLAMEWIZARD_FIRE_STRIKE")]
    [Label("Flamewizard Fire Strike", 1)]
    FlamewizardFireStrike = 12111006,

    /// <summary>Boost critical hit chance.</summary>
    [Label("WINDBREAKER_CRITICAL_SHOT")]
    [Label("Windbreaker Critical Shot", 1)]
    WindbreakerCriticalShot = 13000000,

    /// <summary>Increase accuracy range.</summary>
    [Label("WINDBREAKER_AMAZON_EYE")]
    [Label("Windbreaker Amazon Eye", 1)]
    WindbreakerAmazonEye = 13000001,

    /// <summary>Boost accuracy and avoid.</summary>
    [Label("WINDBREAKER_FOCUS")]
    [Label("Windbreaker Focus", 1)]
    WindbreakerFocus = 13001002,

    /// <summary>Fire two arrows.</summary>
    [Label("WINDBREAKER_DOUBLE_SHOT")]
    [Label("Windbreaker Double Shot", 1)]
    WindbreakerDoubleShot = 13001003,

    /// <summary>Activate storm power.</summary>
    [Label("WINDBREAKER_STORM")]
    [Label("Windbreaker Storm", 1)]
    WindbreakerStorm = 13001004,

    /// <summary>Boost bow proficiency.</summary>
    [Label("WINDBREAKER_BOW_MASTERY")]
    [Label("Windbreaker Bow Mastery", 1)]
    WindbreakerBowMastery = 13100000,

    /// <summary>Boost bow attack speed.</summary>
    [Label("WINDBREAKER_BOW_BOOSTER")]
    [Label("Windbreaker Bow Booster", 1)]
    WindbreakerBowBooster = 13101001,

    /// <summary>Extra bow hit after attack.</summary>
    [Label("WINDBREAKER_FINAL_ATTACK_BOW")]
    [Label("Windbreaker Final Attack Bow", 1)]
    WindbreakerFinalAttackBow = 13101002,

    /// <summary>Fire without consuming arrows.</summary>
    [Label("WINDBREAKER_SOUL_ARROW_BOW")]
    [Label("Windbreaker Soul Arrow Bow", 1)]
    WindbreakerSoulArrowBow = 13101003,

    /// <summary>Boost movement with gear.</summary>
    [Label("WINDBREAKER_THRUST")]
    [Label("Windbreaker Thrust", 1)]
    WindbreakerThrust = 13100004,

    /// <summary>Wind storm attack.</summary>
    [Label("WINDBREAKER_STORM_BREAK")]
    [Label("Windbreaker Storm Break", 1)]
    WindbreakerStormBreak = 13101005,

    /// <summary>Move with wind speed.</summary>
    [Label("WINDBREAKER_WIND_WALK")]
    [Label("Windbreaker Wind Walk", 1)]
    WindbreakerWindWalk = 13101006,

    /// <summary>Rain arrows from sky.</summary>
    [Label("WINDBREAKER_ARROW_RAIN")]
    [Label("Windbreaker Arrow Rain", 1)]
    WindbreakerArrowRain = 13111000,

    /// <summary>Rapid multi-arrow attack.</summary>
    [Label("WINDBREAKER_STRAFE")]
    [Label("Windbreaker Strafe", 1)]
    WindbreakerStrafe = 13111001,

    /// <summary>Rapid-fire arrow volley.</summary>
    [Label("WINDBREAKER_STORM_ARROW")]
    [Label("Windbreaker Storm Arrow", 1)]
    WindbreakerStormArrow = 13111002,

    /// <summary>Master bow proficiency.</summary>
    [Label("WINDBREAKER_BOW_EXPERT")]
    [Label("Windbreaker Bow Expert", 1)]
    WindbreakerBowExpert = 13110003,

    /// <summary>Deploy decoy puppet.</summary>
    [Label("WINDBREAKER_PUPPET")]
    [Label("Windbreaker Puppet", 1)]
    WindbreakerPuppet = 13111004,

    /// <summary>Summon Albatross companion.</summary>
    [Label("WINDBREAKER_ALBATROSS")]
    [Label("Windbreaker Albatross", 1)]
    WindbreakerAlbatross = 13111005,

    /// <summary>Wind spear attack.</summary>
    [Label("WINDBREAKER_WIND_SPEAR")]
    [Label("Windbreaker Wind Spear", 1)]
    WindbreakerWindSpear = 13111006,

    /// <summary>Wind-element arrow shot.</summary>
    [Label("WINDBREAKER_WIND_SHOT")]
    [Label("Windbreaker Wind Shot", 1)]
    WindbreakerWindShot = 13111007,

    /// <summary>Boost avoid and accuracy.</summary>
    [Label("NIGHTWALKER_NIMBLE_BODY")]
    [Label("Nightwalker Nimble Body", 1)]
    NightwalkerNimbleBody = 14000000,

    /// <summary>Increase throwing range.</summary>
    [Label("NIGHTWALKER_KEEN_EYES")]
    [Label("Nightwalker Keen Eyes", 1)]
    NightwalkerKeenEyes = 14000001,

    /// <summary>Lower enemy stats.</summary>
    [Label("NIGHTWALKER_DISORDER")]
    [Label("Nightwalker Disorder", 1)]
    NightwalkerDisorder = 14001002,

    /// <summary>Turn invisible.</summary>
    [Label("NIGHTWALKER_DARK_SIGHT")]
    [Label("Nightwalker Dark Sight", 1)]
    NightwalkerDarkSight = 14001003,

    /// <summary>Throw two stars.</summary>
    [Label("NIGHTWALKER_LUCKY_SEVEN")]
    [Label("Nightwalker Lucky Seven", 1)]
    NightwalkerLuckySeven = 14001004,

    /// <summary>Activate darkness power.</summary>
    [Label("NIGHTWALKER_DARKNESS")]
    [Label("Nightwalker Darkness", 1)]
    NightwalkerDarkness = 14001005,

    /// <summary>Boost star proficiency.</summary>
    [Label("NIGHTWALKER_JAVELIN_MASTERY")]
    [Label("Nightwalker Javelin Mastery", 1)]
    NightwalkerJavelinMastery = 14100000,

    /// <summary>Boost star critical rate.</summary>
    [Label("NIGHTWALKER_CRITICAL_THROW")]
    [Label("Nightwalker Critical Throw", 1)]
    NightwalkerCriticalThrow = 14100001,

    /// <summary>Boost throwing speed.</summary>
    [Label("NIGHTWALKER_JAVELIN_BOOSTER")]
    [Label("Nightwalker Javelin Booster", 1)]
    NightwalkerJavelinBooster = 14101002,

    /// <summary>Increase speed and jump.</summary>
    [Label("NIGHTWALKER_HASTE")]
    [Label("Nightwalker Haste", 1)]
    NightwalkerHaste = 14101003,

    /// <summary>Flash jump forward.</summary>
    [Label("NIGHTWALKER_FLASH_JUMP")]
    [Label("Nightwalker Flash Jump", 1)]
    NightwalkerFlashJump = 14101004,

    /// <summary>Enhanced dark sight.</summary>
    [Label("NIGHTWALKER_VANISH")]
    [Label("Nightwalker Vanish", 1)]
    NightwalkerVanish = 14100005,

    /// <summary>Drain HP from enemies.</summary>
    [Label("NIGHTWALKER_VAMPIRE")]
    [Label("Nightwalker Vampire", 1)]
    NightwalkerVampire = 14101006,

    /// <summary>Shadow mirror attacks.</summary>
    [Label("NIGHTWALKER_SHADOW_PARTNER")]
    [Label("Nightwalker Shadow Partner", 1)]
    NightwalkerShadowPartner = 14111000,

    /// <summary>Trap enemies in web.</summary>
    [Label("NIGHTWALKER_SHADOW_WEB")]
    [Label("Nightwalker Shadow Web", 1)]
    NightwalkerShadowWeb = 14111001,

    /// <summary>Throw giant star.</summary>
    [Label("NIGHTWALKER_AVENGER")]
    [Label("Nightwalker Avenger", 1)]
    NightwalkerAvenger = 14111002,

    /// <summary>Boost potion recovery.</summary>
    [Label("NIGHTWALKER_ALCHEMIST")]
    [Label("Nightwalker Alchemist", 1)]
    NightwalkerAlchemist = 14110003,

    /// <summary>Apply venom to attacks.</summary>
    [Label("NIGHTWALKER_VENOM")]
    [Label("Nightwalker Venom", 1)]
    NightwalkerVenom = 14110004,

    /// <summary>Throw three stars.</summary>
    [Label("NIGHTWALKER_TRIPLE_THROW")]
    [Label("Nightwalker Triple Throw", 1)]
    NightwalkerTripleThrow = 14111005,

    /// <summary>Throw poison bomb.</summary>
    [Label("NIGHTWALKER_POISON_BOMB")]
    [Label("Nightwalker Poison Bomb", 1)]
    NightwalkerPoisonBomb = 14111006,

    /// <summary>Throw snail shells.</summary>
    [Label("LEGEND_THROW_SNAIL")]
    [Label("Legend Throw Snail", 1)]
    LegendThrowSnail = 20001000,

    /// <summary>Recover HP over time.</summary>
    [Label("LEGEND_REGENERATION")]
    [Label("Legend Regeneration", 1)]
    LegendRegeneration = 20001001,

    /// <summary>Recover while moving.</summary>
    [Label("LEGEND_MOVING_WITH_ACTIVITY")]
    [Label("Legend Moving With Activity", 1)]
    LegendMovingWithActivity = 20001002,

    /// <summary>Crafting proficiency boost.</summary>
    [Label("LEGEND_SOUL_OF_CRAFTMAN")]
    [Label("Legend Soul Of Craftsman", 1)]
    LegendSoulOfCraftsman = 20001003,

    /// <summary>Mount a tamed monster.</summary>
    [Label("LEGEND_MONSTER_RIDING")]
    [Label("Legend Monster Riding", 1)]
    LegendMonsterRiding = 20001004,

    /// <summary>Max-level echo buff.</summary>
    [Label("LEGEND_MAXLEVEL_ECHOBUFF")]
    [Label("Legend Max-Level Echo Buff", 1)]
    LegendMaxlevelEchobuff = 20001005,

    /// <summary>Display damage dealt.</summary>
    [Label("LEGEND_DAMAGEMETER")]
    [Label("Legend Damage Meter", 1)]
    LegendDamagemeter = 20001006,

    /// <summary>Craft items via Maker.</summary>
    [Label("LEGEND_MAKER")]
    [Label("Legend Maker", 1)]
    LegendMaker = 20001007,

    /// <summary>Bamboo rain attack.</summary>
    [Label("LEGEND_BAMBOO")]
    [Label("Legend Bamboo", 1)]
    LegendBamboo = 20001009,

    /// <summary>Temporary invincibility.</summary>
    [Label("LEGEND_INVINCIBLE")]
    [Label("Legend Invincible", 1)]
    LegendInvincible = 20001010,

    /// <summary>Enter berserk state.</summary>
    [Label("LEGEND_BERSERK")]
    [Label("Legend Berserk", 1)]
    LegendBerserk = 20001011,

    /// <summary>Nymph's blessing buff.</summary>
    [Label("LEGEND_BLESS_OF_NYMPH")]
    [Label("Legend Bless Of Nymph", 1)]
    LegendBlessOfNymph = 20000012,

    /// <summary>Tutorial guidance skill.</summary>
    [Label("LEGEND_TUTOR")]
    [Label("Legend Tutor", 1)]
    LegendTutor = 20001013,

    /// <summary>Two-hit polearm swing.</summary>
    [Label("LEGEND_DOUBLE_SWING")]
    [Label("Legend Double Swing", 1)]
    LegendDoubleSwing = 20000014,

    /// <summary>Three-hit polearm swing.</summary>
    [Label("LEGEND_TRIPLE_SWING")]
    [Label("Legend Triple Swing", 1)]
    LegendTripleSwing = 20000015,

    /// <summary>Powerful finishing blow.</summary>
    [Label("LEGEND_FINAL_BLOW")]
    [Label("Legend Final Blow", 1)]
    LegendFinalBlow = 20000016,

    /// <summary>Build combo counter.</summary>
    [Label("LEGEND_COMBO_ABILITY")]
    [Label("Legend Combo Ability", 1)]
    LegendComboAbility = 20000017,

    /// <summary>Boost combo critical rate.</summary>
    [Label("LEGEND_COMBO_CRITICAL")]
    [Label("Legend Combo Critical", 1)]
    LegendComboCritical = 20000018,

    /// <summary>Ride Yeti mount (disabled).</summary>
    [Label("DISABLE_LEGEND_YETI_EVENT_RIDING")]
    [Label("Disable Legend Yeti Event Riding", 1)]
    DisableLegendYetiEventRiding = 20001019,

    /// <summary>Party bonus EXP skill.</summary>
    [Label("LEGEND_MASSACRE")]
    [Label("Legend Massacre", 1)]
    LegendMassacre = 20001020,

    /// <summary>Ride Yeti mount variant (disabled).</summary>
    [Label("DISABLE_LEGEND_YETI_EVENT_RIDING2")]
    [Label("Disable Legend Yeti Event Riding2", 1)]
    DisableLegendYetiEventRiding2 = 20001022,

    /// <summary>Ride broomstick mount (disabled).</summary>
    [Label("DISABLE_LEGEND_BROOM_EVENT_RIDING")]
    [Label("Disable Legend Broom Event Riding", 1)]
    DisableLegendBroomEventRiding = 20001023,

    /// <summary>Equip multiple pets.</summary>
    [Label("LEGEND_MULTI_PET")]
    [Label("Legend Multi Pet", 1)]
    LegendMultiPet = 20000024,

    /// <summary>Ride wooden horse mount.</summary>
    [Label("LEGEND_WOODENHORSE_EVENT_RIDING")]
    [Label("Legend Wooden Horse Event Riding", 1)]
    LegendWoodenhorseEventRiding = 20001025,

    /// <summary>Enable flight ability.</summary>
    [Label("LEGEND_FLYING_SKILL")]
    [Label("Legend Flying Skill", 1)]
    LegendFlyingSkill = 20001026,

    /// <summary>Ride crocodile mount.</summary>
    [Label("LEGEND_KROKO_EVENT_RIDING")]
    [Label("Legend Kroko Event Riding", 1)]
    LegendKrokoEventRiding = 20001027,

    /// <summary>Ride streaker mount.</summary>
    [Label("LEGEND_NAKED_EVENT_RIDING")]
    [Label("Legend Naked Event Riding", 1)]
    LegendNakedEventRiding = 20001028,

    /// <summary>Ride pink scooter mount.</summary>
    [Label("LEGEND_PINK_SCOOTER_EVENT_RIDING")]
    [Label("Legend Pink Scooter Event Riding", 1)]
    LegendPinkScooterEventRiding = 20001029,

    /// <summary>Ride nimbus cloud mount.</summary>
    [Label("LEGEND_FLYING_CLOUD_EVENT_RIDING")]
    [Label("Legend Flying Cloud Event Riding", 1)]
    LegendFlyingCloudEventRiding = 20001030,

    /// <summary>Ride Balrog mount.</summary>
    [Label("LEGEND_BALROG_EVENT_RIDING")]
    [Label("Legend Balrog Event Riding", 1)]
    LegendBalrogEventRiding = 20001031,

    /// <summary>Ride go-kart mount.</summary>
    [Label("LEGEND_KART_EVENT_RIDING")]
    [Label("Legend Kart Event Riding", 1)]
    LegendKartEventRiding = 20001033,

    /// <summary>Ride tiger mount.</summary>
    [Label("LEGEND_ZD_TIGER_EVENT_RIDING")]
    [Label("Legend Zd Tiger Event Riding", 1)]
    LegendZdTigerEventRiding = 20001034,

    /// <summary>Ride Mist Balrog mount.</summary>
    [Label("LEGEND_MISTBALROG_EVENT_RIDING")]
    [Label("Legend Mistbalrog Event Riding", 1)]
    LegendMistbalrogEventRiding = 20001035,

    /// <summary>Ride lion mount.</summary>
    [Label("LEGEND_LIONS_EVENT_RIDING")]
    [Label("Legend Lions Event Riding", 1)]
    LegendLionsEventRiding = 20001036,

    /// <summary>Ride unicorn mount.</summary>
    [Label("LEGEND_UNICORN_EVENT_RIDING")]
    [Label("Legend Unicorn Event Riding", 1)]
    LegendUnicornEventRiding = 20001037,

    /// <summary>Ride low-rider mount.</summary>
    [Label("LEGEND_LOWRIDER_EVENT_RIDING")]
    [Label("Legend Lowrider Event Riding", 1)]
    LegendLowriderEventRiding = 20001038,

    /// <summary>Ride red truck mount.</summary>
    [Label("LEGEND_REDTRUCK_EVENT_RIDING")]
    [Label("Legend Redtruck Event Riding", 1)]
    LegendRedtruckEventRiding = 20001039,

    /// <summary>Ride gargoyle mount.</summary>
    [Label("LEGEND_GARGOYLES_EVENT_RIDING")]
    [Label("Legend Gargoyles Event Riding", 1)]
    LegendGargoylesEventRiding = 20001040,

    /// <summary>Ride spaceship mount.</summary>
    [Label("LEGEND_SPACE_EVENT_RIDING")]
    [Label("Legend Space Event Riding", 1)]
    LegendSpaceEventRiding = 20001046,

    /// <summary>Dash on spaceship mount.</summary>
    [Label("LEGEND_SPACE_EVENT_RIDING_DASH")]
    [Label("Legend Space Event Riding Dash", 1)]
    LegendSpaceEventRidingDash = 20001047,

    /// <summary>Interact on spaceship mount.</summary>
    [Label("LEGEND_SPACE_EVENT_RIDING_REACTOR")]
    [Label("Legend Space Event Riding Reactor", 1)]
    LegendSpaceEventRidingReactor = 20001048,

    /// <summary>Ride chicken mount.</summary>
    [Label("LEGEND_CHICKEN_EVENT_RIDING")]
    [Label("Legend Chicken Event Riding", 1)]
    LegendChickenEventRiding = 20001054,

    /// <summary>Ride holly bird mount.</summary>
    [Label("LEGEND_HOLLY_BIRD_EVENT_RIDING")]
    [Label("Legend Holly Bird Event Riding", 1)]
    LegendHollyBirdEventRiding = 20001042,

    /// <summary>Ride Orange Mushroom mount.</summary>
    [Label("LEGEND_ORANGE_MUSHROOM_EVENT_RIDING")]
    [Label("Legend Orange Mushroom Event Riding", 1)]
    LegendOrangeMushroomEventRiding = 20001044,

    /// <summary>Ride Nightmare mount.</summary>
    [Label("LEGEND_NIGHTMARE_EVENT_RIDING")]
    [Label("Legend Nightmare Event Riding", 1)]
    LegendNightmareEventRiding = 20001049,

    /// <summary>Ride Yeti mount.</summary>
    [Label("LEGEND_YETI_EVENT_RIDING")]
    [Label("Legend Yeti Event Riding", 1)]
    LegendYetiEventRiding = 20001050,

    /// <summary>Ride ostrich mount.</summary>
    [Label("LEGEND_OSTRICH_EVENT_RIDING")]
    [Label("Legend Ostrich Event Riding", 1)]
    LegendOstrichEventRiding = 20001051,

    /// <summary>Ride bear balloon mount.</summary>
    [Label("LEGEND_BEAR_BALOON_EVENT_RIDING")]
    [Label("Legend Bear Baloon Event Riding", 1)]
    LegendBearBaloonEventRiding = 20001052,

    /// <summary>Ride transformer mount.</summary>
    [Label("LEGEND_TRANS_ROBOT_EVENT_RIDING")]
    [Label("Legend Trans Robot Event Riding", 1)]
    LegendTransRobotEventRiding = 20001053,

    /// <summary>Ride motorbike mount.</summary>
    [Label("LEGEND_MOTORBIKE_EVENT_RIDING")]
    [Label("Legend Motorbike Event Riding", 1)]
    LegendMotorbikeEventRiding = 20001063,

    /// <summary>Ride power suit mount.</summary>
    [Label("LEGEND_POWERED_SUIT_EVENT_RIDING")]
    [Label("Legend Powered Suit Event Riding", 1)]
    LegendPoweredSuitEventRiding = 20001064,

    /// <summary>Increase speed and jump.</summary>
    [Label("LEGEND_HASTE")]
    [Label("Legend Haste", 1)]
    LegendHaste = 20008000,

    /// <summary>Open town portal.</summary>
    [Label("LEGEND_MYSTIC_DOOR")]
    [Label("Legend Mystic Door", 1)]
    LegendMysticDoor = 20008001,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("LEGEND_SHARP_EYES")]
    [Label("Legend Sharp Eyes", 1)]
    LegendSharpEyes = 20008002,

    /// <summary>Increase max HP and MP.</summary>
    [Label("LEGEND_HYPER_BODY")]
    [Label("Legend Hyper Body", 1)]
    LegendHyperBody = 20008003,

    /// <summary>Build combo counter.</summary>
    [Label("ARAN_COMBO_ABILITY")]
    [Label("Aran Combo Ability", 1)]
    AranComboAbility = 21000000,

    /// <summary>Quick combat movement.</summary>
    [Label("ARAN_COMBAT_STEP")]
    [Label("Aran Combat Step", 1)]
    AranCombatStep = 21001001,

    /// <summary>Two-hit polearm swing.</summary>
    [Label("ARAN_DOUBLE_SWING")]
    [Label("Aran Double Swing", 1)]
    AranDoubleSwing = 21000002,

    /// <summary>Boost polearm speed.</summary>
    [Label("ARAN_POLEARM_BOOSTER")]
    [Label("Aran Polearm Booster", 1)]
    AranPolearmBooster = 21001003,

    /// <summary>Boost polearm proficiency.</summary>
    [Label("ARAN_POLEARM_MASTERY")]
    [Label("Aran Polearm Mastery", 1)]
    AranPolearmMastery = 21100000,

    /// <summary>Three-hit polearm swing.</summary>
    [Label("ARAN_TRIPLE_SWING")]
    [Label("Aran Triple Swing", 1)]
    AranTripleSwing = 21100001,

    /// <summary>Charge while attacking.</summary>
    [Label("ARAN_FINAL_CHARGE")]
    [Label("Aran Final Charge", 1)]
    AranFinalCharge = 21100002,

    /// <summary>Damage touching enemies.</summary>
    [Label("ARAN_BODY_PRESSURE")]
    [Label("Aran Body Pressure", 1)]
    AranBodyPressure = 21101003,

    /// <summary>Combo-powered smash.</summary>
    [Label("ARAN_COMBO_SMASH")]
    [Label("Aran Combo Smash", 1)]
    AranComboSmash = 21100004,

    /// <summary>Combo-powered HP drain.</summary>
    [Label("ARAN_COMBO_DRAIN")]
    [Label("Aran Combo Drain", 1)]
    AranComboDrain = 21100005,

    /// <summary>Boost combo critical rate.</summary>
    [Label("ARAN_COMBO_CRITICAL")]
    [Label("Aran Combo Critical", 1)]
    AranComboCritical = 21110000,

    /// <summary>Resist knockback at combo.</summary>
    [Label("ARAN_SMART_KNOCKBACK")]
    [Label("Aran Smart Knockback", 1)]
    AranSmartKnockback = 21111001,

    /// <summary>Full swing wide attack.</summary>
    [Label("ARAN_FULL_SWING")]
    [Label("Aran Full Swing", 1)]
    AranFullSwing = 21110002,

    /// <summary>Toss enemies into air.</summary>
    [Label("ARAN_FINAL_TOSS")]
    [Label("Aran Final Toss", 1)]
    AranFinalToss = 21110003,

    /// <summary>Combo summon Fenrir.</summary>
    [Label("ARAN_COMBO_FENRIR")]
    [Label("Aran Combo Fenrir", 1)]
    AranComboFenrir = 21110004,

    /// <summary>Imbue weapon with ice.</summary>
    [Label("ARAN_SNOW_CHARGE")]
    [Label("Aran Snow Charge", 1)]
    AranSnowCharge = 21111005,

    /// <summary>Spinning AoE attack.</summary>
    [Label("ARAN_ROLLING_SPIN")]
    [Label("Aran Rolling Spin", 1)]
    AranRollingSpin = 21110006,

    /// <summary>Full swing double variant.</summary>
    [Label("ARAN_FULL_SWING_DS")]
    [Label("Aran Full Swing Ds", 1)]
    AranFullSwingDs = 21110007,

    /// <summary>Full swing triple variant.</summary>
    [Label("ARAN_FULL_SWING_TS")]
    [Label("Aran Full Swing Ts", 1)]
    AranFullSwingTs = 21110008,

    /// <summary>Boost all party stats.</summary>
    [Label("ARAN_MAPLE_HERO")]
    [Label("Aran Maple Hero", 1)]
    AranMapleHero = 21121000,

    /// <summary>Master polearm proficiency.</summary>
    [Label("ARAN_HIGH_MASTERY")]
    [Label("Aran High Mastery", 1)]
    AranHighMastery = 21120001,

    /// <summary>Over swing wide attack.</summary>
    [Label("ARAN_OVER_SWING")]
    [Label("Aran Over Swing", 1)]
    AranOverSwing = 21120002,

    /// <summary>Freeze enemies in place.</summary>
    [Label("ARAN_FREEZE_STANDING")]
    [Label("Aran Freeze Standing", 1)]
    AranFreezeStanding = 21121003,

    /// <summary>Boost defense greatly.</summary>
    [Label("ARAN_HIGH_DEFENSE")]
    [Label("Aran High Defense", 1)]
    AranHighDefense = 21120004,

    /// <summary>Powerful finishing blow.</summary>
    [Label("ARAN_FINAL_BLOW")]
    [Label("Aran Final Blow", 1)]
    AranFinalBlow = 21120005,

    /// <summary>Ultimate combo AoE attack.</summary>
    [Label("ARAN_COMBO_TEMPEST")]
    [Label("Aran Combo Tempest", 1)]
    AranComboTempest = 21120006,

    /// <summary>Combo defense barrier.</summary>
    [Label("ARAN_COMBO_BARRIER")]
    [Label("Aran Combo Barrier", 1)]
    AranComboBarrier = 21120007,

    /// <summary>Remove all debuffs.</summary>
    [Label("ARAN_HEROS_WILL")]
    [Label("Aran Heros Will", 1)]
    AranHerosWill = 21121008,

    /// <summary>Over swing double variant.</summary>
    [Label("ARAN_OVER_SWING_DS")]
    [Label("Aran Over Swing Ds", 1)]
    AranOverSwingDs = 21120009,

    /// <summary>Over swing triple variant.</summary>
    [Label("ARAN_OVER_SWING_TS")]
    [Label("Aran Over Swing Ts", 1)]
    AranOverSwingTs = 21120010,

    /// <summary>Throw snail shells.</summary>
    [Label("EVANJR_THROW_SNAIL")]
    [Label("Evanjr Throw Snail", 1)]
    EvanjrThrowSnail = 20011000,

    /// <summary>Recover HP over time.</summary>
    [Label("EVANJR_REGENERATION")]
    [Label("Evanjr Regeneration", 1)]
    EvanjrRegeneration = 20011001,

    /// <summary>Recover while moving.</summary>
    [Label("EVANJR_MOVING_WITH_ACTIVITY")]
    [Label("Evanjr Moving With Activity", 1)]
    EvanjrMovingWithActivity = 20011002,

    /// <summary>Crafting proficiency boost.</summary>
    [Label("EVANJR_SOUL_OF_CRAFTMAN")]
    [Label("Evanjr Soul Of Craftsman", 1)]
    EvanjrSoulOfCraftsman = 20011003,

    /// <summary>Mount a tamed monster.</summary>
    [Label("EVANJR_MONSTER_RIDING")]
    [Label("Evanjr Monster Riding", 1)]
    EvanjrMonsterRiding = 20011004,

    /// <summary>Max-level echo buff.</summary>
    [Label("EVANJR_MAXLEVEL_ECHOBUFF")]
    [Label("Evanjr Max-Level Echo Buff", 1)]
    EvanjrMaxlevelEchobuff = 20011005,

    /// <summary>Display damage dealt.</summary>
    [Label("EVANJR_DAMAGEMETER")]
    [Label("Evanjr Damage Meter", 1)]
    EvanjrDamagemeter = 20011006,

    /// <summary>Craft items via Maker.</summary>
    [Label("EVANJR_MAKER")]
    [Label("Evanjr Maker", 1)]
    EvanjrMaker = 20011007,

    /// <summary>Bamboo rain attack.</summary>
    [Label("EVANJR_BAMBOO")]
    [Label("Evanjr Bamboo", 1)]
    EvanjrBamboo = 20011009,

    /// <summary>Temporary invincibility.</summary>
    [Label("EVANJR_INVINCIBLE")]
    [Label("Evanjr Invincible", 1)]
    EvanjrInvincible = 20011010,

    /// <summary>Enter berserk state.</summary>
    [Label("EVANJR_BERSERK")]
    [Label("Evanjr Berserk", 1)]
    EvanjrBerserk = 20011011,

    /// <summary>Nymph's blessing buff.</summary>
    [Label("EVANJR_BLESS_OF_NYMPH")]
    [Label("Evanjr Bless Of Nymph", 1)]
    EvanjrBlessOfNymph = 20010012,

    /// <summary>Ride Yeti mount variant (disabled).</summary>
    [Label("DISABLE_EVANJR_YETI_EVENT_RIDING2")]
    [Label("Disable Evanjr Yeti Event Riding2", 1)]
    DisableEvanjrYetiEventRiding2 = 20011018,

    /// <summary>Ride broomstick mount (disabled).</summary>
    [Label("DISABLE_EVANJR_BROOM_EVENT_RIDING")]
    [Label("Disable Evanjr Broom Event Riding", 1)]
    DisableEvanjrBroomEventRiding = 20011019,

    /// <summary>Party bonus EXP skill.</summary>
    [Label("EVANJR_MASSACRE")]
    [Label("Evanjr Massacre", 1)]
    EvanjrMassacre = 20011020,

    /// <summary>Equip multiple pets.</summary>
    [Label("EVANJR_MULTI_PET")]
    [Label("Evanjr Multi Pet", 1)]
    EvanjrMultiPet = 20011024,

    /// <summary>Ride wooden horse mount.</summary>
    [Label("EVANJR_WOODENHORSE_EVENT_RIDING")]
    [Label("Evanjr Wooden Horse Event Riding", 1)]
    EvanjrWoodenhorseEventRiding = 20011025,

    /// <summary>Enable flight ability.</summary>
    [Label("EVANJR_FLYING_SKILL")]
    [Label("Evanjr Flying Skill", 1)]
    EvanjrFlyingSkill = 20011026,

    /// <summary>Ride crocodile mount.</summary>
    [Label("EVANJR_KROKO_EVENT_RIDING")]
    [Label("Evanjr Kroko Event Riding", 1)]
    EvanjrKrokoEventRiding = 20011027,

    /// <summary>Ride streaker mount.</summary>
    [Label("EVANJR_NAKED_EVENT_RIDING")]
    [Label("Evanjr Naked Event Riding", 1)]
    EvanjrNakedEventRiding = 20011028,

    /// <summary>Ride pink scooter mount.</summary>
    [Label("EVANJR_PINK_SCOOTER_EVENT_RIDING")]
    [Label("Evanjr Pink Scooter Event Riding", 1)]
    EvanjrPinkScooterEventRiding = 20011029,

    /// <summary>Ride nimbus cloud mount.</summary>
    [Label("EVANJR_FLYING_CLOUD_EVENT_RIDING")]
    [Label("Evanjr Flying Cloud Event Riding", 1)]
    EvanjrFlyingCloudEventRiding = 20011030,

    /// <summary>Ride Balrog mount.</summary>
    [Label("EVANJR_BALROG_EVENT_RIDING")]
    [Label("Evanjr Balrog Event Riding", 1)]
    EvanjrBalrogEventRiding = 20011031,

    /// <summary>Ride go-kart mount.</summary>
    [Label("EVANJR_KART_EVENT_RIDING")]
    [Label("Evanjr Kart Event Riding", 1)]
    EvanjrKartEventRiding = 20011033,

    /// <summary>Ride tiger mount.</summary>
    [Label("EVANJR_ZD_TIGER_EVENT_RIDING")]
    [Label("Evanjr Zd Tiger Event Riding", 1)]
    EvanjrZdTigerEventRiding = 20011034,

    /// <summary>Ride Mist Balrog mount.</summary>
    [Label("EVANJR_MISTBALROG_EVENT_RIDING")]
    [Label("Evanjr Mistbalrog Event Riding", 1)]
    EvanjrMistbalrogEventRiding = 20011035,

    /// <summary>Ride holly bird mount.</summary>
    [Label("EVANJR_HOLLY_BIRD_EVENT_RIDING")]
    [Label("Evanjr Holly Bird Event Riding", 1)]
    EvanjrHollyBirdEventRiding = 20011042,

    /// <summary>Ride Orange Mushroom mount.</summary>
    [Label("EVANJR_ORANGE_MUSHROOM_EVENT_RIDING")]
    [Label("Evanjr Orange Mushroom Event Riding", 1)]
    EvanjrOrangeMushroomEventRiding = 20011044,

    /// <summary>Ride Nightmare mount.</summary>
    [Label("EVANJR_NIGHTMARE_EVENT_RIDING")]
    [Label("Evanjr Nightmare Event Riding", 1)]
    EvanjrNightmareEventRiding = 20011049,

    /// <summary>Ride Yeti mount.</summary>
    [Label("EVANJR_YETI_EVENT_RIDING")]
    [Label("Evanjr Yeti Event Riding", 1)]
    EvanjrYetiEventRiding = 20011050,

    /// <summary>Ride ostrich mount.</summary>
    [Label("EVANJR_OSTRICH_EVENT_RIDING")]
    [Label("Evanjr Ostrich Event Riding", 1)]
    EvanjrOstrichEventRiding = 20011051,

    /// <summary>Ride bear balloon mount.</summary>
    [Label("EVANJR_BEAR_BALOON_EVENT_RIDING")]
    [Label("Evanjr Bear Baloon Event Riding", 1)]
    EvanjrBearBaloonEventRiding = 20011052,

    /// <summary>Ride transformer mount.</summary>
    [Label("EVANJR_TRANS_ROBOT_EVENT_RIDING")]
    [Label("Evanjr Trans Robot Event Riding", 1)]
    EvanjrTransRobotEventRiding = 20011053,

    /// <summary>Ride motorbike mount.</summary>
    [Label("EVANJR_MOTORBIKE_EVENT_RIDING")]
    [Label("Evanjr Motorbike Event Riding", 1)]
    EvanjrMotorbikeEventRiding = 20011063,

    /// <summary>Ride power suit mount.</summary>
    [Label("EVANJR_POWERED_SUIT_EVENT_RIDING")]
    [Label("Evanjr Powered Suit Event Riding", 1)]
    EvanjrPoweredSuitEventRiding = 20011064,

    /// <summary>Ride lion mount.</summary>
    [Label("EVANJR_LIONS_EVENT_RIDING")]
    [Label("Evanjr Lions Event Riding", 1)]
    EvanjrLionsEventRiding = 20011036,

    /// <summary>Ride unicorn mount.</summary>
    [Label("EVANJR_UNICORN_EVENT_RIDING")]
    [Label("Evanjr Unicorn Event Riding", 1)]
    EvanjrUnicornEventRiding = 20011037,

    /// <summary>Ride low-rider mount.</summary>
    [Label("EVANJR_LOWRIDER_EVENT_RIDING")]
    [Label("Evanjr Lowrider Event Riding", 1)]
    EvanjrLowriderEventRiding = 20011038,

    /// <summary>Ride red truck mount.</summary>
    [Label("EVANJR_REDTRUCK_EVENT_RIDING")]
    [Label("Evanjr Redtruck Event Riding", 1)]
    EvanjrRedtruckEventRiding = 20011039,

    /// <summary>Ride gargoyle mount.</summary>
    [Label("EVANJR_GARGOYLES_EVENT_RIDING")]
    [Label("Evanjr Gargoyles Event Riding", 1)]
    EvanjrGargoylesEventRiding = 20011040,

    /// <summary>Ride spaceship mount.</summary>
    [Label("EVANJR_SPACE_EVENT_RIDING")]
    [Label("Evanjr Space Event Riding", 1)]
    EvanjrSpaceEventRiding = 20011046,

    /// <summary>Dash on spaceship mount.</summary>
    [Label("EVANJR_SPACE_EVENT_RIDING_DASH")]
    [Label("Evanjr Space Event Riding Dash", 1)]
    EvanjrSpaceEventRidingDash = 20011047,

    /// <summary>Interact on spaceship mount.</summary>
    [Label("EVANJR_SPACE_EVENT_RIDING_REACTOR")]
    [Label("Evanjr Space Event Riding Reactor", 1)]
    EvanjrSpaceEventRidingReactor = 20011048,

    /// <summary>Ride chicken mount.</summary>
    [Label("EVANJR_CHICKEN_EVENT_RIDING")]
    [Label("Evanjr Chicken Event Riding", 1)]
    EvanjrChickenEventRiding = 20011054,

    /// <summary>Increase speed and jump.</summary>
    [Label("EVANJR_HASTE")]
    [Label("Evanjr Haste", 1)]
    EvanjrHaste = 20018000,

    /// <summary>Open town portal.</summary>
    [Label("EVANJR_MYSTIC_DOOR")]
    [Label("Evanjr Mystic Door", 1)]
    EvanjrMysticDoor = 20018001,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("EVANJR_SHARP_EYES")]
    [Label("Evanjr Sharp Eyes", 1)]
    EvanjrSharpEyes = 20018002,

    /// <summary>Increase max HP and MP.</summary>
    [Label("EVANJR_HYPER_BODY")]
    [Label("Evanjr Hyper Body", 1)]
    EvanjrHyperBody = 20018003,

    /// <summary>Link with dragon soul.</summary>
    [Label("EVAN_DRAGON_SOUL")]
    [Label("Evan Dragon Soul", 1)]
    EvanDragonSoul = 22000000,

    /// <summary>Fire magic missile.</summary>
    [Label("EVAN_MAGIC_MISSILE")]
    [Label("Evan Magic Missile", 1)]
    EvanMagicMissile = 22001001,

    /// <summary>Fire circle attack.</summary>
    [Label("EVAN_FIRECIRCLE")]
    [Label("Evan Firecircle", 1)]
    EvanFirecircle = 22101000,

    /// <summary>Teleport short distance.</summary>
    [Label("EVAN_TELEPORT")]
    [Label("Evan Teleport", 1)]
    EvanTeleport = 22101001,

    /// <summary>Lightning bolt attack.</summary>
    [Label("EVAN_LIGHTING_BOLT")]
    [Label("Evan Lighting Bolt", 1)]
    EvanLightingBolt = 22111000,

    /// <summary>Absorb damage with MP.</summary>
    [Label("EVAN_MAGIC_GUARD")]
    [Label("Evan Magic Guard", 1)]
    EvanMagicGuard = 22111001,

    /// <summary>Dragon's ice breath.</summary>
    [Label("EVAN_ICE_BREATH")]
    [Label("Evan Ice Breath", 1)]
    EvanIceBreath = 22121000,

    /// <summary>Reset elemental penalty.</summary>
    [Label("EVAN_ELEMENTAL_RESET")]
    [Label("Evan Elemental Reset", 1)]
    EvanElementalReset = 22121001,

    /// <summary>Boost spell proficiency.</summary>
    [Label("EVAN_SPELL_MASTERY")]
    [Label("Evan Spell Mastery", 1)]
    EvanSpellMastery = 22120002,

    /// <summary>Magic flair attack.</summary>
    [Label("EVAN_MAGIC_FLAIR")]
    [Label("Evan Magic Flair", 1)]
    EvanMagicFlair = 22131000,

    /// <summary>Magic damage shield.</summary>
    [Label("EVAN_MAGIC_SHIELD")]
    [Label("Evan Magic Shield", 1)]
    EvanMagicShield = 22131001,

    /// <summary>Boost magic critical rate.</summary>
    [Label("EVAN_MAGIC_CRITICAL")]
    [Label("Evan Magic Critical", 1)]
    EvanMagicCritical = 22140000,

    /// <summary>Dragon thrust attack.</summary>
    [Label("EVAN_DRAGON_THRUST")]
    [Label("Evan Dragon Thrust", 1)]
    EvanDragonThrust = 22141001,

    /// <summary>Boost casting speed.</summary>
    [Label("EVAN_MAGIC_BOOSTER")]
    [Label("Evan Magic Booster", 1)]
    EvanMagicBooster = 22141002,

    /// <summary>Slow enemy movement.</summary>
    [Label("EVAN_SLOW")]
    [Label("Evan Slow", 1)]
    EvanSlow = 22141003,

    /// <summary>Amplify elemental damage.</summary>
    [Label("EVAN_ELEMENT_AMPLIFICATION")]
    [Label("Evan Element Amplification", 1)]
    EvanElementAmplification = 22150000,

    /// <summary>Dragon's breath attack.</summary>
    [Label("EVAN_BREATH")]
    [Label("Evan Breath", 1)]
    EvanBreath = 22151001,

    /// <summary>Dragon wing attack.</summary>
    [Label("EVAN_KILLING_WING")]
    [Label("Evan Killing Wing", 1)]
    EvanKillingWing = 22151002,

    /// <summary>Boost magic resistance.</summary>
    [Label("EVAN_MAGIC_REGISTANCE")]
    [Label("Evan Magic Registance", 1)]
    EvanMagicRegistance = 22151003,

    /// <summary>Dragon's fury buff.</summary>
    [Label("EVAN_DRAGON_FURY")]
    [Label("Evan Dragon Fury", 1)]
    EvanDragonFury = 22160000,

    /// <summary>Earthquake AoE attack.</summary>
    [Label("EVAN_EARTHQUAKE")]
    [Label("Evan Earthquake", 1)]
    EvanEarthquake = 22161001,

    /// <summary>Ghost lettering debuff.</summary>
    [Label("EVAN_GHOST_LETTERING")]
    [Label("Evan Ghost Lettering", 1)]
    EvanGhostLettering = 22161002,

    /// <summary>Party recovery aura.</summary>
    [Label("EVAN_RECOVERY_AURA")]
    [Label("Evan Recovery Aura", 1)]
    EvanRecoveryAura = 22161003,

    /// <summary>Boost all party stats.</summary>
    [Label("EVAN_MAPLE_HERO")]
    [Label("Evan Maple Hero", 1)]
    EvanMapleHero = 22171000,

    /// <summary>Master magic proficiency.</summary>
    [Label("EVAN_MAGIC_MASTERY")]
    [Label("Evan Magic Mastery", 1)]
    EvanMagicMastery = 22170001,

    /// <summary>Illusion AoE attack.</summary>
    [Label("EVAN_ILLUSION")]
    [Label("Evan Illusion", 1)]
    EvanIllusion = 22171002,

    /// <summary>Flame wheel attack.</summary>
    [Label("EVAN_FLAME_WHEEL")]
    [Label("Evan Flame Wheel", 1)]
    EvanFlameWheel = 22171003,

    /// <summary>Remove all debuffs.</summary>
    [Label("EVAN_HEROS_WILL")]
    [Label("Evan Heros Will", 1)]
    EvanHerosWill = 22171004,

    /// <summary>Onyx dragon's blessing.</summary>
    [Label("EVAN_ONIX_BLESSING")]
    [Label("Evan Onix Blessing", 1)]
    EvanOnixBlessing = 22181000,

    /// <summary>Dragon blaze attack.</summary>
    [Label("EVAN_BLAZE")]
    [Label("Evan Blaze", 1)]
    EvanBlaze = 22181001,

    /// <summary>Dark fog AoE attack.</summary>
    [Label("EVAN_DARK_FOG")]
    [Label("Evan Dark Fog", 1)]
    EvanDarkFog = 22181002,

    /// <summary>Soul stone revival item.</summary>
    [Label("EVAN_SOUL_STONE")]
    [Label("Evan Soul Stone", 1)]
    EvanSoulStone = 22181003,

    /// <summary>Throw crystal projectiles.</summary>
    [Label("CITIZEN_CRISTAL_THROW")]
    [Label("Citizen Cristal Throw", 1)]
    CitizenCristalThrow = 30001000,

    /// <summary>Sneak past monsters.</summary>
    [Label("CITIZEN_SNEAK")]
    [Label("Citizen Sneak", 1)]
    CitizenSneak = 30001001,

    /// <summary>Improve work efficiency.</summary>
    [Label("CITIZEN_EFFICIENCY")]
    [Label("Citizen Efficiency", 1)]
    CitizenEfficiency = 30000002,

    /// <summary>Crafting proficiency boost.</summary>
    [Label("CITIZEN_SOUL_OF_CRAFTMAN")]
    [Label("Citizen Soul Of Craftsman", 1)]
    CitizenSoulOfCraftsman = 30001003,

    /// <summary>Mount a tamed monster.</summary>
    [Label("CITIZEN_MONSTER_RIDING")]
    [Label("Citizen Monster Riding", 1)]
    CitizenMonsterRiding = 30001004,

    /// <summary>Max-level echo buff.</summary>
    [Label("CITIZEN_MAXLEVEL_ECHOBUFF")]
    [Label("Citizen Max-Level Echo Buff", 1)]
    CitizenMaxlevelEchobuff = 30001005,

    /// <summary>Display damage dealt.</summary>
    [Label("CITIZEN_DAMAGEMETER")]
    [Label("Citizen Damage Meter", 1)]
    CitizenDamagemeter = 30001006,

    /// <summary>Craft items via Maker.</summary>
    [Label("CITIZEN_MAKER")]
    [Label("Citizen Maker", 1)]
    CitizenMaker = 30001007,

    /// <summary>Bamboo rain attack.</summary>
    [Label("CITIZEN_BAMBOO")]
    [Label("Citizen Bamboo", 1)]
    CitizenBamboo = 30001009,

    /// <summary>Temporary invincibility.</summary>
    [Label("CITIZEN_INVINCIBLE")]
    [Label("Citizen Invincible", 1)]
    CitizenInvincible = 30001010,

    /// <summary>Enter berserk state.</summary>
    [Label("CITIZEN_BERSERK")]
    [Label("Citizen Berserk", 1)]
    CitizenBerserk = 30001011,

    /// <summary>Nymph's blessing buff.</summary>
    [Label("CITIZEN_BLESS_OF_NYMPH")]
    [Label("Citizen Bless Of Nymph", 1)]
    CitizenBlessOfNymph = 30000012,

    /// <summary>Tutorial guidance skill.</summary>
    [Label("CITIZEN_TUTOR")]
    [Label("Citizen Tutor", 1)]
    CitizenTutor = 30001013,

    /// <summary>Party bonus EXP skill.</summary>
    [Label("CITIZEN_MASSACRE")]
    [Label("Citizen Massacre", 1)]
    CitizenMassacre = 30001020,

    /// <summary>Passive critical chance.</summary>
    [Label("CITIZEN_CRITICAL")]
    [Label("Citizen Critical", 1)]
    CitizenCritical = 30000022,

    /// <summary>Equip multiple pets.</summary>
    [Label("CITIZEN_MULTI_PET")]
    [Label("Citizen Multi Pet", 1)]
    CitizenMultiPet = 30001024,

    /// <summary>Ride wooden horse mount.</summary>
    [Label("CITIZEN_WOODENHORSE_EVENT_RIDING")]
    [Label("Citizen Wooden Horse Event Riding", 1)]
    CitizenWoodenhorseEventRiding = 30001025,

    /// <summary>Enable flight ability.</summary>
    [Label("CITIZEN_FLYING_SKILL")]
    [Label("Citizen Flying Skill", 1)]
    CitizenFlyingSkill = 30001026,

    /// <summary>Ride crocodile mount.</summary>
    [Label("CITIZEN_KROKO_EVENT_RIDING")]
    [Label("Citizen Kroko Event Riding", 1)]
    CitizenKrokoEventRiding = 30001027,

    /// <summary>Ride streaker mount.</summary>
    [Label("CITIZEN_NAKED_EVENT_RIDING")]
    [Label("Citizen Naked Event Riding", 1)]
    CitizenNakedEventRiding = 30001028,

    /// <summary>Ride pink scooter mount.</summary>
    [Label("CITIZEN_PINK_SCOOTER_EVENT_RIDING")]
    [Label("Citizen Pink Scooter Event Riding", 1)]
    CitizenPinkScooterEventRiding = 30001029,

    /// <summary>Ride nimbus cloud mount.</summary>
    [Label("CITIZEN_FLYING_CLOUD_EVENT_RIDING")]
    [Label("Citizen Flying Cloud Event Riding", 1)]
    CitizenFlyingCloudEventRiding = 30001030,

    /// <summary>Ride Balrog mount.</summary>
    [Label("CITIZEN_BALROG_EVENT_RIDING")]
    [Label("Citizen Balrog Event Riding", 1)]
    CitizenBalrogEventRiding = 30001031,

    /// <summary>Ride go-kart mount.</summary>
    [Label("CITIZEN_KART_EVENT_RIDING")]
    [Label("Citizen Kart Event Riding", 1)]
    CitizenKartEventRiding = 30001033,

    /// <summary>Ride tiger mount.</summary>
    [Label("CITIZEN_ZD_TIGER_EVENT_RIDING")]
    [Label("Citizen Zd Tiger Event Riding", 1)]
    CitizenZdTigerEventRiding = 30001034,

    /// <summary>Ride Mist Balrog mount.</summary>
    [Label("CITIZEN_MISTBALROG_EVENT_RIDING")]
    [Label("Citizen Mistbalrog Event Riding", 1)]
    CitizenMistbalrogEventRiding = 30001035,

    /// <summary>Ride holly bird mount.</summary>
    [Label("CITIZEN_HOLLY_BIRD_EVENT_RIDING")]
    [Label("Citizen Holly Bird Event Riding", 1)]
    CitizenHollyBirdEventRiding = 30001042,

    /// <summary>Ride Orange Mushroom mount.</summary>
    [Label("CITIZEN_ORANGE_MUSHROOM_EVENT_RIDING")]
    [Label("Citizen Orange Mushroom Event Riding", 1)]
    CitizenOrangeMushroomEventRiding = 30001044,

    /// <summary>Ride Nightmare mount.</summary>
    [Label("CITIZEN_NIGHTMARE_EVENT_RIDING")]
    [Label("Citizen Nightmare Event Riding", 1)]
    CitizenNightmareEventRiding = 30001049,

    /// <summary>Ride Yeti mount.</summary>
    [Label("CITIZEN_YETI_EVENT_RIDING")]
    [Label("Citizen Yeti Event Riding", 1)]
    CitizenYetiEventRiding = 30001050,

    /// <summary>Ride ostrich mount.</summary>
    [Label("CITIZEN_OSTRICH_EVENT_RIDING")]
    [Label("Citizen Ostrich Event Riding", 1)]
    CitizenOstrichEventRiding = 30001051,

    /// <summary>Ride bear balloon mount.</summary>
    [Label("CITIZEN_BEAR_BALOON_EVENT_RIDING")]
    [Label("Citizen Bear Baloon Event Riding", 1)]
    CitizenBearBaloonEventRiding = 30001052,

    /// <summary>Ride transformer mount.</summary>
    [Label("CITIZEN_TRANS_ROBOT_EVENT_RIDING")]
    [Label("Citizen Trans Robot Event Riding", 1)]
    CitizenTransRobotEventRiding = 30001053,

    /// <summary>Ride motorbike mount.</summary>
    [Label("CITIZEN_MOTORBIKE_EVENT_RIDING")]
    [Label("Citizen Motorbike Event Riding", 1)]
    CitizenMotorbikeEventRiding = 30001063,

    /// <summary>Ride power suit mount.</summary>
    [Label("CITIZEN_POWERED_SUIT_EVENT_RIDING")]
    [Label("Citizen Powered Suit Event Riding", 1)]
    CitizenPoweredSuitEventRiding = 30001064,

    /// <summary>Increase speed and jump.</summary>
    [Label("CITIZEN_HASTE")]
    [Label("Citizen Haste", 1)]
    CitizenHaste = 30008000,

    /// <summary>Open town portal.</summary>
    [Label("CITIZEN_MYSTIC_DOOR")]
    [Label("Citizen Mystic Door", 1)]
    CitizenMysticDoor = 30008001,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("CITIZEN_SHARP_EYES")]
    [Label("Citizen Sharp Eyes", 1)]
    CitizenSharpEyes = 30008002,

    /// <summary>Increase max HP and MP.</summary>
    [Label("CITIZEN_HYPER_BODY")]
    [Label("Citizen Hyper Body", 1)]
    CitizenHyperBody = 30008003,

    /// <summary>Capture wild jaguar.</summary>
    [Label("WILDHUNTER_CAPTURE")]
    [Label("Wildhunter Capture", 1)]
    WildhunterCapture = 30001061,

    /// <summary>Summon captured monster.</summary>
    [Label("WILDHUNTER_SUMMON_MONSTER")]
    [Label("Wildhunter Summon Monster", 1)]
    WildhunterSummonMonster = 30001062,

    /// <summary>Charge through enemies.</summary>
    [Label("MECHANIC_RUSH")]
    [Label("Mechanic Rush", 1)]
    MechanicRush = 30001068,

    /// <summary>Three-hit staff combo.</summary>
    [Label("BMAGE_TRIPLE_BLOW")]
    [Label("Bmage Triple Blow", 1)]
    BmageTripleBlow = 32001000,

    /// <summary>Finishing staff attack.</summary>
    [Label("BMAGE_FINISH_ATTACK")]
    [Label("Bmage Finish Attack", 1)]
    BmageFinishAttack = 32001001,

    /// <summary>Teleport short distance.</summary>
    [Label("BMAGE_TELEPORT")]
    [Label("Bmage Teleport", 1)]
    BmageTeleport = 32001002,

    /// <summary>Dark aura damage boost.</summary>
    [Label("BMAGE_AURA_DARK")]
    [Label("Bmage Aura Dark", 1)]
    BmageAuraDark = 32001003,

    /// <summary>Finish attack variant 1.</summary>
    [Label("BMAGE_FINISH_ATTACK1")]
    [Label("Bmage Finish Attack1", 1)]
    BmageFinishAttack1 = 32001007,

    /// <summary>Finish attack variant 2.</summary>
    [Label("BMAGE_FINISH_ATTACK2")]
    [Label("Bmage Finish Attack2", 1)]
    BmageFinishAttack2 = 32001008,

    /// <summary>Finish attack variant 3.</summary>
    [Label("BMAGE_FINISH_ATTACK3")]
    [Label("Bmage Finish Attack3", 1)]
    BmageFinishAttack3 = 32001009,

    /// <summary>Finish attack variant 4.</summary>
    [Label("BMAGE_FINISH_ATTACK4")]
    [Label("Bmage Finish Attack4", 1)]
    BmageFinishAttack4 = 32001010,

    /// <summary>Finish attack variant 5.</summary>
    [Label("BMAGE_FINISH_ATTACK5")]
    [Label("Bmage Finish Attack5", 1)]
    BmageFinishAttack5 = 32001011,

    /// <summary>Four-hit staff combo.</summary>
    [Label("BMAGE_QUAD_BLOW")]
    [Label("Bmage Quad Blow", 1)]
    BmageQuadBlow = 32101000,

    /// <summary>Dark chain attack.</summary>
    [Label("BMAGE_DARK_BOW")]
    [Label("Bmage Dark Bow", 1)]
    BmageDarkBow = 32101001,

    /// <summary>Blue aura defense boost.</summary>
    [Label("BMAGE_AURA_BLUE")]
    [Label("Bmage Aura Blue", 1)]
    BmageAuraBlue = 32101002,

    /// <summary>Yellow aura speed boost.</summary>
    [Label("BMAGE_AURA_YELLOW")]
    [Label("Bmage Aura Yellow", 1)]
    BmageAuraYellow = 32101003,

    /// <summary>Drain HP on attack.</summary>
    [Label("BMAGE_BLOOD_DRAIN")]
    [Label("Bmage Blood Drain", 1)]
    BmageBloodDrain = 32101004,

    /// <summary>Boost staff attack speed.</summary>
    [Label("BMAGE_STAFF_BOOSTER")]
    [Label("Bmage Staff Booster", 1)]
    BmageStaffBooster = 32101005,

    /// <summary>Boost spell proficiency.</summary>
    [Label("BMAGE_SPELL_MASTERY")]
    [Label("Bmage Spell Mastery", 1)]
    BmageSpellMastery = 32100006,

    /// <summary>Enhanced blue aura.</summary>
    [Label("BMAGE_AURA_BLUE_ADVANCED")]
    [Label("Bmage Aura Blue Advanced", 1)]
    BmageAuraBlueAdvanced = 32110000,

    /// <summary>Boost staff proficiency.</summary>
    [Label("BMAGE_STAFF_MASTERY")]
    [Label("Bmage Staff Mastery", 1)]
    BmageStaffMastery = 32110001,

    /// <summary>Deadly blow combo attack.</summary>
    [Label("BMAGE_DEATH_BLOW")]
    [Label("Bmage Death Blow", 1)]
    BmageDeathBlow = 32111002,

    /// <summary>Dark spear AoE attack.</summary>
    [Label("BMAGE_DARK_SPEAR")]
    [Label("Bmage Dark Spear", 1)]
    BmageDarkSpear = 32111003,

    /// <summary>Convert HP to MP.</summary>
    [Label("BMAGE_CONVERSION")]
    [Label("Bmage Conversion", 1)]
    BmageConversion = 32111004,

    /// <summary>Boost HP and MP greatly.</summary>
    [Label("BMAGE_SUPER_BODY")]
    [Label("Bmage Super Body", 1)]
    BmageSuperBody = 32111005,

    /// <summary>Auto-revive on death.</summary>
    [Label("BMAGE_REVIVE")]
    [Label("Bmage Revive", 1)]
    BmageRevive = 32111006,

    /// <summary>Dark super body buff.</summary>
    [Label("BMAGE_SUPER_BODY_DARK")]
    [Label("Bmage Super Body Dark", 1)]
    BmageSuperBodyDark = 32110007,

    /// <summary>Yellow super body buff.</summary>
    [Label("BMAGE_SUPER_BODY_YELLOW")]
    [Label("Bmage Super Body Yellow", 1)]
    BmageSuperBodyYellow = 32110008,

    /// <summary>Blue super body buff.</summary>
    [Label("BMAGE_SUPER_BODY_BLUE")]
    [Label("Bmage Super Body Blue", 1)]
    BmageSuperBodyBlue = 32110009,

    /// <summary>Enhanced teleport range.</summary>
    [Label("BMAGE_TELEPORT_MASTERY")]
    [Label("Bmage Teleport Mastery", 1)]
    BmageTeleportMastery = 32111010,

    /// <summary>Enhanced dark chain.</summary>
    [Label("BMAGE_ADVENCED_DARK_CHAIN")]
    [Label("Bmage Advenced Dark Chain", 1)]
    BmageAdvencedDarkChain = 32111011,

    /// <summary>Enhanced dark aura.</summary>
    [Label("BMAGE_AURA_DARK_ADVANCED")]
    [Label("Bmage Aura Dark Advanced", 1)]
    BmageAuraDarkAdvanced = 32120000,

    /// <summary>Enhanced yellow aura.</summary>
    [Label("BMAGE_AURA_YELLOW_ADVANCED")]
    [Label("Bmage Aura Yellow Advanced", 1)]
    BmageAuraYellowAdvanced = 32120001,

    /// <summary>Ultimate blow finisher.</summary>
    [Label("BMAGE_FINISH_BLOW")]
    [Label("Bmage Finish Blow", 1)]
    BmageFinishBlow = 32121002,

    /// <summary>Cyclone spin attack.</summary>
    [Label("BMAGE_CYCLONE")]
    [Label("Bmage Cyclone", 1)]
    BmageCyclone = 32121003,

    /// <summary>Dark nemesis AoE attack.</summary>
    [Label("BMAGE_NEMESIS")]
    [Label("Bmage Nemesis", 1)]
    BmageNemesis = 32121004,

    /// <summary>Resist knockback attacks.</summary>
    [Label("BMAGE_STANCE")]
    [Label("Bmage Stance", 1)]
    BmageStance = 32121005,

    /// <summary>Party damage shelter.</summary>
    [Label("BMAGE_SHELTER")]
    [Label("Bmage Shelter", 1)]
    BmageShelter = 32121006,

    /// <summary>Boost all party stats.</summary>
    [Label("BMAGE_MAPLE_HERO")]
    [Label("Bmage Maple Hero", 1)]
    BmageMapleHero = 32121007,

    /// <summary>Remove all debuffs.</summary>
    [Label("BMAGE_HEROS_WILL")]
    [Label("Bmage Heros Will", 1)]
    BmageHerosWill = 32121008,

    /// <summary>Boost energy recovery.</summary>
    [Label("BMAGE_ENERGIZE")]
    [Label("Bmage Energize", 1)]
    BmageEnergize = 32120009,

    /// <summary>Rapid crossbow fire.</summary>
    [Label("WILDHUNTER_RAPID_SHOOT")]
    [Label("Wildhunter Rapid Shoot", 1)]
    WildhunterRapidShoot = 33001000,

    /// <summary>Ride jaguar mount.</summary>
    [Label("WILDHUNTER_JAGUAR_RIDING")]
    [Label("Wildhunter Jaguar Riding", 1)]
    WildhunterJaguarRiding = 33001001,

    /// <summary>Double jump midair.</summary>
    [Label("WILDHUNTER_DOUBLE_JUMP")]
    [Label("Wildhunter Double Jump", 1)]
    WildhunterDoubleJump = 33001002,

    /// <summary>Boost crossbow attack speed.</summary>
    [Label("WILDHUNTER_CROSSBOW_BOOSTER")]
    [Label("Wildhunter Crossbow Booster", 1)]
    WildhunterCrossbowBooster = 33001003,

    /// <summary>Boost crossbow proficiency.</summary>
    [Label("WILDHUNTER_CROSSBOW_MASTERY")]
    [Label("Wildhunter Crossbow Mastery", 1)]
    WildhunterCrossbowMastery = 33100000,

    /// <summary>Explosive bolt attack.</summary>
    [Label("WILDHUNTER_BOMB_SHOOT")]
    [Label("Wildhunter Bomb Shoot", 1)]
    WildhunterBombShoot = 33101001,

    /// <summary>Jaguar knockback attack.</summary>
    [Label("WILDHUNTER_JAGUAR_NUCKBACK")]
    [Label("Wildhunter Jaguar Nuckback", 1)]
    WildhunterJaguarNuckback = 33101002,

    /// <summary>Fire without consuming bolts.</summary>
    [Label("WILDHUNTER_SOUL_ARROW_CROSSBOW")]
    [Label("Wildhunter Soul Arrow Crossbow", 1)]
    WildhunterSoulArrowCrossbow = 33101003,

    /// <summary>Deploy hidden mine.</summary>
    [Label("WILDHUNTER_MINE")]
    [Label("Wildhunter Mine", 1)]
    WildhunterMine = 33101004,

    /// <summary>Jaguar swallow attack.</summary>
    [Label("WILDHUNTER_SWALLOW")]
    [Label("Wildhunter Swallow", 1)]
    WildhunterSwallow = 33101005,

    /// <summary>Swallow buff effect.</summary>
    [Label("WILDHUNTER_SWALLOW_DUMMY_BUFF")]
    [Label("Wildhunter Swallow Dummy Buff", 1)]
    WildhunterSwallowDummyBuff = 33101006,

    /// <summary>Swallow attack effect.</summary>
    [Label("WILDHUNTER_SWALLOW_DUMMY_ATTACK")]
    [Label("Wildhunter Swallow Dummy Attack", 1)]
    WildhunterSwallowDummyAttack = 33101007,

    /// <summary>Deployed mine summon.</summary>
    [Label("WILDHUNTER_MINE_DUMMY_SUMMONED")]
    [Label("Wildhunter Mine Dummy Summoned", 1)]
    WildhunterMineDummySummoned = 33101008,

    /// <summary>Extra hit after attack.</summary>
    [Label("WILDHUNTER_FINAL_ATTACK")]
    [Label("Wildhunter Final Attack", 1)]
    WildhunterFinalAttack = 33100009,

    /// <summary>Boost riding proficiency.</summary>
    [Label("WILDHUNTER_RIDING_MASTERY")]
    [Label("Wildhunter Riding Mastery", 1)]
    WildhunterRidingMastery = 33110000,

    /// <summary>Five-arrow volley.</summary>
    [Label("WILDHUNTER_FIVE_SHOOT")]
    [Label("Wildhunter Five Shoot", 1)]
    WildhunterFiveShoot = 33111001,

    /// <summary>Cross-road mine attack.</summary>
    [Label("WILDHUNTER_CROSS_ROAD")]
    [Label("Wildhunter Cross Road", 1)]
    WildhunterCrossRoad = 33111002,

    /// <summary>Deploy hunting trap.</summary>
    [Label("WILDHUNTER_TRAP")]
    [Label("Wildhunter Trap", 1)]
    WildhunterTrap = 33111003,

    /// <summary>Blind enemies on hit.</summary>
    [Label("WILDHUNTER_BLIND")]
    [Label("Wildhunter Blind", 1)]
    WildhunterBlind = 33111004,

    /// <summary>Summon Silver Hawk.</summary>
    [Label("WILDHUNTER_SILVER_HAWK")]
    [Label("Wildhunter Silver Hawk", 1)]
    WildhunterSilverHawk = 33111005,

    /// <summary>Jaguar claw attack.</summary>
    [Label("WILDHUNTER_CLAW_CUT")]
    [Label("Wildhunter Claw Cut", 1)]
    WildhunterClawCut = 33111006,

    /// <summary>Master crossbow proficiency.</summary>
    [Label("WILDHUNTER_CROSSBOW_EXPERT")]
    [Label("Wildhunter Crossbow Expert", 1)]
    WildhunterCrossbowExpert = 33120000,

    /// <summary>Flash arrow rain.</summary>
    [Label("WILDHUNTER_FLASH_RAIN")]
    [Label("Wildhunter Flash Rain", 1)]
    WildhunterFlashRain = 33121001,

    /// <summary>Electric shock attack.</summary>
    [Label("WILDHUNTER_ELRECTRONICSHOCK")]
    [Label("Wildhunter Elrectronicshock", 1)]
    WildhunterElrectronicshock = 33121002,

    /// <summary>One-shot snipe attack.</summary>
    [Label("WILDHUNTER_SNIPING")]
    [Label("Wildhunter Sniping", 1)]
    WildhunterSniping = 33121003,

    /// <summary>Boost critical and accuracy.</summary>
    [Label("WILDHUNTER_SHARP_EYES")]
    [Label("Wildhunter Sharp Eyes", 1)]
    WildhunterSharpEyes = 33121004,

    /// <summary>Nerve gas AoE debuff.</summary>
    [Label("WILDHUNTER_NERVEGAS")]
    [Label("Wildhunter Nervegas", 1)]
    WildhunterNervegas = 33121005,

    /// <summary>Enhanced jaguar power.</summary>
    [Label("WILDHUNTER_MOREWILD")]
    [Label("Wildhunter Morewild", 1)]
    WildhunterMorewild = 33121006,

    /// <summary>Boost all party stats.</summary>
    [Label("WILDHUNTER_MAPLE_HERO")]
    [Label("Wildhunter Maple Hero", 1)]
    WildhunterMapleHero = 33121007,

    /// <summary>Remove all debuffs.</summary>
    [Label("WILDHUNTER_HEROS_WILL")]
    [Label("Wildhunter Heros Will", 1)]
    WildhunterHerosWill = 33121008,

    /// <summary>Wild barrage attack.</summary>
    [Label("WILDHUNTER_WILD_SHOOT")]
    [Label("Wildhunter Wild Shoot", 1)]
    WildhunterWildShoot = 33121009,

    /// <summary>Wild instinct boost.</summary>
    [Label("WILDHUNTER_WILD_INSTINCT")]
    [Label("Wildhunter Wild Instinct", 1)]
    WildhunterWildInstinct = 33120010,

    /// <summary>Mech flamethrower attack.</summary>
    [Label("MECHANIC_FLAMETHROWER")]
    [Label("Mechanic Flamethrower", 1)]
    MechanicFlamethrower = 35001001,

    /// <summary>Flamethrower state buff.</summary>
    [Label("MECHANIC_FLAMETHROWER_DUMMY")]
    [Label("Mechanic Flamethrower Dummy", 1)]
    MechanicFlamethrowerDummy = 35000001,

    /// <summary>Summon HN-07 robot.</summary>
    [Label("MECHANIC_HN07")]
    [Label("Mechanic Hn07", 1)]
    MechanicHn07 = 35001002,

    /// <summary>Mech drill charge attack.</summary>
    [Label("MECHANIC_DRILL_RUSH")]
    [Label("Mechanic Drill Rush", 1)]
    MechanicDrillRush = 35001003,

    /// <summary>Mech gatling gun attack.</summary>
    [Label("MECHANIC_GATLING")]
    [Label("Mechanic Gatling", 1)]
    MechanicGatling = 35001004,

    /// <summary>Boost gun proficiency.</summary>
    [Label("MECHANIC_GUN_MASTERY")]
    [Label("Mechanic Gun Mastery", 1)]
    MechanicGunMastery = 35100000,

    /// <summary>Summon gatling robot.</summary>
    [Label("MECHANIC_GATLING_ROBOT_G007")]
    [Label("Mechanic Gatling Robot G007", 1)]
    MechanicGatlingRobotG007 = 35101001,

    /// <summary>Deploy Earth Slug bomb.</summary>
    [Label("MECHANIC_EARTH_SLUG")]
    [Label("Mechanic Earth Slug", 1)]
    MechanicEarthSlug = 35101003,

    /// <summary>Mech rocket dash boost.</summary>
    [Label("MECHANIC_ROCKET_BOOSTER")]
    [Label("Mechanic Rocket Booster", 1)]
    MechanicRocketBooster = 35101004,

    /// <summary>Rocket booster state.</summary>
    [Label("MECHANIC_ROCKET_BOOSTER_DUMMY")]
    [Label("Mechanic Rocket Booster Dummy", 1)]
    MechanicRocketBoosterDummy = 35100004,

    /// <summary>Open portal gate.</summary>
    [Label("MECHANIC_OPEN_GATE")]
    [Label("Mechanic Open Gate", 1)]
    MechanicOpenGate = 35101005,

    /// <summary>Boost mech attack speed.</summary>
    [Label("MECHANIC_BOOSTER")]
    [Label("Mechanic Booster", 1)]
    MechanicBooster = 35101006,

    /// <summary>Boost mech defense.</summary>
    [Label("MECHANIC_PERFECT_ARMOR")]
    [Label("Mechanic Perfect Armor", 1)]
    MechanicPerfectArmor = 35101007,

    /// <summary>Boost mech weapon mastery.</summary>
    [Label("MECHANIC_WEAPONMASTERY")]
    [Label("Mechanic Weaponmastery", 1)]
    MechanicWeaponmastery = 35100008,

    /// <summary>Enhanced flamethrower.</summary>
    [Label("MECHANIC_FLAMETHROWER_UP")]
    [Label("Mechanic Flamethrower Up", 1)]
    MechanicFlamethrowerUp = 35101009,

    /// <summary>Enhanced flame state.</summary>
    [Label("MECHANIC_FLAMETHROWER_UP_DUMMY")]
    [Label("Mechanic Flamethrower Up Dummy", 1)]
    MechanicFlamethrowerUpDummy = 35100009,

    /// <summary>Enhanced gatling gun.</summary>
    [Label("MECHANIC_GATLING_UP")]
    [Label("Mechanic Gatling Up", 1)]
    MechanicGatlingUp = 35101010,

    /// <summary>Deploy support satellite.</summary>
    [Label("MECHANIC_SATELITE")]
    [Label("Mechanic Satelite", 1)]
    MechanicSatelite = 35111001,

    /// <summary>Deploy Tesla coil trap.</summary>
    [Label("MECHANIC_TESLA_COIL")]
    [Label("Mechanic Tesla Coil", 1)]
    MechanicTeslaCoil = 35111002,

    /// <summary>Siege mode turret.</summary>
    [Label("MECHANIC_SIEGE1")]
    [Label("Mechanic Siege1", 1)]
    MechanicSiege1 = 35111004,

    /// <summary>Siege mode state buff.</summary>
    [Label("MECHANIC_SIEGE1_DUMMY")]
    [Label("Mechanic Siege1Dummy", 1)]
    MechanicSiege1Dummy = 35110004,

    /// <summary>Control party speed.</summary>
    [Label("MECHANIC_VELOCITY_CONTROLER")]
    [Label("Mechanic Velocity Controler", 1)]
    MechanicVelocityControler = 35111005,

    /// <summary>Deploy second satellite.</summary>
    [Label("MECHANIC_SATELITE2")]
    [Label("Mechanic Satelite2", 1)]
    MechanicSatelite2 = 35111009,

    /// <summary>Deploy third satellite.</summary>
    [Label("MECHANIC_SATELITE3")]
    [Label("Mechanic Satelite3", 1)]
    MechanicSatelite3 = 35111010,

    /// <summary>Summon healing robot.</summary>
    [Label("MECHANIC_HEALING_ROBOT_H_LX")]
    [Label("Mechanic Healing Robot HLx", 1)]
    MechanicHealingRobotHLx = 35111011,

    /// <summary>Roll dice for random buff.</summary>
    [Label("MECHANIC_DICE")]
    [Label("Mechanic Dice", 1)]
    MechanicDice = 35111013,

    /// <summary>Boost fist proficiency.</summary>
    [Label("MECHANIC_METAL_FIST_MASTERY")]
    [Label("Mechanic Metal Fist Mastery", 1)]
    MechanicMetalFistMastery = 35110014,

    /// <summary>Mech rocket punch attack.</summary>
    [Label("MECHANIC_ROCKET_PUNCH")]
    [Label("Mechanic Rocket Punch", 1)]
    MechanicRocketPunch = 35111015,

    /// <summary>Upgrade HN-07 robot.</summary>
    [Label("MECHANIC_HN07_UPGRADE")]
    [Label("Mechanic Hn07Upgrade", 1)]
    MechanicHn07Upgrade = 35120000,

    /// <summary>Master mech proficiency.</summary>
    [Label("MECHANIC_MASTERY")]
    [Label("Mechanic Mastery", 1)]
    MechanicMastery = 35120001,

    /// <summary>Upgrade Robo summons.</summary>
    [Label("MECHANIC_ROBOROBO_UPGRADE")]
    [Label("Mechanic Roborobo Upgrade", 1)]
    MechanicRoboroboUpgrade = 35120002,

    /// <summary>Deploy SG-88 cannon.</summary>
    [Label("MECHANIC_SG88")]
    [Label("Mechanic Sg88", 1)]
    MechanicSg88 = 35121003,

    /// <summary>Mech cannon blast attack.</summary>
    [Label("MECHANIC_CANON")]
    [Label("Mechanic Canon", 1)]
    MechanicCanon = 35121004,

    /// <summary>Enhanced siege turret.</summary>
    [Label("MECHANIC_SIEGE2")]
    [Label("Mechanic Siege2", 1)]
    MechanicSiege2 = 35121005,

    /// <summary>Siege 2 state buff.</summary>
    [Label("MECHANIC_SIEGE2_DUMMY")]
    [Label("Mechanic Siege2Dummy", 1)]
    MechanicSiege2Dummy = 35120005,

    /// <summary>Safety shutdown shield.</summary>
    [Label("MECHANIC_SAFETY")]
    [Label("Mechanic Safety", 1)]
    MechanicSafety = 35121006,

    /// <summary>Boost all party stats.</summary>
    [Label("MECHANIC_MAPLE_HERO")]
    [Label("Mechanic Maple Hero", 1)]
    MechanicMapleHero = 35121007,

    /// <summary>Remove all debuffs.</summary>
    [Label("MECHANIC_HEROS_WILL")]
    [Label("Mechanic Heros Will", 1)]
    MechanicHerosWill = 35121008,

    /// <summary>Summon Robo helper.</summary>
    [Label("MECHANIC_ROBOROBO")]
    [Label("Mechanic Roborobo", 1)]
    MechanicRoborobo = 35121009,

    /// <summary>Deploy AR-01 robot.</summary>
    [Label("MECHANIC_AR_01")]
    [Label("Mechanic Ar01", 1)]
    MechanicAr01 = 35121010,

    /// <summary>Robo summon state.</summary>
    [Label("MECHANIC_ROBOROBO_DUMMY")]
    [Label("Mechanic Roborobo Dummy", 1)]
    MechanicRoboroboDummy = 35121011,

    /// <summary>Mech laser beam attack.</summary>
    [Label("MECHANIC_LASER")]
    [Label("Mechanic Laser", 1)]
    MechanicLaser = 35121012,

    /// <summary>Special siege attack.</summary>
    [Label("MECHANIC_SIEGE2_SPECIAL")]
    [Label("Mechanic Siege2Special", 1)]
    MechanicSiege2Special = 35121013,

    /// <summary>Special siege state.</summary>
    [Label("MECHANIC_SIEGE2_SPECIAL_DUMMY")]
    [Label("Mechanic Siege2Special Dummy", 1)]
    MechanicSiege2SpecialDummy = 35120013,

    /// <summary>Deadly mob attack.</summary>
    [Label("UNRECORDED_DEADLYATTACK")]
    [Label("Unrecorded Deadlyattack", 1)]
    UnrecordedDeadlyattack = 90000000,

    /// <summary>Stun target enemy.</summary>
    [Label("UNRECORDED_STUN")]
    [Label("Unrecorded Stun", 1)]
    UnrecordedStun = 90001001,

    /// <summary>Slow enemy movement.</summary>
    [Label("UNRECORDED_SLOW")]
    [Label("Unrecorded Slow", 1)]
    UnrecordedSlow = 90001002,

    /// <summary>Poison target enemy.</summary>
    [Label("UNRECORDED_POISON")]
    [Label("Unrecorded Poison", 1)]
    UnrecordedPoison = 90001003,

    /// <summary>Blind enemies on hit.</summary>
    [Label("UNRECORDED_BLIND")]
    [Label("Unrecorded Blind", 1)]
    UnrecordedBlind = 90001004,

    /// <summary>Seal enemy skills.</summary>
    [Label("UNRECORDED_SEAL")]
    [Label("Unrecorded Seal", 1)]
    UnrecordedSeal = 90001005,

    /// <summary>Freeze target enemy.</summary>
    [Label("UNRECORDED_FREEZE")]
    [Label("Unrecorded Freeze", 1)]
    UnrecordedFreeze = 90001006,

    /// <summary>Guild meso rate boost.</summary>
    [Label("GUILD_MESOUP")]
    [Label("Guild Mesoup", 1)]
    GuildMesoup = 91000000,

    /// <summary>Guild EXP rate boost.</summary>
    [Label("GUILD_EXPERIENCEUP")]
    [Label("Guild Experienceup", 1)]
    GuildExperienceup = 91000001,

    /// <summary>Guild defense boost.</summary>
    [Label("GUILD_DEFENCEUP")]
    [Label("Guild Defenceup", 1)]
    GuildDefenceup = 91000002,

    /// <summary>Guild ATT/MATK boost.</summary>
    [Label("GUILD_ATTNMAGUP")]
    [Label("Guild Attnmagup", 1)]
    GuildAttnmagup = 91000003,

    /// <summary>Guild agility boost.</summary>
    [Label("GUILD_AGILITYUP")]
    [Label("Guild Agilityup", 1)]
    GuildAgilityup = 91000004,

    /// <summary>Guild business efficiency.</summary>
    [Label("GUILD_BUSINESSEFFICENYUP")]
    [Label("Guild Businessefficenyup", 1)]
    GuildBusinessefficenyup = 91000005,

    /// <summary>Guild regular support.</summary>
    [Label("GUILD_REGULARSUPPORT")]
    [Label("Guild Regularsupport", 1)]
    GuildRegularsupport = 91000006,
}
