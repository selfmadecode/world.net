namespace World.Net.UnitTests.Countries;

public sealed class ARMENIATest
{
    private const string ARMENIA_NAME = "Armenia";
    private const int ARMENIA_STATE_COUNT = 11;
    private const string ARMENIA_OFFICIAL_NAME = "Armenia";
    private const string ARMENIA_NATIVE_NAME = "Հայաստան";
    private const string ARMENIA_CAPITAL = "Yerevan";
    private const int ARMENIA_NUMERIC_CODE = 051;
    private const string ARMENIA_ISO2_CODE = "AM";
    private const string ARMENIA_ISO3_CODE = "ARM";
    private const string ARMENIA_CALLING_CODE = "+374";


    [Fact]
    public void ARMENIA_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Armenia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ARMENIA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(ARMENIA_STATE_COUNT, country.States.Count());
        Assert.Equal(ARMENIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ARMENIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ARMENIA_CAPITAL, country.Capital);
        Assert.Equal(ARMENIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ARMENIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ARMENIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ARMENIA_CALLING_CODE, country.CallingCode);
    }
}
