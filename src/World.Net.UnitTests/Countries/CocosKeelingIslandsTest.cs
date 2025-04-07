namespace World.Net.UnitTests.Countries;

public sealed class CocosKeelingIslandsTest
{
    private const string COCOS_COUNTRY_NAME = "Cocos (Keeling) Islands";
    private const string COCOS_NATIVE_NAME = "Pulu Kokos (Malay)";
    private const string COCOS_CAPITAL = "West Island";
    private const string COCOS_OFFICIAL_NAME = "Territory of Cocos (Keeling) Islands";
    private const string COCOS_ISO2_CODE = "CC";
    private const string COCOS_ISO3_CODE = "CCK";
    private const int COCOS_NUMERIC_CODE = 166;
    private readonly string[] COCOS_CALLING_CODE = ["+61"];
    private const int COCOS_STATE_COUNT = 2;
    private static readonly string[] VALID_STATE_TYPES = { "Island" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCocosKeelingIslands()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.CocosKeelingIslands;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(COCOS_COUNTRY_NAME, country.Name);
        Assert.Equal(COCOS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(COCOS_NATIVE_NAME, country.NativeName);
        Assert.Equal(COCOS_CAPITAL, country.Capital);
        Assert.Equal(COCOS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(COCOS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(COCOS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(COCOS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(COCOS_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
