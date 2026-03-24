namespace Maple.Enums.Test;

/// <summary>
/// Verifies the three-tier fallback logic of
/// <see cref="EnumDisplayExtensions.GetDisplayLabel{T}"/>.
/// </summary>
public sealed class EnumDisplayExtensionsTests
{
    // ── Index 1 (explicit display label) ────────────────────────────────

    [Test]
    public async Task GetDisplayLabel_WithIndex1Label_ReturnsDisplayLabel()
    {
        // Gender.None has [Label("Both", 1)]
        var result = Gender.None.GetDisplayLabel();

        await Assert.That(result).IsEqualTo("Both");
    }

    // ── Index 0 fallback (readable PDB label without underscores) ───────

    [Test]
    public async Task GetDisplayLabel_NoIndex1_ReadableIndex0_ReturnsIndex0()
    {
        // SkillSubType.Regular has [Label("Active")] only (index 0, no underscores, no index 1).
        // "Active" has no underscores → readable → returned directly.
        var result = SkillSubType.Regular.GetDisplayLabel();

        await Assert.That(result).IsEqualTo("Active");
    }

    // ── Member name fallback (no labels or PDB label has underscores) ───

    [Test]
    public async Task GetDisplayLabel_NoLabels_ReturnsMemberName()
    {
        // ReactorEventType.Hit has no [Label] attributes — single-word member name fallback.
        var result = ReactorEventType.Hit.GetDisplayLabel();

        await Assert.That(result).IsEqualTo("Hit");
    }

    [Test]
    public async Task GetDisplayLabel_Index0HasUnderscores_ReturnsMemberName()
    {
        // MapPortalType.Invisible has [Label("PORTALTYPE_INVISIBLE")] only (index 0).
        // Contains underscores → rejected → falls to member name.
        var result = MapPortalType.Invisible.GetDisplayLabel();

        await Assert.That(result).IsEqualTo("Invisible");
    }

    [Test]
    public async Task GetDisplayLabel_Index0WithUnderscores_NoIndex1_ReturnsMemberName()
    {
        // Gender.Male has [Label("GENDER_MALE")] (contains underscore) and no index 1.
        // Underscore → not readable → falls to member name.
        var result = Gender.Male.GetDisplayLabel();

        await Assert.That(result).IsEqualTo("Male");
    }
}
