namespace World.Net.UnitTests.Countries;

public sealed class MartiniqueTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Martinique";
    private const string OFFICIAL_NAME = "Martinique";
    private const string NATIVE_NAME = "Martinique";
    private const string CAPITAL = "Fort-de-France";
    private const string ISO2_CODE = "MQ";
    private const string ISO3_CODE = "MTQ";
    private const int NUMERIC_CODE = 474;
    private readonly string[] CALLING_CODE = ["+596"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Martinique;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMartinique()
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
