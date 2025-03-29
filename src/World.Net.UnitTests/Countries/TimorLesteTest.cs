namespace World.Net.UnitTests.Countries;

public sealed class TimorLesteTest
{
    private const string TIMORLESTE_COUNTRY_NAME = "Timor-Leste";
    private const string TIMORLESTE_NATIVE_NAME = "Repúblika Demokrátika Timór-Leste";
    private const string TIMORLESTE_CAPITAL = "Dili";
    private const string TIMORLESTE_OFFICIAL_NAME = "Democratic Republic of Timor-Leste";
    private const string TIMORLESTE_ISO2_CODE = "TL";
    private const string TIMORLESTE_ISO3_CODE = "TLS";
    private const int TIMORLESTE_NUMERIC_CODE = 626;
    private const string TIMORLESTE_CALLING_CODE = "+670";
    private const int TIMORLESTE_STATE_COUNT = 13; // 12 municipalities + 1 special administrative region
    private static readonly string[] VALID_STATE_TYPES = { "Municipality", "Special Administrative Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTimorLeste()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.TimorLeste;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(TIMORLESTE_COUNTRY_NAME, country.Name);
        Assert.Equal(TIMORLESTE_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(TIMORLESTE_NATIVE_NAME, country.NativeName);
        Assert.Equal(TIMORLESTE_CAPITAL, country.Capital);
        Assert.Equal(TIMORLESTE_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(TIMORLESTE_ISO2_CODE, country.ISO2Code);
        Assert.Equal(TIMORLESTE_ISO3_CODE, country.ISO3Code);
        Assert.Equal(TIMORLESTE_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(TIMORLESTE_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
