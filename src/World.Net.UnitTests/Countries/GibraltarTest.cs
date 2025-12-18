namespace World.Net.UnitTests.Countries;

public sealed class GibraltarTest : AssertCountryTestBase
{
    private const string GIBRALTAR_COUNTRY_NAME = "Gibraltar";
    private const string GIBRALTAR_NATIVE_NAME = "Gibraltar";
    private const string GIBRALTAR_CAPITAL = "Gibraltar";
    private const string GIBRALTAR_OFFICIAL_NAME = "Gibraltar";
    private const string GIBRALTAR_ISO2_CODE = "GI";
    private const string GIBRALTAR_ISO3_CODE = "GIB";
    private const int GIBRALTAR_NUMERIC_CODE = 292;
    private readonly string[] GIBRALTAR_CALLING_CODE = ["+350"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Gibraltar;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGibraltar()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GIBRALTAR_COUNTRY_NAME,
            GIBRALTAR_OFFICIAL_NAME,
            GIBRALTAR_NATIVE_NAME,
            GIBRALTAR_CAPITAL,
            GIBRALTAR_NUMERIC_CODE,
            GIBRALTAR_ISO2_CODE,
            GIBRALTAR_ISO3_CODE,
            GIBRALTAR_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
