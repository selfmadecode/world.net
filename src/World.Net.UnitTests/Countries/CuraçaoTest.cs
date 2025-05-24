namespace World.Net.UnitTests.Countries;

public sealed class CuraçaoTest
{
    private const string CURACAO_COUNTRY_NAME = "Curaçao";
    private const string CURACAO_NATIVE_NAME = "Kòrsou";
    private const string CURACAO_CAPITAL = "Willemstad";
    private const string CURACAO_OFFICIAL_NAME = "Country of Curaçao";
    private const string CURACAO_ISO2_CODE = "CW";
    private const string CURACAO_ISO3_CODE = "CUW";
    private const int CURACAO_NUMERIC_CODE = 531;
    private readonly string[] CURACAO_CALLING_CODE = ["+599"];
    private const int CURACAO_STATE_COUNT = 1;
    private static readonly string[] VALID_STATE_TYPES = { "Country" };
    
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCuracao()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Curacao;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CURACAO_COUNTRY_NAME, country.Name);
        Assert.Equal(CURACAO_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CURACAO_NATIVE_NAME, country.NativeName);
        Assert.Equal(CURACAO_CAPITAL, country.Capital);
        Assert.Equal(CURACAO_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CURACAO_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CURACAO_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CURACAO_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.NotEmpty(country.States);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
