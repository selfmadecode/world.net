namespace World.Net.UnitTests.Countries;

public sealed class CzechRepublicTest
{
    private const string CZECHREPUBLIC_COUNTRY_NAME = "Czech Republic";
    private const string CZECHREPUBLIC_NATIVE_NAME = "Česká republika";
    private const string CZECHREPUBLIC_CAPITAL = "Prague";
    private const string CZECHREPUBLIC_OFFICIAL_NAME = "Czech Republic";
    private const string CZECHREPUBLIC_ISO2_CODE = "CZ";
    private const string CZECHREPUBLIC_ISO3_CODE = "CZE";
    private const int CZECHREPUBLIC_NUMERIC_CODE = 203;
    private const string CZECHREPUBLIC_CALLING_CODE = "+420";
    private const int CZECHREPUBLIC_STATE_COUNT = 14;
    private static readonly string[] VALID_STATE_TYPES = { "Region", "Capital City" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCzechRepublic()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.CzechRepublic;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CZECHREPUBLIC_COUNTRY_NAME, country.Name);
        Assert.Equal(CZECHREPUBLIC_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CZECHREPUBLIC_NATIVE_NAME, country.NativeName);
        Assert.Equal(CZECHREPUBLIC_CAPITAL, country.Capital);
        Assert.Equal(CZECHREPUBLIC_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CZECHREPUBLIC_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CZECHREPUBLIC_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CZECHREPUBLIC_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CZECHREPUBLIC_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
