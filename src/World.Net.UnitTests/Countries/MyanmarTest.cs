namespace World.Net.UnitTests.Countries;

public sealed class MyanmarTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Myanmar";
    private const string OFFICIAL_NAME = "Republic of the Union of Myanmar";
    private const string NATIVE_NAME = "မြန်မာ";
    private const string CAPITAL = "Naypyidaw";
    private const string ISO2_CODE = "MM";
    private const string ISO3_CODE = "MMR";
    private const int NUMERIC_CODE = 104;
    private readonly string[] CALLING_CODE = ["+95"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Myanmar;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Ayeyarwady", "MM-07", "Region"),
    ("Bago", "MM-02", "Region"),
    ("Chin", "MM-14", "State"),
    ("Kachin", "MM-11", "State"),
    ("Kayah", "MM-12", "State"),
    ("Kayin", "MM-13", "State"),
    ("Magway", "MM-03", "Region"),
    ("Mandalay", "MM-04", "Region"),
    ("Mon", "MM-15", "State"),
    ("Naypyidaw", "MM-18", "Union Territory"),
    ("Rakhine", "MM-16", "State"),
    ("Sagaing", "MM-01", "Region"),
    ("Shan", "MM-17", "State"),
    ("Tanintharyi", "MM-05", "Region"),
    ("Yangon", "MM-06", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMyanmar()
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
