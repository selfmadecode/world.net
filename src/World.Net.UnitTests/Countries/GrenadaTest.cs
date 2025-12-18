namespace World.Net.UnitTests.Countries;

public sealed class GrenadaTest : AssertCountryTestBase
{
    private const string GRENADA_COUNTRY_NAME = "Grenada";
    private const string GRENADA_NATIVE_NAME = "Grenada";
    private const string GRENADA_CAPITAL = "St. George's";
    private const string GRENADA_OFFICIAL_NAME = "Grenada";
    private const string GRENADA_ISO2_CODE = "GD";
    private const string GRENADA_ISO3_CODE = "GRD";
    private const int GRENADA_NUMERIC_CODE = 308;
    private readonly string[] GRENADA_CALLING_CODE = ["+1-473"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Grenada;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Saint Andrew", "GD-01", "Parish"),
        new("Saint David", "GD-02", "Parish"),
        new("Saint George", "GD-03", "Parish"),
        new("Saint John", "GD-04", "Parish"),
        new("Saint Mark", "GD-05", "Parish"),
        new("Saint Patrick", "GD-06", "Parish"),
        new("Carriacou and Petite Martinique", "GD-10", "Dependency")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGrenada()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GRENADA_COUNTRY_NAME,
            GRENADA_OFFICIAL_NAME,
            GRENADA_NATIVE_NAME,
            GRENADA_CAPITAL,
            GRENADA_NUMERIC_CODE,
            GRENADA_ISO2_CODE,
            GRENADA_ISO3_CODE,
            GRENADA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
