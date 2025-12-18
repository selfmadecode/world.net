namespace World.Net.UnitTests.Countries;

public sealed class OmanTest : AssertCountryTestBase
{
    private const string OMAN_COUNTRY_NAME = "Oman";
    private const string OMAN_NATIVE_NAME = "عُمان";
    private const string OMAN_CAPITAL = "Muscat";
    private const string OMAN_OFFICIAL_NAME = "Sultanate of Oman";
    private const string OMAN_ISO2_CODE = "OM";
    private const string OMAN_ISO3_CODE = "OMN";
    private const int OMAN_NUMERIC_CODE = 512;
    private readonly string[] OMAN_CALLING_CODE = ["+968"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Oman;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Ad Dakhiliyah", "OM-DA", "Governorate"),
    new("Ad Dhahirah", "OM-ZA", "Governorate"),
    new("Al Batinah North", "OM-BN", "Governorate"),
    new("Al Batinah South", "OM-BS", "Governorate"),
    new("Al Wusta", "OM-WU", "Governorate"),
    new("Ash Sharqiyah North", "OM-SH", "Governorate"),
    new("Ash Sharqiyah South", "OM-SS", "Governorate"),
    new("Dhofar", "OM-ZU", "Governorate"),
    new("Muscat", "OM-MU", "Governorate"),
    new("Musandam", "OM-MN", "Governorate"),
    new("Al Buraimi", "OM-BR", "Governorate")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForOman()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            OMAN_COUNTRY_NAME,
            OMAN_OFFICIAL_NAME,
            OMAN_NATIVE_NAME,
            OMAN_CAPITAL,
            OMAN_NUMERIC_CODE,
            OMAN_ISO2_CODE,
            OMAN_ISO3_CODE,
            OMAN_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
