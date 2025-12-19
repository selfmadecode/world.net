namespace World.Net.UnitTests.Countries;

public sealed class TurksAndCaicosIslandsTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Turks and Caicos Islands";
    private const string NATIVE_NAME = "Turks and Caicos Islands";
    private const string CAPITAL = "Cockburn Town";
    private const string OFFICIAL_NAME = "Turks and Caicos Islands";
    private const string ISO2_CODE = "TC";
    private const string ISO3_CODE = "TCA";
    private const int NUMERIC_CODE = 796;
    private readonly string[] CALLING_CODE = ["+1-649"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.TurksAndCaicosIslands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTurksAndCaicosIslands()
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
