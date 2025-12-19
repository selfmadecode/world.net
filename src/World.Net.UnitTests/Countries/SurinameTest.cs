namespace World.Net.UnitTests.Countries;

public sealed class SurinameTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Suriname";
    private const string NATIVE_NAME = "Republiek Suriname";
    private const string CAPITAL = "Paramaribo";
    private const string OFFICIAL_NAME = "Republic of Suriname";
    private const string ISO2_CODE = "SR";
    private const string ISO3_CODE = "SUR";
    private const int NUMERIC_CODE = 740;
    private readonly string[] CALLING_CODE = ["+597"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Suriname;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Brokopondo", "SR-BR", "District"),
    ("Commewijne", "SR-CM", "District"),
    ("Coronie", "SR-CR", "District"),
    ("Marowijne", "SR-MA", "District"),
    ("Nickerie", "SR-NI", "District"),
    ("Para", "SR-PR", "District"),
    ("Paramaribo", "SR-PM", "District"),
    ("Saramacca", "SR-SA", "District"),
    ("Sipaliwini", "SR-SI", "District"),
    ("Wanica", "SR-WA", "District")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSuriname()
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
