namespace World.Net.UnitTests.Countries;

public sealed class SvalbardAndJanMayenTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Svalbard and Jan Mayen";
    private const string NATIVE_NAME = "Svalbard og Jan Mayen";
    private const string CAPITAL = "Longyearbyen";
    private const string OFFICIAL_NAME = "Svalbard and Jan Mayen";
    private const string ISO2_CODE = "SJ";
    private const string ISO3_CODE = "SJM";
    private const int NUMERIC_CODE = 744;
    private readonly string[] CALLING_CODE = ["+47"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SvalbardAndJanMayenIslands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSvalbardAndJanMayen()
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
