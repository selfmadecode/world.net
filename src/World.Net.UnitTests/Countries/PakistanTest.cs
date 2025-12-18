namespace World.Net.UnitTests.Countries;

public sealed class PakistanTest : AssertCountryTestBase
{
    private const string PAKISTAN_COUNTRY_NAME = "Pakistan";
    private const string PAKISTAN_NATIVE_NAME = "پاکستان";
    private const string PAKISTAN_CAPITAL = "Islamabad";
    private const string PAKISTAN_OFFICIAL_NAME = "Islamic Republic of Pakistan";
    private const string PAKISTAN_ISO2_CODE = "PK";
    private const string PAKISTAN_ISO3_CODE = "PAK";
    private const int PAKISTAN_NUMERIC_CODE = 586;
    private readonly string[] PAKISTAN_CALLING_CODE = ["+92"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Pakistan;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Balochistan", "PK-BA", "Province"),
    new("Khyber Pakhtunkhwa", "PK-KP", "Province"),
    new("Punjab", "PK-PB", "Province"),
    new("Sindh", "PK-SD", "Province"),
    new("Gilgit-Baltistan", "PK-GB", "Autonomous Territory"),
    new("Azad Jammu and Kashmir", "PK-AJ", "Autonomous Territory"),
    new("Islamabad Capital Territory", "PK-IS", "Federal Territory")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPakistan()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PAKISTAN_COUNTRY_NAME,
            PAKISTAN_OFFICIAL_NAME,
            PAKISTAN_NATIVE_NAME,
            PAKISTAN_CAPITAL,
            PAKISTAN_NUMERIC_CODE,
            PAKISTAN_ISO2_CODE,
            PAKISTAN_ISO3_CODE,
            PAKISTAN_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
