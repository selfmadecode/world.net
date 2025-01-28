namespace World.Net.UnitTests.Countries;

public sealed class AntiguaAndBarbudaTest
{
    private const string AntiguaAndBarbuda_NAME = "AntiguaAndBarbuda";
    private const int AntiguaAndBarbuda_STATE_COUNT = 8;
    private const string AntiguaAndBarbuda_OFFICIAL_NAME = "Antigua and Barbuda";
    private const string AntiguaAndBarbuda_NATIVE_NAME = "Antigua and Barbuda";
    private const string AntiguaAndBarbuda_CAPITAL = "St.John's";
    private const int AntiguaAndBarbuda_NUMERIC_CODE = 028;
    private const string AntiguaAndBarbuda_ISO2_CODE = "AG";
    private const string AntiguaAndBarbuda_ISO3_CODE = "ATG";
    private const string AntiguaAndBarbuda_CALLING_CODE = "+1";


    [Fact]
    public void AntiguaAndBarbuda_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.AntiguaAndBarbuda;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(AntiguaAndBarbuda_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(AntiguaAndBarbuda_STATE_COUNT, country.States.Count());
        Assert.Equal(AntiguaAndBarbuda_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(AntiguaAndBarbuda_NATIVE_NAME, country.NativeName);
        Assert.Equal(AntiguaAndBarbuda_CAPITAL, country.Capital);
        Assert.Equal(AntiguaAndBarbuda_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(AntiguaAndBarbuda_ISO2_CODE, country.ISO2Code);
        Assert.Equal(AntiguaAndBarbuda_ISO3_CODE, country.ISO3Code);
        Assert.Equal(AntiguaAndBarbuda_CALLING_CODE, country.CallingCode);
    }
}
