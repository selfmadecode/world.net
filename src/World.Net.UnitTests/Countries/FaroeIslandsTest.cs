namespace World.Net.UnitTests.Countries;

public sealed class FaroeIslandsTest
{
    private const string FAROEISLANDS_COUNTRY_NAME = "Faroe Islands";
    private const string FAROEISLANDS_NATIVE_NAME = "Føroyar";
    private const string FAROEISLANDS_CAPITAL = "Tórshavn";
    private const string FAROEISLANDS_OFFICIAL_NAME = "Faroe Islands";
    private const string FAROEISLANDS_ISO2_CODE = "FO";
    private const string FAROEISLANDS_ISO3_CODE = "FRO";
    private const int FAROEISLANDS_NUMERIC_CODE = 234;
    private readonly string[] FAROEISLANDS_CALLING_CODE = ["+298"];
    private const int FAROEISLANDS_STATE_COUNT = 6; // 6 regions
    private static readonly string[] VALID_STATE_TYPES = { "Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFaroeIslands()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.FaroeIslands;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(FAROEISLANDS_COUNTRY_NAME, country.Name);
        Assert.Equal(FAROEISLANDS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(FAROEISLANDS_NATIVE_NAME, country.NativeName);
        Assert.Equal(FAROEISLANDS_CAPITAL, country.Capital);
        Assert.Equal(FAROEISLANDS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(FAROEISLANDS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(FAROEISLANDS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(FAROEISLANDS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(FAROEISLANDS_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}


