namespace World.Net.UnitTests.Countries;

public sealed class SudanTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Sudan";
    private const string NATIVE_NAME = "السودان";
    private const string CAPITAL = "Khartoum";
    private const string OFFICIAL_NAME = "Republic of the Sudan";
    private const string ISO2_CODE = "SD";
    private const string ISO3_CODE = "SDN";
    private const int NUMERIC_CODE = 729;
    private readonly string[] CALLING_CODE = ["+249"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Sudan;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Khartoum", "SD-KH", "State"),
    ("North Kordofan", "SD-NK", "State"),
    ("South Kordofan", "SD-SK", "State"),
    ("White Nile", "SD-WN", "State"),
    ("Blue Nile", "SD-BN", "State"),
    ("North Darfur", "SD-ND", "State"),
    ("South Darfur", "SD-SD", "State"),
    ("West Darfur", "SD-WR", "State"),
    ("East Darfur", "SD-ED", "State"),
    ("Central Darfur", "SD-CD", "State"),
    ("Northern", "SD-NO", "State"),
    ("Red Sea", "SD-RS", "State"),
    ("River Nile", "SD-RN", "State"),
    ("Al Jazirah", "SD-GZ", "State"),
    ("Sennar", "SD-SI", "State"),
    ("Gezira", "SD-GZ", "State"),
    ("Kassala", "SD-KA", "State"),
    ("Al Qadarif", "SD-GQ", "State")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSudan()
    {
        var country = CountryProvider.GetCountry(EXPECTEDID);

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
