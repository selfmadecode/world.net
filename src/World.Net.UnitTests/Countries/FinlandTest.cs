namespace World.Net.UnitTests.Countries;

public sealed class FinlandTest
{
    private const string FINLAND_COUNTRY_NAME = "Finland";
    private const string FINLAND_NATIVE_NAME = "Suomen tasavalta / Republiken Finland";
    private const string FINLAND_CAPITAL = "Helsinki";
    private const string FINLAND_OFFICIAL_NAME = "Republic of Finland";
    private const string FINLAND_ISO2_CODE = "FI";
    private const string FINLAND_ISO3_CODE = "FIN";
    private const int FINLAND_NUMERIC_CODE = 246;
    private readonly string[] FINLAND_CALLING_CODE = ["+358"];
    private const int FINLAND_STATE_COUNT = 21;
    private static readonly string[] VALID_STATE_TYPES = { "Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFinland()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Finland;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(FINLAND_COUNTRY_NAME, country.Name);
        Assert.Equal(FINLAND_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(FINLAND_NATIVE_NAME, country.NativeName);
        Assert.Equal(FINLAND_CAPITAL, country.Capital);
        Assert.Equal(FINLAND_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(FINLAND_ISO2_CODE, country.ISO2Code);
        Assert.Equal(FINLAND_ISO3_CODE, country.ISO3Code);
        Assert.Equal(FINLAND_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(FINLAND_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}

