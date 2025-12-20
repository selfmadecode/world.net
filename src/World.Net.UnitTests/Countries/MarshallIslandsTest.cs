namespace World.Net.UnitTests.Countries;

public sealed class MarshallIslandsTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Marshall Islands";
    private const string OFFICIAL_NAME = "Republic of the Marshall Islands";
    private const string NATIVE_NAME = "Aelōn̄ in M̧ajeļ";
    private const string CAPITAL = "Majuro";
    private const string ISO2_CODE = "MH";
    private const string ISO3_CODE = "MHL";
    private const int NUMERIC_CODE = 584;
    private readonly string[] CALLING_CODE = ["+692"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.MarshallIslands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Ailinglaplap", "MH-ALL", "Municipality"),
    ("Arno", "MH-ARN", "Municipality"),
    ("Aur", "MH-AUR", "Municipality"),
    ("Ebeye", "MH-EBN", "Municipality"),
    ("Enewetak", "MH-ENI", "Municipality"),
    ("Jabat", "MH-JAB", "Municipality"),
    ("Jaluit", "MH-JAL", "Municipality"),
    ("Kwajalein", "MH-KWA", "Municipality"),
    ("Lae", "MH-LAE", "Municipality"),
    ("Lib", "MH-LIB", "Municipality"),
    ("Likiep", "MH-LIK", "Municipality"),
    ("Majuro", "MH-MAJ", "Municipality"),
    ("Maloelap", "MH-MAL", "Municipality"),
    ("Mejit", "MH-MEJ", "Municipality"),
    ("Mili", "MH-MIL", "Municipality"),
    ("Namdrik", "MH-NMK", "Municipality"),
    ("Namu", "MH-NMU", "Municipality"),
    ("Rongelap", "MH-RON", "Municipality"),
    ("Ujae", "MH-UJA", "Municipality"),
    ("Utrik", "MH-UTI", "Municipality"),
    ("Wotho", "MH-WTH", "Municipality"),
    ("Wotje", "MH-WTJ", "Municipality")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMarshallIslands()
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
