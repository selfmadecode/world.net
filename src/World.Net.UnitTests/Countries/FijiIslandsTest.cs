namespace World.Net.UnitTests.Countries;

public sealed class FijiIslandsTest : AssertCountryTestBase
{
    private const string FIJI_COUNTRY_NAME = "Fiji";
    private const string FIJI_NATIVE_NAME = "Matanitu ko Viti";
    private const string FIJI_CAPITAL = "Suva";
    private const string FIJI_OFFICIAL_NAME = "Republic of Fiji";
    private const string FIJI_ISO2_CODE = "FJ";
    private const string FIJI_ISO3_CODE = "FJI";
    private const int FIJI_NUMERIC_CODE = 242;
    private readonly string[] FIJI_CALLING_CODE = ["+679"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.FijiIslands;
    private static readonly (string Name, string IsoCode, string Type)[] States =
    [
        new("Ba", "FJ-01", "Province"),
        new("Bua", "FJ-02", "Province"),
        new("Cakaudrove", "FJ-03", "Province"),
        new("Kadavu", "FJ-04", "Province"),
        new("Lau", "FJ-05", "Province"),
        new("Lomaiviti", "FJ-06", "Province"),
        new("Macuata", "FJ-07", "Province"),
        new("Nadroga-Navosa", "FJ-08", "Province"),
        new("Naitasiri", "FJ-09", "Province"),
        new("Namosi", "FJ-10", "Province"),
        new("Ra", "FJ-11", "Province"),
        new("Rewa", "FJ-12", "Province"),
        new("Serua", "FJ-13", "Province"),
        new("Tailevu", "FJ-14", "Province"),
        new("Rotuma", "FJ-15", "Dependency")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFiji()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);
        
        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            FIJI_COUNTRY_NAME,
            FIJI_OFFICIAL_NAME,
            FIJI_NATIVE_NAME,
            FIJI_CAPITAL,
            FIJI_NUMERIC_CODE,
            FIJI_ISO2_CODE,
            FIJI_ISO3_CODE,
            FIJI_CALLING_CODE,
            States
        );
    }
}


