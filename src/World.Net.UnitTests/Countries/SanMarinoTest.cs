namespace World.Net.UnitTests.Countries;

public sealed class SanMarinoTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "San Marino";
    private const string NATIVE_NAME = "San Marino";
    private const string CAPITAL = "San Marino";
    private const string OFFICIAL_NAME = "Most Serene Republic of San Marino";
    private const string ISO2_CODE = "SM";
    private const string ISO3_CODE = "SMR";
    private const int NUMERIC_CODE = 674;
    private readonly string[] CALLING_CODE = ["+378"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SanMarino;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Acquaviva", "SM-AC", "Municipality"),
    new("Borgo Maggiore", "SM-BM", "Municipality"),
    new("Chiesanuova", "SM-CH", "Municipality"),
    new("Domagnano", "SM-DO", "Municipality"),
    new("Faetano", "SM-FA", "Municipality"),
    new("Fiorentino", "SM-FI", "Municipality"),
    new("Montegiardino", "SM-MG", "Municipality"),
    new("San Marino", "SM-SM", "Municipality"),
    new("Serravalle", "SM-SE", "Municipality")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSanMarino()
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
