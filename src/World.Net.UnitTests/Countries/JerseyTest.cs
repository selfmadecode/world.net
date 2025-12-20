namespace World.Net.UnitTests.Countries;
public sealed class JerseyTest : AssertCountryTestBase
{
    private const string JERSEY_COUNTRY_NAME = "Jersey";
    private const string JERSEY_NATIVE_NAME = "Jersey";
    private const string JERSEY_CAPITAL = "Saint Helier";
    private const string JERSEY_OFFICIAL_NAME = "Bailiwick of Jersey";
    private const string JERSEY_ISO2_CODE = "JE";
    private const string JERSEY_ISO3_CODE = "JEY";
    private const int JERSEY_NUMERIC_CODE = 832;
    private readonly string[] JERSEY_CALLING_CODE = ["+44"];
    private static readonly string[] VALID_STATE_TYPES = { "parish" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.Jersey;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Grouville", "JE-01", "parish"),
        ("St Brelade", "JE-02", "parish"),
        ("St Clement", "JE-03", "parish"),
        ("St Helier", "JE-04", "parish"),
        ("St John", "JE-05", "parish"),
        ("St Lawrence", "JE-06", "parish"),
        ("St Martin", "JE-07", "parish"),
        ("St Mary", "JE-08", "parish"),
        ("St Ouen", "JE-09", "parish"),
        ("St Peter", "JE-10", "parish"),
        ("St Saviour", "JE-11", "parish"),
        ("Trinity", "JE-12", "parish"),
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJersey()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));

        AssertCorrectInformation(
            country,
            ExpectedId,
            JERSEY_COUNTRY_NAME,
            JERSEY_OFFICIAL_NAME,
            JERSEY_NATIVE_NAME,
            JERSEY_CAPITAL,
            JERSEY_NUMERIC_CODE,
            JERSEY_ISO2_CODE,
            JERSEY_ISO3_CODE,
            JERSEY_CALLING_CODE,
            ExpectedStates
        );
    }
}
