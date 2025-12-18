namespace World.Net.UnitTests.Countries;

public sealed class GeorgiaTest : AssertCountryTestBase
{
    private const string GEORGIA_COUNTRY_NAME = "Georgia";
    private const string GEORGIA_NATIVE_NAME = "საქართველო";
    private const string GEORGIA_CAPITAL = "Tbilisi";
    private const string GEORGIA_OFFICIAL_NAME = "Georgia";
    private const string GEORGIA_ISO2_CODE = "GE";
    private const string GEORGIA_ISO3_CODE = "GEO";
    private const int GEORGIA_NUMERIC_CODE = 268;
    private readonly string[] GEORGIA_CALLING_CODE = ["+995"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Georgia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        // Autonomous Republics
        new("Abkhazia", "GE-AB", "Autonomous Republic"),
        new("Adjara", "GE-AJ", "Autonomous Republic"),

        // Regions
        new("Guria", "GE-GU", "Region"),
        new("Imereti", "GE-IM", "Region"),
        new("Kakheti", "GE-KA", "Region"),
        new("Kvemo Kartli", "GE-KK", "Region"),
        new("Mtskheta-Mtianeti", "GE-MM", "Region"),
        new("Racha-Lechkhumi and Kvemo Svaneti", "GE-RL", "Region"),
        new("Samegrelo-Zemo Svaneti", "GE-SZ", "Region"),
        new("Samtskhe-Javakheti", "GE-SJ", "Region"),
        new("Shida Kartli", "GE-SK", "Region"),

        // Capital city
        new("Tbilisi", "GE-TB", "City")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGeorgia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GEORGIA_COUNTRY_NAME,
            GEORGIA_OFFICIAL_NAME,
            GEORGIA_NATIVE_NAME,
            GEORGIA_CAPITAL,
            GEORGIA_NUMERIC_CODE,
            GEORGIA_ISO2_CODE,
            GEORGIA_ISO3_CODE,
            GEORGIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}

