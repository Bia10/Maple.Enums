using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Monster Carnival Season 2 map type identifier.
/// </summary>
public enum MonsterCarnivalMapType : byte
{
    /// <summary>Carnival map variant 1.</summary>
    [Label("MCARNIVALS2_MAPTYPE1")]
    [Label("Map Type1", 1)]
    MapType1 = 0,

    /// <summary>Carnival map variant 2.</summary>
    [Label("MCARNIVALS2_MAPTYPE2")]
    [Label("Map Type2", 1)]
    MapType2 = 1,

    /// <summary>Carnival map variant 3.</summary>
    [Label("MCARNIVALS2_MAPTYPE3")]
    [Label("Map Type3", 1)]
    MapType3 = 2,

    /// <summary>No carnival map type (invalid/sentinel).</summary>
    [Label("MCARNIVALS2_MAPTYPE_NO")]
    [Label("Map Type No", 1)]
    MapTypeNo = 3,
}
