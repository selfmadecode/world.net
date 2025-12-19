namespace World.Net.UnitTests.Countries;

public sealed class SomaliaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Somalia";
    private const string NATIVE_NAME = "Soomaaliya";
    private const string CAPITAL = "Mogadishu";
    private const string OFFICIAL_NAME = "Federal Republic of Somalia";
    private const string ISO2_CODE = "SO";
    private const string ISO3_CODE = "SOM";
    private const int NUMERIC_CODE = 706;
    private readonly string[] CALLING_CODE = ["+252"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Somalia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Awdal", "SO-AW", "Region"),
    ("Bakool", "SO-BK", "Region"),
    ("Banaadir", "SO-BN", "Region"),
    ("Bari", "SO-BR", "Region"),
    ("Bay", "SO-BY", "Region"),
    ("Galguduud", "SO-GA", "Region"),
    ("Gedo", "SO-GE", "Region"),
    ("Hiran", "SO-HI", "Region"),
    ("Lower Juba", "SO-JH", "Region"),
    ("Middle Juba", "SO-JD", "Region"),
    ("Mudug", "SO-MU", "Region"),
    ("Nugal", "SO-NU", "Region"),
    ("Sanaag", "SO-SA", "Region"),
    ("Middle Shabelle", "SO-SD", "Region"),
    ("Lower Shabelle", "SO-SH", "Region"),
    ("Sool", "SO-SO", "Region"),
    ("Togdheer", "SO-TO", "Region"),
    ("Woqooyi Galbeed", "SO-WO", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSomalia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            COUNTRY_NAME,
            OFFICIAL_NAME,
            NATIVE_NAME,
            CAPITAL,
            NUMERIC_CODE,
            ISO2_CODE,
            ISO3_CODE,
            CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
