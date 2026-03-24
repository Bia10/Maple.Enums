namespace Maple.Enums;

/// <summary>Player attack classification.</summary>
public enum AttackType : byte
{
    /// <summary>Close-range physical hit.</summary>
    Melee = 0,

    /// <summary>Ranged projectile attack.</summary>
    Shoot = 1,

    /// <summary>Magic spell attack.</summary>
    Magic = 2,

    /// <summary>Body/contact attack.</summary>
    Body = 3,
}
