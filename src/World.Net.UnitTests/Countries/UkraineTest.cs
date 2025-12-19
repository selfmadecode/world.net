namespace World.Net.UnitTests.Countries;

public sealed class UkraineTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Ukraine";
    private const string NATIVE_NAME = "Україна";
    private const string CAPITAL = "Kyiv";
    private const string OFFICIAL_NAME = "Ukraine";
    private const string ISO2_CODE = "UA";
    private const string ISO3_CODE = "UKR";
    private const int NUMERIC_CODE = 804;
    private readonly string[] CALLING_CODE = ["+380"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Ukraine;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Cherkasy", "UA-CK", "Oblast"),
    ("Chernihiv", "UA-CH", "Oblast"),
    ("Chernivtsi", "UA-CV", "Oblast"),
    ("Dnipropetrovsk", "UA-DP", "Oblast"),
    ("Donetsk", "UA-DO", "Oblast"),
    ("Ivano-Frankivsk", "UA-IF", "Oblast"),
    ("Kharkiv", "UA-KH", "Oblast"),
    ("Kherson", "UA-KH", "Oblast"),
    ("Khmelnytskyi", "UA-KM", "Oblast"),
    ("Kirovohrad", "UA-KR", "Oblast"),
    ("Kyiv", "UA-KY", "City"),
    ("Kyiv Oblast", "UA-KY", "Oblast"),
    ("Luhansk", "UA-LU", "Oblast"),
    ("Lviv", "UA-LV", "Oblast"),
    ("Mykolaiv", "UA-MK", "Oblast"),
    ("Odessa", "UA-OD", "Oblast"),
    ("Poltava", "UA-PL", "Oblast"),
    ("Rivne", "UA-RV", "Oblast"),
    ("Sevastopol", "UA-SE", "City"),
    ("Sumy", "UA-SU", "Oblast"),
    ("Ternopil", "UA-TE", "Oblast"),
    ("Vinnytsia", "UA-VI", "Oblast"),
    ("Volyn", "UA-VO", "Oblast"),
    ("Zakarpattia", "UA-ZA", "Oblast"),
    ("Zaporizhzhia", "UA-ZP", "Oblast"),
    ("Zhytomyr", "UA-ZH", "Oblast"),
    ("Autonomous Republic of Crimea", "UA-CR", "Autonomous Republic")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForUkraine()
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
