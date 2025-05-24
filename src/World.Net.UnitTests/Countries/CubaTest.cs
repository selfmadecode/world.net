namespace World.Net.UnitTests.Countries;

public sealed class CubaTest
{
    private const string CUBA_COUNTRY_NAME = "Cuba";
    private const string CUBA_NATIVE_NAME = "Cuba";
    private const string CUBA_CAPITAL = "Havana";
    private const string CUBA_OFFICIAL_NAME = "Republic of Cuba";
    private const string CUBA_ISO2_CODE = "CU";
    private const string CUBA_ISO3_CODE = "CUB";
    private const int CUBA_NUMERIC_CODE = 192;
    private readonly string[] CUBA_CALLING_CODE = ["+53"];
    private const int CUBA_STATE_COUNT = 16;
    private static readonly string[] VALID_STATE_TYPES = { "Province", "Special Municipality" };
    
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCuba()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Cuba;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CUBA_COUNTRY_NAME, country.Name);
        Assert.Equal(CUBA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CUBA_NATIVE_NAME, country.NativeName);
        Assert.Equal(CUBA_CAPITAL, country.Capital);
        Assert.Equal(CUBA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CUBA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CUBA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CUBA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CUBA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
