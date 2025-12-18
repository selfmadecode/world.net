namespace World.Net.UnitTests.Countries;

public sealed class SaintHelenaTest : AssertCountryTestBase
{
    private const string SAINTHELENA_COUNTRY_NAME = "Saint Helena";
    private const string SAINTHELENA_NATIVE_NAME = "Saint Helena";
    private const string SAINTHELENA_CAPITAL = "Jamestown";
    private const string SAINTHELENA_OFFICIAL_NAME = "Saint Helena, Ascension and Tristan da Cunha";
    private const string SAINTHELENA_ISO2_CODE = "SH";
    private const string SAINTHELENA_ISO3_CODE = "SHN";
    private const int SAINTHELENA_NUMERIC_CODE = 654;
    private readonly string[] SAINTHELENA_CALLING_CODE = ["+290"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintHelena;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Saint Helena", "SH-HL", "District"),
    new("Ascension", "SH-AC", "District"),
    new("Tristan da Cunha", "SH-TR", "District")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSaintHelena()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            SAINTHELENA_COUNTRY_NAME,
            SAINTHELENA_OFFICIAL_NAME,
            SAINTHELENA_NATIVE_NAME,
            SAINTHELENA_CAPITAL,
            SAINTHELENA_NUMERIC_CODE,
            SAINTHELENA_ISO2_CODE,
            SAINTHELENA_ISO3_CODE,
            SAINTHELENA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
