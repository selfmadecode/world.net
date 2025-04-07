namespace World.Net.UnitTests.Countries;

public sealed class ComorosTest
{
    private const string COMOROS_COUNTRY_NAME = "Comoros";
    private const string COMOROS_NATIVE_NAME = "Komori";
    private const string COMOROS_CAPITAL = "Moroni";
    private const string COMOROS_OFFICIAL_NAME = "Union of the Comoros";
    private const string COMOROS_ISO2_CODE = "KM";
    private const string COMOROS_ISO3_CODE = "COM";
    private const int COMOROS_NUMERIC_CODE = 174;
    private readonly string[] COMOROS_CALLING_CODE = ["+269"];
    private const int COMOROS_STATE_COUNT = 3;
    private static readonly string[] VALID_STATE_TYPES = { "Autonomous Island" };
    
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForComoros()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Comoros;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(COMOROS_COUNTRY_NAME, country.Name);
        Assert.Equal(COMOROS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(COMOROS_NATIVE_NAME, country.NativeName);
        Assert.Equal(COMOROS_CAPITAL, country.Capital);
        Assert.Equal(COMOROS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(COMOROS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(COMOROS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(COMOROS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(COMOROS_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
