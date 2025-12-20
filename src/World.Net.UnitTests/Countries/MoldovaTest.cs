namespace World.Net.UnitTests.Countries;

public sealed class MoldovaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Moldova";
    private const string OFFICIAL_NAME = "Republic of Moldova";
    private const string NATIVE_NAME = "Republica Moldova";
    private const string CAPITAL = "Chișinău";
    private const string ISO2_CODE = "MD";
    private const string ISO3_CODE = "MDA";
    private const int NUMERIC_CODE = 498;
    private readonly string[] CALLING_CODE = ["+373"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Moldova;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Bălți", "MD-BA", "City"),
    ("Bender", "MD-BD", "City"),
    ("Chișinău", "MD-CU", "City"),
    ("Anenii Noi", "MD-AN", "District"),
    ("Basarabeasca", "MD-BS", "District"),
    ("Briceni", "MD-BR", "District"),
    ("Cahul", "MD-CA", "District"),
    ("Cantemir", "MD-CT", "District"),
    ("Călărași", "MD-CL", "District"),
    ("Cimișlia", "MD-CM", "District"),
    ("Criuleni", "MD-CR", "District"),
    ("Dondușeni", "MD-DO", "District"),
    ("Drochia", "MD-DR", "District"),
    ("Dubăsari", "MD-DU", "District"),
    ("Edineț", "MD-ED", "District"),
    ("Fălești", "MD-FA", "District"),
    ("Florești", "MD-FL", "District"),
    ("Glodeni", "MD-GL", "District"),
    ("Hîncești", "MD-HI", "District"),
    ("Ialoveni", "MD-IA", "District"),
    ("Leova", "MD-LE", "District"),
    ("Nisporeni", "MD-NI", "District"),
    ("Ocnița", "MD-OC", "District"),
    ("Orhei", "MD-OR", "District"),
    ("Rezina", "MD-RE", "District"),
    ("Rîșcani", "MD-RI", "District"),
    ("Sîngerei", "MD-SI", "District"),
    ("Soroca", "MD-SO", "District"),
    ("Strășeni", "MD-ST", "District"),
    ("Șoldănești", "MD-SD", "District"),
    ("Ștefan Vodă", "MD-SV", "District"),
    ("Taraclia", "MD-TA", "District"),
    ("Telenești", "MD-TE", "District"),
    ("Ungheni", "MD-UN", "District"),
    ("Gagauzia", "MD-GA", "Autonomous Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMoldova()
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
