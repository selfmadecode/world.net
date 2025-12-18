namespace World.Net.UnitTests.Countries;

public sealed class GhanaTest : AssertCountryTestBase
{
    private const string GHANA_COUNTRY_NAME = "Ghana";
    private const string GHANA_NATIVE_NAME = "Ghana";
    private const string GHANA_CAPITAL = "Accra";
    private const string GHANA_OFFICIAL_NAME = "Republic of Ghana";
    private const string GHANA_ISO2_CODE = "GH";
    private const string GHANA_ISO3_CODE = "GHA";
    private const int GHANA_NUMERIC_CODE = 288;
    private readonly string[] GHANA_CALLING_CODE = ["+233"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Ghana;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Ahafo", "GH-AF", "Region"),
        new("Ashanti", "GH-AH", "Region"),
        new("Bono", "GH-BO", "Region"),
        new("Bono East", "GH-BE", "Region"),
        new("Central", "GH-CP", "Region"),
        new("Eastern", "GH-EP", "Region"),
        new("Greater Accra", "GH-AA", "Region"),
        new("North East", "GH-NE", "Region"),
        new("Northern", "GH-NP", "Region"),
        new("Oti", "GH-OT", "Region"),
        new("Savannah", "GH-SV", "Region"),
        new("Upper East", "GH-UE", "Region"),
        new("Upper West", "GH-UW", "Region"),
        new("Volta", "GH-TV", "Region"),
        new("Western", "GH-WP", "Region"),
        new("Western North", "GH-WN", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGhana()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GHANA_COUNTRY_NAME,
            GHANA_OFFICIAL_NAME,
            GHANA_NATIVE_NAME,
            GHANA_CAPITAL,
            GHANA_NUMERIC_CODE,
            GHANA_ISO2_CODE,
            GHANA_ISO3_CODE,
            GHANA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
