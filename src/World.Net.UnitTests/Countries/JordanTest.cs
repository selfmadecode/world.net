namespace World.Net.UnitTests.Countries;
public sealed class JordanTest
{
    private const string JORDAN_COUNTRY_NAME = "Jordan";
    private const string JORDAN_NATIVE_NAME = "الأردن";
    private const string JORDAN_CAPITAL = "Amman";
    private const string JORDAN_OFFICIAL_NAME = "Hashemite Kingdom of Jordan";
    private const string JORDAN_ISO2_CODE = "JO";
    private const string JORDAN_ISO3_CODE = "JOR";
    private const int JORDAN_NUMERIC_CODE = 400;
    private readonly string[] JORDAN_CALLING_CODE = ["+962"];
    private const int JORDAN_STATE_COUNT = 12;
    private static readonly string[] VALID_STATE_TYPES = { "governorate" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJordan()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Jordan;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(JORDAN_COUNTRY_NAME, country.Name);
        Assert.Equal(JORDAN_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(JORDAN_NATIVE_NAME, country.NativeName);
        Assert.Equal(JORDAN_CAPITAL, country.Capital);
        Assert.Equal(JORDAN_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(JORDAN_ISO2_CODE, country.ISO2Code);
        Assert.Equal(JORDAN_ISO3_CODE, country.ISO3Code);
        Assert.Equal(JORDAN_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(JORDAN_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
