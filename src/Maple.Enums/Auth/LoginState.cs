using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Login screen state.
/// </summary>
public enum LoginState : byte
{
    /// <summary>Title/splash screen.</summary>
    [Label("LS_TITLE")]
    Title = 0,

    /// <summary>World selection.</summary>
    [Label("LS_WORLDSELECT")]
    [Label("World Select", 1)]
    WorldSelect = 1,

    /// <summary>Character selection.</summary>
    [Label("LS_CHARSELECT")]
    [Label("Char Select", 1)]
    CharSelect = 2,

    /// <summary>New character race pick.</summary>
    [Label("LS_NEWCHAR_RACE")]
    [Label("New Char Race", 1)]
    NewCharRace = 3,

    /// <summary>New character naming.</summary>
    [Label("LS_NEWCHAR_NAME")]
    [Label("New Char Name", 1)]
    NewCharName = 4,

    /// <summary>View all characters.</summary>
    [Label("LS_VIEWALLCHAR")]
    [Label("View All Char", 1)]
    ViewAllChar = 5,
}
