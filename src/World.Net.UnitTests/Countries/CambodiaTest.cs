namespace World.Net.UnitTests.Countries;

public sealed class CambodiaTest
{
    private const string CAMBODIA_COUNTRY_NAME = "Cambodia";
    private const string CAMBODIA_NATIVE_NAME = "កម្ពុជា";
    private const string CAMBODIA_CAPITAL = "Phnom Penh";
    private const string CAMBODIA_OFFICIAL_NAME = "Kingdom of Cambodia";
    private const string CAMBODIA_ISO2_CODE = "KH";
    private const string CAMBODIA_ISO3_CODE = "KHM";
    private const int CAMBODIA_NUMERIC_CODE = 116;
    private const string CAMBODIA_CALLING_CODE = "+855";
    private const int CAMBODIA_STATE_COUNT = 25;
    private static readonly string[] VALID_STATE_TYPES = { "Province", "Municipality" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCambodia()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Cambodia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CAMBODIA_COUNTRY_NAME, country.Name);
        Assert.Equal(CAMBODIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CAMBODIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(CAMBODIA_CAPITAL, country.Capital);
        Assert.Equal(CAMBODIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CAMBODIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CAMBODIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CAMBODIA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CAMBODIA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
