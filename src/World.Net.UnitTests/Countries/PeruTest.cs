namespace World.Net.UnitTests.Countries;

public sealed class PeruTest : AssertCountryTestBase
{
    private const string PERU_COUNTRY_NAME = "Peru";
    private const string PERU_NATIVE_NAME = "República del Perú";
    private const string PERU_CAPITAL = "Lima";
    private const string PERU_OFFICIAL_NAME = "Republic of Peru";
    private const string PERU_ISO2_CODE = "PE";
    private const string PERU_ISO3_CODE = "PER";
    private const int PERU_NUMERIC_CODE = 604;
    private readonly string[] PERU_CALLING_CODE = ["+51"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Peru;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Amazonas", "PE-AMA", "Region"),
    new("Áncash", "PE-ANC", "Region"),
    new("Apurímac", "PE-APU", "Region"),
    new("Arequipa", "PE-ARE", "Region"),
    new("Ayacucho", "PE-AYA", "Region"),
    new("Cajamarca", "PE-CAJ", "Region"),
    new("Callao", "PE-CAL", "Constitutional Province"),
    new("Cusco", "PE-CUS", "Region"),
    new("Huancavelica", "PE-HUV", "Region"),
    new("Huánuco", "PE-HUC", "Region"),
    new("Ica", "PE-ICA", "Region"),
    new("Junín", "PE-JUN", "Region"),
    new("La Libertad", "PE-LAL", "Region"),
    new("Lambayeque", "PE-LAM", "Region"),
    new("Lima", "PE-LIM", "Region"),
    new("Loreto", "PE-LOR", "Region"),
    new("Madre de Dios", "PE-MDD", "Region"),
    new("Moquegua", "PE-MOQ", "Region"),
    new("Pasco", "PE-PAS", "Region"),
    new("Piura", "PE-PIU", "Region"),
    new("Puno", "PE-PUN", "Region"),
    new("San Martín", "PE-SAM", "Region"),
    new("Tacna", "PE-TAC", "Region"),
    new("Tumbes", "PE-TUM", "Region"),
    new("Ucayali", "PE-UCA", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPeru()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PERU_COUNTRY_NAME,
            PERU_OFFICIAL_NAME,
            PERU_NATIVE_NAME,
            PERU_CAPITAL,
            PERU_NUMERIC_CODE,
            PERU_ISO2_CODE,
            PERU_ISO3_CODE,
            PERU_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
