namespace World.Net.UnitTests.Countries;

public sealed class CyprusTest
{
    private const string CYPRUS_COUNTRY_NAME = "Cyprus";
    private const string CYPRUS_NATIVE_NAME = "Κύπρος";
    private const string CYPRUS_CAPITAL = "Nicosia";
    private const string CYPRUS_OFFICIAL_NAME = "Republic of Cyprus";
    private const string CYPRUS_ISO2_CODE = "CY";
    private const string CYPRUS_ISO3_CODE = "CYP";
    private const int CYPRUS_NUMERIC_CODE = 196;
    private const string CYPRUS_CALLING_CODE = "+357";
    private const int CYPRUS_STATE_COUNT = 6;
    private static readonly string[] VALID_STATE_TYPES = { "District" };
    
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCyprus()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Cyprus;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CYPRUS_COUNTRY_NAME, country.Name);
        Assert.Equal(CYPRUS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CYPRUS_NATIVE_NAME, country.NativeName);
        Assert.Equal(CYPRUS_CAPITAL, country.Capital);
        Assert.Equal(CYPRUS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CYPRUS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CYPRUS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CYPRUS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CYPRUS_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
