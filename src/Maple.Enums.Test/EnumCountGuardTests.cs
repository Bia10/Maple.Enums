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

        // 294 enum types: 290 from initial release + AccountGradeCode, LifeType, BodyPart, Emotion.
        // AccountSubGradeCode was removed — it is a duplicate of the existing PrivateStatusFlag.
        // Update this constant when intentionally adding or removing enums.
        await Assert.That(enumCount).IsEqualTo(294);
    }
}
