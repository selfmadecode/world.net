namespace World.Net.UnitTests.Countries;

public sealed class BahrainTest
{
    private const string BAHRAIN_COUNTRY_NAME = "Bahrain";
    private const string BAHRAIN_NATIVE_NAME = "البحرين";
    private const string BAHRAIN_CAPITAL = "Manama";
    private const string BAHRAIN_OFFICIAL_NAME = "Kingdom of Bahrain";
    private const string BAHRAIN_ISO2_CODE = "BH";
    private const string BAHRAIN_ISO3_CODE = "BHR";
    private const int BAHRAIN_NUMERIC_CODE = 048;
    private const string BAHRAIN_CALLING_CODE = "+973";
    private const int BAHRAIN_STATE_COUNT = 5;
    private static readonly string[] VALID_STATE_TYPES = { "Governorate", };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForBahrain()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Bahrain;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BAHRAIN_COUNTRY_NAME, country.Name);
        Assert.Equal(BAHRAIN_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BAHRAIN_NATIVE_NAME, country.NativeName);
        Assert.Equal(BAHRAIN_CAPITAL, country.Capital);
        Assert.Equal(BAHRAIN_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BAHRAIN_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BAHRAIN_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BAHRAIN_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(BAHRAIN_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
