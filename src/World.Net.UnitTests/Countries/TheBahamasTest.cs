namespace World.Net.UnitTests.Countries;

public sealed class TheBahamasTest
{
    private const string THEBAHAMAS_COUNTRY_NAME = "The Bahamas";
    private const string THEBAHAMAS_NATIVE_NAME = "Bahamas";
    private const string THEBAHAMAS_CAPITAL = "Nassau";
    private const string THEBAHAMAS_OFFICIAL_NAME = "Commonwealth of the Bahamas";
    private const string THEBAHAMAS_ISO2_CODE = "BS";
    private const string THEBAHAMAS_ISO3_CODE = "BHS";
    private const int THEBAHAMAS_NUMERIC_CODE = 044;
    private readonly string[] THEBAHAMAS_CALLING_CODE = ["+1 242"];
    private const int THEBAHAMAS_STATE_COUNT = 42;
    private static readonly string[] VALID_STATE_TYPES = { "District", "Island" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTheBahamas()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Bahamas;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(THEBAHAMAS_COUNTRY_NAME, country.Name);
        Assert.Equal(THEBAHAMAS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(THEBAHAMAS_NATIVE_NAME, country.NativeName);
        Assert.Equal(THEBAHAMAS_CAPITAL, country.Capital);
        Assert.Equal(THEBAHAMAS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(THEBAHAMAS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(THEBAHAMAS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(THEBAHAMAS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(THEBAHAMAS_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
