using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Family tree hierarchy node type.</summary>
public enum FamilyTreeNodeType : byte
{
    /// <summary>Family leader node.</summary>
    [Label("NODE_BOSS")]
    Boss = 0,

    /// <summary>Two levels above.</summary>
    [Label("NODE_GRANDFATHER")]
    Grandfather = 1,

    /// <summary>Direct parent node.</summary>
    [Label("NODE_FATHER")]
    Father = 2,

    /// <summary>Current character node.</summary>
    [Label("NODE_ME")]
    Me = 3,

    /// <summary>Sibling node.</summary>
    [Label("NODE_BROTHER")]
    Brother = 4,

    /// <summary>First child node.</summary>
    [Label("NODE_CHILD_0")]
    Child0 = 5,

    /// <summary>Second child node.</summary>
    [Label("NODE_CHILD_1")]
    Child1 = 6,

    /// <summary>First grandchild node.</summary>
    [Label("NODE_GRANDCHILD_0")]
    Grandchild0 = 7,

    /// <summary>Second grandchild node.</summary>
    [Label("NODE_GRANDCHILD_1")]
    Grandchild1 = 8,

    /// <summary>Third grandchild node.</summary>
    [Label("NODE_GRANDCHILD_2")]
    Grandchild2 = 9,

    /// <summary>Fourth grandchild node.</summary>
    [Label("NODE_GRANDCHILD_3")]
    Grandchild3 = 10,

    /// <summary>Total node count.</summary>
    [Label("NODE_COUNT")]
    Count = 11,
}
