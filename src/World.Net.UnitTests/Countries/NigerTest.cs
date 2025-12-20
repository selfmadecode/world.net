namespace World.Net.UnitTests.Countries;

public sealed class NigerTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Niger";
    private const string OFFICIAL_NAME = "Republic of the Niger";
    private const string NATIVE_NAME = "Niger";
    private const string CAPITAL = "Niamey";
    private const string ISO2_CODE = "NE";
    private const string ISO3_CODE = "NER";
    private const int NUMERIC_CODE = 562;
    private readonly string[] CALLING_CODE = ["+227"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Niger;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Agadez", "NE-1", "Region"),
    ("Diffa", "NE-2", "Region"),
    ("Dosso", "NE-3", "Region"),
    ("Maradi", "NE-4", "Region"),
    ("Tahoua", "NE-5", "Region"),
    ("Tillabéri", "NE-6", "Region"),
    ("Zinder", "NE-7", "Region"),
    ("Niamey", "NE-8", "Capital District")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNiger()
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
