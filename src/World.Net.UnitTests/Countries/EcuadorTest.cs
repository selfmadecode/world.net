namespace World.Net.UnitTests.Countries;

public sealed class EcuadorTest
{
    private const string ECUADOR_COUNTRY_NAME = "Ecuador";
    private const string ECUADOR_NATIVE_NAME = "República del Ecuador";
    private const string ECUADOR_CAPITAL = "Quito";
    private const string ECUADOR_OFFICIAL_NAME = "Republic of Ecuador";
    private const string ECUADOR_ISO2_CODE = "EC";
    private const string ECUADOR_ISO3_CODE = "ECU";
    private const int ECUADOR_NUMERIC_CODE = 218;
    private readonly string[] ECUADOR_CALLING_CODE = ["+593"];
    private const int ECUADOR_STATE_COUNT = 24; // 24 provinces
    private static readonly string[] VALID_STATE_TYPES = { "Province" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForEcuador()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Ecuador;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ECUADOR_COUNTRY_NAME, country.Name);
        Assert.Equal(ECUADOR_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ECUADOR_NATIVE_NAME, country.NativeName);
        Assert.Equal(ECUADOR_CAPITAL, country.Capital);
        Assert.Equal(ECUADOR_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ECUADOR_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ECUADOR_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ECUADOR_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(ECUADOR_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
