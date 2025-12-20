namespace World.Net.UnitTests.Countries;

public sealed class NepalTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Nepal";
    private const string OFFICIAL_NAME = "Federal Democratic Republic of Nepal";
    private const string NATIVE_NAME = "नेपाल";
    private const string CAPITAL = "Kathmandu";
    private const string ISO2_CODE = "NP";
    private const string ISO3_CODE = "NPL";
    private const int NUMERIC_CODE = 524;
    private readonly string[] CALLING_CODE = ["+977"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Nepal;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Koshi", "NP-P1", "Province"),
    ("Madhesh", "NP-P2", "Province"),
    ("Bagmati", "NP-P3", "Province"),
    ("Gandaki", "NP-P4", "Province"),
    ("Lumbini", "NP-P5", "Province"),
    ("Karnali", "NP-P6", "Province"),
    ("Sudurpashchim", "NP-P7", "Province")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNepal()
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
