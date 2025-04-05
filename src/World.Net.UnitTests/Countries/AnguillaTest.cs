namespace World.Net.UnitTests.Countries;

public sealed class AnguillaTest
{
    private const string ANGUILLA_COUNTRY_NAME = "Anguilla";
    private const string ANGUILLA_NATIVE_NAME = "Anguilla";
    private const string ANGUILLA_CAPITAL = "The Valley";
    private const string ANGUILLA_OFFICIAL_NAME = "Anguilla";
    private const string ANGUILLA_ISO2_CODE = "AI";
    private const string ANGUILLA_ISO3_CODE = "AIA";
    private const int ANGUILLA_NUMERIC_CODE = 660;
    private readonly string[] ANGUILLA_CALLING_CODE = ["+1-264"];
    private const int ANGUILLA_DISTRICT_COUNT = 14;
    private const string ANGUILLA_STATE_TYPE = "District";

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForAnguilla()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Anguilla;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ANGUILLA_COUNTRY_NAME, country.Name);
        Assert.Equal(ANGUILLA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ANGUILLA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ANGUILLA_CAPITAL, country.Capital);
        Assert.Equal(ANGUILLA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ANGUILLA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ANGUILLA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ANGUILLA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(ANGUILLA_DISTRICT_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(ANGUILLA_STATE_TYPE, state.Type));
    }
}
