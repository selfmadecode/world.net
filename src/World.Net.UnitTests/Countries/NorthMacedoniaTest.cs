namespace World.Net.UnitTests.Countries;

public sealed class NorthMacedoniaTest : AssertCountryTestBase
{
    private const string NORTH_MACEDONIA_COUNTRY_NAME = "North Macedonia";
    private const string NORTH_MACEDONIA_NATIVE_NAME = "Северна Македонија";
    private const string NORTH_MACEDONIA_CAPITAL = "Skopje";
    private const string NORTH_MACEDONIA_OFFICIAL_NAME = "Republic of North Macedonia";
    private const string NORTH_MACEDONIA_ISO2_CODE = "MK";
    private const string NORTH_MACEDONIA_ISO3_CODE = "MKD";
    private const int NORTH_MACEDONIA_NUMERIC_CODE = 807;
    private readonly string[] NORTH_MACEDONIA_CALLING_CODE = ["+389"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.NorthMacedonia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Eastern", "MK-01", "Region"),
    new("North Eastern", "MK-02", "Region"),
    new("Skopje", "MK-03", "Region"),
    new("Pelagonia", "MK-04", "Region"),
    new("Polog", "MK-05", "Region"),
    new("South Eastern", "MK-06", "Region"),
    new("South Western", "MK-07", "Region"),
    new("Vardar", "MK-08", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNorthMacedonia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NORTH_MACEDONIA_COUNTRY_NAME,
            NORTH_MACEDONIA_OFFICIAL_NAME,
            NORTH_MACEDONIA_NATIVE_NAME,
            NORTH_MACEDONIA_CAPITAL,
            NORTH_MACEDONIA_NUMERIC_CODE,
            NORTH_MACEDONIA_ISO2_CODE,
            NORTH_MACEDONIA_ISO3_CODE,
            NORTH_MACEDONIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
