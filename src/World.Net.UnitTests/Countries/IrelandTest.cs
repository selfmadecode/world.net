namespace World.Net.UnitTests.Countries;
public sealed class IrelandTest
{
    private const string IRELAND_COUNTRY_NAME = "Ireland";
    private const string IRELAND_NATIVE_NAME = "Éire";
    private const string IRELAND_CAPITAL = "Dublin";
    private const string IRELAND_OFFICIAL_NAME = "Republic of Ireland";
    private const string IRELAND_ISO2_CODE = "IE";
    private const string IRELAND_ISO3_CODE = "IRL";
    private const int IRELAND_NUMERIC_CODE = 372;
    private readonly string[] IRELAND_CALLING_CODE = ["+353"];
    private const int IRELAND_STATE_COUNT = 30;
    private static readonly string[] VALID_STATE_TYPES = { "County", "Province" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIreland()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Ireland;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(IRELAND_COUNTRY_NAME, country.Name);
        Assert.Equal(IRELAND_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(IRELAND_NATIVE_NAME, country.NativeName);
        Assert.Equal(IRELAND_CAPITAL, country.Capital);
        Assert.Equal(IRELAND_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(IRELAND_ISO2_CODE, country.ISO2Code);
        Assert.Equal(IRELAND_ISO3_CODE, country.ISO3Code);
        Assert.Equal(IRELAND_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(IRELAND_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
