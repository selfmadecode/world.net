namespace World.Net.UnitTests.Countries;

public sealed class MalaysiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Malaysia";
    private const string OFFICIAL_NAME = "Malaysia";
    private const string NATIVE_NAME = "Malaysia";
    private const string CAPITAL = "Kuala Lumpur";
    private const string ISO2_CODE = "MY";
    private const string ISO3_CODE = "MYS";
    private const int NUMERIC_CODE = 458;
    private readonly string[] CALLING_CODE = ["+60"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Malaysia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Johor", "MY-01", "State"),
    ("Kedah", "MY-02", "State"),
    ("Kelantan", "MY-03", "State"),
    ("Malacca", "MY-04", "State"),
    ("Negeri Sembilan", "MY-05", "State"),
    ("Pahang", "MY-06", "State"),
    ("Penang", "MY-07", "State"),
    ("Perak", "MY-08", "State"),
    ("Perlis", "MY-09", "State"),
    ("Selangor", "MY-10", "State"),
    ("Terengganu", "MY-11", "State"),
    ("Sabah", "MY-12", "State"),
    ("Sarawak", "MY-13", "State"),
    ("Kuala Lumpur", "MY-14", "Federal Territory"),
    ("Labuan", "MY-15", "Federal Territory"),
    ("Putrajaya", "MY-16", "Federal Territory")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMalaysia()
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
