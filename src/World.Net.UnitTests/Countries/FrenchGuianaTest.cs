namespace World.Net.UnitTests.Countries;
public sealed class FrenchGuianaTest
{
    private const string FRENCH_GUIANA_NAME = "French Guiana";
    private const string FRENCH_GUIANA_OFFICIAL_NAME = "Guyane française";
    private const string FRENCH_GUIANA_NATIVE_NAME = "Guyane française";
    private const string FRENCH_GUIANA_CAPITAL = "Cayenne";
    private const int FRENCH_GUIANA_NUMERIC_CODE = 254;
    private const string FRENCH_GUIANA_ISO2_CODE = "GF";
    private const string FRENCH_GUIANA_ISO3_CODE = "GUF";
    private readonly string[] FRENCH_GUIANA_CALLING_CODE = ["+594"];


    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFrench_Guiana()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.FrenchGuiana;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(FRENCH_GUIANA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Empty(country.States);
        Assert.Equal(FRENCH_GUIANA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(FRENCH_GUIANA_NATIVE_NAME, country.NativeName);
        Assert.Equal(FRENCH_GUIANA_CAPITAL, country.Capital);
        Assert.Equal(FRENCH_GUIANA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(FRENCH_GUIANA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(FRENCH_GUIANA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(FRENCH_GUIANA_CALLING_CODE, country.CallingCode);
    }
}
