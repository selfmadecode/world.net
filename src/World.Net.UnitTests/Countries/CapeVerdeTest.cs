namespace World.Net.UnitTests.Countries;

public sealed class CapeVerdeTest
{
    private const string CAPEVERDE_COUNTRY_NAME = "Cape Verde";
    private const string CAPEVERDE_NATIVE_NAME = "Cabo Verde";
    private const string CAPEVERDE_CAPITAL = "Praia";
    private const string CAPEVERDE_OFFICIAL_NAME = "Republic of Cabo Verde";
    private const string CAPEVERDE_ISO2_CODE = "CV";
    private const string CAPEVERDE_ISO3_CODE = "CPV";
    private const int CAPEVERDE_NUMERIC_CODE = 132;
    private const string CAPEVERDE_CALLING_CODE = "+238";
    private const int CAPEVERDE_STATE_COUNT = 22;
    private static readonly string[] VALID_STATE_TYPES = { "Municipality" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCapeVerde()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.CapeVerde;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CAPEVERDE_COUNTRY_NAME, country.Name);
        Assert.Equal(CAPEVERDE_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CAPEVERDE_NATIVE_NAME, country.NativeName);
        Assert.Equal(CAPEVERDE_CAPITAL, country.Capital);
        Assert.Equal(CAPEVERDE_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CAPEVERDE_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CAPEVERDE_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CAPEVERDE_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CAPEVERDE_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
