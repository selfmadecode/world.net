namespace World.Net.UnitTests.Countries;
public sealed class FrenchGuianaTest : AssertCountryTestBase
{
    private const string FRENCH_GUIANA_NAME = "French Guiana";
    private const string FRENCH_GUIANA_OFFICIAL_NAME = "Guyane française";
    private const string FRENCH_GUIANA_NATIVE_NAME = "Guyane française";
    private const string FRENCH_GUIANA_CAPITAL = "Cayenne";
    private const int FRENCH_GUIANA_NUMERIC_CODE = 254;
    private const string FRENCH_GUIANA_ISO2_CODE = "GF";
    private const string FRENCH_GUIANA_ISO3_CODE = "GUF";
    private readonly string[] FRENCH_GUIANA_CALLING_CODE = ["+594"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.FrenchGuiana;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates = 
        [
        ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFrench_Guiana()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        //Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            FRENCH_GUIANA_NAME,
            FRENCH_GUIANA_OFFICIAL_NAME,
            FRENCH_GUIANA_NATIVE_NAME,
            FRENCH_GUIANA_CAPITAL,
            FRENCH_GUIANA_NUMERIC_CODE,
            FRENCH_GUIANA_ISO2_CODE,
            FRENCH_GUIANA_ISO3_CODE,
            FRENCH_GUIANA_CALLING_CODE,
            ExpectedStates
        );
    }
}
