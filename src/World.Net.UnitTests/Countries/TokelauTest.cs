namespace World.Net.UnitTests.Countries;

public sealed class TokelauTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Tokelau";
    private const string NATIVE_NAME = "Tokelau";
    private const string CAPITAL = "Nukunonu";
    private const string OFFICIAL_NAME = "Tokelau";
    private const string ISO2_CODE = "TK";
    private const string ISO3_CODE = "TKL";
    private const int NUMERIC_CODE = 772;
    private readonly string[] CALLING_CODE = ["+690"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Tokelau;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Atafu", "TK-A", "Atoll"),
    ("Nukunonu", "TK-N", "Atoll"),
    ("Fakaofo", "TK-F", "Atoll")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTokelau()
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
