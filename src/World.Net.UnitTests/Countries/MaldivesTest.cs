namespace World.Net.UnitTests.Countries;

public sealed class MaldivesTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Maldives";
    private const string OFFICIAL_NAME = "Republic of Maldives";
    private const string NATIVE_NAME = "Dhivehi Raajje";
    private const string CAPITAL = "Malé";
    private const string ISO2_CODE = "MV";
    private const string ISO3_CODE = "MDV";
    private const int NUMERIC_CODE = 462;
    private readonly string[] CALLING_CODE = ["+960"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Maldives;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Alif Alif", "MV-02", "Administrative Atoll"),
    ("Alif Dhaal", "MV-00", "Administrative Atoll"),
    ("Baa", "MV-20", "Administrative Atoll"),
    ("Dhaalu", "MV-17", "Administrative Atoll"),
    ("Faafu", "MV-14", "Administrative Atoll"),
    ("Gaafu Alif", "MV-27", "Administrative Atoll"),
    ("Gaafu Dhaalu", "MV-28", "Administrative Atoll"),
    ("Gnaviyani", "MV-29", "Administrative Atoll"),
    ("Haa Alif", "MV-07", "Administrative Atoll"),
    ("Haa Dhaalu", "MV-23", "Administrative Atoll"),
    ("Kaafu", "MV-26", "Administrative Atoll"),
    ("Laamu", "MV-05", "Administrative Atoll"),
    ("Lhaviyani", "MV-03", "Administrative Atoll"),
    ("Meemu", "MV-12", "Administrative Atoll"),
    ("Noonu", "MV-25", "Administrative Atoll"),
    ("Raa", "MV-13", "Administrative Atoll"),
    ("Shaviyani", "MV-24", "Administrative Atoll"),
    ("Thaa", "MV-08", "Administrative Atoll"),
    ("Vaavu", "MV-04", "Administrative Atoll"),
    ("Malé", "MV-MLE", "City")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMaldives()
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
