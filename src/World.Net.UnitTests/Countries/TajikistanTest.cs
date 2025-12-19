namespace World.Net.UnitTests.Countries;

public sealed class TajikistanTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Tajikistan";
    private const string NATIVE_NAME = "Ҷумҳурии Тоҷикистон";
    private const string CAPITAL = "Dushanbe";
    private const string OFFICIAL_NAME = "Republic of Tajikistan";
    private const string ISO2_CODE = "TJ";
    private const string ISO3_CODE = "TJK";
    private const int NUMERIC_CODE = 762;
    private readonly string[] CALLING_CODE = ["+992"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Tajikistan;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Sughd", "TJ-SU", "Region"),
    ("Khatlon", "TJ-KT", "Region"),
    ("Gorno-Badakhshan", "TJ-GBAO", "Autonomous Region"),
    ("Districts of Republican Subordination", "TJ-DRS", "Region"),
    ("Dushanbe", "TJ-DU", "Capital District")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTajikistan()
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
