namespace World.Net.UnitTests.Countries;

public sealed class ChristmasIslandTest
{
    private const string CHRISTMAS_ISLAND_COUNTRY_NAME = "Christmas Island";
    private const string CHRISTMAS_ISLAND_NATIVE_NAME = "Christmas Island";
    private const string CHRISTMAS_ISLAND_CAPITAL = "Flying Fish Cove";
    private const string CHRISTMAS_ISLAND_OFFICIAL_NAME = "Territory of Christmas Island";
    private const string CHRISTMAS_ISLAND_ISO2_CODE = "CX";
    private const string CHRISTMAS_ISLAND_ISO3_CODE = "CXR";
    private const int CHRISTMAS_ISLAND_NUMERIC_CODE = 162;
    private const string CHRISTMAS_ISLAND_CALLING_CODE = "+61";
    private const int CHRISTMAS_ISLAND_STATE_COUNT = 0; // No administrative divisions
    private static readonly string[] VALID_STATE_TYPES = { };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForChristmasIsland()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.ChristmasIsland;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CHRISTMAS_ISLAND_COUNTRY_NAME, country.Name);
        Assert.Equal(CHRISTMAS_ISLAND_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CHRISTMAS_ISLAND_NATIVE_NAME, country.NativeName);
        Assert.Equal(CHRISTMAS_ISLAND_CAPITAL, country.Capital);
        Assert.Equal(CHRISTMAS_ISLAND_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CHRISTMAS_ISLAND_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CHRISTMAS_ISLAND_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CHRISTMAS_ISLAND_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CHRISTMAS_ISLAND_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
