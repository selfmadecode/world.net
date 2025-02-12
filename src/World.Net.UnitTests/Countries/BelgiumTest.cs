namespace World.Net.UnitTests.Countries;

public sealed class BelgiumTest
{
    private const string BELGIUM_NAME = "Belgium";
    private const string BELGIUM_OFFICIAL_NAME = "Kingdom of Belgium";
    private const string BELGIUM_NATIVE_NAME = "België";
    private const string BELGIUM_CAPITAL = "Brussels";
    private const int BELGIUM_NUMERIC_CODE = 056;
    private const string BELGIUM_ISO2_CODE = "BE";
    private const string BELGIUM_ISO3_CODE = "BEL";
    private const string BELGIUM_CALLING_CODE = "+32";
    private const int BELGIUM_REGION_COUNT = 3;
    private const int BELGIUM_PROVINCE_COUNT = 10;
    private const string BELGIUM_REGION_TYPE = "Region";
    private const string BELGIUM_PROVINCE_TYPE = "Province";
    
    [Fact]
    public void BelgiumTest_HasExpectedInformation()
    {
        // Arrange
        int belgiumCountryId = CountryIdentifier.Belgium;

        // Act
        var country = CountryProvider.GetCountry(belgiumCountryId);

        //Assert
        // Assert
        Assert.Equal(belgiumCountryId, country.Id);
        Assert.Equal(BELGIUM_NAME, country.Name);
        Assert.Equal(BELGIUM_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BELGIUM_NATIVE_NAME, country.NativeName);
        Assert.Equal(BELGIUM_CAPITAL, country.Capital);
        Assert.Equal(BELGIUM_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BELGIUM_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BELGIUM_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BELGIUM_CALLING_CODE, country.CallingCode);
        
        // Validate states (regions and provinces)
        Assert.NotNull(country.States);

        // Belgium has 3 regions and 10 provinces
        Assert.Equal(BELGIUM_REGION_COUNT + BELGIUM_PROVINCE_COUNT, country.States.Count());

        // Validate region types
        Assert.Equal(BELGIUM_REGION_COUNT, country.States.Count(s => s.Type == BELGIUM_REGION_TYPE));
        Assert.Equal(BELGIUM_PROVINCE_COUNT, country.States.Count(s => s.Type == BELGIUM_PROVINCE_TYPE));
    }
}
