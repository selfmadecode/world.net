namespace World.Net.UnitTests.Countries;

public sealed class MauritaniaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Mauritania";
    private const string OFFICIAL_NAME = "Islamic Republic of Mauritania";
    private const string NATIVE_NAME = "الجمهورية الإسلامية الموريتانية";
    private const string CAPITAL = "Nouakchott";
    private const string ISO2_CODE = "MR";
    private const string ISO3_CODE = "MRT";
    private const int NUMERIC_CODE = 478;
    private readonly string[] CALLING_CODE = ["+222"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mauritania;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Adrar", "MR-07", "Region"),
    ("Assaba", "MR-03", "Region"),
    ("Brakna", "MR-05", "Region"),
    ("Dakhlet Nouadhibou", "MR-08", "Region"),
    ("Gorgol", "MR-04", "Region"),
    ("Guidimaka", "MR-10", "Region"),
    ("Hodh Ech Chargui", "MR-01", "Region"),
    ("Hodh El Gharbi", "MR-02", "Region"),
    ("Inchiri", "MR-12", "Region"),
    ("Nouakchott Nord", "MR-14", "Region"),
    ("Nouakchott Ouest", "MR-13", "Region"),
    ("Nouakchott Sud", "MR-15", "Region"),
    ("Tagant", "MR-09", "Region"),
    ("Tiris Zemmour", "MR-11", "Region"),
    ("Trarza", "MR-06", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMauritania()
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
