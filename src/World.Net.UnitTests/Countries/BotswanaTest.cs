namespace World.Net.UnitTests.Countries;

public sealed class BotswanaTest
{
    private const string BOTSWANA_NAME = "Botswana";
    private const int BOTSWANA_STATE_COUNT = 10;
    private const string BOTSWANA_OFFICIAL_NAME = "Republic of Botswana";
    private const string BOTSWANA_NATIVE_NAME = "Botswana";
    private const string BOTSWANA_CAPITAL = "Gaborone";
    private const int BOTSWANA_NUMERIC_CODE = 072;
    private const string BOTSWANA_ISO2_CODE = "BW";
    private const string BOTSWANA_ISO3_CODE = "BWA";
    private const string BOTSWANA_CALLING_CODE = "+267";


    [Fact]
    public void Botswana_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Botswana;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BOTSWANA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(BOTSWANA_STATE_COUNT, country.States.Count());
        Assert.Equal(BOTSWANA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BOTSWANA_NATIVE_NAME, country.NativeName);
        Assert.Equal(BOTSWANA_CAPITAL, country.Capital);
        Assert.Equal(BOTSWANA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BOTSWANA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BOTSWANA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BOTSWANA_CALLING_CODE, country.CallingCode);
    }
}
