namespace World.Net.UnitTests.Countries;

public sealed class MalawiTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Malawi";
    private const string OFFICIAL_NAME = "Republic of Malawi";
    private const string NATIVE_NAME = "Malawi";
    private const string CAPITAL = "Lilongwe";
    private const string ISO2_CODE = "MW";
    private const string ISO3_CODE = "MWI";
    private const int NUMERIC_CODE = 454;
    private readonly string[] CALLING_CODE = ["+265"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Malawi;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Central Region", "MW-C", "Region"),
    ("Northern Region", "MW-N", "Region"),
    ("Southern Region", "MW-S", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMalawi()
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
