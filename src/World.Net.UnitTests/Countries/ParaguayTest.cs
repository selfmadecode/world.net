namespace World.Net.UnitTests.Countries;

public sealed class ParaguayTest : AssertCountryTestBase
{
    private const string PARAGUAY_COUNTRY_NAME = "Paraguay";
    private const string PARAGUAY_NATIVE_NAME = "República del Paraguay";
    private const string PARAGUAY_CAPITAL = "Asunción";
    private const string PARAGUAY_OFFICIAL_NAME = "Republic of Paraguay";
    private const string PARAGUAY_ISO2_CODE = "PY";
    private const string PARAGUAY_ISO3_CODE = "PRY";
    private const int PARAGUAY_NUMERIC_CODE = 600;
    private readonly string[] PARAGUAY_CALLING_CODE = ["+595"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Paraguay;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Alto Paraguay", "PY-16", "Department"),
    new("Alto Paraná", "PY-10", "Department"),
    new("Amambay", "PY-13", "Department"),
    new("Asunción", "PY-ASU", "Capital District"),
    new("Boquerón", "PY-19", "Department"),
    new("Caaguazú", "PY-5", "Department"),
    new("Caazapá", "PY-6", "Department"),
    new("Canindeyú", "PY-11", "Department"),
    new("Central", "PY-15", "Department"),
    new("Concepción", "PY-1", "Department"),
    new("Cordillera", "PY-3", "Department"),
    new("Guairá", "PY-4", "Department"),
    new("Itapúa", "PY-7", "Department"),
    new("Misiones", "PY-8", "Department"),
    new("Ñeembucú", "PY-12", "Department"),
    new("Paraguarí", "PY-9", "Department"),
    new("Presidente Hayes", "PY-17", "Department"),
    new("San Pedro", "PY-2", "Department")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForParaguay()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PARAGUAY_COUNTRY_NAME,
            PARAGUAY_OFFICIAL_NAME,
            PARAGUAY_NATIVE_NAME,
            PARAGUAY_CAPITAL,
            PARAGUAY_NUMERIC_CODE,
            PARAGUAY_ISO2_CODE,
            PARAGUAY_ISO3_CODE,
            PARAGUAY_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
