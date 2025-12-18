namespace World.Net.UnitTests.Countries;

public sealed class HungaryTest : AssertCountryTestBase
{
    private const string HUNGARY_COUNTRY_NAME = "Hungary";
    private const string HUNGARY_NATIVE_NAME = "Magyarország";
    private const string HUNGARY_CAPITAL = "Budapest";
    private const string HUNGARY_OFFICIAL_NAME = "Hungary";
    private const string HUNGARY_ISO2_CODE = "HU";
    private const string HUNGARY_ISO3_CODE = "HUN";
    private const int HUNGARY_NUMERIC_CODE = 348;
    private readonly string[] HUNGARY_CALLING_CODE = ["+36"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Hungary;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Budapest", "HU-BU", "Capital City"),
        new("Bács-Kiskun", "HU-BK", "County"),
        new("Baranya", "HU-BA", "County"),
        new("Békés", "HU-BE", "County"),
        new("Borsod-Abaúj-Zemplén", "HU-BO", "County"),
        new("Csongrád-Csanád", "HU-CS", "County"),
        new("Fejér", "HU-FE", "County"),
        new("Győr-Moson-Sopron", "HU-GS", "County"),
        new("Hajdú-Bihar", "HU-HB", "County"),
        new("Heves", "HU-HE", "County"),
        new("Jász-Nagykun-Szolnok", "HU-JN", "County"),
        new("Komárom-Esztergom", "HU-KM", "County"),
        new("Nógrád", "HU-NO", "County"),
        new("Pest", "HU-PE", "County"),
        new("Somogy", "HU-SO", "County"),
        new("Szabolcs-Szatmár-Bereg", "HU-SZ", "County"),
        new("Tolna", "HU-TO", "County"),
        new("Vas", "HU-VA", "County"),
        new("Veszprém", "HU-VE", "County"),
        new("Zala", "HU-ZA", "County")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForHungary()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            HUNGARY_COUNTRY_NAME,
            HUNGARY_OFFICIAL_NAME,
            HUNGARY_NATIVE_NAME,
            HUNGARY_CAPITAL,
            HUNGARY_NUMERIC_CODE,
            HUNGARY_ISO2_CODE,
            HUNGARY_ISO3_CODE,
            HUNGARY_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
