namespace Maple.Enums;

/// <summary>
/// Field mob appear type. Signed — values range from -5 to 0.
/// </summary>
public enum FieldMobAppearType : sbyte
{
    /// <summary>Normal spawn.</summary>
    Normal = -1,

    /// <summary>Regenerated spawn.</summary>
    Regen = -2,

    /// <summary>Revived after death.</summary>
    Revived = -3,

    /// <summary>Suspended spawn.</summary>
    Suspended = -4,

    /// <summary>Delayed spawn.</summary>
    Delay = -5,

    /// <summary>Spawn with effect.</summary>
    Effect = 0,
}
