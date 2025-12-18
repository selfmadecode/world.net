namespace World.Net.UnitTests.Countries;

public sealed class PapuaNewGuineaTest : AssertCountryTestBase
{
    private const string PNG_COUNTRY_NAME = "Papua New Guinea";
    private const string PNG_NATIVE_NAME = "Papua Niugini";
    private const string PNG_CAPITAL = "Port Moresby";
    private const string PNG_OFFICIAL_NAME = "Independent State of Papua New Guinea";
    private const string PNG_ISO2_CODE = "PG";
    private const string PNG_ISO3_CODE = "PNG";
    private const int PNG_NUMERIC_CODE = 598;
    private readonly string[] PNG_CALLING_CODE = ["+675"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.PapuaNewGuinea;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Central", "PG-CN", "Province"),
    new("Gulf", "PG-GL", "Province"),
    new("Milne Bay", "PG-MB", "Province"),
    new("Northern", "PG-NB", "Province"),
    new("Southern Highlands", "PG-SH", "Province"),
    new("Western", "PG-WP", "Province"),
    new("Western Highlands", "PG-WH", "Province"),
    new("Enga", "PG-EN", "Province"),
    new("Eastern Highlands", "PG-EH", "Province"),
    new("Hela", "PG-HE", "Province"),
    new("Morobe", "PG-MO", "Province"),
    new("Madang", "PG-MD", "Province"),
    new("New Ireland", "PG-NI", "Province"),
    new("East New Britain", "PG-EB", "Province"),
    new("West New Britain", "PG-WB", "Province"),
    new("Manus", "PG-MA", "Province"),
    new("Bougainville", "PG-BA", "Autonomous Region"),
    new("Chimbu", "PG-CP", "Province"),
    new("Oro", "PG-OR", "Province"),
    new("Sandaun", "PG-SO", "Province"),
    new("Central", "PG-CE", "Province"),
    new("National Capital District", "PG-NCD", "District")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPapuaNewGuinea()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PNG_COUNTRY_NAME,
            PNG_OFFICIAL_NAME,
            PNG_NATIVE_NAME,
            PNG_CAPITAL,
            PNG_NUMERIC_CODE,
            PNG_ISO2_CODE,
            PNG_ISO3_CODE,
            PNG_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
