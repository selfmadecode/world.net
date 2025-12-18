namespace World.Net.UnitTests.Countries;

public sealed class NorthKoreaTest : AssertCountryTestBase
{
    private const string NORTH_KOREA_COUNTRY_NAME = "North Korea";
    private const string NORTH_KOREA_NATIVE_NAME = "조선민주주의인민공화국";
    private const string NORTH_KOREA_CAPITAL = "Pyongyang";
    private const string NORTH_KOREA_OFFICIAL_NAME = "Democratic People's Republic of Korea";
    private const string NORTH_KOREA_ISO2_CODE = "KP";
    private const string NORTH_KOREA_ISO3_CODE = "PRK";
    private const int NORTH_KOREA_NUMERIC_CODE = 408;
    private readonly string[] NORTH_KOREA_CALLING_CODE = ["+850"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.NorthKorea;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Chagang", "KP-CHA", "Province"),
    new("North Hamgyong", "KP-HAMN", "Province"),
    new("South Hamgyong", "KP-HAMS", "Province"),
    new("North Hwanghae", "KP-HWAN", "Province"),
    new("South Hwanghae", "KP-HWAS", "Province"),
    new("Kangwon", "KP-KAN", "Province"),
    new("North Pyongan", "KP-PYON", "Province"),
    new("South Pyongan", "KP-PYOS", "Province"),
    new("Ryanggang", "KP-RYA", "Province"),
    new("Kaesong", "KP-KA", "Special City"),
    new("Nampo", "KP-NAM", "Special City"),
    new("Pyongyang", "KP-PY", "Directly Governed City"),
    new("Rason", "KP-RAS", "Directly Governed City"),
    new("Sinuiju", "KP-SIN", "Special City")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNorthKorea()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NORTH_KOREA_COUNTRY_NAME,
            NORTH_KOREA_OFFICIAL_NAME,
            NORTH_KOREA_NATIVE_NAME,
            NORTH_KOREA_CAPITAL,
            NORTH_KOREA_NUMERIC_CODE,
            NORTH_KOREA_ISO2_CODE,
            NORTH_KOREA_ISO3_CODE,
            NORTH_KOREA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
