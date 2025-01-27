namespace World.Net.UnitTests.Countries;

public sealed class AmericanSamoaTest
{
    private const string AmericanSamoa_NAME = "American Samoa";
    private const string AmericanSamoa_OFFICIAL_NAME = "American Samoa";
    private const string AmericanSamoa_NATIVE_NAME ="American Samoa";
    private const string AmericanSamoa_CAPITAL = "Pago Pago";
    private const int AmericanSamoa_NUMERIC_CODE = 016;
    private const string AmericanSamoa_ISO2_CODE = "AS";
    private const string AmericanSamoa_ISO3_CODE = "ASM";
    private const string AmericanSamoa_CALLING_CODE = "+1";
    private const int AmericanSamoa_STATE_COUNT = 0;
    
    [Fact]
    public void AmericanSamoa_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.AmericanSamoa;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(AmericanSamoa_NAME, country.Name);
        Assert.Equal(AmericanSamoa_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(AmericanSamoa_NATIVE_NAME, country.NativeName);
        Assert.Equal(AmericanSamoa_CAPITAL, country.Capital);
        Assert.Equal(AmericanSamoa_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(AmericanSamoa_ISO2_CODE, country.ISO2Code);
        Assert.Equal(AmericanSamoa_ISO3_CODE, country.ISO3Code);
        Assert.Equal(AmericanSamoa_CALLING_CODE, country.CallingCode);
        Assert.Empty(country.States);
        Assert.Equal(AmericanSamoa_STATE_COUNT, country.States.Count());
    }
}
