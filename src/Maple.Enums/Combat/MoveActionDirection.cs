namespace Maple.Enums;

/// <summary>Movement direction (left/right) encoded in move path actions.</summary>
public enum MoveActionDirection : byte
{
    /// <summary>Facing or moving right.</summary>
    Right = 0,

    /// <summary>Facing or moving left.</summary>
    Left = 1,
}
