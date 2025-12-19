namespace World.Net.UnitTests.Countries;

public sealed class TheGambiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "The Gambia";
    private const string NATIVE_NAME = "The Gambia";
    private const string CAPITAL = "Banjul";
    private const string OFFICIAL_NAME = "Republic of The Gambia";
    private const string ISO2_CODE = "GM";
    private const string ISO3_CODE = "GMB";
    private const int NUMERIC_CODE = 270;
    private readonly string[] CALLING_CODE = ["+220"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Gambia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Banjul", "GM-B", "City"),
    ("Central River", "GM-CR", "Region"),
    ("Lower River", "GM-LR", "Region"),
    ("North Bank", "GM-NB", "Region"),
    ("Upper River", "GM-UR", "Region"),
    ("Western", "GM-W", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTheGambia()
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
