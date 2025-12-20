namespace World.Net.UnitTests.Countries;
public sealed class IsraelTest : AssertCountryTestBase
{
    private const string ISRAEL_COUNTRY_NAME = "Israel";
    private const string ISRAEL_NATIVE_NAME = "יִשְׂרָאֵל";
    private const string ISRAEL_CAPITAL = "Jerusalem";
    private const string ISRAEL_OFFICIAL_NAME = "State of Israel";
    private const string ISRAEL_ISO2_CODE = "IL";
    private const string ISRAEL_ISO3_CODE = "ISR";
    private const int ISRAEL_NUMERIC_CODE = 376;
    private readonly string[] ISRAEL_CALLING_CODE = ["+972"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.Israel;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Central", "IL-M", "District"),
        ("Haifa", "IL-HA", "District"),
        ("Jerusalem", "IL-JM", "District"),
        ("Northern", "IL-Z", "District"),
        ("Southern", "IL-D", "District"),
        ("Tel Aviv", "IL-TA", "District")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIsrael()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            ISRAEL_COUNTRY_NAME,
            ISRAEL_OFFICIAL_NAME,
            ISRAEL_NATIVE_NAME,
            ISRAEL_CAPITAL,
            ISRAEL_NUMERIC_CODE,
            ISRAEL_ISO2_CODE,
            ISRAEL_ISO3_CODE,
            ISRAEL_CALLING_CODE,
            ExpectedStates
        );
    }
}
