namespace World.Net.UnitTests.Countries;

public sealed class TheBahamasTest : AssertCountryTestBase
{
    private const string THEBAHAMAS_COUNTRY_NAME = "The Bahamas";
    private const string THEBAHAMAS_NATIVE_NAME = "Bahamas";
    private const string THEBAHAMAS_CAPITAL = "Nassau";
    private const string THEBAHAMAS_OFFICIAL_NAME = "Commonwealth of the Bahamas";
    private const string THEBAHAMAS_ISO2_CODE = "BS";
    private const string THEBAHAMAS_ISO3_CODE = "BHS";
    private const int THEBAHAMAS_NUMERIC_CODE = 044;
    private readonly string[] THEBAHAMAS_CALLING_CODE = ["+1 242"];
    private const int THEBAHAMAS_STATE_COUNT = 42;
    private static readonly string[] VALID_STATE_TYPES = { "District", "Island" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.Bahamas;
    private readonly static (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
         ("Acklins", "AK", "District"),
        ("Acklins and Crooked Islands", "AC", "District"),
        ("Berry Islands", "BY", "District"),
        ("Bimini", "BI", "District"),
        ("Black Point", "BP", "District"),
        ("Cat Island", "CI", "District"),
        ("Central Abaco", "CO", "District"),
        ("Central Andros", "CS", "District"),
        ("Central Eleuthera", "CE", "District"),
        ("Crooked Island", "CK", "District"),
        ("East Grand Bahama", "EG", "District"),
        ("Exuma", "EX", "District"),
        ("Freeport", "FP", "District"),
        ("Fresh Creek", "FC", "District"),
        ("Governor’s Harbour", "GH", "District"),
        ("Grand Cay", "GC", "District"),
        ("Green Turtle Cay", "GT", "District"),
        ("Harbour Island", "HI", "District"),
        ("High Rock", "HR", "District"),
        ("Hope Town", "HT", "District"),
        ("Inagua", "IN", "District"),
        ("Kemps Bay", "KB", "District"),
        ("Long Island", "LI", "District"),
        ("Mangrove Cay", "MC", "District"),
        ("Marsh Harbour", "MH", "District"),
        ("Mayaguana", "MG", "District"),
        ("New Providence", "NP", "Island"),
        ("Nichollstown and Berry Islands", "NB", "District"),
        ("North Abaco", "NO", "District"),
        ("North Andros", "NS", "District"),
        ("North Eleuthera", "NE", "District"),
        ("Ragged Island", "RI", "District"),
        ("Rock Sound", "RS", "District"),
        ("Rum Cay", "RC", "District"),
        ("San Salvador and Rum Cay", "SR", "District"),
        ("San Salvador Island", "SS", "District"),
        ("Sandy Point", "SP", "District"),
        ("South Abaco", "SO", "District"),
        ("South Andros", "SA", "District"),
        ("South Eleuthera", "SE", "District"),
        ("Spanish Wells", "SW", "District"),
        ("West Grand Bahama", "WG", "District")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTheBahamas()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        Assert.Equal(THEBAHAMAS_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));

        AssertCorrectInformation(
            country,
            ExpectedId,
            THEBAHAMAS_COUNTRY_NAME,
            THEBAHAMAS_OFFICIAL_NAME,
            THEBAHAMAS_NATIVE_NAME,
            THEBAHAMAS_CAPITAL,
            THEBAHAMAS_NUMERIC_CODE,
            THEBAHAMAS_ISO2_CODE,
            THEBAHAMAS_ISO3_CODE,
            THEBAHAMAS_CALLING_CODE,
            ExpectedStates
        );
    }
}
