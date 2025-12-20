namespace World.Net.UnitTests.Countries;

public sealed class MexicoTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Mexico";
    private const string OFFICIAL_NAME = "United Mexican States";
    private const string NATIVE_NAME = "México";
    private const string CAPITAL = "Mexico City";
    private const string ISO2_CODE = "MX";
    private const string ISO3_CODE = "MEX";
    private const int NUMERIC_CODE = 484;
    private readonly string[] CALLING_CODE = ["+52"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mexico;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Aguascalientes", "MX-AGU", "State"),
    ("Baja California", "MX-BCN", "State"),
    ("Baja California Sur", "MX-BCS", "State"),
    ("Campeche", "MX-CAM", "State"),
    ("Chiapas", "MX-CHP", "State"),
    ("Chihuahua", "MX-CHH", "State"),
    ("Coahuila", "MX-COA", "State"),
    ("Colima", "MX-COL", "State"),
    ("Durango", "MX-DUR", "State"),
    ("Guanajuato", "MX-GUA", "State"),
    ("Guerrero", "MX-GRO", "State"),
    ("Hidalgo", "MX-HID", "State"),
    ("Jalisco", "MX-JAL", "State"),
    ("Mexico City", "MX-CMX", "Federal District"),
    ("México", "MX-MEX", "State"),
    ("Michoacán", "MX-MIC", "State"),
    ("Morelos", "MX-MOR", "State"),
    ("Nayarit", "MX-NAY", "State"),
    ("Nuevo León", "MX-NLE", "State"),
    ("Oaxaca", "MX-OAX", "State"),
    ("Puebla", "MX-PUE", "State"),
    ("Querétaro", "MX-QUE", "State"),
    ("Quintana Roo", "MX-ROO", "State"),
    ("San Luis Potosí", "MX-SLP", "State"),
    ("Sinaloa", "MX-SIN", "State"),
    ("Sonora", "MX-SON", "State"),
    ("Tabasco", "MX-TAB", "State"),
    ("Tamaulipas", "MX-TAM", "State"),
    ("Tlaxcala", "MX-TLA", "State"),
    ("Veracruz", "MX-VER", "State"),
    ("Yucatán", "MX-YUC", "State"),
    ("Zacatecas", "MX-ZAC", "State")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMexico()
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
