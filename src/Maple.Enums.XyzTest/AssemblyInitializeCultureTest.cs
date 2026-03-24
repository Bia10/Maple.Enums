using System.Globalization;

namespace Maple.Enums.XyzTest;

public static class AssemblyInitializeCultureTest
{
    [Before(Assembly)]
    public static void SetInvariantCulture()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
    }
}
