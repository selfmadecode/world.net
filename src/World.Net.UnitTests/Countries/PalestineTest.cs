namespace World.Net.UnitTests.Countries;

public sealed class PalestineTest : AssertCountryTestBase
{
    private const string PALESTINE_COUNTRY_NAME = "Palestinian Territory, Occupied";
    private const string PALESTINE_NATIVE_NAME = "دولة فلسطين";
    private const string PALESTINE_CAPITAL = "Ramallah";
    private const string PALESTINE_OFFICIAL_NAME = "State of Palestine";
    private const string PALESTINE_ISO2_CODE = "PS";
    private const string PALESTINE_ISO3_CODE = "PSE";
    private const int PALESTINE_NUMERIC_CODE = 275;
    private readonly string[] PALESTINE_CALLING_CODE = ["+970"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.PalestinianTerritoryOccupied;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Gaza", "PS-GA", "Governorate"),
    new("West Bank", "PS-WB", "Governorate")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPalestine()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PALESTINE_COUNTRY_NAME,
            PALESTINE_OFFICIAL_NAME,
            PALESTINE_NATIVE_NAME,
            PALESTINE_CAPITAL,
            PALESTINE_NUMERIC_CODE,
            PALESTINE_ISO2_CODE,
            PALESTINE_ISO3_CODE,
            PALESTINE_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
