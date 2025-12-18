namespace World.Net.UnitTests.Countries;

public sealed class SaintLuciaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Saint Lucia";
    private const string NATIVE_NAME = "Saint Lucia";
    private const string CAPITAL = "Castries";
    private const string OFFICIAL_NAME = "Saint Lucia";
    private const string ISO2_CODE = "LC";
    private const string ISO3_CODE = "LCA";
    private const int NUMERIC_CODE = 662;
    private readonly string[] CALLING_CODE = ["+1-758"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintLucia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Anse la Raye", "LC-01", "District"),
    new("Canaries", "LC-02", "District"),
    new("Castries", "LC-03", "District"),
    new("Choiseul", "LC-04", "District"),
    new("Dennery", "LC-05", "District"),
    new("Gros Islet", "LC-06", "District"),
    new("Laborie", "LC-07", "District"),
    new("Micoud", "LC-08", "District"),
    new("Praslin", "LC-09", "District"),
    new("Soufriere", "LC-10", "District"),
    new("Vieux Fort", "LC-11", "District")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSaintLucia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            COUNTRY_NAME,
            OFFICIAL_NAME,
            NATIVE_NAME,
            CAPITAL,
            NUMERIC_CODE,
            ISO2_CODE,
            ISO3_CODE,
            CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
