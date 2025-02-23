namespace World.Net.UnitTests.Countries;

public sealed class AzerbaijanTest
{
    private const string AZERBAIJAN_COUNTRY_NAME = "Azerbaijan";
    private const string AZERBAIJAN_NATIVE_NAME = "Azərbaycan";
    private const string AZERBAIJAN_CAPITAL = "Baku";
    private const string AZERBAIJAN_OFFICIAL_NAME = "Republic of Azerbaijan";
    private const string AZERBAIJAN_ISO2_CODE = "AZ";
    private const string AZERBAIJAN_ISO3_CODE = "AZE";
    private const int AZERBAIJAN_NUMERIC_CODE = 031;
    private const string AZERBAIJAN_CALLING_CODE = "+994";
    private const int AZERBAIJAN_STATE_COUNT = 75;
    private static readonly string[] VALID_STATE_TYPES = { "District", "Municipality", "Autonomous Republic", };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForAzerbaijan()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Azerbaijan;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(AZERBAIJAN_COUNTRY_NAME, country.Name);
        Assert.Equal(AZERBAIJAN_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(AZERBAIJAN_NATIVE_NAME, country.NativeName);
        Assert.Equal(AZERBAIJAN_CAPITAL, country.Capital);
        Assert.Equal(AZERBAIJAN_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(AZERBAIJAN_ISO2_CODE, country.ISO2Code);
        Assert.Equal(AZERBAIJAN_ISO3_CODE, country.ISO3Code);
        Assert.Equal(AZERBAIJAN_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(AZERBAIJAN_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));        
    }
}
