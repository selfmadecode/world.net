namespace World.Net.UnitTests.Countries;

public sealed class ColombiaTest
{
    private const string COLOMBIA_COUNTRY_NAME = "Colombia";
    private const string COLOMBIA_NATIVE_NAME = "Colombia";
    private const string COLOMBIA_CAPITAL = "Bogotá";
    private const string COLOMBIA_OFFICIAL_NAME = "Republic of Colombia";
    private const string COLOMBIA_ISO2_CODE = "CO";
    private const string COLOMBIA_ISO3_CODE = "COL";
    private const int COLOMBIA_NUMERIC_CODE = 170;
    private const string COLOMBIA_CALLING_CODE = "+57";
    private const int COLOMBIA_STATE_COUNT = 32;
    private static readonly string[] VALID_STATE_TYPES = { "Department", "Capital District" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForColombia()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Colombia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(COLOMBIA_COUNTRY_NAME, country.Name);
        Assert.Equal(COLOMBIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(COLOMBIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(COLOMBIA_CAPITAL, country.Capital);
        Assert.Equal(COLOMBIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(COLOMBIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(COLOMBIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(COLOMBIA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(COLOMBIA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
