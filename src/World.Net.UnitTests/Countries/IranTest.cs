namespace World.Net.UnitTests.Countries;

public sealed class IranTest : AssertCountryTestBase
{
    private const string IRAN_COUNTRY_NAME = "Iran";
    private const string IRAN_NATIVE_NAME = "ایران";
    private const string IRAN_CAPITAL = "Tehran";
    private const string IRAN_OFFICIAL_NAME = "Islamic Republic of Iran";
    private const string IRAN_ISO2_CODE = "IR";
    private const string IRAN_ISO3_CODE = "IRN";
    private const int IRAN_NUMERIC_CODE = 364;
    private readonly string[] IRAN_CALLING_CODE = ["+98"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Iran;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Alborz", "IR-AL", "Province"),
        new("Ardabil", "IR-AR", "Province"),
        new("Bushehr", "IR-BU", "Province"),
        new("Chaharmahal and Bakhtiari", "IR-CH", "Province"),
        new("East Azerbaijan", "IR-ES", "Province"),
        new("Fars", "IR-FA", "Province"),
        new("Gilan", "IR-GI", "Province"),
        new("Golestan", "IR-GO", "Province"),
        new("Hamadan", "IR-HM", "Province"),
        new("Hormozgan", "IR-HR", "Province"),
        new("Ilam", "IR-IL", "Province"),
        new("Isfahan", "IR-IS", "Province"),
        new("Kerman", "IR-KR", "Province"),
        new("Kermanshah", "IR-KS", "Province"),
        new("Khorasan North", "IR-KN", "Province"),
        new("Khorasan Razavi", "IR-KRZ", "Province"),
        new("Khorasan South", "IR-KS", "Province"),
        new("Khuzestan", "IR-KH", "Province"),
        new("Kohgiluyeh and Boyer-Ahmad", "IR-KB", "Province"),
        new("Kurdistan", "IR-KD", "Province"),
        new("Lorestan", "IR-LR", "Province"),
        new("Markazi", "IR-MK", "Province"),
        new("Mazandaran", "IR-MZ", "Province"),
        new("Qazvin", "IR-QZ", "Province"),
        new("Qom", "IR-QM", "Province"),
        new("Semnan", "IR-SM", "Province"),
        new("Sistan and Baluchestan", "IR-SB", "Province"),
        new("Tehran", "IR-TH", "Province"),
        new("West Azerbaijan", "IR-WA", "Province"),
        new("Yazd", "IR-YZ", "Province"),
        new("Zanjan", "IR-ZN", "Province")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIran()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            IRAN_COUNTRY_NAME,
            IRAN_OFFICIAL_NAME,
            IRAN_NATIVE_NAME,
            IRAN_CAPITAL,
            IRAN_NUMERIC_CODE,
            IRAN_ISO2_CODE,
            IRAN_ISO3_CODE,
            IRAN_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
