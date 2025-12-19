namespace World.Net.UnitTests.Countries;

public sealed class SlovakiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Slovakia";
    private const string NATIVE_NAME = "Slovensko";
    private const string CAPITAL = "Bratislava";
    private const string OFFICIAL_NAME = "Slovak Republic";
    private const string ISO2_CODE = "SK";
    private const string ISO3_CODE = "SVK";
    private const int NUMERIC_CODE = 703;
    private readonly string[] CALLING_CODE = ["+421"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Slovakia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Bratislava Region", "SK-BL", "Region"),
    ("Trnava Region", "SK-TA", "Region"),
    ("Trenčín Region", "SK-TC", "Region"),
    ("Nitra Region", "SK-NI", "Region"),
    ("Žilina Region", "SK-ZI", "Region"),
    ("Banská Bystrica Region", "SK-BC", "Region"),
    ("Prešov Region", "SK-PV", "Region"),
    ("Košice Region", "SK-KI", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSlovakia()
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
