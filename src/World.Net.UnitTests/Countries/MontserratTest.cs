namespace World.Net.UnitTests.Countries;

public sealed class MontserratTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Montserrat";
    private const string OFFICIAL_NAME = "Montserrat";
    private const string NATIVE_NAME = "Montserrat";
    private const string CAPITAL = "Plymouth";
    private const string ISO2_CODE = "MS";
    private const string ISO3_CODE = "MSR";
    private const int NUMERIC_CODE = 500;
    private readonly string[] CALLING_CODE = ["+1-664"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Montserrat;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMontserrat()
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
