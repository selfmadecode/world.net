namespace World.Net.UnitTests.Countries;

public sealed class GermanyTest : AssertCountryTestBase
{
    private const string GERMANY_COUNTRY_NAME = "Germany";
    private const string GERMANY_NATIVE_NAME = "Deutschland";
    private const string GERMANY_CAPITAL = "Berlin";
    private const string GERMANY_OFFICIAL_NAME = "Federal Republic of Germany";
    private const string GERMANY_ISO2_CODE = "DE";
    private const string GERMANY_ISO3_CODE = "DEU";
    private const int GERMANY_NUMERIC_CODE = 276;
    private readonly string[] GERMANY_CALLING_CODE = ["+49"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Germany;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Baden-Württemberg", "DE-BW", "State"),
        new("Bavaria", "DE-BY", "State"),
        new("Berlin", "DE-BE", "State"),
        new("Brandenburg", "DE-BB", "State"),
        new("Bremen", "DE-HB", "State"),
        new("Hamburg", "DE-HH", "State"),
        new("Hesse", "DE-HE", "State"),
        new("Lower Saxony", "DE-NI", "State"),
        new("Mecklenburg-Vorpommern", "DE-MV", "State"),
        new("North Rhine-Westphalia", "DE-NW", "State"),
        new("Rhineland-Palatinate", "DE-RP", "State"),
        new("Saarland", "DE-SL", "State"),
        new("Saxony", "DE-SN", "State"),
        new("Saxony-Anhalt", "DE-ST", "State"),
        new("Schleswig-Holstein", "DE-SH", "State"),
        new("Thuringia", "DE-TH", "State")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGermany()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GERMANY_COUNTRY_NAME,
            GERMANY_OFFICIAL_NAME,
            GERMANY_NATIVE_NAME,
            GERMANY_CAPITAL,
            GERMANY_NUMERIC_CODE,
            GERMANY_ISO2_CODE,
            GERMANY_ISO3_CODE,
            GERMANY_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
