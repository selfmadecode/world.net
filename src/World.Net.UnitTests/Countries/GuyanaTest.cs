namespace World.Net.UnitTests.Countries;

public sealed class GuyanaTest : AssertCountryTestBase
{
    private const string GUYANA_COUNTRY_NAME = "Guyana";
    private const string GUYANA_NATIVE_NAME = "Guyana";
    private const string GUYANA_CAPITAL = "Georgetown";
    private const string GUYANA_OFFICIAL_NAME = "Co-operative Republic of Guyana";
    private const string GUYANA_ISO2_CODE = "GY";
    private const string GUYANA_ISO3_CODE = "GUY";
    private const int GUYANA_NUMERIC_CODE = 328;
    private readonly string[] GUYANA_CALLING_CODE = ["+592"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Guyana;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Barima-Waini", "GY-BA", "Region"),
    new("Pomeroon-Supenaam", "GY-PT", "Region"),
    new("Essequibo Islands-West Demerara", "GY-ES", "Region"),
    new("Demerara-Mahaica", "GY-DE", "Region"),
    new("Mahaica-Berbice", "GY-MA", "Region"),
    new("East Berbice-Corentyne", "GY-EB", "Region"),
    new("Cuyuni-Mazaruni", "GY-CU", "Region"),
    new("Potaro-Siparuni", "GY-PT", "Region"),
    new("Upper Takutu-Upper Essequibo", "GY-UT", "Region"),
    new("Upper Demerara-Berbice", "GY-UD", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGuyana()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GUYANA_COUNTRY_NAME,
            GUYANA_OFFICIAL_NAME,
            GUYANA_NATIVE_NAME,
            GUYANA_CAPITAL,
            GUYANA_NUMERIC_CODE,
            GUYANA_ISO2_CODE,
            GUYANA_ISO3_CODE,
            GUYANA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
