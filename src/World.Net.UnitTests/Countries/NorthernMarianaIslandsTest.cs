namespace World.Net.UnitTests.Countries;

public sealed class NorthernMarianaIslandsTest : AssertCountryTestBase
{
    private const string NORTHERN_MARIANA_ISLANDS_COUNTRY_NAME = "Northern Mariana Islands";
    private const string NORTHERN_MARIANA_ISLANDS_NATIVE_NAME = "Northern Mariana Islands";
    private const string NORTHERN_MARIANA_ISLANDS_CAPITAL = "Saipan";
    private const string NORTHERN_MARIANA_ISLANDS_OFFICIAL_NAME = "Commonwealth of the Northern Mariana Islands";
    private const string NORTHERN_MARIANA_ISLANDS_ISO2_CODE = "MP";
    private const string NORTHERN_MARIANA_ISLANDS_ISO3_CODE = "MNP";
    private const int NORTHERN_MARIANA_ISLANDS_NUMERIC_CODE = 580;
    private readonly string[] NORTHERN_MARIANA_ISLANDS_CALLING_CODE = ["+1-670"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.NorthernMarianaIslands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Saipan", "MP-SA", "Municipality"),
    new("Tinian", "MP-TI", "Municipality"),
    new("Rota", "MP-RO", "Municipality"),
    new("Northern Islands", "MP-NI", "Municipality")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNorthernMarianaIslands()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NORTHERN_MARIANA_ISLANDS_COUNTRY_NAME,
            NORTHERN_MARIANA_ISLANDS_OFFICIAL_NAME,
            NORTHERN_MARIANA_ISLANDS_NATIVE_NAME,
            NORTHERN_MARIANA_ISLANDS_CAPITAL,
            NORTHERN_MARIANA_ISLANDS_NUMERIC_CODE,
            NORTHERN_MARIANA_ISLANDS_ISO2_CODE,
            NORTHERN_MARIANA_ISLANDS_ISO3_CODE,
            NORTHERN_MARIANA_ISLANDS_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
