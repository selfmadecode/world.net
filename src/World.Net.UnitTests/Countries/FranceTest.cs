namespace World.Net.UnitTests.Countries;
public sealed class FranceTest
{
    private const string FRANCE_NAME = "France";
    private const int FRANCE_STATE_COUNT = 116;
    private const string FRANCE_OFFICIAL_NAME = "French Republic";
    private const string FRANCE_NATIVE_NAME = "France";
    private const string FRANCE_CAPITAL = "Paris";
    private const int FRANCE_NUMERIC_CODE = 250;
    private const string FRANCE_ISO2_CODE = "FR";
    private static readonly string[] VALID_STATE_TYPES = { "metropolitan department", "European collectivity", "metropolitan region", "dependency", "metropolitan collectivity with special status", "overseas region", "overseas collectivity", "overseas territory", "overseas region", "metropolitan department", "metropolitan department", };
    private const string FRANCE_ISO3_CODE = "FRA";
    private readonly string[] FRANCE_CALLING_CODE = ["+33"];


    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFrance()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.France;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(FRANCE_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(FRANCE_STATE_COUNT, country.States.Count());
        Assert.Equal(FRANCE_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(FRANCE_NATIVE_NAME, country.NativeName);
        Assert.Equal(FRANCE_CAPITAL, country.Capital);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
        Assert.Equal(FRANCE_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(FRANCE_ISO2_CODE, country.ISO2Code);
        Assert.Equal(FRANCE_ISO3_CODE, country.ISO3Code);
        Assert.Equal(FRANCE_CALLING_CODE, country.CallingCode);
    }
}
