using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// GM / admin account privilege flag bits.
/// </summary>
[Flags]
public enum PrivateStatusFlag : ushort
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Primary trace logging enabled.</summary>
    [Label("PS_PrimaryTrace")]
    [Label("Primary Trace", 1)]
    PrimaryTrace = 0x1,

    /// <summary>Secondary trace logging enabled.</summary>
    [Label("PS_SecondaryTrace")]
    [Label("Secondary Trace", 1)]
    SecondaryTrace = 0x2,

    /// <summary>Client has admin privileges.</summary>
    [Label("PS_AdminClient")]
    [Label("Admin Client", 1)]
    AdminClient = 0x4,

    /// <summary>Mob movement observation enabled.</summary>
    [Label("PS_MobMoveObserve")]
    [Label("Mob Move Observe", 1)]
    MobMoveObserve = 0x8,

    /// <summary>Account has manager-level access.</summary>
    [Label("PS_ManagerAccount")]
    [Label("Manager Account", 1)]
    ManagerAccount = 0x10,

    /// <summary>Outsourced Super GM account.</summary>
    [Label("PS_OutSourceSuperGM")]
    [Label("Out Source Super Gm", 1)]
    OutSourceSuperGm = 0x20,

    /// <summary>Outsourced GM account.</summary>
    [Label("PS_OutSourceGM")]
    [Label("Out Source Gm", 1)]
    OutSourceGm = 0x40,

    /// <summary>User-level GM account.</summary>
    [Label("PS_UserGM")]
    [Label("User Gm", 1)]
    UserGm = 0x80,

    /// <summary>Tester or QA account.</summary>
    [Label("PS_TesterAccount")]
    [Label("Tester Account", 1)]
    TesterAccount = 0x100,
}
