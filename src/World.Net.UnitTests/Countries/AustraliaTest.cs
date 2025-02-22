namespace World.Net.UnitTests.Countries;

public sealed class AustraliaTest
{
    private const string AUSTRALIA_NAME = "Australia";
    private const int AUSTRALIA_STATE_COUNT = 8;
    private const string AUSTRALIA_OFFICIAL_NAME = "Commonwealth of Australia";
    private const string AUSTRALIA_NATIVE_NAME = "Australia";
    private const string AUSTRALIA_CAPITAL = "Canberra";
    private const int AUSTRALIA_NUMERIC_CODE = 036;
    private const string AUSTRALIA_ISO2_CODE = "AU";
    private const string AUSTRALIA_ISO3_CODE = "AUS";
    private const string AUSTRALIA_CALLING_CODE = "+61";


    [Fact]
    public void Australia_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Australia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(AUSTRALIA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(AUSTRALIA_STATE_COUNT, country.States.Count());
        Assert.Equal(AUSTRALIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(AUSTRALIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(AUSTRALIA_CAPITAL, country.Capital);
        Assert.Equal(AUSTRALIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(AUSTRALIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(AUSTRALIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(AUSTRALIA_CALLING_CODE, country.CallingCode);
    }
}
