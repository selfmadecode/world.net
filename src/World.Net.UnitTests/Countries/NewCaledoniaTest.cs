namespace World.Net.UnitTests.Countries;

public sealed class NewCaledoniaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "New Caledonia";
    private const string OFFICIAL_NAME = "New Caledonia";
    private const string NATIVE_NAME = "Nouvelle-Calédonie";
    private const string CAPITAL = "Nouméa";
    private const string ISO2_CODE = "NC";
    private const string ISO3_CODE = "NCL";
    private const int NUMERIC_CODE = 540;
    private readonly string[] CALLING_CODE = ["+687"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.NewCaledonia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("North Province", "NC-N", "Province"),
    ("South Province", "NC-S", "Province"),
    ("Loyalty Islands Province", "NC-L", "Province")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNewCaledonia()
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
