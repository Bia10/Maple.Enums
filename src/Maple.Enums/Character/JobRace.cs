using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Job race category — top-level classification of job lineage origin.
/// Same V95 PDB concept as <see cref="JobLineage"/> (JOB_RACE_* prefix) but declared
/// at a different location (line ~3235 vs ~3609). Member names here preserve the raw PDB naming.
/// </summary>
public enum JobRace : byte
{
    /// <summary>Explorer race.</summary>
    [Label("JOB_RACE_NORMAL")]
    Normal = 0,

    /// <summary>Cygnus race.</summary>
    [Label("JOB_RACE_CYGNUS")]
    Cygnus = 1,

    /// <summary>Heroes (third) race.</summary>
    [Label("JOB_RACE_THIRD")]
    Third = 2,

    /// <summary>Resistance race.</summary>
    [Label("JOB_RACE_RESISTANCE")]
    Resistance = 3,
}
