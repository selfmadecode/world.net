namespace World.Net.UnitTests.Countries;

public sealed class NewZealandTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "New Zealand";
    private const string OFFICIAL_NAME = "New Zealand";
    private const string NATIVE_NAME = "Aotearoa";
    private const string CAPITAL = "Wellington";
    private const string ISO2_CODE = "NZ";
    private const string ISO3_CODE = "NZL";
    private const int NUMERIC_CODE = 554;
    private readonly string[] CALLING_CODE = ["+64"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.NewZealand;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Auckland", "NZ-AUK", "Region"),
    ("Bay of Plenty", "NZ-BOP", "Region"),
    ("Canterbury", "NZ-CAN", "Region"),
    ("Chatham Islands Territory", "NZ-CIT", "Territory"),
    ("Gisborne", "NZ-GIS", "Region"),
    ("Hawke's Bay", "NZ-HKB", "Region"),
    ("Manawatu-Whanganui", "NZ-MWT", "Region"),
    ("Marlborough", "NZ-MBH", "Region"),
    ("Nelson", "NZ-NSN", "Region"),
    ("Northland", "NZ-NTL", "Region"),
    ("Otago", "NZ-OTA", "Region"),
    ("Southland", "NZ-STL", "Region"),
    ("Taranaki", "NZ-TKI", "Region"),
    ("Tasman", "NZ-TAS", "Region"),
    ("Waikato", "NZ-WKO", "Region"),
    ("Wellington", "NZ-WGN", "Region"),
    ("West Coast", "NZ-WTC", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNewZealand()
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
