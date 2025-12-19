namespace World.Net.UnitTests.Countries;

public sealed class SouthAfricaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "South Africa";
    private const string NATIVE_NAME = "South Africa";
    private const string CAPITAL = "Pretoria";
    private const string OFFICIAL_NAME = "Republic of South Africa";
    private const string ISO2_CODE = "ZA";
    private const string ISO3_CODE = "ZAF";
    private const int NUMERIC_CODE = 710;
    private readonly string[] CALLING_CODE = ["+27"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SouthAfrica;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Eastern Cape", "ZA-EC", "Province"),
    ("Free State", "ZA-FS", "Province"),
    ("Gauteng", "ZA-GT", "Province"),
    ("KwaZulu-Natal", "ZA-KZN", "Province"),
    ("Limpopo", "ZA-LP", "Province"),
    ("Mpumalanga", "ZA-MP", "Province"),
    ("North West", "ZA-NW", "Province"),
    ("Northern Cape", "ZA-NC", "Province"),
    ("Western Cape", "ZA-WC", "Province")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSouthAfrica()
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
