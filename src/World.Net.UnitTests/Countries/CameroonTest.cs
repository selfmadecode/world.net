namespace World.Net.UnitTests.Countries;

public sealed class CameroonTest
{
    private const string CAMEROON_COUNTRY_NAME = "Cameroon";
    private const string CAMEROON_NATIVE_NAME = "République du Cameroun";
    private const string CAMEROON_CAPITAL = "Yaoundé";
    private const string CAMEROON_OFFICIAL_NAME = "Republic of Cameroon";
    private const string CAMEROON_ISO2_CODE = "CM";
    private const string CAMEROON_ISO3_CODE = "CMR";
    private const int CAMEROON_NUMERIC_CODE = 120;
    private const string CAMEROON_CALLING_CODE = "+237";
    private const int CAMEROON_STATE_COUNT = 10;
    private static readonly string[] VALID_STATE_TYPES = { "Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCameroon()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Cameroon;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CAMEROON_COUNTRY_NAME, country.Name);
        Assert.Equal(CAMEROON_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CAMEROON_NATIVE_NAME, country.NativeName);
        Assert.Equal(CAMEROON_CAPITAL, country.Capital);
        Assert.Equal(CAMEROON_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CAMEROON_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CAMEROON_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CAMEROON_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CAMEROON_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}