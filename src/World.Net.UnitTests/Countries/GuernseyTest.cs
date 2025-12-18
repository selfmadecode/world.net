namespace World.Net.UnitTests.Countries;

public sealed class GuernseyTest : AssertCountryTestBase
{
    private const string GUERNSEY_COUNTRY_NAME = "Guernsey";
    private const string GUERNSEY_NATIVE_NAME = "Guernsey";
    private const string GUERNSEY_CAPITAL = "St. Peter Port";
    private const string GUERNSEY_OFFICIAL_NAME = "Guernsey";
    private const string GUERNSEY_ISO2_CODE = "GG";
    private const string GUERNSEY_ISO3_CODE = "GGY";
    private const int GUERNSEY_NUMERIC_CODE = 831;
    private readonly string[] GUERNSEY_CALLING_CODE = ["+44-1481"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.GuernseyAndAlderney;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGuernsey()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GUERNSEY_COUNTRY_NAME,
            GUERNSEY_OFFICIAL_NAME,
            GUERNSEY_NATIVE_NAME,
            GUERNSEY_CAPITAL,
            GUERNSEY_NUMERIC_CODE,
            GUERNSEY_ISO2_CODE,
            GUERNSEY_ISO3_CODE,
            GUERNSEY_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
