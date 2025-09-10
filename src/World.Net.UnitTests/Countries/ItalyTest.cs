namespace World.Net.UnitTests.Countries;
public sealed class ItalyTest
{
    private const string ITALY_COUNTRY_NAME = "Italy";
    private const string ITALY_NATIVE_NAME = "Italia";
    private const string ITALY_CAPITAL = "Rome";
    private const string ITALY_OFFICIAL_NAME = "Italian Republic";
    private const string ITALY_ISO2_CODE = "IT";
    private const string ITALY_ISO3_CODE = "ITA";
    private const int ITALY_NUMERIC_CODE = 380;
    private readonly string[] ITALY_CALLING_CODE = ["+39"];
    private const int ITALY_STATE_COUNT = 111;
    private static readonly string[] VALID_STATE_TYPES = { "Decentralized Regional Entity", "Metropolitan City", "Autonomous Region", "Free Municipal Consortium", "Province", "Region", };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForItaly()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Italy;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ITALY_COUNTRY_NAME, country.Name);
        Assert.Equal(ITALY_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ITALY_NATIVE_NAME, country.NativeName);
        Assert.Equal(ITALY_CAPITAL, country.Capital);
        Assert.Equal(ITALY_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ITALY_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ITALY_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ITALY_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(ITALY_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
