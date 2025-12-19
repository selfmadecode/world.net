namespace World.Net.UnitTests.Countries;

public sealed class SwedenTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Sweden";
    private const string NATIVE_NAME = "Sverige";
    private const string CAPITAL = "Stockholm";
    private const string OFFICIAL_NAME = "Kingdom of Sweden";
    private const string ISO2_CODE = "SE";
    private const string ISO3_CODE = "SWE";
    private const int NUMERIC_CODE = 752;
    private readonly string[] CALLING_CODE = ["+46"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Sweden;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Blekinge", "SE-K", "County"),
    ("Dalarna", "SE-W", "County"),
    ("Gävleborg", "SE-X", "County"),
    ("Gotland", "SE-I", "County"),
    ("Halland", "SE-N", "County"),
    ("Jämtland", "SE-Z", "County"),
    ("Jönköping", "SE-F", "County"),
    ("Kalmar", "SE-H", "County"),
    ("Kronoberg", "SE-G", "County"),
    ("Norrbotten", "SE-B", "County"),
    ("Örebro", "SE-T", "County"),
    ("Östergötland", "SE-E", "County"),
    ("Skåne", "SE-M", "County"),
    ("Södermanland", "SE-D", "County"),
    ("Uppsala", "SE-C", "County"),
    ("Värmland", "SE-S", "County"),
    ("Västerbotten", "SE-AC", "County"),
    ("Västernorrland", "SE-Y", "County"),
    ("Västmanland", "SE-U", "County"),
    ("Västra Götaland", "SE-O", "County"),
    ("Öland", "SE-ZX", "County")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSweden()
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
