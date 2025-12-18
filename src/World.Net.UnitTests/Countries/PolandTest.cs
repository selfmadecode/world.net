namespace World.Net.UnitTests.Countries;

public sealed class PolandTest : AssertCountryTestBase
{
    private const string POLAND_COUNTRY_NAME = "Poland";
    private const string POLAND_NATIVE_NAME = "Rzeczpospolita Polska";
    private const string POLAND_CAPITAL = "Warsaw";
    private const string POLAND_OFFICIAL_NAME = "Republic of Poland";
    private const string POLAND_ISO2_CODE = "PL";
    private const string POLAND_ISO3_CODE = "POL";
    private const int POLAND_NUMERIC_CODE = 616;
    private readonly string[] POLAND_CALLING_CODE = ["+48"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Poland;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Greater Poland", "PL-WP", "Voivodeship"),
    new("Kuyavian-Pomeranian", "PL-KP", "Voivodeship"),
    new("Lesser Poland", "PL-MA", "Voivodeship"),
    new("Łódź", "PL-LD", "Voivodeship"),
    new("Lower Silesian", "PL-DS", "Voivodeship"),
    new("Lublin", "PL-LU", "Voivodeship"),
    new("Lubusz", "PL-LB", "Voivodeship"),
    new("Masovian", "PL-MZ", "Voivodeship"),
    new("Opole", "PL-OP", "Voivodeship"),
    new("Podlaskie", "PL-PD", "Voivodeship"),
    new("Pomeranian", "PL-PM", "Voivodeship"),
    new("Silesian", "PL-SL", "Voivodeship"),
    new("Subcarpathian", "PL-PK", "Voivodeship"),
    new("Świętokrzyskie", "PL-SK", "Voivodeship"),
    new("Warmian-Masurian", "PL-WN", "Voivodeship"),
    new("West Pomeranian", "PL-ZP", "Voivodeship")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPoland()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            POLAND_COUNTRY_NAME,
            POLAND_OFFICIAL_NAME,
            POLAND_NATIVE_NAME,
            POLAND_CAPITAL,
            POLAND_NUMERIC_CODE,
            POLAND_ISO2_CODE,
            POLAND_ISO3_CODE,
            POLAND_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
