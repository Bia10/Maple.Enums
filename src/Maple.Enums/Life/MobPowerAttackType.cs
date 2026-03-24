using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob power attack / movement action type.
/// Describes the movement behavior when receiving or executing different attack types.
/// </summary>
public enum MobPowerAttackType : byte
{
    /// <summary>Normal movement action.</summary>
    [Label("MPA_NORMAL")]
    Normal = 0,

    /// <summary>Jump movement action.</summary>
    [Label("MPA_JUMP")]
    Jump = 1,

    /// <summary>Impact knockback movement.</summary>
    [Label("MPA_IMPACT")]
    Impact = 2,

    /// <summary>Immediate/instant displacement.</summary>
    [Label("MPA_IMMEDIATE")]
    Immediate = 3,

    /// <summary>Teleport to a new position.</summary>
    [Label("MPA_TELEPORT")]
    Teleport = 4,

    /// <summary>Hang on the back of the mob.</summary>
    [Label("MPA_HANGONBACK")]
    [Label("Hang On Back", 1)]
    HangOnBack = 5,

    /// <summary>Assaulter skill dash movement.</summary>
    [Label("MPA_ASSAULTER")]
    Assaulter = 6,

    /// <summary>Assassination skill lunge movement.</summary>
    [Label("MPA_ASSASSINATION")]
    Assassination = 7,

    /// <summary>Rush skill charge movement.</summary>
    [Label("MPA_RUSH")]
    Rush = 8,

    /// <summary>Stat change triggered movement.</summary>
    [Label("MPA_STATCHANGE")]
    [Label("Stat Change", 1)]
    StatChange = 9,

    /// <summary>Sit down action.</summary>
    [Label("MPA_SITDOWN")]
    [Label("Sit Down", 1)]
    SitDown = 10,

    /// <summary>Begin falling down.</summary>
    [Label("MPA_STARTFALLDOWN")]
    [Label("Start Fall Down", 1)]
    StartFallDown = 11,

    /// <summary>Falling down in progress.</summary>
    [Label("MPA_FALLDOWN")]
    [Label("Fall Down", 1)]
    FallDown = 12,

    /// <summary>Begin wing/flight activation.</summary>
    [Label("MPA_STARTWINGS")]
    [Label("Start Wings", 1)]
    StartWings = 13,

    /// <summary>Wing/flight movement in progress.</summary>
    [Label("MPA_WINGS")]
    Wings = 14,

    /// <summary>Aran combo position adjustment.</summary>
    [Label("MPA_ARAN_ADJUST")]
    [Label("Aran Adjust", 1)]
    AranAdjust = 15,

    /// <summary>Mob toss displacement.</summary>
    [Label("MPA_MOB_TOSS")]
    [Label("Mob Toss", 1)]
    MobToss = 16,

    /// <summary>Flying block reaction movement.</summary>
    [Label("MPA_FLYING_BLOCK")]
    [Label("Flying Block", 1)]
    FlyingBlock = 17,

    /// <summary>Dash slide movement.</summary>
    [Label("MPA_DASH_SLIDE")]
    [Label("Dash Slide", 1)]
    DashSlide = 18,

    /// <summary>Battle Mage position adjustment.</summary>
    [Label("MPA_BMAGE_ADJUST")]
    [Label("Bmage Adjust", 1)]
    BmageAdjust = 19,

    /// <summary>Flash Jump movement.</summary>
    [Label("MPA_FLASHJUMP")]
    [Label("Flash Jump", 1)]
    FlashJump = 20,

    /// <summary>Rocket Booster propulsion movement.</summary>
    [Label("MPA_ROCKET_BOOSTER")]
    [Label("Rocket Booster", 1)]
    RocketBooster = 21,

    /// <summary>Backstep Shot recoil movement.</summary>
    [Label("MPA_BACKSTEP_SHOT")]
    [Label("Backstep Shot", 1)]
    BackstepShot = 22,

    /// <summary>Mob power knockback displacement.</summary>
    [Label("MPA_MOBPOWERKNOCKBACK")]
    [Label("Mob Power Knockback", 1)]
    MobPowerKnockback = 23,

    /// <summary>Vertical jump movement.</summary>
    [Label("MPA_VERTICALJUMP")]
    [Label("Vertical Jump", 1)]
    VerticalJump = 24,

    /// <summary>Custom impact displacement.</summary>
    [Label("MPA_CUSTOMIMPACT")]
    [Label("Custom Impact", 1)]
    CustomImpact = 25,

    /// <summary>Combat step movement.</summary>
    [Label("MPA_COMBATSTEP")]
    [Label("Combat Step", 1)]
    CombatStep = 26,

    /// <summary>Hit reaction movement.</summary>
    [Label("MPA_HIT")]
    Hit = 27,

    /// <summary>Time bomb attack displacement.</summary>
    [Label("MPA_TIMEBOMBATTACK")]
    [Label("Time Bomb Attack", 1)]
    TimeBombAttack = 28,

    /// <summary>Snowball touch displacement.</summary>
    [Label("MPA_SNOWBALLTOUCH")]
    [Label("Snowball Touch", 1)]
    SnowballTouch = 29,

    /// <summary>Buff zone effect displacement.</summary>
    [Label("MPA_BUFFZONEEFFECT")]
    [Label("Buff Zone Effect", 1)]
    BuffZoneEffect = 30,

    /// <summary>Mob ladder climbing movement.</summary>
    [Label("MPA_MOB_LADDER")]
    [Label("Mob Ladder", 1)]
    MobLadder = 31,

    /// <summary>Mob right-angle turn movement.</summary>
    [Label("MPA_MOB_RIGHTANGLE")]
    [Label("Mob Right Angle", 1)]
    MobRightAngle = 32,

    /// <summary>Mob stop-node start movement.</summary>
    [Label("MPA_MOB_STOPNODE_START")]
    [Label("Mob Stop Node Start", 1)]
    MobStopNodeStart = 33,

    /// <summary>Mob pre-node movement.</summary>
    [Label("MPA_MOB_BEFORE_NODE")]
    [Label("Mob Before Node", 1)]
    MobBeforeNode = 34,

    /// <summary>Mob attack-rush charge movement.</summary>
    [Label("MPA_MOB_ATTACK_RUSH")]
    [Label("Mob Attack Rush", 1)]
    MobAttackRush = 35,

    /// <summary>Mob attack-rush stop movement.</summary>
    [Label("MPA_MOB_ATTACK_RUSH_STOP")]
    [Label("Mob Attack Rush Stop", 1)]
    MobAttackRushStop = 36,
}
