namespace World.Net.UnitTests.Countries;
public sealed class JapanTest
{
    private const string JAPAN_COUNTRY_NAME = "Japan";
    private const string JAPAN_NATIVE_NAME = "日本";
    private const string JAPAN_CAPITAL = "Tokyo";
    private const string JAPAN_OFFICIAL_NAME = "Japan";
    private const string JAPAN_ISO2_CODE = "JP";
    private const string JAPAN_ISO3_CODE = "JPN";
    private const int JAPAN_NUMERIC_CODE = 392;
    private readonly string[] JAPAN_CALLING_CODE = ["+81"];
    private const int JAPAN_STATE_COUNT = 47;
    private static readonly string[] VALID_STATE_TYPES = { "Prefecture" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJapan()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Japan;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(JAPAN_COUNTRY_NAME, country.Name);
        Assert.Equal(JAPAN_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(JAPAN_NATIVE_NAME, country.NativeName);
        Assert.Equal(JAPAN_CAPITAL, country.Capital);
        Assert.Equal(JAPAN_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(JAPAN_ISO2_CODE, country.ISO2Code);
        Assert.Equal(JAPAN_ISO3_CODE, country.ISO3Code);
        Assert.Equal(JAPAN_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(JAPAN_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
