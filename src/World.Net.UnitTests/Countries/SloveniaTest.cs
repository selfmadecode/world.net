
namespace World.Net.UnitTests.Countries;

public sealed class SloveniaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Slovenia";
    private const string NATIVE_NAME = "Slovenija";
    private const string CAPITAL = "Ljubljana";
    private const string OFFICIAL_NAME = "Republic of Slovenia";
    private const string ISO2_CODE = "SI";
    private const string ISO3_CODE = "SVN";
    private const int NUMERIC_CODE = 705;
    private readonly string[] CALLING_CODE = ["+386"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Slovenia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSlovenia()
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
