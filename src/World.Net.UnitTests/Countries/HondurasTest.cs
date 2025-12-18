namespace World.Net.UnitTests.Countries;

public sealed class HondurasTest : AssertCountryTestBase
{
    private const string HONDURAS_COUNTRY_NAME = "Honduras";
    private const string HONDURAS_NATIVE_NAME = "Honduras";
    private const string HONDURAS_CAPITAL = "Tegucigalpa";
    private const string HONDURAS_OFFICIAL_NAME = "Republic of Honduras";
    private const string HONDURAS_ISO2_CODE = "HN";
    private const string HONDURAS_ISO3_CODE = "HND";
    private const int HONDURAS_NUMERIC_CODE = 340;
    private readonly string[] HONDURAS_CALLING_CODE = ["+504"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Honduras;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Atlántida", "HN-AT", "Department"),
        new("Choluteca", "HN-CH", "Department"),
        new("Colón", "HN-CL", "Department"),
        new("Comayagua", "HN-CM", "Department"),
        new("Copán", "HN-CP", "Department"),
        new("Cortés", "HN-CR", "Department"),
        new("El Paraíso", "HN-EP", "Department"),
        new("Francisco Morazán", "HN-FM", "Department"),
        new("Gracias a Dios", "HN-GD", "Department"),
        new("Intibucá", "HN-IN", "Department"),
        new("Islas de la Bahía", "HN-IB", "Department"),
        new("La Paz", "HN-LP", "Department"),
        new("Lempira", "HN-LE", "Department"),
        new("Ocotepeque", "HN-OC", "Department"),
        new("Olancho", "HN-OL", "Department"),
        new("Santa Bárbara", "HN-SB", "Department"),
        new("Valle", "HN-VA", "Department"),
        new("Yoro", "HN-YO", "Department")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForHonduras()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            HONDURAS_COUNTRY_NAME,
            HONDURAS_OFFICIAL_NAME,
            HONDURAS_NATIVE_NAME,
            HONDURAS_CAPITAL,
            HONDURAS_NUMERIC_CODE,
            HONDURAS_ISO2_CODE,
            HONDURAS_ISO3_CODE,
            HONDURAS_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
