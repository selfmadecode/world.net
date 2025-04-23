namespace World.Net.UnitTests.Countries;
public sealed class DenmarkTest
{
    private const string DENMARK_NAME = "Denmark";
    private const int DENMARK_STATE_COUNT = 5;
    private const string DENMARK_OFFICIAL_NAME = "Kingdom of Denmark";
    private const string DENMARK_NATIVE_NAME = "Danmark";
    private const string DENMARK_CAPITAL = "Copenhagen";
    private const int DENMARK_NUMERIC_CODE = 208;
    private const string DENMARK_ISO2_CODE = "DK";
    private const string DENMARK_ISO3_CODE = "DNK";
    private readonly string[] DENMARK_CALLING_CODE = ["+45"];
    private static readonly string[] VALID_STATE_TYPES = { "Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForDenmark()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Denmark;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(DENMARK_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(DENMARK_STATE_COUNT, country.States.Count());
        Assert.Equal(DENMARK_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(DENMARK_NATIVE_NAME, country.NativeName);
        Assert.Equal(DENMARK_CAPITAL, country.Capital);
        Assert.Equal(DENMARK_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(DENMARK_ISO2_CODE, country.ISO2Code);
        Assert.Equal(DENMARK_ISO3_CODE, country.ISO3Code);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
        Assert.Equal(DENMARK_CALLING_CODE, country.CallingCode);
    }
}
