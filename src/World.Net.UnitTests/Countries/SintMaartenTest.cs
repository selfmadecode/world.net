namespace World.Net.UnitTests.Countries;

public sealed class SintMaartenTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Sint Maarten (Dutch part)";
    private const string NATIVE_NAME = "Sint Maarten";
    private const string CAPITAL = "Philipsburg";
    private const string OFFICIAL_NAME = "Sint Maarten";
    private const string ISO2_CODE = "SX";
    private const string ISO3_CODE = "SXM";
    private const int NUMERIC_CODE = 534;
    private readonly string[] CALLING_CODE = ["+1-721"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SintMaartenDutchPart;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSintMaarten()
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
