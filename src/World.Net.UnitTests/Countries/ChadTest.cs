namespace World.Net.UnitTests.Countries;

public sealed class ChadTest
{
    private const string CHAD_COUNTRY_NAME = "Chad";
    private const string CHAD_NATIVE_NAME = "Tchad";
    private const string CHAD_CAPITAL = "N'Djamena";
    private const string CHAD_OFFICIAL_NAME = "Republic of Chad";
    private const string CHAD_ISO2_CODE = "TD";
    private const string CHAD_ISO3_CODE = "TCD";
    private const int CHAD_NUMERIC_CODE = 148;
    private const string CHAD_CALLING_CODE = "+235";
    private const int CHAD_STATE_COUNT = 23;
    private static readonly string[] VALID_STATE_TYPES = { "Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForChad()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Chad;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CHAD_COUNTRY_NAME, country.Name);
        Assert.Equal(CHAD_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CHAD_NATIVE_NAME, country.NativeName);
        Assert.Equal(CHAD_CAPITAL, country.Capital);
        Assert.Equal(CHAD_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CHAD_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CHAD_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CHAD_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CHAD_STATE_COUNT, country.States.Count());

        // Assert that each state has a valid type
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
