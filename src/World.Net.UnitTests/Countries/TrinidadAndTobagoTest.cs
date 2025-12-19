namespace World.Net.UnitTests.Countries;

public sealed class TrinidadAndTobagoTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Trinidad and Tobago";
    private const string NATIVE_NAME = "Trinidad and Tobago";
    private const string CAPITAL = "Port of Spain";
    private const string OFFICIAL_NAME = "Republic of Trinidad and Tobago";
    private const string ISO2_CODE = "TT";
    private const string ISO3_CODE = "TTO";
    private const int NUMERIC_CODE = 780;
    private readonly string[] CALLING_CODE = ["+1-868"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.TrinidadAndTobago;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Arima", "TT-ARI", "City"),
    ("Chaguanas", "TT-CHA", "City"),
    ("Couva-Tabaquite-Talparo", "TT-CTT", "Region"),
    ("Diego Martin", "TT-DMN", "Region"),
    ("Mayaro-Rio Claro", "TT-MRC", "Region"),
    ("Penal-Debe", "TT-PDE", "Region"),
    ("Point Fortin", "TT-PFT", "Region"),
    ("Port of Spain", "TT-POS", "City"),
    ("San Fernando", "TT-SFO", "City"),
    ("San Juan-Laventille", "TT-SJL", "Region"),
    ("Sangre Grande", "TT-SGE", "Region"),
    ("Siparia", "TT-SIP", "Region"),
    ("Tunapuna-Piarco", "TT-TUP", "Region"),
    ("Tobago", "TT-TOB", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTrinidadAndTobago()
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
