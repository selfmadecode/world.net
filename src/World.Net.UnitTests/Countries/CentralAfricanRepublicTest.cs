namespace World.Net.UnitTests.Countries;

public sealed class CentralAfricanRepublicTest
{
    private const string CAR_COUNTRY_NAME = "Central African Republic";
    private const string CAR_NATIVE_NAME = "Ködörösêse tî Bêafrîka";
    private const string CAR_CAPITAL = "Bangui";
    private const string CAR_OFFICIAL_NAME = "Central African Republic";
    private const string CAR_ISO2_CODE = "CF";
    private const string CAR_ISO3_CODE = "CAF";
    private const int CAR_NUMERIC_CODE = 140;
    private readonly string[] CAR_CALLING_CODE = ["+236"];
    private const int CAR_STATE_COUNT = 14;
    private static readonly string[] VALID_STATE_TYPES = { "Prefecture", "Capital District" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForCentralAfricanRepublic()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.CentralAfricanRepublic;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CAR_COUNTRY_NAME, country.Name);
        Assert.Equal(CAR_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CAR_NATIVE_NAME, country.NativeName);
        Assert.Equal(CAR_CAPITAL, country.Capital);
        Assert.Equal(CAR_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CAR_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CAR_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CAR_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CAR_STATE_COUNT, country.States.Count());

        // Assert that each state has a valid type
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}