namespace World.Net.UnitTests.Countries;

public sealed class PalauTest : AssertCountryTestBase
{
    private const string PALAU_COUNTRY_NAME = "Palau";
    private const string PALAU_NATIVE_NAME = "Belau";
    private const string PALAU_CAPITAL = "Ngerulmud";
    private const string PALAU_OFFICIAL_NAME = "Republic of Palau";
    private const string PALAU_ISO2_CODE = "PW";
    private const string PALAU_ISO3_CODE = "PLW";
    private const int PALAU_NUMERIC_CODE = 585;
    private readonly string[] PALAU_CALLING_CODE = ["+680"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Palau;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Aimeliik", "PW-002", "State"),
    new("Airai", "PW-004", "State"),
    new("Angaur", "PW-010", "State"),
    new("Hatohobei", "PW-050", "State"),
    new("Kayangel", "PW-100", "State"),
    new("Koror", "PW-150", "State"),
    new("Melekeok", "PW-212", "State"),
    new("Ngaraard", "PW-214", "State"),
    new("Ngarchelong", "PW-218", "State"),
    new("Ngardmau", "PW-222", "State"),
    new("Ngatpang", "PW-224", "State"),
    new("Ngchesar", "PW-226", "State"),
    new("Ngeremlengui", "PW-227", "State"),
    new("Ngiwal", "PW-228", "State"),
    new("Peleliu", "PW-350", "State"),
    new("Sonsorol", "PW-370", "State")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPalau()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PALAU_COUNTRY_NAME,
            PALAU_OFFICIAL_NAME,
            PALAU_NATIVE_NAME,
            PALAU_CAPITAL,
            PALAU_NUMERIC_CODE,
            PALAU_ISO2_CODE,
            PALAU_ISO3_CODE,
            PALAU_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
