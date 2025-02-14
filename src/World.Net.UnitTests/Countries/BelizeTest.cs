namespace World.Net.UnitTests.Countries;

public sealed class BelizeTest
{
    private const string BELIZE_NAME = "Belize";
    private const string BELIZE_OFFICIAL_NAME = "Belize";
    private const string BELIZE_NATIVE_NAME = "Belize";
    private const string BELIZE_CAPITAL = "Belmopan";
    private const int BELIZE_NUMERIC_CODE = 084;
    private const string BELIZE_ISO2_CODE = "BZ";
    private const string BELIZE_ISO3_CODE = "BLZ";
    private const string BELIZE_CALLING_CODE = "+501";
    private const int BELIZE_DISTRICT_COUNT = 6;
    private const string BELIZE_STATE_TYPE = "District";
    
    [Fact]
    public void BelizeTest_HasExpectedInformation()
    {
        // Arrange
        int belizeCountryId = CountryIdentifier.Belize;

        // Act
        var country = CountryProvider.GetCountry(belizeCountryId);

        // Assert
        Assert.Equal(belizeCountryId, country.Id);
        Assert.Equal(BELIZE_NAME, country.Name);
        Assert.Equal(BELIZE_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BELIZE_NATIVE_NAME, country.NativeName);
        Assert.Equal(BELIZE_CAPITAL, country.Capital);
        Assert.Equal(BELIZE_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BELIZE_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BELIZE_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BELIZE_CALLING_CODE, country.CallingCode);
        
        // Validate districts (Belize has 6)
        Assert.NotNull(country.States);
        Assert.Equal(BELIZE_DISTRICT_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BELIZE_STATE_TYPE, state.Type));
    }
}
