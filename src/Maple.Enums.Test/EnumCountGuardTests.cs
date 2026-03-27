namespace Maple.Enums.Test;

/// <summary>
/// Guard test that catches accidental addition or removal of public enum types.
/// Update the expected count when intentionally adding/removing enums.
/// </summary>
public sealed class EnumCountGuardTests
{
    [Test]
    public async Task PublicEnumCount_MatchesExpected()
    {
        var enumCount = typeof(EnumDisplayExtensions).Assembly.GetExportedTypes().Count(t => t.IsEnum);

        // 290 enum types as of the initial release.
        // Update this constant when intentionally adding or removing enums.
        await Assert.That(enumCount).IsEqualTo(290);
    }
}
