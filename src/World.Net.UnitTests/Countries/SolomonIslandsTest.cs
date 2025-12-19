namespace World.Net.UnitTests.Countries;

public sealed class SolomonIslandsTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Solomon Islands";
    private const string NATIVE_NAME = "Solomon Islands";
    private const string CAPITAL = "Honiara";
    private const string OFFICIAL_NAME = "Solomon Islands";
    private const string ISO2_CODE = "SB";
    private const string ISO3_CODE = "SLB";
    private const int NUMERIC_CODE = 90;
    private readonly string[] CALLING_CODE = ["+677"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.SolomonIslands;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Central Province", "SB-CE", "Province"),
    ("Choiseul Province", "SB-CH", "Province"),
    ("Guadalcanal Province", "SB-GU", "Province"),
    ("Isabel Province", "SB-IS", "Province"),
    ("Makira-Ulawa Province", "SB-MK", "Province"),
    ("Malaita Province", "SB-ML", "Province"),
    ("Rennell and Bellona Province", "SB-RB", "Province"),
    ("Temotu Province", "SB-TE", "Province"),
    ("Western Province", "SB-WE", "Province"),
    ("Capital Territory (Honiara)", "SB-CT", "Capital Territory")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForSolomonIslands()
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
