namespace World.Net.UnitTests.Countries;

public sealed class GuineaTest : AssertCountryTestBase
{
    private const string GUINEA_COUNTRY_NAME = "Guinea";
    private const string GUINEA_NATIVE_NAME = "Guinée";
    private const string GUINEA_CAPITAL = "Conakry";
    private const string GUINEA_OFFICIAL_NAME = "Republic of Guinea";
    private const string GUINEA_ISO2_CODE = "GN";
    private const string GUINEA_ISO3_CODE = "GIN";
    private const int GUINEA_NUMERIC_CODE = 324;
    private readonly string[] GUINEA_CALLING_CODE = ["+224"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Guinea;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Boké", "GN-B", "Region"),
        new("Conakry", "GN-C", "Region"),
        new("Faranah", "GN-F", "Region"),
        new("Kankan", "GN-K", "Region"),
        new("Kindia", "GN-D", "Region"),
        new("Labé", "GN-L", "Region"),
        new("Mamou", "GN-M", "Region"),
        new("Nzérékoré", "GN-N", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGuinea()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GUINEA_COUNTRY_NAME,
            GUINEA_OFFICIAL_NAME,
            GUINEA_NATIVE_NAME,
            GUINEA_CAPITAL,
            GUINEA_NUMERIC_CODE,
            GUINEA_ISO2_CODE,
            GUINEA_ISO3_CODE,
            GUINEA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
