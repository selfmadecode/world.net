namespace World.Net.UnitTests.Countries;

public sealed class SaintPierreAndMiquelonTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Saint Pierre and Miquelon";
    private const string NATIVE_NAME = "Saint Pierre and Miquelon";
    private const string CAPITAL = "Saint-Pierre";
    private const string OFFICIAL_NAME = "Saint Pierre and Miquelon";
    private const string ISO2_CODE = "PM";
    private const string ISO3_CODE = "SPM";
    private const int NUMERIC_CODE = 666;
    private readonly string[] CALLING_CODE = ["+508"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintPierreAndMiquelon;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Saint-Pierre", "PM-SP", "Commune"),
    new("Miquelon-Langlade", "PM-MQ", "Commune")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSaintPierreAndMiquelon()
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
