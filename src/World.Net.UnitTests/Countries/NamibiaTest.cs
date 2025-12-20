namespace World.Net.UnitTests.Countries;

public sealed class NamibiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Namibia";
    private const string OFFICIAL_NAME = "Republic of Namibia";
    private const string NATIVE_NAME = "Namibia";
    private const string CAPITAL = "Windhoek";
    private const string ISO2_CODE = "NA";
    private const string ISO3_CODE = "NAM";
    private const int NUMERIC_CODE = 516;
    private readonly string[] CALLING_CODE = ["+264"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Namibia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Erongo", "NA-ER", "Region"),
    ("Hardap", "NA-HA", "Region"),
    ("Kavango East", "NA-KE", "Region"),
    ("Kavango West", "NA-KW", "Region"),
    ("Khomas", "NA-KH", "Region"),
    ("Kunene", "NA-KU", "Region"),
    ("Ohangwena", "NA-OW", "Region"),
    ("Omaheke", "NA-OH", "Region"),
    ("Omusati", "NA-OS", "Region"),
    ("Oshana", "NA-ON", "Region"),
    ("Oshikoto", "NA-OT", "Region"),
    ("Otjozondjupa", "NA-OD", "Region"),
    ("Zambezi", "NA-CA", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNamibia()
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
