namespace World.Net.UnitTests.Countries;

public sealed class CroatiaTest
{
    private const string CROATIA_COUNTRY_NAME = "Croatia";
    private const string CROATIA_NATIVE_NAME = "Hrvatska";
    private const string CROATIA_CAPITAL = "Zagreb";
    private const string CROATIA_OFFICIAL_NAME = "Republic of Croatia";
    private const string CROATIA_ISO2_CODE = "HR";
    private const string CROATIA_ISO3_CODE = "HRV";
    private const int CROATIA_NUMERIC_CODE = 191;
    private const string CROATIA_CALLING_CODE = "+385";
    private const int CROATIA_STATE_COUNT = 21;
    private static readonly string[] VALID_STATE_TYPES = { "City", "County" };
    
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCroatia()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Croatia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CROATIA_COUNTRY_NAME, country.Name);
        Assert.Equal(CROATIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CROATIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(CROATIA_CAPITAL, country.Capital);
        Assert.Equal(CROATIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CROATIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CROATIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CROATIA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CROATIA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
