using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// UI font type index, used by the canvas rendering system to select a predefined font style and color.
/// </summary>
public enum FontType : byte
{
    /// <summary>Basic white.</summary>
    [Label("FONT_BASIC_WHITE")]
    [Label("Basic White", 1)]
    BasicWhite = 0,

    /// <summary>Basic black.</summary>
    [Label("FONT_BASIC_BLACK")]
    [Label("Basic Black", 1)]
    BasicBlack = 1,

    /// <summary>Basic gray.</summary>
    [Label("FONT_BASIC_GRAY")]
    [Label("Basic Gray", 1)]
    BasicGray = 2,

    /// <summary>Basic yellow.</summary>
    [Label("FONT_BASIC_YELLOW")]
    [Label("Basic Yellow", 1)]
    BasicYellow = 3,

    /// <summary>Basic blue.</summary>
    [Label("FONT_BASIC_BLUE")]
    [Label("Basic Blue", 1)]
    BasicBlue = 4,

    /// <summary>Basic sky blue.</summary>
    [Label("FONT_BASIC_SKYBLUE")]
    [Label("Basic Sky Blue", 1)]
    BasicSkyBlue = 5,

    /// <summary>Basic red.</summary>
    [Label("FONT_BASIC_RED")]
    [Label("Basic Red", 1)]
    BasicRed = 6,

    /// <summary>Basic light green.</summary>
    [Label("FONT_BASIC_LIGHTGREEN")]
    [Label("Basic Light Green", 1)]
    BasicLightGreen = 7,

    /// <summary>Basic pink.</summary>
    [Label("FONT_BASIC_PINK")]
    [Label("Basic Pink", 1)]
    BasicPink = 8,

    /// <summary>Basic orange.</summary>
    [Label("FONT_BASIC_ORANGE")]
    [Label("Basic Orange", 1)]
    BasicOrange = 9,

    /// <summary>Basic red-violet.</summary>
    [Label("FONT_BASIC_REDVIOLET")]
    [Label("Basic Red Violet", 1)]
    BasicRedViolet = 10,

    /// <summary>Basic dim blue.</summary>
    [Label("FONT_BASIC_DIMBLUE")]
    [Label("Basic Dim Blue", 1)]
    BasicDimBlue = 11,

    /// <summary>Basic dim red.</summary>
    [Label("FONT_BASIC_DIMRED")]
    [Label("Basic Dim Red", 1)]
    BasicDimRed = 12,

    /// <summary>Basic dim green.</summary>
    [Label("FONT_BASIC_DIMGREEN")]
    [Label("Basic Dim Green", 1)]
    BasicDimGreen = 13,

    /// <summary>Basic brown.</summary>
    [Label("FONT_BASIC_BROWN")]
    [Label("Basic Brown", 1)]
    BasicBrown = 14,

    /// <summary>Basic light violet.</summary>
    [Label("FONT_BASIC_LIGHTVIOLET")]
    [Label("Basic Light Violet", 1)]
    BasicLightViolet = 15,

    /// <summary>Basic cyan.</summary>
    [Label("FONT_BASIC_CYAN")]
    [Label("Basic Cyan", 1)]
    BasicCyan = 16,

    /// <summary>Basic light gray.</summary>
    [Label("FONT_BASIC_LIGHTGRAY")]
    [Label("Basic Light Gray", 1)]
    BasicLightGray = 17,

    /// <summary>Basic dark gray.</summary>
    [Label("FONT_BASIC_DARKGRAY")]
    [Label("Basic Dark Gray", 1)]
    BasicDarkGray = 18,

    /// <summary>Basic dim gray.</summary>
    [Label("FONT_BASIC_DIMGRAY")]
    [Label("Basic Dim Gray", 1)]
    BasicDimGray = 19,

    /// <summary>Small black.</summary>
    [Label("FONT_SMALL_BLACK")]
    [Label("Small Black", 1)]
    SmallBlack = 20,

    /// <summary>Small black, bold.</summary>
    [Label("FONT_SMALL_BLACK_B")]
    [Label("Small Black Bold", 1)]
    SmallBlackBold = 21,

    /// <summary>Small white.</summary>
    [Label("FONT_SMALL_WHITE")]
    [Label("Small White", 1)]
    SmallWhite = 22,

    /// <summary>Small white, bold.</summary>
    [Label("FONT_SMALL_WHITE_B")]
    [Label("Small White Bold", 1)]
    SmallWhiteBold = 23,

    /// <summary>Small gray.</summary>
    [Label("FONT_SMALL_GRAY")]
    [Label("Small Gray", 1)]
    SmallGray = 24,

    /// <summary>Small gray, bold.</summary>
    [Label("FONT_SMALL_GRAY_B")]
    [Label("Small Gray Bold", 1)]
    SmallGrayBold = 25,

    /// <summary>Small white-gray.</summary>
    [Label("FONT_SMALL_WHITEGRAY")]
    [Label("Small White Gray", 1)]
    SmallWhiteGray = 26,

    /// <summary>Small white-gray, bold.</summary>
    [Label("FONT_SMALL_WHITEGRAY_B")]
    [Label("Small White Gray Bold", 1)]
    SmallWhiteGrayBold = 27,

    /// <summary>Small blue.</summary>
    [Label("FONT_SMALL_BLUE")]
    [Label("Small Blue", 1)]
    SmallBlue = 28,

    /// <summary>Small blue, bold.</summary>
    [Label("FONT_SMALL_BLUE_B")]
    [Label("Small Blue Bold", 1)]
    SmallBlueBold = 29,

    /// <summary>Small sky blue.</summary>
    [Label("FONT_SMALL_SKYBLUE")]
    [Label("Small Sky Blue", 1)]
    SmallSkyBlue = 30,

    /// <summary>Small sky blue, bold.</summary>
    [Label("FONT_SMALL_SKYBLUE_B")]
    [Label("Small Sky Blue Bold", 1)]
    SmallSkyBlueBold = 31,

    /// <summary>Small dim blue.</summary>
    [Label("FONT_SMALL_DIMBLUE")]
    [Label("Small Dim Blue", 1)]
    SmallDimBlue = 32,

    /// <summary>Small dim blue, bold.</summary>
    [Label("FONT_SMALL_DIMBLUE_B")]
    [Label("Small Dim Blue Bold", 1)]
    SmallDimBlueBold = 33,

    /// <summary>Small red.</summary>
    [Label("FONT_SMALL_RED")]
    [Label("Small Red", 1)]
    SmallRed = 34,

    /// <summary>Small red, bold.</summary>
    [Label("FONT_SMALL_RED_B")]
    [Label("Small Red Bold", 1)]
    SmallRedBold = 35,

    /// <summary>Small dim red.</summary>
    [Label("FONT_SMALL_DIMRED")]
    [Label("Small Dim Red", 1)]
    SmallDimRed = 36,

    /// <summary>Small dim red, bold.</summary>
    [Label("FONT_SMALL_DIMRED_B")]
    [Label("Small Dim Red Bold", 1)]
    SmallDimRedBold = 37,

    /// <summary>Small red-violet.</summary>
    [Label("FONT_SMALL_REDVIOLET")]
    [Label("Small Red Violet", 1)]
    SmallRedViolet = 38,

    /// <summary>Small red-violet, bold.</summary>
    [Label("FONT_SMALL_REDVIOLET_B")]
    [Label("Small Red Violet Bold", 1)]
    SmallRedVioletBold = 39,

    /// <summary>Small orange.</summary>
    [Label("FONT_SMALL_ORANGE")]
    [Label("Small Orange", 1)]
    SmallOrange = 40,

    /// <summary>Small orange, bold.</summary>
    [Label("FONT_SMALL_ORANGE_B")]
    [Label("Small Orange Bold", 1)]
    SmallOrangeBold = 41,

    /// <summary>Small dim green.</summary>
    [Label("FONT_SMALL_DIMGREEN")]
    [Label("Small Dim Green", 1)]
    SmallDimGreen = 42,

    /// <summary>Small dim green, bold.</summary>
    [Label("FONT_SMALL_DIMGREEN_B")]
    [Label("Small Dim Green Bold", 1)]
    SmallDimGreenBold = 43,

    /// <summary>Small yellow.</summary>
    [Label("FONT_SMALL_YELLOW")]
    [Label("Small Yellow", 1)]
    SmallYellow = 44,

    /// <summary>Small yellow, bold.</summary>
    [Label("FONT_SMALL_YELLOW_B")]
    [Label("Small Yellow Bold", 1)]
    SmallYellowBold = 45,

    /// <summary>Small light green.</summary>
    [Label("FONT_SMALL_LIGHTGREEN")]
    [Label("Small Light Green", 1)]
    SmallLightGreen = 46,

    /// <summary>Small light green, bold.</summary>
    [Label("FONT_SMALL_LIGHTGREEN_B")]
    [Label("Small Light Green Bold", 1)]
    SmallLightGreenBold = 47,

    /// <summary>Small dark gray.</summary>
    [Label("FONT_SMALL_DARKGRAY")]
    [Label("Small Dark Gray", 1)]
    SmallDarkGray = 48,

    /// <summary>Dialog text, normal.</summary>
    [Label("FONT_DLG_NORMAL")]
    [Label("Dlg Normal", 1)]
    DlgNormal = 49,

    /// <summary>Dialog text, background layer.</summary>
    [Label("FONT_DLG_BACK")]
    [Label("Dlg Back", 1)]
    DlgBack = 50,

    /// <summary>Dialog text, outline.</summary>
    [Label("FONT_DLG_OUTLINE")]
    [Label("Dlg Outline", 1)]
    DlgOutline = 51,

    /// <summary>Dialog text, fixed-width normal.</summary>
    [Label("FONT_DLG_NORMAL_FIXED_W")]
    [Label("Dlg Normal Fixed Width", 1)]
    DlgNormalFixedWidth = 52,

    /// <summary>Dialog text, fixed-width background.</summary>
    [Label("FONT_DLG_BACK_FIXED_W")]
    [Label("Dlg Back Fixed Width", 1)]
    DlgBackFixedWidth = 53,

    /// <summary>Dialog text, fixed-width outline.</summary>
    [Label("FONT_DLG_OUTLINE_FIXED_W")]
    [Label("Dlg Outline Fixed Width", 1)]
    DlgOutlineFixedWidth = 54,

    /// <summary>Numeric display, white.</summary>
    [Label("FONT_NO_WHITE")]
    [Label("Number White", 1)]
    NumberWhite = 55,

    /// <summary>Numeric display, black.</summary>
    [Label("FONT_NO_BLACK")]
    [Label("Number Black", 1)]
    NumberBlack = 56,

    /// <summary>Numeric display, black small.</summary>
    [Label("FONT_NO_BLACK_SMALL")]
    [Label("Number Black Small", 1)]
    NumberBlackSmall = 57,

    /// <summary>Numeric display, gray.</summary>
    [Label("FONT_NO_GRAY")]
    [Label("Number Gray", 1)]
    NumberGray = 58,

    /// <summary>Numeric display, yellow.</summary>
    [Label("FONT_NO_YELLOW")]
    [Label("Number Yellow", 1)]
    NumberYellow = 59,

    /// <summary>Numeric display, white background.</summary>
    [Label("FONT_NO_WHITE_BA")]
    [Label("Number White Background", 1)]
    NumberWhiteBackground = 60,

    /// <summary>Numeric display, black background.</summary>
    [Label("FONT_NO_BLACK_BA")]
    [Label("Number Black Background", 1)]
    NumberBlackBackground = 61,

    /// <summary>Numeric display, blue.</summary>
    [Label("FONT_NO_BLUE")]
    [Label("Number Blue", 1)]
    NumberBlue = 62,

    /// <summary>Numeric display, red.</summary>
    [Label("FONT_NO_RED")]
    [Label("Number Red", 1)]
    NumberRed = 63,

    /// <summary>Numeric display, blue bold.</summary>
    [Label("FONT_NO_BLUE_B")]
    [Label("Number Blue Bold", 1)]
    NumberBlueBold = 64,

    /// <summary>Numeric display, red bold.</summary>
    [Label("FONT_NO_RED_B")]
    [Label("Number Red Bold", 1)]
    NumberRedBold = 65,

    /// <summary>Big white.</summary>
    [Label("FONT_BIG_WHITE")]
    [Label("Big White", 1)]
    BigWhite = 66,

    /// <summary>Disabled state, gray.</summary>
    [Label("FONT_DISABLED_GRAY")]
    [Label("Disabled Gray", 1)]
    DisabledGray = 67,

    /// <summary>Disabled state, small gray.</summary>
    [Label("FONT_SMALL_DISABLED_GRAY")]
    [Label("Small Disabled Gray", 1)]
    SmallDisabledGray = 68,

    /// <summary>Basic black, bold.</summary>
    [Label("FONT_BASIC_BLACK_B")]
    [Label("Basic Black Bold", 1)]
    BasicBlackBold = 69,

    /// <summary>Basic blue, bold.</summary>
    [Label("FONT_BASIC_BLUE_B")]
    [Label("Basic Blue Bold", 1)]
    BasicBlueBold = 70,

    /// <summary>Basic red, bold.</summary>
    [Label("FONT_BASIC_RED_B")]
    [Label("Basic Red Bold", 1)]
    BasicRedBold = 71,

    /// <summary>Basic brown, bold.</summary>
    [Label("FONT_BASIC_BROWN_B")]
    [Label("Basic Brown Bold", 1)]
    BasicBrownBold = 72,

    /// <summary>Cash shop sale, red.</summary>
    [Label("FONT_SALE_RED")]
    [Label("Sale Red", 1)]
    SaleRed = 73,

    /// <summary>Cash shop sale, dark red.</summary>
    [Label("FONT_SALE_DARKRED")]
    [Label("Sale Dark Red", 1)]
    SaleDarkRed = 74,

    /// <summary>Standard white.</summary>
    [Label("FONT_STAN_WHITE")]
    [Label("Stan White", 1)]
    StanWhite = 75,

    /// <summary>Standard black.</summary>
    [Label("FONT_STAN_BLACK")]
    [Label("Stan Black", 1)]
    StanBlack = 76,

    /// <summary>Standard blue.</summary>
    [Label("FONT_STAN_BLUE")]
    [Label("Stan Blue", 1)]
    StanBlue = 77,

    /// <summary>Standard red.</summary>
    [Label("FONT_STAN_RED")]
    [Label("Stan Red", 1)]
    StanRed = 78,

    /// <summary>Standard orange.</summary>
    [Label("FONT_STAN_ORANGE")]
    [Label("Stan Orange", 1)]
    StanOrange = 79,

    /// <summary>Standard white, background.</summary>
    [Label("FONT_STAN_WHITE_BA")]
    [Label("Stan White Background", 1)]
    StanWhiteBackground = 80,

    /// <summary>Standard black, background.</summary>
    [Label("FONT_STAN_BLACK_BA")]
    [Label("Stan Black Background", 1)]
    StanBlackBackground = 81,

    /// <summary>Personal shop title 1.</summary>
    [Label("FONT_PERSONALSHOP_1")]
    [Label("Personal Shop1", 1)]
    PersonalShop1 = 82,

    /// <summary>Personal shop title 2.</summary>
    [Label("FONT_PERSONALSHOP_2")]
    [Label("Personal Shop2", 1)]
    PersonalShop2 = 83,

    /// <summary>Personal shop title 3.</summary>
    [Label("FONT_PERSONALSHOP_3")]
    [Label("Personal Shop3", 1)]
    PersonalShop3 = 84,

    /// <summary>Personal shop title 4.</summary>
    [Label("FONT_PERSONALSHOP_4")]
    [Label("Personal Shop4", 1)]
    PersonalShop4 = 85,

    /// <summary>Personal shop title 5.</summary>
    [Label("FONT_PERSONALSHOP_5")]
    [Label("Personal Shop5", 1)]
    PersonalShop5 = 86,

    /// <summary>Personal shop title 6.</summary>
    [Label("FONT_PERSONALSHOP_6")]
    [Label("Personal Shop6", 1)]
    PersonalShop6 = 87,

    /// <summary>Personal shop title 1, small.</summary>
    [Label("FONT_PERSONALSHOP_1_s")]
    [Label("Personal Shop1Small", 1)]
    PersonalShop1Small = 88,

    /// <summary>Personal shop title 2, small.</summary>
    [Label("FONT_PERSONALSHOP_2_s")]
    [Label("Personal Shop2Small", 1)]
    PersonalShop2Small = 89,

    /// <summary>Personal shop title 3, small.</summary>
    [Label("FONT_PERSONALSHOP_3_s")]
    [Label("Personal Shop3Small", 1)]
    PersonalShop3Small = 90,

    /// <summary>Personal shop title 4, small.</summary>
    [Label("FONT_PERSONALSHOP_4_s")]
    [Label("Personal Shop4Small", 1)]
    PersonalShop4Small = 91,

    /// <summary>Personal shop title 5, small.</summary>
    [Label("FONT_PERSONALSHOP_5_s")]
    [Label("Personal Shop5Small", 1)]
    PersonalShop5Small = 92,

    /// <summary>Personal shop title 6, small.</summary>
    [Label("FONT_PERSONALSHOP_6_s")]
    [Label("Personal Shop6Small", 1)]
    PersonalShop6Small = 93,

    /// <summary>Dodoomche 11pt, white.</summary>
    [Label("FONT_DODOOMCHE_11_WHITE")]
    Dodoomche11White = 94,

    /// <summary>Dodoomche 11pt, black.</summary>
    [Label("FONT_DODOOMCHE_11_BLACK")]
    Dodoomche11Black = 95,

    /// <summary>Dodoomche 11pt, 90% gray.</summary>
    [Label("FONT_DODOOMCHE_11_GRAY90")]
    Dodoomche11Gray90 = 96,

    /// <summary>Basic black, large.</summary>
    [Label("FONT_BASIC_BLACK_BIG")]
    [Label("Basic Black Big", 1)]
    BasicBlackBig = 97,

    /// <summary>Sentinel / count.</summary>
    [Label("FONT_NO")]
    No = 98,
}
