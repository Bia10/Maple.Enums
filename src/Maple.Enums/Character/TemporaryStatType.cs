using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character temporary stat (buff/debuff) bit position index.
/// </summary>
public enum TemporaryStatType : byte
{
    /// <summary>Physical attack boost.</summary>
    [Label("CTS_PAD")]
    PAD = 0,

    /// <summary>Physical defense boost.</summary>
    [Label("CTS_PDD")]
    PDD = 1,

    /// <summary>Magic attack boost.</summary>
    [Label("CTS_MAD")]
    MAD = 2,

    /// <summary>Magic defense boost.</summary>
    [Label("CTS_MDD")]
    MDD = 3,

    /// <summary>Accuracy boost.</summary>
    [Label("CTS_ACC")]
    ACC = 4,

    /// <summary>Evasion boost.</summary>
    [Label("CTS_EVA")]
    EVA = 5,

    /// <summary>Craft/hands boost.</summary>
    [Label("CTS_Craft")]
    Craft = 6,

    /// <summary>Movement speed boost.</summary>
    [Label("CTS_Speed")]
    Speed = 7,

    /// <summary>Jump height boost.</summary>
    [Label("CTS_Jump")]
    Jump = 8,

    /// <summary>MP absorbs damage.</summary>
    [Label("CTS_MagicGuard")]
    [Label("Magic Guard", 1)]
    MagicGuard = 9,

    /// <summary>Rogue invisibility.</summary>
    [Label("CTS_DarkSight")]
    [Label("Dark Sight", 1)]
    DarkSight = 10,

    /// <summary>Attack speed boost.</summary>
    [Label("CTS_Booster")]
    Booster = 11,

    /// <summary>Reflects damage taken.</summary>
    [Label("CTS_PowerGuard")]
    [Label("Power Guard", 1)]
    PowerGuard = 12,

    /// <summary>Max HP boost.</summary>
    [Label("CTS_MaxHP")]
    [Label("Max HP", 1)]
    MaxHP = 13,

    /// <summary>Max MP boost.</summary>
    [Label("CTS_MaxMP")]
    [Label("Max MP", 1)]
    MaxMP = 14,

    /// <summary>Damage immunity.</summary>
    [Label("CTS_Invincible")]
    Invincible = 15,

    /// <summary>No ammo consumption.</summary>
    [Label("CTS_SoulArrow")]
    [Label("Soul Arrow", 1)]
    SoulArrow = 16,

    /// <summary>Stun debuff.</summary>
    [Label("CTS_Stun")]
    Stun = 17,

    /// <summary>Poison DoT debuff.</summary>
    [Label("CTS_Poison")]
    Poison = 18,

    /// <summary>Skill seal debuff.</summary>
    [Label("CTS_Seal")]
    Seal = 19,

    /// <summary>Darkness accuracy debuff.</summary>
    [Label("CTS_Darkness")]
    Darkness = 20,

    /// <summary>Combo attack counter.</summary>
    [Label("CTS_ComboCounter")]
    [Label("Combo Counter", 1)]
    ComboCounter = 21,

    /// <summary>Elemental weapon charge.</summary>
    [Label("CTS_WeaponCharge")]
    [Label("Weapon Charge", 1)]
    WeaponCharge = 22,

    /// <summary>ATK up, HP drain.</summary>
    [Label("CTS_DragonBlood")]
    [Label("Dragon Blood", 1)]
    DragonBlood = 23,

    /// <summary>EXP gain boost.</summary>
    [Label("CTS_HolySymbol")]
    [Label("Holy Symbol", 1)]
    HolySymbol = 24,

    /// <summary>Meso drop boost.</summary>
    [Label("CTS_MesoUp")]
    [Label("Meso Up", 1)]
    MesoUp = 25,

    /// <summary>Shadow clone attacks.</summary>
    [Label("CTS_ShadowPartner")]
    [Label("Shadow Partner", 1)]
    ShadowPartner = 26,

    /// <summary>Drops meso on hit.</summary>
    [Label("CTS_PickPocket")]
    [Label("Pick Pocket", 1)]
    PickPocket = 27,

    /// <summary>Meso absorbs damage.</summary>
    [Label("CTS_MesoGuard")]
    [Label("Meso Guard", 1)]
    MesoGuard = 28,

    /// <summary>Freeze immunity.</summary>
    [Label("CTS_Thaw")]
    Thaw = 29,

    /// <summary>Weakness debuff.</summary>
    [Label("CTS_Weakness")]
    Weakness = 30,

    /// <summary>Curse EXP debuff.</summary>
    [Label("CTS_Curse")]
    Curse = 31,

    /// <summary>Movement slow debuff.</summary>
    [Label("CTS_Slow")]
    Slow = 32,

    /// <summary>Transform appearance.</summary>
    [Label("CTS_Morph")]
    Morph = 33,

    /// <summary>HP regeneration.</summary>
    [Label("CTS_Regen")]
    Regen = 34,

    /// <summary>Base stats boost.</summary>
    [Label("CTS_BasicStatUp")]
    [Label("Basic Stat Up", 1)]
    BasicStatUp = 35,

    /// <summary>Knockback resistance.</summary>
    [Label("CTS_Stance")]
    Stance = 36,

    /// <summary>Critical rate boost.</summary>
    [Label("CTS_SharpEyes")]
    [Label("Sharp Eyes", 1)]
    SharpEyes = 37,

    /// <summary>Reflects magic damage.</summary>
    [Label("CTS_ManaReflection")]
    [Label("Mana Reflection", 1)]
    ManaReflection = 38,

    /// <summary>Monster lure effect.</summary>
    [Label("CTS_Attract")]
    Attract = 39,

    /// <summary>Unlimited throwing stars.</summary>
    [Label("CTS_SpiritJavelin")]
    [Label("Spirit Javelin", 1)]
    SpiritJavelin = 40,

    /// <summary>Infinite MP usage.</summary>
    [Label("CTS_Infinity")]
    Infinity = 41,

    /// <summary>Abnormal status resist.</summary>
    /// <remarks>Documented original client typo: "CTS_Holyshield" (lowercase 's'); see typos.md.</remarks>
    [Label("CTS_Holyshield")]
    [Label("Holy Shield", 1)]
    HolyShield = 42,

    /// <summary>Slows enemy movement.</summary>
    [Label("CTS_HamString")]
    [Label("Ham String", 1)]
    HamString = 43,

    /// <summary>Lowers enemy accuracy.</summary>
    [Label("CTS_Blind")]
    Blind = 44,

    /// <summary>MP efficiency boost.</summary>
    [Label("CTS_Concentration")]
    Concentration = 45,

    /// <summary>Map entry ban.</summary>
    [Label("CTS_BanMap")]
    [Label("Ban Map", 1)]
    BanMap = 46,

    /// <summary>Skill level cap boost.</summary>
    [Label("CTS_MaxLevelBuff")]
    [Label("Max Level Buff", 1)]
    MaxLevelBuff = 47,

    /// <summary>Item meso drop boost.</summary>
    [Label("CTS_MesoUpByItem")]
    [Label("Meso Up By Item", 1)]
    MesoUpByItem = 48,

    /// <summary>Ghost morph state.</summary>
    [Label("CTS_Ghost")]
    Ghost = 49,

    /// <summary>Damage barrier shield.</summary>
    [Label("CTS_Barrier")]
    Barrier = 50,

    /// <summary>Controls reversed debuff.</summary>
    [Label("CTS_ReverseInput")]
    [Label("Reverse Input", 1)]
    ReverseInput = 51,

    /// <summary>Item drop rate boost.</summary>
    [Label("CTS_ItemUpByItem")]
    [Label("Item Up By Item", 1)]
    ItemUpByItem = 52,

    /// <summary>Ignore physical immunity.</summary>
    [Label("CTS_RespectPImmune")]
    [Label("Respect PImmune", 1)]
    RespectPImmune = 53,

    /// <summary>Ignore magic immunity.</summary>
    [Label("CTS_RespectMImmune")]
    [Label("Respect MImmune", 1)]
    RespectMImmune = 54,

    /// <summary>Defense attack mode.</summary>
    [Label("CTS_DefenseAtt")]
    [Label("Defense Att", 1)]
    DefenseAtt = 55,

    /// <summary>Defense stance mode.</summary>
    [Label("CTS_DefenseState")]
    [Label("Defense State", 1)]
    DefenseState = 56,

    /// <summary>HP potion effect boost.</summary>
    [Label("CTS_IncEffectHPPotion")]
    [Label("Inc Effect HP Potion", 1)]
    IncEffectHPPotion = 57,

    /// <summary>MP potion effect boost.</summary>
    [Label("CTS_IncEffectMPPotion")]
    [Label("Inc Effect MP Potion", 1)]
    IncEffectMPPotion = 58,

    /// <summary>Dojo berserk boost.</summary>
    [Label("CTS_DojangBerserk")]
    [Label("Dojang Berserk", 1)]
    DojangBerserk = 59,

    /// <summary>Dojo invincibility.</summary>
    [Label("CTS_DojangInvincible")]
    [Label("Dojang Invincible", 1)]
    DojangInvincible = 60,

    /// <summary>Thunder Breaker spark.</summary>
    [Label("CTS_Spark")]
    Spark = 61,

    /// <summary>Dojo shield buff.</summary>
    [Label("CTS_DojangShield")]
    [Label("Dojang Shield", 1)]
    DojangShield = 62,

    /// <summary>Dawn Warrior final attack.</summary>
    [Label("CTS_SoulMasterFinal")]
    [Label("Soul Master Final", 1)]
    SoulMasterFinal = 63,

    /// <summary>Wind Archer final attack.</summary>
    [Label("CTS_WindBreakerFinal")]
    [Label("Wind Breaker Final", 1)]
    WindBreakerFinal = 64,

    /// <summary>Element resistance reset.</summary>
    [Label("CTS_ElementalReset")]
    [Label("Elemental Reset", 1)]
    ElementalReset = 65,

    /// <summary>Wind Walk invisibility.</summary>
    [Label("CTS_WindWalk")]
    [Label("Wind Walk", 1)]
    WindWalk = 66,

    /// <summary>Event drop rate boost.</summary>
    [Label("CTS_EventRate")]
    [Label("Event Rate", 1)]
    EventRate = 67,

    /// <summary>Aran combo stat buff.</summary>
    [Label("CTS_ComboAbilityBuff")]
    [Label("Combo Ability Buff", 1)]
    ComboAbilityBuff = 68,

    /// <summary>Aran combo HP drain.</summary>
    [Label("CTS_ComboDrain")]
    [Label("Combo Drain", 1)]
    ComboDrain = 69,

    /// <summary>Aran combo barrier.</summary>
    [Label("CTS_ComboBarrier")]
    [Label("Combo Barrier", 1)]
    ComboBarrier = 70,

    /// <summary>Aran body pressure.</summary>
    [Label("CTS_BodyPressure")]
    [Label("Body Pressure", 1)]
    BodyPressure = 71,

    /// <summary>Enhanced knockback.</summary>
    [Label("CTS_SmartKnockback")]
    [Label("Smart Knockback", 1)]
    SmartKnockback = 72,

    /// <summary>Buff repeat effect.</summary>
    [Label("CTS_RepeatEffect")]
    [Label("Repeat Effect", 1)]
    RepeatEffect = 73,

    /// <summary>EXP buff multiplier.</summary>
    [Label("CTS_ExpBuffRate")]
    [Label("Exp Buff Rate", 1)]
    ExpBuffRate = 74,

    /// <summary>Potion use disabled.</summary>
    /// <remarks>Documented original client typo: "CTS_StopPortion" → "CTS_StopPotion"; see typos.md.</remarks>
    [Label("CTS_StopPortion")]
    [Label("Stop Potion", 1)]
    StopPotion = 75,

    /// <summary>Movement disabled.</summary>
    [Label("CTS_StopMotion")]
    [Label("Stop Motion", 1)]
    StopMotion = 76,

    /// <summary>Fear debuff.</summary>
    [Label("CTS_Fear")]
    Fear = 77,

    /// <summary>Evan slow debuff.</summary>
    [Label("CTS_EvanSlow")]
    [Label("Evan Slow", 1)]
    EvanSlow = 78,

    /// <summary>Magic damage shield.</summary>
    [Label("CTS_MagicShield")]
    [Label("Magic Shield", 1)]
    MagicShield = 79,

    /// <summary>Magic resistance boost.</summary>
    [Label("CTS_MagicResistance")]
    [Label("Magic Resistance", 1)]
    MagicResistance = 80,

    /// <summary>Revive on death.</summary>
    [Label("CTS_SoulStone")]
    [Label("Soul Stone", 1)]
    SoulStone = 81,

    /// <summary>Flight enabled.</summary>
    [Label("CTS_Flying")]
    Flying = 82,

    /// <summary>Frozen debuff.</summary>
    [Label("CTS_Frozen")]
    Frozen = 83,

    /// <summary>Assist charge buff.</summary>
    [Label("CTS_AssistCharge")]
    [Label("Assist Charge", 1)]
    AssistCharge = 84,

    /// <summary>Enrage damage boost.</summary>
    [Label("CTS_Enrage")]
    Enrage = 85,

    /// <summary>Instant death debuff.</summary>
    [Label("CTS_SuddenDeath")]
    [Label("Sudden Death", 1)]
    SuddenDeath = 86,

    /// <summary>Damage immunity state.</summary>
    [Label("CTS_NotDamaged")]
    [Label("Not Damaged", 1)]
    NotDamaged = 87,

    /// <summary>Dual Blade final cut.</summary>
    [Label("CTS_FinalCut")]
    [Label("Final Cut", 1)]
    FinalCut = 88,

    /// <summary>Damage reflect thorns.</summary>
    [Label("CTS_ThornsEffect")]
    [Label("Thorns Effect", 1)]
    ThornsEffect = 89,

    /// <summary>Swallow attack boost.</summary>
    [Label("CTS_SwallowAttackDamage")]
    [Label("Swallow Attack Damage", 1)]
    SwallowAttackDamage = 90,

    /// <summary>Wild Hunter damage up.</summary>
    [Label("CTS_MorewildDamageUp")]
    [Label("Morewild Damage Up", 1)]
    MorewildDamageUp = 91,

    /// <summary>Mine placement.</summary>
    [Label("CTS_Mine")]
    Mine = 92,

    /// <summary>Enhanced max HP.</summary>
    [Label("CTS_EMHP")]
    EMHP = 93,

    /// <summary>Enhanced max MP.</summary>
    [Label("CTS_EMMP")]
    EMMP = 94,

    /// <summary>Enhanced physical attack.</summary>
    [Label("CTS_EPAD")]
    EPAD = 95,

    /// <summary>Enhanced physical defense.</summary>
    [Label("CTS_EPDD")]
    EPDD = 96,

    /// <summary>Enhanced magic defense.</summary>
    [Label("CTS_EMDD")]
    EMDD = 97,

    /// <summary>Guard stance.</summary>
    [Label("CTS_Guard")]
    Guard = 98,

    /// <summary>Safety damage cap.</summary>
    [Label("CTS_SafetyDamage")]
    [Label("Safety Damage", 1)]
    SafetyDamage = 99,

    /// <summary>Safety damage absorb.</summary>
    [Label("CTS_SafetyAbsorb")]
    [Label("Safety Absorb", 1)]
    SafetyAbsorb = 100,

    /// <summary>Aran cyclone spin.</summary>
    [Label("CTS_Cyclone")]
    Cyclone = 101,

    /// <summary>Swallow critical boost.</summary>
    [Label("CTS_SwallowCritical")]
    [Label("Swallow Critical", 1)]
    SwallowCritical = 102,

    /// <summary>Swallow max MP boost.</summary>
    [Label("CTS_SwallowMaxMP")]
    [Label("Swallow Max MP", 1)]
    SwallowMaxMP = 103,

    /// <summary>Swallow defense boost.</summary>
    [Label("CTS_SwallowDefence")]
    [Label("Swallow Defence", 1)]
    SwallowDefence = 104,

    /// <summary>Swallow evasion boost.</summary>
    [Label("CTS_SwallowEvasion")]
    [Label("Swallow Evasion", 1)]
    SwallowEvasion = 105,

    /// <summary>HP/MP conversion.</summary>
    [Label("CTS_Conversion")]
    Conversion = 106,

    /// <summary>Auto revive buff.</summary>
    [Label("CTS_Revive")]
    Revive = 107,

    /// <summary>Stealth mode.</summary>
    [Label("CTS_Sneak")]
    Sneak = 108,

    /// <summary>Mechanic mount mode.</summary>
    [Label("CTS_Mechanic")]
    Mechanic = 109,

    /// <summary>Aura buff active.</summary>
    [Label("CTS_Aura")]
    Aura = 110,

    /// <summary>Dark aura attack buff.</summary>
    [Label("CTS_DarkAura")]
    [Label("Dark Aura", 1)]
    DarkAura = 111,

    /// <summary>Blue aura defense buff.</summary>
    [Label("CTS_BlueAura")]
    [Label("Blue Aura", 1)]
    BlueAura = 112,

    /// <summary>Yellow aura speed buff.</summary>
    [Label("CTS_YellowAura")]
    [Label("Yellow Aura", 1)]
    YellowAura = 113,

    /// <summary>Abnormal status immunity.</summary>
    [Label("CTS_SuperBody")]
    [Label("Super Body", 1)]
    SuperBody = 114,

    /// <summary>Wild Hunter max HP.</summary>
    [Label("CTS_MorewildMaxHP")]
    [Label("Morewild Max HP", 1)]
    MorewildMaxHP = 115,

    /// <summary>Corsair dice buff.</summary>
    [Label("CTS_Dice")]
    Dice = 116,

    /// <summary>Blessing armor buff.</summary>
    [Label("CTS_BlessingArmor")]
    [Label("Blessing Armor", 1)]
    BlessingArmor = 117,

    /// <summary>Damage rate boost.</summary>
    [Label("CTS_DamR")]
    [Label("Dam R", 1)]
    DamR = 118,

    /// <summary>Teleport mastery active.</summary>
    [Label("CTS_TeleportMasteryOn")]
    [Label("Teleport Mastery On", 1)]
    TeleportMasteryOn = 119,

    /// <summary>Skill level boost.</summary>
    [Label("CTS_CombatOrders")]
    [Label("Combat Orders", 1)]
    CombatOrders = 120,

    /// <summary>Dark Knight beholder.</summary>
    [Label("CTS_Beholder")]
    Beholder = 121,

    /// <summary>Energy charge state.</summary>
    [Label("CTS_EnergyCharged")]
    [Label("Energy Charged", 1)]
    EnergyCharged = 122,

    /// <summary>Dash speed boost.</summary>
    [Label("CTS_Dash_Speed")]
    [Label("Dash Speed", 1)]
    DashSpeed = 123,

    /// <summary>Dash jump boost.</summary>
    [Label("CTS_Dash_Jump")]
    [Label("Dash Jump", 1)]
    DashJump = 124,

    /// <summary>Mount ride active.</summary>
    [Label("CTS_RideVehicle")]
    [Label("Ride Vehicle", 1)]
    RideVehicle = 125,

    /// <summary>Party speed boost.</summary>
    [Label("CTS_PartyBooster")]
    [Label("Party Booster", 1)]
    PartyBooster = 126,

    /// <summary>Homing bullet active.</summary>
    [Label("CTS_GuidedBullet")]
    [Label("Guided Bullet", 1)]
    GuidedBullet = 127,

    /// <summary>Undead debuff state.</summary>
    [Label("CTS_Undead")]
    Undead = 128,

    /// <summary>Summon bomb active.</summary>
    [Label("CTS_SummonBomb")]
    [Label("Summon Bomb", 1)]
    SummonBomb = 129,
}
