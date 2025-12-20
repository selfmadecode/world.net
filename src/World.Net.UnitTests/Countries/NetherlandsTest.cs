namespace World.Net.UnitTests.Countries;

public sealed class NetherlandsTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Netherlands";
    private const string OFFICIAL_NAME = "Kingdom of the Netherlands";
    private const string NATIVE_NAME = "Nederland";
    private const string CAPITAL = "Amsterdam";
    private const string ISO2_CODE = "NL";
    private const string ISO3_CODE = "NLD";
    private const int NUMERIC_CODE = 528;
    private readonly string[] CALLING_CODE = ["+31"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Netherlands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Drenthe", "NL-DR", "Province"),
    ("Flevoland", "NL-FL", "Province"),
    ("Friesland", "NL-FR", "Province"),
    ("Gelderland", "NL-GE", "Province"),
    ("Groningen", "NL-GR", "Province"),
    ("Limburg", "NL-LI", "Province"),
    ("North Brabant", "NL-NB", "Province"),
    ("North Holland", "NL-NH", "Province"),
    ("Overijssel", "NL-OV", "Province"),
    ("South Holland", "NL-ZH", "Province"),
    ("Utrecht", "NL-UT", "Province"),
    ("Zeeland", "NL-ZE", "Province")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNetherlands()
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
