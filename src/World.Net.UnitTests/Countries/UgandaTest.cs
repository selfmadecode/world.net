namespace World.Net.UnitTests.Countries;

public sealed class UgandaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Uganda";
    private const string NATIVE_NAME = "Uganda";
    private const string CAPITAL = "Kampala";
    private const string OFFICIAL_NAME = "Republic of Uganda";
    private const string ISO2_CODE = "UG";
    private const string ISO3_CODE = "UGA";
    private const int NUMERIC_CODE = 800;
    private readonly string[] CALLING_CODE = ["+256"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Uganda;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
        ("Central", "UG-C", "Region"),
        ("Eastern", "UG-E", "Region"),
        ("Northern", "UG-N", "Region"),
        ("Western", "UG-W", "Region")
    };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForUganda()
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
