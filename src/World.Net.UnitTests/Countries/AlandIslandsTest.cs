namespace World.Net.UnitTests.Countries;

public sealed class AlandIslandsTest
{
    private const string ALAND_ISLANDS_NAME = "Aland Islands";
    private const string ALAND_ISLANDS_OFFICIAL_NAME = "Åland Islands";
    private const string ALAND_ISLANDS_NATIVE_NAME = "Åland";
    private const string ALAND_ISLANDS_CAPITAL = "Mariehamn";
    private const int ALAND_ISLANDS_NUMERIC_CODE = 248;
    private const string ALAND_ISLANDS_ISO2_CODE = "AX";
    private const string ALAND_ISLANDS_ISO3_CODE = "ALA";
    private readonly string[] ALAND_ISLANDS_CALLING_CODE = ["+358"];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForAlandIslands()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.AlandIslands;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ALAND_ISLANDS_NAME, country.Name);
        Assert.Equal(ALAND_ISLANDS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ALAND_ISLANDS_NATIVE_NAME, country.NativeName);
        Assert.Equal(ALAND_ISLANDS_CAPITAL, country.Capital);
        Assert.Equal(ALAND_ISLANDS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ALAND_ISLANDS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ALAND_ISLANDS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ALAND_ISLANDS_CALLING_CODE, country.CallingCode);
    }
}
