namespace World.Net.UnitTests.Countries;

public sealed class SpainTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Spain";
    private const string NATIVE_NAME = "España";
    private const string CAPITAL = "Madrid";
    private const string OFFICIAL_NAME = "Kingdom of Spain";
    private const string ISO2_CODE = "ES";
    private const string ISO3_CODE = "ESP";
    private const int NUMERIC_CODE = 724;
    private readonly string[] CALLING_CODE = ["+34"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Spain;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
        ("Andalusia", "ES-AN", "Autonomous Community"),
        ("Aragon", "ES-AR", "Autonomous Community"),
        ("Asturias", "ES-AS", "Autonomous Community"),
        ("Balearic Islands", "ES-IB", "Autonomous Community"),
        ("Basque Country", "ES-PV", "Autonomous Community"),
        ("Canary Islands", "ES-CN", "Autonomous Community"),
        ("Cantabria", "ES-CB", "Autonomous Community"),
        ("Castile and León", "ES-CL", "Autonomous Community"),
        ("Castile-La Mancha", "ES-CM", "Autonomous Community"),
        ("Catalonia", "ES-CT", "Autonomous Community"),
        ("Extremadura", "ES-EX", "Autonomous Community"),
        ("Galicia", "ES-GA", "Autonomous Community"),
        ("La Rioja", "ES-RI", "Autonomous Community"),
        ("Community of Madrid", "ES-MD", "Autonomous Community"),
        ("Region of Murcia", "ES-MC", "Autonomous Community"),
        ("Navarre", "ES-NC", "Autonomous Community"),
        ("Valencian Community", "ES-VC", "Autonomous Community"),
        ("Ceuta", "ES-CE", "Autonomous City"),
        ("Melilla", "ES-ML", "Autonomous City")
    };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSpain()
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
