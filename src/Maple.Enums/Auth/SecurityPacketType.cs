using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Security packet sub-type for client integrity checks.
/// </summary>
public enum SecurityPacketType : byte
{
    /// <summary>Memory region scan.</summary>
    [Label("SECURITYPACKET_MEMORYREGION")]
    [Label("Memory Region", 1)]
    MemoryRegion = 0,

    /// <summary>Memory hash verification.</summary>
    [Label("SECURITYPACKET_MEMORYHASH")]
    [Label("Memory Hash", 1)]
    MemoryHash = 1,

    /// <summary>Full client integrity check.</summary>
    [Label("SECURITYPACKET_CHECKCLIENTINTEGRITY")]
    [Label("Check Client Integrity", 1)]
    CheckClientIntegrity = 2,
}
