namespace World.Net.UnitTests.Countries;

public sealed class FijiIslandsTest
{
    private const string FIJI_COUNTRY_NAME = "Fiji";
    private const string FIJI_NATIVE_NAME = "Matanitu ko Viti";
    private const string FIJI_CAPITAL = "Suva";
    private const string FIJI_OFFICIAL_NAME = "Republic of Fiji";
    private const string FIJI_ISO2_CODE = "FJ";
    private const string FIJI_ISO3_CODE = "FJI";
    private const int FIJI_NUMERIC_CODE = 242;
    private const string FIJI_CALLING_CODE = "+679";
    private const int FIJI_STATE_COUNT = 15; // 14 provinces + 1 dependency
    private static readonly string[] VALID_STATE_TYPES = { "Province", "Dependency" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFiji()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.FijiIslands;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(FIJI_COUNTRY_NAME, country.Name);
        Assert.Equal(FIJI_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(FIJI_NATIVE_NAME, country.NativeName);
        Assert.Equal(FIJI_CAPITAL, country.Capital);
        Assert.Equal(FIJI_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(FIJI_ISO2_CODE, country.ISO2Code);
        Assert.Equal(FIJI_ISO3_CODE, country.ISO3Code);
        Assert.Equal(FIJI_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(FIJI_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}


