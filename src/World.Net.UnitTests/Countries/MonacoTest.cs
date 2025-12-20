namespace World.Net.UnitTests.Countries;

public sealed class MonacoTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Monaco";
    private const string OFFICIAL_NAME = "Principality of Monaco";
    private const string NATIVE_NAME = "Principauté de Monaco";
    private const string CAPITAL = "Monaco";
    private const string ISO2_CODE = "MC";
    private const string ISO3_CODE = "MCO";
    private const int NUMERIC_CODE = 492;
    private readonly string[] CALLING_CODE = ["+377"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Monaco;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMonaco()
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
