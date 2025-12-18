namespace World.Net.UnitTests.Countries;

public sealed class SaintBarthelemyTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Saint-Barthélemy";
    private const string NATIVE_NAME = "Saint-Barthélemy";
    private const string CAPITAL = "Gustavia";
    private const string OFFICIAL_NAME = "Collectivity of Saint-Barthélemy";
    private const string ISO2_CODE = "BL";
    private const string ISO3_CODE = "BLM";
    private const int NUMERIC_CODE = 652;
    private readonly string[] CALLING_CODE = ["+590"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintBarthelemy;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Saint-Barthélemy", "BL-BL", "Territory")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSaintBarthelemy()
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
