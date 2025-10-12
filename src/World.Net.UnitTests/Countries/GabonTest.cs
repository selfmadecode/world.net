namespace World.Net.UnitTests.Countries;

public sealed class GabonTest : AssertCountryTestBase
{
    private const string GABON_COUNTRY_NAME = "Gabon";
    private const string GABON_NATIVE_NAME = "Republique gabonaise";
    private const string GABON_CAPITAL = "Libreville";
    private const string GABON_OFFICIAL_NAME = "Gabonese Republic";
    private const string GABON_ISO2_CODE = "GA";
    private const string GABON_ISO3_CODE = "GAB";
    private const int GABON_NUMERIC_CODE = 266;
    private readonly string[] GABON_CALLING_CODE = ["+241"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Gabon;
    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Estuaire", "GA-1", "Province"),
        new("Haut-Ogooué", "GA-2", "Province"),
        new("Moyen-Ogooué", "GA-3", "Province"),
        new("Ngounié", "GA-4", "Province"),
        new("Nyanga", "GA-5", "Province"),
        new("Ogooué-Ivindo", "GA-6", "Province"),
        new("Ogooué-Lolo", "GA-7", "Province"),
        new("Ogooué-Maritime", "GA-8", "Province"),
        new("Woleu-Ntem", "GA-9", "Province")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGabon()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GABON_COUNTRY_NAME,
            GABON_OFFICIAL_NAME,
            GABON_NATIVE_NAME,
            GABON_CAPITAL,
            GABON_NUMERIC_CODE,
            GABON_ISO2_CODE,
            GABON_ISO3_CODE,
            GABON_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}

