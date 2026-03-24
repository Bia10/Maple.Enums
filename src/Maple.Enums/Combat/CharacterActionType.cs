using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character animation action types.
/// </summary>
public enum CharacterActionType : ushort
{
    /// <summary>Walking animation 1.</summary>
    [Label("ACT_WALK1")]
    Walk1 = 0,

    /// <summary>Walking animation 2.</summary>
    [Label("ACT_WALK2")]
    Walk2 = 1,

    /// <summary>Standing pose 1.</summary>
    [Label("ACT_STAND1")]
    Stand1 = 2,

    /// <summary>Standing pose 2.</summary>
    [Label("ACT_STAND2")]
    Stand2 = 3,

    /// <summary>Alert stance.</summary>
    [Label("ACT_ALERT")]
    Alert = 4,

    /// <summary>Overhead swing 1.</summary>
    [Label("ACT_SWINGO1")]
    [Label("Swing O1", 1)]
    SwingO1 = 5,

    /// <summary>Overhead swing 2.</summary>
    [Label("ACT_SWINGO2")]
    [Label("Swing O2", 1)]
    SwingO2 = 6,

    /// <summary>Overhead swing 3.</summary>
    [Label("ACT_SWINGO3")]
    [Label("Swing O3", 1)]
    SwingO3 = 7,

    /// <summary>Overhead swing final.</summary>
    [Label("ACT_SWINGOF")]
    [Label("Swing Of", 1)]
    SwingOf = 8,

    /// <summary>Tilt swing 1.</summary>
    [Label("ACT_SWINGT1")]
    [Label("Swing T1", 1)]
    SwingT1 = 9,

    /// <summary>Tilt swing 2.</summary>
    [Label("ACT_SWINGT2")]
    [Label("Swing T2", 1)]
    SwingT2 = 10,

    /// <summary>Tilt swing 3.</summary>
    [Label("ACT_SWINGT3")]
    [Label("Swing T3", 1)]
    SwingT3 = 11,

    /// <summary>Tilt swing final.</summary>
    [Label("ACT_SWINGTF")]
    [Label("Swing Tf", 1)]
    SwingTf = 12,

    /// <summary>Forward swing 1.</summary>
    [Label("ACT_SWINGP1")]
    [Label("Swing P1", 1)]
    SwingP1 = 13,

    /// <summary>Forward swing 2.</summary>
    [Label("ACT_SWINGP2")]
    [Label("Swing P2", 1)]
    SwingP2 = 14,

    /// <summary>Forward swing final.</summary>
    [Label("ACT_SWINGPF")]
    [Label("Swing Pf", 1)]
    SwingPf = 15,

    /// <summary>Overhead stab 1.</summary>
    [Label("ACT_STABO1")]
    [Label("Stab O1", 1)]
    StabO1 = 16,

    /// <summary>Overhead stab 2.</summary>
    [Label("ACT_STABO2")]
    [Label("Stab O2", 1)]
    StabO2 = 17,

    /// <summary>Overhead stab final.</summary>
    [Label("ACT_STABOF")]
    [Label("Stab Of", 1)]
    StabOf = 18,

    /// <summary>Tilt stab 1.</summary>
    [Label("ACT_STABT1")]
    [Label("Stab T1", 1)]
    StabT1 = 19,

    /// <summary>Tilt stab 2.</summary>
    [Label("ACT_STABT2")]
    [Label("Stab T2", 1)]
    StabT2 = 20,

    /// <summary>Tilt stab final.</summary>
    [Label("ACT_STABTF")]
    [Label("Stab Tf", 1)]
    StabTf = 21,

    /// <summary>Downward swing 1.</summary>
    [Label("ACT_SWINGD1")]
    [Label("Swing D1", 1)]
    SwingD1 = 22,

    /// <summary>Downward swing 2.</summary>
    [Label("ACT_SWINGD2")]
    [Label("Swing D2", 1)]
    SwingD2 = 23,

    /// <summary>Downward stab 1.</summary>
    [Label("ACT_STABD1")]
    [Label("Stab D1", 1)]
    StabD1 = 24,

    /// <summary>Triple blow attack.</summary>
    [Label("ACT_TRIPLEBLOW")]
    [Label("Triple Blow", 1)]
    TripleBlow = 25,

    /// <summary>Quad blow attack.</summary>
    [Label("ACT_QUADBLOW")]
    [Label("Quad Blow", 1)]
    QuadBlow = 26,

    /// <summary>Death blow attack.</summary>
    [Label("ACT_DEATHBLOW")]
    [Label("Death Blow", 1)]
    DeathBlow = 27,

    /// <summary>Finishing blow attack.</summary>
    [Label("ACT_FINISHBLOW")]
    [Label("Finish Blow", 1)]
    FinishBlow = 28,

    /// <summary>Finish attack link.</summary>
    [Label("ACT_FINISHATTACK_LINK")]
    [Label("Finish Attack Link", 1)]
    FinishAttackLink = 29,

    /// <summary>Finish attack link 2.</summary>
    [Label("ACT_FINISHATTACK_LINK2")]
    [Label("Finish Attack Link2", 1)]
    FinishAttackLink2 = 30,

    /// <summary>Shooting animation 1.</summary>
    [Label("ACT_SHOOT1")]
    Shoot1 = 31,

    /// <summary>Shooting animation 2.</summary>
    [Label("ACT_SHOOT2")]
    Shoot2 = 32,

    /// <summary>Shooting animation 3.</summary>
    [Label("ACT_SHOOT3")]
    Shoot3 = 33,

    /// <summary>Shooting animation 4.</summary>
    [Label("ACT_SHOOT4")]
    Shoot4 = 34,

    /// <summary>Shooting animation 5.</summary>
    [Label("ACT_SHOOT5")]
    Shoot5 = 35,

    /// <summary>Shooting final.</summary>
    [Label("ACT_SHOOTF")]
    [Label("Shoot F", 1)]
    ShootF = 36,

    /// <summary>Magic attack 1.</summary>
    [Label("ACT_MAGICATTACK1")]
    [Label("Magic Attack1", 1)]
    MagicAttack1 = 37,

    /// <summary>Magic attack 2.</summary>
    [Label("ACT_MAGICATTACK2")]
    [Label("Magic Attack2", 1)]
    MagicAttack2 = 38,

    /// <summary>Magic attack final.</summary>
    [Label("ACT_MAGICATTACKF")]
    [Label("Magic Attack F", 1)]
    MagicAttackF = 39,

    /// <summary>Magic heal cast.</summary>
    [Label("ACT_MAGICHEAL")]
    [Label("Magic Heal", 1)]
    MagicHeal = 40,

    /// <summary>Prone stab attack.</summary>
    [Label("ACT_PRONESTAB")]
    [Label("Prone Stab", 1)]
    ProneStab = 41,

    /// <summary>Prone position.</summary>
    [Label("ACT_PRONE")]
    Prone = 42,

    /// <summary>Flying animation 1.</summary>
    [Label("ACT_FLY1")]
    Fly1 = 43,

    /// <summary>Jump animation.</summary>
    [Label("ACT_JUMP")]
    Jump = 44,

    /// <summary>Ladder climbing.</summary>
    [Label("ACT_LADDER")]
    Ladder = 45,

    /// <summary>Rope climbing.</summary>
    [Label("ACT_ROPE")]
    Rope = 46,

    /// <summary>Death animation.</summary>
    [Label("ACT_DEAD")]
    Dead = 47,

    /// <summary>Sitting pose 1.</summary>
    [Label("ACT_SIT")]
    Sit = 48,

    /// <summary>Sitting pose 2.</summary>
    [Label("ACT_SIT2")]
    Sit2 = 49,

    /// <summary>Sitting pose 3.</summary>
    [Label("ACT_SIT3")]
    Sit3 = 50,

    /// <summary>Sitting pose 4.</summary>
    [Label("ACT_SIT4")]
    Sit4 = 51,

    /// <summary>Sitting pose 5.</summary>
    [Label("ACT_SIT5")]
    Sit5 = 52,

    /// <summary>Sitting pose 6.</summary>
    [Label("ACT_SIT6")]
    Sit6 = 53,

    /// <summary>Sitting pose 7.</summary>
    [Label("ACT_SIT7")]
    Sit7 = 54,

    /// <summary>Tired animation.</summary>
    [Label("ACT_TIRED")]
    Tired = 55,

    /// <summary>Siege mode 2 prone.</summary>
    [Label("ACT_SIEGE2_PRONE")]
    Siege2Prone = 56,

    /// <summary>Jaguar prone stab.</summary>
    [Label("ACT_PRONESTAB_JAGUAR")]
    [Label("Prone Stab Jaguar", 1)]
    ProneStabJaguar = 57,

    /// <summary>Alert stance 2.</summary>
    [Label("ACT_ALERT2")]
    Alert2 = 58,

    /// <summary>Alert stance 3.</summary>
    [Label("ACT_ALERT3")]
    Alert3 = 59,

    /// <summary>Alert stance 4.</summary>
    [Label("ACT_ALERT4")]
    Alert4 = 60,

    /// <summary>Alert stance 5.</summary>
    [Label("ACT_ALERT5")]
    Alert5 = 61,

    /// <summary>Alert stance 6.</summary>
    [Label("ACT_ALERT6")]
    Alert6 = 62,

    /// <summary>Alert stance 7.</summary>
    [Label("ACT_ALERT7")]
    Alert7 = 63,

    /// <summary>Ladder climbing 2.</summary>
    [Label("ACT_LADDER2")]
    Ladder2 = 64,

    /// <summary>Rope climbing 2.</summary>
    [Label("ACT_ROPE2")]
    Rope2 = 65,

    /// <summary>Shooting animation 6.</summary>
    [Label("ACT_SHOOT6")]
    Shoot6 = 66,

    /// <summary>Magic cast 1.</summary>
    [Label("ACT_MAGIC1")]
    Magic1 = 67,

    /// <summary>Magic cast 2.</summary>
    [Label("ACT_MAGIC2")]
    Magic2 = 68,

    /// <summary>Magic cast 3.</summary>
    [Label("ACT_MAGIC3")]
    Magic3 = 69,

    /// <summary>Magic cast 5.</summary>
    [Label("ACT_MAGIC5")]
    Magic5 = 70,

    /// <summary>Magic cast 6.</summary>
    [Label("ACT_MAGIC6")]
    Magic6 = 71,

    /// <summary>Burst attack 1.</summary>
    [Label("ACT_BURSTER1")]
    Burster1 = 72,

    /// <summary>Burst attack 2.</summary>
    [Label("ACT_BURSTER2")]
    Burster2 = 73,

    /// <summary>Savage blow attack.</summary>
    [Label("ACT_SAVAGEBLOW")]
    [Label("Savage Blow", 1)]
    SavageBlow = 74,

    /// <summary>Avenger skill.</summary>
    [Label("ACT_AVENGER")]
    Avenger = 75,

    /// <summary>Assaulter dash.</summary>
    [Label("ACT_ASSAULTER")]
    Assaulter = 76,

    /// <summary>Prone position 2.</summary>
    [Label("ACT_PRONE2")]
    Prone2 = 77,

    /// <summary>Assassination attack.</summary>
    [Label("ACT_ASSASSINATION")]
    Assassination = 78,

    /// <summary>Assassination special.</summary>
    [Label("ACT_ASSASSINATIONS")]
    [Label("Assassination S", 1)]
    AssassinationS = 79,

    /// <summary>Hustle dash.</summary>
    [Label("ACT_HUSTLE_DASH")]
    [Label("Hustle Dash", 1)]
    HustleDash = 80,

    /// <summary>Hustle stop.</summary>
    [Label("ACT_HUSTLE_STOP")]
    [Label("Hustle Stop", 1)]
    HustleStop = 81,

    /// <summary>Hustle attack.</summary>
    [Label("ACT_HUSTLE_ATTACK")]
    [Label("Hustle Attack", 1)]
    HustleAttack = 82,

    /// <summary>Rush charge.</summary>
    [Label("ACT_RUSH")]
    Rush = 83,

    /// <summary>Rush charge 2.</summary>
    [Label("ACT_RUSH2")]
    Rush2 = 84,

    /// <summary>Brandish swing 1.</summary>
    [Label("ACT_BRANDISH1")]
    Brandish1 = 85,

    /// <summary>Brandish swing 2.</summary>
    [Label("ACT_BRANDISH2")]
    Brandish2 = 86,

    /// <summary>Brave slash attack.</summary>
    [Label("ACT_BRAVE_SLASH")]
    [Label("Brave Slash", 1)]
    BraveSlash = 87,

    /// <summary>Sanctuary skill.</summary>
    [Label("ACT_SANCTUARY")]
    Sanctuary = 88,

    /// <summary>Meteor strike.</summary>
    [Label("ACT_METEOR")]
    Meteor = 89,

    /// <summary>Paralyze skill.</summary>
    [Label("ACT_PARALYZE")]
    Paralyze = 90,

    /// <summary>Blizzard skill.</summary>
    [Label("ACT_BLIZZARD")]
    Blizzard = 91,

    /// <summary>Genesis skill.</summary>
    [Label("ACT_GENESIS")]
    Genesis = 92,

    /// <summary>Ninja storm attack.</summary>
    [Label("ACT_NINJASTORM")]
    [Label("Ninja Storm", 1)]
    NinjaStorm = 93,

    /// <summary>Blast attack.</summary>
    [Label("ACT_BLAST")]
    Blast = 94,

    /// <summary>Holy shield buff.</summary>
    [Label("ACT_HOLYSHIELD")]
    [Label("Holy Shield", 1)]
    HolyShield = 95,

    /// <summary>Showdown skill.</summary>
    [Label("ACT_SHOWDOWN")]
    Showdown = 96,

    /// <summary>Resurrection skill.</summary>
    [Label("ACT_RESURRECTION")]
    Resurrection = 97,

    /// <summary>Chain lightning cast.</summary>
    [Label("ACT_CHAINLIGHTNING")]
    [Label("Chain Lightning", 1)]
    ChainLightning = 98,

    /// <summary>Smoke shell deploy.</summary>
    [Label("ACT_SMOKESHELL")]
    [Label("Smoke Shell", 1)]
    SmokeShell = 99,

    /// <summary>Handgun shot.</summary>
    [Label("ACT_HANDGUN")]
    Handgun = 100,

    /// <summary>Somersault kick.</summary>
    [Label("ACT_SOMERSAULT")]
    Somersault = 101,

    /// <summary>Straight punch.</summary>
    [Label("ACT_STRAIGHT")]
    Straight = 102,

    /// <summary>Energy burst.</summary>
    [Label("ACT_EBURSTER")]
    EBurster = 103,

    /// <summary>Back spin kick.</summary>
    [Label("ACT_BACKSPIN")]
    [Label("Back Spin", 1)]
    BackSpin = 104,

    /// <summary>Energy orb.</summary>
    [Label("ACT_EORB")]
    EOrb = 105,

    /// <summary>Screw punch.</summary>
    [Label("ACT_SCREW")]
    Screw = 106,

    /// <summary>Double uppercut.</summary>
    [Label("ACT_DOUBLEUPPER")]
    [Label("Double Upper", 1)]
    DoubleUpper = 107,

    /// <summary>Dragon strike attack.</summary>
    [Label("ACT_DRAGONSTRIKE")]
    [Label("Dragon Strike", 1)]
    DragonStrike = 108,

    /// <summary>Double fire shot.</summary>
    [Label("ACT_DOUBLEFIRE")]
    [Label("Double Fire", 1)]
    DoubleFire = 109,

    /// <summary>Triple fire shot.</summary>
    [Label("ACT_TRIPLEFIRE")]
    [Label("Triple Fire", 1)]
    TripleFire = 110,

    /// <summary>Fake action.</summary>
    [Label("ACT_FAKE")]
    Fake = 111,

    /// <summary>Air strike attack.</summary>
    [Label("ACT_AIRSTRIKE")]
    [Label("Air Strike", 1)]
    AirStrike = 112,

    /// <summary>Energy drain.</summary>
    [Label("ACT_EDRAIN")]
    EDrain = 113,

    /// <summary>Octopus summon.</summary>
    [Label("ACT_OCTOPUS")]
    Octopus = 114,

    /// <summary>Back step dodge.</summary>
    [Label("ACT_BACKSTEP")]
    [Label("Back Step", 1)]
    BackStep = 115,

    /// <summary>Shot attack.</summary>
    [Label("ACT_SHOT")]
    Shot = 116,

    /// <summary>Recovery skill.</summary>
    [Label("ACT_RECOVERY")]
    Recovery = 117,

    /// <summary>Fire burner attack.</summary>
    [Label("ACT_FIREBURNER")]
    [Label("Fire Burner", 1)]
    FireBurner = 118,

    /// <summary>Cooling effect.</summary>
    [Label("ACT_COOLINGEFFECT")]
    [Label("Cooling Effect", 1)]
    CoolingEffect = 119,

    /// <summary>Fist attack.</summary>
    [Label("ACT_FIST")]
    Fist = 120,

    /// <summary>Time leap skill.</summary>
    [Label("ACT_TIMELEAP")]
    [Label("Time Leap", 1)]
    TimeLeap = 121,

    /// <summary>Rapid fire attack.</summary>
    [Label("ACT_RAPIDFIRE")]
    [Label("Rapid Fire", 1)]
    RapidFire = 122,

    /// <summary>Homing shot.</summary>
    [Label("ACT_HOMING")]
    Homing = 123,

    /// <summary>Ghost walk.</summary>
    [Label("ACT_GHOST_WALK")]
    [Label("Ghost Walk", 1)]
    GhostWalk = 124,

    /// <summary>Ghost stand.</summary>
    [Label("ACT_GHOST_STAND")]
    [Label("Ghost Stand", 1)]
    GhostStand = 125,

    /// <summary>Ghost jump.</summary>
    [Label("ACT_GHOST_JUMP")]
    [Label("Ghost Jump", 1)]
    GhostJump = 126,

    /// <summary>Ghost prone stab.</summary>
    [Label("ACT_GHOST_PRONESTAB")]
    [Label("Ghost Prone Stab", 1)]
    GhostProneStab = 127,

    /// <summary>Ghost fly.</summary>
    [Label("ACT_GHOST_FLY")]
    [Label("Ghost Fly", 1)]
    GhostFly = 128,

    /// <summary>Ghost ladder climb.</summary>
    [Label("ACT_GHOST_LADDER")]
    [Label("Ghost Ladder", 1)]
    GhostLadder = 129,

    /// <summary>Ghost rope climb.</summary>
    [Label("ACT_GHOST_ROPE")]
    [Label("Ghost Rope", 1)]
    GhostRope = 130,

    /// <summary>Ghost sit pose.</summary>
    [Label("ACT_GHOST_SIT")]
    [Label("Ghost Sit", 1)]
    GhostSit = 131,

    /// <summary>Cannon shot.</summary>
    [Label("ACT_CANNON")]
    Cannon = 132,

    /// <summary>Torpedo launch.</summary>
    [Label("ACT_TORPEDO")]
    Torpedo = 133,

    /// <summary>Dark sight stealth.</summary>
    [Label("ACT_DARKSIGHT")]
    [Label("Dark Sight", 1)]
    DarkSight = 134,

    /// <summary>Bamboo strike.</summary>
    [Label("ACT_BAMBOO")]
    Bamboo = 135,

    /// <summary>Pyramid skill.</summary>
    [Label("ACT_PYRAMID")]
    Pyramid = 136,

    /// <summary>Wave attack.</summary>
    [Label("ACT_WAVE")]
    Wave = 137,

    /// <summary>Blade attack.</summary>
    [Label("ACT_BLADE")]
    Blade = 138,

    /// <summary>Soul driver attack.</summary>
    [Label("ACT_SOUL_DRIVER")]
    [Label("Soul Driver", 1)]
    SoulDriver = 139,

    /// <summary>Fire strike attack.</summary>
    [Label("ACT_FIRE_STRIKE")]
    [Label("Fire Strike", 1)]
    FireStrike = 140,

    /// <summary>Flame gear skill.</summary>
    [Label("ACT_FLAME_GEAR")]
    [Label("Flame Gear", 1)]
    FlameGear = 141,

    /// <summary>Storm break attack.</summary>
    [Label("ACT_STORM_BREAK")]
    [Label("Storm Break", 1)]
    StormBreak = 142,

    /// <summary>Vampire drain.</summary>
    [Label("ACT_VAMPIRE")]
    Vampire = 143,

    /// <summary>Event floating pose.</summary>
    [Label("ACT_EVENT_FLOATING")]
    [Label("Event Floating", 1)]
    EventFloating = 144,

    /// <summary>Polearm tilt swing 2.</summary>
    [Label("ACT_SWINGT2_POLEARM")]
    [Label("Swing T2Polearm", 1)]
    SwingT2Polearm = 145,

    /// <summary>Polearm forward swing 1.</summary>
    [Label("ACT_SWINGP1_POLEARM")]
    [Label("Swing P1Polearm", 1)]
    SwingP1Polearm = 146,

    /// <summary>Polearm forward swing 2.</summary>
    [Label("ACT_SWINGP2_POLEARM")]
    [Label("Swing P2Polearm", 1)]
    SwingP2Polearm = 147,

    /// <summary>Double swing attack.</summary>
    [Label("ACT_DOUBLE_SWING")]
    [Label("Double Swing", 1)]
    DoubleSwing = 148,

    /// <summary>Triple swing attack.</summary>
    [Label("ACT_TRIPLE_SWING")]
    [Label("Triple Swing", 1)]
    TripleSwing = 149,

    /// <summary>Full double swing.</summary>
    [Label("ACT_FULL_SWING_DOUBLE")]
    [Label("Full Swing Double", 1)]
    FullSwingDouble = 150,

    /// <summary>Full triple swing.</summary>
    [Label("ACT_FULL_SWING_TRIPLE")]
    [Label("Full Swing Triple", 1)]
    FullSwingTriple = 151,

    /// <summary>Over double swing.</summary>
    [Label("ACT_OVER_SWING_DOUBLE")]
    [Label("Over Swing Double", 1)]
    OverSwingDouble = 152,

    /// <summary>Over triple swing.</summary>
    [Label("ACT_OVER_SWING_TRIPLE")]
    [Label("Over Swing Triple", 1)]
    OverSwingTriple = 153,

    /// <summary>Rolling spin attack.</summary>
    [Label("ACT_ROLLING_SPIN")]
    [Label("Rolling Spin", 1)]
    RollingSpin = 154,

    /// <summary>Combo smash attack.</summary>
    [Label("ACT_COMBO_SMASH")]
    [Label("Combo Smash", 1)]
    ComboSmash = 155,

    /// <summary>Combo fenrir attack.</summary>
    [Label("ACT_COMBO_FENRIR")]
    [Label("Combo Fenrir", 1)]
    ComboFenrir = 156,

    /// <summary>Combo tempest attack.</summary>
    [Label("ACT_COMBO_TEMPEST")]
    [Label("Combo Tempest", 1)]
    ComboTempest = 157,

    /// <summary>Final charge attack.</summary>
    [Label("ACT_FINAL_CHARGE")]
    [Label("Final Charge", 1)]
    FinalCharge = 158,

    /// <summary>Combat step move.</summary>
    [Label("ACT_COMBAT_STEP")]
    [Label("Combat Step", 1)]
    CombatStep = 159,

    /// <summary>Final blow attack.</summary>
    [Label("ACT_FINAL_BLOW")]
    [Label("Final Blow", 1)]
    FinalBlow = 160,

    /// <summary>Final toss attack.</summary>
    [Label("ACT_FINAL_TOSS")]
    [Label("Final Toss", 1)]
    FinalToss = 161,

    /// <summary>Magic missile cast.</summary>
    [Label("ACT_MAGIC_MISSILE")]
    [Label("Magic Missile", 1)]
    MagicMissile = 162,

    /// <summary>Lightning bolt cast.</summary>
    [Label("ACT_LIGHTINGBOLT")]
    [Label("Lighting Bolt", 1)]
    LightingBolt = 163,

    /// <summary>Dragon breathe attack.</summary>
    [Label("ACT_DRAGON_BREATHE")]
    [Label("Dragon Breathe", 1)]
    DragonBreathe = 164,

    /// <summary>Breathe prepare stance.</summary>
    [Label("ACT_BREATHE_PREPARE")]
    [Label("Breathe Prepare", 1)]
    BreathePrepare = 165,

    /// <summary>Dragon ice breathe.</summary>
    [Label("ACT_DRAGON_ICE_BREATHE")]
    [Label("Dragon Ice Breathe", 1)]
    DragonIceBreathe = 166,

    /// <summary>Ice breathe prepare.</summary>
    [Label("ACT_ICE_BREATHE_PREPARE")]
    [Label("Ice Breathe Prepare", 1)]
    IceBreathePrepare = 167,

    /// <summary>Blaze attack.</summary>
    [Label("ACT_BLAZE")]
    Blaze = 168,

    /// <summary>Fire circle skill.</summary>
    [Label("ACT_FIRECIRCLE")]
    [Label("Fire Circle", 1)]
    FireCircle = 169,

    /// <summary>Illusion skill.</summary>
    [Label("ACT_ILLUSION")]
    Illusion = 170,

    /// <summary>Magic flare attack.</summary>
    [Label("ACT_MAGICFLARE")]
    [Label("Magic Flare", 1)]
    MagicFlare = 171,

    /// <summary>Elemental reset buff.</summary>
    [Label("ACT_ELEMENTAL_RESET")]
    [Label("Elemental Reset", 1)]
    ElementalReset = 172,

    /// <summary>Magic resistance buff.</summary>
    [Label("ACT_MAGIC_REGISTANCE")]
    [Label("Magic Resistance", 1)]
    MagicResistance = 173,

    /// <summary>Recovery aura buff.</summary>
    [Label("ACT_RECOVERY_AURA")]
    [Label("Recovery Aura", 1)]
    RecoveryAura = 174,

    /// <summary>Magic booster buff.</summary>
    [Label("ACT_MAGIC_BOOSTER")]
    [Label("Magic Booster", 1)]
    MagicBooster = 175,

    /// <summary>Magic shield buff.</summary>
    [Label("ACT_MAGIC_SHIELD")]
    [Label("Magic Shield", 1)]
    MagicShield = 176,

    /// <summary>Flame wheel attack.</summary>
    [Label("ACT_FLAME_WHEEL")]
    [Label("Flame Wheel", 1)]
    FlameWheel = 177,

    /// <summary>Killing wing attack.</summary>
    [Label("ACT_KILLING_WING")]
    [Label("Killing Wing", 1)]
    KillingWing = 178,

    /// <summary>Onyx blessing buff.</summary>
    [Label("ACT_ONIX_BLESSING")]
    [Label("Onix Blessing", 1)]
    OnixBlessing = 179,

    /// <summary>Earthquake attack.</summary>
    [Label("ACT_EARTHQUAKE")]
    Earthquake = 180,

    /// <summary>Soul stone skill.</summary>
    [Label("ACT_SOULSTONE")]
    [Label("Soul Stone", 1)]
    SoulStone = 181,

    /// <summary>Dragon thrust attack.</summary>
    [Label("ACT_DRAGONTHRUST")]
    [Label("Dragon Thrust", 1)]
    DragonThrust = 182,

    /// <summary>Ghost lettering skill.</summary>
    [Label("ACT_GHOST_LETHERING")]
    [Label("Ghost Lethering", 1)]
    GhostLethering = 183,

    /// <summary>Dark fog skill.</summary>
    [Label("ACT_DARKFOG")]
    [Label("Dark Fog", 1)]
    DarkFog = 184,

    /// <summary>Slow debuff.</summary>
    [Label("ACT_SLOW")]
    Slow = 185,

    /// <summary>Maple hero buff.</summary>
    [Label("ACT_MAPLE_HERO")]
    [Label("Maple Hero", 1)]
    MapleHero = 186,

    /// <summary>Awakening skill.</summary>
    [Label("ACT_AWAKENING")]
    Awakening = 187,

    /// <summary>Flying assaulter dash.</summary>
    [Label("ACT_FLYING_ASSAULTER")]
    [Label("Flying Assaulter", 1)]
    FlyingAssaulter = 188,

    /// <summary>Triple stab attack.</summary>
    [Label("ACT_TRIPLE_STAB")]
    [Label("Triple Stab", 1)]
    TripleStab = 189,

    /// <summary>Fatal blow attack.</summary>
    [Label("ACT_FATAL_BLOW")]
    [Label("Fatal Blow", 1)]
    FatalBlow = 190,

    /// <summary>Slash storm 1.</summary>
    [Label("ACT_SLASH_STORM1")]
    [Label("Slash Storm1", 1)]
    SlashStorm1 = 191,

    /// <summary>Slash storm 2.</summary>
    [Label("ACT_SLASH_STORM2")]
    [Label("Slash Storm2", 1)]
    SlashStorm2 = 192,

    /// <summary>Slash storm 3.</summary>
    [Label("ACT_SLASH_STORM3")]
    [Label("Slash Storm3", 1)]
    SlashStorm3 = 193,

    /// <summary>Flash bang skill.</summary>
    [Label("ACT_FLASH_BANG")]
    [Label("Flash Bang", 1)]
    FlashBang = 194,

    /// <summary>Upper stab attack.</summary>
    [Label("ACT_UPPER_STAB")]
    [Label("Upper Stab", 1)]
    UpperStab = 195,

    /// <summary>Owl death pose.</summary>
    [Label("ACT_OWL_DEAD")]
    [Label("Owl Dead", 1)]
    OwlDead = 196,

    /// <summary>Chain pull attack.</summary>
    [Label("ACT_CHAIN_PULL")]
    [Label("Chain Pull", 1)]
    ChainPull = 197,

    /// <summary>Chain attack.</summary>
    [Label("ACT_CHAIN_ATTACK")]
    [Label("Chain Attack", 1)]
    ChainAttack = 198,

    /// <summary>Sudden death attack.</summary>
    [Label("ACT_SUDDEN_DEATH")]
    [Label("Sudden Death", 1)]
    SuddenDeath = 199,

    /// <summary>Monster bomb prepare.</summary>
    [Label("ACT_MONSTER_BOMB_PREPARE")]
    [Label("Monster Bomb Prepare", 1)]
    MonsterBombPrepare = 200,

    /// <summary>Monster bomb throw.</summary>
    [Label("ACT_MONSTER_BOMB_THROW")]
    [Label("Monster Bomb Throw", 1)]
    MonsterBombThrow = 201,

    /// <summary>Final cut attack.</summary>
    [Label("ACT_FINAL_CUT")]
    [Label("Final Cut", 1)]
    FinalCut = 202,

    /// <summary>Final cut prepare.</summary>
    [Label("ACT_FINAL_CUT_PREPARE")]
    [Label("Final Cut Prepare", 1)]
    FinalCutPrepare = 203,

    /// <summary>Cyclone prepare.</summary>
    [Label("ACT_CYCLONE_PRE")]
    [Label("Cyclone Pre", 1)]
    CyclonePre = 204,

    /// <summary>Cyclone attack.</summary>
    [Label("ACT_CYCLONE")]
    Cyclone = 205,

    /// <summary>Cyclone aftermath.</summary>
    [Label("ACT_CYCLONE_AFTER")]
    [Label("Cyclone After", 1)]
    CycloneAfter = 206,

    /// <summary>Double jump.</summary>
    [Label("ACT_DOUBLEJUMP")]
    [Label("Double Jump", 1)]
    DoubleJump = 207,

    /// <summary>Knockback animation.</summary>
    [Label("ACT_KNOCKBACK")]
    Knockback = 208,

    /// <summary>Rocket booster start.</summary>
    [Label("ACT_ROCKET_BOOSTER_START")]
    [Label("Rocket Booster Start", 1)]
    RocketBoosterStart = 209,

    /// <summary>Rocket booster flight.</summary>
    [Label("ACT_ROCKET_BOOSTER")]
    [Label("Rocket Booster", 1)]
    RocketBooster = 210,

    /// <summary>Rocket booster end.</summary>
    [Label("ACT_ROCKET_BOOSTER_END")]
    [Label("Rocket Booster End", 1)]
    RocketBoosterEnd = 211,

    /// <summary>Cross road attack.</summary>
    [Label("ACT_CROSS_ROAD")]
    [Label("Cross Road", 1)]
    CrossRoad = 212,

    /// <summary>Nemesis attack.</summary>
    [Label("ACT_NEMESIS")]
    Nemesis = 213,

    /// <summary>Wild beast attack.</summary>
    [Label("ACT_WILDBEAST")]
    [Label("Wild Beast", 1)]
    WildBeast = 214,

    /// <summary>Siege mode 1 start.</summary>
    [Label("ACT_SIEGE1_START")]
    Siege1Start = 215,

    /// <summary>Siege mode 1 fire.</summary>
    [Label("ACT_SIEGE1")]
    Siege1 = 216,

    /// <summary>Siege mode 1 stand.</summary>
    [Label("ACT_SIEGE1_STAND")]
    Siege1Stand = 217,

    /// <summary>Siege mode 1 end.</summary>
    [Label("ACT_SIEGE1_END")]
    Siege1End = 218,

    /// <summary>Siege mode 2 start.</summary>
    [Label("ACT_SIEGE2_START")]
    Siege2Start = 219,

    /// <summary>Siege mode 2 fire.</summary>
    [Label("ACT_SIEGE2")]
    Siege2 = 220,

    /// <summary>Siege mode 2 stand.</summary>
    [Label("ACT_SIEGE2_STAND")]
    Siege2Stand = 221,

    /// <summary>Siege mode 2 end.</summary>
    [Label("ACT_SIEGE2_END")]
    Siege2End = 222,

    /// <summary>Siege mode 2 walk.</summary>
    [Label("ACT_SIEGE2_WALK")]
    Siege2Walk = 223,

    /// <summary>Siege mode 2 laser.</summary>
    [Label("ACT_SIEGE2_LASER")]
    Siege2Laser = 224,

    /// <summary>Siege mode start.</summary>
    [Label("ACT_SIEGE_START")]
    [Label("Siege Start", 1)]
    SiegeStart = 225,

    /// <summary>Siege mode fire.</summary>
    [Label("ACT_SIEGE")]
    Siege = 226,

    /// <summary>Siege mode stand.</summary>
    [Label("ACT_SIEGE_STAND")]
    [Label("Siege Stand", 1)]
    SiegeStand = 227,

    /// <summary>Siege mode end.</summary>
    [Label("ACT_SIEGE_END")]
    [Label("Siege End", 1)]
    SiegeEnd = 228,

    /// <summary>Sonic boom attack.</summary>
    [Label("ACT_SONICBOOM")]
    [Label("Sonic Boom", 1)]
    SonicBoom = 229,

    /// <summary>Revive animation.</summary>
    [Label("ACT_REVIVE")]
    Revive = 230,

    /// <summary>Dark spear attack.</summary>
    [Label("ACT_DARK_SPEAR")]
    [Label("Dark Spear", 1)]
    DarkSpear = 231,

    /// <summary>Dark chain attack.</summary>
    [Label("ACT_DARK_CHAIN")]
    [Label("Dark Chain", 1)]
    DarkChain = 232,

    /// <summary>Flamethrower start.</summary>
    [Label("ACT_FLAMETHROWER_START")]
    [Label("Flamethrower Start", 1)]
    FlamethrowerStart = 233,

    /// <summary>Flamethrower attack.</summary>
    [Label("ACT_FLAMETHROWER")]
    Flamethrower = 234,

    /// <summary>Flamethrower end.</summary>
    [Label("ACT_FLAMETHROWER_END")]
    [Label("Flamethrower End", 1)]
    FlamethrowerEnd = 235,

    /// <summary>Flamethrower 2 start.</summary>
    [Label("ACT_FLAMETHROWER2_START")]
    Flamethrower2Start = 236,

    /// <summary>Flamethrower 2 attack.</summary>
    [Label("ACT_FLAMETHROWER2")]
    Flamethrower2 = 237,

    /// <summary>Flamethrower 2 end.</summary>
    [Label("ACT_FLAMETHROWER2_END")]
    Flamethrower2End = 238,

    /// <summary>Mechanic booster buff.</summary>
    [Label("ACT_MECHANIC_BOOSTER")]
    [Label("Mechanic Booster", 1)]
    MechanicBooster = 239,

    /// <summary>Mechanic summon.</summary>
    [Label("ACT_MSUMMON")]
    MSummon = 240,

    /// <summary>Mechanic summon 2.</summary>
    [Label("ACT_MSUMMON2")]
    MSummon2 = 241,

    /// <summary>Gatling shot attack.</summary>
    [Label("ACT_GATLINGSHOT")]
    [Label("Gatling Shot", 1)]
    GatlingShot = 242,

    /// <summary>Gatling shot 2.</summary>
    [Label("ACT_GATLINGSHOT2")]
    [Label("Gatling Shot2", 1)]
    GatlingShot2 = 243,

    /// <summary>Drill rush attack.</summary>
    [Label("ACT_DRILLRUSH")]
    [Label("Drill Rush", 1)]
    DrillRush = 244,

    /// <summary>Earth slug attack.</summary>
    [Label("ACT_EARTHSLUG")]
    [Label("Earth Slug", 1)]
    EarthSlug = 245,

    /// <summary>Rocket punch attack.</summary>
    [Label("ACT_ROCKET_PUNCH")]
    [Label("Rocket Punch", 1)]
    RocketPunch = 246,

    /// <summary>Claw cut attack.</summary>
    [Label("ACT_CLAW_CUT")]
    [Label("Claw Cut", 1)]
    ClawCut = 247,

    /// <summary>Swallow capture.</summary>
    [Label("ACT_SWALLOW")]
    Swallow = 248,

    /// <summary>Swallow loop.</summary>
    [Label("ACT_SWALLOW_LOOP")]
    [Label("Swallow Loop", 1)]
    SwallowLoop = 249,

    /// <summary>Swallow attack.</summary>
    [Label("ACT_SWALLOW_ATTACK")]
    [Label("Swallow Attack", 1)]
    SwallowAttack = 250,

    /// <summary>Swallow prepare.</summary>
    [Label("ACT_SWALLOW_PRE")]
    [Label("Swallow Pre", 1)]
    SwallowPre = 251,

    /// <summary>Flash rain attack.</summary>
    [Label("ACT_FLASH_RAIN")]
    [Label("Flash Rain", 1)]
    FlashRain = 252,

    /// <summary>Mine deploy.</summary>
    [Label("ACT_MINE")]
    Mine = 253,

    /// <summary>Capture skill.</summary>
    [Label("ACT_CAPTURE")]
    Capture = 254,

    /// <summary>Mount ride.</summary>
    [Label("ACT_RIDE")]
    Ride = 255,

    /// <summary>Mount dismount.</summary>
    [Label("ACT_GETOFF")]
    [Label("Get Off", 1)]
    GetOff = 256,

    /// <summary>Mount ride 2.</summary>
    [Label("ACT_RIDE2")]
    Ride2 = 257,

    /// <summary>Mount dismount 2.</summary>
    [Label("ACT_GETOFF2")]
    [Label("Get Off2", 1)]
    GetOff2 = 258,

    /// <summary>Mechanic rush.</summary>
    [Label("ACT_MECHANIC_RUSH")]
    [Label("Mechanic Rush", 1)]
    MechanicRush = 259,

    /// <summary>Tank mech summon.</summary>
    [Label("ACT_TANK_MSUMMON")]
    [Label("Tank MSummon", 1)]
    TankMSummon = 260,

    /// <summary>Tank mech summon 2.</summary>
    [Label("ACT_TANK_MSUMMON2")]
    [Label("Tank MSummon2", 1)]
    TankMSummon2 = 261,

    /// <summary>Tank mech rush.</summary>
    [Label("ACT_TANK_MRUSH")]
    [Label("Tank MRush", 1)]
    TankMRush = 262,

    /// <summary>Tank booster prepare.</summary>
    [Label("ACT_TANK_RBOOSTER_PRE")]
    [Label("Tank RBooster Pre", 1)]
    TankRBoosterPre = 263,

    /// <summary>Tank booster end.</summary>
    [Label("ACT_TANK_RBOOSTER_AFTER")]
    [Label("Tank RBooster After", 1)]
    TankRBoosterAfter = 264,

    /// <summary>Shock wave attack.</summary>
    [Label("ACT_SHOCKWAVE")]
    [Label("Shock Wave", 1)]
    ShockWave = 265,

    /// <summary>Demolition attack.</summary>
    [Label("ACT_DEMOLITION")]
    Demolition = 266,

    /// <summary>Snatch grab.</summary>
    [Label("ACT_SNATCH")]
    Snatch = 267,

    /// <summary>Wind spear attack.</summary>
    [Label("ACT_WIND_SPEAR")]
    [Label("Wind Spear", 1)]
    WindSpear = 268,

    /// <summary>Wind shot attack.</summary>
    [Label("ACT_WIND_SHOT")]
    [Label("Wind Shot", 1)]
    WindShot = 269,

    /// <summary>Flying animation 2.</summary>
    [Label("ACT_FLY2")]
    Fly2 = 270,

    /// <summary>Flying move 2.</summary>
    [Label("ACT_FLY2_MOVE")]
    Fly2Move = 271,

    /// <summary>Flying skill 2.</summary>
    [Label("ACT_FLY2_SKILL")]
    Fly2Skill = 272,

    /// <summary>No action.</summary>
    [Label("ACT_NO")]
    No = 273,
}
