using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Screenshot file format used by the game's screenshot system.
/// </summary>
public enum ScreenshotFormat : byte
{
    /// <summary>BMP bitmap format.</summary>
    [Label("SFF_BMP")]
    Bmp = 0,

    /// <summary>JPEG compressed format.</summary>
    [Label("SFF_JPG")]
    Jpg = 1,

    /// <summary>TGA Targa format.</summary>
    [Label("SFF_TGA")]
    Tga = 2,

    /// <summary>PNG lossless format.</summary>
    [Label("SFF_PNG")]
    Png = 3,

    /// <summary>DDS DirectDraw Surface format.</summary>
    [Label("SFF_DDS")]
    Dds = 4,

    /// <summary>PPM portable pixmap format.</summary>
    [Label("SFF_PPM")]
    Ppm = 5,

    /// <summary>DIB device-independent bitmap.</summary>
    [Label("SFF_DIB")]
    Dib = 6,

    /// <summary>HDR high dynamic range format.</summary>
    [Label("SFF_HDR")]
    Hdr = 7,

    /// <summary>PFM portable float map format.</summary>
    [Label("SFF_PFM")]
    Pfm = 8,
}
