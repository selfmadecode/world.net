namespace World.Net.UnitTests.Countries;

public sealed class GreeceTest : AssertCountryTestBase
{
    private const string GREECE_COUNTRY_NAME = "Greece";
    private const string GREECE_NATIVE_NAME = "Ελλάδα";
    private const string GREECE_CAPITAL = "Athens";
    private const string GREECE_OFFICIAL_NAME = "Hellenic Republic";
    private const string GREECE_ISO2_CODE = "GR";
    private const string GREECE_ISO3_CODE = "GRC";
    private const int GREECE_NUMERIC_CODE = 300;
    private readonly string[] GREECE_CALLING_CODE = ["+30"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Greece;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Attica", "GR-I", "Region"),
        new("Central Greece", "GR-H", "Region"),
        new("Central Macedonia", "GR-B", "Region"),
        new("Crete", "GR-M", "Region"),
        new("Eastern Macedonia and Thrace", "GR-A", "Region"),
        new("Epirus", "GR-D", "Region"),
        new("Ionian Islands", "GR-F", "Region"),
        new("North Aegean", "GR-K", "Region"),
        new("Peloponnese", "GR-J", "Region"),
        new("South Aegean", "GR-L", "Region"),
        new("Thessaly", "GR-E", "Region"),
        new("Western Greece", "GR-G", "Region"),
        new("Western Macedonia", "GR-C", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGreece()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GREECE_COUNTRY_NAME,
            GREECE_OFFICIAL_NAME,
            GREECE_NATIVE_NAME,
            GREECE_CAPITAL,
            GREECE_NUMERIC_CODE,
            GREECE_ISO2_CODE,
            GREECE_ISO3_CODE,
            GREECE_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
