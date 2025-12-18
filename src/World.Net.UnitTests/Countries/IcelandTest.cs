namespace World.Net.UnitTests.Countries;

public sealed class IcelandTest : AssertCountryTestBase
{
    private const string ICELAND_COUNTRY_NAME = "Iceland";
    private const string ICELAND_NATIVE_NAME = "Ísland";
    private const string ICELAND_CAPITAL = "Reykjavík";
    private const string ICELAND_OFFICIAL_NAME = "Republic of Iceland";
    private const string ICELAND_ISO2_CODE = "IS";
    private const string ICELAND_ISO3_CODE = "ISL";
    private const int ICELAND_NUMERIC_CODE = 352;
    private readonly string[] ICELAND_CALLING_CODE = ["+354"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Iceland;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Capital Region", "IS-1", "Region"),
        new("Southern Peninsula", "IS-2", "Region"),
        new("West", "IS-3", "Region"),
        new("Westfjords", "IS-4", "Region"),
        new("North", "IS-5", "Region"),
        new("Northwest", "IS-6", "Region"),
        new("East", "IS-7", "Region"),
        new("South", "IS-8", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIceland()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            ICELAND_COUNTRY_NAME,
            ICELAND_OFFICIAL_NAME,
            ICELAND_NATIVE_NAME,
            ICELAND_CAPITAL,
            ICELAND_NUMERIC_CODE,
            ICELAND_ISO2_CODE,
            ICELAND_ISO3_CODE,
            ICELAND_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
