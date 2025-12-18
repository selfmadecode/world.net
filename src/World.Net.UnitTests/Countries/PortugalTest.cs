namespace World.Net.UnitTests.Countries;

public sealed class PortugalTest : AssertCountryTestBase
{
    private const string PORTUGAL_COUNTRY_NAME = "Portugal";
    private const string PORTUGAL_NATIVE_NAME = "República Portuguesa";
    private const string PORTUGAL_CAPITAL = "Lisbon";
    private const string PORTUGAL_OFFICIAL_NAME = "Portuguese Republic";
    private const string PORTUGAL_ISO2_CODE = "PT";
    private const string PORTUGAL_ISO3_CODE = "PRT";
    private const int PORTUGAL_NUMERIC_CODE = 620;
    private readonly string[] PORTUGAL_CALLING_CODE = ["+351"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Portugal;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Aveiro", "PT-01", "District"),
    new("Beja", "PT-02", "District"),
    new("Braga", "PT-03", "District"),
    new("Bragança", "PT-04", "District"),
    new("Castelo Branco", "PT-05", "District"),
    new("Coimbra", "PT-06", "District"),
    new("Évora", "PT-07", "District"),
    new("Faro", "PT-08", "District"),
    new("Guarda", "PT-09", "District"),
    new("Leiria", "PT-10", "District"),
    new("Lisbon", "PT-11", "District"),
    new("Portalegre", "PT-12", "District"),
    new("Porto", "PT-13", "District"),
    new("Santarém", "PT-14", "District"),
    new("Setúbal", "PT-15", "District"),
    new("Viana do Castelo", "PT-16", "District"),
    new("Vila Real", "PT-17", "District"),
    new("Viseu", "PT-18", "District"),
    new("Azores", "PT-20", "Autonomous Region"),
    new("Madeira", "PT-30", "Autonomous Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPortugal()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PORTUGAL_COUNTRY_NAME,
            PORTUGAL_OFFICIAL_NAME,
            PORTUGAL_NATIVE_NAME,
            PORTUGAL_CAPITAL,
            PORTUGAL_NUMERIC_CODE,
            PORTUGAL_ISO2_CODE,
            PORTUGAL_ISO3_CODE,
            PORTUGAL_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
