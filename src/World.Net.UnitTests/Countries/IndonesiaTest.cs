namespace World.Net.UnitTests.Countries;

public sealed class IndonesiaTest : AssertCountryTestBase
{
    private const string INDONESIA_COUNTRY_NAME = "Indonesia";
    private const string INDONESIA_NATIVE_NAME = "Indonesia";
    private const string INDONESIA_CAPITAL = "Jakarta";
    private const string INDONESIA_OFFICIAL_NAME = "Republic of Indonesia";
    private const string INDONESIA_ISO2_CODE = "ID";
    private const string INDONESIA_ISO3_CODE = "IDN";
    private const int INDONESIA_NUMERIC_CODE = 360;
    private readonly string[] INDONESIA_CALLING_CODE = ["+62"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Indonesia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Aceh", "ID-AC", "Special Region"),
        new("Bali", "ID-BA", "Province"),
        new("Banten", "ID-BT", "Province"),
        new("Bengkulu", "ID-BE", "Province"),
        new("Central Java", "ID-JT", "Province"),
        new("Central Kalimantan", "ID-KT", "Province"),
        new("Central Sulawesi", "ID-ST", "Province"),
        new("East Java", "ID-JI", "Province"),
        new("East Kalimantan", "ID-KI", "Province"),
        new("East Nusa Tenggara", "ID-NT", "Province"),
        new("Gorontalo", "ID-GO", "Province"),
        new("Jakarta", "ID-JK", "Special Capital Region"),
        new("Jambi", "ID-JA", "Province"),
        new("Lampung", "ID-LA", "Province"),
        new("Maluku", "ID-MA", "Province"),
        new("North Kalimantan", "ID-KU", "Province"),
        new("North Maluku", "ID-MU", "Province"),
        new("North Sulawesi", "ID-SA", "Province"),
        new("North Sumatra", "ID-SU", "Province"),
        new("Papua", "ID-PA", "Province"),
        new("Riau", "ID-RI", "Province"),
        new("Riau Islands", "ID-KR", "Province"),
        new("Southeast Sulawesi", "ID-SG", "Province"),
        new("South Kalimantan", "ID-KS", "Province"),
        new("South Sulawesi", "ID-SN", "Province"),
        new("South Sumatra", "ID-SS", "Province"),
        new("Special Region of Yogyakarta", "ID-YO", "Special Region"),
        new("West Java", "ID-JB", "Province"),
        new("West Kalimantan", "ID-KB", "Province"),
        new("West Nusa Tenggara", "ID-NB", "Province"),
        new("West Papua", "ID-PA", "Province"),
        new("West Sulawesi", "ID-SB", "Province"),
        new("West Sumatra", "ID-SB", "Province"),
        new("South East Sulawesi", "ID-SG", "Province")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIndonesia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            INDONESIA_COUNTRY_NAME,
            INDONESIA_OFFICIAL_NAME,
            INDONESIA_NATIVE_NAME,
            INDONESIA_CAPITAL,
            INDONESIA_NUMERIC_CODE,
            INDONESIA_ISO2_CODE,
            INDONESIA_ISO3_CODE,
            INDONESIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
