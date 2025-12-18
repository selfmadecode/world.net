namespace World.Net.UnitTests.Countries;

public sealed class HongKongTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Hong Kong";
    private const string NATIVE_NAME = "香港";
    private const string CAPITAL = "Hong Kong";
    private const string OFFICIAL_NAME = "Hong Kong Special Administrative Region of China";
    private const string ISO2_CODE = "HK";
    private const string ISO3_CODE = "HKG";
    private const int NUMERIC_CODE = 344;
    private readonly string[] CALLING_CODE = ["+852"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.HongKongSAR;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForHongKong()
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
