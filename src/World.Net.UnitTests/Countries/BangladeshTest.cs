namespace World.Net.UnitTests.Countries;

public sealed class BangladeshTest
{
    private const string BANGLADESH_NAME = "Bangladesh";
    private const string BANGLADESH_OFFICIAL_NAME = "People's Republic of Bangladesh";
    private const string BANGLADESH_NATIVE_NAME = "Bangladesh";
    private const string BANGLADESH_CAPITAL = "Dhaka";
    private const int BANGLADESH_NUMERIC_CODE = 050;
    private const string BANGLADESH_ISO2_CODE = "BD";
    private const string BANGLADESH_ISO3_CODE = "BGD";
    private const string BANGLADESH_CALLING_CODE = "+880";
    private const int BANGLADESH_DIVISION_COUNT = 8;
    private const string BANGLADESH_STATE_TYPE = "Division";
    
    [Fact]
    public void Bangladesh_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Bangladesh;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BANGLADESH_NAME, country.Name);
        Assert.Equal(BANGLADESH_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BANGLADESH_NATIVE_NAME, country.NativeName);
        Assert.Equal(BANGLADESH_CAPITAL, country.Capital);
        Assert.Equal(BANGLADESH_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BANGLADESH_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BANGLADESH_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BANGLADESH_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(BANGLADESH_DIVISION_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BANGLADESH_STATE_TYPE, state.Type));
    }
}
