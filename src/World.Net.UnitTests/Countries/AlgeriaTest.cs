namespace World.Net.UnitTests.Countries;

public sealed class AlgeriaTest
{
    private const string ALGERIA_NAME = "Algeria";
    private const string ALGERIA_OFFICIAL_NAME = "People's Democratic Republic of Algeria";
    private const string ALGERIA_NATIVE_NAME = "الجزائر";
    private const string ALGERIA_CAPITAL = "Algiers";
    private const int ALGERIA_NUMERIC_CODE = 012;
    private const string ALGERIA_ISO2_CODE = "DZ";
    private const string ALGERIA_ISO3_CODE = "DZA";
    private const string ALGERIA_CALLING_CODE = "+213";
    private const int ALGERIA_PROVINCE_COUNT = 57;
    private const string ALGERIA_STATE_TYPE = "Province";
    
    [Fact]
    public void Algeria_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Algeria;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ALGERIA_NAME, country.Name);
        Assert.Equal(ALGERIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ALGERIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ALGERIA_CAPITAL, country.Capital);
        Assert.Equal(ALGERIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ALGERIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ALGERIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ALGERIA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(ALGERIA_PROVINCE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(ALGERIA_STATE_TYPE, state.Type));
    }
}
