namespace World.Net.UnitTests.Countries;

public sealed class AntiguaAndBarbudaTest
{
    private const string ANTIGUA_AND_BERBUDA_NAME = "Antigua and Barbuda";
    private const int ANTIGUA_AND_BERBUDA_STATE_COUNT = 8;
    private const string ANTIGUA_AND_BERBUDA_OFFICIAL_NAME = "Antigua and Barbuda";
    private const string ANTIGUA_AND_BERBUDA_NATIVE_NAME = "Antigua and Barbuda";
    private const string ANTIGUA_AND_BERBUDA_CAPITAL = "St. John's";
    private const int ANTIGUA_AND_BERBUDA_NUMERIC_CODE = 028;
    private const string ANTIGUA_AND_BERBUDA_ISO2_CODE = "AG";
    private const string ANTIGUA_AND_BERBUDA_ISO3_CODE = "ATG";
    private const string ANTIGUA_AND_BERBUDA_CALLING_CODE = "+1";


    [Fact]
    public void ANTIGUA_AND_BERBUDA_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.AntiguaAndBarbuda;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ANTIGUA_AND_BERBUDA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(ANTIGUA_AND_BERBUDA_STATE_COUNT, country.States.Count());
        Assert.Equal(ANTIGUA_AND_BERBUDA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ANTIGUA_AND_BERBUDA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ANTIGUA_AND_BERBUDA_CAPITAL, country.Capital);
        Assert.Equal(ANTIGUA_AND_BERBUDA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ANTIGUA_AND_BERBUDA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ANTIGUA_AND_BERBUDA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ANTIGUA_AND_BERBUDA_CALLING_CODE, country.CallingCode);
    }
}
