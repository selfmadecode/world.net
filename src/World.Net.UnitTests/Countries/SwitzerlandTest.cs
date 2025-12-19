namespace World.Net.UnitTests.Countries;

public sealed class SwitzerlandTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Switzerland";
    private const string NATIVE_NAME = "Schweiz / Suisse / Svizzera / Svizra";
    private const string CAPITAL = "Bern";
    private const string OFFICIAL_NAME = "Swiss Confederation";
    private const string ISO2_CODE = "CH";
    private const string ISO3_CODE = "CHE";
    private const int NUMERIC_CODE = 756;
    private readonly string[] CALLING_CODE = ["+41"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Switzerland;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Aargau", "CH-AG", "Canton"),
    ("Appenzell Ausserrhoden", "CH-AR", "Canton"),
    ("Appenzell Innerrhoden", "CH-AI", "Canton"),
    ("Basel-Landschaft", "CH-BL", "Canton"),
    ("Basel-Stadt", "CH-BS", "Canton"),
    ("Bern", "CH-BE", "Canton"),
    ("Fribourg", "CH-FR", "Canton"),
    ("Geneva", "CH-GE", "Canton"),
    ("Glarus", "CH-GL", "Canton"),
    ("Graubünden", "CH-GR", "Canton"),
    ("Jura", "CH-JU", "Canton"),
    ("Lucerne", "CH-LU", "Canton"),
    ("Neuchâtel", "CH-NE", "Canton"),
    ("Nidwalden", "CH-NW", "Canton"),
    ("Obwalden", "CH-OW", "Canton"),
    ("St. Gallen", "CH-SG", "Canton"),
    ("Schaffhausen", "CH-SH", "Canton"),
    ("Solothurn", "CH-SO", "Canton"),
    ("Schwyz", "CH-SZ", "Canton"),
    ("Thurgau", "CH-TG", "Canton"),
    ("Ticino", "CH-TI", "Canton"),
    ("Uri", "CH-UR", "Canton"),
    ("Valais", "CH-VS", "Canton"),
    ("Vaud", "CH-VD", "Canton"),
    ("Zug", "CH-ZG", "Canton"),
    ("Zurich", "CH-ZH", "Canton")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSwitzerland()
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
