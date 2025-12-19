namespace World.Net.UnitTests.Countries;

public sealed class SyriaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Syria";
    private const string NATIVE_NAME = "الجمهورية العربية السورية";
    private const string CAPITAL = "Damascus";
    private const string OFFICIAL_NAME = "Syrian Arab Republic";
    private const string ISO2_CODE = "SY";
    private const string ISO3_CODE = "SYR";
    private const int NUMERIC_CODE = 760;
    private readonly string[] CALLING_CODE = ["+963"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Syria;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Al-Hasakah", "SY-HA", "Governorate"),
    ("Al-Ladhiqiyah", "SY-LA", "Governorate"),
    ("Al-Qunaytirah", "SY-QU", "Governorate"),
    ("Ar-Raqqah", "SY-RQ", "Governorate"),
    ("As-Suwayda", "SY-SU", "Governorate"),
    ("Dar‘a", "SY-DR", "Governorate"),
    ("Dayr az-Zawr", "SY-DY", "Governorate"),
    ("Rif Dimashq", "SY-DI", "Governorate"),
    ("Dimashq", "SY-DI", "Governorate"),
    ("Hamah", "SY-HM", "Governorate"),
    ("Hims", "SY-HI", "Governorate"),
    ("Idlib", "SY-ID", "Governorate"),
    ("Tartus", "SY-TA", "Governorate"),
    ("Raqqa", "SY-RQ", "Governorate")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSyria()
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
