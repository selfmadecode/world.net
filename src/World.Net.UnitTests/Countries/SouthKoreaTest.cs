namespace World.Net.UnitTests.Countries;

public sealed class SouthKoreaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "South Korea";
    private const string NATIVE_NAME = "대한민국";
    private const string CAPITAL = "Seoul";
    private const string OFFICIAL_NAME = "Republic of Korea";
    private const string ISO2_CODE = "KR";
    private const string ISO3_CODE = "KOR";
    private const int NUMERIC_CODE = 410;
    private readonly string[] CALLING_CODE = ["+82"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SouthKorea;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Seoul", "KR-11", "Special City"),
    ("Busan", "KR-26", "Metropolitan City"),
    ("Daegu", "KR-27", "Metropolitan City"),
    ("Incheon", "KR-28", "Metropolitan City"),
    ("Gwangju", "KR-29", "Metropolitan City"),
    ("Daejeon", "KR-30", "Metropolitan City"),
    ("Ulsan", "KR-31", "Metropolitan City"),
    ("Sejong", "KR-50", "Special Self-Governing City"),
    ("Gyeonggi", "KR-41", "Province"),
    ("Gangwon", "KR-42", "Province"),
    ("North Chungcheong", "KR-43", "Province"),
    ("South Chungcheong", "KR-44", "Province"),
    ("North Jeolla", "KR-45", "Province"),
    ("South Jeolla", "KR-46", "Province"),
    ("North Gyeongsang", "KR-47", "Province"),
    ("South Gyeongsang", "KR-48", "Province"),
    ("Jeju", "KR-49", "Special Self-Governing Province")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSouthKorea()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
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
