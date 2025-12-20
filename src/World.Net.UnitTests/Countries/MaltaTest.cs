namespace World.Net.UnitTests.Countries;

public sealed class MaltaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Malta";
    private const string OFFICIAL_NAME = "Republic of Malta";
    private const string NATIVE_NAME = "Malta";
    private const string CAPITAL = "Valletta";
    private const string ISO2_CODE = "MT";
    private const string ISO3_CODE = "MLT";
    private const int NUMERIC_CODE = 470;
    private readonly string[] CALLING_CODE = ["+356"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Malta;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Gozo", "MT-45", "Region"),
    ("Northern Harbour", "MT-48", "Region"),
    ("Northern", "MT-51", "Region"),
    ("South Eastern", "MT-52", "Region"),
    ("Southern Harbour", "MT-53", "Region"),
    ("Western", "MT-55", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMalta()
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
