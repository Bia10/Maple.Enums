using System.Reflection;

namespace Maple.Enums.Test;

/// <summary>
/// Smoke test ensuring <see cref="EnumDisplayExtensions.GetDisplayLabel{T}"/>
/// returns a non-empty string for every member of every public enum in Maple.Enums.
/// </summary>
public sealed class BulkEnumDisplayTests
{
    static readonly MethodInfo s_getDisplayLabelMethod = typeof(EnumDisplayExtensions).GetMethod(
        nameof(EnumDisplayExtensions.GetDisplayLabel)
    )!;

    public static IEnumerable<(Type EnumType, string MemberName, object Value)> AllEnumMembers()
    {
        var enumTypes = typeof(EnumDisplayExtensions)
            .Assembly.GetExportedTypes()
            .Where(t => t.IsEnum)
            .OrderBy(t => t.Name, StringComparer.Ordinal);

        foreach (var enumType in enumTypes)
        {
            foreach (var name in Enum.GetNames(enumType))
            {
                yield return (enumType, name, Enum.Parse(enumType, name));
            }
        }
    }

    [Test]
    [MethodDataSource(nameof(AllEnumMembers))]
    public async Task GetDisplayLabel_NeverThrows_ReturnsNonEmpty(Type enumType, string memberName, object value)
    {
        var generic = s_getDisplayLabelMethod.MakeGenericMethod(enumType);
        var result = (string?)generic.Invoke(null, [value]);

        await Assert.That(result).IsNotNull().And.IsNotEmpty();
    }
}
