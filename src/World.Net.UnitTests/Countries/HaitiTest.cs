namespace World.Net.UnitTests.Countries;

public sealed class HaitiTest : AssertCountryTestBase
{
    private const string HAITI_COUNTRY_NAME = "Haiti";
    private const string HAITI_NATIVE_NAME = "Haïti";
    private const string HAITI_CAPITAL = "Port-au-Prince";
    private const string HAITI_OFFICIAL_NAME = "Republic of Haiti";
    private const string HAITI_ISO2_CODE = "HT";
    private const string HAITI_ISO3_CODE = "HTI";
    private const int HAITI_NUMERIC_CODE = 332;
    private readonly string[] HAITI_CALLING_CODE = ["+509"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Haiti;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Artibonite", "HT-AR", "Department"),
        new("Centre", "HT-CE", "Department"),
        new("Grand'Anse", "HT-GA", "Department"),
        new("Nippes", "HT-NI", "Department"),
        new("Nord", "HT-NO", "Department"),
        new("Nord-Est", "HT-NE", "Department"),
        new("Nord-Ouest", "HT-NW", "Department"),
        new("Ouest", "HT-OU", "Department"),
        new("Sud", "HT-SD", "Department"),
        new("Sud-Est", "HT-SE", "Department")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForHaiti()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            HAITI_COUNTRY_NAME,
            HAITI_OFFICIAL_NAME,
            HAITI_NATIVE_NAME,
            HAITI_CAPITAL,
            HAITI_NUMERIC_CODE,
            HAITI_ISO2_CODE,
            HAITI_ISO3_CODE,
            HAITI_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
