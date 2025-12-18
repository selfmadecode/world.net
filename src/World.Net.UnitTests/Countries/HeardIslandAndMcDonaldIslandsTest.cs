namespace World.Net.UnitTests.Countries;

public sealed class HeardIslandAndMcDonaldIslandsTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Heard Island and McDonald Islands";
    private const string NATIVE_NAME = "Heard Island and McDonald Islands";
    private const string CAPITAL = "Atlas Cove";
    private const string OFFICIAL_NAME = "Heard Island and McDonald Islands";
    private const string ISO2_CODE = "HM";
    private const string ISO3_CODE = "HMD";
    private const int NUMERIC_CODE = 334;
    private readonly string[] CALLING_CODE = []; // No calling code
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.HeardIslandAndMcDonaldIslands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForHeardIslandAndMcDonaldIslands()
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
