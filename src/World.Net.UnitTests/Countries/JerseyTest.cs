namespace World.Net.UnitTests.Countries;
public sealed class JerseyTest
{
    private const string JERSEY_COUNTRY_NAME = "Jersey";
    private const string JERSEY_NATIVE_NAME = "Jersey";
    private const string JERSEY_CAPITAL = "Saint Helier";
    private const string JERSEY_OFFICIAL_NAME = "Bailiwick of Jersey";
    private const string JERSEY_ISO2_CODE = "JE";
    private const string JERSEY_ISO3_CODE = "JEY";
    private const int JERSEY_NUMERIC_CODE = 832;
    private readonly string[] JERSEY_CALLING_CODE = ["+44"];
    private const int JERSEY_STATE_COUNT = 12;
    private static readonly string[] VALID_STATE_TYPES = { "parish" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJersey()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Jersey;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(JERSEY_COUNTRY_NAME, country.Name);
        Assert.Equal(JERSEY_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(JERSEY_NATIVE_NAME, country.NativeName);
        Assert.Equal(JERSEY_CAPITAL, country.Capital);
        Assert.Equal(JERSEY_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(JERSEY_ISO2_CODE, country.ISO2Code);
        Assert.Equal(JERSEY_ISO3_CODE, country.ISO3Code);
        Assert.Equal(JERSEY_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(JERSEY_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
