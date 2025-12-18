namespace World.Net.UnitTests.Countries;

public sealed class SaudiArabiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Saudi Arabia";
    private const string NATIVE_NAME = "المملكة العربية السعودية";
    private const string CAPITAL = "Riyadh";
    private const string OFFICIAL_NAME = "Kingdom of Saudi Arabia";
    private const string ISO2_CODE = "SA";
    private const string ISO3_CODE = "SAU";
    private const int NUMERIC_CODE = 682;
    private readonly string[] CALLING_CODE = ["+966"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaudiArabia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Riyadh", "SA-01", "Region"),
        new("Makkah", "SA-02", "Region"),
        new("Al Madinah", "SA-03", "Region"),
        new("Eastern Province", "SA-04", "Region"),
        new("Asir", "SA-05", "Region"),
        new("Tabuk", "SA-07", "Region"),
        new("Hail", "SA-06", "Region"),
        new("Northern Borders", "SA-08", "Region"),
        new("Jazan", "SA-09", "Region"),
        new("Najran", "SA-10", "Region"),
        new("Al Bahah", "SA-11", "Region"),
        new("Al Jawf", "SA-12", "Region"),
        new("Qassim", "SA-14", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSaudiArabia()
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
