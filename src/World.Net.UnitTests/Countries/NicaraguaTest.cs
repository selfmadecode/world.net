namespace World.Net.UnitTests.Countries;

public sealed class NicaraguaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Nicaragua";
    private const string OFFICIAL_NAME = "Republic of Nicaragua";
    private const string NATIVE_NAME = "Nicaragua";
    private const string CAPITAL = "Managua";
    private const string ISO2_CODE = "NI";
    private const string ISO3_CODE = "NIC";
    private const int NUMERIC_CODE = 558;
    private readonly string[] CALLING_CODE = ["+505"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Nicaragua;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Boaco", "NI-BO", "Department"),
    ("Carazo", "NI-CA", "Department"),
    ("Chinandega", "NI-CI", "Department"),
    ("Chontales", "NI-CO", "Department"),
    ("Estelí", "NI-ES", "Department"),
    ("Granada", "NI-GR", "Department"),
    ("Jinotega", "NI-JI", "Department"),
    ("León", "NI-LE", "Department"),
    ("Madriz", "NI-MD", "Department"),
    ("Managua", "NI-MN", "Department"),
    ("Masaya", "NI-MS", "Department"),
    ("Matagalpa", "NI-MT", "Department"),
    ("North Caribbean Coast", "NI-AN", "Autonomous Region"),
    ("South Caribbean Coast", "NI-AS", "Autonomous Region"),
    ("Nueva Segovia", "NI-NS", "Department"),
    ("Rivas", "NI-RI", "Department"),
    ("Río San Juan", "NI-SJ", "Department")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNicaragua()
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
