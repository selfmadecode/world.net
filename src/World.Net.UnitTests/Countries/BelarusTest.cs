namespace World.Net.UnitTests.Countries;

public sealed class BelarusTest
{
    private const string BELARUS_NAME = "Belarus";
    private const string BELARUS_OFFICIAL_NAME = "Republic of Belarus";
    private const string BELARUS_NATIVE_NAME = "Беларусь";
    private const string BELARUS_CAPITAL = "Minsk";
    private const int BELARUS_NUMERIC_CODE = 112;
    private const string BELARUS_ISO2_CODE = "BY";
    private const string BELARUS_ISO3_CODE = "BLR";
    private const string BELARUS_CALLING_CODE = "+375";
    private const int BELARUS_PARISH_COUNT = 7;
    
    [Fact]
    public void Belarus_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Belarus;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BELARUS_NAME, country.Name);
        Assert.Equal(BELARUS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BELARUS_NATIVE_NAME, country.NativeName);
        Assert.Equal(BELARUS_CAPITAL, country.Capital);
        Assert.Equal(BELARUS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BELARUS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BELARUS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BELARUS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(BELARUS_PARISH_COUNT, country.States.Count());
    }
}
