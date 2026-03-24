using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Well-known boss mob template IDs used by the server for boss encounter logic.
/// </summary>
/// <remarks>
/// The V95 PDB spells Horntail as "Hontail" (numbered parts) and "Hontale" (named parts).
/// Member names and index-0 labels preserve these PDB spellings; index-1 labels carry the
/// corrected "Horntail" display name.
/// </remarks>
public enum BossMobId : int
{
    // ── Zakum ────────────────────────────────────────────────────────────

    /// <summary>Zakum body phase 1.</summary>
    [Label("ZAKUM1_MOB_ID")]
    Zakum1 = 8800000,

    /// <summary>Zakum body phase 2.</summary>
    [Label("ZAKUM2_MOB_ID")]
    Zakum2 = 8800001,

    /// <summary>Zakum body phase 3.</summary>
    [Label("ZAKUM3_MOB_ID")]
    Zakum3 = 8800002,

    /// <summary>Zakum arm 1.</summary>
    [Label("ZAKUMARM1_MOB_ID")]
    [Label("Zakum Arm1", 1)]
    ZakumArm1 = 8800003,

    /// <summary>Zakum arm 2.</summary>
    [Label("ZAKUMARM2_MOB_ID")]
    [Label("Zakum Arm2", 1)]
    ZakumArm2 = 8800004,

    /// <summary>Zakum arm 3.</summary>
    [Label("ZAKUMARM3_MOB_ID")]
    [Label("Zakum Arm3", 1)]
    ZakumArm3 = 8800005,

    /// <summary>Zakum arm 4.</summary>
    [Label("ZAKUMARM4_MOB_ID")]
    [Label("Zakum Arm4", 1)]
    ZakumArm4 = 8800006,

    /// <summary>Zakum arm 5.</summary>
    [Label("ZAKUMARM5_MOB_ID")]
    [Label("Zakum Arm5", 1)]
    ZakumArm5 = 8800007,

    /// <summary>Zakum arm 6.</summary>
    [Label("ZAKUMARM6_MOB_ID")]
    [Label("Zakum Arm6", 1)]
    ZakumArm6 = 8800008,

    /// <summary>Zakum arm 7.</summary>
    [Label("ZAKUMARM7_MOB_ID")]
    [Label("Zakum Arm7", 1)]
    ZakumArm7 = 8800009,

    /// <summary>Zakum arm 8.</summary>
    [Label("ZAKUMARM8_MOB_ID")]
    [Label("Zakum Arm8", 1)]
    ZakumArm8 = 8800010,

    // ── Chaos Zakum ─────────────────────────────────────────────────────

    /// <summary>Chaos Zakum body phase 1.</summary>
    [Label("CHAOSZAKUM1_MOB_ID")]
    [Label("Chaos Zakum1", 1)]
    ChaosZakum1 = 8800100,

    /// <summary>Chaos Zakum body phase 2.</summary>
    [Label("CHAOSZAKUM2_MOB_ID")]
    [Label("Chaos Zakum2", 1)]
    ChaosZakum2 = 8800101,

    /// <summary>Chaos Zakum body phase 3.</summary>
    [Label("CHAOSZAKUM3_MOB_ID")]
    [Label("Chaos Zakum3", 1)]
    ChaosZakum3 = 8800102,

    /// <summary>Chaos Zakum arm 1.</summary>
    [Label("CHAOSZAKUMARM1_MOB_ID")]
    [Label("Chaos Zakum Arm1", 1)]
    ChaosZakumArm1 = 8800103,

    /// <summary>Chaos Zakum arm 2.</summary>
    [Label("CHAOSZAKUMARM2_MOB_ID")]
    [Label("Chaos Zakum Arm2", 1)]
    ChaosZakumArm2 = 8800104,

    /// <summary>Chaos Zakum arm 3.</summary>
    [Label("CHAOSZAKUMARM3_MOB_ID")]
    [Label("Chaos Zakum Arm3", 1)]
    ChaosZakumArm3 = 8800105,

    /// <summary>Chaos Zakum arm 4.</summary>
    [Label("CHAOSZAKUMARM4_MOB_ID")]
    [Label("Chaos Zakum Arm4", 1)]
    ChaosZakumArm4 = 8800106,

    /// <summary>Chaos Zakum arm 5.</summary>
    [Label("CHAOSZAKUMARM5_MOB_ID")]
    [Label("Chaos Zakum Arm5", 1)]
    ChaosZakumArm5 = 8800107,

    /// <summary>Chaos Zakum arm 6.</summary>
    [Label("CHAOSZAKUMARM6_MOB_ID")]
    [Label("Chaos Zakum Arm6", 1)]
    ChaosZakumArm6 = 8800108,

    /// <summary>Chaos Zakum arm 7.</summary>
    [Label("CHAOSZAKUMARM7_MOB_ID")]
    [Label("Chaos Zakum Arm7", 1)]
    ChaosZakumArm7 = 8800109,

    /// <summary>Chaos Zakum arm 8.</summary>
    [Label("CHAOSZAKUMARM8_MOB_ID")]
    [Label("Chaos Zakum Arm8", 1)]
    ChaosZakumArm8 = 8800110,

    // ── Horntail (numbered) ─────────────────────────────────────────────

    /// <summary>Horntail part 1.</summary>
    [Label("HONTAIL1_MOB_ID")]
    [Label("Horntail Part 1", 1)]
    Hontail1 = 8810000,

    /// <summary>Horntail part 2.</summary>
    [Label("HONTAIL2_MOB_ID")]
    [Label("Horntail Part 2", 1)]
    Hontail2 = 8810001,

    /// <summary>Horntail part 3.</summary>
    [Label("HONTAIL3_MOB_ID")]
    [Label("Horntail Part 3", 1)]
    Hontail3 = 8810002,

    /// <summary>Horntail part 4.</summary>
    [Label("HONTAIL4_MOB_ID")]
    [Label("Horntail Part 4", 1)]
    Hontail4 = 8810003,

    /// <summary>Horntail part 5.</summary>
    [Label("HONTAIL5_MOB_ID")]
    [Label("Horntail Part 5", 1)]
    Hontail5 = 8810004,

    /// <summary>Horntail part 6.</summary>
    [Label("HONTAIL6_MOB_ID")]
    [Label("Horntail Part 6", 1)]
    Hontail6 = 8810005,

    /// <summary>Horntail part 7.</summary>
    [Label("HONTAIL7_MOB_ID")]
    [Label("Horntail Part 7", 1)]
    Hontail7 = 8810006,

    /// <summary>Horntail part 8.</summary>
    [Label("HONTAIL8_MOB_ID")]
    [Label("Horntail Part 8", 1)]
    Hontail8 = 8810007,

    /// <summary>Horntail part 9.</summary>
    [Label("HONTAIL9_MOB_ID")]
    [Label("Horntail Part 9", 1)]
    Hontail9 = 8810008,

    /// <summary>Horntail part 10.</summary>
    [Label("HONTAIL10_MOB_ID")]
    [Label("Horntail Part 10", 1)]
    Hontail10 = 8810009,

    /// <summary>Horntail part 11.</summary>
    [Label("HONTAIL11_MOB_ID")]
    [Label("Horntail Part 11", 1)]
    Hontail11 = 8810010,

    /// <summary>Horntail part 12.</summary>
    [Label("HONTAIL12_MOB_ID")]
    [Label("Horntail Part 12", 1)]
    Hontail12 = 8810011,

    /// <summary>Horntail part 13.</summary>
    [Label("HONTAIL13_MOB_ID")]
    [Label("Horntail Part 13", 1)]
    Hontail13 = 8810012,

    /// <summary>Horntail part 14.</summary>
    [Label("HONTAIL14_MOB_ID")]
    [Label("Horntail Part 14", 1)]
    Hontail14 = 8810013,

    /// <summary>Horntail part 15.</summary>
    [Label("HONTAIL15_MOB_ID")]
    [Label("Horntail Part 15", 1)]
    Hontail15 = 8810014,

    /// <summary>Horntail part 16.</summary>
    [Label("HONTAIL16_MOB_ID")]
    [Label("Horntail Part 16", 1)]
    Hontail16 = 8810015,

    /// <summary>Horntail part 17.</summary>
    [Label("HONTAIL17_MOB_ID")]
    [Label("Horntail Part 17", 1)]
    Hontail17 = 8810016,

    /// <summary>Horntail part 18.</summary>
    [Label("HONTAIL18_MOB_ID")]
    [Label("Horntail Part 18", 1)]
    Hontail18 = 8810017,

    /// <summary>Horntail part 19.</summary>
    [Label("HONTAIL19_MOB_ID")]
    [Label("Horntail Part 19", 1)]
    Hontail19 = 8810018,

    /// <summary>Horntail part 20.</summary>
    [Label("HONTAIL20_MOB_ID")]
    [Label("Horntail Part 20", 1)]
    Hontail20 = 8810024,

    /// <summary>Horntail part 21.</summary>
    [Label("HONTAIL21_MOB_ID")]
    [Label("Horntail Part 21", 1)]
    Hontail21 = 8810025,

    /// <summary>Horntail part 22.</summary>
    [Label("HONTAIL22_MOB_ID")]
    [Label("Horntail Part 22", 1)]
    Hontail22 = 8810026,

    // ── Horntail (named parts) ──────────────────────────────────────────

    /// <summary>Horntail left head.</summary>
    [Label("HONTALE_LEFTHEAD_MOB_ID")]
    [Label("Horntail Left Head", 1)]
    HontaleLeftHead = 8810000,

    /// <summary>Horntail right head.</summary>
    [Label("HONTALE_RIGHTHEAD_MOB_ID")]
    [Label("Horntail Right Head", 1)]
    HontaleRightHead = 8810001,

    /// <summary>Horntail main head 1.</summary>
    [Label("HONTALE_HEAD1_MOB_ID")]
    [Label("Horntail Main Head 1", 1)]
    HontaleHead1 = 8810002,

    /// <summary>Horntail main head 2.</summary>
    [Label("HONTALE_HEAD2_MOB_ID")]
    [Label("Horntail Main Head 2", 1)]
    HontaleHead2 = 8810003,

    /// <summary>Horntail main head 3.</summary>
    [Label("HONTALE_HEAD3_MOB_ID")]
    [Label("Horntail Main Head 3", 1)]
    HontaleHead3 = 8810004,

    /// <summary>Horntail left hand.</summary>
    [Label("HONTALE_LEFTHAND_MOB_ID")]
    [Label("Horntail Left Hand", 1)]
    HontaleLeftHand = 8810005,

    /// <summary>Horntail right hand.</summary>
    [Label("HONTALE_RIGHTHAND_MOB_ID")]
    [Label("Horntail Right Hand", 1)]
    HontaleRightHand = 8810006,

    /// <summary>Horntail wings.</summary>
    [Label("HONTALE_WING_MOB_ID")]
    [Label("Horntail Wings", 1)]
    HontaleWing = 8810007,

    /// <summary>Horntail legs.</summary>
    [Label("HONTALE_LEG_MOB_ID")]
    [Label("Horntail Legs", 1)]
    HontaleLeg = 8810008,

    /// <summary>Horntail tail.</summary>
    [Label("HONTALE_TAIL_MOB_ID")]
    [Label("Horntail Tail", 1)]
    HontaleTail = 8810009,

    /// <summary>Dead Horntail head 1.</summary>
    [Label("DEADHONTALE_HEAD1_MOB_ID")]
    [Label("Dead Horntail Head 1", 1)]
    DeadHontaleHead1 = 8810010,

    /// <summary>Dead Horntail head 2.</summary>
    [Label("DEADHONTALE_HEAD2_MOB_ID")]
    [Label("Dead Horntail Head 2", 1)]
    DeadHontaleHead2 = 8810011,

    /// <summary>Dead Horntail head 3.</summary>
    [Label("DEADHONTALE_HEAD3_MOB_ID")]
    [Label("Dead Horntail Head 3", 1)]
    DeadHontaleHead3 = 8810012,

    /// <summary>Dead Horntail left hand.</summary>
    [Label("DEADHONTALE_LEFTHAND_MOB_ID")]
    [Label("Dead Horntail Left Hand", 1)]
    DeadHontaleLeftHand = 8810013,

    /// <summary>Dead Horntail right hand.</summary>
    [Label("DEADHONTALE_RIGHTHAND_MOB_ID")]
    [Label("Dead Horntail Right Hand", 1)]
    DeadHontaleRightHand = 8810014,

    /// <summary>Dead Horntail wings.</summary>
    [Label("DEADHONTALE_WING_MOB_ID")]
    [Label("Dead Horntail Wings", 1)]
    DeadHontaleWing = 8810015,

    /// <summary>Dead Horntail legs.</summary>
    [Label("DEADHONTALE_LEG_MOB_ID")]
    [Label("Dead Horntail Legs", 1)]
    DeadHontaleLeg = 8810016,

    /// <summary>Dead Horntail tail.</summary>
    [Label("DEADHONTALE_TAIL_MOB_ID")]
    [Label("Dead Horntail Tail", 1)]
    DeadHontaleTail = 8810017,

    /// <summary>Horntail spirit form.</summary>
    [Label("HONTALE_SPIRIT_MOB_ID")]
    [Label("Horntail Spirit Form", 1)]
    HontaleSpirit = 8810018,

    /// <summary>Horntail summoned mob.</summary>
    [Label("HONTALE_SUMMONED")]
    [Label("Horntail Summoned Mob", 1)]
    HontaleSummoned = 8810026,

    /// <summary>Horntail base ID.</summary>
    [Label("HONTALE_BASE_MOB_ID")]
    [Label("Horntail Base ID", 1)]
    HontaleBase = 8810000,

    // ── Chaos Horntail ──────────────────────────────────────────────────

    /// <summary>Chaos Horntail left head.</summary>
    [Label("CHAOSHONTALE_LEFTHEAD_MOB_ID")]
    [Label("Chaos Horntail Left Head", 1)]
    ChaosHontaleLeftHead = 8810100,

    /// <summary>Chaos Horntail right head.</summary>
    [Label("CHAOSHONTALE_RIGHTHEAD_MOB_ID")]
    [Label("Chaos Horntail Right Head", 1)]
    ChaosHontaleRightHead = 8810101,

    /// <summary>Chaos Horntail head 1.</summary>
    [Label("CHAOSHONTALE_HEAD1_MOB_ID")]
    [Label("Chaos Horntail Head 1", 1)]
    ChaosHontaleHead1 = 8810102,

    /// <summary>Chaos Horntail head 2.</summary>
    [Label("CHAOSHONTALE_HEAD2_MOB_ID")]
    [Label("Chaos Horntail Head 2", 1)]
    ChaosHontaleHead2 = 8810103,

    /// <summary>Chaos Horntail head 3.</summary>
    [Label("CHAOSHONTALE_HEAD3_MOB_ID")]
    [Label("Chaos Horntail Head 3", 1)]
    ChaosHontaleHead3 = 8810104,

    /// <summary>Chaos Horntail left hand.</summary>
    [Label("CHAOSHONTALE_LEFTHAND_MOB_ID")]
    [Label("Chaos Horntail Left Hand", 1)]
    ChaosHontaleLeftHand = 8810105,

    /// <summary>Chaos Horntail right hand.</summary>
    [Label("CHAOSHONTALE_RIGHTHAND_MOB_ID")]
    [Label("Chaos Horntail Right Hand", 1)]
    ChaosHontaleRightHand = 8810106,

    /// <summary>Chaos Horntail wings.</summary>
    [Label("CHAOSHONTALE_WING_MOB_ID")]
    [Label("Chaos Horntail Wings", 1)]
    ChaosHontaleWing = 8810107,

    /// <summary>Chaos Horntail legs.</summary>
    [Label("CHAOSHONTALE_LEG_MOB_ID")]
    [Label("Chaos Horntail Legs", 1)]
    ChaosHontaleLeg = 8810108,

    /// <summary>Chaos Horntail tail.</summary>
    [Label("CHAOSHONTALE_TAIL_MOB_ID")]
    [Label("Chaos Horntail Tail", 1)]
    ChaosHontaleTail = 8810109,

    /// <summary>Chaos Horntail spirit 1.</summary>
    [Label("CHAOSHONTALE_SPIRIT_MOB1_ID")]
    [Label("Chaos Horntail Spirit 1", 1)]
    ChaosHontaleSpiritMob1 = 8810118,

    /// <summary>Chaos Horntail spirit 2.</summary>
    [Label("CHAOSHONTALE_SPIRIT_MOB2_ID")]
    [Label("Chaos Horntail Spirit 2", 1)]
    ChaosHontaleSpiritMob2 = 8810119,

    /// <summary>Chaos Horntail spirit 3.</summary>
    [Label("CHAOSHONTALE_SPIRIT_MOB3_ID")]
    [Label("Chaos Horntail Spirit 3", 1)]
    ChaosHontaleSpiritMob3 = 8810120,

    /// <summary>Chaos Horntail spirit 4.</summary>
    [Label("CHAOSHONTALE_SPIRIT_MOB4_ID")]
    [Label("Chaos Horntail Spirit 4", 1)]
    ChaosHontaleSpiritMob4 = 8810121,

    /// <summary>Chaos Horntail spirit 5.</summary>
    [Label("CHAOSHONTALE_SPIRIT_MOB5_ID")]
    [Label("Chaos Horntail Spirit 5", 1)]
    ChaosHontaleSpiritMob5 = 8810122,

    /// <summary>Chaos Horntail summoned mob.</summary>
    [Label("CHAOSHONTALE_SUMMONED")]
    [Label("Chaos Horntail Summoned Mob", 1)]
    ChaosHontaleSummoned = 8810130,

    /// <summary>Chaos Horntail base ID.</summary>
    [Label("CHAOSHONTALE_BASE_MOB_ID")]
    [Label("Chaos Horntail Base ID", 1)]
    ChaosHontaleBase = 8810100,

    // ── Papulatus (Baby Boss) ───────────────────────────────────────────

    /// <summary>Papulatus fixed body.</summary>
    [Label("BABYBOSS_FIXED_MOB_ID")]
    [Label("Babyboss Fixed", 1)]
    BabybossFixed = 8820000,

    /// <summary>Papulatus boss.</summary>
    [Label("BABYBOSS_MOB_ID")]
    Babyboss = 8820001,

    /// <summary>Papulatus goddess statue.</summary>
    [Label("BABYBOSS_MIRRORGODDESS_STATUE_MOB_ID")]
    [Label("Babyboss Mirror Goddess Statue", 1)]
    BabybossMirrorGoddessStatue = 8820002,

    /// <summary>Left human statue petrified.</summary>
    [Label("BABYBOSS_LEFTHUMAN_STATUE_TURNTOSTONE_MOB_ID")]
    [Label("Babyboss Left Human Statue Turn To Stone", 1)]
    BabybossLeftHumanStatueTurnToStone = 8820003,

    /// <summary>Right human statue petrified.</summary>
    [Label("BABYBOSS_RIGHTHUMAN_STATUE_TURNTOSTONE_MOB_ID")]
    [Label("Babyboss Right Human Statue Turn To Stone", 1)]
    BabybossRightHumanStatueTurnToStone = 8820004,

    /// <summary>Left bird statue petrified.</summary>
    [Label("BABYBOSS_LEFTBIRD_STATUE_TURNTOSTONE_MOB_ID")]
    [Label("Babyboss Left Bird Statue Turn To Stone", 1)]
    BabybossLeftBirdStatueTurnToStone = 8820005,

    /// <summary>Right bird statue petrified.</summary>
    [Label("BABYBOSS_RIGHTBIRD_STATUE_TURNTOSTONE_MOB_ID")]
    [Label("Babyboss Right Bird Statue Turn To Stone", 1)]
    BabybossRightBirdStatueTurnToStone = 8820006,

    /// <summary>Papulatus kid form.</summary>
    [Label("BABYBOSS_KID_MOB_ID")]
    [Label("Babyboss Kid", 1)]
    BabybossKid = 8820007,

    /// <summary>Papulatus fixed summoner.</summary>
    [Label("BABYBOSS_FIXED_SUMMONER_MOB_ID")]
    [Label("Babyboss Fixed Summoner", 1)]
    BabybossFixedSummoner = 8820008,

    /// <summary>Papulatus dummy 0.</summary>
    [Label("BABYBOSS_DUMMY0_MOB_ID")]
    [Label("Babyboss Dummy0", 1)]
    BabybossDummy0 = 8820009,

    /// <summary>Papulatus dummy 1.</summary>
    [Label("BABYBOSS_DUMMY1_MOB_ID")]
    [Label("Babyboss Dummy1", 1)]
    BabybossDummy1 = 8820010,

    /// <summary>Papulatus dummy 2.</summary>
    [Label("BABYBOSS_DUMMY2_MOB_ID")]
    [Label("Babyboss Dummy2", 1)]
    BabybossDummy2 = 8820011,

    /// <summary>Papulatus dummy 3.</summary>
    [Label("BABYBOSS_DUMMY3_MOB_ID")]
    [Label("Babyboss Dummy3", 1)]
    BabybossDummy3 = 8820012,

    /// <summary>Papulatus dummy 4.</summary>
    [Label("BABYBOSS_DUMMY4_MOB_ID")]
    [Label("Babyboss Dummy4", 1)]
    BabybossDummy4 = 8820013,

    /// <summary>Papulatus dummy 5.</summary>
    [Label("BABYBOSS_DUMMY5_MOB_ID")]
    [Label("Babyboss Dummy5", 1)]
    BabybossDummy5 = 8820014,

    /// <summary>Left human statue crumble.</summary>
    [Label("BABYBOSS_LEFTHUMAN_STATUE_CRUMBLE_MOB_ID")]
    [Label("Babyboss Left Human Statue Crumble", 1)]
    BabybossLeftHumanStatueCrumble = 8820015,

    /// <summary>Right human statue crumble.</summary>
    [Label("BABYBOSS_RIGHTHUMAN_STATUE_CRUMBLE_MOB_ID")]
    [Label("Babyboss Right Human Statue Crumble", 1)]
    BabybossRightHumanStatueCrumble = 8820016,

    /// <summary>Left bird statue crumble.</summary>
    [Label("BABYBOSS_LEFTBIRD_STATUE_CRUMBLE_MOB_ID")]
    [Label("Babyboss Left Bird Statue Crumble", 1)]
    BabybossLeftBirdStatueCrumble = 8820017,

    /// <summary>Right bird statue crumble.</summary>
    [Label("BABYBOSS_RIGHTBIRD_STATUE_CRUMBLE_MOB_ID")]
    [Label("Babyboss Right Bird Statue Crumble", 1)]
    BabybossRightBirdStatueCrumble = 8820018,

    /// <summary>Goddess statue crumble.</summary>
    [Label("BABYBOSS_MIRRORGODDESS_STATUE_CRUMBLE_MOB_ID")]
    [Label("Babyboss Mirror Goddess Statue Crumble", 1)]
    BabybossMirrorGoddessStatueCrumble = 8820019,

    /// <summary>Left human crumble phase 2.</summary>
    [Label("BABYBOSS_LEFTHUMAN_STATUE_CRUMBLE2_MOB_ID")]
    [Label("Babyboss Left Human Statue Crumble2", 1)]
    BabybossLeftHumanStatueCrumble2 = 8820020,

    /// <summary>Right human crumble phase 2.</summary>
    [Label("BABYBOSS_RIGHTHUMAN_STATUE_CRUMBLE2_MOB_ID")]
    [Label("Babyboss Right Human Statue Crumble2", 1)]
    BabybossRightHumanStatueCrumble2 = 8820021,

    /// <summary>Left bird crumble phase 2.</summary>
    [Label("BABYBOSS_LEFTBIRD_STATUE_CRUMBLE2_MOB_ID")]
    [Label("Babyboss Left Bird Statue Crumble2", 1)]
    BabybossLeftBirdStatueCrumble2 = 8820022,

    /// <summary>Right bird crumble phase 2.</summary>
    [Label("BABYBOSS_RIGHTBIRD_STATUE_CRUMBLE2_MOB_ID")]
    [Label("Babyboss Right Bird Statue Crumble2", 1)]
    BabybossRightBirdStatueCrumble2 = 8820023,

    /// <summary>Left human crumble phase 3.</summary>
    [Label("BABYBOSS_LEFTHUMAN_STATUE_CRUMBLE3_MOB_ID")]
    [Label("Babyboss Left Human Statue Crumble3", 1)]
    BabybossLeftHumanStatueCrumble3 = 8820024,

    /// <summary>Right human crumble phase 3.</summary>
    [Label("BABYBOSS_RIGHTHUMAN_STATUE_CRUMBLE3_MOB_ID")]
    [Label("Babyboss Right Human Statue Crumble3", 1)]
    BabybossRightHumanStatueCrumble3 = 8820025,

    /// <summary>Left bird crumble phase 3.</summary>
    [Label("BABYBOSS_LEFTBIRD_STATUE_CRUMBLE3_MOB_ID")]
    [Label("Babyboss Left Bird Statue Crumble3", 1)]
    BabybossLeftBirdStatueCrumble3 = 8820026,

    /// <summary>Right bird crumble phase 3.</summary>
    [Label("BABYBOSS_RIGHTBIRD_STATUE_CRUMBLE3_MOB_ID")]
    [Label("Babyboss Right Bird Statue Crumble3", 1)]
    BabybossRightBirdStatueCrumble3 = 8820027,

    /// <summary>Papulatus base ID.</summary>
    [Label("BABYBOSS_BASE_MOB_ID")]
    [Label("Babyboss Base", 1)]
    BabybossBase = 8820000,

    // ── Balrog ──────────────────────────────────────────────────────────

    /// <summary>Balrog body.</summary>
    [Label("BALROG_BODY_MOB_ID")]
    [Label("Balrog Body", 1)]
    BalrogBody = 8830000,

    /// <summary>Balrog left hand.</summary>
    [Label("BALROG_LEFTHAND_MOB_ID")]
    [Label("Balrog Left Hand", 1)]
    BalrogLeftHand = 8830001,

    /// <summary>Balrog right hand.</summary>
    [Label("BALROG_RIGHTHAND_MOB_ID")]
    [Label("Balrog Right Hand", 1)]
    BalrogRightHand = 8830002,

    /// <summary>Balrog spirit form.</summary>
    [Label("BALROG_SPIRIT_MOB_ID")]
    [Label("Balrog Spirit", 1)]
    BalrogSpirit = 8830003,

    /// <summary>Balrog dead left hand.</summary>
    [Label("BALROG_LEFTDEAD_MOB_ID")]
    [Label("Balrog Left Dead", 1)]
    BalrogLeftDead = 8830004,

    /// <summary>Balrog dead right hand.</summary>
    [Label("BALROG_RIGHTDEAD_MOB_ID")]
    [Label("Balrog Right Dead", 1)]
    BalrogRightDead = 8830005,

    /// <summary>Balrog left dummy.</summary>
    [Label("BALROG_LEFTDUMMY_MOB_ID")]
    [Label("Balrog Left Dummy", 1)]
    BalrogLeftDummy = 8830006,

    /// <summary>Balrog base ID.</summary>
    [Label("BALROG_BASE_MOB_ID")]
    [Label("Balrog Base", 1)]
    BalrogBase = 8830000,

    // ── Easy Balrog ─────────────────────────────────────────────────────

    /// <summary>Easy Balrog body.</summary>
    [Label("EASYBALROG_BODY_MOB_ID")]
    [Label("Easy Balrog Body", 1)]
    EasyBalrogBody = 8830007,

    /// <summary>Easy Balrog left hand.</summary>
    [Label("EASYBALROG_LEFTHAND_MOB_ID")]
    [Label("Easy Balrog Left Hand", 1)]
    EasyBalrogLeftHand = 8830008,

    /// <summary>Easy Balrog right hand.</summary>
    [Label("EASYBALROG_RIGHTHAND_MOB_ID")]
    [Label("Easy Balrog Right Hand", 1)]
    EasyBalrogRightHand = 8830009,

    /// <summary>Easy Balrog spirit form.</summary>
    [Label("EASYBALROG_SPIRIT_MOB_ID")]
    [Label("Easy Balrog Spirit", 1)]
    EasyBalrogSpirit = 8830010,

    /// <summary>Easy Balrog dead left hand.</summary>
    [Label("EASYBALROG_LEFTDEAD_MOB_ID")]
    [Label("Easy Balrog Left Dead", 1)]
    EasyBalrogLeftDead = 8830011,

    /// <summary>Easy Balrog dead right hand.</summary>
    [Label("EASYBALROG_RIGHTDEAD_MOB_ID")]
    [Label("Easy Balrog Right Dead", 1)]
    EasyBalrogRightDead = 8830012,

    /// <summary>Easy Balrog left dummy.</summary>
    [Label("EASYBALROG_LEFTDUMMY_MOB_ID")]
    [Label("Easy Balrog Left Dummy", 1)]
    EasyBalrogLeftDummy = 8830013,

    /// <summary>Easy Balrog base ID.</summary>
    [Label("EASYBALROG_BASE_MOB_ID")]
    [Label("Easy Balrog Base", 1)]
    EasyBalrogBase = 8830007,

    // ── Miscellaneous ───────────────────────────────────────────────────

    /// <summary>Fixed position mob.</summary>
    [Label("FIXED_MOB_ID")]
    Fixed = 9999999,

    /// <summary>Transparent mob.</summary>
    [Label("TRANSPARENT_MOB_ID")]
    Transparent = 9300216,

    /// <summary>Massacre transparent mob 1.</summary>
    [Label("MASSACRE_TRANSPARENT_MOB1_ID")]
    [Label("Massacre Transparent Mob1", 1)]
    MassacreTransparentMob1 = 9700022,

    /// <summary>Massacre transparent mob 2.</summary>
    [Label("MASSACRE_TRANSPARENT_MOB2_ID")]
    [Label("Massacre Transparent Mob2", 1)]
    MassacreTransparentMob2 = 9700023,

    /// <summary>Ghost ship captain.</summary>
    [Label("CAPTAIN_OF_PHANTOM_SHIP_MOB_ID")]
    [Label("Captain Of Phantom Ship", 1)]
    CaptainOfPhantomShip = 9700037,

    /// <summary>7th anniversary ad balloon.</summary>
    [Label("ADBALLOON_7TH_ANNIVERSARY_MOB_ID")]
    [Label("Ad Balloon7th Anniversary", 1)]
    AdBalloon7thAnniversary = 9500401,
}
