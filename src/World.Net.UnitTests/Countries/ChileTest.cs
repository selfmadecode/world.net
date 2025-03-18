namespace World.Net.UnitTests.Countries;

public sealed class ChileTest
{
    private const string CHILE_COUNTRY_NAME = "Chile";
    private const string CHILE_NATIVE_NAME = "República de Chile";
    private const string CHILE_CAPITAL = "Santiago";
    private const string CHILE_OFFICIAL_NAME = "Republic of Chile";
    private const string CHILE_ISO2_CODE = "CL";
    private const string CHILE_ISO3_CODE = "CHL";
    private const int CHILE_NUMERIC_CODE = 152;
    private const string CHILE_CALLING_CODE = "+56";
    private const int CHILE_STATE_COUNT = 16;
    private static readonly string[] VALID_STATE_TYPES = { "Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForChile()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Chile;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CHILE_COUNTRY_NAME, country.Name);
        Assert.Equal(CHILE_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CHILE_NATIVE_NAME, country.NativeName);
        Assert.Equal(CHILE_CAPITAL, country.Capital);
        Assert.Equal(CHILE_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CHILE_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CHILE_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CHILE_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CHILE_STATE_COUNT, country.States.Count());

        // Assert that each state has a valid type
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
