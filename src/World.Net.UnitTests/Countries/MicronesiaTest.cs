namespace World.Net.UnitTests.Countries;

public sealed class MicronesiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Micronesia";
    private const string OFFICIAL_NAME = "Federated States of Micronesia";
    private const string NATIVE_NAME = "Federated States of Micronesia";
    private const string CAPITAL = "Palikir";
    private const string ISO2_CODE = "FM";
    private const string ISO3_CODE = "FSM";
    private const int NUMERIC_CODE = 583;
    private readonly string[] CALLING_CODE = ["+691"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Micronesia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Chuuk", "FM-TRK", "State"),
    ("Kosrae", "FM-KSA", "State"),
    ("Pohnpei", "FM-PNI", "State"),
    ("Yap", "FM-YAP", "State")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMicronesia()
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
