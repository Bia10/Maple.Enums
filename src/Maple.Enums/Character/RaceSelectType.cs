using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// New character creation race selection.
/// Used for UI selection only. Character data uses JobLineage for the stored lineage value.
/// </summary>
public enum RaceSelectType : byte
{
    /// <summary>Resistance faction.</summary>
    [Label("RACE_SELECT_RESISTANCE")]
    Resistance = 0,

    /// <summary>Explorer class.</summary>
    [Label("RACE_SELECT_NORMAL")]
    Normal = 1,

    /// <summary>Cygnus Knight class.</summary>
    [Label("RACE_SELECT_CYGNUS")]
    Cygnus = 2,

    /// <summary>Aran hero class.</summary>
    [Label("RACE_SELECT_ARAN")]
    Aran = 3,

    /// <summary>Evan dragon class.</summary>
    [Label("RACE_SELECT_EVAN")]
    Evan = 4,
}
