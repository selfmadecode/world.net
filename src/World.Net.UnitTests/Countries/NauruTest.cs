namespace World.Net.UnitTests.Countries;

public sealed class NauruTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Nauru";
    private const string OFFICIAL_NAME = "Republic of Nauru";
    private const string NATIVE_NAME = "Nauru";
    private const string CAPITAL = "Yaren";
    private const string ISO2_CODE = "NR";
    private const string ISO3_CODE = "NRU";
    private const int NUMERIC_CODE = 520;
    private readonly string[] CALLING_CODE = ["+674"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Nauru;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Aiwo", "NR-01", "District"),
    ("Anabar", "NR-02", "District"),
    ("Anetan", "NR-03", "District"),
    ("Anibare", "NR-04", "District"),
    ("Baiti", "NR-05", "District"),
    ("Boe", "NR-06", "District"),
    ("Buada", "NR-07", "District"),
    ("Denigomodu", "NR-08", "District"),
    ("Ewa", "NR-09", "District"),
    ("Ijuw", "NR-10", "District"),
    ("Meneng", "NR-11", "District"),
    ("Nibok", "NR-12", "District"),
    ("Uaboe", "NR-13", "District"),
    ("Yaren", "NR-14", "District")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNauru()
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
