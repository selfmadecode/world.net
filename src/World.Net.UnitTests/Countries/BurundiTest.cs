namespace World.Net.UnitTests.Countries;

public sealed class BurundiTest
{
    private const string BURUNDI_COUNTRY_NAME = "Burundi";
    private const string BURUNDI_NATIVE_NAME = "Uburundi";
    private const string BURUNDI_CAPITAL = "Gitega";
    private const string BURUNDI_OFFICIAL_NAME = "Republic of Burundi";
    private const string BURUNDI_ISO2_CODE = "BI";
    private const string BURUNDI_ISO3_CODE = "BDI";
    private const int BURUNDI_NUMERIC_CODE = 108;
    private const string BURUNDI_CALLING_CODE = "+257";
    private const int BURUNDI_STATE_COUNT = 18;
    private static readonly string[] VALID_STATE_TYPES = { "Province" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForBurundi()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Burundi;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BURUNDI_COUNTRY_NAME, country.Name);
        Assert.Equal(BURUNDI_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BURUNDI_NATIVE_NAME, country.NativeName);
        Assert.Equal(BURUNDI_CAPITAL, country.Capital);
        Assert.Equal(BURUNDI_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BURUNDI_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BURUNDI_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BURUNDI_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(BURUNDI_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
