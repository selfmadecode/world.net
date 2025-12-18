namespace World.Net.UnitTests.Countries;

public sealed class NigeriaTest : AssertCountryTestBase
{
    private const string NIGERIA_COUNTRY_NAME = "Nigeria";
    private const string NIGERIA_NATIVE_NAME = "Nigeria";
    private const string NIGERIA_CAPITAL = "Abuja";
    private const string NIGERIA_OFFICIAL_NAME = "Federal Republic of Nigeria";
    private const string NIGERIA_ISO2_CODE = "NG";
    private const string NIGERIA_ISO3_CODE = "NGA";
    private const int NIGERIA_NUMERIC_CODE = 566;
    private readonly string[] NIGERIA_CALLING_CODE = ["+234"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Nigeria;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Abia", "NG-AB", "State"),
        new("Adamawa", "NG-AD", "State"),
        new("Akwa Ibom", "NG-AK", "State"),
        new("Anambra", "NG-AN", "State"),
        new("Bauchi", "NG-BA", "State"),
        new("Bayelsa", "NG-BY", "State"),
        new("Benue", "NG-BE", "State"),
        new("Borno", "NG-BO", "State"),
        new("Cross River", "NG-CR", "State"),
        new("Delta", "NG-DE", "State"),
        new("Ebonyi", "NG-EB", "State"),
        new("Edo", "NG-ED", "State"),
        new("Ekiti", "NG-EK", "State"),
        new("Enugu", "NG-EN", "State"),
        new("Gombe", "NG-GO", "State"),
        new("Imo", "NG-IM", "State"),
        new("Jigawa", "NG-JI", "State"),
        new("Kaduna", "NG-KD", "State"),
        new("Kano", "NG-KN", "State"),
        new("Katsina", "NG-KT", "State"),
        new("Kebbi", "NG-KE", "State"),
        new("Kogi", "NG-KO", "State"),
        new("Kwara", "NG-KW", "State"),
        new("Lagos", "NG-LA", "State"),
        new("Nasarawa", "NG-NA", "State"),
        new("Niger", "NG-NI", "State"),
        new("Ogun", "NG-OG", "State"),
        new("Ondo", "NG-ON", "State"),
        new("Osun", "NG-OS", "State"),
        new("Oyo", "NG-OY", "State"),
        new("Plateau", "NG-PL", "State"),
        new("Rivers", "NG-RI", "State"),
        new("Sokoto", "NG-SO", "State"),
        new("Taraba", "NG-TA", "State"),
        new("Yobe", "NG-YO", "State"),
        new("Zamfara", "NG-ZA", "State"),
        new("Federal Capital Territory", "NG-FC", "Federal Capital Territory")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNigeria()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NIGERIA_COUNTRY_NAME,
            NIGERIA_OFFICIAL_NAME,
            NIGERIA_NATIVE_NAME,
            NIGERIA_CAPITAL,
            NIGERIA_NUMERIC_CODE,
            NIGERIA_ISO2_CODE,
            NIGERIA_ISO3_CODE,
            NIGERIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
