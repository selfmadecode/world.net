namespace World.Net.UnitTests.Countries;
public sealed class DominicaTest
{
    private const string DOMINICA_NAME = "Dominica";
    private const int DOMINICA_STATE_COUNT = 10;
    private const string DOMINICA_OFFICIAL_NAME = "Commonwealth of Dominica";
    private const string DOMINICA_NATIVE_NAME = "Dominica";
    private const string DOMINICA_CAPITAL = "Roseau";
    private const int DOMINICA_NUMERIC_CODE = 212;
    private const string DOMINICA_ISO2_CODE = "DM";
    private const string DOMINICA_ISO3_CODE = "DMA";
    private readonly string[] DOMINICA_CALLING_CODE = ["+1"];


    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForDominica()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Dominica;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(DOMINICA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(DOMINICA_STATE_COUNT, country.States.Count());
        Assert.Equal(DOMINICA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(DOMINICA_NATIVE_NAME, country.NativeName);
        Assert.Equal(DOMINICA_CAPITAL, country.Capital);
        Assert.Equal(DOMINICA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(DOMINICA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(DOMINICA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(DOMINICA_CALLING_CODE, country.CallingCode);
    }
}
