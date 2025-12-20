namespace World.Net.UnitTests.Countries;

public sealed class MoroccoTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Morocco";
    private const string OFFICIAL_NAME = "Kingdom of Morocco";
    private const string NATIVE_NAME = "المغرب";
    private const string CAPITAL = "Rabat";
    private const string ISO2_CODE = "MA";
    private const string ISO3_CODE = "MAR";
    private const int NUMERIC_CODE = 504;
    private readonly string[] CALLING_CODE = ["+212"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Morocco;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Tanger-Tetouan-Al Hoceima", "MA-01", "Region"),
    ("Oriental", "MA-02", "Region"),
    ("Fes-Meknes", "MA-03", "Region"),
    ("Rabat-Sale-Kenitra", "MA-04", "Region"),
    ("Beni Mellal-Khenifra", "MA-05", "Region"),
    ("Casablanca-Settat", "MA-06", "Region"),
    ("Marrakesh-Safi", "MA-07", "Region"),
    ("Draa-Tafilalet", "MA-08", "Region"),
    ("Souss-Massa", "MA-09", "Region"),
    ("Guelmim-Oued Noun", "MA-10", "Region"),
    ("Laayoune-Sakia El Hamra", "MA-11", "Region"),
    ("Dakhla-Oued Ed-Dahab", "MA-12", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMorocco()
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
