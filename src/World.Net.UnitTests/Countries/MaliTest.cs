namespace World.Net.UnitTests.Countries;

public sealed class MaliTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Mali";
    private const string OFFICIAL_NAME = "Republic of Mali";
    private const string NATIVE_NAME = "Mali";
    private const string CAPITAL = "Bamako";
    private const string ISO2_CODE = "ML";
    private const string ISO3_CODE = "MLI";
    private const int NUMERIC_CODE = 466;
    private readonly string[] CALLING_CODE = ["+223"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mali;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Bamako", "ML-BKO", "District"),
    ("Gao", "ML-7", "Region"),
    ("Kayes", "ML-1", "Region"),
    ("Kidal", "ML-8", "Region"),
    ("Koulikoro", "ML-2", "Region"),
    ("Mopti", "ML-5", "Region"),
    ("Ségou", "ML-4", "Region"),
    ("Sikasso", "ML-3", "Region"),
    ("Tombouctou", "ML-6", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMali()
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
