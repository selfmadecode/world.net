namespace World.Net.UnitTests.Countries;

public sealed class CanadaTest
{
    private const string CANADA_COUNTRY_NAME = "Canada";
    private const string CANADA_NATIVE_NAME = "Canada";
    private const string CANADA_CAPITAL = "Ottawa";
    private const string CANADA_OFFICIAL_NAME = "Canada";
    private const string CANADA_ISO2_CODE = "CA";
    private const string CANADA_ISO3_CODE = "CAN";
    private const int CANADA_NUMERIC_CODE = 124;
    private const string CANADA_CALLING_CODE = "+1";
    private const int CANADA_STATE_COUNT = 13;
    private static readonly string[] VALID_STATE_TYPES = { "Province", "Territory" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCanada()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Canada;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CANADA_COUNTRY_NAME, country.Name);
        Assert.Equal(CANADA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CANADA_NATIVE_NAME, country.NativeName);
        Assert.Equal(CANADA_CAPITAL, country.Capital);
        Assert.Equal(CANADA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CANADA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CANADA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CANADA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CANADA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
