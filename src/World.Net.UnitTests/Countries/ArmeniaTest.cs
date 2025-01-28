namespace World.Net.UnitTests.Countries;

public sealed class ArmeniaTest
{
    private const string Armenia_NAME = "Armenia";
    private const int Armenia_STATE_COUNT = 11;
    private const string Armenia_OFFICIAL_NAME = "Armenia";
    private const string Armenia_NATIVE_NAME = "Armenia";
    private const string Armenia_CAPITAL = "Yerevan";
    private const int Armenia_NUMERIC_CODE = 051;
    private const string Armenia_ISO2_CODE = "AM";
    private const string Armenia_ISO3_CODE = "ARM";
    private const string Armenia_CALLING_CODE = "+374";


    [Fact]
    public void Armenia_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Armenia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(Armenia_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(Armenia_STATE_COUNT, country.States.Count());
        Assert.Equal(Armenia_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(Armenia_NATIVE_NAME, country.NativeName);
        Assert.Equal(Armenia_CAPITAL, country.Capital);
        Assert.Equal(Armenia_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(Armenia_ISO2_CODE, country.ISO2Code);
        Assert.Equal(Armenia_ISO3_CODE, country.ISO3Code);
        Assert.Equal(Armenia_CALLING_CODE, country.CallingCode);
    }
}
