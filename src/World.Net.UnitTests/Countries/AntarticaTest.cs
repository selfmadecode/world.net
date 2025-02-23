namespace World.Net.UnitTests.Countries;

public class AntarticaTest
{
    private const string ANTARCTICA_COUNTRY_NAME = "Antarctica";
    private const string ANTARCTICA_NATIVE_NAME = "Antarctica";
    private const string ANTARCTICA_CAPITAL = ""; // Antarctica has no capital
    private const string ANTARCTICA_OFFICIAL_NAME = "Antarctica";
    private const string ANTARCTICA_ISO2_CODE = "AQ";
    private const string ANTARCTICA_ISO3_CODE = "ATA";
    private const int ANTARCTICA_NUMERIC_CODE = 10;
    private const string ANTARCTICA_CALLING_CODE = "+672";

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForAntarctica()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Antarctica;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ANTARCTICA_COUNTRY_NAME, country.Name);
        Assert.Equal(ANTARCTICA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ANTARCTICA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ANTARCTICA_CAPITAL, country.Capital);
        Assert.Equal(ANTARCTICA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ANTARCTICA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ANTARCTICA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ANTARCTICA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Empty(country.States);
    }
}
