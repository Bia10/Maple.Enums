using Maple.Enums;

Console.WriteLine($"Maple.Enums version: {typeof(EnumDisplayExtensions).Assembly.GetName().Version}");
Console.WriteLine(Job.WhiteKnight.GetDisplayLabel());
Console.WriteLine("OK");
