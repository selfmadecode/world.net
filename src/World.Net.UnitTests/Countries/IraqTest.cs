namespace World.Net.UnitTests.Countries;
public sealed class IraqTest
{
    private const string IRAQ_COUNTRY_NAME = "Iraq";
    private const string IRAQ_NATIVE_NAME = "العراق";
    private const string IRAQ_CAPITAL = "Baghdad";
    private const string IRAQ_OFFICIAL_NAME = "Republic of Iraq";
    private const string IRAQ_ISO2_CODE = "IQ";
    private const string IRAQ_ISO3_CODE = "IRQ";
    private const int IRAQ_NUMERIC_CODE = 368;
    private readonly string[] IRAQ_CALLING_CODE = ["+964"];
    private const int IRAQ_STATE_COUNT = 18;
    private static readonly string[] VALID_STATE_TYPES = { "Governorate" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIraq()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Iraq;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(IRAQ_COUNTRY_NAME, country.Name);
        Assert.Equal(IRAQ_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(IRAQ_NATIVE_NAME, country.NativeName);
        Assert.Equal(IRAQ_CAPITAL, country.Capital);
        Assert.Equal(IRAQ_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(IRAQ_ISO2_CODE, country.ISO2Code);
        Assert.Equal(IRAQ_ISO3_CODE, country.ISO3Code);
        Assert.Equal(IRAQ_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(IRAQ_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}

