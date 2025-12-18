namespace World.Net.UnitTests.Countries;

public sealed class NorfolkIslandTest : AssertCountryTestBase
{
    private const string NORFOLK_ISLAND_COUNTRY_NAME = "Norfolk Island";
    private const string NORFOLK_ISLAND_NATIVE_NAME = "Norfolk Island";
    private const string NORFOLK_ISLAND_CAPITAL = "Kingston";
    private const string NORFOLK_ISLAND_OFFICIAL_NAME = "Territory of Norfolk Island";
    private const string NORFOLK_ISLAND_ISO2_CODE = "NF";
    private const string NORFOLK_ISLAND_ISO3_CODE = "NFK";
    private const int NORFOLK_ISLAND_NUMERIC_CODE = 574;
    private readonly string[] NORFOLK_ISLAND_CALLING_CODE = ["+672"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.NorfolkIsland;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Anson Bay", "NF-01", "Settlement"),
        new("Ball Bay", "NF-02", "Settlement"),
        new("Bicentennial", "NF-03", "Settlement"),
        new("Burnt Pine", "NF-04", "Settlement"),
        new("Cascade", "NF-05", "Settlement"),
        new("Kingston", "NF-06", "Settlement"),
        new("Longridge", "NF-07", "Settlement"),
        new("Mount Pitt", "NF-08", "Settlement"),
        new("Queen Elizabeth", "NF-09", "Settlement"),
        new("Royal", "NF-10", "Settlement"),
        new("Suffolk", "NF-11", "Settlement")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNorfolkIsland()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NORFOLK_ISLAND_COUNTRY_NAME,
            NORFOLK_ISLAND_OFFICIAL_NAME,
            NORFOLK_ISLAND_NATIVE_NAME,
            NORFOLK_ISLAND_CAPITAL,
            NORFOLK_ISLAND_NUMERIC_CODE,
            NORFOLK_ISLAND_ISO2_CODE,
            NORFOLK_ISLAND_ISO3_CODE,
            NORFOLK_ISLAND_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}

