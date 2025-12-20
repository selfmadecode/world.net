namespace World.Net.UnitTests.Countries;

public sealed class IsleOfManTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Isle of Man";
    private const string OFFICIAL_NAME = "Isle of Man";
    private const string NATIVE_NAME = "Ellan Vannin";
    private const string CAPITAL = "Douglas";
    private const string ISO2_CODE = "IM";
    private const string ISO3_CODE = "IMN";
    private const int NUMERIC_CODE = 833;
    private readonly string[] CALLING_CODE = ["+44"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.IsleOfMan;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Ayre", "IM-01", "Sheading"),
    ("Garff", "IM-02", "Sheading"),
    ("Glenfaba", "IM-03", "Sheading"),
    ("Michael", "IM-04", "Sheading"),
    ("Middle", "IM-05", "Sheading"),
    ("Rushen", "IM-06", "Sheading")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIsleOfMan()
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
