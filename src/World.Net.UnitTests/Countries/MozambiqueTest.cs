namespace World.Net.UnitTests.Countries;

public sealed class MozambiqueTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Mozambique";
    private const string OFFICIAL_NAME = "Republic of Mozambique";
    private const string NATIVE_NAME = "Moçambique";
    private const string CAPITAL = "Maputo";
    private const string ISO2_CODE = "MZ";
    private const string ISO3_CODE = "MOZ";
    private const int NUMERIC_CODE = 508;
    private readonly string[] CALLING_CODE = ["+258"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mozambique;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Cabo Delgado", "MZ-P", "Province"),
    ("Gaza", "MZ-G", "Province"),
    ("Inhambane", "MZ-I", "Province"),
    ("Manica", "MZ-B", "Province"),
    ("Maputo Province", "MZ-L", "Province"),
    ("Maputo City", "MZ-MPM", "City"),
    ("Nampula", "MZ-N", "Province"),
    ("Niassa", "MZ-A", "Province"),
    ("Sofala", "MZ-S", "Province"),
    ("Tete", "MZ-T", "Province"),
    ("Zambezia", "MZ-Q", "Province")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMozambique()
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
