namespace World.Net.UnitTests.Countries;

public sealed class TongaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Tonga";
    private const string NATIVE_NAME = "Tonga";
    private const string CAPITAL = "Nukuʻalofa";
    private const string OFFICIAL_NAME = "Kingdom of Tonga";
    private const string ISO2_CODE = "TO";
    private const string ISO3_CODE = "TON";
    private const int NUMERIC_CODE = 776;
    private readonly string[] CALLING_CODE = ["+676"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Tonga;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Haʻapai", "TO-02", "Division"),
    ("Tongatapu", "TO-01", "Division"),
    ("Vavaʻu", "TO-05", "Division"),
    ("Eua", "TO-03", "Division"),
    ("Niuas", "TO-04", "Division")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTonga()
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
