namespace World.Net.UnitTests.Countries;
public sealed class JamaicaTest
{
    private const string JAMAICA_COUNTRY_NAME = "Jamaica";
    private const string JAMAICA_NATIVE_NAME = "Jamaica";
    private const string JAMAICA_CAPITAL = "Kingston";
    private const string JAMAICA_OFFICIAL_NAME = "Jamaica";
    private const string JAMAICA_ISO2_CODE = "JM";
    private const string JAMAICA_ISO3_CODE = "JAM";
    private const int JAMAICA_NUMERIC_CODE = 388;
    private readonly string[] JAMAICA_CALLING_CODE = ["+1-876"];
    private const int JAMAICA_STATE_COUNT = 14;
    private static readonly string[] VALID_STATE_TYPES = { "Parish" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJamaica()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Jamaica;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(JAMAICA_COUNTRY_NAME, country.Name);
        Assert.Equal(JAMAICA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(JAMAICA_NATIVE_NAME, country.NativeName);
        Assert.Equal(JAMAICA_CAPITAL, country.Capital);
        Assert.Equal(JAMAICA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(JAMAICA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(JAMAICA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(JAMAICA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(JAMAICA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
