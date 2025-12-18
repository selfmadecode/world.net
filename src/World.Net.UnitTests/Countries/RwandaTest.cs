namespace World.Net.UnitTests.Countries;

public sealed class RwandaTest : AssertCountryTestBase
{
    private const string RWANDA_COUNTRY_NAME = "Rwanda";
    private const string RWANDA_NATIVE_NAME = "Rwanda";
    private const string RWANDA_CAPITAL = "Kigali";
    private const string RWANDA_OFFICIAL_NAME = "Republic of Rwanda";
    private const string RWANDA_ISO2_CODE = "RW";
    private const string RWANDA_ISO3_CODE = "RWA";
    private const int RWANDA_NUMERIC_CODE = 646;
    private readonly string[] RWANDA_CALLING_CODE = ["+250"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Rwanda;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Kigali", "RW-KI", "Province"),
    new("Eastern", "RW-ES", "Province"),
    new("Northern", "RW-NO", "Province"),
    new("Western", "RW-WE", "Province"),
    new("Southern", "RW-SO", "Province")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForRwanda()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            RWANDA_COUNTRY_NAME,
            RWANDA_OFFICIAL_NAME,
            RWANDA_NATIVE_NAME,
            RWANDA_CAPITAL,
            RWANDA_NUMERIC_CODE,
            RWANDA_ISO2_CODE,
            RWANDA_ISO3_CODE,
            RWANDA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
