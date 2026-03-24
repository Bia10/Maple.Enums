using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Behaviour flags that control what users can do with a Nexon Messenger buddy-list category.
/// </summary>
[Flags]
public enum NmCategoryProperty : byte
{
    /// <summary>No special properties.</summary>
    None = 0,

    /// <summary>This is the default category.</summary>
    [Label("kCateProp_DefaultCategory")]
    DefaultCategory = 1,

    /// <summary>Category cannot be deleted.</summary>
    [Label("kCateProp_CateNotDelete")]
    CategoryNotDelete = 2,

    /// <summary>Category cannot be renamed.</summary>
    [Label("kCateProp_CateNotRename")]
    CategoryNotRename = 4,

    /// <summary>Users cannot be added to this category.</summary>
    [Label("kCateProp_UserNotAdd")]
    UserNotAdd = 8,

    /// <summary>Users cannot be deleted from this category.</summary>
    [Label("kCateProp_UserNotDelete")]
    UserNotDelete = 16,
}
