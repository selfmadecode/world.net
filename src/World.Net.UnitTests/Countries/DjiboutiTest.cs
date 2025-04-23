namespace World.Net.UnitTests.Countries;
public sealed class DjiboutiTest
{
    private const string DJIBOUTI_NAME = "Djibouti";
    private const int DJIBOUTI_STATE_COUNT = 6;
    private const string DJIBOUTI_OFFICIAL_NAME = "Republic of Djibouti";
    private const string DJIBOUTI_NATIVE_NAME = "Djibouti";
    private const string DJIBOUTI_CAPITAL = "Djibouti";
    private const int DJIBOUTI_NUMERIC_CODE = 262;
    private const string DJIBOUTI_ISO2_CODE = "DJ";
    private const string DJIBOUTI_ISO3_CODE = "DJI";
    private static readonly string[] VALID_STATE_TYPES = { "Region", "City" };
    private readonly string[] DJIBOUTI_CALLING_CODE = ["+253"];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForDjibouti()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Djibouti;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(DJIBOUTI_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(DJIBOUTI_STATE_COUNT, country.States.Count());
        Assert.Equal(DJIBOUTI_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(DJIBOUTI_NATIVE_NAME, country.NativeName);
        Assert.Equal(DJIBOUTI_CAPITAL, country.Capital);
        Assert.Equal(DJIBOUTI_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(DJIBOUTI_ISO2_CODE, country.ISO2Code);
        Assert.Equal(DJIBOUTI_ISO3_CODE, country.ISO3Code);
        Assert.Equal(DJIBOUTI_CALLING_CODE, country.CallingCode);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
