namespace World.Net.UnitTests.Countries;

public sealed class SouthGeorgiaAndTheSouthSandwichIslandsTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "South Georgia and the South Sandwich Islands";
    private const string NATIVE_NAME = "South Georgia and the South Sandwich Islands";
    private const string CAPITAL = "King Edward Point";
    private const string OFFICIAL_NAME = "South Georgia and the South Sandwich Islands";
    private const string ISO2_CODE = "GS";
    private const string ISO3_CODE = "SGS";
    private const int NUMERIC_CODE = 239;
    private readonly string[] CALLING_CODE = [];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SouthGeorgia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSouthGeorgiaAndTheSouthSandwichIslands()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            COUNTRY_NAME,
            OFFICIAL_NAME,
            NATIVE_NAME,
            CAPITAL,
            NUMERIC_CODE,
            ISO2_CODE,
            ISO3_CODE,
            CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
