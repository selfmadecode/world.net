namespace World.Net.UnitTests.Countries;
public sealed class IsraelTest
{
    private const string ISRAEL_COUNTRY_NAME = "Israel";
    private const string ISRAEL_NATIVE_NAME = "יִשְׂרָאֵל";
    private const string ISRAEL_CAPITAL = "Jerusalem";
    private const string ISRAEL_OFFICIAL_NAME = "State of Israel";
    private const string ISRAEL_ISO2_CODE = "IL";
    private const string ISRAEL_ISO3_CODE = "ISR";
    private const int ISRAEL_NUMERIC_CODE = 376;
    private readonly string[] ISRAEL_CALLING_CODE = ["+972"];
    private const int ISRAEL_STATE_COUNT = 6;
    private static readonly string[] VALID_STATE_TYPES = { "District" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIsrael()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Israel;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ISRAEL_COUNTRY_NAME, country.Name);
        Assert.Equal(ISRAEL_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ISRAEL_NATIVE_NAME, country.NativeName);
        Assert.Equal(ISRAEL_CAPITAL, country.Capital);
        Assert.Equal(ISRAEL_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ISRAEL_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ISRAEL_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ISRAEL_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(ISRAEL_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
