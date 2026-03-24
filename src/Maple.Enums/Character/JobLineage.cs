using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character job race/lineage derived from the job code: <c>jobCode / 1000</c>.
/// This is the stored lineage value on character data.
/// See also <see cref="JobRace"/> which is the same PDB concept at a different declaration site (line ~3235).
/// </summary>
public enum JobLineage : byte
{
    /// <summary>Explorer lineage.</summary>
    [Label("JOB_RACE_NORMAL")]
    Explorer = 0,

    /// <summary>Cygnus Knights lineage.</summary>
    [Label("JOB_RACE_CYGNUS")]
    Cygnus = 1,

    /// <summary>Heroes lineage.</summary>
    [Label("JOB_RACE_THIRD")]
    Heroes = 2,

    /// <summary>Resistance lineage.</summary>
    [Label("JOB_RACE_RESISTANCE")]
    Resistance = 3,
}
