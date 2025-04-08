namespace World.Net.UnitTests.Countries;

public sealed class AngolaTest
{
    private const string ANGOLA_COUNTRY_NAME = "Angola";
    private const string ANGOLA_NATIVE_NAME = "Angola";
    private const string ANGOLA_CAPITAL = "Luanda";
    private const string ANGOLA_OFFICIAL_NAME = "Republic of Angola";
    private const string ANGOLA_ISO2_CODE = "AO";
    private const string ANGOLA_ISO3_CODE = "AGO";
    private const int ANGOLA_NUMERIC_CODE = 024;
    private readonly string[] ANGOLA_CALLING_CODE = ["+244"];
    private const string ANGOLA_STATE_TYPE = "Province";


    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForAngola()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Angola;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ANGOLA_COUNTRY_NAME, country.Name);
        Assert.Equal(ANGOLA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ANGOLA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ANGOLA_CAPITAL, country.Capital);
        Assert.Equal(ANGOLA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ANGOLA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ANGOLA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ANGOLA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(17, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(ANGOLA_STATE_TYPE, state.Type));
    }
}
