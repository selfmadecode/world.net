namespace World.Net.UnitTests.Countries;

public sealed class BarbadosTest
{
    private const string BARBADOS_NAME = "Barbados";
    private const string BARBADOS_OFFICIAL_NAME = "Barbados";
    private const string BARBADOS_NATIVE_NAME = "Barbados";
    private const string BARBADOS_CAPITAL = "Bridgetown";
    private const int BARBADOS_NUMERIC_CODE = 052;
    private const string BARBADOS_ISO2_CODE = "BB";
    private const string BARBADOS_ISO3_CODE = "BRB";
    private readonly string[] BARBADOS_CALLING_CODE = ["+1-246"];
    private const int BARBADOS_PARISH_COUNT = 11;
    private const string BARBADOS_STATE_TYPE = "Parish";
    
    [Fact]
    public void Barbados_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Barbados;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BARBADOS_NAME, country.Name);
        Assert.Equal(BARBADOS_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BARBADOS_NATIVE_NAME, country.NativeName);
        Assert.Equal(BARBADOS_CAPITAL, country.Capital);
        Assert.Equal(BARBADOS_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BARBADOS_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BARBADOS_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BARBADOS_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(BARBADOS_PARISH_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BARBADOS_STATE_TYPE, state.Type));
    }
}
