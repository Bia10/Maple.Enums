namespace Maple.Enums;

/// <summary>Server rate multiplier category (EXP, meso, drop).</summary>
public enum RateType : byte
{
    /// <summary>Experience point rate.</summary>
    Exp = 0,

    /// <summary>Meso currency rate.</summary>
    Meso = 1,

    /// <summary>Item drop rate.</summary>
    Drop = 2,
}
