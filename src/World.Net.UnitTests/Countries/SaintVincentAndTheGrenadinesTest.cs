
namespace World.Net.UnitTests.Countries;

public sealed class SaintVincentAndTheGrenadinesTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Saint Vincent and the Grenadines";
    private const string NATIVE_NAME = "Saint Vincent and the Grenadines";
    private const string CAPITAL = "Kingstown";
    private const string OFFICIAL_NAME = "Saint Vincent and the Grenadines";
    private const string ISO2_CODE = "VC";
    private const string ISO3_CODE = "VCT";
    private const int NUMERIC_CODE = 670;
    private readonly string[] CALLING_CODE = ["+1-784"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintVincentAndTheGrenadines;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Charlotte", "VC-C", "Parish"),
    new("Saint Andrew", "VC-A", "Parish"),
    new("Saint David", "VC-D", "Parish"),
    new("Saint George", "VC-G", "Parish"),
    new("Saint Patrick", "VC-P", "Parish"),
    new("Grenadines", "VC-VG", "Parish")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSaintVincentAndTheGrenadines()
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
