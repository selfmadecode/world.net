namespace World.Net.UnitTests.Countries;

public sealed class PhilippinesTest : AssertCountryTestBase
{
    private const string PH_COUNTRY_NAME = "Philippines";
    private const string PH_NATIVE_NAME = "Republika ng Pilipinas";
    private const string PH_CAPITAL = "Manila";
    private const string PH_OFFICIAL_NAME = "Republic of the Philippines";
    private const string PH_ISO2_CODE = "PH";
    private const string PH_ISO3_CODE = "PHL";
    private const int PH_NUMERIC_CODE = 608;
    private readonly string[] PH_CALLING_CODE = ["+63"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Philippines;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Ilocos Region", "PH-01", "Region"),
    new("Cagayan Valley", "PH-02", "Region"),
    new("Central Luzon", "PH-03", "Region"),
    new("CALABARZON", "PH-04", "Region"),
    new("MIMAROPA", "PH-05", "Region"),
    new("Bicol Region", "PH-06", "Region"),
    new("Western Visayas", "PH-07", "Region"),
    new("Central Visayas", "PH-08", "Region"),
    new("Eastern Visayas", "PH-09", "Region"),
    new("Zamboanga Peninsula", "PH-10", "Region"),
    new("Northern Mindanao", "PH-11", "Region"),
    new("Davao Region", "PH-12", "Region"),
    new("SOCCSKSARGEN", "PH-13", "Region"),
    new("Caraga", "PH-14", "Region"),
    new("Bangsamoro Autonomous Region in Muslim Mindanao", "PH-15", "Autonomous Region"),
    new("Cordillera Administrative Region", "PH-16", "Region"),
    new("National Capital Region", "PH-NCR", "Capital Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPhilippines()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PH_COUNTRY_NAME,
            PH_OFFICIAL_NAME,
            PH_NATIVE_NAME,
            PH_CAPITAL,
            PH_NUMERIC_CODE,
            PH_ISO2_CODE,
            PH_ISO3_CODE,
            PH_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
