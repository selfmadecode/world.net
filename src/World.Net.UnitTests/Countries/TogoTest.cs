namespace World.Net.UnitTests.Countries;

public sealed class TogoTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Togo";
    private const string NATIVE_NAME = "Togo";
    private const string CAPITAL = "Lomé";
    private const string OFFICIAL_NAME = "Togolese Republic";
    private const string ISO2_CODE = "TG";
    private const string ISO3_CODE = "TGO";
    private const int NUMERIC_CODE = 768;
    private readonly string[] CALLING_CODE = ["+228"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Togo;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Centrale", "TG-C", "Region"),
    ("Kara", "TG-K", "Region"),
    ("Maritime", "TG-M", "Region"),
    ("Plateaux", "TG-P", "Region"),
    ("Savanes", "TG-S", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTogo()
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
