namespace World.Net.UnitTests.Countries;

public sealed class MauritiusTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Mauritius";
    private const string OFFICIAL_NAME = "Republic of Mauritius";
    private const string NATIVE_NAME = "Maurice";
    private const string CAPITAL = "Port Louis";
    private const string ISO2_CODE = "MU";
    private const string ISO3_CODE = "MUS";
    private const int NUMERIC_CODE = 480;
    private readonly string[] CALLING_CODE = ["+230"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mauritius;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Black River", "MU-BL", "District"),
    ("Flacq", "MU-FL", "District"),
    ("Grand Port", "MU-GP", "District"),
    ("Moka", "MU-MO", "District"),
    ("Pamplemousses", "MU-PA", "District"),
    ("Plaines Wilhems", "MU-PW", "District"),
    ("Port Louis", "MU-PL", "District"),
    ("Rivière du Rempart", "MU-RR", "District"),
    ("Savanne", "MU-SA", "District")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMauritius()
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
