using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Type of movement fragment in a CMovePath movement packet.</summary>
public enum MovePathFragmentType : byte
{
    /// <summary>Standard ground movement.</summary>
    Normal = 0,

    /// <summary>Jump movement.</summary>
    Jump = 1,

    /// <summary>Knockback impact movement.</summary>
    Impact = 2,

    /// <summary>Instant position update.</summary>
    Immediate = 3,

    /// <summary>Teleport movement.</summary>
    Teleport = 4,

    /// <summary>Hanging on a rope or ladder from the back.</summary>
    [Label("Hang On Back", 1)]
    HangOnBack = 5,

    /// <summary>Assaulter skill movement.</summary>
    Assaulter = 6,

    /// <summary>Assassination skill movement.</summary>
    Assassination = 7,

    /// <summary>Rush skill movement.</summary>
    Rush = 8,

    /// <summary>Stat change notification (no positional movement).</summary>
    [Label("Stat Change", 1)]
    StatChange = 9,

    /// <summary>Begin falling down.</summary>
    [Label("Start Fall Down", 1)]
    StartFallDown = 10,

    /// <summary>Falling down in progress.</summary>
    [Label("Fall Down", 1)]
    FallDown = 11,

    /// <summary>Begin wings/glide mode.</summary>
    [Label("Start Wings", 1)]
    StartWings = 12,

    /// <summary>Wings/glide mode in progress.</summary>
    Wings = 13,

    /// <summary>Aran combo position adjustment.</summary>
    [Label("Aran Adjust", 1)]
    AranAdjust = 14,

    /// <summary>Mob toss knockback movement.</summary>
    [Label("Mob Toss", 1)]
    MobToss = 15,

    /// <summary>Flying block movement.</summary>
    [Label("Flying Block", 1)]
    FlyingBlock = 16,

    /// <summary>Dash slide movement.</summary>
    [Label("Dash Slide", 1)]
    DashSlide = 17,

    /// <summary>Battle Mage position adjustment.</summary>
    [Label("BMage Adjust", 1)]
    BmageAdjust = 18,

    /// <summary>Flash Jump skill movement.</summary>
    [Label("Flash Jump", 1)]
    FlashJump = 19,

    /// <summary>Mechanic Rocket Booster movement.</summary>
    [Label("Rocket Booster", 1)]
    RocketBooster = 20,

    /// <summary>Backstep Shot skill movement.</summary>
    [Label("Back Step Shot", 1)]
    BackStepShot = 21,

    /// <summary>Mob power knockback movement.</summary>
    [Label("Mob Power Knock Back", 1)]
    MobPowerKnockBack = 22,

    /// <summary>Vertical jump movement.</summary>
    [Label("Vertical Jump", 1)]
    VerticalJump = 23,

    /// <summary>Custom impact movement.</summary>
    [Label("Custom Impact", 1)]
    CustomImpact = 24,

    /// <summary>Combat Step skill movement.</summary>
    [Label("Combat Step", 1)]
    CombatStep = 25,

    /// <summary>Hit reaction movement.</summary>
    Hit = 26,

    /// <summary>Time Bomb attack movement.</summary>
    [Label("Time Bomb Attack", 1)]
    TimeBombAttack = 27,

    /// <summary>Snowball touch event movement.</summary>
    [Label("Snowball Touch", 1)]
    SnowballTouch = 28,

    /// <summary>Buff zone effect trigger.</summary>
    [Label("Buff Zone Effect", 1)]
    BuffZoneEffect = 29,

    /// <summary>Mob ladder climbing movement.</summary>
    [Label("Mob Ladder", 1)]
    MobLadder = 30,

    /// <summary>Mob right-angle turn movement.</summary>
    [Label("Mob Right Angle", 1)]
    MobRightAngle = 31,

    /// <summary>Mob stop-node start movement.</summary>
    [Label("Mob Stop Node Start", 1)]
    MobStopNodeStart = 32,

    /// <summary>Mob before-node movement.</summary>
    [Label("Mob Before Node", 1)]
    MobBeforeNode = 33,

    /// <summary>Mob attack rush movement.</summary>
    [Label("Mob Attack Rush", 1)]
    MobAttackRush = 34,

    /// <summary>Mob attack rush stop movement.</summary>
    [Label("Mob Attack Rush Stop", 1)]
    MobAttackRushStop = 35,
}
