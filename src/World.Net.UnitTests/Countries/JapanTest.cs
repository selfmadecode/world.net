namespace World.Net.UnitTests.Countries;
public sealed class JapanTest : AssertCountryTestBase
{
    private const string JAPAN_COUNTRY_NAME = "Japan";
    private const string JAPAN_NATIVE_NAME = "日本";
    private const string JAPAN_CAPITAL = "Tokyo";
    private const string JAPAN_OFFICIAL_NAME = "Japan";
    private const string JAPAN_ISO2_CODE = "JP";
    private const string JAPAN_ISO3_CODE = "JPN";
    private const int JAPAN_NUMERIC_CODE = 392;
    private readonly string[] JAPAN_CALLING_CODE = ["+81"];
    private static readonly string[] VALID_STATE_TYPES = { "Prefecture" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.Japan;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
        ("Aichi", "JP-23", "Prefecture"),
        ("Akita", "JP-05", "Prefecture"),
        ("Aomori", "JP-02", "Prefecture"),
        ("Chiba", "JP-12", "Prefecture"),
        ("Ehime", "JP-38", "Prefecture"),
        ("Fukui", "JP-18", "Prefecture"),
        ("Fukuoka", "JP-40", "Prefecture"),
        ("Fukushima", "JP-07", "Prefecture"),
        ("Gifu", "JP-21", "Prefecture"),
        ("Gunma", "JP-10", "Prefecture"),
        ("Hiroshima", "JP-34", "Prefecture"),
        ("Hokkaidō", "JP-01", "Prefecture"),
        ("Hyōgo", "JP-28", "Prefecture"),
        ("Ibaraki", "JP-08", "Prefecture"),
        ("Ishikawa", "JP-17", "Prefecture"),
        ("Iwate", "JP-03", "Prefecture"),
        ("Kagawa", "JP-37", "Prefecture"),
        ("Kagoshima", "JP-46", "Prefecture"),
        ("Kanagawa", "JP-14", "Prefecture"),
        ("Kōchi", "JP-39", "Prefecture"),
        ("Kumamoto", "JP-43", "Prefecture"),
        ("Kyōto", "JP-26", "Prefecture"),
        ("Mie", "JP-24", "Prefecture"),
        ("Miyagi", "JP-04", "Prefecture"),
        ("Miyazaki", "JP-45", "Prefecture"),
        ("Nagano", "JP-20", "Prefecture"),
        ("Nagasaki", "JP-42", "Prefecture"),
        ("Nara", "JP-29", "Prefecture"),
        ("Niigata", "JP-15", "Prefecture"),
        ("Ōita", "JP-44", "Prefecture"),
        ("Okayama", "JP-33", "Prefecture"),
        ("Okinawa", "JP-47", "Prefecture"),
        ("Ōsaka", "JP-27", "Prefecture"),
        ("Saga", "JP-41", "Prefecture"),
        ("Saitama", "JP-11", "Prefecture"),
        ("Shiga", "JP-25", "Prefecture"),
        ("Shimane", "JP-32", "Prefecture"),
        ("Shizuoka", "JP-22", "Prefecture"),
        ("Tochigi", "JP-09", "Prefecture"),
        ("Tokushima", "JP-36", "Prefecture"),
        ("Tokyo", "JP-13", "Prefecture"),
        ("Tottori", "JP-31", "Prefecture"),
        ("Toyama", "JP-16", "Prefecture"),
        ("Wakayama", "JP-30", "Prefecture"),
        ("Yamagata", "JP-06", "Prefecture"),
        ("Yamaguchi", "JP-35", "Prefecture"),
        ("Yamanashi", "JP-19", "Prefecture")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJapan()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        Assert.NotNull(country);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));

        AssertCorrectInformation(
            country,
            ExpectedId,
            JAPAN_COUNTRY_NAME,
            JAPAN_OFFICIAL_NAME,
            JAPAN_NATIVE_NAME,
            JAPAN_CAPITAL,
            JAPAN_NUMERIC_CODE,
            JAPAN_ISO2_CODE,
            JAPAN_ISO3_CODE,
            JAPAN_CALLING_CODE,
            ExpectedStates
        );
    }
}
