namespace World.Net.UnitTests.Countries;

public sealed class DominicanRepublicTest
{
    private const string DOMINICANREPUBLIC_COUNTRY_NAME = "Dominican Republic";
    private const string DOMINICANREPUBLIC_NATIVE_NAME = "República Dominicana";
    private const string DOMINICANREPUBLIC_CAPITAL = "Santo Domingo";
    private const string DOMINICANREPUBLIC_OFFICIAL_NAME = "Dominican Republic";
    private const string DOMINICANREPUBLIC_ISO2_CODE = "DO";
    private const string DOMINICANREPUBLIC_ISO3_CODE = "DOM";
    private const int DOMINICANREPUBLIC_NUMERIC_CODE = 214;
    private const string DOMINICANREPUBLIC_CALLING_CODE = "+1-809, +1-829, +1-849";
    private const int DOMINICANREPUBLIC_STATE_COUNT = 32; // 31 provinces + 1 National District
    private static readonly string[] VALID_STATE_TYPES = { "Province", "National District" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForDominicanRepublic()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.DominicanRepublic;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(DOMINICANREPUBLIC_COUNTRY_NAME, country.Name);
        Assert.Equal(DOMINICANREPUBLIC_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(DOMINICANREPUBLIC_NATIVE_NAME, country.NativeName);
        Assert.Equal(DOMINICANREPUBLIC_CAPITAL, country.Capital);
        Assert.Equal(DOMINICANREPUBLIC_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(DOMINICANREPUBLIC_ISO2_CODE, country.ISO2Code);
        Assert.Equal(DOMINICANREPUBLIC_ISO3_CODE, country.ISO3Code);
        Assert.Equal(DOMINICANREPUBLIC_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(DOMINICANREPUBLIC_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
