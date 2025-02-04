namespace World.Net.UnitTests.Countries;

public sealed class AustriaTest
{
    private const string AUSTRIA_NAME = "Austria";
    private const int AUSTRIA_STATE_COUNT = 9;
    private const string AUSTRIA_OFFICIAL_NAME = "Republic of Austria";
    private const string AUSTRIA_NATIVE_NAME = "Österreich";
    private const string AUSTRIA_CAPITAL = "Vienna";
    private const int AUSTRIA_NUMERIC_CODE = 040;
    private const string AUSTRIA_ISO2_CODE = "AT";
    private const string AUSTRIA_ISO3_CODE = "AUT";
    private const string AUSTRIA_CALLING_CODE = "+43";


    [Fact]
    public void Austria_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Austria;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(AUSTRIA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(AUSTRIA_STATE_COUNT, country.States.Count());
        Assert.Equal(AUSTRIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(AUSTRIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(AUSTRIA_CAPITAL, country.Capital);
        Assert.Equal(AUSTRIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(AUSTRIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(AUSTRIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(AUSTRIA_CALLING_CODE, country.CallingCode);
    }
}
