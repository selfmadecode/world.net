namespace World.Net.UnitTests.Countries;

public sealed class ReunionTest : AssertCountryTestBase
{
    private const string REUNION_COUNTRY_NAME = "Réunion";
    private const string REUNION_NATIVE_NAME = "Réunion";
    private const string REUNION_CAPITAL = "Saint-Denis";
    private const string REUNION_OFFICIAL_NAME = "Réunion";
    private const string REUNION_ISO2_CODE = "RE";
    private const string REUNION_ISO3_CODE = "REU";
    private const int REUNION_NUMERIC_CODE = 638;
    private readonly string[] REUNION_CALLING_CODE = ["+262"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Reunion;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Réunion", "RE-RE", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForReunion()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            REUNION_COUNTRY_NAME,
            REUNION_OFFICIAL_NAME,
            REUNION_NATIVE_NAME,
            REUNION_CAPITAL,
            REUNION_NUMERIC_CODE,
            REUNION_ISO2_CODE,
            REUNION_ISO3_CODE,
            REUNION_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
