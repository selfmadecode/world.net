namespace World.Net.UnitTests.Countries;

public sealed class EgyptTest
{
    private const string EGYPT_COUNTRY_NAME = "Egypt";
    private const string EGYPT_NATIVE_NAME = "جمهورية مصر العربية";
    private const string EGYPT_CAPITAL = "Cairo";
    private const string EGYPT_OFFICIAL_NAME = "Arab Republic of Egypt";
    private const string EGYPT_ISO2_CODE = "EG";
    private const string EGYPT_ISO3_CODE = "EGY";
    private const int EGYPT_NUMERIC_CODE = 818;
    private readonly string[] EGYPT_CALLING_CODE = ["+20"];
    private const int EGYPT_STATE_COUNT = 27; // 27 Governorates
    private static readonly string[] VALID_STATE_TYPES = { "Governorate" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForEgypt()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Egypt;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(EGYPT_COUNTRY_NAME, country.Name);
        Assert.Equal(EGYPT_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(EGYPT_NATIVE_NAME, country.NativeName);
        Assert.Equal(EGYPT_CAPITAL, country.Capital);
        Assert.Equal(EGYPT_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(EGYPT_ISO2_CODE, country.ISO2Code);
        Assert.Equal(EGYPT_ISO3_CODE, country.ISO3Code);
        Assert.Equal(EGYPT_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(EGYPT_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
